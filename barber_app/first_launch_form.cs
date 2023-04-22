using ClientApp.classes;
using ClientApp.settings_files;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class first_launch_form : DevExpress.XtraEditors.XtraForm
    {
        public first_launch_form()
        {
            InitializeComponent();
            set_default_values_for_settings_files();
        }
        bool check_connection()
        {
            SqlConnection connection = new SqlConnection();
            if (remote_connection_cb.SelectedIndex == 0)
            {
                connection = new SqlConnection($@"Server={settings_files.database_settings.Default.server_name}" +
                                         ";Database=client_database" +
                                        ";User Id="
                                        + settings_files.database_settings.Default.username +
                                        ";Password="
                                        + settings_files.database_settings.Default.password +
                                        ";MultipleActiveResultSets=true;Max Pool Size=10000;Pooling=true;");

            }
            if (remote_connection_cb.SelectedIndex == 1)
            {
                connection = new SqlConnection($@"Server={settings_files.database_settings.Default.server_name}" +
                               $";Database=client_database" +
                               ";Trusted_Connection=true;MultipleActiveResultSets=true;Max Pool Size=10000;Pooling=true;");
            }
            connection.Open();
            if (connection.State != ConnectionState.Open)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void clear_database()
        {
            connection_class.sp_command_noPara("Clean");
        }
        void set_default_values_for_settings_files()
        {
            settings_files.main_settings.Default.Reset();
            main_settings.Default.Save();
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
            if (texts_class.is_null(server_tb.Text.Trim()))
            {
                OmarNotifications.Alert.ShowInformation("الرجاء إدخال إسم السيرفر");
                return false;
            }
            if (remote_connection_cb.SelectedIndex == 0)
            {
                if (texts_class.is_null(username_tb.Text.Trim()))
                {
                    OmarNotifications.Alert.ShowInformation("الرجاء إدخال إسم المستخدم");
                    return false;
                }
                if (texts_class.is_null(password_tb.Text.Trim()))
                {
                    OmarNotifications.Alert.ShowInformation("الرجاء إدخال كلمة المرور");
                    return false;
                }
            }
            return true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_if_every_thing_ok())
                {
                    main_settings.Default.barber_name = barber_name_tb.Text.Trim();
                    main_settings.Default.tax_value = Convert.ToDouble(tax_value_cb.Text.Replace("%", ""));
                    main_settings.Default.reports_print_type = Convert.ToInt32(reports_print_type_cb.SelectedIndex);
                    main_settings.Default.invoice_print_type = Convert.ToInt32(invoice_print_type_cb.SelectedIndex);
                    main_settings.Default.tax_number = tax_number_tb.Text.Trim();
                    main_settings.Default.mobile = mobile_tb.Text.Trim();
                    main_settings.Default.landline = landline_tb.Text.Trim();
                    main_settings.Default.logo = openFileDialog1.FileName.Trim().Length == 0 ? "" : openFileDialog1.FileName;
                    database_settings.Default.server_name = server_tb.Text.Trim();
                    database_settings.Default.trusted_connection = 1;
                    if (remote_connection_cb.SelectedIndex == 0)
                    {
                        database_settings.Default.username = username_tb.Text.Trim();
                        database_settings.Default.password = password_tb.Text.Trim();
                        database_settings.Default.trusted_connection = 0;
                    }
                    database_settings.Default.Save();
                    save_btn.Text = "الرجاء الأنتظار";
                    save_btn.Enabled = false;
                    if (check_connection() == false)
                    {
                        notifications_class.my_messageBox("لم يتم الإتصال بقاعدة البيانات\nالرجاء التأكد من أدخال الأعدادات بشكل صحيح وإعادة المحاولة من جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        save_btn.Enabled = true;
                        save_btn.Text = "حفظ";
                        return;
                    }
                    main_settings.Default.first_run = false;
                    main_settings.Default.Save();
                    clear_database();
                    notifications_class.my_messageBox("تم حفظ الإعدادات بنجاح\nيرجى تشغيل البرنامج من جديد");
                    Application.Exit();
                }
            }
            catch (Exception Ex)
            {
                if (Ex.Message.Contains("Cannot open database"))
                {
                    classes.notifications_class.my_messageBox("لم يتم الإتصال بقاعدة البيانات\nالرجاء التأكد من أدخال الأعدادات بشكل صحيح وإعادة المحاولة من جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Ex.Message.Contains("The server was not found"))
                {
                    classes.notifications_class.my_messageBox("لم يتم الإتصال بقاعدة البيانات\nالرجاء التأكد من أدخال إسم السيرفر بشكل صحيح وإعادة المحاولة من جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    notifications_class.my_messageBox(Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                save_btn.Enabled = true;
                save_btn.Text = "حفظ";
            }
        }
        private void remote_connection_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (remote_connection_cb.SelectedIndex == 0)
            {
                username_tb.ReadOnly = password_tb.ReadOnly = false;
                username_tb.Properties.TextEditStyle = password_tb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            else
            {
                username_tb.ReadOnly = password_tb.ReadOnly = true;
                username_tb.Properties.TextEditStyle = password_tb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            }
            username_tb.Text = password_tb.Text = "";
        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logo_pic.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else return;
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            logo_pic.Image = Properties.Resources.thelogo;
        }

        private void open_page_btn_Click(object sender, EventArgs e)
        {
            if (navigationFrame1.SelectedPage == main_page)
            {
                navigationFrame1.SelectedPage = server_page;
                open_page_btn.Text = "الإعدادات العامة";
            }
            else
            {
                navigationFrame1.SelectedPage = main_page;
                open_page_btn.Text = "إعدادات الإتصال بقاعدة البيانات";
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void first_launch_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void first_launch_form_Load(object sender, EventArgs e)
        {
            main_settings.Default.first_run = true;
            main_settings.Default.is_activated = false;
            main_settings.Default.Save();
        }

        private void pic_upload_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                logo_pic.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else return;
        }

        private void pic_delete_btn_Click(object sender, EventArgs e)
        {
            logo_pic.Image = Properties.Resources.thelogo;
        }
    }
}