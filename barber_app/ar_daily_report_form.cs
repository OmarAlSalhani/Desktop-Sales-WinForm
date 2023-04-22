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
using ClientApp.classes;

namespace ClientApp
{
    public partial class ar_daily_report_form : DevExpress.XtraEditors.XtraForm
    {
        public ar_daily_report_form()
        {
            InitializeComponent();
            first_date.DateTime = last_date.DateTime = DateTime.Now;
        }
        string get_data(string query)
        {
            DataTable table = connection_class.select(query);
                if (table.Rows.Count == 0)
            {
                return "0";
            }
            else
                return table.Rows[0][0].ToString();

        }
        bool IsZero()
        {
            if (
                   Convert.ToDouble(customers_deon_tb.Text) == 0
                && Convert.ToDouble(customers_paied_money_tb.Text) == 0
                && Convert.ToDouble(total_tax_tb.Text) == 0
                && Convert.ToDouble(snd_srf_tb.Text) == 0
                && Convert.ToDouble(total_without_tax_tb.Text) == 0
                && Convert.ToDouble(total_with_taxes_tb.Text) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void show_report_btn_Click(object sender, EventArgs e)
        {
            string f = first_date.DateTime.ToString("dd-MM-yyyy");
            string l = last_date.DateTime.ToString("dd-MM-yyyy");
            customers_deon_tb.Text = get_data($"select isnull(sum(how_stay),0) as 'total' from agle_table where the_pay_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            customers_paied_money_tb.Text = get_data($"select isnull(sum(value),0)  as 'total' from customers_paied_money_table where the_date between convert(date,'{f}',105) and convert(date,'{l}',105) ");
            snd_srf_tb.Text = get_data($"select isnull(sum(value),0) as 'value' from snd_srf_table where the_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            snd_srf_tb.Text = get_data($"select isnull(sum(value),0) as 'value' from snd_kbd_table where the_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
          
            total_tax_tb.Text = get_data($"select isnull(sum(taxes),0) as 'value' from sales_head_table where sell_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            total_without_tax_tb.Text = get_data($"select isnull(sum(total_before_taxes),0) as 'value' from sales_head_table where sell_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            total_with_taxes_tb.Text = get_data($"select isnull(sum(total_amount),0) as 'value' from sales_head_table where sell_date between convert(date,'{f}',105) and convert(date,'{l}',105)");
            
            
            
            if (IsZero())
            {
                OmarNotifications.Alert.ShowInformation("لا يوجد بيانات لعرضها في الفترة المحددة");
                return;
            }
        }

        private void ar_daily_report_form_Load(object sender, EventArgs e)
        {

        }
        public static string the_date, total_with_tax, total_without_tax, taxes, customers_deon, customers_paied_money, snd_srf, snd_qbd;
        private void print_btn_Click(object sender, EventArgs e)
        {
            the_date = first_date.Text + " | " + last_date.Text;
            total_with_tax = total_with_taxes_tb.Text;
            total_without_tax = total_without_tax_tb.Text;
            taxes = total_tax_tb.Text;
            customers_deon = customers_deon_tb.Text;
            customers_paied_money = customers_paied_money_tb.Text;
            snd_qbd = snd_qbd_tb.Text;
            snd_srf = snd_srf_tb.Text;
            repost_pos.daily_report.print();
        }
    }
}