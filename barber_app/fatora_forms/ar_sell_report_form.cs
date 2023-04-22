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
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using ClientApp.classes;

namespace ClientApp.fatora_forms
{
    public partial class ar_sell_report_form : XtraForm
    {

        public ar_sell_report_form()
        {
            InitializeComponent();
            first_date.DateTime = last_date.DateTime = DateTime.Now;
            my_grid_view_class.set_find_panel_font2(gridView2, gridControl2, true, true);
            my_grid_view_class.show_empty_message2(gridView2);
            my_grid_view_class.set_font_and_hover_effect(gridView2);
        }
        bool convert_int32(int num, string textbox)
        {
            if (!int.TryParse(textbox, out num))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void uncheck_radio()
        {
            if (date_cbx.Checked || username_cbx.Checked || customer_cbx.Checked)
            {
                id_barcode_radio.Checked = false;
            }
        }
        int choices()
        {
            int c = 2;
            if (id_barcode_radio.Checked)
            {
                c = 1;
            }
            if (date_cbx.Checked && username_cbx.Checked == false && customer_cbx.Checked == false)
            {
                c = 2;
            }
            if (username_cbx.Checked && date_cbx.Checked == false && customer_cbx.Checked == false)
            {
                c = 3;
            }
            if (customer_cbx.Checked && date_cbx.Checked == false && username_cbx.Checked == false)
            {
                c = 4;
            }
            return c;
        }
        string query(int choices)
        {
            string f = first_date.DateTime.ToString("dd-MM-yyyy");
            string l = last_date.DateTime.ToString("dd-MM-yyyy");
            string a = "";
            if (choices == 1)
            {
                a = $@"SELECT [fatora_id] as 'الفاتورة'
      ,[bill_type] as 'نوع الفاتورة'
      ,convert(varchar,[sell_date],105)+' '+[sell_time] as 'تاريخ ووقت البيع'
      ,customer_name as 'العميل'
      ,[total_before_taxes] as 'الأجمالي قبل الضريبة',[taxes] as 'الضريبة',[total_amount] as 'الأجمالي بعد الضريبة',[net_amount] as 'القيمة النهائية'
	  ,[paied_money] as 'المدفوع'
      ,[net_amount] as 'المتبقي'
	  
      ,(select username from users_table where users_table.user_id=userID) as 'المستخدم'   
  FROM [sales_head_table] where fatora_id={Convert.ToInt32(id_barcode_tb.Text)}";
            }
            if (choices == 2)
            {
                a = $@"SELECT [fatora_id] as 'الفاتورة'
      ,[bill_type] as 'نوع الفاتورة'
      ,convert(varchar,[sell_date],105)+' '+[sell_time] as 'تاريخ ووقت البيع'
      ,customer_name as 'العميل'
      ,[total_before_taxes] as 'الأجمالي قبل الضريبة',[taxes] as 'الضريبة',[total_amount] as 'الأجمالي بعد الضريبة',[net_amount] as 'القيمة النهائية'
	  ,[paied_money] as 'المدفوع'
      ,[net_amount] as 'المتبقي'
	  
      ,(select username from users_table where users_table.user_id=userID) as 'المستخدم'   
  FROM [sales_head_table] where sell_date between convert(date,'{f}',105) and convert(date,'{l}',105)";
            }
            if (choices == 3)
            {
                a = $@"SELECT [fatora_id] as 'الفاتورة'
      ,[bill_type] as 'نوع الفاتورة'
      ,convert(varchar,[sell_date],105)+' '+[sell_time] as 'تاريخ ووقت البيع'
      ,customer_name as 'العميل'
      ,[total_before_taxes] as 'الأجمالي قبل الضريبة',[taxes] as 'الضريبة',[total_amount] as 'الأجمالي بعد الضريبة',[net_amount] as 'القيمة النهائية'
	  ,[paied_money] as 'المدفوع'
      ,[net_amount] as 'المتبقي'
	  
      ,(select username from users_table where users_table.user_id=userID) as 'المستخدم'   
  FROM [sales_head_table] where userID=(select user_id from users_table where username=N'{username_cb.Text}')";
            }
            if (choices == 4)
            {
                a = $@"SELECT [fatora_id] as 'الفاتورة'
      ,[bill_type] as 'نوع الفاتورة'
      ,convert(varchar,[sell_date],105)+' '+[sell_time] as 'تاريخ ووقت البيع'
      ,customer_name as 'العميل'
      ,[total_before_taxes] as 'الأجمالي قبل الضريبة',[taxes] as 'الضريبة',[total_amount] as 'الأجمالي بعد الضريبة',[net_amount] as 'القيمة النهائية'
	  ,[paied_money] as 'المدفوع'
      ,[net_amount] as 'المتبقي'
	  
      ,(select username from users_table where users_table.user_id=userID) as 'المستخدم'   
  FROM [sales_head_table] where customer_name=N'{customer_name_cb.Text}'";
            }
            return a;
        }
        private void id_barcode_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (id_barcode_radio.Checked)
            {
                date_cbx.Checked = customer_cbx.Checked = username_cbx.Checked = false;
            }
        }

        private void date_cbx_CheckedChanged(object sender, EventArgs e)
        {
            uncheck_radio();
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            if (date_cbx.Checked == false && id_barcode_radio.Checked == false && username_cbx.Checked == false && customer_cbx.Checked == false)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء تحديد خيار للبحث");
                return;
            }
            if (id_barcode_radio.Checked)
            {
                if (texts_class.is_null(id_barcode_tb.Text))
                {
                    OmarNotifications.Alert.ShowInformation("يرجى كتابة الرقم أو الباركود");
                    return;
                }
                else
                {
                    int invoice_id = 0;
                    if (convert_int32(invoice_id, id_barcode_tb.Text) == false)
                    {
                        OmarNotifications.Alert.ShowInformation("الرقم المدخل غير صحيح");
                        return;
                    }
                }
            }
            DataTable table = connection_class.select(query(choices()));
            if (table.Rows.Count == 0)
            {
                notifications_class.grid_message();
                gridControl2.DataSource = null;
                return;
            }
            my_grid_view_class.set_datasource(gridControl2, gridView2, table);
            my_grid_view_class.set_summary(gridView2, "الأجمالي بعد الضريبة");
            my_grid_view_class.set_summary(gridView2, "الأجمالي قبل الضريبة");
            my_grid_view_class.set_summary(gridView2, "القيمة النهائية");
            my_grid_view_class.set_summary(gridView2, "الضريبة");
            my_grid_view_class.set_summary(gridView2, "المدفوع");
            my_grid_view_class.set_summary(gridView2, "المتبقي");
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
            repost_pos.sales_report.print(my_grid_view_class.gridview_to_data_table(gridView2), null);

        }

        private void ar_sell_report_form_Load(object sender, EventArgs e)
        {
            DataTable table = connection_class.select(@"SELECT [fatora_id] as 'الفاتورة'
      ,[bill_type] as 'نوع الفاتورة'
      ,convert(varchar,[sell_date],105)+' '+[sell_time] as 'تاريخ ووقت البيع'
      ,customer_name as 'العميل'
      ,[total_before_taxes] as 'الأجمالي قبل الضريبة',[taxes] as 'الضريبة',[total_amount] as 'الأجمالي بعد الضريبة',[net_amount] as 'القيمة النهائية'
	  ,[paied_money] as 'المدفوع'
      ,[net_amount] as 'المتبقي'
	  
      ,(select username from users_table where users_table.user_id=userID) as 'المستخدم'    
  FROM [sales_head_table] where 1 = 2");
            my_grid_view_class.set_datasource(gridControl2, gridView2, table);
            if (fill_cb_worker.IsBusy == false)
                fill_cb_worker.RunWorkerAsync();
        }
        DataTable customers_table, users_table, bill_type_table;
        private void fill_cb_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            customers_table = connection_class.select("select distinct customer_name as 'العميل' from sales_head_table");
            users_table = connection_class.select("select distinct username as 'المستخدم' from users_table");
            bill_type_table = connection_class.select("select distinct bill_type as 'نوع الفاتورة' from sales_head_table");
        }

        private void fill_cb_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.lookup_edit_class.fill_lookup(customers_table, customer_name_cb, "العميل");
            classes.lookup_edit_class.fill_lookup(users_table, username_cb, "المستخدم");
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.sales_report.to_word(my_grid_view_class.gridview_to_data_table(gridView2));
        }
        void openForm(XtraForm form, bool m = false)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.IconOptions.ShowIcon = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = m;
            form.Text = "";
            form.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DevExpress);
            form.Show();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount == 0)
            {
                return;
            }
            if (gridView2.SelectedRowsCount > 1)
            {
                OmarNotifications.Alert.ShowInformation("يرجى أختيار فاتورة واحدة فقط");
                return;
            }
            string invoice_number = gridView2.GetFocusedRowCellValue(gridView2.Columns[0].FieldName).ToString();
            fatora_detailes_form form = new fatora_detailes_form();
            fatora_detailes_form.invoice_number = invoice_number;
            form.head_label.Text = $"تفاصيل الفاتورة {invoice_number}";
            openForm(new fatora_detailes_form());
        }
        static DataTable head_datasource(int fatora_id)
        {
            DataTable table = connection_class.select(@"SELECT [fatora_id]
      ,[sell_date]
      ,[sell_time]
      ,customer_name as customer_name
      ,(select customer_tax_number from customers_table where customers_table.customer_name=sales_head_table.customer_name) as customer_tax_number
      ,(select concat(country,'-',town,'-',al7e) from customers_table where customers_table.customer_name=sales_head_table.customer_name) as customer_address
      ,(select customer_sgl_number from customers_table where customers_table.customer_name=sales_head_table.customer_name) as customer_sgl_number
      ,(select building_number from customers_table where customers_table.customer_name=sales_head_table.customer_name) as building
      ,(select street from customers_table where customers_table.customer_name=sales_head_table.customer_name) as street
      ,(select customer_second_mobile from customers_table where customers_table.customer_name=sales_head_table.customer_name) as customer_second_mobile
      ,[total_amount]
      ,[net_amount]
      ,[pay_method]
      ,[taxes]
      ,[total_before_taxes]
      ,[paied_money]
      ,[cash]
      ,[card]
      ,[discount]
  FROM[client_database].[dbo].[sales_head_table] where fatora_id=" + fatora_id);
            if (table.Rows.Count != 0)
            {
                ar_pos_uc.customer_name = table.Rows[0]["customer_name"].ToString();
                ar_pos_uc.customer_tax_number = table.Rows[0]["customer_tax_number"].ToString();
                ar_pos_uc.customer_address = table.Rows[0]["customer_address"].ToString();
                ar_pos_uc.customer_sgl = table.Rows[0]["customer_sgl_number"].ToString();
                ar_pos_uc.customer_building = table.Rows[0]["building"].ToString();
                ar_pos_uc.customer_street = table.Rows[0]["street"].ToString();
                ar_pos_uc.customer_second_number = table.Rows[0]["customer_second_mobile"].ToString();
                ar_pos_uc.totalForPrint = Convert.ToDecimal(table.Rows[0]["total_amount"]);
                ar_pos_uc.taxForPrint = Convert.ToDecimal(table.Rows[0]["taxes"]);
                TLVCls tlv = new TLVCls(settings_files.main_settings.Default.barber_name, settings_files.main_settings.Default.tax_number, DateTime.Now, fatora_forms.ar_pos_uc.totalForPrint, fatora_forms.ar_pos_uc.taxForPrint);
                ar_pos_uc.qr= tlv.toQrCode();
            }
            return table;
        }
        // fill table with report body info for print
        static DataTable products_datasource(int fatora_id)
        {
            DataTable table = connection_class.select(@"SELECT number = ROW_NUMBER() OVER (ORDER BY fatora_id)
      ,[fatora_id]
      ,[service_name]
      ,[unit]
      ,[quantity]
      ,[product_price_before_tax]
      ,[tax]
      ,[product_full_price]
      ,[ash3ar_qty]
  FROM [client_database].[dbo].[sales_body_table] where fatora_id=" + fatora_id);
            return table;
        }
        //direct print
        private void simpleButton3_Click(object sender, EventArgs e)
        {
          if(gridView2.SelectedRowsCount>1)
            {
                OmarNotifications.Alert.ShowInformation("يرجى أختيار فاتورة واحدة فقط");
                return;
            }
            int fatora_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue(gridView2.Columns[0].FieldName));
            repost_pos.new_fatora.print(products_datasource(fatora_id), head_datasource(fatora_id), true);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount > 1)
            {
                OmarNotifications.Alert.ShowInformation("يرجى أختيار فاتورة واحدة فقط");
                return;
            }
            int fatora_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue(gridView2.Columns[0].FieldName));
            repost_pos.new_fatora.print(products_datasource(fatora_id), head_datasource(fatora_id), false);
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.sales_report.to_excel(my_grid_view_class.gridview_to_data_table(gridView2));
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            from_date = first_date.DateTime.ToString("dd-MM-yyyy");
            to_date = last_date.DateTime.ToString("dd-MM-yyyy");
            repost_pos.sales_report.to_pdf(my_grid_view_class.gridview_to_data_table(gridView2));
        }
        public static int fatora_id;

    }
}