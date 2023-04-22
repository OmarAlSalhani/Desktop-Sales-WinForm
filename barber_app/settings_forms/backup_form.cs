using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ClientApp.classes;
using ClientApp.settings_files;
using Microsoft.SqlServer.Management.Smo;

namespace ClientApp.n_settings_forms.ar
{

    public partial class backup_form : DevExpress.XtraEditors.XtraForm
    {
        public backup_form()
        {
            InitializeComponent();
        }
        void info_message(string message)
        {
            OmarNotifications.Alert.ShowInformation(message);
        }

        private void db_folder_text_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.StartsWith("C:"))
                {
                    classes.notifications_class.my_messageBox($"لا يمكن أجراء النسخ الأحتياطي على القرص الخاص بالنظام\nالرجاء أختيار قرص آخر", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                db_folder_text.Text = folderBrowserDialog1.SelectedPath;
                settings_files.main_settings.Default.backup_folder = db_folder_text.Text;
                settings_files.main_settings.Default.Save();
            }
        }

        private void add_to_backup_grid_btn_Click(object sender, EventArgs e)
        {
            if (texts_class.is_null(db_folder_text.Text))
            {
                OmarNotifications.Alert.ShowInformation("الرجاء إختيار مجلد النسخ الأحتياطي");
                return;
            }
            DataTable table = connection_class.select("select isnull(max(id)+1,1) from backup_scheduale_table");
            int id = Convert.ToInt32(table.Rows[0][0]);
            string time = backup_time.Time.ToString("hh:mm tt");
            string folder = db_folder_text.Text;

            DataTable check_table = connection_class.select($"select * from backup_scheduale_table where the_time=N'{time}'");
            for (int i = 0; i < check_table.Rows.Count; i++)
            {
                if (check_table.Rows.Count != 0)
                {
                    OmarNotifications.Alert.ShowInformation("التوقيت مجدول مسبقاً");
                    return;
                }
            }
            connection_class.command($"insert into backup_scheduale_table values({id},N'{time}',N'{folder}')");
            update_backup_grid();
            notifications_class.success_message();
            settings_files.main_settings.Default.backup_folder = folder;
            settings_files.main_settings.Default.Save();
        }

        void update_backup_grid()
        {
            DataTable table = connection_class.select($"select id as 'الرقم',the_time as 'الوقت',the_folder as 'المجلد' from backup_scheduale_table");
            my_grid_view_class.set_datasource(backup_gridcontrol, backup_gridview, table);
        }
        private void delete_backup_btn_Click(object sender, EventArgs e)
        {
            if (backup_gridview.SelectedRowsCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("يرجى تحديد البيانات أولاً");
                return;
            }
            DialogResult dr = notifications_class.my_messageBoxRightYesNo("هل تريد تأكيد الحذف ؟");
            if (dr == DialogResult.Yes)
            {
                foreach (int i in backup_gridview.GetSelectedRows())
                {
                    int id = Convert.ToInt32(backup_gridview.GetRowCellValue(i, backup_gridview.Columns[0].FieldName));
                    connection_class.command($"delete from backup_scheduale_table where id={id}");
                }
                update_backup_grid();
                notifications_class.success_message();
            }
        }

        private void backup_form_Load(object sender, EventArgs e)
        {
            db_folder_text.Text = settings_files.main_settings.Default.backup_folder;
            update_backup_grid();
        }
    }
}