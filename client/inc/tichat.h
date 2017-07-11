#ifndef __tichat_H__
#define __tichat_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <curl/curl.h>
#include <stdlib.h>
#include <glib-object.h>
#include <json-glib/json-glib.h>
#include <net_connection.h>
#include <cJSON.h>
#include <string.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "tichat"

#if !defined(PACKAGE)
#define PACKAGE "org.example.tichat"
#endif


#undef FALSE
#define FALSE 0
#undef TRUE
#define TRUE 1


#define APP_VIEW_EDJ "opt/usr/apps/org.example.tichat/res/app_view.edj"
#define ICON_DIR "opt/usr/apps/org.example.tichat/res/images"

int socket_fd;
typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *nf;
} appdata_s;

typedef struct login_data {
	Evas_Object *nf;
	Evas_Object *account_entry;
	Evas_Object *password_entry;
	Evas_Object *login_button;

	char *account_text;
	char *password_text;
} login_data_s;

typedef struct room_data {
	Evas_Object *nf;
	Evas_Object *roomname_entry;
	Evas_Object *create_button;
	Evas_Object *create_popup_button;
	Evas_Object *roomscroller;
	Evas_Object *roomlist;
	Evas_Object *createpopup;
	Ecore_Thread *read_message;
	Elm_Genlist_Item_Class *itc;
	char *itemlist;
	char *id;
	char *roomname_text;

	//chat
	char *id_text;
	const char *selected_roomname_text;
	Evas_Object *main_box;
	Evas_Object *bubble_scroller;
	Evas_Object *bubble_box;
	Evas_Object *input_field_entry;

	int num_of_bubbles;
	int total_messages;

} room_data_s;

struct curl_fetch_st {
    char *payload;
    size_t size;
};

#define BUBBLE_TEXT_WIDTH 400
#define NUM_OF_SAMPLE_MESSAGES 10
#define BUBBLE_MAIN_TEXT_STYLE "<font_size=40>%s</font_size>"
#define BUBBLE_SUB_TEXT_STYLE "<font_size=20 font_weight=Bold color=#454545>%s</font_size>"

typedef enum {
	MESSAGE_BUBBLE_NONE = 0,
	MESSAGE_BUBBLE_SENT,
	MESSAGE_BUBBLE_RECEIVE,
	MESSAGE_BUBBLE_LAST
} Message_Bubble_Style;


static connection_h connection;

void signup_cb(void *data, Evas_Object *obj, void *event_info);
void roomlist_cb(void *data, Evas_Object *obj, void *event_info);
void enter_room(void *data, const char * roomname);

size_t curl_callback (void *contents, size_t size, size_t nmemb, void *userp);
CURLcode curl_fetch_url(CURL *ch, const char *url, struct curl_fetch_st *fetch);

#if !defined(PACKAGE)
#define PACKAGE "org.example.tichat"
#endif

#endif /* __tichat_H__ */
