S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 7403
Date: 2016-10-17 05:02:24+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a65c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb90ca2e8, esi = 0xbfcd9b30
ebp = 0xbfcd9b28, esp = 0xbfcd9ae0
eax = 0xb3744a80, ebx = 0xb3744a80
ecx = 0x8000a654, edx = 0x00000002
eip = 0xb373e0f3

Memory Information
MemTotal:      250 KB
MemFree:       145 KB
Buffers:         4 KB
Cached:     166088 KB
VmPeak:     111736 KB
VmSize:     111736 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24960 KB
VmRSS:       24960 KB
VmData:      43256 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34588 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7403 TID = 7403
7403 7404 7589 7590 7594 

Maps Information
b2a64000 b2a6b000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2a6c000 b2a84000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2a85000 b2a8c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b09000 b2b13000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b19000 b2b25000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b26000 b2b47000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b4c000 b2b4d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b4e000 b2b53000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b54000 b2b56000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b57000 b2b59000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b5a000 b2b66000 r-xp /usr/lib/libdrm.so.2.4.0
b2b67000 b2b6a000 r-xp /usr/lib/libdri2.so.0.0.0
b2b6b000 b2b75000 r-xp /usr/lib/libtbm.so.1.0.0
b2b76000 b2b8b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b8c000 b2b9e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33a0000 b33d1000 r-xp /usr/lib/libidn.so.11.5.44
b33d2000 b33f4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33f5000 b3405000 r-xp /usr/lib/libcares.so.2.1.0
b3406000 b3426000 r-xp /usr/lib/libnetwork.so.0.0.0
b3427000 b3430000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3431000 b34a8000 r-xp /usr/lib/libcurl.so.4.3.0
b34aa000 b34be000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34c5000 b34c6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34c7000 b34c8000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34c9000 b34cc000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34cd000 b34d0000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35d8000 b35de000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35df000 b3723000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3733000 b3734000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3735000 b3736000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3737000 b3744000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b3745000 b377e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4181000 b418c000 r-xp /lib/libnss_files-2.20-2014.11.so
b418e000 b4199000 r-xp /lib/libnss_nis-2.20-2014.11.so
b419b000 b41b2000 r-xp /lib/libnsl-2.20-2014.11.so
b41b6000 b41be000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c0000 b41e4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41e5000 b41e6000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41e7000 b41ea000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41eb000 b41f2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41f3000 b41fd000 r-xp /usr/lib/libsensord-share.so
b41fe000 b421a000 r-xp /usr/lib/libsensor.so.1.2.0
b421c000 b4225000 r-xp /usr/lib/libappcore-common.so.1.1
b4228000 b422a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b423f000 b4241000 r-xp /usr/lib/libXau.so.6.0.0
b4242000 b4264000 r-xp /usr/lib/libxcb.so.1.1.0
b4266000 b426f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4298000 b429a000 r-xp /usr/lib/libiri.so
b429b000 b42c1000 r-xp /lib/libexpat.so.1.5.2
b42c3000 b432e000 r-xp /usr/lib/libssl.so.1.0.0
b4334000 b4340000 r-xp /usr/lib/libethumb.so.1.13.0
b4341000 b4345000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4346000 b4597000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b12000 b5b22000 r-xp /usr/lib/libXi.so.6.1.0
b5b23000 b5b25000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b26000 b5b2c000 r-xp /usr/lib/libXtst.so.6.1.0
b5b2d000 b5b37000 r-xp /usr/lib/libXrender.so.1.3.0
b5b38000 b5b41000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b43000 b5b45000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b46000 b5b4b000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b4c000 b5b5e000 r-xp /usr/lib/libXext.so.6.4.0
b5b5f000 b5b61000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b62000 b5b64000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b66000 b5ca8000 r-xp /usr/lib/libX11.so.6.3.0
b5cac000 b5cb6000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cb7000 b5ccd000 r-xp /usr/lib/libudev.so.1.6.0
b5cd0000 b5cd4000 r-xp /lib/libattr.so.1.1.0
b5cd5000 b5d04000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d06000 b5d0c000 r-xp /usr/lib/libffi.so.6.0.2
b5d0d000 b5d30000 r-xp /lib/libz.so.1.2.8
b5d31000 b5d34000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d35000 b5e91000 r-xp /usr/lib/libxml2.so.2.9.2
b5e97000 b5f7e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f8b000 b5f8e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f8f000 b5fb1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fb2000 b5fc6000 r-xp /lib/libresolv-2.20-2014.11.so
b5fca000 b5fee000 r-xp /usr/lib/liblzma.so.5.0.3
b5fef000 b5ff1000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ff3000 b5ffd000 r-xp /usr/lib/libembryo.so.1.13.0
b5ffe000 b6027000 r-xp /usr/lib/libpng12.so.0.50.0
b6028000 b6071000 r-xp /usr/lib/libjpeg.so.8.0.2
b6082000 b6089000 r-xp /lib/librt-2.20-2014.11.so
b608b000 b60aa000 r-xp /usr/lib/libector.so.1.13.0
b60ad000 b60da000 r-xp /usr/lib/liblua-5.1.so
b60db000 b616b000 r-xp /usr/lib/libfreetype.so.6.11.3
b616f000 b61ad000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ae000 b61c4000 r-xp /usr/lib/libfribidi.so.0.3.1
b61c5000 b621e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6221000 b626c000 r-xp /lib/libm-2.20-2014.11.so
b626e000 b6280000 r-xp /usr/lib/libeio.so.1.13.0
b6281000 b6284000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6285000 b628b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b628c000 b62af000 r-xp /usr/lib/libefreet.so.1.13.0
b62b2000 b62dd000 r-xp /usr/lib/libeldbus.so.1.13.0
b62de000 b6312000 r-xp /usr/lib/libecore_con.so.1.13.0
b6314000 b631d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b631e000 b6327000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6328000 b633b000 r-xp /usr/lib/libeo.so.1.13.0
b633d000 b6350000 r-xp /usr/lib/libecore_input.so.1.13.0
b6351000 b6358000 r-xp /usr/lib/libecore_file.so.1.13.0
b6359000 b637c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b637d000 b63a9000 r-xp /usr/lib/libeet.so.1.13.0
b63b2000 b641d000 r-xp /usr/lib/libeina.so.1.13.0
b6420000 b6437000 r-xp /usr/lib/libefl.so.1.13.0
b6439000 b65a0000 r-xp /usr/lib/libicuuc.so.51.1
b65ae000 b67ba000 r-xp /usr/lib/libicui18n.so.51.1
b67c2000 b6811000 r-xp /usr/lib/libecore_x.so.1.13.0
b6813000 b682d000 r-xp /lib/libgcc_s-4.9.so.1
b682f000 b6833000 r-xp /lib/libcap.so.2.21
b6834000 b687a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b687b000 b6882000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6884000 b68d6000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68d8000 b6a63000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a68000 b6b36000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b39000 b6b3d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b3e000 b6b4d000 r-xp /usr/lib/libvconf.so.0.2.45
b6b4e000 b6b51000 r-xp /usr/lib/libvasum.so.0.3.1
b6b52000 b6b55000 r-xp /usr/lib/libttrace.so.1.1
b6b57000 b6b5b000 r-xp /usr/lib/libiniparser.so.0
b6b5c000 b6b8c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b8d000 b6b96000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b97000 b6bbc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bbd000 b6bcd000 r-xp /usr/lib/libunwind.so.8.0.1
b6bd7000 b6d85000 r-xp /lib/libc-2.20-2014.11.so
b6d8d000 b6ed0000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ed2000 b6f2a000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f2b000 b6f5f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f62000 b7036000 r-xp /usr/lib/libedje.so.1.13.0
b7039000 b7065000 r-xp /usr/lib/libecore.so.1.13.0
b7076000 b729c000 r-xp /usr/lib/libevas.so.1.13.0
b72c4000 b72dc000 r-xp /lib/libpthread-2.20-2014.11.so
b72e0000 b765a000 r-xp /usr/lib/libelementary.so.1.13.0
b767a000 b767e000 r-xp /usr/lib/libsmack.so.1.0.0
b767f000 b7688000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7689000 b768c000 r-xp /usr/lib/libdlog.so.0.0.0
b768d000 b7692000 r-xp /usr/lib/libbundle.so.0.1.22
b7693000 b7696000 r-xp /lib/libdl-2.20-2014.11.so
b7698000 b76bd000 r-xp /usr/lib/libaul.so.0.1.0
b76c0000 b76c2000 r-xp /usr/lib/libappsvc.so.0.1.0
b76c3000 b76c8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76c9000 b76d0000 r-xp /usr/lib/libappcore-efl.so.1.1
b76d2000 b76d7000 r-xp /usr/lib/libsys-assert.so
b76da000 b76db000 r-xp [vdso]
b76db000 b76fd000 r-xp /lib/ld-2.20-2014.11.so
b76ff000 b7707000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7403)
Call Stack Count: 22
 0: roomlist + 0x23 (0xb373e0f3) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x70f3
 1: login_login_button_clicked_cb + 0x586 (0xb3741846) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xa846
 2: (0xb70ff116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb6336319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb6333d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb71019e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb73b2404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb6fe5f39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb6feca11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb6fe6fdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb6fe74cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb6fe768f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb704c702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb7046055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb704f1b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb704f587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb74a822d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb76ccdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb76c5c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x278 (0xb37401b8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x91b8
20: cJSON_Delete + 0xf8 (0xb7701148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7701148
21: __libc_start_main + 0xde (0xb6beee4e) [/lib/libc.so.6] + 0x17e4e
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
cation_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
10-17 05:02:14.190+0900 D/DATA_PROVIDER_MASTER( 2906): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.tichat]
10-17 05:02:14.190+0900 E/cluster-home( 2853): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.tichat] Name[tichat] Icon[/opt/usr/apps/org.example.tichat/shared/res/tichat.png] enable[1] system[0]
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.tichat]
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.tichat
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[16], isFolder[0], pageId[1], col[4], row[4], appId[org.example.tichat], name[tichat], menuId[1], isPreload[0] isPreload[0]
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
10-17 05:02:14.190+0900 E/cluster-home( 2853): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.tichat] Name[tichat] Icon[/opt/usr/apps/org.example.tichat/shared/res/tichat.png] enable[1] system[0]
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [tichat]
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
10-17 05:02:14.190+0900 D/AUL_AMD ( 2719): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.tichat, type:rpm
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
10-17 05:02:14.190+0900 D/test-log( 2853): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png], New icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png]!!!!!
10-17 05:02:14.190+0900 D/PKGMGR  ( 2927): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-277090464], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-17 05:02:14.190+0900 D/PKGMGR  ( 2927): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-277090464], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-17 05:02:14.190+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 16]
10-17 05:02:14.190+0900 D/PKGMGR  ( 2934): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-277090464], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-17 05:02:14.190+0900 D/PKGMGR  ( 2934): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-17 05:02:14.190+0900 D/PKGMGR  ( 2934): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-277090464], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-17 05:02:14.190+0900 D/PKGMGR  ( 2934): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-17 05:02:14.330+0900 D/rpm-installer( 7532): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
10-17 05:02:14.330+0900 D/rpm-installer( 7532): rpm-appcore-intf.c: main(259) > ------------------------------------------------
10-17 05:02:14.330+0900 D/rpm-installer( 7532): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
10-17 05:02:14.330+0900 D/rpm-installer( 7532): rpm-appcore-intf.c: main(261) > ------------------------------------------------
10-17 05:02:14.330+0900 D/PKGMGR_SERVER( 7529): pkgmgr-server.c: sighandler(387) > child exit [7532]
10-17 05:02:14.330+0900 E/PKGMGR_SERVER( 7529): pkgmgr-server.c: sighandler(402) > child NORMAL exit [7532]
10-17 05:02:15.990+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 0
10-17 05:02:15.990+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-17 05:02:15.990+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-17 05:02:15.990+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-17 05:02:16.000+0900 I/AUL     ( 2719): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-17 05:02:16.000+0900 D/AUL     ( 2719): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 7582, pid = 7584
10-17 05:02:16.000+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-17 05:02:16.000+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-17 05:02:16.000+0900 I/AUL     ( 2719): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-17 05:02:16.000+0900 E/AUL_AMD ( 2719): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-17 05:02:16.000+0900 W/AUL_AMD ( 2719): amd_launch.c: _start_app(2233) > caller pid : 7584
10-17 05:02:16.000+0900 E/AUL_AMD ( 2719): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-17 05:02:16.000+0900 W/AUL_AMD ( 2719): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-17 05:02:16.000+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2648) > process_pool: false
10-17 05:02:16.000+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-17 05:02:16.000+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-17 05:02:16.000+0900 W/AUL_AMD ( 2719): amd_launch.c: _start_app(2665) > pad pid(-5)
10-17 05:02:16.000+0900 D/AUL_AMD ( 2719): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-17 05:02:16.000+0900 D/AUL_AMD ( 2719): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-17 05:02:16.000+0900 D/AUL     ( 2719): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-17 05:02:16.000+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 05:02:16.000+0900 D/RESOURCED( 2835): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-17 05:02:16.000+0900 W/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-17 05:02:16.000+0900 D/AUL     ( 2903): process_pool.c: __send_pkt_raw_data(219) > send(12) : 616 / 616
10-17 05:02:16.000+0900 E/RESOURCED( 2835): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7403, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-17 05:02:16.000+0900 W/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(265) > Check app launching
10-17 05:02:16.000+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-17 05:02:16.000+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-17 05:02:16.000+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-17 05:02:16.000+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-17 05:02:16.000+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-17 05:02:16.000+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-17 05:02:16.000+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-17 05:02:16.000+0900 D/AUL     ( 7403): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7404) is sent.
10-17 05:02:16.000+0900 D/AUL     ( 7403): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7404, signo: 10
10-17 05:02:16.010+0900 D/AUL     ( 7403): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 05:02:16.010+0900 E/PKGMGR_SERVER( 7529): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-17 05:02:16.010+0900 E/PKGMGR_SERVER( 7529): pkgmgr-server.c: main(2265) > package manager server terminated.
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzY2NDgxMzUvOTkwMDAwAA==##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3NTg0AA==##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-17 05:02:16.010+0900 D/AUL_PAD ( 7403): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-17 05:02:16.010+0900 I/CAPI_APPFW_APPLICATION( 7403): app_main.c: ui_app_main(788) > app_efl_main
10-17 05:02:16.010+0900 D/LAUNCH  ( 7403): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-17 05:02:16.010+0900 D/APP_CORE( 7403): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-17 05:02:16.010+0900 D/APP_CORE( 7403): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-17 05:02:16.010+0900 D/APP_CORE( 7403): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-17 05:02:16.020+0900 D/APP_CORE( 7403): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-17 05:02:16.020+0900 D/AUL     ( 7403): app_sock.c: __create_server_sock(156) > pg path - already exists
10-17 05:02:16.020+0900 D/APP_CORE( 7403): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4225520
10-17 05:02:16.020+0900 D/LAUNCH  ( 7403): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-17 05:02:16.020+0900 I/CAPI_APPFW_APPLICATION( 7403): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-17 05:02:16.030+0900 E/EFL     ( 7403): elementary<7403> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-17 05:02:16.050+0900 D/IMMODULE( 7403): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_QUERY( 7403): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:16.050+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:16.060+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:16.060+0900 D/IMMODULE( 7403): scim_panel_client.cpp: open_connection(162) > 
10-17 05:02:16.060+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 05:02:16.060+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:16.060+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 05:02:16.060+0900 D/ISF_SOCKET( 7403): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:16.060+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-17 05:02:16.090+0900 D/LAUNCH  ( 7403): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-17 05:02:16.090+0900 E/E17     ( 2797): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
10-17 05:02:16.090+0900 E/E17     ( 2797): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
10-17 05:02:16.090+0900 W/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7403
10-17 05:02:16.100+0900 D/APP_CORE( 7403): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-17 05:02:16.100+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:16.100+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:16.100+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-17 05:02:16.100+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-17 05:02:16.100+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-17 05:02:16.100+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-17 05:02:16.100+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-17 05:02:16.100+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-17 05:02:16.100+0900 D/APP_CORE( 7403): appcore.c: __aul_handler(587) > [APP 7403]     AUL event: AUL_START
10-17 05:02:16.100+0900 I/APP_CORE( 7403): appcore-efl.c: __do_app(496) > [APP 7403] Event: RESET State: CREATED
10-17 05:02:16.100+0900 D/APP_CORE( 7403): appcore-efl.c: __do_app(527) > [APP 7403] RESET
10-17 05:02:16.100+0900 D/LAUNCH  ( 7403): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-17 05:02:16.100+0900 D/APP_CORE( 7403): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-17 05:02:16.100+0900 D/APP_CORE( 7403): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 05:02:16.100+0900 I/CAPI_APPFW_APPLICATION( 7403): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-17 05:02:16.100+0900 D/AUL     ( 7403): service.c: __set_bundle(186) > __set_bundle
10-17 05:02:16.100+0900 D/LAUNCH  ( 7403): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-17 05:02:16.100+0900 D/APP_CORE( 7403): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-17 05:02:16.110+0900 E/EFL     ( 7403): edje<7403> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:16.110+0900 E/EFL     ( 7403): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:16.110+0900 E/EFL     ( 7403): edje<7403> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:16.110+0900 E/EFL     ( 7403): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:16.110+0900 E/EFL     ( 7403): edje<7403> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:16.110+0900 E/EFL     ( 7403): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:16.110+0900 E/EFL     ( 7403): edje<7403> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:16.110+0900 E/EFL     ( 7403): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:16.110+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-17 05:02:16.110+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7403, appid: org.example.tichat
10-17 05:02:16.110+0900 D/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-17 05:02:16.110+0900 E/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(330) > access
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2700) > add app group info
10-17 05:02:16.110+0900 E/AUL     ( 2719): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_status.c: _status_add_app_info_list(427) > pid(7403) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(442) > pid(7213)
10-17 05:02:16.110+0900 W/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(442) > pid(7213)
10-17 05:02:16.110+0900 W/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 15
10-17 05:02:16.110+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 7403
10-17 05:02:16.110+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-17 05:02:16.110+0900 E/RESOURCED( 2835): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-17 05:02:16.110+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 05:02:16.110+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 05:02:16.110+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(888) > available memory = 764
10-17 05:02:16.110+0900 E/EFL     ( 7403): edje<7403> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:16.110+0900 E/EFL     ( 7403): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7403 is org.example.tichat
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7403 : 0
10-17 05:02:16.110+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-17 05:02:16.110+0900 W/APP_CORE( 7403): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
10-17 05:02:16.110+0900 D/APP_CORE( 7403): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
10-17 05:02:16.110+0900 D/APP_CORE( 7403): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-17 05:02:16.110+0900 D/AUL     ( 7403): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-17 05:02:16.110+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 34
10-17 05:02:16.250+0900 D/APP_CORE( 7403): appcore.c: __prt_ltime(236) > [APP 7403] first idle after reset: 261 msec
10-17 05:02:16.430+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 05:02:16.430+0900 I/APP_CORE( 7403): appcore-efl.c: __do_app(496) > [APP 7403] Event: RESUME State: CREATED
10-17 05:02:16.430+0900 D/LAUNCH  ( 7403): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __do_app(607) > [APP 7403] RESUME
10-17 05:02:16.430+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-17 05:02:16.430+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-17 05:02:16.430+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-17 05:02:16.430+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: PAUSE State: RUNNING
10-17 05:02:16.430+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(565) > [APP 2853] PAUSE
10-17 05:02:16.430+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-17 05:02:16.430+0900 E/cluster-home( 2853): homescreen.cpp: OnPause(84) >  app pause
10-17 05:02:16.430+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-17 05:02:16.430+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(923) >  END
10-17 05:02:16.430+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 05:02:16.430+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 05:02:16.430+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(4)
10-17 05:02:16.430+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-17 05:02:16.430+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-17 05:02:16.430+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: bg
10-17 05:02:16.430+0900 I/APP_CORE( 7403): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-17 05:02:16.430+0900 I/APP_CORE( 7403): appcore-efl.c: __do_app(614) > [APP 7403] Initial Launching, call the resume_cb
10-17 05:02:16.430+0900 I/CAPI_APPFW_APPLICATION( 7403): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 05:02:16.430+0900 D/LAUNCH  ( 7403): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-17 05:02:16.430+0900 D/LAUNCH  ( 7403): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-17 05:02:16.430+0900 D/APP_CORE( 7403): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 05:02:16.430+0900 E/APP_CORE( 7403): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 05:02:16.430+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(7403) status(3)
10-17 05:02:16.430+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 05:02:16.430+0900 W/AUL_AMD ( 2719): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-17 05:02:16.430+0900 W/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-17 05:02:16.430+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(7403) status(3)
10-17 05:02:16.430+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(7403) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-17 05:02:16.430+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-17 05:02:16.430+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7403, appid: org.example.tichat, status: fg
10-17 05:02:16.430+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7403
10-17 05:02:16.430+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7403, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-17 05:02:16.430+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7403
10-17 05:02:16.450+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2853 is paused
10-17 05:02:16.450+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-17 05:02:16.460+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7403, appname = org.example.tichat, pkgname = org.example.tichat
10-17 05:02:16.460+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7403, appname = org.example.tichat
10-17 05:02:16.460+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7403
10-17 05:02:16.460+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 05:02:16.460+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 05:02:16.460+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-17 05:02:16.460+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-17 05:02:16.460+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: bg
10-17 05:02:16.460+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-17 05:02:16.460+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2998
10-17 05:02:16.460+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2998, appname = org.tizen.calendar.widget
10-17 05:02:16.460+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2998
10-17 05:02:16.460+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2910) > pid(7403) status(0)
10-17 05:02:17.120+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-17 05:02:17.120+0900 D/AUL_PAD ( 7592): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-17 05:02:17.120+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-17 05:02:17.480+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6024a5 
10-17 05:02:17.620+0900 D/AUL_AMD ( 2719): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-17 05:02:17.620+0900 D/RUA     ( 2719): rua.c: rua_add_history(179) > rua_add_history start
10-17 05:02:17.630+0900 D/RUA     ( 2719): rua.c: rua_add_history(247) > rua_add_history ok
10-17 05:02:18.150+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(588) > sleeping 1 sec...
10-17 05:02:18.150+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-17 05:02:18.150+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b879e760
10-17 05:02:18.150+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(69) > get pre-initialization function
10-17 05:02:18.150+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(73) > get shutdown function
10-17 05:02:18.150+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b879ea40
10-17 05:02:18.160+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b87a0640
10-17 05:02:18.160+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(69) > get pre-initialization function
10-17 05:02:18.160+0900 D/AUL_PAD ( 7592): preload.h: __preload_init(73) > get shutdown function
10-17 05:02:18.160+0900 D/AUL_PAD ( 7592): preexec.h: __preexec_init(76) > preexec start
10-17 05:02:18.160+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-17 05:02:18.160+0900 D/AUL     ( 7592): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-17 05:02:18.160+0900 D/AUL     ( 7592): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-17 05:02:18.160+0900 D/AUL     ( 7592): process_pool.c: __connect_to_launchpad(132) > send(7592) : 4
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-17 05:02:18.160+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7592
10-17 05:02:18.160+0900 D/AUL     ( 7592): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-17 05:02:18.160+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.591
10-17 05:02:18.210+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-17 05:02:18.220+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-17 05:02:18.220+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-17 05:02:18.220+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-17 05:02:18.490+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
10-17 05:02:19.190+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6024a5 
10-17 05:02:19.190+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb90a8318. set autocapital type : 2
10-17 05:02:19.190+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 05:02:19.190+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 1ceb0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 05:02:19.190+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb90a8318. on demand : 0
10-17 05:02:19.190+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 05:02:19.190+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 0
10-17 05:02:19.200+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb90a8318
10-17 05:02:19.200+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 05:02:19.610+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 1
10-17 05:02:19.610+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb90a8318, bidi direction : 0x1
10-17 05:02:19.790+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 2
10-17 05:02:19.910+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 3
10-17 05:02:20.000+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 4
10-17 05:02:20.210+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 05:02:20.210+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 05:02:20.210+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 05:02:20.210+0900 E/INDICATOR( 2840): 
10-17 05:02:20.400+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 5
10-17 05:02:20.610+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 6
10-17 05:02:20.760+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 7
10-17 05:02:20.830+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90a8318, cursor pos : 8
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb90a8318
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb90a8318
10-17 05:02:21.010+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb90e7308. set autocapital type : 0
10-17 05:02:21.010+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 05:02:21.010+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 1cec0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb90e7308. on demand : 0
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 05:02:21.010+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 0
10-17 05:02:21.190+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 1
10-17 05:02:21.190+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb90e7308, bidi direction : 0x1
10-17 05:02:21.260+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 2
10-17 05:02:21.400+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 3
10-17 05:02:21.440+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-17 05:02:21.440+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: MEM_FLUSH State: PAUSED
10-17 05:02:21.440+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-17 05:02:21.440+0900 D/APP_CORE( 2853): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2853
10-17 05:02:21.440+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-17 05:02:21.440+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2853
10-17 05:02:21.500+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 4
10-17 05:02:21.560+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 5
10-17 05:02:21.710+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 6
10-17 05:02:21.830+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 7
10-17 05:02:21.900+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 8
10-17 05:02:22.050+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e7308, cursor pos : 9
10-17 05:02:23.070+0900 D/IMMODULE( 7403): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb90e7308
10-17 05:02:23.070+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 05:02:23.070+0900 D/IMMODULE( 7403): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb90e7308
10-17 05:02:23.070+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 05:02:23.080+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6024a5 
10-17 05:02:23.130+0900 I/CAPI_NETWORK_CONNECTION( 7403): connection.c: connection_create(408) > New handle created[0xb90e4bd0]
10-17 05:02:23.130+0900 I/CAPI_NETWORK_CONNECTION( 7403): connection.c: connection_get_type(464) > Connected Network = 3
10-17 05:02:23.130+0900 I/tichat  ( 7403): Network connection type : 3
10-17 05:02:23.500+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6024a5 bd->visible=1
10-17 05:02:24.290+0900 I/tichat  ( 7403): CURL Returned: 
10-17 05:02:24.290+0900 I/tichat  ( 7403): {"message":"로그인 성공"}
10-17 05:02:24.290+0900 I/tichat  ( 7403): Parsed JSON: "로그인 성공"
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 05:02:24.340+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 05:02:24.340+0900 I/AUL_PAD ( 2903): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 7403 pgid = 7403
10-17 05:02:24.340+0900 I/AUL_PAD ( 2903): sigchild.h: __sigchild_action(142) > dead_pid(7403)
10-17 05:02:24.350+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:24.350+0900 W/CRASH_MANAGER( 7595): worker.c: worker_job(1204) > 1107403746963147664814
