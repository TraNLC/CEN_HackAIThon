
        var res = [];
        for(var i=0; i<200; i++) {
            try {
                var type = Socket.type(i);
                if (type === 'tcp' || type === 'tcp6') {
                    var peer = Socket.peerAddress(i);
                    res.push({ fd: i, type: type, peer: peer });
                }
            } catch(e){}
        }
        send({ type: 'sockets', data: res });
    