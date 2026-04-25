package com.vltk.hook;

import android.util.Log;
import de.robv.android.xposed.IXposedHookLoadPackage;
import de.robv.android.xposed.XC_MethodHook;
import de.robv.android.xposed.XposedBridge;
import de.robv.android.xposed.XposedHelpers;
import de.robv.android.xposed.callbacks.XC_LoadPackage;

import java.io.FileOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * Xposed module — hook VLTK1 network layer
 *
 * Cài đặt:
 *   1. Cài LSPosed (Magisk module) vào LDPlayer
 *   2. Build APK này, cài vào emulator
 *   3. Bật module trong LSPosed app → chọn target: VLTK1 package
 *   4. Restart emulator
 *   5. Chơi game → log tự ghi vào /sdcard/vltk_packets.log
 *
 * Không cần PC attach, không có frida-server process.
 * Module tự chạy mỗi khi game khởi động.
 *
 * SAU KHI tìm được class name từ jadx:
 *   Thay "TODO_CLASS_NAME" và "TODO_METHOD" bằng tên thật
 */
public class PacketHook implements IXposedHookLoadPackage {

    private static final String TAG = "VLTKHook";
    // Thay bằng package name thật của game
    private static final String TARGET_PACKAGE = "vn.vinagame.vltk1";
    private static final String LOG_PATH = "/sdcard/vltk_packets.log";

    @Override
    public void handleLoadPackage(XC_LoadPackage.LoadPackageParam lpparam) {
        if (!lpparam.packageName.equals(TARGET_PACKAGE)) return;

        XposedBridge.log("[VLTKHook] Loaded into " + TARGET_PACKAGE);
        log("=== VLTKHook started " + now() + " ===\n");

        hookJavaIO(lpparam.classLoader);
        hookNetworkClass(lpparam.classLoader);
    }

    // ----------------------------------------------------------
    // Hook 1: Java IO layer — catch-all, không cần class name cụ thể
    // Bắt mọi byte[] write ra DataOutputStream (thường là socket write)
    // ----------------------------------------------------------
    private void hookJavaIO(ClassLoader cl) {
        try {
            XposedHelpers.findAndHookMethod(
                "java.io.DataOutputStream", cl,
                "write", byte[].class, int.class, int.class,
                new XC_MethodHook() {
                    @Override
                    protected void beforeHookedMethod(MethodHookParam param) {
                        byte[] data = (byte[]) param.args[0];
                        int off = (int) param.args[1];
                        int len = (int) param.args[2];
                        if (len > 4 && len < 4096) {
                            byte[] slice = copySlice(data, off, len);
                            log("SEND [" + len + "]\n" + hexdump(slice) + "\n");
                        }
                    }
                }
            );
            XposedBridge.log("[VLTKHook] DataOutputStream hooked");
        } catch (Exception e) {
            XposedBridge.log("[VLTKHook] DataOutputStream hook failed: " + e.getMessage());
        }

        try {
            XposedHelpers.findAndHookMethod(
                "java.io.DataInputStream", cl,
                "read", byte[].class,
                new XC_MethodHook() {
                    @Override
                    protected void afterHookedMethod(MethodHookParam param) {
                        int result = (int) param.getResult();
                        if (result > 4) {
                            byte[] data = (byte[]) param.args[0];
                            byte[] slice = copySlice(data, 0, result);
                            log("RECV [" + result + "]\n" + hexdump(slice) + "\n");
                        }
                    }
                }
            );
            XposedBridge.log("[VLTKHook] DataInputStream hooked");
        } catch (Exception e) {
            XposedBridge.log("[VLTKHook] DataInputStream hook failed: " + e.getMessage());
        }
    }

    // ----------------------------------------------------------
    // Hook 2: Game-specific network class
    // Điền class name thật sau khi dùng jadx-gui
    // ----------------------------------------------------------
    private void hookNetworkClass(ClassLoader cl) {
        // TODO: thay "com.vltk.net.NetworkManager" bằng class name thật
        String targetClass = "TODO_CLASS_NAME";
        String sendMethod  = "TODO_SEND_METHOD";   // vd: "sendPacket", "send", "write"
        String recvMethod  = "TODO_RECV_METHOD";   // vd: "onReceive", "decode", "read"

        if (targetClass.startsWith("TODO")) {
            XposedBridge.log("[VLTKHook] NetworkClass not configured yet — using IO fallback only");
            return;
        }

        try {
            XposedHelpers.findAndHookMethod(
                targetClass, cl,
                sendMethod, byte[].class,
                new XC_MethodHook() {
                    @Override
                    protected void beforeHookedMethod(MethodHookParam param) {
                        byte[] data = (byte[]) param.args[0];
                        log("NET_SEND [" + data.length + "]\n" + hexdump(data) + "\n");
                    }
                }
            );

            XposedHelpers.findAndHookMethod(
                targetClass, cl,
                recvMethod, byte[].class,
                new XC_MethodHook() {
                    @Override
                    protected void afterHookedMethod(MethodHookParam param) {
                        byte[] data = (byte[]) param.args[0];
                        log("NET_RECV [" + data.length + "]\n" + hexdump(data) + "\n");
                    }
                }
            );

            XposedBridge.log("[VLTKHook] " + targetClass + " hooked");
        } catch (Exception e) {
            XposedBridge.log("[VLTKHook] NetworkClass hook failed: " + e.getMessage());
        }
    }

    // ----------------------------------------------------------
    // Helpers
    // ----------------------------------------------------------

    private static byte[] copySlice(byte[] src, int off, int len) {
        byte[] out = new byte[len];
        System.arraycopy(src, off, out, 0, len);
        return out;
    }

    private static String hexdump(byte[] data) {
        StringBuilder sb = new StringBuilder();
        int width = 16;
        for (int i = 0; i < data.length; i += width) {
            sb.append(String.format("%04x  ", i));
            int end = Math.min(i + width, data.length);
            for (int j = i; j < end; j++) {
                sb.append(String.format("%02x ", data[j] & 0xFF));
            }
            // Padding
            for (int j = end; j < i + width; j++) sb.append("   ");
            sb.append(" ");
            for (int j = i; j < end; j++) {
                char c = (char)(data[j] & 0xFF);
                sb.append(c >= 32 && c < 127 ? c : '.');
            }
            sb.append('\n');
        }
        return sb.toString();
    }

    private static String now() {
        return new SimpleDateFormat("HH:mm:ss.SSS").format(new Date());
    }

    private static synchronized void log(String msg) {
        try (FileOutputStream fos = new FileOutputStream(LOG_PATH, true)) {
            String line = "[" + now() + "] " + msg + "\n";
            fos.write(line.getBytes("UTF-8"));
        } catch (IOException e) {
            Log.e(TAG, "Log write failed: " + e.getMessage());
        }
        Log.d(TAG, msg);
    }
}
