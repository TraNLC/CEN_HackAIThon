import frida
import sys

def main():
    try:
        device = frida.get_usb_device()
        pid = 2548
        print(f"Using hardcoded PID: {pid}")
        
        print("Attaching with realm='emulated' using PID...")
        session = device.attach(pid, realm="emulated")
        print("Attached successfully!")
        
        script = session.create_script("console.log('Hello from emulated realm! Modules: ' + Process.enumerateModules().length);")
        script.load()
        
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    main()
