using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.Utils.Svg;
using ClientApp.classes;
using System.IO;
using DevExpress.XtraGrid.Columns;

namespace ClientApp.users_forms.en
{
    public partial class en_users_form : DevExpress.XtraEditors.XtraForm
    {
        public en_users_form()
        {
            InitializeComponent();
            if (settings_files.permissions_settings.Default.manage_users_roles == 0)
            {
                manage_roles_btn.Enabled = false;
            }
            if ((System.Windows.SystemParameters.PrimaryScreenWidth == 1366 || System.Windows.SystemParameters.PrimaryScreenWidth == 1360) && System.Windows.SystemParameters.PrimaryScreenHeight >= 720)
            {
                this.Height = this.Height - 100;
                this.Width = this.Width - 100;
                tableLayoutPanel2.Height = tableLayoutPanel2.Height - 20;
                label1.Font = new Font("Arial", 12, FontStyle.Bold);
                groupControl2.AppearanceCaption.Font = new Font("Arial", 9, FontStyle.Bold);
                groupControl17.AppearanceCaption.Font = new Font("Arial", 9, FontStyle.Bold);
            }
            my_grid_view_class.set_find_panel_font2(gridView1, grid_control, false, true);
            my_grid_view_class.set_font_and_hover_effect(gridView1);
            my_grid_view_class.show_empty_message2(gridView1);
        }

        int get_id()
        {
            DataTable table = connection_class.select("select isnull(max(user_id)+1,1) from users_table");
            return Convert.ToInt32(table.Rows[0][0]);
        }
        private void password_text_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (password_text.Properties.PasswordChar == '*')
                password_text.Properties.PasswordChar = '\0';
            else
                password_text.Properties.PasswordChar = '*';
        }
        void add_data()
        {
            Image image = user_pic.Image.Clone() as Image;
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            DataTable getStorageTable = connection_class.select($"select id from storage_table where storage_name=N'{storage_name_cb.Text}'");
            int storageID = Convert.ToInt32(getStorageTable.Rows[0][0]);
            int id = Convert.ToInt32(id_tb.Text);
            SqlCommand command = new SqlCommand("insert into users_table values (@id,@username,@password,@user_image,@storage_id)", connection_class.connection());
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@username", username_text.Text.Trim());
            command.Parameters.AddWithValue("@password", password_text.Text.Trim());
            command.Parameters.AddWithValue("@user_image", convert_class.image_to_byte(image));
            command.Parameters.AddWithValue("@storage_id", storageID);
            if (command.ExecuteNonQuery() == 1)
            {
                connection_class.command($"insert into roles_table (user_id) values ({id})");
                logs_class.log_add($"Add user with id {id}", id, "Users");
                run_worker_class.run(backgroundWorker1);
                notifications_class.success_message();
            }
            else
            {
                OmarNotifications.Alert.ShowInformation("Failed to add");
            }
        }
        void update_data()
        {
            try
            {
                Image image = user_pic.Image.Clone() as Image;
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                DataTable getStorageTable = connection_class.select($"select id from storage_table where storage_name=N'{storage_name_cb.Text}'");
                int storageID = Convert.ToInt32(getStorageTable.Rows[0][0]);
                SqlCommand command = new SqlCommand("update users_table set username=@user_name,password=@password,user_image=@user_image,storage_id=@storage_id", connection_class.connection());
                command.Parameters.AddWithValue("@user_id", Convert.ToInt32(id_tb.Text));
                command.Parameters.AddWithValue("@user_name", username_text.Text.Trim());
                command.Parameters.AddWithValue("@password", password_text.Text.Trim());
                command.Parameters.AddWithValue("@user_image", convert_class.image_to_byte(image));
                command.Parameters.AddWithValue("@storage_id", storageID);
                if (command.ExecuteNonQuery() == 1)
                {
                    if (old_username == const_variables_class.username)
                    {
                        settings_files.main_settings.Default.username = username_text.Text.Trim();
                        settings_files.main_settings.Default.userID = Convert.ToInt32(id_tb.Text);
                        settings_files.main_settings.Default.storage_id = storageID;
                        settings_files.main_settings.Default.Save();
                    }
                    const_variables_class.username = settings_files.main_settings.Default.username;
                    logs_class.log_add($"edit user with id {id_tb.Text}", Convert.ToInt32(id_tb.Text), "Users");
                    run_worker_class.run(backgroundWorker1);
                    classes.notifications_class.success_message();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("unique"))
                {
                    OmarNotifications.Alert.ShowError("Username already exists");
                    return;
                }
            }
        }
        bool check_if_every_thing_ok()
        {
            if (texts_class.is_null(username_text.Text.Trim()))
            {
                OmarNotifications.Alert.ShowInformation("Enter username");
                return false;
            }
            if (texts_class.is_null(password_text.Text))
            {
                OmarNotifications.Alert.ShowInformation("Enter password");
                return false;
            }
            if (username_text.Text.Trim().Trim().Length > 20 || password_text.Text.Trim().Length > 20)
            {
                OmarNotifications.Alert.ShowInformation("Username and password cannot be more than 20 char");
                return false;
            }
            if (storage_name_cb.SelectedIndex == -1)
            {
                OmarNotifications.Alert.ShowInformation("Select safe");
                return false;
            }

            return true;
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_if_every_thing_ok())
                {
                    add_data();
                }
            }
            catch (SqlException Ex)
            {
                if (Ex.Message.Contains("Cannot insert duplicate key"))
                {
                    OmarNotifications.Alert.ShowInformation("Username already exists");
                }
                else
                {
                    classes.notifications_class.my_messageBox(Ex.Message);
                }
            }
        }
        private void en_users_form_Load(object sender, EventArgs e)
        {
            run_worker_class.run(backgroundWorker1);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 1)
            {
                OmarNotifications.Alert.ShowInformation("Select one user");
                return;
            }
            if (texts_class.is_null(id_tb.Text))
            {
                notifications_class.select_data_message();
                return;
            }
            if (check_if_every_thing_ok())
            {
                DialogResult dr = notifications_class.my_messageBoxRightYesNo("Are you sure ?");
                if (dr == DialogResult.Yes)
                    update_data();
            }
        }
        DataTable storage_table;
        private void storage_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            storage_table = connection_class.select("select storage_name as 'Safe' from storage_table");
        }

        private void storage_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.comboBox_class.fill_combobox(storage_table, storage_name_cb);
            new_btn.PerformClick();
        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                user_pic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void delete_image_btn_Click(object sender, EventArgs e)
        {
            user_pic.Image = Properties.Resources.profile;
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            navigate_btn($"select * from users_table where user_id=(select min(user_id) from users_table)");

        }
        void clear_permissions(int userID)
        {
            connection_class.command($"delete from roles_table where user_id=N'{userID}'");
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount == 0)
                {
                    notifications_class.select_data_message();
                    return;
                }
                List<int> ids = new List<int>();
                if (gridView1.SelectedRowsCount == 1)
                {
                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        int id = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0].FieldName));
                        ids.Add(id);
                        if (ids.Contains(1))
                        {
                            OmarNotifications.Alert.ShowInformation("Cannot delete admin");
                            return;
                        }

                        else
                        {
                            DialogResult dr = notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                int userID = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0].FieldName));
                                string username = gridView1.GetRowCellValue(i, gridView1.Columns[1].FieldName).ToString();
                                if (username == const_variables_class.username)
                                {
                                    OmarNotifications.Alert.ShowInformation("Cannot delete current user");
                                    return;
                                }
                                connection_class.command($"Delete from users_table where user_id={id}");
                                clear_permissions(userID);
                                logs_class.log_add($"Delete user with id {id}", id, "Users");
                                run_worker_class.run(backgroundWorker1);
                                classes.notifications_class.success_message();
                            }
                        }
                    }
                }
                if (gridView1.SelectedRowsCount > 1)
                {
                    DialogResult dr = notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (int i in gridView1.GetSelectedRows())
                        {
                            int id = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns[0].FieldName));
                            ids.Add(id);
                            if (ids.Contains(1))
                            {
                                OmarNotifications.Alert.ShowInformation("Uncheck admin and try again");
                                break;
                            }
                            string username = gridView1.GetRowCellValue(i, gridView1.Columns[1].FieldName).ToString();
                            if (username == const_variables_class.username)
                            {
                                OmarNotifications.Alert.ShowInformation("Cannot delete current user");
                                return;
                            }
                            connection_class.command($"Delete from users_table where user_id={id}");
                            clear_permissions(id);
                            logs_class.log_add($"Delete user with id {id}", id, "Users");
                        }
                        run_worker_class.run(backgroundWorker1);
                        classes.notifications_class.success_message();
                    }
                }

            }
            catch (Exception ex)
            {
                classes.notifications_class.my_messageBox(ex.Message);
            }
        }
        DataTable users_table;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            users_table = connection_class.select(@"Select
user_id as 'ID'
,username 
,(select storage_name from storage_table where storage_table.id=users_table.storage_id) as 'Safe'
from users_table");
        }
        public static int userIDforRoles = 0;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            my_grid_view_class.set_datasource(grid_control, gridView1, users_table);
            run_worker_class.run(storage_worker);
            delete_image_btn.PerformClick();
        }
        void openForm(XtraForm form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.IconOptions.ShowIcon = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Text = "";
            form.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DevExpress);
            form.ShowDialog();
        }

        private void manage_roles_btn_Click(object sender, EventArgs e)
        {
            // if we didn`t select any user
            if (gridView1.SelectedRowsCount == 0)
            {
                OmarNotifications.Alert.ShowInformation("Select user first");
                return;
            }
            if (gridView1.SelectedRowsCount > 1)
            {
                OmarNotifications.Alert.ShowInformation("Select one user");
                return;
            }
            else
            {
                userIDforRoles = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridView1.Columns[0].FieldName));
                string username = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                en_user_permissions_form form = new en_user_permissions_form();
                form.top_label.Text = "Manage roles for user : " + username;
                openForm(form);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            repost_pos.en_users_report.print(my_grid_view_class.gridview_to_data_table(gridView1), null);
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            repost_pos.en_users_report.to_word(my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            repost_pos.en_users_report.to_excel(my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            repost_pos.en_users_report.to_pdf(my_grid_view_class.gridview_to_data_table(gridView1));
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            gridView1.ClearSelection();
            storage_name_cb.Enabled = true;
            username_text.Text = string.Empty;
            password_text.Text = string.Empty;
            id_tb.Text = get_id().ToString();
            save_btn.Enabled = true;
            update_btn.Enabled = delete_btn.Enabled = false;
            user_pic.Image = Properties.Resources.profile;
        }
        void navigate_btn(string query)
        {
            DataTable table = connection_class.select(query);
            if (table.Rows.Count == 0)
            {
                DataTable table1 = connection_class.select("select * from users_table");
                if (table1.Rows.Count == 0)
                {
                    OmarNotifications.Alert.ShowInformation("No Data!");
                    return;
                }
            }
            else
            {
                int id = Convert.ToInt32(table.Rows[0]["user_id"]);
                id_tb.Text = id.ToString();
                username_text.Text = table.Rows[0]["username"].ToString();
                password_text.Text = table.Rows[0]["password"].ToString();
                storage_name_cb.Text = table.Rows[0]["storage_name"].ToString();
                byte[] photo_aray = (byte[])table.Rows[0]["user_image"];
                MemoryStream ms = new MemoryStream(photo_aray);
                Image image = Image.FromStream(ms);
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                user_pic.Image = image;
            }
            delete_btn.Enabled = true;
            update_btn.Enabled = true;
            save_btn.Enabled = false;
            old_username = username_text.Text.Trim();
        }
        string old_username = "";
     

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridView1.Columns[0].FieldName));
                navigate_btn($"select user_id,username,password,user_image,(select storage_name from storage_table where storage_table.id=users_table.storage_id) as storage_name from users_table where user_id={id}");
            }
            if (gridView1.SelectedRowsCount == 0)
            {
                delete_btn.Enabled = false;
                update_btn.Enabled = false;
                save_btn.Enabled = true;
                new_btn.PerformClick();
            }
        }
        private void storage_name_cb_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                openForm(new storages_forms.ar_storages_form());
                run_worker_class.run(storage_worker);
            }
        }
        private void en_users_form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}