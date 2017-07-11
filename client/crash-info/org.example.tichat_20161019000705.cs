S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 7373
Date: 2016-10-19 00:07:05+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8f02200, esi = 0xb37ecf4a
ebp = 0xbfeb3698, esp = 0xbfeb3670
eax = 0xb37ef860, ebx = 0xb37ef860
ecx = 0x00000000, edx = 0x00000000
eip = 0xb37e2bb2

Memory Information
MemTotal:      250 KB
MemFree:       139 KB
Buffers:         5 KB
Cached:     202044 KB
VmPeak:     117676 KB
VmSize:     112060 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31048 KB
VmRSS:       25520 KB
VmData:      43572 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34596 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7373 TID = 7373
7373 7375 7599 7600 7607 

Maps Information
b2b0d000 b2b14000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2b15000 b2b2d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b2e000 b2b35000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2bb2000 b2bbc000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bc2000 b2bce000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bcf000 b2bf0000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bf5000 b2bf6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bf7000 b2bfc000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bfd000 b2bfe000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bff000 b2c01000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c02000 b2c04000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c05000 b2c11000 r-xp /usr/lib/libdrm.so.2.4.0
b2c12000 b2c15000 r-xp /usr/lib/libdri2.so.0.0.0
b2c16000 b2c20000 r-xp /usr/lib/libtbm.so.1.0.0
b2c21000 b2c36000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c37000 b2c49000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b344b000 b347c000 r-xp /usr/lib/libidn.so.11.5.44
b347d000 b349f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34a0000 b34b0000 r-xp /usr/lib/libcares.so.2.1.0
b34b1000 b34d1000 r-xp /usr/lib/libnetwork.so.0.0.0
b34d2000 b34db000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34dc000 b3553000 r-xp /usr/lib/libcurl.so.4.3.0
b3555000 b3569000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b3570000 b3571000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3572000 b3573000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3574000 b3577000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3578000 b357b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3683000 b3689000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b368a000 b37ce000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37de000 b37df000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37e0000 b37ef000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37f0000 b3829000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b422c000 b4237000 r-xp /lib/libnss_files-2.20-2014.11.so
b4239000 b4244000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4246000 b425d000 r-xp /lib/libnsl-2.20-2014.11.so
b4261000 b4269000 r-xp /lib/libnss_compat-2.20-2014.11.so
b426b000 b428f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4290000 b4291000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4292000 b4295000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4296000 b429d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b429e000 b42a8000 r-xp /usr/lib/libsensord-share.so
b42a9000 b42c5000 r-xp /usr/lib/libsensor.so.1.2.0
b42c7000 b42d0000 r-xp /usr/lib/libappcore-common.so.1.1
b42d3000 b42d5000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42ea000 b42ec000 r-xp /usr/lib/libXau.so.6.0.0
b42ed000 b430f000 r-xp /usr/lib/libxcb.so.1.1.0
b4311000 b431a000 r-xp /lib/libcrypt-2.20-2014.11.so
b4343000 b4345000 r-xp /usr/lib/libiri.so
b4346000 b436c000 r-xp /lib/libexpat.so.1.5.2
b436e000 b43d9000 r-xp /usr/lib/libssl.so.1.0.0
b43df000 b43eb000 r-xp /usr/lib/libethumb.so.1.13.0
b43ec000 b43f0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43f1000 b4642000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bbd000 b5bcd000 r-xp /usr/lib/libXi.so.6.1.0
b5bce000 b5bd0000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bd1000 b5bd7000 r-xp /usr/lib/libXtst.so.6.1.0
b5bd8000 b5be2000 r-xp /usr/lib/libXrender.so.1.3.0
b5be3000 b5bec000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bee000 b5bf0000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bf1000 b5bf6000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bf7000 b5c09000 r-xp /usr/lib/libXext.so.6.4.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c0d000 b5c0f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c11000 b5d53000 r-xp /usr/lib/libX11.so.6.3.0
b5d57000 b5d61000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d62000 b5d78000 r-xp /usr/lib/libudev.so.1.6.0
b5d7b000 b5d7f000 r-xp /lib/libattr.so.1.1.0
b5d80000 b5daf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5db1000 b5db7000 r-xp /usr/lib/libffi.so.6.0.2
b5db8000 b5ddb000 r-xp /lib/libz.so.1.2.8
b5ddc000 b5ddf000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5de0000 b5f3c000 r-xp /usr/lib/libxml2.so.2.9.2
b5f42000 b6029000 r-xp /usr/lib/libstdc++.so.6.0.20
b6036000 b6039000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b603a000 b605c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b605d000 b6071000 r-xp /lib/libresolv-2.20-2014.11.so
b6075000 b6099000 r-xp /usr/lib/liblzma.so.5.0.3
b609a000 b609c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b609e000 b60a8000 r-xp /usr/lib/libembryo.so.1.13.0
b60a9000 b60d2000 r-xp /usr/lib/libpng12.so.0.50.0
b60d3000 b611c000 r-xp /usr/lib/libjpeg.so.8.0.2
b612d000 b6134000 r-xp /lib/librt-2.20-2014.11.so
b6136000 b6155000 r-xp /usr/lib/libector.so.1.13.0
b6158000 b6185000 r-xp /usr/lib/liblua-5.1.so
b6186000 b6216000 r-xp /usr/lib/libfreetype.so.6.11.3
b621a000 b6258000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6259000 b626f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6270000 b62c9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62cc000 b6317000 r-xp /lib/libm-2.20-2014.11.so
b6319000 b632b000 r-xp /usr/lib/libeio.so.1.13.0
b632c000 b632f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6330000 b6336000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6337000 b635a000 r-xp /usr/lib/libefreet.so.1.13.0
b635d000 b6388000 r-xp /usr/lib/libeldbus.so.1.13.0
b6389000 b63bd000 r-xp /usr/lib/libecore_con.so.1.13.0
b63bf000 b63c8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63c9000 b63d2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63d3000 b63e6000 r-xp /usr/lib/libeo.so.1.13.0
b63e8000 b63fb000 r-xp /usr/lib/libecore_input.so.1.13.0
b63fc000 b6403000 r-xp /usr/lib/libecore_file.so.1.13.0
b6404000 b6427000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6428000 b6454000 r-xp /usr/lib/libeet.so.1.13.0
b645d000 b64c8000 r-xp /usr/lib/libeina.so.1.13.0
b64cb000 b64e2000 r-xp /usr/lib/libefl.so.1.13.0
b64e4000 b664b000 r-xp /usr/lib/libicuuc.so.51.1
b6659000 b6865000 r-xp /usr/lib/libicui18n.so.51.1
b686d000 b68bc000 r-xp /usr/lib/libecore_x.so.1.13.0
b68be000 b68d8000 r-xp /lib/libgcc_s-4.9.so.1
b68da000 b68de000 r-xp /lib/libcap.so.2.21
b68df000 b6925000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6926000 b692d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b692f000 b6981000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6983000 b6b0e000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b13000 b6be1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6be4000 b6be8000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6be9000 b6bf8000 r-xp /usr/lib/libvconf.so.0.2.45
b6bf9000 b6bfc000 r-xp /usr/lib/libvasum.so.0.3.1
b6bfd000 b6c00000 r-xp /usr/lib/libttrace.so.1.1
b6c02000 b6c06000 r-xp /usr/lib/libiniparser.so.0
b6c07000 b6c37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c38000 b6c41000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c42000 b6c67000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c68000 b6c78000 r-xp /usr/lib/libunwind.so.8.0.1
b6c82000 b6e30000 r-xp /lib/libc-2.20-2014.11.so
b6e38000 b6f7b000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f7d000 b6fd5000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fd6000 b700a000 r-xp /usr/lib/libsystemd.so.0.4.0
b700d000 b70e1000 r-xp /usr/lib/libedje.so.1.13.0
b70e4000 b7110000 r-xp /usr/lib/libecore.so.1.13.0
b7121000 b7347000 r-xp /usr/lib/libevas.so.1.13.0
b736f000 b7387000 r-xp /lib/libpthread-2.20-2014.11.so
b738b000 b7705000 r-xp /usr/lib/libelementary.so.1.13.0
b7725000 b7729000 r-xp /usr/lib/libsmack.so.1.0.0
b772a000 b7733000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7734000 b7737000 r-xp /usr/lib/libdlog.so.0.0.0
b7738000 b773d000 r-xp /usr/lib/libbundle.so.0.1.22
b773e000 b7741000 r-xp /lib/libdl-2.20-2014.11.so
b7743000 b7768000 r-xp /usr/lib/libaul.so.0.1.0
b776b000 b776d000 r-xp /usr/lib/libappsvc.so.0.1.0
b776e000 b7773000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7774000 b777b000 r-xp /usr/lib/libappcore-efl.so.1.1
b777d000 b7782000 r-xp /usr/lib/libsys-assert.so
b7785000 b7786000 r-xp [vdso]
b7786000 b77a8000 r-xp /lib/ld-2.20-2014.11.so
b77aa000 b77b2000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7373)
Call Stack Count: 24
 0: cJSON_GetObjectItem + 0x22 (0xb37e2bb2) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2bb2
 1: refresh_button_clicked_cb + 0x413 (0xb37e7d33) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x7d33
 2: roomlist_cb + 0x298 (0xb37e7448) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x7448
 3: roomlist_button_cb + 0x47 (0xb37ec707) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xc707
 4: (0xb71aa116) [/usr/lib/libevas.so.1] + 0x89116
 5: (0xb63e1319) [/usr/lib/libeo.so.1] + 0xe319
 6: eo_event_callback_call + 0xb3 (0xb63ded63) [/usr/lib/libeo.so.1] + 0xbd63
 7: evas_object_smart_callback_call + 0x75 (0xb71ac9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 8: (0xb745d404) [/usr/lib/libelementary.so.1] + 0xd2404
 9: (0xb7090f39) [/usr/lib/libedje.so.1] + 0x83f39
10: (0xb7097a11) [/usr/lib/libedje.so.1] + 0x8aa11
11: (0xb7091fdc) [/usr/lib/libedje.so.1] + 0x84fdc
12: (0xb70924cb) [/usr/lib/libedje.so.1] + 0x854cb
13: (0xb709268f) [/usr/lib/libedje.so.1] + 0x8568f
14: (0xb70f7702) [/usr/lib/libecore.so.1] + 0x13702
15: (0xb70f1055) [/usr/lib/libecore.so.1] + 0xd055
16: (0xb70fa1b9) [/usr/lib/libecore.so.1] + 0x161b9
17: ecore_main_loop_begin + 0x57 (0xb70fa587) [/usr/lib/libecore.so.1] + 0x16587
18: elm_run + 0x2d (0xb755322d) [/usr/lib/libelementary.so.1] + 0x1c822d
19: appcore_efl_main + 0x4de (0xb7777dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
20: ui_app_main + 0x140 (0xb7770c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
21: main + 0x278 (0xb37ea9e8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xa9e8
22: cJSON_Delete + 0xa8 (0xb77ac148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb77ac148
23: __libc_start_main + 0xde (0xb6c99e4e) [/lib/libc.so.6] + 0x17e4e
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
353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_183921165], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-19 00:06:54.007+0900 D/PKGMGR  ( 2938): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-19 00:06:54.007+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_183921165], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-19 00:06:54.007+0900 D/PKGMGR  ( 2938): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-19 00:06:54.007+0900 D/PKGMGR  ( 2919): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_183921165], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-19 00:06:54.007+0900 D/PKGMGR  ( 7538): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_183921165], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-19 00:06:54.007+0900 D/QUICKPANEL( 2919): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.tichat key:end val:ok
10-19 00:06:54.007+0900 D/PKGMGR  ( 7538): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_183921165], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-19 00:06:54.137+0900 D/rpm-installer( 7543): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
10-19 00:06:54.137+0900 D/rpm-installer( 7543): rpm-appcore-intf.c: main(259) > ------------------------------------------------
10-19 00:06:54.137+0900 D/rpm-installer( 7543): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
10-19 00:06:54.137+0900 D/rpm-installer( 7543): rpm-appcore-intf.c: main(261) > ------------------------------------------------
10-19 00:06:54.137+0900 D/PKGMGR_SERVER( 7540): pkgmgr-server.c: sighandler(387) > child exit [7543]
10-19 00:06:54.137+0900 E/PKGMGR_SERVER( 7540): pkgmgr-server.c: sighandler(402) > child NORMAL exit [7543]
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_request.c: __request_handler(838) > __request_handler: 0
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-19 00:06:55.507+0900 D/PKGMGR_INFO( 2778): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-19 00:06:55.507+0900 D/PKGMGR_INFO( 2778): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-19 00:06:55.507+0900 I/AUL     ( 2778): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-19 00:06:55.507+0900 D/AUL     ( 2778): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 7593, pid = 7595
10-19 00:06:55.507+0900 D/PKGMGR_INFO( 2778): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-19 00:06:55.507+0900 D/PKGMGR_INFO( 2778): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-19 00:06:55.507+0900 I/AUL     ( 2778): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-19 00:06:55.507+0900 E/AUL_AMD ( 2778): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-19 00:06:55.507+0900 W/AUL_AMD ( 2778): amd_launch.c: _start_app(2233) > caller pid : 7595
10-19 00:06:55.507+0900 E/AUL_AMD ( 2778): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-19 00:06:55.507+0900 W/AUL_AMD ( 2778): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_launch.c: _start_app(2648) > process_pool: false
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-19 00:06:55.507+0900 W/AUL_AMD ( 2778): amd_launch.c: _start_app(2665) > pad pid(-5)
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-19 00:06:55.507+0900 D/AUL_AMD ( 2778): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-19 00:06:55.507+0900 D/AUL     ( 2778): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-19 00:06:55.507+0900 W/AUL_PAD ( 2908): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-19 00:06:55.507+0900 D/AUL     ( 2908): process_pool.c: __send_pkt_raw_data(219) > send(11) : 616 / 616
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7373, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-19 00:06:55.507+0900 W/AUL_PAD ( 2908): launchpad.c: __send_result_to_caller(265) > Check app launching
10-19 00:06:55.507+0900 D/AUL_PAD ( 2908): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-19 00:06:55.507+0900 D/RESOURCED( 2837): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-19 00:06:55.507+0900 D/RESOURCED( 2837): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-19 00:06:55.507+0900 E/RESOURCED( 2837): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-19 00:06:55.507+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-19 00:06:55.507+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-19 00:06:55.507+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-19 00:06:55.507+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-19 00:06:55.507+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-19 00:06:55.507+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-19 00:06:55.507+0900 D/AUL     ( 7373): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7375) is sent.
10-19 00:06:55.507+0900 D/AUL     ( 7373): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7375, signo: 10
10-19 00:06:55.517+0900 D/AUL     ( 7373): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzY4MDMyMTUvNTEzOTYyAA==##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3NTk1AA==##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-19 00:06:55.517+0900 D/AUL_PAD ( 7373): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-19 00:06:55.517+0900 I/CAPI_APPFW_APPLICATION( 7373): app_main.c: ui_app_main(788) > app_efl_main
10-19 00:06:55.517+0900 D/LAUNCH  ( 7373): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-19 00:06:55.517+0900 D/APP_CORE( 7373): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-19 00:06:55.517+0900 D/APP_CORE( 7373): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-19 00:06:55.517+0900 D/APP_CORE( 7373): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-19 00:06:55.527+0900 D/APP_CORE( 7373): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-19 00:06:55.527+0900 D/AUL     ( 7373): app_sock.c: __create_server_sock(156) > pg path - already exists
10-19 00:06:55.527+0900 D/APP_CORE( 7373): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42d0520
10-19 00:06:55.527+0900 D/LAUNCH  ( 7373): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-19 00:06:55.527+0900 I/CAPI_APPFW_APPLICATION( 7373): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-19 00:06:55.557+0900 D/IMMODULE( 7373): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-19 00:06:55.557+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(515) > ppid:2908  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-19 00:06:55.557+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(524) > connect() succeeded
10-19 00:06:55.567+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(515) > ppid:2908  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-19 00:06:55.567+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(524) > connect() succeeded
10-19 00:06:55.577+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(515) > ppid:2908  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-19 00:06:55.577+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(524) > connect() succeeded
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_QUERY( 7373): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-19 00:06:55.577+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(515) > ppid:2908  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-19 00:06:55.577+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(524) > connect() succeeded
10-19 00:06:55.577+0900 D/IMMODULE( 7373): scim_panel_client.cpp: open_connection(162) > 
10-19 00:06:55.577+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(515) > ppid:2908  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-19 00:06:55.577+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(524) > connect() succeeded
10-19 00:06:55.587+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(515) > ppid:2908  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-19 00:06:55.587+0900 D/ISF_SOCKET( 7373): scim_socket.cpp: connect(524) > connect() succeeded
10-19 00:06:55.587+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-19 00:06:55.607+0900 D/AUL_PAD ( 2908): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-19 00:06:55.607+0900 W/AUL     ( 2778): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7373, appid: org.example.tichat
10-19 00:06:55.607+0900 D/AUL     ( 2778): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-19 00:06:55.607+0900 E/AUL     ( 2778): simple_util.c: __trm_app_info_send_socket(330) > access
10-19 00:06:55.607+0900 D/AUL_AMD ( 2778): amd_launch.c: _start_app(2700) > add app group info
10-19 00:06:55.607+0900 E/AUL     ( 2778): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-19 00:06:55.607+0900 D/AUL_AMD ( 2778): amd_status.c: _status_add_app_info_list(427) > pid(7373) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-19 00:06:55.617+0900 D/RESOURCED( 2837): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 7373
10-19 00:06:55.617+0900 D/RESOURCED( 2837): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-19 00:06:55.617+0900 E/RESOURCED( 2837): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-19 00:06:55.617+0900 D/RESOURCED( 2837): proc-main.c: resourced_proc_status_change(888) > available memory = 775
10-19 00:06:55.617+0900 D/LAUNCH  ( 7373): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-19 00:06:55.617+0900 D/APP_CORE( 7373): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-19 00:06:55.617+0900 E/E17     ( 2765): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02c00002)
10-19 00:06:55.617+0900 E/E17     ( 2765): e_border.c: e_border_show(2088) > BD_SHOW(0x02c00002)
10-19 00:06:55.637+0900 D/APP_CORE( 7373): appcore.c: __aul_handler(587) > [APP 7373]     AUL event: AUL_START
10-19 00:06:55.637+0900 I/APP_CORE( 7373): appcore-efl.c: __do_app(496) > [APP 7373] Event: RESET State: CREATED
10-19 00:06:55.637+0900 D/APP_CORE( 7373): appcore-efl.c: __do_app(527) > [APP 7373] RESET
10-19 00:06:55.637+0900 D/LAUNCH  ( 7373): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-19 00:06:55.637+0900 D/APP_CORE( 7373): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-19 00:06:55.637+0900 D/APP_CORE( 7373): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-19 00:06:55.637+0900 I/CAPI_APPFW_APPLICATION( 7373): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-19 00:06:55.637+0900 D/AUL     ( 7373): service.c: __set_bundle(186) > __set_bundle
10-19 00:06:55.637+0900 D/LAUNCH  ( 7373): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-19 00:06:55.637+0900 D/APP_CORE( 7373): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-19 00:06:55.637+0900 E/EFL     ( 7373): edje<7373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-19 00:06:55.637+0900 E/EFL     ( 7373): By the power of Grayskull, your previous Embryo stack is now broken!
10-19 00:06:55.637+0900 E/EFL     ( 7373): edje<7373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-19 00:06:55.637+0900 E/EFL     ( 7373): By the power of Grayskull, your previous Embryo stack is now broken!
10-19 00:06:55.637+0900 E/EFL     ( 7373): edje<7373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-19 00:06:55.637+0900 E/EFL     ( 7373): By the power of Grayskull, your previous Embryo stack is now broken!
10-19 00:06:55.637+0900 E/EFL     ( 7373): edje<7373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-19 00:06:55.637+0900 E/EFL     ( 7373): By the power of Grayskull, your previous Embryo stack is now broken!
10-19 00:06:55.647+0900 E/EFL     ( 7373): edje<7373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-19 00:06:55.647+0900 E/EFL     ( 7373): By the power of Grayskull, your previous Embryo stack is now broken!
10-19 00:06:55.647+0900 W/APP_CORE( 7373): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
10-19 00:06:55.647+0900 D/APP_CORE( 7373): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00002
10-19 00:06:55.647+0900 D/APP_CORE( 7373): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-19 00:06:55.647+0900 D/AUL     ( 7373): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-19 00:06:55.647+0900 D/AUL_AMD ( 2778): amd_request.c: __request_handler(838) > __request_handler: 34
10-19 00:06:55.647+0900 W/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7373
10-19 00:06:55.657+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-19 00:06:55.657+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-19 00:06:55.657+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-19 00:06:55.667+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-19 00:06:55.667+0900 D/AUL_AMD ( 2778): amd_request.c: __request_handler(838) > __request_handler: 15
10-19 00:06:55.667+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-19 00:06:55.667+0900 D/PKGMGR_INFO( 2778): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-19 00:06:55.667+0900 D/PKGMGR_INFO( 2778): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-19 00:06:55.667+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-19 00:06:55.667+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-19 00:06:55.667+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-19 00:06:55.667+0900 D/AUL_AMD ( 2778): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7373 is org.example.tichat
10-19 00:06:55.667+0900 D/AUL_AMD ( 2778): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7373 : 0
10-19 00:06:55.667+0900 D/AUL     ( 2930): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-19 00:06:55.817+0900 D/APP_CORE( 7373): appcore.c: __prt_ltime(236) > [APP 7373] first idle after reset: 308 msec
10-19 00:06:55.987+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-19 00:06:55.987+0900 I/APP_CORE( 7373): appcore-efl.c: __do_app(496) > [APP 7373] Event: RESUME State: CREATED
10-19 00:06:55.987+0900 D/LAUNCH  ( 7373): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __do_app(607) > [APP 7373] RESUME
10-19 00:06:55.987+0900 I/APP_CORE( 7373): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-19 00:06:55.987+0900 I/APP_CORE( 7373): appcore-efl.c: __do_app(614) > [APP 7373] Initial Launching, call the resume_cb
10-19 00:06:55.987+0900 I/CAPI_APPFW_APPLICATION( 7373): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-19 00:06:55.987+0900 D/LAUNCH  ( 7373): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-19 00:06:55.987+0900 D/LAUNCH  ( 7373): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-19 00:06:55.987+0900 D/APP_CORE( 7373): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-19 00:06:55.987+0900 E/APP_CORE( 7373): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-19 00:06:55.987+0900 D/APP_CORE( 2850): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-19 00:06:55.987+0900 D/APP_CORE( 2850): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-19 00:06:55.987+0900 D/APP_CORE( 2850): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-19 00:06:55.987+0900 I/APP_CORE( 2850): appcore-efl.c: __do_app(496) > [APP 2850] Event: PAUSE State: RUNNING
10-19 00:06:55.987+0900 D/APP_CORE( 2850): appcore-efl.c: __do_app(565) > [APP 2850] PAUSE
10-19 00:06:55.987+0900 I/CAPI_APPFW_APPLICATION( 2850): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-19 00:06:55.987+0900 E/cluster-home( 2850): homescreen.cpp: OnPause(84) >  app pause
10-19 00:06:55.987+0900 D/cluster-view( 2850): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-19 00:06:55.987+0900 D/cluster-view( 2850): homescreen-view-manager.cpp: AppPause(923) >  END
10-19 00:06:55.987+0900 D/APP_CORE( 2850): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-19 00:06:55.987+0900 E/APP_CORE( 2850): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-19 00:06:55.987+0900 D/AUL_AMD ( 2778): amd_status.c: _status_update_app_info_list(456) > pid(2850) status(4)
10-19 00:06:55.987+0900 D/AUL_AMD ( 2778): amd_status.c: _status_update_app_info_list(468) > pid(2850) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-19 00:06:55.987+0900 D/AUL     ( 2778): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-19 00:06:55.987+0900 W/AUL     ( 2778): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2850, appid: org.tizen.homescreen, status: bg
10-19 00:06:55.997+0900 D/AUL_AMD ( 2778): amd_launch.c: __e17_status_handler(2891) > pid(7373) status(3)
10-19 00:06:55.997+0900 D/AUL_AMD ( 2778): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
10-19 00:06:55.997+0900 E/PKGMGR_SERVER( 7540): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-19 00:06:55.997+0900 E/PKGMGR_SERVER( 7540): pkgmgr-server.c: main(2265) > package manager server terminated.
10-19 00:06:55.997+0900 W/AUL_AMD ( 2778): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-19 00:06:55.997+0900 W/AUL_AMD ( 2778): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-19 00:06:55.997+0900 D/AUL_AMD ( 2778): amd_status.c: _status_update_app_info_list(456) > pid(7373) status(3)
10-19 00:06:55.997+0900 D/AUL_AMD ( 2778): amd_status.c: _status_update_app_info_list(468) > pid(7373) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-19 00:06:55.997+0900 D/AUL     ( 2778): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-19 00:06:55.997+0900 W/AUL     ( 2778): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7373, appid: org.example.tichat, status: fg
10-19 00:06:55.997+0900 D/RESOURCED( 2837): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7373
10-19 00:06:55.997+0900 D/RESOURCED( 2837): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7373, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-19 00:06:55.997+0900 D/RESOURCED( 2837): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7373
10-19 00:06:56.007+0900 D/DATA_PROVIDER_MASTER( 2912): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2850 is paused
10-19 00:06:56.007+0900 D/DATA_PROVIDER_MASTER( 2912): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-19 00:06:56.007+0900 I/CAPI_WIDGET_APPLICATION( 2997): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-19 00:06:56.007+0900 I/CAPI_WIDGET_APPLICATION( 2997): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-19 00:06:56.007+0900 W/AUL     ( 2997): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2997, appid: org.tizen.calendar.widget, status: bg
10-19 00:06:56.027+0900 D/AUL_AMD ( 2778): amd_launch.c: __e17_status_handler(2910) > pid(7373) status(0)
10-19 00:06:56.047+0900 D/RESOURCED( 2837): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7373, appname = org.example.tichat, pkgname = org.example.tichat
10-19 00:06:56.047+0900 D/RESOURCED( 2837): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7373, appname = org.example.tichat
10-19 00:06:56.047+0900 D/RESOURCED( 2837): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7373
10-19 00:06:56.127+0900 I/RESOURCED( 2837): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-19 00:06:56.127+0900 I/RESOURCED( 2837): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-19 00:06:56.127+0900 D/RESOURCED( 2837): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2997, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-19 00:06:56.127+0900 D/RESOURCED( 2837): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2997
10-19 00:06:56.127+0900 D/RESOURCED( 2837): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2997, appname = org.tizen.calendar.widget
10-19 00:06:56.127+0900 D/RESOURCED( 2837): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2997
10-19 00:06:56.617+0900 D/AUL_PAD ( 2908): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-19 00:06:56.617+0900 D/AUL_PAD ( 7605): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-19 00:06:56.617+0900 D/AUL_PAD ( 2908): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-19 00:06:56.617+0900 E/RESOURCED( 2837): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.590
10-19 00:06:57.117+0900 D/AUL_AMD ( 2778): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-19 00:06:57.117+0900 D/RUA     ( 2778): rua.c: rua_add_history(179) > rua_add_history start
10-19 00:06:57.117+0900 D/RUA     ( 2778): rua.c: rua_add_history(247) > rua_add_history ok
10-19 00:06:57.637+0900 D/AUL_PAD ( 7605): launchpad_loader.c: main(588) > sleeping 1 sec...
10-19 00:06:57.637+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b84f7760
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(69) > get pre-initialization function
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(73) > get shutdown function
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b84f7a40
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b84f9640
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(69) > get pre-initialization function
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preload.h: __preload_init(73) > get shutdown function
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): preexec.h: __preexec_init(76) > preexec start
10-19 00:06:57.647+0900 D/AUL_PAD ( 7605): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-19 00:06:57.647+0900 D/AUL     ( 7605): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-19 00:06:57.647+0900 D/AUL     ( 7605): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-19 00:06:57.647+0900 D/AUL     ( 7605): process_pool.c: __connect_to_launchpad(132) > send(7605) : 4
10-19 00:06:57.647+0900 D/AUL     ( 7605): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-19 00:06:57.647+0900 D/AUL_PAD ( 2908): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7605
10-19 00:06:57.717+0900 D/AUL_PAD ( 7605): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-19 00:06:57.717+0900 D/AUL_PAD ( 7605): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-19 00:06:57.717+0900 D/AUL_PAD ( 7605): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-19 00:06:57.717+0900 D/AUL_PAD ( 7605): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-19 00:06:57.867+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2029fb 
10-19 00:06:57.867+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8d89378. set autocapital type : 2
10-19 00:06:57.867+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_in(245) > Enter
10-19 00:06:57.867+0900 D/ISE_DEFAULT( 3023): ise.cpp: ise_focus_in(824) > ic : 1ccd0027 , 0 , g_ic : ed20027 , 0, g_focused_ic : 0 , 1
10-19 00:06:57.867+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8d89378. on demand : 0
10-19 00:06:57.867+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-19 00:06:57.867+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 0
10-19 00:06:57.867+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8d89378
10-19 00:06:57.867+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-19 00:06:58.377+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 1
10-19 00:06:58.377+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8d89378, bidi direction : 0x1
10-19 00:06:58.507+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 2
10-19 00:06:58.597+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 3
10-19 00:06:58.687+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 4
10-19 00:06:58.867+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
10-19 00:06:59.267+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 5
10-19 00:06:59.477+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 6
10-19 00:06:59.667+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 7
10-19 00:06:59.727+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8d89378, cursor pos : 8
10-19 00:06:59.837+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-19 00:06:59.837+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-19 00:06:59.837+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-19 00:06:59.837+0900 E/INDICATOR( 2840): 
10-19 00:06:59.967+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8d89378
10-19 00:06:59.967+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-19 00:06:59.967+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8d89378
10-19 00:06:59.967+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_out(251) > Enter
10-19 00:06:59.977+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8dcf6c8. set autocapital type : 0
10-19 00:06:59.977+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_in(245) > Enter
10-19 00:06:59.977+0900 D/ISE_DEFAULT( 3023): ise.cpp: ise_focus_in(824) > ic : 1cce0027 , 0 , g_ic : ed20027 , 0, g_focused_ic : 0 , 1
10-19 00:06:59.977+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8dcf6c8. on demand : 0
10-19 00:06:59.977+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-19 00:06:59.977+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 0
10-19 00:07:00.157+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 1
10-19 00:07:00.157+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8dcf6c8, bidi direction : 0x1
10-19 00:07:00.247+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 2
10-19 00:07:00.367+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 3
10-19 00:07:00.437+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 4
10-19 00:07:00.517+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 5
10-19 00:07:00.647+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 6
10-19 00:07:00.787+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 7
10-19 00:07:00.847+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 8
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 12:07 5 h"
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 12:07"
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 12&#x2236;07"
10-19 00:07:00.857+0900 D/INDICATOR( 2840): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146413521 Time: <font_size=33>12&#x2236;07</font_size> <font_size=32>AM</font_size></font>
10-19 00:07:00.997+0900 D/APP_CORE( 2850): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-19 00:07:00.997+0900 I/APP_CORE( 2850): appcore-efl.c: __do_app(496) > [APP 2850] Event: MEM_FLUSH State: PAUSED
10-19 00:07:00.997+0900 D/APP_CORE( 2850): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-19 00:07:00.997+0900 D/APP_CORE( 2850): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2850
10-19 00:07:00.997+0900 D/APP_CORE( 2850): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-19 00:07:00.997+0900 D/RESOURCED( 2837): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2850
10-19 00:07:01.017+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8dcf6c8, cursor pos : 9
10-19 00:07:01.937+0900 D/IMMODULE( 7373): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8dcf6c8
10-19 00:07:01.937+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-19 00:07:01.937+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8dcf6c8
10-19 00:07:01.937+0900 E/EFL     ( 7373): edje<7373> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-19 00:07:01.937+0900 E/EFL     ( 7373): By the power of Grayskull, your previous Embryo stack is now broken!
10-19 00:07:01.937+0900 D/ISE_DEFAULT( 3023): ise.cpp: on_focus_out(251) > Enter
10-19 00:07:01.957+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2029fb 
10-19 00:07:02.057+0900 I/CAPI_NETWORK_CONNECTION( 7373): connection.c: connection_create(408) > New handle created[0xb8dd00c0]
10-19 00:07:02.057+0900 I/CAPI_NETWORK_CONNECTION( 7373): connection.c: connection_get_type(464) > Connected Network = 3
10-19 00:07:02.057+0900 I/tichat  ( 7373): Network connection type : 3
10-19 00:07:02.697+0900 I/tichat  ( 7373): CURL Returned: 
10-19 00:07:02.697+0900 I/tichat  ( 7373): {"message":"로그인 성공"}
10-19 00:07:02.697+0900 I/tichat  ( 7373): Parsed JSON: "로그인 성공"
10-19 00:07:02.717+0900 I/CAPI_NETWORK_CONNECTION( 7373): connection.c: connection_destroy(426) > Destroy handle: 0xb8dd00c0
10-19 00:07:02.717+0900 D/IMMODULE( 7373): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-19 00:07:02.717+0900 D/ISF_PANEL_EFL( 3019): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 40 40
10-19 00:07:02.717+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-19 00:07:02.717+0900 D/ISF_PANEL_EFL( 3019): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-19 00:07:02.717+0900 D/ISF_PANEL_EFL( 3019): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-19 00:07:02.717+0900 D/SCIM_HELPER( 3023): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-19 00:07:02.717+0900 D/LIBSCL_UI( 3023): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2200009 (basewin 0x8000321a mag 0x8000fc7f)
10-19 00:07:02.947+0900 D/LIBSCL_UI( 3023): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2200003 (basewin 0x8000321a mag 0x8000fc7f)
10-19 00:07:02.947+0900 D/ISE_DEFAULT( 3023): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-19 00:07:03.867+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x2029fb bd->visible=1
10-19 00:07:04.237+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2029fb 
10-19 00:07:04.377+0900 I/CAPI_NETWORK_CONNECTION( 7373): connection.c: connection_create(408) > New handle created[0xb8ede230]
10-19 00:07:04.377+0900 I/CAPI_NETWORK_CONNECTION( 7373): connection.c: connection_get_type(464) > Connected Network = 3
10-19 00:07:04.377+0900 I/tichat  ( 7373): Network connection type : 3
10-19 00:07:05.007+0900 I/tichat  ( 7373): CURL Returned: 
10-19 00:07:05.007+0900 I/tichat  ( 7373): [{"id":1,"title":"1324876","participant":[],"createdAt":"2016-10-17T16:24:38.612Z","updatedAt":"2016-10-17T16:24:38.612Z"},{"id":2,"title":"1324876","participant":[],"createdAt":"2016-10-17T16:32:39.112Z","updatedAt":"2016-10-17T16:32:39.112Z"},{"id":3,"title":"cvadfq","participant":[],"createdAt":"2016-10-17T16:39:37.603Z","updatedAt":"2016-10-17T16:39:37.603Z"},{"id":4,"title":"asdfzc","participant":[],"createdAt":"2016-10-17T17:57:47.612Z","updatedAt":"2016-10-17T17:57:47.612Z"},{"id":5,"title":"asdfasdf","participant":[],"createdAt":"2016-10-17T19:29:39.539Z","updatedAt":"2016-10-17T19:29:39.539Z"}]
10-19 00:07:05.047+0900 W/CRASH_MANAGER( 7608): worker.c: worker_job(1204) > 1107373746963147680322
