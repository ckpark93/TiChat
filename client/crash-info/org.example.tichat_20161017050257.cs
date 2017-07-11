S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 7592
Date: 2016-10-17 05:02:56+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a65c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8980fd8, esi = 0xbfda2c90
ebp = 0xbfda2c88, esp = 0xbfda2c40
eax = 0xb3825a70, ebx = 0xb3825a70
ecx = 0x8000a654, edx = 0x00000002
eip = 0xb381f0f3

Memory Information
MemTotal:      250 KB
MemFree:       145 KB
Buffers:         4 KB
Cached:     166076 KB
VmPeak:     111732 KB
VmSize:     111732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24932 KB
VmRSS:       24932 KB
VmData:      43252 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34588 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7592 TID = 7592
7592 7593 7817 7818 7823 

Maps Information
b2b45000 b2b4c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2b4d000 b2b65000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b66000 b2b6d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2bea000 b2bf4000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bfa000 b2c06000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c07000 b2c28000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c2d000 b2c2e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c2f000 b2c34000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c35000 b2c37000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c38000 b2c3a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c3b000 b2c47000 r-xp /usr/lib/libdrm.so.2.4.0
b2c48000 b2c4b000 r-xp /usr/lib/libdri2.so.0.0.0
b2c4c000 b2c56000 r-xp /usr/lib/libtbm.so.1.0.0
b2c57000 b2c6c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c6d000 b2c7f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3481000 b34b2000 r-xp /usr/lib/libidn.so.11.5.44
b34b3000 b34d5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34d6000 b34e6000 r-xp /usr/lib/libcares.so.2.1.0
b34e7000 b3507000 r-xp /usr/lib/libnetwork.so.0.0.0
b3508000 b3511000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3512000 b3589000 r-xp /usr/lib/libcurl.so.4.3.0
b358b000 b359f000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b35a6000 b35a7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35a8000 b35a9000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35aa000 b35ad000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35ae000 b35b1000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36b9000 b36bf000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36c0000 b3804000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3814000 b3815000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3816000 b3817000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3818000 b3825000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b3826000 b385f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4262000 b426d000 r-xp /lib/libnss_files-2.20-2014.11.so
b426f000 b427a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b427c000 b4293000 r-xp /lib/libnsl-2.20-2014.11.so
b4297000 b429f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42a1000 b42c5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42c6000 b42c7000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42c8000 b42cb000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42cc000 b42d3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d4000 b42de000 r-xp /usr/lib/libsensord-share.so
b42df000 b42fb000 r-xp /usr/lib/libsensor.so.1.2.0
b42fd000 b4306000 r-xp /usr/lib/libappcore-common.so.1.1
b4309000 b430b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4320000 b4322000 r-xp /usr/lib/libXau.so.6.0.0
b4323000 b4345000 r-xp /usr/lib/libxcb.so.1.1.0
b4347000 b4350000 r-xp /lib/libcrypt-2.20-2014.11.so
b4379000 b437b000 r-xp /usr/lib/libiri.so
b437c000 b43a2000 r-xp /lib/libexpat.so.1.5.2
b43a4000 b440f000 r-xp /usr/lib/libssl.so.1.0.0
b4415000 b4421000 r-xp /usr/lib/libethumb.so.1.13.0
b4422000 b4426000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4427000 b4678000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bf3000 b5c03000 r-xp /usr/lib/libXi.so.6.1.0
b5c04000 b5c06000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c07000 b5c0d000 r-xp /usr/lib/libXtst.so.6.1.0
b5c0e000 b5c18000 r-xp /usr/lib/libXrender.so.1.3.0
b5c19000 b5c22000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c24000 b5c26000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c27000 b5c2c000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c2d000 b5c3f000 r-xp /usr/lib/libXext.so.6.4.0
b5c40000 b5c42000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c43000 b5c45000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c47000 b5d89000 r-xp /usr/lib/libX11.so.6.3.0
b5d8d000 b5d97000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d98000 b5dae000 r-xp /usr/lib/libudev.so.1.6.0
b5db1000 b5db5000 r-xp /lib/libattr.so.1.1.0
b5db6000 b5de5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5de7000 b5ded000 r-xp /usr/lib/libffi.so.6.0.2
b5dee000 b5e11000 r-xp /lib/libz.so.1.2.8
b5e12000 b5e15000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e16000 b5f72000 r-xp /usr/lib/libxml2.so.2.9.2
b5f78000 b605f000 r-xp /usr/lib/libstdc++.so.6.0.20
b606c000 b606f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6070000 b6092000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6093000 b60a7000 r-xp /lib/libresolv-2.20-2014.11.so
b60ab000 b60cf000 r-xp /usr/lib/liblzma.so.5.0.3
b60d0000 b60d2000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60d4000 b60de000 r-xp /usr/lib/libembryo.so.1.13.0
b60df000 b6108000 r-xp /usr/lib/libpng12.so.0.50.0
b6109000 b6152000 r-xp /usr/lib/libjpeg.so.8.0.2
b6163000 b616a000 r-xp /lib/librt-2.20-2014.11.so
b616c000 b618b000 r-xp /usr/lib/libector.so.1.13.0
b618e000 b61bb000 r-xp /usr/lib/liblua-5.1.so
b61bc000 b624c000 r-xp /usr/lib/libfreetype.so.6.11.3
b6250000 b628e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b628f000 b62a5000 r-xp /usr/lib/libfribidi.so.0.3.1
b62a6000 b62ff000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6302000 b634d000 r-xp /lib/libm-2.20-2014.11.so
b634f000 b6361000 r-xp /usr/lib/libeio.so.1.13.0
b6362000 b6365000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6366000 b636c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b636d000 b6390000 r-xp /usr/lib/libefreet.so.1.13.0
b6393000 b63be000 r-xp /usr/lib/libeldbus.so.1.13.0
b63bf000 b63f3000 r-xp /usr/lib/libecore_con.so.1.13.0
b63f5000 b63fe000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63ff000 b6408000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6409000 b641c000 r-xp /usr/lib/libeo.so.1.13.0
b641e000 b6431000 r-xp /usr/lib/libecore_input.so.1.13.0
b6432000 b6439000 r-xp /usr/lib/libecore_file.so.1.13.0
b643a000 b645d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b645e000 b648a000 r-xp /usr/lib/libeet.so.1.13.0
b6493000 b64fe000 r-xp /usr/lib/libeina.so.1.13.0
b6501000 b6518000 r-xp /usr/lib/libefl.so.1.13.0
b651a000 b6681000 r-xp /usr/lib/libicuuc.so.51.1
b668f000 b689b000 r-xp /usr/lib/libicui18n.so.51.1
b68a3000 b68f2000 r-xp /usr/lib/libecore_x.so.1.13.0
b68f4000 b690e000 r-xp /lib/libgcc_s-4.9.so.1
b6910000 b6914000 r-xp /lib/libcap.so.2.21
b6915000 b695b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b695c000 b6963000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6965000 b69b7000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69b9000 b6b44000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b49000 b6c17000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c1a000 b6c1e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c1f000 b6c2e000 r-xp /usr/lib/libvconf.so.0.2.45
b6c2f000 b6c32000 r-xp /usr/lib/libvasum.so.0.3.1
b6c33000 b6c36000 r-xp /usr/lib/libttrace.so.1.1
b6c38000 b6c3c000 r-xp /usr/lib/libiniparser.so.0
b6c3d000 b6c6d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c6e000 b6c77000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c78000 b6c9d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c9e000 b6cae000 r-xp /usr/lib/libunwind.so.8.0.1
b6cb8000 b6e66000 r-xp /lib/libc-2.20-2014.11.so
b6e6e000 b6fb1000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fb3000 b700b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b700c000 b7040000 r-xp /usr/lib/libsystemd.so.0.4.0
b7043000 b7117000 r-xp /usr/lib/libedje.so.1.13.0
b711a000 b7146000 r-xp /usr/lib/libecore.so.1.13.0
b7157000 b737d000 r-xp /usr/lib/libevas.so.1.13.0
b73a5000 b73bd000 r-xp /lib/libpthread-2.20-2014.11.so
b73c1000 b773b000 r-xp /usr/lib/libelementary.so.1.13.0
b775b000 b775f000 r-xp /usr/lib/libsmack.so.1.0.0
b7760000 b7769000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b776a000 b776d000 r-xp /usr/lib/libdlog.so.0.0.0
b776e000 b7773000 r-xp /usr/lib/libbundle.so.0.1.22
b7774000 b7777000 r-xp /lib/libdl-2.20-2014.11.so
b7779000 b779e000 r-xp /usr/lib/libaul.so.0.1.0
b77a1000 b77a3000 r-xp /usr/lib/libappsvc.so.0.1.0
b77a4000 b77a9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77aa000 b77b1000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b3000 b77b8000 r-xp /usr/lib/libsys-assert.so
b77bb000 b77bc000 r-xp [vdso]
b77bc000 b77de000 r-xp /lib/ld-2.20-2014.11.so
b77e0000 b77e8000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7592)
Call Stack Count: 22
 0: roomlist + 0x23 (0xb381f0f3) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x70f3
 1: login_login_button_clicked_cb + 0x586 (0xb3822846) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xa846
 2: (0xb71e0116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb6417319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb6414d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb71e29e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb7493404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb70c6f39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb70cda11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb70c7fdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb70c84cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb70c868f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb712d702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb7127055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb71301b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb7130587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb758922d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb77addde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb77a6c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x278 (0xb38211b8) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x91b8
20: cJSON_Delete + 0xf8 (0xb77e2148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb77e2148
21: __libc_start_main + 0xde (0xb6ccfe4e) [/lib/libc.so.6] + 0x17e4e
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
tichat
10-17 05:02:48.610+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-17 05:02:48.610+0900 D/AUL     ( 7592): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7593) is sent.
10-17 05:02:48.610+0900 D/AUL     ( 7592): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7593, signo: 10
10-17 05:02:48.620+0900 D/AUL     ( 7592): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzY2NDgxNjgvNjAwMDAwAA==##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3ODEzAA==##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-17 05:02:48.620+0900 D/AUL_PAD ( 7592): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-17 05:02:48.620+0900 I/CAPI_APPFW_APPLICATION( 7592): app_main.c: ui_app_main(788) > app_efl_main
10-17 05:02:48.620+0900 D/LAUNCH  ( 7592): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-17 05:02:48.620+0900 D/APP_CORE( 7592): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-17 05:02:48.620+0900 D/APP_CORE( 7592): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-17 05:02:48.620+0900 D/APP_CORE( 7592): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-17 05:02:48.620+0900 D/APP_CORE( 7592): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-17 05:02:48.630+0900 D/AUL     ( 7592): app_sock.c: __create_server_sock(156) > pg path - already exists
10-17 05:02:48.630+0900 D/APP_CORE( 7592): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4306520
10-17 05:02:48.630+0900 D/LAUNCH  ( 7592): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-17 05:02:48.630+0900 I/CAPI_APPFW_APPLICATION( 7592): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-17 05:02:48.650+0900 E/EFL     ( 7592): elementary<7592> elm_image.c:905 _elm_image_smart_internal_file_set() Things are going bad for 'opt/usr/apps/org.example.tichat/res/images/iu.jpg' (0x8000fe80)
10-17 05:02:48.660+0900 D/IMMODULE( 7592): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-17 05:02:48.660+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:48.660+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_QUERY( 7592): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:48.670+0900 D/IMMODULE( 7592): scim_panel_client.cpp: open_connection(162) > 
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-17 05:02:48.670+0900 D/ISF_SOCKET( 7592): scim_socket.cpp: connect(524) > connect() succeeded
10-17 05:02:48.670+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-17 05:02:48.700+0900 D/LAUNCH  ( 7592): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-17 05:02:48.700+0900 E/E17     ( 2797): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
10-17 05:02:48.710+0900 D/APP_CORE( 7592): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-17 05:02:48.710+0900 E/E17     ( 2797): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
10-17 05:02:48.710+0900 W/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7592
10-17 05:02:48.710+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:48.710+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:48.720+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-17 05:02:48.720+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-17 05:02:48.720+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-17 05:02:48.720+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-17 05:02:48.720+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-17 05:02:48.720+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-17 05:02:48.720+0900 D/APP_CORE( 7592): appcore.c: __aul_handler(587) > [APP 7592]     AUL event: AUL_START
10-17 05:02:48.720+0900 I/APP_CORE( 7592): appcore-efl.c: __do_app(496) > [APP 7592] Event: RESET State: CREATED
10-17 05:02:48.720+0900 D/APP_CORE( 7592): appcore-efl.c: __do_app(527) > [APP 7592] RESET
10-17 05:02:48.720+0900 D/LAUNCH  ( 7592): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-17 05:02:48.720+0900 D/APP_CORE( 7592): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-17 05:02:48.720+0900 D/APP_CORE( 7592): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 05:02:48.720+0900 I/CAPI_APPFW_APPLICATION( 7592): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-17 05:02:48.720+0900 D/AUL     ( 7592): service.c: __set_bundle(186) > __set_bundle
10-17 05:02:48.720+0900 D/LAUNCH  ( 7592): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-17 05:02:48.720+0900 D/APP_CORE( 7592): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-17 05:02:48.720+0900 E/EFL     ( 7592): edje<7592> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:48.720+0900 E/EFL     ( 7592): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:48.720+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-17 05:02:48.720+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7592, appid: org.example.tichat
10-17 05:02:48.720+0900 D/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-17 05:02:48.720+0900 E/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(330) > access
10-17 05:02:48.720+0900 D/AUL_AMD ( 2719): amd_launch.c: _start_app(2700) > add app group info
10-17 05:02:48.720+0900 E/AUL     ( 2719): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-17 05:02:48.720+0900 D/AUL_AMD ( 2719): amd_status.c: _status_add_app_info_list(427) > pid(7592) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-17 05:02:48.720+0900 E/EFL     ( 7592): edje<7592> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:48.720+0900 E/EFL     ( 7592): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:48.720+0900 E/EFL     ( 7592): edje<7592> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:48.720+0900 E/EFL     ( 7592): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:48.720+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 7592
10-17 05:02:48.720+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-17 05:02:48.720+0900 E/RESOURCED( 2835): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-17 05:02:48.720+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(888) > available memory = 762
10-17 05:02:48.720+0900 E/EFL     ( 7592): edje<7592> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:48.720+0900 E/EFL     ( 7592): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:48.720+0900 E/EFL     ( 7592): edje<7592> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-17 05:02:48.720+0900 E/EFL     ( 7592): By the power of Grayskull, your previous Embryo stack is now broken!
10-17 05:02:48.720+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 15
10-17 05:02:48.720+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 05:02:48.720+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-17 05:02:48.730+0900 D/AUL_AMD ( 2719): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7592 is org.example.tichat
10-17 05:02:48.730+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7592 : 0
10-17 05:02:48.730+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-17 05:02:48.730+0900 W/APP_CORE( 7592): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
10-17 05:02:48.730+0900 D/APP_CORE( 7592): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
10-17 05:02:48.730+0900 D/APP_CORE( 7592): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-17 05:02:48.730+0900 D/AUL     ( 7592): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-17 05:02:48.730+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 34
10-17 05:02:48.860+0900 D/APP_CORE( 7592): appcore.c: __prt_ltime(236) > [APP 7592] first idle after reset: 260 msec
10-17 05:02:48.960+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 05:02:48.960+0900 I/APP_CORE( 7592): appcore-efl.c: __do_app(496) > [APP 7592] Event: RESUME State: CREATED
10-17 05:02:48.960+0900 D/LAUNCH  ( 7592): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __do_app(607) > [APP 7592] RESUME
10-17 05:02:48.960+0900 I/APP_CORE( 7592): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-17 05:02:48.960+0900 I/APP_CORE( 7592): appcore-efl.c: __do_app(614) > [APP 7592] Initial Launching, call the resume_cb
10-17 05:02:48.960+0900 I/CAPI_APPFW_APPLICATION( 7592): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 05:02:48.960+0900 D/LAUNCH  ( 7592): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-17 05:02:48.960+0900 D/LAUNCH  ( 7592): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-17 05:02:48.960+0900 D/APP_CORE( 7592): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 05:02:48.960+0900 E/APP_CORE( 7592): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 05:02:48.960+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-17 05:02:48.960+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-17 05:02:48.960+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-17 05:02:48.960+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: PAUSE State: RUNNING
10-17 05:02:48.960+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(565) > [APP 2853] PAUSE
10-17 05:02:48.960+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-17 05:02:48.970+0900 E/cluster-home( 2853): homescreen.cpp: OnPause(84) >  app pause
10-17 05:02:48.970+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-17 05:02:48.970+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppPause(923) >  END
10-17 05:02:48.970+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 05:02:48.970+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 05:02:48.970+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(4)
10-17 05:02:48.970+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-17 05:02:48.970+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-17 05:02:48.970+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: bg
10-17 05:02:48.970+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(7592) status(3)
10-17 05:02:48.970+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 05:02:48.970+0900 W/AUL_AMD ( 2719): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-17 05:02:48.970+0900 W/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-17 05:02:48.970+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(7592) status(3)
10-17 05:02:48.970+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(7592) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-17 05:02:48.970+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-17 05:02:48.970+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7592, appid: org.example.tichat, status: fg
10-17 05:02:48.970+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7592
10-17 05:02:48.970+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7592, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-17 05:02:48.970+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7592
10-17 05:02:48.990+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2853 is paused
10-17 05:02:48.990+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-17 05:02:49.000+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-17 05:02:49.000+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-17 05:02:49.000+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: bg
10-17 05:02:49.010+0900 E/PKGMGR_SERVER( 7758): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-17 05:02:49.010+0900 E/PKGMGR_SERVER( 7758): pkgmgr-server.c: main(2265) > package manager server terminated.
10-17 05:02:49.010+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7592, appname = org.example.tichat, pkgname = org.example.tichat
10-17 05:02:49.010+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7592, appname = org.example.tichat
10-17 05:02:49.010+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7592
10-17 05:02:49.010+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-17 05:02:49.010+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2998
10-17 05:02:49.010+0900 D/RESOURCED( 2835): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2998, appname = org.tizen.calendar.widget
10-17 05:02:49.010+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2998
10-17 05:02:49.010+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 05:02:49.010+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 05:02:49.050+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2910) > pid(7592) status(0)
10-17 05:02:49.730+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-17 05:02:49.730+0900 D/AUL_PAD ( 7822): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-17 05:02:49.730+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-17 05:02:49.730+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.608
10-17 05:02:50.230+0900 D/AUL_AMD ( 2719): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-17 05:02:50.230+0900 D/RUA     ( 2719): rua.c: rua_add_history(179) > rua_add_history start
10-17 05:02:50.240+0900 D/RUA     ( 2719): rua.c: rua_add_history(247) > rua_add_history ok
10-17 05:02:50.370+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb893f3a0. set autocapital type : 2
10-17 05:02:50.370+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60253e 
10-17 05:02:50.370+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 05:02:50.370+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 1da80023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 05:02:50.380+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb893f3a0. on demand : 0
10-17 05:02:50.380+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 05:02:50.380+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 0
10-17 05:02:50.380+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb893f3a0
10-17 05:02:50.380+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): launchpad_loader.c: main(588) > sleeping 1 sec...
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7a69760
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(69) > get pre-initialization function
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(73) > get shutdown function
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7a69a40
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7a6b640
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(69) > get pre-initialization function
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preload.h: __preload_init(73) > get shutdown function
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): preexec.h: __preexec_init(76) > preexec start
10-17 05:02:50.760+0900 D/AUL_PAD ( 7822): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-17 05:02:50.760+0900 D/AUL     ( 7822): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-17 05:02:50.760+0900 D/AUL     ( 7822): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-17 05:02:50.760+0900 D/AUL     ( 7822): process_pool.c: __connect_to_launchpad(132) > send(7822) : 4
10-17 05:02:50.760+0900 D/AUL     ( 7822): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-17 05:02:50.760+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7822
10-17 05:02:50.820+0900 D/AUL_PAD ( 7822): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-17 05:02:50.820+0900 D/AUL_PAD ( 7822): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-17 05:02:50.820+0900 D/AUL_PAD ( 7822): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-17 05:02:50.820+0900 D/AUL_PAD ( 7822): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-17 05:02:50.920+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 1
10-17 05:02:50.920+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb893f3a0, bidi direction : 0x1
10-17 05:02:51.260+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 2
10-17 05:02:51.380+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 3
10-17 05:02:51.390+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
10-17 05:02:51.540+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 4
10-17 05:02:51.960+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 5
10-17 05:02:52.170+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 6
10-17 05:02:52.350+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 7
10-17 05:02:52.450+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb893f3a0, cursor pos : 8
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb893f3a0
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb893f3a0
10-17 05:02:52.630+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb898a0e0. set autocapital type : 0
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb898a0e0. on demand : 0
10-17 05:02:52.630+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_in(245) > Enter
10-17 05:02:52.630+0900 D/ISE_DEFAULT( 3017): ise.cpp: ise_focus_in(824) > ic : 1da90023 , 0 , g_ic : b670023 , 0, g_focused_ic : 0 , 1
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-17 05:02:52.630+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 0
10-17 05:02:52.840+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 1
10-17 05:02:52.840+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb898a0e0, bidi direction : 0x1
10-17 05:02:53.000+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 2
10-17 05:02:53.120+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 3
10-17 05:02:53.210+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 4
10-17 05:02:53.270+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 5
10-17 05:02:53.390+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 6
10-17 05:02:53.540+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 7
10-17 05:02:53.630+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 8
10-17 05:02:53.780+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb898a0e0, cursor pos : 9
10-17 05:02:53.980+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-17 05:02:53.980+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: MEM_FLUSH State: PAUSED
10-17 05:02:53.980+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-17 05:02:53.980+0900 D/APP_CORE( 2853): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2853
10-17 05:02:53.980+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2853
10-17 05:02:53.980+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-17 05:02:54.820+0900 D/IMMODULE( 7592): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb898a0e0
10-17 05:02:54.820+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-17 05:02:54.820+0900 D/IMMODULE( 7592): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb898a0e0
10-17 05:02:54.820+0900 D/ISE_DEFAULT( 3017): ise.cpp: on_focus_out(251) > Enter
10-17 05:02:54.830+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60253e 
10-17 05:02:54.880+0900 I/CAPI_NETWORK_CONNECTION( 7592): connection.c: connection_create(408) > New handle created[0xb897a4b0]
10-17 05:02:54.880+0900 I/CAPI_NETWORK_CONNECTION( 7592): connection.c: connection_get_type(464) > Connected Network = 3
10-17 05:02:54.880+0900 I/tichat  ( 7592): Network connection type : 3
10-17 05:02:56.400+0900 D/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60253e bd->visible=1
10-17 05:02:56.770+0900 I/tichat  ( 7592): CURL Returned: 
10-17 05:02:56.770+0900 I/tichat  ( 7592): {"message":"로그인 성공"}
10-17 05:02:56.770+0900 I/tichat  ( 7592): Parsed JSON: "로그인 성공"
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-17 05:02:56.820+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-17 05:02:56.820+0900 I/AUL_PAD ( 2903): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 7592 pgid = 7592
10-17 05:02:56.820+0900 I/AUL_PAD ( 2903): sigchild.h: __sigchild_action(142) > dead_pid(7592)
10-17 05:02:56.830+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:56.830+0900 D/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2891) > pid(2853) status(3)
10-17 05:02:56.830+0900 D/AUL_AMD ( 2719): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-17 05:02:56.830+0900 W/AUL_AMD ( 2719): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-17 05:02:56.830+0900 W/AUL_AMD ( 2719): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-17 05:02:56.830+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(456) > pid(2853) status(3)
10-17 05:02:56.830+0900 D/AUL_AMD ( 2719): amd_status.c: _status_update_app_info_list(468) > pid(2853) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
10-17 05:02:56.830+0900 D/AUL     ( 2719): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
10-17 05:02:56.830+0900 W/AUL     ( 2719): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2853, appid: org.tizen.homescreen, status: fg
10-17 05:02:56.830+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2853
10-17 05:02:56.830+0900 D/RESOURCED( 2835): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2853, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
10-17 05:02:56.830+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2853, appname = org.tizen.homescreen
10-17 05:02:56.830+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2853
10-17 05:02:56.840+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_dead_signal(90) > send dead signal done
10-17 05:02:56.840+0900 I/AUL_PAD ( 2903): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
10-17 05:02:56.840+0900 I/AUL_PAD ( 2903): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
10-17 05:02:56.840+0900 E/AUL_PAD ( 2903): launchpad.c: main(688) > error reading sigchld info
10-17 05:02:56.840+0900 D/STARTER ( 2833): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 7592 is termianted
10-17 05:02:56.840+0900 D/STARTER ( 2833): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
10-17 05:02:56.840+0900 I/ESD     ( 2914): esd_main.c: __esd_app_dead_handler(1771) > pid: 7592
10-17 05:02:56.840+0900 W/AUL_AMD ( 2719): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 7592
10-17 05:02:56.840+0900 W/AUL_AMD ( 2719): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 7592
10-17 05:02:56.840+0900 D/AUL_AMD ( 2719): amd_key.c: _unregister_key_event(179) > ===key stack===
10-17 05:02:56.840+0900 E/AUL_AMD ( 2719): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
10-17 05:02:56.840+0900 D/AUL_AMD ( 2719): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.tichat)
10-17 05:02:56.840+0900 D/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-17 05:02:56.840+0900 E/AUL     ( 2719): simple_util.c: __trm_app_info_send_socket(330) > access
10-17 05:02:56.840+0900 E/E17     ( 2797): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
10-17 05:02:56.840+0900 E/E17     ( 2797): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200002), visible:1
10-17 05:02:56.840+0900 D/INDICATOR( 2840): main.c: _property_changed_cb(432) > UNSNIFF API 1200002
10-17 05:02:56.840+0900 D/INDICATOR( 2840): util.c: util_signal_emit_by_win(116) > emission bg.translucent
10-17 05:02:56.840+0900 D/INDICATOR( 2840): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-17 05:02:56.840+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-17 05:02:56.840+0900 D/INDICATOR( 2840): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-17 05:02:56.840+0900 D/INDICATOR( 2840): main.c: _rotate_window(252) > port :: hide more icon
10-17 05:02:56.850+0900 E/RESOURCED( 2835): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.613
10-17 05:02:56.850+0900 D/RESOURCED( 2835): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 7592
10-17 05:02:56.850+0900 D/RESOURCED( 2835): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.tichat, pkgname = org.example.tichat, ref = 0
10-17 05:02:56.890+0900 W/PROCESSMGR( 2797): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2853
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-17 05:02:56.940+0900 I/APP_CORE( 2853): appcore-efl.c: __do_app(496) > [APP 2853] Event: RESUME State: PAUSED
10-17 05:02:56.940+0900 D/LAUNCH  ( 2853): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __do_app(607) > [APP 2853] RESUME
10-17 05:02:56.940+0900 I/CAPI_APPFW_APPLICATION( 2853): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-17 05:02:56.940+0900 E/cluster-home( 2853): homescreen.cpp: OnResume(66) >  app resume
10-17 05:02:56.940+0900 D/cluster-home( 2853): widget-data-provider.cpp: SetBoxVisibility(1543) >  
10-17 05:02:56.940+0900 D/cluster-home( 2853): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
10-17 05:02:56.940+0900 D/WIDGET_VIEWER( 2853): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
10-17 05:02:56.940+0900 D/cluster-home( 2853): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
10-17 05:02:56.940+0900 D/cluster-home( 2853): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
10-17 05:02:56.940+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
10-17 05:02:56.940+0900 D/cluster-view( 2853): homescreen-view-manager.cpp: AppResume(910) >  END
10-17 05:02:56.940+0900 E/EFL     ( 2797): eo<2797> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-17 05:02:56.940+0900 D/cluster-view( 2853): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
10-17 05:02:56.940+0900 D/cluster-view( 2853): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
10-17 05:02:56.940+0900 D/cluster-view( 2853): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
10-17 05:02:56.940+0900 D/cluster-view( 2853): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
10-17 05:02:56.940+0900 D/cluster-view( 2853): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
10-17 05:02:56.940+0900 D/cluster-view( 2853): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
10-17 05:02:56.940+0900 D/test-log( 2853): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
10-17 05:02:56.940+0900 D/test-log( 2853): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
10-17 05:02:56.940+0900 D/cluster-view( 2853): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
10-17 05:02:56.940+0900 D/cluster-home( 2853): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
10-17 05:02:56.940+0900 D/LAUNCH  ( 2853): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
10-17 05:02:56.940+0900 D/LAUNCH  ( 2853): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
10-17 05:02:56.940+0900 D/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-17 05:02:56.940+0900 E/APP_CORE( 2853): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-17 05:02:56.950+0900 I/TIZEN_N_SOUND_MANAGER( 2927): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
10-17 05:02:56.950+0900 E/TIZEN_N_SOUND_MANAGER( 2927): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
10-17 05:02:56.950+0900 I/TIZEN_N_SOUND_MANAGER( 2927): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
10-17 05:02:56.950+0900 E/TIZEN_N_SOUND_MANAGER( 2927): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
10-17 05:02:56.950+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(838) > __request_handler: 15
10-17 05:02:56.950+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-17 05:02:56.950+0900 D/PKGMGR_INFO( 2719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-17 05:02:56.950+0900 D/AUL_AMD ( 2719): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2853 is org.tizen.homescreen
10-17 05:02:56.950+0900 D/AUL_AMD ( 2719): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2853 : 0
10-17 05:02:56.950+0900 D/AUL     ( 2927): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
10-17 05:02:56.960+0900 D/DATA_PROVIDER_MASTER( 2906): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2853 is resumed
10-17 05:02:56.960+0900 D/DATA_PROVIDER_MASTER( 2906): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
10-17 05:02:56.960+0900 E/DATA_PROVIDER_MASTER( 2906): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
10-17 05:02:56.970+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
10-17 05:02:56.970+0900 I/CAPI_WIDGET_APPLICATION( 2998): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
10-17 05:02:56.970+0900 W/AUL     ( 2998): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2998, appid: org.tizen.calendar.widget, status: fg
10-17 05:02:56.970+0900 D/RESOURCED( 2835): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2998
10-17 05:02:56.970+0900 D/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2998, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
10-17 05:02:56.970+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 2998
10-17 05:02:56.980+0900 D/RESOURCED( 2835): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2998, appname = org.tizen.calendar.widget
10-17 05:02:56.980+0900 D/RESOURCED( 2835): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2998
10-17 05:02:56.980+0900 I/RESOURCED( 2835): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-17 05:02:56.980+0900 I/RESOURCED( 2835): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-17 05:02:57.070+0900 W/CRASH_MANAGER( 7826): worker.c: worker_job(1204) > 1107592746963147664817
