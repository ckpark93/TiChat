
#include "tichat.h"
#include <curl/curl.h>
typedef struct signup_data {
	Evas_Object *nf;
	Evas_Object *account_entry;
	Evas_Object *password_entry;
	Evas_Object *signup_button;

	char *account_text;
	char *password_text;
} signup_data_s;

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
signup_scroller_del_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	signup_data_s *sd = data;
	sd->nf = NULL;
	sd->account_entry = NULL;
	sd->password_entry = NULL;
	sd->signup_button = NULL;
	if (sd->account_text) free(sd->account_text);
	if (sd->password_text) free(sd->password_text);
	sd->account_text = NULL;
	sd->password_text = NULL;
}


static void
signup_account_entry_activated_cb(void *data, Evas_Object *obj, void *event_info)
{
	signup_data_s *sd = data;

	elm_object_focus_set(sd->password_entry, EINA_TRUE);
}


static void
signup_save_account_info(signup_data_s *sd)
{
	if (sd->account_text) free(sd->account_text);
	if (sd->password_text) free(sd->password_text);
	sd->account_text = NULL;
	sd->password_text = NULL;

	sd->account_text = elm_entry_markup_to_utf8(elm_entry_entry_get(sd->account_entry));
	sd->password_text = strdup(elm_entry_entry_get(sd->password_entry));
}
static void
signup_popup_button_ok_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup = data;
	evas_object_del(popup);
}


static Evas_Object *
create_signup_popup(signup_data_s *sd)
{
	Evas_Object *popup, *buttonok;
	char *password_markup;

	Eina_Strbuf *buf = eina_strbuf_new();
	password_markup = elm_entry_utf8_to_markup(sd->password_text);

	popup = elm_popup_add(sd->nf);
	eina_strbuf_append_printf(buf, "Account: %s<br/>Password: %s<br/>회원가입 성공",
			sd->account_text, password_markup);
	elm_object_text_set(popup, eina_strbuf_string_steal(buf));
	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	elm_object_part_text_set(popup, "title,text", "signup");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	buttonok = elm_button_add(popup);
	elm_object_style_set(buttonok, "popup");
	elm_object_text_set(buttonok, "OK");
	elm_object_part_content_set(popup, "button1", buttonok);
	evas_object_smart_callback_add(buttonok, "clicked", signup_popup_button_ok_clicked_cb, popup);


	eina_strbuf_free(buf);
	free(password_markup);

	return popup;
}
static Evas_Object *
create_signfailed_popup(signup_data_s *sd,char * res)
{
	Evas_Object *popup, *buttonok;\
	Eina_Strbuf *buf = eina_strbuf_new();\

	popup = elm_popup_add(sd->nf);
	eina_strbuf_append_printf(buf, "Error :%s",res);
	elm_object_text_set(popup, eina_strbuf_string_steal(buf));
	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	elm_object_part_text_set(popup, "title,text", "failed");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	buttonok = elm_button_add(popup);
	elm_object_style_set(buttonok, "popup");
	elm_object_text_set(buttonok, "OK");
	elm_object_part_content_set(popup, "button1", buttonok);
	evas_object_smart_callback_add(buttonok, "clicked", signup_popup_button_ok_clicked_cb, popup);


	eina_strbuf_free(buf);\

	return popup;
}
static void
signup_password_entry_activated_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	signup_data_s *sd = data;

	if (!elm_entry_is_empty(sd->account_entry) && !elm_entry_is_empty(sd->password_entry)) {
		signup_save_account_info(sd);
		popup = create_signup_popup(sd);
		evas_object_show(popup);
	}
}

static Evas_Object *
create_input_field(Evas_Object *parent, signup_data_s *sd)
{
	Evas_Object *box, *editfield, *label;

	box = elm_box_add(parent);
	label = elm_label_add(box);
	evas_object_size_hint_align_set(label, 0.05, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, 0.0);
	elm_object_text_set(label, "<b>ID</b>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	/* ID Editfield */
	editfield = create_singleline_editfield_layout(box);
	evas_object_size_hint_align_set(editfield, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(editfield, EVAS_HINT_EXPAND, 0.0);
	sd->account_entry = elm_object_part_content_get(editfield, "elm.swallow.content");
	elm_object_part_text_set(sd->account_entry, "elm.guide", "Enter your ID");
	elm_entry_input_panel_layout_set(sd->account_entry, ELM_INPUT_PANEL_LAYOUT_NORMAL);
	elm_entry_input_panel_return_key_type_set(sd->account_entry, ELM_INPUT_PANEL_RETURN_KEY_TYPE_NEXT);
	evas_object_smart_callback_add(sd->account_entry, "activated", signup_account_entry_activated_cb, sd);

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

	sd->password_entry = elm_object_part_content_get(editfield, "elm.swallow.content");
	elm_entry_password_set(sd->password_entry, EINA_TRUE);
	elm_object_part_text_set(sd->password_entry, "elm.guide", "Enter your password");
	elm_entry_input_panel_layout_set(sd->password_entry, ELM_INPUT_PANEL_LAYOUT_PASSWORD);
	elm_entry_input_panel_return_key_type_set(sd->password_entry, ELM_INPUT_PANEL_RETURN_KEY_TYPE_DONE);
	evas_object_smart_callback_add(sd->password_entry, "activated", signup_password_entry_activated_cb, sd);

	elm_box_pack_end(box, editfield);
	evas_object_show(editfield);

	return box;
}

static void
signup_cancel_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	signup_data_s *sd = data;

	elm_naviframe_item_pop(sd->nf);
}





static void
signup_signup_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	signup_data_s *sd = data;

	signup_save_account_info(sd);

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
	password_markup = elm_entry_utf8_to_markup(sd->password_text);

	CURL *ch;
	CURLcode rcode;


    struct curl_fetch_st curl_fetch;                        /* curl fetch struct */
    struct curl_fetch_st *cf = &curl_fetch;                 /* pointer to fetch struct */
    struct curl_slist *headers = NULL;                      /* http headers to send with request */

    char *url = "http://172.20.10.2:3000/signup";
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

    cJSON_AddStringToObject(root,"id", sd->account_text);
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
        popup = create_signfailed_popup(sd,"연결실패");
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
	if(!strcmp(final_result,"\"유저있음\"")){
		popup = create_signfailed_popup(sd,"이미 유저가 존재합니다");
		evas_object_show(popup);
	}
	else if(!strcmp(final_result,"\"가입성공\"")){
		popup = create_signup_popup(sd);
		evas_object_show(popup);
		elm_naviframe_item_pop(sd->nf);
	}
	else{
		popup = create_signfailed_popup(sd,final_result);
		evas_object_show(popup);
	}


}

static void
signup_account_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	signup_data_s *sd = data;

	if (!elm_entry_is_empty(sd->account_entry) && !elm_entry_is_empty(sd->password_entry))
		elm_object_disabled_set(sd->signup_button, EINA_FALSE);
	else
		elm_object_disabled_set(sd->signup_button, EINA_TRUE);
}

static void
signup_password_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	signup_data_s *sd = data;

	if (!elm_entry_is_empty(sd->account_entry) && !elm_entry_is_empty(sd->password_entry))
		elm_object_disabled_set(sd->signup_button, EINA_FALSE);
	else
		elm_object_disabled_set(sd->signup_button, EINA_TRUE);
}

static Evas_Object *
create_button_field(Evas_Object *parent, signup_data_s *sd)
{
	Evas_Object *box, *button;

	box = elm_box_add(parent);
	elm_box_horizontal_set(box, EINA_TRUE);
	elm_box_padding_set(box, ELM_SCALE_SIZE(10), 0);

	/* Cancel Button */
	button = elm_button_add(box);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, 0.0);
	evas_object_smart_callback_add(button, "clicked", signup_cancel_button_clicked_cb, sd);
	elm_object_text_set(button, "Cancel");
	elm_box_pack_end(box, button);
	evas_object_show(button);

	/* signup Button */
	sd->signup_button = elm_button_add(box);
	evas_object_size_hint_align_set(sd->signup_button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(sd->signup_button, EVAS_HINT_EXPAND, 0.0);
	evas_object_smart_callback_add(sd->signup_button, "clicked", signup_signup_button_clicked_cb, sd);
	elm_object_text_set(sd->signup_button, "Submit");
	elm_object_disabled_set(sd->signup_button, EINA_TRUE);
	elm_box_pack_end(box, sd->signup_button);
	evas_object_show(sd->signup_button);

	evas_object_smart_callback_add(sd->account_entry, "changed", signup_account_entry_changed_cb, sd);
	evas_object_smart_callback_add(sd->password_entry, "changed", signup_password_entry_changed_cb, sd);

	return box;
}

void
signup_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *layout, *box;
	static signup_data_s sd = {0,};
	sd.nf = ad->nf;

	scroller = elm_scroller_add(sd.nf);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, 0.0);
	evas_object_event_callback_add(scroller, EVAS_CALLBACK_DEL, signup_scroller_del_cb, &sd);

	layout = elm_layout_add(scroller);
	elm_layout_file_set(layout, APP_VIEW_EDJ, "signup_layout");
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, 0.0);


	box = create_input_field(layout, &sd);
	elm_object_part_content_set(layout, "elm.swallow.content", box);

	box = create_button_field(layout, &sd);
	elm_object_part_content_set(layout, "elm.swallow.buttons", box);

	elm_object_content_set(scroller, layout);

	elm_naviframe_item_push(sd.nf, "Sign Up", NULL, NULL, scroller, NULL);
}
