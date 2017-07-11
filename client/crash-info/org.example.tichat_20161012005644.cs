S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 5026
Date: 2016-10-12 00:56:44+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a658

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7ccb380, esi = 0x8000a654
ebp = 0xbff11868, esp = 0xbff11820
eax = 0xb37bcad8, ebx = 0xb63b32b8
ecx = 0x8000a654, edx = 0x800170b9
eip = 0xb37bac40

Memory Information
MemTotal:      250 KB
MemFree:       156 KB
Buffers:         5 KB
Cached:     166856 KB
VmPeak:     109292 KB
VmSize:     109292 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22280 KB
VmRSS:       22280 KB
VmData:      42640 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5026 TID = 5026
5026 5028 5210 5212 5215 

Maps Information
b2ca0000 b2caa000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cb0000 b2cbc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cbd000 b2cde000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ce3000 b2ce4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2ce5000 b2cea000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ceb000 b2ced000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cee000 b2cf0000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cf1000 b2cfd000 r-xp /usr/lib/libdrm.so.2.4.0
b2cfe000 b2d01000 r-xp /usr/lib/libdri2.so.0.0.0
b2d02000 b2d0c000 r-xp /usr/lib/libtbm.so.1.0.0
b2d13000 b2d14000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d15000 b2d16000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d17000 b2d1a000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d1b000 b2d1e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d1f000 b2d34000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d35000 b2d47000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3650000 b3656000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3657000 b379b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37ab000 b37ac000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37ad000 b37ae000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37af000 b37b8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37b9000 b37bc000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37bd000 b37f6000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41f9000 b4204000 r-xp /lib/libnss_files-2.20-2014.11.so
b4206000 b4211000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4213000 b422a000 r-xp /lib/libnsl-2.20-2014.11.so
b422e000 b4236000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4238000 b425c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b425d000 b425e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b425f000 b4262000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4263000 b426a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b426b000 b4275000 r-xp /usr/lib/libsensord-share.so
b4276000 b4292000 r-xp /usr/lib/libsensor.so.1.2.0
b4294000 b429d000 r-xp /usr/lib/libappcore-common.so.1.1
b42a0000 b42a2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42b7000 b42b9000 r-xp /usr/lib/libXau.so.6.0.0
b42ba000 b42dc000 r-xp /usr/lib/libxcb.so.1.1.0
b42de000 b42e7000 r-xp /lib/libcrypt-2.20-2014.11.so
b4310000 b4312000 r-xp /usr/lib/libiri.so
b4313000 b4339000 r-xp /lib/libexpat.so.1.5.2
b433b000 b43a6000 r-xp /usr/lib/libssl.so.1.0.0
b43ac000 b43b8000 r-xp /usr/lib/libethumb.so.1.13.0
b43b9000 b43bd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43be000 b460f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b8a000 b5b9a000 r-xp /usr/lib/libXi.so.6.1.0
b5b9b000 b5b9d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b9e000 b5ba4000 r-xp /usr/lib/libXtst.so.6.1.0
b5ba5000 b5baf000 r-xp /usr/lib/libXrender.so.1.3.0
b5bb0000 b5bb9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bbb000 b5bbd000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bbe000 b5bc3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bc4000 b5bd6000 r-xp /usr/lib/libXext.so.6.4.0
b5bd7000 b5bd9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bda000 b5bdc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bde000 b5d20000 r-xp /usr/lib/libX11.so.6.3.0
b5d24000 b5d2e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d2f000 b5d45000 r-xp /usr/lib/libudev.so.1.6.0
b5d48000 b5d4c000 r-xp /lib/libattr.so.1.1.0
b5d4d000 b5d7c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d7e000 b5d84000 r-xp /usr/lib/libffi.so.6.0.2
b5d85000 b5da8000 r-xp /lib/libz.so.1.2.8
b5da9000 b5dac000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dad000 b5f09000 r-xp /usr/lib/libxml2.so.2.9.2
b5f0f000 b5ff6000 r-xp /usr/lib/libstdc++.so.6.0.20
b6003000 b6006000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6007000 b6029000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b602a000 b603e000 r-xp /lib/libresolv-2.20-2014.11.so
b6042000 b6066000 r-xp /usr/lib/liblzma.so.5.0.3
b6067000 b6069000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b606b000 b6075000 r-xp /usr/lib/libembryo.so.1.13.0
b6076000 b609f000 r-xp /usr/lib/libpng12.so.0.50.0
b60a0000 b60e9000 r-xp /usr/lib/libjpeg.so.8.0.2
b60fa000 b6101000 r-xp /lib/librt-2.20-2014.11.so
b6103000 b6122000 r-xp /usr/lib/libector.so.1.13.0
b6125000 b6152000 r-xp /usr/lib/liblua-5.1.so
b6153000 b61e3000 r-xp /usr/lib/libfreetype.so.6.11.3
b61e7000 b6225000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6226000 b623c000 r-xp /usr/lib/libfribidi.so.0.3.1
b623d000 b6296000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6299000 b62e4000 r-xp /lib/libm-2.20-2014.11.so
b62e6000 b62f8000 r-xp /usr/lib/libeio.so.1.13.0
b62f9000 b62fc000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62fd000 b6303000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6304000 b6327000 r-xp /usr/lib/libefreet.so.1.13.0
b632a000 b6355000 r-xp /usr/lib/libeldbus.so.1.13.0
b6356000 b638a000 r-xp /usr/lib/libecore_con.so.1.13.0
b638c000 b6395000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6396000 b639f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63a0000 b63b3000 r-xp /usr/lib/libeo.so.1.13.0
b63b5000 b63c8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63c9000 b63d0000 r-xp /usr/lib/libecore_file.so.1.13.0
b63d1000 b63f4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63f5000 b6421000 r-xp /usr/lib/libeet.so.1.13.0
b642a000 b6495000 r-xp /usr/lib/libeina.so.1.13.0
b6498000 b64af000 r-xp /usr/lib/libefl.so.1.13.0
b64b1000 b6618000 r-xp /usr/lib/libicuuc.so.51.1
b6626000 b6832000 r-xp /usr/lib/libicui18n.so.51.1
b683a000 b6889000 r-xp /usr/lib/libecore_x.so.1.13.0
b688b000 b68a5000 r-xp /lib/libgcc_s-4.9.so.1
b68a7000 b68ab000 r-xp /lib/libcap.so.2.21
b68ac000 b68f2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68f3000 b68fa000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68fc000 b694e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6950000 b6adb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ae0000 b6bae000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bb1000 b6bb5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bb6000 b6bc5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bc6000 b6bc9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bca000 b6bcd000 r-xp /usr/lib/libttrace.so.1.1
b6bcf000 b6bd3000 r-xp /usr/lib/libiniparser.so.0
b6bd4000 b6c04000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c05000 b6c0e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c0f000 b6c34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c35000 b6c45000 r-xp /usr/lib/libunwind.so.8.0.1
b6c4f000 b6dfd000 r-xp /lib/libc-2.20-2014.11.so
b6e05000 b6f48000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f4a000 b6fa2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fa3000 b6fd7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fda000 b70ae000 r-xp /usr/lib/libedje.so.1.13.0
b70b1000 b70dd000 r-xp /usr/lib/libecore.so.1.13.0
b70ee000 b7314000 r-xp /usr/lib/libevas.so.1.13.0
b733c000 b7354000 r-xp /lib/libpthread-2.20-2014.11.so
b7358000 b76d2000 r-xp /usr/lib/libelementary.so.1.13.0
b76f2000 b76f6000 r-xp /usr/lib/libsmack.so.1.0.0
b76f7000 b7700000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7701000 b7704000 r-xp /usr/lib/libdlog.so.0.0.0
b7705000 b770a000 r-xp /usr/lib/libbundle.so.0.1.22
b770b000 b770e000 r-xp /lib/libdl-2.20-2014.11.so
b7710000 b7735000 r-xp /usr/lib/libaul.so.0.1.0
b7738000 b773a000 r-xp /usr/lib/libappsvc.so.0.1.0
b773b000 b7740000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7741000 b7748000 r-xp /usr/lib/libappcore-efl.so.1.1
b774a000 b774f000 r-xp /usr/lib/libsys-assert.so
b7752000 b7753000 r-xp [vdso]
b7753000 b7775000 r-xp /lib/ld-2.20-2014.11.so
b7777000 b777f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5026)
Call Stack Count: 21
 0: btn_login_cb + 0x30 (0xb37bac40) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1c40
 1: (0xb7177116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63ae319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63abd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71799e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb742a404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb705df39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7064a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb705efdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb705f4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb705f68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70c4702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70be055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70c71b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70c7587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb752022d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7744dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb773dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x279 (0xb37ba399) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1399
19: btn_submit_cb + 0x18 (0xb7779148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7779148
20: __libc_start_main + 0xde (0xb6c66e4e) [/lib/libc.so.6] + 0x17e4e
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
.example.tichat], key=[end], value=[ok]
10-12 00:56:31.273+0900 D/PKGMGR  ( 3027): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.273+0900 D/ISF_PANEL_EFL( 3027): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.tichat event_type=UPDATE event_state=COMPLETED progress=100 error=0
10-12 00:56:31.273+0900 D/PKGMGR  ( 5149): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.273+0900 D/PKGMGR  ( 2930): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.273+0900 D/QUICKPANEL( 2930): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.tichat key:end val:ok
10-12 00:56:31.283+0900 D/PKGMGR  ( 2923): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 D/DATA_PROVIDER_MASTER( 2923): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.tichat] ok
10-12 00:56:31.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.tichat], event_type[1]
10-12 00:56:31.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
10-12 00:56:31.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
10-12 00:56:31.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
10-12 00:56:31.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.tichat]
10-12 00:56:31.283+0900 D/PKGMGR  ( 2867): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 W/cluster-home( 2867): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.tichat]
10-12 00:56:31.283+0900 D/cluster-home( 2867): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.tichat]
10-12 00:56:31.283+0900 D/PKGMGR  ( 2867): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28670003] pkg_type[tpk] package[org.example.tichat] key[end] val[ok] pmsg[(null)]
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
10-12 00:56:31.283+0900 D/PKGMGR  ( 2948): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 D/PKGMGR  ( 2948): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-12 00:56:31.283+0900 D/PKGMGR  ( 2939): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 D/ESD     ( 2939): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29390002), pkg_type(tpk), pkgid(org.example.tichat), key(end), val(ok)
10-12 00:56:31.283+0900 D/ESD     ( 2939): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
10-12 00:56:31.283+0900 D/PKGMGR  ( 2740): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 D/AUL_AMD ( 2740): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.tichat), key(end), value(ok)
10-12 00:56:31.283+0900 W/AUL_AMD ( 2740): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.tichat]
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.tichat]
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.tichat]
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.tichat]
10-12 00:56:31.283+0900 W/ISF_PANEL_EFL( 3027): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
10-12 00:56:31.283+0900 D/AUL_AMD ( 2740): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.tichat, type:rpm
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.tichat] Name[tichat] Icon[/opt/usr/apps/org.example.tichat/shared/res/tichat.png] enable[1] system[0]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.tichat]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.tichat
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[16], isFolder[0], pageId[1], col[4], row[4], appId[org.example.tichat], name[tichat], menuId[1], isPreload[0] isPreload[0]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
10-12 00:56:31.283+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.tichat] Name[tichat] Icon[/opt/usr/apps/org.example.tichat/shared/res/tichat.png] enable[1] system[0]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [tichat]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
10-12 00:56:31.283+0900 D/test-log( 2867): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png], New icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png]!!!!!
10-12 00:56:31.283+0900 D/PKGMGR  ( 2941): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-343323260], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 00:56:31.283+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 16]
10-12 00:56:31.393+0900 D/rpm-installer( 5154): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
10-12 00:56:31.393+0900 D/rpm-installer( 5154): rpm-appcore-intf.c: main(259) > ------------------------------------------------
10-12 00:56:31.393+0900 D/rpm-installer( 5154): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
10-12 00:56:31.393+0900 D/rpm-installer( 5154): rpm-appcore-intf.c: main(261) > ------------------------------------------------
10-12 00:56:31.393+0900 D/PKGMGR_SERVER( 5151): pkgmgr-server.c: sighandler(387) > child exit [5154]
10-12 00:56:31.393+0900 E/PKGMGR_SERVER( 5151): pkgmgr-server.c: sighandler(402) > child NORMAL exit [5154]
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-12 00:56:32.963+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-12 00:56:32.963+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-12 00:56:32.963+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-12 00:56:32.963+0900 D/AUL     ( 2740): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5204, pid = 5206
10-12 00:56:32.963+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-12 00:56:32.963+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-12 00:56:32.963+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-12 00:56:32.963+0900 E/AUL_AMD ( 2740): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-12 00:56:32.963+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2233) > caller pid : 5206
10-12 00:56:32.963+0900 E/AUL_AMD ( 2740): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-12 00:56:32.963+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2648) > process_pool: false
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-12 00:56:32.963+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2665) > pad pid(-5)
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-12 00:56:32.963+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-12 00:56:32.963+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-12 00:56:32.963+0900 D/RESOURCED( 2849): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-12 00:56:32.963+0900 D/RESOURCED( 2849): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-12 00:56:32.963+0900 W/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-12 00:56:32.963+0900 D/AUL     ( 2917): process_pool.c: __send_pkt_raw_data(219) > send(11) : 616 / 616
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5026, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-12 00:56:32.963+0900 W/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(265) > Check app launching
10-12 00:56:32.963+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-12 00:56:32.963+0900 E/RESOURCED( 2849): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-12 00:56:32.963+0900 D/AUL     ( 5026): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5028) is sent.
10-12 00:56:32.963+0900 D/AUL     ( 5026): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5028, signo: 10
10-12 00:56:32.963+0900 D/AUL     ( 5026): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzYyMDEzOTIvOTcyMzE1AA==##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1MjA2AA==##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-12 00:56:32.963+0900 D/AUL_PAD ( 5026): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-12 00:56:32.973+0900 I/CAPI_APPFW_APPLICATION( 5026): app_main.c: ui_app_main(788) > app_efl_main
10-12 00:56:32.973+0900 D/LAUNCH  ( 5026): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-12 00:56:32.973+0900 D/APP_CORE( 5026): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-12 00:56:32.973+0900 D/APP_CORE( 5026): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-12 00:56:32.973+0900 D/APP_CORE( 5026): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-12 00:56:32.973+0900 D/APP_CORE( 5026): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-12 00:56:32.973+0900 D/AUL     ( 5026): app_sock.c: __create_server_sock(156) > pg path - already exists
10-12 00:56:32.973+0900 D/APP_CORE( 5026): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb429d520
10-12 00:56:32.973+0900 D/LAUNCH  ( 5026): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-12 00:56:32.973+0900 I/CAPI_APPFW_APPLICATION( 5026): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-12 00:56:32.993+0900 E/PKGMGR_SERVER( 5151): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-12 00:56:32.993+0900 E/PKGMGR_SERVER( 5151): pkgmgr-server.c: main(2265) > package manager server terminated.
10-12 00:56:33.023+0900 D/LAUNCH  ( 5026): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-12 00:56:33.023+0900 E/E17     ( 2779): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
10-12 00:56:33.023+0900 D/APP_CORE( 5026): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-12 00:56:33.033+0900 E/E17     ( 2779): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
10-12 00:56:33.043+0900 W/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5026
10-12 00:56:33.043+0900 D/APP_CORE( 5026): appcore.c: __aul_handler(587) > [APP 5026]     AUL event: AUL_START
10-12 00:56:33.043+0900 I/APP_CORE( 5026): appcore-efl.c: __do_app(496) > [APP 5026] Event: RESET State: CREATED
10-12 00:56:33.043+0900 D/APP_CORE( 5026): appcore-efl.c: __do_app(527) > [APP 5026] RESET
10-12 00:56:33.043+0900 D/LAUNCH  ( 5026): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-12 00:56:33.043+0900 D/APP_CORE( 5026): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-12 00:56:33.043+0900 D/APP_CORE( 5026): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 00:56:33.043+0900 I/CAPI_APPFW_APPLICATION( 5026): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-12 00:56:33.043+0900 D/AUL     ( 5026): service.c: __set_bundle(186) > __set_bundle
10-12 00:56:33.043+0900 D/LAUNCH  ( 5026): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-12 00:56:33.043+0900 D/APP_CORE( 5026): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-12 00:56:33.043+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 00:56:33.043+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:33.043+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 00:56:33.043+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:33.043+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 00:56:33.043+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:33.043+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 00:56:33.043+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:33.043+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 00:56:33.043+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:33.043+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 00:56:33.043+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 00:56:33.053+0900 D/INDICATOR( 2852): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-12 00:56:33.053+0900 D/INDICATOR( 2852): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-12 00:56:33.053+0900 D/INDICATOR( 2852): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-12 00:56:33.053+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-12 00:56:33.053+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-12 00:56:33.053+0900 D/INDICATOR( 2852): main.c: _rotate_window(252) > port :: hide more icon
10-12 00:56:33.063+0900 W/APP_CORE( 5026): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
10-12 00:56:33.063+0900 D/APP_CORE( 5026): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
10-12 00:56:33.063+0900 D/APP_CORE( 5026): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-12 00:56:33.063+0900 D/AUL     ( 5026): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-12 00:56:33.063+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-12 00:56:33.063+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5026, appid: org.example.tichat
10-12 00:56:33.063+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-12 00:56:33.063+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
10-12 00:56:33.063+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2700) > add app group info
10-12 00:56:33.063+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-12 00:56:33.063+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(5026) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-12 00:56:33.063+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
10-12 00:56:33.063+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 00:56:33.063+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 00:56:33.073+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5026 is org.example.tichat
10-12 00:56:33.073+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5026 : 0
10-12 00:56:33.073+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
10-12 00:56:33.073+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 5026
10-12 00:56:33.073+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-12 00:56:33.073+0900 E/RESOURCED( 2849): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-12 00:56:33.073+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(888) > available memory = 805
10-12 00:56:33.073+0900 D/AUL     ( 2941): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-12 00:56:33.153+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(4976)
10-12 00:56:33.153+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-12 00:56:33.153+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(4976)
10-12 00:56:33.153+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-12 00:56:33.203+0900 D/APP_CORE( 5026): appcore.c: __prt_ltime(236) > [APP 5026] first idle after reset: 240 msec
10-12 00:56:33.313+0900 E/E17     ( 2779): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-12 00:56:33.313+0900 I/APP_CORE( 5026): appcore-efl.c: __do_app(496) > [APP 5026] Event: RESUME State: CREATED
10-12 00:56:33.313+0900 D/LAUNCH  ( 5026): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __do_app(607) > [APP 5026] RESUME
10-12 00:56:33.313+0900 I/APP_CORE( 5026): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-12 00:56:33.313+0900 I/APP_CORE( 5026): appcore-efl.c: __do_app(614) > [APP 5026] Initial Launching, call the resume_cb
10-12 00:56:33.313+0900 I/CAPI_APPFW_APPLICATION( 5026): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-12 00:56:33.313+0900 D/LAUNCH  ( 5026): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-12 00:56:33.313+0900 D/LAUNCH  ( 5026): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-12 00:56:33.313+0900 D/APP_CORE( 5026): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 00:56:33.313+0900 E/APP_CORE( 5026): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 00:56:33.323+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-12 00:56:33.323+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-12 00:56:33.323+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-12 00:56:33.323+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
10-12 00:56:33.323+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
10-12 00:56:33.323+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-12 00:56:33.323+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
10-12 00:56:33.323+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-12 00:56:33.323+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
10-12 00:56:33.323+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 00:56:33.323+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 00:56:33.323+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
10-12 00:56:33.323+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-12 00:56:33.323+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-12 00:56:33.323+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
10-12 00:56:33.323+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(5026) status(3)
10-12 00:56:33.323+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-12 00:56:33.323+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-12 00:56:33.323+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-12 00:56:33.323+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(5026) status(3)
10-12 00:56:33.323+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(5026) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-12 00:56:33.323+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-12 00:56:33.323+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5026, appid: org.example.tichat, status: fg
10-12 00:56:33.323+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5026
10-12 00:56:33.323+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5026, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-12 00:56:33.323+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5026
10-12 00:56:33.333+0900 D/DATA_PROVIDER_MASTER( 2923): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
10-12 00:56:33.333+0900 D/DATA_PROVIDER_MASTER( 2923): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-12 00:56:33.333+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-12 00:56:33.333+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-12 00:56:33.333+0900 W/AUL     ( 3000): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3000, appid: org.tizen.calendar.widget, status: bg
10-12 00:56:33.393+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5026, appname = org.example.tichat, pkgname = org.example.tichat
10-12 00:56:33.393+0900 D/RESOURCED( 2849): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5026, appname = org.example.tichat
10-12 00:56:33.393+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5026
10-12 00:56:33.393+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3000, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-12 00:56:33.393+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3000
10-12 00:56:33.393+0900 D/RESOURCED( 2849): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3000, appname = org.tizen.calendar.widget
10-12 00:56:33.393+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3000
10-12 00:56:33.393+0900 I/RESOURCED( 2849): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-12 00:56:33.393+0900 I/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-12 00:56:33.403+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(5026) status(0)
10-12 00:56:34.073+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-12 00:56:34.073+0900 D/AUL_PAD ( 5214): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-12 00:56:34.073+0900 D/AUL_PAD ( 2917): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-12 00:56:34.073+0900 E/RESOURCED( 2849): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.335
10-12 00:56:34.573+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-12 00:56:34.573+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
10-12 00:56:34.573+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
10-12 00:56:34.613+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:35.093+0900 D/AUL_PAD ( 5214): launchpad_loader.c: main(588) > sleeping 1 sec...
10-12 00:56:35.093+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-12 00:56:35.093+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b77a6760
10-12 00:56:35.093+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(69) > get pre-initialization function
10-12 00:56:35.093+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(73) > get shutdown function
10-12 00:56:35.093+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b77a6a40
10-12 00:56:35.103+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b77a8640
10-12 00:56:35.103+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(69) > get pre-initialization function
10-12 00:56:35.103+0900 D/AUL_PAD ( 5214): preload.h: __preload_init(73) > get shutdown function
10-12 00:56:35.103+0900 D/AUL_PAD ( 5214): preexec.h: __preexec_init(76) > preexec start
10-12 00:56:35.103+0900 D/AUL_PAD ( 5214): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-12 00:56:35.103+0900 D/AUL     ( 5214): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-12 00:56:35.103+0900 D/AUL     ( 5214): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-12 00:56:35.103+0900 D/AUL     ( 5214): process_pool.c: __connect_to_launchpad(132) > send(5214) : 4
10-12 00:56:35.103+0900 D/AUL     ( 5214): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-12 00:56:35.103+0900 D/AUL_PAD ( 2917): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5214
10-12 00:56:35.253+0900 D/AUL_PAD ( 5214): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-12 00:56:35.253+0900 D/AUL_PAD ( 5214): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-12 00:56:35.253+0900 D/AUL_PAD ( 5214): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-12 00:56:35.253+0900 D/AUL_PAD ( 5214): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-12 00:56:35.613+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2e00002
10-12 00:56:35.973+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-12 00:56:35.973+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:35.973+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:37.223+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:38.323+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-12 00:56:38.323+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: MEM_FLUSH State: PAUSED
10-12 00:56:38.323+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-12 00:56:38.323+0900 D/APP_CORE( 2867): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2867
10-12 00:56:38.323+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-12 00:56:38.323+0900 D/RESOURCED( 2849): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2867
10-12 00:56:38.773+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-12 00:56:38.773+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:38.773+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:40.173+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:40.613+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x400cf0 bd->visible=1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-12 00:56:41.013+0900 I/RESOURCED( 2849): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-12 00:56:41.013+0900 D/RESOURCED( 2849): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-12 00:56:41.013+0900 I/RESOURCED( 2849): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-12 00:56:41.013+0900 I/RESOURCED( 2849): logging.c: logging_save_to_storage(978) > battery cache is empty
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476200816 11 5 3378 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476200826 82 43 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476200826 42 8 3378 2
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476200831 42 8 3378 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476200889 87 49 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476200894 8 7 3567 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476200903 92 52 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476200905 12 3 3755 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476200913 96 56 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201001 12 3 3805 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201010 102 60 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201012 12 3 4031 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201176 106 63 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201181 13 3 4081 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201190 112 68 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201195 12 3 4269 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201198 120 70 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.timer org.example.timer 1476201200 14 4 3373 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201201 126 73 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.timer org.example.timer 1476201201 15 4 3373 2
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201203 10 6 4455 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201205 132 74 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201206 13 5 4505 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201239 135 78 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201244 12 5 4548 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201250 142 83 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201259 14 2 4738 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201342 150 83 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201347 13 2 4788 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201355 156 86 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201357 11 6 4976 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476201388 161 92 2867 1
10-12 00:56:41.013+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476201393 10 7 5026 1
10-12 00:56:41.543+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:42.523+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:43.223+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-12 00:56:43.223+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:43.233+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:44.323+0900 E/EFL     ( 5026): edje<5026> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-12 00:56:44.323+0900 E/EFL     ( 5026): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 00:56:44.333+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400cf0 
10-12 00:56:44.483+0900 W/CRASH_MANAGER( 5217): worker.c: worker_job(1204) > 1105026746963147620140
