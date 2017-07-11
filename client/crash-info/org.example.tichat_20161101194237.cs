S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 21152
Date: 2016-11-01 19:42:37+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb34ebd90, esi = 0xb0cdaf40
ebp = 0xb0cdb0a8, esp = 0xb0cdaf3c
eax = 0xb34e8df9, ebx = 0xb34ebacc
ecx = 0x00000072, edx = 0x00000000
eip = 0xb6d23c0b

Memory Information
MemTotal:      250 KB
MemFree:       110 KB
Buffers:        11 KB
Cached:     198396 KB
VmPeak:     130504 KB
VmSize:     130504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       33148 KB
VmRSS:       33148 KB
VmData:      60284 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 21152 TID = 21389
21152 21154 21383 21384 21388 21389 

Maps Information
b2a7a000 b2a81000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2a82000 b2a9a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2a9b000 b2aa2000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b1f000 b2b29000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b2f000 b2b3b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b3c000 b2b5d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b62000 b2b63000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b64000 b2b69000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b6a000 b2b6b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b6c000 b2b6e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b6f000 b2b71000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b72000 b2b7e000 r-xp /usr/lib/libdrm.so.2.4.0
b2b7f000 b2b82000 r-xp /usr/lib/libdri2.so.0.0.0
b2b83000 b2b8d000 r-xp /usr/lib/libtbm.so.1.0.0
b2b8e000 b2b8f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b90000 b2ba5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2ba6000 b2bb8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33ba000 b33eb000 r-xp /usr/lib/libidn.so.11.5.44
b33ec000 b340e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b340f000 b341f000 r-xp /usr/lib/libcares.so.2.1.0
b3420000 b3440000 r-xp /usr/lib/libnetwork.so.0.0.0
b3441000 b344a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b344b000 b34c2000 r-xp /usr/lib/libcurl.so.4.3.0
b34c4000 b34d8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34d9000 b34eb000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b35f3000 b35f9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35fa000 b373e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3754000 b3755000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3756000 b3757000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3758000 b375b000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b375c000 b375f000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3760000 b3799000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b419c000 b41a7000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a9000 b41b4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41b6000 b41cd000 r-xp /lib/libnsl-2.20-2014.11.so
b41d1000 b41d9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41db000 b41ff000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4200000 b4201000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4202000 b4205000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4206000 b420d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b420e000 b4218000 r-xp /usr/lib/libsensord-share.so
b4219000 b4235000 r-xp /usr/lib/libsensor.so.1.2.0
b4237000 b4240000 r-xp /usr/lib/libappcore-common.so.1.1
b4243000 b4245000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b425a000 b425c000 r-xp /usr/lib/libXau.so.6.0.0
b425d000 b427f000 r-xp /usr/lib/libxcb.so.1.1.0
b4281000 b428a000 r-xp /lib/libcrypt-2.20-2014.11.so
b42b3000 b42b5000 r-xp /usr/lib/libiri.so
b42b6000 b42dc000 r-xp /lib/libexpat.so.1.5.2
b42de000 b4349000 r-xp /usr/lib/libssl.so.1.0.0
b434f000 b435b000 r-xp /usr/lib/libethumb.so.1.13.0
b435c000 b4360000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4361000 b45b2000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b2d000 b5b3d000 r-xp /usr/lib/libXi.so.6.1.0
b5b3e000 b5b40000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b41000 b5b47000 r-xp /usr/lib/libXtst.so.6.1.0
b5b48000 b5b52000 r-xp /usr/lib/libXrender.so.1.3.0
b5b53000 b5b5c000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b5e000 b5b60000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b61000 b5b66000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b67000 b5b79000 r-xp /usr/lib/libXext.so.6.4.0
b5b7a000 b5b7c000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b7d000 b5b7f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b81000 b5cc3000 r-xp /usr/lib/libX11.so.6.3.0
b5cc7000 b5cd1000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cd2000 b5ce8000 r-xp /usr/lib/libudev.so.1.6.0
b5ceb000 b5cef000 r-xp /lib/libattr.so.1.1.0
b5cf0000 b5d1f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d21000 b5d27000 r-xp /usr/lib/libffi.so.6.0.2
b5d28000 b5d4b000 r-xp /lib/libz.so.1.2.8
b5d4c000 b5d4f000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d50000 b5eac000 r-xp /usr/lib/libxml2.so.2.9.2
b5eb2000 b5f99000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fa6000 b5fa9000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5faa000 b5fcc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fcd000 b5fe1000 r-xp /lib/libresolv-2.20-2014.11.so
b5fe5000 b6009000 r-xp /usr/lib/liblzma.so.5.0.3
b600a000 b600c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b600e000 b6018000 r-xp /usr/lib/libembryo.so.1.13.0
b6019000 b6042000 r-xp /usr/lib/libpng12.so.0.50.0
b6043000 b608c000 r-xp /usr/lib/libjpeg.so.8.0.2
b609d000 b60a4000 r-xp /lib/librt-2.20-2014.11.so
b60a6000 b60c5000 r-xp /usr/lib/libector.so.1.13.0
b60c8000 b60f5000 r-xp /usr/lib/liblua-5.1.so
b60f6000 b6186000 r-xp /usr/lib/libfreetype.so.6.11.3
b618a000 b61c8000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c9000 b61df000 r-xp /usr/lib/libfribidi.so.0.3.1
b61e0000 b6239000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b623c000 b6287000 r-xp /lib/libm-2.20-2014.11.so
b6289000 b629b000 r-xp /usr/lib/libeio.so.1.13.0
b629c000 b629f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62a0000 b62a6000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62a7000 b62ca000 r-xp /usr/lib/libefreet.so.1.13.0
b62cd000 b62f8000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f9000 b632d000 r-xp /usr/lib/libecore_con.so.1.13.0
b632f000 b6338000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6339000 b6342000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6343000 b6356000 r-xp /usr/lib/libeo.so.1.13.0
b6358000 b636b000 r-xp /usr/lib/libecore_input.so.1.13.0
b636c000 b6373000 r-xp /usr/lib/libecore_file.so.1.13.0
b6374000 b6397000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6398000 b63c4000 r-xp /usr/lib/libeet.so.1.13.0
b63cd000 b6438000 r-xp /usr/lib/libeina.so.1.13.0
b643b000 b6452000 r-xp /usr/lib/libefl.so.1.13.0
b6454000 b65bb000 r-xp /usr/lib/libicuuc.so.51.1
b65c9000 b67d5000 r-xp /usr/lib/libicui18n.so.51.1
b67dd000 b682c000 r-xp /usr/lib/libecore_x.so.1.13.0
b682e000 b6848000 r-xp /lib/libgcc_s-4.9.so.1
b684a000 b684e000 r-xp /lib/libcap.so.2.21
b684f000 b6895000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6896000 b689d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b689f000 b68f1000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68f3000 b6a7e000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a83000 b6b51000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b54000 b6b58000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b59000 b6b68000 r-xp /usr/lib/libvconf.so.0.2.45
b6b69000 b6b6c000 r-xp /usr/lib/libvasum.so.0.3.1
b6b6d000 b6b70000 r-xp /usr/lib/libttrace.so.1.1
b6b72000 b6b76000 r-xp /usr/lib/libiniparser.so.0
b6b77000 b6ba7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba8000 b6bb1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bb2000 b6bd7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd8000 b6be8000 r-xp /usr/lib/libunwind.so.8.0.1
b6bf2000 b6da0000 r-xp /lib/libc-2.20-2014.11.so
b6da8000 b6eeb000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6eed000 b6f45000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f46000 b6f7a000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f7d000 b7051000 r-xp /usr/lib/libedje.so.1.13.0
b7054000 b7080000 r-xp /usr/lib/libecore.so.1.13.0
b7091000 b72b7000 r-xp /usr/lib/libevas.so.1.13.0
b72df000 b72f7000 r-xp /lib/libpthread-2.20-2014.11.so
b72fb000 b7675000 r-xp /usr/lib/libelementary.so.1.13.0
b7695000 b7699000 r-xp /usr/lib/libsmack.so.1.0.0
b769a000 b76a3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a4000 b76a7000 r-xp /usr/lib/libdlog.so.0.0.0
b76a8000 b76ad000 r-xp /usr/lib/libbundle.so.0.1.22
b76ae000 b76b1000 r-xp /lib/libdl-2.20-2014.11.so
b76b3000 b76d8000 r-xp /usr/lib/libaul.so.0.1.0
b76db000 b76dd000 r-xp /usr/lib/libappsvc.so.0.1.0
b76de000 b76e3000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76e4000 b76eb000 r-xp /usr/lib/libappcore-efl.so.1.1
b76ed000 b76f2000 r-xp /usr/lib/libsys-assert.so
b76f5000 b76f6000 r-xp [vdso]
b76f6000 b7718000 r-xp /lib/ld-2.20-2014.11.so
b771a000 b7722000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:21152)
Call Stack Count: 5
 0: (0xb6d23c0b) [/lib/libc.so.6] + 0x131c0b
 1: (0xb70703f1) [/usr/lib/libecore.so.1] + 0x1c3f1
 2: (0xb6409afb) [/usr/lib/libeina.so.1] + 0x3cafb
 3: (0xb72e515f) [/lib/libpthread.so.0] + 0x615f
 4: clone + 0x5e (0xb6cd93ee) [/lib/libc.so.6] + 0xe73ee
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
    ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2849, appid: org.tizen.homescreen, status: bg
11-01 19:40:38.773+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(21152) status(3)
11-01 19:40:38.773+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
11-01 19:40:38.773+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-01 19:40:38.773+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
11-01 19:40:38.773+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(21152) status(3)
11-01 19:40:38.773+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(21152) appid(org.example.tichat) pkgid(org.example.tichat) status(3)
11-01 19:40:38.773+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.tichat
11-01 19:40:38.773+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 21152, appid: org.example.tichat, status: fg
11-01 19:40:38.773+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 21152
11-01 19:40:38.773+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 21152, proc_name: org.example.tichat, cg_name: foreground, oom_score_adj: 200
11-01 19:40:38.773+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 21152
11-01 19:40:38.773+0900 D/DATA_PROVIDER_MASTER( 2905): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2849 is paused
11-01 19:40:38.773+0900 D/DATA_PROVIDER_MASTER( 2905): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
11-01 19:40:38.773+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __provider_pause_cb(294) > widget obj was paused
11-01 19:40:38.773+0900 I/CAPI_WIDGET_APPLICATION( 2988): widget_app.c: __check_status_for_cgroup(142) > enter background group
11-01 19:40:38.773+0900 W/AUL     ( 2988): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2988, appid: org.tizen.calendar.widget, status: bg
11-01 19:40:38.813+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2910) > pid(21152) status(0)
11-01 19:40:38.833+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 21152, appname = org.example.tichat, pkgname = org.example.tichat
11-01 19:40:38.833+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 21152, appname = org.example.tichat
11-01 19:40:38.833+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 21152
11-01 19:40:38.833+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2988, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
11-01 19:40:38.833+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2988
11-01 19:40:38.833+0900 D/RESOURCED( 2836): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2988, appname = org.tizen.calendar.widget
11-01 19:40:38.833+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2988
11-01 19:40:38.833+0900 I/RESOURCED( 2836): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
11-01 19:40:38.833+0900 I/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
11-01 19:40:39.383+0900 D/AUL_PAD ( 2902): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
11-01 19:40:39.383+0900 D/AUL_PAD (21386): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
11-01 19:40:39.393+0900 D/AUL_PAD ( 2902): sigchild.h: __send_app_launch_signal(131) > send launch signal done
11-01 19:40:39.413+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1854
11-01 19:40:39.873+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
11-01 19:40:39.873+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
11-01 19:40:39.883+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
11-01 19:40:40.463+0900 D/AUL_PAD (21386): launchpad_loader.c: main(588) > sleeping 1 sec...
11-01 19:40:40.463+0900 D/AUL_PAD (21386): preload.h: __preload_init(52) > max_cmdline_size = 1053
11-01 19:40:40.473+0900 D/AUL_PAD (21386): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b82fa760
11-01 19:40:40.473+0900 D/AUL_PAD (21386): preload.h: __preload_init(69) > get pre-initialization function
11-01 19:40:40.473+0900 D/AUL_PAD (21386): preload.h: __preload_init(73) > get shutdown function
11-01 19:40:40.483+0900 D/AUL_PAD (21386): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b82faa40
11-01 19:40:40.493+0900 D/AUL_PAD (21386): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b82fc640
11-01 19:40:40.493+0900 D/AUL_PAD (21386): preload.h: __preload_init(69) > get pre-initialization function
11-01 19:40:40.493+0900 D/AUL_PAD (21386): preload.h: __preload_init(73) > get shutdown function
11-01 19:40:40.493+0900 D/AUL_PAD (21386): preexec.h: __preexec_init(76) > preexec start
11-01 19:40:40.493+0900 D/AUL_PAD (21386): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
11-01 19:40:40.493+0900 D/AUL     (21386): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
11-01 19:40:40.493+0900 D/AUL     (21386): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
11-01 19:40:40.493+0900 D/AUL     (21386): process_pool.c: __connect_to_launchpad(132) > send(21386) : 4
11-01 19:40:40.493+0900 D/AUL     (21386): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
11-01 19:40:40.493+0900 D/AUL_PAD ( 2902): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 21386
11-01 19:40:40.513+0900 E/RESOURCED( 2836): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1855
11-01 19:40:40.623+0900 D/AUL_PAD (21386): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
11-01 19:40:40.633+0900 D/AUL_PAD (21386): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
11-01 19:40:40.633+0900 D/AUL_PAD (21386): launchpad_loader.c: main(693) > [candidate] ecore handler add
11-01 19:40:40.633+0900 D/AUL_PAD (21386): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
11-01 19:40:43.783+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
11-01 19:40:43.783+0900 I/APP_CORE( 2849): appcore-efl.c: __do_app(496) > [APP 2849] Event: MEM_FLUSH State: PAUSED
11-01 19:40:43.783+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
11-01 19:40:43.783+0900 D/APP_CORE( 2849): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2849
11-01 19:40:43.783+0900 D/APP_CORE( 2849): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
11-01 19:40:43.783+0900 D/RESOURCED( 2836): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2849
11-01 19:40:52.113+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:40:52.113+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:40:52.113+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:40:52.113+0900 E/INDICATOR( 2842): 
11-01 19:40:53.732+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:40:54.212+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:40:54.212+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7ccebc8. set autocapital type : 2
11-01 19:40:54.212+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:40:54.212+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 52a00027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:40:54.212+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7ccebc8. on demand : 0
11-01 19:40:54.212+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:40:54.212+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 0
11-01 19:40:54.212+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7ccebc8
11-01 19:40:54.222+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:40:54.732+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 1
11-01 19:40:54.732+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7ccebc8, bidi direction : 0x1
11-01 19:40:54.822+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 2
11-01 19:40:54.932+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 3
11-01 19:40:55.212+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
11-01 19:40:55.282+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 4
11-01 19:40:55.402+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 5
11-01 19:40:55.562+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 6
11-01 19:40:55.682+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7ccebc8, cursor pos : 7
11-01 19:40:55.952+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7ccebc8
11-01 19:40:55.962+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:40:55.962+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7ccebc8
11-01 19:40:55.972+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:40:55.992+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7d29128. set autocapital type : 0
11-01 19:40:56.002+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7d29128. on demand : 0
11-01 19:40:56.002+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:40:56.002+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 52a10027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:40:56.012+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:40:56.012+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 0
11-01 19:40:57.402+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 1
11-01 19:40:57.402+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7d29128, bidi direction : 0x1
11-01 19:40:57.552+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 2
11-01 19:40:57.702+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 3
11-01 19:40:57.832+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 4
11-01 19:40:58.072+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 5
11-01 19:40:58.352+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 6
11-01 19:40:58.502+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 7
11-01 19:40:58.632+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 8
11-01 19:40:58.782+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 9
11-01 19:40:58.962+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d29128, cursor pos : 10
11-01 19:41:00.212+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6070c7 bd->visible=1
11-01 19:41:00.362+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:00.372+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7d29128
11-01 19:41:00.372+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:41:00.372+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7d29128
11-01 19:41:00.372+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:41:00.442+0900 I/CAPI_NETWORK_CONNECTION(21152): connection.c: connection_create(408) > New handle created[0xb7d47fd8]
11-01 19:41:00.442+0900 I/CAPI_NETWORK_CONNECTION(21152): connection.c: connection_get_type(464) > Connected Network = 3
11-01 19:41:00.442+0900 I/tichat  (21152): Network connection type : 3
11-01 19:41:00.532+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:41:00.532+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:41:00.532+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:41:00.542+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:41 4 h"
11-01 19:41:00.542+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:41"
11-01 19:41:00.542+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;41"
11-01 19:41:00.542+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146880032 Time: <font_size=33>7&#x2236;41</font_size> <font_size=32>PM</font_size></font>
11-01 19:41:01.782+0900 I/tichat  (21152): CURL Returned: 
11-01 19:41:01.782+0900 I/tichat  (21152): {"message":"로그인 성공"}
11-01 19:41:01.782+0900 I/tichat  (21152): Parsed JSON: "로그인 성공"
11-01 19:41:01.842+0900 I/CAPI_NETWORK_CONNECTION(21152): connection.c: connection_destroy(426) > Destroy handle: 0xb7d47fd8
11-01 19:41:01.852+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:41:01.852+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:41:03.422+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:03.552+0900 E/EFL     (21152): edje<21152> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:41:03.552+0900 E/EFL     (21152): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:41:04.092+0900 I/CAPI_NETWORK_CONNECTION(21152): connection.c: connection_create(408) > New handle created[0xb7d657f0]
11-01 19:41:04.092+0900 I/CAPI_NETWORK_CONNECTION(21152): connection.c: connection_get_type(464) > Connected Network = 3
11-01 19:41:04.092+0900 I/tichat  (21152): Network connection type : 3
11-01 19:41:04.092+0900 I/tichat  (21152): socket open success : 49
11-01 19:41:04.102+0900 I/tichat  (21152): socket connect success
11-01 19:41:04.102+0900 I/tichat  (21152): Sent count: 13, msg:
11-01 19:41:04.102+0900 I/tichat  (21152): thread run
11-01 19:41:04.162+0900 I/tichat  (21152): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 19:41:04.162+0900 I/tichat  (21152): roomlist : (null)
11-01 19:41:05.942+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:07.062+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:07.062+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7df8060. set autocapital type : 2
11-01 19:41:07.062+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:41:07.062+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 52a20027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:41:07.072+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7df8060. on demand : 0
11-01 19:41:07.072+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:41:07.072+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 0
11-01 19:41:07.072+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7df8060
11-01 19:41:07.072+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:41:07.982+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 1
11-01 19:41:07.982+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7df8060, bidi direction : 0x1
11-01 19:41:07.982+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 2
11-01 19:41:08.012+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 3
11-01 19:41:08.282+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 4
11-01 19:41:08.702+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 3
11-01 19:41:09.002+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 2
11-01 19:41:09.192+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 1
11-01 19:41:09.192+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 0
11-01 19:41:09.192+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7df8060, bidi direction : 0
11-01 19:41:10.092+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 1
11-01 19:41:10.092+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7df8060, bidi direction : 0x1
11-01 19:41:10.092+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 2
11-01 19:41:10.272+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 3
11-01 19:41:10.422+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 4
11-01 19:41:10.422+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 5
11-01 19:41:11.922+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7df8060, cursor pos : 4
11-01 19:41:12.122+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:41:12.122+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:41:12.122+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:41:12.122+0900 E/INDICATOR( 2842): 
11-01 19:41:12.862+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:13.022+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7df8060
11-01 19:41:13.022+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:41:13.022+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7df8060
11-01 19:41:13.032+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:41:13.032+0900 E/EFL     (21152): edje<21152> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:41:13.032+0900 E/EFL     (21152): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:41:13.262+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:41:13.262+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:41:13.472+0900 I/tichat  (21152): title : room id : ohg1006
11-01 19:41:13.472+0900 I/tichat  (21152): Sent count: 16, msg:
11-01 19:41:13.472+0900 I/tichat  (21152): Sent count: 14, msg:
11-01 19:41:13.472+0900 E/EFL     (21152): elementary<21152> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x80123720 into part 'elm.swallow.indicator_bg'
11-01 19:41:13.552+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb7df8060
11-01 19:41:13.552+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-01 19:41:13.552+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-01 19:41:13.872+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
11-01 19:41:15.922+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:41:15.922+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:41:15.922+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:41:15.922+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:41:18.872+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6070c7 bd->visible=1
11-01 19:41:27.132+0900 I/tichat  (21152): load message : Hello
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.132+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.142+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.142+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:27.142+0900 E/EFL     (21152): ecore<21152> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:41:29.042+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:29.042+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7e6ac88. set autocapital type : 2
11-01 19:41:29.042+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:41:29.042+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 52a30027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:41:29.042+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7e6ac88. on demand : 0
11-01 19:41:29.042+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:41:29.042+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7e6ac88, cursor pos : 0
11-01 19:41:29.052+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb7e6ac88
11-01 19:41:29.052+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:41:29.832+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7e6ac88, cursor pos : 1
11-01 19:41:29.842+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb7e6ac88, bidi direction : 0x1
11-01 19:41:29.902+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7e6ac88, cursor pos : 2
11-01 19:41:30.052+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
11-01 19:41:31.342+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7e6ac88
11-01 19:41:31.342+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:41:31.342+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7e6ac88
11-01 19:41:31.352+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:41:31.352+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:41:31.402+0900 I/tichat  (21152): Sent count: 7, msg:
11-01 19:41:31.402+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:41:31.412+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:41:32.152+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:41:32.152+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:41:32.152+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:41:32.152+0900 E/INDICATOR( 2842): 
11-01 19:41:35.052+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6070c7 bd->visible=1
11-01 19:41:52.172+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:41:52.172+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:41:52.172+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:41:52.172+0900 E/INDICATOR( 2842): 
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:42 4 h"
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:42"
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;42"
11-01 19:42:00.552+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146878492 Time: <font_size=33>7&#x2236;42</font_size> <font_size=32>PM</font_size></font>
11-01 19:42:01.272+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:02.282+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
11-01 19:42:03.032+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:03.082+0900 I/tichat  (21152): room leaved
11-01 19:42:03.332+0900 D/IMMODULE(21152): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb7e6ac88
11-01 19:42:03.332+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-01 19:42:03.332+0900 D/IMMODULE(21152): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-01 19:42:04.482+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:04.522+0900 E/EFL     (21152): edje<21152> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:42:04.522+0900 E/EFL     (21152): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:42:04.642+0900 I/tichat  (21152): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 19:42:04.642+0900 I/tichat  (21152): roomlist : room$
11-01 19:42:05.652+0900 I/tichat  (21152): not toked : room$
11-01 19:42:05.652+0900 I/tichat  (21152): toked : room
11-01 19:42:06.922+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:07.152+0900 I/tichat  (21152): Sent count: 14, msg:
11-01 19:42:07.152+0900 E/EFL     (21152): elementary<21152> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x801ac368 into part 'elm.swallow.indicator_bg'
11-01 19:42:07.272+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6070c7 bd->visible=1
11-01 19:42:12.182+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:42:12.182+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:42:12.182+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:42:12.182+0900 E/INDICATOR( 2842): 
11-01 19:42:15.781+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:15.841+0900 I/tichat  (21152): room leaved
11-01 19:42:15.901+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:42:15.901+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:42:15.901+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:42:15.901+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:42:18.161+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:18.221+0900 E/EFL     (21152): edje<21152> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:42:18.221+0900 E/EFL     (21152): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:42:18.481+0900 I/tichat  (21152): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 19:42:18.481+0900 I/tichat  (21152): roomlist : room$
11-01 19:42:19.161+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
11-01 19:42:19.491+0900 I/tichat  (21152): not toked : room$
11-01 19:42:19.491+0900 I/tichat  (21152): toked : room
11-01 19:42:21.811+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:21.871+0900 E/EFL     (21152): edje<21152> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:42:21.871+0900 E/EFL     (21152): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:42:22.061+0900 I/tichat  (21152): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 19:42:22.061+0900 I/tichat  (21152): roomlist : room$
11-01 19:42:23.071+0900 I/tichat  (21152): not toked : room$
11-01 19:42:23.071+0900 I/tichat  (21152): toked : room
11-01 19:42:24.171+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6070c7 bd->visible=1
11-01 19:42:26.951+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:27.091+0900 I/tichat  (21152): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 19:42:27.091+0900 I/tichat  (21152): roomlist : (null)
11-01 19:42:32.211+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:42:32.211+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:42:32.211+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:42:32.211+0900 E/INDICATOR( 2842): 
11-01 19:42:37.421+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x6070c7 
11-01 19:42:37.461+0900 E/EFL     (21152): edje<21152> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:42:37.461+0900 E/EFL     (21152): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:42:37.701+0900 I/CAPI_APPFW_APPLICATION(21152): app_main.c: ui_app_exit(799) > ui_app_exit
11-01 19:42:37.701+0900 D/AUL     (21152): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
11-01 19:42:37.701+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 22
11-01 19:42:37.701+0900 W/AUL_AMD ( 2746): amd_request.c: __request_handler(1056) > app status : 5
11-01 19:42:37.701+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(21152) status(5)
11-01 19:42:37.701+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(21152) appid(org.example.tichat) pkgid(org.example.tichat) status(5)
11-01 19:42:37.701+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.tichat
11-01 19:42:37.701+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 21152, appid: org.example.tichat, status: bg
11-01 19:42:37.711+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 21152, appname = org.example.tichat, pkgname = org.example.tichat
11-01 19:42:37.711+0900 D/RESOURCED( 2836): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 21152, appname = org.example.tichat
11-01 19:42:37.711+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 21152
11-01 19:42:37.711+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2847 increase lru 15
11-01 19:42:37.711+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.example.tichat
11-01 19:42:37.711+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 21152, proc_name: org.example.tichat, cg_name: favorite, oom_score_adj: 270
11-01 19:42:37.711+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 21152
11-01 19:42:37.721+0900 D/APP_CORE(21152): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
11-01 19:42:37.721+0900 D/APP_CORE(21152): appcore-efl.c: __after_loop(1169) > [APP 21152] PAUSE before termination
11-01 19:42:37.721+0900 I/CAPI_APPFW_APPLICATION(21152): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
11-01 19:42:37.721+0900 I/CAPI_APPFW_APPLICATION(21152): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
11-01 19:42:37.721+0900 E/EFL     (21152): eo<21152> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80054ca8 is not pointing to a valid object. Maybe it has already been freed.
11-01 19:42:37.721+0900 E/EFL     (21152): eo<21152> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80054ca8) is an invalid ref.
11-01 19:42:37.781+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
11-01 19:42:37.781+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(2849) status(3)
11-01 19:42:37.781+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
11-01 19:42:37.781+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-01 19:42:37.781+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
11-01 19:42:37.781+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2849) status(3)
11-01 19:42:37.781+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2849) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
11-01 19:42:37.781+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
11-01 19:42:37.781+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2849, appid: org.tizen.homescreen, status: fg
11-01 19:42:37.781+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2849
11-01 19:42:37.781+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2849, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
11-01 19:42:37.781+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2849, appname = org.tizen.homescreen
11-01 19:42:37.781+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2849
11-01 19:42:37.801+0900 W/CRASH_MANAGER(21390): worker.c: worker_job(1204) > 1121152746963147799695
