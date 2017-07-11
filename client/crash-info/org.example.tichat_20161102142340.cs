S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 2906
Date: 2016-11-02 14:23:40+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb34f5d90, esi = 0xb0d3af40
ebp = 0xb0d3b0a8, esp = 0xb0d3af3c
eax = 0xb34f2df9, ebx = 0xb34f5acc
ecx = 0x00000072, edx = 0x00000000
eip = 0xb6d2dc0b

Memory Information
MemTotal:      123 KB
MemFree:        39 KB
Buffers:         7 KB
Cached:     150376 KB
VmPeak:     125036 KB
VmSize:     125036 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32468 KB
VmRSS:       32468 KB
VmData:      58796 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2906 TID = 3306
2906 3013 3298 3302 3306 

Maps Information
b2a84000 b2a8b000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2a8c000 b2aa4000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2aa5000 b2aac000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b29000 b2b33000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b39000 b2b45000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b46000 b2b67000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b6c000 b2b6d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b6e000 b2b73000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b74000 b2b75000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b76000 b2b78000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b79000 b2b7b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b7c000 b2b88000 r-xp /usr/lib/libdrm.so.2.4.0
b2b89000 b2b8c000 r-xp /usr/lib/libdri2.so.0.0.0
b2b8d000 b2b97000 r-xp /usr/lib/libtbm.so.1.0.0
b2b98000 b2b99000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b9a000 b2baf000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bb0000 b2bc2000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33c4000 b33f5000 r-xp /usr/lib/libidn.so.11.5.44
b33f6000 b3418000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3419000 b3429000 r-xp /usr/lib/libcares.so.2.1.0
b342a000 b344a000 r-xp /usr/lib/libnetwork.so.0.0.0
b344b000 b3454000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3455000 b34cc000 r-xp /usr/lib/libcurl.so.4.3.0
b34ce000 b34e2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34e3000 b34f5000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b35fd000 b3603000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3604000 b3748000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b375e000 b375f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3760000 b3761000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3762000 b3765000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3766000 b3769000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b376a000 b37a3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41a6000 b41b1000 r-xp /lib/libnss_files-2.20-2014.11.so
b41b3000 b41be000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41c0000 b41d7000 r-xp /lib/libnsl-2.20-2014.11.so
b41db000 b41e3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41e5000 b4209000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b420a000 b420b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b420c000 b420f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4210000 b4217000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4218000 b4222000 r-xp /usr/lib/libsensord-share.so
b4223000 b423f000 r-xp /usr/lib/libsensor.so.1.2.0
b4241000 b424a000 r-xp /usr/lib/libappcore-common.so.1.1
b424d000 b424f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4264000 b4266000 r-xp /usr/lib/libXau.so.6.0.0
b4267000 b4289000 r-xp /usr/lib/libxcb.so.1.1.0
b428b000 b4294000 r-xp /lib/libcrypt-2.20-2014.11.so
b42bd000 b42bf000 r-xp /usr/lib/libiri.so
b42c0000 b42e6000 r-xp /lib/libexpat.so.1.5.2
b42e8000 b4353000 r-xp /usr/lib/libssl.so.1.0.0
b4359000 b4365000 r-xp /usr/lib/libethumb.so.1.13.0
b4366000 b436a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b436b000 b45bc000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b37000 b5b47000 r-xp /usr/lib/libXi.so.6.1.0
b5b48000 b5b4a000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b4b000 b5b51000 r-xp /usr/lib/libXtst.so.6.1.0
b5b52000 b5b5c000 r-xp /usr/lib/libXrender.so.1.3.0
b5b5d000 b5b66000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b68000 b5b6a000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b6b000 b5b70000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b71000 b5b83000 r-xp /usr/lib/libXext.so.6.4.0
b5b84000 b5b86000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b87000 b5b89000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b8b000 b5ccd000 r-xp /usr/lib/libX11.so.6.3.0
b5cd1000 b5cdb000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cdc000 b5cf2000 r-xp /usr/lib/libudev.so.1.6.0
b5cf5000 b5cf9000 r-xp /lib/libattr.so.1.1.0
b5cfa000 b5d29000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d2b000 b5d31000 r-xp /usr/lib/libffi.so.6.0.2
b5d32000 b5d55000 r-xp /lib/libz.so.1.2.8
b5d56000 b5d59000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d5a000 b5eb6000 r-xp /usr/lib/libxml2.so.2.9.2
b5ebc000 b5fa3000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fb0000 b5fb3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fb4000 b5fd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fd7000 b5feb000 r-xp /lib/libresolv-2.20-2014.11.so
b5fef000 b6013000 r-xp /usr/lib/liblzma.so.5.0.3
b6014000 b6016000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6018000 b6022000 r-xp /usr/lib/libembryo.so.1.13.0
b6023000 b604c000 r-xp /usr/lib/libpng12.so.0.50.0
b604d000 b6096000 r-xp /usr/lib/libjpeg.so.8.0.2
b60a7000 b60ae000 r-xp /lib/librt-2.20-2014.11.so
b60b0000 b60cf000 r-xp /usr/lib/libector.so.1.13.0
b60d2000 b60ff000 r-xp /usr/lib/liblua-5.1.so
b6100000 b6190000 r-xp /usr/lib/libfreetype.so.6.11.3
b6194000 b61d2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61d3000 b61e9000 r-xp /usr/lib/libfribidi.so.0.3.1
b61ea000 b6243000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6246000 b6291000 r-xp /lib/libm-2.20-2014.11.so
b6293000 b62a5000 r-xp /usr/lib/libeio.so.1.13.0
b62a6000 b62a9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62aa000 b62b0000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62b1000 b62d4000 r-xp /usr/lib/libefreet.so.1.13.0
b62d7000 b6302000 r-xp /usr/lib/libeldbus.so.1.13.0
b6303000 b6337000 r-xp /usr/lib/libecore_con.so.1.13.0
b6339000 b6342000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6343000 b634c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b634d000 b6360000 r-xp /usr/lib/libeo.so.1.13.0
b6362000 b6375000 r-xp /usr/lib/libecore_input.so.1.13.0
b6376000 b637d000 r-xp /usr/lib/libecore_file.so.1.13.0
b637e000 b63a1000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63a2000 b63ce000 r-xp /usr/lib/libeet.so.1.13.0
b63d7000 b6442000 r-xp /usr/lib/libeina.so.1.13.0
b6445000 b645c000 r-xp /usr/lib/libefl.so.1.13.0
b645e000 b65c5000 r-xp /usr/lib/libicuuc.so.51.1
b65d3000 b67df000 r-xp /usr/lib/libicui18n.so.51.1
b67e7000 b6836000 r-xp /usr/lib/libecore_x.so.1.13.0
b6838000 b6852000 r-xp /lib/libgcc_s-4.9.so.1
b6854000 b6858000 r-xp /lib/libcap.so.2.21
b6859000 b689f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68a0000 b68a7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68a9000 b68fb000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68fd000 b6a88000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a8d000 b6b5b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b5e000 b6b62000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b63000 b6b72000 r-xp /usr/lib/libvconf.so.0.2.45
b6b73000 b6b76000 r-xp /usr/lib/libvasum.so.0.3.1
b6b77000 b6b7a000 r-xp /usr/lib/libttrace.so.1.1
b6b7c000 b6b80000 r-xp /usr/lib/libiniparser.so.0
b6b81000 b6bb1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bb2000 b6bbb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bbc000 b6be1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be2000 b6bf2000 r-xp /usr/lib/libunwind.so.8.0.1
b6bfc000 b6daa000 r-xp /lib/libc-2.20-2014.11.so
b6db2000 b6ef5000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ef7000 b6f4f000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f50000 b6f84000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f87000 b705b000 r-xp /usr/lib/libedje.so.1.13.0
b705e000 b708a000 r-xp /usr/lib/libecore.so.1.13.0
b709b000 b72c1000 r-xp /usr/lib/libevas.so.1.13.0
b72e9000 b7301000 r-xp /lib/libpthread-2.20-2014.11.so
b7305000 b767f000 r-xp /usr/lib/libelementary.so.1.13.0
b769f000 b76a3000 r-xp /usr/lib/libsmack.so.1.0.0
b76a4000 b76ad000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ae000 b76b1000 r-xp /usr/lib/libdlog.so.0.0.0
b76b2000 b76b7000 r-xp /usr/lib/libbundle.so.0.1.22
b76b8000 b76bb000 r-xp /lib/libdl-2.20-2014.11.so
b76bd000 b76e2000 r-xp /usr/lib/libaul.so.0.1.0
b76e5000 b76e7000 r-xp /usr/lib/libappsvc.so.0.1.0
b76e8000 b76ed000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76ee000 b76f5000 r-xp /usr/lib/libappcore-efl.so.1.1
b76f7000 b76fc000 r-xp /usr/lib/libsys-assert.so
b76ff000 b7700000 r-xp [vdso]
b7700000 b7722000 r-xp /lib/ld-2.20-2014.11.so
b7724000 b772c000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:2906)
Call Stack Count: 5
 0: (0xb6d2dc0b) [/lib/libc.so.6] + 0x131c0b
 1: (0xb707a3f1) [/usr/lib/libecore.so.1] + 0x1c3f1
 2: (0xb6413afb) [/usr/lib/libeina.so.1] + 0x3cafb
 3: (0xb72ef15f) [/lib/libpthread.so.0] + 0x615f
 4: clone + 0x5e (0xb6ce33ee) [/lib/libc.so.6] + 0xe73ee
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
_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.539+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.539+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:21:59.549+0900 E/EFL     ( 2906): evas_main<2906> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800ce476 is not stable during recalc loop
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 2:22 4 h"
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 2:22"
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 2&#x2236;22"
11-02 14:22:00.069+0900 D/INDICATOR( 2831): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147080427 Time: <font_size=23>2&#x2236;22</font_size> <font_size=22>PM</font_size></font>
11-02 14:22:02.879+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600117 
11-02 14:22:02.989+0900 I/tichat  ( 2906): Sent count: 14, msg:
11-02 14:22:02.989+0900 E/EFL     ( 2906): elementary<2906> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x800e0104 into part 'elm.swallow.indicator_bg'
11-02 14:22:04.159+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600117 
11-02 14:22:04.159+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7f3cf00. set autocapital type : 2
11-02 14:22:04.169+0900 D/ISE_DEFAULT( 3008): ise.cpp: on_focus_in(245) > Enter
11-02 14:22:04.169+0900 D/ISE_DEFAULT( 3008): ise.cpp: ise_focus_in(824) > ic : b5c0023 , 0 , g_ic : b5a0023 , 0, g_focused_ic : 0 , 1
11-02 14:22:04.169+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7f3cf00. on demand : 0
11-02 14:22:04.169+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 14:22:04.169+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 0
11-02 14:22:04.179+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7f3cf00
11-02 14:22:04.179+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 14:22:05.159+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
11-02 14:22:05.259+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 1
11-02 14:22:05.259+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7f3cf00, bidi direction : 0x1
11-02 14:22:05.309+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 2
11-02 14:22:05.359+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 3
11-02 14:22:05.439+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 4
11-02 14:22:05.509+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 5
11-02 14:22:05.579+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 6
11-02 14:22:05.609+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7f3cf00, cursor pos : 7
11-02 14:22:06.669+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600117 
11-02 14:22:06.679+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7f3cf00
11-02 14:22:06.689+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-02 14:22:06.689+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7f3cf00
11-02 14:22:06.689+0900 E/EFL     ( 2906): edje<2906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-02 14:22:06.689+0900 E/EFL     ( 2906): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 14:22:06.689+0900 D/ISE_DEFAULT( 3008): ise.cpp: on_focus_out(251) > Enter
11-02 14:22:06.739+0900 I/tichat  ( 2906): Sent count: 12, msg:
11-02 14:22:06.769+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-02 14:22:06.769+0900 D/ISF_PANEL_EFL( 2994): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
11-02 14:22:06.769+0900 D/ISF_PANEL_EFL( 2994): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
11-02 14:22:06.769+0900 D/ISF_PANEL_EFL( 2994): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
11-02 14:22:06.769+0900 D/ISF_PANEL_EFL( 2994): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 14:22:06.769+0900 D/SCIM_HELPER( 3008): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 14:22:06.769+0900 D/LIBSCL_UI( 3008): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2600009 (basewin 0x8000321a mag 0x8000fc7f)
11-02 14:22:06.799+0900 D/LIBSCL_UI( 3008): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2600003 (basewin 0x8000321a mag 0x8000fc7f)
11-02 14:22:06.799+0900 D/ISE_DEFAULT( 3008): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
11-02 14:22:10.169+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x600117 bd->visible=1
11-02 14:22:10.169+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(370) > [PROCESSMGR] pointed_win=0x600117 cwin=0x600117 
11-02 14:22:10.169+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(373) > [PROCESSMGR] pointed_win=0x600117 is not response!
11-02 14:22:10.169+0900 E/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_dbus_msg_send(308) > [PROCESSMGR] pointed_win=0x2800002 Send kill command to the ResourceD! PID=2906
11-02 14:22:10.179+0900 E/RESOURCED( 2828): proc-monitor.c: proc_dbus_watchdog_handler(688) > Receive watchdog signal to pid: 2906(tichat)
11-02 14:22:10.179+0900 D/RESOURCED( 2828): heart-abnormal.c: heart_abnormal_anr(100) > info : 2906 ANR 1 
11-02 14:22:10.179+0900 E/RESOURCED( 2828): proc-monitor.c: proc_dbus_watchdog_handler(694) > current killing watchdog process. so skipped kill 2906(tichat)
11-02 14:22:12.169+0900 D/DATA_PROVIDER_MASTER( 2899): slave_life.c: slave_ttl_cb(322) > [SECURE_LOG] Slave is paused, Terminate it now
11-02 14:22:12.169+0900 D/DATA_PROVIDER_MASTER( 2899): slave_life.c: slave_deactivate(245) > [SECURE_LOG] Fire the terminate timer: 2988 (1)
11-02 14:22:14.429+0900 E/CAPI_NETWORK_WIFI( 2831): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 14:22:14.429+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-02 14:22:14.429+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 14:22:14.429+0900 E/INDICATOR( 2831): 
11-02 14:22:25.329+0900 D/RESOURCED( 2828): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-02 14:22:25.329+0900 I/RESOURCED( 2828): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-02 14:22:25.329+0900 D/RESOURCED( 2828): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-02 14:22:25.329+0900 I/RESOURCED( 2828): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-02 14:22:28.598+0900 E/AUL_AMD ( 2769): amd_main.c: __platform_ready_handler(429) > [Info]__platform_ready_handler
11-02 14:22:29.048+0900 D/ALARM_MANAGER( 3059): alarm-lib.c: alarmmgr_fini(481) > [SECURE_LOG] Enter
11-02 14:22:29.048+0900 D/ALARM_MANAGER( 3059): alarm-lib.c: alarmmgr_fini(503) > [SECURE_LOG] Leave
11-02 14:22:34.438+0900 E/CAPI_NETWORK_WIFI( 2831): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 14:22:34.438+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-02 14:22:34.438+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 14:22:34.438+0900 E/INDICATOR( 2831): 
11-02 14:22:42.208+0900 D/DATA_PROVIDER_MASTER( 2899): slave_life.c: terminate_timer_cb(195) > [SECURE_LOG] Terminate slave: 2988 (0_20.804984)
11-02 14:22:42.208+0900 D/AUL     ( 2899): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 2988
11-02 14:22:42.208+0900 D/AUL     ( 2899): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(4)
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 4
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 2988, 
11-02 14:22:42.208+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(2988) : cmd(4)
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_launch.c: _term_app(1076) > term done
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
11-02 14:22:42.208+0900 D/AUL     ( 2988): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
11-02 14:22:42.208+0900 D/WIDGET_PROVIDER_APP( 2988): client.c: widget_provider_app_terminate_app(1818) > [SECURE_LOG] Reason: 5, 1
11-02 14:22:42.208+0900 D/WIDGET  ( 2988): virtual_window.c: pre_destroy_cb(949) > [SECURE_LOG] Pre destroy event callback is called [file:///opt/usr/share/live_magazine/org.tizen.calendar.widget_2843_17.675676.png]
11-02 14:22:42.208+0900 D/WIDGET  ( 2988): virtual_window.c: pre_destroy_cb(952) > [SECURE_LOG] Toggle manual render mode to prevent from unwanted rendering
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 D/WAPP    ( 2988): WControl.cpp: ~WControl(90) > [0;34m>>>HIT<<<[0;m
11-02 14:22:42.208+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __provider_destroy_cb(249) > widget obj was deleted
11-02 14:22:42.208+0900 D/WIDGET_PROVIDER( 2988): widget_provider.c: disconnected_cb(1243) > [SECURE_LOG] 35 is not my favor (26)
11-02 14:22:42.208+0900 D/COM_CORE( 2988): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(35) for pid(-1)
11-02 14:22:42.208+0900 D/COM_CORE( 2988): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
11-02 14:22:42.208+0900 D/COM_CORE( 2988): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (35)
11-02 14:22:42.208+0900 E/COM_CORE( 2988): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
11-02 14:22:42.208+0900 D/WIDGET_PROVIDER_APP( 2988): client.c: widget_provider_app_terminate_app(1850) > [SECURE_LOG] 1 instances are destroyed
11-02 14:22:42.208+0900 D/WIDGET_PROVIDER_APP( 2988): client.c: client_fini(1179) > [SECURE_LOG] Finalize the Provider App Connection
11-02 14:22:42.208+0900 D/WIDGET_PROVIDER( 2988): widget_provider.c: disconnected_cb(1247) > [SECURE_LOG] Disconnected (26)
11-02 14:22:42.208+0900 E/WIDGET_PROVIDER_APP( 2988): client.c: client_fini(1175) > Provider is not initialized
11-02 14:22:42.208+0900 D/RESOURCED( 2828): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2988
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 22
11-02 14:22:42.208+0900 W/AUL_AMD ( 2769): amd_request.c: __request_handler(1056) > app status : 5
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(2988) status(5)
11-02 14:22:42.208+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(2988) appid(org.tizen.calendar.widget) pkgid(org.tizen.calendar) status(5)
11-02 14:22:42.208+0900 W/AUL_AMD ( 2769): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(2988), cmd(4)
11-02 14:22:42.218+0900 D/AUL     ( 2899): launch.c: app_request_to_launchpad(425) > launch request result : 0
11-02 14:22:42.218+0900 E/COM_CORE( 2843): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
11-02 14:22:42.218+0900 D/COM_CORE( 2843): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (74)
11-02 14:22:42.218+0900 D/COM_CORE( 2843): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
11-02 14:22:42.218+0900 D/COM_CORE( 2843): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(-1233025013)
11-02 14:22:42.218+0900 D/COM_CORE( 2843): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
11-02 14:22:42.218+0900 D/COM_CORE( 2843): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
11-02 14:22:42.218+0900 D/COM_CORE( 2843): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(74) for pid(-1)
11-02 14:22:42.218+0900 E/COM_CORE( 2843): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
11-02 14:22:42.218+0900 D/COM_CORE( 2988): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
11-02 14:22:42.218+0900 D/COM_CORE( 2988): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (26)
11-02 14:22:42.218+0900 E/COM_CORE( 2899): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (66)
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(0)
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
11-02 14:22:42.218+0900 D/DATA_PROVIDER_MASTER( 2899): instance.c: instance_need_slave(3445) > [SECURE_LOG] Req. to ACTIVATED (org.tizen.calendar.widget)
11-02 14:22:42.218+0900 D/DATA_PROVIDER_MASTER( 2899): slave_rpc.c: slave_deactivate_cb(338) > [SECURE_LOG] Reset handle for -1 (66)
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(66) for pid(-1)
11-02 14:22:42.218+0900 E/COM_CORE( 2899): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
11-02 14:22:42.218+0900 E/COM_CORE( 2988): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
11-02 14:22:42.218+0900 D/WIDGET_PROVIDER_APP( 2988): client.c: client_fini(1184) > [SECURE_LOG] Provider is disconnected(app)
11-02 14:22:42.218+0900 E/EFL     ( 2988): ecore<2988> lib/ecore/ecore_timer.c:566 _ecore_timer_cleanup() 1 timers to delete, but they were not found!Stats: todo=1, done=0, pending=1, in_use=0. reset counter.
11-02 14:22:42.218+0900 D/WIDGET_PROVIDER( 2988): fb.c: destroy_gem(454) > [SECURE_LOG] Release compensate buffer 0xb20dd008
11-02 14:22:42.218+0900 E/WIDGET_PROVIDER( 2988): fb.c: destroy_gem(466) > [SECURE_LOG] Resource is not trusted anymore(12582916)
11-02 14:22:42.218+0900 D/WIDGET  ( 2988): binder.c: free_fb(498) > [SECURE_LOG] HW Accelerated buffer is destroyed
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [46] New TCB created: R(49), W(50)
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 46 (server: 4)
11-02 14:22:42.218+0900 E/DATA_PROVIDER_MASTER( 2899): server.c: slave_release_buffer(7921) > [SECURE_LOG] Failed to find a slave
11-02 14:22:42.218+0900 D/COM_CORE( 2988): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2899, fd: -1
11-02 14:22:42.218+0900 D/COM_CORE( 2988): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2899), fd: -1
11-02 14:22:42.218+0900 D/COM_CORE( 2988): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 26 (recv_fd: -1)
11-02 14:22:42.218+0900 E/WIDGET_PROVIDER( 2988): widget_provider_buffer.c: widget_provider_buffer_release(2198) > [SECURE_LOG] Failed to send a release request [-49545208]
11-02 14:22:42.218+0900 D/WIDGET  ( 2988): widget.c: widget_viewer_release_buffer(609) > [SECURE_LOG] Release buffer: -1 (0)
11-02 14:22:42.218+0900 D/WIDGET  ( 2988): widget.c: widget_destroy_buffer(635) > [SECURE_LOG] Destroy buffer
11-02 14:22:42.218+0900 E/COM_CORE( 2899): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (46)
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(2988)
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
11-02 14:22:42.218+0900 D/COM_CORE( 2899): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(46) for pid(-1)
11-02 14:22:42.228+0900 E/COM_CORE( 2899): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
11-02 14:22:42.338+0900 D/CALENDAR( 2988): main.cpp: main(28) > app return=0
11-02 14:22:42.338+0900 D/CALENDAR( 2988): main.cpp: main(29) > [0;32mEND <<<<[0;m
11-02 14:22:42.348+0900 D/AUL_AMD ( 2769): amd_request.c: __sigchld_handler(1289) > Sig child 2988
11-02 14:22:42.348+0900 I/AUL_AMD ( 2769): amd_request.c: __release_app(1259) > [SECURE_LOG] appid: org.tizen.calendar.widget
11-02 14:22:42.348+0900 D/AUL_AMD ( 2769): amd_request.c: __check_restart(471) > ri (b77ac098)
11-02 14:22:42.348+0900 D/AUL_AMD ( 2769): amd_request.c: __check_restart(472) > [SECURE_LOG] appid (org.tizen.calendar.widget)
11-02 14:22:42.348+0900 W/AUL_AMD ( 2769): amd_request.c: __send_app_termination_signal(549) > send dead signal done
11-02 14:22:42.348+0900 I/ESD     ( 2910): esd_main.c: __esd_app_dead_handler(1771) > pid: 2988
11-02 14:22:42.348+0900 D/STARTER ( 2825): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 2988 is termianted
11-02 14:22:42.348+0900 D/STARTER ( 2825): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
11-02 14:22:42.348+0900 W/AUL_AMD ( 2769): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 2988
11-02 14:22:42.348+0900 D/AUL_AMD ( 2769): amd_key.c: _unregister_key_event(179) > ===key stack===
11-02 14:22:42.348+0900 E/AUL_AMD ( 2769): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
11-02 14:22:42.348+0900 D/AUL_AMD ( 2769): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.calendar.widget)
11-02 14:22:42.348+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
11-02 14:22:42.348+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
11-02 14:22:42.348+0900 D/RESOURCED( 2828): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 2988
11-02 14:22:42.348+0900 D/RESOURCED( 2828): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.calendar.widget, pkgname = org.tizen.calendar, ref = 0
11-02 14:22:47.218+0900 D/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(442) > pid(2988)
11-02 14:22:47.218+0900 W/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
11-02 14:22:52.358+0900 D/AUL_AMD ( 2769): amd_request.c: __restart_timeout_handler(443) > ri (b77ac098)
11-02 14:22:52.358+0900 D/AUL_AMD ( 2769): amd_request.c: __restart_timeout_handler(444) > [SECURE_LOG] appid (org.tizen.calendar.widget)
11-02 14:22:54.458+0900 E/CAPI_NETWORK_WIFI( 2831): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 14:22:54.458+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-02 14:22:54.458+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 14:22:54.458+0900 E/INDICATOR( 2831): 
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 2:23 4 h"
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 2:23"
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 2&#x2236;23"
11-02 14:23:00.078+0900 D/INDICATOR( 2831): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147078375 Time: <font_size=23>2&#x2236;23</font_size> <font_size=22>PM</font_size></font>
11-02 14:23:14.468+0900 E/CAPI_NETWORK_WIFI( 2831): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 14:23:14.468+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-02 14:23:14.468+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 14:23:14.468+0900 E/INDICATOR( 2831): 
11-02 14:23:24.188+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600117 
11-02 14:23:24.218+0900 I/tichat  ( 2906): room leaved
11-02 14:23:24.488+0900 D/IMMODULE( 2906): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb7f3cf00
11-02 14:23:24.488+0900 D/ISF_PANEL_EFL( 2994): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-02 14:23:24.488+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-02 14:23:25.198+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
11-02 14:23:25.318+0900 D/RESOURCED( 2828): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-02 14:23:25.318+0900 I/RESOURCED( 2828): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-02 14:23:25.318+0900 D/RESOURCED( 2828): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-02 14:23:25.318+0900 I/RESOURCED( 2828): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-02 14:23:25.688+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600117 
11-02 14:23:25.738+0900 E/EFL     ( 2906): edje<2906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-02 14:23:25.738+0900 E/EFL     ( 2906): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 14:23:25.798+0900 D/DOWNLOAD_PROVIDER( 2911): download-provider-client-manager.c: dp_client_manager(700) > 0 clients are active now
11-02 14:23:25.798+0900 D/DOWNLOAD_PROVIDER( 2911): download-provider-client-manager.c: __dp_manage_client_requests(315) > slot_index:0
11-02 14:23:25.798+0900 D/PKGMGR_INFO( 2911): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
11-02 14:23:25.798+0900 D/PKGMGR_INFO( 2911): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
11-02 14:23:25.798+0900 I/AUL     ( 2911): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/download-provider, ret : 0
11-02 14:23:25.798+0900 D/AUL     ( 2911): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 2911, pid = 2911
11-02 14:23:25.798+0900 D/PKGMGR_INFO( 2911): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
11-02 14:23:25.798+0900 D/PKGMGR_INFO( 2911): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
11-02 14:23:25.798+0900 I/AUL     ( 2911): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/download-provider, ret : 0
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [46]
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): notification_service.c: service_thread_main(864) > [SECURE_LOG] 0xb2600540 REQ: Command: [del_noti_multiple]
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 92 bytes
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): notification_service.c: _handler_delete_multiple(345) > [SECURE_LOG] pkgname: [/usr/bin/download-provider] type: [1]
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): notification_service.c: _handler_delete_multiple(348) > [SECURE_LOG] ret: [0] num_deleted: [0]
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
11-02 14:23:25.798+0900 D/COM_CORE( 2911): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2899, fd: -1
11-02 14:23:25.798+0900 D/COM_CORE( 2911): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 8 bytes (pid: 2899), fd: -1
11-02 14:23:25.798+0900 D/COM_CORE( 2911): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 3 (recv_fd: -1)
11-02 14:23:25.798+0900 E/NOTIFICATION( 2911): notification_ipc.c: notification_ipc_request_delete_multiple(1289) > [SECURE_LOG] [notification_ipc_request_delete_multiple : 1289] num deleted:0
11-02 14:23:25.798+0900 D/DOWNLOAD_PROVIDER( 2911): download-provider-client-manager.c: __dp_db_free_client_manager(110) > [SECURE_LOG] TRY to close [.download-provider-clients]
11-02 14:23:25.798+0900 D/COM_CORE( 2899): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
11-02 14:23:25.798+0900 D/DOWNLOAD_PROVIDER( 2911): download-provider-client-manager.c: dp_client_manager(723) > try to deallocate the resources for all clients
11-02 14:23:25.798+0900 I/DOWNLOAD_PROVIDER( 2911): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb2600540 is terminated
11-02 14:23:25.798+0900 D/DATA_PROVIDER_MASTER( 2899): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
11-02 14:23:25.798+0900 E/WIFI_DIRECT( 2911): wifi-direct-client-proxy.c: wifi_direct_unset_connection_state_changed_cb(1342) > http://tizen.org/feature/network.wifi.direct feature is disabled
11-02 14:23:25.798+0900 E/WIFI_DIRECT( 2911): wifi-direct-client-proxy.c: wifi_direct_deinitialize(1070) > http://tizen.org/feature/network.wifi.direct feature is disabled
11-02 14:23:25.798+0900 I/CAPI_NETWORK_CONNECTION( 2911): connection.c: __connection_set_type_changed_callback(175) > Successfully de-registered(0)
11-02 14:23:25.798+0900 I/CAPI_NETWORK_CONNECTION( 2911): connection.c: __connection_set_ip_changed_callback(262) > Successfully de-registered(0)
11-02 14:23:25.798+0900 I/CAPI_NETWORK_CONNECTION( 2911): connection.c: connection_destroy(426) > Destroy handle: 0xb930b810
11-02 14:23:25.798+0900 I/DOWNLOAD_PROVIDER( 2911): download-provider-main.c: main(64) > download-provider's working is done
11-02 14:23:25.858+0900 I/tichat  ( 2906): socket 47 requset sent: 12, msg:getroomlist/ 
11-02 14:23:25.858+0900 I/tichat  ( 2906): roomlist : sdfasdf$Dsds$
11-02 14:23:26.858+0900 I/tichat  ( 2906): not toked : sdfasdf$Dsds$
11-02 14:23:26.858+0900 I/tichat  ( 2906): toked : sdfasdf
11-02 14:23:26.908+0900 I/tichat  ( 2906): toked : Dsds
11-02 14:23:30.198+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x600117 bd->visible=1
11-02 14:23:34.488+0900 E/CAPI_NETWORK_WIFI( 2831): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 14:23:34.488+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-02 14:23:34.488+0900 E/INDICATOR( 2831): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 14:23:34.488+0900 E/INDICATOR( 2831): 
11-02 14:23:39.038+0900 D/IMMODULE( 2906): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
11-02 14:23:39.038+0900 D/ISF_PANEL_EFL( 2994): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-02 14:23:39.038+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-02 14:23:39.148+0900 D/IMMODULE( 2906): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
11-02 14:23:39.148+0900 D/ISF_PANEL_EFL( 2994): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-02 14:23:39.148+0900 D/IMMODULE( 2906): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-02 14:23:40.148+0900 D/PROCESSMGR( 2745): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600117 
11-02 14:23:40.238+0900 E/EFL     ( 2906): edje<2906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-02 14:23:40.238+0900 E/EFL     ( 2906): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 14:23:40.508+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: ui_app_exit(799) > ui_app_exit
11-02 14:23:40.518+0900 D/AUL     ( 2906): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
11-02 14:23:40.518+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 22
11-02 14:23:40.518+0900 W/AUL_AMD ( 2769): amd_request.c: __request_handler(1056) > app status : 5
11-02 14:23:40.518+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(2906) status(5)
11-02 14:23:40.518+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(2906) appid(org.example.tichat) pkgid(org.example.tichat) status(5)
11-02 14:23:40.518+0900 D/AUL     ( 2769): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.tichat
11-02 14:23:40.518+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2906, appid: org.example.tichat, status: bg
11-02 14:23:40.528+0900 D/APP_CORE( 2906): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
11-02 14:23:40.528+0900 D/RESOURCED( 2828): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 2906, appname = org.example.tichat, pkgname = org.example.tichat
11-02 14:23:40.528+0900 D/RESOURCED( 2828): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 2906, appname = org.example.tichat
11-02 14:23:40.528+0900 D/APP_CORE( 2906): appcore-efl.c: __after_loop(1169) > [APP 2906] PAUSE before termination
11-02 14:23:40.528+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
11-02 14:23:40.528+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
11-02 14:23:40.528+0900 E/EFL     ( 2906): eo<2906> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800552ab is not pointing to a valid object. Maybe it has already been freed.
11-02 14:23:40.528+0900 E/EFL     ( 2906): eo<2906> lib/eo/eo.c:485 _eo_do_internal() Obj (0x800552ab) is an invalid ref.
11-02 14:23:40.528+0900 D/RESOURCED( 2828): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2906
11-02 14:23:40.528+0900 D/RESOURCED( 2828): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2840 increase lru 3
11-02 14:23:40.528+0900 D/RESOURCED( 2828): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2840 set score 360 (before 330)
11-02 14:23:40.528+0900 D/RESOURCED( 2828): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.example.tichat
11-02 14:23:40.528+0900 D/RESOURCED( 2828): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2906, proc_name: org.example.tichat, cg_name: favorite, oom_score_adj: 270
11-02 14:23:40.528+0900 D/RESOURCED( 2828): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 2906
11-02 14:23:40.568+0900 E/EFL     ( 2745): eo<2745> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
11-02 14:23:40.568+0900 D/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2891) > pid(2843) status(3)
11-02 14:23:40.568+0900 D/AUL_AMD ( 2769): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
11-02 14:23:40.578+0900 W/AUL_AMD ( 2769): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-02 14:23:40.578+0900 W/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
11-02 14:23:40.578+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(2843) status(3)
11-02 14:23:40.578+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(2843) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
11-02 14:23:40.578+0900 D/AUL     ( 2769): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
11-02 14:23:40.578+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2843, appid: org.tizen.homescreen, status: fg
11-02 14:23:40.578+0900 D/RESOURCED( 2828): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2843
11-02 14:23:40.578+0900 D/RESOURCED( 2828): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2843, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
11-02 14:23:40.578+0900 D/RESOURCED( 2828): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2843, appname = org.tizen.homescreen
11-02 14:23:40.578+0900 D/RESOURCED( 2828): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2843
11-02 14:23:40.598+0900 E/E17     ( 2745): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
11-02 14:23:40.608+0900 E/E17     ( 2745): e_border.c: e_border_hide(2248) > BD_HIDE(0x02800002), visible:1
11-02 14:23:40.608+0900 D/INDICATOR( 2831): main.c: _property_changed_cb(432) > UNSNIFF API 2800002
11-02 14:23:40.608+0900 D/INDICATOR( 2831): util.c: util_signal_emit_by_win(116) > emission bg.translucent
11-02 14:23:40.608+0900 D/INDICATOR( 2831): main.c: _rotate_window(229) > Indicator angle is 0 degree
11-02 14:23:40.608+0900 D/INDICATOR( 2831): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
11-02 14:23:40.608+0900 D/INDICATOR( 2831): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
11-02 14:23:40.608+0900 D/INDICATOR( 2831): main.c: _rotate_window(252) > port :: hide more icon
11-02 14:23:40.628+0900 W/CRASH_MANAGER( 3313): worker.c: worker_job(1204) > 1102906746963147806422
