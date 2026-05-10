import "frida-il2cpp-bridge";

function initBot() {
    console.log("Initializing IL2CPP Bridge...");

    // Khởi tạo IL2CPP
    Il2Cpp.perform(() => {
        console.log(`Unity Version: ${Il2Cpp.unityVersion}`);
        
        try {
            // Tìm Assembly chứa code game (thường là Assembly-CSharp)
            const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
            const image = assembly.image;
            
            console.log("Tìm Class game.ui.NpcDialogPc...");
            const NpcDialogPc = image.class("game.ui.NpcDialogPc");
            console.log(`Đã tìm thấy NpcDialogPc: ${NpcDialogPc.handle}`);

            // Tìm hàm Open (hàm để mở giao diện NPC)
            const openMethod = NpcDialogPc.method("Open");
            console.log(`Đã tìm thấy hàm Open(): ${openMethod.virtualAddress}`);

            // Nếu muốn gọi hàm Open(), chúng ta cần tìm một đối tượng (Instance)
            // của NpcDialogPc đang tồn tại trong RAM.
            // Để an toàn, chúng ta sẽ hook vào hàm Open() để xem khi nào nó được gọi
            // và lấy ra Instance đó.
            let dialogInstance: Il2Cpp.Object | null = null;

            openMethod.implementation = function () {
                // 'this' trong ngữ cảnh này chính là instance của NpcDialogPc
                console.log(`[+] Hàm Open() của NpcDialogPc vừa được game gọi! (Instance: ${this.handle})`);
                dialogInstance = this;
                
                // Vẫn gọi hàm gốc để game mở UI bình thường
                return this.method("Open").invoke();
            };
            
            console.log("Đã đặt Hook vào NpcDialogPc.Open() thành công!");
            
            // Expose RPC API để Python gọi vào
            rpc.exports = {
                remoteOpenDialog: function() {
                    if (dialogInstance) {
                        console.log("Đang gọi hàm Open() từ xa...");
                        // Phải chạy trong luồng chính của Unity (Main Thread)
                        Il2Cpp.scheduleOnMainThread(() => {
                            dialogInstance!.method("Open").invoke();
                            console.log("Đã gửi lệnh Open() thành công!");
                        });
                        return "SUCCESS";
                    } else {
                        return "ERROR: Chưa bắt được Instance của NpcDialogPc. Hãy click thủ công vào Dã Tẩu 1 lần để Tool bắt đối tượng!";
                    }
                }
            };

            console.log("Bot IL2CPP đã sẵn sàng!");
            
        } catch (e) {
            console.log("Lỗi IL2CPP: " + e);
        }
    });
}

initBot();
