#include "tichat.h"



#define APP_VIEW_EDJ "opt/usr/apps/org.example.tichat/res/app_view.edj"


/* callback for curl fetch */
size_t curl_callback (void *contents, size_t size, size_t nmemb, void *userp) {
    size_t realsize = size * nmemb;                             /* calculate buffer size */
    struct curl_fetch_st *p = (struct curl_fetch_st *) userp;   /* cast pointer to fetch struct */

    /* expand buffer */
    p->payload = (char *) realloc(p->payload, p->size + realsize + 1);

    /* check buffer */
    if (p->payload == NULL) {
      /* this isn't good */
      fprintf(stderr, "ERROR: Failed to expand buffer in curl_callback");

      /* free buffer */
      free(p->payload);
      /* return */
      return -1;
    }

    /* copy contents to buffer */
    memcpy(&(p->payload[p->size]), contents, realsize);

    /* set new buffer size */
    p->size += realsize;

    /* ensure null termination */
    p->payload[p->size] = 0;

    /* return size */
    return realsize;
}

/* fetch and return url body via curl */
CURLcode curl_fetch_url(CURL *ch, const char *url, struct curl_fetch_st *fetch) {
    CURLcode rcode;                   /* curl result code */

    /* init payload */
    fetch->payload = (char *) calloc(1, sizeof(fetch->payload));

    /* check payload */
    if (fetch->payload == NULL) {
        /* log error */
        dlog_print(DLOG_INFO, LOG_TAG, "ERROR: Failed to allocate payload in curl_fetch_url");
        /* return error */
        return CURLE_FAILED_INIT;
    }

    /* init size */
    fetch->size = 0;

    /* set url to fetch */
    curl_easy_setopt(ch, CURLOPT_URL, url);

    /* set calback function */
    curl_easy_setopt(ch, CURLOPT_WRITEFUNCTION, curl_callback);

    /* pass fetch struct pointer */
    curl_easy_setopt(ch, CURLOPT_WRITEDATA, (void *) fetch);

    /* set default user agent */
    curl_easy_setopt(ch, CURLOPT_USERAGENT, "libcurl-agent/1.0");

    /* set timeout */
    curl_easy_setopt(ch, CURLOPT_TIMEOUT, 5);

    /* enable location redirects */
    curl_easy_setopt(ch, CURLOPT_FOLLOWLOCATION, 1);

    /* set maximum allowed redirects */
    curl_easy_setopt(ch, CURLOPT_MAXREDIRS, 1);

    /* fetch the url */
    rcode = curl_easy_perform(ch);

    /* return */
    return rcode;
}



static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	if(socket_fd!=0){
		write(socket_fd,"disconnect/",12);
		close(socket_fd);
	}
	ui_app_exit();
}
/*
static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	//Letwindow go to hide state.
	elm_win_lower(ad->win);
}
*/



static void
login_popup_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup = data;
	evas_object_del(popup);
}
static void
exit_button_cb(void *data, Evas_Object *obj, void *event_inf)
{
	if(socket_fd!=0){
		write(socket_fd,"disconnect/",12);
		close(socket_fd);
	}
	ui_app_exit();
}

static Evas_Object *
create_exit_popup(appdata_s *ad)
{
	Evas_Object *popup, *button1,*button2;

	Eina_Strbuf *buf = eina_strbuf_new();

	popup = elm_popup_add(ad->nf);
	eina_strbuf_append_printf(buf, "Exit App");
	elm_object_text_set(popup, eina_strbuf_string_steal(buf));
	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	elm_object_part_text_set(popup, "title,text", "Exit");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	button1 = elm_button_add(popup);
	elm_object_style_set(button1, "popup");
	elm_object_text_set(button1, "Exit");
	elm_object_part_content_set(popup, "button2", button1);
	evas_object_smart_callback_add(button1, "clicked", 	exit_button_cb, popup);

	button2 = elm_button_add(popup);
	elm_object_style_set(button2, "popup");
	elm_object_text_set(button2, "Cancle");
	elm_object_part_content_set(popup, "button1", button2);
	evas_object_smart_callback_add(button2, "clicked",login_popup_button_clicked_cb , popup);

	eina_strbuf_free(buf);

	return popup;
}

static void _app_navi_back_cb(void *data,Evas_Object *obj, void *event_info){
	appdata_s *ad = data;
	Evas_Object *popup;
	popup =	create_exit_popup(ad);
	evas_object_show(popup);
}


#define PROFILE_IMAGE_HEIGHT 150


static Eina_Bool
naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	appdata_s *ad = data;

	/* Let window go to hide state. */
	elm_win_lower(ad->win);

	return EINA_FALSE;
}
static Evas_Object *
create_singleline_editfield_layout(Evas_Object *parent)
{
	Evas_Object *editfield, *entry;

	editfield = elm_layout_add(parent);
	elm_layout_theme_set(editfield, "layout", "editfield", "singleline");

	entry = elm_entry_add(editfield);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_object_part_content_set(editfield, "elm.swallow.content", entry);

	return editfield;
}

static void
login_scroller_del_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	login_data_s *ld = data;
	ld->nf = NULL;
	ld->account_entry = NULL;
	ld->password_entry = NULL;
	ld->login_button = NULL;
	if (ld->account_text) free(ld->account_text);
	if (ld->password_text) free(ld->password_text);
	ld->account_text = NULL;
	ld->password_text = NULL;
}

static void
login_account_entry_activated_cb(void *data, Evas_Object *obj, void *event_info)
{
	login_data_s *ld = data;

	elm_object_focus_set(ld->password_entry, EINA_TRUE);
}

static void
login_save_account_info(login_data_s *ld)
{
	if (ld->account_text) free(ld->account_text);
	if (ld->password_text) free(ld->password_text);
	ld->account_text = NULL;
	ld->password_text = NULL;

	ld->account_text = elm_entry_markup_to_utf8(elm_entry_entry_get(ld->account_entry));
	ld->password_text = strdup(elm_entry_entry_get(ld->password_entry));
}


static void
roomlist_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ld = data;
	roomlist_cb(ld,obj,event_info);
}


static Evas_Object *
create_login_popup(login_data_s *ld)
{
	Evas_Object *popup, *button;
	char *password_markup;

	Eina_Strbuf *buf = eina_strbuf_new();
	password_markup = elm_entry_utf8_to_markup(ld->password_text);

	popup = elm_popup_add(ld->nf);
	eina_strbuf_append_printf(buf, "Account: %s<br/>로그인 성공",
			ld->account_text);
	elm_object_text_set(popup, eina_strbuf_string_steal(buf));
	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	elm_object_part_text_set(popup, "title,text", "Login");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	button = elm_button_add(popup);
	elm_object_style_set(button, "popup");
	elm_object_text_set(button, "방목록");
	elm_object_part_content_set(popup, "button1", button);
	evas_object_smart_callback_add(button, "clicked", roomlist_button_cb, ld);
	evas_object_smart_callback_add(button, "clicked", login_popup_button_clicked_cb, popup);

	eina_strbuf_free(buf);
	free(password_markup);

	return popup;
}

static Evas_Object *
create_login_failed_popup(login_data_s *ld,char *recieved)
{
	Evas_Object *popup, *button;

	Eina_Strbuf *buf = eina_strbuf_new();

	popup = elm_popup_add(ld->nf);
	eina_strbuf_append_printf(buf, "Error :%s",recieved);
	elm_object_text_set(popup, eina_strbuf_string_steal(buf));
	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	elm_object_part_text_set(popup, "title,text", "Login");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	button = elm_button_add(popup);
	elm_object_style_set(button, "popup");
	elm_object_text_set(button, "OK");
	elm_object_part_content_set(popup, "button1", button);
	evas_object_smart_callback_add(button, "clicked", login_popup_button_clicked_cb, popup);

	eina_strbuf_free(buf);
	return popup;
}

static void
login_password_entry_activated_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	login_data_s *ld = data;

	if (!elm_entry_is_empty(ld->account_entry) && !elm_entry_is_empty(ld->password_entry)) {
		login_save_account_info(ld);
		popup = create_login_popup(ld);
		evas_object_show(popup);
	}
}



static Evas_Object *
create_input_field(Evas_Object *parent, login_data_s *ld)
{
	Evas_Object *box, *editfield, *label;

	box = elm_box_add(parent);
	label = elm_label_add(box);
	evas_object_size_hint_align_set(label, 0.5, 1);
	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, 0.0);
	elm_object_text_set(label, "<color=#000000><font_size=60><b>TiChat<br><br></b></font_size></color>");
	elm_box_pack_end(box, label);
	evas_object_show(label);


	label = elm_label_add(box);
	evas_object_size_hint_align_set(label, 0.05, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, 0.0);
	elm_object_text_set(label, "<b>ID</b>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	/* Account Editfield */
	editfield = create_singleline_editfield_layout(box);
	evas_object_size_hint_align_set(editfield, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(editfield, EVAS_HINT_EXPAND, 0.0);

	ld->account_entry = elm_object_part_content_get(editfield, "elm.swallow.content");
	elm_object_part_text_set(ld->account_entry, "elm.guide", "Enter your ID");
	elm_entry_input_panel_layout_set(ld->account_entry, ELM_INPUT_PANEL_LAYOUT_NORMAL);
	elm_entry_input_panel_return_key_type_set(ld->account_entry, ELM_INPUT_PANEL_RETURN_KEY_TYPE_NEXT);
	evas_object_smart_callback_add(ld->account_entry, "activated", login_account_entry_activated_cb, ld);

	elm_box_pack_end(box, editfield);
	evas_object_show(editfield);

	label = elm_label_add(box);
	evas_object_size_hint_align_set(label, 0.05, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, 0.0);
	elm_object_text_set(label, "<b>Password</b>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	/* Password Editfield */
	editfield = create_singleline_editfield_layout(box);
	evas_object_size_hint_align_set(editfield, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(editfield, EVAS_HINT_EXPAND, 0.0);

	ld->password_entry = elm_object_part_content_get(editfield, "elm.swallow.content");
	elm_entry_password_set(ld->password_entry, EINA_TRUE);
	elm_object_part_text_set(ld->password_entry, "elm.guide", "Enter your password");
	elm_entry_input_panel_layout_set(ld->password_entry, ELM_INPUT_PANEL_LAYOUT_PASSWORD);
	elm_entry_input_panel_return_key_type_set(ld->password_entry, ELM_INPUT_PANEL_RETURN_KEY_TYPE_DONE);
	evas_object_smart_callback_add(ld->password_entry, "activated", login_password_entry_activated_cb, ld);

	elm_box_pack_end(box, editfield);
	evas_object_show(editfield);

	return box;
}



static void
signup_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	signup_cb(ad,obj,event_info);
}



static void
login_login_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	login_data_s *ld = data;

	login_save_account_info(ld);
	int error_code;
	error_code = connection_create(&connection);
	if (error_code != CONNECTION_ERROR_NONE)
		dlog_print(DLOG_INFO, LOG_TAG, "Connection Failed!!!!!!!!!!!!");

	connection_type_e net_state;
	error_code = connection_get_type(connection, &net_state);
	if (error_code == CONNECTION_ERROR_NONE) {
		dlog_print(DLOG_INFO, LOG_TAG, "Network connection type : %d", net_state);
	}


	/*json make*/
	char *password_markup;
	password_markup = elm_entry_utf8_to_markup(ld->password_text);

	CURL *ch;
	CURLcode rcode;


    struct curl_fetch_st curl_fetch;                        /* curl fetch struct */
    struct curl_fetch_st *cf = &curl_fetch;                 /* pointer to fetch struct */
    struct curl_slist *headers = NULL;                      /* http headers to send with request */

    char *url = "http://172.20.10.2:3000/login";
    if ((ch = curl_easy_init()) == NULL) {
            /* log error */
            dlog_print(DLOG_INFO, LOG_TAG, "ERROR: Failed to create curl handle in fetch_session");
            /* return error */
    }
    headers = curl_slist_append(headers, "Accept: application/json");
    headers = curl_slist_append(headers, "Content-Type: application/json");

    cJSON *root = NULL;
    cJSON *res = NULL;
    char *json = NULL;
    root = cJSON_CreateObject();

    cJSON_AddStringToObject(root,"id", ld->account_text);
    cJSON_AddStringToObject(root,"password", password_markup);

    json =  cJSON_PrintUnformatted(root);

    curl_easy_setopt(ch, CURLOPT_CUSTOMREQUEST, "POST");
    curl_easy_setopt(ch, CURLOPT_HTTPHEADER, headers);
    curl_easy_setopt(ch, CURLOPT_POSTFIELDS, json);

    rcode = curl_fetch_url(ch, url, cf);


    curl_easy_cleanup(ch);
    /* free headers */
    curl_slist_free_all(headers);


    if (rcode != CURLE_OK || cf->size < 1) {

        /* log error */
        dlog_print(DLOG_INFO, LOG_TAG, "ERROR: Failed to fetch url (%s) - curl said: %s",url, curl_easy_strerror(rcode));
        popup = create_login_failed_popup(ld,"연결실패");
		evas_object_show(popup);
    }
    if (cf->payload != NULL) {
        /* print result */
        dlog_print(DLOG_INFO, LOG_TAG, "CURL Returned: \n%s\n", cf->payload);
        /* parse return */
        res = cJSON_Parse(cf->payload);
        /* free payload */
         free(cf->payload);
    } else {
        /* error */
        dlog_print(DLOG_INFO, LOG_TAG, "ERROR: Failed to populate payload");
        /* free payload */
        free(cf->payload);
        /* return */
    }
     /* check error */

    /* debugging */


    cJSON *item = NULL;
    item = cJSON_GetObjectItem(res, "message");
    dlog_print(DLOG_INFO, LOG_TAG, "Parsed JSON: %s\n", cJSON_PrintUnformatted(item));
    char * final_result = cJSON_PrintUnformatted(item);
	if(!strcmp(final_result,"\"로그인 실패\"")){
		popup = create_login_failed_popup(ld,"아이디와 비밀번호를 확인해주세요");
		evas_object_show(popup);
	}
	else if(!strcmp(final_result,"\"로그인 성공\"")){
		popup = create_login_popup(ld);
		evas_object_show(popup);
	}
	else{
		popup = create_login_failed_popup(ld,final_result);
		evas_object_show(popup);
	}


	connection_destroy(connection);
}

static void
login_account_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	login_data_s *ld = data;

	if (!elm_entry_is_empty(ld->account_entry) && !elm_entry_is_empty(ld->password_entry))
		elm_object_disabled_set(ld->login_button, EINA_FALSE);
	else
		elm_object_disabled_set(ld->login_button, EINA_TRUE);
}

static void
login_password_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	login_data_s *ld = data;

	if (!elm_entry_is_empty(ld->account_entry) && !elm_entry_is_empty(ld->password_entry))
		elm_object_disabled_set(ld->login_button, EINA_FALSE);
	else
		elm_object_disabled_set(ld->login_button, EINA_TRUE);
}

static Evas_Object *
create_button_field(Evas_Object *parent, login_data_s *ld,void *data)
{
	appdata_s *ad = data;
	Evas_Object *box, *button;
	box = elm_box_add(parent);
	elm_box_horizontal_set(box, EINA_TRUE);
	elm_box_padding_set(box, ELM_SCALE_SIZE(10), 0);

	/* signup Button */
	button = elm_button_add(box);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, 0.0);
	evas_object_smart_callback_add(button, "clicked", signup_button_cb, ad);
	elm_object_text_set(button, "Sign Up");
	elm_box_pack_end(box, button);
	evas_object_show(button);

	/* Login Button */
	ld->login_button = elm_button_add(box);
	evas_object_size_hint_align_set(ld->login_button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(ld->login_button, EVAS_HINT_EXPAND, 0.0);
	evas_object_smart_callback_add(ld->login_button, "clicked", login_login_button_clicked_cb, ld);
	elm_object_text_set(ld->login_button, "Login");
	elm_object_disabled_set(ld->login_button, EINA_TRUE);
	elm_box_pack_end(box, ld->login_button);
	evas_object_show(ld->login_button);

	evas_object_smart_callback_add(ld->account_entry, "changed", login_account_entry_changed_cb, ld);
	evas_object_smart_callback_add(ld->password_entry, "changed", login_password_entry_changed_cb, ld);

	return box;
}



static void
create_base_gui(appdata_s *ad)
{
	// Window
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);
	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, _app_navi_back_cb, ad);
	elm_app_base_scale_set(1.8);
	// Conformant
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	// Add the naviframe
	ad->nf = elm_naviframe_add(ad->conform);
	evas_object_size_hint_weight_set(ad->nf, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->nf);

	// Create the login view
	Evas_Object *scroller, *layout,  *box;
	static login_data_s ld = {0,};
	ld.nf = ad->nf;
	Elm_Object_Item *nf_it;
	scroller = elm_scroller_add(ld.nf);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, 0.0);
	evas_object_event_callback_add(scroller, EVAS_CALLBACK_DEL, login_scroller_del_cb, &ld);

	layout = elm_layout_add(scroller);
	elm_layout_file_set(layout, APP_VIEW_EDJ, "login_layout");
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, 0.0);

	box = create_input_field(layout, &ld);
	elm_object_part_content_set(layout, "elm.swallow.content", box);

	box = create_button_field(layout, &ld,ad);
	elm_object_part_content_set(layout, "elm.swallow.buttons", box);

	elm_object_content_set(scroller, layout);

	nf_it = elm_naviframe_item_push(ld.nf, "Login", NULL, NULL, scroller, NULL);
	elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, ad);

	//elm_naviframe_item_popup_cb_set(ad->frame_item,naviframe_pop_cb,ad);
	// Show the window after the base GUI is set up
	evas_object_show(ad->win);
}


static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/

	int ret;
	char *language;

	ret = app_event_get_language(event_info, &language);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_event_get_language() failed. Err = %d.", ret);
		return;
	}

	if (language != NULL) {
		elm_language_set(language);
		free(language);
	}
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
