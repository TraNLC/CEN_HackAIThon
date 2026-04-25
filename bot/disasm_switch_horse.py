"""
disasm_switch_horse.py
Static ARM32 disassembly of SyncSwitchHorse to find the GS opcode ID.
Reads libil2cpp.so from disk - no game/emulator needed.

Usage:
    python bot\disasm_switch_horse.py
"""
import struct, sys
import capstone

LIB_PATH = 'data/libil2cpp.so'

# Offsets from Il2CppDumper dump.cs
SYNC_SWITCH_HORSE   = 0x704D08  # SyncSwitchHorse(bool)
SEND_GS_MSG_IDMSG   = 0x8FFC4C  # SendGSMessage(Id, IMessage)
SEND_GS_MSG_ID_ONLY = 0x8FFC90  # SendGSMessage(Id)

print(f"[*] Loading {LIB_PATH} ...")
with open(LIB_PATH, 'rb') as f:
    elf = f.read()
print(f"[*] Loaded {len(elf):,} bytes")

def u32(off):
    return struct.unpack_from('<I', elf, off)[0]

def disasm_arm32(file_offset, size=512):
    cs = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_ARM)
    cs.detail = True
    code = elf[file_offset : file_offset + size]
    return list(cs.disasm(code, file_offset))   # use file_offset as base addr

# ── Helper: resolve BL target ──────────────────────────────────────────────
def bl_target(insn):
    """Return absolute target of BL/BLX (ARM32 encoding) or None."""
    for op in insn.operands:
        if op.type == capstone.arm.ARM_OP_IMM:
            return op.imm
    return None

# ── Disassemble SyncSwitchHorse ────────────────────────────────────────────
print(f"\n{'='*60}")
print(f"SyncSwitchHorse @ file offset 0x{SYNC_SWITCH_HORSE:08X}")
print(f"{'='*60}")

insns = disasm_arm32(SYNC_SWITCH_HORSE, size=600)

# Simulate registers for constant tracking
regs = {}

for insn in insns:
    addr = insn.address
    mnem = insn.mnemonic.lower()
    ops  = insn.op_str

    print(f"  {addr:08X}  {mnem:<8s} {ops}")

    # ── Track MOV Rx, #imm ──────────────────────────────────────────────
    if mnem in ('mov', 'movw') and len(insn.operands) == 2:
        dst = insn.reg_name(insn.operands[0].reg)
        src = insn.operands[1]
        if src.type == capstone.arm.ARM_OP_IMM:
            regs[dst] = src.imm
            print(f"           ^-- r[{dst}] = {src.imm} (0x{src.imm:X})")

    # ── Track LDR Rx, [pc, #off] (literal pool) ─────────────────────────
    if mnem == 'ldr' and len(insn.operands) >= 2:
        dst = insn.reg_name(insn.operands[0].reg)
        src = insn.operands[1]
        if src.type == capstone.arm.ARM_OP_MEM:
            base_r = insn.reg_name(src.mem.base)
            disp   = src.mem.disp
            if base_r == 'pc':
                pool_addr = (addr + 8) + disp   # ARM: PC = insn+8
                if 0 < pool_addr < len(elf) - 4:
                    val = u32(pool_addr)
                    regs[dst] = val
                    print(f"           ^-- pool[0x{pool_addr:08X}] = 0x{val:08X} ({val})")

    # ── Track ADD Rx, pc, Ry ─────────────────────────────────────────────
    if mnem == 'add' and len(insn.operands) == 3:
        dst = insn.reg_name(insn.operands[0].reg)
        op1 = insn.operands[1]
        op2 = insn.operands[2]
        if insn.reg_name(op1.reg) == 'pc':
            pc_val = addr + 8
            rhs = regs.get(insn.reg_name(op2.reg), 0)
            regs[dst] = pc_val + rhs
            print(f"           ^-- r[{dst}] = PC+0x{rhs:X} = 0x{regs[dst]:08X}")

    # ── BL / BLX call ───────────────────────────────────────────────────
    if mnem in ('bl', 'blx'):
        target = bl_target(insn)
        if target is None:
            # indirect BLX Rx
            for op in insn.operands:
                if op.type == capstone.arm.ARM_OP_REG:
                    rn = insn.reg_name(op.reg)
                    target = regs.get(rn)
                    break

        target_str = f"0x{target:08X}" if target else "?"

        if target in (SEND_GS_MSG_IDMSG, SEND_GS_MSG_ID_ONLY):
            fn = "SendGSMessage(Id,IMessage)" if target == SEND_GS_MSG_IDMSG else "SendGSMessage(Id)"
            r1_val = regs.get('r1', regs.get('r0', '???'))
            r2_val = regs.get('r2', '???')
            print(f"\n  *** CALL → {fn} ***")
            print(f"  *** r1 (Id)       = {r1_val}  (0x{r1_val:X if isinstance(r1_val,int) else 'r1_val'})")
            print(f"  *** r2 (IMessage) = {r2_val}")
            print()
        else:
            print(f"           --> BL {target_str}")

    # ── Function return ──────────────────────────────────────────────────
    if mnem == 'pop' and 'pc' in ops:
        print("  --- RETURN ---")
        break
    if mnem == 'bx' and ops.strip() == 'lr':
        print("  --- RETURN (bx lr) ---")
        break

print("\n[*] Done. Look for '*** CALL → SendGSMessage' lines above.")
print("[*] r1 value = the GS opcode ID used for mount/dismount.")
