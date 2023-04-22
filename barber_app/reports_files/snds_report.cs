using System.Windows.Forms;using DevExpress.XtraReports.UI;using System;
using ClientApp.classes;

namespace ClientApp.repost_pos
{
    public partial class snds_report : DevExpress.XtraReports.UI.XtraReport
    {
        public snds_report()
        {
            InitializeComponent();
        }
        public static void to_pdf(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            snds_report report = new snds_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "PDF|*.pdf";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            saveFileDialog.FileName = report.head_label.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToPdf(saveFileDialog.FileName);
        }
        public static void to_excel(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            snds_report report = new snds_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "Excel|*.xlsx";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            saveFileDialog.FileName = report.head_label.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToXlsx(saveFileDialog.FileName);
        }
        public static void to_word(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            snds_report report = new snds_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "Word|*.docx";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            saveFileDialog.FileName = report.head_label.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToDocx(saveFileDialog.FileName);
        }
        void set_report_detailes()
        {
            
            first_phone_label.Text = "الهاتف : " + ClientApp.settings_files.main_settings.Default.landline;
            second_phone_label.Text = "الجوال : " + ClientApp.settings_files.main_settings.Default.mobile;
            pharmacy_name_label.Text = ClientApp.settings_files.main_settings.Default.barber_name;
            logo_image.ImageUrl = ClientApp.settings_files.main_settings.Default.logo;
        }
        public static void print(System.Data.DataTable products_datasource, object main_datasource)
        {
            // 0 Direct
            if (ClientApp.settings_files.main_settings.Default.reports_print_type == 0)
            {
                snds_report report = new snds_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                snds_report report = new snds_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }

        void BindData()
        {
            set_report_detailes();
            from_date.Text = "من تاريخ : " + n_snds_forms.ar.ar_snds_report_form.from_date;
            to_date.Text = "إلى تاريخ : " + n_snds_forms.ar.ar_snds_report_form.to_date;
            if (n_snds_forms.ar.ar_snds_report_form.snd_type == "سند قبض")
                head_label.Text = "تقرير سندات القبض";
            else
                head_label.Text = "تقرير سندات الصرف";
        }


    }
}
