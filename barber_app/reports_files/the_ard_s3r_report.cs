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
    public partial class the_ard_s3r_report : DevExpress.XtraReports.UI.XtraReport
    {
        public the_ard_s3r_report()
        {
            InitializeComponent();
            
        }
        public static void to_pdf(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            the_ard_s3r_report report = new the_ard_s3r_report();
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

            the_ard_s3r_report report = new the_ard_s3r_report();
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
            the_ard_s3r_report report = new the_ard_s3r_report();
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
            company_tax_number_tb.Text = settings_files.main_settings.Default.tax_number.Length!=0? "VAT : " + ClientApp.settings_files.main_settings.Default.tax_number:"";
            company_address_tb.Text ="OFFICE ADDRESS : \n" + settings_files.main_settings.Default.building_number+" - "+ settings_files.main_settings.Default.street+" - "+ ClientApp.settings_files.main_settings.Default.al7e+" - "+ClientApp.settings_files.main_settings.Default.town+" - "+ ClientApp.settings_files.main_settings.Default.country;
            company_email.Text = settings_files.main_settings.Default.email.Length!=0? "Email : " + ClientApp.settings_files.main_settings.Default.email : "";
            logo_image.ImageUrl = ClientApp.settings_files.main_settings.Default.logo;
            extra_number_tb.Text = "CONTACT : "+settings_files.main_settings.Default.landline+" OR "+settings_files.main_settings.Default.mobile;
            if(fatora_forms.ar_pos_uc.customer_tax_number.Length==0)
            {
                customer_vat_row.Visible = false;
            }
            if (fatora_forms.ar_pos_uc.customer_address.Length == 0)
            {
                customer_address_row.Visible = false;
            }
            if (fatora_forms.ar_pos_uc.customer_email.Length == 0)
            {
                customer_email_row.Visible = false;
            }
            if (fatora_forms.ar_pos_uc.customer_second_number.Length == 0)
            {
                customer_second_row.Visible = false;
            }
            string ename = fatora_forms.ar_pos_uc.en_name.Length == 0 ? "" : "M/s " + fatora_forms.ar_pos_uc.en_name;
            customer_name_tb.Text = fatora_forms.ar_pos_uc.customer_name.Length != 0 ? "M/s " + fatora_forms.ar_pos_uc.customer_name + "\n" + ename : "";
            customer_tax_number_tb.Text = fatora_forms.ar_pos_uc.customer_tax_number.Length != 0 ?  fatora_forms.ar_pos_uc.customer_tax_number : "";
            customer_address_tb.Text = fatora_forms.ar_pos_uc.customer_address.Length >2 ?fatora_forms.ar_pos_uc.customer_address+" - "+fatora_forms.ar_pos_uc.customer_street+" - "+fatora_forms.ar_pos_uc.customer_building : "";
            customer_second_mobile_tb.Text =  fatora_forms.ar_pos_uc.customer_second_number;
            customer_email_tb.Text =  fatora_forms.ar_pos_uc.customer_email;
            footer_tb.Text = fatora_forms.ar_pos_uc.Footer is null?"": fatora_forms.ar_pos_uc.Footer;

            footer_tb.Text = fatora_forms.ard_s3r_uc.note.Length != 0 ? fatora_forms.ard_s3r_uc.note : "";
            id_tb.Text = fatora_forms.ard_s3r_uc.FatoraID.ToString();
            date_tb.Text =  fatora_forms.ard_s3r_uc.the_date;
            tax_tb.Text = fatora_forms.ard_s3r_uc.taxForPrint.ToString();
            total_without_tax_tb.Text = fatora_forms.ard_s3r_uc.totalWithoutTaxPrint.ToString();
            total_tb.Text = fatora_forms.ard_s3r_uc.totalForPrint.ToString();
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
                the_ard_s3r_report report = new the_ard_s3r_report();
                report.DataSource = main_datasource;
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                the_ard_s3r_report report = new the_ard_s3r_report();
                report.DataSource = main_datasource;
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }
        public static void print(System.Data.DataTable products_datasource, object main_datasource,bool direct_print)
        {
            // 0 Direct
            if (direct_print)
            {
                the_ard_s3r_report report = new the_ard_s3r_report();
                report.DataSource = main_datasource;
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                the_ard_s3r_report report = new the_ard_s3r_report();
                report.DataSource = main_datasource;
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }


    }
}
