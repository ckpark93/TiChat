S/W Version Information
Model: TM1
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-TM1_20160307.1306
Build-Date: 2016.03.07 13:06:48

Crash Information
Process Name: tichat
PID: 2661
Date: 2015-03-04 03:13:14+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0xb32f417f
r2   = 0xb32fca5c, r3   = 0x00000000
r4   = 0xb69f7100, r5   = 0xb69f712c
r6   = 0xb69f7100, r7   = 0xb00debd0
r8   = 0xb8e066f0, r9   = 0xb00df210
r10  = 0xb8e06780, fp   = 0x00000000
ip   = 0xb32fcc54, sp   = 0xb00dea78
lr   = 0xb32f0185, pc   = 0xb66e56f0
cpsr = 0x60010030

Memory Information
MemTotal:   987328 KB
MemFree:    485700 KB
Buffers:     26352 KB
Cached:     165016 KB
VmPeak:     127964 KB
VmSize:     127960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30428 KB
VmRSS:       30428 KB
VmData:      51532 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       23168 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2661 TID = 2927
2661 2663 2921 2927 

Maps Information
af8e1000 b00e0000 rw-p [stack:2927]
b0481000 b0c80000 rw-p [stack:2921]
b2582000 b2587000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2597000 b25a7000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25a8000 b25ad000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b262e000 b2636000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2647000 b2648000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2658000 b265f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2683000 b2696000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26aa000 b26af000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b26bf000 b26c0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d0000 b26d3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26e4000 b26e5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26f5000 b26f7000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2707000 b2709000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2719000 b2721000 r-xp /usr/lib/libdrm.so.2.4.0
b2731000 b2733000 r-xp /usr/lib/libdri2.so.0.0.0
b2743000 b274b000 r-xp /usr/lib/libtbm.so.1.0.0
b275b000 b275c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b276e000 b276f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b277f000 b278b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b279d000 b2f9c000 rw-p [stack:2917]
b2f9c000 b2fca000 r-xp /usr/lib/libidn.so.11.5.44
b2fda000 b2ff0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3001000 b300b000 r-xp /usr/lib/libcares.so.2.1.0
b301b000 b3030000 r-xp /usr/lib/libnetwork.so.0.0.0
b3041000 b3048000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3058000 b309e000 r-xp /usr/lib/libcurl.so.4.3.0
b30af000 b30bc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b30ce000 b30de000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b31e6000 b31ea000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b31fb000 b32db000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b32ea000 b32f5000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b32fd000 b3325000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b3337000 b3b36000 rw-p [stack:2663]
b3b36000 b3b38000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3d48000 b3d51000 r-xp /lib/libnss_files-2.20-2014.11.so
b3d62000 b3d6b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3d7c000 b3d8d000 r-xp /lib/libnsl-2.20-2014.11.so
b3da0000 b3da6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3db7000 b3dd1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b3de2000 b3de3000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b3df3000 b3df5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e06000 b3e0b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e1b000 b3e1e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3e2f000 b3e36000 r-xp /usr/lib/libsensord-share.so
b3e46000 b3e57000 r-xp /usr/lib/libsensor.so.1.2.0
b3e68000 b3e6e000 r-xp /usr/lib/libappcore-common.so.1.1
b3e91000 b3e96000 r-xp /usr/lib/libappcore-efl.so.1.1
b3eac000 b3eae000 r-xp /usr/lib/libXau.so.6.0.0
b3ebe000 b3ed2000 r-xp /usr/lib/libxcb.so.1.1.0
b3ee2000 b3ee9000 r-xp /lib/libcrypt-2.20-2014.11.so
b3f21000 b3f23000 r-xp /usr/lib/libiri.so
b3f34000 b3f49000 r-xp /lib/libexpat.so.1.5.2
b3f5b000 b3fa9000 r-xp /usr/lib/libssl.so.1.0.0
b3fbe000 b3fc7000 r-xp /usr/lib/libethumb.so.1.13.0
b3fd8000 b3fdb000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b3feb000 b41a2000 r-xp /usr/lib/libcrypto.so.1.0.0
b5739000 b5742000 r-xp /usr/lib/libXi.so.6.1.0
b5753000 b5755000 r-xp /usr/lib/libXgesture.so.7.0.0
b5765000 b5769000 r-xp /usr/lib/libXtst.so.6.1.0
b5779000 b577f000 r-xp /usr/lib/libXrender.so.1.3.0
b578f000 b5795000 r-xp /usr/lib/libXrandr.so.2.2.0
b57a5000 b57a7000 r-xp /usr/lib/libXinerama.so.1.0.0
b57b7000 b57ba000 r-xp /usr/lib/libXfixes.so.3.1.0
b57cb000 b57d6000 r-xp /usr/lib/libXext.so.6.4.0
b57e6000 b57e8000 r-xp /usr/lib/libXdamage.so.1.1.0
b57f8000 b57fa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b580a000 b58ed000 r-xp /usr/lib/libX11.so.6.3.0
b5900000 b5907000 r-xp /usr/lib/libXcursor.so.1.0.2
b5918000 b5930000 r-xp /usr/lib/libudev.so.1.6.0
b5932000 b5935000 r-xp /lib/libattr.so.1.1.0
b5945000 b5965000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5966000 b596b000 r-xp /usr/lib/libffi.so.6.0.2
b597b000 b5993000 r-xp /lib/libz.so.1.2.8
b59a3000 b59a5000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b59b5000 b5a8a000 r-xp /usr/lib/libxml2.so.2.9.2
b5a9f000 b5b3a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b56000 b5b59000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b69000 b5b83000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b93000 b5ba4000 r-xp /lib/libresolv-2.20-2014.11.so
b5bb8000 b5bcf000 r-xp /usr/lib/liblzma.so.5.0.3
b5bdf000 b5be1000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf1000 b5bf8000 r-xp /usr/lib/libembryo.so.1.13.0
b5c08000 b5c20000 r-xp /usr/lib/libpng12.so.0.50.0
b5c31000 b5c54000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c74000 b5c7a000 r-xp /lib/librt-2.20-2014.11.so
b5c8b000 b5c9f000 r-xp /usr/lib/libector.so.1.13.0
b5cb0000 b5cc8000 r-xp /usr/lib/liblua-5.1.so
b5cd9000 b5d30000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d44000 b5d6c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d7d000 b5d90000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da1000 b5ddb000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dec000 b5e57000 r-xp /lib/libm-2.20-2014.11.so
b5e68000 b5e75000 r-xp /usr/lib/libeio.so.1.13.0
b5e85000 b5e87000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e97000 b5e9c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5eac000 b5ec3000 r-xp /usr/lib/libefreet.so.1.13.0
b5ed5000 b5ef5000 r-xp /usr/lib/libeldbus.so.1.13.0
b5f05000 b5f25000 r-xp /usr/lib/libecore_con.so.1.13.0
b5f27000 b5f2d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f3d000 b5f44000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f54000 b5f62000 r-xp /usr/lib/libeo.so.1.13.0
b5f72000 b5f84000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f95000 b5f9a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5faa000 b5fc2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fd3000 b5ff0000 r-xp /usr/lib/libeet.so.1.13.0
b6009000 b6051000 r-xp /usr/lib/libeina.so.1.13.0
b6062000 b6072000 r-xp /usr/lib/libefl.so.1.13.0
b6083000 b6168000 r-xp /usr/lib/libicuuc.so.51.1
b6185000 b62c5000 r-xp /usr/lib/libicui18n.so.51.1
b62dc000 b6314000 r-xp /usr/lib/libecore_x.so.1.13.0
b6326000 b6329000 r-xp /lib/libcap.so.2.21
b6339000 b6362000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6373000 b637a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b638c000 b63c2000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b63d3000 b64bb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b64cf000 b6545000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6557000 b655a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b656a000 b6575000 r-xp /usr/lib/libvconf.so.0.2.45
b6585000 b6587000 r-xp /usr/lib/libvasum.so.0.3.1
b6597000 b6599000 r-xp /usr/lib/libttrace.so.1.1
b65a9000 b65ac000 r-xp /usr/lib/libiniparser.so.0
b65bc000 b65df000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ef000 b65f4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6605000 b661c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b662d000 b663a000 r-xp /usr/lib/libunwind.so.8.0.1
b6670000 b6794000 r-xp /lib/libc-2.20-2014.11.so
b67a9000 b67c2000 r-xp /lib/libgcc_s-4.9.so.1
b67d2000 b68b4000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b68c5000 b68f9000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6909000 b6943000 r-xp /usr/lib/libsystemd.so.0.4.0
b6945000 b69c5000 r-xp /usr/lib/libedje.so.1.13.0
b69c8000 b69e6000 r-xp /usr/lib/libecore.so.1.13.0
b6a06000 b6b68000 r-xp /usr/lib/libevas.so.1.13.0
b6b9f000 b6bb3000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc7000 b6deb000 r-xp /usr/lib/libelementary.so.1.13.0
b6e19000 b6e1d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e2d000 b6e33000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e44000 b6e46000 r-xp /usr/lib/libdlog.so.0.0.0
b6e56000 b6e59000 r-xp /usr/lib/libbundle.so.0.1.22
b6e69000 b6e6b000 r-xp /lib/libdl-2.20-2014.11.so
b6e7c000 b6e95000 r-xp /usr/lib/libaul.so.0.1.0
b6ea7000 b6ea9000 r-xp /usr/lib/libappsvc.so.0.1.0
b6eba000 b6ebe000 r-xp /usr/lib/libsys-assert.so
b6ecf000 b6eef000 r-xp /lib/ld-2.20-2014.11.so
b6f00000 b6f06000 r-xp /usr/bin/launchpad-loader
b8b6b000 b8efe000 rw-p [heap]
bead4000 beaf5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2661)
Call Stack Count: 1
 0: (0xb66e56f0) [/lib/libc.so.6] + 0x756f0
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
9): sclevents-efl.cpp: mouse_move(566) > mouse_move : 621 1038, 621 200
03-04 03:12:00.280+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 621 1038, 621 200
03-04 03:12:00.280+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.280+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:12:00.280+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : a670025, 6c
03-04 03:12:00.290+0900 D/IMMODULE( 2661): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb8e8ea68, cursor pos : 4
03-04 03:12:00.290+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: isf_imf_context_input_panel_caps_mode_set(734) > [SECURE_LOG] ctx : 0xb8e8ea68, mode : 0
03-04 03:12:00.290+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 100 0x8018f1a5
03-04 03:12:00.290+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x801a13bb
03-04 03:12:00.290+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 03:12:00.290+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 03:12:00.300+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x20194e 
03-04 03:12:00.300+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x1295990), gem(30), surface(0x1263948)
03-04 03:12:00.390+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:12:00.390+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:00.390+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x801a13bb
03-04 03:12:00.390+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Returning Timer : 105 0
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 580 938, 580 100
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:12:00.460+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 100 0x801d262e
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:00.470+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 565 727 565 727 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:00.480+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:00.480+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:12:00.490+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:12:00.510+0900 I/MALI    ( 1099): tizen_buffer.c: tizen_dri2_get_buffers(734) > Re-used flag set for un-cached buffer.
03-04 03:12:00.520+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x12655e8), gem(4), surface(0x1395780)
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 580 938, 580 100
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 580 938, 580 100
03-04 03:12:00.540+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x20194e 
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:12:00.540+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : a670025, 6f
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 100 0x801d262e
03-04 03:12:00.540+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x801b703e
03-04 03:12:00.540+0900 D/IMMODULE( 2661): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb8e8ea68, cursor pos : 5
03-04 03:12:00.540+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: isf_imf_context_input_panel_caps_mode_set(734) > [SECURE_LOG] ctx : 0xb8e8ea68, mode : 0
03-04 03:12:00.540+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 03:12:00.550+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 03:12:00.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:12:00.591+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:12:00.641+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:12:00.641+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:00.641+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x801b703e
03-04 03:12:00.641+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Returning Timer : 105 0
03-04 03:12:00.721+0900 D/INDICATOR(  907): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-04 03:12:00.721+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-04 03:12:00.721+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-04 03:12:00.731+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 3:12 4 h"
03-04 03:12:00.731+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 3:12"
03-04 03:12:00.731+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 3&#x2236;12"
03-04 03:12:00.731+0900 D/INDICATOR(  907): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146571014 Time: <font_size=33>3&#x2236;12</font_size> <font_size=32>AM</font_size></font>
03-04 03:12:01.021+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 616 801, 616 0
03-04 03:12:01.031+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:12:01.091+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201745 
03-04 03:12:01.091+0900 D/IMMODULE( 2661): isf_imf_context.cpp: isf_imf_context_focus_out(1589) > ctx : 0xb8e8ea68
03-04 03:12:01.091+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
03-04 03:12:01.091+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8e8ea68
03-04 03:12:01.091+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_focus_out(251) > Enter
03-04 03:12:01.101+0900 I/tichat  ( 2661): Sent count: 10, msg:
03-04 03:12:01.141+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
03-04 03:12:01.141+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
03-04 03:12:01.141+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_hide_ise(5748) > slot_hide_ise ()
03-04 03:12:01.141+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: hide_ise(3860) > send request to hide helper
03-04 03:12:01.141+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 03:12:01.141+0900 D/SCIM_HELPER( 1099): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 03:12:01.141+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:01.141+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_client_message_cb(6409) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
03-04 03:12:01.151+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 03:12:01.151+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 03:12:01.151+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 03:12:01.151+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb8e8ea68
03-04 03:12:01.151+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x3e00003 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:12:01.151+0900 D/ISE_DEFAULT( 1099): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
03-04 03:12:01.161+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb8e8ea68
03-04 03:12:01.161+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _process_ise_panel_hided(1080) > received_will_hide_event = 1
03-04 03:12:01.171+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5763) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (5a, 3000002)
03-04 03:12:01.171+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5765) > calling ui_candidate_hide (true, false)
03-04 03:12:01.171+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:12:01.171+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300002a)
03-04 03:12:01.171+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00003), visible:1
03-04 03:12:01.171+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x12e27a8), gem(21), surface(0x12641c0)
03-04 03:12:01.181+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x13dd9f8), gem(28), surface(0x13eb628)
03-04 03:12:01.181+0900 W/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2661
03-04 03:12:01.181+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-04 03:12:01.191+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 03:12:01.191+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 03:12:01.191+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:12:01.191+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(646) > [EGL-X11] eglimage target 30b0 imported bo(0x12b8bb0), gem(25), surface(0x13dcfe8)
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300002a)
03-04 03:12:01.201+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_settle_candidate_window(3397) > Moving candidate window to : 0 1196
03-04 03:12:01.201+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 03:12:01.211+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 03:12:01.211+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 03:12:01.211+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:12:01.211+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300002a)
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:12:01.211+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:12:01.211+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:12:01.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:12:01.592+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:12:02.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:12:02.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:12:04.094+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_destroy_candidate_window(3253) > calling ui_candidate_hide (true)
03-04 03:12:04.094+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:12:04.094+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 03:12:04.094+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 03:12:04.094+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 03:12:04.094+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:12:04.094+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300002a)
03-04 03:12:04.104+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:12:04.104+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:12:04.154+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 03:12:04.154+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 03:12:05.585+0900 I/tichat  ( 2661): load message : hi
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.585+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.595+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.605+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.615+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.615+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.615+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:05.615+0900 E/EFL     ( 2661): ecore<2661> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:12:06.586+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:12:06.586+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:12:07.577+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:12:07.577+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:12:16.946+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_add_capacity(1179) > 92 -> 93 1425406336 400 400187
03-04 03:12:16.946+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 93 301 119 35
03-04 03:12:16.946+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 93 0 0 29
03-04 03:12:16.946+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 93 310 8 36
03-04 03:12:16.946+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 93 328 5 38
03-04 03:12:16.946+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 93 300 7 35
03-04 03:12:16.946+0900 D/RESOURCED(  872): heart-battery.c: heart_battery_add_capacity(1267) > battery_heart_capacity_write 93 diff_capacity 1, used time 0, charging time 400187, charger status 1, reset_mark 1
03-04 03:12:16.946+0900 D/RESOURCED(  872): logging.c: logging_leveldb_putv(530) > BATTERY_USED_TIME:522022 531110 
03-04 03:12:16.956+0900 D/INDICATOR(  907): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 93"
03-04 03:12:16.956+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
03-04 03:12:16.956+0900 D/INDICATOR(  907): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
03-04 03:12:16.956+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
03-04 03:12:16.956+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 0, Minictrl count : 3
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 0, Minictrl count : 3
03-04 03:12:16.956+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(269) > default
03-04 03:12:16.956+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-04 03:12:16.956+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-04 03:12:16.956+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 03:12:16.956+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
03-04 03:12:16.956+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
03-04 03:12:16.956+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.show"
03-04 03:12:16.956+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 03:12:16.956+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 03:12:16.967+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 03:12:16.967+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 1
03-04 03:12:16.967+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
03-04 03:12:16.967+0900 D/INDICATOR(  907): icon.c: _hide_more_noti(779) > port :: hide more icon
03-04 03:12:54.153+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201745 
03-04 03:12:54.353+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 1 -> 3
03-04 03:12:54.353+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 1 -> 3
03-04 03:12:54.353+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:12:54.353+0900 D/APP_CORE( 2661): appcore-rotation.c: __changed_cb(121) > [APP 2661] Rotation: 0 -> 3
03-04 03:12:54.353+0900 D/APP_CORE( 2661): appcore-rotation.c: __changed_cb(124) > [APP 2661] Rotation: 0 -> 3
03-04 03:12:54.353+0900 I/CAPI_APPFW_APPLICATION( 2661): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:12:54.954+0900 D/APP_CORE( 2661): appcore-rotation.c: __changed_cb(121) > [APP 2661] Rotation: 3 -> 1
03-04 03:12:54.954+0900 D/APP_CORE( 2661): appcore-rotation.c: __changed_cb(124) > [APP 2661] Rotation: 3 -> 1
03-04 03:12:54.954+0900 I/CAPI_APPFW_APPLICATION( 2661): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:12:54.954+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 3 -> 1
03-04 03:12:54.954+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 3 -> 1
03-04 03:12:54.954+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:12:55.154+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
03-04 03:12:59.038+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201745 
03-04 03:12:59.058+0900 I/tichat  ( 2661): room leaved
03-04 03:12:59.278+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
03-04 03:12:59.278+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
03-04 03:12:59.288+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
03-04 03:12:59.288+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
03-04 03:12:59.288+0900 I/RESOURCED(  872): logging.c: logging_save_to_storage(978) > storage cache is empty
03-04 03:12:59.308+0900 D/IMMODULE( 2661): isf_imf_context.cpp: isf_imf_context_del(1300) > ctx : 0xb8e8ea68
03-04 03:12:59.308+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 1
03-04 03:12:59.308+0900 D/IMMODULE( 2661): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
03-04 03:12:59.578+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:12:59.578+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:13:00.159+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x201745 bd->visible=1
03-04 03:13:00.589+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:13:00.589+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:13:00.719+0900 D/INDICATOR(  907): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-04 03:13:00.729+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-04 03:13:00.729+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-04 03:13:00.729+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 3:13 4 h"
03-04 03:13:00.729+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 3:13"
03-04 03:13:00.729+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 3&#x2236;13"
03-04 03:13:00.729+0900 D/INDICATOR(  907): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146556137 Time: <font_size=33>3&#x2236;13</font_size> <font_size=32>AM</font_size></font>
03-04 03:13:03.422+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201745 
03-04 03:13:03.432+0900 I/tichat  ( 2661): socket 53 requset sent: 12, msg:getroomlist/ 
03-04 03:13:03.442+0900 I/tichat  ( 2661): roomlist : (null)
03-04 03:13:03.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:13:03.592+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:13:04.573+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:13:04.583+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:13:14.743+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201745 
03-04 03:13:14.753+0900 I/CAPI_APPFW_APPLICATION( 2661): app_main.c: ui_app_exit(799) > ui_app_exit
03-04 03:13:14.753+0900 D/AUL     ( 2661): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
03-04 03:13:14.763+0900 D/AUL_AMD (  821): amd_request.c: __request_handler(838) > __request_handler: 22
03-04 03:13:14.763+0900 W/AUL_AMD (  821): amd_request.c: __request_handler(1056) > app status : 5
03-04 03:13:14.763+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(456) > pid(2661) status(5)
03-04 03:13:14.763+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(468) > pid(2661) appid(org.example.tichat) pkgid(org.example.tichat) status(5)
03-04 03:13:14.763+0900 D/AUL     (  821): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.tichat
03-04 03:13:14.763+0900 W/AUL     (  821): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 2661, appid: org.example.tichat, status: bg
03-04 03:13:14.763+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 2661, appname = org.example.tichat, pkgname = org.example.tichat
03-04 03:13:14.763+0900 D/RESOURCED(  872): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 2661, appname = org.example.tichat
03-04 03:13:14.763+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2661
03-04 03:13:14.763+0900 D/RESOURCED(  872): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2661, proc_name: org.example.tichat, cg_name: previous, oom_score_adj: 300
03-04 03:13:14.763+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2661
03-04 03:13:14.783+0900 D/APP_CORE( 2661): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
03-04 03:13:14.783+0900 D/APP_CORE( 2661): appcore-efl.c: __after_loop(1169) > [APP 2661] PAUSE before termination
03-04 03:13:14.783+0900 I/CAPI_APPFW_APPLICATION( 2661): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
03-04 03:13:14.783+0900 I/CAPI_APPFW_APPLICATION( 2661): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
03-04 03:13:14.783+0900 E/EFL     ( 2661): eo<2661> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80054ca8 is not pointing to a valid object. Maybe it has already been freed.
03-04 03:13:14.783+0900 E/EFL     ( 2661): eo<2661> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80054ca8) is an invalid ref.
03-04 03:13:14.783+0900 E/EFL     (  535): eo<535> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-04 03:13:14.783+0900 D/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2887) > pid(934) status(3)
03-04 03:13:14.783+0900 D/AUL_AMD (  821): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
03-04 03:13:14.793+0900 W/AUL_AMD (  821): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-04 03:13:14.793+0900 W/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2891) > back key ungrab error
03-04 03:13:14.793+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(456) > pid(934) status(3)
03-04 03:13:14.793+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(468) > pid(934) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
03-04 03:13:14.793+0900 D/AUL     (  821): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
03-04 03:13:14.793+0900 W/AUL     (  821): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 934, appid: org.tizen.homescreen, status: fg
03-04 03:13:14.803+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
03-04 03:13:14.823+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200002), visible:1
03-04 03:13:14.833+0900 D/RESOURCED(  872): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 934
03-04 03:13:14.833+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 934, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
03-04 03:13:14.833+0900 D/INDICATOR(  907): main.c: _property_changed_cb(432) > UNSNIFF API 1200002
03-04 03:13:14.833+0900 D/RESOURCED(  872): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 934, appname = org.tizen.homescreen
03-04 03:13:14.833+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 934
03-04 03:13:14.833+0900 D/INDICATOR(  907): util.c: util_signal_emit_by_win(116) > emission bg.translucent
03-04 03:13:14.833+0900 E/RESOURCED(  872): freezer-process.c: freezer_process_pid_set(160) > freezer_process_pid_set 934 foreground
03-04 03:13:14.833+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x1270570), gem(19), surface(0x1329330)
03-04 03:13:14.833+0900 D/INDICATOR(  907): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-04 03:13:14.833+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 1
03-04 03:13:14.833+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
03-04 03:13:14.833+0900 D/INDICATOR(  907): main.c: _rotate_window(252) > port :: hide more icon
03-04 03:13:14.923+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x136af48), gem(21), surface(0x13fce88)
03-04 03:13:14.923+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x136af48), gem(21), surface(0x1263390)
03-04 03:13:14.923+0900 W/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=934
03-04 03:13:14.923+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 0
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-04 03:13:14.943+0900 I/APP_CORE(  934): appcore-efl.c: __do_app(496) > [APP 934] Event: RESUME State: PAUSED
03-04 03:13:14.943+0900 D/LAUNCH  (  934): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __do_app(607) > [APP 934] RESUME
03-04 03:13:14.943+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-04 03:13:14.943+0900 E/cluster-home(  934): homescreen.cpp: OnResume(66) >  app resume
03-04 03:13:14.943+0900 D/cluster-home(  934): widget-data-provider.cpp: SetBoxVisibility(1543) >  
03-04 03:13:14.943+0900 D/cluster-home(  934): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
03-04 03:13:14.943+0900 D/cluster-home(  934): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[1]
03-04 03:13:14.943+0900 D/cluster-view(  934): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
03-04 03:13:14.943+0900 D/cluster-view(  934): homescreen-view-manager.cpp: AppResume(910) >  END
03-04 03:13:14.943+0900 D/cluster-view(  934): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
03-04 03:13:14.943+0900 D/cluster-view(  934): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
03-04 03:13:14.943+0900 D/cluster-view(  934): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
03-04 03:13:14.943+0900 D/cluster-view(  934): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
03-04 03:13:14.943+0900 E/EFL     (  535): eo<535> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-04 03:13:14.943+0900 D/cluster-view(  934): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
03-04 03:13:14.943+0900 D/cluster-view(  934): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
03-04 03:13:14.943+0900 D/test-log(  934): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
03-04 03:13:14.943+0900 D/test-log(  934): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
03-04 03:13:14.943+0900 D/cluster-view(  934): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
03-04 03:13:14.943+0900 D/cluster-home(  934): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
03-04 03:13:14.943+0900 D/LAUNCH  (  934): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
03-04 03:13:14.943+0900 D/LAUNCH  (  934): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
03-04 03:13:14.943+0900 D/APP_CORE(  934): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-04 03:13:14.943+0900 E/APP_CORE(  934): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-04 03:13:14.953+0900 D/DATA_PROVIDER_MASTER( 1015): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 934 is resumed
03-04 03:13:14.953+0900 D/DATA_PROVIDER_MASTER( 1015): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-04 03:13:14.953+0900 E/DATA_PROVIDER_MASTER( 1015): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
03-04 03:13:14.963+0900 I/TIZEN_N_SOUND_MANAGER( 1016): sound_manager.c: sound_manager_get_volume(77) > returns : type=0, volume=9, ret=0x0
03-04 03:13:14.963+0900 E/TIZEN_N_SOUND_MANAGER( 1016): sound_manager_private.c: __convert_sound_manager_error_code(70) > [sound_manager_get_volume(79)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-04 03:13:14.963+0900 I/TIZEN_N_SOUND_MANAGER( 1016): sound_manager.c: sound_manager_get_volume(77) > returns : type=4, volume=0, ret=0x0
03-04 03:13:14.973+0900 E/TIZEN_N_SOUND_MANAGER( 1016): sound_manager_private.c: __convert_sound_manager_error_code(70) > [sound_manager_get_volume(79)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-04 03:13:14.973+0900 D/AUL_AMD (  821): amd_request.c: __request_handler(838) > __request_handler: 15
03-04 03:13:14.973+0900 D/PKGMGR_INFO(  821): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-04 03:13:14.973+0900 D/PKGMGR_INFO(  821): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-04 03:13:14.983+0900 D/AUL_AMD (  821): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 934 is org.tizen.homescreen
03-04 03:13:14.983+0900 D/AUL     ( 1016): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
03-04 03:13:14.983+0900 D/AUL_AMD (  821): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 934 : 0
03-04 03:13:15.053+0900 W/CRASH_MANAGER( 2941): worker.c: worker_job(1204) > 1102661746963142540639
