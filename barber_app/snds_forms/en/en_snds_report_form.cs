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
using DevExpress.XtraGrid;
using ClientApp.classes;
using ClientApp.settings_files;

namespace ClientApp.n_snds_forms.en
{
    public partial class en_snds_report_form : DevExpress.XtraEditors.XtraForm
    {
        public en_snds_report_form()
        {
            InitializeComponent(); 
            first_date.DateTime = last_date.DateTime = DateTime.Now;

            my_grid_view_class.set_find_panel_font2(gridView1, gridControl1,true,true);
            my_grid_view_class.set_font_and_hover_effect(gridView1);
            my_grid_view_class.show_empty_message2(gridView1);
        }
        public static string snd_type = "";
        int choices()
        {
            int a = 0;
            if (date_cbx.Checked)
            {
                a = 1;
            }
            if (snd_reason_cbx.Checked)
            {
                a = 2;
            }
            if (username_cbx.Checked)
            {
                a = 3;
            }
            if (date_cbx.Checked && snd_reason_cbx.Checked)
            {
                a = 4;
            }
            if (date_cbx.Checked && username_cbx.Checked)
            {
                a = 5;
            }
            if (date_cbx.Checked && snd_reason_cbx.Checked && username_cbx.Checked)
            {
                a = 6;
            }
            if (snd_reason_cbx.Checked && username_cbx.Checked)
            {
                a = 7;
            }
            return a;
        }
        string query(int choices)
        {
            string f = first_date.DateTime.ToString("dd-MM-yyyy");
            string l = last_date.DateTime.ToString("dd-MM-yyyy");
            string d = "";
            if (choices == 0)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table]";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table]";
                }
            }
            if (choices == 1)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
            }
            if (choices == 2)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where reason=N'{snd_reason_cb.Text}'";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where reason=N'{snd_reason_cb.Text}'";
                }
            }
            if (choices == 3)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where username=N'{username_cb.Text}'";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where username=N'{username_cb.Text}'";
                }
            }
            if (choices == 4)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where reason=N'{snd_reason_cb.Text}' and the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where reason=N'{snd_reason_cb.Text}' and the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
            }
            if (choices == 5)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where username=N'{username_cb.Text}' and the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where username=N'{username_cb.Text}' and the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
            }
            if (choices == 6)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where reason=N'{snd_reason_cb.Text}' and username=N'{username_cb.Text}' and the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where reason=N'{snd_reason_cb.Text}' and username=N'{username_cb.Text}' and the_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
                }
            }
            if (choices == 7)
            {
                if (snd_type_cb.Text == "Cash Receipt")
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_kbd_table] where reason=N'{snd_reason_cb.Text}' and username=N'{username_cb.Text}'";
                }
                else
                {
                    d = $@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where reason=N'{snd_reason_cb.Text}' and username=N'{username_cb.Text}'";
                }
            }
            return d;

        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            DataTable table = connection_class.select(query(choices()));
            if (table.Rows.Count == 0)
            {
                notifications_class.grid_message();
                gridControl1.DataSource = null;
                return;
            }
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
            my_grid_view_class.set_summary(gridView1, "Value");
        }
        DataTable reason_table, username_table;

        private void snd_type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            classes.run_worker_class.run(fill_cb_worker);
        }

        private void fill_cb_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.lookup_edit_class.fill_lookup(reason_table, snd_reason_cb,"Customer");
            classes.lookup_edit_class.fill_lookup(username_table, username_cb,"Username");
        }
        public static string from_date, to_date;

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                gridControl1.DataSource = null;
                return;
            }
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            snd_type = snd_type_cb.Text;
            repost_pos.en_snds_report.print(classes.my_grid_view_class.gridview_to_data_table(gridView1), null);
        }

        private void fill_cb_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string the_type = snd_type_cb.Text;
            if (the_type == "Cash Receipt")
            {
                reason_table = connection_class.select("select distinct reason as 'Customer' from snd_kbd_table");
                username_table = connection_class.select("select distinct username as 'Username' from users_table");
            }
            else
            {
                reason_table = connection_class.select("select distinct reason as 'Customer' from snd_srf_table");
                username_table = connection_class.select("select distinct username as 'Username' from users_table");
            }
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            repost_pos.en_snds_report.to_pdf(classes.my_grid_view_class.gridview_to_data_table(gridView1));
        }
        private void excel_btn_Click(object sender, EventArgs e)
        {
            repost_pos.en_snds_report.to_excel(classes.my_grid_view_class.gridview_to_data_table(gridView1));
        }
        private void word_btn_Click(object sender, EventArgs e)
        {
            repost_pos.en_snds_report.to_word(classes.my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void en_snds_report_form_Load(object sender, EventArgs e)
        {
            DataTable table = connection_class.select($@"SELECT [id] as 'ID'
      ,[reason] as 'Customer'
      ,[value] as 'Value'
      ,convert(nvarchar,[the_date],105) as 'Date',pay_method as 'Pay method'
      ,[username] as 'Username'
      ,[notes] as 'Statment'
  FROM [snd_srf_table] where 1=2");
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
            run_worker_class.run(fill_cb_worker);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                notifications_class.select_data_message();
                return;
            }
            DialogResult dr = classes.notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                foreach (int i in gridView1.GetSelectedRows())
                {
                    int id = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0]));
                    if (snd_type_cb.Text == "Cash Receipt")
                    {
                        DataTable old_table = connection_class.select($"select * from snd_kbd_table where id={id}");
                        string reason = old_table.Rows[0]["reason"].ToString();
                        double value = Convert.ToDouble(old_table.Rows[0]["value"]);
                        string the_date =Convert.ToDateTime(old_table.Rows[0]["the_date"]).ToString("dd-MM-yyyy");
                        string username = old_table.Rows[0]["username"].ToString();
                        string notes = old_table.Rows[0]["notes"].ToString();
                        logs_class.log_add($"Delete cash bond with id {id}", 0, "Bonds");
                        classes.storage_class.storage_value_decrease(value);
                        classes.storage_class.storage_log_add($"Delete cash bond with id [ {id} ]", value * -1, settings_files.main_settings.Default.storage_id);
                        connection_class.command($"delete from snd_kbd_table where id={id}");
                    }
                    else
                    {
                        DataTable old_table = connection_class.select($"select * from snd_srf_table where id={id}");
                        string reason = old_table.Rows[0]["reason"].ToString();
                        double value = Convert.ToDouble(old_table.Rows[0]["value"]);
                        string the_date = Convert.ToDateTime(old_table.Rows[0]["the_date"]).ToString("dd-MM-yyyy");
                        string username = old_table.Rows[0]["username"].ToString();
                        string notes = old_table.Rows[0]["notes"].ToString();
                        classes.storage_class.storage_value_increase(value);
                        logs_class.log_add($"Delete reciept with id [ {id} ]", 0, "Bonds");
                        classes.storage_class.storage_log_add($"Delete reciept with id {id}", value, settings_files.main_settings.Default.storage_id);
                        connection_class.command($"delete from snd_srf_table where id={id}");
                    }
                }
                show_report_btn.PerformClick();
                classes.notifications_class.success_message();
            }
        }

    }
}