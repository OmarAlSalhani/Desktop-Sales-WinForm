using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.classes
{
    class lookup_edit_class
    {
       static string column_name;
       static string column_name1;
        public static void fill_lookup(DataTable table, DevExpress.XtraEditors.LookUpEdit lookup_edit, string member_name)
        {
            if(table is null)
            {
                return;
            }
            lookup_edit.Properties.DataSource = null;
            if (table.Rows.Count != 0)
            {
                lookup_edit.Properties.DropDownRows = table.Rows.Count;
                lookup_edit.Properties.ShowFooter = false;
                lookup_edit.Properties.ValueMember = member_name;
                lookup_edit.Properties.DisplayMember = member_name;
                lookup_edit.EditValue = member_name;
                lookup_edit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
                lookup_edit.Properties.DataSource = table;
                lookup_edit.ItemIndex = 0;
                column_name = member_name;
            }
        }
    }
}
