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

namespace ClientApp.ash3ar_forms.en
{
    public partial class en_da2en_ash3ar_form : XtraForm
    {

        public en_da2en_ash3ar_form()
        {
            InitializeComponent();
            my_grid_view_class.set_find_panel_font2(gridView2, gridControl2, true, true);
            my_grid_view_class.show_empty_message2(gridView2);
            my_grid_view_class.set_font_and_hover_effect(gridView2);
            gridView2.RowCellClick += GridView2_RowCellClick;
        }

        private void GridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(e.Column.Caption== "Delete")
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
                OmarNotifications.Alert.ShowInformation("Select type");
                return false;
            }
            if (invoice_id_cb.SelectedIndex == -1)
            {
                OmarNotifications.Alert.ShowInformation("Select invoice id");
                return false;
            }
            if (service_cb.SelectedIndex == -1)
            {
                OmarNotifications.Alert.ShowInformation("Select product");
                return false;
            }
            if (Convert.ToDouble(current_qty_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("Quantity not available");
                return false;
            }
            if (Convert.ToDouble(qty_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("Enter Quantity");
                return false;
            }
            if (Convert.ToDouble(qty_tb.Text) > Convert.ToDouble(current_qty_tb.Text))
            {
                OmarNotifications.Alert.ShowInformation("Quantity not available");
                return false;
            }
            if (Convert.ToDouble(price_tb.Text) <= 0)
            {
                OmarNotifications.Alert.ShowInformation("Enter Quantity");
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
                    table.Columns.Add("Invoice id");
                    table.Columns.Add("Product");
                    table.Columns.Add("Quantity");
                    table.Columns.Add("Unit");
                    table.Columns.Add("Price before tax");
                    table.Columns.Add("Tax");
                    table.Columns.Add("Total");
                }
                double vals = 0;

                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    string invoiceID = gridView2.GetRowCellValue(i, "Invoice id").ToString();
                    string serviceName = gridView2.GetRowCellValue(i, "Product").ToString();
                    if(serviceName==service_cb.Text && invoiceID==invoice_id_cb.Text)
                    {
                        vals += Convert.ToDouble(gridView2.GetRowCellValue(i, "Quantity"));
                    }
                }
                if(vals>=Convert.ToDouble(current_qty_tb.Text))
                {
                    OmarNotifications.Alert.ShowInformation("Added before");
                    return;
                }
                DataRow row = table.NewRow();
                row["Invoice id"] = invoice_id_cb.Text;
                row["Product"] = service_cb.Text;
                row["Quantity"] = qty_tb.Text;
                row["Unit"] = unit.Text;
                row["Tax"] = tax_tb.Text;
                row["Price before tax"] = price_tb.Text;
                row["Total"] = Convert.ToDouble(price_tb.Text)*Convert.ToDouble(qty_tb.Text)*Convert.ToDouble(tax_tb.Text);
                table.Rows.Add(row);
                
                gridControl2.DataSource = table;
                if(gridView2.Columns.Count==4)
                {
                    GridColumn unboundColumn = new GridColumn();
                    unboundColumn.FieldName = "Delete";
                    unboundColumn.Caption = "Delete";
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

        private void en_da2en_ash3ar_form_Load(object sender, EventArgs e)
        {
            run_worker_class.run(invoiceIDWorker);
        }

        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {

        }

        DataTable printTable = new DataTable();
        private void save_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                double qty = Convert.ToDouble(gridView2.GetRowCellValue(i, "Quantity"));
                int invoiceID = Convert.ToInt32(gridView2.GetRowCellValue(i, "Invoice id"));
                string name = gridView2.GetRowCellValue(i, "Product").ToString();
                connection_class.command($"update sales_body_table set ash3ar_qty=ash3ar_qty-{qty} where fatora_id={invoiceID} and  service_name=N'{name}'");
            }
            DataTable table=gridControl2.DataSource as DataTable;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int fatora = Convert.ToInt32(table.Rows[i]["Invoice id"]);
                string service = table.Rows[i]["Product"].ToString();
                string unit = table.Rows[i]["Unit"].ToString();
                int qty = Convert.ToInt32(table.Rows[i]["Quantity"]);
                double price_before_tax = Convert.ToInt32(table.Rows[i]["Price before tax"]);
                double tax = Convert.ToInt32(table.Rows[i]["Tax"]);
                double fullPrice = Convert.ToInt32(table.Rows[i]["Total"]);
                connection_class.command($"insert into ash3ar_table values ({fatora},N'{service}',N'{unit}',{qty},{price_before_tax},{tax},{fullPrice})");
            }
            repost_pos.en_ash3ar_report.print(table);


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