using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientApp.classes
{
    class my_grid_view_class
    {
        public static void show_empty_message2(DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            gridview.CustomDrawEmptyForeground += (s, e) =>
              {
                  Font font;
                  if (gridview.RowCount != 0) return;
                  StringFormat drawFormat = new StringFormat();
                  drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                  font = new Font("Arial", 10, System.Drawing.FontStyle.Bold);
                  e.Graphics.DrawString("لا يوجد بيانات لعرضها", font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
              };
        }
        public class MyGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FindControlFindButton:
                        return "بحث";
                    case GridStringId.FindControlClearButton:
                        return "حذف ";
                    case GridStringId.FilterPanelCustomizeButton:
                        return "فلترة";
                    case GridStringId.CheckboxSelectorColumnCaption:
                        return "تحديد";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }
        public static void set_find_panel_font2(DevExpress.XtraGrid.Views.Grid.GridView gridView, DevExpress.XtraGrid.GridControl gridControl, bool show_footer, bool show_find_panel, bool allow_color_edit = true)
        {
            if (show_footer == true)
            {
                gridView.OptionsView.ShowFooter = true;
            }
            else
            {
                gridView.OptionsView.ShowFooter = false;
            }
            if (show_find_panel == true)
            {
                gridView.OptionsFind.AlwaysVisible = true;
            }
            else
            {
                gridView.OptionsFind.AlwaysVisible = false;
            }

            gridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            gridView.OptionsMenu.EnableFooterMenu = false;
            gridView.OptionsHint.ShowFooterHints = false;
            gridView.OptionsFind.ShowFindButton = true;
            gridView.OptionsFind.ShowClearButton = true;
            gridView.OptionsFind.ShowCloseButton = true;
            gridView.OptionsFind.ShowSearchNavButtons = true;
            gridView.Appearance.FooterPanel.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
            gridView.Appearance.FocusedRow.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
            gridView.Appearance.SelectedRow.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
            gridView.Appearance.Row.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
            gridView.Appearance.HotTrackedRow.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
            gridView.Appearance.HeaderPanel.Font = new Font("Arial", 13, FontStyle.Bold);
            gridView.Appearance.FooterPanel.ForeColor = Color.RoyalBlue;
            gridView.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.ColumnFilterChanged += (s, e) =>
            {
                if (gridView.RowCount == 0)
                {
                    notifications_class.grid_message();
                }
            };
            gridView.MRUFiltersInfo.Clear();

            gridView.OptionsFind.FindNullPrompt = "ابدأ بكتابة النص لبدء البحث";

            gridControl.Layout += (s, e) =>
            {
                if (gridView.IsFindPanelVisible)
                {
                    FindControl findPanel = gridControl.Controls.Find("FindControlCore", false).FirstOrDefault() as FindControl;
                    if (findPanel != null)
                    {

                        findPanel.FindEdit.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
                        findPanel.FindButton.Appearance.Font = new Font("Arial", 13, System.Drawing.FontStyle.Bold);
                    }
                }
            };
            if (allow_color_edit)
                set_colors(gridView);
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowMove = false;
                gridView.Columns[i].OptionsFilter.AllowFilter = false;
                gridView.Columns[i].OptionsFilter.AllowAutoFilter = false;
                gridView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            }
        }
        // method to convert grid_view to data_table
        public static DataTable gridview_to_data_table(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            DataTable dt = new DataTable();
            foreach (GridColumn column in gridView.VisibleColumns)
            {
                dt.Columns.Add(column.FieldName, column.ColumnType);
            }
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                DataRow row = dt.NewRow();
                foreach (GridColumn column in gridView.VisibleColumns)
                {
                    row[column.FieldName] = gridView.GetRowCellValue(i, column);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        static string col_name;
        public static void set_summary(DevExpress.XtraGrid.Views.Grid.GridView main_gridview, string column_name)
        {
            try
            {
                GridColumn column = main_gridview.Columns[column_name];
                GridSummaryItem item = column.SummaryItem;
                if (item != null)
                {
                    column.Summary.Remove(item);
                }
                if (main_gridview.RowCount != 0)
                {
                    GridColumnSummaryItem summaryItem = new GridColumnSummaryItem();
                    summaryItem.FieldName = column_name;
                    summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    if(settings_files.main_settings.Default.language=="ar")
                    summaryItem.DisplayFormat = "المجموع : " + " " + "{0:N}";
                    else
                        summaryItem.DisplayFormat = "Sum : " + " " + "{0:N}";
                    main_gridview.Columns[column_name].Summary.Add(summaryItem);
                    main_gridview.Columns[column_name].DisplayFormat.FormatType = FormatType.Numeric;
                    main_gridview.Columns[column_name].DisplayFormat.FormatString = "{0:N}";
                    main_gridview.BestFitColumns(true);
                    col_name = column_name;
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
            main_gridview.CustomColumnDisplayText += Main_gridview_CustomColumnDisplayText;
        }
        public static void set_summary_with_custom_text(DevExpress.XtraGrid.Views.Grid.GridView main_gridview, string column_name, string text)
        {
            try
            {
                GridColumn column = main_gridview.Columns[column_name];
                GridSummaryItem item = column.SummaryItem;
                if (item != null)
                {
                    column.Summary.Remove(item);
                }
                if (main_gridview.RowCount != 0)
                {
                    GridColumnSummaryItem summaryItem = new GridColumnSummaryItem();
                    summaryItem.FieldName = column_name;
                    summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    summaryItem.DisplayFormat = $"{text} : " + " " + "{0:N}";
                    main_gridview.Columns[column_name].Summary.Add(summaryItem);
                    main_gridview.Columns[column_name].DisplayFormat.FormatType = FormatType.Numeric;
                    main_gridview.Columns[column_name].DisplayFormat.FormatString = "{0:N}";
                    main_gridview.BestFitColumns(true);
                    col_name = column_name;
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
            main_gridview.CustomColumnDisplayText += Main_gridview_CustomColumnDisplayText;
        }
        private static void Main_gridview_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == col_name)
                {
                    if (Convert.ToDouble(e.Value) == 0D)
                        e.DisplayText = "0";
                }
            }
            catch (FormatException)
            {

            }

        }
        public static void set_font_and_hover_effect(DevExpress.XtraGrid.Views.Grid.GridView main_gridview, int header_font_size = 14, int row_font_size = 13)
        {
            Font body_font;
            Font head_font;
            body_font = new Font("Arial", row_font_size);
            head_font = new Font("Arial", header_font_size, FontStyle.Bold);
            main_gridview.OptionsMenu.EnableColumnMenu = false;
            main_gridview.OptionsMenu.EnableGroupPanelMenu = false;
            main_gridview.OptionsMenu.EnableGroupRowMenu = false;
            main_gridview.Appearance.FocusedRow.Font = body_font;
            main_gridview.Appearance.FocusedCell.Font = body_font;
            main_gridview.Appearance.Row.Font = body_font;
            main_gridview.Appearance.SelectedRow.Font = body_font;
            main_gridview.Appearance.HeaderPanel.Font = head_font;
            main_gridview.OptionsView.ShowIndicator = false;
            main_gridview.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;

        }
        public static double column_sum(DevExpress.XtraGrid.Views.Grid.GridView gridview, string column_name)
        {
            double a = 0;
            for (int i = 0; i < gridview.RowCount; i++)
            {
                a += Convert.ToDouble(gridview.GetRowCellValue(i, column_name));
            }
            return a;
        }
        public static double column_sum_with_condition(DevExpress.XtraGrid.Views.Grid.GridView gridview, string column_name, string if_column, string condition)
        {
            double a = 0;
            for (int i = 0; i < gridview.RowCount; i++)
            {
                double val = Convert.ToDouble(gridview.GetRowCellValue(i, gridview.Columns[if_column]));
                a += Convert.ToDouble(gridview.GetRowCellValue(i, column_name));
            }
            return a;
        }
        public static void set_colors(DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            gridview.OptionsSelection.EnableAppearanceHotTrackedRow = DefaultBoolean.True;
            gridview.Appearance.HotTrackedRow.BackColor = Color.FromArgb(100, 181, 246);
            gridview.Appearance.HotTrackedRow.BackColor2 = Color.FromArgb(100, 181, 246);
            gridview.Appearance.HotTrackedRow.ForeColor = Color.White;
            gridview.Appearance.SelectedRow.ForeColor = Color.White;
            gridview.Appearance.SelectedRow.BackColor = Color.FromArgb(21, 101, 192);
            gridview.Appearance.SelectedRow.BackColor2 = Color.FromArgb(21, 101, 192);
            gridview.Appearance.FocusedRow.ForeColor = Color.White;
            gridview.Appearance.FocusedRow.BackColor = Color.FromArgb(21, 101, 192);
            gridview.Appearance.FocusedRow.BackColor2 = Color.FromArgb(21, 101, 192);

        }
        public static void set_datasource(DevExpress.XtraGrid.GridControl gridControl, DevExpress.XtraGrid.Views.Grid.GridView gridview, DataTable table)
        {
            gridview.BestFitColumns();
            gridview.OptionsView.ColumnAutoWidth = false;
            gridview.ScrollStyle = ScrollStyleFlags.LiveHorzScroll;
            gridview.HorzScrollVisibility = ScrollVisibility.Always;
            set_colors(gridview);
            gridControl.DataSource = table;
            gridview.AutoFillColumn = gridview.Columns[0];
            gridview.BestFitColumns(true);
            gridview.KeyDown += Gridview_KeyDown;
            gridview.RowCellStyle += Gridview_RowCellStyle;
            for (int i = 0; i < gridview.Columns.Count; i++)
            {
                gridview.Columns[i].OptionsColumn.AllowMove = false;
                gridview.Columns[i].OptionsFilter.AllowFilter = false;
                gridview.Columns[i].OptionsFilter.AllowAutoFilter = false;
                gridview.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
            }
        }
        private static void Gridview_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == col_name)
            {
                if (Convert.ToDouble(e.CellValue) > 0)
                    e.Appearance.ForeColor = Color.Green;
                else if (Convert.ToDouble(e.CellValue) < 0)
                    e.Appearance.ForeColor = Color.Red;
                else
                    e.Appearance.ForeColor = Color.Black;
            }
        }
        private static void Gridview_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                e.Handled = true;
            }
        }
        public static string get_min_value(DevExpress.XtraGrid.Views.Grid.GridView gridView, string column_name)
        {
            List<string> values = new List<string>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                string value = gridView.GetRowCellValue(i, gridView.Columns[column_name]).ToString();
                values.Add(value);
            }
            values.Sort();
            return values[0].ToString();
        }
        public static string get_max_value(DevExpress.XtraGrid.Views.Grid.GridView gridView, string column_name)
        {
            List<string> values = new List<string>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                string value = gridView.GetRowCellValue(i, gridView.Columns[column_name]).ToString();
                values.Add(value);
            }
            values.Sort();
            return values[values.Count - 1].ToString();
        }
    }

}
