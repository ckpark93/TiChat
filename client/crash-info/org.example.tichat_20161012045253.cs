S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 12706
Date: 2016-10-12 04:52:53+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a65c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb73444c8, esi = 0x8000a654
ebp = 0xbfb43d38, esp = 0xbfb43ce0
eax = 0xb37ec1f4, ebx = 0xb63e32b8
ecx = 0x8000a654, edx = 0x8003eff8
eip = 0xb37e78df

Memory Information
MemTotal:      250 KB
MemFree:       147 KB
Buffers:         7 KB
Cached:     175044 KB
VmPeak:     109008 KB
VmSize:     109008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23524 KB
VmRSS:       23524 KB
VmData:      43052 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33480 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12706 TID = 12706
12706 12712 12723 12729 12753 

Maps Information
b2c27000 b2c2e000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2c2f000 b2c47000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2c48000 b2c4f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2ccc000 b2cd6000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cdc000 b2ce8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ce9000 b2d0a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d0f000 b2d10000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d11000 b2d16000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d17000 b2d18000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d19000 b2d1b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d1c000 b2d1e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d1f000 b2d2b000 r-xp /usr/lib/libdrm.so.2.4.0
b2d2c000 b2d2f000 r-xp /usr/lib/libdri2.so.0.0.0
b2d30000 b2d3a000 r-xp /usr/lib/libtbm.so.1.0.0
b2d3b000 b2d3c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2d43000 b2d44000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d45000 b2d46000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d47000 b2d4a000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d4b000 b2d4e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d4f000 b2d64000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d65000 b2d77000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3680000 b3686000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3687000 b37cb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37dc000 b37e5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37e6000 b37ec000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37ed000 b3826000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4229000 b4234000 r-xp /lib/libnss_files-2.20-2014.11.so
b4236000 b4241000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4243000 b425a000 r-xp /lib/libnsl-2.20-2014.11.so
b425e000 b4266000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4268000 b428c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b428d000 b428e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b428f000 b4292000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4293000 b429a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b429b000 b42a5000 r-xp /usr/lib/libsensord-share.so
b42a6000 b42c2000 r-xp /usr/lib/libsensor.so.1.2.0
b42c4000 b42cd000 r-xp /usr/lib/libappcore-common.so.1.1
b42d0000 b42d2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42e7000 b42e9000 r-xp /usr/lib/libXau.so.6.0.0
b42ea000 b430c000 r-xp /usr/lib/libxcb.so.1.1.0
b430e000 b4317000 r-xp /lib/libcrypt-2.20-2014.11.so
b4340000 b4342000 r-xp /usr/lib/libiri.so
b4343000 b4369000 r-xp /lib/libexpat.so.1.5.2
b436b000 b43d6000 r-xp /usr/lib/libssl.so.1.0.0
b43dc000 b43e8000 r-xp /usr/lib/libethumb.so.1.13.0
b43e9000 b43ed000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ee000 b463f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bba000 b5bca000 r-xp /usr/lib/libXi.so.6.1.0
b5bcb000 b5bcd000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bce000 b5bd4000 r-xp /usr/lib/libXtst.so.6.1.0
b5bd5000 b5bdf000 r-xp /usr/lib/libXrender.so.1.3.0
b5be0000 b5be9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5beb000 b5bed000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bee000 b5bf3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bf4000 b5c06000 r-xp /usr/lib/libXext.so.6.4.0
b5c07000 b5c09000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c0e000 b5d50000 r-xp /usr/lib/libX11.so.6.3.0
b5d54000 b5d5e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d5f000 b5d75000 r-xp /usr/lib/libudev.so.1.6.0
b5d78000 b5d7c000 r-xp /lib/libattr.so.1.1.0
b5d7d000 b5dac000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dae000 b5db4000 r-xp /usr/lib/libffi.so.6.0.2
b5db5000 b5dd8000 r-xp /lib/libz.so.1.2.8
b5dd9000 b5ddc000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5ddd000 b5f39000 r-xp /usr/lib/libxml2.so.2.9.2
b5f3f000 b6026000 r-xp /usr/lib/libstdc++.so.6.0.20
b6033000 b6036000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6037000 b6059000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b605a000 b606e000 r-xp /lib/libresolv-2.20-2014.11.so
b6072000 b6096000 r-xp /usr/lib/liblzma.so.5.0.3
b6097000 b6099000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b609b000 b60a5000 r-xp /usr/lib/libembryo.so.1.13.0
b60a6000 b60cf000 r-xp /usr/lib/libpng12.so.0.50.0
b60d0000 b6119000 r-xp /usr/lib/libjpeg.so.8.0.2
b612a000 b6131000 r-xp /lib/librt-2.20-2014.11.so
b6133000 b6152000 r-xp /usr/lib/libector.so.1.13.0
b6155000 b6182000 r-xp /usr/lib/liblua-5.1.so
b6183000 b6213000 r-xp /usr/lib/libfreetype.so.6.11.3
b6217000 b6255000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6256000 b626c000 r-xp /usr/lib/libfribidi.so.0.3.1
b626d000 b62c6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c9000 b6314000 r-xp /lib/libm-2.20-2014.11.so
b6316000 b6328000 r-xp /usr/lib/libeio.so.1.13.0
b6329000 b632c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b632d000 b6333000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6334000 b6357000 r-xp /usr/lib/libefreet.so.1.13.0
b635a000 b6385000 r-xp /usr/lib/libeldbus.so.1.13.0
b6386000 b63ba000 r-xp /usr/lib/libecore_con.so.1.13.0
b63bc000 b63c5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63c6000 b63cf000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63d0000 b63e3000 r-xp /usr/lib/libeo.so.1.13.0
b63e5000 b63f8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f9000 b6400000 r-xp /usr/lib/libecore_file.so.1.13.0
b6401000 b6424000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6425000 b6451000 r-xp /usr/lib/libeet.so.1.13.0
b645a000 b64c5000 r-xp /usr/lib/libeina.so.1.13.0
b64c8000 b64df000 r-xp /usr/lib/libefl.so.1.13.0
b64e1000 b6648000 r-xp /usr/lib/libicuuc.so.51.1
b6656000 b6862000 r-xp /usr/lib/libicui18n.so.51.1
b686a000 b68b9000 r-xp /usr/lib/libecore_x.so.1.13.0
b68bb000 b68d5000 r-xp /lib/libgcc_s-4.9.so.1
b68d7000 b68db000 r-xp /lib/libcap.so.2.21
b68dc000 b6922000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6923000 b692a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b692c000 b697e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6980000 b6b0b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b10000 b6bde000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6be1000 b6be5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6be6000 b6bf5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bf6000 b6bf9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bfa000 b6bfd000 r-xp /usr/lib/libttrace.so.1.1
b6bff000 b6c03000 r-xp /usr/lib/libiniparser.so.0
b6c04000 b6c34000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c35000 b6c3e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c3f000 b6c64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c65000 b6c75000 r-xp /usr/lib/libunwind.so.8.0.1
b6c7f000 b6e2d000 r-xp /lib/libc-2.20-2014.11.so
b6e35000 b6f78000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f7a000 b6fd2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fd3000 b7007000 r-xp /usr/lib/libsystemd.so.0.4.0
b700a000 b70de000 r-xp /usr/lib/libedje.so.1.13.0
b70e1000 b710d000 r-xp /usr/lib/libecore.so.1.13.0
b711e000 b7344000 r-xp /usr/lib/libevas.so.1.13.0
b736c000 b7384000 r-xp /lib/libpthread-2.20-2014.11.so
b7388000 b7702000 r-xp /usr/lib/libelementary.so.1.13.0
b7722000 b7726000 r-xp /usr/lib/libsmack.so.1.0.0
b7727000 b7730000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7731000 b7734000 r-xp /usr/lib/libdlog.so.0.0.0
b7735000 b773a000 r-xp /usr/lib/libbundle.so.0.1.22
b773b000 b773e000 r-xp /lib/libdl-2.20-2014.11.so
b7740000 b7765000 r-xp /usr/lib/libaul.so.0.1.0
b7768000 b776a000 r-xp /usr/lib/libappsvc.so.0.1.0
b776b000 b7770000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7771000 b7778000 r-xp /usr/lib/libappcore-efl.so.1.1
b777a000 b777f000 r-xp /usr/lib/libsys-assert.so
b7782000 b7783000 r-xp [vdso]
b7783000 b77a5000 r-xp /lib/ld-2.20-2014.11.so
b77a7000 b77af000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12706)
Call Stack Count: 21
 0: signup_cb + 0x2f (0xb37e78df) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x18df
 1: (0xb71a7116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63de319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63dbd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71a99e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb745a404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb708df39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7094a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb708efdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb708f4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb708f68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70f4702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70ee055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70f71b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70f7587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb755022d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7774dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb776dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x278 (0xb37e8e38) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2e38
19: create_button_field + 0x8 (0xb77a9148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb77a9148
20: __libc_start_main + 0xde (0xb6c96e4e) [/lib/libc.so.6] + 0x17e4e
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
5+0900 D/cluster-view( 2867): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
10-12 04:52:50.715+0900 D/cluster-view( 2867): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
10-12 04:52:50.715+0900 D/cluster-view( 2867): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
10-12 04:52:50.715+0900 D/test-log( 2867): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
10-12 04:52:50.715+0900 D/test-log( 2867): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
10-12 04:52:50.715+0900 D/cluster-view( 2867): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
10-12 04:52:50.715+0900 D/cluster-home( 2867): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
10-12 04:52:50.715+0900 D/LAUNCH  ( 2867): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
10-12 04:52:50.715+0900 D/LAUNCH  ( 2867): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
10-12 04:52:50.715+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 04:52:50.715+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 04:52:50.715+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 04:52:50.725+0900 I/TIZEN_N_SOUND_MANAGER( 2941): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
10-12 04:52:50.725+0900 E/TIZEN_N_SOUND_MANAGER( 2941): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
10-12 04:52:50.725+0900 I/TIZEN_N_SOUND_MANAGER( 2941): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
10-12 04:52:50.725+0900 E/TIZEN_N_SOUND_MANAGER( 2941): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
10-12 04:52:50.725+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
10-12 04:52:50.725+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-12 04:52:50.725+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-12 04:52:50.725+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2867 is org.tizen.homescreen
10-12 04:52:50.725+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2867 : 0
10-12 04:52:50.725+0900 D/AUL     ( 2941): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
10-12 04:52:50.725+0900 D/DATA_PROVIDER_MASTER( 2923): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2867 is resumed
10-12 04:52:50.725+0900 D/DATA_PROVIDER_MASTER( 2923): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
10-12 04:52:50.725+0900 E/DATA_PROVIDER_MASTER( 2923): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
10-12 04:52:50.725+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
10-12 04:52:50.725+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
10-12 04:52:50.725+0900 W/AUL     ( 3000): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3000, appid: org.tizen.calendar.widget, status: fg
10-12 04:52:50.725+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3000
10-12 04:52:50.735+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3000, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
10-12 04:52:50.735+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3000
10-12 04:52:50.775+0900 D/AUL_PAD (12706): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-12 04:52:50.775+0900 D/AUL_PAD (12706): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-12 04:52:50.775+0900 D/AUL_PAD (12706): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-12 04:52:50.775+0900 D/AUL_PAD (12706): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-12 04:52:50.795+0900 D/RESOURCED( 2849): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3000, appname = org.tizen.calendar.widget
10-12 04:52:50.795+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3000
10-12 04:52:50.795+0900 I/RESOURCED( 2849): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-12 04:52:50.795+0900 I/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-12 04:52:50.965+0900 D/cluster-view( 2867): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
10-12 04:52:50.965+0900 D/cluster-view( 2867): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
10-12 04:52:50.965+0900 D/cluster-view( 2867): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
10-12 04:52:50.965+0900 D/test-log( 2867): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
10-12 04:52:50.965+0900 D/test-log( 2867): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
10-12 04:52:50.965+0900 D/cluster-view( 2867): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
10-12 04:52:50.965+0900 D/cluster-home( 2867): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
10-12 04:52:51.355+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:51.355+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:51.355+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:51.355+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:51.355+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:51.355+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.355+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.365+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:51.365+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:51.365+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:51.365+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:51.365+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:51.365+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.365+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:51.375+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:51.375+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.375+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:51.375+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:51.375+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:51.485+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
10-12 04:52:51.485+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
10-12 04:52:51.535+0900 D/LAUNCH  (12717): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
10-12 04:52:51.535+0900 D/PKGMGR_INFO(12717): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.535+0900 D/PKGMGR_INFO(12717): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.535+0900 D/AUL     (12717): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 12717 is org.tizen.crash-popup
10-12 04:52:51.605+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
10-12 04:52:51.605+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
10-12 04:52:51.605+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
10-12 04:52:51.605+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
10-12 04:52:51.605+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[438.00][791.00] to[438.00][791.00]!
10-12 04:52:51.605+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
10-12 04:52:51.605+0900 D/cluster-home( 2867): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [16]MenuBox clicked
10-12 04:52:51.605+0900 D/cluster-home( 2867): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
10-12 04:52:51.605+0900 D/AUL     ( 2867): service.c: __set_bundle(186) > __set_bundle
10-12 04:52:51.605+0900 D/AUL     ( 2867): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
10-12 04:52:51.605+0900 D/AUL     ( 2867): service.c: __set_bundle(186) > __set_bundle
10-12 04:52:51.605+0900 D/AUL     ( 2867): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.tichat - no result
10-12 04:52:51.605+0900 D/AUL     ( 2867): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.tichat
10-12 04:52:51.605+0900 D/AUL     ( 2867): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
10-12 04:52:51.605+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-12 04:52:51.615+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
10-12 04:52:51.615+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2233) > caller pid : 2867
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_key.c: _key_grab(243) > _key_grab, win : a00002
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2448) > back key grab
10-12 04:52:51.615+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-12 04:52:51.615+0900 D/RESOURCED( 2849): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-12 04:52:51.615+0900 D/RESOURCED( 2849): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-12 04:52:51.615+0900 E/RESOURCED( 2849): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2648) > process_pool: false
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-12 04:52:51.615+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2665) > pad pid(-5)
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-12 04:52:51.615+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-12 04:52:51.615+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-12 04:52:51.615+0900 W/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-12 04:52:51.615+0900 D/AUL     ( 2917): process_pool.c: __send_pkt_raw_data(219) > send(11) : 876 / 876
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12706, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-12 04:52:51.615+0900 W/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(265) > Check app launching
10-12 04:52:51.615+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 876, pkt->len: 868
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-12 04:52:51.615+0900 D/AUL     (12706): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (12712) is sent.
10-12 04:52:51.615+0900 D/AUL     (12706): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 12712, signo: 10
10-12 04:52:51.615+0900 D/AUL     (12706): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OAAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AEwAAAG9yZy5leGFtcGxlLnRpY2hhdAA=##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzYyMTU1NzEvNjE5NjMwAA==##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODY3AA==##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 14
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-12 04:52:51.615+0900 D/AUL_PAD (12706): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-12 04:52:51.615+0900 I/CAPI_APPFW_APPLICATION(12706): app_main.c: ui_app_main(788) > app_efl_main
10-12 04:52:51.615+0900 D/LAUNCH  (12706): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-12 04:52:51.615+0900 D/APP_CORE(12706): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-12 04:52:51.615+0900 D/APP_CORE(12706): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-12 04:52:51.615+0900 D/APP_CORE(12706): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-12 04:52:51.615+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
10-12 04:52:51.625+0900 D/APP_CORE(12706): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-12 04:52:51.625+0900 D/AUL     (12706): app_sock.c: __create_server_sock(156) > pg path - already exists
10-12 04:52:51.625+0900 D/APP_CORE(12706): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42cd520
10-12 04:52:51.625+0900 D/LAUNCH  (12706): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-12 04:52:51.625+0900 I/CAPI_APPFW_APPLICATION(12706): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-12 04:52:51.665+0900 E/EFL     (12706): elementary<12706> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-12 04:52:51.675+0900 D/APP_CORE(12717): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-12 04:52:51.675+0900 D/APP_CORE(12717): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
10-12 04:52:51.675+0900 D/APP_CORE(12717): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-12 04:52:51.685+0900 D/APP_CORE(12717): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-12 04:52:51.685+0900 D/AUL     (12717): app_sock.c: __create_server_sock(156) > pg path - already exists
10-12 04:52:51.685+0900 D/APP_CORE(12717): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb76c8520
10-12 04:52:51.685+0900 D/LAUNCH  (12717): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
10-12 04:52:51.695+0900 D/IMMODULE(12706): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-12 04:52:51.695+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:51.695+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:51.705+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:51.705+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:51.705+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:51.705+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/ISF_QUERY(12706): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:51.715+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-12 04:52:51.715+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12706, appid: org.example.tichat
10-12 04:52:51.715+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-12 04:52:51.715+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
10-12 04:52:51.715+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2700) > add app group info
10-12 04:52:51.715+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-12 04:52:51.715+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(12706) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-12 04:52:51.715+0900 D/AUL     ( 2867): launch.c: app_request_to_launchpad(425) > launch request result : 12706
10-12 04:52:51.715+0900 E/cluster-home( 2867): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.tichat]
10-12 04:52:51.715+0900 D/test-log( 2867): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
10-12 04:52:51.715+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 12706
10-12 04:52:51.715+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-12 04:52:51.715+0900 E/RESOURCED( 2849): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-12 04:52:51.715+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(888) > available memory = 791
10-12 04:52:51.735+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:51.735+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:51.735+0900 D/IMMODULE(12706): scim_panel_client.cpp: open_connection(162) > 
10-12 04:52:51.735+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-12 04:52:51.735+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:51.735+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-12 04:52:51.735+0900 D/ISF_SOCKET(12706): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:51.745+0900 D/APP_CORE(12717): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-12 04:52:51.745+0900 D/IMMODULE(12706): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-12 04:52:51.745+0900 D/LAUNCH  (12717): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
10-12 04:52:51.755+0900 D/APP_CORE(12717): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-12 04:52:51.785+0900 D/LAUNCH  (12706): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-12 04:52:51.785+0900 D/APP_CORE(12706): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-12 04:52:51.795+0900 E/E17     ( 2779): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
10-12 04:52:51.805+0900 D/APP_CORE(12706): appcore.c: __aul_handler(587) > [APP 12706]     AUL event: AUL_START
10-12 04:52:51.805+0900 I/APP_CORE(12706): appcore-efl.c: __do_app(496) > [APP 12706] Event: RESET State: CREATED
10-12 04:52:51.805+0900 D/APP_CORE(12706): appcore-efl.c: __do_app(527) > [APP 12706] RESET
10-12 04:52:51.805+0900 D/LAUNCH  (12706): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-12 04:52:51.805+0900 D/APP_CORE(12706): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-12 04:52:51.805+0900 D/APP_CORE(12706): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 04:52:51.805+0900 I/CAPI_APPFW_APPLICATION(12706): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-12 04:52:51.805+0900 D/LAUNCH  (12706): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-12 04:52:51.805+0900 D/APP_CORE(12706): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
10-12 04:52:51.805+0900 E/EFL     (12706): edje<12706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:51.805+0900 E/EFL     (12706): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:51.805+0900 E/EFL     (12706): edje<12706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:51.805+0900 E/EFL     (12706): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:51.805+0900 E/EFL     (12706): edje<12706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:51.805+0900 E/EFL     (12706): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:51.805+0900 E/EFL     (12706): edje<12706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:51.805+0900 E/EFL     (12706): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:51.805+0900 E/EFL     (12706): edje<12706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:51.805+0900 E/EFL     (12706): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:51.825+0900 E/E17     ( 2779): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
10-12 04:52:51.845+0900 W/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12706
10-12 04:52:51.845+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 04:52:51.845+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 04:52:51.855+0900 D/INDICATOR( 2852): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-12 04:52:51.855+0900 D/INDICATOR( 2852): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-12 04:52:51.855+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
10-12 04:52:51.855+0900 D/INDICATOR( 2852): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-12 04:52:51.855+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-12 04:52:51.855+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-12 04:52:51.855+0900 D/INDICATOR( 2852): main.c: _rotate_window(252) > port :: hide more icon
10-12 04:52:51.855+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.855+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:51.855+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12706 is org.example.tichat
10-12 04:52:51.855+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12706 : 0
10-12 04:52:51.855+0900 D/AUL     ( 2941): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-12 04:52:51.955+0900 D/APP_CORE(12706): appcore.c: __prt_ltime(236) > [APP 12706] first idle after reset: 343 msec
10-12 04:52:51.965+0900 W/APP_CORE(12706): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
10-12 04:52:51.965+0900 D/APP_CORE(12706): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
10-12 04:52:51.965+0900 D/APP_CORE(12706): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-12 04:52:51.965+0900 D/AUL     (12706): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-12 04:52:51.965+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
10-12 04:52:52.125+0900 E/E17     ( 2779): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-12 04:52:52.125+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-12 04:52:52.125+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-12 04:52:52.125+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-12 04:52:52.125+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
10-12 04:52:52.125+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
10-12 04:52:52.125+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-12 04:52:52.125+0900 I/APP_CORE(12706): appcore-efl.c: __do_app(496) > [APP 12706] Event: RESUME State: CREATED
10-12 04:52:52.125+0900 D/LAUNCH  (12706): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __do_app(607) > [APP 12706] RESUME
10-12 04:52:52.125+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
10-12 04:52:52.125+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-12 04:52:52.125+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
10-12 04:52:52.125+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 04:52:52.125+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 04:52:52.125+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
10-12 04:52:52.125+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-12 04:52:52.125+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-12 04:52:52.125+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
10-12 04:52:52.125+0900 I/APP_CORE(12706): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-12 04:52:52.125+0900 I/APP_CORE(12706): appcore-efl.c: __do_app(614) > [APP 12706] Initial Launching, call the resume_cb
10-12 04:52:52.125+0900 I/CAPI_APPFW_APPLICATION(12706): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-12 04:52:52.125+0900 D/LAUNCH  (12706): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-12 04:52:52.125+0900 D/LAUNCH  (12706): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-12 04:52:52.125+0900 D/APP_CORE(12706): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 04:52:52.125+0900 E/APP_CORE(12706): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 04:52:52.125+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(12706) status(3)
10-12 04:52:52.125+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-12 04:52:52.135+0900 D/DATA_PROVIDER_MASTER( 2923): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
10-12 04:52:52.135+0900 D/DATA_PROVIDER_MASTER( 2923): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-12 04:52:52.135+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-12 04:52:52.135+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-12 04:52:52.135+0900 W/AUL     ( 3000): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3000, appid: org.tizen.calendar.widget, status: bg
10-12 04:52:52.135+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3000, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-12 04:52:52.135+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3000
10-12 04:52:52.135+0900 D/RESOURCED( 2849): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3000, appname = org.tizen.calendar.widget
10-12 04:52:52.135+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3000
10-12 04:52:52.135+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2897) > back key ungrab
10-12 04:52:52.135+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(12706) status(3)
10-12 04:52:52.135+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(12706) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-12 04:52:52.135+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-12 04:52:52.135+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12706, appid: org.example.tichat, status: fg
10-12 04:52:52.135+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12706
10-12 04:52:52.135+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12706, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-12 04:52:52.135+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12706
10-12 04:52:52.195+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12706, appname = org.example.tichat, pkgname = org.example.tichat
10-12 04:52:52.195+0900 D/RESOURCED( 2849): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12706, appname = org.example.tichat
10-12 04:52:52.195+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12706
10-12 04:52:52.195+0900 I/RESOURCED( 2849): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-12 04:52:52.195+0900 I/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-12 04:52:52.265+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(12706) status(0)
10-12 04:52:52.285+0900 E/RESOURCED( 2849): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
10-12 04:52:52.715+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-12 04:52:52.715+0900 D/AUL_PAD (12746): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-12 04:52:52.725+0900 D/AUL_PAD ( 2917): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-12 04:52:52.995+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40429f 
10-12 04:52:53.115+0900 W/CRASH_MANAGER(12488): worker.c: worker_job(1204) > 1112706746963147621557
