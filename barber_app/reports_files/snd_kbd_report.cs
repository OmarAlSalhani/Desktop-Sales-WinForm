using DevExpress.XtraReports.UI;using System;
using ClientApp.classes;
using System.Windows.Forms;

namespace ClientApp.repost_pos
{
    public partial class snd_kbd_report : DevExpress.XtraReports.UI.XtraReport
    {
        public snd_kbd_report()
        {
            InitializeComponent();
        }
        void set_report_detailes()
        {
            drebe_number_label.Text = "الرقم الضريبي : " + settings_files.main_settings.Default.tax_number;
            first_phone_label.Text = "الهاتف : " + settings_files.main_settings.Default.landline;
            second_phone_label.Text = "الجوال : " + settings_files.main_settings.Default.mobile;
           pharmacy_name_label.Text = settings_files.main_settings.Default.barber_name;address_label.Text = "";
            logo_image.ImageUrl = settings_files.main_settings.Default.logo;
        }

        void BindData()
        {
            set_report_detailes();
            name_lbl.Text = customers_forms.ar_customers_mdeonee_form.the_name;
            money_lbl.Text = customers_forms.ar_customers_mdeonee_form.the_money + " "+ "ر.س";
            datetime_lbl.Text = customers_forms.ar_customers_mdeonee_form.date_time;
            detailes_lbl.Text = "الفواتير بالأرقام [ " + customers_forms.ar_customers_mdeonee_form.the_fatora_numbers + " ] ";
            n2c_text.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(customers_forms.ar_customers_mdeonee_form.the_money),"ريال سعودي", "");

        }


        public static void to_pdf(System.Data.DataTable products_datasource)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            snd_kbd_report report = new snd_kbd_report();
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

            snd_kbd_report report = new snd_kbd_report();
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
            snd_kbd_report report = new snd_kbd_report();
            report.DetailReport.DataSource = products_datasource;
            report.BindData();
            report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
            saveFileDialog.Filter = "Word|*.docx";
            if (products_datasource.Rows.Count == 0) { notifications_class.no_data_message(); return; }
            saveFileDialog.FileName = report.head_label.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                report.ExportToDocx(saveFileDialog.FileName);
        }
        public static void print(System.Data.DataTable products_datasource, object main_datasource)
        {
            // 0 Direct
            if (ClientApp.settings_files.main_settings.Default.reports_print_type == 0)
            {
                snd_kbd_report report = new snd_kbd_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                snd_kbd_report report = new snd_kbd_report();
                report.DetailReport.DataSource = products_datasource;
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }
    }
}
