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

namespace ClientApp.fatora_forms
{
    public partial class ar_sell_fatora_checkout_form : DevExpress.XtraEditors.XtraForm
    {
        public static string the_pay_type;
        public static bool IsClicked = false;
        public static double cash_pay, how_stay, total_amount,discount;

        private void ar_sell_fatora_checkout_form_Load(object sender, EventArgs e)
        {
            the_pay_type = "نقداً";

            cash_pay_textbox.Select();
            net_textbox.Text = total_textbox.Text;
            cash_pay_textbox.Text = total_textbox.Text;
        }
        void keypad(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            if (pay_type_cb.Text == "نقداً")
            {
                cash_focused = true;
            }
            if (cash_focused)
            {
                cash_pay_textbox.Text = cash_pay_textbox.Text + button.Text;
            }
            else
            {
                discount_tb.Text = discount_tb.Text + button.Text;
            }

        }
        private void cash_pay_textbox_TextChanged(object sender, EventArgs e)
        {
            cash_pay_textbox.Text = ClientApp.classes.texts_class.is_number(cash_pay_textbox.Text) ? cash_pay_textbox.Text : "";
            if (ClientApp.classes.texts_class.is_number(cash_pay_textbox.Text))
            {
                double discount = Convert.ToDouble(discount_tb.Text);
                double total = Convert.ToDouble(total_textbox.Text);
                double cash = Convert.ToDouble(cash_pay_textbox.Text);
                double calc = total - discount - cash;
                net_textbox.Text = calc.ToString();
            }
            else
            {
                cash_pay_textbox.Text = "0";
            }
        }

        private void card_pay_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pay_type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pay_type_cb.SelectedIndex == 0)
            {
                the_pay_type = "نقداً";
                cash_pay_textbox.Enabled = true;
            }
            if(pay_type_cb.SelectedIndex>0)
            {
                the_pay_type = pay_type_cb.Text;
                cash_pay_textbox.Text = "0";
                cash_pay_textbox.Enabled = false;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            total_amount = Math.Round(Convert.ToDouble(total_textbox.Text), 2);
            how_stay = Math.Round(Convert.ToDouble(net_textbox.Text), 2);
            cash_pay = Math.Round(Convert.ToDouble(cash_pay_textbox.Text), 2);
            discount = Math.Round(Convert.ToDouble(discount_tb.Text), 2);
            if (cash_pay <= 0 && the_pay_type == "نقداً")
            {
                OmarNotifications.Alert.ShowInformation("لا يمكن أن تكون القيمة صفر أو سالبة");
                return;
            }
            if (how_stay < 0)
            {
                OmarNotifications.Alert.ShowInformation("المبلغ المدفوع أكبر من قيمة الفاتورة");
                return;
            }
            IsClicked = true;
            the_pay_type = pay_type_cb.Text;
            Close();
        }
        int SC_CLOSE = 0xF060;
        int WM_SYSCOMMAND = 0x0112;
        bool xClick = false;
        bool cash_focused = false;
        private void cash_pay_textbox_Click(object sender, EventArgs e)
        {
            cash_focused = true;
        }
        private void card_pay_textbox_Click(object sender, EventArgs e)
        {
            cash_focused = false;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (cash_focused)
            {
                cash_pay_textbox.Text = "0";
            }
            else discount_tb.Text = "0";
           
        }



        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_CLOSE)
                xClick = true;
            base.WndProc(ref m);
        }

        private void discount_tb_EditValueChanged(object sender, EventArgs e)
        {
            double discount = Convert.ToDouble(discount_tb.Text);
            double total = Convert.ToDouble(total_textbox.Text);
            double cash = Convert.ToDouble(cash_pay_textbox.Text);
            double calc = total - discount - cash;
            net_textbox.Text = calc.ToString();
        }

        private void ar_sell_fatora_checkout_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xClick)
                IsClicked = false;
        }

        public ar_sell_fatora_checkout_form()
        {
            InitializeComponent();
        }
    }
}