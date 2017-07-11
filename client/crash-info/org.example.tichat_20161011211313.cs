S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 3628
Date: 2016-10-11 21:13:13+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a658

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0x8001188d, esi = 0xb37d9c90
ebp = 0xbf9194e8, esp = 0xbf919460
eax = 0xb42c2000, ebx = 0xb37db92c
ecx = 0x8000a654, edx = 0x00000002
eip = 0xb37d9ac8

Memory Information
MemTotal:      250 KB
MemFree:       162 KB
Buffers:         3 KB
Cached:     162056 KB
VmPeak:      80284 KB
VmSize:      80284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15760 KB
VmRSS:       15760 KB
VmData:      20096 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3628 TID = 3628
3628 3653 3663 

Maps Information
b2cbf000 b2cc9000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ccf000 b2cdb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cdc000 b2cfd000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d02000 b2d03000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d04000 b2d09000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d0a000 b2d0c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d0d000 b2d0f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d10000 b2d1c000 r-xp /usr/lib/libdrm.so.2.4.0
b2d1d000 b2d20000 r-xp /usr/lib/libdri2.so.0.0.0
b2d21000 b2d2b000 r-xp /usr/lib/libtbm.so.1.0.0
b2d32000 b2d33000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d34000 b2d35000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d36000 b2d39000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d3a000 b2d3d000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d3e000 b2d53000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d54000 b2d66000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b366f000 b3675000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3676000 b37ba000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37ca000 b37cb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37cc000 b37cd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ce000 b37d7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37d8000 b37db000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37dc000 b3815000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4218000 b4223000 r-xp /lib/libnss_files-2.20-2014.11.so
b4225000 b4230000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4232000 b4249000 r-xp /lib/libnsl-2.20-2014.11.so
b424d000 b4255000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4257000 b427b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b427c000 b427d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b427e000 b4281000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4282000 b4289000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b428a000 b4294000 r-xp /usr/lib/libsensord-share.so
b4295000 b42b1000 r-xp /usr/lib/libsensor.so.1.2.0
b42b3000 b42bc000 r-xp /usr/lib/libappcore-common.so.1.1
b42bf000 b42c1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d6000 b42d8000 r-xp /usr/lib/libXau.so.6.0.0
b42d9000 b42fb000 r-xp /usr/lib/libxcb.so.1.1.0
b42fd000 b4306000 r-xp /lib/libcrypt-2.20-2014.11.so
b432f000 b4331000 r-xp /usr/lib/libiri.so
b4332000 b4358000 r-xp /lib/libexpat.so.1.5.2
b435a000 b43c5000 r-xp /usr/lib/libssl.so.1.0.0
b43cb000 b43d7000 r-xp /usr/lib/libethumb.so.1.13.0
b43d8000 b43dc000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43dd000 b462e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ba9000 b5bb9000 r-xp /usr/lib/libXi.so.6.1.0
b5bba000 b5bbc000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bbd000 b5bc3000 r-xp /usr/lib/libXtst.so.6.1.0
b5bc4000 b5bce000 r-xp /usr/lib/libXrender.so.1.3.0
b5bcf000 b5bd8000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bda000 b5bdc000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bdd000 b5be2000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be3000 b5bf5000 r-xp /usr/lib/libXext.so.6.4.0
b5bf6000 b5bf8000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bf9000 b5bfb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bfd000 b5d3f000 r-xp /usr/lib/libX11.so.6.3.0
b5d43000 b5d4d000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d4e000 b5d64000 r-xp /usr/lib/libudev.so.1.6.0
b5d67000 b5d6b000 r-xp /lib/libattr.so.1.1.0
b5d6c000 b5d9b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d9d000 b5da3000 r-xp /usr/lib/libffi.so.6.0.2
b5da4000 b5dc7000 r-xp /lib/libz.so.1.2.8
b5dc8000 b5dcb000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dcc000 b5f28000 r-xp /usr/lib/libxml2.so.2.9.2
b5f2e000 b6015000 r-xp /usr/lib/libstdc++.so.6.0.20
b6022000 b6025000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6026000 b6048000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6049000 b605d000 r-xp /lib/libresolv-2.20-2014.11.so
b6061000 b6085000 r-xp /usr/lib/liblzma.so.5.0.3
b6086000 b6088000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b608a000 b6094000 r-xp /usr/lib/libembryo.so.1.13.0
b6095000 b60be000 r-xp /usr/lib/libpng12.so.0.50.0
b60bf000 b6108000 r-xp /usr/lib/libjpeg.so.8.0.2
b6119000 b6120000 r-xp /lib/librt-2.20-2014.11.so
b6122000 b6141000 r-xp /usr/lib/libector.so.1.13.0
b6144000 b6171000 r-xp /usr/lib/liblua-5.1.so
b6172000 b6202000 r-xp /usr/lib/libfreetype.so.6.11.3
b6206000 b6244000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6245000 b625b000 r-xp /usr/lib/libfribidi.so.0.3.1
b625c000 b62b5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62b8000 b6303000 r-xp /lib/libm-2.20-2014.11.so
b6305000 b6317000 r-xp /usr/lib/libeio.so.1.13.0
b6318000 b631b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b631c000 b6322000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6323000 b6346000 r-xp /usr/lib/libefreet.so.1.13.0
b6349000 b6374000 r-xp /usr/lib/libeldbus.so.1.13.0
b6375000 b63a9000 r-xp /usr/lib/libecore_con.so.1.13.0
b63ab000 b63b4000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b5000 b63be000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63bf000 b63d2000 r-xp /usr/lib/libeo.so.1.13.0
b63d4000 b63e7000 r-xp /usr/lib/libecore_input.so.1.13.0
b63e8000 b63ef000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f0000 b6413000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6414000 b6440000 r-xp /usr/lib/libeet.so.1.13.0
b6449000 b64b4000 r-xp /usr/lib/libeina.so.1.13.0
b64b7000 b64ce000 r-xp /usr/lib/libefl.so.1.13.0
b64d0000 b6637000 r-xp /usr/lib/libicuuc.so.51.1
b6645000 b6851000 r-xp /usr/lib/libicui18n.so.51.1
b6859000 b68a8000 r-xp /usr/lib/libecore_x.so.1.13.0
b68aa000 b68c4000 r-xp /lib/libgcc_s-4.9.so.1
b68c6000 b68ca000 r-xp /lib/libcap.so.2.21
b68cb000 b6911000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6912000 b6919000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b691b000 b696d000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b696f000 b6afa000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aff000 b6bcd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd0000 b6bd4000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd5000 b6be4000 r-xp /usr/lib/libvconf.so.0.2.45
b6be5000 b6be8000 r-xp /usr/lib/libvasum.so.0.3.1
b6be9000 b6bec000 r-xp /usr/lib/libttrace.so.1.1
b6bee000 b6bf2000 r-xp /usr/lib/libiniparser.so.0
b6bf3000 b6c23000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c24000 b6c2d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c2e000 b6c53000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c54000 b6c64000 r-xp /usr/lib/libunwind.so.8.0.1
b6c6e000 b6e1c000 r-xp /lib/libc-2.20-2014.11.so
b6e24000 b6f67000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f69000 b6fc1000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc2000 b6ff6000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ff9000 b70cd000 r-xp /usr/lib/libedje.so.1.13.0
b70d0000 b70fc000 r-xp /usr/lib/libecore.so.1.13.0
b710d000 b7333000 r-xp /usr/lib/libevas.so.1.13.0
b735b000 b7373000 r-xp /lib/libpthread-2.20-2014.11.so
b7377000 b76f1000 r-xp /usr/lib/libelementary.so.1.13.0
b7711000 b7715000 r-xp /usr/lib/libsmack.so.1.0.0
b7716000 b771f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7720000 b7723000 r-xp /usr/lib/libdlog.so.0.0.0
b7724000 b7729000 r-xp /usr/lib/libbundle.so.0.1.22
b772a000 b772d000 r-xp /lib/libdl-2.20-2014.11.so
b772f000 b7754000 r-xp /usr/lib/libaul.so.0.1.0
b7757000 b7759000 r-xp /usr/lib/libappsvc.so.0.1.0
b775a000 b775f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7760000 b7767000 r-xp /usr/lib/libappcore-efl.so.1.1
b7769000 b776e000 r-xp /usr/lib/libsys-assert.so
b7771000 b7772000 r-xp [vdso]
b7772000 b7794000 r-xp /lib/ld-2.20-2014.11.so
b7796000 b779e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3628)
Call Stack Count: 9
 0: first_page + 0x168 (0xb37d9ac8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1ac8
 1: create_base_gui + 0x1b8 (0xb37d9858) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1858
 2: app_create + 0x2c (0xb37d94fc) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x14fc
 3: (0xb775c65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 4: appcore_efl_main + 0x327 (0xb7763c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 5: ui_app_main + 0x140 (0xb775cc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x279 (0xb37d9469) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1469
 7: popup_block_clicked + 0x18 (0xb7798148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7798148
 8: __libc_start_main + 0xde (0xb6c85e4e) [/lib/libc.so.6] + 0x17e4e
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
d(1592) >  Stop boost timer of Apps view by [1]
10-11 21:13:10.769+0900 D/APP_CORE( 3634): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-11 21:13:10.769+0900 D/APP_CORE( 3634): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.timer/res/locale
10-11 21:13:10.769+0900 D/APP_CORE( 3634): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-11 21:13:10.779+0900 D/APP_CORE( 3634): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-11 21:13:10.779+0900 D/AUL     ( 3634): app_sock.c: __create_server_sock(156) > pg path - already exists
10-11 21:13:10.779+0900 D/APP_CORE( 3634): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb6ed5520
10-11 21:13:10.779+0900 D/LAUNCH  ( 3634): appcore-efl.c: __before_loop(1136) > [timer:Platform:appcore_init:done]
10-11 21:13:10.779+0900 I/CAPI_APPFW_APPLICATION( 3634): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-11 21:13:10.849+0900 E/RESOURCED( 2836): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
10-11 21:13:10.919+0900 D/AUL_AMD ( 2780): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:13:10.919+0900 D/RUA     ( 2780): rua.c: rua_add_history(179) > rua_add_history start
10-11 21:13:10.929+0900 D/RUA     ( 2780): rua.c: rua_add_history(247) > rua_add_history ok
10-11 21:13:11.189+0900 E/EFL     ( 3634): eo<3634> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
10-11 21:13:11.189+0900 E/EFL     ( 3634): eo<3634> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
10-11 21:13:11.189+0900 E/EFL     ( 3634): eo<3634> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
10-11 21:13:11.189+0900 D/LAUNCH  ( 3634): appcore-efl.c: __before_loop(1154) > [timer:Application:create:done]
10-11 21:13:11.189+0900 E/E17     ( 2800): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02c00003)
10-11 21:13:11.199+0900 D/APP_CORE( 3634): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-11 21:13:11.199+0900 E/E17     ( 2800): e_border.c: e_border_show(2088) > BD_SHOW(0x02c00003)
10-11 21:13:11.199+0900 W/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3634
10-11 21:13:11.199+0900 E/EFL     ( 2800): eo<2800> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-11 21:13:11.199+0900 E/EFL     ( 2800): eo<2800> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-11 21:13:11.209+0900 D/INDICATOR( 2839): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-11 21:13:11.209+0900 D/INDICATOR( 2839): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-11 21:13:11.209+0900 D/INDICATOR( 2839): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-11 21:13:11.209+0900 D/INDICATOR( 2839): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-11 21:13:11.209+0900 D/INDICATOR( 2839): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-11 21:13:11.209+0900 D/INDICATOR( 2839): main.c: _rotate_window(252) > port :: hide more icon
10-11 21:13:11.219+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 15
10-11 21:13:11.219+0900 D/PKGMGR_INFO( 2780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.timer/bin/timer' and package_app_info.app_disable IN ('false','False')
10-11 21:13:11.219+0900 D/PKGMGR_INFO( 2780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.timer/bin/timer' and package_app_info.app_disable IN ('false','False')
10-11 21:13:11.219+0900 D/AUL_AMD ( 2780): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3634 is org.example.timer
10-11 21:13:11.219+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3634 : 0
10-11 21:13:11.219+0900 D/AUL     ( 2924): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 26
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore.c: __aul_handler(587) > [APP 3634]     AUL event: AUL_START
10-11 21:13:11.219+0900 I/APP_CORE( 3634): appcore-efl.c: __do_app(496) > [APP 3634] Event: RESET State: CREATED
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore-efl.c: __do_app(527) > [APP 3634] RESET
10-11 21:13:11.219+0900 D/LAUNCH  ( 3634): appcore-efl.c: __do_app(529) > [timer:Application:reset:start]
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:13:11.219+0900 I/CAPI_APPFW_APPLICATION( 3634): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-11 21:13:11.219+0900 D/LAUNCH  ( 3634): appcore-efl.c: __do_app(544) > [timer:Application:reset:done]
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
10-11 21:13:11.219+0900 E/EFL     ( 3634): edje<3634> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:13:11.219+0900 E/EFL     ( 3634): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:13:11.219+0900 E/EFL     ( 3634): edje<3634> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:13:11.219+0900 E/EFL     ( 3634): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:13:11.219+0900 E/EFL     ( 3634): edje<3634> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:13:11.219+0900 E/EFL     ( 3634): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:13:11.219+0900 E/EFL     ( 3634): edje<3634> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:13:11.219+0900 E/EFL     ( 3634): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:13:11.219+0900 E/EFL     ( 3634): edje<3634> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:13:11.219+0900 E/EFL     ( 3634): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:13:11.219+0900 W/APP_CORE( 3634): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00003
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00003
10-11 21:13:11.219+0900 D/APP_CORE( 3634): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-11 21:13:11.219+0900 D/AUL     ( 3634): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-11 21:13:11.229+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 34
10-11 21:13:11.339+0900 D/APP_CORE( 3634): appcore.c: __prt_ltime(236) > [APP 3634] first idle after reset: 729 msec
10-11 21:13:11.479+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(588) > sleeping 1 sec...
10-11 21:13:11.479+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-11 21:13:11.479+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b977a760
10-11 21:13:11.479+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(69) > get pre-initialization function
10-11 21:13:11.479+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(73) > get shutdown function
10-11 21:13:11.479+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b977aa40
10-11 21:13:11.489+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b977c640
10-11 21:13:11.489+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(69) > get pre-initialization function
10-11 21:13:11.489+0900 D/AUL_PAD ( 3628): preload.h: __preload_init(73) > get shutdown function
10-11 21:13:11.489+0900 D/AUL_PAD ( 3628): preexec.h: __preexec_init(76) > preexec start
10-11 21:13:11.489+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-11 21:13:11.489+0900 D/AUL     ( 3628): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-11 21:13:11.489+0900 D/AUL     ( 3628): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-11 21:13:11.489+0900 D/AUL     ( 3628): process_pool.c: __connect_to_launchpad(132) > send(3628) : 4
10-11 21:13:11.489+0900 D/AUL     ( 3628): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-11 21:13:11.489+0900 D/AUL_PAD ( 2909): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3628
10-11 21:13:11.489+0900 E/E17     ( 2800): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-11 21:13:11.489+0900 D/APP_CORE( 2848): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-11 21:13:11.489+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-11 21:13:11.489+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-11 21:13:11.489+0900 I/APP_CORE( 2848): appcore-efl.c: __do_app(496) > [APP 2848] Event: PAUSE State: RUNNING
10-11 21:13:11.489+0900 D/APP_CORE( 2848): appcore-efl.c: __do_app(565) > [APP 2848] PAUSE
10-11 21:13:11.489+0900 I/CAPI_APPFW_APPLICATION( 2848): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-11 21:13:11.489+0900 E/cluster-home( 2848): homescreen.cpp: OnPause(84) >  app pause
10-11 21:13:11.489+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-11 21:13:11.489+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppPause(923) >  END
10-11 21:13:11.489+0900 D/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-11 21:13:11.489+0900 E/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-11 21:13:11.489+0900 D/APP_CORE( 3634): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00003 fully_obscured 0
10-11 21:13:11.489+0900 D/APP_CORE( 3634): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-11 21:13:11.489+0900 D/APP_CORE( 3634): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-11 21:13:11.489+0900 I/APP_CORE( 3634): appcore-efl.c: __do_app(496) > [APP 3634] Event: RESUME State: CREATED
10-11 21:13:11.489+0900 D/LAUNCH  ( 3634): appcore-efl.c: __do_app(597) > [timer:Application:resume:start]
10-11 21:13:11.489+0900 D/APP_CORE( 3634): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-11 21:13:11.489+0900 D/APP_CORE( 3634): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:13:11.489+0900 D/APP_CORE( 3634): appcore-efl.c: __do_app(607) > [APP 3634] RESUME
10-11 21:13:11.489+0900 D/PKGMGR_INFO( 3634): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.timer/bin/timer' and package_app_info.app_disable IN ('false','False')
10-11 21:13:11.489+0900 D/PKGMGR_INFO( 3634): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.timer/bin/timer' and package_app_info.app_disable IN ('false','False')
10-11 21:13:11.489+0900 D/AUL     ( 3634): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 3634 is org.example.timer
10-11 21:13:11.499+0900 I/APP_CORE( 3634): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-11 21:13:11.499+0900 I/APP_CORE( 3634): appcore-efl.c: __do_app(614) > [APP 3634] Initial Launching, call the resume_cb
10-11 21:13:11.499+0900 I/CAPI_APPFW_APPLICATION( 3634): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-11 21:13:11.499+0900 D/LAUNCH  ( 3634): appcore-efl.c: __do_app(636) > [timer:Application:resume:done]
10-11 21:13:11.499+0900 D/LAUNCH  ( 3634): appcore-efl.c: __do_app(638) > [timer:Application:Launching:done]
10-11 21:13:11.499+0900 D/APP_CORE( 3634): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-11 21:13:11.499+0900 E/APP_CORE( 3634): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-11 21:13:11.499+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(2848) status(4)
10-11 21:13:11.499+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(468) > pid(2848) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-11 21:13:11.499+0900 D/AUL     ( 2780): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-11 21:13:11.499+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2848, appid: org.tizen.homescreen, status: bg
10-11 21:13:11.499+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2891) > pid(3634) status(3)
10-11 21:13:11.499+0900 D/AUL_AMD ( 2780): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
10-11 21:13:11.499+0900 D/DATA_PROVIDER_MASTER( 2911): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2848 is paused
10-11 21:13:11.499+0900 D/DATA_PROVIDER_MASTER( 2911): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-11 21:13:11.519+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2897) > back key ungrab
10-11 21:13:11.519+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(3634) status(3)
10-11 21:13:11.519+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(468) > pid(3634) appid(org.example.timer) pkgid(org.example.timer) status(3)
10-11 21:13:11.519+0900 D/AUL     ( 2780): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.timer
10-11 21:13:11.519+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3634, appid: org.example.timer, status: fg
10-11 21:13:11.519+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2910) > pid(3634) status(0)
10-11 21:13:11.519+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3634
10-11 21:13:11.519+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3634, proc_name: org.example.timer, cg_name: foreground, oom_score_adj: 200
10-11 21:13:11.519+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3634
10-11 21:13:11.569+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3634, appname = org.example.timer, pkgname = org.example.timer
10-11 21:13:11.569+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3634, appname = org.example.timer
10-11 21:13:11.569+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3634
10-11 21:13:11.569+0900 I/RESOURCED( 2836): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-11 21:13:11.569+0900 I/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-11 21:13:11.569+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-11 21:13:11.579+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-11 21:13:11.579+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-11 21:13:11.579+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-11 21:13:12.199+0900 D/AUL_AMD ( 2780): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.timer /opt/usr/apps/org.example.timer/bin/timer
10-11 21:13:12.199+0900 D/RUA     ( 2780): rua.c: rua_add_history(179) > rua_add_history start
10-11 21:13:12.209+0900 D/RUA     ( 2780): rua.c: rua_add_history(247) > rua_add_history ok
10-11 21:13:12.859+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2891) > pid(2848) status(3)
10-11 21:13:12.859+0900 D/AUL_AMD ( 2780): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
10-11 21:13:12.859+0900 W/AUL_AMD ( 2780): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-11 21:13:12.859+0900 W/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-11 21:13:12.859+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(2848) status(3)
10-11 21:13:12.859+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(468) > pid(2848) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
10-11 21:13:12.859+0900 D/AUL     ( 2780): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
10-11 21:13:12.859+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2848, appid: org.tizen.homescreen, status: fg
10-11 21:13:12.859+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2848
10-11 21:13:12.859+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2848, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
10-11 21:13:12.859+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2848, appname = org.tizen.homescreen
10-11 21:13:12.859+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2848
10-11 21:13:12.879+0900 E/E17     ( 2800): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
10-11 21:13:12.879+0900 E/E17     ( 2800): e_border.c: _e_border_window_pending_event_send(16228) > Set ICONIFY BY CLIENT [2c00003]
10-11 21:13:12.879+0900 E/E17     ( 2800): e_border.c: e_border_hide(2248) > BD_HIDE(0x02c00003), visible:1
10-11 21:13:12.879+0900 E/EFL     ( 2800): eo<2800> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-11 21:13:12.889+0900 W/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2848
10-11 21:13:12.939+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(3634) status(4)
10-11 21:13:12.939+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(468) > pid(3634) appid(org.example.timer) pkgid(org.example.timer) status(4)
10-11 21:13:12.939+0900 D/AUL     ( 2780): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.timer
10-11 21:13:12.939+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3634, appid: org.example.timer, status: bg
10-11 21:13:12.939+0900 D/APP_CORE( 3634): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00003 fully_obscured 1
10-11 21:13:12.939+0900 D/APP_CORE( 3634): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-11 21:13:12.939+0900 D/APP_CORE( 3634): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-11 21:13:12.939+0900 I/APP_CORE( 3634): appcore-efl.c: __do_app(496) > [APP 3634] Event: PAUSE State: RUNNING
10-11 21:13:12.939+0900 D/APP_CORE( 3634): appcore-efl.c: __do_app(565) > [APP 3634] PAUSE
10-11 21:13:12.939+0900 I/CAPI_APPFW_APPLICATION( 3634): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-11 21:13:12.939+0900 D/APP_CORE( 3634): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-11 21:13:12.939+0900 E/APP_CORE( 3634): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-11 21:13:12.939+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 3634, appname = org.example.timer, pkgname = org.example.timer
10-11 21:13:12.939+0900 D/RESOURCED( 2836): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 3634, appname = org.example.timer
10-11 21:13:12.939+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3634
10-11 21:13:12.939+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2850 increase lru 5
10-11 21:13:12.939+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2850 set score 420 (before 390)
10-11 21:13:12.939+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.example.timer
10-11 21:13:12.939+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3634, proc_name: org.example.timer, cg_name: favorite, oom_score_adj: 270
10-11 21:13:12.939+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 3634
10-11 21:13:12.939+0900 D/INDICATOR( 2839): main.c: _property_changed_cb(432) > UNSNIFF API 2c00003
10-11 21:13:12.939+0900 D/INDICATOR( 2839): util.c: util_signal_emit_by_win(116) > emission bg.translucent
10-11 21:13:12.939+0900 D/INDICATOR( 2839): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-11 21:13:12.939+0900 D/INDICATOR( 2839): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-11 21:13:12.939+0900 D/INDICATOR( 2839): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-11 21:13:12.939+0900 D/INDICATOR( 2839): main.c: _rotate_window(252) > port :: hide more icon
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-11 21:13:12.999+0900 I/APP_CORE( 2848): appcore-efl.c: __do_app(496) > [APP 2848] Event: RESUME State: PAUSED
10-11 21:13:12.999+0900 D/LAUNCH  ( 2848): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __do_app(607) > [APP 2848] RESUME
10-11 21:13:12.999+0900 I/CAPI_APPFW_APPLICATION( 2848): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-11 21:13:12.999+0900 E/cluster-home( 2848): homescreen.cpp: OnResume(66) >  app resume
10-11 21:13:12.999+0900 D/cluster-home( 2848): widget-data-provider.cpp: SetBoxVisibility(1543) >  
10-11 21:13:12.999+0900 D/cluster-home( 2848): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
10-11 21:13:12.999+0900 D/WIDGET_VIEWER( 2848): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.tizen.calendar.widget] visibility is changed 0x[0]
10-11 21:13:12.999+0900 D/cluster-home( 2848): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
10-11 21:13:12.999+0900 D/cluster-home( 2848): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
10-11 21:13:12.999+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
10-11 21:13:12.999+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppResume(910) >  END
10-11 21:13:12.999+0900 D/cluster-view( 2848): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
10-11 21:13:12.999+0900 D/cluster-view( 2848): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
10-11 21:13:12.999+0900 D/cluster-view( 2848): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
10-11 21:13:12.999+0900 D/cluster-view( 2848): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
10-11 21:13:12.999+0900 D/cluster-view( 2848): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
10-11 21:13:12.999+0900 D/cluster-view( 2848): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
10-11 21:13:12.999+0900 D/test-log( 2848): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
10-11 21:13:12.999+0900 D/test-log( 2848): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
10-11 21:13:12.999+0900 E/EFL     ( 2800): eo<2800> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-11 21:13:12.999+0900 D/cluster-view( 2848): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
10-11 21:13:12.999+0900 D/cluster-home( 2848): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
10-11 21:13:12.999+0900 D/LAUNCH  ( 2848): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
10-11 21:13:12.999+0900 D/LAUNCH  ( 2848): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
10-11 21:13:12.999+0900 D/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-11 21:13:12.999+0900 E/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-11 21:13:13.009+0900 I/TIZEN_N_SOUND_MANAGER( 2924): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
10-11 21:13:13.009+0900 E/TIZEN_N_SOUND_MANAGER( 2924): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
10-11 21:13:13.009+0900 I/TIZEN_N_SOUND_MANAGER( 2924): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
10-11 21:13:13.009+0900 E/TIZEN_N_SOUND_MANAGER( 2924): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
10-11 21:13:13.009+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 15
10-11 21:13:13.009+0900 D/PKGMGR_INFO( 2780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-11 21:13:13.009+0900 D/PKGMGR_INFO( 2780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-11 21:13:13.009+0900 D/AUL_AMD ( 2780): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2848 is org.tizen.homescreen
10-11 21:13:13.009+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2848 : 0
10-11 21:13:13.009+0900 D/AUL     ( 2924): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
10-11 21:13:13.019+0900 D/DATA_PROVIDER_MASTER( 2911): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
10-11 21:13:13.029+0900 D/DATA_PROVIDER_MASTER( 2911): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2848 is resumed
10-11 21:13:13.029+0900 D/DATA_PROVIDER_MASTER( 2911): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
10-11 21:13:13.029+0900 E/DATA_PROVIDER_MASTER( 2911): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
10-11 21:13:13.029+0900 I/CAPI_WIDGET_APPLICATION( 3007): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
10-11 21:13:13.029+0900 I/CAPI_WIDGET_APPLICATION( 3007): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
10-11 21:13:13.029+0900 W/AUL     ( 3007): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3007, appid: org.tizen.calendar.widget, status: fg
10-11 21:13:13.029+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3007
10-11 21:13:13.029+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3007, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
10-11 21:13:13.029+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3007
10-11 21:13:13.069+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3007, appname = org.tizen.calendar.widget
10-11 21:13:13.069+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3007
10-11 21:13:13.069+0900 I/RESOURCED( 2836): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-11 21:13:13.069+0900 I/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-11 21:13:13.309+0900 D/cluster-view( 2848): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
10-11 21:13:13.309+0900 D/cluster-view( 2848): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
10-11 21:13:13.309+0900 D/cluster-view( 2848): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
10-11 21:13:13.309+0900 D/test-log( 2848): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
10-11 21:13:13.309+0900 D/test-log( 2848): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
10-11 21:13:13.309+0900 D/cluster-view( 2848): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
10-11 21:13:13.309+0900 D/cluster-home( 2848): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
10-11 21:13:13.509+0900 E/EFL     ( 3625): eldbus<3625> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-1bEmJtzwsL: Connection refused
10-11 21:13:13.509+0900 E/EFL     ( 3625): <3625> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
10-11 21:13:13.509+0900 E/EFL     ( 3625): elementary<3625> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
10-11 21:13:13.509+0900 D/APP_CORE( 3625): appcore.c: __aul_handler(587) > [APP 3625]     AUL event: AUL_START
10-11 21:13:13.509+0900 I/APP_CORE( 3625): appcore-efl.c: __do_app(496) > [APP 3625] Event: RESET State: CREATED
10-11 21:13:13.509+0900 D/APP_CORE( 3625): appcore-efl.c: __do_app(527) > [APP 3625] RESET
10-11 21:13:13.509+0900 D/LAUNCH  ( 3625): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
10-11 21:13:13.509+0900 D/APP_CORE( 3625): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-11 21:13:13.509+0900 D/APP_CORE( 3625): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:13:13.509+0900 E/SYSPOPUP( 3625): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
10-11 21:13:13.509+0900 E/SYSPOPUP( 3625): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
10-11 21:13:13.509+0900 E/SYSPOPUP( 3625): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
10-11 21:13:13.509+0900 D/LAUNCH  ( 3625): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
10-11 21:13:13.509+0900 D/APP_CORE( 3625): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-11 21:13:13.619+0900 D/AUL     ( 3625): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
10-11 21:13:13.619+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 22
10-11 21:13:13.619+0900 W/AUL_AMD ( 2780): amd_request.c: __request_handler(1056) > app status : 5
10-11 21:13:13.619+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(3625) status(5)
10-11 21:13:13.619+0900 D/APP_CORE( 3625): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
10-11 21:13:13.619+0900 E/EFL     ( 3625): eo<3625> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
10-11 21:13:13.619+0900 E/EFL     ( 3625): eo<3625> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
10-11 21:13:13.729+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
10-11 21:13:13.729+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
10-11 21:13:13.859+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
10-11 21:13:13.859+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
10-11 21:13:13.859+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
10-11 21:13:13.859+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
10-11 21:13:13.859+0900 D/test-log( 2848): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[291.00][798.00] to[291.00][798.00]!
10-11 21:13:13.859+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
10-11 21:13:13.859+0900 D/cluster-home( 2848): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [16]MenuBox clicked
10-11 21:13:13.859+0900 D/cluster-home( 2848): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
10-11 21:13:13.859+0900 D/AUL     ( 2848): service.c: __set_bundle(186) > __set_bundle
10-11 21:13:13.859+0900 D/AUL     ( 2848): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
10-11 21:13:13.859+0900 D/AUL     ( 2848): service.c: __set_bundle(186) > __set_bundle
10-11 21:13:13.859+0900 D/AUL     ( 2848): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.tichat - no result
10-11 21:13:13.859+0900 D/AUL     ( 2848): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.tichat
10-11 21:13:13.859+0900 D/AUL     ( 2848): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
10-11 21:13:13.859+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 0
10-11 21:13:13.859+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-11 21:13:13.859+0900 W/AUL_AMD ( 2780): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
10-11 21:13:13.859+0900 W/AUL_AMD ( 2780): amd_launch.c: _start_app(2233) > caller pid : 2848
10-11 21:13:13.859+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2443) > win(600002) ecore_x_pointer_grab(1)
10-11 21:13:13.859+0900 D/AUL_AMD ( 2780): amd_key.c: _key_grab(243) > _key_grab, win : 600002
10-11 21:13:13.859+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2448) > back key grab
10-11 21:13:13.859+0900 W/AUL_AMD ( 2780): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-11 21:13:13.859+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-11 21:13:13.859+0900 D/RESOURCED( 2836): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-11 21:13:13.859+0900 E/RESOURCED( 2836): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-11 21:13:13.859+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
10-11 21:13:13.869+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2648) > process_pool: false
10-11 21:13:13.869+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-11 21:13:13.869+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-11 21:13:13.869+0900 W/AUL_AMD ( 2780): amd_launch.c: _start_app(2665) > pad pid(-5)
10-11 21:13:13.869+0900 D/AUL_AMD ( 2780): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-11 21:13:13.869+0900 D/AUL_AMD ( 2780): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-11 21:13:13.869+0900 D/AUL     ( 2780): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-11 21:13:13.869+0900 W/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-11 21:13:13.869+0900 D/AUL     ( 2909): process_pool.c: __send_pkt_raw_data(219) > send(12) : 876 / 876
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 3628, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:13:13.869+0900 W/AUL_PAD ( 2909): launchpad.c: __send_result_to_caller(265) > Check app launching
10-11 21:13:13.869+0900 D/AUL_PAD ( 2909): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 876, pkt->len: 868
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-11 21:13:13.869+0900 D/AUL     ( 3628): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3653) is sent.
10-11 21:13:13.869+0900 D/AUL     ( 3628): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3653, signo: 10
10-11 21:13:13.869+0900 D/AUL     ( 3628): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OAAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AEwAAAG9yZy5leGFtcGxlLnRpY2hhdAA=##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzYxODc5OTMvODY2OTMzAA==##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODQ4AA==##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 14
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-11 21:13:13.869+0900 D/AUL_PAD ( 3628): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-11 21:13:13.869+0900 I/CAPI_APPFW_APPLICATION( 3628): app_main.c: ui_app_main(788) > app_efl_main
10-11 21:13:13.869+0900 D/LAUNCH  ( 3628): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-11 21:13:13.869+0900 D/APP_CORE( 3628): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-11 21:13:13.869+0900 D/APP_CORE( 3628): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-11 21:13:13.869+0900 D/APP_CORE( 3628): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-11 21:13:13.869+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20004e 
10-11 21:13:13.879+0900 D/APP_CORE( 3628): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-11 21:13:13.879+0900 D/AUL     ( 3628): app_sock.c: __create_server_sock(156) > pg path - already exists
10-11 21:13:13.879+0900 D/APP_CORE( 3628): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42bc520
10-11 21:13:13.879+0900 D/LAUNCH  ( 3628): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-11 21:13:13.879+0900 I/CAPI_APPFW_APPLICATION( 3628): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-11 21:13:13.949+0900 W/CRASH_MANAGER( 3478): worker.c: worker_job(1204) > 1103628746963147618799
