S/W Version Information
Model: TM1
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-TM1_20160307.1306
Build-Date: 2016.03.07 13:06:48

Crash Information
Process Name: tichat
PID: 3059
Date: 2015-03-04 03:33:44+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0xb339617f
r2   = 0xb339ea5c, r3   = 0x00000000
r4   = 0xb6a99100, r5   = 0xb6a9912c
r6   = 0xb6a99100, r7   = 0xaf13ebd0
r8   = 0xb86ea008, r9   = 0xaf13f210
r10  = 0xb86ea098, fp   = 0x00000000
ip   = 0xb339ec54, sp   = 0xaf13ea78
lr   = 0xb3392185, pc   = 0xb67876f0
cpsr = 0x60070030

Memory Information
MemTotal:   987328 KB
MemFree:    477416 KB
Buffers:     27204 KB
Cached:     166964 KB
VmPeak:     138768 KB
VmSize:     138764 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31520 KB
VmRSS:       31064 KB
VmData:      60912 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       23168 KB
VmPTE:          94 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3059 TID = 3104
3059 3061 3091 3096 3104 

Maps Information
ae941000 af140000 rw-p [stack:3104]
afc21000 b0420000 rw-p [stack:3096]
b1c79000 b2478000 rw-p [stack:3091]
b2624000 b2629000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2639000 b2649000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b264a000 b264f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b26d0000 b26d8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b26e9000 b26ea000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b26fa000 b2701000 r-xp /usr/lib/libfeedback.so.0.1.4
b2725000 b2738000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b274c000 b2751000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2761000 b2762000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2772000 b2775000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2786000 b2787000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2797000 b2799000 r-xp /usr/lib/libxcb-present.so.0.0.0
b27a9000 b27ab000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b27bb000 b27c3000 r-xp /usr/lib/libdrm.so.2.4.0
b27d3000 b27d5000 r-xp /usr/lib/libdri2.so.0.0.0
b27e5000 b27ed000 r-xp /usr/lib/libtbm.so.1.0.0
b27fd000 b27fe000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2810000 b2811000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2821000 b282d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b283f000 b303e000 rw-p [stack:3090]
b303e000 b306c000 r-xp /usr/lib/libidn.so.11.5.44
b307c000 b3092000 r-xp /usr/lib/libnghttp2.so.5.4.0
b30a3000 b30ad000 r-xp /usr/lib/libcares.so.2.1.0
b30bd000 b30d2000 r-xp /usr/lib/libnetwork.so.0.0.0
b30e3000 b30ea000 r-xp /usr/lib/libefl-extension.so.0.1.0
b30fa000 b3140000 r-xp /usr/lib/libcurl.so.4.3.0
b3151000 b315e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b3170000 b3180000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b3288000 b328c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b329d000 b337d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b338c000 b3397000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b339f000 b33c7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b33d9000 b3bd8000 rw-p [stack:3061]
b3bd8000 b3bda000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3dea000 b3df3000 r-xp /lib/libnss_files-2.20-2014.11.so
b3e04000 b3e0d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3e1e000 b3e2f000 r-xp /lib/libnsl-2.20-2014.11.so
b3e42000 b3e48000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3e59000 b3e73000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b3e84000 b3e85000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b3e95000 b3e97000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ea8000 b3ead000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ebd000 b3ec0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ed1000 b3ed8000 r-xp /usr/lib/libsensord-share.so
b3ee8000 b3ef9000 r-xp /usr/lib/libsensor.so.1.2.0
b3f0a000 b3f10000 r-xp /usr/lib/libappcore-common.so.1.1
b3f33000 b3f38000 r-xp /usr/lib/libappcore-efl.so.1.1
b3f4e000 b3f50000 r-xp /usr/lib/libXau.so.6.0.0
b3f60000 b3f74000 r-xp /usr/lib/libxcb.so.1.1.0
b3f84000 b3f8b000 r-xp /lib/libcrypt-2.20-2014.11.so
b3fc3000 b3fc5000 r-xp /usr/lib/libiri.so
b3fd6000 b3feb000 r-xp /lib/libexpat.so.1.5.2
b3ffd000 b404b000 r-xp /usr/lib/libssl.so.1.0.0
b4060000 b4069000 r-xp /usr/lib/libethumb.so.1.13.0
b407a000 b407d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b408d000 b4244000 r-xp /usr/lib/libcrypto.so.1.0.0
b57db000 b57e4000 r-xp /usr/lib/libXi.so.6.1.0
b57f5000 b57f7000 r-xp /usr/lib/libXgesture.so.7.0.0
b5807000 b580b000 r-xp /usr/lib/libXtst.so.6.1.0
b581b000 b5821000 r-xp /usr/lib/libXrender.so.1.3.0
b5831000 b5837000 r-xp /usr/lib/libXrandr.so.2.2.0
b5847000 b5849000 r-xp /usr/lib/libXinerama.so.1.0.0
b5859000 b585c000 r-xp /usr/lib/libXfixes.so.3.1.0
b586d000 b5878000 r-xp /usr/lib/libXext.so.6.4.0
b5888000 b588a000 r-xp /usr/lib/libXdamage.so.1.1.0
b589a000 b589c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b58ac000 b598f000 r-xp /usr/lib/libX11.so.6.3.0
b59a2000 b59a9000 r-xp /usr/lib/libXcursor.so.1.0.2
b59ba000 b59d2000 r-xp /usr/lib/libudev.so.1.6.0
b59d4000 b59d7000 r-xp /lib/libattr.so.1.1.0
b59e7000 b5a07000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5a08000 b5a0d000 r-xp /usr/lib/libffi.so.6.0.2
b5a1d000 b5a35000 r-xp /lib/libz.so.1.2.8
b5a45000 b5a47000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5a57000 b5b2c000 r-xp /usr/lib/libxml2.so.2.9.2
b5b41000 b5bdc000 r-xp /usr/lib/libstdc++.so.6.0.20
b5bf8000 b5bfb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5c0b000 b5c25000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5c35000 b5c46000 r-xp /lib/libresolv-2.20-2014.11.so
b5c5a000 b5c71000 r-xp /usr/lib/liblzma.so.5.0.3
b5c81000 b5c83000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c93000 b5c9a000 r-xp /usr/lib/libembryo.so.1.13.0
b5caa000 b5cc2000 r-xp /usr/lib/libpng12.so.0.50.0
b5cd3000 b5cf6000 r-xp /usr/lib/libjpeg.so.8.0.2
b5d16000 b5d1c000 r-xp /lib/librt-2.20-2014.11.so
b5d2d000 b5d41000 r-xp /usr/lib/libector.so.1.13.0
b5d52000 b5d6a000 r-xp /usr/lib/liblua-5.1.so
b5d7b000 b5dd2000 r-xp /usr/lib/libfreetype.so.6.11.3
b5de6000 b5e0e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5e1f000 b5e32000 r-xp /usr/lib/libfribidi.so.0.3.1
b5e43000 b5e7d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e8e000 b5ef9000 r-xp /lib/libm-2.20-2014.11.so
b5f0a000 b5f17000 r-xp /usr/lib/libeio.so.1.13.0
b5f27000 b5f29000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5f39000 b5f3e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5f4e000 b5f65000 r-xp /usr/lib/libefreet.so.1.13.0
b5f77000 b5f97000 r-xp /usr/lib/libeldbus.so.1.13.0
b5fa7000 b5fc7000 r-xp /usr/lib/libecore_con.so.1.13.0
b5fc9000 b5fcf000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5fdf000 b5fe6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ff6000 b6004000 r-xp /usr/lib/libeo.so.1.13.0
b6014000 b6026000 r-xp /usr/lib/libecore_input.so.1.13.0
b6037000 b603c000 r-xp /usr/lib/libecore_file.so.1.13.0
b604c000 b6064000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6075000 b6092000 r-xp /usr/lib/libeet.so.1.13.0
b60ab000 b60f3000 r-xp /usr/lib/libeina.so.1.13.0
b6104000 b6114000 r-xp /usr/lib/libefl.so.1.13.0
b6125000 b620a000 r-xp /usr/lib/libicuuc.so.51.1
b6227000 b6367000 r-xp /usr/lib/libicui18n.so.51.1
b637e000 b63b6000 r-xp /usr/lib/libecore_x.so.1.13.0
b63c8000 b63cb000 r-xp /lib/libcap.so.2.21
b63db000 b6404000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6415000 b641c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b642e000 b6464000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6475000 b655d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6571000 b65e7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b65f9000 b65fc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b660c000 b6617000 r-xp /usr/lib/libvconf.so.0.2.45
b6627000 b6629000 r-xp /usr/lib/libvasum.so.0.3.1
b6639000 b663b000 r-xp /usr/lib/libttrace.so.1.1
b664b000 b664e000 r-xp /usr/lib/libiniparser.so.0
b665e000 b6681000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6691000 b6696000 r-xp /usr/lib/libxdgmime.so.1.1.0
b66a7000 b66be000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b66cf000 b66dc000 r-xp /usr/lib/libunwind.so.8.0.1
b6712000 b6836000 r-xp /lib/libc-2.20-2014.11.so
b684b000 b6864000 r-xp /lib/libgcc_s-4.9.so.1
b6874000 b6956000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6967000 b699b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b69ab000 b69e5000 r-xp /usr/lib/libsystemd.so.0.4.0
b69e7000 b6a67000 r-xp /usr/lib/libedje.so.1.13.0
b6a6a000 b6a88000 r-xp /usr/lib/libecore.so.1.13.0
b6aa8000 b6c0a000 r-xp /usr/lib/libevas.so.1.13.0
b6c41000 b6c55000 r-xp /lib/libpthread-2.20-2014.11.so
b6c69000 b6e8d000 r-xp /usr/lib/libelementary.so.1.13.0
b6ebb000 b6ebf000 r-xp /usr/lib/libsmack.so.1.0.0
b6ecf000 b6ed5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee6000 b6ee8000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef8000 b6efb000 r-xp /usr/lib/libbundle.so.0.1.22
b6f0b000 b6f0d000 r-xp /lib/libdl-2.20-2014.11.so
b6f1e000 b6f37000 r-xp /usr/lib/libaul.so.0.1.0
b6f49000 b6f4b000 r-xp /usr/lib/libappsvc.so.0.1.0
b6f5c000 b6f60000 r-xp /usr/lib/libsys-assert.so
b6f71000 b6f91000 r-xp /lib/ld-2.20-2014.11.so
b6fa2000 b6fa8000 r-xp /usr/bin/launchpad-loader
b854b000 b8903000 rw-p [heap]
bec4e000 bec6f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3059)
Call Stack Count: 1
 0: (0xb67876f0) [/lib/libc.so.6] + 0x756f0
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
SE_DEFAULT( 1099): ise.cpp: on_focus_out(251) > Enter
03-04 03:31:18.450+0900 I/tichat  ( 3059): title : Dsds id : test
03-04 03:31:18.450+0900 I/tichat  ( 3059): Sent count: 16, msg:
03-04 03:31:18.460+0900 I/tichat  ( 3059): Sent count: 14, msg:
03-04 03:31:18.470+0900 E/EFL     ( 3059): elementary<3059> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x80073f9b into part 'elm.swallow.indicator_bg'
03-04 03:31:18.540+0900 D/IMMODULE( 3059): isf_imf_context.cpp: isf_imf_context_del(1300) > ctx : 0xb887fe70
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:31:18.540+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:31:18.540+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb887fe70
03-04 03:31:18.540+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
03-04 03:31:18.540+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb887fe70
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_hide_ise(5748) > slot_hide_ise ()
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: hide_ise(3860) > send request to hide helper
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 03:31:18.540+0900 D/SCIM_HELPER( 1099): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 03:31:18.540+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5763) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (5a, 3000002)
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5765) > calling ui_candidate_hide (true, false)
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300004d)
03-04 03:31:18.540+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_client_message_cb(6409) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
03-04 03:31:18.540+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00003), visible:1
03-04 03:31:18.550+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x1352930), gem(19), surface(0x13ebfb0)
03-04 03:31:18.550+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:31:18.550+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 03:31:18.550+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 03:31:18.550+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x127c6f0), gem(29), surface(0x13da300)
03-04 03:31:18.550+0900 W/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3059
03-04 03:31:18.550+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-04 03:31:18.560+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x3e00003 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:31:18.560+0900 D/ISE_DEFAULT( 1099): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
03-04 03:31:18.560+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:31:18.560+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(646) > [EGL-X11] eglimage target 30b0 imported bo(0x13104a0), gem(23), surface(0x12d8648)
03-04 03:31:18.580+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 03:31:18.580+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 03:31:18.580+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 03:31:18.580+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 03:31:18.580+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:31:18.580+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300004d)
03-04 03:31:18.590+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 03:31:18.590+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:31:18.590+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:31:18.590+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_settle_candidate_window(3397) > Moving candidate window to : 0 1196
03-04 03:31:18.590+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 03:31:18.590+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 03:31:18.590+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 03:31:18.590+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:31:18.590+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300004d)
03-04 03:31:18.590+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:31:18.590+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:31:18.620+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:31:18.620+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:31:18.620+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:31:18.620+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : (nil)
03-04 03:31:18.620+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _process_ise_panel_hided(1080) > received_will_hide_event = 1
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:31:18.630+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5763) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (5a, 3000002)
03-04 03:31:18.630+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5765) > calling ui_candidate_hide (true, false)
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:31:18.630+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:31:18.630+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300004d)
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:31:18.630+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:31:19.912+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x201c69 bd->visible=1
03-04 03:31:20.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:31:20.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:31:21.443+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_destroy_candidate_window(3253) > calling ui_candidate_hide (true)
03-04 03:31:21.443+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
03-04 03:31:21.443+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:31:21.443+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 03:31:21.443+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 03:31:21.443+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:31:21.443+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x300004d)
03-04 03:31:21.453+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
03-04 03:31:21.453+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:31:21.493+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 03:31:21.493+0900 D/IMMODULE( 3059): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 03:31:59.330+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
03-04 03:31:59.330+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
03-04 03:31:59.330+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
03-04 03:31:59.330+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 3:32 4 h"
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 3:32"
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 3&#x2236;32"
03-04 03:32:00.141+0900 D/INDICATOR(  907): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146403261 Time: <font_size=33>3&#x2236;32</font_size> <font_size=32>AM</font_size></font>
03-04 03:32:09.110+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201c69 
03-04 03:32:09.560+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 1 -> 3
03-04 03:32:09.560+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 1 -> 3
03-04 03:32:09.560+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:32:09.560+0900 D/APP_CORE( 3059): appcore-rotation.c: __changed_cb(121) > [APP 3059] Rotation: 0 -> 3
03-04 03:32:09.560+0900 D/APP_CORE( 3059): appcore-rotation.c: __changed_cb(124) > [APP 3059] Rotation: 0 -> 3
03-04 03:32:09.560+0900 I/CAPI_APPFW_APPLICATION( 3059): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:32:09.960+0900 D/APP_CORE( 3059): appcore-rotation.c: __changed_cb(121) > [APP 3059] Rotation: 3 -> 1
03-04 03:32:09.960+0900 D/APP_CORE( 3059): appcore-rotation.c: __changed_cb(124) > [APP 3059] Rotation: 3 -> 1
03-04 03:32:09.960+0900 I/CAPI_APPFW_APPLICATION( 3059): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:32:09.960+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 3 -> 1
03-04 03:32:09.960+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 3 -> 1
03-04 03:32:09.960+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:32:10.111+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1400002
03-04 03:32:14.215+0900 I/tichat  ( 3059): load message : hjgjhkj
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.215+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.225+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.235+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.245+0900 E/EFL     ( 3059): ecore<3059> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
03-04 03:32:14.575+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:32:14.575+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:32:15.115+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x201c69 bd->visible=1
03-04 03:32:15.586+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:32:15.586+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:32:19.580+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:32:19.580+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:32:20.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:32:20.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:32:37.507+0900 D/eventsystem(  769): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.battery_level_status)
03-04 03:32:37.507+0900 D/eventsystem(  769): eventsystem.c: __get_member_name_from_eventname(259) > member_name(battery_level_status)
03-04 03:32:37.507+0900 D/eventsystem(  769): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
03-04 03:32:37.507+0900 D/eventsystem(  769): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
03-04 03:32:37.507+0900 D/eventsystem(  769): eventsystem.c: __eventsystem_send_event(853) > member_name(battery_level_status)
03-04 03:32:37.517+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_add_capacity(1179) > 95 -> 96 1425407557 450 450208
03-04 03:32:37.517+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 96 304 122 20
03-04 03:32:37.517+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 96 0 0 18
03-04 03:32:37.517+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 96 335 11 22
03-04 03:32:37.517+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 96 404 5 27
03-04 03:32:37.517+0900 I/RESOURCED(  872): heart-battery.c: heart_battery_calculate_prediction(1149) > TimeToFull: 96 327 10 22
03-04 03:32:37.517+0900 D/RESOURCED(  872): heart-battery.c: heart_battery_add_capacity(1267) > battery_heart_capacity_write 96 diff_capacity 1, used time 0, charging time 450208, charger status 1, reset_mark 1
03-04 03:32:37.517+0900 D/RESOURCED(  872): logging.c: logging_leveldb_putv(530) > BATTERY_USED_TIME:522022 532331 
03-04 03:32:37.517+0900 D/INDICATOR(  907): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 96"
03-04 03:32:37.517+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
03-04 03:32:37.527+0900 D/INDICATOR(  907): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
03-04 03:32:37.527+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
03-04 03:32:37.527+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 0, Minictrl count : 3
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 0, Minictrl count : 3
03-04 03:32:37.527+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(269) > default
03-04 03:32:37.527+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-04 03:32:37.527+0900 E/INDICATOR(  907): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-04 03:32:37.527+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
03-04 03:32:37.527+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
03-04 03:32:37.527+0900 D/INDICATOR(  907): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.show"
03-04 03:32:37.527+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 03:32:37.527+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 03:32:37.527+0900 E/INDICATOR(  907): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 1
03-04 03:32:37.527+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
03-04 03:32:37.527+0900 D/INDICATOR(  907): icon.c: _hide_more_noti(779) > port :: hide more icon
03-04 03:32:59.309+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
03-04 03:32:59.309+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
03-04 03:32:59.309+0900 D/RESOURCED(  872): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
03-04 03:32:59.309+0900 I/RESOURCED(  872): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
03-04 03:32:59.319+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1425407032 69 6 3030 1
03-04 03:32:59.319+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1425407043 191 15 3030 2
03-04 03:32:59.319+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1425407043 9455 2358 934 1
03-04 03:32:59.319+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_update(576) > org.example.tichat org.example.tichat 1425407285 66 9 3059 1
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 3:33 4 h"
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 3:33"
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 3&#x2236;33"
03-04 03:33:00.159+0900 D/INDICATOR(  907): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146389923 Time: <font_size=33>3&#x2236;33</font_size> <font_size=32>AM</font_size></font>
03-04 03:33:35.154+0900 D/APP_CORE( 3059): appcore-rotation.c: __changed_cb(121) > [APP 3059] Rotation: 1 -> 3
03-04 03:33:35.154+0900 D/APP_CORE( 3059): appcore-rotation.c: __changed_cb(124) > [APP 3059] Rotation: 1 -> 3
03-04 03:33:35.154+0900 I/CAPI_APPFW_APPLICATION( 3059): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:33:35.154+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(121) > [APP 934] Rotation: 1 -> 3
03-04 03:33:35.154+0900 D/APP_CORE(  934): appcore-rotation.c: __changed_cb(124) > [APP 934] Rotation: 1 -> 3
03-04 03:33:35.154+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-04 03:33:36.745+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201c69 
03-04 03:33:36.785+0900 I/tichat  ( 3059): room leaved
03-04 03:33:37.576+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:33:37.576+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:33:37.746+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1400002
03-04 03:33:38.487+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201c69 
03-04 03:33:38.497+0900 I/tichat  ( 3059): socket 54 requset sent: 12, msg:getroomlist/ 
03-04 03:33:38.517+0900 I/tichat  ( 3059): roomlist : sdfasdf$
03-04 03:33:39.508+0900 I/tichat  ( 3059): not toked : sdfasdf$
03-04 03:33:39.508+0900 I/tichat  ( 3059): toked : sdfasdf
03-04 03:33:39.618+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:33:39.618+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:33:42.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:33:42.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:33:42.751+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x201c69 bd->visible=1
03-04 03:33:43.221+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201c69 
03-04 03:33:43.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:33:43.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:33:44.202+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x201c69 
03-04 03:33:44.212+0900 I/CAPI_APPFW_APPLICATION( 3059): app_main.c: ui_app_exit(799) > ui_app_exit
03-04 03:33:44.212+0900 D/AUL     ( 3059): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
03-04 03:33:44.222+0900 D/AUL_AMD (  821): amd_request.c: __request_handler(838) > __request_handler: 22
03-04 03:33:44.222+0900 W/AUL_AMD (  821): amd_request.c: __request_handler(1056) > app status : 5
03-04 03:33:44.222+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(456) > pid(3059) status(5)
03-04 03:33:44.222+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(468) > pid(3059) appid(org.example.tichat) pkgid(org.example.tichat) status(5)
03-04 03:33:44.222+0900 D/AUL     (  821): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.tichat
03-04 03:33:44.222+0900 W/AUL     (  821): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 3059, appid: org.example.tichat, status: bg
03-04 03:33:44.222+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 3059, appname = org.example.tichat, pkgname = org.example.tichat
03-04 03:33:44.222+0900 D/RESOURCED(  872): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 3059, appname = org.example.tichat
03-04 03:33:44.222+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3059
03-04 03:33:44.222+0900 D/RESOURCED(  872): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3059, proc_name: org.example.tichat, cg_name: previous, oom_score_adj: 300
03-04 03:33:44.222+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3059
03-04 03:33:44.232+0900 D/APP_CORE( 3059): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
03-04 03:33:44.232+0900 D/APP_CORE( 3059): appcore-efl.c: __after_loop(1169) > [APP 3059] PAUSE before termination
03-04 03:33:44.232+0900 I/CAPI_APPFW_APPLICATION( 3059): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
03-04 03:33:44.232+0900 I/CAPI_APPFW_APPLICATION( 3059): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
03-04 03:33:44.232+0900 E/EFL     ( 3059): eo<3059> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80054ca8 is not pointing to a valid object. Maybe it has already been freed.
03-04 03:33:44.232+0900 E/EFL     ( 3059): eo<3059> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80054ca8) is an invalid ref.
03-04 03:33:44.232+0900 E/EFL     (  535): eo<535> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-04 03:33:44.242+0900 D/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2887) > pid(934) status(3)
03-04 03:33:44.242+0900 D/AUL_AMD (  821): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
03-04 03:33:44.242+0900 W/AUL_AMD (  821): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-04 03:33:44.242+0900 W/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2891) > back key ungrab error
03-04 03:33:44.242+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(456) > pid(934) status(3)
03-04 03:33:44.242+0900 D/AUL_AMD (  821): amd_status.c: _status_update_app_info_list(468) > pid(934) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
03-04 03:33:44.242+0900 D/AUL     (  821): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
03-04 03:33:44.242+0900 W/AUL     (  821): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 934, appid: org.tizen.homescreen, status: fg
03-04 03:33:44.252+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
03-04 03:33:44.262+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x01400002), visible:1
03-04 03:33:44.262+0900 D/INDICATOR(  907): main.c: _property_changed_cb(432) > UNSNIFF API 1400002
03-04 03:33:44.262+0900 D/INDICATOR(  907): util.c: util_signal_emit_by_win(116) > emission bg.translucent
03-04 03:33:44.262+0900 D/INDICATOR(  907): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-04 03:33:44.262+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 1
03-04 03:33:44.262+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
03-04 03:33:44.262+0900 D/INDICATOR(  907): main.c: _rotate_window(252) > port :: hide more icon
03-04 03:33:44.262+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x12c89b8), gem(21), surface(0x13e30a8)
03-04 03:33:44.342+0900 D/RESOURCED(  872): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 934
03-04 03:33:44.342+0900 D/RESOURCED(  872): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 934, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
03-04 03:33:44.342+0900 D/RESOURCED(  872): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 934, appname = org.tizen.homescreen
03-04 03:33:44.352+0900 D/RESOURCED(  872): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 934
03-04 03:33:44.352+0900 E/RESOURCED(  872): freezer-process.c: freezer_process_pid_set(160) > freezer_process_pid_set 934 foreground
03-04 03:33:44.352+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x12fe530), gem(4), surface(0x1329330)
03-04 03:33:44.363+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x12fe530), gem(4), surface(0x13fec60)
03-04 03:33:44.363+0900 W/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=934
03-04 03:33:44.363+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 0
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-04 03:33:44.383+0900 I/APP_CORE(  934): appcore-efl.c: __do_app(496) > [APP 934] Event: RESUME State: PAUSED
03-04 03:33:44.383+0900 D/LAUNCH  (  934): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __do_app(607) > [APP 934] RESUME
03-04 03:33:44.383+0900 I/CAPI_APPFW_APPLICATION(  934): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-04 03:33:44.383+0900 E/cluster-home(  934): homescreen.cpp: OnResume(66) >  app resume
03-04 03:33:44.383+0900 D/cluster-home(  934): widget-data-provider.cpp: SetBoxVisibility(1543) >  
03-04 03:33:44.383+0900 D/cluster-home(  934): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
03-04 03:33:44.383+0900 D/cluster-home(  934): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[1]
03-04 03:33:44.383+0900 D/cluster-view(  934): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
03-04 03:33:44.383+0900 D/cluster-view(  934): homescreen-view-manager.cpp: AppResume(910) >  END
03-04 03:33:44.383+0900 D/cluster-view(  934): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
03-04 03:33:44.383+0900 D/cluster-view(  934): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
03-04 03:33:44.383+0900 D/cluster-view(  934): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
03-04 03:33:44.383+0900 D/cluster-view(  934): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
03-04 03:33:44.383+0900 D/cluster-view(  934): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
03-04 03:33:44.383+0900 D/cluster-view(  934): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
03-04 03:33:44.383+0900 D/test-log(  934): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
03-04 03:33:44.383+0900 E/EFL     (  535): eo<535> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-04 03:33:44.383+0900 D/test-log(  934): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
03-04 03:33:44.383+0900 D/cluster-view(  934): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
03-04 03:33:44.383+0900 D/cluster-home(  934): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
03-04 03:33:44.383+0900 D/LAUNCH  (  934): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
03-04 03:33:44.383+0900 D/LAUNCH  (  934): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
03-04 03:33:44.383+0900 D/APP_CORE(  934): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-04 03:33:44.383+0900 E/APP_CORE(  934): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-04 03:33:44.383+0900 D/DATA_PROVIDER_MASTER( 1015): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 934 is resumed
03-04 03:33:44.383+0900 D/DATA_PROVIDER_MASTER( 1015): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-04 03:33:44.383+0900 E/DATA_PROVIDER_MASTER( 1015): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
03-04 03:33:44.413+0900 I/TIZEN_N_SOUND_MANAGER( 1016): sound_manager.c: sound_manager_get_volume(77) > returns : type=0, volume=9, ret=0x0
03-04 03:33:44.413+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(646) > [EGL-X11] eglimage target 30b0 imported bo(0x13cc5a8), gem(20), surface(0x1329330)
03-04 03:33:44.413+0900 E/TIZEN_N_SOUND_MANAGER( 1016): sound_manager_private.c: __convert_sound_manager_error_code(70) > [sound_manager_get_volume(79)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-04 03:33:44.413+0900 I/TIZEN_N_SOUND_MANAGER( 1016): sound_manager.c: sound_manager_get_volume(77) > returns : type=4, volume=0, ret=0x0
03-04 03:33:44.413+0900 E/TIZEN_N_SOUND_MANAGER( 1016): sound_manager_private.c: __convert_sound_manager_error_code(70) > [sound_manager_get_volume(79)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
03-04 03:33:44.413+0900 D/AUL_AMD (  821): amd_request.c: __request_handler(838) > __request_handler: 15
03-04 03:33:44.413+0900 D/PKGMGR_INFO(  821): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-04 03:33:44.413+0900 D/PKGMGR_INFO(  821): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-04 03:33:44.423+0900 D/AUL_AMD (  821): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 934 is org.tizen.homescreen
03-04 03:33:44.423+0900 D/AUL_AMD (  821): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 934 : 0
03-04 03:33:44.423+0900 D/AUL     ( 1016): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-04 03:33:44.433+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-04 03:33:44.433+0900 I/AUL_PAD ( 1001): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 3059 pgid = 3059
03-04 03:33:44.433+0900 I/AUL_PAD ( 1001): sigchild.h: __sigchild_action(141) > dead_pid(3059)
03-04 03:33:44.493+0900 D/AUL_PAD ( 1001): sigchild.h: __send_app_dead_signal(90) > send dead signal done
03-04 03:33:44.493+0900 I/AUL_PAD ( 1001): sigchild.h: __sigchild_action(147) > __send_app_dead_signal(0)
03-04 03:33:44.493+0900 I/AUL_PAD ( 1001): sigchild.h: __launchpad_process_sigchld(168) > after __sigchild_action
03-04 03:33:44.493+0900 E/AUL_PAD ( 1001): launchpad.c: main(688) > error reading sigchld info
03-04 03:33:44.493+0900 W/AUL_AMD (  821): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 3059
03-04 03:33:44.493+0900 D/STARTER (  875): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 3059 is termianted
03-04 03:33:44.493+0900 D/STARTER (  875): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
03-04 03:33:44.493+0900 W/AUL_AMD (  821): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 3059
03-04 03:33:44.493+0900 D/AUL_AMD (  821): amd_key.c: _unregister_key_event(179) > ===key stack===
03-04 03:33:44.493+0900 E/AUL_AMD (  821): amd_launch.c: _revoke_temporary_permission(2128) > list or callee_label was null
03-04 03:33:44.493+0900 D/AUL_AMD (  821): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.tichat)
03-04 03:33:44.493+0900 D/AUL     (  821): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-04 03:33:44.493+0900 E/AUL     (  821): simple_util.c: __trm_app_info_send_socket(330) > access
03-04 03:33:44.503+0900 I/ESD     ( 1007): esd_main.c: __esd_app_dead_handler(1771) > pid: 3059
03-04 03:33:44.513+0900 D/RESOURCED(  872): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 3059
03-04 03:33:44.513+0900 D/RESOURCED(  872): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.tichat, pkgname = org.example.tichat, ref = 0
03-04 03:33:44.533+0900 W/CRASH_MANAGER( 3150): worker.c: worker_job(1204) > 1103059746963142540762
