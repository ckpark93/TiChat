S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 6151
Date: 2016-10-31 19:54:16+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfef177c, esi = 0xb34e1e75
ebp = 0xbfef17d8, esp = 0xbfef1640
eax = 0x0000001d, ebx = 0xb34e4cf0
ecx = 0x00000031, edx = 0x00000000
eip = 0xb34da0df

Memory Information
MemTotal:      250 KB
MemFree:       152 KB
Buffers:         6 KB
Cached:     166680 KB
VmPeak:     117688 KB
VmSize:     112076 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31056 KB
VmRSS:       25600 KB
VmData:      43576 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6151 TID = 6151
6151 6152 6377 6378 6382 

Maps Information
b2a73000 b2a7a000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2a7b000 b2a93000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2a94000 b2a9b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b18000 b2b22000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b28000 b2b34000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b35000 b2b56000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b5b000 b2b5c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b5d000 b2b62000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b63000 b2b64000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b65000 b2b67000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b68000 b2b6a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b6b000 b2b77000 r-xp /usr/lib/libdrm.so.2.4.0
b2b78000 b2b7b000 r-xp /usr/lib/libdri2.so.0.0.0
b2b7c000 b2b86000 r-xp /usr/lib/libtbm.so.1.0.0
b2b87000 b2b88000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b89000 b2b9e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b9f000 b2bb1000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33b3000 b33e4000 r-xp /usr/lib/libidn.so.11.5.44
b33e5000 b3407000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3408000 b3418000 r-xp /usr/lib/libcares.so.2.1.0
b3419000 b3439000 r-xp /usr/lib/libnetwork.so.0.0.0
b343a000 b3443000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3444000 b34bb000 r-xp /usr/lib/libcurl.so.4.3.0
b34bd000 b34d1000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34d2000 b34e4000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b35ec000 b35f2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f3000 b3737000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b374d000 b374e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b374f000 b3750000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3751000 b3754000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3755000 b3758000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3759000 b3792000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4195000 b41a0000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a2000 b41ad000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41af000 b41c6000 r-xp /lib/libnsl-2.20-2014.11.so
b41ca000 b41d2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d4000 b41f8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f9000 b41fa000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41fb000 b41fe000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41ff000 b4206000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4207000 b4211000 r-xp /usr/lib/libsensord-share.so
b4212000 b422e000 r-xp /usr/lib/libsensor.so.1.2.0
b4230000 b4239000 r-xp /usr/lib/libappcore-common.so.1.1
b423c000 b423e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4253000 b4255000 r-xp /usr/lib/libXau.so.6.0.0
b4256000 b4278000 r-xp /usr/lib/libxcb.so.1.1.0
b427a000 b4283000 r-xp /lib/libcrypt-2.20-2014.11.so
b42ac000 b42ae000 r-xp /usr/lib/libiri.so
b42af000 b42d5000 r-xp /lib/libexpat.so.1.5.2
b42d7000 b4342000 r-xp /usr/lib/libssl.so.1.0.0
b4348000 b4354000 r-xp /usr/lib/libethumb.so.1.13.0
b4355000 b4359000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b435a000 b45ab000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b26000 b5b36000 r-xp /usr/lib/libXi.so.6.1.0
b5b37000 b5b39000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b3a000 b5b40000 r-xp /usr/lib/libXtst.so.6.1.0
b5b41000 b5b4b000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4c000 b5b55000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b57000 b5b59000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b5a000 b5b5f000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b60000 b5b72000 r-xp /usr/lib/libXext.so.6.4.0
b5b73000 b5b75000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b76000 b5b78000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b7a000 b5cbc000 r-xp /usr/lib/libX11.so.6.3.0
b5cc0000 b5cca000 r-xp /usr/lib/libXcursor.so.1.0.2
b5ccb000 b5ce1000 r-xp /usr/lib/libudev.so.1.6.0
b5ce4000 b5ce8000 r-xp /lib/libattr.so.1.1.0
b5ce9000 b5d18000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d1a000 b5d20000 r-xp /usr/lib/libffi.so.6.0.2
b5d21000 b5d44000 r-xp /lib/libz.so.1.2.8
b5d45000 b5d48000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d49000 b5ea5000 r-xp /usr/lib/libxml2.so.2.9.2
b5eab000 b5f92000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9f000 b5fa2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa3000 b5fc5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc6000 b5fda000 r-xp /lib/libresolv-2.20-2014.11.so
b5fde000 b6002000 r-xp /usr/lib/liblzma.so.5.0.3
b6003000 b6005000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6007000 b6011000 r-xp /usr/lib/libembryo.so.1.13.0
b6012000 b603b000 r-xp /usr/lib/libpng12.so.0.50.0
b603c000 b6085000 r-xp /usr/lib/libjpeg.so.8.0.2
b6096000 b609d000 r-xp /lib/librt-2.20-2014.11.so
b609f000 b60be000 r-xp /usr/lib/libector.so.1.13.0
b60c1000 b60ee000 r-xp /usr/lib/liblua-5.1.so
b60ef000 b617f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6183000 b61c1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c2000 b61d8000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d9000 b6232000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6235000 b6280000 r-xp /lib/libm-2.20-2014.11.so
b6282000 b6294000 r-xp /usr/lib/libeio.so.1.13.0
b6295000 b6298000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6299000 b629f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62a0000 b62c3000 r-xp /usr/lib/libefreet.so.1.13.0
b62c6000 b62f1000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f2000 b6326000 r-xp /usr/lib/libecore_con.so.1.13.0
b6328000 b6331000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6332000 b633b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633c000 b634f000 r-xp /usr/lib/libeo.so.1.13.0
b6351000 b6364000 r-xp /usr/lib/libecore_input.so.1.13.0
b6365000 b636c000 r-xp /usr/lib/libecore_file.so.1.13.0
b636d000 b6390000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6391000 b63bd000 r-xp /usr/lib/libeet.so.1.13.0
b63c6000 b6431000 r-xp /usr/lib/libeina.so.1.13.0
b6434000 b644b000 r-xp /usr/lib/libefl.so.1.13.0
b644d000 b65b4000 r-xp /usr/lib/libicuuc.so.51.1
b65c2000 b67ce000 r-xp /usr/lib/libicui18n.so.51.1
b67d6000 b6825000 r-xp /usr/lib/libecore_x.so.1.13.0
b6827000 b6841000 r-xp /lib/libgcc_s-4.9.so.1
b6843000 b6847000 r-xp /lib/libcap.so.2.21
b6848000 b688e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688f000 b6896000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6898000 b68ea000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68ec000 b6a77000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7c000 b6b4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b4d000 b6b51000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b52000 b6b61000 r-xp /usr/lib/libvconf.so.0.2.45
b6b62000 b6b65000 r-xp /usr/lib/libvasum.so.0.3.1
b6b66000 b6b69000 r-xp /usr/lib/libttrace.so.1.1
b6b6b000 b6b6f000 r-xp /usr/lib/libiniparser.so.0
b6b70000 b6ba0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba1000 b6baa000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bab000 b6bd0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd1000 b6be1000 r-xp /usr/lib/libunwind.so.8.0.1
b6beb000 b6d99000 r-xp /lib/libc-2.20-2014.11.so
b6da1000 b6ee4000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee6000 b6f3e000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3f000 b6f73000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f76000 b704a000 r-xp /usr/lib/libedje.so.1.13.0
b704d000 b7079000 r-xp /usr/lib/libecore.so.1.13.0
b708a000 b72b0000 r-xp /usr/lib/libevas.so.1.13.0
b72d8000 b72f0000 r-xp /lib/libpthread-2.20-2014.11.so
b72f4000 b766e000 r-xp /usr/lib/libelementary.so.1.13.0
b768e000 b7692000 r-xp /usr/lib/libsmack.so.1.0.0
b7693000 b769c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b769d000 b76a0000 r-xp /usr/lib/libdlog.so.0.0.0
b76a1000 b76a6000 r-xp /usr/lib/libbundle.so.0.1.22
b76a7000 b76aa000 r-xp /lib/libdl-2.20-2014.11.so
b76ac000 b76d1000 r-xp /usr/lib/libaul.so.0.1.0
b76d4000 b76d6000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d7000 b76dc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76dd000 b76e4000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e6000 b76eb000 r-xp /usr/lib/libsys-assert.so
b76ee000 b76ef000 r-xp [vdso]
b76ef000 b7711000 r-xp /lib/ld-2.20-2014.11.so
b7713000 b771b000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6151)
Call Stack Count: 15
 0: create_connection + 0x6bf (0xb34da0df) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x80df
 1: enter_room + 0x5a (0xb34da24a) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x824a
 2: room_list_clicked_cb + 0x74 (0xb34dce44) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xae44
 3: (0xb74541d0) [/usr/lib/libelementary.so.1] + 0x1601d0
 4: (0xb7454315) [/usr/lib/libelementary.so.1] + 0x160315
 5: (0xb7068370) [/usr/lib/libecore.so.1] + 0x1b370
 6: (0xb70684ff) [/usr/lib/libecore.so.1] + 0x1b4ff
 7: (0xb7063061) [/usr/lib/libecore.so.1] + 0x16061
 8: ecore_main_loop_begin + 0x57 (0xb7063587) [/usr/lib/libecore.so.1] + 0x16587
 9: elm_run + 0x2d (0xb74bc22d) [/usr/lib/libelementary.so.1] + 0x1c822d
10: appcore_efl_main + 0x4de (0xb76e0dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
11: ui_app_main + 0x140 (0xb76d9c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
12: main + 0x278 (0xb34df928) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xd928
13: (0xb7715148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7715148
14: __libc_start_main + 0xde (0xb6c02e4e) [/lib/libc.so.6] + 0x17e4e
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
) status(0)
10-31 19:54:07.059+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
10-31 19:54:07.059+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
10-31 19:54:07.059+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
10-31 19:54:07.059+0900 E/INDICATOR( 2842): 
10-31 19:54:07.149+0900 D/AUL_PAD ( 2902): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-31 19:54:07.149+0900 D/AUL_PAD ( 6380): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-31 19:54:07.159+0900 D/AUL_PAD ( 2902): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-31 19:54:07.159+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.407
10-31 19:54:07.649+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-31 19:54:07.649+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
10-31 19:54:07.659+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
10-31 19:54:08.179+0900 D/AUL_PAD ( 6380): launchpad_loader.c: main(588) > sleeping 1 sec...
10-31 19:54:08.179+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-31 19:54:08.179+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b96bf760
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(69) > get pre-initialization function
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(73) > get shutdown function
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b96bfa40
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b96c1640
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(69) > get pre-initialization function
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preload.h: __preload_init(73) > get shutdown function
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): preexec.h: __preexec_init(76) > preexec start
10-31 19:54:08.189+0900 D/AUL_PAD ( 6380): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-31 19:54:08.189+0900 D/AUL     ( 6380): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-31 19:54:08.189+0900 D/AUL     ( 6380): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-31 19:54:08.189+0900 D/AUL     ( 6380): process_pool.c: __connect_to_launchpad(132) > send(6380) : 4
10-31 19:54:08.189+0900 D/AUL     ( 6380): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-31 19:54:08.189+0900 D/AUL_PAD ( 2902): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6380
10-31 19:54:08.299+0900 D/AUL_PAD ( 6380): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-31 19:54:08.319+0900 D/AUL_PAD ( 6380): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-31 19:54:08.319+0900 D/AUL_PAD ( 6380): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-31 19:54:08.319+0900 D/AUL_PAD ( 6380): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-31 19:54:09.209+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600f72 
10-31 19:54:09.219+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9872ba8. set autocapital type : 2
10-31 19:54:09.219+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9872ba8. on demand : 0
10-31 19:54:09.219+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
10-31 19:54:09.219+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 18070027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
10-31 19:54:09.219+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 19:54:09.219+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 0
10-31 19:54:09.219+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb9872ba8
10-31 19:54:09.219+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 19:54:09.789+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 1
10-31 19:54:09.789+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb9872ba8, bidi direction : 0x1
10-31 19:54:09.849+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 2
10-31 19:54:09.939+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 3
10-31 19:54:10.059+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 4
10-31 19:54:10.209+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
10-31 19:54:10.299+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 5
10-31 19:54:10.479+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 6
10-31 19:54:10.659+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 7
10-31 19:54:10.699+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9872ba8, cursor pos : 8
10-31 19:54:10.819+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9872ba8
10-31 19:54:10.819+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-31 19:54:10.819+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9872ba8
10-31 19:54:10.819+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
10-31 19:54:10.829+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb98c1cc8. set autocapital type : 0
10-31 19:54:10.829+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
10-31 19:54:10.829+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 18080027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
10-31 19:54:10.829+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb98c1cc8. on demand : 0
10-31 19:54:10.829+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 19:54:10.829+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 0
10-31 19:54:10.999+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 1
10-31 19:54:10.999+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb98c1cc8, bidi direction : 0x1
10-31 19:54:11.119+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 2
10-31 19:54:11.239+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 3
10-31 19:54:11.339+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 4
10-31 19:54:11.399+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 5
10-31 19:54:11.439+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-31 19:54:11.439+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: MEM_FLUSH State: PAUSED
10-31 19:54:11.439+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-31 19:54:11.439+0900 D/APP_CORE( 2849): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2849
10-31 19:54:11.439+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-31 19:54:11.439+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2849
10-31 19:54:11.519+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 6
10-31 19:54:11.669+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 7
10-31 19:54:11.759+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 8
10-31 19:54:11.879+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98c1cc8, cursor pos : 9
10-31 19:54:12.859+0900 D/IMMODULE( 6151): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb98c1cc8
10-31 19:54:12.859+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-31 19:54:12.859+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb98c1cc8
10-31 19:54:12.869+0900 E/EFL     ( 6151): edje<6151> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
10-31 19:54:12.869+0900 E/EFL     ( 6151): By the power of Grayskull, your previous Embryo stack is now broken!
10-31 19:54:12.869+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
10-31 19:54:12.869+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600f72 
10-31 19:54:12.939+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_create(408) > New handle created[0xb98c9fa8]
10-31 19:54:12.949+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_get_type(464) > Connected Network = 3
10-31 19:54:12.949+0900 I/tichat  ( 6151): Network connection type : 3
10-31 19:54:13.589+0900 I/tichat  ( 6151): CURL Returned: 
10-31 19:54:13.589+0900 I/tichat  ( 6151): {"message":"로그인 성공"}
10-31 19:54:13.589+0900 I/tichat  ( 6151): Parsed JSON: "로그인 성공"
10-31 19:54:13.609+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_destroy(426) > Destroy handle: 0xb98c9fa8
10-31 19:54:13.609+0900 D/IMMODULE( 6151): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-31 19:54:13.609+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
10-31 19:54:14.919+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600f72 
10-31 19:54:15.059+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_create(408) > New handle created[0xb99de310]
10-31 19:54:15.059+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_get_type(464) > Connected Network = 3
10-31 19:54:15.059+0900 I/tichat  ( 6151): Network connection type : 3
10-31 19:54:15.209+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x600f72 bd->visible=1
10-31 19:54:15.679+0900 I/tichat  ( 6151): CURL Returned: 
10-31 19:54:15.679+0900 I/tichat  ( 6151): [{"id":1,"title":"new room","participant":0,"createdAt":"2016-10-31T09:08:36.056Z","updatedAt":"2016-10-31T09:08:36.056Z"},{"id":2,"title":"asdfsdf","participant":0,"createdAt":"2016-10-31T09:56:54.496Z","updatedAt":"2016-10-31T09:56:54.496Z"}]
10-31 19:54:15.679+0900 I/tichat  ( 6151): Parsed JSON: (null)
10-31 19:54:15.679+0900 I/tichat  ( 6151): 1's title: "asdfsdf"
10-31 19:54:15.679+0900 I/tichat  ( 6151): 0's title: "new room"
10-31 19:54:15.679+0900 I/tichat  ( 6151): JSON: [{"id":1,"title":"new room","participant":0,"createdAt":"2016-10-31T09:08:36.056Z","updatedAt":"2016-10-31T09:08:36.056Z"},{"id":2,"title":"asdfsdf","participant":0,"createdAt":"2016-10-31T09:56:54.496Z","updatedAt":"2016-10-31T09:56:54.496Z"}]
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.709+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.719+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.729+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.739+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.749+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.759+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.769+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.779+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.789+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.799+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.809+0900 E/EFL     ( 6151): evas_main<6151> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c7a41 is not stable during recalc loop
10-31 19:54:15.919+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-31 19:54:15.919+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-31 19:54:15.919+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-31 19:54:15.919+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-31 19:54:16.409+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600f72 
10-31 19:54:16.499+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_create(408) > New handle created[0xb99a5418]
10-31 19:54:16.499+0900 I/CAPI_NETWORK_CONNECTION( 6151): connection.c: connection_get_type(464) > Connected Network = 3
10-31 19:54:16.499+0900 I/tichat  ( 6151): IPv6 address: fec0::5054:ff:fe12:3456
10-31 19:54:16.499+0900 I/tichat  ( 6151): IPv4 address: 10.0.2.15
10-31 19:54:16.499+0900 I/tichat  ( 6151): Interface Name: eth0
10-31 19:54:16.499+0900 I/tichat  ( 6151): IPv4
10-31 19:54:16.499+0900 I/tichat  ( 6151): socket open success
10-31 19:54:16.499+0900 I/tichat  ( 6151): socket open success2
10-31 19:54:16.519+0900 W/CRASH_MANAGER( 6154): worker.c: worker_job(1204) > 1106151746963147791125
