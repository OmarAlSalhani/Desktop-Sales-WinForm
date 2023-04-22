using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Linq;
using System.Windows.Forms;
using ClientApp.classes;
using DevExpress.XtraPrinting.Drawing;

namespace ClientApp.repost_pos
{
    public partial class ard_s3r_report : DevExpress.XtraReports.UI.XtraReport
    {
        public ard_s3r_report()
        {
            InitializeComponent();
            
        }
        public static void to_pdf(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            ard_s3r_report report = new ard_s3r_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "PDF|*.pdf";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToPdf(saveFileDialog.FileName);
        }
        public static void to_excel(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            ard_s3r_report report = new ard_s3r_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "Excel|*.xlsx";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToXlsx(saveFileDialog.FileName);
        }
        public static void to_word(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            ard_s3r_report report = new ard_s3r_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "Word|*.docx";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToDocx(saveFileDialog.FileName);
        }
        void set_report_detailes()
        {
            company_name_tb.Text = settings_files.main_settings.Default.barber_name.Length!=0? ClientApp.settings_files.main_settings.Default.barber_name:"";
            en_company_name_tb.Text = settings_files.main_settings.Default.en_barber_name.Length!=0? ClientApp.settings_files.main_settings.Default.en_barber_name : "";
            company_tax_number_tb.Text = settings_files.main_settings.Default.tax_number.Length!=0? "الرقم الضريبي-tax number : " + ClientApp.settings_files.main_settings.Default.tax_number:"";
            company_address_tb.Text = settings_files.main_settings.Default.town.Length!=0? "العنوان-address : " + ClientApp.settings_files.main_settings.Default.country + "-" + ClientApp.settings_files.main_settings.Default.town + "-" + ClientApp.settings_files.main_settings.Default.al7e:"";
            company_sgl_tb.Text = settings_files.main_settings.Default.sgl_number.Length!=0? "السجل التجاري-commercial register : " + ClientApp.settings_files.main_settings.Default.sgl_number:"";
            logo_image.ImageUrl = ClientApp.settings_files.main_settings.Default.logo;
            the_street_tb.Text = settings_files.main_settings.Default.street.Length!=0? "الشارع-street : " + settings_files.main_settings.Default.street:"";
            building_tb.Text = settings_files.main_settings.Default.building_number.Length!=0? "المبنى-building : " + settings_files.main_settings.Default.building_number:"";
            extra_number_tb.Text = settings_files.main_settings.Default.second_mobile.Length!=0? "الرقم الاضافي-mobile2 : " + settings_files.main_settings.Default.second_mobile:"";
           
            notes_tb.Text = fatora_forms.ard_s3r_uc.note.Length!=0? fatora_forms.ard_s3r_uc.note : "";
            id_tb.Text ="رقم العرض - No : "+ fatora_forms.ard_s3r_uc.FatoraID.ToString();
            date_tb.Text ="تاريخ العرض - Date : "+ fatora_forms.ard_s3r_uc.the_date;
            tax_tb.Text = fatora_forms.ard_s3r_uc.taxForPrint.ToString();
            total_tb.Text = fatora_forms.ard_s3r_uc.totalForPrint.ToString();

            customer_name_tb.Text = fatora_forms.ar_pos_uc.customer_name.Length != 0 ? "بيانات العميل - Customer detailes : " + fatora_forms.ar_pos_uc.customer_name : "";
            customer_tax_number_tb.Text = fatora_forms.ar_pos_uc.customer_tax_number.Length != 0 ? "الرقم الضريبي-tax number : " + fatora_forms.ar_pos_uc.customer_tax_number : "";
            customer_address_tb.Text = fatora_forms.ar_pos_uc.customer_address.Length > 2 ? "العنوان-address : " + fatora_forms.ar_pos_uc.customer_address : "";
            customer_street_tb.Text = fatora_forms.ar_pos_uc.customer_street.Length != 0 ? "الشارع-street : " + fatora_forms.ar_pos_uc.customer_street : "";
            customer_building_tb.Text = fatora_forms.ar_pos_uc.customer_building.Length != 0 ? "المبنى-building : " + fatora_forms.ar_pos_uc.customer_building : "";
            customer_extra_number_tb.Text = fatora_forms.ar_pos_uc.customer_second_number.Length != 0 ? "الرقم الاضافي-mobile2 : " + fatora_forms.ar_pos_uc.customer_second_number : "";

        }
        void BindData()
        {
            set_report_detailes();
        }
        public static void print(System.Data.DataTable products_datasource, object main_datasource)
        {
            // 0 Direct
            if (ClientApp.settings_files.main_settings.Default.invoice_print_type == 0)
            {
                ard_s3r_report report = new ard_s3r_report();
                report.DataSource = main_datasource;
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                ard_s3r_report report = new ard_s3r_report();
                report.DataSource = main_datasource;
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }


    }
}
