using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.classes
{
    class validate_class
    {
        /// <summary>
        /// للتأكد من أن الحساب لا يوجد عليه أي نقود
        /// </summary>
        public static bool is_customer_agel_clean(string customer_name)
        {
            DataTable table = connection_class.select($"select isnull(aol_moda,0) from customers_table where customer_name=N'{customer_name}'");
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                double how_stay = Convert.ToDouble(table.Rows[0][0]);
                if (how_stay == 0)
                {
                    return true;
                }
                else
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف العميل {customer_name} لوجود مستحقات مالية عليه");
                    return false;
                }
            }
        }
        public static bool is_mord_agel_clean(string mord_name)
        {
            DataTable table = connection_class.select($"select isnull(aol_moda,0) from morden_table where the_name=N'{mord_name}'");
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                double how_stay = Convert.ToDouble(table.Rows[0][0]);
                if (how_stay == 0)
                {
                    return true;
                }
                else
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف المورد {mord_name} لوجود مستحقات مالية له");
                    return false;
                }
            }
        }
        public static bool is_employee_clean(string employee_name)
        {
            DataTable selfa_table = connection_class.select($"select isnull(sum(selfa_value),0) from selfa_table where is_paied=0 and employee_name=N'{employee_name}'");
            DataTable discount_table = connection_class.select($"select isnull(sum(cut_value),0) from employee_cut_table where is_paied=0 and employee_name=N'{employee_name}'");
            DataTable reward_table = connection_class.select($"select isnull(sum(reward_value),0) from employee_reward_table where is_paied=0 and employee_name=N'{employee_name}'");
            DataTable warehouse_table = connection_class.select($"select isnull(supervisor_name,'none') from warehouse_table where supervisor_name=N'{employee_name}'");
            if (selfa_table.Rows.Count == 0 && discount_table.Rows.Count == 0 && reward_table.Rows.Count == 0 && warehouse_table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                double selfa_value = Convert.ToDouble(selfa_table.Rows[0][0]);
                double discount_value = Convert.ToDouble(discount_table.Rows[0][0]);
                double reward_value = Convert.ToDouble(reward_table.Rows[0][0]);
                if (selfa_value > 0)
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الموظف {employee_name} لوجود سلف عليه");
                    return false;
                }
                if (discount_value > 0)
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الموظف {employee_name} لوجود خصميات عليه");
                    return false;
                }
                if (reward_value > 0)
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الموظف {employee_name} لوجود مكافئات له");
                    return false;
                }
                if (warehouse_table.Rows.Count != 0)
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الموظف {employee_name} لإرتباطه بالمخازن");
                    return false;
                }
                return true;
            }
        }
        public static bool is_storage_clean(string storage_name)
        {
            DataTable table = connection_class.select($"select isnull(storage_value,0) from storage_table where storage_name=N'{storage_name}'");
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                double value = Convert.ToDouble(table.Rows[0][0]);
                if (value > 0)
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الخزنة {storage_name} لأحتوائها على رصيد مالي");
                    return false;
                }
            }
            return true;
        }
        public static bool is_bank_clean(string bank_name)
        {
            DataTable table = connection_class.select($"select isnull(bank_value,0) from bank_table where bank_name=N'{bank_name}'");
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                double value = Convert.ToDouble(table.Rows[0][0]);
                if (value > 0)
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف البنك {bank_name} لأحتوائه على رصيد مالي");
                    return false;
                }
            }
            return true;
        }
        public static bool is_storage_bound_to_this_user()
        {
            DataTable table = connection_class.select($"select isnull(storage_id,'none') from users_table where user_id={settings_files.main_settings.Default.userID}");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                string name = table.Rows[0][0].ToString();
                if (name != "none")
                {
                    return true;
                }
                else
                {
                    OmarNotifications.Alert.ShowInformation($"لا توجد خزنة مرتبطة مع المستخدم الحالي\nسيتم إيقاف العملية الحالية");
                    return false;
                }
            }
        }
        public static bool is_bank_bound_to_this_user()
        {
            DataTable table = connection_class.select($"select isnull(bank_name,'none') from users_table where username=N'{settings_files.main_settings.Default.username}'");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                string name = table.Rows[0][0].ToString();
                if (name!="")
                {
                    return true;
                }
                else
                {
                    OmarNotifications.Alert.ShowInformation($"لا يوجد بنك مرتبط مع المستخدم الحالي\nسيتم إيقاف العملية الحالية");
                    return false;
                }
            }
        }
        public static bool is_company_has_bills(string company_name)
        {
            DataTable table = connection_class.select($"select * from [buy_head_table] where company_name=N'{company_name}'");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الشركة {company_name}\nلوجود فواتير مرتبطة بها");
                return true;
            }
        }
        public static bool is_doctor_clean(string doctor_name)
        {
            DataTable table = connection_class.select($"select isnull(aol_moda,0) from doctors_table where doctor_name=N'{doctor_name}'");
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                double aol_moda = Convert.ToDouble(table.Rows[0][0]);
                if (aol_moda == 0)
                {
                    return true;
                }
                else
                {
                    OmarNotifications.Alert.ShowInformation($"لا يمكن حذف الطبيب {doctor_name} لوجود مستحقات مالية");
                    return false;
                }
            }
        }
        public static bool is_text_less_then_300_char(string the_text)
        {
            if (the_text.Trim().Length > 300)
            {
                OmarNotifications.Alert.ShowInformation("لا يمكن أن تكون عدد المحارف أكبر من 300");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
