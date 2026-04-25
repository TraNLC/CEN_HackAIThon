"""
disasm_il2cpp.py - Disassemble ARM functions from libil2cpp.so to find what
SyncSwitchHorse passes to SendGSMessage.
"""
import struct
import capstone

LIB_PATH = 'data/libil2cpp.so'

# Key addresses from script.json / dump.cs
SYNC_SWITCH_HORSE  = 0x704D08
SEND_GS_MSG_ID_MSG = 0x8FFC4C   # SendGSMessage(Id, IMessage)
SEND_GS_MSG_ID     = 0x8FFC90   # SendGSMessage(Id)

with open(LIB_PATH, 'rb') as f:
    elf = f.read()

def read_u32(offset):
    return struct.unpack_from('<I', elf, offset)[0]

def disasm_arm(addr, size=256):
    """Disassemble ARM32 code at given address."""
    cs = capstone.Cs(capstone.CS_ARCH_ARM, capstone.CS_MODE_ARM)
    cs.detail = True
    code = elf[addr:addr+size]
    return list(cs.disasm(code, addr))

def pool_val(insn_addr, offset):
    """Get literal pool value: PC = insn_addr+8, pool at PC+offset."""
    pool_addr = insn_addr + 8 + offset
    return read_u32(pool_addr), pool_addr

print("=" * 60)
print(f"Disassembling SyncSwitchHorse @ 0x{SYNC_SWITCH_HORSE:08X}")
print("=" * 60)

insns = disasm_arm(SYNC_SWITCH_HORSE, 512)

# Track register values (simplified constant folding)
regs = {}

for insn in insns:
    addr = insn.address
    mnem = insn.mnemonic
    ops  = insn.op_str

    print(f"  0x{addr:08X}  {mnem:8s} {ops}")

    # Track LDR Rn, [pc, #N]  (literal pool load)
    if mnem == 'ldr' and '[pc,' in ops:
        # parse register and offset
        try:
            parts = ops.split(',')
            reg = parts[0].strip()
            off_str = parts[-1].strip().rstrip(']').strip('#').strip()
            off = int(off_str, 0) if off_str else 0
            val, pool_a = pool_val(addr, off)
            regs[reg] = val
            print(f"           ^-- pool[0x{pool_a:08X}] = 0x{val:08X} ({val})")
        except:
            pass

    # Track MOV Rn, #imm
    if mnem == 'mov' and '#' in ops:
        try:
            parts = ops.split(',')
            reg = parts[0].strip()
            imm = int(parts[1].strip().strip('#'), 0)
            regs[reg] = imm
        except:
            pass

    # BL = function call, check what's in r1 (= Id argument)
    if mnem in ('bl', 'blx'):
        try:
            target_str = ops.strip()
            target = int(target_str, 0)
            if target in (SEND_GS_MSG_ID_MSG, SEND_GS_MSG_ID):
                print(f"\n  >>> CALL TO SendGSMessage!")
                print(f"  >>> r1 (Id) = {regs.get('r1', '?')} = 0x{regs.get('r1', 0):X}")
                print(f"  >>> r2 (IMessage type) = {regs.get('r2', '?')}")
                print()
            elif target == SYNC_SWITCH_HORSE:
                print(f"  >>> Recursive call to self")
            else:
                print(f"  >>> BL to 0x{target:08X}")
        except:
            pass

    # Stop after ret (POP with PC or BX lr)
    if 'pc' in ops and mnem in ('pop', 'ldm'):
        print("  --- function return ---")
        break
