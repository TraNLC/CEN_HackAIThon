import sys
from test_open_shop import parse_pcap_recv

def run():
    PCAP_LOC = r'e:\tool\sample-test\vltk1-re\data\output\shop_live.pcap'
    packets = parse_pcap_recv(PCAP_LOC, 45676)
    opcodes = {}
    for opcode, body in packets:
        opcodes[opcode] = opcodes.get(opcode, 0) + 1
        print(f"Opcode {opcode} - {len(body)} bytes")
    print(f"\nSummary: {opcodes}")

if __name__ == '__main__':
    run()
