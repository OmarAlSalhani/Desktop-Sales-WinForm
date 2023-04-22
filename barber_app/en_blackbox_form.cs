using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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

namespace ClientApp.n_blackbox_forms.ar
{
    public partial class en_blackbox_form : DevExpress.XtraEditors.XtraForm
    {
        public en_blackbox_form()
        {
            InitializeComponent(); 
            first_date.DateTime = last_date.DateTime = DateTime.Now;

            my_grid_view_class.set_find_panel_font2(gridView2, gridControl2,false,true);
            my_grid_view_class.set_font_and_hover_effect(gridView2);
            my_grid_view_class.show_empty_message2(gridView2);
        }
        DataTable users_table, screens_table;
        int choices()
        {
            int a = 0;
            if (date_checkbox.Checked)
            {
                a = 1;
            }
            if (username_checkbox.Checked)
            {
                a = 2;
            }
            if (screen_name_checkbox.Checked)
            {
                a = 3;
            }
            if (date_checkbox.Checked && username_checkbox.Checked)
            {
                a = 4;
            }
            if (date_checkbox.Checked && username_checkbox.Checked && screen_name_checkbox.Checked)
            {
                a = 5;
            }
            if (username_checkbox.Checked && screen_name_checkbox.Checked)
            {
                a = 6;
            }
            if (date_checkbox.Checked && screen_name_checkbox.Checked)
            {
                a = 7;
            }
            return a;
        }
        string query(int choices)
        {
            string b = "";
            if (choices == 1)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where event_date between convert(nvarchar,'{first_date.DateTime.ToString("dd-MM-yyyy")}',105) and convert(nvarchar,'{last_date.DateTime.ToString("dd-MM-yyyy")}',105)";
            }
            if (choices == 2)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where userID=(select user_id from users_table where username=N'{username_cb.Text}')";
            }
            if (choices == 3)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where event_screen=N'{screen_cb.Text}'";
            }
            if (choices == 4)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where userID=(select user_id from users_table where username=N'{username_cb.Text}') and event_date between convert(nvarchar,'{first_date.DateTime.ToString("dd-MM-yyyy")}',105) and convert(nvarchar,'{last_date.DateTime.ToString("dd-MM-yyyy")}',105)";
            }
            if (choices == 5)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where userID=(select user_id from users_table where username=N'{username_cb.Text}') and event_screen=N'{screen_cb.Text}' and event_date between convert(nvarchar,'{first_date.DateTime.ToString("dd-MM-yyyy")}',105) and convert(nvarchar,'{last_date.DateTime.ToString("dd-MM-yyyy")}',105)";
            }
            if (choices == 6)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where userID=(select user_id from users_table where username=N'{username_cb.Text}') and event_screen=N'{screen_cb.Text}'";
            }
            if (choices == 7)
            {
                b = $@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where event_screen=N'{screen_cb.Text}' and event_date between convert(nvarchar,'{first_date.DateTime.ToString("dd-MM-yyyy")}',105) and convert(nvarchar,'{last_date.DateTime.ToString("dd-MM-yyyy")}',105)";
            }
            return b;
        }
        private void FillWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            users_table = connection_class.select("select distinct username as 'username' from users_table");
            screens_table = connection_class.select("select distinct event_screen as 'screen' from black_box_table");
        }

        private void FillWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.lookup_edit_class.fill_lookup(users_table, username_cb, "username");
            classes.lookup_edit_class.fill_lookup(screens_table, screen_cb, "screen");
        }

        private void en_blackbox_form_Load(object sender, EventArgs e)
        {
            DataTable table = connection_class.select(@"
SELECT [id] as 'id'
      ,(select username from users_table where user_id=userID) as 'username'
      ,[event_name] as 'event'
      ,convert(nvarchar,[event_date],105)+' '+[event_time] as 'date and time'
      ,[event_screen] as 'screen'
  FROM [black_box_table] where 1 = 2");
            my_grid_view_class.set_datasource(gridControl2, gridView2, table);
            if (FillWorker.IsBusy == false)
            {
                FillWorker.RunWorkerAsync();
            }
        }
        bool check()
        {
            if (date_checkbox.Checked == false && username_checkbox.Checked == false && screen_name_checkbox.Checked == false)
            {
                return false;
            }
            return true;
        }
        private void show_report_btn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DataTable table = connection_class.select(query(choices()));
                if (table.Rows.Count == 0)
                {
                    gridControl2.DataSource = null;
                    notifications_class.grid_message();
                    return;
                }
                my_grid_view_class.set_datasource(gridControl2, gridView2, table);
               
            }
            else
            {
                OmarNotifications.Alert.ShowInformation("select search options");

            }

        }
        public static string from_date, to_date;
        private void print_btn_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_logs_report.print(classes.my_grid_view_class.gridview_to_data_table(gridView2), null);
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_logs_report.to_word(classes.my_grid_view_class.gridview_to_data_table(gridView2));
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_logs_report.to_excel(classes.my_grid_view_class.gridview_to_data_table(gridView2));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("select data first");
                return;
            }
            if (notifications_class.my_messageBoxRightYesNo("are you sure ?") == DialogResult.Yes)
            {
                foreach (int i in gridView2.GetSelectedRows())
                {
                    int id = Convert.ToInt32(gridView2.GetRowCellValue(i, "id"));
                    connection_class.command($"delete from black_box_table where id={id}");
                }
                notifications_class.success_message();
                show_report_btn.PerformClick();
            }
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_logs_report.to_pdf(classes.my_grid_view_class.gridview_to_data_table(gridView2));
        }

        private void employees_cb_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
