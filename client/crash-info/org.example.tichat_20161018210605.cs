S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 3794
Date: 2016-10-18 21:06:05+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0xb839ef88, esi = 0xb37cddba
ebp = 0xbfe15a48, esp = 0xbfe15a20
eax = 0xb37d0608, ebx = 0xb37d0608
ecx = 0x00000000, edx = 0x00000000
eip = 0xb37c3b32

Memory Information
MemTotal:      250 KB
MemFree:       138 KB
Buffers:         4 KB
Cached:     202660 KB
VmPeak:     111776 KB
VmSize:     111776 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25032 KB
VmRSS:       25032 KB
VmData:      43288 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34596 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3794 TID = 3794
3794 3795 3799 3800 3803 

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
b2be3000 b2be5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2be6000 b2bf2000 r-xp /usr/lib/libdrm.so.2.4.0
b2bf3000 b2bf6000 r-xp /usr/lib/libdri2.so.0.0.0
b2bf7000 b2c01000 r-xp /usr/lib/libtbm.so.1.0.0
b2c02000 b2c17000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c18000 b2c2a000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b342c000 b345d000 r-xp /usr/lib/libidn.so.11.5.44
b345e000 b3480000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3481000 b3491000 r-xp /usr/lib/libcares.so.2.1.0
b3492000 b34b2000 r-xp /usr/lib/libnetwork.so.0.0.0
b34b3000 b34bc000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34bd000 b3534000 r-xp /usr/lib/libcurl.so.4.3.0
b3536000 b354a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b3551000 b3552000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3553000 b3554000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3555000 b3558000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3559000 b355c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3664000 b366a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b366b000 b37af000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bf000 b37c0000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c1000 b37d0000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37d1000 b380a000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420d000 b4218000 r-xp /lib/libnss_files-2.20-2014.11.so
b421a000 b4225000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4227000 b423e000 r-xp /lib/libnsl-2.20-2014.11.so
b4242000 b424a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b424c000 b4270000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4271000 b4272000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4273000 b4276000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4277000 b427e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427f000 b4289000 r-xp /usr/lib/libsensord-share.so
b428a000 b42a6000 r-xp /usr/lib/libsensor.so.1.2.0
b42a8000 b42b1000 r-xp /usr/lib/libappcore-common.so.1.1
b42b4000 b42b6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42cb000 b42cd000 r-xp /usr/lib/libXau.so.6.0.0
b42ce000 b42f0000 r-xp /usr/lib/libxcb.so.1.1.0
b42f2000 b42fb000 r-xp /lib/libcrypt-2.20-2014.11.so
b4324000 b4326000 r-xp /usr/lib/libiri.so
b4327000 b434d000 r-xp /lib/libexpat.so.1.5.2
b434f000 b43ba000 r-xp /usr/lib/libssl.so.1.0.0
b43c0000 b43cc000 r-xp /usr/lib/libethumb.so.1.13.0
b43cd000 b43d1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d2000 b4623000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9e000 b5bae000 r-xp /usr/lib/libXi.so.6.1.0
b5baf000 b5bb1000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb2000 b5bb8000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb9000 b5bc3000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc4000 b5bcd000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcf000 b5bd1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd2000 b5bd7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd8000 b5bea000 r-xp /usr/lib/libXext.so.6.4.0
b5beb000 b5bed000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bee000 b5bf0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf2000 b5d34000 r-xp /usr/lib/libX11.so.6.3.0
b5d38000 b5d42000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d43000 b5d59000 r-xp /usr/lib/libudev.so.1.6.0
b5d5c000 b5d60000 r-xp /lib/libattr.so.1.1.0
b5d61000 b5d90000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d92000 b5d98000 r-xp /usr/lib/libffi.so.6.0.2
b5d99000 b5dbc000 r-xp /lib/libz.so.1.2.8
b5dbd000 b5dc0000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dc1000 b5f1d000 r-xp /usr/lib/libxml2.so.2.9.2
b5f23000 b600a000 r-xp /usr/lib/libstdc++.so.6.0.20
b6017000 b601a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b601b000 b603d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603e000 b6052000 r-xp /lib/libresolv-2.20-2014.11.so
b6056000 b607a000 r-xp /usr/lib/liblzma.so.5.0.3
b607b000 b607d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607f000 b6089000 r-xp /usr/lib/libembryo.so.1.13.0
b608a000 b60b3000 r-xp /usr/lib/libpng12.so.0.50.0
b60b4000 b60fd000 r-xp /usr/lib/libjpeg.so.8.0.2
b610e000 b6115000 r-xp /lib/librt-2.20-2014.11.so
b6117000 b6136000 r-xp /usr/lib/libector.so.1.13.0
b6139000 b6166000 r-xp /usr/lib/liblua-5.1.so
b6167000 b61f7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61fb000 b6239000 r-xp /usr/lib/libfontconfig.so.1.8.0
b623a000 b6250000 r-xp /usr/lib/libfribidi.so.0.3.1
b6251000 b62aa000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ad000 b62f8000 r-xp /lib/libm-2.20-2014.11.so
b62fa000 b630c000 r-xp /usr/lib/libeio.so.1.13.0
b630d000 b6310000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6311000 b6317000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6318000 b633b000 r-xp /usr/lib/libefreet.so.1.13.0
b633e000 b6369000 r-xp /usr/lib/libeldbus.so.1.13.0
b636a000 b639e000 r-xp /usr/lib/libecore_con.so.1.13.0
b63a0000 b63a9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63aa000 b63b3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b4000 b63c7000 r-xp /usr/lib/libeo.so.1.13.0
b63c9000 b63dc000 r-xp /usr/lib/libecore_input.so.1.13.0
b63dd000 b63e4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e5000 b6408000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6409000 b6435000 r-xp /usr/lib/libeet.so.1.13.0
b643e000 b64a9000 r-xp /usr/lib/libeina.so.1.13.0
b64ac000 b64c3000 r-xp /usr/lib/libefl.so.1.13.0
b64c5000 b662c000 r-xp /usr/lib/libicuuc.so.51.1
b663a000 b6846000 r-xp /usr/lib/libicui18n.so.51.1
b684e000 b689d000 r-xp /usr/lib/libecore_x.so.1.13.0
b689f000 b68b9000 r-xp /lib/libgcc_s-4.9.so.1
b68bb000 b68bf000 r-xp /lib/libcap.so.2.21
b68c0000 b6906000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6907000 b690e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6910000 b6962000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6964000 b6aef000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af4000 b6bc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc5000 b6bc9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bca000 b6bd9000 r-xp /usr/lib/libvconf.so.0.2.45
b6bda000 b6bdd000 r-xp /usr/lib/libvasum.so.0.3.1
b6bde000 b6be1000 r-xp /usr/lib/libttrace.so.1.1
b6be3000 b6be7000 r-xp /usr/lib/libiniparser.so.0
b6be8000 b6c18000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c19000 b6c22000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c23000 b6c48000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c49000 b6c59000 r-xp /usr/lib/libunwind.so.8.0.1
b6c63000 b6e11000 r-xp /lib/libc-2.20-2014.11.so
b6e19000 b6f5c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5e000 b6fb6000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb7000 b6feb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fee000 b70c2000 r-xp /usr/lib/libedje.so.1.13.0
b70c5000 b70f1000 r-xp /usr/lib/libecore.so.1.13.0
b7102000 b7328000 r-xp /usr/lib/libevas.so.1.13.0
b7350000 b7368000 r-xp /lib/libpthread-2.20-2014.11.so
b736c000 b76e6000 r-xp /usr/lib/libelementary.so.1.13.0
b7706000 b770a000 r-xp /usr/lib/libsmack.so.1.0.0
b770b000 b7714000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7715000 b7718000 r-xp /usr/lib/libdlog.so.0.0.0
b7719000 b771e000 r-xp /usr/lib/libbundle.so.0.1.22
b771f000 b7722000 r-xp /lib/libdl-2.20-2014.11.so
b7724000 b7749000 r-xp /usr/lib/libaul.so.0.1.0
b774c000 b774e000 r-xp /usr/lib/libappsvc.so.0.1.0
b774f000 b7754000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7755000 b775c000 r-xp /usr/lib/libappcore-efl.so.1.1
b775e000 b7763000 r-xp /usr/lib/libsys-assert.so
b7766000 b7767000 r-xp [vdso]
b7767000 b7789000 r-xp /lib/ld-2.20-2014.11.so
b778b000 b7793000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3794)
Call Stack Count: 22
 0: cJSON_GetObjectItem + 0x22 (0xb37c3b32) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2b32
 1: login_login_button_clicked_cb + 0x481 (0xb37ccc81) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xbc81
 2: (0xb718b116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb63c2319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb63bfd63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb718d9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb743e404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb7071f39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb7078a11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb7072fdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb70734cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb707368f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb70d8702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb70d2055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70db1b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb70db587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb753422d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb7758dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb7751c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x278 (0xb37cb7a8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xa7a8
20: cJSON_ParseWithOpts + 0x18 (0xb778d148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb778d148
21: __libc_start_main + 0xde (0xb6c7ae4e) [/lib/libc.so.6] + 0x17e4e
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
shown] ctx : 0xb833ac20
10-18 21:05:56.283+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: _process_ise_panel_showed(1060) > received_will_hide_event = 0
10-18 21:05:56.343+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: isf_imf_context_set_keyboard_mode(1007) > [SECURE_LOG] keyboard mode : 0
10-18 21:05:56.343+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: slot_set_keyboard_mode(5841) > slot_set_keyboard_mode called (TOOLBAR_MODE : 0)
10-18 21:05:56.343+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: change_keyboard_mode(6146) > HARDWARE KEYBOARD MODE
10-18 21:05:56.343+0900 D/ISF_PANEL_EFL( 3019): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-18 21:05:56.343+0900 D/SCIM_HELPER( 3023): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-18 21:05:56.343+0900 D/LIBSCL_UI( 3023): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2200009 (basewin 0x8000321a mag 0x8000fc7f)
10-18 21:05:56.343+0900 D/AUL_AMD ( 2778): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-18 21:05:56.343+0900 D/RUA     ( 2778): rua.c: rua_add_history(179) > rua_add_history start
10-18 21:05:56.353+0900 D/LIBSCL_UI( 3023): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2200003 (basewin 0x8000321a mag 0x8000fc7f)
10-18 21:05:56.353+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 1
10-18 21:05:56.353+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_event_notification(581) > shift state: 0
10-18 21:05:56.353+0900 D/ISE_DEFAULT( 3023): ise.cpp: ise_send_event(463) > ic : ed20027, ffe1
10-18 21:05:56.353+0900 D/RUA     ( 2778): rua.c: rua_add_history(247) > rua_add_history ok
10-18 21:05:56.353+0900 D/ISE_DEFAULT( 3023): ise.cpp: _reset_shift_state(163) > Shift state changed from (1) to (0)
10-18 21:05:56.353+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: change_keyboard_mode(6200) > Create kbd_mode_changer notification with : org.tizen.isf-kbd-mode-changer
10-18 21:05:56.353+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 I/AUL     ( 3019): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/isf-panel-efl, ret : 0
10-18 21:05:56.363+0900 D/AUL     ( 3019): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 3019, pid = 3019
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 I/AUL     ( 3019): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/isf-panel-efl, ret : 0
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 I/AUL     ( 3019): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/isf-panel-efl, ret : 0
10-18 21:05:56.363+0900 D/AUL     ( 3019): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 3019, pid = 3019
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.363+0900 D/PKGMGR_INFO( 3019): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/isf-panel-efl' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 I/AUL     ( 3019): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/isf-panel-efl, ret : 0
10-18 21:05:56.373+0900 E/CAPI_APPFW_APP_MANAGER( 3019): app_manager.c: app_manager_error(73) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
10-18 21:05:56.373+0900 W/NOTIFICATION( 3019): notification.c: _notification_create(1700) > [SECURE_LOG] [_notification_create : 1700] app_manager_get_app_id failed err[-22] app_id[(nil)]
10-18 21:05:56.373+0900 D/AUL     ( 3019): service.c: __set_bundle(186) > __set_bundle
10-18 21:05:56.373+0900 D/AUL     ( 3019): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
10-18 21:05:56.373+0900 D/AUL     ( 3019): service.c: __set_bundle(186) > __set_bundle
10-18 21:05:56.373+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [61]
10-18 21:05:56.373+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 912 bytes
10-18 21:05:56.373+0900 D/DATA_PROVIDER_MASTER( 2912): notification_service.c: service_thread_main(864) > [SECURE_LOG] 0xb1f00618 REQ: Command: [add_noti]
10-18 21:05:56.373+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 I/AUL     ( 2912): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/data-provider-master, ret : 0
10-18 21:05:56.373+0900 D/AUL     ( 2912): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 2912, pid = 2912
10-18 21:05:56.373+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 I/AUL     ( 2912): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/data-provider-master, ret : 0
10-18 21:05:56.373+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.373+0900 I/AUL     ( 2912): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/data-provider-master, ret : 0
10-18 21:05:56.383+0900 D/AUL     ( 2912): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 2912, pid = 2912
10-18 21:05:56.383+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.383+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/data-provider-master' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.383+0900 I/AUL     ( 2912): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/data-provider-master, ret : 0
10-18 21:05:56.383+0900 E/CAPI_APPFW_APP_MANAGER( 2912): app_manager.c: app_manager_error(73) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
10-18 21:05:56.383+0900 W/NOTIFICATION( 2912): notification.c: _notification_create(1700) > [SECURE_LOG] [_notification_create : 1700] app_manager_get_app_id failed err[-22] app_id[(nil)]
10-18 21:05:56.383+0900 D/NOTIFICATION( 2912): notification_setting.c: notification_setting_get_setting_by_package_name(228) > [SECURE_LOG] [notification_setting_get_setting_by_package_name : 228] No setting found for [isf-panel-efl]
10-18 21:05:56.383+0900 D/PKGMGR_INFO( 2912): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1630) > [SECURE_LOG] Appid[isf-panel-efl] not found in DB
10-18 21:05:56.383+0900 E/NOTIFICATION( 2912): notification_noti.c: _get_package_id_by_app_id(741) > [SECURE_LOG] [_get_package_id_by_app_id : 741] pkgmgrinfo_appinfo_get_appinfo failed [-1]
10-18 21:05:56.383+0900 E/NOTIFICATION( 2912): notification_noti.c: _is_allowed_to_notify(782) > [SECURE_LOG] [_is_allowed_to_notify : 782] _get_package_id_by_app_id failed [-38]
10-18 21:05:56.383+0900 D/NOTIFICATION( 2912): notification_setting.c: notification_system_setting_load_system_setting(836) > [SECURE_LOG] [notification_system_setting_load_system_setting : 836] row_count [1] column_count [2]
10-18 21:05:56.383+0900 D/NOTIFICATION( 2912): notification_noti.c: _handle_do_not_disturb_option(842) > [SECURE_LOG] [_handle_do_not_disturb_option : 842] do_not_disturb [0]
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): notification_service.c: _handler_insert_noti(125) > [SECURE_LOG] priv_id: [14]
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
10-18 21:05:56.393+0900 D/COM_CORE( 3019): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2912, fd: -1
10-18 21:05:56.393+0900 D/COM_CORE( 3019): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 8 bytes (pid: 2912), fd: -1
10-18 21:05:56.393+0900 D/COM_CORE( 3019): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 45 (recv_fd: -1)
10-18 21:05:56.393+0900 D/NOTIFICATION( 3019): notification_internal.c: notification_insert(1018) > [SECURE_LOG] [notification_insert : 1018] from master:14
10-18 21:05:56.393+0900 D/COM_CORE( 2912): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
10-18 21:05:56.393+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: show_soft_keyboard(486) > Current toolbar mode should be TOOBAR_HELPER_MODE but is 0, returning
10-18 21:05:56.393+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: x_event_client_message_cb(6456) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: service_common_multicast_packet(1156) > [SECURE_LOG] Multicasting packets
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: service_common_multicast_packet(1164) > [SECURE_LOG] Skip target: 0xb1f00618(0) == 0xb1f00618/1
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: service_common_multicast_packet(1173) > [SECURE_LOG] Finish to multicast packet
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb1f00618 is terminated
10-18 21:05:56.393+0900 D/DATA_PROVIDER_MASTER( 2912): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
10-18 21:05:56.393+0900 D/PKGMGR_INFO( 2919): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.quickpanel/bin/quickpanel' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.393+0900 D/PKGMGR_INFO( 2919): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.quickpanel/bin/quickpanel' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.393+0900 D/AUL     ( 2919): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 2919 is org.tizen.quickpanel
10-18 21:05:56.393+0900 D/PKGMGR_INFO( 2919): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.quickpanel/bin/quickpanel' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.393+0900 D/PKGMGR_INFO( 2919): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.quickpanel/bin/quickpanel' and package_app_info.app_disable IN ('false','False')
10-18 21:05:56.393+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: get_ise_geometry(983) > angle : 0, w_angle : 0, mode : 0, Geometry : 0 1280 0 0
10-18 21:05:56.393+0900 D/AUL     ( 2919): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 2919 is org.tizen.quickpanel
10-18 21:05:56.403+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:56.403+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1043) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
10-18 21:05:56.403+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: x_event_client_message_cb(6476) > _candidate_state : 0
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti.c: _detailed_changed_cb(808) > [SECURE_LOG] [_detailed_changed_cb : 808] num_op:1
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti.c: _detailed_changed_cb(815) > [SECURE_LOG] [_detailed_changed_cb : 815] noti operation:1 privid:14
10-18 21:05:56.403+0900 D/QUICKPANEL( 2919): noti.c: _detailed_changed_cb(820) > [_detailed_changed_cb : 820] NOTIFICATION_OP_INSERT
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti.c: _print_debuginfo_from_noti(786) > [SECURE_LOG] [_print_debuginfo_from_noti : 786] pkg:isf-panel-efl
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti.c: _print_debuginfo_from_noti(789) > [SECURE_LOG] [_print_debuginfo_from_noti : 789] type:1
10-18 21:05:56.403+0900 D/QUICKPANEL( 2919): noti_led.c: quickpanel_noti_led_proc(243) > [quickpanel_noti_led_proc : 243] on:0 off:0
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti_led.c: _led_list_find_by_priv_id(113) > [_led_list_find_by_priv_id : 113] invalid parameter
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti_led.c: _noti_led_off(219) > [_noti_led_off : 219] try to turn off LED
10-18 21:05:56.403+0900 E/QUICKPANEL( 2919): noti_led.c: _noti_led_off(223) > [_noti_led_off : 223] failed led_set_mode:-1
10-18 21:05:56.403+0900 D/ISF_UTILITY( 3794): scim_utility.cpp: isf_save_log(1441) > time:1476792356  pid:3794  isf_imf_context.cpp  isf_imf_context_filter_event  Changed keyboard mode from S/W to H/W (code: 70, name: p)
10-18 21:05:56.403+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_filter_event(2107) > Hardware keyboard mode, active helper option: 13
10-18 21:05:56.403+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 1
10-18 21:05:56.403+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb833ac20, bidi direction : 0x1
10-18 21:05:56.403+0900 D/QUICKPANEL( 2919): noti_list_item.c: quickpanel_noti_list_item_create(461) > [quickpanel_noti_list_item_create : 461] created box:0x800751aa
10-18 21:05:56.403+0900 D/QUICKPANEL( 2919): noti_node.c: quickpanel_noti_node_add(89) > [quickpanel_noti_node_add : 89] n_noti = [0] n_ongoing = [1]
10-18 21:05:56.413+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:56.413+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: ui_settle_candidate_window(3443) > Moving candidate window to : 0 1196
10-18 21:05:56.413+0900 D/QUICKPANEL( 2919): noti_util.c: quickpanel_noti_util_get_text(315) > [quickpanel_noti_util_get_text : 315] text : Input detected from hardware keyboard.
10-18 21:05:56.413+0900 D/QUICKPANEL( 2919): noti_util.c: quickpanel_noti_util_get_text(315) > [quickpanel_noti_util_get_text : 315] text : Tap to use virtual keyboard.
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_value_bool(502) > Enter [system_settings_get_value_bool]
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
10-18 21:05:56.413+0900 D/SYSTEM-SETTINGS( 2919): system_setting_platform.c: system_setting_get_locale_timeformat_24hour(1564) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timeformat_24hour. [0m
10-18 21:05:56.413+0900 I/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_value_bool(512) > [SECURE_LOG] [0;36m inf (flag) value : 0 [0m
10-18 21:05:56.413+0900 I/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_value_bool(515) > [SECURE_LOG] [0;36m flag == 0 [0m
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
10-18 21:05:56.413+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2919): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
10-18 21:05:56.413+0900 D/SYSTEM-SETTINGS( 2919): system_setting_platform.c: system_setting_get_locale_country(1460) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_country. [0m
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): noti_listbox.c: quickpanel_noti_listbox_add_item(261) > [quickpanel_noti_listbox_add_item : 261] set to (null), 800751aa
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): vi_manager.c: quickpanel_vi_new_with_data(189) > [quickpanel_vi_new_with_data : 189] 
10-18 21:05:56.423+0900 I/QUICKPANEL( 2919): vi_manager.c: _vi_freeze_start(78) > [_vi_freeze_start : 78] VIM freezing
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): noti.c: _noti_ongoing_add(680) > [_noti_ongoing_add : 680] noti[0xb7ec5398] data[0x800751aa] added listbox[0x800150a9]
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): noti_node.c: quickpanel_noti_node_get_item_count(149) > [quickpanel_noti_node_get_item_count : 149] n_noti 0 , n_ongoing 1 
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): noti_node.c: quickpanel_noti_node_get_item_count(149) > [quickpanel_noti_node_get_item_count : 149] n_noti 0 , n_ongoing 1 
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): noti_section.c: _noti_section_set_text(55) > [_noti_section_set_text : 55] count is : 1 
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): noti_section.c: _noti_section_set_text(76) > [_noti_section_set_text : 76] Trying to set text :Notifications 1 
10-18 21:05:56.423+0900 I/QUICKPANEL( 2919): noti.c: quickpanel_noti_set_clear_all_status(1445) > [quickpanel_noti_set_clear_all_status : 1445] NOTI SECTION CLEAR ALL SHOW
10-18 21:05:56.423+0900 E/QUICKPANEL( 2919): noti.c: _detailed_changed_cb(1029) > [SECURE_LOG] [_detailed_changed_cb : 1029] current noti count:0, ongoing:1
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _activenoti_noti_detailed_changed_cb(1446) > [_activenoti_noti_detailed_changed_cb : 1446] 
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _activenoti_noti_detailed_changed_cb(1459) > [_activenoti_noti_detailed_changed_cb : 1459] op_type:1
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _activenoti_noti_detailed_changed_cb(1460) > [_activenoti_noti_detailed_changed_cb : 1460] op_priv_id:14
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _activenoti_noti_detailed_changed_cb(1461) > [_activenoti_noti_detailed_changed_cb : 1461] noti:0xb7ec67d8
10-18 21:05:56.423+0900 D/NOTIFICATION( 2919): notification_setting.c: notification_system_setting_load_system_setting(836) > [SECURE_LOG] [notification_system_setting_load_system_setting : 836] row_count [1] column_count [2]
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _check_sound_off(278) > [_check_sound_off : 278] do_not_disturb [0]
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): 
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _activenoti_noti_detailed_changed_cb(1490) > [_activenoti_noti_detailed_changed_cb : 1490] try to play notification sound b394ed00
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _media_feedback_sound(1360) > [SECURE_LOG] [_media_feedback_sound : 1360] notification sound: -1, (null)
10-18 21:05:56.423+0900 E/QUICKPANEL( 2919): activenoti.c: _media_feedback_sound(1414) > [_media_feedback_sound : 1414] None type: No sound
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _media_feedback_vibration(1432) > [_media_feedback_vibration : 1432] notification vibration: -1, (null)
10-18 21:05:56.423+0900 D/QUICKPANEL( 2919): activenoti.c: _activenoti_noti_detailed_changed_cb(1502) > [_activenoti_noti_detailed_changed_cb : 1502] applist : 1
10-18 21:05:56.423+0900 E/QUICKPANEL( 2919): vi_manager.c: _vi_list_count(139) > [_vi_list_count : 139] list null
10-18 21:05:56.423+0900 I/QUICKPANEL( 2919): vi_manager.c: _vi_freeze_stop(90) > [_vi_freeze_stop : 90] VIM unfreezing
10-18 21:05:56.433+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
10-18 21:05:56.433+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
10-18 21:05:56.443+0900 E/E17     ( 2765): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x00c00012)
10-18 21:05:56.453+0900 E/E17     ( 2765): e_border.c: e_border_show(2088) > BD_SHOW(0x00c00012)
10-18 21:05:56.563+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb833ac20
10-18 21:05:56.563+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 2
10-18 21:05:56.563+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:56.633+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb833ac20
10-18 21:05:56.633+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: _process_ise_panel_hided(1080) > received_will_hide_event = 1
10-18 21:05:56.673+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: slot_will_hide_ack(5811) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (59, 2000002)
10-18 21:05:56.673+0900 W/APP_CORE( 2840): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:c00012
10-18 21:05:56.673+0900 D/APP_CORE( 2840): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:c00012
10-18 21:05:56.673+0900 D/APP_CORE( 2840): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-18 21:05:56.673+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 3
10-18 21:05:56.683+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:56.703+0900 D/INDICATOR( 2840): ticker.c: _ticker_noti_detailed_changed_cb(1312) > 
10-18 21:05:56.703+0900 D/INDICATOR( 2840): ticker.c: _ticker_noti_detailed_changed_cb(1340) > displaying ticker option is off
10-18 21:05:56.723+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 4
10-18 21:05:56.813+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:56.813+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x02200003), visible:1
10-18 21:05:56.873+0900 D/AUL_PAD ( 3802): launchpad_loader.c: main(588) > sleeping 1 sec...
10-18 21:05:56.873+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9450760
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(69) > get pre-initialization function
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(73) > get shutdown function
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9450a40
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9452640
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(69) > get pre-initialization function
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preload.h: __preload_init(73) > get shutdown function
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): preexec.h: __preexec_init(76) > preexec start
10-18 21:05:56.883+0900 D/AUL_PAD ( 3802): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-18 21:05:56.883+0900 D/AUL     ( 3802): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-18 21:05:56.883+0900 D/AUL     ( 3802): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-18 21:05:56.883+0900 D/AUL     ( 3802): process_pool.c: __connect_to_launchpad(132) > send(3802) : 4
10-18 21:05:56.883+0900 D/AUL     ( 3802): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-18 21:05:56.883+0900 D/AUL_PAD ( 2908): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3802
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:c00012 fully_obscured 0
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-18 21:05:56.973+0900 I/APP_CORE( 2840): appcore-efl.c: __do_app(496) > [APP 2840] Event: RESUME State: PAUSED
10-18 21:05:56.973+0900 D/LAUNCH  ( 2840): appcore-efl.c: __do_app(597) > [indicator:Application:resume:start]
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __do_app(607) > [APP 2840] RESUME
10-18 21:05:56.973+0900 I/CAPI_APPFW_APPLICATION( 2840): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-18 21:05:56.973+0900 D/LAUNCH  ( 2840): appcore-efl.c: __do_app(636) > [indicator:Application:resume:done]
10-18 21:05:56.973+0900 D/LAUNCH  ( 2840): appcore-efl.c: __do_app(638) > [indicator:Application:Launching:done]
10-18 21:05:56.973+0900 D/APP_CORE( 2840): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-18 21:05:56.973+0900 E/APP_CORE( 2840): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-18 21:05:56.973+0900 D/AUL_PAD ( 3802): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-18 21:05:56.983+0900 D/AUL_PAD ( 3802): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-18 21:05:56.983+0900 D/AUL_PAD ( 3802): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-18 21:05:56.983+0900 D/AUL_PAD ( 3802): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-18 21:05:57.053+0900 W/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3794
10-18 21:05:57.063+0900 D/AUL_AMD ( 2778): amd_launch.c: __e17_status_handler(2891) > pid(2840) status(3)
10-18 21:05:57.063+0900 D/AUL_AMD ( 2778): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
10-18 21:05:57.063+0900 W/AUL_AMD ( 2778): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-18 21:05:57.063+0900 W/AUL_AMD ( 2778): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-18 21:05:57.063+0900 D/AUL_AMD ( 2778): amd_status.c: _status_update_app_info_list(456) > pid(2840) status(3)
10-18 21:05:57.083+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: x_event_window_property_cb(6298) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x2000002, atom : 479
10-18 21:05:57.083+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: x_event_window_property_cb(6373) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
10-18 21:05:57.103+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:57.123+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:57.123+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: x_event_window_property_cb(6298) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x2000002, atom : 479
10-18 21:05:57.123+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: x_event_window_property_cb(6373) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
10-18 21:05:57.123+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:57.123+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:57.533+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 5
10-18 21:05:57.533+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:57.733+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 6
10-18 21:05:57.743+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:57.913+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 7
10-18 21:05:57.923+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:58.003+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb833ac20, cursor pos : 8
10-18 21:05:58.003+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:58.373+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb833ac20
10-18 21:05:58.373+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-18 21:05:58.373+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb833ac20
10-18 21:05:58.373+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_out(251) > Enter
10-18 21:05:58.373+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb839cf70. set autocapital type : 0
10-18 21:05:58.383+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: slot_hide_candidate_table(4476) > Feedback deinitialize fail : -38404095
10-18 21:05:58.383+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: slot_hide_candidate_table(4483) > setting _show_candidate_requested to FALSE
10-18 21:05:58.383+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_in(245) > Enter
10-18 21:05:58.383+0900 D/ISE_DEFAULT( 3023): ise.cpp: ise_focus_in(824) > ic : ed30027 , 0 , g_ic : ed20027 , 0, g_focused_ic : 0 , 1
10-18 21:05:58.383+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb839cf70. on demand : 0
10-18 21:05:58.383+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-18 21:05:58.383+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 0
10-18 21:05:58.383+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:58.583+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 1
10-18 21:05:58.583+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb839cf70, bidi direction : 0x1
10-18 21:05:58.583+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:58.743+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 2
10-18 21:05:58.753+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:58.923+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 3
10-18 21:05:58.923+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:58.993+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 4
10-18 21:05:59.003+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:59.103+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 5
10-18 21:05:59.103+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:59.253+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 6
10-18 21:05:59.263+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:59.403+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 7
10-18 21:05:59.413+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:59.493+0900 W/APP_CORE( 2840): appcore-efl.c: __hide_cb(937) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:c00012
10-18 21:05:59.493+0900 D/APP_CORE( 2840): appcore-efl.c: __hide_cb(944) >  Go to Pasue state 
10-18 21:05:59.493+0900 I/APP_CORE( 2840): appcore-efl.c: __do_app(496) > [APP 2840] Event: PAUSE State: RUNNING
10-18 21:05:59.493+0900 D/APP_CORE( 2840): appcore-efl.c: __do_app(565) > [APP 2840] PAUSE
10-18 21:05:59.493+0900 I/CAPI_APPFW_APPLICATION( 2840): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-18 21:05:59.493+0900 D/APP_CORE( 2840): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-18 21:05:59.493+0900 E/APP_CORE( 2840): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-18 21:05:59.493+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 8
10-18 21:05:59.503+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:05:59.603+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x00c00012), visible:1
10-18 21:05:59.643+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb839cf70, cursor pos : 9
10-18 21:05:59.643+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:06:00.123+0900 D/APP_CORE( 2850): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-18 21:06:00.123+0900 I/APP_CORE( 2850): appcore-efl.c: __do_app(496) > [APP 2850] Event: MEM_FLUSH State: PAUSED
10-18 21:06:00.123+0900 D/APP_CORE( 2850): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-18 21:06:00.123+0900 D/APP_CORE( 2850): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2850
10-18 21:06:00.123+0900 D/APP_CORE( 2850): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-18 21:06:00.123+0900 D/RESOURCED( 2837): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2850
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 9:06 4 h"
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 9:06"
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 9&#x2236;06"
10-18 21:06:00.363+0900 D/INDICATOR( 2840): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146953714 Time: <font_size=33>9&#x2236;06</font_size> <font_size=32>PM</font_size></font>
10-18 21:06:00.803+0900 D/IMMODULE( 3794): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb839cf70
10-18 21:06:00.803+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-18 21:06:00.803+0900 D/IMMODULE( 3794): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb839cf70
10-18 21:06:00.803+0900 E/EFL     ( 3794): edje<3794> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-18 21:06:00.803+0900 E/EFL     ( 3794): By the power of Grayskull, your previous Embryo stack is now broken!
10-18 21:06:00.803+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_out(251) > Enter
10-18 21:06:00.813+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x201307 
10-18 21:06:00.913+0900 I/CAPI_NETWORK_CONNECTION( 3794): connection.c: connection_create(408) > New handle created[0xb83cec70]
10-18 21:06:00.913+0900 I/CAPI_NETWORK_CONNECTION( 3794): connection.c: connection_get_type(464) > Connected Network = 3
10-18 21:06:00.913+0900 I/tichat  ( 3794): Network connection type : 3
10-18 21:06:01.823+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x3000002
10-18 21:06:03.003+0900 E/E17     ( 2765): e_border.c: _e_border_cb_ping_poller(15414) > [ANR] - 1 time no response, org.example.tichat(3794,0x3000002)
10-18 21:06:03.003+0900 E/E17_EXTRA_MODULES( 2765): e_mod_anr.c: _e_mod_anr_dbus_msg_send(162) > [ANR][_e_mod_anr_dbus_msg_send] send dbus msg to resourced for 3794. type[0]
10-18 21:06:03.003+0900 E/RESOURCED( 2837): proc-monitor.c: edbus_signal_trigger(780) > Receive watchdog signal to pid: 3794(tichat)
10-18 21:06:03.813+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: ui_destroy_candidate_window(3256) > calling ui_candidate_hide (true)
10-18 21:06:03.813+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:06:03.813+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: get_ise_geometry(983) > angle : 0, w_angle : -1, mode : 0, Geometry : 0 1280 0 0
10-18 21:06:03.813+0900 W/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x3000002 FAILED!
10-18 21:06:03.813+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1043) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
10-18 21:06:03.813+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
10-18 21:06:03.813+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: candidate_window_hide(2222) > evas_object_hide (_candidate_window, 0x2000007)
10-18 21:06:04.503+0900 D/APP_CORE( 2840): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-18 21:06:04.503+0900 I/APP_CORE( 2840): appcore-efl.c: __do_app(496) > [APP 2840] Event: MEM_FLUSH State: PAUSED
10-18 21:06:04.503+0900 D/APP_CORE( 2840): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-18 21:06:04.503+0900 D/APP_CORE( 2840): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2840
10-18 21:06:04.503+0900 D/APP_CORE( 2840): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-18 21:06:04.503+0900 D/RESOURCED( 2837): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2840
10-18 21:06:05.923+0900 I/tichat  ( 3794): ERROR: Failed to fetch url (http://192.168.0.2:3000/login) - curl said: Timeout was reached
10-18 21:06:05.933+0900 I/tichat  ( 3794): CURL Returned: 
10-18 21:06:05.933+0900 I/tichat  ( 3794): 
10-18 21:06:05.963+0900 W/CRASH_MANAGER( 3807): worker.c: worker_job(1204) > 1103794746963147679236
