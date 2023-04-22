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
using System.Data.SqlClient;
using ClientApp.classes;
using ClientApp.settings_files;

namespace ClientApp
{
    public partial class ar_agel_notifications_form : DevExpress.XtraEditors.XtraForm
    {
        public ar_agel_notifications_form()
        {
            InitializeComponent();

            my_grid_view_class.set_find_panel_font2(main_gridview, gridControl2,false,false);
            my_grid_view_class.set_font_and_hover_effect(main_gridview);
            my_grid_view_class.show_empty_message2(main_gridview);

        }

        DataTable agel_table;
        // fill agel table with data from database
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            agel_table = connection_class.select(@"select
 agl_id as 'الرمز'
,fatora_id as 'الفاتورة'
,customer_name  as 'إسم العميل'
,full_money as 'المبلغ الكامل'
,how_pay as 'القيمة المدفوعة'
,how_stay as 'القيمة المتبقية'
from agle_table where the_pay_date=CONVERT(date, GETDATE(), 105) and how_stay>0");
        }
        // bind table to gridview and make gridview read only
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (agel_table.Rows.Count == 0)
            {
                return;
            }
            my_grid_view_class.set_datasource(gridControl2, main_gridview, agel_table);
            main_gridview.BestFitColumns();
        }

        private void ar_agel_notifications_form_Load(object sender, EventArgs e)
        {
            agel_table = connection_class.select(@"select
 agl_id as 'الرمز'
,fatora_id as 'الفاتورة'
,customer_name  as 'إسم العميل'
,full_money as 'المبلغ الكامل'
,how_pay as 'القيمة المدفوعة'
,how_stay as 'القيمة المتبقية'
from agle_table where 1=2");
            my_grid_view_class.set_datasource(gridControl2, main_gridview, agel_table);
            classes.run_worker_class.run(backgroundWorker1);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int agl_id = 0;
            int fatora_id = 0;
            string customer_name = string.Empty;
            string the_date = classes.const_variables_class.now_date;
            string username = classes.const_variables_class.username;
            double value = 0;
            if(!validate_class.is_storage_bound_to_this_user())
            {
                return;
            }
            if (main_gridview.SelectedRowsCount == 0)
            {
                notifications_class.select_data_message();
                return;
            }
            if (ClientApp.classes.texts_class.is_null(some_tb.Text))
            {
                OmarNotifications.Alert.ShowInformation("يجب إدخال قيمة");
                return;
            }
            if (Convert.ToDouble(some_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("لا يمكن أن تكون القيمة صفر أو سالبة");
                return;
            }
            else
            {
                value = Convert.ToDouble(some_tb.Text);
                if (value <= 0)
                {
                    OmarNotifications.Alert.ShowInformation("لا يمكن أن تكون القيمة صفر أو سالبة");
                    return;
                }
                foreach (int i in main_gridview.GetSelectedRows())
                {
                    double how_stay = Convert.ToDouble(main_gridview.GetRowCellValue(i, main_gridview.Columns["القيمة المتبقية"]));
                    int id = Convert.ToInt32(main_gridview.GetRowCellValue(i, main_gridview.Columns["الرمز"]));
                    if (value > how_stay)
                    {
                        OmarNotifications.Alert.ShowInformation($"القيمة المدخلة للمديونية ذات الرمز {id} أكبر من المبلغ المستحق");
                        return;
                    }
                }
                DialogResult dr = notifications_class.my_messageBox("هل تريد تأكيد قبض المديونية ؟", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (int n in main_gridview.GetSelectedRows())
                    {
                        fatora_id = Convert.ToInt32(main_gridview.GetRowCellValue(n, main_gridview.Columns[1]));
                        agl_id = Convert.ToInt32(main_gridview.GetRowCellValue(n, main_gridview.Columns[0]));
                        customer_name = main_gridview.GetRowCellValue(n, main_gridview.Columns["إسم العميل"]).ToString();
                        connection_class.command($"update agle_table set how_stay=how_stay-{value} where agl_id={agl_id}");
                        connection_class.command($"update agle_table set how_pay=full_money-how_stay where agl_id={agl_id}");
                        connection_class.command($"insert into customers_paied_money_table values ({fatora_id},{agl_id},N'{customer_name}',{value},N'{the_date}',{const_variables_class.userID})");
                        connection_class.command("delete from agle_table where how_stay=0");
                        add_kshf_class.customer_kshf(customer_name, $"قبض من مديونية العملاء برقم [{agl_id}]", value);
                        classes.aol_moda_class.update_customer_aol_moda(customer_name, value * -1);
                        logs_class.log_add($"قبض مديونية من العملاء للفاتورة ذات الرقم {fatora_id}", 0, "العملاء");
                        storage_class.storage_value_increase(value);
                        storage_class.storage_log_add($"قبض مديونية من العميل {customer_name} برقم {agl_id}", value, settings_files.main_settings.Default.storage_id);
                    }
                    gridControl2.DataSource = null;
                    run_worker_class.run(backgroundWorker1);
                    notifications_class.success_message();
                }

            }
        }
    }
}