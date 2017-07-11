S/W Version Information
Model: TM1
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-TM1_20160307.1306
Build-Date: 2016.03.07 13:06:48

Crash Information
Process Name: tichat
PID: 2402
Date: 2015-03-04 03:00:07+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0xb33cb17f
r2   = 0xb33d3a54, r3   = 0x00000000
r4   = 0xb6ace100, r5   = 0xb6ace12c
r6   = 0xb6ace100, r7   = 0xafcf6bd0
r8   = 0xb7c693c8, r9   = 0xafcf7210
r10  = 0xb7c69458, fp   = 0x00000000
ip   = 0xb33d3c4c, sp   = 0xafcf6a78
lr   = 0xb33c7185, pc   = 0xb67bc6f0
cpsr = 0x600f0030

Memory Information
MemTotal:   987328 KB
MemFree:    496732 KB
Buffers:     25504 KB
Cached:     164096 KB
VmPeak:     129996 KB
VmSize:     129992 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28188 KB
VmRSS:       23776 KB
VmData:      53564 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       23168 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 2402 TID = 2492
2402 2406 2483 2484 2487 2492 

Maps Information
af4f9000 afcf8000 rw-p [stack:2492]
b0701000 b0f00000 rw-p [stack:2487]
b1cae000 b24ad000 rw-p [stack:2484]
b2659000 b265e000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b266e000 b267e000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b267f000 b2684000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2705000 b270d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b271e000 b271f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b272f000 b2736000 r-xp /usr/lib/libfeedback.so.0.1.4
b275a000 b276d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2781000 b2786000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2796000 b2797000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b27a7000 b27aa000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b27bb000 b27bc000 r-xp /usr/lib/libxshmfence.so.1.0.0
b27cc000 b27ce000 r-xp /usr/lib/libxcb-present.so.0.0.0
b27de000 b27e0000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b27f0000 b27f8000 r-xp /usr/lib/libdrm.so.2.4.0
b2808000 b280a000 r-xp /usr/lib/libdri2.so.0.0.0
b281a000 b2822000 r-xp /usr/lib/libtbm.so.1.0.0
b2832000 b2833000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2845000 b2846000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2856000 b2862000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2874000 b3073000 rw-p [stack:2483]
b3073000 b30a1000 r-xp /usr/lib/libidn.so.11.5.44
b30b1000 b30c7000 r-xp /usr/lib/libnghttp2.so.5.4.0
b30d8000 b30e2000 r-xp /usr/lib/libcares.so.2.1.0
b30f2000 b3107000 r-xp /usr/lib/libnetwork.so.0.0.0
b3118000 b311f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b312f000 b3175000 r-xp /usr/lib/libcurl.so.4.3.0
b3186000 b3193000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b31a5000 b31b5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b32bd000 b32c1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b32d2000 b33b2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b33c1000 b33cc000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b33d4000 b33fc000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b340e000 b3c0d000 rw-p [stack:2406]
b3c0d000 b3c0f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3e1f000 b3e28000 r-xp /lib/libnss_files-2.20-2014.11.so
b3e39000 b3e42000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3e53000 b3e64000 r-xp /lib/libnsl-2.20-2014.11.so
b3e77000 b3e7d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3e8e000 b3ea8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b3eb9000 b3eba000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b3eca000 b3ecc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3edd000 b3ee2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ef2000 b3ef5000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f06000 b3f0d000 r-xp /usr/lib/libsensord-share.so
b3f1d000 b3f2e000 r-xp /usr/lib/libsensor.so.1.2.0
b3f3f000 b3f45000 r-xp /usr/lib/libappcore-common.so.1.1
b3f68000 b3f6d000 r-xp /usr/lib/libappcore-efl.so.1.1
b3f83000 b3f85000 r-xp /usr/lib/libXau.so.6.0.0
b3f95000 b3fa9000 r-xp /usr/lib/libxcb.so.1.1.0
b3fb9000 b3fc0000 r-xp /lib/libcrypt-2.20-2014.11.so
b3ff8000 b3ffa000 r-xp /usr/lib/libiri.so
b400b000 b4020000 r-xp /lib/libexpat.so.1.5.2
b4032000 b4080000 r-xp /usr/lib/libssl.so.1.0.0
b4095000 b409e000 r-xp /usr/lib/libethumb.so.1.13.0
b40af000 b40b2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b40c2000 b4279000 r-xp /usr/lib/libcrypto.so.1.0.0
b5810000 b5819000 r-xp /usr/lib/libXi.so.6.1.0
b582a000 b582c000 r-xp /usr/lib/libXgesture.so.7.0.0
b583c000 b5840000 r-xp /usr/lib/libXtst.so.6.1.0
b5850000 b5856000 r-xp /usr/lib/libXrender.so.1.3.0
b5866000 b586c000 r-xp /usr/lib/libXrandr.so.2.2.0
b587c000 b587e000 r-xp /usr/lib/libXinerama.so.1.0.0
b588e000 b5891000 r-xp /usr/lib/libXfixes.so.3.1.0
b58a2000 b58ad000 r-xp /usr/lib/libXext.so.6.4.0
b58bd000 b58bf000 r-xp /usr/lib/libXdamage.so.1.1.0
b58cf000 b58d1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b58e1000 b59c4000 r-xp /usr/lib/libX11.so.6.3.0
b59d7000 b59de000 r-xp /usr/lib/libXcursor.so.1.0.2
b59ef000 b5a07000 r-xp /usr/lib/libudev.so.1.6.0
b5a09000 b5a0c000 r-xp /lib/libattr.so.1.1.0
b5a1c000 b5a3c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5a3d000 b5a42000 r-xp /usr/lib/libffi.so.6.0.2
b5a52000 b5a6a000 r-xp /lib/libz.so.1.2.8
b5a7a000 b5a7c000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5a8c000 b5b61000 r-xp /usr/lib/libxml2.so.2.9.2
b5b76000 b5c11000 r-xp /usr/lib/libstdc++.so.6.0.20
b5c2d000 b5c30000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5c40000 b5c5a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5c6a000 b5c7b000 r-xp /lib/libresolv-2.20-2014.11.so
b5c8f000 b5ca6000 r-xp /usr/lib/liblzma.so.5.0.3
b5cb6000 b5cb8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5cc8000 b5ccf000 r-xp /usr/lib/libembryo.so.1.13.0
b5cdf000 b5cf7000 r-xp /usr/lib/libpng12.so.0.50.0
b5d08000 b5d2b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5d4b000 b5d51000 r-xp /lib/librt-2.20-2014.11.so
b5d62000 b5d76000 r-xp /usr/lib/libector.so.1.13.0
b5d87000 b5d9f000 r-xp /usr/lib/liblua-5.1.so
b5db0000 b5e07000 r-xp /usr/lib/libfreetype.so.6.11.3
b5e1b000 b5e43000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5e54000 b5e67000 r-xp /usr/lib/libfribidi.so.0.3.1
b5e78000 b5eb2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5ec3000 b5f2e000 r-xp /lib/libm-2.20-2014.11.so
b5f3f000 b5f4c000 r-xp /usr/lib/libeio.so.1.13.0
b5f5c000 b5f5e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5f6e000 b5f73000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5f83000 b5f9a000 r-xp /usr/lib/libefreet.so.1.13.0
b5fac000 b5fcc000 r-xp /usr/lib/libeldbus.so.1.13.0
b5fdc000 b5ffc000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ffe000 b6004000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6014000 b601b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b602b000 b6039000 r-xp /usr/lib/libeo.so.1.13.0
b6049000 b605b000 r-xp /usr/lib/libecore_input.so.1.13.0
b606c000 b6071000 r-xp /usr/lib/libecore_file.so.1.13.0
b6081000 b6099000 r-xp /usr/lib/libecore_evas.so.1.13.0
b60aa000 b60c7000 r-xp /usr/lib/libeet.so.1.13.0
b60e0000 b6128000 r-xp /usr/lib/libeina.so.1.13.0
b6139000 b6149000 r-xp /usr/lib/libefl.so.1.13.0
b615a000 b623f000 r-xp /usr/lib/libicuuc.so.51.1
b625c000 b639c000 r-xp /usr/lib/libicui18n.so.51.1
b63b3000 b63eb000 r-xp /usr/lib/libecore_x.so.1.13.0
b63fd000 b6400000 r-xp /lib/libcap.so.2.21
b6410000 b6439000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b644a000 b6451000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6463000 b6499000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b64aa000 b6592000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b65a6000 b661c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b662e000 b6631000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6641000 b664c000 r-xp /usr/lib/libvconf.so.0.2.45
b665c000 b665e000 r-xp /usr/lib/libvasum.so.0.3.1
b666e000 b6670000 r-xp /usr/lib/libttrace.so.1.1
b6680000 b6683000 r-xp /usr/lib/libiniparser.so.0
b6693000 b66b6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b66c6000 b66cb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b66dc000 b66f3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6704000 b6711000 r-xp /usr/lib/libunwind.so.8.0.1
b6747000 b686b000 r-xp /lib/libc-2.20-2014.11.so
b6880000 b6899000 r-xp /lib/libgcc_s-4.9.so.1
b68a9000 b698b000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b699c000 b69d0000 r-xp /usr/lib/libdbus-1.so.3.8.11
b69e0000 b6a1a000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a1c000 b6a9c000 r-xp /usr/lib/libedje.so.1.13.0
b6a9f000 b6abd000 r-xp /usr/lib/libecore.so.1.13.0
b6add000 b6c3f000 r-xp /usr/lib/libevas.so.1.13.0
b6c76000 b6c8a000 r-xp /lib/libpthread-2.20-2014.11.so
b6c9e000 b6ec2000 r-xp /usr/lib/libelementary.so.1.13.0
b6ef0000 b6ef4000 r-xp /usr/lib/libsmack.so.1.0.0
b6f04000 b6f0a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f1b000 b6f1d000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2d000 b6f30000 r-xp /usr/lib/libbundle.so.0.1.22
b6f40000 b6f42000 r-xp /lib/libdl-2.20-2014.11.so
b6f53000 b6f6c000 r-xp /usr/lib/libaul.so.0.1.0
b6f7e000 b6f80000 r-xp /usr/lib/libappsvc.so.0.1.0
b6f91000 b6f95000 r-xp /usr/lib/libsys-assert.so
b6fa6000 b6fc6000 r-xp /lib/ld-2.20-2014.11.so
b6fd7000 b6fdd000 r-xp /usr/bin/launchpad-loader
b79cc000 b7d3f000 rw-p [heap]
bea6a000 bea8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2402)
Call Stack Count: 1
 0: (0xb67bc6f0) [/lib/libc.so.6] + 0x756f0
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
lutils-linux.cpp: log(325) > Destoyed Timer : 100 0x80124797
03-04 02:58:32.472+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x801085a7
03-04 02:58:32.472+0900 D/IMMODULE( 2402): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb7cf20a0, cursor pos : 8
03-04 02:58:32.472+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: isf_imf_context_input_panel_caps_mode_set(734) > [SECURE_LOG] ctx : 0xb7cf20a0, mode : 0
03-04 02:58:32.472+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 02:58:32.472+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 02:58:32.572+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 02:58:32.572+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 02:58:32.572+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x801085a7
03-04 02:58:32.572+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Returning Timer : 105 0
03-04 02:58:32.692+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 628 808, 628 0
03-04 02:58:32.692+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 02:58:32.762+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2011f5 
03-04 02:58:32.772+0900 D/IMMODULE( 2402): isf_imf_context.cpp: isf_imf_context_focus_out(1589) > ctx : 0xb7cf20a0
03-04 02:58:32.772+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
03-04 02:58:32.772+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7cf20a0
03-04 02:58:32.772+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_focus_out(251) > Enter
03-04 02:58:32.802+0900 I/tichat  ( 2402): Sent count: 13, msg:
03-04 02:58:32.822+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
03-04 02:58:32.822+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
03-04 02:58:32.822+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_hide_ise(5748) > slot_hide_ise ()
03-04 02:58:32.822+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: hide_ise(3860) > send request to hide helper
03-04 02:58:32.822+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 02:58:32.822+0900 D/SCIM_HELPER( 1099): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 02:58:32.822+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 02:58:32.822+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_client_message_cb(6409) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
03-04 02:58:32.832+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 02:58:32.832+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 02:58:32.832+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 02:58:32.832+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb7cf20a0
03-04 02:58:32.832+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb7cf20a0
03-04 02:58:32.832+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _process_ise_panel_hided(1080) > received_will_hide_event = 1
03-04 02:58:32.832+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5763) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (5a, 3000002)
03-04 02:58:32.832+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5765) > calling ui_candidate_hide (true, false)
03-04 02:58:32.832+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 02:58:32.832+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300001b)
03-04 02:58:32.832+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00003), visible:1
03-04 02:58:32.842+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x3e00003 (basewin 0x8000321a mag 0x8000fc7f)
03-04 02:58:32.842+0900 D/ISE_DEFAULT( 1099): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
03-04 02:58:32.842+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x1282828), gem(27), surface(0x139f720)
03-04 02:58:32.852+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x13540c0), gem(25), surface(0x12d83e8)
03-04 02:58:32.852+0900 W/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2402
03-04 02:58:32.852+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-04 02:58:32.873+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 02:58:32.873+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 02:58:32.873+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 02:58:32.873+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 02:58:32.873+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 02:58:32.873+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 02:58:32.873+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300001b)
03-04 02:58:32.873+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 02:58:32.883+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_settle_candidate_window(3397) > Moving candidate window to : 0 1196
03-04 02:58:32.883+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 02:58:32.883+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 02:58:32.883+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 02:58:32.883+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 02:58:32.883+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300001b)
03-04 02:58:32.883+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 02:58:32.893+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 02:58:33.583+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 02:58:33.583+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 02:58:33.763+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
03-04 02:58:34.574+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 02:58:34.574+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 02:58:35.775+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_destroy_candidate_window(3253) > calling ui_candidate_hide (true)
03-04 02:58:35.775+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 02:58:35.775+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1200002 FAILED!
03-04 02:58:35.775+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 02:58:35.775+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 02:58:35.775+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 02:58:35.775+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300001b)
03-04 02:58:35.785+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 02:58:35.785+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 02:58:35.825+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 02:58:35.825+0900 D/IMMODULE( 2402): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 02:58:38.578+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 02:58:38.578+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 02:58:38.768+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x2011f5 bd->visible=1
03-04 02:58:39.589+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 02:58:39.589+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 02:58:42.162+0900 I/tichat  ( 2402): load message : kjklj,mn
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.162+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.172+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.182+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.192+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.192+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.192+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 02:58:42.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 02:58:42.592+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 02:58:43.573+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 02:58:43.573+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 02:58:59.308+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
03-04 02:58:59.308+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
03-04 02:58:59.308+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
03-04 02:58:59.308+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 2:59 4 h"
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 2:59"
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 2&#x2236;59"
03-04 02:59:00.259+0900 D/INDICATOR(  907): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146659763 Time: <font_size=33>2&#x2236;59</font_size> <font_size=32>AM</font_size></font>
03-04 02:59:16.585+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_add_capacity(1179) > 90 -> 91 1425405556 470 470215
03-04 02:59:16.585+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 91 300 117 45
03-04 02:59:16.585+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 91 0 0 35
03-04 02:59:16.585+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 91 285 6 43
03-04 02:59:16.585+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 91 250 5 38
03-04 02:59:16.585+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 91 250 5 38
03-04 02:59:16.585+0900 D/RESOURCED(  872): heart-battery.c: heart_battery_add_capacity(1267) > battery_heart_capacity_write 91 diff_capacity 1, used time 0, charging time 470215, charger status 1, reset_mark 1
03-04 02:59:16.585+0900 D/RESOURCED(  872): logging.c: logging_leveldb_putv(530) > BATTERY_USED_TIME:522022 530330 
03-04 02:59:16.595+0900 D/INDICATOR(  907): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 91"
03-04 02:59:16.595+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
03-04 02:59:16.595+0900 D/INDICATOR(  907): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
03-04 02:59:16.595+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
03-04 02:59:16.595+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 0, Minictrl count : 3
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 0, Minictrl count : 3
03-04 02:59:16.595+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(269) > default
03-04 02:59:16.595+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-04 02:59:16.595+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-04 02:59:16.595+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 02:59:16.595+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
03-04 02:59:16.595+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
03-04 02:59:16.595+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.show"
03-04 02:59:16.595+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 02:59:16.605+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 02:59:16.605+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 02:59:16.605+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 1
03-04 02:59:16.605+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
03-04 02:59:16.605+0900 D/INDICATOR(  907): icon.c: _hide_more_noti(779) > port :: hide more icon
03-04 02:59:59.337+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
03-04 02:59:59.337+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
03-04 02:59:59.337+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
03-04 02:59:59.337+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
03-04 02:59:59.337+0900 I/RESOURCED(  872): logging.c: logging_save_to_storage(978) > cpu cache is empty
03-04 02:59:59.998+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __alarm_handler_idle(1772) > Lock the display not to enter LCD OFF
03-04 02:59:59.998+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __display_lock_state(2103) > Lock LCD OFF is successfully done
03-04 02:59:59.998+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_handler_idle(1781) > __alarm_handler_idle
03-04 02:59:59.998+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1523) > [alarm-server]: Enter
03-04 02:59:59.998+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1532) > [alarm-server]: c_due_time(1425405600), current_time(1425405600), interval(0.000000)
03-04 02:59:59.998+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1557) > zone /
03-04 02:59:59.998+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1644) > [SECURE_LOG] [alarm-server]:destination is null, so we send expired alarm to ALARM.contextd(220).
03-04 02:59:59.998+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1659) > [SECURE_LOG] [alarm-server]: destination_app_service_name :ALARM.acontextd, app_pid=1016
03-04 03:00:00.008+0900 D/PKGMGR_INFO(  869): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1630) > [SECURE_LOG] Appid[contextd] not found in DB
03-04 03:00:00.008+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1690) > appid : contextd (0)
03-04 03:00:00.008+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1725) > before alarm_send_noti_to_application
03-04 03:00:00.008+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1726) > WAKEUP pid: 1016
03-04 03:00:00.008+0900 W/AUL     (  869): app_signal.c: aul_update_freezer_status(324) > send_update_freezer_status, pid: 1016, type: wakeup
03-04 03:00:00.008+0900 D/RESOURCED(  872): proc-monitor.c: proc_dbus_exclude_signal_handler(474) > call proc_dbus_exclude_signal_handler : pid = 1016, str = wakeup
03-04 03:00:00.008+0900 E/RESOURCED(  872): freezer-process.c: freezer_process_pid_set(148) > Cant find process info for 1016
03-04 03:00:00.008+0900 E/RESOURCED(  872): freezer-process.c: freezer_process_pid_set(150) > freezer_process_pid_set 1016 foreground
03-04 03:00:00.008+0900 I/ALARM_MANAGER(  869): alarm-manager.c: __alarm_send_noti_to_application(1439) > [SECURE_LOG] [alarm server][send expired_alarm(alarm_id=1856502228) to app_service_name(ALARM.acontextd)]
03-04 03:00:00.008+0900 E/ALARM_MANAGER( 1016): alarm-lib.c: __handle_expiry_method_call(168) > [alarm-lib] : Alarm expired for [ALARM.acontextd] : Alarm id [1856502228]
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1730) > after __alarm_send_noti_to_application
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1734) > alarm_id[1856502228] is expired.
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: _alarm_next_duetime(458) > mode->repeat is 2
03-04 03:00:00.028+0900 E/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(363) > 3:0:0. duetime = 1425405600, isdst = 0
03-04 03:00:00.028+0900 E/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(366) > duetime is less than or equal to current time. current_dst = 0
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(372) > [SECURE_LOG] 3:0:0. duetime = 1425405600
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(393) > [SECURE_LOG] before_dst = 0
03-04 03:00:00.028+0900 E/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(397) > current_time(1425405600) due_time(1425405600)
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(423) > interval : 1
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(429) > [SECURE_LOG] after_dst = 0
03-04 03:00:00.028+0900 E/ALARM_MANAGER(  869): alarm-manager-schedule.c: __alarm_next_duetime_weekly(438) > Final due_time = 1425492000
03-04 03:00:00.028+0900 E/ALARM_MANAGER(  869): alarm-manager-schedule.c: _alarm_next_duetime(490) > alarm_id: 1856502228, next duetime: 1425492000
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __alarm_expired(1753) > [alarm-server]: Leave
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(520) > [SECURE_LOG] alarm[1856502228] with duetime(1425492000) at current(1425405600) pid: (1016)
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(94) > [SECURE_LOG] _add_to_scheduled_alarm_list :alarm->pid =1016, app_service_name=ALARM.contextd(220)
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-schedule.c: _add_to_scheduled_alarm_list(96) > [SECURE_LOG] _add_to_scheduled_alarm_list :target zone : [/]
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager-timer.c: _alarm_set_timer(80) > [alarm-server][timer]: remain time from current is 86400.000000 , due_time is 1425492000.
03-04 03:00:00.028+0900 D/ALARM_MANAGER(  869): alarm-manager.c: __rtc_set(219) > alarm_context.c_due_time is 1425492000.
03-04 03:00:00.038+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __rtc_set(230) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
03-04 03:00:00.038+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __rtc_set(237) > Setted RTC Alarm date/time is 4-3-2015, 18:00:00 (UTC).
03-04 03:00:00.038+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __rtc_set(252) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
03-04 03:00:00.038+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __alarm_handler_idle(1798) > Unlock the display from LCD OFF
03-04 03:00:00.048+0900 E/ALARM_MANAGER(  869): alarm-manager.c: __display_unlock_state(2147) > Unlock LCD OFF is successfully done
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 3:00 4 h"
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 3:00"
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 3&#x2236;00"
03-04 03:00:00.298+0900 D/INDICATOR(  907): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146650529 Time: <font_size=33>3&#x2236;00</font_size> <font_size=32>AM</font_size></font>
03-04 03:00:00.798+0900 I/tichat  ( 2402): load message : sadfsadfsdf
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.808+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.818+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.818+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.818+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.818+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:00.828+0900 E/EFL     ( 2402): ecore<2402> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:00:01.599+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:00:01.599+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:00:02.580+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:00:02.580+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:00:03.151+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2011f5 
03-04 03:00:03.151+0900 D/IMMODULE( 2402): isf_imf_context.cpp: isf_imf_context_filter_event(2149) > [Mouse-up event] ctx : 0xb7cf20a0
03-04 03:00:03.151+0900 E/IMMODULE( 2402): isf_imf_context.cpp: isf_imf_context_filter_event(2159) > Can't show IME because there is no focus. ctx : 0xb7cf20a0
03-04 03:00:03.161+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 1 -> 3
03-04 03:00:03.161+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 1 -> 3
03-04 03:00:03.161+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:00:03.161+0900 D/APP_CORE( 2402): appcore-rotation.c: __changed_cb(121) > [APP 2402] Rotation: 1 -> 3
03-04 03:00:03.161+0900 D/APP_CORE( 2402): appcore-rotation.c: __changed_cb(124) > [APP 2402] Rotation: 1 -> 3
03-04 03:00:03.161+0900 I/CAPI_APPFW_APPLICATION( 2402): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:00:03.761+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 3 -> 1
03-04 03:00:03.761+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 3 -> 1
03-04 03:00:03.761+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:00:03.761+0900 D/APP_CORE( 2402): appcore-rotation.c: __changed_cb(121) > [APP 2402] Rotation: 3 -> 1
03-04 03:00:03.761+0900 D/APP_CORE( 2402): appcore-rotation.c: __changed_cb(124) > [APP 2402] Rotation: 3 -> 1
03-04 03:00:03.761+0900 I/CAPI_APPFW_APPLICATION( 2402): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:00:04.152+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
03-04 03:00:06.584+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:00:06.584+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:00:07.395+0900 E/EFL     (  535): eo<535> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-04 03:00:07.405+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-04 03:00:07.405+0900 I/AUL_PAD ( 1001): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 2402 pgid = 2402
03-04 03:00:07.405+0900 I/AUL_PAD ( 1001): sigchild.h: __sigchild_action(141) > dead_pid(2402)
03-04 03:00:07.425+0900 D/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2887) > pid(934) status(3)
03-04 03:00:07.425+0900 D/AUL_AMD (  821): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
03-04 03:00:07.425+0900 W/AUL_AMD (  821): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-04 03:00:07.425+0900 W/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2891) > back key ungrab error
03-04 03:00:07.425+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(456) > pid(934) status(3)
03-04 03:00:07.425+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(468) > pid(934) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
03-04 03:00:07.425+0900 D/AUL     (  821): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
03-04 03:00:07.425+0900 W/AUL     (  821): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 934, appid: org.tizen.homescreen, status: fg
03-04 03:00:07.435+0900 D/RESOURCED(  872): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 934
03-04 03:00:07.435+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 934, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
03-04 03:00:07.435+0900 D/RESOURCED(  872): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 934, appname = org.tizen.homescreen
03-04 03:00:07.435+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 934
03-04 03:00:07.435+0900 E/RESOURCED(  872): freezer-process.c: freezer_process_pid_set(160) > freezer_process_pid_set 934 foreground
03-04 03:00:07.435+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
03-04 03:00:07.435+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200002), visible:1
03-04 03:00:07.445+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x125d890), gem(20), surface(0x13836c0)
03-04 03:00:07.465+0900 D/INDICATOR(  907): main.c: _property_changed_cb(432) > UNSNIFF API 1200002
03-04 03:00:07.465+0900 D/AUL_PAD ( 1001): sigchild.h: __send_app_dead_signal(90) > send dead signal done
03-04 03:00:07.465+0900 I/AUL_PAD ( 1001): sigchild.h: __sigchild_action(147) > __send_app_dead_signal(0)
03-04 03:00:07.465+0900 I/AUL_PAD ( 1001): sigchild.h: __launchpad_process_sigchld(168) > after __sigchild_action
03-04 03:00:07.465+0900 E/AUL_PAD ( 1001): launchpad.c: main(688) > error reading sigchld info
03-04 03:00:07.465+0900 I/ESD     ( 1007): esd_main.c: __esd_app_dead_handler(1771) > pid: 2402
03-04 03:00:07.465+0900 D/STARTER (  875): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 2402 is termianted
03-04 03:00:07.465+0900 D/STARTER (  875): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
03-04 03:00:07.465+0900 W/AUL_AMD (  821): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 2402
03-04 03:00:07.465+0900 W/AUL_AMD (  821): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 2402
03-04 03:00:07.465+0900 D/AUL_AMD (  821): amd_key.c: _unregister_key_event(179) > ===key stack===
03-04 03:00:07.465+0900 E/AUL_AMD (  821): amd_launch.c: _revoke_temporary_permission(2128) > list or callee_label was null
03-04 03:00:07.465+0900 D/AUL_AMD (  821): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.tichat)
03-04 03:00:07.465+0900 D/AUL     (  821): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-04 03:00:07.465+0900 E/AUL     (  821): simple_util.c: __trm_app_info_send_socket(330) > access
03-04 03:00:07.475+0900 E/RESOURCED(  872): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.232
03-04 03:00:07.475+0900 D/RESOURCED(  872): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 2402
03-04 03:00:07.475+0900 D/RESOURCED(  872): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.tichat, pkgname = org.example.tichat, ref = 0
03-04 03:00:07.495+0900 W/CRASH_MANAGER( 2584): worker.c: worker_job(1204) > 1102402746963142540560
