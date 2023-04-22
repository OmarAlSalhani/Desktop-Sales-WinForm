using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using ClientApp.classes;
using ClientApp.settings_files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class activate_form : DevExpress.XtraEditors.XtraForm
    {
        public activate_form()
        {
            InitializeComponent();
            run_worker_class.run(FillWorker);

        }
        string serial;
        private void FillWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            serial = get_pc_information_class.get_cpu();
        }

        private void FillWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            serial_tb.Text = serial;
        }

        private void activate_form_Load(object sender, EventArgs e)
        {
         
        }
      
        private void show_report_btn_Click(object sender, EventArgs e)
        {

        }
        public static string from_date, to_date;
        private void print_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
         
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int date = DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
            string the_serial = serial_tb.Text;
            string code = the_serial + date.ToString();
            if(code==activate_tb.Text)
            {
                settings_files.main_settings.Default.is_activated = true;
                settings_files.main_settings.Default.Save();
                notifications_class.my_messageBox("تم التفعيل بنجاح\nيرجى أعادة تشغيل البرنامج");
                Application.Exit();
            }

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(serial_tb.Text);

        }

        private void employees_cb_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }
    }
}
