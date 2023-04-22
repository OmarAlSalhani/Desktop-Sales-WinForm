using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.classes
{
    class const_variables_class
    {
        public static string get_report()
        {
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\";
            string file_name = "pos_report2.repx";
            string[] files = Directory.GetFiles(folder, file_name);
            return files[0];
        }
        public static string now_date = DateTime.Now.ToString("dd-MM-yyyy");
        public static string username = settings_files.main_settings.Default.username;
        public static int userID = settings_files.main_settings.Default.userID;
    }
}
