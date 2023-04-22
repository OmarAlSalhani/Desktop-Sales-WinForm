using System.Windows.Forms;using DevExpress.XtraReports.UI;using System;
using ClientApp.classes;
using DevExpress.XtraPrinting;
using ClientApp.settings_files;
namespace ClientApp.repost_pos
{
    public partial class en_pos_report : DevExpress.XtraReports.UI.XtraReport
    {
        public en_pos_report()
        {
            InitializeComponent();
        }

        void set_report_detailes()
        {
            drebe_number_label.Text = "Tax Number : " + settings_files.main_settings.Default.tax_number;
            pharmacy_name_label.Text = settings_files.main_settings.Default.barber_name; address_label.Text = "";
            logo_image.ImageUrl = settings_files.main_settings.Default.logo;
        }

        private void BindData()
        {
            set_report_detailes();
            tax_type_lbl.Text = "السعر شامل لقيمة الضريبة المضافة";
            cash_paied_lbl.Text = fatora_forms.ar_sell_fatora_checkout_form.cash_pay.ToString();
            date_tb.Text = DateTime.Now.ToString("dd-MM-yyyy");
            time_tb.Text = DateTime.Now.ToString("hh:mm:ss tt");
            qr_image.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(fatora_forms.ar_pos_uc.qr);
        }
        public static void print(System.Data.DataTable products_datasource, object main_datasource)
        {
            if (settings_files.main_settings.Default.invoice_print_type == 0)
            {
                en_pos_report invoice = new en_pos_report();
                invoice.DataSource = main_datasource;
                invoice.DetailReport.DataSource = products_datasource;
                invoice.BindData();
                invoice.PrinterName = settings_files.main_settings.Default.invoice_printer_name;
                invoice.Print();
            }
            else
            {
                en_pos_report invoice = new en_pos_report();
                invoice.DataSource = main_datasource;
                invoice.DetailReport.DataSource = products_datasource;
                invoice.BindData();
                invoice.PrinterName = settings_files.main_settings.Default.invoice_printer_name;
                invoice.ShowPreview();
            }


        }
    }
}
