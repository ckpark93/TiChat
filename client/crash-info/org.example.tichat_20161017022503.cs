S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 3857
Date: 2016-10-17 02:25:03+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x40000021

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000021, esi = 0xbfe1db18
ebp = 0xbfe1d6e8, esp = 0xbfe1d6ac
eax = 0xbfe1dc08, ebx = 0xb6d98000
ecx = 0xb91544d4, edx = 0x0000000c
eip = 0x40000021

Memory Information
MemTotal:      250 KB
MemFree:       154 KB
Buffers:         3 KB
Cached:     163456 KB
VmPeak:     110192 KB
VmSize:     110192 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24672 KB
VmRSS:       24672 KB
VmData:      43108 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34584 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3857 TID = 3857
3857 3858 4042 4043 4048 

Maps Information
b2a75000 b2a7c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2a7d000 b2a95000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2a96000 b2a9d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b1a000 b2b24000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b2a000 b2b36000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b37000 b2b58000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b5d000 b2b5e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b5f000 b2b64000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b65000 b2b66000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b67000 b2b69000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b6a000 b2b76000 r-xp /usr/lib/libdrm.so.2.4.0
b2b77000 b2b7a000 r-xp /usr/lib/libdri2.so.0.0.0
b2b7b000 b2b85000 r-xp /usr/lib/libtbm.so.1.0.0
b2b86000 b2b9b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b9c000 b2bae000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33b0000 b33e1000 r-xp /usr/lib/libidn.so.11.5.44
b33e2000 b3404000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3405000 b3415000 r-xp /usr/lib/libcares.so.2.1.0
b3416000 b3436000 r-xp /usr/lib/libnetwork.so.0.0.0
b3437000 b3440000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3441000 b34b8000 r-xp /usr/lib/libcurl.so.4.3.0
b34ba000 b34ce000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34d5000 b34d6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34d7000 b34d8000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34d9000 b34dc000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34dd000 b34e0000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35e8000 b35ee000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35ef000 b3733000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3743000 b3745000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3746000 b3747000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3748000 b3754000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b3755000 b378e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4191000 b419c000 r-xp /lib/libnss_files-2.20-2014.11.so
b419e000 b41a9000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41ab000 b41c2000 r-xp /lib/libnsl-2.20-2014.11.so
b41c6000 b41ce000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d0000 b41f4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f5000 b41f6000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41f7000 b41fa000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41fb000 b4202000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4203000 b420d000 r-xp /usr/lib/libsensord-share.so
b420e000 b422a000 r-xp /usr/lib/libsensor.so.1.2.0
b422c000 b4235000 r-xp /usr/lib/libappcore-common.so.1.1
b4238000 b423a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b424f000 b4251000 r-xp /usr/lib/libXau.so.6.0.0
b4252000 b4274000 r-xp /usr/lib/libxcb.so.1.1.0
b4276000 b427f000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a8000 b42aa000 r-xp /usr/lib/libiri.so
b42ab000 b42d1000 r-xp /lib/libexpat.so.1.5.2
b42d3000 b433e000 r-xp /usr/lib/libssl.so.1.0.0
b4344000 b4350000 r-xp /usr/lib/libethumb.so.1.13.0
b4351000 b4355000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4356000 b45a7000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b22000 b5b32000 r-xp /usr/lib/libXi.so.6.1.0
b5b33000 b5b35000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b36000 b5b3c000 r-xp /usr/lib/libXtst.so.6.1.0
b5b3d000 b5b47000 r-xp /usr/lib/libXrender.so.1.3.0
b5b48000 b5b51000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b53000 b5b55000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b56000 b5b5b000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b5c000 b5b6e000 r-xp /usr/lib/libXext.so.6.4.0
b5b6f000 b5b71000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b72000 b5b74000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b76000 b5cb8000 r-xp /usr/lib/libX11.so.6.3.0
b5cbc000 b5cc6000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cc7000 b5cdd000 r-xp /usr/lib/libudev.so.1.6.0
b5ce0000 b5ce4000 r-xp /lib/libattr.so.1.1.0
b5ce5000 b5d14000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d16000 b5d1c000 r-xp /usr/lib/libffi.so.6.0.2
b5d1d000 b5d40000 r-xp /lib/libz.so.1.2.8
b5d41000 b5d44000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d45000 b5ea1000 r-xp /usr/lib/libxml2.so.2.9.2
b5ea7000 b5f8e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9b000 b5f9e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f9f000 b5fc1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc2000 b5fd6000 r-xp /lib/libresolv-2.20-2014.11.so
b5fda000 b5ffe000 r-xp /usr/lib/liblzma.so.5.0.3
b5fff000 b6001000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6003000 b600d000 r-xp /usr/lib/libembryo.so.1.13.0
b600e000 b6037000 r-xp /usr/lib/libpng12.so.0.50.0
b6038000 b6081000 r-xp /usr/lib/libjpeg.so.8.0.2
b6092000 b6099000 r-xp /lib/librt-2.20-2014.11.so
b609b000 b60ba000 r-xp /usr/lib/libector.so.1.13.0
b60bd000 b60ea000 r-xp /usr/lib/liblua-5.1.so
b60eb000 b617b000 r-xp /usr/lib/libfreetype.so.6.11.3
b617f000 b61bd000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61be000 b61d4000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d5000 b622e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6231000 b627c000 r-xp /lib/libm-2.20-2014.11.so
b627e000 b6290000 r-xp /usr/lib/libeio.so.1.13.0
b6291000 b6294000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6295000 b629b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b629c000 b62bf000 r-xp /usr/lib/libefreet.so.1.13.0
b62c2000 b62ed000 r-xp /usr/lib/libeldbus.so.1.13.0
b62ee000 b6322000 r-xp /usr/lib/libecore_con.so.1.13.0
b6324000 b632d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b632e000 b6337000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6338000 b634b000 r-xp /usr/lib/libeo.so.1.13.0
b634d000 b6360000 r-xp /usr/lib/libecore_input.so.1.13.0
b6361000 b6368000 r-xp /usr/lib/libecore_file.so.1.13.0
b6369000 b638c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b638d000 b63b9000 r-xp /usr/lib/libeet.so.1.13.0
b63c2000 b642d000 r-xp /usr/lib/libeina.so.1.13.0
b6430000 b6447000 r-xp /usr/lib/libefl.so.1.13.0
b6449000 b65b0000 r-xp /usr/lib/libicuuc.so.51.1
b65be000 b67ca000 r-xp /usr/lib/libicui18n.so.51.1
b67d2000 b6821000 r-xp /usr/lib/libecore_x.so.1.13.0
b6823000 b683d000 r-xp /lib/libgcc_s-4.9.so.1
b683f000 b6843000 r-xp /lib/libcap.so.2.21
b6844000 b688a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688b000 b6892000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6894000 b68e6000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e8000 b6a73000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a78000 b6b46000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b49000 b6b4d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b4e000 b6b5d000 r-xp /usr/lib/libvconf.so.0.2.45
b6b5e000 b6b61000 r-xp /usr/lib/libvasum.so.0.3.1
b6b62000 b6b65000 r-xp /usr/lib/libttrace.so.1.1
b6b67000 b6b6b000 r-xp /usr/lib/libiniparser.so.0
b6b6c000 b6b9c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b9d000 b6ba6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ba7000 b6bcc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bcd000 b6bdd000 r-xp /usr/lib/libunwind.so.8.0.1
b6be7000 b6d95000 r-xp /lib/libc-2.20-2014.11.so
b6d9d000 b6ee0000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee2000 b6f3a000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3b000 b6f6f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f72000 b7046000 r-xp /usr/lib/libedje.so.1.13.0
b7049000 b7075000 r-xp /usr/lib/libecore.so.1.13.0
b7086000 b72ac000 r-xp /usr/lib/libevas.so.1.13.0
b72d4000 b72ec000 r-xp /lib/libpthread-2.20-2014.11.so
b72f0000 b766a000 r-xp /usr/lib/libelementary.so.1.13.0
b768a000 b768e000 r-xp /usr/lib/libsmack.so.1.0.0
b768f000 b7698000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7699000 b769c000 r-xp /usr/lib/libdlog.so.0.0.0
b769d000 b76a2000 r-xp /usr/lib/libbundle.so.0.1.22
b76a3000 b76a6000 r-xp /lib/libdl-2.20-2014.11.so
b76a8000 b76cd000 r-xp /usr/lib/libaul.so.0.1.0
b76d0000 b76d2000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d3000 b76d8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d9000 b76e0000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e2000 b76e7000 r-xp /usr/lib/libsys-assert.so
b76ea000 b76eb000 r-xp [vdso]
b76eb000 b770d000 r-xp /lib/ld-2.20-2014.11.so
b770f000 b7717000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3857)
Call Stack Count: 27
 0: (0x40000021) (null)
 1: (0xb345756a) [/usr/lib/libcurl.so.4] + 0x1656a
 2: (0xb346f026) [/usr/lib/libcurl.so.4] + 0x2e026
 3: (0xb347a262) [/usr/lib/libcurl.so.4] + 0x39262
 4: curl_multi_perform + 0xf7 (0xb347ac77) [/usr/lib/libcurl.so.4] + 0x39c77
 5: (0xb34708a8) [/usr/lib/libcurl.so.4] + 0x2f8a8
 6: signup_signup_button_clicked_cb + 0x43f (0xb374fedf) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x7edf
 7: (0xb710f116) [/usr/lib/libevas.so.1] + 0x89116
 8: (0xb6346319) [/usr/lib/libeo.so.1] + 0xe319
 9: eo_event_callback_call + 0xb3 (0xb6343d63) [/usr/lib/libeo.so.1] + 0xbd63
10: evas_object_smart_callback_call + 0x75 (0xb71119e5) [/usr/lib/libevas.so.1] + 0x8b9e5
11: (0xb73c2404) [/usr/lib/libelementary.so.1] + 0xd2404
12: (0xb6ff5f39) [/usr/lib/libedje.so.1] + 0x83f39
13: (0xb6ffca11) [/usr/lib/libedje.so.1] + 0x8aa11
14: (0xb6ff6fdc) [/usr/lib/libedje.so.1] + 0x84fdc
15: (0xb6ff74cb) [/usr/lib/libedje.so.1] + 0x854cb
16: (0xb6ff768f) [/usr/lib/libedje.so.1] + 0x8568f
17: (0xb705c702) [/usr/lib/libecore.so.1] + 0x13702
18: (0xb7056055) [/usr/lib/libecore.so.1] + 0xd055
19: (0xb705f1b9) [/usr/lib/libecore.so.1] + 0x161b9
20: ecore_main_loop_begin + 0x57 (0xb705f587) [/usr/lib/libecore.so.1] + 0x16587
21: elm_run + 0x2d (0xb74b822d) [/usr/lib/libelementary.so.1] + 0x1c822d
22: appcore_efl_main + 0x4de (0xb76dcdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
23: ui_app_main + 0x140 (0xb76d5c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
24: main + 0x278 (0xb3750c38) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8c38
25: cJSON_New_Item + 0x38 (0xb7711148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7711148
26: __libc_start_main + 0xde (0xb6bfee4e) [/lib/libc.so.6] + 0x17e4e
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
53.420+0900 D/PKGMGR  ( 2927): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1127885872], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-17 02:24:53.420+0900 D/PKGMGR  ( 2927): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1127885872], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-17 02:24:53.420+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1127885872], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.tichat] 100
10-17 02:24:53.420+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1127885872], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.tichat] ok
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.tichat], event_type[1]
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
10-17 02:24:53.420+0900 D/DATA_PROVIDER_MASTER( 2906): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.tichat]
10-17 02:24:53.420+0900 D/PKGMGR  ( 2719): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.tichat_-1127885872], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-17 02:24:53.420+0900 D/AUL_AMD ( 2719): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.tichat), key(end), value(ok)
10-17 02:24:53.420+0900 W/AUL_AMD ( 2719): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
10-17 02:24:53.420+0900 W/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
10-17 02:24:53.420+0900 D/AUL_AMD ( 2719): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.tichat, type:rpm
10-17 02:24:53.550+0900 D/rpm-installer( 3986): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
10-17 02:24:53.550+0900 D/rpm-installer( 3986): rpm-appcore-intf.c: main(259) > ------------------------------------------------
10-17 02:24:53.550+0900 D/rpm-installer( 3986): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
10-17 02:24:53.550+0900 D/rpm-installer( 3986): rpm-appcore-intf.c: main(261) > ------------------------------------------------
10-17 02:24:53.550+0900 D/PKGMGR_SERVER( 3983): pkgmgr-server.c: sighandler(387) > child exit [3986]
10-17 02:24:53.550+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: sighandler(402) > child NORMAL exit [3986]
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 0
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-17 02:24:55.090+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-17 02:24:55.090+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-17 02:24:55.090+0900 I/AUL     ( 2719): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-17 02:24:55.090+0900 D/AUL     ( 2719): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 4036, pid = 4038
10-17 02:24:55.090+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-17 02:24:55.090+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-17 02:24:55.090+0900 I/AUL     ( 2719): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-17 02:24:55.090+0900 E/AUL_AMD ( 2719): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-17 02:24:55.090+0900 W/AUL_AMD ( 2719): amd_launch.c: _start_app(2233) > caller pid : 4038
10-17 02:24:55.090+0900 E/AUL_AMD ( 2719): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-17 02:24:55.090+0900 W/AUL_AMD ( 2719): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2648) > process_pool: false
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-17 02:24:55.090+0900 W/AUL_AMD ( 2719): amd_launch.c: _start_app(2665) > pad pid(-5)
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-17 02:24:55.090+0900 D/AUL_AMD ( 2719): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-17 02:24:55.090+0900 D/AUL     ( 2719): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-17 02:24:55.100+0900 W/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-17 02:24:55.100+0900 D/AUL     ( 2903): process_pool.c: __send_pkt_raw_data(219) > send(12) : 616 / 616
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 3857, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-17 02:24:55.100+0900 W/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(265) > Check app launching
10-17 02:24:55.100+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-17 02:24:55.100+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-17 02:24:55.100+0900 D/RESOURCED( 2835): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-17 02:24:55.100+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-17 02:24:55.100+0900 E/RESOURCED( 2835): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-17 02:24:55.100+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-17 02:24:55.100+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-17 02:24:55.100+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-17 02:24:55.100+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-17 02:24:55.100+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-17 02:24:55.100+0900 D/AUL     ( 3857): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3858) is sent.
10-17 02:24:55.100+0900 D/AUL     ( 3857): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3858, signo: 10
10-17 02:24:55.110+0900 D/AUL     ( 3857): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : MwAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEQAAADE0NzY2Mzg2OTUvOTAwMDAA##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA0MDM4AA==##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-17 02:24:55.110+0900 D/AUL_PAD ( 3857): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-17 02:24:55.120+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: ui_app_main(788) > app_efl_main
10-17 02:24:55.120+0900 D/LAUNCH  ( 3857): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-17 02:24:55.120+0900 D/APP_CORE( 3857): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-17 02:24:55.120+0900 D/APP_CORE( 3857): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-17 02:24:55.120+0900 D/APP_CORE( 3857): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-17 02:24:55.120+0900 D/APP_CORE( 3857): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-17 02:24:55.120+0900 D/AUL     ( 3857): app_sock.c: __create_server_sock(156) > pg path - already exists
10-17 02:24:55.120+0900 D/APP_CORE( 3857): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4235520
10-17 02:24:55.120+0900 D/LAUNCH  ( 3857): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-17 02:24:55.120+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-17 02:24:55.140+0900 E/EFL     ( 3857): elementary<3857> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-17 02:24:55.160+0900 D/IMMODULE( 3857): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(524) > connect() succeeded
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(524) > connect() succeeded
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(524) > connect() succeeded
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_QUERY( 3857): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(524) > connect() succeeded
10-17 02:24:55.160+0900 D/IMMODULE( 3857): scim_panel_client.cpp: open_connection(162) > 
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(524) > connect() succeeded
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 02:24:55.160+0900 D/ISF_SOCKET( 3857): scim_socket.cpp: connect(524) > connect() succeeded
10-17 02:24:55.160+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-17 02:24:55.200+0900 D/LAUNCH  ( 3857): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-17 02:24:55.200+0900 E/E17     ( 2797): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
10-17 02:24:55.200+0900 D/APP_CORE( 3857): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-17 02:24:55.200+0900 E/E17     ( 2797): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
10-17 02:24:55.200+0900 W/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3857
10-17 02:24:55.210+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 02:24:55.210+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 02:24:55.210+0900 D/APP_CORE( 3857): appcore.c: __aul_handler(587) > [APP 3857]     AUL event: AUL_START
10-17 02:24:55.210+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(496) > [APP 3857] Event: RESET State: CREATED
10-17 02:24:55.210+0900 D/APP_CORE( 3857): appcore-efl.c: __do_app(527) > [APP 3857] RESET
10-17 02:24:55.210+0900 D/LAUNCH  ( 3857): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-17 02:24:55.210+0900 D/APP_CORE( 3857): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-17 02:24:55.210+0900 D/APP_CORE( 3857): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 02:24:55.210+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-17 02:24:55.210+0900 D/AUL     ( 3857): service.c: __set_bundle(186) > __set_bundle
10-17 02:24:55.210+0900 D/LAUNCH  ( 3857): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-17 02:24:55.210+0900 D/APP_CORE( 3857): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-17 02:24:55.210+0900 E/EFL     ( 3857): edje<3857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 02:24:55.210+0900 E/EFL     ( 3857): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 02:24:55.210+0900 E/EFL     ( 3857): edje<3857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 02:24:55.210+0900 E/EFL     ( 3857): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 02:24:55.210+0900 E/EFL     ( 3857): edje<3857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 02:24:55.210+0900 E/EFL     ( 3857): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 02:24:55.210+0900 E/EFL     ( 3857): edje<3857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 02:24:55.210+0900 E/EFL     ( 3857): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 02:24:55.210+0900 E/EFL     ( 3857): edje<3857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 02:24:55.210+0900 E/EFL     ( 3857): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 02:24:55.210+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-17 02:24:55.210+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 3857, appid: org.example.tichat
10-17 02:24:55.210+0900 D/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-17 02:24:55.210+0900 E/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(330) > access
10-17 02:24:55.210+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2700) > add app group info
10-17 02:24:55.210+0900 E/AUL     ( 2719): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-17 02:24:55.210+0900 D/AUL_AMD ( 2719): amd_status.c: _status_add_app_info_list(427) > pid(3857) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-17 02:24:55.210+0900 D/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(442) > pid(3668)
10-17 02:24:55.210+0900 W/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-17 02:24:55.210+0900 D/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(442) > pid(3668)
10-17 02:24:55.210+0900 W/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-17 02:24:55.220+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 15
10-17 02:24:55.220+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 02:24:55.220+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 02:24:55.220+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 3857
10-17 02:24:55.220+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-17 02:24:55.220+0900 E/RESOURCED( 2835): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-17 02:24:55.220+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(888) > available memory = 792
10-17 02:24:55.220+0900 D/AUL_AMD ( 2719): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3857 is org.example.tichat
10-17 02:24:55.220+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3857 : 0
10-17 02:24:55.220+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-17 02:24:55.220+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-17 02:24:55.220+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-17 02:24:55.220+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-17 02:24:55.220+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-17 02:24:55.220+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-17 02:24:55.220+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-17 02:24:55.220+0900 W/APP_CORE( 3857): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
10-17 02:24:55.220+0900 D/APP_CORE( 3857): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
10-17 02:24:55.220+0900 D/APP_CORE( 3857): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-17 02:24:55.220+0900 D/AUL     ( 3857): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-17 02:24:55.220+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 34
10-17 02:24:55.340+0900 D/APP_CORE( 3857): appcore.c: __prt_ltime(236) > [APP 3857] first idle after reset: 250 msec
10-17 02:24:55.450+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 02:24:55.450+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(496) > [APP 3857] Event: RESUME State: CREATED
10-17 02:24:55.450+0900 D/LAUNCH  ( 3857): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __do_app(607) > [APP 3857] RESUME
10-17 02:24:55.450+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-17 02:24:55.450+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(614) > [APP 3857] Initial Launching, call the resume_cb
10-17 02:24:55.450+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 02:24:55.450+0900 D/LAUNCH  ( 3857): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-17 02:24:55.450+0900 D/LAUNCH  ( 3857): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-17 02:24:55.450+0900 D/APP_CORE( 3857): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 02:24:55.450+0900 E/APP_CORE( 3857): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 02:24:55.450+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-17 02:24:55.450+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-17 02:24:55.450+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-17 02:24:55.450+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: PAUSE State: RUNNING
10-17 02:24:55.450+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(565) > [APP 2853] PAUSE
10-17 02:24:55.450+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-17 02:24:55.450+0900 E/cluster-home( 2853): homescreen.cpp: OnPause(84) >  app pause
10-17 02:24:55.450+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-17 02:24:55.450+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(923) >  END
10-17 02:24:55.450+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 02:24:55.450+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 02:24:55.460+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(4)
10-17 02:24:55.460+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-17 02:24:55.460+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-17 02:24:55.460+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: bg
10-17 02:24:55.460+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2853 is paused
10-17 02:24:55.460+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-17 02:24:55.480+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-17 02:24:55.480+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-17 02:24:55.480+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: bg
10-17 02:24:55.480+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-17 02:24:55.480+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2998
10-17 02:24:55.480+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2998, appname = org.tizen.calendar.widget
10-17 02:24:55.480+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2998
10-17 02:24:55.480+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(3857) status(3)
10-17 02:24:55.480+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 02:24:55.520+0900 W/AUL_AMD ( 2719): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-17 02:24:55.520+0900 W/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-17 02:24:55.520+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(3857) status(3)
10-17 02:24:55.520+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(3857) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-17 02:24:55.520+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-17 02:24:55.520+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3857, appid: org.example.tichat, status: fg
10-17 02:24:55.520+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3857
10-17 02:24:55.520+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3857, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-17 02:24:55.520+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3857
10-17 02:24:55.550+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3857, appname = org.example.tichat, pkgname = org.example.tichat
10-17 02:24:55.550+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3857, appname = org.example.tichat
10-17 02:24:55.550+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3857
10-17 02:24:55.550+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 02:24:55.550+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 02:24:55.610+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2910) > pid(3857) status(0)
10-17 02:24:56.010+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-17 02:24:56.010+0900 E/PKGMGR_SERVER( 3983): pkgmgr-server.c: main(2265) > package manager server terminated.
10-17 02:24:56.220+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-17 02:24:56.220+0900 D/AUL_PAD ( 4046): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-17 02:24:56.230+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-17 02:24:56.230+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.266
10-17 02:24:56.720+0900 D/AUL_AMD ( 2719): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-17 02:24:56.720+0900 D/RUA     ( 2719): rua.c: rua_add_history(179) > rua_add_history start
10-17 02:24:56.720+0900 D/RUA     ( 2719): rua.c: rua_add_history(247) > rua_add_history ok
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): launchpad_loader.c: main(588) > sleeping 1 sec...
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8a7b760
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(69) > get pre-initialization function
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(73) > get shutdown function
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8a7ba40
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8a7d640
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(69) > get pre-initialization function
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preload.h: __preload_init(73) > get shutdown function
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): preexec.h: __preexec_init(76) > preexec start
10-17 02:24:57.270+0900 D/AUL_PAD ( 4046): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-17 02:24:57.280+0900 D/AUL     ( 4046): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-17 02:24:57.280+0900 D/AUL     ( 4046): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-17 02:24:57.280+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4046
10-17 02:24:57.280+0900 D/AUL     ( 4046): process_pool.c: __connect_to_launchpad(132) > send(4046) : 4
10-17 02:24:57.280+0900 D/AUL     ( 4046): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-17 02:24:57.330+0900 D/AUL_PAD ( 4046): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-17 02:24:57.330+0900 D/AUL_PAD ( 4046): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-17 02:24:57.330+0900 D/AUL_PAD ( 4046): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-17 02:24:57.330+0900 D/AUL_PAD ( 4046): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-17 02:24:58.230+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600f19 
10-17 02:24:58.250+0900 E/EFL     ( 3857): edje<3857> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-17 02:24:58.250+0900 E/EFL     ( 3857): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 02:24:58.350+0900 E/EFL     ( 3857): elementary<3857> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x80062f19)
10-17 02:24:59.050+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600f19 
10-17 02:24:59.260+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600f19 
10-17 02:24:59.770+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600f19 
10-17 02:24:59.780+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb90b8938. set autocapital type : 2
10-17 02:24:59.780+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 02:24:59.780+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb90b8938. on demand : 0
10-17 02:24:59.780+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : f130023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 02:24:59.780+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 02:24:59.780+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 0
10-17 02:24:59.780+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb90b8938
10-17 02:24:59.780+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 02:25:00.380+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 1
10-17 02:25:00.380+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb90b8938, bidi direction : 0x1
10-17 02:25:00.460+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-17 02:25:00.460+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: MEM_FLUSH State: PAUSED
10-17 02:25:00.460+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-17 02:25:00.460+0900 D/APP_CORE( 2853): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2853
10-17 02:25:00.460+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-17 02:25:00.460+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2853
10-17 02:25:00.590+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 2
10-17 02:25:00.650+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 3
10-17 02:25:00.670+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 4
10-17 02:25:00.780+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 5
10-17 02:25:00.790+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 2:25 4 h"
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 2:25"
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 2&#x2236;25"
10-17 02:25:00.830+0900 D/INDICATOR( 2840): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146696699 Time: <font_size=33>2&#x2236;25</font_size> <font_size=32>AM</font_size></font>
10-17 02:25:00.860+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 6
10-17 02:25:00.860+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 7
10-17 02:25:00.990+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 8
10-17 02:25:01.140+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 9
10-17 02:25:01.170+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90b8938, cursor pos : 10
10-17 02:25:01.440+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600f19 
10-17 02:25:01.440+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb90b8938
10-17 02:25:01.440+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 02:25:01.440+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb90b8938
10-17 02:25:01.440+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 02:25:01.440+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb90e8e70. set autocapital type : 0
10-17 02:25:01.450+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb90e8e70. on demand : 0
10-17 02:25:01.450+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 02:25:01.450+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : f140023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 02:25:01.450+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 02:25:01.450+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 0
10-17 02:25:01.450+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb90e8e70
10-17 02:25:01.450+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 02:25:01.750+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 1
10-17 02:25:01.750+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb90e8e70, bidi direction : 0x1
10-17 02:25:01.810+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 2
10-17 02:25:01.960+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 3
10-17 02:25:02.180+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 4
10-17 02:25:02.450+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 5
10-17 02:25:02.550+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 6
10-17 02:25:02.640+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90e8e70, cursor pos : 7
10-17 02:25:02.950+0900 D/IMMODULE( 3857): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb90e8e70
10-17 02:25:02.950+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 02:25:02.950+0900 D/IMMODULE( 3857): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb90e8e70
10-17 02:25:02.950+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 02:25:02.960+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600f19 
10-17 02:25:03.010+0900 I/CAPI_NETWORK_CONNECTION( 3857): connection.c: connection_create(408) > New handle created[0xb90b75f0]
10-17 02:25:03.010+0900 I/CAPI_NETWORK_CONNECTION( 3857): connection.c: connection_get_type(464) > Connected Network = 3
10-17 02:25:03.010+0900 I/tichat  ( 3857): Network connection type : 3
10-17 02:25:03.010+0900 I/tichat  ( 3857): IP address : 
10-17 02:25:03.010+0900 I/tichat  ( 3857): Login Jason : {"id":"bcxvbxcvan","password":"vcbawfw"}
10-17 02:25:03.840+0900 W/CRASH_MANAGER( 4049): worker.c: worker_job(1204) > 1103857746963147663870
