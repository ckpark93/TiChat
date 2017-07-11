S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 8389
Date: 2016-10-12 01:49:54+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a658

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8e68698, esi = 0x8000a654
ebp = 0xbffe9138, esp = 0xbffe90f0
eax = 0xb379aa68, ebx = 0xb63912b8
ecx = 0x8000a654, edx = 0x80032995
eip = 0xb37990f0

Memory Information
MemTotal:      250 KB
MemFree:       154 KB
Buffers:         6 KB
Cached:     167976 KB
VmPeak:     109292 KB
VmSize:     109292 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22260 KB
VmRSS:       22260 KB
VmData:      42640 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8389 TID = 8389
8389 8401 8611 8612 8616 

Maps Information
b2c7e000 b2c88000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c8e000 b2c9a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c9b000 b2cbc000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cc1000 b2cc2000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cc3000 b2cc8000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cc9000 b2ccb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2ccc000 b2cce000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2ccf000 b2cdb000 r-xp /usr/lib/libdrm.so.2.4.0
b2cdc000 b2cdf000 r-xp /usr/lib/libdri2.so.0.0.0
b2ce0000 b2cea000 r-xp /usr/lib/libtbm.so.1.0.0
b2cf1000 b2cf2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2cf3000 b2cf4000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2cf5000 b2cf8000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2cf9000 b2cfc000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2cfd000 b2d12000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d13000 b2d25000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b362e000 b3634000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3635000 b3779000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3789000 b378a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b378b000 b378c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b378d000 b3796000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3797000 b379a000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b379b000 b37d4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41d7000 b41e2000 r-xp /lib/libnss_files-2.20-2014.11.so
b41e4000 b41ef000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f1000 b4208000 r-xp /lib/libnsl-2.20-2014.11.so
b420c000 b4214000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4216000 b423a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b423b000 b423c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b423d000 b4240000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4241000 b4248000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4249000 b4253000 r-xp /usr/lib/libsensord-share.so
b4254000 b4270000 r-xp /usr/lib/libsensor.so.1.2.0
b4272000 b427b000 r-xp /usr/lib/libappcore-common.so.1.1
b427e000 b4280000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4295000 b4297000 r-xp /usr/lib/libXau.so.6.0.0
b4298000 b42ba000 r-xp /usr/lib/libxcb.so.1.1.0
b42bc000 b42c5000 r-xp /lib/libcrypt-2.20-2014.11.so
b42ee000 b42f0000 r-xp /usr/lib/libiri.so
b42f1000 b4317000 r-xp /lib/libexpat.so.1.5.2
b4319000 b4384000 r-xp /usr/lib/libssl.so.1.0.0
b438a000 b4396000 r-xp /usr/lib/libethumb.so.1.13.0
b4397000 b439b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b439c000 b45ed000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b68000 b5b78000 r-xp /usr/lib/libXi.so.6.1.0
b5b79000 b5b7b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b7c000 b5b82000 r-xp /usr/lib/libXtst.so.6.1.0
b5b83000 b5b8d000 r-xp /usr/lib/libXrender.so.1.3.0
b5b8e000 b5b97000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b99000 b5b9b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b9c000 b5ba1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba2000 b5bb4000 r-xp /usr/lib/libXext.so.6.4.0
b5bb5000 b5bb7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bb8000 b5bba000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bbc000 b5cfe000 r-xp /usr/lib/libX11.so.6.3.0
b5d02000 b5d0c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d0d000 b5d23000 r-xp /usr/lib/libudev.so.1.6.0
b5d26000 b5d2a000 r-xp /lib/libattr.so.1.1.0
b5d2b000 b5d5a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d5c000 b5d62000 r-xp /usr/lib/libffi.so.6.0.2
b5d63000 b5d86000 r-xp /lib/libz.so.1.2.8
b5d87000 b5d8a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d8b000 b5ee7000 r-xp /usr/lib/libxml2.so.2.9.2
b5eed000 b5fd4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe1000 b5fe4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fe5000 b6007000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6008000 b601c000 r-xp /lib/libresolv-2.20-2014.11.so
b6020000 b6044000 r-xp /usr/lib/liblzma.so.5.0.3
b6045000 b6047000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6049000 b6053000 r-xp /usr/lib/libembryo.so.1.13.0
b6054000 b607d000 r-xp /usr/lib/libpng12.so.0.50.0
b607e000 b60c7000 r-xp /usr/lib/libjpeg.so.8.0.2
b60d8000 b60df000 r-xp /lib/librt-2.20-2014.11.so
b60e1000 b6100000 r-xp /usr/lib/libector.so.1.13.0
b6103000 b6130000 r-xp /usr/lib/liblua-5.1.so
b6131000 b61c1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61c5000 b6203000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6204000 b621a000 r-xp /usr/lib/libfribidi.so.0.3.1
b621b000 b6274000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6277000 b62c2000 r-xp /lib/libm-2.20-2014.11.so
b62c4000 b62d6000 r-xp /usr/lib/libeio.so.1.13.0
b62d7000 b62da000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62db000 b62e1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e2000 b6305000 r-xp /usr/lib/libefreet.so.1.13.0
b6308000 b6333000 r-xp /usr/lib/libeldbus.so.1.13.0
b6334000 b6368000 r-xp /usr/lib/libecore_con.so.1.13.0
b636a000 b6373000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6374000 b637d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b637e000 b6391000 r-xp /usr/lib/libeo.so.1.13.0
b6393000 b63a6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63a7000 b63ae000 r-xp /usr/lib/libecore_file.so.1.13.0
b63af000 b63d2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d3000 b63ff000 r-xp /usr/lib/libeet.so.1.13.0
b6408000 b6473000 r-xp /usr/lib/libeina.so.1.13.0
b6476000 b648d000 r-xp /usr/lib/libefl.so.1.13.0
b648f000 b65f6000 r-xp /usr/lib/libicuuc.so.51.1
b6604000 b6810000 r-xp /usr/lib/libicui18n.so.51.1
b6818000 b6867000 r-xp /usr/lib/libecore_x.so.1.13.0
b6869000 b6883000 r-xp /lib/libgcc_s-4.9.so.1
b6885000 b6889000 r-xp /lib/libcap.so.2.21
b688a000 b68d0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d1000 b68d8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68da000 b692c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b692e000 b6ab9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6abe000 b6b8c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b8f000 b6b93000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b94000 b6ba3000 r-xp /usr/lib/libvconf.so.0.2.45
b6ba4000 b6ba7000 r-xp /usr/lib/libvasum.so.0.3.1
b6ba8000 b6bab000 r-xp /usr/lib/libttrace.so.1.1
b6bad000 b6bb1000 r-xp /usr/lib/libiniparser.so.0
b6bb2000 b6be2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be3000 b6bec000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bed000 b6c12000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c13000 b6c23000 r-xp /usr/lib/libunwind.so.8.0.1
b6c2d000 b6ddb000 r-xp /lib/libc-2.20-2014.11.so
b6de3000 b6f26000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f28000 b6f80000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f81000 b6fb5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fb8000 b708c000 r-xp /usr/lib/libedje.so.1.13.0
b708f000 b70bb000 r-xp /usr/lib/libecore.so.1.13.0
b70cc000 b72f2000 r-xp /usr/lib/libevas.so.1.13.0
b731a000 b7332000 r-xp /lib/libpthread-2.20-2014.11.so
b7336000 b76b0000 r-xp /usr/lib/libelementary.so.1.13.0
b76d0000 b76d4000 r-xp /usr/lib/libsmack.so.1.0.0
b76d5000 b76de000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76df000 b76e2000 r-xp /usr/lib/libdlog.so.0.0.0
b76e3000 b76e8000 r-xp /usr/lib/libbundle.so.0.1.22
b76e9000 b76ec000 r-xp /lib/libdl-2.20-2014.11.so
b76ee000 b7713000 r-xp /usr/lib/libaul.so.0.1.0
b7716000 b7718000 r-xp /usr/lib/libappsvc.so.0.1.0
b7719000 b771e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b771f000 b7726000 r-xp /usr/lib/libappcore-efl.so.1.1
b7728000 b772d000 r-xp /usr/lib/libsys-assert.so
b7730000 b7731000 r-xp [vdso]
b7731000 b7753000 r-xp /lib/ld-2.20-2014.11.so
b7755000 b775d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8389)
Call Stack Count: 21
 0: btn_submit_cb + 0x30 (0xb37990f0) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x20f0
 1: (0xb7155116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb638c319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6389d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71579e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7408404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb703bf39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7042a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb703cfdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb703d4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb703d68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70a2702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb709c055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70a51b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70a5587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb74fe22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7722dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb771bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x279 (0xb3798359) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1359
19: btn_submit_cb + 0x88 (0xb7757148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7757148
20: __libc_start_main + 0xde (0xb6c44e4e) [/lib/libc.so.6] + 0x17e4e
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
D/rpm-installer( 8555): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.tichat, /opt/usr/apps/org.example.tichat/signature1.xml, 0, org.example.tichat), result=[0]
10-12 01:49:49.273+0900 D/rpm-installer( 8555): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.tichat, /opt/share/packages/org.example.tichat.xml, 0, org.example.tichat), result=[0]
10-12 01:49:49.283+0900 D/rpm-installer( 8555): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.tichat] version set to [2.4] result=[0]
10-12 01:49:49.283+0900 D/rpm-installer( 8555): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
10-12 01:49:49.283+0900 D/rpm-installer( 8555): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.tichat, 7), result=[0]
10-12 01:49:49.283+0900 D/rpm-installer( 8555): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(8555), zone(host), pkg_typ(tpk), pkg_id(org.example.tichat), key(install_percent), val(100)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(8555), pkg_typ(tpk), pkg_id(org.example.tichat), key(install_percent), val(100)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
10-12 01:49:49.283+0900 D/PKGMGR_INSTALLER( 8555): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.tichat] key[install_percent] value[100]
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(8555), zone(host), pkg_typ(tpk), pkg_id(org.example.tichat), key(install_percent), val(100)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(8555), pkg_typ(tpk), pkg_id(org.example.tichat), key(install_percent), val(100)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
10-12 01:49:49.283+0900 D/rpm-installer( 8555): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.tichat) is done.
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(8555), zone(host), pkg_typ(tpk), pkg_id(org.example.tichat), key(end), val(ok)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(8555), pkg_typ(tpk), pkg_id(org.example.tichat), key(end), val(ok)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
10-12 01:49:49.283+0900 D/PKGMGR_INSTALLER( 8555): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.tichat] key[end] value[ok]
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(8555), zone(host), pkg_typ(tpk), pkg_id(org.example.tichat), key(end), val(ok)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(8555), pkg_typ(tpk), pkg_id(org.example.tichat), key(end), val(ok)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8555): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
10-12 01:49:49.283+0900 D/PKGMGR  ( 3027): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2867): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 W/cluster-home( 2867): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.tichat]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2867): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28670003] pkg_type[tpk] package[org.example.tichat] key[install_percent] val[100] pmsg[(null)]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2923): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.tichat] 100
10-12 01:49:49.283+0900 D/PKGMGR  ( 3081): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/PKGMGR  ( 3081): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/PKGMGR  ( 3027): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/ISF_PANEL_EFL( 3027): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.tichat event_type=UPDATE event_state=COMPLETED progress=100 error=0
10-12 01:49:49.283+0900 D/PKGMGR  ( 2941): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2941): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2948): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2948): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-12 01:49:49.283+0900 D/PKGMGR  ( 2948): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2948): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
10-12 01:49:49.283+0900 D/PKGMGR  ( 2740): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/AUL_AMD ( 2740): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.tichat), key(end), value(ok)
10-12 01:49:49.283+0900 W/AUL_AMD ( 2740): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
10-12 01:49:49.283+0900 D/PKGMGR  ( 8550): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/PKGMGR  ( 8550): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/PKGMGR  ( 2939): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/ESD     ( 2939): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29390002), pkg_type(tpk), pkgid(org.example.tichat), key(install_percent), val(100)
10-12 01:49:49.283+0900 D/PKGMGR  ( 2939): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/ESD     ( 2939): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29390002), pkg_type(tpk), pkgid(org.example.tichat), key(end), val(ok)
10-12 01:49:49.283+0900 D/ESD     ( 2939): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
10-12 01:49:49.283+0900 D/PKGMGR  ( 2923): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.tichat] ok
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.tichat], event_type[1]
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
10-12 01:49:49.283+0900 W/ISF_PANEL_EFL( 3027): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
10-12 01:49:49.283+0900 D/PKGMGR  ( 2930): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[install_percent], value=[100]
10-12 01:49:49.283+0900 D/QUICKPANEL( 2930): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.tichat key:install_percent val:100
10-12 01:49:49.283+0900 D/PKGMGR  ( 2930): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.283+0900 D/QUICKPANEL( 2930): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.tichat key:end val:ok
10-12 01:49:49.283+0900 D/AUL_AMD ( 2740): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.tichat, type:rpm
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
10-12 01:49:49.283+0900 D/DATA_PROVIDER_MASTER( 2923): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.tichat]
10-12 01:49:49.293+0900 D/PKGMGR  ( 2867): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.293+0900 W/cluster-home( 2867): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.tichat]
10-12 01:49:49.293+0900 D/cluster-home( 2867): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.tichat]
10-12 01:49:49.293+0900 D/PKGMGR  ( 2867): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.tichat_-1440271469], pkg_type=[tpk], pkgid=[org.example.tichat], key=[end], value=[ok]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28670003] pkg_type[tpk] package[org.example.tichat] key[end] val[ok] pmsg[(null)]
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.tichat]
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.tichat]
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.tichat]
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.tichat]
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.tichat] Name[tichat] Icon[/opt/usr/apps/org.example.tichat/shared/res/tichat.png] enable[1] system[0]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.tichat]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.tichat
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[16], isFolder[0], pageId[1], col[4], row[4], appId[org.example.tichat], name[tichat], menuId[1], isPreload[0] isPreload[0]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
10-12 01:49:49.293+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.tichat] Name[tichat] Icon[/opt/usr/apps/org.example.tichat/shared/res/tichat.png] enable[1] system[0]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [tichat]
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
10-12 01:49:49.293+0900 D/test-log( 2867): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png], New icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png]!!!!!
10-12 01:49:49.293+0900 D/cluster-home( 2867): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 16]
10-12 01:49:49.403+0900 D/rpm-installer( 8555): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
10-12 01:49:49.403+0900 D/rpm-installer( 8555): rpm-appcore-intf.c: main(259) > ------------------------------------------------
10-12 01:49:49.403+0900 D/rpm-installer( 8555): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
10-12 01:49:49.403+0900 D/rpm-installer( 8555): rpm-appcore-intf.c: main(261) > ------------------------------------------------
10-12 01:49:49.403+0900 D/PKGMGR_SERVER( 8552): pkgmgr-server.c: sighandler(387) > child exit [8555]
10-12 01:49:49.403+0900 E/PKGMGR_SERVER( 8552): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8555]
10-12 01:49:49.463+0900 E/CAPI_NETWORK_WIFI( 2852): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-12 01:49:49.463+0900 E/INDICATOR( 2852): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fcff)
10-12 01:49:49.463+0900 E/INDICATOR( 2852): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-12 01:49:49.463+0900 E/INDICATOR( 2852): 
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-12 01:49:50.933+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-12 01:49:50.933+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-12 01:49:50.933+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-12 01:49:50.933+0900 D/AUL     ( 2740): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8605, pid = 8607
10-12 01:49:50.933+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-12 01:49:50.933+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-12 01:49:50.933+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-12 01:49:50.933+0900 E/AUL_AMD ( 2740): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-12 01:49:50.933+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2233) > caller pid : 8607
10-12 01:49:50.933+0900 E/AUL_AMD ( 2740): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-12 01:49:50.933+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2648) > process_pool: false
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-12 01:49:50.933+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2665) > pad pid(-5)
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-12 01:49:50.933+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-12 01:49:50.933+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-12 01:49:50.933+0900 W/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-12 01:49:50.933+0900 D/AUL     ( 2917): process_pool.c: __send_pkt_raw_data(219) > send(11) : 616 / 616
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8389, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-12 01:49:50.933+0900 W/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(265) > Check app launching
10-12 01:49:50.933+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-12 01:49:50.933+0900 D/RESOURCED( 2849): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-12 01:49:50.933+0900 D/RESOURCED( 2849): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-12 01:49:50.933+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-12 01:49:50.933+0900 E/RESOURCED( 2849): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-12 01:49:50.933+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-12 01:49:50.943+0900 D/AUL     ( 8389): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8401) is sent.
10-12 01:49:50.943+0900 D/AUL     ( 8389): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8401, signo: 10
10-12 01:49:50.943+0900 D/AUL     ( 8389): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzYyMDQ1OTAvOTQ1OTIzAA==##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4NjA3AA==##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-12 01:49:50.943+0900 D/AUL_PAD ( 8389): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-12 01:49:50.943+0900 I/CAPI_APPFW_APPLICATION( 8389): app_main.c: ui_app_main(788) > app_efl_main
10-12 01:49:50.943+0900 D/LAUNCH  ( 8389): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-12 01:49:50.943+0900 D/APP_CORE( 8389): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-12 01:49:50.943+0900 D/APP_CORE( 8389): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-12 01:49:50.943+0900 D/APP_CORE( 8389): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-12 01:49:50.943+0900 D/APP_CORE( 8389): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-12 01:49:50.943+0900 D/AUL     ( 8389): app_sock.c: __create_server_sock(156) > pg path - already exists
10-12 01:49:50.943+0900 D/APP_CORE( 8389): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb427b520
10-12 01:49:50.943+0900 D/LAUNCH  ( 8389): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-12 01:49:50.943+0900 I/CAPI_APPFW_APPLICATION( 8389): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-12 01:49:50.983+0900 E/EFL     ( 8389): elementary<8389> elm_layout.c:637 _elm_layout_part_aliasing_eval() no default content part set for object 0x8000ac57 -- part must not be NULL
10-12 01:49:50.983+0900 E/EFL     ( 8389): elementary<8389> elm_layout.c:637 _elm_layout_part_aliasing_eval() no default content part set for object 0x8000ac57 -- part must not be NULL
10-12 01:49:50.993+0900 D/LAUNCH  ( 8389): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-12 01:49:50.993+0900 E/PKGMGR_SERVER( 8552): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-12 01:49:50.993+0900 D/APP_CORE( 8389): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-12 01:49:50.993+0900 E/PKGMGR_SERVER( 8552): pkgmgr-server.c: main(2265) > package manager server terminated.
10-12 01:49:50.993+0900 E/E17     ( 2779): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
10-12 01:49:51.003+0900 E/E17     ( 2779): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
10-12 01:49:51.003+0900 D/APP_CORE( 8389): appcore.c: __aul_handler(587) > [APP 8389]     AUL event: AUL_START
10-12 01:49:51.003+0900 I/APP_CORE( 8389): appcore-efl.c: __do_app(496) > [APP 8389] Event: RESET State: CREATED
10-12 01:49:51.003+0900 D/APP_CORE( 8389): appcore-efl.c: __do_app(527) > [APP 8389] RESET
10-12 01:49:51.003+0900 D/LAUNCH  ( 8389): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-12 01:49:51.003+0900 D/APP_CORE( 8389): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-12 01:49:51.003+0900 D/APP_CORE( 8389): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 01:49:51.003+0900 I/CAPI_APPFW_APPLICATION( 8389): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-12 01:49:51.003+0900 D/AUL     ( 8389): service.c: __set_bundle(186) > __set_bundle
10-12 01:49:51.003+0900 D/LAUNCH  ( 8389): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-12 01:49:51.003+0900 D/APP_CORE( 8389): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-12 01:49:51.003+0900 E/EFL     ( 8389): edje<8389> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 01:49:51.003+0900 E/EFL     ( 8389): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 01:49:51.003+0900 E/EFL     ( 8389): edje<8389> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 01:49:51.003+0900 E/EFL     ( 8389): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 01:49:51.003+0900 E/EFL     ( 8389): edje<8389> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 01:49:51.003+0900 E/EFL     ( 8389): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 01:49:51.003+0900 E/EFL     ( 8389): edje<8389> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 01:49:51.003+0900 E/EFL     ( 8389): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 01:49:51.003+0900 E/EFL     ( 8389): edje<8389> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-12 01:49:51.003+0900 E/EFL     ( 8389): By the power of Grayskull, your previous Embryo stack is now broken!
10-12 01:49:51.013+0900 W/APP_CORE( 8389): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
10-12 01:49:51.013+0900 D/APP_CORE( 8389): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
10-12 01:49:51.013+0900 D/APP_CORE( 8389): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-12 01:49:51.013+0900 D/AUL     ( 8389): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-12 01:49:51.013+0900 W/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8389
10-12 01:49:51.013+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 01:49:51.013+0900 E/EFL     ( 2779): eo<2779> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-12 01:49:51.013+0900 D/INDICATOR( 2852): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-12 01:49:51.013+0900 D/INDICATOR( 2852): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-12 01:49:51.013+0900 D/INDICATOR( 2852): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-12 01:49:51.013+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-12 01:49:51.013+0900 D/INDICATOR( 2852): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-12 01:49:51.013+0900 D/INDICATOR( 2852): main.c: _rotate_window(252) > port :: hide more icon
10-12 01:49:51.043+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-12 01:49:51.043+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8389, appid: org.example.tichat
10-12 01:49:51.043+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-12 01:49:51.043+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
10-12 01:49:51.043+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2700) > add app group info
10-12 01:49:51.043+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-12 01:49:51.043+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(8389) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-12 01:49:51.043+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 8389
10-12 01:49:51.043+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
10-12 01:49:51.043+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-12 01:49:51.043+0900 E/RESOURCED( 2849): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-12 01:49:51.043+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
10-12 01:49:51.043+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(888) > available memory = 803
10-12 01:49:51.043+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 01:49:51.043+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-12 01:49:51.043+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8389 is org.example.tichat
10-12 01:49:51.043+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8389 : 0
10-12 01:49:51.043+0900 D/AUL     ( 2941): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-12 01:49:51.123+0900 D/APP_CORE( 8389): appcore.c: __prt_ltime(236) > [APP 8389] first idle after reset: 186 msec
10-12 01:49:51.373+0900 E/E17     ( 2779): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-12 01:49:51.373+0900 I/APP_CORE( 8389): appcore-efl.c: __do_app(496) > [APP 8389] Event: RESUME State: CREATED
10-12 01:49:51.373+0900 D/LAUNCH  ( 8389): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __do_app(607) > [APP 8389] RESUME
10-12 01:49:51.373+0900 I/APP_CORE( 8389): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-12 01:49:51.373+0900 I/APP_CORE( 8389): appcore-efl.c: __do_app(614) > [APP 8389] Initial Launching, call the resume_cb
10-12 01:49:51.373+0900 I/CAPI_APPFW_APPLICATION( 8389): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-12 01:49:51.373+0900 D/LAUNCH  ( 8389): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-12 01:49:51.373+0900 D/LAUNCH  ( 8389): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-12 01:49:51.373+0900 D/APP_CORE( 8389): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 01:49:51.373+0900 E/APP_CORE( 8389): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 01:49:51.373+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-12 01:49:51.373+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-12 01:49:51.373+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-12 01:49:51.373+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
10-12 01:49:51.373+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
10-12 01:49:51.373+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-12 01:49:51.373+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
10-12 01:49:51.373+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-12 01:49:51.373+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
10-12 01:49:51.373+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-12 01:49:51.373+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-12 01:49:51.373+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
10-12 01:49:51.373+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-12 01:49:51.373+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-12 01:49:51.373+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
10-12 01:49:51.373+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(8389) status(3)
10-12 01:49:51.373+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-12 01:49:51.373+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-12 01:49:51.373+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-12 01:49:51.373+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(8389) status(3)
10-12 01:49:51.373+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(8389) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-12 01:49:51.373+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-12 01:49:51.373+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8389, appid: org.example.tichat, status: fg
10-12 01:49:51.373+0900 D/RESOURCED( 2849): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8389
10-12 01:49:51.373+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8389, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-12 01:49:51.373+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8389
10-12 01:49:51.383+0900 D/DATA_PROVIDER_MASTER( 2923): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
10-12 01:49:51.383+0900 D/DATA_PROVIDER_MASTER( 2923): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-12 01:49:51.383+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-12 01:49:51.383+0900 I/CAPI_WIDGET_APPLICATION( 3000): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-12 01:49:51.383+0900 W/AUL     ( 3000): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3000, appid: org.tizen.calendar.widget, status: bg
10-12 01:49:51.433+0900 D/RESOURCED( 2849): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8389, appname = org.example.tichat, pkgname = org.example.tichat
10-12 01:49:51.433+0900 D/RESOURCED( 2849): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8389, appname = org.example.tichat
10-12 01:49:51.433+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8389
10-12 01:49:51.433+0900 D/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3000, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-12 01:49:51.433+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3000
10-12 01:49:51.433+0900 D/RESOURCED( 2849): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3000, appname = org.tizen.calendar.widget
10-12 01:49:51.433+0900 D/RESOURCED( 2849): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3000
10-12 01:49:51.433+0900 I/RESOURCED( 2849): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-12 01:49:51.433+0900 I/RESOURCED( 2849): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-12 01:49:51.453+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(8389) status(0)
10-12 01:49:52.043+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-12 01:49:52.043+0900 D/AUL_PAD ( 8615): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-12 01:49:52.053+0900 D/AUL_PAD ( 2917): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-12 01:49:52.053+0900 E/RESOURCED( 2849): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.706
10-12 01:49:52.323+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401c01 
10-12 01:49:52.553+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-12 01:49:52.553+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
10-12 01:49:52.553+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
10-12 01:49:52.723+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401c01 
10-12 01:49:52.793+0900 E/EFL     ( 8389): elementary<8389> elm_layout.c:637 _elm_layout_part_aliasing_eval() no default content part set for object 0x80028342 -- part must not be NULL
10-12 01:49:53.063+0900 D/AUL_PAD ( 8615): launchpad_loader.c: main(588) > sleeping 1 sec...
10-12 01:49:53.063+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9668760
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(69) > get pre-initialization function
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(73) > get shutdown function
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9668a40
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b966a640
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(69) > get pre-initialization function
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preload.h: __preload_init(73) > get shutdown function
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): preexec.h: __preexec_init(76) > preexec start
10-12 01:49:53.073+0900 D/AUL_PAD ( 8615): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-12 01:49:53.073+0900 D/AUL     ( 8615): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-12 01:49:53.073+0900 D/AUL     ( 8615): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-12 01:49:53.073+0900 D/AUL     ( 8615): process_pool.c: __connect_to_launchpad(132) > send(8615) : 4
10-12 01:49:53.073+0900 D/AUL     ( 8615): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-12 01:49:53.073+0900 D/AUL_PAD ( 2917): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8615
10-12 01:49:53.173+0900 D/AUL_PAD ( 8615): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-12 01:49:53.183+0900 D/AUL_PAD ( 8615): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-12 01:49:53.183+0900 D/AUL_PAD ( 8615): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-12 01:49:53.183+0900 D/AUL_PAD ( 8615): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-12 01:49:53.733+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2e00002
10-12 01:49:54.163+0900 D/PROCESSMGR( 2779): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401c01 
10-12 01:49:54.253+0900 W/CRASH_MANAGER( 8618): worker.c: worker_job(1204) > 1108389746963147620459
