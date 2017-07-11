S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 4354
Date: 2016-11-02 07:39:04+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb34e8bfd, esi = 0xb34ebc14
ebp = 0xb0d3af58, esp = 0xb0d3ae9c
eax = 0xb34eb9dc, ebx = 0xb34eb9dc
ecx = 0x00000000, edx = 0xb0d3aed8
eip = 0xb6c7a668

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         3 KB
Cached:     184284 KB
VmPeak:     121336 KB
VmSize:     121336 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30520 KB
VmRSS:       27688 KB
VmData:      54604 KB
VmStk:         628 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 4354 TID = 4370
4354 4355 4364 4365 4368 4370 

Maps Information
b2a7a000 b2a81000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2a82000 b2a9a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2a9b000 b2aa2000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b1f000 b2b29000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b2f000 b2b3b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b3c000 b2b5d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b62000 b2b63000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b64000 b2b69000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b6a000 b2b6b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b6c000 b2b6e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b6f000 b2b71000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b72000 b2b7e000 r-xp /usr/lib/libdrm.so.2.4.0
b2b7f000 b2b82000 r-xp /usr/lib/libdri2.so.0.0.0
b2b83000 b2b8d000 r-xp /usr/lib/libtbm.so.1.0.0
b2b8e000 b2b8f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b90000 b2ba5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2ba6000 b2bb8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33ba000 b33eb000 r-xp /usr/lib/libidn.so.11.5.44
b33ec000 b340e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b340f000 b341f000 r-xp /usr/lib/libcares.so.2.1.0
b3420000 b3440000 r-xp /usr/lib/libnetwork.so.0.0.0
b3441000 b344a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b344b000 b34c2000 r-xp /usr/lib/libcurl.so.4.3.0
b34c4000 b34d8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34d9000 b34eb000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b35f3000 b35f9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35fa000 b373e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3754000 b3755000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3756000 b3757000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3758000 b375b000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b375c000 b375f000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3760000 b3799000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b419c000 b41a7000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a9000 b41b4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41b6000 b41cd000 r-xp /lib/libnsl-2.20-2014.11.so
b41d1000 b41d9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41db000 b41ff000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4200000 b4201000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4202000 b4205000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4206000 b420d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b420e000 b4218000 r-xp /usr/lib/libsensord-share.so
b4219000 b4235000 r-xp /usr/lib/libsensor.so.1.2.0
b4237000 b4240000 r-xp /usr/lib/libappcore-common.so.1.1
b4243000 b4245000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b425a000 b425c000 r-xp /usr/lib/libXau.so.6.0.0
b425d000 b427f000 r-xp /usr/lib/libxcb.so.1.1.0
b4281000 b428a000 r-xp /lib/libcrypt-2.20-2014.11.so
b42b3000 b42b5000 r-xp /usr/lib/libiri.so
b42b6000 b42dc000 r-xp /lib/libexpat.so.1.5.2
b42de000 b4349000 r-xp /usr/lib/libssl.so.1.0.0
b434f000 b435b000 r-xp /usr/lib/libethumb.so.1.13.0
b435c000 b4360000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4361000 b45b2000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b2d000 b5b3d000 r-xp /usr/lib/libXi.so.6.1.0
b5b3e000 b5b40000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b41000 b5b47000 r-xp /usr/lib/libXtst.so.6.1.0
b5b48000 b5b52000 r-xp /usr/lib/libXrender.so.1.3.0
b5b53000 b5b5c000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b5e000 b5b60000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b61000 b5b66000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b67000 b5b79000 r-xp /usr/lib/libXext.so.6.4.0
b5b7a000 b5b7c000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b7d000 b5b7f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b81000 b5cc3000 r-xp /usr/lib/libX11.so.6.3.0
b5cc7000 b5cd1000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cd2000 b5ce8000 r-xp /usr/lib/libudev.so.1.6.0
b5ceb000 b5cef000 r-xp /lib/libattr.so.1.1.0
b5cf0000 b5d1f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d21000 b5d27000 r-xp /usr/lib/libffi.so.6.0.2
b5d28000 b5d4b000 r-xp /lib/libz.so.1.2.8
b5d4c000 b5d4f000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d50000 b5eac000 r-xp /usr/lib/libxml2.so.2.9.2
b5eb2000 b5f99000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fa6000 b5fa9000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5faa000 b5fcc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fcd000 b5fe1000 r-xp /lib/libresolv-2.20-2014.11.so
b5fe5000 b6009000 r-xp /usr/lib/liblzma.so.5.0.3
b600a000 b600c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b600e000 b6018000 r-xp /usr/lib/libembryo.so.1.13.0
b6019000 b6042000 r-xp /usr/lib/libpng12.so.0.50.0
b6043000 b608c000 r-xp /usr/lib/libjpeg.so.8.0.2
b609d000 b60a4000 r-xp /lib/librt-2.20-2014.11.so
b60a6000 b60c5000 r-xp /usr/lib/libector.so.1.13.0
b60c8000 b60f5000 r-xp /usr/lib/liblua-5.1.so
b60f6000 b6186000 r-xp /usr/lib/libfreetype.so.6.11.3
b618a000 b61c8000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c9000 b61df000 r-xp /usr/lib/libfribidi.so.0.3.1
b61e0000 b6239000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b623c000 b6287000 r-xp /lib/libm-2.20-2014.11.so
b6289000 b629b000 r-xp /usr/lib/libeio.so.1.13.0
b629c000 b629f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62a0000 b62a6000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62a7000 b62ca000 r-xp /usr/lib/libefreet.so.1.13.0
b62cd000 b62f8000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f9000 b632d000 r-xp /usr/lib/libecore_con.so.1.13.0
b632f000 b6338000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6339000 b6342000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6343000 b6356000 r-xp /usr/lib/libeo.so.1.13.0
b6358000 b636b000 r-xp /usr/lib/libecore_input.so.1.13.0
b636c000 b6373000 r-xp /usr/lib/libecore_file.so.1.13.0
b6374000 b6397000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6398000 b63c4000 r-xp /usr/lib/libeet.so.1.13.0
b63cd000 b6438000 r-xp /usr/lib/libeina.so.1.13.0
b643b000 b6452000 r-xp /usr/lib/libefl.so.1.13.0
b6454000 b65bb000 r-xp /usr/lib/libicuuc.so.51.1
b65c9000 b67d5000 r-xp /usr/lib/libicui18n.so.51.1
b67dd000 b682c000 r-xp /usr/lib/libecore_x.so.1.13.0
b682e000 b6848000 r-xp /lib/libgcc_s-4.9.so.1
b684a000 b684e000 r-xp /lib/libcap.so.2.21
b684f000 b6895000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6896000 b689d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b689f000 b68f1000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68f3000 b6a7e000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a83000 b6b51000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b54000 b6b58000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b59000 b6b68000 r-xp /usr/lib/libvconf.so.0.2.45
b6b69000 b6b6c000 r-xp /usr/lib/libvasum.so.0.3.1
b6b6d000 b6b70000 r-xp /usr/lib/libttrace.so.1.1
b6b72000 b6b76000 r-xp /usr/lib/libiniparser.so.0
b6b77000 b6ba7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba8000 b6bb1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bb2000 b6bd7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd8000 b6be8000 r-xp /usr/lib/libunwind.so.8.0.1
b6bf2000 b6da0000 r-xp /lib/libc-2.20-2014.11.so
b6da8000 b6eeb000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6eed000 b6f45000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f46000 b6f7a000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f7d000 b7051000 r-xp /usr/lib/libedje.so.1.13.0
b7054000 b7080000 r-xp /usr/lib/libecore.so.1.13.0
b7091000 b72b7000 r-xp /usr/lib/libevas.so.1.13.0
b72df000 b72f7000 r-xp /lib/libpthread-2.20-2014.11.so
b72fb000 b7675000 r-xp /usr/lib/libelementary.so.1.13.0
b7695000 b7699000 r-xp /usr/lib/libsmack.so.1.0.0
b769a000 b76a3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a4000 b76a7000 r-xp /usr/lib/libdlog.so.0.0.0
b76a8000 b76ad000 r-xp /usr/lib/libbundle.so.0.1.22
b76ae000 b76b1000 r-xp /lib/libdl-2.20-2014.11.so
b76b3000 b76d8000 r-xp /usr/lib/libaul.so.0.1.0
b76db000 b76dd000 r-xp /usr/lib/libappsvc.so.0.1.0
b76de000 b76e3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76e4000 b76eb000 r-xp /usr/lib/libappcore-efl.so.1.1
b76ed000 b76f2000 r-xp /usr/lib/libsys-assert.so
b76f5000 b76f6000 r-xp [vdso]
b76f6000 b7718000 r-xp /lib/ld-2.20-2014.11.so
b771a000 b7722000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4354)
Call Stack Count: 6
 0: (0xb6c7a668) [/lib/libc.so.6] + 0x88668
 1: get_message + 0x109 (0xb34e0d79) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x7d79
 2: (0xb70703f1) [/usr/lib/libecore.so.1] + 0x1c3f1
 3: (0xb6409afb) [/usr/lib/libeina.so.1] + 0x3cafb
 4: (0xb72e515f) [/lib/libpthread.so.0] + 0x615f
 5: clone + 0x5e (0xb6cd93ee) [/lib/libc.so.6] + 0xe73ee
End of Call Stack

Package Information
Package Name: org.example.tichat
Package ID : org.example.tichat
Version: 1.0.0
Package Type: tpk
App Name: tichat
App ID: org.example.tichat
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
unt: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.650+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.650+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.660+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.660+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.670+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.670+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.680+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.680+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.690+0900 I/tichat  ( 4354): Sent count: 12, msg:
11-02 07:39:04.690+0900 I/tichat  ( 4354): read : 
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
11-02 07:39:04.750+0900 D/AUL_PAD ( 2987): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-02 07:39:04.750+0900 I/AUL_PAD ( 2987): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 4354 pgid = 4354
11-02 07:39:04.750+0900 I/AUL_PAD ( 2987): sigchild.h: __sigchild_action(142) > dead_pid(4354)
11-02 07:39:04.750+0900 E/EFL     ( 2687): eo<2687> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
11-02 07:39:04.750+0900 W/CRASH_MANAGER( 4371): worker.c: worker_job(1204) > 1104354746963147803994
