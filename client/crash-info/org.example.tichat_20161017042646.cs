S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 6118
Date: 2016-10-17 04:26:46+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb853d690, esi = 0xb37d8bde
ebp = 0xbfecef48, esp = 0xbfecef20
eax = 0xb37da15c, ebx = 0xb37da15c
ecx = 0x00000000, edx = 0x00000000
eip = 0xb37d0b12

Memory Information
MemTotal:      250 KB
MemFree:       149 KB
Buffers:         4 KB
Cached:     165600 KB
VmPeak:     117888 KB
VmSize:     112140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31356 KB
VmRSS:       25448 KB
VmData:      43664 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34584 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6118 TID = 6118
6118 6119 6160 6161 6164 

Maps Information
b2afb000 b2b02000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2b03000 b2b1b000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b1c000 b2b23000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2ba0000 b2baa000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bb0000 b2bbc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bbd000 b2bde000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2be3000 b2be4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2be5000 b2bea000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2beb000 b2bec000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bed000 b2bef000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bf0000 b2bfc000 r-xp /usr/lib/libdrm.so.2.4.0
b2bfd000 b2c00000 r-xp /usr/lib/libdri2.so.0.0.0
b2c01000 b2c0b000 r-xp /usr/lib/libtbm.so.1.0.0
b2c0c000 b2c21000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c22000 b2c34000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3436000 b3467000 r-xp /usr/lib/libidn.so.11.5.44
b3468000 b348a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b348b000 b349b000 r-xp /usr/lib/libcares.so.2.1.0
b349c000 b34bc000 r-xp /usr/lib/libnetwork.so.0.0.0
b34bd000 b34c6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34c7000 b353e000 r-xp /usr/lib/libcurl.so.4.3.0
b3540000 b3554000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b355b000 b355c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b355d000 b355e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b355f000 b3562000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3563000 b3566000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b366e000 b3674000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3675000 b37b9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37c9000 b37cb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37cc000 b37cd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ce000 b37da000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37db000 b3814000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4217000 b4222000 r-xp /lib/libnss_files-2.20-2014.11.so
b4224000 b422f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4231000 b4248000 r-xp /lib/libnsl-2.20-2014.11.so
b424c000 b4254000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4256000 b427a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b427b000 b427c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b427d000 b4280000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4281000 b4288000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4289000 b4293000 r-xp /usr/lib/libsensord-share.so
b4294000 b42b0000 r-xp /usr/lib/libsensor.so.1.2.0
b42b2000 b42bb000 r-xp /usr/lib/libappcore-common.so.1.1
b42be000 b42c0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d5000 b42d7000 r-xp /usr/lib/libXau.so.6.0.0
b42d8000 b42fa000 r-xp /usr/lib/libxcb.so.1.1.0
b42fc000 b4305000 r-xp /lib/libcrypt-2.20-2014.11.so
b432e000 b4330000 r-xp /usr/lib/libiri.so
b4331000 b4357000 r-xp /lib/libexpat.so.1.5.2
b4359000 b43c4000 r-xp /usr/lib/libssl.so.1.0.0
b43ca000 b43d6000 r-xp /usr/lib/libethumb.so.1.13.0
b43d7000 b43db000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43dc000 b462d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ba8000 b5bb8000 r-xp /usr/lib/libXi.so.6.1.0
b5bb9000 b5bbb000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bbc000 b5bc2000 r-xp /usr/lib/libXtst.so.6.1.0
b5bc3000 b5bcd000 r-xp /usr/lib/libXrender.so.1.3.0
b5bce000 b5bd7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bd9000 b5bdb000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bdc000 b5be1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be2000 b5bf4000 r-xp /usr/lib/libXext.so.6.4.0
b5bf5000 b5bf7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bf8000 b5bfa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bfc000 b5d3e000 r-xp /usr/lib/libX11.so.6.3.0
b5d42000 b5d4c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d4d000 b5d63000 r-xp /usr/lib/libudev.so.1.6.0
b5d66000 b5d6a000 r-xp /lib/libattr.so.1.1.0
b5d6b000 b5d9a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d9c000 b5da2000 r-xp /usr/lib/libffi.so.6.0.2
b5da3000 b5dc6000 r-xp /lib/libz.so.1.2.8
b5dc7000 b5dca000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dcb000 b5f27000 r-xp /usr/lib/libxml2.so.2.9.2
b5f2d000 b6014000 r-xp /usr/lib/libstdc++.so.6.0.20
b6021000 b6024000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6025000 b6047000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6048000 b605c000 r-xp /lib/libresolv-2.20-2014.11.so
b6060000 b6084000 r-xp /usr/lib/liblzma.so.5.0.3
b6085000 b6087000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6089000 b6093000 r-xp /usr/lib/libembryo.so.1.13.0
b6094000 b60bd000 r-xp /usr/lib/libpng12.so.0.50.0
b60be000 b6107000 r-xp /usr/lib/libjpeg.so.8.0.2
b6118000 b611f000 r-xp /lib/librt-2.20-2014.11.so
b6121000 b6140000 r-xp /usr/lib/libector.so.1.13.0
b6143000 b6170000 r-xp /usr/lib/liblua-5.1.so
b6171000 b6201000 r-xp /usr/lib/libfreetype.so.6.11.3
b6205000 b6243000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6244000 b625a000 r-xp /usr/lib/libfribidi.so.0.3.1
b625b000 b62b4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62b7000 b6302000 r-xp /lib/libm-2.20-2014.11.so
b6304000 b6316000 r-xp /usr/lib/libeio.so.1.13.0
b6317000 b631a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b631b000 b6321000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6322000 b6345000 r-xp /usr/lib/libefreet.so.1.13.0
b6348000 b6373000 r-xp /usr/lib/libeldbus.so.1.13.0
b6374000 b63a8000 r-xp /usr/lib/libecore_con.so.1.13.0
b63aa000 b63b3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b4000 b63bd000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63be000 b63d1000 r-xp /usr/lib/libeo.so.1.13.0
b63d3000 b63e6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63e7000 b63ee000 r-xp /usr/lib/libecore_file.so.1.13.0
b63ef000 b6412000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6413000 b643f000 r-xp /usr/lib/libeet.so.1.13.0
b6448000 b64b3000 r-xp /usr/lib/libeina.so.1.13.0
b64b6000 b64cd000 r-xp /usr/lib/libefl.so.1.13.0
b64cf000 b6636000 r-xp /usr/lib/libicuuc.so.51.1
b6644000 b6850000 r-xp /usr/lib/libicui18n.so.51.1
b6858000 b68a7000 r-xp /usr/lib/libecore_x.so.1.13.0
b68a9000 b68c3000 r-xp /lib/libgcc_s-4.9.so.1
b68c5000 b68c9000 r-xp /lib/libcap.so.2.21
b68ca000 b6910000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6911000 b6918000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b691a000 b696c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b696e000 b6af9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6afe000 b6bcc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bcf000 b6bd3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd4000 b6be3000 r-xp /usr/lib/libvconf.so.0.2.45
b6be4000 b6be7000 r-xp /usr/lib/libvasum.so.0.3.1
b6be8000 b6beb000 r-xp /usr/lib/libttrace.so.1.1
b6bed000 b6bf1000 r-xp /usr/lib/libiniparser.so.0
b6bf2000 b6c22000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c23000 b6c2c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c2d000 b6c52000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c53000 b6c63000 r-xp /usr/lib/libunwind.so.8.0.1
b6c6d000 b6e1b000 r-xp /lib/libc-2.20-2014.11.so
b6e23000 b6f66000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f68000 b6fc0000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc1000 b6ff5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ff8000 b70cc000 r-xp /usr/lib/libedje.so.1.13.0
b70cf000 b70fb000 r-xp /usr/lib/libecore.so.1.13.0
b710c000 b7332000 r-xp /usr/lib/libevas.so.1.13.0
b735a000 b7372000 r-xp /lib/libpthread-2.20-2014.11.so
b7376000 b76f0000 r-xp /usr/lib/libelementary.so.1.13.0
b7710000 b7714000 r-xp /usr/lib/libsmack.so.1.0.0
b7715000 b771e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b771f000 b7722000 r-xp /usr/lib/libdlog.so.0.0.0
b7723000 b7728000 r-xp /usr/lib/libbundle.so.0.1.22
b7729000 b772c000 r-xp /lib/libdl-2.20-2014.11.so
b772e000 b7753000 r-xp /usr/lib/libaul.so.0.1.0
b7756000 b7758000 r-xp /usr/lib/libappsvc.so.0.1.0
b7759000 b775e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b775f000 b7766000 r-xp /usr/lib/libappcore-efl.so.1.1
b7768000 b776d000 r-xp /usr/lib/libsys-assert.so
b7770000 b7771000 r-xp [vdso]
b7771000 b7793000 r-xp /lib/ld-2.20-2014.11.so
b7795000 b779d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6118)
Call Stack Count: 22
 0: cJSON_GetObjectItem + 0x22 (0xb37d0b12) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2b12
 1: signup_signup_button_clicked_cb + 0x481 (0xb37d6361) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8361
 2: (0xb7195116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb63cc319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb63c9d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb71979e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb7448404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb707bf39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb7082a11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb707cfdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb707d4cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb707d68f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb70e2702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb70dc055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70e51b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb70e5587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb753e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb7762dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb775bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x278 (0xb37d6fd8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8fd8
20: cJSON_ParseWithOpts + 0x38 (0xb7797148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7797148
21: __libc_start_main + 0xde (0xb6c84e4e) [/lib/libc.so.6] + 0x17e4e
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
 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OAAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AEwAAAG9yZy5leGFtcGxlLnRpY2hhdAA=##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzY2NDU5ODcvNDYwMDAwAA==##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODUzAA==##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 14
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-17 04:26:27.470+0900 D/AUL_PAD ( 6118): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-17 04:26:27.470+0900 I/CAPI_APPFW_APPLICATION( 6118): app_main.c: ui_app_main(788) > app_efl_main
10-17 04:26:27.470+0900 D/LAUNCH  ( 6118): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-17 04:26:27.470+0900 D/APP_CORE( 6118): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-17 04:26:27.470+0900 D/APP_CORE( 6118): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-17 04:26:27.470+0900 D/APP_CORE( 6118): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-17 04:26:27.470+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60004c 
10-17 04:26:27.470+0900 D/APP_CORE( 6118): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-17 04:26:27.470+0900 D/AUL     ( 6118): app_sock.c: __create_server_sock(156) > pg path - already exists
10-17 04:26:27.470+0900 D/APP_CORE( 6118): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42bb520
10-17 04:26:27.470+0900 D/LAUNCH  ( 6118): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-17 04:26:27.470+0900 I/CAPI_APPFW_APPLICATION( 6118): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-17 04:26:27.530+0900 E/EFL     ( 6118): elementary<6118> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-17 04:26:27.540+0900 D/IMMODULE( 6118): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-17 04:26:27.540+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 04:26:27.540+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(524) > connect() succeeded
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(524) > connect() succeeded
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(524) > connect() succeeded
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_QUERY( 6118): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(524) > connect() succeeded
10-17 04:26:27.550+0900 D/IMMODULE( 6118): scim_panel_client.cpp: open_connection(162) > 
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 04:26:27.550+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(524) > connect() succeeded
10-17 04:26:27.560+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 04:26:27.560+0900 D/ISF_SOCKET( 6118): scim_socket.cpp: connect(524) > connect() succeeded
10-17 04:26:27.560+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-17 04:26:27.570+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-17 04:26:27.570+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6118, appid: org.example.tichat
10-17 04:26:27.570+0900 D/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-17 04:26:27.570+0900 E/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(330) > access
10-17 04:26:27.570+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2700) > add app group info
10-17 04:26:27.570+0900 E/AUL     ( 2719): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-17 04:26:27.570+0900 D/AUL_AMD ( 2719): amd_status.c: _status_add_app_info_list(427) > pid(6118) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-17 04:26:27.570+0900 D/AUL     ( 2853): launch.c: app_request_to_launchpad(425) > launch request result : 6118
10-17 04:26:27.570+0900 E/cluster-home( 2853): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.tichat]
10-17 04:26:27.570+0900 D/test-log( 2853): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
10-17 04:26:27.570+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 6118
10-17 04:26:27.570+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-17 04:26:27.570+0900 E/RESOURCED( 2835): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-17 04:26:27.570+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(888) > available memory = 779
10-17 04:26:27.590+0900 D/LAUNCH  ( 6118): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-17 04:26:27.630+0900 D/APP_CORE( 6118): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-17 04:26:27.640+0900 D/APP_CORE( 6118): appcore.c: __aul_handler(587) > [APP 6118]     AUL event: AUL_START
10-17 04:26:27.640+0900 I/APP_CORE( 6118): appcore-efl.c: __do_app(496) > [APP 6118] Event: RESET State: CREATED
10-17 04:26:27.640+0900 D/APP_CORE( 6118): appcore-efl.c: __do_app(527) > [APP 6118] RESET
10-17 04:26:27.640+0900 D/LAUNCH  ( 6118): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-17 04:26:27.640+0900 D/APP_CORE( 6118): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-17 04:26:27.640+0900 D/APP_CORE( 6118): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 04:26:27.640+0900 I/CAPI_APPFW_APPLICATION( 6118): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-17 04:26:27.640+0900 D/LAUNCH  ( 6118): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-17 04:26:27.640+0900 D/APP_CORE( 6118): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
10-17 04:26:27.640+0900 E/EFL     ( 6118): edje<6118> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 04:26:27.640+0900 E/EFL     ( 6118): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:26:27.640+0900 E/EFL     ( 6118): edje<6118> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 04:26:27.640+0900 E/EFL     ( 6118): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:26:27.640+0900 E/EFL     ( 6118): edje<6118> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 04:26:27.640+0900 E/EFL     ( 6118): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:26:27.640+0900 E/EFL     ( 6118): edje<6118> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 04:26:27.640+0900 E/EFL     ( 6118): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:26:27.640+0900 E/EFL     ( 6118): edje<6118> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 04:26:27.640+0900 E/EFL     ( 6118): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 04:26:27.650+0900 E/E17     ( 2797): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
10-17 04:26:27.650+0900 E/E17     ( 2797): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
10-17 04:26:27.660+0900 W/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6118
10-17 04:26:27.660+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 04:26:27.660+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 04:26:27.660+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-17 04:26:27.670+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 15
10-17 04:26:27.670+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 04:26:27.670+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 04:26:27.670+0900 D/AUL_AMD ( 2719): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6118 is org.example.tichat
10-17 04:26:27.670+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6118 : 0
10-17 04:26:27.680+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-17 04:26:27.710+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-17 04:26:27.710+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-17 04:26:27.710+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-17 04:26:27.710+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-17 04:26:27.710+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-17 04:26:27.800+0900 D/APP_CORE( 6118): appcore.c: __prt_ltime(236) > [APP 6118] first idle after reset: 340 msec
10-17 04:26:27.800+0900 W/APP_CORE( 6118): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
10-17 04:26:27.800+0900 D/APP_CORE( 6118): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
10-17 04:26:27.800+0900 D/APP_CORE( 6118): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-17 04:26:27.800+0900 D/AUL     ( 6118): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-17 04:26:27.800+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 34
10-17 04:26:28.020+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 04:26:28.020+0900 I/APP_CORE( 6118): appcore-efl.c: __do_app(496) > [APP 6118] Event: RESUME State: CREATED
10-17 04:26:28.020+0900 D/LAUNCH  ( 6118): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __do_app(607) > [APP 6118] RESUME
10-17 04:26:28.020+0900 I/APP_CORE( 6118): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-17 04:26:28.020+0900 I/APP_CORE( 6118): appcore-efl.c: __do_app(614) > [APP 6118] Initial Launching, call the resume_cb
10-17 04:26:28.020+0900 I/CAPI_APPFW_APPLICATION( 6118): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 04:26:28.020+0900 D/LAUNCH  ( 6118): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-17 04:26:28.020+0900 D/LAUNCH  ( 6118): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-17 04:26:28.020+0900 D/APP_CORE( 6118): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 04:26:28.020+0900 E/APP_CORE( 6118): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 04:26:28.020+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-17 04:26:28.020+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-17 04:26:28.020+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-17 04:26:28.020+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: PAUSE State: RUNNING
10-17 04:26:28.020+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(565) > [APP 2853] PAUSE
10-17 04:26:28.020+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-17 04:26:28.020+0900 E/cluster-home( 2853): homescreen.cpp: OnPause(84) >  app pause
10-17 04:26:28.020+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-17 04:26:28.020+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(923) >  END
10-17 04:26:28.020+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 04:26:28.020+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 04:26:28.020+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(4)
10-17 04:26:28.020+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-17 04:26:28.020+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-17 04:26:28.020+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: bg
10-17 04:26:28.030+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2853 is paused
10-17 04:26:28.030+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-17 04:26:28.030+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(6118) status(3)
10-17 04:26:28.030+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 04:26:28.040+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-17 04:26:28.040+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-17 04:26:28.040+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: bg
10-17 04:26:28.040+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-17 04:26:28.040+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2998
10-17 04:26:28.040+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2998, appname = org.tizen.calendar.widget
10-17 04:26:28.040+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2998
10-17 04:26:28.070+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2897) > back key ungrab
10-17 04:26:28.070+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(6118) status(3)
10-17 04:26:28.070+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(6118) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-17 04:26:28.070+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-17 04:26:28.070+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6118, appid: org.example.tichat, status: fg
10-17 04:26:28.070+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6118
10-17 04:26:28.070+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6118, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-17 04:26:28.070+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6118
10-17 04:26:28.100+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6118, appname = org.example.tichat, pkgname = org.example.tichat
10-17 04:26:28.100+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6118, appname = org.example.tichat
10-17 04:26:28.100+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6118
10-17 04:26:28.100+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 04:26:28.100+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 04:26:28.190+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2910) > pid(6118) status(0)
10-17 04:26:28.580+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-17 04:26:28.580+0900 D/AUL_PAD ( 6163): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-17 04:26:28.580+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-17 04:26:28.900+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb85a5668. set autocapital type : 2
10-17 04:26:28.900+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:26:28.900+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 17e60023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:26:28.900+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb85a5668. on demand : 0
10-17 04:26:28.900+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:28.900+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb85a5668, cursor pos : 0
10-17 04:26:28.900+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb85a5668
10-17 04:26:28.900+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:28.910+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:29.080+0900 D/AUL_AMD ( 2719): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-17 04:26:29.080+0900 D/RUA     ( 2719): rua.c: rua_add_history(179) > rua_add_history start
10-17 04:26:29.080+0900 D/RUA     ( 2719): rua.c: rua_add_history(247) > rua_add_history ok
10-17 04:26:29.330+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:29.330+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb85a5668
10-17 04:26:29.330+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:26:29.330+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb85a5668
10-17 04:26:29.330+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:26:29.380+0900 E/EFL     ( 6118): elementary<6118> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8006ed78)
10-17 04:26:29.410+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 04:26:29.410+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-17 04:26:29.410+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-17 04:26:29.410+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-17 04:26:29.410+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:26:29.410+0900 D/SCIM_HELPER( 3017): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:26:29.410+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:26:29.620+0900 D/AUL_PAD ( 6163): launchpad_loader.c: main(588) > sleeping 1 sec...
10-17 04:26:29.620+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-17 04:26:29.620+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7aab760
10-17 04:26:29.620+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(69) > get pre-initialization function
10-17 04:26:29.620+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(73) > get shutdown function
10-17 04:26:29.620+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7aaba40
10-17 04:26:29.630+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7aad640
10-17 04:26:29.630+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(69) > get pre-initialization function
10-17 04:26:29.630+0900 D/AUL_PAD ( 6163): preload.h: __preload_init(73) > get shutdown function
10-17 04:26:29.630+0900 D/AUL_PAD ( 6163): preexec.h: __preexec_init(76) > preexec start
10-17 04:26:29.630+0900 D/AUL_PAD ( 6163): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-17 04:26:29.630+0900 D/AUL     ( 6163): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-17 04:26:29.630+0900 D/AUL     ( 6163): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-17 04:26:29.630+0900 D/AUL     ( 6163): process_pool.c: __connect_to_launchpad(132) > send(6163) : 4
10-17 04:26:29.630+0900 D/AUL     ( 6163): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-17 04:26:29.630+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6163
10-17 04:26:29.740+0900 D/AUL_PAD ( 6163): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-17 04:26:29.750+0900 D/AUL_PAD ( 6163): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-17 04:26:29.750+0900 D/AUL_PAD ( 6163): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-17 04:26:29.750+0900 D/AUL_PAD ( 6163): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-17 04:26:29.810+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:26:29.810+0900 D/ISE_DEFAULT( 3017): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-17 04:26:30.050+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:30.050+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb86601f0. set autocapital type : 2
10-17 04:26:30.050+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb86601f0. on demand : 0
10-17 04:26:30.050+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:26:30.050+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 17e80023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:26:30.050+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:30.050+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 0
10-17 04:26:30.050+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb86601f0
10-17 04:26:30.060+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:30.170+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 1
10-17 04:26:30.170+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb86601f0, bidi direction : 0x1
10-17 04:26:30.210+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 2
10-17 04:26:30.240+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 3
10-17 04:26:30.390+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 4
10-17 04:26:30.480+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 5
10-17 04:26:30.600+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 6
10-17 04:26:30.650+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 7
10-17 04:26:30.850+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86601f0, cursor pos : 8
10-17 04:26:31.060+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
10-17 04:26:31.090+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb86601f0
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb86601f0
10-17 04:26:31.090+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8645428. set autocapital type : 0
10-17 04:26:31.090+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:26:31.090+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 17e90023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8645428. on demand : 0
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 0
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8645428
10-17 04:26:31.090+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:31.180+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 1
10-17 04:26:31.180+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8645428, bidi direction : 0x1
10-17 04:26:31.360+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 2
10-17 04:26:31.520+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 3
10-17 04:26:31.700+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 4
10-17 04:26:31.820+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 5
10-17 04:26:31.920+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8645428, cursor pos : 6
10-17 04:26:32.190+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:32.200+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8645428
10-17 04:26:32.200+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:26:32.200+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8645428
10-17 04:26:32.200+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:26:32.250+0900 I/CAPI_NETWORK_CONNECTION( 6118): connection.c: connection_create(408) > New handle created[0xb85f5740]
10-17 04:26:32.250+0900 I/CAPI_NETWORK_CONNECTION( 6118): connection.c: connection_get_type(464) > Connected Network = 3
10-17 04:26:32.250+0900 I/tichat  ( 6118): Network connection type : 3
10-17 04:26:33.030+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-17 04:26:33.030+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: MEM_FLUSH State: PAUSED
10-17 04:26:33.030+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-17 04:26:33.030+0900 D/APP_CORE( 2853): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2853
10-17 04:26:33.030+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-17 04:26:33.030+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2853
10-17 04:26:33.050+0900 I/tichat  ( 6118): CURL Returned: 
10-17 04:26:33.050+0900 I/tichat  ( 6118): {"message":200}
10-17 04:26:33.050+0900 I/tichat  ( 6118): Parsed JSON: 200
10-17 04:26:33.070+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-17 04:26:33.070+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-17 04:26:33.070+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-17 04:26:33.070+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-17 04:26:33.070+0900 D/ISF_PANEL_EFL( 3003): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:26:33.070+0900 D/SCIM_HELPER( 3017): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-17 04:26:33.070+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:26:33.350+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb8645428
10-17 04:26:33.350+0900 D/ISF_PANEL_EFL( 3003): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
10-17 04:26:33.360+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
10-17 04:26:33.480+0900 D/LIBSCL_UI( 3017): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
10-17 04:26:33.480+0900 D/ISE_DEFAULT( 3017): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-17 04:26:34.310+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:35.110+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:35.180+0900 E/EFL     ( 6118): elementary<6118> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x800ead5a)
10-17 04:26:36.070+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x601c3c bd->visible=1
10-17 04:26:36.110+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:37.110+0900 D/RESOURCED( 2835): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-17 04:26:37.110+0900 I/RESOURCED( 2835): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-17 04:26:37.110+0900 D/RESOURCED( 2835): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-17 04:26:37.110+0900 I/RESOURCED( 2835): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476644711 137 96 2853 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476644716 20 3 4936 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476644754 141 96 2853 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476644760 9 5 5124 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476644866 147 99 2853 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476644871 16 5 5313 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476645148 153 104 2853 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1476645153 14 6 5499 1
10-17 04:26:37.110+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1476645337 158 110 2853 1
10-17 04:26:37.110+0900 I/RESOURCED( 2835): logging.c: logging_save_to_storage(978) > battery cache is empty
10-17 04:26:37.110+0900 I/RESOURCED( 2835): logging.c: logging_save_to_storage(978) > storage cache is empty
10-17 04:26:37.500+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:37.510+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb86ea208. set autocapital type : 2
10-17 04:26:37.510+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:26:37.510+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 17ea0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:26:37.510+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb86ea208. on demand : 0
10-17 04:26:37.510+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:37.510+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 0
10-17 04:26:37.510+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb86ea208
10-17 04:26:37.510+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:37.600+0900 E/CAPI_NETWORK_WIFI( 2840): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-17 04:26:37.600+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-17 04:26:37.600+0900 E/INDICATOR( 2840): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-17 04:26:37.600+0900 E/INDICATOR( 2840): 
10-17 04:26:37.870+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 1
10-17 04:26:38.050+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 2
10-17 04:26:38.110+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 3
10-17 04:26:38.200+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 4
10-17 04:26:38.680+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 5
10-17 04:26:38.870+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 6
10-17 04:26:39.020+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 7
10-17 04:26:39.080+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb86ea208, cursor pos : 8
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb86ea208
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb86ea208
10-17 04:26:39.570+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8662d38. set autocapital type : 0
10-17 04:26:39.570+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 04:26:39.570+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 17eb0023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8662d38. on demand : 0
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 04:26:39.570+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 0
10-17 04:26:39.960+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 1
10-17 04:26:40.020+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 2
10-17 04:26:40.150+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 3
10-17 04:26:40.210+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 4
10-17 04:26:40.270+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 5
10-17 04:26:40.390+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 6
10-17 04:26:40.570+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 7
10-17 04:26:40.610+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 8
10-17 04:26:40.790+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8662d38, cursor pos : 9
10-17 04:26:41.740+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x601c3c 
10-17 04:26:41.760+0900 D/IMMODULE( 6118): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8662d38
10-17 04:26:41.760+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 04:26:41.760+0900 D/IMMODULE( 6118): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8662d38
10-17 04:26:41.760+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 04:26:41.790+0900 E/CAPI_NETWORK_CONNECTION( 6118): connection.c: connection_create(392) > Invalid parameter
10-17 04:26:41.790+0900 I/tichat  ( 6118): Connection Failed!!!!!!!!!!!!
10-17 04:26:41.790+0900 I/CAPI_NETWORK_CONNECTION( 6118): connection.c: connection_get_type(464) > Connected Network = 3
10-17 04:26:41.790+0900 I/tichat  ( 6118): Network connection type : 3
10-17 04:26:46.800+0900 I/tichat  ( 6118): ERROR: Failed to fetch url (http://192.168.0.2:3000/signup) - curl said: Timeout was reached
10-17 04:26:46.800+0900 I/tichat  ( 6118): CURL Returned: 
10-17 04:26:46.800+0900 I/tichat  ( 6118): 
10-17 04:26:46.840+0900 W/CRASH_MANAGER( 6167): worker.c: worker_job(1204) > 1106118746963147664600
