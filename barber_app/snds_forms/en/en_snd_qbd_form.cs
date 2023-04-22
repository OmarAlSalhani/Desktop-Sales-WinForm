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
using ClientApp.settings_files;
using ClientApp.classes;

namespace ClientApp.n_snds_forms.en
{
    public partial class en_snd_qbd_form : DevExpress.XtraEditors.XtraForm
    {
        public en_snd_qbd_form()
        {
            InitializeComponent();
            snd_date_dtp.DateTime = DateTime.Now;
        }
        public static string theName, theNotes, theDate, theId, theValue;
        void clear_form()
        {
            value_textbox.Text =
                notes_textbox.Text =
                string.Empty;
            save_btn.Enabled = true;
            update_btn.Enabled = delete_btn.Enabled = false;

        }
        public static string payMethod = "";
        void print()
        {
            DataTable table = connection_class.select($@"select [id]
      ,[reason]
      ,[value]
      ,convert(nvarchar,[the_date],105) as 'the_date'
      ,[username]
      ,[notes]
      ,[added_date]
      ,[pay_method]
  FROM [client_database].[dbo].[snd_kbd_table] where id={get_id_from_lbl()}");
            theName = table.Rows[0]["reason"].ToString();
            theNotes = table.Rows[0]["notes"].ToString();
            theDate = table.Rows[0]["the_date"].ToString();
            theId = get_id_from_lbl().ToString();
            theValue = table.Rows[0]["value"].ToString();
            payMethod = table.Rows[0]["pay_method"].ToString();
            repost_pos.en_snd_kbd_report2.print();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double value = ClientApp.classes.texts_class.is_number(value_textbox.Text) ? Convert.ToDouble(value_textbox.Text) : 0;
                if (value <= 0)
                {
                    OmarNotifications.Alert.ShowInformation("Value cannot be zero or less");
                    return;
                }
                DialogResult dr = notifications_class.my_messageBoxRightYesNo("Are you sure ?");
                if (dr == DialogResult.Yes)
                {
                    add_snd();
                    clear_form();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    OmarNotifications.Alert.ShowInformation("Enter New button");
                    return;
                }
                else
                {
                    OmarNotifications.Alert.ShowInformation(ex.Message);
                }
            }
        }

        DataTable table;
        private void fill_cb_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            table = connection_class.select("select customer_name as 'Customer' from customers_table");
        }
        void navigate_btn(string query)
        {
            DataTable table = connection_class.select(query);
            if (table.Rows.Count == 0)
            {
                DataTable table1 = connection_class.select("select * from snd_kbd_table");
                if (table1.Rows.Count == 0)
                {
                    OmarNotifications.Alert.ShowInformation("No Data!");
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
                customer_name_cb.Text = table.Rows[0]["customer_name"].ToString();
                value_textbox.Text = table.Rows[0]["value"].ToString();
                notes_textbox.Text = table.Rows[0]["notes"].ToString();
                pay_type_cb.Text = table.Rows[0]["pay_method"].ToString();
                snd_date_dtp.DateTime = Convert.ToDateTime(table.Rows[0]["the_date"].ToString());
                delete_btn.Enabled = true;
                update_btn.Enabled = true;
                save_btn.Enabled = false;

            }
        }
        void openForm(XtraForm form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.IconOptions.ShowIcon = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Text = "";
            form.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DevExpress);
            form.ShowDialog();

        }
        private void base_unit_cb_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                customers_forms.en.en_customers_form form = new customers_forms.en.en_customers_form();
                openForm(form);
                if (fill_cb_worker.IsBusy == false)
                {
                    fill_cb_worker.RunWorkerAsync();
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            double value = ClientApp.classes.texts_class.is_number(value_textbox.Text) ? Convert.ToDouble(value_textbox.Text) : 0;
            if (value <= 0)
            {
                OmarNotifications.Alert.ShowInformation("Value cannot be zero or less");
                return;
            }
            DialogResult dr = notifications_class.my_messageBoxRightYesNo("are you sure ?");
            if (dr == DialogResult.Yes)
            {
                DataTable old_data_table = connection_class.select($"select * from snd_kbd_table where id={get_id_from_lbl()}");
                value = Convert.ToDouble(old_data_table.Rows[0]["value"]);
                string name = customer_name_cb.Text.Trim();
                string pay_method = pay_type_cb.Text.Trim();
                double new_value = Convert.ToDouble(value_textbox.Text);
                string the_date = snd_date_dtp.DateTime.ToString("dd-MM-yyyy");
                string username = main_settings.Default.username;
                string notes = notes_textbox.Text.Trim();
                string added_date = classes.const_variables_class.now_date;
                connection_class.command($"delete from snd_kbd_table where id={get_id_from_lbl()}");
                logs_class.log_add($"Edit cash bond with id {get_id_from_lbl()}", 0, "Bonds");
                connection_class.command($"insert into snd_kbd_table values ({get_id_from_lbl()},N'{name}',{new_value},N'{the_date}',N'{username}',N'{notes}',N'{added_date}',N'{pay_method}')");
                classes.storage_class.storage_value_increase(new_value);
                classes.storage_class.storage_value_decrease(value);
                classes.storage_class.storage_log_add($"Edit cash bond with id [ {get_id_from_lbl()} ]", new_value - value, settings_files.main_settings.Default.storage_id);
                new_btn.PerformClick();
                classes.notifications_class.success_message();
            }

        }
        private void delete_btn_Click(object sender, EventArgs e)
        {

            DialogResult dr = classes.notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                connection_class.command($"delete from snd_kbd_table where id={get_id_from_lbl()}");
                double value = Convert.ToDouble(value_textbox.Text);
                classes.storage_class.storage_value_decrease(value);
                logs_class.log_add($"Delete cash bond with id {get_id_from_lbl()}", 0, "Bonds");
                classes.storage_class.storage_log_add($"Delete cash bond with id [ {get_id_from_lbl()} ]", value * -1, settings_files.main_settings.Default.storage_id);
                new_btn.PerformClick();
                classes.notifications_class.success_message();
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            clear_form();
            get_snd_number();
        }
        bool is_next_clicked = false;
        private void first_btn_Click(object sender, EventArgs e)
        {
            navigate_btn("select * from snd_kbd_table where id=(select min(id) from snd_kbd_table)");
        }

        private void second_btn_Click(object sender, EventArgs e)
        {
            navigate_btn(navigation_class.next_navigatoin("snd_kbd_table", "id", id_tb.Text));
            is_next_clicked = true;
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            navigate_btn(navigation_class.prev_navigation("snd_kbd_table", "id", id_tb.Text));
            is_next_clicked = false;
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            navigate_btn("select * from snd_kbd_table where id=(select max(id) from snd_kbd_table)");

        }

        private void fill_cb_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.comboBox_class.fill_combobox(table, customer_name_cb);
        }

        private void en_snd_qbd_form_Load(object sender, EventArgs e)
        {
            new_btn.PerformClick();
            get_snd_number();
            if (fill_cb_worker.IsBusy == false)
                fill_cb_worker.RunWorkerAsync();
        }

        void add_snd()
        {
            string name = customer_name_cb.Text.Trim();
            string pay_method = pay_type_cb.Text.Trim();
            double value = Convert.ToDouble(value_textbox.Text);
            string the_date = snd_date_dtp.DateTime.ToString("dd-MM-yyyy");
            string username = classes.const_variables_class.username;
            string notes = notes_textbox.Text.Trim();
            string added_date = classes.const_variables_class.now_date;
            connection_class.command($"insert into snd_kbd_table values ({get_id_from_lbl()},N'{name}',{value},N'{the_date}',N'{username}',N'{notes}',N'{added_date}',N'{pay_method}')");
            logs_class.log_add($"pay cash bond with id {get_id_from_lbl()}", 0, "Bonds");
            classes.storage_class.storage_log_add($"pay cash bond with id [ {get_id_from_lbl()} ]", value, settings_files.main_settings.Default.storage_id);
            classes.storage_class.storage_value_increase(value);
            DialogResult dr = classes.notifications_class.my_messageBox("Saved Successfully\nDo you want to print ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                print();
            }
            else
                get_snd_number();

        }
        void get_snd_number()
        {
            DataTable table = connection_class.select("select isnull(max(id)+1,1) from snd_kbd_table");
            id_tb.Text = table.Rows[0][0].ToString();
        }
        int get_id_from_lbl()
        {
            return Convert.ToInt32(id_tb.Text);
        }
    }
}