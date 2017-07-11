S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 3727
Date: 2016-10-31 18:23:19+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x5589cc49

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfeb37ec, esi = 0xb35b4068
ebp = 0xbfeb3848, esp = 0xbfeb36b0
eax = 0x5589cc45, ebx = 0xb35b7174
ecx = 0x00000000, edx = 0x00000000
eip = 0xb35ac032

Memory Information
MemTotal:      250 KB
MemFree:       156 KB
Buffers:         6 KB
Cached:     165248 KB
VmPeak:     117692 KB
VmSize:     112248 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31044 KB
VmRSS:       25656 KB
VmData:      43716 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34632 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3727 TID = 3727
3727 3728 3953 3955 3959 

Maps Information
b1a07000 b1a0c000 r-xp /lib/libnss_dns-2.20-2014.11.so
b2b45000 b2b4c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2b4d000 b2b65000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b66000 b2b6d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2bea000 b2bf4000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bfa000 b2c06000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c07000 b2c28000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c2d000 b2c2e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c2f000 b2c34000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c35000 b2c36000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c37000 b2c39000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c3a000 b2c3c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c3d000 b2c49000 r-xp /usr/lib/libdrm.so.2.4.0
b2c4a000 b2c4d000 r-xp /usr/lib/libdri2.so.0.0.0
b2c4e000 b2c58000 r-xp /usr/lib/libtbm.so.1.0.0
b2c59000 b2c5a000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c5b000 b2c70000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c71000 b2c83000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3485000 b34b6000 r-xp /usr/lib/libidn.so.11.5.44
b34b7000 b34d9000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34da000 b34ea000 r-xp /usr/lib/libcares.so.2.1.0
b34eb000 b350b000 r-xp /usr/lib/libnetwork.so.0.0.0
b350c000 b3515000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3516000 b358d000 r-xp /usr/lib/libcurl.so.4.3.0
b358f000 b35a3000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b35a4000 b35b7000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b36bf000 b36c5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36c6000 b380a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3820000 b3821000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3822000 b3823000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3824000 b3827000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3828000 b382b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b382c000 b3865000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4268000 b4273000 r-xp /lib/libnss_files-2.20-2014.11.so
b4275000 b4280000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4282000 b4299000 r-xp /lib/libnsl-2.20-2014.11.so
b429d000 b42a5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42a7000 b42cb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42cc000 b42cd000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42ce000 b42d1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42d2000 b42d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42da000 b42e4000 r-xp /usr/lib/libsensord-share.so
b42e5000 b4301000 r-xp /usr/lib/libsensor.so.1.2.0
b4303000 b430c000 r-xp /usr/lib/libappcore-common.so.1.1
b430f000 b4311000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4326000 b4328000 r-xp /usr/lib/libXau.so.6.0.0
b4329000 b434b000 r-xp /usr/lib/libxcb.so.1.1.0
b434d000 b4356000 r-xp /lib/libcrypt-2.20-2014.11.so
b437f000 b4381000 r-xp /usr/lib/libiri.so
b4382000 b43a8000 r-xp /lib/libexpat.so.1.5.2
b43aa000 b4415000 r-xp /usr/lib/libssl.so.1.0.0
b441b000 b4427000 r-xp /usr/lib/libethumb.so.1.13.0
b4428000 b442c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b442d000 b467e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bf9000 b5c09000 r-xp /usr/lib/libXi.so.6.1.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c0d000 b5c13000 r-xp /usr/lib/libXtst.so.6.1.0
b5c14000 b5c1e000 r-xp /usr/lib/libXrender.so.1.3.0
b5c1f000 b5c28000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c2a000 b5c2c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c2d000 b5c32000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c33000 b5c45000 r-xp /usr/lib/libXext.so.6.4.0
b5c46000 b5c48000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c49000 b5c4b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c4d000 b5d8f000 r-xp /usr/lib/libX11.so.6.3.0
b5d93000 b5d9d000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d9e000 b5db4000 r-xp /usr/lib/libudev.so.1.6.0
b5db7000 b5dbb000 r-xp /lib/libattr.so.1.1.0
b5dbc000 b5deb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5ded000 b5df3000 r-xp /usr/lib/libffi.so.6.0.2
b5df4000 b5e17000 r-xp /lib/libz.so.1.2.8
b5e18000 b5e1b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e1c000 b5f78000 r-xp /usr/lib/libxml2.so.2.9.2
b5f7e000 b6065000 r-xp /usr/lib/libstdc++.so.6.0.20
b6072000 b6075000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6076000 b6098000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6099000 b60ad000 r-xp /lib/libresolv-2.20-2014.11.so
b60b1000 b60d5000 r-xp /usr/lib/liblzma.so.5.0.3
b60d6000 b60d8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60da000 b60e4000 r-xp /usr/lib/libembryo.so.1.13.0
b60e5000 b610e000 r-xp /usr/lib/libpng12.so.0.50.0
b610f000 b6158000 r-xp /usr/lib/libjpeg.so.8.0.2
b6169000 b6170000 r-xp /lib/librt-2.20-2014.11.so
b6172000 b6191000 r-xp /usr/lib/libector.so.1.13.0
b6194000 b61c1000 r-xp /usr/lib/liblua-5.1.so
b61c2000 b6252000 r-xp /usr/lib/libfreetype.so.6.11.3
b6256000 b6294000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6295000 b62ab000 r-xp /usr/lib/libfribidi.so.0.3.1
b62ac000 b6305000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6308000 b6353000 r-xp /lib/libm-2.20-2014.11.so
b6355000 b6367000 r-xp /usr/lib/libeio.so.1.13.0
b6368000 b636b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b636c000 b6372000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6373000 b6396000 r-xp /usr/lib/libefreet.so.1.13.0
b6399000 b63c4000 r-xp /usr/lib/libeldbus.so.1.13.0
b63c5000 b63f9000 r-xp /usr/lib/libecore_con.so.1.13.0
b63fb000 b6404000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6405000 b640e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b640f000 b6422000 r-xp /usr/lib/libeo.so.1.13.0
b6424000 b6437000 r-xp /usr/lib/libecore_input.so.1.13.0
b6438000 b643f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6440000 b6463000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6464000 b6490000 r-xp /usr/lib/libeet.so.1.13.0
b6499000 b6504000 r-xp /usr/lib/libeina.so.1.13.0
b6507000 b651e000 r-xp /usr/lib/libefl.so.1.13.0
b6520000 b6687000 r-xp /usr/lib/libicuuc.so.51.1
b6695000 b68a1000 r-xp /usr/lib/libicui18n.so.51.1
b68a9000 b68f8000 r-xp /usr/lib/libecore_x.so.1.13.0
b68fa000 b6914000 r-xp /lib/libgcc_s-4.9.so.1
b6916000 b691a000 r-xp /lib/libcap.so.2.21
b691b000 b6961000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6962000 b6969000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b696b000 b69bd000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69bf000 b6b4a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b4f000 b6c1d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c20000 b6c24000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c25000 b6c34000 r-xp /usr/lib/libvconf.so.0.2.45
b6c35000 b6c38000 r-xp /usr/lib/libvasum.so.0.3.1
b6c39000 b6c3c000 r-xp /usr/lib/libttrace.so.1.1
b6c3e000 b6c42000 r-xp /usr/lib/libiniparser.so.0
b6c43000 b6c73000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c74000 b6c7d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c7e000 b6ca3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6ca4000 b6cb4000 r-xp /usr/lib/libunwind.so.8.0.1
b6cbe000 b6e6c000 r-xp /lib/libc-2.20-2014.11.so
b6e74000 b6fb7000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fb9000 b7011000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7012000 b7046000 r-xp /usr/lib/libsystemd.so.0.4.0
b7049000 b711d000 r-xp /usr/lib/libedje.so.1.13.0
b7120000 b714c000 r-xp /usr/lib/libecore.so.1.13.0
b715d000 b7383000 r-xp /usr/lib/libevas.so.1.13.0
b73ab000 b73c3000 r-xp /lib/libpthread-2.20-2014.11.so
b73c7000 b7741000 r-xp /usr/lib/libelementary.so.1.13.0
b7761000 b7765000 r-xp /usr/lib/libsmack.so.1.0.0
b7766000 b776f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7770000 b7773000 r-xp /usr/lib/libdlog.so.0.0.0
b7774000 b7779000 r-xp /usr/lib/libbundle.so.0.1.22
b777a000 b777d000 r-xp /lib/libdl-2.20-2014.11.so
b777f000 b77a4000 r-xp /usr/lib/libaul.so.0.1.0
b77a7000 b77a9000 r-xp /usr/lib/libappsvc.so.0.1.0
b77aa000 b77af000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77b0000 b77b7000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b9000 b77be000 r-xp /usr/lib/libsys-assert.so
b77c1000 b77c2000 r-xp [vdso]
b77c2000 b77e4000 r-xp /lib/ld-2.20-2014.11.so
b77e6000 b77ee000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3727)
Call Stack Count: 15
 0: create_connection + 0x532 (0xb35ac032) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8032
 1: enter_room + 0x2b (0xb35ac35b) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x835b
 2: room_list_clicked_cb + 0x74 (0xb35af074) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb074
 3: (0xb75271d0) [/usr/lib/libelementary.so.1] + 0x1601d0
 4: (0xb7527315) [/usr/lib/libelementary.so.1] + 0x160315
 5: (0xb713b370) [/usr/lib/libecore.so.1] + 0x1b370
 6: (0xb713b4ff) [/usr/lib/libecore.so.1] + 0x1b4ff
 7: (0xb7136061) [/usr/lib/libecore.so.1] + 0x16061
 8: ecore_main_loop_begin + 0x57 (0xb7136587) [/usr/lib/libecore.so.1] + 0x16587
 9: elm_run + 0x2d (0xb758f22d) [/usr/lib/libelementary.so.1] + 0x1c822d
10: appcore_efl_main + 0x4de (0xb77b3dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
11: ui_app_main + 0x140 (0xb77acc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
12: main + 0x278 (0xb35b1b58) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xdb58
13: (0xb77e8148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb77e8148
14: __libc_start_main + 0xde (0xb6cd5e4e) [/lib/libc.so.6] + 0x17e4e
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
AD ( 3727): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-31 18:23:04.977+0900 D/AUL     ( 3727): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3728) is sent.
10-31 18:23:04.977+0900 D/AUL     ( 3727): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3728, signo: 10
10-31 18:23:04.977+0900 D/AUL     ( 3727): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0Nzc5MDU3ODQvOTczMjczAA==##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzOTQ5AA==##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-31 18:23:04.977+0900 D/AUL_PAD ( 3727): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-31 18:23:04.977+0900 I/CAPI_APPFW_APPLICATION( 3727): app_main.c: ui_app_main(788) > app_efl_main
10-31 18:23:04.977+0900 D/LAUNCH  ( 3727): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-31 18:23:04.977+0900 D/APP_CORE( 3727): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-31 18:23:04.977+0900 D/APP_CORE( 3727): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-31 18:23:04.977+0900 D/APP_CORE( 3727): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-31 18:23:04.987+0900 D/APP_CORE( 3727): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-31 18:23:04.987+0900 D/AUL     ( 3727): app_sock.c: __create_server_sock(156) > pg path - already exists
10-31 18:23:04.987+0900 D/APP_CORE( 3727): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb430c520
10-31 18:23:04.987+0900 D/LAUNCH  ( 3727): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-31 18:23:04.987+0900 I/CAPI_APPFW_APPLICATION( 3727): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-31 18:23:04.987+0900 E/PKGMGR_SERVER( 3894): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
10-31 18:23:04.997+0900 E/PKGMGR_SERVER( 3894): pkgmgr-server.c: main(2265) > package manager server terminated.
10-31 18:23:05.027+0900 D/IMMODULE( 3727): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-31 18:23:05.027+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-31 18:23:05.027+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(524) > connect() succeeded
10-31 18:23:05.027+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-31 18:23:05.027+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(524) > connect() succeeded
10-31 18:23:05.037+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-31 18:23:05.037+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(524) > connect() succeeded
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_QUERY( 3727): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-31 18:23:05.037+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
10-31 18:23:05.037+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(524) > connect() succeeded
10-31 18:23:05.047+0900 D/IMMODULE( 3727): scim_panel_client.cpp: open_connection(162) > 
10-31 18:23:05.047+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-31 18:23:05.047+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(524) > connect() succeeded
10-31 18:23:05.047+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-panel-socket:0, tichat
10-31 18:23:05.047+0900 D/ISF_SOCKET( 3727): scim_socket.cpp: connect(524) > connect() succeeded
10-31 18:23:05.047+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-31 18:23:05.077+0900 D/AUL_PAD ( 2902): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-31 18:23:05.077+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 3727, appid: org.example.tichat
10-31 18:23:05.077+0900 D/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-31 18:23:05.077+0900 E/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(330) > access
10-31 18:23:05.077+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2700) > add app group info
10-31 18:23:05.077+0900 E/AUL     ( 2746): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-31 18:23:05.077+0900 D/AUL_AMD ( 2746): amd_status.c: _status_add_app_info_list(427) > pid(3727) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-31 18:23:05.077+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 3727
10-31 18:23:05.077+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-31 18:23:05.077+0900 E/RESOURCED( 2836): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-31 18:23:05.077+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(888) > available memory = 816
10-31 18:23:05.087+0900 D/LAUNCH  ( 3727): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-31 18:23:05.087+0900 E/E17     ( 2763): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
10-31 18:23:05.087+0900 D/APP_CORE( 3727): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-31 18:23:05.097+0900 E/E17     ( 2763): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
10-31 18:23:05.107+0900 D/APP_CORE( 3727): appcore.c: __aul_handler(587) > [APP 3727]     AUL event: AUL_START
10-31 18:23:05.107+0900 I/APP_CORE( 3727): appcore-efl.c: __do_app(496) > [APP 3727] Event: RESET State: CREATED
10-31 18:23:05.107+0900 D/APP_CORE( 3727): appcore-efl.c: __do_app(527) > [APP 3727] RESET
10-31 18:23:05.107+0900 D/LAUNCH  ( 3727): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-31 18:23:05.107+0900 D/APP_CORE( 3727): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-31 18:23:05.107+0900 D/APP_CORE( 3727): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-31 18:23:05.107+0900 I/CAPI_APPFW_APPLICATION( 3727): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-31 18:23:05.107+0900 D/AUL     ( 3727): service.c: __set_bundle(186) > __set_bundle
10-31 18:23:05.107+0900 D/LAUNCH  ( 3727): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-31 18:23:05.107+0900 D/APP_CORE( 3727): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-31 18:23:05.107+0900 W/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3727
10-31 18:23:05.107+0900 E/EFL     ( 3727): edje<3727> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-31 18:23:05.107+0900 E/EFL     ( 3727): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 18:23:05.107+0900 E/EFL     ( 3727): edje<3727> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-31 18:23:05.107+0900 E/EFL     ( 3727): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 18:23:05.107+0900 E/EFL     ( 3727): edje<3727> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-31 18:23:05.107+0900 E/EFL     ( 3727): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 18:23:05.107+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-31 18:23:05.107+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-31 18:23:05.107+0900 E/EFL     ( 3727): edje<3727> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-31 18:23:05.107+0900 E/EFL     ( 3727): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 18:23:05.117+0900 E/EFL     ( 3727): edje<3727> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-31 18:23:05.117+0900 E/EFL     ( 3727): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 18:23:05.117+0900 D/INDICATOR( 2842): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-31 18:23:05.117+0900 D/INDICATOR( 2842): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-31 18:23:05.117+0900 D/INDICATOR( 2842): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-31 18:23:05.117+0900 D/INDICATOR( 2842): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-31 18:23:05.117+0900 D/INDICATOR( 2842): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-31 18:23:05.117+0900 D/INDICATOR( 2842): main.c: _rotate_window(252) > port :: hide more icon
10-31 18:23:05.117+0900 W/APP_CORE( 3727): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
10-31 18:23:05.117+0900 D/APP_CORE( 3727): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
10-31 18:23:05.117+0900 D/APP_CORE( 3727): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-31 18:23:05.117+0900 D/AUL     ( 3727): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-31 18:23:05.117+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 34
10-31 18:23:05.117+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 15
10-31 18:23:05.117+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-31 18:23:05.117+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-31 18:23:05.127+0900 D/AUL_AMD ( 2746): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3727 is org.example.tichat
10-31 18:23:05.127+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3727 : 0
10-31 18:23:05.127+0900 D/AUL     ( 2922): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-31 18:23:05.257+0900 D/APP_CORE( 3727): appcore.c: __prt_ltime(236) > [APP 3727] first idle after reset: 298 msec
10-31 18:23:05.437+0900 E/E17     ( 2763): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-31 18:23:05.437+0900 I/APP_CORE( 3727): appcore-efl.c: __do_app(496) > [APP 3727] Event: RESUME State: CREATED
10-31 18:23:05.437+0900 D/LAUNCH  ( 3727): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __do_app(607) > [APP 3727] RESUME
10-31 18:23:05.437+0900 I/APP_CORE( 3727): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-31 18:23:05.437+0900 I/APP_CORE( 3727): appcore-efl.c: __do_app(614) > [APP 3727] Initial Launching, call the resume_cb
10-31 18:23:05.437+0900 I/CAPI_APPFW_APPLICATION( 3727): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-31 18:23:05.437+0900 D/LAUNCH  ( 3727): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-31 18:23:05.437+0900 D/LAUNCH  ( 3727): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-31 18:23:05.437+0900 D/APP_CORE( 3727): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-31 18:23:05.437+0900 E/APP_CORE( 3727): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-31 18:23:05.437+0900 D/APP_CORE( 2849): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-31 18:23:05.437+0900 D/APP_CORE( 2849): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-31 18:23:05.437+0900 D/APP_CORE( 2849): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-31 18:23:05.437+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: PAUSE State: RUNNING
10-31 18:23:05.437+0900 D/APP_CORE( 2849): appcore-efl.c: __do_app(565) > [APP 2849] PAUSE
10-31 18:23:05.437+0900 I/CAPI_APPFW_APPLICATION( 2849): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-31 18:23:05.437+0900 E/cluster-home( 2849): homescreen.cpp: OnPause(84) >  app pause
10-31 18:23:05.437+0900 D/cluster-view( 2849): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-31 18:23:05.437+0900 D/cluster-view( 2849): homescreen-view-manager.cpp: AppPause(923) >  END
10-31 18:23:05.437+0900 D/APP_CORE( 2849): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-31 18:23:05.437+0900 E/APP_CORE( 2849): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-31 18:23:05.437+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2849) status(4)
10-31 18:23:05.437+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2849) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-31 18:23:05.437+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-31 18:23:05.437+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2849, appid: org.tizen.homescreen, status: bg
10-31 18:23:05.437+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(3727) status(3)
10-31 18:23:05.437+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-31 18:23:05.437+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-31 18:23:05.437+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-31 18:23:05.437+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(3727) status(3)
10-31 18:23:05.437+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(3727) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-31 18:23:05.437+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-31 18:23:05.437+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3727, appid: org.example.tichat, status: fg
10-31 18:23:05.437+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3727
10-31 18:23:05.437+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3727, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-31 18:23:05.437+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3727
10-31 18:23:05.447+0900 D/DATA_PROVIDER_MASTER( 2905): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2849 is paused
10-31 18:23:05.447+0900 D/DATA_PROVIDER_MASTER( 2905): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-31 18:23:05.447+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-31 18:23:05.447+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-31 18:23:05.447+0900 W/AUL     ( 2988): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2988, appid: org.tizen.calendar.widget, status: bg
10-31 18:23:05.467+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3727, appname = org.example.tichat, pkgname = org.example.tichat
10-31 18:23:05.467+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3727, appname = org.example.tichat
10-31 18:23:05.467+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3727
10-31 18:23:05.467+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2988, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-31 18:23:05.467+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2988
10-31 18:23:05.467+0900 D/RESOURCED( 2836): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2988, appname = org.tizen.calendar.widget
10-31 18:23:05.467+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2988
10-31 18:23:05.467+0900 I/RESOURCED( 2836): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-31 18:23:05.467+0900 I/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-31 18:23:05.467+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2910) > pid(3727) status(0)
10-31 18:23:06.077+0900 D/AUL_PAD ( 2902): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-31 18:23:06.077+0900 D/AUL_PAD ( 3957): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-31 18:23:06.077+0900 D/AUL_PAD ( 2902): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-31 18:23:06.577+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-31 18:23:06.577+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
10-31 18:23:06.577+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): launchpad_loader.c: main(588) > sleeping 1 sec...
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b848c760
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(69) > get pre-initialization function
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(73) > get shutdown function
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b848ca40
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b848e640
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(69) > get pre-initialization function
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preload.h: __preload_init(73) > get shutdown function
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): preexec.h: __preexec_init(76) > preexec start
10-31 18:23:07.107+0900 D/AUL_PAD ( 3957): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-31 18:23:07.107+0900 D/AUL     ( 3957): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-31 18:23:07.107+0900 D/AUL     ( 3957): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-31 18:23:07.107+0900 D/AUL     ( 3957): process_pool.c: __connect_to_launchpad(132) > send(3957) : 4
10-31 18:23:07.107+0900 D/AUL     ( 3957): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-31 18:23:07.107+0900 D/AUL_PAD ( 2902): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3957
10-31 18:23:07.167+0900 D/AUL_PAD ( 3957): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-31 18:23:07.177+0900 D/AUL_PAD ( 3957): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-31 18:23:07.177+0900 D/AUL_PAD ( 3957): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-31 18:23:07.177+0900 D/AUL_PAD ( 3957): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-31 18:23:10.447+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-31 18:23:10.447+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: MEM_FLUSH State: PAUSED
10-31 18:23:10.447+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-31 18:23:10.447+0900 D/APP_CORE( 2849): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2849
10-31 18:23:10.447+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-31 18:23:10.447+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2849
10-31 18:23:11.547+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6004f0 
10-31 18:23:11.547+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9920550. set autocapital type : 2
10-31 18:23:11.547+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
10-31 18:23:11.547+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : e8f0023 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
10-31 18:23:11.547+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9920550. on demand : 0
10-31 18:23:11.547+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 18:23:11.547+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 0
10-31 18:23:11.557+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb9920550
10-31 18:23:11.557+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 18:23:12.217+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 1
10-31 18:23:12.217+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb9920550, bidi direction : 0x1
10-31 18:23:12.417+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 2
10-31 18:23:12.537+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 3
10-31 18:23:12.547+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
10-31 18:23:12.657+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 4
10-31 18:23:12.927+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 5
10-31 18:23:13.177+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 6
10-31 18:23:13.357+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 7
10-31 18:23:13.417+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9920550, cursor pos : 8
10-31 18:23:13.567+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9920550
10-31 18:23:13.567+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-31 18:23:13.567+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9920550
10-31 18:23:13.577+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
10-31 18:23:13.577+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9966fe8. set autocapital type : 0
10-31 18:23:13.577+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
10-31 18:23:13.577+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : e900023 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
10-31 18:23:13.577+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9966fe8. on demand : 0
10-31 18:23:13.577+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 18:23:13.577+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 0
10-31 18:23:13.777+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 1
10-31 18:23:13.787+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb9966fe8, bidi direction : 0x1
10-31 18:23:13.877+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 2
10-31 18:23:14.027+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 3
10-31 18:23:14.087+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 4
10-31 18:23:14.177+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 5
10-31 18:23:14.297+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 6
10-31 18:23:14.447+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 7
10-31 18:23:14.507+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 8
10-31 18:23:14.637+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9966fe8, cursor pos : 9
10-31 18:23:15.677+0900 D/IMMODULE( 3727): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9966fe8
10-31 18:23:15.677+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-31 18:23:15.677+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9966fe8
10-31 18:23:15.687+0900 E/EFL     ( 3727): edje<3727> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-31 18:23:15.687+0900 E/EFL     ( 3727): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 18:23:15.687+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
10-31 18:23:15.697+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6004f0 
10-31 18:23:15.807+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_create(408) > New handle created[0xb996a600]
10-31 18:23:15.807+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_get_type(464) > Connected Network = 3
10-31 18:23:15.807+0900 I/tichat  ( 3727): Network connection type : 3
10-31 18:23:15.917+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-31 18:23:15.917+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-31 18:23:15.917+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-31 18:23:15.917+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-31 18:23:17.007+0900 I/tichat  ( 3727): CURL Returned: 
10-31 18:23:17.007+0900 I/tichat  ( 3727): {"message":"로그인 성공"}
10-31 18:23:17.007+0900 I/tichat  ( 3727): Parsed JSON: "로그인 성공"
10-31 18:23:17.027+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_destroy(426) > Destroy handle: 0xb996a600
10-31 18:23:17.027+0900 D/IMMODULE( 3727): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-31 18:23:17.027+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-31 18:23:17.027+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-31 18:23:17.027+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-31 18:23:17.027+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-31 18:23:17.027+0900 D/SCIM_HELPER( 3015): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-31 18:23:17.027+0900 D/LIBSCL_UI( 3015): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2200009 (basewin 0x8000321a mag 0x8000fc7f)
10-31 18:23:17.057+0900 D/LIBSCL_UI( 3015): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2200003 (basewin 0x8000321a mag 0x8000fc7f)
10-31 18:23:17.057+0900 D/ISE_DEFAULT( 3015): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-31 18:23:17.547+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6004f0 bd->visible=1
10-31 18:23:18.147+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6004f0 
10-31 18:23:18.277+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_create(408) > New handle created[0xb9a73580]
10-31 18:23:18.277+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_get_type(464) > Connected Network = 3
10-31 18:23:18.277+0900 I/tichat  ( 3727): Network connection type : 3
10-31 18:23:18.897+0900 I/tichat  ( 3727): CURL Returned: 
10-31 18:23:18.897+0900 I/tichat  ( 3727): [{"id":1,"title":"new room","participant":0,"createdAt":"2016-10-31T09:08:36.056Z","updatedAt":"2016-10-31T09:08:36.056Z"}]
10-31 18:23:18.897+0900 I/tichat  ( 3727): Parsed JSON: (null)
10-31 18:23:18.897+0900 I/tichat  ( 3727): 0's title: "new room"
10-31 18:23:18.897+0900 I/tichat  ( 3727): JSON: [{"id":1,"title":"new room","participant":0,"createdAt":"2016-10-31T09:08:36.056Z","updatedAt":"2016-10-31T09:08:36.056Z"}]
10-31 18:23:18.917+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.927+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.937+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.937+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.937+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.937+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.937+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:18.937+0900 E/EFL     ( 3727): evas_main<3727> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8647 is not stable during recalc loop
10-31 18:23:19.687+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6004f0 
10-31 18:23:19.767+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_create(408) > New handle created[0xb9a06b08]
10-31 18:23:19.767+0900 I/CAPI_NETWORK_CONNECTION( 3727): connection.c: connection_get_type(464) > Connected Network = 3
10-31 18:23:19.767+0900 I/tichat  ( 3727): IPv6 address: fec0::5054:ff:fe12:3456
10-31 18:23:19.767+0900 I/tichat  ( 3727): IPv4 address: 10.0.2.15
10-31 18:23:19.767+0900 I/tichat  ( 3727): Interface Name: eth0
10-31 18:23:19.787+0900 I/tichat  ( 3727): getaddrinfo() error
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-31 18:23:19.837+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-31 18:23:19.837+0900 I/AUL_PAD ( 2902): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 3727 pgid = 3727
10-31 18:23:19.837+0900 I/AUL_PAD ( 2902): sigchild.h: __sigchild_action(142) > dead_pid(3727)
10-31 18:23:19.857+0900 D/AUL_PAD ( 2902): sigchild.h: __send_app_dead_signal(90) > send dead signal done
10-31 18:23:19.857+0900 I/AUL_PAD ( 2902): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
10-31 18:23:19.857+0900 I/AUL_PAD ( 2902): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
10-31 18:23:19.857+0900 E/AUL_PAD ( 2902): launchpad.c: main(688) > error reading sigchld info
10-31 18:23:19.857+0900 W/AUL_AMD ( 2746): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 3727
10-31 18:23:19.857+0900 I/ESD     ( 2920): esd_main.c: __esd_app_dead_handler(1771) > pid: 3727
10-31 18:23:19.857+0900 W/AUL_AMD ( 2746): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 3727
10-31 18:23:19.857+0900 D/AUL_AMD ( 2746): amd_key.c: _unregister_key_event(179) > ===key stack===
10-31 18:23:19.857+0900 E/AUL_AMD ( 2746): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
10-31 18:23:19.857+0900 D/AUL_AMD ( 2746): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.tichat)
10-31 18:23:19.857+0900 D/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-31 18:23:19.857+0900 E/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(330) > access
10-31 18:23:19.857+0900 D/STARTER ( 2833): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 3727 is termianted
10-31 18:23:19.857+0900 D/STARTER ( 2833): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
10-31 18:23:19.857+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-31 18:23:19.857+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.197
10-31 18:23:19.857+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 3727
10-31 18:23:19.857+0900 D/RESOURCED( 2836): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.tichat, pkgname = org.example.tichat, ref = 0
10-31 18:23:19.857+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(2849) status(3)
10-31 18:23:19.857+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-31 18:23:19.867+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
10-31 18:23:19.867+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
10-31 18:23:19.867+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2849) status(3)
10-31 18:23:19.867+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2849) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
10-31 18:23:19.867+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
10-31 18:23:19.867+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2849, appid: org.tizen.homescreen, status: fg
10-31 18:23:19.867+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2849
10-31 18:23:19.867+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2849, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
10-31 18:23:19.867+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2849, appname = org.tizen.homescreen
10-31 18:23:19.867+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2849
10-31 18:23:19.867+0900 W/CRASH_MANAGER( 3960): worker.c: worker_job(1204) > 1103727746963147790579
