using DevExpress.XtraPrinting;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System;
using ClientApp.classes;
using ClientApp.settings_files;

namespace ClientApp.repost_pos
{
    public partial class en_ash3ar_report : DevExpress.XtraReports.UI.XtraReport
    {
        public en_ash3ar_report()
        {
            InitializeComponent();
        }
        void set_report_detailes()
        {
            drebe_number_label.Text = "Tax Number : " + settings_files.main_settings.Default.tax_number;
            first_phone_label.Text = "Landline : " + settings_files.main_settings.Default.landline;
            second_phone_label.Text = "Mobile : " + settings_files.main_settings.Default.mobile;
            pharmacy_name_label.Text = settings_files.main_settings.Default.barber_name; address_label.Text = "";
            logo_image.ImageUrl = settings_files.main_settings.Default.logo;
        }

        void BindData()
        {
            set_report_detailes();
        }

        public static void print(System.Data.DataTable products_datasource)
        {
            if (settings_files.main_settings.Default.invoice_print_type == 0)
            {
                en_ash3ar_report report = new en_ash3ar_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = settings_files.main_settings.Default.invoice_printer_name;
                report.Print();
            }
            else
            {
                en_ash3ar_report report = new en_ash3ar_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = settings_files.main_settings.Default.invoice_printer_name;

                report.ShowPreview();
            }
        }
    }
}
