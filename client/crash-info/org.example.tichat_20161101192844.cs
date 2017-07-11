S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: tichat
PID: 20770
Date: 2016-11-01 19:28:44+0900
Executable File Path: /opt/usr/apps/org.example.tichat/bin/tichat
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb3511d84, esi = 0xb0cd9f40
ebp = 0xb0cda0a8, esp = 0xb0cd9f3c
eax = 0xb350edf9, ebx = 0xb3511ac0
ecx = 0x00000072, edx = 0x00000000
eip = 0xb6d49c0b

Memory Information
MemTotal:      250 KB
MemFree:       111 KB
Buffers:        11 KB
Cached:     198644 KB
VmPeak:     131660 KB
VmSize:     131660 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32936 KB
VmRSS:       32936 KB
VmData:      61440 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34608 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 20770 TID = 20989
20770 20771 20960 20961 20988 20989 

Maps Information
b2aa0000 b2aa7000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2aa8000 b2ac0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2ac1000 b2ac8000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2b45000 b2b4f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b55000 b2b61000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b62000 b2b83000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b88000 b2b89000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b8a000 b2b8f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b90000 b2b91000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b92000 b2b94000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b95000 b2b97000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b98000 b2ba4000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba5000 b2ba8000 r-xp /usr/lib/libdri2.so.0.0.0
b2ba9000 b2bb3000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb4000 b2bb5000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2bb6000 b2bcb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bcc000 b2bde000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33e0000 b3411000 r-xp /usr/lib/libidn.so.11.5.44
b3412000 b3434000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3435000 b3445000 r-xp /usr/lib/libcares.so.2.1.0
b3446000 b3466000 r-xp /usr/lib/libnetwork.so.0.0.0
b3467000 b3470000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3471000 b34e8000 r-xp /usr/lib/libcurl.so.4.3.0
b34ea000 b34fe000 r-xp /usr/lib/libcapi-network-connection.so.1.0.72
b34ff000 b3511000 r-xp /opt/usr/apps/org.example.tichat/bin/tichat
b3619000 b361f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3620000 b3764000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b377a000 b377b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b377c000 b377d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b377e000 b3781000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3782000 b3785000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3786000 b37bf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c2000 b41cd000 r-xp /lib/libnss_files-2.20-2014.11.so
b41cf000 b41da000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41dc000 b41f3000 r-xp /lib/libnsl-2.20-2014.11.so
b41f7000 b41ff000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4201000 b4225000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4226000 b4227000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4228000 b422b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b422c000 b4233000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4234000 b423e000 r-xp /usr/lib/libsensord-share.so
b423f000 b425b000 r-xp /usr/lib/libsensor.so.1.2.0
b425d000 b4266000 r-xp /usr/lib/libappcore-common.so.1.1
b4269000 b426b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4280000 b4282000 r-xp /usr/lib/libXau.so.6.0.0
b4283000 b42a5000 r-xp /usr/lib/libxcb.so.1.1.0
b42a7000 b42b0000 r-xp /lib/libcrypt-2.20-2014.11.so
b42d9000 b42db000 r-xp /usr/lib/libiri.so
b42dc000 b4302000 r-xp /lib/libexpat.so.1.5.2
b4304000 b436f000 r-xp /usr/lib/libssl.so.1.0.0
b4375000 b4381000 r-xp /usr/lib/libethumb.so.1.13.0
b4382000 b4386000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4387000 b45d8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b53000 b5b63000 r-xp /usr/lib/libXi.so.6.1.0
b5b64000 b5b66000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b67000 b5b6d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b6e000 b5b78000 r-xp /usr/lib/libXrender.so.1.3.0
b5b79000 b5b82000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b84000 b5b86000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b87000 b5b8c000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b8d000 b5b9f000 r-xp /usr/lib/libXext.so.6.4.0
b5ba0000 b5ba2000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba3000 b5ba5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5ba7000 b5ce9000 r-xp /usr/lib/libX11.so.6.3.0
b5ced000 b5cf7000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cf8000 b5d0e000 r-xp /usr/lib/libudev.so.1.6.0
b5d11000 b5d15000 r-xp /lib/libattr.so.1.1.0
b5d16000 b5d45000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d47000 b5d4d000 r-xp /usr/lib/libffi.so.6.0.2
b5d4e000 b5d71000 r-xp /lib/libz.so.1.2.8
b5d72000 b5d75000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d76000 b5ed2000 r-xp /usr/lib/libxml2.so.2.9.2
b5ed8000 b5fbf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fcc000 b5fcf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd0000 b5ff2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff3000 b6007000 r-xp /lib/libresolv-2.20-2014.11.so
b600b000 b602f000 r-xp /usr/lib/liblzma.so.5.0.3
b6030000 b6032000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6034000 b603e000 r-xp /usr/lib/libembryo.so.1.13.0
b603f000 b6068000 r-xp /usr/lib/libpng12.so.0.50.0
b6069000 b60b2000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c3000 b60ca000 r-xp /lib/librt-2.20-2014.11.so
b60cc000 b60eb000 r-xp /usr/lib/libector.so.1.13.0
b60ee000 b611b000 r-xp /usr/lib/liblua-5.1.so
b611c000 b61ac000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b0000 b61ee000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ef000 b6205000 r-xp /usr/lib/libfribidi.so.0.3.1
b6206000 b625f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6262000 b62ad000 r-xp /lib/libm-2.20-2014.11.so
b62af000 b62c1000 r-xp /usr/lib/libeio.so.1.13.0
b62c2000 b62c5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62c6000 b62cc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62cd000 b62f0000 r-xp /usr/lib/libefreet.so.1.13.0
b62f3000 b631e000 r-xp /usr/lib/libeldbus.so.1.13.0
b631f000 b6353000 r-xp /usr/lib/libecore_con.so.1.13.0
b6355000 b635e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b635f000 b6368000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6369000 b637c000 r-xp /usr/lib/libeo.so.1.13.0
b637e000 b6391000 r-xp /usr/lib/libecore_input.so.1.13.0
b6392000 b6399000 r-xp /usr/lib/libecore_file.so.1.13.0
b639a000 b63bd000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63be000 b63ea000 r-xp /usr/lib/libeet.so.1.13.0
b63f3000 b645e000 r-xp /usr/lib/libeina.so.1.13.0
b6461000 b6478000 r-xp /usr/lib/libefl.so.1.13.0
b647a000 b65e1000 r-xp /usr/lib/libicuuc.so.51.1
b65ef000 b67fb000 r-xp /usr/lib/libicui18n.so.51.1
b6803000 b6852000 r-xp /usr/lib/libecore_x.so.1.13.0
b6854000 b686e000 r-xp /lib/libgcc_s-4.9.so.1
b6870000 b6874000 r-xp /lib/libcap.so.2.21
b6875000 b68bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68bc000 b68c3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c5000 b6917000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6919000 b6aa4000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aa9000 b6b77000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b7a000 b6b7e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b7f000 b6b8e000 r-xp /usr/lib/libvconf.so.0.2.45
b6b8f000 b6b92000 r-xp /usr/lib/libvasum.so.0.3.1
b6b93000 b6b96000 r-xp /usr/lib/libttrace.so.1.1
b6b98000 b6b9c000 r-xp /usr/lib/libiniparser.so.0
b6b9d000 b6bcd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bce000 b6bd7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd8000 b6bfd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bfe000 b6c0e000 r-xp /usr/lib/libunwind.so.8.0.1
b6c18000 b6dc6000 r-xp /lib/libc-2.20-2014.11.so
b6dce000 b6f11000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f13000 b6f6b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f6c000 b6fa0000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa3000 b7077000 r-xp /usr/lib/libedje.so.1.13.0
b707a000 b70a6000 r-xp /usr/lib/libecore.so.1.13.0
b70b7000 b72dd000 r-xp /usr/lib/libevas.so.1.13.0
b7305000 b731d000 r-xp /lib/libpthread-2.20-2014.11.so
b7321000 b769b000 r-xp /usr/lib/libelementary.so.1.13.0
b76bb000 b76bf000 r-xp /usr/lib/libsmack.so.1.0.0
b76c0000 b76c9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ca000 b76cd000 r-xp /usr/lib/libdlog.so.0.0.0
b76ce000 b76d3000 r-xp /usr/lib/libbundle.so.0.1.22
b76d4000 b76d7000 r-xp /lib/libdl-2.20-2014.11.so
b76d9000 b76fe000 r-xp /usr/lib/libaul.so.0.1.0
b7701000 b7703000 r-xp /usr/lib/libappsvc.so.0.1.0
b7704000 b7709000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b770a000 b7711000 r-xp /usr/lib/libappcore-efl.so.1.1
b7713000 b7718000 r-xp /usr/lib/libsys-assert.so
b771b000 b771c000 r-xp [vdso]
b771c000 b773e000 r-xp /lib/ld-2.20-2014.11.so
b7740000 b7748000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:20770)
Call Stack Count: 5
 0: (0xb6d49c0b) [/lib/libc.so.6] + 0x131c0b
 1: (0xb70963f1) [/usr/lib/libecore.so.1] + 0x1c3f1
 2: (0xb642fafb) [/usr/lib/libeina.so.1] + 0x3cafb
 3: (0xb730b15f) [/lib/libpthread.so.0] + 0x615f
 4: clone + 0x5e (0xb6cff3ee) [/lib/libc.so.6] + 0xe73ee
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
-01 19:22:10.997+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:22:10.997+0900 E/INDICATOR( 2842): 
11-01 19:22:15.937+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:22:15.937+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:22:15.937+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:22:15.937+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:22:31.026+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:22:31.026+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:22:31.026+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:22:31.026+0900 E/INDICATOR( 2842): 
11-01 19:22:51.066+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:22:51.066+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:22:51.066+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:22:51.066+0900 E/INDICATOR( 2842): 
11-01 19:23:00.346+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:23:00.346+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:23:00.346+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:23:00.356+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:23 4 h"
11-01 19:23:00.356+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:23"
11-01 19:23:00.356+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;23"
11-01 19:23:00.356+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147050143 Time: <font_size=33>7&#x2236;23</font_size> <font_size=32>PM</font_size></font>
11-01 19:23:11.086+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:23:11.086+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:23:11.086+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:23:11.086+0900 E/INDICATOR( 2842): 
11-01 19:23:15.976+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:23:15.976+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:23:15.976+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:23:15.976+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:23:31.126+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:23:31.126+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:23:31.126+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:23:31.126+0900 E/INDICATOR( 2842): 
11-01 19:23:51.155+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:23:51.155+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:23:51.155+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:23:51.155+0900 E/INDICATOR( 2842): 
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:24 4 h"
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:24"
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;24"
11-01 19:24:00.365+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147063963 Time: <font_size=33>7&#x2236;24</font_size> <font_size=32>PM</font_size></font>
11-01 19:24:11.165+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:24:11.165+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:24:11.165+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:24:11.165+0900 E/INDICATOR( 2842): 
11-01 19:24:15.975+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:24:15.975+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:24:15.975+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:24:15.975+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:24:31.195+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:24:31.195+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:24:31.195+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:24:31.195+0900 E/INDICATOR( 2842): 
11-01 19:24:51.215+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:24:51.215+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:24:51.215+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:24:51.215+0900 E/INDICATOR( 2842): 
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:25 4 h"
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:25"
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;25"
11-01 19:25:00.374+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147062935 Time: <font_size=33>7&#x2236;25</font_size> <font_size=32>PM</font_size></font>
11-01 19:25:11.234+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:25:11.234+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:25:11.234+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:25:11.234+0900 E/INDICATOR( 2842): 
11-01 19:25:15.934+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:25:15.934+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:25:15.934+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:25:15.934+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:25:15.954+0900 I/RESOURCED( 2836): logging.c: logging_save_to_storage(978) > battery cache is empty
11-01 19:25:15.954+0900 I/RESOURCED( 2836): logging.c: logging_save_to_storage(978) > storage cache is empty
11-01 19:25:31.254+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:25:31.254+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:25:31.254+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:25:31.254+0900 E/INDICATOR( 2842): 
11-01 19:25:51.284+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:25:51.284+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:25:51.284+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:25:51.284+0900 E/INDICATOR( 2842): 
11-01 19:25:53.934+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:25:53.934+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8a69140. set autocapital type : 2
11-01 19:25:53.934+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:25:53.934+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 51250027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:25:53.934+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8a69140. on demand : 0
11-01 19:25:53.934+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:25:53.934+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a69140, cursor pos : 0
11-01 19:25:53.944+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8a69140
11-01 19:25:53.944+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:25:54.944+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
11-01 19:25:56.234+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a69140, cursor pos : 1
11-01 19:25:56.234+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8a69140, bidi direction : 0x1
11-01 19:25:56.374+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8a69140, cursor pos : 2
11-01 19:25:57.964+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8a69140
11-01 19:25:57.964+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:25:57.964+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8a69140
11-01 19:25:57.974+0900 E/EFL     (20770): edje<20770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:25:57.974+0900 E/EFL     (20770): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:25:57.974+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:25:57.984+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:25:58.074+0900 I/tichat  (20770): Sent count: 7, msg:
11-01 19:25:58.074+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:25:58.074+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:25:59.944+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60673f bd->visible=1
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:26 4 h"
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:26"
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;26"
11-01 19:26:00.384+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147055251 Time: <font_size=33>7&#x2236;26</font_size> <font_size=32>PM</font_size></font>
11-01 19:26:11.294+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:26:11.294+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:26:11.294+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:26:11.294+0900 E/INDICATOR( 2842): 
11-01 19:26:15.924+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:26:15.924+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:26:15.924+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:26:15.924+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:26:15.924+0900 I/RESOURCED( 2836): logging.c: logging_save_to_storage(978) > abnormal cache is empty
11-01 19:26:31.313+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:26:31.313+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:26:31.313+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:26:31.313+0900 E/INDICATOR( 2842): 
11-01 19:26:51.343+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:26:51.343+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:26:51.343+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:26:51.343+0900 E/INDICATOR( 2842): 
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:27 4 h"
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:27"
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;27"
11-01 19:27:00.393+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146937487 Time: <font_size=33>7&#x2236;27</font_size> <font_size=32>PM</font_size></font>
11-01 19:27:11.353+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:27:11.353+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:27:11.353+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:27:11.353+0900 E/INDICATOR( 2842): 
11-01 19:27:15.973+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:27:15.973+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:27:15.973+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:27:15.973+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:27:29.063+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:27:29.143+0900 E/EFL     (20770): edje<20770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:27:29.143+0900 E/EFL     (20770): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:27:30.073+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
11-01 19:27:30.543+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:27:30.643+0900 I/tichat  (20770): room leaved
11-01 19:27:30.933+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb8a69140
11-01 19:27:30.933+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-01 19:27:30.933+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-01 19:27:31.373+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:27:31.373+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:27:31.373+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:27:31.373+0900 E/INDICATOR( 2842): 
11-01 19:27:32.143+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:27:32.203+0900 I/tichat  (20770): socket 49 requset sent: 12, msg:getroomlist/ 
11-01 19:27:32.203+0900 I/tichat  (20770): roomlist : khkjhkj$
11-01 19:27:33.203+0900 I/tichat  (20770): not toked : khkjhkj$
11-01 19:27:33.203+0900 I/tichat  (20770): toked : khkjhkj
11-01 19:27:34.633+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:27:34.783+0900 I/tichat  (20770): Sent count: 17, msg:
11-01 19:27:34.783+0900 E/EFL     (20770): elementary<20770> elm_layout.c:982 _elm_layout_elm_container_content_set() could not swallow 0x801b43a8 into part 'elm.swallow.indicator_bg'
11-01 19:27:35.143+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60673f bd->visible=1
11-01 19:27:36.803+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:27:36.803+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb89f0b58. set autocapital type : 2
11-01 19:27:36.803+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:27:36.803+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb89f0b58. on demand : 0
11-01 19:27:36.803+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 51260027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:27:36.803+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:27:36.803+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 0
11-01 19:27:36.813+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb89f0b58
11-01 19:27:36.813+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:27:41.812+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 1
11-01 19:27:41.812+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb89f0b58, bidi direction : 0x1
11-01 19:27:41.992+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 2
11-01 19:27:42.142+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 3
11-01 19:27:42.192+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 4
11-01 19:27:43.552+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb89f0b58
11-01 19:27:43.552+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:27:43.552+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb89f0b58
11-01 19:27:43.562+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:27:43.562+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:27:43.612+0900 I/tichat  (20770): Sent count: 9, msg:
11-01 19:27:43.612+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:27:43.612+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:27:51.402+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:27:51.402+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:27:51.402+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:27:51.402+0900 E/INDICATOR( 2842): 
11-01 19:27:58.762+0900 I/tichat  (20770): load message : Xsmxnsnz
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.762+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.772+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.782+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.792+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.792+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:27:58.792+0900 E/EFL     (20770): ecore<20770> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:28 4 h"
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:28"
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;28"
11-01 19:28:00.412+0900 D/INDICATOR( 2842): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146935435 Time: <font_size=33>7&#x2236;28</font_size> <font_size=32>PM</font_size></font>
11-01 19:28:04.712+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:28:04.712+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb89f0b58. set autocapital type : 2
11-01 19:28:04.712+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:28:04.712+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 51260027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:28:04.712+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb89f0b58. on demand : 0
11-01 19:28:04.712+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:28:04.712+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 0
11-01 19:28:04.712+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb89f0b58
11-01 19:28:04.712+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:28:05.662+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 1
11-01 19:28:05.662+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb89f0b58, bidi direction : 0x1
11-01 19:28:05.712+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
11-01 19:28:05.732+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 2
11-01 19:28:06.092+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 3
11-01 19:28:06.142+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 4
11-01 19:28:06.292+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 5
11-01 19:28:06.522+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 6
11-01 19:28:06.572+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 7
11-01 19:28:06.652+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 8
11-01 19:28:07.862+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb89f0b58
11-01 19:28:07.862+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:28:07.862+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb89f0b58
11-01 19:28:07.862+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:28:07.872+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:28:07.912+0900 I/tichat  (20770): Sent count: 13, msg:
11-01 19:28:07.922+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:28:07.922+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:28:10.712+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60673f bd->visible=1
11-01 19:28:11.412+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:28:11.412+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:28:11.412+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:28:11.412+0900 E/INDICATOR( 2842): 
11-01 19:28:15.912+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
11-01 19:28:15.912+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
11-01 19:28:15.912+0900 D/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
11-01 19:28:15.912+0900 I/RESOURCED( 2836): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
11-01 19:28:20.712+0900 E/EFL     (20770): edje<20770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p11';
11-01 19:28:20.712+0900 E/EFL     (20770): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:28:20.832+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:28:20.832+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb89f0b58. set autocapital type : 2
11-01 19:28:20.832+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:28:20.832+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 51260027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:28:20.832+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb89f0b58. on demand : 0
11-01 19:28:20.832+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:28:20.832+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 0
11-01 19:28:20.842+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb89f0b58
11-01 19:28:20.842+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:28:20.842+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb89f0b58
11-01 19:28:20.842+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:28:20.842+0900 E/EFL     (20770): edje<20770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p12';
11-01 19:28:20.842+0900 E/EFL     (20770): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:28:20.892+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:28:20.892+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:28:21.832+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
11-01 19:28:23.182+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:28:23.182+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb89f0b58. set autocapital type : 2
11-01 19:28:23.182+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_in(245) > Enter
11-01 19:28:23.182+0900 D/ISE_DEFAULT( 3015): ise.cpp: ise_focus_in(824) > ic : 51260027 , 0 , g_ic : b5e0023 , 0, g_focused_ic : 0 , 1
11-01 19:28:23.182+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb89f0b58. on demand : 0
11-01 19:28:23.182+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:28:23.182+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb89f0b58, cursor pos : 0
11-01 19:28:23.182+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb89f0b58
11-01 19:28:23.182+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
11-01 19:28:26.832+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60673f bd->visible=1
11-01 19:28:31.442+0900 E/CAPI_NETWORK_WIFI( 2842): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
11-01 19:28:31.442+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
11-01 19:28:31.442+0900 E/INDICATOR( 2842): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
11-01 19:28:31.442+0900 E/INDICATOR( 2842): 
11-01 19:28:42.282+0900 D/IMMODULE(20770): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
11-01 19:28:42.282+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-01 19:28:42.282+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-01 19:28:42.392+0900 D/IMMODULE(20770): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
11-01 19:28:42.392+0900 D/ISF_PANEL_EFL( 3011): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
11-01 19:28:42.392+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
11-01 19:28:42.422+0900 D/IMMODULE(20770): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb89f0b58
11-01 19:28:42.422+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
11-01 19:28:42.422+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb89f0b58
11-01 19:28:42.422+0900 D/ISE_DEFAULT( 3015): ise.cpp: on_focus_out(251) > Enter
11-01 19:28:42.702+0900 D/IMMODULE(20770): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
11-01 19:28:42.702+0900 D/ISF_PANEL_EFL( 3011): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 41 36
11-01 19:28:43.822+0900 D/PROCESSMGR( 2763): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60673f 
11-01 19:28:43.902+0900 E/EFL     (20770): edje<20770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
11-01 19:28:43.902+0900 E/EFL     (20770): By the power of Grayskull, your previous Embryo stack is now broken!
11-01 19:28:44.142+0900 I/CAPI_APPFW_APPLICATION(20770): app_main.c: ui_app_exit(799) > ui_app_exit
11-01 19:28:44.142+0900 D/AUL     (20770): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
11-01 19:28:44.142+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 22
11-01 19:28:44.142+0900 W/AUL_AMD ( 2746): amd_request.c: __request_handler(1056) > app status : 5
11-01 19:28:44.142+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(20770) status(5)
11-01 19:28:44.142+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(20770) appid(org.example.tichat) pkgid(org.example.tichat) status(5)
11-01 19:28:44.142+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.tichat
11-01 19:28:44.142+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 20770, appid: org.example.tichat, status: bg
11-01 19:28:44.142+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 20770, appname = org.example.tichat, pkgname = org.example.tichat
11-01 19:28:44.142+0900 D/RESOURCED( 2836): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 20770, appname = org.example.tichat
11-01 19:28:44.142+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 20770
11-01 19:28:44.142+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2847 increase lru 15
11-01 19:28:44.142+0900 D/RESOURCED( 2836): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.example.tichat
11-01 19:28:44.142+0900 D/RESOURCED( 2836): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 20770, proc_name: org.example.tichat, cg_name: favorite, oom_score_adj: 270
11-01 19:28:44.142+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 20770
11-01 19:28:44.152+0900 D/APP_CORE(20770): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
11-01 19:28:44.152+0900 D/APP_CORE(20770): appcore-efl.c: __after_loop(1169) > [APP 20770] PAUSE before termination
11-01 19:28:44.152+0900 I/CAPI_APPFW_APPLICATION(20770): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
11-01 19:28:44.152+0900 I/CAPI_APPFW_APPLICATION(20770): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
11-01 19:28:44.152+0900 E/EFL     (20770): eo<20770> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80054ca8 is not pointing to a valid object. Maybe it has already been freed.
11-01 19:28:44.152+0900 E/EFL     (20770): eo<20770> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80054ca8) is an invalid ref.
11-01 19:28:44.152+0900 E/EFL     ( 2763): eo<2763> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
11-01 19:28:44.162+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(2849) status(3)
11-01 19:28:44.162+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
11-01 19:28:44.162+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-01 19:28:44.162+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
11-01 19:28:44.162+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2849) status(3)
11-01 19:28:44.162+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2849) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
11-01 19:28:44.162+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
11-01 19:28:44.162+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2849, appid: org.tizen.homescreen, status: fg
11-01 19:28:44.182+0900 D/RESOURCED( 2836): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2849
11-01 19:28:44.182+0900 D/RESOURCED( 2836): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2849, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
11-01 19:28:44.182+0900 D/RESOURCED( 2836): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2849, appname = org.tizen.homescreen
11-01 19:28:44.182+0900 D/RESOURCED( 2836): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2849
11-01 19:28:44.202+0900 E/E17     ( 2763): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
11-01 19:28:44.202+0900 E/E17     ( 2763): e_border.c: e_border_hide(2248) > BD_HIDE(0x02c00002), visible:1
11-01 19:28:44.212+0900 W/CRASH_MANAGER(20990): worker.c: worker_job(1204) > 1120770746963147799612
