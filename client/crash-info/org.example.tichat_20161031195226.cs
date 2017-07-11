S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 5500
Date: 2016-10-31 19:52:26+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfdff6dc, esi = 0xb353442f
ebp = 0xbfdff738, esp = 0xbfdff5a0
eax = 0x00000031, ebx = 0xb3536cdc
ecx = 0x00000000, edx = 0x00000000
eip = 0xb352c0ac

Memory Information
MemTotal:      250 KB
MemFree:       153 KB
Buffers:         6 KB
Cached:     166324 KB
VmPeak:     117688 KB
VmSize:     112076 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31040 KB
VmRSS:       25588 KB
VmData:      43576 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5500 TID = 5500
5500 5502 5728 5729 5734 

Maps Information
b2ac5000 b2acc000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2acd000 b2ae5000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2ae6000 b2aed000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b6a000 b2b74000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b7a000 b2b86000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b87000 b2ba8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bad000 b2bae000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2baf000 b2bb4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bb5000 b2bb6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bb7000 b2bb9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bba000 b2bbc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bbd000 b2bc9000 r-xp /usr/lib/libdrm.so.2.4.0
b2bca000 b2bcd000 r-xp /usr/lib/libdri2.so.0.0.0
b2bce000 b2bd8000 r-xp /usr/lib/libtbm.so.1.0.0
b2bd9000 b2bda000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2bdb000 b2bf0000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bf1000 b2c03000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3405000 b3436000 r-xp /usr/lib/libidn.so.11.5.44
b3437000 b3459000 r-xp /usr/lib/libnghttp2.so.5.4.0
b345a000 b346a000 r-xp /usr/lib/libcares.so.2.1.0
b346b000 b348b000 r-xp /usr/lib/libnetwork.so.0.0.0
b348c000 b3495000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3496000 b350d000 r-xp /usr/lib/libcurl.so.4.3.0
b350f000 b3523000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b3524000 b3536000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b363e000 b3644000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3645000 b3789000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b379f000 b37a0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b37a1000 b37a2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b37a3000 b37a6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b37a7000 b37aa000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b37ab000 b37e4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41e7000 b41f2000 r-xp /lib/libnss_files-2.20-2014.11.so
b41f4000 b41ff000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4201000 b4218000 r-xp /lib/libnsl-2.20-2014.11.so
b421c000 b4224000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4226000 b424a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b424b000 b424c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b424d000 b4250000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4251000 b4258000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4259000 b4263000 r-xp /usr/lib/libsensord-share.so
b4264000 b4280000 r-xp /usr/lib/libsensor.so.1.2.0
b4282000 b428b000 r-xp /usr/lib/libappcore-common.so.1.1
b428e000 b4290000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42a5000 b42a7000 r-xp /usr/lib/libXau.so.6.0.0
b42a8000 b42ca000 r-xp /usr/lib/libxcb.so.1.1.0
b42cc000 b42d5000 r-xp /lib/libcrypt-2.20-2014.11.so
b42fe000 b4300000 r-xp /usr/lib/libiri.so
b4301000 b4327000 r-xp /lib/libexpat.so.1.5.2
b4329000 b4394000 r-xp /usr/lib/libssl.so.1.0.0
b439a000 b43a6000 r-xp /usr/lib/libethumb.so.1.13.0
b43a7000 b43ab000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ac000 b45fd000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b78000 b5b88000 r-xp /usr/lib/libXi.so.6.1.0
b5b89000 b5b8b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b8c000 b5b92000 r-xp /usr/lib/libXtst.so.6.1.0
b5b93000 b5b9d000 r-xp /usr/lib/libXrender.so.1.3.0
b5b9e000 b5ba7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5ba9000 b5bab000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bac000 b5bb1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bb2000 b5bc4000 r-xp /usr/lib/libXext.so.6.4.0
b5bc5000 b5bc7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bc8000 b5bca000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bcc000 b5d0e000 r-xp /usr/lib/libX11.so.6.3.0
b5d12000 b5d1c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d1d000 b5d33000 r-xp /usr/lib/libudev.so.1.6.0
b5d36000 b5d3a000 r-xp /lib/libattr.so.1.1.0
b5d3b000 b5d6a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d6c000 b5d72000 r-xp /usr/lib/libffi.so.6.0.2
b5d73000 b5d96000 r-xp /lib/libz.so.1.2.8
b5d97000 b5d9a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d9b000 b5ef7000 r-xp /usr/lib/libxml2.so.2.9.2
b5efd000 b5fe4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ff1000 b5ff4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ff5000 b6017000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6018000 b602c000 r-xp /lib/libresolv-2.20-2014.11.so
b6030000 b6054000 r-xp /usr/lib/liblzma.so.5.0.3
b6055000 b6057000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6059000 b6063000 r-xp /usr/lib/libembryo.so.1.13.0
b6064000 b608d000 r-xp /usr/lib/libpng12.so.0.50.0
b608e000 b60d7000 r-xp /usr/lib/libjpeg.so.8.0.2
b60e8000 b60ef000 r-xp /lib/librt-2.20-2014.11.so
b60f1000 b6110000 r-xp /usr/lib/libector.so.1.13.0
b6113000 b6140000 r-xp /usr/lib/liblua-5.1.so
b6141000 b61d1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61d5000 b6213000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6214000 b622a000 r-xp /usr/lib/libfribidi.so.0.3.1
b622b000 b6284000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6287000 b62d2000 r-xp /lib/libm-2.20-2014.11.so
b62d4000 b62e6000 r-xp /usr/lib/libeio.so.1.13.0
b62e7000 b62ea000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62eb000 b62f1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62f2000 b6315000 r-xp /usr/lib/libefreet.so.1.13.0
b6318000 b6343000 r-xp /usr/lib/libeldbus.so.1.13.0
b6344000 b6378000 r-xp /usr/lib/libecore_con.so.1.13.0
b637a000 b6383000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6384000 b638d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b638e000 b63a1000 r-xp /usr/lib/libeo.so.1.13.0
b63a3000 b63b6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63b7000 b63be000 r-xp /usr/lib/libecore_file.so.1.13.0
b63bf000 b63e2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63e3000 b640f000 r-xp /usr/lib/libeet.so.1.13.0
b6418000 b6483000 r-xp /usr/lib/libeina.so.1.13.0
b6486000 b649d000 r-xp /usr/lib/libefl.so.1.13.0
b649f000 b6606000 r-xp /usr/lib/libicuuc.so.51.1
b6614000 b6820000 r-xp /usr/lib/libicui18n.so.51.1
b6828000 b6877000 r-xp /usr/lib/libecore_x.so.1.13.0
b6879000 b6893000 r-xp /lib/libgcc_s-4.9.so.1
b6895000 b6899000 r-xp /lib/libcap.so.2.21
b689a000 b68e0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68e1000 b68e8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68ea000 b693c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b693e000 b6ac9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ace000 b6b9c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b9f000 b6ba3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6ba4000 b6bb3000 r-xp /usr/lib/libvconf.so.0.2.45
b6bb4000 b6bb7000 r-xp /usr/lib/libvasum.so.0.3.1
b6bb8000 b6bbb000 r-xp /usr/lib/libttrace.so.1.1
b6bbd000 b6bc1000 r-xp /usr/lib/libiniparser.so.0
b6bc2000 b6bf2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bf3000 b6bfc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bfd000 b6c22000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c23000 b6c33000 r-xp /usr/lib/libunwind.so.8.0.1
b6c3d000 b6deb000 r-xp /lib/libc-2.20-2014.11.so
b6df3000 b6f36000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f38000 b6f90000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f91000 b6fc5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fc8000 b709c000 r-xp /usr/lib/libedje.so.1.13.0
b709f000 b70cb000 r-xp /usr/lib/libecore.so.1.13.0
b70dc000 b7302000 r-xp /usr/lib/libevas.so.1.13.0
b732a000 b7342000 r-xp /lib/libpthread-2.20-2014.11.so
b7346000 b76c0000 r-xp /usr/lib/libelementary.so.1.13.0
b76e0000 b76e4000 r-xp /usr/lib/libsmack.so.1.0.0
b76e5000 b76ee000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ef000 b76f2000 r-xp /usr/lib/libdlog.so.0.0.0
b76f3000 b76f8000 r-xp /usr/lib/libbundle.so.0.1.22
b76f9000 b76fc000 r-xp /lib/libdl-2.20-2014.11.so
b76fe000 b7723000 r-xp /usr/lib/libaul.so.0.1.0
b7726000 b7728000 r-xp /usr/lib/libappsvc.so.0.1.0
b7729000 b772e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b772f000 b7736000 r-xp /usr/lib/libappcore-efl.so.1.1
b7738000 b773d000 r-xp /usr/lib/libsys-assert.so
b7740000 b7741000 r-xp [vdso]
b7741000 b7763000 r-xp /lib/ld-2.20-2014.11.so
b7765000 b776d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5500)
Call Stack Count: 15
 0: create_connection + 0x68c (0xb352c0ac) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x80ac
 1: enter_room + 0x5a (0xb352c22a) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x822a
 2: room_list_clicked_cb + 0x74 (0xb352ee24) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xae24
 3: (0xb74a61d0) [/usr/lib/libelementary.so.1] + 0x1601d0
 4: (0xb74a6315) [/usr/lib/libelementary.so.1] + 0x160315
 5: (0xb70ba370) [/usr/lib/libecore.so.1] + 0x1b370
 6: (0xb70ba4ff) [/usr/lib/libecore.so.1] + 0x1b4ff
 7: (0xb70b5061) [/usr/lib/libecore.so.1] + 0x16061
 8: ecore_main_loop_begin + 0x57 (0xb70b5587) [/usr/lib/libecore.so.1] + 0x16587
 9: elm_run + 0x2d (0xb750e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
10: appcore_efl_main + 0x4de (0xb7732dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
11: ui_app_main + 0x140 (0xb772bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
12: main + 0x278 (0xb3531908) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xd908
13: (0xb7767148) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0xb7767148
14: __libc_start_main + 0xde (0xb6c54e4e) [/lib/libc.so.6] + 0x17e4e
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
_signal(131) > send launch signal done
10-31 19:52:14.750+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.359
10-31 19:52:15.260+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
10-31 19:52:15.260+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
10-31 19:52:15.260+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
10-31 19:52:15.780+0900 D/AUL_PAD ( 5732): launchpad_loader.c: main(588) > sleeping 1 sec...
10-31 19:52:15.780+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-31 19:52:15.780+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b78af760
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(69) > get pre-initialization function
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(73) > get shutdown function
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b78afa40
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b78b1640
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(69) > get pre-initialization function
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preload.h: __preload_init(73) > get shutdown function
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): preexec.h: __preexec_init(76) > preexec start
10-31 19:52:15.790+0900 D/AUL_PAD ( 5732): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-31 19:52:15.790+0900 D/AUL     ( 5732): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-31 19:52:15.790+0900 D/AUL     ( 5732): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-31 19:52:15.790+0900 D/AUL     ( 5732): process_pool.c: __connect_to_launchpad(132) > send(5732) : 4
10-31 19:52:15.790+0900 D/AUL     ( 5732): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-31 19:52:15.790+0900 D/AUL_PAD ( 2902): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5732
10-31 19:52:15.790+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.360
10-31 19:52:15.850+0900 D/AUL_PAD ( 5732): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-31 19:52:15.850+0900 D/AUL_PAD ( 5732): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-31 19:52:15.850+0900 D/AUL_PAD ( 5732): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-31 19:52:15.850+0900 D/AUL_PAD ( 5732): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-31 19:52:15.910+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
10-31 19:52:15.910+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
10-31 19:52:15.910+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
10-31 19:52:15.910+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
10-31 19:52:16.760+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600db6 
10-31 19:52:16.760+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb87144f0. set autocapital type : 2
10-31 19:52:16.760+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
10-31 19:52:16.760+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 157c0027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
10-31 19:52:16.760+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb87144f0. on demand : 0
10-31 19:52:16.760+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 19:52:16.760+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 0
10-31 19:52:16.760+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb87144f0
10-31 19:52:16.760+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 19:52:17.120+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 1
10-31 19:52:17.120+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb87144f0, bidi direction : 0x1
10-31 19:52:17.190+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 2
10-31 19:52:17.270+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 3
10-31 19:52:17.370+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 4
10-31 19:52:17.600+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 5
10-31 19:52:17.750+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
10-31 19:52:17.790+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 6
10-31 19:52:17.940+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 7
10-31 19:52:18.020+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb87144f0, cursor pos : 8
10-31 19:52:18.120+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb87144f0
10-31 19:52:18.130+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-31 19:52:18.130+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb87144f0
10-31 19:52:18.130+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
10-31 19:52:18.130+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb874c4b8. set autocapital type : 0
10-31 19:52:18.130+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
10-31 19:52:18.130+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 157d0027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
10-31 19:52:18.130+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb874c4b8. on demand : 0
10-31 19:52:18.130+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-31 19:52:18.130+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 0
10-31 19:52:18.340+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 1
10-31 19:52:18.340+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb874c4b8, bidi direction : 0x1
10-31 19:52:18.430+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 2
10-31 19:52:18.580+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 3
10-31 19:52:18.640+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 4
10-31 19:52:18.730+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 5
10-31 19:52:18.820+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 6
10-31 19:52:18.970+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 7
10-31 19:52:19.060+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 8
10-31 19:52:19.160+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-31 19:52:19.160+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: MEM_FLUSH State: PAUSED
10-31 19:52:19.160+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-31 19:52:19.160+0900 D/APP_CORE( 2849): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2849
10-31 19:52:19.160+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-31 19:52:19.160+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2849
10-31 19:52:19.190+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb874c4b8, cursor pos : 9
10-31 19:52:20.060+0900 D/IMMODULE( 5500): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb874c4b8
10-31 19:52:20.060+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-31 19:52:20.060+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb874c4b8
10-31 19:52:20.060+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
10-31 19:52:20.060+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600db6 
10-31 19:52:20.100+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_create(408) > New handle created[0xb8730c98]
10-31 19:52:20.100+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_get_type(464) > Connected Network = 3
10-31 19:52:20.100+0900 I/tichat  ( 5500): Network connection type : 3
10-31 19:52:21.240+0900 I/tichat  ( 5500): CURL Returned: 
10-31 19:52:21.240+0900 I/tichat  ( 5500): {"message":"로그인 성공"}
10-31 19:52:21.240+0900 I/tichat  ( 5500): Parsed JSON: "로그인 성공"
10-31 19:52:21.250+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_destroy(426) > Destroy handle: 0xb8730c98
10-31 19:52:21.270+0900 D/IMMODULE( 5500): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-31 19:52:21.270+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
10-31 19:52:22.760+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x600db6 bd->visible=1
10-31 19:52:24.880+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600db6 
10-31 19:52:25.020+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_create(408) > New handle created[0xb886a0d0]
10-31 19:52:25.020+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_get_type(464) > Connected Network = 3
10-31 19:52:25.020+0900 I/tichat  ( 5500): Network connection type : 3
10-31 19:52:25.660+0900 I/tichat  ( 5500): CURL Returned: 
10-31 19:52:25.660+0900 I/tichat  ( 5500): [{"id":1,"title":"new room","participant":0,"createdAt":"2016-10-31T09:08:36.056Z","updatedAt":"2016-10-31T09:08:36.056Z"},{"id":2,"title":"asdfsdf","participant":0,"createdAt":"2016-10-31T09:56:54.496Z","updatedAt":"2016-10-31T09:56:54.496Z"}]
10-31 19:52:25.660+0900 I/tichat  ( 5500): Parsed JSON: (null)
10-31 19:52:25.660+0900 I/tichat  ( 5500): 1's title: "asdfsdf"
10-31 19:52:25.660+0900 I/tichat  ( 5500): 0's title: "new room"
10-31 19:52:25.660+0900 I/tichat  ( 5500): JSON: [{"id":1,"title":"new room","participant":0,"createdAt":"2016-10-31T09:08:36.056Z","updatedAt":"2016-10-31T09:08:36.056Z"},{"id":2,"title":"asdfsdf","participant":0,"createdAt":"2016-10-31T09:56:54.496Z","updatedAt":"2016-10-31T09:56:54.496Z"}]
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.680+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.690+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.700+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.710+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.720+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.730+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.740+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.750+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:25.760+0900 E/EFL     ( 5500): evas_main<5500> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800c8446 is not stable during recalc loop
10-31 19:52:26.850+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600db6 
10-31 19:52:26.930+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_create(408) > New handle created[0xb878dac0]
10-31 19:52:26.930+0900 I/CAPI_NETWORK_CONNECTION( 5500): connection.c: connection_get_type(464) > Connected Network = 3
10-31 19:52:26.930+0900 I/tichat  ( 5500): IPv6 address: fec0::5054:ff:fe12:3456
10-31 19:52:26.930+0900 I/tichat  ( 5500): IPv4 address: 10.0.2.15
10-31 19:52:26.930+0900 I/tichat  ( 5500): Interface Name: eth0
10-31 19:52:26.930+0900 I/tichat  ( 5500): IPv4
10-31 19:52:26.930+0900 I/tichat  ( 5500): socket open success
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-31 19:52:26.960+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-31 19:52:26.960+0900 I/AUL_PAD ( 2902): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 5500 pgid = 5500
10-31 19:52:26.960+0900 I/AUL_PAD ( 2902): sigchild.h: __sigchild_action(142) > dead_pid(5500)
10-31 19:52:26.980+0900 W/CRASH_MANAGER( 5735): worker.c: worker_job(1204) > 1105500746963147791114
