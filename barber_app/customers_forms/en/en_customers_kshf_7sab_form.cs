using DevExpress.Utils;
using DevExpress.XtraGrid;
using ClientApp.classes;
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
    public partial class en_customers_kshf_7sab_form : DevExpress.XtraEditors.XtraForm
    {
        public en_customers_kshf_7sab_form()
        {
            InitializeComponent(); 
            first_date.DateTime = last_date.DateTime = DateTime.Now;

            my_grid_view_class.set_find_panel_font2(gridView1, gridControl1,true,true);
            my_grid_view_class.set_font_and_hover_effect(gridView1);
            my_grid_view_class.show_empty_message2(gridView1);
        }

        DataTable customer_table;
        public static string date_time, the_name, the_money, the_fatora_numbers, from_date, to_date;

        private void en_customers_kshf_7sab_form_Load(object sender, EventArgs e)
        {
            DataTable table = connection_class.select($"select id as 'ID', customer_id as 'customer id',(select customer_name from customers_table where customers_table.customer_id=customer_kshf_table.customer_id) as 'customer',statment,value ,convert(nvarchar,the_date,105) as 'date',(select username from users_table where users_table.user_id=userID) as 'user' from customer_kshf_table where 1=2");
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
            run_worker_class.run(customer_worker);
        }

        public static double total;

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            if (gridView1.RowCount != 0)
            {
                total = my_grid_view_class.column_sum(gridView1, "value");
                from_date = first_date.DateTime.ToString("dd-MM-yyyy");
                to_date = last_date.DateTime.ToString("dd-MM-yyyy");
                repost_pos.en_customers_kshf_7sab_report.print(classes.my_grid_view_class.gridview_to_data_table(gridView1), null);
            }
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            total = my_grid_view_class.column_sum(gridView1, "value");
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_customers_kshf_7sab_report.to_word(classes.my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                notifications_class.select_data_message();
                return;
            }
            if (gridView1.SelectedRowsCount != 0)
            {
                DialogResult dr = notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        int ID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0]));
                        connection_class.command($"delete from customer_kshf_table where id={ID}");
                        logs_class.log_add($"Delete customers logs with id : {customer_cb.Text}", 0, "Customers");
                    }
                    classes.notifications_class.success_message();
                    show_report_btn.PerformClick();
                }
            }
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            total = my_grid_view_class.column_sum(gridView1, "value");
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_customers_kshf_7sab_report.to_excel(classes.my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            total = my_grid_view_class.column_sum(gridView1, "value");
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.en_customers_kshf_7sab_report.to_pdf(classes.my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void customer_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            customer_table = connection_class.select("select  customer_name as 'customer' from customers_table");
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "value")
            {
                if (Convert.ToDouble(e.CellValue) > 0)
                    e.Appearance.ForeColor = Color.RoyalBlue;
                else if (Convert.ToDouble(e.CellValue) < 0)
                    e.Appearance.ForeColor = Color.Red;
                else
                    e.Appearance.ForeColor = Color.Black;
            }
        }

        private void customer_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.lookup_edit_class.fill_lookup(customer_table, customer_cb, "customer");
        }
        DataTable table;
        int query_status()
        {
            int query_status = 0;
            if (customer_checkbox.Checked)
                query_status = 1;
            if (date_checkbox.Checked)
                query_status = 2;
            if (date_checkbox.Checked && customer_checkbox.Checked)
                query_status = 3;
            return query_status;
        }
        void do_search(int query_status)
        {
            DataTable CustomerIDTable = connection_class.select($"select customer_id from customers_table where customer_name=N'{customer_cb.Text}'");
            int customerID = 0;
            if (CustomerIDTable.Rows.Count != 0)
            {
                customerID = Convert.ToInt32(CustomerIDTable.Rows[0][0]);
            }
            string f = first_date.DateTime.ToString("dd-MM-yyyy");
            string l = last_date.DateTime.ToString("dd-MM-yyyy");
            if (query_status == 1)
            {
                table = connection_class.select($"select id as 'ID', customer_id as 'customer id',(select customer_name from customers_table where customers_table.customer_id=customer_kshf_table.customer_id) as 'customer',statment ,value ,convert(nvarchar,the_date,105) as 'date',(select username from users_table where users_table.user_id=userID) as 'user' from customer_kshf_table where customer_id={customerID}");
            }
            if (query_status == 2)
            {
                table = connection_class.select($"select id as 'ID', customer_id as 'customer id',(select customer_name from customers_table where customers_table.customer_id=customer_kshf_table.customer_id) as 'customer',statment ,value ,convert(nvarchar,the_date,105) as 'date',(select username from users_table where users_table.user_id=userID) as 'user' from customer_kshf_table where the_date between convert(date,N'{f}',105) and convert(date,N'{l}',105)");
            }
            if (query_status == 3)
            {
                table = connection_class.select($"select id as 'ID', customer_id as 'customer id',(select customer_name from customers_table where customers_table.customer_id=customer_kshf_table.customer_id) as 'customer',statment ,value ,convert(nvarchar,the_date,105) as 'date',(select username from users_table where users_table.user_id=userID) as 'user' from customer_kshf_table where customer_id={customerID} and the_date between convert(date,N'{f}',105) and convert(date,N'{l}',105)");
            }
            if (table.Rows.Count == 0)
            {
                notifications_class.grid_message();
                gridControl1.DataSource = null;
                return;
            }
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
            my_grid_view_class.set_summary(gridView1, "value");
          
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            if (customer_checkbox.Checked == false && date_checkbox.Checked == false)
            {
                OmarNotifications.Alert.ShowInformation("select search options");
                return;
            }
            do_search(query_status());
        }
    }
}
