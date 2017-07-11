S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 6322
Date: 2016-10-27 04:11:38+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8b88a68, esi = 0xbfc10ab0
ebp = 0xbfc10bb8, esp = 0xbfc10aac
eax = 0xb350f362, ebx = 0xb351240c
ecx = 0x00000000, edx = 0x00000000
eip = 0xb6d4ac0b

Memory Information
MemTotal:      250 KB
MemFree:       144 KB
Buffers:         4 KB
Cached:     174244 KB
VmPeak:     121012 KB
VmSize:     121012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32840 KB
VmRSS:       32840 KB
VmData:      50792 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6322 TID = 6322
6322 6324 6552 6553 6557 

Maps Information
b2aa1000 b2aa8000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2aa9000 b2ac1000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2ac2000 b2ac9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b46000 b2b50000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b56000 b2b62000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b63000 b2b84000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b89000 b2b8a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b8b000 b2b90000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b91000 b2b92000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b93000 b2b95000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b96000 b2b98000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b99000 b2ba5000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba6000 b2ba9000 r-xp /usr/lib/libdri2.so.0.0.0
b2baa000 b2bb4000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb5000 b2bb6000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2bb7000 b2bcc000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bcd000 b2bdf000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33e1000 b3412000 r-xp /usr/lib/libidn.so.11.5.44
b3413000 b3435000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3436000 b3446000 r-xp /usr/lib/libcares.so.2.1.0
b3447000 b3467000 r-xp /usr/lib/libnetwork.so.0.0.0
b3468000 b3471000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3472000 b34e9000 r-xp /usr/lib/libcurl.so.4.3.0
b34eb000 b34ff000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b3500000 b3512000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b361a000 b3620000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3621000 b3765000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b377b000 b377c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b377d000 b377e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b377f000 b3782000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3783000 b3786000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3787000 b37c0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c3000 b41ce000 r-xp /lib/libnss_files-2.20-2014.11.so
b41d0000 b41db000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41dd000 b41f4000 r-xp /lib/libnsl-2.20-2014.11.so
b41f8000 b4200000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4202000 b4226000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4227000 b4228000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4229000 b422c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b422d000 b4234000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4235000 b423f000 r-xp /usr/lib/libsensord-share.so
b4240000 b425c000 r-xp /usr/lib/libsensor.so.1.2.0
b425e000 b4267000 r-xp /usr/lib/libappcore-common.so.1.1
b426a000 b426c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4281000 b4283000 r-xp /usr/lib/libXau.so.6.0.0
b4284000 b42a6000 r-xp /usr/lib/libxcb.so.1.1.0
b42a8000 b42b1000 r-xp /lib/libcrypt-2.20-2014.11.so
b42da000 b42dc000 r-xp /usr/lib/libiri.so
b42dd000 b4303000 r-xp /lib/libexpat.so.1.5.2
b4305000 b4370000 r-xp /usr/lib/libssl.so.1.0.0
b4376000 b4382000 r-xp /usr/lib/libethumb.so.1.13.0
b4383000 b4387000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4388000 b45d9000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b54000 b5b64000 r-xp /usr/lib/libXi.so.6.1.0
b5b65000 b5b67000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b68000 b5b6e000 r-xp /usr/lib/libXtst.so.6.1.0
b5b6f000 b5b79000 r-xp /usr/lib/libXrender.so.1.3.0
b5b7a000 b5b83000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b85000 b5b87000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b88000 b5b8d000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b8e000 b5ba0000 r-xp /usr/lib/libXext.so.6.4.0
b5ba1000 b5ba3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba4000 b5ba6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5ba8000 b5cea000 r-xp /usr/lib/libX11.so.6.3.0
b5cee000 b5cf8000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cf9000 b5d0f000 r-xp /usr/lib/libudev.so.1.6.0
b5d12000 b5d16000 r-xp /lib/libattr.so.1.1.0
b5d17000 b5d46000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d48000 b5d4e000 r-xp /usr/lib/libffi.so.6.0.2
b5d4f000 b5d72000 r-xp /lib/libz.so.1.2.8
b5d73000 b5d76000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d77000 b5ed3000 r-xp /usr/lib/libxml2.so.2.9.2
b5ed9000 b5fc0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fcd000 b5fd0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd1000 b5ff3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff4000 b6008000 r-xp /lib/libresolv-2.20-2014.11.so
b600c000 b6030000 r-xp /usr/lib/liblzma.so.5.0.3
b6031000 b6033000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6035000 b603f000 r-xp /usr/lib/libembryo.so.1.13.0
b6040000 b6069000 r-xp /usr/lib/libpng12.so.0.50.0
b606a000 b60b3000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c4000 b60cb000 r-xp /lib/librt-2.20-2014.11.so
b60cd000 b60ec000 r-xp /usr/lib/libector.so.1.13.0
b60ef000 b611c000 r-xp /usr/lib/liblua-5.1.so
b611d000 b61ad000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b1000 b61ef000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61f0000 b6206000 r-xp /usr/lib/libfribidi.so.0.3.1
b6207000 b6260000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6263000 b62ae000 r-xp /lib/libm-2.20-2014.11.so
b62b0000 b62c2000 r-xp /usr/lib/libeio.so.1.13.0
b62c3000 b62c6000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62c7000 b62cd000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62ce000 b62f1000 r-xp /usr/lib/libefreet.so.1.13.0
b62f4000 b631f000 r-xp /usr/lib/libeldbus.so.1.13.0
b6320000 b6354000 r-xp /usr/lib/libecore_con.so.1.13.0
b6356000 b635f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6360000 b6369000 r-xp /usr/lib/libethumb_client.so.1.13.0
b636a000 b637d000 r-xp /usr/lib/libeo.so.1.13.0
b637f000 b6392000 r-xp /usr/lib/libecore_input.so.1.13.0
b6393000 b639a000 r-xp /usr/lib/libecore_file.so.1.13.0
b639b000 b63be000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63bf000 b63eb000 r-xp /usr/lib/libeet.so.1.13.0
b63f4000 b645f000 r-xp /usr/lib/libeina.so.1.13.0
b6462000 b6479000 r-xp /usr/lib/libefl.so.1.13.0
b647b000 b65e2000 r-xp /usr/lib/libicuuc.so.51.1
b65f0000 b67fc000 r-xp /usr/lib/libicui18n.so.51.1
b6804000 b6853000 r-xp /usr/lib/libecore_x.so.1.13.0
b6855000 b686f000 r-xp /lib/libgcc_s-4.9.so.1
b6871000 b6875000 r-xp /lib/libcap.so.2.21
b6876000 b68bc000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68bd000 b68c4000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c6000 b6918000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b691a000 b6aa5000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aaa000 b6b78000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b7b000 b6b7f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b80000 b6b8f000 r-xp /usr/lib/libvconf.so.0.2.45
b6b90000 b6b93000 r-xp /usr/lib/libvasum.so.0.3.1
b6b94000 b6b97000 r-xp /usr/lib/libttrace.so.1.1
b6b99000 b6b9d000 r-xp /usr/lib/libiniparser.so.0
b6b9e000 b6bce000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bcf000 b6bd8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd9000 b6bfe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bff000 b6c0f000 r-xp /usr/lib/libunwind.so.8.0.1
b6c19000 b6dc7000 r-xp /lib/libc-2.20-2014.11.so
b6dcf000 b6f12000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f14000 b6f6c000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f6d000 b6fa1000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa4000 b7078000 r-xp /usr/lib/libedje.so.1.13.0
b707b000 b70a7000 r-xp /usr/lib/libecore.so.1.13.0
b70b8000 b72de000 r-xp /usr/lib/libevas.so.1.13.0
b7306000 b731e000 r-xp /lib/libpthread-2.20-2014.11.so
b7322000 b769c000 r-xp /usr/lib/libelementary.so.1.13.0
b76bc000 b76c0000 r-xp /usr/lib/libsmack.so.1.0.0
b76c1000 b76ca000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76cb000 b76ce000 r-xp /usr/lib/libdlog.so.0.0.0
b76cf000 b76d4000 r-xp /usr/lib/libbundle.so.0.1.22
b76d5000 b76d8000 r-xp /lib/libdl-2.20-2014.11.so
b76da000 b76ff000 r-xp /usr/lib/libaul.so.0.1.0
b7702000 b7704000 r-xp /usr/lib/libappsvc.so.0.1.0
b7705000 b770a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b770b000 b7712000 r-xp /usr/lib/libappcore-efl.so.1.1
b7714000 b7719000 r-xp /usr/lib/libsys-assert.so
b771c000 b771d000 r-xp [vdso]
b771d000 b773f000 r-xp /lib/ld-2.20-2014.11.so
b7741000 b7749000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6322)
Call Stack Count: 22
 0: (0xb6d4ac0b) [/lib/libc.so.6] + 0x131c0b
 1: create_popup_button_create_clicked_cb + 0x5d3 (0xb350afc3) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xafc3
 2: (0xb7141116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb6378319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb6375d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb71439e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb73f4404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb7027f39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb702ea11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb7028fdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb70294cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb702968f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb708e702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb7088055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70911b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb7091587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb74ea22d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb770edde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb7707c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x278 (0xb350cf88) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xcf88
20: (0xb7743148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7743148
21: __libc_start_main + 0xde (0xb6c30e4e) [/lib/libc.so.6] + 0x17e4e
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
o ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-27 04:11:20.839+0900 I/AUL     ( 2728): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-27 04:11:20.839+0900 D/AUL     ( 2728): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 6546, pid = 6548
10-27 04:11:20.839+0900 D/PKGMGR_INFO( 2728): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-27 04:11:20.839+0900 D/PKGMGR_INFO( 2728): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-27 04:11:20.839+0900 I/AUL     ( 2728): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-27 04:11:20.839+0900 E/AUL_AMD ( 2728): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-27 04:11:20.839+0900 W/AUL_AMD ( 2728): amd_launch.c: _start_app(2233) > caller pid : 6548
10-27 04:11:20.839+0900 E/AUL_AMD ( 2728): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-27 04:11:20.839+0900 W/AUL_AMD ( 2728): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-27 04:11:20.839+0900 D/AUL_AMD ( 2728): amd_launch.c: _start_app(2648) > process_pool: false
10-27 04:11:20.839+0900 D/AUL_AMD ( 2728): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-27 04:11:20.839+0900 D/AUL_AMD ( 2728): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-27 04:11:20.839+0900 W/AUL_AMD ( 2728): amd_launch.c: _start_app(2665) > pad pid(-5)
10-27 04:11:20.839+0900 D/AUL_AMD ( 2728): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-27 04:11:20.839+0900 D/AUL_AMD ( 2728): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-27 04:11:20.839+0900 D/AUL     ( 2728): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-27 04:11:20.839+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-27 04:11:20.839+0900 D/RESOURCED( 2835): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-27 04:11:20.839+0900 E/RESOURCED( 2835): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-27 04:11:20.839+0900 W/AUL_PAD ( 2904): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-27 04:11:20.839+0900 D/AUL     ( 2904): process_pool.c: __send_pkt_raw_data(219) > send(12) : 616 / 616
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6322, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-27 04:11:20.839+0900 W/AUL_PAD ( 2904): launchpad.c: __send_result_to_caller(265) > Check app launching
10-27 04:11:20.839+0900 D/AUL_PAD ( 2904): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-27 04:11:20.839+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-27 04:11:20.839+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-27 04:11:20.839+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-27 04:11:20.839+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-27 04:11:20.839+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-27 04:11:20.839+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-27 04:11:20.839+0900 D/AUL     ( 6322): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6324) is sent.
10-27 04:11:20.839+0900 D/AUL     ( 6322): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6324, signo: 10
10-27 04:11:20.849+0900 D/AUL     ( 6322): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0Nzc1MDkwODAvODQzNzgwAA==##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA2NTQ4AA==##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-27 04:11:20.849+0900 D/AUL_PAD ( 6322): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-27 04:11:20.849+0900 I/CAPI_APPFW_APPLICATION( 6322): app_main.c: ui_app_main(788) > app_efl_main
10-27 04:11:20.849+0900 D/LAUNCH  ( 6322): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-27 04:11:20.849+0900 D/APP_CORE( 6322): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-27 04:11:20.849+0900 D/APP_CORE( 6322): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-27 04:11:20.849+0900 D/APP_CORE( 6322): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-27 04:11:20.849+0900 D/APP_CORE( 6322): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-27 04:11:20.849+0900 D/AUL     ( 6322): app_sock.c: __create_server_sock(156) > pg path - already exists
10-27 04:11:20.849+0900 D/APP_CORE( 6322): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4267520
10-27 04:11:20.849+0900 D/LAUNCH  ( 6322): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-27 04:11:20.849+0900 I/CAPI_APPFW_APPLICATION( 6322): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-27 04:11:20.879+0900 D/IMMODULE( 6322): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-27 04:11:20.879+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(515) > ppid:2904  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-27 04:11:20.879+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(524) > connect() succeeded
10-27 04:11:20.889+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(515) > ppid:2904  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-27 04:11:20.889+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(524) > connect() succeeded
10-27 04:11:20.889+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(515) > ppid:2904  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-27 04:11:20.889+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(524) > connect() succeeded
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_QUERY( 6322): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-27 04:11:20.889+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(515) > ppid:2904  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-27 04:11:20.889+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(524) > connect() succeeded
10-27 04:11:20.899+0900 D/IMMODULE( 6322): scim_panel_client.cpp: open_connection(162) > 
10-27 04:11:20.899+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(515) > ppid:2904  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-27 04:11:20.899+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(524) > connect() succeeded
10-27 04:11:20.899+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(515) > ppid:2904  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-27 04:11:20.899+0900 D/ISF_SOCKET( 6322): scim_socket.cpp: connect(524) > connect() succeeded
10-27 04:11:20.899+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-27 04:11:20.919+0900 D/LAUNCH  ( 6322): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-27 04:11:20.919+0900 D/APP_CORE( 6322): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-27 04:11:20.919+0900 E/E17     ( 2764): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
10-27 04:11:20.929+0900 E/E17     ( 2764): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
10-27 04:11:20.929+0900 D/APP_CORE( 6322): appcore.c: __aul_handler(587) > [APP 6322]     AUL event: AUL_START
10-27 04:11:20.929+0900 I/APP_CORE( 6322): appcore-efl.c: __do_app(496) > [APP 6322] Event: RESET State: CREATED
10-27 04:11:20.929+0900 D/APP_CORE( 6322): appcore-efl.c: __do_app(527) > [APP 6322] RESET
10-27 04:11:20.929+0900 D/LAUNCH  ( 6322): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-27 04:11:20.929+0900 D/APP_CORE( 6322): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-27 04:11:20.929+0900 D/APP_CORE( 6322): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-27 04:11:20.929+0900 I/CAPI_APPFW_APPLICATION( 6322): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-27 04:11:20.929+0900 D/AUL     ( 6322): service.c: __set_bundle(186) > __set_bundle
10-27 04:11:20.929+0900 D/LAUNCH  ( 6322): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-27 04:11:20.929+0900 D/APP_CORE( 6322): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-27 04:11:20.929+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-27 04:11:20.929+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:20.939+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-27 04:11:20.939+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:20.939+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-27 04:11:20.939+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:20.939+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-27 04:11:20.939+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:20.939+0900 W/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6322
10-27 04:11:20.939+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-27 04:11:20.939+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:20.939+0900 E/EFL     ( 2764): eo<2764> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-27 04:11:20.939+0900 E/EFL     ( 2764): eo<2764> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-27 04:11:20.939+0900 D/INDICATOR( 2838): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-27 04:11:20.939+0900 D/INDICATOR( 2838): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-27 04:11:20.939+0900 D/INDICATOR( 2838): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-27 04:11:20.939+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-27 04:11:20.939+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-27 04:11:20.939+0900 D/INDICATOR( 2838): main.c: _rotate_window(252) > port :: hide more icon
10-27 04:11:20.949+0900 W/APP_CORE( 6322): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
10-27 04:11:20.949+0900 D/APP_CORE( 6322): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
10-27 04:11:20.949+0900 D/APP_CORE( 6322): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-27 04:11:20.949+0900 D/AUL     ( 6322): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-27 04:11:20.949+0900 D/AUL_PAD ( 2904): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-27 04:11:20.949+0900 W/AUL     ( 2728): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6322, appid: org.example.tichat
10-27 04:11:20.949+0900 D/AUL     ( 2728): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-27 04:11:20.949+0900 E/AUL     ( 2728): simple_util.c: __trm_app_info_send_socket(330) > access
10-27 04:11:20.949+0900 D/AUL_AMD ( 2728): amd_launch.c: _start_app(2700) > add app group info
10-27 04:11:20.949+0900 E/AUL     ( 2728): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-27 04:11:20.949+0900 D/AUL_AMD ( 2728): amd_status.c: _status_add_app_info_list(427) > pid(6322) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-27 04:11:20.949+0900 D/AUL_AMD ( 2728): amd_request.c: __request_handler(838) > __request_handler: 15
10-27 04:11:20.949+0900 D/PKGMGR_INFO( 2728): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-27 04:11:20.949+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 6322
10-27 04:11:20.949+0900 D/PKGMGR_INFO( 2728): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-27 04:11:20.949+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-27 04:11:20.949+0900 E/RESOURCED( 2835): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-27 04:11:20.949+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(888) > available memory = 766
10-27 04:11:20.949+0900 D/AUL_AMD ( 2728): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6322 is org.example.tichat
10-27 04:11:20.949+0900 D/AUL_AMD ( 2728): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6322 : 0
10-27 04:11:20.949+0900 D/AUL     ( 2914): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-27 04:11:20.949+0900 D/AUL_AMD ( 2728): amd_request.c: __request_handler(838) > __request_handler: 34
10-27 04:11:20.999+0900 E/PKGMGR_SERVER( 6493): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-27 04:11:20.999+0900 E/PKGMGR_SERVER( 6493): pkgmgr-server.c: main(2265) > package manager server terminated.
10-27 04:11:21.139+0900 D/APP_CORE( 6322): appcore.c: __prt_ltime(236) > [APP 6322] first idle after reset: 306 msec
10-27 04:11:21.279+0900 E/E17     ( 2764): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-27 04:11:21.279+0900 I/APP_CORE( 6322): appcore-efl.c: __do_app(496) > [APP 6322] Event: RESUME State: CREATED
10-27 04:11:21.279+0900 D/LAUNCH  ( 6322): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __do_app(607) > [APP 6322] RESUME
10-27 04:11:21.279+0900 I/APP_CORE( 6322): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-27 04:11:21.279+0900 I/APP_CORE( 6322): appcore-efl.c: __do_app(614) > [APP 6322] Initial Launching, call the resume_cb
10-27 04:11:21.279+0900 I/CAPI_APPFW_APPLICATION( 6322): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-27 04:11:21.279+0900 D/LAUNCH  ( 6322): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-27 04:11:21.279+0900 D/LAUNCH  ( 6322): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-27 04:11:21.279+0900 D/APP_CORE( 6322): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-27 04:11:21.279+0900 E/APP_CORE( 6322): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-27 04:11:21.279+0900 D/APP_CORE( 2848): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-27 04:11:21.279+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-27 04:11:21.279+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-27 04:11:21.279+0900 I/APP_CORE( 2848): appcore-efl.c: __do_app(496) > [APP 2848] Event: PAUSE State: RUNNING
10-27 04:11:21.279+0900 D/APP_CORE( 2848): appcore-efl.c: __do_app(565) > [APP 2848] PAUSE
10-27 04:11:21.279+0900 I/CAPI_APPFW_APPLICATION( 2848): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-27 04:11:21.279+0900 E/cluster-home( 2848): homescreen.cpp: OnPause(84) >  app pause
10-27 04:11:21.279+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-27 04:11:21.279+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppPause(923) >  END
10-27 04:11:21.279+0900 D/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-27 04:11:21.279+0900 E/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-27 04:11:21.289+0900 D/AUL_AMD ( 2728): amd_status.c: _status_update_app_info_list(456) > pid(2848) status(4)
10-27 04:11:21.289+0900 D/AUL_AMD ( 2728): amd_status.c: _status_update_app_info_list(468) > pid(2848) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-27 04:11:21.289+0900 D/AUL     ( 2728): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-27 04:11:21.289+0900 W/AUL     ( 2728): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2848, appid: org.tizen.homescreen, status: bg
10-27 04:11:21.289+0900 D/AUL_AMD ( 2728): amd_launch.c: __e17_status_handler(2891) > pid(6322) status(3)
10-27 04:11:21.289+0900 D/AUL_AMD ( 2728): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-27 04:11:21.289+0900 W/AUL_AMD ( 2728): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-27 04:11:21.289+0900 W/AUL_AMD ( 2728): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-27 04:11:21.289+0900 D/AUL_AMD ( 2728): amd_status.c: _status_update_app_info_list(456) > pid(6322) status(3)
10-27 04:11:21.289+0900 D/AUL_AMD ( 2728): amd_status.c: _status_update_app_info_list(468) > pid(6322) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-27 04:11:21.289+0900 D/AUL     ( 2728): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-27 04:11:21.289+0900 W/AUL     ( 2728): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6322, appid: org.example.tichat, status: fg
10-27 04:11:21.289+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6322
10-27 04:11:21.289+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6322, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-27 04:11:21.289+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6322
10-27 04:11:21.299+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2848 is paused
10-27 04:11:21.299+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-27 04:11:21.299+0900 I/CAPI_WIDGET_APPLICATION( 2992): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-27 04:11:21.299+0900 I/CAPI_WIDGET_APPLICATION( 2992): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-27 04:11:21.299+0900 W/AUL     ( 2992): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2992, appid: org.tizen.calendar.widget, status: bg
10-27 04:11:21.329+0900 D/AUL_AMD ( 2728): amd_launch.c: __e17_status_handler(2910) > pid(6322) status(0)
10-27 04:11:21.339+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6322, appname = org.example.tichat, pkgname = org.example.tichat
10-27 04:11:21.339+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6322, appname = org.example.tichat
10-27 04:11:21.339+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6322
10-27 04:11:21.339+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2992, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-27 04:11:21.339+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2992
10-27 04:11:21.339+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2992, appname = org.tizen.calendar.widget
10-27 04:11:21.339+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2992
10-27 04:11:21.339+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-27 04:11:21.339+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-27 04:11:21.949+0900 D/AUL_PAD ( 2904): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-27 04:11:21.949+0900 D/AUL_PAD ( 6556): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-27 04:11:21.949+0900 D/AUL_PAD ( 2904): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-27 04:11:21.949+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.406
10-27 04:11:22.449+0900 D/AUL_AMD ( 2728): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-27 04:11:22.449+0900 D/RUA     ( 2728): rua.c: rua_add_history(179) > rua_add_history start
10-27 04:11:22.449+0900 D/RUA     ( 2728): rua.c: rua_add_history(247) > rua_add_history ok
10-27 04:11:22.969+0900 D/AUL_PAD ( 6556): launchpad_loader.c: main(588) > sleeping 1 sec...
10-27 04:11:22.969+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-27 04:11:22.969+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7e83760
10-27 04:11:22.969+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(69) > get pre-initialization function
10-27 04:11:22.969+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(73) > get shutdown function
10-27 04:11:22.969+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7e83a40
10-27 04:11:22.979+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:22.979+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7e85640
10-27 04:11:22.979+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(69) > get pre-initialization function
10-27 04:11:22.979+0900 D/AUL_PAD ( 6556): preload.h: __preload_init(73) > get shutdown function
10-27 04:11:22.979+0900 D/AUL_PAD ( 6556): preexec.h: __preexec_init(76) > preexec start
10-27 04:11:22.979+0900 D/AUL_PAD ( 6556): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-27 04:11:22.979+0900 D/AUL     ( 6556): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-27 04:11:22.979+0900 D/AUL     ( 6556): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-27 04:11:22.979+0900 D/AUL     ( 6556): process_pool.c: __connect_to_launchpad(132) > send(6556) : 4
10-27 04:11:22.979+0900 D/AUL     ( 6556): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-27 04:11:22.979+0900 D/AUL_PAD ( 2904): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6556
10-27 04:11:22.979+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8a76360. set autocapital type : 2
10-27 04:11:22.979+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.407
10-27 04:11:22.979+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8a76360. on demand : 0
10-27 04:11:22.979+0900 D/ISE_DEFAULT( 3105): ise.cpp: on_focus_in(245) > Enter
10-27 04:11:22.979+0900 D/ISE_DEFAULT( 3105): ise.cpp: ise_focus_in(824) > ic : 18b20027 , 0 , g_ic : d140028 , 0, g_focused_ic : 0 , 1
10-27 04:11:22.979+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-27 04:11:22.979+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 0
10-27 04:11:22.989+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8a76360
10-27 04:11:22.989+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-27 04:11:23.089+0900 D/AUL_PAD ( 6556): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-27 04:11:23.099+0900 D/AUL_PAD ( 6556): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-27 04:11:23.099+0900 D/AUL_PAD ( 6556): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-27 04:11:23.099+0900 D/AUL_PAD ( 6556): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-27 04:11:23.439+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 1
10-27 04:11:23.439+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8a76360, bidi direction : 0x1
10-27 04:11:23.629+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 2
10-27 04:11:23.659+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 3
10-27 04:11:23.809+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 4
10-27 04:11:23.979+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2e00002
10-27 04:11:24.059+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 5
10-27 04:11:24.269+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 6
10-27 04:11:24.459+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 7
10-27 04:11:24.519+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a76360, cursor pos : 8
10-27 04:11:24.639+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8a76360
10-27 04:11:24.639+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-27 04:11:24.639+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8a76360
10-27 04:11:24.649+0900 D/ISE_DEFAULT( 3105): ise.cpp: on_focus_out(251) > Enter
10-27 04:11:24.649+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8ab8138. set autocapital type : 0
10-27 04:11:24.649+0900 D/ISE_DEFAULT( 3105): ise.cpp: on_focus_in(245) > Enter
10-27 04:11:24.649+0900 D/ISE_DEFAULT( 3105): ise.cpp: ise_focus_in(824) > ic : 18b30027 , 0 , g_ic : d140028 , 0, g_focused_ic : 0 , 1
10-27 04:11:24.649+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8ab8138. on demand : 0
10-27 04:11:24.649+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-27 04:11:24.649+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 0
10-27 04:11:24.859+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 1
10-27 04:11:24.859+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8ab8138, bidi direction : 0x1
10-27 04:11:24.979+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 2
10-27 04:11:25.139+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 3
10-27 04:11:25.229+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 4
10-27 04:11:25.319+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 5
10-27 04:11:25.439+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 6
10-27 04:11:25.559+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 7
10-27 04:11:25.649+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 8
10-27 04:11:25.779+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8ab8138, cursor pos : 9
10-27 04:11:26.289+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-27 04:11:26.289+0900 I/APP_CORE( 2848): appcore-efl.c: __do_app(496) > [APP 2848] Event: MEM_FLUSH State: PAUSED
10-27 04:11:26.289+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-27 04:11:26.289+0900 D/APP_CORE( 2848): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2848
10-27 04:11:26.289+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-27 04:11:26.289+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2848
10-27 04:11:26.639+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:26.899+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8ab8138
10-27 04:11:26.899+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-27 04:11:26.899+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8ab8138
10-27 04:11:26.899+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-27 04:11:26.899+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:26.899+0900 D/ISE_DEFAULT( 3105): ise.cpp: on_focus_out(251) > Enter
10-27 04:11:26.909+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:27.029+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_create(408) > New handle created[0xb8abf3c0]
10-27 04:11:27.029+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_get_type(464) > Connected Network = 3
10-27 04:11:27.029+0900 I/tichat  ( 6322): Network connection type : 3
10-27 04:11:27.109+0900 E/CAPI_NETWORK_WIFI( 2838): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-27 04:11:27.109+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-27 04:11:27.109+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-27 04:11:27.109+0900 E/INDICATOR( 2838): 
10-27 04:11:27.689+0900 I/tichat  ( 6322): CURL Returned: 
10-27 04:11:27.689+0900 I/tichat  ( 6322): {"message":"로그인 성공"}
10-27 04:11:27.689+0900 I/tichat  ( 6322): Parsed JSON: "로그인 성공"
10-27 04:11:27.699+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_destroy(426) > Destroy handle: 0xb8abf3c0
10-27 04:11:27.709+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-27 04:11:27.709+0900 D/ISF_PANEL_EFL( 3026): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 40 36
10-27 04:11:28.979+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x601416 bd->visible=1
10-27 04:11:29.009+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:29.179+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_create(408) > New handle created[0xb8bca238]
10-27 04:11:29.179+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_get_type(464) > Connected Network = 3
10-27 04:11:29.179+0900 I/tichat  ( 6322): Network connection type : 3
10-27 04:11:29.819+0900 I/tichat  ( 6322): CURL Returned: 
10-27 04:11:29.819+0900 I/tichat  ( 6322): {"message":"방이 존재하지 않습니다."}
10-27 04:11:29.819+0900 I/tichat  ( 6322): Parsed JSON: "방이 존재하지 않습니다."
10-27 04:11:32.239+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:33.689+0900 E/EFL     ( 6322): edje<6322> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-27 04:11:33.689+0900 E/EFL     ( 6322): By the power of Grayskull, your previous Embryo stack is now broken!
10-27 04:11:33.699+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:35.379+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:35.379+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8b89230. set autocapital type : 2
10-27 04:11:35.389+0900 D/ISE_DEFAULT( 3105): ise.cpp: on_focus_in(245) > Enter
10-27 04:11:35.389+0900 D/ISE_DEFAULT( 3105): ise.cpp: ise_focus_in(824) > ic : 18b40027 , 0 , g_ic : d140028 , 0, g_focused_ic : 0 , 1
10-27 04:11:35.389+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8b89230. on demand : 0
10-27 04:11:35.389+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-27 04:11:35.389+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 0
10-27 04:11:35.389+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8b89230
10-27 04:11:35.389+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-27 04:11:36.179+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 1
10-27 04:11:36.179+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8b89230, bidi direction : 0x1
10-27 04:11:36.519+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 0
10-27 04:11:36.519+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8b89230, bidi direction : 0
10-27 04:11:36.729+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 1
10-27 04:11:36.729+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8b89230, bidi direction : 0x1
10-27 04:11:36.829+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 2
10-27 04:11:36.959+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 3
10-27 04:11:37.099+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 4
10-27 04:11:37.279+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8b89230, cursor pos : 5
10-27 04:11:38.269+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601416 
10-27 04:11:38.299+0900 D/IMMODULE( 6322): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8b89230
10-27 04:11:38.299+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-27 04:11:38.299+0900 D/IMMODULE( 6322): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8b89230
10-27 04:11:38.299+0900 D/ISE_DEFAULT( 3105): ise.cpp: on_focus_out(251) > Enter
10-27 04:11:38.429+0900 I/tichat  ( 6322): title : hello id : park3745
10-27 04:11:38.429+0900 E/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_create(392) > Invalid parameter
10-27 04:11:38.429+0900 I/tichat  ( 6322): Connection Failed!!!!!!!!!!!!
10-27 04:11:38.429+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_get_type(464) > Connected Network = 3
10-27 04:11:38.429+0900 I/tichat  ( 6322): Network connection type : 3
10-27 04:11:38.559+0900 I/tichat  ( 6322): CURL Returned: 
10-27 04:11:38.559+0900 I/tichat  ( 6322): {"message":"방 만들기 성공"}
10-27 04:11:38.559+0900 I/tichat  ( 6322): Parsed JSON: "방 만들기 성공"
10-27 04:11:38.559+0900 E/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_create(392) > Invalid parameter
10-27 04:11:38.559+0900 I/tichat  ( 6322): Connection Failed!!!!!!!!!!!!
10-27 04:11:38.559+0900 I/CAPI_NETWORK_CONNECTION( 6322): connection.c: connection_get_type(464) > Connected Network = 3
10-27 04:11:38.559+0900 I/tichat  ( 6322): Network connection type : 3
10-27 04:11:38.699+0900 I/tichat  ( 6322): CURL Returned: 
10-27 04:11:38.699+0900 I/tichat  ( 6322): [{"id":1,"title":"hello","createdAt":"2016-10-26T19:11:40.857Z","updatedAt":"2016-10-26T19:11:40.857Z"}]
10-27 04:11:38.699+0900 I/tichat  ( 6322): Parsed JSON: (null)
10-27 04:11:38.739+0900 W/CRASH_MANAGER( 6559): worker.c: worker_job(1204) > 1106322746963147750909
