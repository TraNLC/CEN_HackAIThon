"""
disasm_send_gs.py
Disassemble SendGSMessage(Id, IMessage) @ 0x8FFC4C to find TCP packet framing.
"""
import struct, capstone

LIB_PATH = 'data/libil2cpp.so'
SEND_GS_MSG = 0x8FFC4C  # SendGSMessage(Id, IMessage)

with open(LIB_PATH, 'rb') as f:
    elf = f.read()

def u32(off):
    return struct.unpack_from('<I', elf, off)[0]

def disasm_arm32(file_offset, size=600):
    cs = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_ARM)
    cs.detail = True
    return list(cs.disasm(elf[file_offset:file_offset+size], file_offset))

print(f"{'='*60}")
print(f"SendGSMessage(Id,IMessage) @ 0x{SEND_GS_MSG:08X}")
print(f"{'='*60}")

regs = {}
for insn in disasm_arm32(SEND_GS_MSG):
    addr, mnem, ops = insn.address, insn.mnemonic.lower(), insn.op_str
    print(f"  {addr:08X}  {mnem:<8s} {ops}")

    # Track LDR Rx, [pc, #off]
    if mnem == 'ldr' and len(insn.operands) >= 2:
        dst = insn.reg_name(insn.operands[0].reg)
        src = insn.operands[1]
        if src.type == capstone.arm.ARM_OP_MEM and insn.reg_name(src.mem.base) == 'pc':
            pool_addr = (addr + 8) + src.mem.disp
            if 0 < pool_addr < len(elf) - 4:
                val = u32(pool_addr)
                regs[dst] = val
                print(f"           ^-- pool[0x{pool_addr:08X}] = 0x{val:08X} ({val})")

    # Track MOV/MOVW
    if mnem in ('mov', 'movw') and len(insn.operands) == 2:
        dst = insn.reg_name(insn.operands[0].reg)
        op1 = insn.operands[1]
        if op1.type == capstone.arm.ARM_OP_IMM:
            regs[dst] = op1.imm
            print(f"           ^-- r[{dst}] = {op1.imm} (0x{op1.imm:X})")

    # Track STR/STRH patterns (how it writes the packet header)
    if mnem in ('str', 'strh', 'strb') and len(insn.operands) >= 2:
        src_r = insn.reg_name(insn.operands[0].reg)
        mem   = insn.operands[1]
        if mem.type == capstone.arm.ARM_OP_MEM:
            base_r = insn.reg_name(mem.mem.base)
            disp   = mem.mem.disp
            val    = regs.get(src_r, '?')
            print(f"           ^^WRITE {mnem} r[{src_r}]={val} → [{base_r}+0x{disp:X}]")

    # BL calls
    if mnem in ('bl', 'blx'):
        for op in insn.operands:
            if op.type == capstone.arm.ARM_OP_IMM:
                print(f"           --> BL 0x{op.imm:08X}")

    # Return
    if (mnem == 'pop' and 'pc' in ops) or (mnem == 'bx' and ops.strip() == 'lr'):
        print("  --- RETURN ---")
        break
