using System.Windows.Forms;using DevExpress.XtraReports.UI;using System;using ClientApp.classes;

namespace ClientApp.repost_pos
{
    public partial class logs_report : DevExpress.XtraReports.UI.XtraReport
    {
        public logs_report()
        {
            InitializeComponent();
        }
        public static void to_pdf(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            logs_report report = new logs_report();
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

            logs_report report = new logs_report();
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
            logs_report report = new logs_report();
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
        void BindData()
        {
            set_report_detailes();
        }
        public static void print(System.Data.DataTable products_datasource, object main_datasource)
        {
            // 0 Direct
            if (ClientApp.settings_files.main_settings.Default.reports_print_type == 0)
            {
                logs_report report = new logs_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                logs_report report = new logs_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }
    }
}
