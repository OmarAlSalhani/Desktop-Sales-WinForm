using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClientApp.classes;
using ClientApp.settings_files;
using DevExpress.XtraGrid;

namespace ClientApp.storages_forms
{
    public partial class ar_storages_form : DevExpress.XtraEditors.XtraForm
    {
        public ar_storages_form()
        {
            InitializeComponent();
            my_grid_view_class.set_font_and_hover_effect(quantites_grid_view);
            my_grid_view_class.show_empty_message2(quantites_grid_view);
        }

        DataTable storage_table;
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            storage_table = connection_class.select("select id as 'رقم الخزنة', storage_name as 'الخزنة',storage_value as 'الرصيد' from storage_table");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            my_grid_view_class.set_datasource(quantites_grid_control, quantites_grid_view, storage_table);
            new_btn.PerformClick();
            my_grid_view_class.set_summary(quantites_grid_view, "الرصيد");
        }
        bool check_if_every_thing_ok()
        {

            if (texts_class.is_null(storage_name_textbox.Text.Trim()))
            {
                OmarNotifications.Alert.ShowInformation("الرجاء كتابة إسم الخزنة");
                return false;
            }
            if (texts_class.is_null(storage_value_textbox.Text.Trim()))
            {
                storage_value_textbox.Text = 0.ToString();
                return false;
            }
            if (!validate_class.is_text_less_then_300_char(storage_name_textbox.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (check_if_every_thing_ok())
            {
                try
                {
                    connection_class.command($"insert into storage_table(id,storage_name,storage_value) values({Convert.ToInt32(id_tb.Text)},N'{storage_name_textbox.Text.Trim()}',{Math.Round(Convert.ToDouble(storage_value_textbox.Text), 2)})");
                    storage_class.storage_log_add($"إضافة رصيد أفتتاحي إلى الخزنة رقم : {id_tb.Text}", Math.Round(Convert.ToDouble(storage_value_textbox.Text), 2), Convert.ToInt32(id_tb.Text));
                    logs_class.log_add($"إضافة الخزنة {storage_name_textbox.Text.Trim()} برصيد إفتتاحي {storage_value_textbox.Text}", 0, "الخزنات");
                    classes.notifications_class.success_message();
                    run_worker_class.run(backgroundWorker1);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("unique"))
                    {
                        OmarNotifications.Alert.ShowInformation("أسم الخزنة موجود مسبقاً");
                    }
                    else
                    {
                        classes.notifications_class.my_messageBox(ex.Message);
                    }
                }
            }
        }

        private void ar_storages_form_Load(object sender, EventArgs e)
        {
            run_worker_class.run(backgroundWorker1);
        }
        string old_name;
        void navigate_btn(string query)
        {
            DataTable table = connection_class.select(query);
            if (table.Rows.Count == 0)
            {
                DataTable table1 = connection_class.select("select * from storage_table");
                if (table1.Rows.Count == 0)
                {
                    OmarNotifications.Alert.ShowInformation("لا يوجد بيانات");
                    return;
                }
                else
                {
                    if (is_next_clicked)
                        first_btn.PerformClick();
                    else
                        last_btn.PerformClick();
                }
            }

            else
            {
                int id = Convert.ToInt32(table.Rows[0]["id"]);
                id_tb.Text = id.ToString();
                storage_name_textbox.Text = table.Rows[0]["storage_name"].ToString();
                storage_value_textbox.Text = table.Rows[0]["storage_value"].ToString();
                old_name = table.Rows[0]["storage_name"].ToString();
            }
            delete_btn.Enabled = true;
            update_btn.Enabled = true;
            save_btn.Enabled = false;
            storage_value_textbox.Enabled = false;

        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            quantites_grid_view.ClearSelection();

            update_btn.Enabled = false;
            delete_btn.Enabled = false;
            save_btn.Enabled = true;
            storage_value_textbox.Enabled = true;
            clear();
        }
        void clear()
        {
            storage_name_textbox.Text =
                storage_value_textbox.Text =
                string.Empty;
            id_tb.Text = get_id().ToString();

        }
        int get_id()
        {
            DataTable table = connection_class.select("select isnull(max(id)+1,1) from storage_table");
            return Convert.ToInt32(table.Rows[0][0]);
        }
        int get_lbl_id()
        {
            string id = id_tb.Text;
            return Convert.ToInt32(id);
        }
        void update_storages_in_user_table(string old_name, string new_name)
        {
            connection_class.command($"update users_table set storage_name=N'{new_name}' where storage_name=N'{old_name}'");
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (check_if_every_thing_ok())
            {
                try
                {
                    if (quantites_grid_view.SelectedRowsCount > 1)
                    {
                        OmarNotifications.Alert.ShowInformation("يجب تحديد خزنة واحدة فقط");
                        return;
                    }
                    check_if_every_thing_ok();
                    DialogResult dr = classes.notifications_class.my_messageBox("هل تريد تعديل الخزنة ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        connection_class.command($"update storage_table set storage_name=N'{storage_name_textbox.Text.Trim()}',storage_value={Math.Round(Convert.ToDouble(storage_value_textbox.Text), 2)} where id={get_lbl_id()} ");
                        update_storages_in_user_table(old_name, storage_name_textbox.Text.Trim());
                        classes.notifications_class.success_message();
                        storage_class.storage_log_add($"تعديل الخزنة ذات الرقم {id_tb.Text}", Convert.ToDouble(storage_value_textbox.Text), get_lbl_id());
                        logs_class.log_add($"تعديل الخزنة ذات الرقم {id_tb.Text}", 0, "الخزنات");
                        run_worker_class.run(backgroundWorker1);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("unique"))
                    {
                        OmarNotifications.Alert.ShowInformation("أسم الخزنة موجود مسبقاً");
                        storage_name_textbox.Text = storage_value_textbox.Text = "";
                    }
                    else if (!ex.Message.Contains("format"))
                    {
                        classes.notifications_class.my_messageBox(ex.Message);
                    }
                }
            }
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            navigate_btn("select * from storage_table where id=(select min(id) from storage_table)");

        }
        bool is_next_clicked = false;
        private void next_btn_Click(object sender, EventArgs e)
        {
            navigate_btn(navigation_class.next_navigatoin("storage_table", "id", id_tb.Text));
            is_next_clicked = true;
        }

        private void perv_btn_Click(object sender, EventArgs e)
        {
            navigate_btn(navigation_class.prev_navigation("storage_table", "id", id_tb.Text));
            is_next_clicked = false;
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            navigate_btn("select * from storage_table where id=(select max(id) from storage_table)");

        }

        private void quantites_grid_view_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (quantites_grid_view.RowCount != 0)
            {
                navigate_btn($"select * from storage_table where id={quantites_grid_view.GetFocusedRowCellValue(quantites_grid_view.Columns[0].FieldName).ToString()}");
                delete_btn.Enabled = true;
                update_btn.Enabled = true;
                save_btn.Enabled = false;
            }
            if (quantites_grid_view.SelectedRowsCount == 0)
            {

                new_btn.PerformClick();
            }
        }
        private void print_btn_Click(object sender, EventArgs e)
        {
            if (quantites_grid_view.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            repost_pos.manage_storage_report.print(classes.my_grid_view_class.gridview_to_data_table(quantites_grid_view),null);
        }
        string names = "";
        bool is_storage_bind_with_users(string storage_name)
        {
            DataTable table = connection_class.select($"select username from users_table where storage_name=N'{storage_name}'");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    names += table.Rows[i][0].ToString() + "\n";
                }
                return true;
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (quantites_grid_view.SelectedRowsCount == 0)
            {
                notifications_class.select_data_message();
                return;
            }
            foreach (int i in quantites_grid_view.GetSelectedRows())
            {
                string the_name = quantites_grid_view.GetRowCellValue(i, quantites_grid_view.Columns[1].FieldName).ToString();
                if (!validate_class.is_storage_clean(the_name))
                {
                    return;
                }
            }
            foreach (int i in quantites_grid_view.GetSelectedRows())
            {
                string name = quantites_grid_view.GetRowCellValue(i, quantites_grid_view.Columns[1].FieldName).ToString();
                if (is_storage_bind_with_users(name))
                {
                    notifications_class.my_messageBox($"لا يمكن حذف الخزنة لإنها مرتبطة مع المستخدمين الآتيين :\n{names}");
                    return;
                }
            }
            DialogResult dr = classes.notifications_class.my_messageBox("هل تريد تأكيد حذف الخزنات المحددة ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                foreach (int i in quantites_grid_view.GetSelectedRows())
                {
                    string name = quantites_grid_view.GetRowCellValue(i, quantites_grid_view.Columns[1].FieldName).ToString();
                    int id = Convert.ToInt32(quantites_grid_view.GetRowCellValue(i, quantites_grid_view.Columns[0].FieldName));
                    connection_class.command($"delete from storage_table where id={id}");
                    logs_class.log_add($"حذف الخزنة ذات الرقم {id}", 0, "الخزنات");

                }
                classes.notifications_class.success_message();
                run_worker_class.run(backgroundWorker1);
            }
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
           repost_pos.manage_storage_report.to_pdf(classes.my_grid_view_class.gridview_to_data_table(quantites_grid_view));
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            repost_pos.manage_storage_report.to_excel(classes.my_grid_view_class.gridview_to_data_table(quantites_grid_view));
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
           repost_pos.manage_storage_report.to_word(classes.my_grid_view_class.gridview_to_data_table(quantites_grid_view));
        }

        private void quantites_grid_view_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }
    }
}