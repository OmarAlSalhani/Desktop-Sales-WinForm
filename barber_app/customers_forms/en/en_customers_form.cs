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
using ClientApp.classes;
using System.IO;
using ClientApp.settings_files;

namespace ClientApp.customers_forms.en
{
    public partial class en_customers_form : DevExpress.XtraEditors.XtraForm
    {
        public en_customers_form()
        {
            InitializeComponent();
            my_grid_view_class.set_font_and_hover_effect(main_gridview);
            my_grid_view_class.show_empty_message2(main_gridview);
            my_grid_view_class.set_find_panel_font2(main_gridview, quantites_grid_control, false, true);
        }
        public static bool came_from_logs = false;
        // check if all required data filled
        private bool CheckIfAllGood()
        {
            if (texts_class.is_null(name.Text.Trim()))
            {
                OmarNotifications.Alert.ShowInformation("Enter name");
                return false;
            }
            if (!validate_class.is_text_less_then_300_char(name.Text.Trim()))
            {
                return false;
            }
            return true;
        }
        // add data to database
        private void AddData()
        {
            if (CheckIfAllGood())
            {
                try
                {
                    double aol_moda = 0;
                    bool isDouble = Double.TryParse(aol_moda_text.Text, out aol_moda);
                    if (isDouble)
                    {
                        aol_moda = Math.Round(Convert.ToDouble(aol_moda_text.Text), 2);
                    }
                    DataTable table = connection_class.select("select isnull(max(customer_id)+1,1) from customers_table");
                    int id = Convert.ToInt32(table.Rows[0][0]);
                    string customer_name = name.Text.Trim();
                    string en_customer_name = en_name.Text.Trim();
                    string email = email_tb.Text.Trim();
                    string landline = (landline_tb.Text.Trim().Length == 0) ? "" : landline_tb.Text;
                    string mobile = (mobile_tb.Text.Trim().Length == 0) ? "" : mobile_tb.Text;
                    string second_mobile = (second_mobile_tb.Text.Trim().Length == 0) ? "" : second_mobile_tb.Text;
                    string tax_number = (drebe_number_tb.Text.Trim().Length == 0) ? "" : drebe_number_tb.Text;
                    string sgl_number = (sgl_number_tb.Text.Trim().Length == 0) ? "" : sgl_number_tb.Text;
                    string building_number = (building_number_tb.Text.Trim().Length == 0) ? "" : building_number_tb.Text;
                    string street = (street_tb.Text.Trim().Length == 0) ? "" : street_tb.Text;
                    string al7e = (al7e_tb.Text.Trim().Length == 0) ? "" : al7e_tb.Text;
                    string town = (town_tb.Text.Trim().Length == 0) ? "" : town_tb.Text;
                    string country = (country_tb.Text.Trim().Length == 0) ? "" : country_tb.Text;
                    connection_class.command($"insert into customers_table values ({id},N'{customer_name}',N'{landline}',N'{mobile}',N'{second_mobile}',N'{tax_number}',N'{sgl_number}',N'{building_number}',N'{street}',N'{al7e}',N'{town}',N'{country}',{aol_moda},N'{en_customer_name}',N'{email}')");
                    logs_class.log_add($"Add customer with id {id}", id, "Customers");
                    new_btn.PerformClick();

                    classes.notifications_class.success_message(); ;

                }
                catch (SqlException Ex)
                {
                    if (Ex.Message.Contains("unique"))
                    {
                        classes.notifications_class.my_messageBox("Customer name already exists");
                    }
                    else
                    {
                        classes.notifications_class.my_messageBox(Ex.Message);
                    }
                }
            }
        }
        // updata data to database
        private void UpdateData()
        {
            if (CheckIfAllGood())
            {
                try
                {
                    string customer_name = name.Text.Trim();
                    string en_customer_name = en_name.Text.Trim();
                    string email = email_tb.Text.Trim();
                    string landline = (landline_tb.Text.Trim().Length == 0) ? "" : landline_tb.Text;
                    string mobile = (mobile_tb.Text.Trim().Length == 0) ? "" : mobile_tb.Text;
                    string second_mobile = (second_mobile_tb.Text.Trim().Length == 0) ? "" : second_mobile_tb.Text;
                    string tax_number = (drebe_number_tb.Text.Trim().Length == 0) ? "" : drebe_number_tb.Text;
                    string sgl_number = (sgl_number_tb.Text.Trim().Length == 0) ? "" : sgl_number_tb.Text;
                    string building_number = (building_number_tb.Text.Trim().Length == 0) ? "" : building_number_tb.Text;
                    string street = (street_tb.Text.Trim().Length == 0) ? "" : street_tb.Text;
                    string al7e = (al7e_tb.Text.Trim().Length == 0) ? "" : al7e_tb.Text;
                    string town = (town_tb.Text.Trim().Length == 0) ? "" : town_tb.Text;
                    string country = (country_tb.Text.Trim().Length == 0) ? "" : country_tb.Text;
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection_class.connection();
                    command.CommandText = @"update customers_table set en_name=@en_name,email=@email, customer_name=@customer_name,customer_landline=@customer_landline,customer_mobile=@customer_mobile,customer_second_mobile=@customer_second_mobile,customer_tax_number=@customer_tax_number,customer_sgl_number=@customer_sgl_number,building_number=@building_number,street=@street,al7e=@al7e,town=@town,country=@country where customer_id=@customer_id";
                    command.Parameters.AddWithValue("@customer_id", Convert.ToInt32(id_tb.Text));
                    command.Parameters.AddWithValue("@customer_name", customer_name);
                    command.Parameters.AddWithValue("@customer_landline", landline);
                    command.Parameters.AddWithValue("@customer_mobile", mobile);
                    command.Parameters.AddWithValue("@customer_second_mobile", second_mobile);
                    command.Parameters.AddWithValue("@customer_tax_number", tax_number);
                    command.Parameters.AddWithValue("@customer_sgl_number", sgl_number);
                    command.Parameters.AddWithValue("@building_number", building_number);
                    command.Parameters.AddWithValue("@street", street);
                    command.Parameters.AddWithValue("@al7e", al7e);
                    command.Parameters.AddWithValue("@town", town);
                    command.Parameters.AddWithValue("@country", country);
                    command.Parameters.AddWithValue("@en_name", en_customer_name);
                    command.Parameters.AddWithValue("@email", email);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        logs_class.log_add($"Edit customer with id {id_tb.Text}", 0, "Customers");
                        new_btn.PerformClick();
                        classes.notifications_class.success_message();
                    }
                }
                catch (Exception Ex)
                {
                    if (Ex.Message.Contains("key row"))
                    {
                        OmarNotifications.Alert.ShowInformation("Customer name already exists");
                        return;
                    }
                    else
                        classes.notifications_class.my_messageBox(Ex.Message);
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            AddData();

        }

        private void customer_pic_upload_Click(object sender, EventArgs e)
        {
            
        }

        private void earse_customer_pic_Click(object sender, EventArgs e)
        {
        }

        private void new_btn_Click(object sender, EventArgs e)
        {

            run_worker_class.run(backgroundWorker1);
        }
        void clear()
        {
            name.Text = mobile_tb.Text = landline_tb.Text = second_mobile_tb.Text = drebe_number_tb.Text = sgl_number_tb.Text = building_number_tb.Text = al7e_tb.Text
                 = street_tb.Text = town_tb.Text = country_tb.Text = aol_moda_text.Text = "";
            id_tb.Text = get_id().ToString();

        }
        int get_id()
        {
            DataTable table = connection_class.select("select isnull(max(customer_id)+1,1) from customers_table");
            return Convert.ToInt32(table.Rows[0][0]);
        }
        void delete_customer_in_all_tables(int id)
        {
            connection_class.command($"delete from agle_table where customer_id={id}");
            connection_class.command($"delete from customers_paied_money_table where customer_id={id}");
            connection_class.command($"delete from customer_kshf_table where customer_id={id}");
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (main_gridview.SelectedRowsCount > 1)
            {
                OmarNotifications.Alert.ShowInformation("Select one customer");
                return;
            }
            DialogResult dr = notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                UpdateData();
        }
        string old_name;
        void navigate_btn(string query)
        {
            DataTable table = connection_class.select(query);
            if (table.Rows.Count == 0)
            {
                DataTable table1 = connection_class.select("select * from customers_table");
                if (table1.Rows.Count == 0)
                {
                    OmarNotifications.Alert.ShowInformation("No Data!");
                    return;
                }
                else
                {
                    if (is_next_clicked)
                        first_btn.PerformClick();
                    else
                        last_btn.PerformClick();
                }
            }
            else
            {
                int id = Convert.ToInt32(table.Rows[0]["customer_id"]);
                id_tb.Text = id.ToString();
                name.Text = table.Rows[0]["customer_name"].ToString();
                en_name.Text = table.Rows[0]["en_name"].ToString();
                email_tb.Text = table.Rows[0]["email"].ToString();
                landline_tb.Text = table.Rows[0]["customer_landline"].ToString();
                landline_tb.Text = table.Rows[0]["customer_landline"].ToString();
                mobile_tb.Text = table.Rows[0]["customer_mobile"].ToString();
                second_mobile_tb.Text = table.Rows[0]["customer_second_mobile"].ToString();
                drebe_number_tb.Text = table.Rows[0]["customer_tax_number"].ToString();
                sgl_number_tb.Text = table.Rows[0]["customer_sgl_number"].ToString();
                building_number_tb.Text = table.Rows[0]["building_number"].ToString();
                street_tb.Text = table.Rows[0]["street"].ToString();
                town_tb.Text = table.Rows[0]["town"].ToString();
                al7e_tb.Text = table.Rows[0]["al7e"].ToString();
                country_tb.Text = table.Rows[0]["country"].ToString();
                aol_moda_text.Text = table.Rows[0]["aol_moda"].ToString();
                old_name = name.Text.Trim();
            }
            delete_btn.Enabled = true;
            update_btn.Enabled = true;
            save_btn.Enabled = false;
            aol_moda_text.Enabled = false;
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            navigate_btn($"select * from customers_table where customer_id=(select min(customer_id) from customers_table)");

        }
        bool is_next_clicked = false;

        private void next_btn_Click(object sender, EventArgs e)
        {
            navigate_btn(navigation_class.next_navigatoin("customers_table", "customer_id", id_tb.Text));
            is_next_clicked = true;
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            navigate_btn(navigation_class.prev_navigation("customers_table", "customer_id", id_tb.Text));
            is_next_clicked = false;
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            navigate_btn($"select * from customers_table where customer_id=(select max(customer_id) from customers_table)");

        }

        private void en_customers_form_Load(object sender, EventArgs e)
        {
            run_worker_class.run(backgroundWorker1);

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (main_gridview.SelectedRowsCount == 0)
            {
                notifications_class.select_data_message();
            }
            if (main_gridview.SelectedRowsCount > 0)
            {
                foreach (int i in main_gridview.GetSelectedRows())
                {
                    string the_name = main_gridview.GetRowCellValue(i, main_gridview.Columns[1].FieldName).ToString();
                    if (!validate_class.is_customer_agel_clean(the_name))
                    {
                        return;
                    }
                }
                DialogResult dr = classes.notifications_class.my_messageBox("Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    foreach (int i in main_gridview.GetSelectedRows())
                    {
                        int id = Convert.ToInt32(main_gridview.GetRowCellValue(i, main_gridview.Columns[0].FieldName));
                        delete_customer_in_all_tables(id);
                        connection_class.command($"delete from customers_table where customer_id={Convert.ToInt32(main_gridview.GetRowCellValue(i, main_gridview.Columns[0].FieldName))}");
                        logs_class.log_add($"Delete customer with id {id_tb.Text}", 0, "Customers");
                    }
                    new_btn.PerformClick();
                    notifications_class.success_message();
                }

            }
        }
        private void main_gridview_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (main_gridview.RowCount != 0)
            {
                navigate_btn($"select * from customers_table where customer_id={Convert.ToInt32(main_gridview.GetFocusedRowCellValue(main_gridview.Columns[0]))}");
                delete_btn.Enabled = true;
                update_btn.Enabled = true;
                save_btn.Enabled = false;
            }
            if (main_gridview.SelectedRowsCount == 0)
            {
                delete_btn.Enabled = false;
                update_btn.Enabled = false;
                save_btn.Enabled = true;
                new_btn.PerformClick();
            }
        }
        DataTable get_data_table;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            get_data_table = connection_class.select("select customer_id as 'ID' , customer_name as 'Name',customer_landline as 'Landline',customer_mobile as 'Mobile',customer_tax_number as 'Tax Number',customer_sgl_number as 'Commercial Register',aol_moda as 'Balance' from customers_table order by customer_id desc");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            my_grid_view_class.set_datasource(quantites_grid_control, main_gridview, get_data_table);
            if (get_data_table.Rows.Count != 0)
                my_grid_view_class.set_summary(main_gridview, "Balance");
            main_gridview.ClearSelection();
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
            save_btn.Enabled = true;
            aol_moda_text.Enabled = true;
            clear();

        }
        private void print_btn_Click(object sender, EventArgs e)
        {
            if (main_gridview.RowCount == 0)
            {
                notifications_class.no_data_message();
                return;
            }
            repost_pos.en_manage_customers.print(my_grid_view_class.gridview_to_data_table(main_gridview), null);
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            repost_pos.en_manage_customers.to_word(my_grid_view_class.gridview_to_data_table(main_gridview));
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            repost_pos.en_manage_customers.to_excel(my_grid_view_class.gridview_to_data_table(main_gridview));
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            repost_pos.en_manage_customers.to_pdf(my_grid_view_class.gridview_to_data_table(main_gridview));
        }

    }
}