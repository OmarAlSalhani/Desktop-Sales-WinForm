using DevExpress.XtraGrid;
using ClientApp.classes;
using ClientApp.settings_files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.customers_forms.en
{
    public partial class en_customers_mdeonee_form : DevExpress.XtraEditors.XtraForm
    {
        public en_customers_mdeonee_form()
        {
            InitializeComponent();
            first_date.DateTime = last_date.DateTime = DateTime.Now;

            my_grid_view_class.set_find_panel_font2(gridView1, gridControl1, false, true);
            my_grid_view_class.set_font_and_hover_effect(gridView1);
            my_grid_view_class.show_empty_message2(gridView1);
        }
        DataTable customer_table, users_table;
        public static string date_time, the_name, the_money, the_fatora_numbers, from_date, to_date;
        private void customer_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            customer_table = connection_class.select("select customer_name as 'Customer' from customers_table");
            users_table = connection_class.select("select username as 'username' from users_table");
        }

        private void customer_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.lookup_edit_class.fill_lookup(customer_table, customer_cb, "Customer");
            classes.lookup_edit_class.fill_lookup(users_table, username_cb, "username");
        }
        DataTable table;

        private void en_customers_mdeonee_form_Load(object sender, EventArgs e)
        {
            DataTable table = connection_class.select("select agl_id as 'ID',fatora_id as 'Invoice id', customer_name as 'Customer',full_money as 'Total',how_pay as 'Paied',how_stay as 'Remaining',convert(nvarchar,sell_date,105) as 'Sell date' from agle_table where 1=2");
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
            if (customer_worker.IsBusy == false)
            {
                customer_worker.RunWorkerAsync();
            }
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            if (gridView1.DataRowCount != 0)
            {
                from_date = first_date.DateTime.ToString("dd-MM-yyyy");
                to_date = last_date.DateTime.ToString("dd-MM-yyyy");
                repost_pos.en_customers_mdeonea_report.to_word(classes.my_grid_view_class.gridview_to_data_table(gridView1));
            }
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            if (gridView1.DataRowCount != 0)
            {
                from_date = first_date.DateTime.ToString("dd-MM-yyyy");
                to_date = last_date.DateTime.ToString("dd-MM-yyyy");
                repost_pos.en_customers_mdeonea_report.to_excel(classes.my_grid_view_class.gridview_to_data_table(gridView1));
            }
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            if (gridView1.DataRowCount != 0)
            {
                from_date = first_date.DateTime.ToString("dd-MM-yyyy");
                to_date = last_date.DateTime.ToString("dd-MM-yyyy");
                repost_pos.en_customers_mdeonea_report.to_pdf(classes.my_grid_view_class.gridview_to_data_table(gridView1));
            }
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
           
            DataTable UserIDTable = connection_class.select($"select user_id from users_table where username=N'{username_cb.Text}'");
            int userID = 0;
            if (UserIDTable.Rows.Count != 0)
            {
                userID = Convert.ToInt32(UserIDTable.Rows[0][0]);
            }
            string f = first_date.DateTime.ToString("dd-MM-yyyy");
            string l = last_date.DateTime.ToString("dd-MM-yyyy");
            if (customer_checkbox.Checked == false && date_checkbox.Checked == false && username_cbx.Checked == false)
            {
                OmarNotifications.Alert.ShowInformation("Select search option");
                return;
            }
            // customer
            if (customer_checkbox.Checked && date_checkbox.Checked == false && username_cbx.Checked == false)
            {
                table = connection_class.select($"select agl_id as 'ID',fatora_id as 'Invoice id',customer_name  as 'Customer',full_money as 'Total',how_pay as 'Paied',how_stay as 'Remaining',convert(nvarchar,sell_date,105) as 'Sell date' from agle_table where customer_name=N'{customer_cb.Text}'");
            }
            // date
            if (date_checkbox.Checked && customer_checkbox.Checked == false && username_cbx.Checked == false)
            {
                table = connection_class.select($"select agl_id as 'ID',fatora_id as 'Invoice id',customer_name  as 'Customer',full_money as 'Total',how_pay as 'Paied',how_stay as 'Remaining',convert(nvarchar,sell_date,105) as 'Sell date'  from agle_table where sell_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            }
            // username
            if (username_cbx.Checked && date_checkbox.Checked == false && customer_checkbox.Checked == false)
            {
                table = connection_class.select($"select agl_id as 'ID',fatora_id as 'Invoice id',customer_name  as 'Customer',full_money as 'Total',how_pay as 'Paied',how_stay as 'Remaining',convert(nvarchar,sell_date,105) as 'Sell date' from agle_table where fatora_id in (select fatora_id from sell_head_table where user_id={userID})");
            }
            // customer and username
            if (customer_checkbox.Checked && date_checkbox.Checked == false && username_cbx.Checked)
            {
                table = connection_class.select($"select agl_id as 'ID',fatora_id as 'Invoice id',customer_name  as 'Customer',full_money as 'Total',how_pay as 'Paied',how_stay as 'Remaining',convert(nvarchar,sell_date,105) as 'Sell date' from agle_table where customer_name=N'{customer_cb.Text}' and fatora_id in (select fatora_id from sell_head_table where user_id={userID})");
            }
            // date and customer
            if (date_checkbox.Checked && customer_checkbox.Checked && username_cbx.Checked == false)
            {
                table = connection_class.select($"select agl_id as 'ID',fatora_id as 'Invoice id',customer_name  as 'Customer',full_money as 'Total',how_pay as 'Paied',how_stay as 'Remaining',convert(nvarchar,sell_date,105) as 'Sell date'  from agle_table where customer_name=N'{customer_cb.Text}' and sell_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            }
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
            my_grid_view_class.set_summary(gridView1, "Paied");
            my_grid_view_class.set_summary(gridView1, "Remaining");
            my_grid_view_class.set_summary(gridView1, "Total");
            if (table.Rows.Count == 0)
            {
                notifications_class.grid_message();
                gridControl1.DataSource = null;
                return;
            }
        }

        private void pay_some_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            if (pay_some_radio.Checked)
            {
                some_tb.Enabled = true;
                some_tb.Text = "0";
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0 && pay_all_radio.Checked)
            {
                pay_all_check_change();
            }
        }

        private void customer_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (customer_checkbox.Checked)
            {
                date_checkbox.Checked = false;
            }
        }

        private void date_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (date_checkbox.Checked)
            {
                customer_checkbox.Checked = false;
            }
        }
        void pay_all_check_change()
        {
            double result = 0;
            if (gridView1.SelectedRowsCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("Select data first");
                all_tb.Text = "0";
                return;
            }
            foreach (int i in gridView1.GetSelectedRows())
            {
                if (gridView1.GetRowCellValue(i, "Remaining") is DBNull)
                {
                    continue;
                }
                result += Convert.ToDouble(gridView1.GetRowCellValue(i, "Remaining"));
            }
            all_tb.Text = result.ToString();
            if (pay_all_radio.Checked)
            {
                some_tb.Enabled = false;
                some_tb.Text = "0";
            }
        }
        private void pay_all_radio_CheckedChanged(object sender, EventArgs e)
        {
            pay_all_check_change();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("Show report first");
                return;
            }
            if (!validate_class.is_storage_bound_to_this_user())
            {
                return;
            }
            if (gridView1.SelectedRowsCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("Select data first");
                return;
            }
            // if we didn`t select any data
            if (gridView1.RowCount != 0)
            {
                if (pay_all_radio.Checked == false && pay_some_radio.Checked == false)
                {
                    OmarNotifications.Alert.ShowInformation("Select pay method");
                    return;
                }
                int agl_id = 0;
                int fatora_id = 0;
                string customer_name = string.Empty;
                string the_date = classes.const_variables_class.now_date;
                int userID = classes.const_variables_class.userID;
                double value = 0;
                double full_value = 0;
                // تسديد كامل المستحق
                if (pay_all_radio.Checked)
                {
                    DialogResult dr = notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (int i in gridView1.GetSelectedRows())
                        {
                            value = Convert.ToDouble(gridView1.GetRowCellValue(i, gridView1.Columns[5]));
                            agl_id = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0]));
                            fatora_id = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[1]));
                            customer_name = gridView1.GetRowCellValue(i, gridView1.Columns[2]).ToString();

                            the_fatora_numbers += agl_id.ToString() + ",";
                            full_value += value;
                            connection_class.command($"update agle_table set how_stay=0,ok=1 where agl_id={agl_id}");
                            connection_class.command($"insert into customers_paied_money_table values ({fatora_id},{agl_id},N'{customer_name}',{value},N'{the_date}',N'{userID}')");
                            classes.add_kshf_class.customer_kshf(customer_name, $"customer pay money with id ( {agl_id} )", value * -1);
                            classes.aol_moda_class.update_customer_aol_moda(customer_name, value * -1);
                            connection_class.command("delete from agle_table where how_stay=0");
                            logs_class.log_add($"customer pay money for invoice {fatora_id}", 0, "Customers");
                            storage_class.storage_log_add($"customer {customer_name} pay money with id {agl_id}", value, settings_files.main_settings.Default.storage_id);
                        }
                        storage_class.storage_value_increase(full_value);
                        DialogResult dr2 = classes.notifications_class.my_messageBox("Saved Successfully\nDo you want to print ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr2 == DialogResult.Yes)
                        {
                            if (the_fatora_numbers.EndsWith(","))
                            {
                                the_fatora_numbers = the_fatora_numbers.Remove(the_fatora_numbers.Length - 1, 1);
                            }
                            the_name = customer_name;
                            date_time = DateTime.Now.ToString("dd-MM-yyyy") + " | " + DateTime.Now.ToString("HH:mm");
                            the_money = full_value.ToString();
                            repost_pos.snd_kbd_report.print(null, null);
                            the_fatora_numbers = the_name = "";
                            full_value = 0;
                        }
                        show_report_btn.PerformClick();

                    }
                }
                else
                {
                    if (gridView1.SelectedRowsCount == 0)
                    {
                        notifications_class.select_data_message();
                        return;
                    }
                    if (ClientApp.classes.texts_class.is_null(some_tb.Text))
                    {
                        OmarNotifications.Alert.ShowInformation("Please enter amount");
                        return;
                    }
                    if (Convert.ToDouble(some_tb.Text) <= 0)
                    {
                        OmarNotifications.Alert.ShowInformation("Value cannot be zero or less");
                        return;
                    }
                    value = Convert.ToDouble(some_tb.Text);
                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        agl_id = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0]));
                        double how_stay = Convert.ToDouble(gridView1.GetRowCellValue(i, gridView1.Columns["Remaining"]));
                        if (value > how_stay)
                        {
                            OmarNotifications.Alert.ShowError($"Remaining for {agl_id} is less than entered amount");
                            return;
                        }
                    }
                    DialogResult dr = notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (int n in gridView1.GetSelectedRows())
                        {
                            fatora_id = Convert.ToInt32(gridView1.GetRowCellValue(n, gridView1.Columns[1]));
                            agl_id = Convert.ToInt32(gridView1.GetRowCellValue(n, gridView1.Columns[0]));
                            customer_name = gridView1.GetRowCellValue(n, gridView1.Columns[2]).ToString();
                            
                            the_fatora_numbers += agl_id.ToString() + ",";
                            connection_class.command($"update agle_table set how_stay=how_stay-{value} where agl_id={agl_id}");
                            connection_class.command($"update agle_table set how_pay=full_money-how_stay where agl_id={agl_id}");
                            connection_class.command($"insert into customers_paied_money_table values ({fatora_id},{agl_id},N'{customer_name}',{value},N'{the_date}',N'{userID}')");
                            connection_class.command("delete from agle_table where how_stay=0");
                            classes.add_kshf_class.customer_kshf(customer_name, $"قبض مستحقات برقم ( {agl_id} )", value * -1);
                            classes.aol_moda_class.update_customer_aol_moda(customer_name, value * -1);
                            logs_class.log_add($"قبض مديونية من العملاء للفاتورة ذات الرقم {fatora_id}", 0, "العملاء");
                            storage_class.storage_log_add($"قبض مديونية من العميل {customer_name} برقم {agl_id}", value, settings_files.main_settings.Default.storage_id);
                            storage_class.storage_value_increase(value);
                        }
                        DialogResult dr2 = classes.notifications_class.my_messageBox("تم قبض المديونيات بنجاح\nهل تريد طباعة سند القبض ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr2 == DialogResult.Yes)
                        {
                            if (the_fatora_numbers.EndsWith(","))
                            {
                                the_fatora_numbers = the_fatora_numbers.Remove(the_fatora_numbers.Length - 1, 1);
                            }
                            the_name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                            date_time = DateTime.Now.ToString("dd-MM-yyyy") + " | " + DateTime.Now.ToString("HH:mm tt");
                            the_money = value.ToString();
                            repost_pos.snd_kbd_report.print(null, null);
                            the_money = the_fatora_numbers = "";
                            value = 0;
                        }
                    }
                    show_report_btn.PerformClick();
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            if (gridView1.DataRowCount != 0)
            {
                from_date = first_date.DateTime.ToString("dd-MM-yyyy");
                to_date = last_date.DateTime.ToString("dd-MM-yyyy");
                repost_pos.en_customers_mdeonea_report.print(classes.my_grid_view_class.gridview_to_data_table(gridView1), null);
            }
        }
    }
}
