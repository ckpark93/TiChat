S/W Version Information
Model: TM1
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-TM1_20160307.1306
Build-Date: 2016.03.07 13:06:48

Crash Information
Process Name: tichat
PID: 2486
Date: 2015-03-04 03:05:53+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000000, r1   = 0xb32f939f
r2   = 0xb32f939f, r3   = 0x00000000
r4   = 0xb32f83d9, r5   = 0xb811e878
r6   = 0xb8122418, r7   = 0xbe828130
r8   = 0x8004381e, r9   = 0xb5f76f74
r10  = 0xb8119cb0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe828118
lr   = 0xb32f863f, pc   = 0xb32f1f68
cpsr = 0x400d0030

Memory Information
MemTotal:   987328 KB
MemFree:    496352 KB
Buffers:     25792 KB
Cached:     164648 KB
VmPeak:     113756 KB
VmSize:     113752 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22840 KB
VmRSS:       22840 KB
VmData:      44812 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       23168 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2486 TID = 2486
2486 2489 2658 2659 2662 

Maps Information
b0769000 b0f68000 rw-p [stack:2662]
b1bdc000 b23db000 rw-p [stack:2659]
b2587000 b258c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b259c000 b25ac000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25ad000 b25b2000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2633000 b263b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b264c000 b264d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b265d000 b2664000 r-xp /usr/lib/libfeedback.so.0.1.4
b2688000 b269b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b26af000 b26b4000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b26c4000 b26c5000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b26d5000 b26d8000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b26e9000 b26ea000 r-xp /usr/lib/libxshmfence.so.1.0.0
b26fa000 b26fc000 r-xp /usr/lib/libxcb-present.so.0.0.0
b270c000 b270e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b271e000 b2726000 r-xp /usr/lib/libdrm.so.2.4.0
b2736000 b2738000 r-xp /usr/lib/libdri2.so.0.0.0
b2748000 b2750000 r-xp /usr/lib/libtbm.so.1.0.0
b2760000 b2761000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2773000 b2774000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2784000 b2790000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b27a2000 b2fa1000 rw-p [stack:2658]
b2fa1000 b2fcf000 r-xp /usr/lib/libidn.so.11.5.44
b2fdf000 b2ff5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3006000 b3010000 r-xp /usr/lib/libcares.so.2.1.0
b3020000 b3035000 r-xp /usr/lib/libnetwork.so.0.0.0
b3046000 b304d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b305d000 b30a3000 r-xp /usr/lib/libcurl.so.4.3.0
b30b4000 b30c1000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b30d3000 b30e3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b31eb000 b31ef000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3200000 b32e0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b32ef000 b32fa000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b3302000 b332a000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b333c000 b3b3b000 rw-p [stack:2489]
b3b3b000 b3b3d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3d4d000 b3d56000 r-xp /lib/libnss_files-2.20-2014.11.so
b3d67000 b3d70000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3d81000 b3d92000 r-xp /lib/libnsl-2.20-2014.11.so
b3da5000 b3dab000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3dbc000 b3dd6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b3de7000 b3de8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b3df8000 b3dfa000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e0b000 b3e10000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e20000 b3e23000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3e34000 b3e3b000 r-xp /usr/lib/libsensord-share.so
b3e4b000 b3e5c000 r-xp /usr/lib/libsensor.so.1.2.0
b3e6d000 b3e73000 r-xp /usr/lib/libappcore-common.so.1.1
b3e96000 b3e9b000 r-xp /usr/lib/libappcore-efl.so.1.1
b3eb1000 b3eb3000 r-xp /usr/lib/libXau.so.6.0.0
b3ec3000 b3ed7000 r-xp /usr/lib/libxcb.so.1.1.0
b3ee7000 b3eee000 r-xp /lib/libcrypt-2.20-2014.11.so
b3f26000 b3f28000 r-xp /usr/lib/libiri.so
b3f39000 b3f4e000 r-xp /lib/libexpat.so.1.5.2
b3f60000 b3fae000 r-xp /usr/lib/libssl.so.1.0.0
b3fc3000 b3fcc000 r-xp /usr/lib/libethumb.so.1.13.0
b3fdd000 b3fe0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b3ff0000 b41a7000 r-xp /usr/lib/libcrypto.so.1.0.0
b573e000 b5747000 r-xp /usr/lib/libXi.so.6.1.0
b5758000 b575a000 r-xp /usr/lib/libXgesture.so.7.0.0
b576a000 b576e000 r-xp /usr/lib/libXtst.so.6.1.0
b577e000 b5784000 r-xp /usr/lib/libXrender.so.1.3.0
b5794000 b579a000 r-xp /usr/lib/libXrandr.so.2.2.0
b57aa000 b57ac000 r-xp /usr/lib/libXinerama.so.1.0.0
b57bc000 b57bf000 r-xp /usr/lib/libXfixes.so.3.1.0
b57d0000 b57db000 r-xp /usr/lib/libXext.so.6.4.0
b57eb000 b57ed000 r-xp /usr/lib/libXdamage.so.1.1.0
b57fd000 b57ff000 r-xp /usr/lib/libXcomposite.so.1.0.0
b580f000 b58f2000 r-xp /usr/lib/libX11.so.6.3.0
b5905000 b590c000 r-xp /usr/lib/libXcursor.so.1.0.2
b591d000 b5935000 r-xp /usr/lib/libudev.so.1.6.0
b5937000 b593a000 r-xp /lib/libattr.so.1.1.0
b594a000 b596a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b596b000 b5970000 r-xp /usr/lib/libffi.so.6.0.2
b5980000 b5998000 r-xp /lib/libz.so.1.2.8
b59a8000 b59aa000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b59ba000 b5a8f000 r-xp /usr/lib/libxml2.so.2.9.2
b5aa4000 b5b3f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b5b000 b5b5e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b6e000 b5b88000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b98000 b5ba9000 r-xp /lib/libresolv-2.20-2014.11.so
b5bbd000 b5bd4000 r-xp /usr/lib/liblzma.so.5.0.3
b5be4000 b5be6000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf6000 b5bfd000 r-xp /usr/lib/libembryo.so.1.13.0
b5c0d000 b5c25000 r-xp /usr/lib/libpng12.so.0.50.0
b5c36000 b5c59000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c79000 b5c7f000 r-xp /lib/librt-2.20-2014.11.so
b5c90000 b5ca4000 r-xp /usr/lib/libector.so.1.13.0
b5cb5000 b5ccd000 r-xp /usr/lib/liblua-5.1.so
b5cde000 b5d35000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d49000 b5d71000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d82000 b5d95000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da6000 b5de0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df1000 b5e5c000 r-xp /lib/libm-2.20-2014.11.so
b5e6d000 b5e7a000 r-xp /usr/lib/libeio.so.1.13.0
b5e8a000 b5e8c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e9c000 b5ea1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5eb1000 b5ec8000 r-xp /usr/lib/libefreet.so.1.13.0
b5eda000 b5efa000 r-xp /usr/lib/libeldbus.so.1.13.0
b5f0a000 b5f2a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5f2c000 b5f32000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f42000 b5f49000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f59000 b5f67000 r-xp /usr/lib/libeo.so.1.13.0
b5f77000 b5f89000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f9a000 b5f9f000 r-xp /usr/lib/libecore_file.so.1.13.0
b5faf000 b5fc7000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fd8000 b5ff5000 r-xp /usr/lib/libeet.so.1.13.0
b600e000 b6056000 r-xp /usr/lib/libeina.so.1.13.0
b6067000 b6077000 r-xp /usr/lib/libefl.so.1.13.0
b6088000 b616d000 r-xp /usr/lib/libicuuc.so.51.1
b618a000 b62ca000 r-xp /usr/lib/libicui18n.so.51.1
b62e1000 b6319000 r-xp /usr/lib/libecore_x.so.1.13.0
b632b000 b632e000 r-xp /lib/libcap.so.2.21
b633e000 b6367000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6378000 b637f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6391000 b63c7000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b63d8000 b64c0000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b64d4000 b654a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b655c000 b655f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b656f000 b657a000 r-xp /usr/lib/libvconf.so.0.2.45
b658a000 b658c000 r-xp /usr/lib/libvasum.so.0.3.1
b659c000 b659e000 r-xp /usr/lib/libttrace.so.1.1
b65ae000 b65b1000 r-xp /usr/lib/libiniparser.so.0
b65c1000 b65e4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65f4000 b65f9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b660a000 b6621000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6632000 b663f000 r-xp /usr/lib/libunwind.so.8.0.1
b6675000 b6799000 r-xp /lib/libc-2.20-2014.11.so
b67ae000 b67c7000 r-xp /lib/libgcc_s-4.9.so.1
b67d7000 b68b9000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b68ca000 b68fe000 r-xp /usr/lib/libdbus-1.so.3.8.11
b690e000 b6948000 r-xp /usr/lib/libsystemd.so.0.4.0
b694a000 b69ca000 r-xp /usr/lib/libedje.so.1.13.0
b69cd000 b69eb000 r-xp /usr/lib/libecore.so.1.13.0
b6a0b000 b6b6d000 r-xp /usr/lib/libevas.so.1.13.0
b6ba4000 b6bb8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bcc000 b6df0000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1e000 b6e22000 r-xp /usr/lib/libsmack.so.1.0.0
b6e32000 b6e38000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e49000 b6e4b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e5b000 b6e5e000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6e000 b6e70000 r-xp /lib/libdl-2.20-2014.11.so
b6e81000 b6e9a000 r-xp /usr/lib/libaul.so.0.1.0
b6eac000 b6eae000 r-xp /usr/lib/libappsvc.so.0.1.0
b6ebf000 b6ec3000 r-xp /usr/lib/libsys-assert.so
b6ed4000 b6ef4000 r-xp /lib/ld-2.20-2014.11.so
b6f05000 b6f0b000 r-xp /usr/bin/launchpad-loader
b7f08000 b81ec000 rw-p [heap]
be808000 be829000 rw-p [stack]
be808000 be829000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2486)
Call Stack Count: 21
 0: cJSON_GetObjectItem + 0xf (0xb32f1f68) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2f68
 1: login_login_button_clicked_cb + 0x266 (0xb32f863f) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x963f
 2: (0xb6a6d6b1) [/usr/lib/libevas.so.1] + 0x626b1
 3: (0xb5f63985) [/usr/lib/libeo.so.1] + 0xa985
 4: eo_event_callback_call + 0x68 (0xb5f62241) [/usr/lib/libeo.so.1] + 0x9241
 5: evas_object_smart_callback_call + 0x38 (0xb6a6eda1) [/usr/lib/libevas.so.1] + 0x63da1
 6: (0xb69a0307) [/usr/lib/libedje.so.1] + 0x56307
 7: (0xb69a463f) [/usr/lib/libedje.so.1] + 0x5a63f
 8: (0xb69a0cc1) [/usr/lib/libedje.so.1] + 0x56cc1
 9: (0xb69a1081) [/usr/lib/libedje.so.1] + 0x57081
10: (0xb69a11d1) [/usr/lib/libedje.so.1] + 0x571d1
11: (0xb69dcd51) [/usr/lib/libecore.so.1] + 0xfd51
12: (0xb69d8c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69dea9d) [/usr/lib/libecore.so.1] + 0x11a9d
14: ecore_main_loop_begin + 0x3e (0xb69decc3) [/usr/lib/libecore.so.1] + 0x11cc3
15: appcore_efl_main + 0x340 (0xb3e98f11) [/usr/lib/libappcore-efl.so.1] + 0x2f11
16: ui_app_main + 0xc0 (0xb3e220b5) [/usr/lib/libcapi-appfw-application.so.0] + 0x20b5
17: main + 0x11a (0xb32f7a5b) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x8a5b
18: (0xb6f06cab) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x1cab
19: __libc_start_main + 0x114 (0xb668b4bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f07134) [/opt/usr/apps/org.example.tichat/bin/tichat] + 0x2134
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
aps mode : 0
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(647) > [SECURE_LOG] return_key_type : 1, return_key_disabled : 0, autocapital type : 0
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(648) > [SECURE_LOG] client_window : 0x1400002, password mode : 1, prediction_allow : 0
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(649) > [SECURE_LOG] input hint : 0x2
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(650) > [SECURE_LOG] bidi direction : 0
03-04 03:05:43.633+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: show_ise_panel(1858) > prepare to show ISE 38 [ise-default] [ise-default]
03-04 03:05:43.633+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: show_helper(1449) > Send ISM_TRANS_CMD_SHOW_ISE_PANEL message
03-04 03:05:43.633+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_show_ise(5696) > slot_show_ise ()
03-04 03:05:43.633+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_ise_hide_timer(3851) > deleting ise_hide_timer
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 0
03-04 03:05:43.633+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_filter_event(2149) > [Mouse-up event] ctx : 0xb80fb0b8
03-04 03:05:43.633+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_set_transient_for_app_window(3460) > win : 3e00003, forwin : 1400002
03-04 03:05:43.633+0900 D/SCIM_HELPER( 1099): scim_helper.cpp: filter_event(526) > Helper ISE received ISM_TRANS_CMD_SHOW_ISE_PANEL message
03-04 03:05:43.633+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:43.633+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:05:43.633+0900 D/LIBSCL_CORE( 1099): sclcoreui-efl.cpp: get_screen_rotation_degree(217) > Trying to get app window degree for 0x8000321a
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:05:43.633+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(613) > already show
03-04 03:05:43.633+0900 D/LIBSCL_CORE( 1099): sclcoreui-efl.cpp: get_screen_rotation_degree(236) > app_window : 0x1400002, ret 0, 0, (nil)
03-04 03:05:43.633+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_set_layout(805) > layout:11, variation:0
03-04 03:05:43.693+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 03:05:43.713+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_ise_show(279) > Skipping rotation angle , 0
03-04 03:05:43.723+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_show(872) > ic : 9b70025 , 0 , g_ic : 9b60025 , 0, g_focused_ic : 9b70025 , 0
03-04 03:05:43.723+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 03:05:43.723+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_show(935) > new layout index:11
03-04 03:05:43.723+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 6, g_need_send_shift_event: 0
03-04 03:05:43.723+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 03:05:43.723+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, ffe1
03-04 03:05:43.743+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(251) > [SECURE_LOG] [language is changed] ctx : 0xb80fb0b8
03-04 03:05:43.763+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_event_notification(571) > noti type: 5, g_need_send_shift_event: 0
03-04 03:05:43.763+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000321a 0x3e00003 0 838 0 838 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:43.763+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:43.783+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000321a 0x3e00003 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:43.873+0900 D/APP_CORE(  934): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
03-04 03:05:43.873+0900 I/APP_CORE(  934): appcore-efl.c: __do_app(496) > [APP 934] Event: MEM_FLUSH State: PAUSED
03-04 03:05:43.873+0900 D/APP_CORE(  934): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
03-04 03:05:43.873+0900 D/APP_CORE(  934): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 934
03-04 03:05:43.873+0900 D/APP_CORE(  934): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
03-04 03:05:43.873+0900 D/RESOURCED(  872): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 934
03-04 03:05:44.023+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.023+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.023+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.023+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 215 1029, 215 191
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:05:44.033+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:05:44.043+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.043+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:05:44.043+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:05:44.043+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:05:44.053+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 100 0x800e689b
03-04 03:05:44.053+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.053+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 166 836 166 836 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.053+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:05:44.063+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:05:44.093+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.113+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2015a1 
03-04 03:05:44.123+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.123+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.123+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 215 1029, 215 191
03-04 03:05:44.123+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 215 1029, 215 191
03-04 03:05:44.123+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.123+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:05:44.133+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 1
03-04 03:05:44.133+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2309) > ctx : 0xb80fb0b8, bidi direction : 0x1
03-04 03:05:44.133+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:44.143+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, 64
03-04 03:05:44.153+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 100 0x800e689b
03-04 03:05:44.163+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x800e92a9
03-04 03:05:44.173+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x13699c8), gem(28), surface(0x13dd680)
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 457 999, 457 161
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:05:44.203+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x800e92a9
03-04 03:05:44.213+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 102 0x800f8b17
03-04 03:05:44.213+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:05:44.213+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.213+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 379 836 379 836 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.223+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.223+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 457 999, 457 161
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 457 999, 457 161
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:05:44.243+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, 68
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 102 0x800f8b17
03-04 03:05:44.243+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x800fb52a
03-04 03:05:44.243+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 2
03-04 03:05:44.253+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:05:44.253+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:44.273+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2015a1 
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 100 977, 100 139
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x800fb52a
03-04 03:05:44.303+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 100 0x80174998
03-04 03:05:44.303+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:05:44.313+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.313+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 24 836 24 836 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.313+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.313+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:05:44.333+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:05:44.343+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.343+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 100 977, 100 139
03-04 03:05:44.343+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 100 977, 100 139
03-04 03:05:44.343+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.343+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:05:44.343+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, 61
03-04 03:05:44.353+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 3
03-04 03:05:44.353+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 100 0x80174998
03-04 03:05:44.353+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x80173fac
03-04 03:05:44.353+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:44.363+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2015a1 
03-04 03:05:44.363+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x1312f18), gem(32), surface(0x13ea068)
03-04 03:05:44.383+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.383+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.383+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.383+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.383+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 471 1019, 471 181
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x80173fac
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 102 0x80133c1a
03-04 03:05:44.394+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.394+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 450 836 450 836 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.404+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.414+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 471 1019, 471 181
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 471 1019, 471 181
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:05:44.424+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, 6a
03-04 03:05:44.424+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 4
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 102 0x80133c1a
03-04 03:05:44.424+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x8011922d
03-04 03:05:44.424+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:05:44.434+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:44.454+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2015a1 
03-04 03:05:44.484+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x13acdc8), gem(24), surface(0x13d0940)
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 156 946, 156 108
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:05:44.494+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:05:44.504+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x8011922d
03-04 03:05:44.504+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 100 0x8013829d
03-04 03:05:44.504+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:05:44.504+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.504+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 95 836 95 836 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.504+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.514+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:05:44.534+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:05:44.564+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x12be320), gem(28), surface(0x13e3ad8)
03-04 03:05:44.584+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.584+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 156 946, 156 108
03-04 03:05:44.594+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 156 946, 156 108
03-04 03:05:44.594+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2015a1 
03-04 03:05:44.594+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.594+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:05:44.594+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, 73
03-04 03:05:44.594+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 5
03-04 03:05:44.594+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 100 0x8013829d
03-04 03:05:44.594+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x801282b3
03-04 03:05:44.594+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:44.694+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:05:44.694+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.694+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x801282b3
03-04 03:05:44.694+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Returning Timer : 105 0
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1041, 303 203
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1041, 303 203
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1041, 303 203
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1041, 303 203
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1041, 303 203
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_press(218) > mouse_press : 303 1041, 303 203
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > E_PROP_TOUCH_INPUT : 1 1
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > TOUCH_OFFSET is enabled!!!!
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclcontroller.cpp: mouse_press(2023) > dim window is_virtual:0, hidden:1
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > LIST : 0
03-04 03:05:44.794+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > 
03-04 03:05:44.804+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 102 0x8014cd26
03-04 03:05:44.804+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.804+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_movewin 0x8000fc7f 0x3e00009 237 836 237 836 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.804+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_showwin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.804+0900 E/E17     (  535): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x03e00009)
03-04 03:05:44.824+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x03e00009)
03-04 03:05:44.844+0900 I/MALI    ( 1099): tizen_buffer.c: tizen_dri2_get_buffers(734) > Re-used flag set for un-cached buffer.
03-04 03:05:44.844+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1040, 303 202
03-04 03:05:44.854+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x13595d0), gem(4), surface(0x13e8350)
03-04 03:05:44.864+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1040, 303 202
03-04 03:05:44.864+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 303 1040, 303 202
03-04 03:05:44.864+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_release(362) > mouse_release : 303 1040, 303 202
03-04 03:05:44.864+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x2015a1 
03-04 03:05:44.864+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:44.864+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > PRESSED CTX : 0x8000321a 0 838
03-04 03:05:44.864+0900 D/ISE_DEFAULT( 1099): ise.cpp: ise_send_event(463) > ic : 9b70025, 66
03-04 03:05:44.874+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1681) > ctx : 0xb80fb0b8, cursor pos : 6
03-04 03:05:44.874+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:44.874+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 102 0x8014cd26
03-04 03:05:44.874+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Created Timer : 105 0x8015f135
03-04 03:05:44.974+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00009), visible:1
03-04 03:05:44.984+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:44.984+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Destoyed Timer : 105 0x8015f135
03-04 03:05:44.984+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > Returning Timer : 105 0
03-04 03:05:45.094+0900 D/LIBSCL_UI( 1099): sclevents-efl.cpp: mouse_move(566) > mouse_move : 570 703, 570 0
03-04 03:05:45.094+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_getwinrect 0x8000321a 0x3e00003, 0 838 720 442
03-04 03:05:45.174+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_filter_event(2149) > [Mouse-up event] ctx : 0xb80fb0b8
03-04 03:05:45.174+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x20158b 
03-04 03:05:45.174+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:05:45.174+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:05:45.174+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(613) > already show
03-04 03:05:45.545+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x20158b bd->visible=1
03-04 03:05:45.815+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x20158b 
03-04 03:05:46.696+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x20158b 
03-04 03:05:47.446+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x2015a1 bd->visible=1
03-04 03:05:47.837+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:05:47.857+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:05:47.857+0900 D/IMMODULE( 2486): isf_imf_context.cpp: _key_down_cb(587) > XF86Back key is pressed.
03-04 03:05:47.857+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:05:47.857+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:05:47.877+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:05:47.877+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:05:47.877+0900 D/IMMODULE( 2486): isf_imf_context.cpp: _key_up_cb(634) > XF86Back key is released.
03-04 03:05:47.877+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_get_ise_state(5823) > state = 0
03-04 03:05:47.877+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
03-04 03:05:47.887+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_hide_ise(5748) > slot_hide_ise ()
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: hide_ise(3860) > send request to hide helper
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 03:05:47.887+0900 D/SCIM_HELPER( 1099): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
03-04 03:05:47.887+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x3e00009 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_client_message_cb(6409) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
03-04 03:05:47.887+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 03:05:47.887+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 03:05:47.897+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb80fb0b8
03-04 03:05:47.907+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
03-04 03:05:47.907+0900 D/LIBSCL_UI( 1099): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x3e00003 (basewin 0x8000321a mag 0x8000fc7f)
03-04 03:05:47.907+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
03-04 03:05:47.917+0900 D/ISE_DEFAULT( 1099): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
03-04 03:05:47.927+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb80fb0b8
03-04 03:05:47.927+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _process_ise_panel_hided(1080) > received_will_hide_event = 1
03-04 03:05:47.927+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5763) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (5a, 3000002)
03-04 03:05:47.927+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: slot_will_hide_ack(5765) > calling ui_candidate_hide (true, false)
03-04 03:05:47.927+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:05:47.927+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x3000020)
03-04 03:05:47.937+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x03e00003), visible:1
03-04 03:05:47.937+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x127c6f0), gem(21), surface(0x13da140)
03-04 03:05:47.947+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x13540c0), gem(29), surface(0x13e2550)
03-04 03:05:47.947+0900 W/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2486
03-04 03:05:47.957+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb80fb0b8
03-04 03:05:47.957+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : 0xb80fb0b8, 1
03-04 03:05:47.957+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:05:47.967+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 03:05:47.967+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 03:05:47.967+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 03:05:47.967+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:05:47.967+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x3000020)
03-04 03:05:47.977+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb80fb0b8
03-04 03:05:47.977+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : 0xb80fb0b8, 1
03-04 03:05:47.977+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:05:47.977+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:47.977+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_settle_candidate_window(3397) > Moving candidate window to : 0 1196
03-04 03:05:47.977+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6251) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x3000002, atom : 438
03-04 03:05:47.977+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6326) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
03-04 03:05:47.977+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: x_event_window_property_cb(6343) > calling ui_candidate_hide (true, false)
03-04 03:05:47.977+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:05:47.977+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x3000020)
03-04 03:05:47.977+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb80fb0b8
03-04 03:05:47.977+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : 0xb80fb0b8, 1
03-04 03:05:47.977+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
03-04 03:05:47.977+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:48.788+0900 D/PROCESSMGR(  535): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x200035  register trigger_timer!  pointed_win=0x20158b 
03-04 03:05:48.798+0900 D/IMMODULE( 2486): isf_imf_context.cpp: isf_imf_context_focus_out(1589) > ctx : 0xb80fb0b8
03-04 03:05:48.798+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
03-04 03:05:48.798+0900 D/IMMODULE( 2486): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb80fb0b8
03-04 03:05:48.798+0900 D/ISE_DEFAULT( 1099): ise.cpp: on_focus_out(251) > Enter
03-04 03:05:48.848+0900 I/CAPI_NETWORK_CONNECTION( 2486): connection.c: connection_create(408) > New handle created[0xb80f9768]
03-04 03:05:48.848+0900 I/CAPI_NETWORK_CONNECTION( 2486): connection.c: connection_get_type(464) > Connected Network = 2
03-04 03:05:48.848+0900 I/tichat  ( 2486): Network connection type : 1
03-04 03:05:49.579+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:05:49.579+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:05:50.580+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:05:50.580+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:05:51.591+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:05:51.591+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:05:51.801+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: ui_destroy_candidate_window(3253) > calling ui_candidate_hide (true)
03-04 03:05:51.801+0900 W/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x1400002 FAILED!
03-04 03:05:51.801+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: get_ise_geometry(984) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
03-04 03:05:51.801+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1044) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
03-04 03:05:51.801+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: delete_candidate_hide_timer(2209) > deleting candidate_hide_timer
03-04 03:05:51.801+0900 D/ISF_PANEL_EFL( 1079): isf_panel_efl.cpp: candidate_window_hide(2223) > evas_object_hide (_candidate_window, 0x3000020)
03-04 03:05:52.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:05:52.581+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:05:53.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(192) > wifi state : 1
03-04 03:05:53.582+0900 D/INDICATOR(  907): wifi.c: _wifi_changed_cb(198) > wifi connection state : 3
03-04 03:05:53.863+0900 I/tichat  ( 2486): ERROR: Failed to fetch url (http://172.20.10.2/login) - curl said: Timeout was reached
03-04 03:05:53.943+0900 I/tichat  ( 2486): CURL Returned: 
03-04 03:05:53.943+0900 I/tichat  ( 2486): 
03-04 03:05:54.043+0900 E/EFL     (  535): eo<535> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-04 03:05:54.063+0900 D/AUL_PAD ( 1001): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-04 03:05:54.063+0900 I/AUL_PAD ( 1001): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 2486 pgid = 2486
03-04 03:05:54.063+0900 I/AUL_PAD ( 1001): sigchild.h: __sigchild_action(141) > dead_pid(2486)
03-04 03:05:54.073+0900 E/E17     (  535): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
03-04 03:05:54.073+0900 E/E17     (  535): e_border.c: e_border_hide(2248) > BD_HIDE(0x01400002), visible:1
03-04 03:05:54.083+0900 D/INDICATOR(  907): main.c: _property_changed_cb(432) > UNSNIFF API 1400002
03-04 03:05:54.083+0900 D/INDICATOR(  907): util.c: util_signal_emit_by_win(116) > emission bg.translucent
03-04 03:05:54.083+0900 I/MALI    (  535): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x127aff0), gem(20), surface(0x13328a0)
03-04 03:05:54.083+0900 D/INDICATOR(  907): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-04 03:05:54.083+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 1
03-04 03:05:54.083+0900 D/INDICATOR(  907): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
03-04 03:05:54.083+0900 D/INDICATOR(  907): main.c: _rotate_window(252) > port :: hide more icon
03-04 03:05:54.113+0900 D/AUL_AMD (  821): amd_launch.c: __e17_status_handler(2887) > pid(934) status(3)
03-04 03:05:54.113+0900 D/AUL_AMD (  821): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
03-04 03:05:54.133+0900 D/AUL_PAD ( 1001): sigchild.h: __send_app_dead_signal(90) > send dead signal done
03-04 03:05:54.133+0900 I/AUL_PAD ( 1001): sigchild.h: __sigchild_action(147) > __send_app_dead_signal(0)
03-04 03:05:54.133+0900 I/AUL_PAD ( 1001): sigchild.h: __launchpad_process_sigchld(168) > after __sigchild_action
03-04 03:05:54.133+0900 E/AUL_PAD ( 1001): launchpad.c: main(688) > error reading sigchld info
03-04 03:05:54.133+0900 I/ESD     ( 1007): esd_main.c: __esd_app_dead_handler(1771) > pid: 2486
03-04 03:05:54.133+0900 D/STARTER (  875): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 2486 is termianted
03-04 03:05:54.133+0900 D/STARTER (  875): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
03-04 03:05:54.143+0900 E/RESOURCED(  872): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.240
03-04 03:05:54.163+0900 W/CRASH_MANAGER( 2667): worker.c: worker_job(1204) > 1102486746963142540595
