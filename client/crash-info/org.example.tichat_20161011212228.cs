S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 3890
Date: 2016-10-11 21:22:28+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000a658

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7bf3248, esi = 0x8000a654
ebp = 0xbfef6858, esp = 0xbfef6810
eax = 0xb37cc92c, ebx = 0xb63c32b8
ecx = 0x8000a654, edx = 0x800170b9
eip = 0xb37cad10

Memory Information
MemTotal:      250 KB
MemFree:       157 KB
Buffers:         3 KB
Cached:     166836 KB
VmPeak:     110772 KB
VmSize:     110772 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23876 KB
VmRSS:       23876 KB
VmData:      43864 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3890 TID = 3890
3890 3891 3922 3923 3941 

Maps Information
b2cb0000 b2cba000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cc0000 b2ccc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ccd000 b2cee000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cf3000 b2cf4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cf5000 b2cfa000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cfb000 b2cfd000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cfe000 b2d00000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d01000 b2d0d000 r-xp /usr/lib/libdrm.so.2.4.0
b2d0e000 b2d11000 r-xp /usr/lib/libdri2.so.0.0.0
b2d12000 b2d1c000 r-xp /usr/lib/libtbm.so.1.0.0
b2d23000 b2d24000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d25000 b2d26000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d27000 b2d2a000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d2b000 b2d2e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d2f000 b2d44000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d45000 b2d57000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3660000 b3666000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3667000 b37ab000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bb000 b37bc000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37bd000 b37be000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37bf000 b37c8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37c9000 b37cc000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b37cd000 b3806000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4209000 b4214000 r-xp /lib/libnss_files-2.20-2014.11.so
b4216000 b4221000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4223000 b423a000 r-xp /lib/libnsl-2.20-2014.11.so
b423e000 b4246000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4248000 b426c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b426d000 b426e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b426f000 b4272000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4273000 b427a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427b000 b4285000 r-xp /usr/lib/libsensord-share.so
b4286000 b42a2000 r-xp /usr/lib/libsensor.so.1.2.0
b42a4000 b42ad000 r-xp /usr/lib/libappcore-common.so.1.1
b42b0000 b42b2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c7000 b42c9000 r-xp /usr/lib/libXau.so.6.0.0
b42ca000 b42ec000 r-xp /usr/lib/libxcb.so.1.1.0
b42ee000 b42f7000 r-xp /lib/libcrypt-2.20-2014.11.so
b4320000 b4322000 r-xp /usr/lib/libiri.so
b4323000 b4349000 r-xp /lib/libexpat.so.1.5.2
b434b000 b43b6000 r-xp /usr/lib/libssl.so.1.0.0
b43bc000 b43c8000 r-xp /usr/lib/libethumb.so.1.13.0
b43c9000 b43cd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ce000 b461f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9a000 b5baa000 r-xp /usr/lib/libXi.so.6.1.0
b5bab000 b5bad000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bae000 b5bb4000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb5000 b5bbf000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc0000 b5bc9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcb000 b5bcd000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bce000 b5bd3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd4000 b5be6000 r-xp /usr/lib/libXext.so.6.4.0
b5be7000 b5be9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bea000 b5bec000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bee000 b5d30000 r-xp /usr/lib/libX11.so.6.3.0
b5d34000 b5d3e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d3f000 b5d55000 r-xp /usr/lib/libudev.so.1.6.0
b5d58000 b5d5c000 r-xp /lib/libattr.so.1.1.0
b5d5d000 b5d8c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d8e000 b5d94000 r-xp /usr/lib/libffi.so.6.0.2
b5d95000 b5db8000 r-xp /lib/libz.so.1.2.8
b5db9000 b5dbc000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dbd000 b5f19000 r-xp /usr/lib/libxml2.so.2.9.2
b5f1f000 b6006000 r-xp /usr/lib/libstdc++.so.6.0.20
b6013000 b6016000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6017000 b6039000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603a000 b604e000 r-xp /lib/libresolv-2.20-2014.11.so
b6052000 b6076000 r-xp /usr/lib/liblzma.so.5.0.3
b6077000 b6079000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607b000 b6085000 r-xp /usr/lib/libembryo.so.1.13.0
b6086000 b60af000 r-xp /usr/lib/libpng12.so.0.50.0
b60b0000 b60f9000 r-xp /usr/lib/libjpeg.so.8.0.2
b610a000 b6111000 r-xp /lib/librt-2.20-2014.11.so
b6113000 b6132000 r-xp /usr/lib/libector.so.1.13.0
b6135000 b6162000 r-xp /usr/lib/liblua-5.1.so
b6163000 b61f3000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f7000 b6235000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6236000 b624c000 r-xp /usr/lib/libfribidi.so.0.3.1
b624d000 b62a6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62a9000 b62f4000 r-xp /lib/libm-2.20-2014.11.so
b62f6000 b6308000 r-xp /usr/lib/libeio.so.1.13.0
b6309000 b630c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b630d000 b6313000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6314000 b6337000 r-xp /usr/lib/libefreet.so.1.13.0
b633a000 b6365000 r-xp /usr/lib/libeldbus.so.1.13.0
b6366000 b639a000 r-xp /usr/lib/libecore_con.so.1.13.0
b639c000 b63a5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a6000 b63af000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b0000 b63c3000 r-xp /usr/lib/libeo.so.1.13.0
b63c5000 b63d8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63d9000 b63e0000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e1000 b6404000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6405000 b6431000 r-xp /usr/lib/libeet.so.1.13.0
b643a000 b64a5000 r-xp /usr/lib/libeina.so.1.13.0
b64a8000 b64bf000 r-xp /usr/lib/libefl.so.1.13.0
b64c1000 b6628000 r-xp /usr/lib/libicuuc.so.51.1
b6636000 b6842000 r-xp /usr/lib/libicui18n.so.51.1
b684a000 b6899000 r-xp /usr/lib/libecore_x.so.1.13.0
b689b000 b68b5000 r-xp /lib/libgcc_s-4.9.so.1
b68b7000 b68bb000 r-xp /lib/libcap.so.2.21
b68bc000 b6902000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6903000 b690a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690c000 b695e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6960000 b6aeb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af0000 b6bbe000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc1000 b6bc5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc6000 b6bd5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd6000 b6bd9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bda000 b6bdd000 r-xp /usr/lib/libttrace.so.1.1
b6bdf000 b6be3000 r-xp /usr/lib/libiniparser.so.0
b6be4000 b6c14000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c15000 b6c1e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c1f000 b6c44000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c45000 b6c55000 r-xp /usr/lib/libunwind.so.8.0.1
b6c5f000 b6e0d000 r-xp /lib/libc-2.20-2014.11.so
b6e15000 b6f58000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5a000 b6fb2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb3000 b6fe7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fea000 b70be000 r-xp /usr/lib/libedje.so.1.13.0
b70c1000 b70ed000 r-xp /usr/lib/libecore.so.1.13.0
b70fe000 b7324000 r-xp /usr/lib/libevas.so.1.13.0
b734c000 b7364000 r-xp /lib/libpthread-2.20-2014.11.so
b7368000 b76e2000 r-xp /usr/lib/libelementary.so.1.13.0
b7702000 b7706000 r-xp /usr/lib/libsmack.so.1.0.0
b7707000 b7710000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7711000 b7714000 r-xp /usr/lib/libdlog.so.0.0.0
b7715000 b771a000 r-xp /usr/lib/libbundle.so.0.1.22
b771b000 b771e000 r-xp /lib/libdl-2.20-2014.11.so
b7720000 b7745000 r-xp /usr/lib/libaul.so.0.1.0
b7748000 b774a000 r-xp /usr/lib/libappsvc.so.0.1.0
b774b000 b7750000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7751000 b7758000 r-xp /usr/lib/libappcore-efl.so.1.1
b775a000 b775f000 r-xp /usr/lib/libsys-assert.so
b7762000 b7763000 r-xp [vdso]
b7763000 b7785000 r-xp /lib/ld-2.20-2014.11.so
b7787000 b778f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3890)
Call Stack Count: 21
 0: btn_login_cb + 0x30 (0xb37cad10) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1d10
 1: (0xb7187116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63be319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63bbd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71899e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb743a404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb706df39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7074a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb706efdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb706f4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb706f68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70d4702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70ce055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70d71b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70d7587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb753022d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7754dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb774dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x279 (0xb37ca469) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1469
19: popup_block_clicked + 0x18 (0xb7789148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7789148
20: __libc_start_main + 0xde (0xb6c76e4e) [/lib/libc.so.6] + 0x17e4e
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
ain_loop(490) > [SECURE_LOG] internal pool : false
10-11 21:19:56.114+0900 D/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-11 21:19:56.114+0900 D/AUL_PAD ( 2909): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-11 21:19:56.114+0900 D/AUL_PAD ( 2909): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-11 21:19:56.114+0900 W/AUL_PAD ( 2909): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-11 21:19:56.114+0900 D/AUL     ( 2909): process_pool.c: __send_pkt_raw_data(219) > send(12) : 876 / 876
10-11 21:19:56.114+0900 D/AUL_PAD ( 2909): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 3890, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:19:56.114+0900 W/AUL_PAD ( 2909): launchpad.c: __send_result_to_caller(265) > Check app launching
10-11 21:19:56.114+0900 D/AUL_PAD ( 2909): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 876, pkt->len: 868
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
10-11 21:19:56.114+0900 D/AUL     ( 3890): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3891) is sent.
10-11 21:19:56.114+0900 D/AUL     ( 3890): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3891, signo: 10
10-11 21:19:56.114+0900 D/AUL     ( 3890): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OAAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AEwAAAG9yZy5leGFtcGxlLnRpY2hhdAA=##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzYxODgzOTYvMTE3NDIwAA==##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODQ4AA==##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 14
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-11 21:19:56.114+0900 D/AUL_PAD ( 3890): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
10-11 21:19:56.114+0900 I/CAPI_APPFW_APPLICATION( 3890): app_main.c: ui_app_main(788) > app_efl_main
10-11 21:19:56.114+0900 D/LAUNCH  ( 3890): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
10-11 21:19:56.114+0900 D/APP_CORE( 3890): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-11 21:19:56.114+0900 D/APP_CORE( 3890): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
10-11 21:19:56.114+0900 D/APP_CORE( 3890): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-11 21:19:56.124+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20004e 
10-11 21:19:56.124+0900 D/APP_CORE( 3890): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-11 21:19:56.124+0900 D/AUL     ( 3890): app_sock.c: __create_server_sock(156) > pg path - already exists
10-11 21:19:56.124+0900 D/APP_CORE( 3890): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ad520
10-11 21:19:56.124+0900 D/LAUNCH  ( 3890): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
10-11 21:19:56.124+0900 I/CAPI_APPFW_APPLICATION( 3890): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-11 21:19:56.164+0900 D/LAUNCH  ( 3890): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
10-11 21:19:56.164+0900 E/E17     ( 2800): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x00e00002)
10-11 21:19:56.174+0900 D/APP_CORE( 3890): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-11 21:19:56.174+0900 E/E17     ( 2800): e_border.c: e_border_show(2088) > BD_SHOW(0x00e00002)
10-11 21:19:56.174+0900 W/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3890
10-11 21:19:56.184+0900 E/EFL     ( 2800): eo<2800> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-11 21:19:56.184+0900 E/EFL     ( 2800): eo<2800> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore.c: __aul_handler(587) > [APP 3890]     AUL event: AUL_START
10-11 21:19:56.194+0900 I/APP_CORE( 3890): appcore-efl.c: __do_app(496) > [APP 3890] Event: RESET State: CREATED
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore-efl.c: __do_app(527) > [APP 3890] RESET
10-11 21:19:56.194+0900 D/LAUNCH  ( 3890): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:19:56.194+0900 I/CAPI_APPFW_APPLICATION( 3890): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-11 21:19:56.194+0900 D/LAUNCH  ( 3890): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
10-11 21:19:56.194+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:19:56.194+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:19:56.194+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:19:56.194+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:19:56.194+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:19:56.194+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:19:56.194+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:19:56.194+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:19:56.194+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-11 21:19:56.194+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:19:56.194+0900 D/INDICATOR( 2839): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-11 21:19:56.194+0900 D/INDICATOR( 2839): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-11 21:19:56.194+0900 D/INDICATOR( 2839): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-11 21:19:56.194+0900 D/INDICATOR( 2839): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
10-11 21:19:56.194+0900 D/INDICATOR( 2839): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
10-11 21:19:56.194+0900 D/INDICATOR( 2839): main.c: _rotate_window(252) > port :: hide more icon
10-11 21:19:56.194+0900 W/APP_CORE( 3890): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:e00002
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:e00002
10-11 21:19:56.194+0900 D/APP_CORE( 3890): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-11 21:19:56.194+0900 D/AUL     ( 3890): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-11 21:19:56.214+0900 D/AUL_PAD ( 2909): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-11 21:19:56.214+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 3890, appid: org.example.tichat
10-11 21:19:56.214+0900 D/AUL     ( 2780): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-11 21:19:56.214+0900 E/AUL     ( 2780): simple_util.c: __trm_app_info_send_socket(330) > access
10-11 21:19:56.214+0900 D/AUL_AMD ( 2780): amd_launch.c: _start_app(2700) > add app group info
10-11 21:19:56.214+0900 E/AUL     ( 2780): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-11 21:19:56.214+0900 D/AUL_AMD ( 2780): amd_status.c: _status_add_app_info_list(427) > pid(3890) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
10-11 21:19:56.214+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 34
10-11 21:19:56.214+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 3890
10-11 21:19:56.214+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
10-11 21:19:56.214+0900 E/RESOURCED( 2836): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
10-11 21:19:56.214+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 15
10-11 21:19:56.214+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(888) > available memory = 803
10-11 21:19:56.214+0900 D/PKGMGR_INFO( 2780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-11 21:19:56.214+0900 D/PKGMGR_INFO( 2780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
10-11 21:19:56.214+0900 D/AUL_AMD ( 2780): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3890 is org.example.tichat
10-11 21:19:56.214+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3890 : 0
10-11 21:19:56.214+0900 D/AUL     ( 2848): launch.c: app_request_to_launchpad(425) > launch request result : 3890
10-11 21:19:56.214+0900 E/cluster-home( 2848): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.tichat]
10-11 21:19:56.214+0900 D/test-log( 2848): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
10-11 21:19:56.214+0900 D/AUL     ( 2924): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
10-11 21:19:56.334+0900 D/APP_CORE( 3890): appcore.c: __prt_ltime(236) > [APP 3890] first idle after reset: 233 msec
10-11 21:19:56.464+0900 E/E17     ( 2800): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:e00002 fully_obscured 0
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-11 21:19:56.464+0900 I/APP_CORE( 3890): appcore-efl.c: __do_app(496) > [APP 3890] Event: RESUME State: CREATED
10-11 21:19:56.464+0900 D/LAUNCH  ( 3890): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __do_app(607) > [APP 3890] RESUME
10-11 21:19:56.464+0900 D/APP_CORE( 2848): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-11 21:19:56.464+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-11 21:19:56.464+0900 D/APP_CORE( 2848): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-11 21:19:56.464+0900 I/APP_CORE( 2848): appcore-efl.c: __do_app(496) > [APP 2848] Event: PAUSE State: RUNNING
10-11 21:19:56.464+0900 D/APP_CORE( 2848): appcore-efl.c: __do_app(565) > [APP 2848] PAUSE
10-11 21:19:56.464+0900 I/CAPI_APPFW_APPLICATION( 2848): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-11 21:19:56.464+0900 E/cluster-home( 2848): homescreen.cpp: OnPause(84) >  app pause
10-11 21:19:56.464+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-11 21:19:56.464+0900 D/cluster-view( 2848): homescreen-view-manager.cpp: AppPause(923) >  END
10-11 21:19:56.464+0900 D/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-11 21:19:56.464+0900 E/APP_CORE( 2848): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-11 21:19:56.464+0900 I/APP_CORE( 3890): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-11 21:19:56.464+0900 I/APP_CORE( 3890): appcore-efl.c: __do_app(614) > [APP 3890] Initial Launching, call the resume_cb
10-11 21:19:56.464+0900 I/CAPI_APPFW_APPLICATION( 3890): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-11 21:19:56.464+0900 D/LAUNCH  ( 3890): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
10-11 21:19:56.464+0900 D/LAUNCH  ( 3890): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
10-11 21:19:56.464+0900 D/APP_CORE( 3890): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-11 21:19:56.464+0900 E/APP_CORE( 3890): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-11 21:19:56.474+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(2848) status(4)
10-11 21:19:56.474+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(468) > pid(2848) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-11 21:19:56.474+0900 D/AUL     ( 2780): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-11 21:19:56.474+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2848, appid: org.tizen.homescreen, status: bg
10-11 21:19:56.474+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2891) > pid(3890) status(3)
10-11 21:19:56.474+0900 D/AUL_AMD ( 2780): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
10-11 21:19:56.484+0900 D/DATA_PROVIDER_MASTER( 2911): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2848 is paused
10-11 21:19:56.484+0900 D/DATA_PROVIDER_MASTER( 2911): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-11 21:19:56.484+0900 I/CAPI_WIDGET_APPLICATION( 3007): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-11 21:19:56.484+0900 I/CAPI_WIDGET_APPLICATION( 3007): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-11 21:19:56.484+0900 W/AUL     ( 3007): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3007, appid: org.tizen.calendar.widget, status: bg
10-11 21:19:56.484+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3007, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-11 21:19:56.484+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3007
10-11 21:19:56.484+0900 D/RESOURCED( 2836): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3007, appname = org.tizen.calendar.widget
10-11 21:19:56.484+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3007
10-11 21:19:56.494+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2897) > back key ungrab
10-11 21:19:56.494+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(3890) status(3)
10-11 21:19:56.494+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(468) > pid(3890) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
10-11 21:19:56.494+0900 D/AUL     ( 2780): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
10-11 21:19:56.494+0900 W/AUL     ( 2780): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3890, appid: org.example.tichat, status: fg
10-11 21:19:56.494+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3890
10-11 21:19:56.494+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3890, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
10-11 21:19:56.494+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3890
10-11 21:19:56.534+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3890, appname = org.example.tichat, pkgname = org.example.tichat
10-11 21:19:56.534+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3890, appname = org.example.tichat
10-11 21:19:56.534+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3890
10-11 21:19:56.534+0900 I/RESOURCED( 2836): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-11 21:19:56.534+0900 I/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-11 21:19:56.564+0900 D/AUL_AMD ( 2780): amd_launch.c: __e17_status_handler(2910) > pid(3890) status(0)
10-11 21:19:57.214+0900 D/AUL_PAD ( 2909): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-11 21:19:57.214+0900 D/AUL_PAD ( 3940): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-11 21:19:57.224+0900 D/AUL_PAD ( 2909): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-11 21:19:57.234+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.234
10-11 21:19:57.274+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:19:57.294+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:19:57.294+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:19:57.714+0900 D/AUL_AMD ( 2780): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-11 21:19:57.714+0900 D/RUA     ( 2780): rua.c: rua_add_history(179) > rua_add_history start
10-11 21:19:57.714+0900 D/RUA     ( 2780): rua.c: rua_add_history(247) > rua_add_history ok
10-11 21:19:58.264+0900 D/AUL_PAD ( 3940): launchpad_loader.c: main(588) > sleeping 1 sec...
10-11 21:19:58.264+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-11 21:19:58.274+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0xe00002
10-11 21:19:58.274+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7c3a760
10-11 21:19:58.274+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(69) > get pre-initialization function
10-11 21:19:58.274+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(73) > get shutdown function
10-11 21:19:58.274+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7c3aa40
10-11 21:19:58.284+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7c3c640
10-11 21:19:58.284+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(69) > get pre-initialization function
10-11 21:19:58.284+0900 D/AUL_PAD ( 3940): preload.h: __preload_init(73) > get shutdown function
10-11 21:19:58.284+0900 D/AUL_PAD ( 3940): preexec.h: __preexec_init(76) > preexec start
10-11 21:19:58.284+0900 D/AUL_PAD ( 3940): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-11 21:19:58.284+0900 D/AUL     ( 3940): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-11 21:19:58.284+0900 D/AUL     ( 3940): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-11 21:19:58.284+0900 D/AUL     ( 3940): process_pool.c: __connect_to_launchpad(132) > send(3940) : 4
10-11 21:19:58.284+0900 D/AUL     ( 3940): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-11 21:19:58.284+0900 D/AUL_PAD ( 2909): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3940
10-11 21:19:58.344+0900 D/AUL_PAD ( 3940): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-11 21:19:58.344+0900 D/AUL_PAD ( 3940): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-11 21:19:58.344+0900 D/AUL_PAD ( 3940): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-11 21:19:58.344+0900 D/AUL_PAD ( 3940): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-11 21:19:58.484+0900 E/EFL     ( 3905): eldbus<3905> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-kwNvru8dIe: Connection refused
10-11 21:19:58.484+0900 E/EFL     ( 3905): <3905> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
10-11 21:19:58.484+0900 E/EFL     ( 3905): elementary<3905> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
10-11 21:19:58.484+0900 D/APP_CORE( 3905): appcore.c: __aul_handler(587) > [APP 3905]     AUL event: AUL_START
10-11 21:19:58.484+0900 I/APP_CORE( 3905): appcore-efl.c: __do_app(496) > [APP 3905] Event: RESET State: CREATED
10-11 21:19:58.484+0900 D/APP_CORE( 3905): appcore-efl.c: __do_app(527) > [APP 3905] RESET
10-11 21:19:58.484+0900 D/LAUNCH  ( 3905): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
10-11 21:19:58.484+0900 D/APP_CORE( 3905): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-11 21:19:58.484+0900 D/APP_CORE( 3905): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-11 21:19:58.484+0900 E/SYSPOPUP( 3905): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
10-11 21:19:58.484+0900 E/SYSPOPUP( 3905): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
10-11 21:19:58.484+0900 E/SYSPOPUP( 3905): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
10-11 21:19:58.484+0900 D/LAUNCH  ( 3905): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
10-11 21:19:58.484+0900 D/APP_CORE( 3905): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
10-11 21:19:58.524+0900 D/AUL     ( 3905): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
10-11 21:19:58.524+0900 D/AUL_AMD ( 2780): amd_request.c: __request_handler(838) > __request_handler: 22
10-11 21:19:58.524+0900 W/AUL_AMD ( 2780): amd_request.c: __request_handler(1056) > app status : 5
10-11 21:19:58.524+0900 D/AUL_AMD ( 2780): amd_status.c: _status_update_app_info_list(456) > pid(3905) status(5)
10-11 21:19:58.524+0900 D/APP_CORE( 3905): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
10-11 21:19:58.524+0900 E/EFL     ( 3905): eo<3905> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
10-11 21:19:58.524+0900 E/EFL     ( 3905): eo<3905> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
10-11 21:19:59.424+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:19:59.444+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:19:59.444+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 9:20 4 h"
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 9:20"
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 9&#x2236;20"
10-11 21:20:00.284+0900 D/INDICATOR( 2839): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146983470 Time: <font_size=33>9&#x2236;20</font_size> <font_size=32>PM</font_size></font>
10-11 21:20:00.574+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:01.494+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-11 21:20:01.494+0900 I/APP_CORE( 2848): appcore-efl.c: __do_app(496) > [APP 2848] Event: MEM_FLUSH State: PAUSED
10-11 21:20:01.494+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-11 21:20:01.494+0900 D/APP_CORE( 2848): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2848
10-11 21:20:01.494+0900 D/APP_CORE( 2848): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-11 21:20:01.494+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2848
10-11 21:20:01.544+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:02.424+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:02.454+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:20:02.454+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:03.324+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x200601 bd->visible=1
10-11 21:20:03.324+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:20:03.324+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:03.334+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:04.234+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:20:04.234+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:04.244+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:05.014+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:20:05.014+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:05.024+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:06.854+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:06.884+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p17';
10-11 21:20:06.884+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:09.304+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p17';
10-11 21:20:09.304+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:09.314+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:09.974+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p17';
10-11 21:20:09.974+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:09.984+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:10.264+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:20:10.264+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:20:10.264+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:20:10.264+0900 E/INDICATOR( 2839): 
10-11 21:20:10.404+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:10.893+0900 E/EFL     ( 3890): eo<3890> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:400: func 'edje_obj_data_get' (698) could not be resolved for class 'Elm_Layout'.
10-11 21:20:10.893+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:12.333+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p17';
10-11 21:20:12.333+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:20:12.333+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:13.153+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:13.703+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:13.903+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:14.113+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:14.303+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:20:15.303+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0xe00002
10-11 21:20:20.303+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x200601 bd->visible=1
10-11 21:20:30.283+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:20:30.283+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:20:30.283+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:20:30.283+0900 E/INDICATOR( 2839): 
10-11 21:20:42.983+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-11 21:20:42.983+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-11 21:20:42.983+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-11 21:20:42.983+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-11 21:20:42.983+0900 I/RESOURCED( 2836): logging.c: logging_save_to_storage(978) > storage cache is empty
10-11 21:20:50.303+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:20:50.303+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:20:50.303+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:20:50.303+0900 E/INDICATOR( 2839): 
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 9:21 4 h"
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 9:21"
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 9&#x2236;21"
10-11 21:21:00.293+0900 D/INDICATOR( 2839): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146981418 Time: <font_size=33>9&#x2236;21</font_size> <font_size=32>PM</font_size></font>
10-11 21:21:10.313+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:21:10.313+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:21:10.313+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:21:10.313+0900 E/INDICATOR( 2839): 
10-11 21:21:30.333+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:21:30.333+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:21:30.333+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:21:30.333+0900 E/INDICATOR( 2839): 
10-11 21:21:43.032+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-11 21:21:43.032+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-11 21:21:43.032+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-11 21:21:43.032+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-11 21:21:50.352+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:21:50.352+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:21:50.352+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:21:50.352+0900 E/INDICATOR( 2839): 
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 9:22 4 h"
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 9:22"
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 9&#x2236;22"
10-11 21:22:00.302+0900 D/INDICATOR( 2839): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146979366 Time: <font_size=33>9&#x2236;22</font_size> <font_size=32>PM</font_size></font>
10-11 21:22:10.362+0900 E/CAPI_NETWORK_WIFI( 2839): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-11 21:22:10.362+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
10-11 21:22:10.362+0900 E/INDICATOR( 2839): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-11 21:22:10.362+0900 E/INDICATOR( 2839): 
10-11 21:22:18.632+0900 D/QUICKPANEL( 2918): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(15)[Tue, October 11][1476188538]
10-11 21:22:18.632+0900 D/QUICKPANEL( 2918): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(4)[9:22][1476188538]
10-11 21:22:18.632+0900 D/QUICKPANEL( 2918): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(2)[PM][1476188538]
10-11 21:22:18.632+0900 D/QUICKPANEL( 2918): datetime.c: quickpanel_datetime_view_update(312) > [quickpanel_datetime_view_update : 312] update time: Tue, October 11 9&#x2236;22 PM
10-11 21:22:18.632+0900 I/QUICKPANEL( 2918): datetime.c: quickpanel_datetime_view_update(342) > DATE STR SET: <time>9&#x2236;22</> <ampm>PM</>
10-11 21:22:18.692+0900 E/EFL     ( 2800): <2800> e_mod_processmgr.c:481 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
10-11 21:22:18.722+0900 E/QUICKPANEL( 2918): quickpanel-ui.c: _ecore_event_client_message_cb(603) > [SECURE_LOG] [_ecore_event_client_message_cb : 603] quickpanel is opened
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): datetime.c: quickpanel_datetime_editing_icon_visibility_set(258) > [quickpanel_datetime_editing_icon_visibility_set : 258] visibility set:0
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): minictrl.c: _minictrl_opened(1155) > [_minictrl_opened : 1155] 
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): brightness.c: _qp_opened(716) > [_qp_opened : 716] quickpanel opened
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): activenoti.c: _activenoti_qp_opened(1586) > [_activenoti_qp_opened : 1586] 
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): activenoti.c: _activenoti_hide(185) > [_activenoti_hide : 185] delay : 0
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): activenoti.c: _activenoti_delete_current_noti(360) > [_activenoti_delete_current_noti : 360] There is no displaying notification
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): activenoti.c: _activenoti_hide(215) > [_activenoti_hide : 215] 
10-11 21:22:18.722+0900 E/QUICKPANEL( 2918): quickpanel-ui.c: _ecore_event_client_message_cb(579) > [SECURE_LOG] [_ecore_event_client_message_cb : 579] quickpanel is closed
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(15)[Tue, October 11][1476188538]
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(4)[9:22][1476188538]
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(2)[PM][1476188538]
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): datetime.c: quickpanel_datetime_view_update(312) > [quickpanel_datetime_view_update : 312] update time: Tue, October 11 9&#x2236;22 PM
10-11 21:22:18.722+0900 I/QUICKPANEL( 2918): datetime.c: quickpanel_datetime_view_update(342) > DATE STR SET: <time>9&#x2236;22</> <ampm>PM</>
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): datetime.c: quickpanel_datetime_editing_icon_visibility_set(258) > [quickpanel_datetime_editing_icon_visibility_set : 258] visibility set:0
10-11 21:22:18.722+0900 E/EFL     ( 2918): elementary<2918> elm_scroller.c:1141 elm_scroller_page_show() The object (0x8002c161) doesn't implement the Elementary scrollable interface
10-11 21:22:18.722+0900 D/QUICKPANEL( 2918): minictrl.c: _minictrl_closed(1161) > [_minictrl_closed : 1161] 
10-11 21:22:28.532+0900 E/EFL     ( 3890): edje<3890> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-11 21:22:28.532+0900 E/EFL     ( 3890): By the power of Grayskull, your previous Embryo stack is now broken!
10-11 21:22:28.542+0900 D/PROCESSMGR( 2800): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200601 
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-11 21:22:28.692+0900 D/AUL_PAD ( 2909): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-11 21:22:28.692+0900 I/AUL_PAD ( 2909): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 3890 pgid = 3890
10-11 21:22:28.692+0900 I/AUL_PAD ( 2909): sigchild.h: __sigchild_action(142) > dead_pid(3890)
10-11 21:22:28.702+0900 W/CRASH_MANAGER( 3943): worker.c: worker_job(1204) > 1103890746963147618854
