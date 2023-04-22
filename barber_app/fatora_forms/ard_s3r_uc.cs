using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClientApp.classes;
using ClientApp.settings_files;
using System.Data.SqlClient;
using DevExpress.XtraGrid;

namespace ClientApp.fatora_forms
{
    public partial class ard_s3r_uc : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// delete from head table
        /// delete from body table
        /// </summary>
        /// 
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
        public ard_s3r_uc()
        {
            InitializeComponent();
            my_grid_view_class.set_find_panel_font2(main_gridview, quantites_grid_control, true, false, false);
            my_grid_view_class.set_font_and_hover_effect(main_gridview);
            my_grid_view_class.show_empty_message2(main_gridview);
            repositoryItemButtonEdit1.Click += delegate
            {
                try
                {
                    main_gridview.DeleteRow(main_gridview.FocusedRowHandle);
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }

            };
        }

        #region vars_area
        public static string the_date;
        // pos products user control
        // list to prevent add duplicate products to gridview
        public List<string> AddedProducts = new List<string>();
        DataTable products_table;
        // to store invoice id 
        public static int FatoraID = 0;

        #endregion
        #region methods_area
        // to check if everything ok before add invoice
        private bool IsEveryThingOK()
        {
            if (main_gridview.RowCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء أختيار الخدمات أولاً");
                return false;
            }
            return true;
        }
        // fill { total amount } and { discount } and { final amount } texts

        // get fatora id from database
        // fill table with report head info for print
        public static double totalForPrint, taxForPrint,totalWithoutTaxPrint;
        public static string note;

        DataTable head_datasource()
        {
            DataTable table = connection_class.select($@"SELECT
      customer_name as customer_name
      ,en_name
      ,customer_tax_number as customer_tax_number
      , concat(country,'-',town,'-',al7e)  as customer_address
      , customer_sgl_number as customer_sgl_number
      , building_number as building
      , street
      ,customer_second_mobile  as customer_second_mobile
      ,email
  FROM customers_table where customer_name=N'{customer_name_cb.Text}'");
            if (table.Rows.Count != 0)
            {
                ar_pos_uc.customer_name = table.Rows[0]["customer_name"].ToString();
                ar_pos_uc.customer_tax_number = table.Rows[0]["customer_tax_number"].ToString();
                ar_pos_uc.customer_address = table.Rows[0]["customer_address"].ToString();
                ar_pos_uc.customer_sgl = table.Rows[0]["customer_sgl_number"].ToString();
                ar_pos_uc.customer_building = table.Rows[0]["building"].ToString();
                ar_pos_uc.customer_street = table.Rows[0]["street"].ToString();
                ar_pos_uc.customer_second_number = table.Rows[0]["customer_second_mobile"].ToString();
                ar_pos_uc.customer_email = table.Rows[0]["email"].ToString();
                ar_pos_uc.en_name = table.Rows[0]["en_name"].ToString();
            }
            else
            {
                ar_pos_uc.customer_name = "";
                ar_pos_uc.customer_tax_number = "";
                ar_pos_uc.customer_address = "";
                ar_pos_uc.customer_sgl = "";
                ar_pos_uc.customer_building = "";
                ar_pos_uc.customer_street = "";
                ar_pos_uc.customer_second_number = "";
            }
            return table;
        }
        // fill table with report body info for print
        DataTable products_datasource()
        {
            DataTable t = connection_class.select("select * from ard_s3r_temp_table");
            return t;
        }

        void clear_rows()
        {
            note_tb.Text = "";
            for (int c = 0; c < main_gridview.RowCount; c++)
            {
                main_gridview.DeleteRow(c);
            }
            for (int l = 0; l < main_gridview.DataRowCount; l++)
            {
                main_gridview.DeleteRow(l);
            }
            if (main_gridview.RowCount != 0)
            {
                for (int c = 0; c < main_gridview.RowCount; c++)
                {
                    main_gridview.DeleteRow(c);
                }
            }
            if (main_gridview.DataRowCount != 0)
            {
                for (int l = 0; l < main_gridview.DataRowCount; l++)
                {
                    main_gridview.DeleteRow(l);
                }

            }

        }
        void print()
        {
            for (int i = 0; i < main_gridview.DataRowCount; i++)
            {
                string name = main_gridview.GetRowCellValue(i, colproduct_name).ToString();
                string qty = main_gridview.GetRowCellValue(i, colqty).ToString();
                string unit = main_gridview.GetRowCellValue(i, colunit) is null ? "" : main_gridview.GetRowCellValue(i, colunit).ToString();
                string price = main_gridview.GetRowCellValue(i, col_priceBeforeTax).ToString();
                string tax = main_gridview.GetRowCellValue(i, col_tax).ToString();
                string total = main_gridview.GetRowCellValue(i, colfull_Value).ToString();
                connection_class.command($"insert into ard_s3r_temp_table values (N'{name}',{qty},N'{unit}',{price},{tax},{total})");
            }
            repost_pos.the_ard_s3r_report.print(products_datasource(), head_datasource());
            customer_name_cb.ItemIndex = 0;
            note_tb.Text = "";
            id_tb.Text = (Convert.ToInt32(id_tb.Text) + 1).ToString();
            clear_rows();
            connection_class.command($"delete from ard_s3r_temp_table");
        }
        #endregion

        double the_total_amount()
        {
            double value = 0;
            double tax = 0;
            for (int i = 0; i < main_gridview.DataRowCount; i++)
            {
                value += Convert.ToDouble(main_gridview.GetRowCellValue(i, colfull_Value).ToString());
                tax += Convert.ToDouble(main_gridview.GetRowCellValue(i, col_tax).ToString());
            }
            return value + tax;
        }
        double get_tax()
        {
            double value = 0;
            if (settings_files.main_settings.Default.tax_value != 0)
            {
                for (int i = 0; i < main_gridview.DataRowCount; i++)
                {
                    double tax = Convert.ToDouble(main_gridview.GetRowCellValue(i, col_tax).ToString());
                    value += tax;
                }
            }

            return value;
        }
        double get_total_without_tax()
        {
            double value = 0;
            if (settings_files.main_settings.Default.tax_value != 0)
            {
                for (int i = 0; i < main_gridview.DataRowCount; i++)
                {
                    double tax = Convert.ToDouble(main_gridview.GetRowCellValue(i, colfull_Value).ToString());
                    value += tax;
                }
            }

            return value;
        }
        private void pay_btn_Click(object sender, EventArgs e)
        {
        }
        private void main_gridview_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colqty)
            {
                double qty = Convert.ToDouble(main_gridview.GetFocusedRowCellValue(colqty));
                double beforetax = Convert.ToDouble(main_gridview.GetFocusedRowCellValue(col_priceBeforeTax));
                double tax = Convert.ToDouble(beforetax * main_settings.Default.tax_value) / 100;
                main_gridview.SetFocusedRowCellValue(colfull_Value, beforetax * qty);
                main_gridview.SetFocusedRowCellValue(col_tax, (tax * qty));
            }
            if (e.Column == col_priceBeforeTax)
            {

                double qty = Convert.ToDouble(main_gridview.GetFocusedRowCellValue(colqty));
                double beforetax = Convert.ToDouble(main_gridview.GetFocusedRowCellValue(col_priceBeforeTax));
                double tax = Convert.ToDouble(beforetax * main_settings.Default.tax_value) / 100;
                main_gridview.SetFocusedRowCellValue(colfull_Value, beforetax * qty);
                main_gridview.SetFocusedRowCellValue(col_tax, (tax * qty));
            }
        }

        private void main_gridview_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
        }

        private void main_gridview_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {

        }

        private void pay_print_btn_Click(object sender, EventArgs e)
        {
            note = note_tb.Text;
            FatoraID = Convert.ToInt32(id_tb.Text);
            the_date = DateTime.Now.ToString("yyyy-MM-dd");
            taxForPrint = get_tax();
            totalWithoutTaxPrint = get_total_without_tax();
            totalForPrint = the_total_amount();
            print();
        }

        private void ard_s3r_uc_Load(object sender, EventArgs e)
        {
            run_worker_class.run(customers_worker);
        }

        private void main_gridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void search_cb_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {


        }

        private void customer_name_cb_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        DataTable customers_table;
        private void customers_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            customers_table = connection_class.select("select customer_id as 'الرقم',customer_name as 'العميل',customer_mobile as 'الجوال' from customers_table order by customer_name");

        }
        private void customers_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataRow dr = customers_table.NewRow();
            dr["الرقم"] = 0;
            dr["العميل"] = "عميل نقدي";
            dr["الجوال"] = "";
            int yourPosition = 0;
            customers_table.Rows.InsertAt(dr, yourPosition);
            classes.lookup_edit_class.fill_lookup(customers_table, customer_name_cb, "العميل");
        }
        public static bool is_bill_agel = false;
        public static bool is_gomla = false;
        public static int col_number_for_open_unit_form = 0;
        DataTable main_category_table;
        private void products_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            main_category_table = connection_class.select("select id,category_name from categories_table where is_main=1");
        }

        private void customer_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer_name_cb.Text != "عميل نقدي")
            {
                is_bill_agel = true;

            }
            else is_bill_agel = false;
        }
        private void main_category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void add_product_btn_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openForm(new customers_forms.ar_customers_form());
            run_worker_class.run(customers_worker);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (notifications_class.my_messageBoxRightYesNo("هل أنت متأكد ؟") == DialogResult.Yes)
            {
                classes.form_close_class.close("ard_s3r_form");
            }
        }
    }
}
