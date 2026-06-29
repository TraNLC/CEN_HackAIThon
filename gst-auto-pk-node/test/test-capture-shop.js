const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const fs = require('fs');
const path = require('path');

async function run() {
    console.log('Connecting to device...');
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    console.log('Connected successfully!\n');

    console.log('Loading bot.bundle.js...');
    const scriptPath = path.join(__dirname, '../frida-scripts/bot.bundle.js');
    
    let isReady = false;
    let gameFd = -1;

    frida.onMessage(m => {
        if (m && m.type === 'log') {
            console.log(m.msg);
        } else if (m && m.type === 'bot_ready') {
            isReady = true;
        } else if (m && m.type === 'game_fd') {
            gameFd = m.fd;
            console.log(`[+] Auto-detected game socket FD: ${gameFd} (${m.detectedBy})`);
        } else if (m && (m.type === 'send_out' || m.type === 'shop_data')) {
            console.log(`[LIVE PACKET] ${m.type} | Opcode: ${m.opcode} | ${m.name || ''}`);
        } else {
            console.log(`[EVENT] ${m.type}`);
        }
    });

    let s;
    try {
        s = await frida.loadScript(scriptPath);
        console.log('createScript success!');
    } catch (e) {
        console.error('createScript failed:', e);
        process.exit(1);
    }

    // Đợi script init xong
    while (!isReady) {
        await new Promise(r => setTimeout(r, 100));
    }
    console.log('Script loaded & hooks attached successfully!\n');

    console.log('Waiting up to 10s for game socket to be detected (game_fd)...');
    for (let i=0; i<100; i++) {
        if (gameFd !== -1) break;
        await new Promise(r => setTimeout(r, 100));
    }

    if (gameFd === -1) {
        console.log('Không nhận diện được gameFd, nhưng vẫn tiếp tục lấy packet...');
    } else {
        console.log('Đã có gameFd!');
    }

    console.log('\n=======================================');
    console.log('  STARTING PACKET CAPTURE');
    console.log('=======================================');
    console.log('Vui lòng MỞ MỘT SHOP trong game NGAY BÂY GIỜ!');
    console.log('Và cứ để shop mở, hoặc bấm qua lại vài món đồ.');
    console.log('Script sẽ tự động lấy dữ liệu packet sau 15 giây...');

    // Enable capture
    await s.exports.setCaptureAllSends(true);

    // Chờ user thao tác
    await new Promise(r => setTimeout(r, 15000));

    console.log('\n--- DIAGNOSTICS ---');
    const diag = await s.exports.getDiag();
    console.log(JSON.stringify(diag, null, 2));

    console.log('\n--- KẾT QUẢ GÓI TIN ĐÃ GỬI (SENT) ---');
    const sent = await s.exports.getSentPackets(100);
    if (sent && sent.packets && sent.packets.length > 0) {
        sent.packets.forEach((p, i) => {
            console.log(`[Sent #${i}] Opcode: ${p.opcode} | Name: ${p.name} | Hex: ${p.hex}`);
        });
    } else {
        console.log('Không có gói tin nào được gửi đi!');
    }

    console.log('\n--- KẾT QUẢ GÓI TIN ĐÃ NHẬN (RECV) ---');
    const recv = await s.exports.getRecvPackets(null, 100);
    if (recv && recv.packets && recv.packets.length > 0) {
        recv.packets.forEach((p, i) => {
            console.log(`[Recv #${i}] Opcode: ${p.opcode} | Name: ${p.name} | Hex: ${p.hex}`);
        });
    } else {
        console.log('Không có gói tin nào nhận được!');
    }

    console.log('\n=======================================');
    console.log('Hoàn thành! Bạn có thể copy log gửi lại cho mình.');
    frida.disconnect();
}

run().catch(e => {
    console.error(e);
    process.exit(1);
});
