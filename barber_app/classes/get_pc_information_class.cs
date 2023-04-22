using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
namespace ClientApp.classes
{
    class get_pc_information_class
    {
        public static string get_cpu()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                return mo.Properties["processorID"].Value.ToString();
            }
            return string.Empty;
        }

    }
}
