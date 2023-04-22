using System.Windows.Forms;using DevExpress.XtraReports.UI;using System;
using ClientApp.classes;

namespace ClientApp.repost_pos
{
    public partial class snd_srf_report2 : DevExpress.XtraReports.UI.XtraReport
    {
        public snd_srf_report2()
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
            snd_type_lbl.Text = n_snds_forms.ar.ar_snd_qbd_form.theName;
            snd_id_lbl.Text = n_snds_forms.ar.ar_snd_srf_form.theId;
            money_lbl.Text = n_snds_forms.ar.ar_snd_srf_form.theValue;
            date_lbl.Text = n_snds_forms.ar.ar_snd_srf_form.theDate;
            notes_lbl.Text = n_snds_forms.ar.ar_snd_srf_form.theNotes;
            n2c_text.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(n_snds_forms.ar.ar_snd_srf_form.theValue), "ريال سعودي", "هللة");
            pay_method_tb.Text= n_snds_forms.ar.ar_snd_srf_form.payMethod;
        }

        public static void print()
        {
            // 0 Direct
            if (ClientApp.settings_files.main_settings.Default.reports_print_type == 0)
            {
                snd_srf_report2 report = new snd_srf_report2();
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.Print();
            }
            else
            {
                snd_srf_report2 report = new snd_srf_report2();
                report.BindData();
                report.PrinterName = ClientApp.settings_files.main_settings.Default.reports_printer_name;
                report.ShowPreview();
            }

        }
    }
}
