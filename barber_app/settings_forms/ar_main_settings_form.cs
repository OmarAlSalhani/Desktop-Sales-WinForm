using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ClientApp.classes;
using ClientApp.settings_files;

namespace ClientApp.n_settings_forms.ar
{

    public partial class ar_main_settings_form : DevExpress.XtraEditors.XtraForm
    {
        public ar_main_settings_form()
        {
            InitializeComponent();
            get_printers();
        }
        void get_printers()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                invoice_printer_name_cb.Properties.Items.Add(printer);
                invoice_printer_name_cb.Properties.Items.Remove("Microsoft XPS Document Writer");
                invoice_printer_name_cb.SelectedIndex = 0;

                report_printer_name_cb.Properties.Items.Add(printer);
                report_printer_name_cb.Properties.Items.Remove("Microsoft XPS Document Writer");
                report_printer_name_cb.SelectedIndex = 0;
            }
        }
        void info_message(string message)
        {
            OmarNotifications.Alert.ShowInformation(message);
        }
        bool check_if_every_thing_ok()
        {
            if (barber_name_tb.Text.Trim().Length == 0)
            {
                info_message("الرجاء إدخال أسم المحل");
                return false;
            }
            if (mobile_tb.Text.Trim().Length == 0)
            {
                info_message("الرجاء إدخال رقم الجوال");
                return false;
            }
           
            if (invoice_print_type_cb.SelectedIndex == -1)
            {
                info_message("الرجاء أختيار طريقة طباعة الفاتورة");
                return false;
            }
            if (reports_print_type_cb.SelectedIndex == -1)
            {
                info_message("الرجاء أختيار طريقة طباعة التقرير");
                return false;
            }

            return true;
        }
        private void ar_main_settings_form_Load(object sender, EventArgs e)
        {
            try
            {
                barber_name_tb.Text = main_settings.Default.barber_name;
                email_tb.Text = main_settings.Default.email;
                en_barber_name_tb.Text = main_settings.Default.en_barber_name;
                tax_value_cb.Text = main_settings.Default.tax_value.ToString() + " %";
                reports_print_type_cb.SelectedIndex = main_settings.Default.reports_print_type;
                invoice_print_type_cb.SelectedIndex = main_settings.Default.invoice_print_type;
                tax_number_tb.Text = main_settings.Default.tax_number;
                second_mobile_tb.Text = main_settings.Default.second_mobile;
                sgl_number_tb.Text = main_settings.Default.sgl_number;
                building_number_tb.Text = main_settings.Default.building_number;
                street_tb.Text = main_settings.Default.street;
                al7e_tb.Text = main_settings.Default.al7e;
                town_tb.Text = main_settings.Default.town;
                country_tb.Text = main_settings.Default.country;
                mobile_tb.Text = main_settings.Default.mobile;
                landline_tb.Text = main_settings.Default.landline;
                logo_pic.Image = main_settings.Default.logo.Trim().Length == 0 || main_settings.Default.logo == "openFileDialog1" ? null : Image.FromFile(main_settings.Default.logo);
                invoice_printer_name_cb.Text = main_settings.Default.invoice_printer_name;
                report_printer_name_cb.Text = main_settings.Default.reports_printer_name;
                language_cb.Text = main_settings.Default.language == "en" ? "أنكليزي" : "عربي";
            }
            catch
            {
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_if_every_thing_ok())
                {
                    main_settings.Default.barber_name = barber_name_tb.Text.Trim();
                    main_settings.Default.email = email_tb.Text.Trim();
                    main_settings.Default.en_barber_name = en_barber_name_tb.Text.Trim();
                    main_settings.Default.tax_value = Convert.ToDouble(tax_value_cb.Text.Replace("%", ""));
                    main_settings.Default.reports_print_type = Convert.ToInt32(reports_print_type_cb.SelectedIndex);
                    main_settings.Default.invoice_print_type = Convert.ToInt32(invoice_print_type_cb.SelectedIndex);
                    main_settings.Default.tax_number = tax_number_tb.Text.Trim();
                    main_settings.Default.mobile = mobile_tb.Text.Trim();
                    main_settings.Default.second_mobile = second_mobile_tb.Text.Trim();
                    main_settings.Default.sgl_number = sgl_number_tb.Text.Trim();
                    main_settings.Default.building_number = building_number_tb.Text.Trim();
                    main_settings.Default.street = street_tb.Text.Trim();
                    main_settings.Default.al7e = al7e_tb.Text.Trim();
                    main_settings.Default.country = country_tb.Text.Trim();
                    main_settings.Default.town = town_tb.Text.Trim();
                    main_settings.Default.landline = landline_tb.Text.Trim();
                    main_settings.Default.logo = openFileDialog1.FileName.Trim().Length == 0 ? "" : openFileDialog1.FileName;
                    main_settings.Default.invoice_printer_name = invoice_printer_name_cb.Text;
                    main_settings.Default.reports_printer_name = report_printer_name_cb.Text;
                    main_settings.Default.language = language_cb.Text=="أنكليزي"?"en":"ar";
                    main_settings.Default.Save();
                    notifications_class.success_message();
                    logs_class.log_add("تغيير الإعدادات العامة", 0, "الإعدادات");
                }
            }
            catch (Exception Ex)
            {
                classes.notifications_class.my_messageBox(Ex.Message);
            }
        }

        private void pic_upload_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logo_pic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pic_delete_btn_Click(object sender, EventArgs e)
        {
            logo_pic.Image = null;
        }
    }
}