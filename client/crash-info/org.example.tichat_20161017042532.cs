S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 5877
Date: 2016-10-17 04:25:32+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7da1060, esi = 0xb37cbbde
ebp = 0xbfe37d48, esp = 0xbfe37d20
eax = 0xb37cd15c, ebx = 0xb37cd15c
ecx = 0x00000000, edx = 0x00000000
eip = 0xb37c3b12

Memory Information
MemTotal:      250 KB
MemFree:       150 KB
Buffers:         4 KB
Cached:     165312 KB
VmPeak:     117960 KB
VmSize:     112060 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31472 KB
VmRSS:       25460 KB
VmData:      43584 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34584 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5877 TID = 5877
5877 5878 6062 6063 6068 

Maps Information
b2aee000 b2af5000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2af6000 b2b0e000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b0f000 b2b16000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b93000 b2b9d000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ba3000 b2baf000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bb0000 b2bd1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bd6000 b2bd7000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bd8000 b2bdd000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bde000 b2bdf000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2be0000 b2be2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2be3000 b2bef000 r-xp /usr/lib/libdrm.so.2.4.0
b2bf0000 b2bf3000 r-xp /usr/lib/libdri2.so.0.0.0
b2bf4000 b2bfe000 r-xp /usr/lib/libtbm.so.1.0.0
b2bff000 b2c14000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c15000 b2c27000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3429000 b345a000 r-xp /usr/lib/libidn.so.11.5.44
b345b000 b347d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b347e000 b348e000 r-xp /usr/lib/libcares.so.2.1.0
b348f000 b34af000 r-xp /usr/lib/libnetwork.so.0.0.0
b34b0000 b34b9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34ba000 b3531000 r-xp /usr/lib/libcurl.so.4.3.0
b3533000 b3547000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b354e000 b354f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3550000 b3551000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3552000 b3555000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3556000 b3559000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3661000 b3667000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3668000 b37ac000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bc000 b37be000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37bf000 b37c0000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c1000 b37cd000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37ce000 b3807000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420a000 b4215000 r-xp /lib/libnss_files-2.20-2014.11.so
b4217000 b4222000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4224000 b423b000 r-xp /lib/libnsl-2.20-2014.11.so
b423f000 b4247000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4249000 b426d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b426e000 b426f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4270000 b4273000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4274000 b427b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427c000 b4286000 r-xp /usr/lib/libsensord-share.so
b4287000 b42a3000 r-xp /usr/lib/libsensor.so.1.2.0
b42a5000 b42ae000 r-xp /usr/lib/libappcore-common.so.1.1
b42b1000 b42b3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c8000 b42ca000 r-xp /usr/lib/libXau.so.6.0.0
b42cb000 b42ed000 r-xp /usr/lib/libxcb.so.1.1.0
b42ef000 b42f8000 r-xp /lib/libcrypt-2.20-2014.11.so
b4321000 b4323000 r-xp /usr/lib/libiri.so
b4324000 b434a000 r-xp /lib/libexpat.so.1.5.2
b434c000 b43b7000 r-xp /usr/lib/libssl.so.1.0.0
b43bd000 b43c9000 r-xp /usr/lib/libethumb.so.1.13.0
b43ca000 b43ce000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43cf000 b4620000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9b000 b5bab000 r-xp /usr/lib/libXi.so.6.1.0
b5bac000 b5bae000 r-xp /usr/lib/libXgesture.so.7.0.0
b5baf000 b5bb5000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb6000 b5bc0000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc1000 b5bca000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcc000 b5bce000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bcf000 b5bd4000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd5000 b5be7000 r-xp /usr/lib/libXext.so.6.4.0
b5be8000 b5bea000 r-xp /usr/lib/libXdamage.so.1.1.0
b5beb000 b5bed000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bef000 b5d31000 r-xp /usr/lib/libX11.so.6.3.0
b5d35000 b5d3f000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d40000 b5d56000 r-xp /usr/lib/libudev.so.1.6.0
b5d59000 b5d5d000 r-xp /lib/libattr.so.1.1.0
b5d5e000 b5d8d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d8f000 b5d95000 r-xp /usr/lib/libffi.so.6.0.2
b5d96000 b5db9000 r-xp /lib/libz.so.1.2.8
b5dba000 b5dbd000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dbe000 b5f1a000 r-xp /usr/lib/libxml2.so.2.9.2
b5f20000 b6007000 r-xp /usr/lib/libstdc++.so.6.0.20
b6014000 b6017000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6018000 b603a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603b000 b604f000 r-xp /lib/libresolv-2.20-2014.11.so
b6053000 b6077000 r-xp /usr/lib/liblzma.so.5.0.3
b6078000 b607a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607c000 b6086000 r-xp /usr/lib/libembryo.so.1.13.0
b6087000 b60b0000 r-xp /usr/lib/libpng12.so.0.50.0
b60b1000 b60fa000 r-xp /usr/lib/libjpeg.so.8.0.2
b610b000 b6112000 r-xp /lib/librt-2.20-2014.11.so
b6114000 b6133000 r-xp /usr/lib/libector.so.1.13.0
b6136000 b6163000 r-xp /usr/lib/liblua-5.1.so
b6164000 b61f4000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f8000 b6236000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6237000 b624d000 r-xp /usr/lib/libfribidi.so.0.3.1
b624e000 b62a7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62aa000 b62f5000 r-xp /lib/libm-2.20-2014.11.so
b62f7000 b6309000 r-xp /usr/lib/libeio.so.1.13.0
b630a000 b630d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b630e000 b6314000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6315000 b6338000 r-xp /usr/lib/libefreet.so.1.13.0
b633b000 b6366000 r-xp /usr/lib/libeldbus.so.1.13.0
b6367000 b639b000 r-xp /usr/lib/libecore_con.so.1.13.0
b639d000 b63a6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a7000 b63b0000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b1000 b63c4000 r-xp /usr/lib/libeo.so.1.13.0
b63c6000 b63d9000 r-xp /usr/lib/libecore_input.so.1.13.0
b63da000 b63e1000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e2000 b6405000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6406000 b6432000 r-xp /usr/lib/libeet.so.1.13.0
b643b000 b64a6000 r-xp /usr/lib/libeina.so.1.13.0
b64a9000 b64c0000 r-xp /usr/lib/libefl.so.1.13.0
b64c2000 b6629000 r-xp /usr/lib/libicuuc.so.51.1
b6637000 b6843000 r-xp /usr/lib/libicui18n.so.51.1
b684b000 b689a000 r-xp /usr/lib/libecore_x.so.1.13.0
b689c000 b68b6000 r-xp /lib/libgcc_s-4.9.so.1
b68b8000 b68bc000 r-xp /lib/libcap.so.2.21
b68bd000 b6903000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6904000 b690b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690d000 b695f000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6961000 b6aec000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af1000 b6bbf000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc2000 b6bc6000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc7000 b6bd6000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd7000 b6bda000 r-xp /usr/lib/libvasum.so.0.3.1
b6bdb000 b6bde000 r-xp /usr/lib/libttrace.so.1.1
b6be0000 b6be4000 r-xp /usr/lib/libiniparser.so.0
b6be5000 b6c15000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c16000 b6c1f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c20000 b6c45000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c46000 b6c56000 r-xp /usr/lib/libunwind.so.8.0.1
b6c60000 b6e0e000 r-xp /lib/libc-2.20-2014.11.so
b6e16000 b6f59000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5b000 b6fb3000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb4000 b6fe8000 r-xp /usr/lib/libsystemd.so.0.4.0
b6feb000 b70bf000 r-xp /usr/lib/libedje.so.1.13.0
b70c2000 b70ee000 r-xp /usr/lib/libecore.so.1.13.0
b70ff000 b7325000 r-xp /usr/lib/libevas.so.1.13.0
b734d000 b7365000 r-xp /lib/libpthread-2.20-2014.11.so
b7369000 b76e3000 r-xp /usr/lib/libelementary.so.1.13.0
b7703000 b7707000 r-xp /usr/lib/libsmack.so.1.0.0
b7708000 b7711000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7712000 b7715000 r-xp /usr/lib/libdlog.so.0.0.0
b7716000 b771b000 r-xp /usr/lib/libbundle.so.0.1.22
b771c000 b771f000 r-xp /lib/libdl-2.20-2014.11.so
b7721000 b7746000 r-xp /usr/lib/libaul.so.0.1.0
b7749000 b774b000 r-xp /usr/lib/libappsvc.so.0.1.0
b774c000 b7751000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7752000 b7759000 r-xp /usr/lib/libappcore-efl.so.1.1
b775b000 b7760000 r-xp /usr/lib/libsys-assert.so
b7763000 b7764000 r-xp [vdso]
b7764000 b7786000 r-xp /lib/ld-2.20-2014.11.so
b7788000 b7790000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5877)
Call Stack Count: 22
 0: cJSON_GetObjectItem + 0x22 (0xb37c3b12) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2b12
 1: signup_signup_button_clicked_cb + 0x481 (0xb37c9361) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8361
 2: (0xb7188116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb63bf319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb63bcd63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb718a9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb743b404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb706ef39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb7075a11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb706ffdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb70704cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb707068f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb70d5702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb70cf055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70d81b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb70d8587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb753122d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb7755dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb774ec80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x278 (0xb37c9fd8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8fd8
20: cJSON_ParseWithOpts + 0x38 (0xb778a148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb778a148
21: __libc_start_main + 0xde (0xb6c77e4e) [/lib/libc.so.6] + 0x17e4e
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
id(971) > [SECURE_LOG] appid for 5877 is org.example.tichat
10-17 04:23:42.830+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5877 : 0
10-17 04:23:42.830+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 34
10-17 04:23:42.830+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-17 04:23:42.940+0900 D/APP_CORE( 5877): appcore.c: __prt_ltime(236) > [APP 5877] first idle after reset: 230 msec
10-17 04:23:43.010+0900 E/PKGMGR_SERVER( 6003): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-17 04:23:43.010+0900 E/PKGMGR_SERVER( 6003): pkgmgr-server.c: main(2265) > package manager server terminated.
10-17 04:23:43.040+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-17 04:23:43.040+0900 D/APP_CORE( 5877): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
10-17 04:23:43.040+0900 D/APP_CORE( 5877): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-17 04:23:43.040+0900 D/APP_CORE( 5877): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 04:23:43.040+0900 I/APP_CORE( 5877): appcore-efl.c: __do_app(496) > [APP 5877] Event: RESUME State: CREATED
10-17 04:23:43.040+0900 D/LAUNCH  ( 5877): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-17 04:23:43.040+0900 D/APP_CORE( 5877): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 04:23:43.040+0900 D/APP_CORE( 5877): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 04:23:43.040+0900 D/APP_CORE( 5877): appcore-efl.c: __do_app(607) > [APP 5877] RESUME
10-17 04:23:43.050+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-17 04:23:43.050+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-17 04:23:43.050+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-17 04:23:43.050+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: PAUSE State: RUNNING
10-17 04:23:43.050+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(565) > [APP 2853] PAUSE
10-17 04:23:43.050+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-17 04:23:43.050+0900 E/cluster-home( 2853): homescreen.cpp: OnPause(84) >  app pause
10-17 04:23:43.050+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-17 04:23:43.050+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(923) >  END
10-17 04:23:43.050+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 04:23:43.050+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 04:23:43.050+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(4)
10-17 04:23:43.050+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-17 04:23:43.050+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-17 04:23:43.050+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: bg
10-17 04:23:43.050+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(5877) status(3)
10-17 04:23:43.050+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 04:23:43.060+0900 I/APP_CORE( 5877): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-17 04:23:43.060+0900 I/APP_CORE( 5877): appcore-efl.c: __do_app(614) > [APP 5877] Initial Launching, call the resume_cb
10-17 04:23:43.060+0900 I/CAPI_APPFW_APPLICATION( 5877): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 04:23:43.060+0900 D/LAUNCH  ( 5877): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-17 04:23:43.060+0900 D/LAUNCH  ( 5877): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-17 04:23:43.060+0900 D/APP_CORE( 5877): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 04:23:43.060+0900 E/APP_CORE( 5877): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 04:23:43.060+0900 W/AUL_AMD ( 2719): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-17 04:23:43.060+0900 W/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-17 04:23:43.060+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(5877) status(3)
10-17 04:23:43.060+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(5877) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-17 04:23:43.060+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-17 04:23:43.060+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5877, appid: org.example.tichat, status: fg
10-17 04:23:43.060+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5877
10-17 04:23:43.060+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5877, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-17 04:23:43.060+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5877
10-17 04:23:43.070+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2853 is paused
10-17 04:23:43.070+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-17 04:23:43.080+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-17 04:23:43.080+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-17 04:23:43.080+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: bg
10-17 04:23:43.130+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5877, appname = org.example.tichat, pkgname = org.example.tichat
10-17 04:23:43.130+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5877, appname = org.example.tichat
10-17 04:23:43.130+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5877
10-17 04:23:43.130+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-17 04:23:43.130+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2998
10-17 04:23:43.130+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2998, appname = org.tizen.calendar.widget
10-17 04:23:43.130+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2998
10-17 04:23:43.130+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 04:23:43.130+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 04:23:43.140+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2910) > pid(5877) status(0)
10-17 04:23:43.840+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-17 04:23:43.840+0900 D/AUL_PAD ( 6067): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-17 04:23:43.840+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-17 04:23:43.840+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.450
10-17 04:23:44.130+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:23:44.130+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7c693b8. set autocapital type : 2
10-17 04:23:44.130+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:23:44.130+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16f50023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:23:44.130+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7c693b8. on demand : 0
10-17 04:23:44.130+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:23:44.130+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 0
10-17 04:23:44.130+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7c693b8
10-17 04:23:44.140+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:23:44.340+0900 D/AUL_AMD ( 2719): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-17 04:23:44.340+0900 D/RUA     ( 2719): rua.c: rua_add_history(179) > rua_add_history start
10-17 04:23:44.340+0900 D/RUA     ( 2719): rua.c: rua_add_history(247) > rua_add_history ok
10-17 04:23:44.790+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 1
10-17 04:23:44.790+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7c693b8, bidi direction : 0x1
10-17 04:23:44.870+0900 D/AUL_PAD ( 6067): launchpad_loader.c: main(588) > sleeping 1 sec...
10-17 04:23:44.870+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b95cb760
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(69) > get pre-initialization function
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(73) > get shutdown function
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b95cba40
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b95cd640
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(69) > get pre-initialization function
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preload.h: __preload_init(73) > get shutdown function
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): preexec.h: __preexec_init(76) > preexec start
10-17 04:23:44.880+0900 D/AUL_PAD ( 6067): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-17 04:23:44.880+0900 D/AUL     ( 6067): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-17 04:23:44.880+0900 D/AUL     ( 6067): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-17 04:23:44.880+0900 D/AUL     ( 6067): process_pool.c: __connect_to_launchpad(132) > send(6067) : 4
10-17 04:23:44.880+0900 D/AUL     ( 6067): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-17 04:23:44.880+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6067
10-17 04:23:44.930+0900 D/AUL_PAD ( 6067): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-17 04:23:44.940+0900 D/AUL_PAD ( 6067): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-17 04:23:44.940+0900 D/AUL_PAD ( 6067): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-17 04:23:44.940+0900 D/AUL_PAD ( 6067): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-17 04:23:45.140+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
10-17 04:23:45.190+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 2
10-17 04:23:45.280+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 3
10-17 04:23:45.370+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 4
10-17 04:23:46.280+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 3
10-17 04:23:46.820+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 2
10-17 04:23:46.870+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 1
10-17 04:23:46.890+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 0
10-17 04:23:46.890+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7c693b8, bidi direction : 0
10-17 04:23:48.060+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-17 04:23:48.060+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: MEM_FLUSH State: PAUSED
10-17 04:23:48.060+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-17 04:23:48.060+0900 D/APP_CORE( 2853): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2853
10-17 04:23:48.060+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-17 04:23:48.060+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2853
10-17 04:23:49.590+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:23:50.060+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7c693b8
10-17 04:23:50.060+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:23:50.060+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7c693b8
10-17 04:23:50.060+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:23:50.070+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:23:50.120+0900 E/EFL     ( 5877): elementary<5877> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8008e274)
10-17 04:23:50.130+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 04:23:50.140+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-17 04:23:50.140+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-17 04:23:50.140+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-17 04:23:50.140+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:23:50.140+0900 D/SCIM_HELPER( 3017): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:23:50.140+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:23:50.150+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x601a16 bd->visible=1
10-17 04:23:50.530+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:23:50.530+0900 D/ISE_DEFAULT( 3017): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-17 04:23:50.720+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:23:50.720+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7d1f2a8. set autocapital type : 2
10-17 04:23:50.720+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:23:50.720+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16f70023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:23:50.720+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7d1f2a8. on demand : 0
10-17 04:23:50.720+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:23:50.720+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d1f2a8, cursor pos : 0
10-17 04:23:50.720+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7d1f2a8
10-17 04:23:50.720+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:23:51.080+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d1f2a8, cursor pos : 1
10-17 04:23:51.080+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7d1f2a8, bidi direction : 0x1
10-17 04:23:51.380+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d1f2a8, cursor pos : 2
10-17 04:23:51.480+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d1f2a8, cursor pos : 3
10-17 04:23:51.940+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d1f2a8, cursor pos : 4
10-17 04:23:52.060+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d1f2a8, cursor pos : 5
10-17 04:23:52.400+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7d1f2a8
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7d1f2a8
10-17 04:23:52.400+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7d289a0. set autocapital type : 0
10-17 04:23:52.400+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:23:52.400+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16f80023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7d289a0. on demand : 0
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 0
10-17 04:23:52.400+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7d289a0
10-17 04:23:52.410+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:23:52.610+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 1
10-17 04:23:52.610+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7d289a0, bidi direction : 0x1
10-17 04:23:52.680+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 2
10-17 04:23:52.740+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 3
10-17 04:23:52.890+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 4
10-17 04:23:52.960+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 5
10-17 04:23:52.960+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 6
10-17 04:23:53.020+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d289a0, cursor pos : 7
10-17 04:23:53.520+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:23:53.530+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7d289a0
10-17 04:23:53.530+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:23:53.530+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7d289a0
10-17 04:23:53.530+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:23:53.590+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 04:23:53.590+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-17 04:23:53.590+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-17 04:23:53.590+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-17 04:23:53.590+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:23:53.590+0900 D/SCIM_HELPER( 3017): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:23:53.590+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:23:53.600+0900 I/CAPI_NETWORK_CONNECTION( 5877): connection.c: connection_create(408) > New handle created[0xb7c879d8]
10-17 04:23:53.600+0900 I/CAPI_NETWORK_CONNECTION( 5877): connection.c: connection_get_type(464) > Connected Network = 3
10-17 04:23:53.600+0900 I/tichat  ( 5877): Network connection type : 3
10-17 04:23:53.910+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:23:53.910+0900 D/ISE_DEFAULT( 3017): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-17 04:23:55.760+0900 I/tichat  ( 5877): CURL Returned: 
10-17 04:23:55.760+0900 I/tichat  ( 5877): {"message":200}
10-17 04:23:55.760+0900 I/tichat  ( 5877): Parsed JSON: 200
10-17 04:23:56.090+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb7d289a0
10-17 04:23:56.090+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
10-17 04:23:56.090+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
10-17 04:23:57.450+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 04:23:57.450+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 04:23:57.450+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 04:23:57.450+0900 E/INDICATOR( 2840): 
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:24 4 h"
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:24"
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;24"
10-17 04:24:00.060+0900 D/INDICATOR( 2840): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146506889 Time: <font_size=33>4&#x2236;24</font_size> <font_size=32>AM</font_size></font>
10-17 04:24:02.540+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:24:02.630+0900 E/EFL     ( 5877): edje<5877> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-17 04:24:02.630+0900 E/EFL     ( 5877): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:24:03.550+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
10-17 04:24:04.290+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:24:04.380+0900 E/EFL     ( 5877): elementary<5877> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x80107e44)
10-17 04:24:05.190+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:24:05.190+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7da94d8. set autocapital type : 2
10-17 04:24:05.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7da94d8. on demand : 0
10-17 04:24:05.200+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:24:05.200+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16f90023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:24:05.200+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:24:05.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 0
10-17 04:24:05.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7da94d8
10-17 04:24:05.200+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:24:05.530+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 1
10-17 04:24:05.650+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 2
10-17 04:24:05.740+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 3
10-17 04:24:05.810+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 4
10-17 04:24:06.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 5
10-17 04:24:06.450+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 6
10-17 04:24:06.600+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 7
10-17 04:24:06.660+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da94d8, cursor pos : 8
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7da94d8
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7da94d8
10-17 04:24:06.780+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7da92c8. set autocapital type : 0
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7da92c8. on demand : 0
10-17 04:24:06.780+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:24:06.780+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16fa0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:24:06.780+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 0
10-17 04:24:07.120+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 1
10-17 04:24:07.210+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 2
10-17 04:24:07.330+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 3
10-17 04:24:07.400+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 4
10-17 04:24:07.480+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 5
10-17 04:24:07.600+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 6
10-17 04:24:07.750+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 7
10-17 04:24:07.850+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 8
10-17 04:24:07.970+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da92c8, cursor pos : 9
10-17 04:24:08.560+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x601a16 bd->visible=1
10-17 04:24:08.870+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7da92c8
10-17 04:24:08.870+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:24:08.870+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7da92c8
10-17 04:24:08.870+0900 E/EFL     ( 5877): edje<5877> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-17 04:24:08.870+0900 E/EFL     ( 5877): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:24:08.870+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:24:08.880+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:24:08.920+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 04:24:08.920+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-17 04:24:08.920+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-17 04:24:08.920+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-17 04:24:08.920+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:24:08.920+0900 D/SCIM_HELPER( 3017): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:24:08.920+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:24:08.990+0900 E/CAPI_NETWORK_CONNECTION( 5877): connection.c: connection_create(392) > Invalid parameter
10-17 04:24:08.990+0900 I/tichat  ( 5877): Connection Failed!!!!!!!!!!!!
10-17 04:24:08.990+0900 I/CAPI_NETWORK_CONNECTION( 5877): connection.c: connection_get_type(464) > Connected Network = 3
10-17 04:24:08.990+0900 I/tichat  ( 5877): Network connection type : 3
10-17 04:24:09.250+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:24:09.250+0900 D/ISE_DEFAULT( 3017): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-17 04:24:09.640+0900 I/tichat  ( 5877): CURL Returned: 
10-17 04:24:09.640+0900 I/tichat  ( 5877): {"message":"300"}
10-17 04:24:09.640+0900 I/tichat  ( 5877): Parsed JSON: "300"
10-17 04:24:11.750+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:24:17.470+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 04:24:17.470+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 04:24:17.470+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 04:24:17.470+0900 E/INDICATOR( 2840): 
10-17 04:24:37.130+0900 D/RESOURCED( 2835): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-17 04:24:37.130+0900 I/RESOURCED( 2835): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-17 04:24:37.130+0900 D/RESOURCED( 2835): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-17 04:24:37.130+0900 I/RESOURCED( 2835): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-17 04:24:37.500+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 04:24:37.500+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 04:24:37.500+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 04:24:37.500+0900 E/INDICATOR( 2840): 
10-17 04:24:57.530+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 04:24:57.530+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 04:24:57.530+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 04:24:57.530+0900 E/INDICATOR( 2840): 
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:25 4 h"
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:25"
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;25"
10-17 04:25:00.070+0900 D/INDICATOR( 2840): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146504837 Time: <font_size=33>4&#x2236;25</font_size> <font_size=32>AM</font_size></font>
10-17 04:25:17.550+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 04:25:17.550+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 04:25:17.550+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 04:25:17.550+0900 E/INDICATOR( 2840): 
10-17 04:25:19.280+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:25:19.580+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb7da92c8
10-17 04:25:19.580+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
10-17 04:25:19.580+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
10-17 04:25:20.290+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
10-17 04:25:20.920+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:25:20.920+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7c693b8. set autocapital type : 2
10-17 04:25:20.920+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:25:20.920+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16f50023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:25:20.920+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7c693b8. on demand : 0
10-17 04:25:20.920+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:25:20.920+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7c693b8, cursor pos : 0
10-17 04:25:20.920+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7c693b8
10-17 04:25:20.920+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:25:22.610+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:25:22.620+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7c693b8
10-17 04:25:22.620+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:25:22.620+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7c693b8
10-17 04:25:22.620+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:25:22.690+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 04:25:22.690+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-17 04:25:22.690+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-17 04:25:22.690+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-17 04:25:22.690+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:25:22.690+0900 D/SCIM_HELPER( 3017): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:25:22.690+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:25:22.690+0900 E/EFL     ( 5877): elementary<5877> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8019c0e7)
10-17 04:25:23.060+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:25:23.060+0900 D/ISE_DEFAULT( 3017): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-17 04:25:23.200+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:25:23.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7d5c1b8. set autocapital type : 2
10-17 04:25:23.200+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:25:23.200+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16fb0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:25:23.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7d5c1b8. on demand : 0
10-17 04:25:23.200+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:25:23.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 0
10-17 04:25:23.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7d5c1b8
10-17 04:25:23.200+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:25:23.900+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 1
10-17 04:25:24.020+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 2
10-17 04:25:24.110+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 3
10-17 04:25:24.200+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 4
10-17 04:25:24.540+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 5
10-17 04:25:24.750+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 6
10-17 04:25:24.900+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 7
10-17 04:25:24.970+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d5c1b8, cursor pos : 8
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7d5c1b8
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7d5c1b8
10-17 04:25:25.090+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7da7588. set autocapital type : 0
10-17 04:25:25.090+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:25:25.090+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 16fc0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7da7588. on demand : 0
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:25:25.090+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 0
10-17 04:25:25.300+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x601a16 bd->visible=1
10-17 04:25:25.300+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 1
10-17 04:25:25.360+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 2
10-17 04:25:25.510+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 3
10-17 04:25:25.570+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 4
10-17 04:25:25.640+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 5
10-17 04:25:25.750+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 6
10-17 04:25:25.910+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 7
10-17 04:25:25.970+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 8
10-17 04:25:26.120+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7da7588, cursor pos : 9
10-17 04:25:27.140+0900 D/IMMODULE( 5877): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7da7588
10-17 04:25:27.140+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:25:27.140+0900 D/IMMODULE( 5877): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7da7588
10-17 04:25:27.140+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:25:27.150+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601a16 
10-17 04:25:27.200+0900 E/CAPI_NETWORK_CONNECTION( 5877): connection.c: connection_create(392) > Invalid parameter
10-17 04:25:27.200+0900 I/tichat  ( 5877): Connection Failed!!!!!!!!!!!!
10-17 04:25:27.200+0900 I/CAPI_NETWORK_CONNECTION( 5877): connection.c: connection_get_type(464) > Connected Network = 3
10-17 04:25:27.200+0900 I/tichat  ( 5877): Network connection type : 3
10-17 04:25:32.210+0900 I/tichat  ( 5877): ERROR: Failed to fetch url (http://192.168.0.2:3000/signup) - curl said: Timeout was reached
10-17 04:25:32.210+0900 I/tichat  ( 5877): CURL Returned: 
10-17 04:25:32.210+0900 I/tichat  ( 5877): 
10-17 04:25:32.250+0900 W/CRASH_MANAGER( 6070): worker.c: worker_job(1204) > 1105877746963147664593
