using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.products_forms
{
    public class products_model
    {
        public string product_name { get; set; }
        public string unit { get; set; }
        public double price_before_tax { get; set; }
        public int quantity { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }
}
