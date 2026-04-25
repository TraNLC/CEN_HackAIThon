"""
il2cpp_find_net.py — Deep search for game-specific networking classes
"""

import struct
from pathlib import Path

def read_cstr(data, offset):
    end = data.index(b'\x00', offset)
    return data[offset:end].decode('utf-8', errors='replace')

def find_network_classes(metadata_path):
    data = Path(metadata_path).read_bytes()
    
    magic = struct.unpack_from('<I', data, 0)[0]
    version = struct.unpack_from('<i', data, 4)[0]
    
    str_offset = struct.unpack_from('<i', data, 24)[0]
    str_size   = struct.unpack_from('<i', data, 28)[0]
    
    # Extract all identifiers
    identifiers = []
    pos = str_offset
    end = str_offset + str_size
    while pos < end:
        try:
            s = read_cstr(data, pos)
            if s:
                identifiers.append(s)
            pos += len(s.encode('utf-8', errors='replace')) + 1
        except (ValueError, IndexError):
            break
    
    # Game-specific keywords for VLTK / JX1 Mobile
    game_keywords = [
        # Network core
        'NetClient', 'NetManager', 'NetworkManager', 'SocketClient',
        'TcpClient', 'GameSocket', 'GameNet', 'NetWork',
        'SendMsg', 'SendPacket', 'SendData', 'SendMessage', 'SendBytes',
        'RecvMsg', 'RecvPacket', 'ReceiveData', 'OnMessage', 'OnReceive',
        'HandleMsg', 'HandlePacket', 'ProcessMsg', 'DispatchMsg',
        'PacketHandler', 'MsgHandler', 'MessageHandler',
        
        # Protobuf
        'ProtobufSerializer', 'ProtoSerializer', 'MessageParser',
        'WriteTo', 'MergeFrom', 'ParseFrom',
        
        # Game logic
        'LoginReq', 'LoginRes', 'LoginHandler',
        'QuestHandler', 'TaskHandler', 'NpcHandler',
        'MoveHandler', 'ChatHandler', 'BattleHandler',
        'PacketId', 'MsgId', 'CmdId', 'OpCode',
        
        # Chinese game common patterns
        'NetModule', 'NetProxy', 'NetService', 'NetHelper',
        'MsgDispatcher', 'ProtoManager', 'ProtocolManager',
        'GameManager', 'SceneManager',
        'C2S', 'S2C', 'Req', 'Rsp', 'Ack', 'Ntf', 'Notify',
    ]
    
    print("="*80)
    print("  GAME-SPECIFIC NETWORK CLASSES & METHODS")
    print("="*80)
    
    found = {}
    for s in identifiers:
        for kw in game_keywords:
            if kw.lower() in s.lower() and len(s) > 2 and len(s) < 200:
                if kw not in found:
                    found[kw] = []
                if s not in found[kw]:
                    found[kw].append(s)
                break
    
    for kw in sorted(found.keys()):
        items = found[kw]
        if len(items) > 0:
            print(f"\n--- [{kw}] ({len(items)} matches) ---")
            for item in sorted(items)[:30]:
                print(f"  {item}")
    
    # Search for patterns like "C2S_XXX" or "S2C_XXX" (Client to Server / Server to Client)
    print(f"\n{'='*80}")
    print("  C2S/S2C MESSAGE PATTERNS")
    print("="*80)
    
    c2s_msgs = [s for s in identifiers if 'C2S' in s or 'c2s' in s]
    s2c_msgs = [s for s in identifiers if 'S2C' in s or 's2c' in s]
    
    if c2s_msgs:
        print(f"\nClient-to-Server messages ({len(c2s_msgs)}):")
        for m in sorted(set(c2s_msgs))[:50]:
            print(f"  → {m}")
    
    if s2c_msgs:
        print(f"\nServer-to-Client messages ({len(s2c_msgs)}):")
        for m in sorted(set(s2c_msgs))[:50]:
            print(f"  ← {m}")
    
    # Look for Lua-related (game uses xlua)
    print(f"\n{'='*80}")
    print("  LUA SCRIPTING (xlua detected)")
    print("="*80)
    
    lua_items = [s for s in identifiers if 'lua' in s.lower() and 'net' in s.lower()]
    if lua_items:
        print(f"\nLua+Network related ({len(lua_items)}):")
        for item in sorted(set(lua_items))[:30]:
            print(f"  {item}")
    
    # Look for KCP (common in Chinese mobile games)
    print(f"\n{'='*80}")
    print("  KCP / CUSTOM PROTOCOL")
    print("="*80)
    
    kcp_items = [s for s in identifiers if 'kcp' in s.lower() or 'kcpclient' in s.lower()]
    if kcp_items:
        print(f"\nKCP related ({len(kcp_items)}):")
        for item in sorted(set(kcp_items))[:30]:
            print(f"  {item}")
    else:
        print("  No KCP found.")
    
    # COMPLETE network namespace scan
    print(f"\n{'='*80}")
    print("  ALL IDENTIFIERS CONTAINING 'Net' (case sensitive)")
    print("="*80)
    
    net_exact = [s for s in identifiers if s.startswith('Net') and len(s) < 60]
    for item in sorted(set(net_exact))[:80]:
        print(f"  {item}")

if __name__ == '__main__':
    meta_path = str(Path(__file__).parent.parent / 'data' / 'apk_extracted' / 'assets' / 'bin' / 'Data' / 'Managed' / 'Metadata' / 'global-metadata.dat')
    find_network_classes(meta_path)
