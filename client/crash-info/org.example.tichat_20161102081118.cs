S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 5570
Date: 2016-11-02 08:11:17+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb35c4c99, esi = 0xb35c7cd8
ebp = 0xb0e3af58, esp = 0xb0e3ae9c
eax = 0xb35c7a9c, ebx = 0xb35c7a9c
ecx = 0x00000000, edx = 0xb0e3aed8
eip = 0xb6d56668

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         4 KB
Cached:     184916 KB
VmPeak:     120828 KB
VmSize:     120828 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30520 KB
VmRSS:       27264 KB
VmData:      54588 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 5570 TID = 5626
5570 5571 5620 5621 5624 5626 

Maps Information
b2b56000 b2b5d000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2b5e000 b2b76000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2b77000 b2b7e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2bfb000 b2c05000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c0b000 b2c17000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c18000 b2c39000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c3e000 b2c3f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c40000 b2c45000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c46000 b2c47000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c48000 b2c4a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c4b000 b2c4d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c4e000 b2c5a000 r-xp /usr/lib/libdrm.so.2.4.0
b2c5b000 b2c5e000 r-xp /usr/lib/libdri2.so.0.0.0
b2c5f000 b2c69000 r-xp /usr/lib/libtbm.so.1.0.0
b2c6a000 b2c6b000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c6c000 b2c81000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c82000 b2c94000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3496000 b34c7000 r-xp /usr/lib/libidn.so.11.5.44
b34c8000 b34ea000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34eb000 b34fb000 r-xp /usr/lib/libcares.so.2.1.0
b34fc000 b351c000 r-xp /usr/lib/libnetwork.so.0.0.0
b351d000 b3526000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3527000 b359e000 r-xp /usr/lib/libcurl.so.4.3.0
b35a0000 b35b4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b35b5000 b35c7000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b36cf000 b36d5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d6000 b381a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3830000 b3831000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3832000 b3833000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3834000 b3837000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3838000 b383b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b383c000 b3875000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4278000 b4283000 r-xp /lib/libnss_files-2.20-2014.11.so
b4285000 b4290000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4292000 b42a9000 r-xp /lib/libnsl-2.20-2014.11.so
b42ad000 b42b5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42b7000 b42db000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42dc000 b42dd000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42de000 b42e1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e2000 b42e9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ea000 b42f4000 r-xp /usr/lib/libsensord-share.so
b42f5000 b4311000 r-xp /usr/lib/libsensor.so.1.2.0
b4313000 b431c000 r-xp /usr/lib/libappcore-common.so.1.1
b431f000 b4321000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4336000 b4338000 r-xp /usr/lib/libXau.so.6.0.0
b4339000 b435b000 r-xp /usr/lib/libxcb.so.1.1.0
b435d000 b4366000 r-xp /lib/libcrypt-2.20-2014.11.so
b438f000 b4391000 r-xp /usr/lib/libiri.so
b4392000 b43b8000 r-xp /lib/libexpat.so.1.5.2
b43ba000 b4425000 r-xp /usr/lib/libssl.so.1.0.0
b442b000 b4437000 r-xp /usr/lib/libethumb.so.1.13.0
b4438000 b443c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b443d000 b468e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c09000 b5c19000 r-xp /usr/lib/libXi.so.6.1.0
b5c1a000 b5c1c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c1d000 b5c23000 r-xp /usr/lib/libXtst.so.6.1.0
b5c24000 b5c2e000 r-xp /usr/lib/libXrender.so.1.3.0
b5c2f000 b5c38000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c3a000 b5c3c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c3d000 b5c42000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c43000 b5c55000 r-xp /usr/lib/libXext.so.6.4.0
b5c56000 b5c58000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c59000 b5c5b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c5d000 b5d9f000 r-xp /usr/lib/libX11.so.6.3.0
b5da3000 b5dad000 r-xp /usr/lib/libXcursor.so.1.0.2
b5dae000 b5dc4000 r-xp /usr/lib/libudev.so.1.6.0
b5dc7000 b5dcb000 r-xp /lib/libattr.so.1.1.0
b5dcc000 b5dfb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dfd000 b5e03000 r-xp /usr/lib/libffi.so.6.0.2
b5e04000 b5e27000 r-xp /lib/libz.so.1.2.8
b5e28000 b5e2b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2c000 b5f88000 r-xp /usr/lib/libxml2.so.2.9.2
b5f8e000 b6075000 r-xp /usr/lib/libstdc++.so.6.0.20
b6082000 b6085000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6086000 b60a8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60a9000 b60bd000 r-xp /lib/libresolv-2.20-2014.11.so
b60c1000 b60e5000 r-xp /usr/lib/liblzma.so.5.0.3
b60e6000 b60e8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ea000 b60f4000 r-xp /usr/lib/libembryo.so.1.13.0
b60f5000 b611e000 r-xp /usr/lib/libpng12.so.0.50.0
b611f000 b6168000 r-xp /usr/lib/libjpeg.so.8.0.2
b6179000 b6180000 r-xp /lib/librt-2.20-2014.11.so
b6182000 b61a1000 r-xp /usr/lib/libector.so.1.13.0
b61a4000 b61d1000 r-xp /usr/lib/liblua-5.1.so
b61d2000 b6262000 r-xp /usr/lib/libfreetype.so.6.11.3
b6266000 b62a4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a5000 b62bb000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bc000 b6315000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6318000 b6363000 r-xp /lib/libm-2.20-2014.11.so
b6365000 b6377000 r-xp /usr/lib/libeio.so.1.13.0
b6378000 b637b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637c000 b6382000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6383000 b63a6000 r-xp /usr/lib/libefreet.so.1.13.0
b63a9000 b63d4000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d5000 b6409000 r-xp /usr/lib/libecore_con.so.1.13.0
b640b000 b6414000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6415000 b641e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b641f000 b6432000 r-xp /usr/lib/libeo.so.1.13.0
b6434000 b6447000 r-xp /usr/lib/libecore_input.so.1.13.0
b6448000 b644f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6450000 b6473000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6474000 b64a0000 r-xp /usr/lib/libeet.so.1.13.0
b64a9000 b6514000 r-xp /usr/lib/libeina.so.1.13.0
b6517000 b652e000 r-xp /usr/lib/libefl.so.1.13.0
b6530000 b6697000 r-xp /usr/lib/libicuuc.so.51.1
b66a5000 b68b1000 r-xp /usr/lib/libicui18n.so.51.1
b68b9000 b6908000 r-xp /usr/lib/libecore_x.so.1.13.0
b690a000 b6924000 r-xp /lib/libgcc_s-4.9.so.1
b6926000 b692a000 r-xp /lib/libcap.so.2.21
b692b000 b6971000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6972000 b6979000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697b000 b69cd000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69cf000 b6b5a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b5f000 b6c2d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c30000 b6c34000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c35000 b6c44000 r-xp /usr/lib/libvconf.so.0.2.45
b6c45000 b6c48000 r-xp /usr/lib/libvasum.so.0.3.1
b6c49000 b6c4c000 r-xp /usr/lib/libttrace.so.1.1
b6c4e000 b6c52000 r-xp /usr/lib/libiniparser.so.0
b6c53000 b6c83000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c84000 b6c8d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c8e000 b6cb3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb4000 b6cc4000 r-xp /usr/lib/libunwind.so.8.0.1
b6cce000 b6e7c000 r-xp /lib/libc-2.20-2014.11.so
b6e84000 b6fc7000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fc9000 b7021000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7022000 b7056000 r-xp /usr/lib/libsystemd.so.0.4.0
b7059000 b712d000 r-xp /usr/lib/libedje.so.1.13.0
b7130000 b715c000 r-xp /usr/lib/libecore.so.1.13.0
b716d000 b7393000 r-xp /usr/lib/libevas.so.1.13.0
b73bb000 b73d3000 r-xp /lib/libpthread-2.20-2014.11.so
b73d7000 b7751000 r-xp /usr/lib/libelementary.so.1.13.0
b7771000 b7775000 r-xp /usr/lib/libsmack.so.1.0.0
b7776000 b777f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7780000 b7783000 r-xp /usr/lib/libdlog.so.0.0.0
b7784000 b7789000 r-xp /usr/lib/libbundle.so.0.1.22
b778a000 b778d000 r-xp /lib/libdl-2.20-2014.11.so
b778f000 b77b4000 r-xp /usr/lib/libaul.so.0.1.0
b77b7000 b77b9000 r-xp /usr/lib/libappsvc.so.0.1.0
b77ba000 b77bf000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77c0000 b77c7000 r-xp /usr/lib/libappcore-efl.so.1.1
b77c9000 b77ce000 r-xp /usr/lib/libsys-assert.so
b77d1000 b77d2000 r-xp [vdso]
b77d2000 b77f4000 r-xp /lib/ld-2.20-2014.11.so
b77f6000 b77fe000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5570)
Call Stack Count: 6
 0: (0xb6d56668) [/lib/libc.so.6] + 0x88668
 1: get_message + 0x109 (0xb35bcda9) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x7da9
 2: (0xb714c3f1) [/usr/lib/libecore.so.1] + 0x1c3f1
 3: (0xb64e5afb) [/usr/lib/libeina.so.1] + 0x3cafb
 4: (0xb73c115f) [/lib/libpthread.so.0] + 0x615f
 5: clone + 0x5e (0xb6db53ee) [/lib/libc.so.6] + 0xe73ee
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
tatus(0)
11-02 08:09:28.207+0900 D/AUL_PAD ( 2987): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
11-02 08:09:28.207+0900 D/AUL_PAD ( 5623): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
11-02 08:09:28.207+0900 D/AUL_PAD ( 2987): sigchild.h: __send_app_launch_signal(131) > send launch signal done
11-02 08:09:28.697+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:28.707+0900 D/AUL_AMD ( 2825): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.tichat /opt/usr/apps/org.example.tichat/bin/tichat
11-02 08:09:28.707+0900 D/RUA     ( 2825): rua.c: rua_add_history(179) > rua_add_history start
11-02 08:09:28.707+0900 D/RUA     ( 2825): rua.c: rua_add_history(247) > rua_add_history ok
11-02 08:09:29.047+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:29.047+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9607400. set autocapital type : 2
11-02 08:09:29.047+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_in(245) > Enter
11-02 08:09:29.047+0900 D/ISE_DEFAULT( 3101): ise.cpp: ise_focus_in(824) > ic : 15c20023 , 0 , g_ic : bad0023 , 0, g_focused_ic : 0 , 1
11-02 08:09:29.047+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9607400. on demand : 0
11-02 08:09:29.047+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:09:29.047+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 0
11-02 08:09:29.057+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb9607400
11-02 08:09:29.057+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): launchpad_loader.c: main(588) > sleeping 1 sec...
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(52) > max_cmdline_size = 1053
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8740760
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(69) > get pre-initialization function
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(73) > get shutdown function
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8740a40
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8742640
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(69) > get pre-initialization function
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preload.h: __preload_init(73) > get shutdown function
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): preexec.h: __preexec_init(76) > preexec start
11-02 08:09:29.237+0900 D/AUL_PAD ( 5623): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
11-02 08:09:29.237+0900 D/AUL     ( 5623): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
11-02 08:09:29.237+0900 D/AUL     ( 5623): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
11-02 08:09:29.237+0900 D/AUL     ( 5623): process_pool.c: __connect_to_launchpad(132) > send(5623) : 4
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
11-02 08:09:29.237+0900 D/AUL_PAD ( 2987): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5623
11-02 08:09:29.237+0900 D/AUL     ( 5623): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
11-02 08:09:29.307+0900 D/AUL_PAD ( 5623): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
11-02 08:09:29.317+0900 D/AUL_PAD ( 5623): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
11-02 08:09:29.317+0900 D/AUL_PAD ( 5623): launchpad_loader.c: main(693) > [candidate] ecore handler add
11-02 08:09:29.317+0900 D/AUL_PAD ( 5623): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
11-02 08:09:29.767+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 1
11-02 08:09:29.767+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb9607400, bidi direction : 0x1
11-02 08:09:29.797+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 2
11-02 08:09:29.947+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 3
11-02 08:09:30.047+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
11-02 08:09:30.317+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 4
11-02 08:09:30.467+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 5
11-02 08:09:30.627+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 6
11-02 08:09:30.747+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9607400, cursor pos : 7
11-02 08:09:30.797+0900 D/RESOURCED( 2876): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-02 08:09:30.797+0900 I/RESOURCED( 2876): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-02 08:09:30.797+0900 D/RESOURCED( 2876): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-02 08:09:30.797+0900 I/RESOURCED( 2876): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-02 08:09:31.117+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9607400
11-02 08:09:31.117+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-02 08:09:31.117+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9607400
11-02 08:09:31.117+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_out(251) > Enter
11-02 08:09:31.127+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9666840. set autocapital type : 0
11-02 08:09:31.127+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_in(245) > Enter
11-02 08:09:31.127+0900 D/ISE_DEFAULT( 3101): ise.cpp: ise_focus_in(824) > ic : 15c30023 , 0 , g_ic : bad0023 , 0, g_focused_ic : 0 , 1
11-02 08:09:31.127+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9666840. on demand : 0
11-02 08:09:31.127+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:09:31.127+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 0
11-02 08:09:31.657+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 1
11-02 08:09:31.657+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb9666840, bidi direction : 0x1
11-02 08:09:31.817+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 2
11-02 08:09:32.027+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 3
11-02 08:09:32.147+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 4
11-02 08:09:32.367+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 5
11-02 08:09:32.417+0900 D/APP_CORE( 2941): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
11-02 08:09:32.417+0900 I/APP_CORE( 2941): appcore-efl.c: __do_app(496) > [APP 2941] Event: MEM_FLUSH State: PAUSED
11-02 08:09:32.417+0900 D/APP_CORE( 2941): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
11-02 08:09:32.417+0900 D/APP_CORE( 2941): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2941
11-02 08:09:32.417+0900 D/APP_CORE( 2941): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
11-02 08:09:32.417+0900 D/RESOURCED( 2876): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2941
11-02 08:09:32.637+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 6
11-02 08:09:32.777+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 7
11-02 08:09:32.827+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 8
11-02 08:09:32.957+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 9
11-02 08:09:33.047+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9666840, cursor pos : 10
11-02 08:09:34.267+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:34.267+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9666840
11-02 08:09:34.267+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-02 08:09:34.267+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9666840
11-02 08:09:34.267+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_out(251) > Enter
11-02 08:09:34.317+0900 I/CAPI_NETWORK_CONNECTION( 5570): connection.c: connection_create(408) > New handle created[0xb9663270]
11-02 08:09:34.317+0900 I/CAPI_NETWORK_CONNECTION( 5570): connection.c: connection_get_type(464) > Connected Network = 3
11-02 08:09:34.317+0900 I/tichat  ( 5570): Network connection type : 3
11-02 08:09:35.047+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x2018d1 bd->visible=1
11-02 08:09:35.336+0900 I/tichat  ( 5570): CURL Returned: 
11-02 08:09:35.336+0900 I/tichat  ( 5570): {"message":"로그인 성공"}
11-02 08:09:35.336+0900 I/tichat  ( 5570): Parsed JSON: "로그인 성공"
11-02 08:09:35.366+0900 I/CAPI_NETWORK_CONNECTION( 5570): connection.c: connection_destroy(426) > Destroy handle: 0xb9663270
11-02 08:09:35.386+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-02 08:09:35.386+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
11-02 08:09:35.386+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
11-02 08:09:35.386+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
11-02 08:09:35.386+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:09:35.386+0900 D/SCIM_HELPER( 3101): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:09:35.386+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:09:35.606+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:09:35.606+0900 D/ISE_DEFAULT( 3101): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
11-02 08:09:41.516+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:41.586+0900 E/EFL     ( 5570): edje<5570> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-02 08:09:41.586+0900 E/EFL     ( 5570): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 08:09:41.746+0900 I/CAPI_NETWORK_CONNECTION( 5570): connection.c: connection_create(408) > New handle created[0xb96c79f8]
11-02 08:09:41.746+0900 I/CAPI_NETWORK_CONNECTION( 5570): connection.c: connection_get_type(464) > Connected Network = 3
11-02 08:09:41.746+0900 I/tichat  ( 5570): Network connection type : 3
11-02 08:09:41.746+0900 I/tichat  ( 5570): socket open success : 49
11-02 08:09:41.756+0900 I/tichat  ( 5570): socket connect success
11-02 08:09:41.756+0900 I/tichat  ( 5570): Sent count: 13, msg:
11-02 08:09:41.766+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:41.766+0900 I/tichat  ( 5570): readroomlist : roomlist/
11-02 08:09:45.156+0900 E/CAPI_NETWORK_WIFI( 2884): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 08:09:45.156+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
11-02 08:09:45.156+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 08:09:45.156+0900 E/INDICATOR( 2884): 
11-02 08:09:50.826+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:50.856+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:50.856+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:50.856+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:51.826+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
11-02 08:09:51.976+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:52.046+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:52.046+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:52.046+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:53.106+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:53.176+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:53.176+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:53.176+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:54.006+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:54.076+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:54.076+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:54.076+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:54.616+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:54.616+0900 E/EFL     ( 5570): edje<5570> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-02 08:09:54.616+0900 E/EFL     ( 5570): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 08:09:54.736+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:54.746+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:54.746+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:55.216+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:55.226+0900 E/EFL     ( 5570): edje<5570> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-02 08:09:55.226+0900 E/EFL     ( 5570): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 08:09:55.346+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:55.346+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:55.346+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:55.706+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:55.766+0900 I/tichat  ( 5570): requset sent: 12, msg:getroomlist/ 
11-02 08:09:55.766+0900 I/tichat  ( 5570): readroomlist : roomlist/cvdfqs$
11-02 08:09:55.766+0900 I/tichat  ( 5570): toked : cvdfqs
11-02 08:09:56.826+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x2018d1 bd->visible=1
11-02 08:09:58.276+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:58.396+0900 I/tichat  ( 5570): Sent count: 16, msg:
11-02 08:09:58.396+0900 E/EFL     ( 5570): elementary<5570> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x8011128e into part 'elm.swallow.indicator_bg'
11-02 08:09:59.626+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:09:59.626+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb978b350. set autocapital type : 2
11-02 08:09:59.626+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_in(245) > Enter
11-02 08:09:59.626+0900 D/ISE_DEFAULT( 3101): ise.cpp: ise_focus_in(824) > ic : 15c40023 , 0 , g_ic : bad0023 , 0, g_focused_ic : 0 , 1
11-02 08:09:59.626+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb978b350. on demand : 0
11-02 08:09:59.626+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:09:59.626+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 0
11-02 08:09:59.626+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb978b350
11-02 08:09:59.636+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:10:00.636+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 1
11-02 08:10:00.636+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb978b350, bidi direction : 0x1
11-02 08:10:00.756+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 2
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 8:10 4 h"
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 8:10"
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 8&#x2236;10"
11-02 08:10:00.766+0900 D/INDICATOR( 2884): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146656172 Time: <font_size=23>8&#x2236;10</font_size> <font_size=22>AM</font_size></font>
11-02 08:10:00.876+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 3
11-02 08:10:00.996+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 4
11-02 08:10:01.156+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 5
11-02 08:10:03.426+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb978b350
11-02 08:10:03.426+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-02 08:10:03.426+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb978b350
11-02 08:10:03.436+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_out(251) > Enter
11-02 08:10:03.446+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:10:03.466+0900 I/tichat  ( 5570): Sent count: 10, msg:
11-02 08:10:03.516+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-02 08:10:03.516+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
11-02 08:10:03.516+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
11-02 08:10:03.516+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
11-02 08:10:03.516+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:10:03.516+0900 D/SCIM_HELPER( 3101): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:10:03.516+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:10:03.776+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:10:03.776+0900 D/ISE_DEFAULT( 3101): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
11-02 08:10:05.156+0900 E/CAPI_NETWORK_WIFI( 2884): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 08:10:05.156+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
11-02 08:10:05.156+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 08:10:05.156+0900 E/INDICATOR( 2884): 
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:22.486+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:25.166+0900 E/CAPI_NETWORK_WIFI( 2884): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 08:10:25.166+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
11-02 08:10:25.166+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 08:10:25.166+0900 E/INDICATOR( 2884): 
11-02 08:10:30.806+0900 D/RESOURCED( 2876): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-02 08:10:30.806+0900 I/RESOURCED( 2876): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-02 08:10:30.806+0900 D/RESOURCED( 2876): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-02 08:10:30.806+0900 I/RESOURCED( 2876): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-02 08:10:38.406+0900 E/EFL     ( 5570): edje<5570> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p11';
11-02 08:10:38.406+0900 E/EFL     ( 5570): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 08:10:38.556+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:10:38.556+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb978b350. set autocapital type : 2
11-02 08:10:38.566+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_in(245) > Enter
11-02 08:10:38.566+0900 D/ISE_DEFAULT( 3101): ise.cpp: ise_focus_in(824) > ic : 15c40023 , 0 , g_ic : bad0023 , 0, g_focused_ic : 0 , 1
11-02 08:10:38.566+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb978b350. on demand : 0
11-02 08:10:38.566+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:10:38.566+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 0
11-02 08:10:38.566+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb978b350
11-02 08:10:38.566+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-02 08:10:38.566+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb978b350
11-02 08:10:38.576+0900 E/EFL     ( 5570): edje<5570> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p12';
11-02 08:10:38.576+0900 E/EFL     ( 5570): By the power of Grayskull, your previous Embryo stack is now broken!
11-02 08:10:38.576+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_out(251) > Enter
11-02 08:10:38.626+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-02 08:10:38.626+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
11-02 08:10:38.626+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
11-02 08:10:38.626+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
11-02 08:10:38.626+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:10:38.626+0900 D/SCIM_HELPER( 3101): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:10:38.626+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:10:38.786+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:10:38.786+0900 D/ISE_DEFAULT( 3101): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
11-02 08:10:39.556+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
11-02 08:10:40.506+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:10:40.506+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb978b350. set autocapital type : 2
11-02 08:10:40.506+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_in(245) > Enter
11-02 08:10:40.506+0900 D/ISE_DEFAULT( 3101): ise.cpp: ise_focus_in(824) > ic : 15c40023 , 0 , g_ic : bad0023 , 0, g_focused_ic : 0 , 1
11-02 08:10:40.516+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb978b350. on demand : 0
11-02 08:10:40.516+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:10:40.516+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 0
11-02 08:10:40.516+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb978b350
11-02 08:10:40.516+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-02 08:10:41.546+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 1
11-02 08:10:41.546+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb978b350, bidi direction : 0x1
11-02 08:10:41.726+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 2
11-02 08:10:41.936+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 3
11-02 08:10:42.056+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb978b350, cursor pos : 4
11-02 08:10:43.346+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2018d1 
11-02 08:10:43.366+0900 D/IMMODULE( 5570): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb978b350
11-02 08:10:43.366+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-02 08:10:43.366+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb978b350
11-02 08:10:43.366+0900 D/ISE_DEFAULT( 3101): ise.cpp: on_focus_out(251) > Enter
11-02 08:10:43.396+0900 I/tichat  ( 5570): Sent count: 9, msg:
11-02 08:10:43.456+0900 D/IMMODULE( 5570): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-02 08:10:43.456+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
11-02 08:10:43.456+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
11-02 08:10:43.456+0900 D/ISF_PANEL_EFL( 3097): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
11-02 08:10:43.456+0900 D/ISF_PANEL_EFL( 3097): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:10:43.456+0900 D/SCIM_HELPER( 3101): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
11-02 08:10:43.456+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:10:43.696+0900 D/LIBSCL_UI( 3101): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
11-02 08:10:43.696+0900 D/ISE_DEFAULT( 3101): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
11-02 08:10:44.566+0900 D/PROCESSMGR( 2687): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x2018d1 bd->visible=1
11-02 08:10:45.186+0900 E/CAPI_NETWORK_WIFI( 2884): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 08:10:45.186+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
11-02 08:10:45.186+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 08:10:45.186+0900 E/INDICATOR( 2884): 
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:10:49.926+0900 E/EFL     ( 5570): ecore<5570> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-02 08:11:00.765+0900 D/INDICATOR( 2884): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-02 08:11:00.765+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-02 08:11:00.765+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-02 08:11:00.765+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 8:11 4 h"
11-02 08:11:00.765+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 8:11"
11-02 08:11:00.765+0900 D/INDICATOR( 2884): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 8&#x2236;11"
11-02 08:11:00.775+0900 D/INDICATOR( 2884): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146654120 Time: <font_size=23>8&#x2236;11</font_size> <font_size=22>AM</font_size></font>
11-02 08:11:05.185+0900 E/CAPI_NETWORK_WIFI( 2884): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-02 08:11:05.185+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
11-02 08:11:05.185+0900 E/INDICATOR( 2884): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-02 08:11:05.185+0900 E/INDICATOR( 2884): 
11-02 08:11:18.065+0900 W/CRASH_MANAGER( 5627): worker.c: worker_job(1204) > 1105570746963147804187
