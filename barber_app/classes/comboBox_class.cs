using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.classes
{
    class comboBox_class
    {
        
            public static void fill_combobox(DataTable table, ComboBoxEdit combobox)
            {
                combobox.Properties.Items.Clear();
                Font font = new Font("Arial",10);
                combobox.Properties.AppearanceDropDown.Font = font;
                combobox.Properties.AppearanceFocused.Font = font;
                combobox.Properties.AppearanceItemHighlight.Font = font;
                combobox.Properties.AppearanceItemSelected.Font = font;
                if (table.Rows.Count != 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        combobox.Properties.Items.Add(table.Rows[i][0].ToString());
                    }
                    combobox.SelectedIndex = 0;
                }
            }
            public static void clear_combobox(ComboBoxEdit combobox)
            {
                combobox.Properties.Items.Clear();
                for (int i = 0; i < combobox.Properties.Items.Count; i++)
                {
                    combobox.Properties.Items.RemoveAt(i);
                }
            }

    }
}
