using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.classes
{
    class navigation_class
    {
        public static string prev_navigation(string table_name, string column_name, string id)
        {
            return $"select top(1) * from {table_name} where {column_name} < {Convert.ToInt32(id)} order by {column_name} desc";
        }
        public static string next_navigatoin(string table_name, string column_name, string id)
        {
            return $"select top(1) * from {table_name} where {column_name} >{Convert.ToInt32(id)}";
        }
    }
}
