#include "tichat.h"
#include <sys/stat.h>
#include <arpa/inet.h>
#include <netdb.h>
#include <net/if.h>

int finalindex;
typedef struct _text_item {
	char text[100];
} text_item;


char *nottok;


static void
bubble_button_mouse_down_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	Evas_Object *bg = (Evas_Object *)data;
	int r, g, b, a;

	if (!bg)
		return;

	evas_object_color_get(bg, &r, &g, &b, &a);
	r *= 0.8;
	g *= 0.8;
	b *= 0.8;

	evas_object_color_set(bg, r, g, b, a);
}

static void
bubble_button_mouse_up_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	Evas_Object *bg = (Evas_Object *)data;
	int r, g, b, a;

	if (!bg)
		return;

	evas_object_color_get(bg, &r, &g, &b, &a);
	r *= 1.25;
	g *= 1.25;
	b *= 1.25;

	evas_object_color_set(bg, r, g, b, a);
}


static Evas_Object *
create_bubble_table(Evas_Object *parent, Message_Bubble_Style style, const char *main_text, const char *sub_text)
{
	Evas_Object *bubble_table, *button, *bg, *main_label, *sub_label;
	Eina_Strbuf *strbuf = NULL;
	char *buf = NULL;

	bubble_table = elm_table_add(parent);
	evas_object_size_hint_weight_set(bubble_table, EVAS_HINT_EXPAND, 0.0);
	elm_table_padding_set(bubble_table, ELM_SCALE_SIZE(5), ELM_SCALE_SIZE(5));
	evas_object_show(bubble_table);

	button = elm_button_add(bubble_table);
	elm_object_style_set(button, "transparent");
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

	bg = evas_object_rectangle_add(evas_object_evas_get(button));
	elm_object_content_set(button, bg);
	evas_object_event_callback_add(button, EVAS_CALLBACK_MOUSE_DOWN, bubble_button_mouse_down_cb, bg);
	evas_object_event_callback_add(button, EVAS_CALLBACK_MOUSE_UP, bubble_button_mouse_up_cb, bg);
	evas_object_show(button);

	/* Prepare string buffer for making mark up text */
	strbuf = eina_strbuf_new();
	/* Make a mark up text to string buffer for main label widget */
	eina_strbuf_append_printf(strbuf, BUBBLE_MAIN_TEXT_STYLE, main_text);
	/* Get the string from string buffer. String buffer will be empty. */
	buf = eina_strbuf_string_steal(strbuf);

	main_label = elm_label_add(bubble_table);
	elm_object_text_set(main_label, buf);
	elm_label_wrap_width_set(main_label, ELM_SCALE_SIZE(BUBBLE_TEXT_WIDTH));
	elm_label_line_wrap_set(main_label, ELM_WRAP_MIXED);
	evas_object_size_hint_weight_set(main_label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(main_label, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_repeat_events_set(main_label, EINA_TRUE);
	evas_object_show(main_label);

	/* Make a mark up text to string buffer for sub label widget */
	eina_strbuf_append_printf(strbuf, BUBBLE_SUB_TEXT_STYLE, sub_text);
	/* Get the string from string buffer. String buffer will be empty. */
	buf = eina_strbuf_string_steal(strbuf);
	/* Free string buffer */
	eina_strbuf_free(strbuf);

	sub_label = elm_label_add(bubble_table);
	elm_object_text_set(sub_label, buf);
	evas_object_size_hint_weight_set(sub_label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_repeat_events_set(sub_label, EINA_TRUE);
	evas_object_show(sub_label);

	switch (style) {
		case MESSAGE_BUBBLE_SENT:
			evas_object_size_hint_align_set(bubble_table, 1.0, 0.0);
			evas_object_size_hint_align_set(sub_label, 1.0, EVAS_HINT_FILL);
			evas_object_color_set(bg, 200, 170, 100, 255);
			elm_table_pack(bubble_table, button, 0, 0, 1, 2);
			elm_table_pack(bubble_table, main_label, 0, 0, 1, 1);
			elm_table_pack(bubble_table, sub_label, 0, 1, 1, 1);
			break;
		case MESSAGE_BUBBLE_RECEIVE:
			evas_object_size_hint_align_set(bubble_table, 0.0, 0.0);
			evas_object_size_hint_align_set(sub_label, 0.0, EVAS_HINT_FILL);
			evas_object_color_set(bg, 100, 170, 200, 255);
			elm_table_pack(bubble_table, button, 0, 0, 1, 2);
			elm_table_pack(bubble_table, main_label, 0, 0, 1, 1);
			elm_table_pack(bubble_table, sub_label, 0, 1, 1, 1);
			break;
		case MESSAGE_BUBBLE_NONE:
		case MESSAGE_BUBBLE_LAST:
		default:
			break;
	}

	return bubble_table;
}


static char *
get_current_time()
{
	Eina_Strbuf *strbuf = eina_strbuf_new();
	time_t local_time = time(NULL);
	char buf[200] = {0};
	char *ret = NULL;
	struct tm *time_info = localtime(&local_time);

	strftime(buf, 200, "%l:%M", time_info);
	eina_strbuf_append_printf(strbuf, "%s %s", buf, (time_info->tm_hour >= 12) ? "PM":"AM");
	ret = eina_strbuf_string_steal(strbuf);
	eina_strbuf_free(strbuf);

	return ret;
}

static void
load_messages(room_data_s *cd,char *id, char *message)
{

	Evas_Object *bubble_table;
	char subtext[100];
	strcpy(subtext,id);
	strcat(subtext,", ");
	strcat(subtext,get_current_time());
	bubble_table = create_bubble_table(cd->bubble_box, MESSAGE_BUBBLE_RECEIVE,
				message,
				subtext);
	evas_object_show(bubble_table);
	elm_box_pack_end(cd->bubble_box, bubble_table);
	cd->num_of_bubbles++;

}



static void
bubble_box_resize_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	Evas_Coord w, h;
	room_data_s *cd = data;

	elm_scroller_child_size_get(cd->bubble_scroller, &w, &h);
	elm_scroller_region_show(cd->bubble_scroller, 0, h, 0, 0);
	evas_object_event_callback_del(cd->bubble_box, EVAS_CALLBACK_RESIZE, bubble_box_resize_cb);
}







static void
send_message(room_data_s *cd)
{
	Evas_Object *bubble_table;
	const char *main_text = NULL;

	if (!cd->input_field_entry)
		return;
	main_text = elm_entry_entry_get(cd->input_field_entry);

	if (!main_text || (strlen(main_text) == 0))
		return;

	int count = 0;
	char writebuf[200];
	strcpy(writebuf,"chat/");
	strcat(writebuf,main_text);
	if ((count = write(socket_fd, writebuf, strlen(writebuf))) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "write() error: %s\n", strerror(errno));
	}
	dlog_print(DLOG_INFO, LOG_TAG, "Sent count: %d, msg:\n", count);


	bubble_table = create_bubble_table(cd->bubble_box, MESSAGE_BUBBLE_SENT,
			elm_entry_entry_get(cd->input_field_entry),
			get_current_time());
	evas_object_show(bubble_table);
	elm_box_pack_end(cd->bubble_box, bubble_table);
	cd->num_of_bubbles++;
	cd->total_messages++;
	elm_entry_entry_set(cd->input_field_entry, "");

	evas_object_event_callback_add(cd->bubble_box, EVAS_CALLBACK_RESIZE, bubble_box_resize_cb, cd);
}
static void
send_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	send_message(data);
}


static void
entry_focused_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *bg = (Evas_Object *)data;
	evas_object_color_set(bg, 110, 210, 210, 255);
}

static void
entry_unfocused_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *bg = (Evas_Object *)data;
	evas_object_color_set(bg, 0, 0, 0, 0);
}

static Evas_Object *
create_input_field_table(room_data_s *cd)
{
	Evas_Object *table, *button, *bg;

	table = elm_table_add(cd->main_box);
	elm_table_homogeneous_set(table, EINA_TRUE);
	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, 0.0);
	evas_object_size_hint_align_set(table, EVAS_HINT_FILL, 1.0);
	evas_object_show(table);

	button = elm_button_add(table);
	elm_object_style_set(button, "transparent");
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

	bg = evas_object_rectangle_add(evas_object_evas_get(button));
	elm_object_content_set(button, bg);
	evas_object_color_set(bg, 120, 220, 220, 255);
	evas_object_show(button);
	elm_table_pack(table, button, 0, 0, 3, 2);

	button = elm_button_add(table);
	elm_object_style_set(button, "transparent");
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

	bg = evas_object_rectangle_add(evas_object_evas_get(button));
	elm_object_content_set(button, bg);
	evas_object_color_set(bg, 0, 0, 0, 0);
	evas_object_show(button);
	elm_table_pack(table, button, 0, 0, 2, 2);

	cd->input_field_entry = elm_entry_add(table);
	elm_object_part_text_set(cd->input_field_entry, "elm.guide", "Enter Message");
	evas_object_size_hint_weight_set(cd->input_field_entry, EVAS_HINT_EXPAND, 0.0);
	evas_object_size_hint_align_set(cd->input_field_entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_smart_callback_add(cd->input_field_entry, "focused", entry_focused_cb, bg);
	evas_object_smart_callback_add(cd->input_field_entry, "unfocused", entry_unfocused_cb, bg);
	evas_object_show(cd->input_field_entry);
	elm_table_pack(table, cd->input_field_entry, 0, 0, 2, 2);

	button = elm_button_add(table);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(button, "SEND");
	evas_object_smart_callback_add(button, "clicked", send_button_clicked_cb, cd);
	evas_object_show(button);
	elm_table_pack(table, button, 2, 1, 1, 1);

	return table;
}

static Evas_Object *
create_main_view(room_data_s *cd)
{
	Evas_Object *main_scroller, *input_field_table;

	main_scroller = elm_scroller_add(cd->nf);
	elm_scroller_bounce_set(main_scroller, EINA_FALSE, EINA_TRUE);
	evas_object_size_hint_weight_set(main_scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(main_scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(main_scroller);

	cd->main_box = elm_box_add(main_scroller);
	elm_box_align_set(cd->main_box, 0, 0);
	evas_object_size_hint_weight_set(cd->main_box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(cd->main_box);

	cd->bubble_scroller = elm_scroller_add(cd->main_box);
	elm_scroller_bounce_set(cd->bubble_scroller, EINA_FALSE, EINA_TRUE);
	evas_object_size_hint_weight_set(cd->bubble_scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(cd->bubble_scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);

	cd->bubble_box = elm_box_add(cd->bubble_scroller);
	elm_box_align_set(cd->bubble_box, 0, 0);
	evas_object_size_hint_weight_set(cd->bubble_box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(cd->bubble_box);
	elm_box_padding_set(cd->bubble_box, ELM_SCALE_SIZE(10), ELM_SCALE_SIZE(15));

	elm_object_content_set(cd->bubble_scroller, cd->bubble_box);
	evas_object_show(cd->bubble_scroller);
	elm_box_pack_end(cd->main_box, cd->bubble_scroller);

	input_field_table = create_input_field_table(cd);
	evas_object_show(input_field_table);
	elm_box_pack_end(cd->main_box, input_field_table);
	elm_object_content_set(main_scroller, cd->main_box);


	return main_scroller;
}

static void
prv_btn_clicked_cb(void *data,Evas_Object *obj, void *event_info)
{
	room_data_s *cd = data;
	if ( write(socket_fd, "leaveroom/", 12) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "write() error to close : %s\n", strerror(errno));
		close(socket_fd);
	}
	dlog_print(DLOG_INFO, LOG_TAG, "room leaved");
	elm_naviframe_item_pop(cd->nf);
}



int enter_handle(room_data_s *data){

	room_data_s *cd = data;
	//wirte and do protocol
	int count = 0;
	char writebuf[200];
	strcpy(writebuf,"enterroom/");
	strcat(writebuf,cd->selected_roomname_text);
	if ((count = write(socket_fd, writebuf, strlen(writebuf))) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "write() error: %s\n", strerror(errno));
		close(socket_fd);
	}
	dlog_print(DLOG_INFO, LOG_TAG, "Sent count: %d, msg:\n", count);


	return 1;
}


void
enter_room(void *data ,const char * roomname){

	room_data_s *cd = data;

	cd->selected_roomname_text = roomname;
	enter_handle(cd);
	Evas_Object *main_scroller, *bg, *prevbtn;
	Elm_Object_Item *nf_it;
	ecore_thread_max_set(2);
	/* Indicator BG */
	bg = elm_bg_add(cd->nf);
	elm_object_style_set(bg, "indicator/headerbg");
	elm_object_part_content_set(cd->nf, "elm.swallow.indicator_bg", bg);
	evas_object_show(bg);

	/* Main view */
	main_scroller = create_main_view(cd);
	nf_it = elm_naviframe_item_push(cd->nf,cd->selected_roomname_text, NULL, NULL, main_scroller, NULL);
	prevbtn = elm_button_add(cd->nf);
	elm_object_style_set(prevbtn,"naviframe/title_left");
	elm_object_item_part_content_set(nf_it,"title_left_btn",prevbtn);
	elm_object_text_set(prevbtn,"Prev");
	evas_object_smart_callback_add(prevbtn,"clicked",prv_btn_clicked_cb, cd);


}


static char*
gl_text_get_cb(void *data, Evas_Object *obj, const char *part)
{
	text_item *text_data = data;
	return strdup(text_data->text);
}

static void
gl_del_cb(void *data, Evas_Object *obj)
{
	text_item *text_data = data;
	free(text_data);
}

Evas_Object*
create_roomlist(Evas_Object* parent)
{
	/* add an genlist to the layout */
	Evas_Object* genlist;
	genlist = elm_genlist_add(parent);

	return genlist;
}

Elm_Genlist_Item_Class*
create_item_class()
{
	/* set genlist item style and callbacks */
	Elm_Genlist_Item_Class* itc;
	itc = elm_genlist_item_class_new();
	itc->item_style = "default";
	itc->func.content_get = NULL;
	itc->func.text_get = gl_text_get_cb;
	itc->func.del = gl_del_cb;
	return itc;
}

static void
create_popup_button_cancle_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup = data;
	evas_object_del(popup);
}

static Evas_Object *
create_room_failed_popup(room_data_s *sd,char * res)
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
	evas_object_smart_callback_add(buttonok, "clicked", create_popup_button_cancle_clicked_cb, popup);


	eina_strbuf_free(buf);\

	return popup;
}

static void
room_list_clicked_cb(void *data, Evas_Object *obj, void *event_info){
	room_data_s *rd = data;
	Elm_Object_Item *it;

	it = elm_genlist_selected_item_get(rd->roomlist);
	enter_room(rd, elm_object_item_part_text_get(it,"elm.text"));
}

static void
refresh_button_clicked_cb(void *data, Evas_Object *obj, void *event_info){
	room_data_s *rd = data;

	elm_genlist_clear (rd->roomlist);
	//wirte and do protocol
	int count = 0;
	char writebuf[256];

	char buf[257];
	memset(buf, 0x00, 257);
	strcpy(writebuf,"getroomlist/");
	if ((count = write(socket_fd, writebuf, strlen(writebuf))) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "write() error: %s\n", strerror(errno));
		close(socket_fd);
	}
	dlog_print(DLOG_INFO, LOG_TAG, "socket %d requset sent: %d, msg:%s \n", socket_fd, count,writebuf);

	sleep(1);
	if(nottok!=NULL){
		strcpy(buf,nottok);
		dlog_print(DLOG_INFO, LOG_TAG, "not toked : %s\n", buf);
		char *tok;
		tok=strtok(buf,"$");
		for(;;){
			dlog_print(DLOG_INFO, LOG_TAG, "toked : %s\n", tok);
			text_item *text_data = calloc(sizeof(text_item), 1);
			sprintf(text_data->text, "%s", tok);
			elm_genlist_item_append(rd->roomlist, rd->itc, text_data->text, NULL, ELM_GENLIST_ITEM_NONE, room_list_clicked_cb, rd);
			tok=strtok(NULL,"$");
			if(tok==NULL)break;
		}
	}
}


static void
room_layout_del_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	room_data_s *rd = data;

	rd->nf = NULL;
	rd->roomlist = NULL;
	rd->roomname_entry = NULL;
	rd->create_button = NULL;
	if(rd->roomname_text) free(rd->roomname_text);
	rd->roomname_text = NULL;

}


static void
create_popup_button_create_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	room_data_s *rd = data;
	if (rd->roomname_text) free(rd->roomname_text);
	rd->roomname_text = NULL;
	rd->roomname_text = elm_entry_markup_to_utf8(elm_entry_entry_get(rd->roomname_entry));
	dlog_print(DLOG_INFO, LOG_TAG, "title : %s id : %s", rd->roomname_text,rd->id);


	int count = 0;
	char writebuf[256];
	strcpy(writebuf,"addroomlist/");
	strcat(writebuf,rd->roomname_text);
	if ((count = write(socket_fd, writebuf, strlen(writebuf))) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "write() error: %s\n", strerror(errno));
		close(socket_fd);
	}
	dlog_print(DLOG_INFO, LOG_TAG, "Sent count: %d, msg:\n", count);
	usleep(100);
	enter_room(rd,rd->roomname_text);
	evas_object_del(rd->createpopup);

}


static void
room_roomname_entry_activated_cb(void *data, Evas_Object *obj, void *event_info)
{
	room_data_s *rd = data;

	elm_object_focus_set(rd->roomname_entry, EINA_TRUE);
}


static void
roomname_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	room_data_s *rd = data;

	if (!elm_entry_is_empty(rd->roomname_entry))
		elm_object_disabled_set(rd->create_popup_button, EINA_FALSE);
	else
		elm_object_disabled_set(rd->create_popup_button, EINA_TRUE);
}

static Evas_Object *
create_create_popup(room_data_s *rd)
{
	Evas_Object *popup,*buttoncancle;
	Eina_Strbuf *buf = eina_strbuf_new();
	popup = elm_popup_add(rd->nf);
	eina_strbuf_append_printf(buf, "<align=left><b>방제목</b><br/></align>");
	elm_object_text_set(popup, eina_strbuf_string_steal(buf));
	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);

	elm_object_part_text_set(popup, "title,text", "Create Room");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	rd->roomname_entry = elm_entry_add(popup);
	elm_object_style_set(rd->roomname_entry, "popup");
	elm_entry_single_line_set(rd->roomname_entry, EINA_TRUE);
	elm_object_part_content_set(popup, NULL, rd->roomname_entry);
	elm_object_part_text_set(rd->roomname_entry, "elm.guide", "방제목");
	elm_entry_input_panel_layout_set(rd->roomname_entry, ELM_INPUT_PANEL_LAYOUT_NORMAL);
	elm_entry_input_panel_return_key_type_set(rd->roomname_entry, ELM_INPUT_PANEL_RETURN_KEY_TYPE_NEXT);
	evas_object_smart_callback_add(rd->roomname_entry, "activated", room_roomname_entry_activated_cb, rd);

	rd->create_popup_button = elm_button_add(popup);
	elm_object_style_set(rd->create_popup_button, "popup");
	elm_object_text_set(rd->create_popup_button, "Create");
	elm_object_part_content_set(popup, "button2", rd->create_popup_button);
	evas_object_smart_callback_add(rd->create_popup_button, "clicked", create_popup_button_create_clicked_cb, rd);
	elm_object_disabled_set(rd->create_popup_button, EINA_TRUE);

	buttoncancle = elm_button_add(popup);
	elm_object_style_set(buttoncancle, "popup");
	elm_object_text_set(buttoncancle, "Cancle");
	elm_object_part_content_set(popup, "button1", buttoncancle);
	evas_object_smart_callback_add(buttoncancle, "clicked", create_popup_button_cancle_clicked_cb, popup);

	eina_strbuf_free(buf);

	evas_object_smart_callback_add(rd->roomname_entry, "changed", roomname_entry_changed_cb, rd);

	return popup;
}

static void
create_button_clicked_cb(void *data, Evas_Object *obj, void *event_info){
	room_data_s *rd = data;
	rd->createpopup = create_create_popup(rd);
	evas_object_show(rd->createpopup);
}


static Evas_Object *
create_list_field(Evas_Object *parent, room_data_s *rd)
{
	Evas_Object *box;

	box = elm_box_add(parent);
	elm_box_align_set(box, 0, 0);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(box);

	rd->roomscroller = elm_scroller_add(box);
	elm_scroller_bounce_set(rd->roomscroller, EINA_FALSE, EINA_TRUE);
	evas_object_size_hint_weight_set(rd->roomscroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(rd->roomscroller, EVAS_HINT_FILL, EVAS_HINT_FILL);

	rd->roomlist = create_roomlist(rd->roomscroller);
	evas_object_show(rd->roomscroller);
	elm_object_content_set(rd->roomscroller, rd->roomlist);

	elm_box_pack_end(box, rd->roomscroller);

	return box;
}


static void
get_message(void *data , Ecore_Thread *thread)
{
	dlog_print(DLOG_INFO, LOG_TAG, "thread run");
	room_data_s *rd =data;
	char buf[257];
	int strlen;
	while(1)
	{
		strlen=read(socket_fd,buf,256);
		if(strlen==-1)
			return (void)-1;
		buf[strlen]='\0';
		char *id,*message;
		id=strtok(buf,"/");
		if(!strcmp(id,"roomlist")){
			nottok=strtok(NULL,"");
			dlog_print(DLOG_INFO, LOG_TAG, "roomlist : %s",nottok);
		}
		else{
			message=strtok(NULL,"");
			dlog_print(DLOG_INFO, LOG_TAG, "load message : %s",message);
			load_messages(rd,id,message);
		}

	}
}


int create_connection(room_data_s *data){
	room_data_s *rd = data;

	int error_code;
	error_code = connection_create(&connection);
	if (error_code != CONNECTION_ERROR_NONE)
		dlog_print(DLOG_INFO, LOG_TAG, "Connection Failed!!!!!!!!!!!!");
	connection_type_e net_state;
	error_code = connection_get_type(connection, &net_state);
	if (error_code == CONNECTION_ERROR_NONE) {
		dlog_print(DLOG_INFO, LOG_TAG, "Network connection type : %d", net_state);
	}


	struct sockaddr_in serv_addr;

	bzero((char *)&serv_addr, sizeof(serv_addr));
	serv_addr.sin_family = PF_INET;
	serv_addr.sin_addr.s_addr = inet_addr("172.20.10.7");
	serv_addr.sin_port = htons(4000);

	//open a tcp socket
	if ((socket_fd = socket(PF_INET, SOCK_STREAM, 0)) < 0) {
		return -1;
	}
	dlog_print(DLOG_INFO, LOG_TAG, "socket open success : %d",socket_fd);

	//connect to the server
	if (connect(socket_fd, (struct sockaddr *)&serv_addr, sizeof(serv_addr)) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "can't connect to the server\n");
		return -1;
	}
	dlog_print(DLOG_INFO, LOG_TAG, "socket connect success");


	//wirte and do protocol
	int count = 0;
	char writebuf[256];
	strcpy(writebuf,"login/");
	strcat(writebuf,rd->id);
	if ((count = write(socket_fd, writebuf, strlen(writebuf))) < 0) {
		dlog_print(DLOG_INFO, LOG_TAG, "write() error: %s\n", strerror(errno));
		close(socket_fd);
	}
	dlog_print(DLOG_INFO, LOG_TAG, "Sent count: %d, msg:\n", count);

	rd->read_message = ecore_thread_feedback_run(get_message, NULL, NULL, NULL, rd, EINA_FALSE);

    return 1;

}


static Evas_Object *
create_button_field(Evas_Object *parent, room_data_s *rd)
{
	Evas_Object *box, *button;

	box = elm_box_add(parent);
	elm_box_horizontal_set(box, EINA_TRUE);
	elm_box_padding_set(box, ELM_SCALE_SIZE(5), 0);

	/* refresh Button */
	button = elm_button_add(box);
	evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, 0.0);
	evas_object_smart_callback_add(button, "clicked", refresh_button_clicked_cb, rd);
	elm_object_text_set(button, "refresh");
	elm_box_pack_end(box, button);
	evas_object_show(button);


	/* create Button */
	rd->create_button = elm_button_add(box);
	evas_object_size_hint_align_set(rd->create_button, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(rd->create_button, EVAS_HINT_EXPAND, 0.0);
	evas_object_smart_callback_add(rd->create_button, "clicked", create_button_clicked_cb, rd);
	elm_object_text_set(rd->create_button, "방 생성");
	elm_box_pack_end(box, rd->create_button);
	evas_object_show(rd->create_button);


	return box;
}



void roomlist_cb(void *data, Evas_Object *obj, void *event_info){
	login_data_s *ld = (login_data_s *)data;
	static room_data_s rd = {0,};
	rd.nf = ld->nf;
	rd.id = ld->account_text;
	finalindex = 0;

	if(create_connection(&rd)==-1){
		dlog_print(DLOG_INFO, LOG_TAG, "Connection Failed!!!!!!!!!!!!");
		elm_naviframe_item_pop(rd.nf);
	}
	Evas_Object *main_scroller,*layout,*box;
	main_scroller =  elm_scroller_add(rd.nf);
	evas_object_size_hint_align_set(main_scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(main_scroller, EVAS_HINT_EXPAND, 0.0);
	evas_object_event_callback_add(main_scroller, EVAS_CALLBACK_DEL, room_layout_del_cb, &rd);

	layout = elm_layout_add(main_scroller);
	elm_layout_file_set(layout, APP_VIEW_EDJ, "room_layout");
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	box = create_list_field(layout,&rd);
	elm_object_part_content_set(layout, "elm.swallow.content", box);

	box = create_button_field(layout, &rd);
	elm_object_part_content_set(layout, "elm.swallow.buttons", box);

	rd.itc = create_item_class();
	elm_object_content_set(main_scroller, layout);

	elm_naviframe_item_push(rd.nf, "Room List", NULL, NULL, main_scroller, NULL);
	refresh_button_clicked_cb(&rd,NULL,NULL);
}
