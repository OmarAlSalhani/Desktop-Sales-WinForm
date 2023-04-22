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
using ClientApp.settings_files;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using ClientApp.classes;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;

namespace ClientApp.ash3ar_forms
{
    public partial class da2en_ash3ar_form : XtraForm
    {

        public da2en_ash3ar_form()
        {
            InitializeComponent();
            my_grid_view_class.set_find_panel_font2(gridView2, gridControl2, true, true);
            my_grid_view_class.show_empty_message2(gridView2);
            my_grid_view_class.set_font_and_hover_effect(gridView2);
            gridView2.RowCellClick += GridView2_RowCellClick;
        }

        private void GridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Caption == "حذف")
            {
                gridView2.DeleteRow(e.RowHandle);
            }
        }

        DataTable invoiceIDTable;
        private void invoiceIDWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            invoiceIDTable = connection_class.select($"select fatora_id from sales_head_table");
        }

        private void invoiceIDWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            classes.comboBox_class.fill_combobox(invoiceIDTable, invoice_id_cb);
        }

        private void invoice_id_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invoice_id_cb.SelectedIndex == -1)
            {
                return;
            }
            DataTable t = connection_class.select($" select service_name from sales_body_table where fatora_id={Convert.ToInt32(invoice_id_cb.Text)}");
            if (t.Rows.Count != 0)
                classes.comboBox_class.fill_combobox(t, service_cb);
        }

        private void service_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (service_cb.SelectedIndex == -1)
            {
                return;
            }

            DataTable t = connection_class.select($"select ash3ar_qty,unit from sales_body_table where service_name=N'{service_cb.Text}' and fatora_id={Convert.ToInt32(invoice_id_cb.Text)}");
            if (t.Rows.Count != 0)
            {
                double val = Convert.ToDouble(t.Rows[0][0]);
                current_qty_tb.Text = val.ToString();
                qty_tb.Text = "0".ToString();
                unit.Text = t.Rows[0][1].ToString();
            }

        }
        private void qty_tb_EditValueChanged(object sender, EventArgs e)
        {
            DataTable t = connection_class.select($"select product_price_before_tax from sales_body_table where service_name=N'{service_cb.Text}' and fatora_id={Convert.ToInt32(invoice_id_cb.Text)}");
            if (t.Rows.Count != 0)
            {
                double val = Convert.ToDouble(t.Rows[0][0]) * Convert.ToDouble(qty_tb.Text);
                price_tb.Text = val.ToString();
            }
        }
        DataTable table = new DataTable();
        bool check()
        {
            if (ash3ar_type_cb.SelectedIndex == -1)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء أختيار نوع الأشعار");
                return false;
            }
            if (invoice_id_cb.SelectedIndex == -1)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء أختيار رقم الفاتورة");
                return false;
            }
            if (service_cb.SelectedIndex == -1)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء أختيار البيان");
                return false;
            }
            if (Convert.ToDouble(current_qty_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("لا يمكن أصدار أشعار لعدم توفر كمية");
                return false;
            }
            if (Convert.ToDouble(qty_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء أدخال الكمية");
                return false;
            }
            if (Convert.ToDouble(qty_tb.Text) > Convert.ToDouble(current_qty_tb.Text))
            {
                OmarNotifications.Alert.ShowInformation("الكمية غير متوفرة");
                return false;
            }
            if (Convert.ToDouble(price_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("الرجاء أدخال الكمية");
                return false;
            }
            return true;

        }
        private void add_to_grid_btn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (gridView2.Columns.Count == 0)
                {
                    table.Columns.Add("رقم الفاتورة");
                    table.Columns.Add("البيان");
                    table.Columns.Add("الكمية");
                    table.Columns.Add("وحدة القياس");
                    table.Columns.Add("السعر قبل الضريبة");
                    table.Columns.Add("الضريبة");
                    table.Columns.Add("الأجمالي");
                }
                double vals = 0;

                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    string invoiceID = gridView2.GetRowCellValue(i, "رقم الفاتورة").ToString();
                    string serviceName = gridView2.GetRowCellValue(i, "البيان").ToString();
                    if (serviceName == service_cb.Text && invoiceID == invoice_id_cb.Text)
                    {
                        vals += Convert.ToDouble(gridView2.GetRowCellValue(i, "الكمية"));
                    }
                }
                if (vals >= Convert.ToDouble(current_qty_tb.Text))
                {
                    OmarNotifications.Alert.ShowInformation("تمت أضافة كل الكمية مسبقاً");
                    return;
                }
                DataRow row = table.NewRow();
                double price_with_tax = Convert.ToDouble(price_tb.Text) + Convert.ToDouble(tax_tb.Text);
                row["رقم الفاتورة"] = invoice_id_cb.Text;
                row["البيان"] = service_cb.Text;
                row["الكمية"] = qty_tb.Text;
                row["وحدة القياس"] = unit.Text;
                row["الضريبة"] = tax_tb.Text;
                row["السعر قبل الضريبة"] = price_tb.Text;
                row["الأجمالي"] = price_with_tax * Convert.ToDouble(qty_tb.Text);
                table.Rows.Add(row);

                gridControl2.DataSource = table;
                if (gridView2.Columns.Count == 4)
                {
                    GridColumn unboundColumn = new GridColumn();
                    unboundColumn.FieldName = "حذف";
                    unboundColumn.Caption = "حذف";
                    unboundColumn.VisibleIndex = gridView2.Columns.Count;
                    RepositoryItemButtonEdit item = new RepositoryItemButtonEdit();
                    item.TextEditStyle = TextEditStyles.HideTextEditor;
                    item.ButtonsStyle = BorderStyles.HotFlat;
                    item.Buttons.Clear();
                    item.Buttons.Add(new EditorButton(ButtonPredefines.Delete));
                    unboundColumn.ColumnEdit = item;
                    gridView2.Columns.Add(unboundColumn);
                    item.ButtonClick += Item_ButtonClick;

                }
            }

        }

        private void Item_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            gridView2.DeleteRow(gridView2.FocusedRowHandle);
            MessageBox.Show("one");
        }

        private void da2en_ash3ar_form_Load(object sender, EventArgs e)
        {
            run_worker_class.run(invoiceIDWorker);
        }

        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {

        }

        DataTable printTable = new DataTable();
        private void save_btn_Click(object sender, EventArgs e)
        {
            if(gridView2.RowCount==0)
            {
                OmarNotifications.Alert.ShowInformation("يرجى الضغط على أضافة أولاً");
                return;
            }
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                double qty = Convert.ToDouble(gridView2.GetRowCellValue(i, "الكمية"));
                int invoiceID = Convert.ToInt32(gridView2.GetRowCellValue(i, "رقم الفاتورة"));
                string name = gridView2.GetRowCellValue(i, "البيان").ToString();
                connection_class.command($"update sales_body_table set ash3ar_qty=ash3ar_qty-{qty} where fatora_id={invoiceID} and  service_name=N'{name}'");
            }
            DataTable table = gridControl2.DataSource as DataTable;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int fatora = Convert.ToInt32(table.Rows[i]["رقم الفاتورة"]);
                string service = table.Rows[i]["البيان"].ToString();
                string unit = table.Rows[i]["وحدة القياس"].ToString();
                double qty = Convert.ToDouble(table.Rows[i]["الكمية"]);
                double price_before_tax = Convert.ToDouble(table.Rows[i]["السعر قبل الضريبة"]);
                double tax = Convert.ToDouble(table.Rows[i]["الضريبة"]);
                double fullPrice = Convert.ToDouble(table.Rows[i]["الأجمالي"]);
                connection_class.command($"insert into ash3ar_table values ({fatora},N'{service}',N'{unit}',{qty},{price_before_tax},{tax},{fullPrice})");
            }
            repost_pos.ash3ar_report.print(table);


        }

        private void current_qty_tb_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void price_tb_EditValueChanged(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(price_tb.Text);
            double tax = (price * settings_files.main_settings.Default.tax_value) / 100;
            tax_tb.Text = tax.ToString();
        }
    }
}