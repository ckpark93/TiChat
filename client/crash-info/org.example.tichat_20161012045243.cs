S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 12593
Date: 2016-10-12 04:52:43+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a65c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb72d64c8, esi = 0x8000a654
ebp = 0xbfb01838, esp = 0xbfb017e0
eax = 0xb77621f4, ebx = 0xb6d372b8
ecx = 0x8000a654, edx = 0x8003eff8
eip = 0xb775d8df

Memory Information
MemTotal:      250 KB
MemFree:       147 KB
Buffers:         7 KB
Cached:     174808 KB
VmPeak:     107128 KB
VmSize:     107128 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25156 KB
VmRSS:       25156 KB
VmData:      43244 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       34032 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12593 TID = 12593
12593 12595 12599 12600 12623 

Maps Information
b2b72000 b2b79000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2b7e000 b2b96000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b97000 b2b9e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2c1e000 b2c1f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2c24000 b2c30000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c32000 b2c53000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d5f000 b2e23000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b2e2c000 b2e2f000 r-xp /usr/lib/libdri2.so.0.0.0
b2e30000 b2e35000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2e36000 b2e37000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2e38000 b2e3a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2e3b000 b2e3d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2e3e000 b2e3f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2e40000 b2e4a000 r-xp /usr/lib/libtbm.so.1.0.0
b2e4b000 b2e57000 r-xp /usr/lib/libdrm.so.2.4.0
b2e58000 b2e75000 r-xp /usr/lib/yagl/libEGL.so.1.0
b2e76000 b2ec2000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b2ec5000 b2ecf000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ed4000 b2ed5000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2ed7000 b2ee9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b36eb000 b36f6000 r-xp /lib/libnss_files-2.20-2014.11.so
b36f8000 b3703000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3705000 b371c000 r-xp /lib/libnsl-2.20-2014.11.so
b3720000 b3728000 r-xp /lib/libnss_compat-2.20-2014.11.so
b372a000 b3730000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3731000 b3875000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3885000 b3888000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3889000 b3896000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b3897000 b38d0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b42da000 b42dc000 r-xp /usr/lib/libXau.so.6.0.0
b42de000 b42e8000 r-xp /usr/lib/libsensord-share.so
b42e9000 b430d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b430e000 b4314000 r-xp /usr/lib/libffi.so.6.0.2
b4315000 b4318000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b4319000 b4475000 r-xp /usr/lib/libxml2.so.2.9.2
b447c000 b44a2000 r-xp /lib/libexpat.so.1.5.2
b44a4000 b450f000 r-xp /usr/lib/libssl.so.1.0.0
b4514000 b4520000 r-xp /usr/lib/libethumb.so.1.13.0
b4521000 b4525000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4527000 b454a000 r-xp /lib/libz.so.1.2.8
b454b000 b479c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d16000 b5dfd000 r-xp /usr/lib/libstdc++.so.6.0.20
b5e09000 b5e19000 r-xp /usr/lib/libXi.so.6.1.0
b5e1b000 b5e1d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5e1e000 b5e24000 r-xp /usr/lib/libXtst.so.6.1.0
b5e25000 b5e2f000 r-xp /usr/lib/libXrender.so.1.3.0
b5e30000 b5e39000 r-xp /usr/lib/libXrandr.so.2.2.0
b5e3a000 b5e3c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5e3e000 b5e43000 r-xp /usr/lib/libXfixes.so.3.1.0
b5e44000 b5e56000 r-xp /usr/lib/libXext.so.6.4.0
b5e57000 b5e59000 r-xp /usr/lib/libXdamage.so.1.1.0
b5e5a000 b5e5c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5e5d000 b5e67000 r-xp /usr/lib/libXcursor.so.1.0.2
b5e69000 b5e7f000 r-xp /usr/lib/libudev.so.1.6.0
b5e82000 b5e96000 r-xp /lib/libresolv-2.20-2014.11.so
b5e9a000 b5ebe000 r-xp /usr/lib/liblzma.so.5.0.3
b5ebf000 b5ee1000 r-xp /usr/lib/libxcb.so.1.1.0
b5ee2000 b5ee4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ee6000 b5ef0000 r-xp /usr/lib/libembryo.so.1.13.0
b5ef1000 b5f0d000 r-xp /usr/lib/libsensor.so.1.2.0
b5f0f000 b5f16000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b5f18000 b5f19000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5f1a000 b5f1c000 r-xp /usr/lib/libappsvc.so.0.1.0
b5f1e000 b5f21000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f22000 b5f44000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5f45000 b5f97000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b5f99000 b6124000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6128000 b61f6000 r-xp /usr/lib/libsqlite3.so.0.8.6
b61fa000 b61fe000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b61ff000 b620e000 r-xp /usr/lib/libvconf.so.0.2.45
b620f000 b6212000 r-xp /usr/lib/libvasum.so.0.3.1
b6213000 b6216000 r-xp /usr/lib/libttrace.so.1.1
b6217000 b621b000 r-xp /usr/lib/libiniparser.so.0
b621d000 b6221000 r-xp /usr/lib/libsmack.so.1.0.0
b6222000 b622b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b622c000 b6284000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6285000 b62aa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b62ab000 b62b0000 r-xp /usr/lib/libbundle.so.0.1.22
b62b2000 b62db000 r-xp /usr/lib/libpng12.so.0.50.0
b62dc000 b6325000 r-xp /usr/lib/libjpeg.so.8.0.2
b6336000 b6355000 r-xp /usr/lib/libector.so.1.13.0
b6357000 b6384000 r-xp /usr/lib/liblua-5.1.so
b6385000 b6415000 r-xp /usr/lib/libfreetype.so.6.11.3
b641a000 b6458000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6459000 b646f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6470000 b64c9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b64cb000 b64dd000 r-xp /usr/lib/libeio.so.1.13.0
b64de000 b64e1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b64e3000 b64e9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b64ea000 b650d000 r-xp /usr/lib/libefreet.so.1.13.0
b650f000 b653a000 r-xp /usr/lib/libeldbus.so.1.13.0
b653b000 b656f000 r-xp /usr/lib/libecore_con.so.1.13.0
b6571000 b657a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b657c000 b6585000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6586000 b6599000 r-xp /usr/lib/libecore_input.so.1.13.0
b659a000 b65a1000 r-xp /usr/lib/libecore_file.so.1.13.0
b65a2000 b65c5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b65c6000 b65f2000 r-xp /usr/lib/libeet.so.1.13.0
b65fc000 b6613000 r-xp /usr/lib/libefl.so.1.13.0
b6615000 b677c000 r-xp /usr/lib/libicuuc.so.51.1
b678a000 b6996000 r-xp /usr/lib/libicui18n.so.51.1
b699e000 b69ed000 r-xp /usr/lib/libecore_x.so.1.13.0
b69ef000 b69f6000 r-xp /lib/librt-2.20-2014.11.so
b69f9000 b6a44000 r-xp /lib/libm-2.20-2014.11.so
b6a46000 b6a7a000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a7d000 b6a97000 r-xp /lib/libgcc_s-4.9.so.1
b6a98000 b6bdb000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6bdd000 b6d1f000 r-xp /usr/lib/libX11.so.6.3.0
b6d24000 b6d37000 r-xp /usr/lib/libeo.so.1.13.0
b6d38000 b6e0c000 r-xp /usr/lib/libedje.so.1.13.0
b6e0f000 b6e3b000 r-xp /usr/lib/libecore.so.1.13.0
b6e4b000 b6e54000 r-xp /usr/lib/libappcore-common.so.1.1
b6e55000 b6e5c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e5e000 b6e65000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6e66000 b6e7e000 r-xp /lib/libpthread-2.20-2014.11.so
b6e82000 b6eb2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6eb3000 b6ed8000 r-xp /usr/lib/libaul.so.0.1.0
b6edb000 b6ede000 r-xp /lib/libdl-2.20-2014.11.so
b6ee0000 b6ef0000 r-xp /usr/lib/libunwind.so.8.0.1
b6efb000 b70a9000 r-xp /lib/libc-2.20-2014.11.so
b70b0000 b72d6000 r-xp /usr/lib/libevas.so.1.13.0
b72fe000 b7678000 r-xp /usr/lib/libelementary.so.1.13.0
b7698000 b7703000 r-xp /usr/lib/libeina.so.1.13.0
b7705000 b770e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b770f000 b7712000 r-xp /usr/lib/libdlog.so.0.0.0
b7713000 b7718000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7719000 b771c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b771e000 b7720000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b772f000 b7734000 r-xp /usr/lib/libsys-assert.so
b7737000 b7738000 r-xp [vdso]
b7738000 b775a000 r-xp /lib/ld-2.20-2014.11.so
b775c000 b7762000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
End of Maps Information

Callstack Information (PID:12593)
Call Stack Count: 20
 0: signup_cb + 0x2f (0xb775d8df) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb775d8df
 1: (0xb7139116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb6d32319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6d2fd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb713b9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb73d0404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb6dbbf39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb6dc2a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb6dbcfdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb6dbd4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb6dbd68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb6e22702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb6e1c055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb6e251b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb6e25587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb74c622d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb6e58dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7715c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x278 (0xb775ee38) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb775ee38
19: __libc_start_main + 0xde (0xb6f12e4e) [/lib/libc.so.6] + 0x17e4e
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
app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.005+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2867 is org.tizen.homescreen
10-12 04:52:41.005+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2867 : 0
10-12 04:52:41.005+0900 D/AUL     ( 2941): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
10-12 04:52:41.005+0900 D/DATA_PROVIDER_MASTER( 2923): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2867 is resumed
10-12 04:52:41.005+0900 D/DATA_PROVIDER_MASTER( 2923): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
10-12 04:52:41.005+0900 D/RESOURCED( 2849): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-12 04:52:41.005+0900 E/DATA_PROVIDER_MASTER( 2923): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
10-12 04:52:41.005+0900 I/RESOURCED( 2849): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-12 04:52:41.005+0900 D/RESOURCED( 2849): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-12 04:52:41.005+0900 I/RESOURCED( 2849): logging.c: logging_save_to_storage(978) > storage cache is empty
10-12 04:52:41.005+0900 I/RESOURCED( 2849): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-12 04:52:41.015+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
10-12 04:52:41.015+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
10-12 04:52:41.015+0900 W/AUL     ( 3000): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3000, appid: org.tizen.calendar.widget, status: fg
10-12 04:52:41.015+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3000
10-12 04:52:41.015+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3000, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
10-12 04:52:41.015+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3000
10-12 04:52:41.095+0900 D/RESOURCED( 2849): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3000, appname = org.tizen.calendar.widget
10-12 04:52:41.095+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3000
10-12 04:52:41.095+0900 I/RESOURCED( 2849): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-12 04:52:41.095+0900 I/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-12 04:52:41.185+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-12 04:52:41.185+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
10-12 04:52:41.185+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
10-12 04:52:41.255+0900 D/cluster-view( 2867): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
10-12 04:52:41.255+0900 D/cluster-view( 2867): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
10-12 04:52:41.255+0900 D/cluster-view( 2867): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
10-12 04:52:41.255+0900 D/test-log( 2867): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
10-12 04:52:41.255+0900 D/test-log( 2867): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
10-12 04:52:41.255+0900 D/cluster-view( 2867): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
10-12 04:52:41.255+0900 D/cluster-home( 2867): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:41.615+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:41.615+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.615+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:41.615+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:41.615+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:41.615+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.615+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:41.625+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:41.625+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.625+0900 D/PKGMGR_INFO(12488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
10-12 04:52:41.625+0900 E/VCONF   (12488): vconf.c: vconf_get_str(2891) > vconf_get_str(12488) : db/menu_widget/language error
10-12 04:52:41.625+0900 E/PKGMGR_INFO(12488): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
10-12 04:52:41.675+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
10-12 04:52:41.675+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
10-12 04:52:41.725+0900 D/AUL_PAD (12582): launchpad_loader.c: main(588) > sleeping 1 sec...
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b88be760
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(69) > get pre-initialization function
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(73) > get shutdown function
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b88bea40
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b88c0640
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(69) > get pre-initialization function
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preload.h: __preload_init(73) > get shutdown function
10-12 04:52:41.725+0900 D/AUL_PAD (12582): preexec.h: __preexec_init(76) > preexec start
10-12 04:52:41.725+0900 D/AUL_PAD (12582): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-12 04:52:41.725+0900 D/AUL     (12582): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-12 04:52:41.725+0900 D/AUL     (12582): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-12 04:52:41.725+0900 D/AUL     (12582): process_pool.c: __connect_to_launchpad(132) > send(12582) : 4
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-12 04:52:41.725+0900 D/AUL     (12582): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-12 04:52:41.725+0900 D/AUL_PAD ( 2917): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12582
10-12 04:52:41.795+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
10-12 04:52:41.795+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
10-12 04:52:41.795+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
10-12 04:52:41.795+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
10-12 04:52:41.795+0900 D/test-log( 2867): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[447.00][792.00] to[447.00][792.00]!
10-12 04:52:41.795+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
10-12 04:52:41.795+0900 D/cluster-home( 2867): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [16]MenuBox clicked
10-12 04:52:41.795+0900 D/cluster-home( 2867): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
10-12 04:52:41.795+0900 D/AUL     ( 2867): service.c: __set_bundle(186) > __set_bundle
10-12 04:52:41.795+0900 D/AUL     ( 2867): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
10-12 04:52:41.795+0900 D/AUL     ( 2867): service.c: __set_bundle(186) > __set_bundle
10-12 04:52:41.795+0900 D/AUL     ( 2867): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.tichat - no result
10-12 04:52:41.795+0900 D/AUL     ( 2867): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.tichat
10-12 04:52:41.795+0900 D/AUL     ( 2867): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
10-12 04:52:41.795+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
10-12 04:52:41.795+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-12 04:52:41.795+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
10-12 04:52:41.795+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2233) > caller pid : 2867
10-12 04:52:41.795+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
10-12 04:52:41.795+0900 D/AUL_AMD ( 2740): amd_key.c: _key_grab(243) > _key_grab, win : a00002
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2448) > back key grab
10-12 04:52:41.805+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-12 04:52:41.805+0900 D/RESOURCED( 2849): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-12 04:52:41.805+0900 D/RESOURCED( 2849): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-12 04:52:41.805+0900 E/RESOURCED( 2849): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2648) > process_pool: false
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-12 04:52:41.805+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2665) > pad pid(-5)
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-12 04:52:41.805+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-12 04:52:41.805+0900 D/AUL_PAD ( 2917): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-12 04:52:41.805+0900 W/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(524) > Candidate is not prepared, enter legacy logic
10-12 04:52:41.805+0900 W/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(265) > Check app launching
10-12 04:52:41.805+0900 E/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(271) > launching failed
10-12 04:52:41.805+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2675) > Launch with legacy way
10-12 04:52:41.805+0900 W/AUL_AMD ( 2740): amd_launch.c: start_process(511) > child process: 12593
10-12 04:52:41.805+0900 D/AUL_AMD ( 2740): amd_launch.c: __check_cmdline(467) > -- now wait to change cmdline --
10-12 04:52:41.805+0900 D/AUL_AMD (12593): amd_launch.c: start_process(491) > start application
10-12 04:52:41.805+0900 D/AUL_AMD (12593): amd_request.c: _signal_unblock_sigchld(1320) > SIGCHLD unblocked
10-12 04:52:41.805+0900 D/AUL_AMD (12593): amd_launch.c: _prepare_exec(266) > [SECURE_LOG] appid : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat 
10-12 04:52:41.815+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
10-12 04:52:41.835+0900 D/AUL_PAD (12582): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-12 04:52:41.845+0900 D/PKGMGR_INFO(12593): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.845+0900 D/PKGMGR_INFO(12593): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.845+0900 D/AUL_PAD (12582): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-12 04:52:41.845+0900 D/AUL_PAD (12582): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-12 04:52:41.845+0900 D/AUL_PAD (12582): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-12 04:52:41.845+0900 D/AUL     (12593): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 12593 is org.example.tichat
10-12 04:52:41.845+0900 I/CAPI_APPFW_APPLICATION(12593): app_main.c: ui_app_main(788) > app_efl_main
10-12 04:52:41.845+0900 D/LAUNCH  (12593): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-12 04:52:41.845+0900 D/PKGMGR_INFO(12593): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.845+0900 D/PKGMGR_INFO(12593): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:41.845+0900 D/AUL     (12593): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 12593 is org.example.tichat
10-12 04:52:41.855+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_app_launch_signal(356) > send launch signal done: 12593, org.example.tichat
10-12 04:52:41.855+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12593, appid: org.example.tichat
10-12 04:52:41.855+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-12 04:52:41.855+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
10-12 04:52:41.855+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2700) > add app group info
10-12 04:52:41.855+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-12 04:52:41.855+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(12593) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-12 04:52:41.855+0900 D/AUL     ( 2867): launch.c: app_request_to_launchpad(425) > launch request result : 12593
10-12 04:52:41.855+0900 E/cluster-home( 2867): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.tichat]
10-12 04:52:41.855+0900 D/test-log( 2867): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
10-12 04:52:41.865+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 12593
10-12 04:52:41.865+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-12 04:52:41.865+0900 E/RESOURCED( 2849): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-12 04:52:41.865+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(888) > available memory = 790
10-12 04:52:41.955+0900 D/APP_CORE(12593): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-12 04:52:41.955+0900 D/APP_CORE(12593): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-12 04:52:41.955+0900 D/APP_CORE(12593): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-12 04:52:41.965+0900 D/APP_CORE(12593): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-12 04:52:41.965+0900 D/AUL     (12593): app_sock.c: __create_server_sock(156) > pg path - already exists
10-12 04:52:41.965+0900 D/APP_CORE(12593): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb6e54520
10-12 04:52:41.965+0900 D/LAUNCH  (12593): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-12 04:52:41.965+0900 I/CAPI_APPFW_APPLICATION(12593): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-12 04:52:42.285+0900 E/EFL     (12547): eldbus<12547> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-4YzamKSTXh: Connection refused
10-12 04:52:42.285+0900 E/EFL     (12547): <12547> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
10-12 04:52:42.285+0900 E/EFL     (12547): elementary<12547> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
10-12 04:52:42.285+0900 D/APP_CORE(12547): appcore.c: __aul_handler(587) > [APP 12547]     AUL event: AUL_START
10-12 04:52:42.285+0900 I/APP_CORE(12547): appcore-efl.c: __do_app(496) > [APP 12547] Event: RESET State: CREATED
10-12 04:52:42.285+0900 D/APP_CORE(12547): appcore-efl.c: __do_app(527) > [APP 12547] RESET
10-12 04:52:42.285+0900 D/LAUNCH  (12547): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
10-12 04:52:42.285+0900 D/APP_CORE(12547): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-12 04:52:42.285+0900 D/APP_CORE(12547): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 04:52:42.285+0900 E/SYSPOPUP(12547): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
10-12 04:52:42.285+0900 E/SYSPOPUP(12547): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
10-12 04:52:42.285+0900 E/SYSPOPUP(12547): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
10-12 04:52:42.285+0900 D/LAUNCH  (12547): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
10-12 04:52:42.285+0900 D/APP_CORE(12547): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-12 04:52:42.325+0900 D/AUL     (12547): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
10-12 04:52:42.325+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 22
10-12 04:52:42.325+0900 W/AUL_AMD ( 2740): amd_request.c: __request_handler(1056) > app status : 5
10-12 04:52:42.325+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(12547) status(5)
10-12 04:52:42.335+0900 D/APP_CORE(12547): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
10-12 04:52:42.335+0900 E/EFL     (12547): eo<12547> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
10-12 04:52:42.335+0900 E/EFL     (12547): eo<12547> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
10-12 04:52:42.425+0900 E/EFL     (12593): elementary<12593> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-12 04:52:42.445+0900 D/IMMODULE(12593): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-12 04:52:42.445+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(515) > ppid:2740  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:42.445+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:42.445+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(515) > ppid:2740  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:42.445+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(515) > ppid:2740  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_QUERY(12593): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(515) > ppid:2740  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:42.455+0900 D/IMMODULE(12593): scim_panel_client.cpp: open_connection(162) > 
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(515) > ppid:2740  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(515) > ppid:2740  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-12 04:52:42.455+0900 D/ISF_SOCKET(12593): scim_socket.cpp: connect(524) > connect() succeeded
10-12 04:52:42.455+0900 D/IMMODULE(12593): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-12 04:52:42.485+0900 D/LAUNCH  (12593): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-12 04:52:42.485+0900 D/APP_CORE(12593): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-12 04:52:42.485+0900 E/E17     ( 2779): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03000003)
10-12 04:52:42.495+0900 E/E17     ( 2779): e_border.c: e_border_show(2088) > BD_SHOW(0x03000003)
10-12 04:52:42.505+0900 W/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12593
10-12 04:52:42.505+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 04:52:42.505+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 04:52:42.505+0900 D/APP_CORE(12593): appcore.c: __aul_handler(587) > [APP 12593]     AUL event: AUL_START
10-12 04:52:42.505+0900 I/APP_CORE(12593): appcore-efl.c: __do_app(496) > [APP 12593] Event: RESET State: CREATED
10-12 04:52:42.505+0900 D/APP_CORE(12593): appcore-efl.c: __do_app(527) > [APP 12593] RESET
10-12 04:52:42.505+0900 D/LAUNCH  (12593): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-12 04:52:42.505+0900 D/APP_CORE(12593): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-12 04:52:42.505+0900 D/APP_CORE(12593): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 04:52:42.505+0900 I/CAPI_APPFW_APPLICATION(12593): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-12 04:52:42.505+0900 D/LAUNCH  (12593): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-12 04:52:42.505+0900 D/APP_CORE(12593): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
10-12 04:52:42.505+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
10-12 04:52:42.505+0900 D/INDICATOR( 2852): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-12 04:52:42.505+0900 D/INDICATOR( 2852): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-12 04:52:42.505+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:42.505+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:42.505+0900 D/INDICATOR( 2852): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-12 04:52:42.505+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-12 04:52:42.505+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-12 04:52:42.505+0900 D/INDICATOR( 2852): main.c: _rotate_window(252) > port :: hide more icon
10-12 04:52:42.505+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12593 is org.example.tichat
10-12 04:52:42.505+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12593 : 0
10-12 04:52:42.505+0900 D/AUL     ( 2941): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-12 04:52:42.505+0900 E/EFL     (12593): edje<12593> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:42.505+0900 E/EFL     (12593): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:42.515+0900 E/EFL     (12593): edje<12593> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:42.515+0900 E/EFL     (12593): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:42.515+0900 E/EFL     (12593): edje<12593> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:42.515+0900 E/EFL     (12593): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:42.515+0900 E/EFL     (12593): edje<12593> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:42.515+0900 E/EFL     (12593): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:42.515+0900 E/EFL     (12593): edje<12593> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 04:52:42.515+0900 E/EFL     (12593): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 04:52:42.515+0900 W/APP_CORE(12593): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3000003
10-12 04:52:42.515+0900 D/APP_CORE(12593): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:3000003
10-12 04:52:42.515+0900 D/APP_CORE(12593): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-12 04:52:42.515+0900 D/AUL     (12593): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-12 04:52:42.515+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
10-12 04:52:42.595+0900 E/RESOURCED( 2849): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
10-12 04:52:42.615+0900 D/APP_CORE(12593): appcore.c: __prt_ltime(236) > [APP 12593] first idle after reset: 814 msec
10-12 04:52:42.705+0900 E/E17     ( 2779): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-12 04:52:42.705+0900 D/APP_CORE(12593): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:3000003 fully_obscured 0
10-12 04:52:42.705+0900 D/APP_CORE(12593): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-12 04:52:42.705+0900 D/APP_CORE(12593): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-12 04:52:42.705+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-12 04:52:42.705+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-12 04:52:42.705+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-12 04:52:42.705+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
10-12 04:52:42.705+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
10-12 04:52:42.705+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-12 04:52:42.705+0900 I/APP_CORE(12593): appcore-efl.c: __do_app(496) > [APP 12593] Event: RESUME State: CREATED
10-12 04:52:42.705+0900 D/LAUNCH  (12593): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-12 04:52:42.705+0900 D/APP_CORE(12593): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-12 04:52:42.705+0900 D/APP_CORE(12593): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 04:52:42.705+0900 D/APP_CORE(12593): appcore-efl.c: __do_app(607) > [APP 12593] RESUME
10-12 04:52:42.705+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
10-12 04:52:42.705+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-12 04:52:42.705+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
10-12 04:52:42.705+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 04:52:42.705+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 04:52:42.705+0900 D/PKGMGR_INFO(12593): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:42.705+0900 D/PKGMGR_INFO(12593): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 04:52:42.705+0900 D/AUL     (12593): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 12593 is org.example.tichat
10-12 04:52:42.705+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
10-12 04:52:42.705+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-12 04:52:42.705+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-12 04:52:42.705+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
10-12 04:52:42.705+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(12593) status(3)
10-12 04:52:42.705+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-12 04:52:42.715+0900 I/APP_CORE(12593): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-12 04:52:42.715+0900 I/APP_CORE(12593): appcore-efl.c: __do_app(614) > [APP 12593] Initial Launching, call the resume_cb
10-12 04:52:42.715+0900 I/CAPI_APPFW_APPLICATION(12593): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-12 04:52:42.715+0900 D/LAUNCH  (12593): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-12 04:52:42.715+0900 D/LAUNCH  (12593): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-12 04:52:42.715+0900 D/APP_CORE(12593): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 04:52:42.715+0900 E/APP_CORE(12593): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 04:52:42.715+0900 D/DATA_PROVIDER_MASTER( 2923): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
10-12 04:52:42.715+0900 D/DATA_PROVIDER_MASTER( 2923): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-12 04:52:42.715+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-12 04:52:42.715+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-12 04:52:42.715+0900 W/AUL     ( 3000): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3000, appid: org.tizen.calendar.widget, status: bg
10-12 04:52:42.715+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3000, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-12 04:52:42.715+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3000
10-12 04:52:42.715+0900 D/RESOURCED( 2849): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3000, appname = org.tizen.calendar.widget
10-12 04:52:42.715+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3000
10-12 04:52:42.735+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2897) > back key ungrab
10-12 04:52:42.735+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(12593) status(3)
10-12 04:52:42.735+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(12593) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-12 04:52:42.735+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-12 04:52:42.735+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12593, appid: org.example.tichat, status: fg
10-12 04:52:42.735+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12593
10-12 04:52:42.735+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12593, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-12 04:52:42.735+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12593
10-12 04:52:42.775+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12593, appname = org.example.tichat, pkgname = org.example.tichat
10-12 04:52:42.775+0900 D/RESOURCED( 2849): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12593, appname = org.example.tichat
10-12 04:52:42.775+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12593
10-12 04:52:42.775+0900 I/RESOURCED( 2849): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-12 04:52:42.775+0900 I/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-12 04:52:42.795+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(12593) status(0)
10-12 04:52:43.365+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-12 04:52:43.365+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
10-12 04:52:43.365+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
10-12 04:52:43.555+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40416d 
10-12 04:52:43.645+0900 W/CRASH_MANAGER(12488): worker.c: worker_job(1204) > 1112593746963147621556
