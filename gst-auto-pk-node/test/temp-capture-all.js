
        function toHex(arr) {
            var n = Math.min(arr.length, 128);
            var result = '';
            for (var i = 0; i < n; i++) {
                result += ('0' + arr[i].toString(16)).slice(-2) + ' ';
            }
            return result.trim();
        }

        function checkAndSend(funcName, fd, n, data) {
            try {
                // Bỏ qua noise
                if ((fd === 67 || fd === 81) && n === 8) return;
                if (fd === 56 && n === 795) return;
                if ((fd === 71 || fd === 85) && n === 64) return;
                
                // Lọc heartbeat packet 104 byte trên FD 78
                if (fd === 78) {
                    if (n === 104) return; 
                    // Kiểm tra xem packet lớn có phải cấu tạo hoàn toàn từ heartbeat ko
                    if (n > 104 && n % 104 === 0) {
                        var isAllHb = true;
                        for (var i = 0; i < n; i += 104) {
                            if (data[i] !== 0x68 || data[i+1] !== 0x00) {
                                isAllHb = false;
                                break;
                            }
                        }
                        if (isAllHb) return;
                    }
                }
                
                // Nếu FD 95 hoặc 97 bắt đầu bằng SPR hoặc fb 53 50 52 (Resource file) thì bỏ qua
                if ((fd === 95 || fd === 97) && data.length >= 4) {
                    if (data[0] === 0x53 && data[1] === 0x50 && data[2] === 0x52) return; // 'S' 'P' 'R'
                    if (data[1] === 0x53 && data[2] === 0x50 && data[3] === 0x52) return;
                }
                
                send({ type: 'data', func: funcName, fd: fd, len: n, hex: toHex(data) });
            } catch(e) {}
        }

        var libc = Process.findModuleByName('libc.so');

        // Bắt các hàm IO thông thường
        var funcs = ['read', 'write', 'recv', 'send', 'recvfrom', 'sendto'];
        funcs.forEach(function(name) {
            var addr = libc.findExportByName(name);
            if (addr) {
                Interceptor.attach(addr, {
                    onEnter: function(args) {
                        this.fd = args[0].toInt32();
                        this.buf = args[1];
                        this.funcName = name;
                    },
                    onLeave: function(retval) {
                        var n = retval.toInt32();
                        if (n <= 0) return;
                        var data = new Uint8Array(this.buf.readByteArray(n));
                        checkAndSend(this.funcName, this.fd, n, data);
                    }
                });
            }
        });

        // Bắt writev (nhiều game dùng scatter/gather để gửi)
        var writevAddr = libc.findExportByName('writev');
        if (writevAddr) {
            Interceptor.attach(writevAddr, {
                onEnter: function(args) {
                    this.fd = args[0].toInt32();
                    this.iov = args[1];
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0) return;
                    try {
                        var ptrSize = Process.pointerSize;
                        var iov_base = this.iov.readPointer();
                        var data = new Uint8Array(iov_base.readByteArray(n));
                        checkAndSend('writev', this.fd, n, data);
                    } catch(e) {}
                }
            });
        }

        // Bắt recvmsg
        var recvmsgAddr = libc.findExportByName('recvmsg');
        if (recvmsgAddr) {
            Interceptor.attach(recvmsgAddr, {
                onEnter: function(args) {
                    this.fd = args[0].toInt32();
                    this.msg = args[1];
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0) return;
                    try {
                        var ptrSize = Process.pointerSize;
                        var iovPtr = this.msg.add(ptrSize === 8 ? 16 : 8).readPointer();
                        var iov_base = iovPtr.readPointer();
                        var data = new Uint8Array(iov_base.readByteArray(n));
                        checkAndSend('recvmsg', this.fd, n, data);
                    } catch(e) {}
                }
            });
        }
        
        // Bắt sendmsg
        var sendmsgAddr = libc.findExportByName('sendmsg');
        if (sendmsgAddr) {
            Interceptor.attach(sendmsgAddr, {
                onEnter: function(args) {
                    this.fd = args[0].toInt32();
                    this.msg = args[1];
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0) return;
                    try {
                        var ptrSize = Process.pointerSize;
                        var iovPtr = this.msg.add(ptrSize === 8 ? 16 : 8).readPointer();
                        var iov_base = iovPtr.readPointer();
                        var data = new Uint8Array(iov_base.readByteArray(n));
                        checkAndSend('sendmsg', this.fd, n, data);
                    } catch(e) {}
                }
            });
        }
        
        send({ type: 'ready' });
    