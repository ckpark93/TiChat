S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 18679
Date: 2016-11-01 17:19:42+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb350e07b, esi = 0xb0cdaf10
ebp = 0xb0cdb0a8, esp = 0xb0cdaf0c
eax = 0xb350dc8f, ebx = 0xb3510964
ecx = 0x00000072, edx = 0x00000000
eip = 0xb6d48c0b

Memory Information
MemTotal:      250 KB
MemFree:       118 KB
Buffers:        10 KB
Cached:     197240 KB
VmPeak:     128148 KB
VmSize:     122252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31932 KB
VmRSS:       25944 KB
VmData:      52032 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 18679 TID = 18911
18679 18681 18904 18905 18910 18911 

Maps Information
b2a9f000 b2aa6000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2aa7000 b2abf000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2ac0000 b2ac7000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b44000 b2b4e000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b54000 b2b60000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b61000 b2b82000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b87000 b2b88000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b89000 b2b8e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b8f000 b2b90000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b91000 b2b93000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b94000 b2b96000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b97000 b2ba3000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba4000 b2ba7000 r-xp /usr/lib/libdri2.so.0.0.0
b2ba8000 b2bb2000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb3000 b2bb4000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2bb5000 b2bca000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bcb000 b2bdd000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33df000 b3410000 r-xp /usr/lib/libidn.so.11.5.44
b3411000 b3433000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3434000 b3444000 r-xp /usr/lib/libcares.so.2.1.0
b3445000 b3465000 r-xp /usr/lib/libnetwork.so.0.0.0
b3466000 b346f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3470000 b34e7000 r-xp /usr/lib/libcurl.so.4.3.0
b34e9000 b34fd000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34fe000 b3510000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b3618000 b361e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b361f000 b3763000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3779000 b377a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b377b000 b377c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b377d000 b3780000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3781000 b3784000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3785000 b37be000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c1000 b41cc000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ce000 b41d9000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41db000 b41f2000 r-xp /lib/libnsl-2.20-2014.11.so
b41f6000 b41fe000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4200000 b4224000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4225000 b4226000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4227000 b422a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b422b000 b4232000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4233000 b423d000 r-xp /usr/lib/libsensord-share.so
b423e000 b425a000 r-xp /usr/lib/libsensor.so.1.2.0
b425c000 b4265000 r-xp /usr/lib/libappcore-common.so.1.1
b4268000 b426a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b427f000 b4281000 r-xp /usr/lib/libXau.so.6.0.0
b4282000 b42a4000 r-xp /usr/lib/libxcb.so.1.1.0
b42a6000 b42af000 r-xp /lib/libcrypt-2.20-2014.11.so
b42d8000 b42da000 r-xp /usr/lib/libiri.so
b42db000 b4301000 r-xp /lib/libexpat.so.1.5.2
b4303000 b436e000 r-xp /usr/lib/libssl.so.1.0.0
b4374000 b4380000 r-xp /usr/lib/libethumb.so.1.13.0
b4381000 b4385000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4386000 b45d7000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b52000 b5b62000 r-xp /usr/lib/libXi.so.6.1.0
b5b63000 b5b65000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b66000 b5b6c000 r-xp /usr/lib/libXtst.so.6.1.0
b5b6d000 b5b77000 r-xp /usr/lib/libXrender.so.1.3.0
b5b78000 b5b81000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b83000 b5b85000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b86000 b5b8b000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b8c000 b5b9e000 r-xp /usr/lib/libXext.so.6.4.0
b5b9f000 b5ba1000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba2000 b5ba4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5ba6000 b5ce8000 r-xp /usr/lib/libX11.so.6.3.0
b5cec000 b5cf6000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cf7000 b5d0d000 r-xp /usr/lib/libudev.so.1.6.0
b5d10000 b5d14000 r-xp /lib/libattr.so.1.1.0
b5d15000 b5d44000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d46000 b5d4c000 r-xp /usr/lib/libffi.so.6.0.2
b5d4d000 b5d70000 r-xp /lib/libz.so.1.2.8
b5d71000 b5d74000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d75000 b5ed1000 r-xp /usr/lib/libxml2.so.2.9.2
b5ed7000 b5fbe000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fcb000 b5fce000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fcf000 b5ff1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff2000 b6006000 r-xp /lib/libresolv-2.20-2014.11.so
b600a000 b602e000 r-xp /usr/lib/liblzma.so.5.0.3
b602f000 b6031000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6033000 b603d000 r-xp /usr/lib/libembryo.so.1.13.0
b603e000 b6067000 r-xp /usr/lib/libpng12.so.0.50.0
b6068000 b60b1000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c2000 b60c9000 r-xp /lib/librt-2.20-2014.11.so
b60cb000 b60ea000 r-xp /usr/lib/libector.so.1.13.0
b60ed000 b611a000 r-xp /usr/lib/liblua-5.1.so
b611b000 b61ab000 r-xp /usr/lib/libfreetype.so.6.11.3
b61af000 b61ed000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ee000 b6204000 r-xp /usr/lib/libfribidi.so.0.3.1
b6205000 b625e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6261000 b62ac000 r-xp /lib/libm-2.20-2014.11.so
b62ae000 b62c0000 r-xp /usr/lib/libeio.so.1.13.0
b62c1000 b62c4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62c5000 b62cb000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62cc000 b62ef000 r-xp /usr/lib/libefreet.so.1.13.0
b62f2000 b631d000 r-xp /usr/lib/libeldbus.so.1.13.0
b631e000 b6352000 r-xp /usr/lib/libecore_con.so.1.13.0
b6354000 b635d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b635e000 b6367000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6368000 b637b000 r-xp /usr/lib/libeo.so.1.13.0
b637d000 b6390000 r-xp /usr/lib/libecore_input.so.1.13.0
b6391000 b6398000 r-xp /usr/lib/libecore_file.so.1.13.0
b6399000 b63bc000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63bd000 b63e9000 r-xp /usr/lib/libeet.so.1.13.0
b63f2000 b645d000 r-xp /usr/lib/libeina.so.1.13.0
b6460000 b6477000 r-xp /usr/lib/libefl.so.1.13.0
b6479000 b65e0000 r-xp /usr/lib/libicuuc.so.51.1
b65ee000 b67fa000 r-xp /usr/lib/libicui18n.so.51.1
b6802000 b6851000 r-xp /usr/lib/libecore_x.so.1.13.0
b6853000 b686d000 r-xp /lib/libgcc_s-4.9.so.1
b686f000 b6873000 r-xp /lib/libcap.so.2.21
b6874000 b68ba000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68bb000 b68c2000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c4000 b6916000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6918000 b6aa3000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aa8000 b6b76000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b79000 b6b7d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b7e000 b6b8d000 r-xp /usr/lib/libvconf.so.0.2.45
b6b8e000 b6b91000 r-xp /usr/lib/libvasum.so.0.3.1
b6b92000 b6b95000 r-xp /usr/lib/libttrace.so.1.1
b6b97000 b6b9b000 r-xp /usr/lib/libiniparser.so.0
b6b9c000 b6bcc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bcd000 b6bd6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd7000 b6bfc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bfd000 b6c0d000 r-xp /usr/lib/libunwind.so.8.0.1
b6c17000 b6dc5000 r-xp /lib/libc-2.20-2014.11.so
b6dcd000 b6f10000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f12000 b6f6a000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f6b000 b6f9f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa2000 b7076000 r-xp /usr/lib/libedje.so.1.13.0
b7079000 b70a5000 r-xp /usr/lib/libecore.so.1.13.0
b70b6000 b72dc000 r-xp /usr/lib/libevas.so.1.13.0
b7304000 b731c000 r-xp /lib/libpthread-2.20-2014.11.so
b7320000 b769a000 r-xp /usr/lib/libelementary.so.1.13.0
b76ba000 b76be000 r-xp /usr/lib/libsmack.so.1.0.0
b76bf000 b76c8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76c9000 b76cc000 r-xp /usr/lib/libdlog.so.0.0.0
b76cd000 b76d2000 r-xp /usr/lib/libbundle.so.0.1.22
b76d3000 b76d6000 r-xp /lib/libdl-2.20-2014.11.so
b76d8000 b76fd000 r-xp /usr/lib/libaul.so.0.1.0
b7700000 b7702000 r-xp /usr/lib/libappsvc.so.0.1.0
b7703000 b7708000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7709000 b7710000 r-xp /usr/lib/libappcore-efl.so.1.1
b7712000 b7717000 r-xp /usr/lib/libsys-assert.so
b771a000 b771b000 r-xp [vdso]
b771b000 b773d000 r-xp /lib/ld-2.20-2014.11.so
b773f000 b7747000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:18679)
Call Stack Count: 5
 0: (0xb6d48c0b) [/lib/libc.so.6] + 0x131c0b
 1: (0xb70953f1) [/usr/lib/libecore.so.1] + 0x1c3f1
 2: (0xb642eafb) [/usr/lib/libeina.so.1] + 0x3cafb
 3: (0xb730a15f) [/lib/libpthread.so.0] + 0x615f
 4: clone + 0x5e (0xb6cfe3ee) [/lib/libc.so.6] + 0xe73ee
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
art_app(2233) > caller pid : 18900
11-01 17:18:58.520+0900 E/AUL_AMD ( 2746): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
11-01 17:18:58.520+0900 W/AUL_AMD ( 2746): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.tichat) pkgid(org.example.tichat) attribute(600)
11-01 17:18:58.520+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2648) > process_pool: false
11-01 17:18:58.520+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
11-01 17:18:58.520+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.tichat
11-01 17:18:58.520+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2665) > pad pid(-5)
11-01 17:18:58.520+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
11-01 17:18:58.520+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
11-01 17:18:58.520+0900 D/AUL     ( 2746): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.tichat
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.tichat/bin/tichat
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
11-01 17:18:58.520+0900 W/AUL_PAD ( 2902): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
11-01 17:18:58.520+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.tichat, pkgid = org.example.tichat, flags = 1536
11-01 17:18:58.520+0900 D/RESOURCED( 2836): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.tichat, pkgname = org.example.tichat, ref = 1
11-01 17:18:58.520+0900 D/AUL     ( 2902): process_pool.c: __send_pkt_raw_data(219) > send(12) : 616 / 616
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 18679, bin path: /opt/usr/apps/org.example.tichat/bin/tichat
11-01 17:18:58.520+0900 W/AUL_PAD ( 2902): launchpad.c: __send_result_to_caller(265) > Check app launching
11-01 17:18:58.520+0900 D/AUL_PAD ( 2902): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
11-01 17:18:58.520+0900 E/RESOURCED( 2836): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-01 17:18:58.520+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
11-01 17:18:58.520+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 616, pkt->len: 608
11-01 17:18:58.520+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.tichat, launchpad type: 0
11-01 17:18:58.520+0900 D/AUL_PAD (18679): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
11-01 17:18:58.520+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.tichat
11-01 17:18:58.520+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.tichat
11-01 17:18:58.520+0900 D/AUL     (18679): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (18681) is sent.
11-01 17:18:58.520+0900 D/AUL     (18679): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 18681, signo: 10
11-01 17:18:58.530+0900 D/AUL     (18679): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.tichat / pkg_type : rpm / app_path : /opt/usr/apps/org.example.tichat/bin/tichat
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.tichat/bin/tichat##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0Nzc5ODgzMzgvNTIyOTIzAA==##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxODkwMAA=##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.tichat/bin/tichat, real app argc: 8
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
11-01 17:18:58.530+0900 D/AUL_PAD (18679): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.tichat/bin/tichat)
11-01 17:18:58.540+0900 I/CAPI_APPFW_APPLICATION(18679): app_main.c: ui_app_main(788) > app_efl_main
11-01 17:18:58.540+0900 D/LAUNCH  (18679): appcore-efl.c: appcore_efl_main(1692) > [tichat:Application:main:done]
11-01 17:18:58.540+0900 D/APP_CORE(18679): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
11-01 17:18:58.540+0900 D/APP_CORE(18679): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.tichat/res/locale
11-01 17:18:58.540+0900 D/APP_CORE(18679): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
11-01 17:18:58.540+0900 D/APP_CORE(18679): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
11-01 17:18:58.540+0900 D/AUL     (18679): app_sock.c: __create_server_sock(156) > pg path - already exists
11-01 17:18:58.540+0900 D/APP_CORE(18679): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4265520
11-01 17:18:58.540+0900 D/LAUNCH  (18679): appcore-efl.c: __before_loop(1136) > [tichat:Platform:appcore_init:done]
11-01 17:18:58.540+0900 I/CAPI_APPFW_APPLICATION(18679): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
11-01 17:18:58.580+0900 D/IMMODULE(18679): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
11-01 17:18:58.580+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
11-01 17:18:58.580+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(524) > connect() succeeded
11-01 17:18:58.580+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
11-01 17:18:58.580+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(524) > connect() succeeded
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(524) > connect() succeeded
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_QUERY(18679): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-socket-frontend, tichat
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(524) > connect() succeeded
11-01 17:18:58.590+0900 D/IMMODULE(18679): scim_panel_client.cpp: open_connection(162) > 
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-panel-socket:0, tichat
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(524) > connect() succeeded
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(515) > ppid:2902  trying connect() to local:/tmp/scim-panel-socket:0, tichat
11-01 17:18:58.590+0900 D/ISF_SOCKET(18679): scim_socket.cpp: connect(524) > connect() succeeded
11-01 17:18:58.600+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
11-01 17:18:58.620+0900 D/AUL_PAD ( 2902): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
11-01 17:18:58.620+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 18679, appid: org.example.tichat
11-01 17:18:58.620+0900 D/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
11-01 17:18:58.620+0900 E/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(330) > access
11-01 17:18:58.620+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2700) > add app group info
11-01 17:18:58.620+0900 E/AUL     ( 2746): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
11-01 17:18:58.620+0900 D/AUL_AMD ( 2746): amd_status.c: _status_add_app_info_list(427) > pid(18679) appid(org.example.tichat) pkgid(org.example.tichat) comp(uiapp)
11-01 17:18:58.630+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.tichat, 18679
11-01 17:18:58.630+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.tichat with pkgname
11-01 17:18:58.630+0900 E/RESOURCED( 2836): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.tichat
11-01 17:18:58.630+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(888) > available memory = 712
11-01 17:18:58.640+0900 D/LAUNCH  (18679): appcore-efl.c: __before_loop(1154) > [tichat:Application:create:done]
11-01 17:18:58.640+0900 E/E17     ( 2763): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
11-01 17:18:58.640+0900 D/APP_CORE(18679): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
11-01 17:18:58.650+0900 E/E17     ( 2763): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
11-01 17:18:58.660+0900 D/APP_CORE(18679): appcore.c: __aul_handler(587) > [APP 18679]     AUL event: AUL_START
11-01 17:18:58.660+0900 I/APP_CORE(18679): appcore-efl.c: __do_app(496) > [APP 18679] Event: RESET State: CREATED
11-01 17:18:58.660+0900 D/APP_CORE(18679): appcore-efl.c: __do_app(527) > [APP 18679] RESET
11-01 17:18:58.660+0900 D/LAUNCH  (18679): appcore-efl.c: __do_app(529) > [tichat:Application:reset:start]
11-01 17:18:58.660+0900 D/APP_CORE(18679): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
11-01 17:18:58.660+0900 D/APP_CORE(18679): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
11-01 17:18:58.660+0900 I/CAPI_APPFW_APPLICATION(18679): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
11-01 17:18:58.660+0900 D/AUL     (18679): service.c: __set_bundle(186) > __set_bundle
11-01 17:18:58.660+0900 D/LAUNCH  (18679): appcore-efl.c: __do_app(544) > [tichat:Application:reset:done]
11-01 17:18:58.660+0900 D/APP_CORE(18679): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
11-01 17:18:58.660+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
11-01 17:18:58.660+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:18:58.660+0900 W/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=18679
11-01 17:18:58.660+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
11-01 17:18:58.660+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:18:58.660+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
11-01 17:18:58.660+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:18:58.660+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
11-01 17:18:58.660+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:18:58.660+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
11-01 17:18:58.660+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:18:58.660+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
11-01 17:18:58.660+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
11-01 17:18:58.670+0900 D/INDICATOR( 2842): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
11-01 17:18:58.670+0900 D/INDICATOR( 2842): util.c: util_signal_emit_by_win(116) > emission bg.opaque
11-01 17:18:58.670+0900 D/INDICATOR( 2842): main.c: _rotate_window(229) > Indicator angle is 0 degree
11-01 17:18:58.670+0900 D/INDICATOR( 2842): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
11-01 17:18:58.670+0900 D/INDICATOR( 2842): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
11-01 17:18:58.670+0900 D/INDICATOR( 2842): main.c: _rotate_window(252) > port :: hide more icon
11-01 17:18:58.670+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 15
11-01 17:18:58.670+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
11-01 17:18:58.670+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.tichat/bin/tichat' and package_app_info.app_disable IN ('false','False')
11-01 17:18:58.670+0900 W/APP_CORE(18679): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
11-01 17:18:58.670+0900 D/APP_CORE(18679): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
11-01 17:18:58.670+0900 D/APP_CORE(18679): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
11-01 17:18:58.670+0900 D/AUL     (18679): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
11-01 17:18:58.680+0900 D/AUL_AMD ( 2746): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 18679 is org.example.tichat
11-01 17:18:58.680+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 18679 : 0
11-01 17:18:58.680+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 34
11-01 17:18:58.680+0900 D/AUL     ( 2922): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 27
11-01 17:18:58.850+0900 D/APP_CORE(18679): appcore.c: __prt_ltime(236) > [APP 18679] first idle after reset: 331 msec
11-01 17:18:59.000+0900 E/PKGMGR_SERVER(18845): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
11-01 17:18:59.000+0900 E/PKGMGR_SERVER(18845): pkgmgr-server.c: main(2265) > package manager server terminated.
11-01 17:18:59.030+0900 E/E17     ( 2763): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
11-01 17:18:59.030+0900 I/APP_CORE(18679): appcore-efl.c: __do_app(496) > [APP 18679] Event: RESUME State: CREATED
11-01 17:18:59.030+0900 D/LAUNCH  (18679): appcore-efl.c: __do_app(597) > [tichat:Application:resume:start]
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __do_app(607) > [APP 18679] RESUME
11-01 17:18:59.030+0900 I/APP_CORE(18679): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
11-01 17:18:59.030+0900 I/APP_CORE(18679): appcore-efl.c: __do_app(614) > [APP 18679] Initial Launching, call the resume_cb
11-01 17:18:59.030+0900 I/CAPI_APPFW_APPLICATION(18679): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
11-01 17:18:59.030+0900 D/LAUNCH  (18679): appcore-efl.c: __do_app(636) > [tichat:Application:resume:done]
11-01 17:18:59.030+0900 D/LAUNCH  (18679): appcore-efl.c: __do_app(638) > [tichat:Application:Launching:done]
11-01 17:18:59.030+0900 D/APP_CORE(18679): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
11-01 17:18:59.030+0900 E/APP_CORE(18679): appcore-efl.c: __trm_app_info_send_socket(242) > access
11-01 17:18:59.030+0900 D/APP_CORE( 2849): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
11-01 17:18:59.030+0900 D/APP_CORE( 2849): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
11-01 17:18:59.030+0900 D/APP_CORE( 2849): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
11-01 17:18:59.030+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: PAUSE State: RUNNING
11-01 17:18:59.030+0900 D/APP_CORE( 2849): appcore-efl.c: __do_app(565) > [APP 2849] PAUSE
11-01 17:18:59.030+0900 I/CAPI_APPFW_APPLICATION( 2849): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
11-01 17:18:59.030+0900 E/cluster-home( 2849): homescreen.cpp: OnPause(84) >  app pause
11-01 17:18:59.030+0900 D/cluster-view( 2849): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
11-01 17:18:59.030+0900 D/cluster-view( 2849): homescreen-view-manager.cpp: AppPause(923) >  END
11-01 17:18:59.030+0900 D/APP_CORE( 2849): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
11-01 17:18:59.030+0900 E/APP_CORE( 2849): appcore-efl.c: __trm_app_info_send_socket(242) > access
11-01 17:18:59.030+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2849) status(4)
11-01 17:18:59.040+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2849) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
11-01 17:18:59.040+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
11-01 17:18:59.040+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2849, appid: org.tizen.homescreen, status: bg
11-01 17:18:59.040+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(18679) status(3)
11-01 17:18:59.040+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
11-01 17:18:59.040+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-01 17:18:59.040+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
11-01 17:18:59.040+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(18679) status(3)
11-01 17:18:59.040+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(18679) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
11-01 17:18:59.040+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
11-01 17:18:59.040+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 18679, appid: org.example.tichat, status: fg
11-01 17:18:59.040+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 18679
11-01 17:18:59.040+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 18679, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
11-01 17:18:59.040+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 18679
11-01 17:18:59.040+0900 D/DATA_PROVIDER_MASTER( 2905): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2849 is paused
11-01 17:18:59.040+0900 D/DATA_PROVIDER_MASTER( 2905): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
11-01 17:18:59.040+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __provider_pause_cb(294) > widget obj was paused
11-01 17:18:59.040+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __check_status_for_cgroup(142) > enter background group
11-01 17:18:59.040+0900 W/AUL     ( 2988): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2988, appid: org.tizen.calendar.widget, status: bg
11-01 17:18:59.070+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2910) > pid(18679) status(0)
11-01 17:18:59.090+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 18679, appname = org.example.tichat, pkgname = org.example.tichat
11-01 17:18:59.090+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 18679, appname = org.example.tichat
11-01 17:18:59.090+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 18679
11-01 17:18:59.130+0900 I/RESOURCED( 2836): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
11-01 17:18:59.130+0900 I/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
11-01 17:18:59.130+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2988, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
11-01 17:18:59.130+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2988
11-01 17:18:59.130+0900 D/RESOURCED( 2836): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2988, appname = org.tizen.calendar.widget
11-01 17:18:59.130+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2988
11-01 17:18:59.630+0900 D/AUL_PAD ( 2902): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
11-01 17:18:59.630+0900 D/AUL_PAD (18908): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
11-01 17:18:59.630+0900 D/AUL_PAD ( 2902): sigchild.h: __send_app_launch_signal(131) > send launch signal done
11-01 17:18:59.640+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1598
11-01 17:19:00.130+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
11-01 17:19:00.130+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
11-01 17:19:00.130+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 5:19 4 h"
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 5:19"
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 5&#x2236;19"
11-01 17:19:00.480+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147234004 Time: <font_size=33>5&#x2236;19</font_size> <font_size=32>PM</font_size></font>
11-01 17:19:00.650+0900 D/AUL_PAD (18908): launchpad_loader.c: main(588) > sleeping 1 sec...
11-01 17:19:00.650+0900 D/AUL_PAD (18908): preload.h: __preload_init(52) > max_cmdline_size = 1053
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9591760
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(69) > get pre-initialization function
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(73) > get shutdown function
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9591a40
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9593640
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(69) > get pre-initialization function
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preload.h: __preload_init(73) > get shutdown function
11-01 17:19:00.660+0900 D/AUL_PAD (18908): preexec.h: __preexec_init(76) > preexec start
11-01 17:19:00.660+0900 D/AUL_PAD (18908): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
11-01 17:19:00.660+0900 D/AUL     (18908): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
11-01 17:19:00.660+0900 D/AUL     (18908): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
11-01 17:19:00.660+0900 D/AUL     (18908): process_pool.c: __connect_to_launchpad(132) > send(18908) : 4
11-01 17:19:00.660+0900 D/AUL     (18908): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
11-01 17:19:00.660+0900 D/AUL_PAD ( 2902): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 18908
11-01 17:19:00.720+0900 D/AUL_PAD (18908): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
11-01 17:19:00.730+0900 D/AUL_PAD (18908): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
11-01 17:19:00.730+0900 D/AUL_PAD (18908): launchpad_loader.c: main(693) > [candidate] ecore handler add
11-01 17:19:00.730+0900 D/AUL_PAD (18908): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
11-01 17:19:04.039+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
11-01 17:19:04.039+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: MEM_FLUSH State: PAUSED
11-01 17:19:04.039+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
11-01 17:19:04.039+0900 D/APP_CORE( 2849): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2849
11-01 17:19:04.039+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
11-01 17:19:04.039+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2849
11-01 17:19:04.059+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 17:19:04.059+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 17:19:04.059+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 17:19:04.059+0900 E/INDICATOR( 2842): 
11-01 17:19:15.929+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 17:19:15.929+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 17:19:15.929+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 17:19:15.929+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 17:19:15.929+0900 I/RESOURCED( 2836): logging.c: logging_save_to_storage(978) > storage cache is empty
11-01 17:19:18.329+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:18.329+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8fe4228. set autocapital type : 2
11-01 17:19:18.329+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 17:19:18.329+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 48f70027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 17:19:18.329+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8fe4228. on demand : 0
11-01 17:19:18.339+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 17:19:18.339+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 0
11-01 17:19:18.339+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8fe4228
11-01 17:19:18.339+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 17:19:19.329+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
11-01 17:19:20.499+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:20.499+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8fe4228
11-01 17:19:20.499+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 17:19:21.009+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 1
11-01 17:19:21.009+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8fe4228, bidi direction : 0x1
11-01 17:19:21.459+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 2
11-01 17:19:21.529+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 3
11-01 17:19:21.649+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 4
11-01 17:19:22.069+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 5
11-01 17:19:22.319+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 6
11-01 17:19:22.499+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 7
11-01 17:19:22.529+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8fe4228, cursor pos : 8
11-01 17:19:22.739+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8fe4228
11-01 17:19:22.739+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 17:19:22.739+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8fe4228
11-01 17:19:22.749+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 17:19:22.749+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9023620. set autocapital type : 0
11-01 17:19:22.749+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 17:19:22.749+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 48f80027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 17:19:22.759+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9023620. on demand : 0
11-01 17:19:22.759+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 17:19:22.759+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 0
11-01 17:19:22.989+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 1
11-01 17:19:22.989+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb9023620, bidi direction : 0x1
11-01 17:19:23.079+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 2
11-01 17:19:23.199+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 3
11-01 17:19:23.289+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 4
11-01 17:19:23.389+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 5
11-01 17:19:23.509+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 6
11-01 17:19:23.659+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 7
11-01 17:19:23.779+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 8
11-01 17:19:23.899+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9023620, cursor pos : 9
11-01 17:19:24.069+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 17:19:24.069+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 17:19:24.069+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 17:19:24.069+0900 E/INDICATOR( 2842): 
11-01 17:19:24.329+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x605b63 bd->visible=1
11-01 17:19:25.069+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9023620
11-01 17:19:25.069+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 17:19:25.069+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9023620
11-01 17:19:25.069+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 17:19:25.079+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:25.119+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 17:19:25.119+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 17:19:25.129+0900 I/CAPI_NETWORK_CONNECTION(18679): connection.c: connection_create(408) > New handle created[0xb9027508]
11-01 17:19:25.129+0900 I/CAPI_NETWORK_CONNECTION(18679): connection.c: connection_get_type(464) > Connected Network = 3
11-01 17:19:25.129+0900 I/tichat  (18679): Network connection type : 3
11-01 17:19:26.359+0900 I/tichat  (18679): CURL Returned: 
11-01 17:19:26.359+0900 I/tichat  (18679): {"message":"로그인 성공"}
11-01 17:19:26.369+0900 I/tichat  (18679): Parsed JSON: "로그인 성공"
11-01 17:19:26.409+0900 I/CAPI_NETWORK_CONNECTION(18679): connection.c: connection_destroy(426) > Destroy handle: 0xb9027508
11-01 17:19:34.219+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:34.319+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 17:19:34.319+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:19:34.559+0900 I/CAPI_NETWORK_CONNECTION(18679): connection.c: connection_create(408) > New handle created[0xb90ac6c8]
11-01 17:19:34.559+0900 I/CAPI_NETWORK_CONNECTION(18679): connection.c: connection_get_type(464) > Connected Network = 3
11-01 17:19:34.559+0900 I/tichat  (18679): Network connection type : 3
11-01 17:19:34.559+0900 I/tichat  (18679): socket open success : 49
11-01 17:19:34.559+0900 I/tichat  (18679): socket connect success
11-01 17:19:34.559+0900 I/tichat  (18679): Sent count: 14, msg:
11-01 17:19:34.569+0900 I/tichat  (18679): thread run
11-01 17:19:34.579+0900 I/tichat  (18679): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 17:19:35.219+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
11-01 17:19:37.369+0900 E/EFL     (18679): edje<18679> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 17:19:37.369+0900 E/EFL     (18679): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 17:19:37.389+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:38.859+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:38.859+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb90f5160. set autocapital type : 2
11-01 17:19:38.859+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 17:19:38.859+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb90f5160. on demand : 0
11-01 17:19:38.859+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 48f90027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 17:19:38.859+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 17:19:38.859+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 0
11-01 17:19:38.859+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb90f5160
11-01 17:19:38.859+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 17:19:39.129+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 1
11-01 17:19:39.129+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb90f5160, bidi direction : 0x1
11-01 17:19:39.229+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 2
11-01 17:19:39.349+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 3
11-01 17:19:39.529+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 4
11-01 17:19:39.629+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 5
11-01 17:19:39.639+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 6
11-01 17:19:39.839+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb90f5160, cursor pos : 7
11-01 17:19:40.049+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605b63 
11-01 17:19:40.069+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb90f5160
11-01 17:19:40.069+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 17:19:40.069+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb90f5160
11-01 17:19:40.069+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 17:19:40.179+0900 I/tichat  (18679): title : asdfasf id : park3745
11-01 17:19:40.179+0900 I/tichat  (18679): Sent count: 19, msg:
11-01 17:19:40.189+0900 I/tichat  (18679): Sent count: 17, msg:
11-01 17:19:40.189+0900 E/EFL     (18679): elementary<18679> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x80112497 into part 'elm.swallow.indicator_bg'
11-01 17:19:40.209+0900 D/IMMODULE(18679): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb90f5160
11-01 17:19:40.209+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-01 17:19:40.209+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-01 17:19:40.219+0900 D/IMMODULE(18679): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 17:19:40.219+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 17:19:40.269+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x605b63 bd->visible=1
11-01 17:19:42.309+0900 W/CRASH_MANAGER(18912): worker.c: worker_job(1204) > 1118679746963147798838
