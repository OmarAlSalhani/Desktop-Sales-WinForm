using ClientApp.classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ClientApp.users_forms.en
{
    public partial class en_user_permissions_form : DevExpress.XtraEditors.XtraForm
    {
        public en_user_permissions_form()
        {
            InitializeComponent();

        }
        int userID;
        int checkbox_to_int(CheckBox checkBox)
        {
            if (checkBox.Checked)
                return 1;
            else
                return 0;
        }
        bool table_cell_to_int(string table_column)
        {
            int a = Convert.ToInt32(table_column);
            if (a == 0)
                return false;
            else
                return true;
        }
        void get_roles()
        {
            DataTable table = connection_class.select($"select * from roles_table where user_id={userID}");
            manage_customers.Checked = table_cell_to_int(table.Rows[0]["manage_customers"].ToString());
            customers_kshf_7sab.Checked = table_cell_to_int(table.Rows[0]["customers_kshf_7sab"].ToString());
            customers_mdeonee.Checked = table_cell_to_int(table.Rows[0]["customers_mdeonee"].ToString());
            customers_paied_money.Checked = table_cell_to_int(table.Rows[0]["customers_paied_money"].ToString());
            open_pos.Checked = table_cell_to_int(table.Rows[0]["open_pos"].ToString());
            sales_report.Checked = table_cell_to_int(table.Rows[0]["sales_report"].ToString());
            manage_settings.Checked = table_cell_to_int(table.Rows[0]["manage_settings"].ToString());
            manage_storages.Checked = table_cell_to_int(table.Rows[0]["manage_storages"].ToString());
            storages_operations.Checked = table_cell_to_int(table.Rows[0]["storages_operations"].ToString());
            manage_users.Checked = table_cell_to_int(table.Rows[0]["manage_users"].ToString());
            manage_users_roles.Checked = table_cell_to_int(table.Rows[0]["manage_users_roles"].ToString());
            manage_blackbox.Checked = table_cell_to_int(table.Rows[0]["manage_blackbox"].ToString());
            snd_qbd.Checked = table_cell_to_int(table.Rows[0]["snd_qbd"].ToString());
            snd_srf.Checked = table_cell_to_int(table.Rows[0]["snd_srf"].ToString());
            snds_report.Checked = table_cell_to_int(table.Rows[0]["snds_report"].ToString());
            manage_daily_brief.Checked = table_cell_to_int(table.Rows[0]["manage_daily_brief"].ToString());
            manage_today_agle.Checked = table_cell_to_int(table.Rows[0]["manage_today_agle"].ToString());
        }
        void update_roles()
        {
            connection_class.command($@"
update roles_table set
manage_customers={checkbox_to_int(manage_customers)},
customers_kshf_7sab={checkbox_to_int(customers_kshf_7sab)},
customers_mdeonee={checkbox_to_int(customers_mdeonee)},
customers_paied_money={checkbox_to_int(customers_paied_money)},
open_pos={checkbox_to_int(open_pos)},
sales_report={checkbox_to_int(sales_report)},
manage_products=1,
manage_categories=1,
manage_settings={checkbox_to_int(manage_settings)},
manage_storages={checkbox_to_int(manage_storages)},
storages_operations={checkbox_to_int(storages_operations)},
manage_users={checkbox_to_int(manage_users)},
manage_users_roles={checkbox_to_int(manage_users_roles)},
manage_blackbox={checkbox_to_int(manage_blackbox)},
snd_qbd={checkbox_to_int(snd_qbd)},
snd_srf={checkbox_to_int(snd_srf)},
snds_report={checkbox_to_int(snds_report)},
manage_daily_brief={checkbox_to_int(manage_daily_brief)},
manage_today_agle={checkbox_to_int(manage_today_agle)}
where user_id={userID}
");
        }

        private void en_user_permissions_form_Load(object sender, EventArgs e)
        {
            userID = ar_users_form.userIDforRoles;
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            get_roles();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            userID = ar_users_form.userIDforRoles;
            update_roles();
            notifications_class.success_message();

        }
    }
}