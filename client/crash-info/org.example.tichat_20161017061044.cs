S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 9380
Date: 2016-10-17 06:10:44+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7b62198, esi = 0x800cfa81
ebp = 0xbfb7bb98, esp = 0xbfb7bb60
eax = 0x00000000, ebx = 0xb730b5f0
ecx = 0x000016ca, edx = 0x00000015
eip = 0xb7162bbf

Memory Information
MemTotal:      250 KB
MemFree:       124 KB
Buffers:         5 KB
Cached:     185404 KB
VmPeak:     117652 KB
VmSize:     111752 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31108 KB
VmRSS:       25044 KB
VmData:      43272 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34588 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9380 TID = 9380
9380 9382 9564 9565 9570 

Maps Information
b2ad1000 b2ad8000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2ad9000 b2af1000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2af2000 b2af9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b76000 b2b80000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b86000 b2b92000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b93000 b2bb4000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bb9000 b2bba000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bbb000 b2bc0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bc1000 b2bc3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bc4000 b2bc6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bc7000 b2bd3000 r-xp /usr/lib/libdrm.so.2.4.0
b2bd4000 b2bd7000 r-xp /usr/lib/libdri2.so.0.0.0
b2bd8000 b2be2000 r-xp /usr/lib/libtbm.so.1.0.0
b2be3000 b2bf8000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bf9000 b2c0b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b340d000 b343e000 r-xp /usr/lib/libidn.so.11.5.44
b343f000 b3461000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3462000 b3472000 r-xp /usr/lib/libcares.so.2.1.0
b3473000 b3493000 r-xp /usr/lib/libnetwork.so.0.0.0
b3494000 b349d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b349e000 b3515000 r-xp /usr/lib/libcurl.so.4.3.0
b3517000 b352b000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b3532000 b3533000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3534000 b3535000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3536000 b3539000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b353a000 b353d000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3645000 b364b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b364c000 b3790000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37a0000 b37a1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37a2000 b37a3000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37a4000 b37b1000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37b2000 b37eb000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41ee000 b41f9000 r-xp /lib/libnss_files-2.20-2014.11.so
b41fb000 b4206000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4208000 b421f000 r-xp /lib/libnsl-2.20-2014.11.so
b4223000 b422b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b422d000 b4251000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4252000 b4253000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4254000 b4257000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4258000 b425f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4260000 b426a000 r-xp /usr/lib/libsensord-share.so
b426b000 b4287000 r-xp /usr/lib/libsensor.so.1.2.0
b4289000 b4292000 r-xp /usr/lib/libappcore-common.so.1.1
b4295000 b4297000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42ac000 b42ae000 r-xp /usr/lib/libXau.so.6.0.0
b42af000 b42d1000 r-xp /usr/lib/libxcb.so.1.1.0
b42d3000 b42dc000 r-xp /lib/libcrypt-2.20-2014.11.so
b4305000 b4307000 r-xp /usr/lib/libiri.so
b4308000 b432e000 r-xp /lib/libexpat.so.1.5.2
b4330000 b439b000 r-xp /usr/lib/libssl.so.1.0.0
b43a1000 b43ad000 r-xp /usr/lib/libethumb.so.1.13.0
b43ae000 b43b2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43b3000 b4604000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b7f000 b5b8f000 r-xp /usr/lib/libXi.so.6.1.0
b5b90000 b5b92000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b93000 b5b99000 r-xp /usr/lib/libXtst.so.6.1.0
b5b9a000 b5ba4000 r-xp /usr/lib/libXrender.so.1.3.0
b5ba5000 b5bae000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bb0000 b5bb2000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bb3000 b5bb8000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bb9000 b5bcb000 r-xp /usr/lib/libXext.so.6.4.0
b5bcc000 b5bce000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bcf000 b5bd1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bd3000 b5d15000 r-xp /usr/lib/libX11.so.6.3.0
b5d19000 b5d23000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d24000 b5d3a000 r-xp /usr/lib/libudev.so.1.6.0
b5d3d000 b5d41000 r-xp /lib/libattr.so.1.1.0
b5d42000 b5d71000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d73000 b5d79000 r-xp /usr/lib/libffi.so.6.0.2
b5d7a000 b5d9d000 r-xp /lib/libz.so.1.2.8
b5d9e000 b5da1000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5da2000 b5efe000 r-xp /usr/lib/libxml2.so.2.9.2
b5f04000 b5feb000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ff8000 b5ffb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ffc000 b601e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b601f000 b6033000 r-xp /lib/libresolv-2.20-2014.11.so
b6037000 b605b000 r-xp /usr/lib/liblzma.so.5.0.3
b605c000 b605e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6060000 b606a000 r-xp /usr/lib/libembryo.so.1.13.0
b606b000 b6094000 r-xp /usr/lib/libpng12.so.0.50.0
b6095000 b60de000 r-xp /usr/lib/libjpeg.so.8.0.2
b60ef000 b60f6000 r-xp /lib/librt-2.20-2014.11.so
b60f8000 b6117000 r-xp /usr/lib/libector.so.1.13.0
b611a000 b6147000 r-xp /usr/lib/liblua-5.1.so
b6148000 b61d8000 r-xp /usr/lib/libfreetype.so.6.11.3
b61dc000 b621a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b621b000 b6231000 r-xp /usr/lib/libfribidi.so.0.3.1
b6232000 b628b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b628e000 b62d9000 r-xp /lib/libm-2.20-2014.11.so
b62db000 b62ed000 r-xp /usr/lib/libeio.so.1.13.0
b62ee000 b62f1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62f2000 b62f8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62f9000 b631c000 r-xp /usr/lib/libefreet.so.1.13.0
b631f000 b634a000 r-xp /usr/lib/libeldbus.so.1.13.0
b634b000 b637f000 r-xp /usr/lib/libecore_con.so.1.13.0
b6381000 b638a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b638b000 b6394000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6395000 b63a8000 r-xp /usr/lib/libeo.so.1.13.0
b63aa000 b63bd000 r-xp /usr/lib/libecore_input.so.1.13.0
b63be000 b63c5000 r-xp /usr/lib/libecore_file.so.1.13.0
b63c6000 b63e9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ea000 b6416000 r-xp /usr/lib/libeet.so.1.13.0
b641f000 b648a000 r-xp /usr/lib/libeina.so.1.13.0
b648d000 b64a4000 r-xp /usr/lib/libefl.so.1.13.0
b64a6000 b660d000 r-xp /usr/lib/libicuuc.so.51.1
b661b000 b6827000 r-xp /usr/lib/libicui18n.so.51.1
b682f000 b687e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6880000 b689a000 r-xp /lib/libgcc_s-4.9.so.1
b689c000 b68a0000 r-xp /lib/libcap.so.2.21
b68a1000 b68e7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68e8000 b68ef000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68f1000 b6943000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6945000 b6ad0000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ad5000 b6ba3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ba6000 b6baa000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bab000 b6bba000 r-xp /usr/lib/libvconf.so.0.2.45
b6bbb000 b6bbe000 r-xp /usr/lib/libvasum.so.0.3.1
b6bbf000 b6bc2000 r-xp /usr/lib/libttrace.so.1.1
b6bc4000 b6bc8000 r-xp /usr/lib/libiniparser.so.0
b6bc9000 b6bf9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bfa000 b6c03000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c04000 b6c29000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c2a000 b6c3a000 r-xp /usr/lib/libunwind.so.8.0.1
b6c44000 b6df2000 r-xp /lib/libc-2.20-2014.11.so
b6dfa000 b6f3d000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f3f000 b6f97000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f98000 b6fcc000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fcf000 b70a3000 r-xp /usr/lib/libedje.so.1.13.0
b70a6000 b70d2000 r-xp /usr/lib/libecore.so.1.13.0
b70e3000 b7309000 r-xp /usr/lib/libevas.so.1.13.0
b7331000 b7349000 r-xp /lib/libpthread-2.20-2014.11.so
b734d000 b76c7000 r-xp /usr/lib/libelementary.so.1.13.0
b76e7000 b76eb000 r-xp /usr/lib/libsmack.so.1.0.0
b76ec000 b76f5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76f6000 b76f9000 r-xp /usr/lib/libdlog.so.0.0.0
b76fa000 b76ff000 r-xp /usr/lib/libbundle.so.0.1.22
b7700000 b7703000 r-xp /lib/libdl-2.20-2014.11.so
b7705000 b772a000 r-xp /usr/lib/libaul.so.0.1.0
b772d000 b772f000 r-xp /usr/lib/libappsvc.so.0.1.0
b7730000 b7735000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7736000 b773d000 r-xp /usr/lib/libappcore-efl.so.1.1
b773f000 b7744000 r-xp /usr/lib/libsys-assert.so
b7747000 b7748000 r-xp [vdso]
b7748000 b776a000 r-xp /lib/ld-2.20-2014.11.so
b776c000 b7774000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:9380)
Call Stack Count: 45
 0: (0xb7162bbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb7154ce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb714f629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb715cfa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb7560d29) [/usr/lib/libelementary.so.1] + 0x213d29
 5: elm_obj_layout_sizing_eval + 0x99 (0xb74f8559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb74ff205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb716d809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb74f179a) [/usr/lib/libelementary.so.1] + 0x1a479a
 9: evas_obj_smart_add + 0x99 (0xb716d809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb756527b) [/usr/lib/libelementary.so.1] + 0x21827b
11: evas_obj_smart_add + 0x99 (0xb716d809) [/usr/lib/libevas.so.1] + 0x8a809
12: (0xb7170d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
13: eo_constructor + 0x99 (0xb639f899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb75be4a6) [/usr/lib/libelementary.so.1] + 0x2714a6
15: eo_constructor + 0x99 (0xb639f899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb7500c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
17: eo_constructor + 0x99 (0xb639f899) [/usr/lib/libeo.so.1] + 0xa899
18: (0xb74f1879) [/usr/lib/libelementary.so.1] + 0x1a4879
19: eo_constructor + 0x99 (0xb639f899) [/usr/lib/libeo.so.1] + 0xa899
20: (0xb75657c2) [/usr/lib/libelementary.so.1] + 0x2187c2
21: eo_constructor + 0x99 (0xb639f899) [/usr/lib/libeo.so.1] + 0xa899
22: elm_scroller_add + 0x77 (0xb7563db7) [/usr/lib/libelementary.so.1] + 0x216db7
23: roomlist_cb + 0x5c (0xb37ab0ec) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x70ec
24: roomlist_button_cb + 0x47 (0xb37af3e7) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb3e7
25: (0xb716c116) [/usr/lib/libevas.so.1] + 0x89116
26: (0xb63a3319) [/usr/lib/libeo.so.1] + 0xe319
27: eo_event_callback_call + 0xb3 (0xb63a0d63) [/usr/lib/libeo.so.1] + 0xbd63
28: evas_object_smart_callback_call + 0x75 (0xb716e9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
29: (0xb741f404) [/usr/lib/libelementary.so.1] + 0xd2404
30: (0xb7052f39) [/usr/lib/libedje.so.1] + 0x83f39
31: (0xb7059a11) [/usr/lib/libedje.so.1] + 0x8aa11
32: (0xb7053fdc) [/usr/lib/libedje.so.1] + 0x84fdc
33: (0xb70544cb) [/usr/lib/libedje.so.1] + 0x854cb
34: (0xb705468f) [/usr/lib/libedje.so.1] + 0x8568f
35: (0xb70b9702) [/usr/lib/libecore.so.1] + 0x13702
36: (0xb70b3055) [/usr/lib/libecore.so.1] + 0xd055
37: (0xb70bc1b9) [/usr/lib/libecore.so.1] + 0x161b9
38: ecore_main_loop_begin + 0x57 (0xb70bc587) [/usr/lib/libecore.so.1] + 0x16587
39: elm_run + 0x2d (0xb751522d) [/usr/lib/libelementary.so.1] + 0x1c822d
40: appcore_efl_main + 0x4de (0xb7739dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
41: ui_app_main + 0x140 (0xb7732c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
42: main + 0x278 (0xb37ad618) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x9618
43: cJSON_Delete + 0xa8 (0xb776e148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb776e148
44: __libc_start_main + 0xde (0xb6c5be4e) [/lib/libc.so.6] + 0x17e4e
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
es/tichat.png] enable[1] system[0]
10-17 06:10:25.710+0900 D/cluster-home( 2853): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [tichat]
10-17 06:10:25.710+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
10-17 06:10:25.710+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
10-17 06:10:25.710+0900 D/test-log( 2853): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png], New icon path[/opt/usr/apps/org.example.tichat/shared/res/tichat.png]!!!!!
10-17 06:10:25.710+0900 D/cluster-home( 2853): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 16]
10-17 06:10:25.720+0900 W/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
10-17 06:10:25.840+0900 D/rpm-installer( 9508): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
10-17 06:10:25.840+0900 D/rpm-installer( 9508): rpm-appcore-intf.c: main(259) > ------------------------------------------------
10-17 06:10:25.840+0900 D/rpm-installer( 9508): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
10-17 06:10:25.840+0900 D/rpm-installer( 9508): rpm-appcore-intf.c: main(261) > ------------------------------------------------
10-17 06:10:25.840+0900 D/PKGMGR_SERVER( 9505): pkgmgr-server.c: sighandler(387) > child exit [9508]
10-17 06:10:25.840+0900 E/PKGMGR_SERVER( 9505): pkgmgr-server.c: sighandler(402) > child NORMAL exit [9508]
10-17 06:10:27.370+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 0
10-17 06:10:27.370+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.tichat
10-17 06:10:27.370+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-17 06:10:27.370+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
10-17 06:10:27.380+0900 I/AUL     ( 2719): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
10-17 06:10:27.380+0900 D/AUL     ( 2719): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 9558, pid = 9560
10-17 06:10:27.380+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-17 06:10:27.380+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
10-17 06:10:27.380+0900 I/AUL     ( 2719): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
10-17 06:10:27.380+0900 E/AUL_AMD ( 2719): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
10-17 06:10:27.380+0900 W/AUL_AMD ( 2719): amd_launch.c: _start_app(2233) > caller pid : 9560
10-17 06:10:27.380+0900 E/AUL_AMD ( 2719): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
10-17 06:10:27.380+0900 W/AUL_AMD ( 2719): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
10-17 06:10:27.380+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2648) > process_pool: false
10-17 06:10:27.380+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-17 06:10:27.380+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
10-17 06:10:27.380+0900 W/AUL_AMD ( 2719): amd_launch.c: _start_app(2665) > pad pid(-5)
10-17 06:10:27.380+0900 D/AUL_AMD ( 2719): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-17 06:10:27.380+0900 D/AUL_AMD ( 2719): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-17 06:10:27.380+0900 D/AUL     ( 2719): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-17 06:10:27.380+0900 W/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-17 06:10:27.380+0900 D/AUL     ( 2903): process_pool.c: __send_pkt_raw_data(219) > send(12) : 616 / 616
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 9380, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-17 06:10:27.380+0900 W/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(265) > Check app launching
10-17 06:10:27.380+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-17 06:10:27.380+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
10-17 06:10:27.380+0900 D/RESOURCED( 2835): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
10-17 06:10:27.380+0900 E/RESOURCED( 2835): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-17 06:10:27.380+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-17 06:10:27.380+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-17 06:10:27.380+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-17 06:10:27.380+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-17 06:10:27.380+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-17 06:10:27.380+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-17 06:10:27.380+0900 D/AUL     ( 9380): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (9382) is sent.
10-17 06:10:27.380+0900 D/AUL     ( 9380): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 9382, signo: 10
10-17 06:10:27.390+0900 D/AUL     ( 9380): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzY2NTIyMjcvMzcwMDAwAA==##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA5NTYwAA==##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-17 06:10:27.390+0900 D/AUL_PAD ( 9380): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-17 06:10:27.390+0900 I/CAPI_APPFW_APPLICATION( 9380): app_main.c: ui_app_main(788) > app_efl_main
10-17 06:10:27.390+0900 D/LAUNCH  ( 9380): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-17 06:10:27.390+0900 D/APP_CORE( 9380): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-17 06:10:27.390+0900 D/APP_CORE( 9380): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-17 06:10:27.390+0900 D/APP_CORE( 9380): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-17 06:10:27.400+0900 D/APP_CORE( 9380): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-17 06:10:27.400+0900 D/AUL     ( 9380): app_sock.c: __create_server_sock(156) > pg path - already exists
10-17 06:10:27.400+0900 D/APP_CORE( 9380): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4292520
10-17 06:10:27.400+0900 D/LAUNCH  ( 9380): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-17 06:10:27.400+0900 I/CAPI_APPFW_APPLICATION( 9380): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-17 06:10:27.420+0900 E/EFL     ( 9380): elementary<9380> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-17 06:10:27.430+0900 D/IMMODULE( 9380): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-17 06:10:27.430+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 06:10:27.430+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(524) > connect() succeeded
10-17 06:10:27.430+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 06:10:27.430+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(524) > connect() succeeded
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(524) > connect() succeeded
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_QUERY( 9380): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(524) > connect() succeeded
10-17 06:10:27.440+0900 D/IMMODULE( 9380): scim_panel_client.cpp: open_connection(162) > 
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(524) > connect() succeeded
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 06:10:27.440+0900 D/ISF_SOCKET( 9380): scim_socket.cpp: connect(524) > connect() succeeded
10-17 06:10:27.440+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-17 06:10:27.490+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-17 06:10:27.490+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 9380, appid: org.example.tichat
10-17 06:10:27.490+0900 D/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-17 06:10:27.490+0900 E/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(330) > access
10-17 06:10:27.490+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2700) > add app group info
10-17 06:10:27.490+0900 E/AUL     ( 2719): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-17 06:10:27.490+0900 D/AUL_AMD ( 2719): amd_status.c: _status_add_app_info_list(427) > pid(9380) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-17 06:10:27.490+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 9380
10-17 06:10:27.490+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-17 06:10:27.490+0900 E/RESOURCED( 2835): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-17 06:10:27.490+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(888) > available memory = 689
10-17 06:10:27.500+0900 D/LAUNCH  ( 9380): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-17 06:10:27.500+0900 E/E17     ( 2797): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03400002)
10-17 06:10:27.500+0900 E/E17     ( 2797): e_border.c: e_border_show(2088) > BD_SHOW(0x03400002)
10-17 06:10:27.510+0900 D/APP_CORE( 9380): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-17 06:10:27.520+0900 W/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9380
10-17 06:10:27.520+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 06:10:27.520+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 06:10:27.520+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-17 06:10:27.520+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-17 06:10:27.520+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-17 06:10:27.520+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-17 06:10:27.520+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-17 06:10:27.520+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-17 06:10:27.520+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 15
10-17 06:10:27.520+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 06:10:27.520+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 06:10:27.530+0900 D/AUL_AMD ( 2719): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 9380 is org.example.tichat
10-17 06:10:27.530+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 9380 : 0
10-17 06:10:27.530+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-17 06:10:27.530+0900 D/APP_CORE( 9380): appcore.c: __aul_handler(587) > [APP 9380]     AUL event: AUL_START
10-17 06:10:27.530+0900 I/APP_CORE( 9380): appcore-efl.c: __do_app(496) > [APP 9380] Event: RESET State: CREATED
10-17 06:10:27.530+0900 D/APP_CORE( 9380): appcore-efl.c: __do_app(527) > [APP 9380] RESET
10-17 06:10:27.530+0900 D/LAUNCH  ( 9380): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-17 06:10:27.530+0900 D/APP_CORE( 9380): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-17 06:10:27.530+0900 D/APP_CORE( 9380): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 06:10:27.530+0900 I/CAPI_APPFW_APPLICATION( 9380): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-17 06:10:27.530+0900 D/AUL     ( 9380): service.c: __set_bundle(186) > __set_bundle
10-17 06:10:27.530+0900 D/LAUNCH  ( 9380): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-17 06:10:27.530+0900 D/APP_CORE( 9380): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-17 06:10:27.530+0900 E/EFL     ( 9380): edje<9380> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 06:10:27.530+0900 E/EFL     ( 9380): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 06:10:27.530+0900 E/EFL     ( 9380): edje<9380> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 06:10:27.530+0900 E/EFL     ( 9380): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 06:10:27.530+0900 E/EFL     ( 9380): edje<9380> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 06:10:27.530+0900 E/EFL     ( 9380): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 06:10:27.530+0900 E/EFL     ( 9380): edje<9380> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 06:10:27.530+0900 E/EFL     ( 9380): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 06:10:27.530+0900 E/EFL     ( 9380): edje<9380> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 06:10:27.530+0900 E/EFL     ( 9380): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 06:10:27.540+0900 W/APP_CORE( 9380): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
10-17 06:10:27.540+0900 D/APP_CORE( 9380): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:3400002
10-17 06:10:27.540+0900 D/APP_CORE( 9380): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-17 06:10:27.540+0900 D/AUL     ( 9380): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-17 06:10:27.540+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 34
10-17 06:10:27.560+0900 D/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(442) > pid(9191)
10-17 06:10:27.560+0900 W/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-17 06:10:27.560+0900 D/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(442) > pid(9191)
10-17 06:10:27.560+0900 W/AUL_AMD ( 2719): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-17 06:10:27.640+0900 D/APP_CORE( 9380): appcore.c: __prt_ltime(236) > [APP 9380] first idle after reset: 270 msec
10-17 06:10:27.750+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-17 06:10:27.750+0900 D/APP_CORE( 9380): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:3400002 fully_obscured 0
10-17 06:10:27.750+0900 D/APP_CORE( 9380): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-17 06:10:27.750+0900 D/APP_CORE( 9380): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 06:10:27.750+0900 I/APP_CORE( 9380): appcore-efl.c: __do_app(496) > [APP 9380] Event: RESUME State: CREATED
10-17 06:10:27.750+0900 D/LAUNCH  ( 9380): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-17 06:10:27.750+0900 D/APP_CORE( 9380): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 06:10:27.750+0900 D/APP_CORE( 9380): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 06:10:27.750+0900 D/APP_CORE( 9380): appcore-efl.c: __do_app(607) > [APP 9380] RESUME
10-17 06:10:27.760+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-17 06:10:27.760+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-17 06:10:27.760+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-17 06:10:27.760+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: PAUSE State: RUNNING
10-17 06:10:27.760+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(565) > [APP 2853] PAUSE
10-17 06:10:27.760+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-17 06:10:27.760+0900 E/cluster-home( 2853): homescreen.cpp: OnPause(84) >  app pause
10-17 06:10:27.760+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-17 06:10:27.760+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(923) >  END
10-17 06:10:27.760+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 06:10:27.760+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 06:10:27.760+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(4)
10-17 06:10:27.760+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-17 06:10:27.760+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-17 06:10:27.760+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: bg
10-17 06:10:27.760+0900 I/APP_CORE( 9380): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-17 06:10:27.760+0900 I/APP_CORE( 9380): appcore-efl.c: __do_app(614) > [APP 9380] Initial Launching, call the resume_cb
10-17 06:10:27.760+0900 I/CAPI_APPFW_APPLICATION( 9380): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 06:10:27.760+0900 D/LAUNCH  ( 9380): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-17 06:10:27.760+0900 D/LAUNCH  ( 9380): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-17 06:10:27.760+0900 D/APP_CORE( 9380): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 06:10:27.760+0900 E/APP_CORE( 9380): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 06:10:27.760+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(9380) status(3)
10-17 06:10:27.760+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 06:10:27.760+0900 W/AUL_AMD ( 2719): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-17 06:10:27.760+0900 W/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-17 06:10:27.760+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(9380) status(3)
10-17 06:10:27.760+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(9380) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-17 06:10:27.760+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-17 06:10:27.760+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 9380, appid: org.example.tichat, status: fg
10-17 06:10:27.760+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 9380
10-17 06:10:27.760+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 9380, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-17 06:10:27.760+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 9380
10-17 06:10:27.780+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2853 is paused
10-17 06:10:27.780+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-17 06:10:27.790+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-17 06:10:27.790+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-17 06:10:27.790+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: bg
10-17 06:10:27.800+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 9380, appname = org.example.tichat, pkgname = org.example.tichat
10-17 06:10:27.800+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 9380, appname = org.example.tichat
10-17 06:10:27.800+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 9380
10-17 06:10:27.800+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-17 06:10:27.800+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2998
10-17 06:10:27.800+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2998, appname = org.tizen.calendar.widget
10-17 06:10:27.800+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2998
10-17 06:10:27.800+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 06:10:27.800+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 06:10:27.850+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2910) > pid(9380) status(0)
10-17 06:10:28.010+0900 E/PKGMGR_SERVER( 9505): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-17 06:10:28.010+0900 E/PKGMGR_SERVER( 9505): pkgmgr-server.c: main(2265) > package manager server terminated.
10-17 06:10:28.500+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-17 06:10:28.500+0900 D/AUL_PAD ( 9568): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-17 06:10:28.500+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-17 06:10:28.510+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.787
10-17 06:10:29.000+0900 D/AUL_AMD ( 2719): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-17 06:10:29.000+0900 D/RUA     ( 2719): rua.c: rua_add_history(179) > rua_add_history start
10-17 06:10:29.000+0900 D/RUA     ( 2719): rua.c: rua_add_history(247) > rua_add_history ok
10-17 06:10:29.530+0900 D/AUL_PAD ( 9568): launchpad_loader.c: main(588) > sleeping 1 sec...
10-17 06:10:29.530+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-17 06:10:29.530+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b83da760
10-17 06:10:29.530+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(69) > get pre-initialization function
10-17 06:10:29.530+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(73) > get shutdown function
10-17 06:10:29.530+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b83daa40
10-17 06:10:29.540+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b83dc640
10-17 06:10:29.540+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(69) > get pre-initialization function
10-17 06:10:29.540+0900 D/AUL_PAD ( 9568): preload.h: __preload_init(73) > get shutdown function
10-17 06:10:29.540+0900 D/AUL_PAD ( 9568): preexec.h: __preexec_init(76) > preexec start
10-17 06:10:29.540+0900 D/AUL_PAD ( 9568): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-17 06:10:29.540+0900 D/AUL     ( 9568): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-17 06:10:29.540+0900 D/AUL     ( 9568): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-17 06:10:29.540+0900 D/AUL     ( 9568): process_pool.c: __connect_to_launchpad(132) > send(9568) : 4
10-17 06:10:29.540+0900 D/AUL     ( 9568): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-17 06:10:29.540+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 9568
10-17 06:10:29.600+0900 D/AUL_PAD ( 9568): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-17 06:10:29.600+0900 D/AUL_PAD ( 9568): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-17 06:10:29.600+0900 D/AUL_PAD ( 9568): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-17 06:10:29.600+0900 D/AUL_PAD ( 9568): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-17 06:10:32.770+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-17 06:10:32.770+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: MEM_FLUSH State: PAUSED
10-17 06:10:32.770+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-17 06:10:32.770+0900 D/APP_CORE( 2853): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2853
10-17 06:10:32.770+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-17 06:10:32.770+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2853
10-17 06:10:35.620+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603932 
10-17 06:10:35.620+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7af8008. set autocapital type : 2
10-17 06:10:35.620+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 06:10:35.620+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 24a4002a , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 06:10:35.620+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7af8008. on demand : 0
10-17 06:10:35.620+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 06:10:35.620+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 0
10-17 06:10:35.620+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7af8008
10-17 06:10:35.620+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 06:10:36.200+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 1
10-17 06:10:36.200+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7af8008, bidi direction : 0x1
10-17 06:10:36.440+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 2
10-17 06:10:36.560+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 3
10-17 06:10:36.640+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x3400002
10-17 06:10:36.860+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 4
10-17 06:10:37.070+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 5
10-17 06:10:37.110+0900 D/RESOURCED( 2835): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-17 06:10:37.110+0900 I/RESOURCED( 2835): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-17 06:10:37.110+0900 D/RESOURCED( 2835): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-17 06:10:37.110+0900 I/RESOURCED( 2835): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-17 06:10:37.230+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 6
10-17 06:10:37.290+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 7
10-17 06:10:37.440+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7af8008
10-17 06:10:37.440+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 06:10:37.440+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7af8008
10-17 06:10:37.440+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 06:10:37.440+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7b63748. set autocapital type : 0
10-17 06:10:37.440+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7b63748. on demand : 0
10-17 06:10:37.440+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 06:10:37.440+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 24a5002a , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 06:10:37.440+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 06:10:37.450+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 0
10-17 06:10:37.650+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 1
10-17 06:10:37.650+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7b63748, bidi direction : 0x1
10-17 06:10:37.740+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 2
10-17 06:10:37.900+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 3
10-17 06:10:37.960+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 4
10-17 06:10:37.990+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 5
10-17 06:10:38.140+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 6
10-17 06:10:38.290+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 7
10-17 06:10:38.350+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 8
10-17 06:10:38.500+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7b63748, cursor pos : 9
10-17 06:10:39.660+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603932 
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7b63748
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7b63748
10-17 06:10:39.660+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7af8008. set autocapital type : 2
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7af8008. on demand : 0
10-17 06:10:39.660+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 06:10:39.660+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 24a4002a , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 7
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7af8008
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 06:10:39.660+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 2
10-17 06:10:40.050+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 1
10-17 06:10:40.200+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 0
10-17 06:10:40.410+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 1
10-17 06:10:40.720+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 0
10-17 06:10:40.900+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 1
10-17 06:10:40.990+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 2
10-17 06:10:41.080+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7af8008, cursor pos : 3
10-17 06:10:41.650+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x603932 bd->visible=1
10-17 06:10:42.480+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7af8008
10-17 06:10:42.480+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 06:10:42.480+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7af8008
10-17 06:10:42.480+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 06:10:42.490+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603932 
10-17 06:10:42.530+0900 I/CAPI_NETWORK_CONNECTION( 9380): connection.c: connection_create(408) > New handle created[0xb7bc2cd0]
10-17 06:10:42.530+0900 I/CAPI_NETWORK_CONNECTION( 9380): connection.c: connection_get_type(464) > Connected Network = 3
10-17 06:10:42.530+0900 I/tichat  ( 9380): Network connection type : 3
10-17 06:10:43.640+0900 I/tichat  ( 9380): CURL Returned: 
10-17 06:10:43.640+0900 I/tichat  ( 9380): {"message":"로그인 성공"}
10-17 06:10:43.640+0900 I/tichat  ( 9380): Parsed JSON: "로그인 성공"
10-17 06:10:43.660+0900 I/CAPI_NETWORK_CONNECTION( 9380): connection.c: connection_destroy(426) > Destroy handle: 0xb7bc2cd0
10-17 06:10:43.660+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 06:10:43.660+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 43 36
10-17 06:10:44.370+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603932 
10-17 06:10:44.530+0900 D/IMMODULE( 9380): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb7af8008
10-17 06:10:44.530+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
10-17 06:10:44.530+0900 D/IMMODULE( 9380): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
10-17 06:10:44.540+0900 E/EFL     ( 9380): <9380> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
10-17 06:10:44.580+0900 W/CRASH_MANAGER( 9571): worker.c: worker_job(1204) > 1109380746963147665224
