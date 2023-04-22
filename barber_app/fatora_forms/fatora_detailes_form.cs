﻿using DevExpress.Utils;
using DevExpress.XtraGrid;
using ClientApp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.fatora_forms
{
    public partial class fatora_detailes_form : DevExpress.XtraEditors.XtraForm
    {
        public fatora_detailes_form()
        {
            InitializeComponent(); 

            my_grid_view_class.set_find_panel_font2(gridView1, gridControl1,true,true);
            my_grid_view_class.set_font_and_hover_effect(gridView1);
            my_grid_view_class.show_empty_message2(gridView1);
        }

       public static string invoice_number;
        private void fatora_detailes_form_Load(object sender, EventArgs e)
        {
            run_worker_class.run(backgroundWorker1);
        }
        DataTable table;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            table = connection_class.select($"select service_name as 'البيان',unit as 'وحدة القياس',quantity as 'الكمية',product_price_before_tax as 'السعر قبل الضريبة',tax as 'الضريبة',product_full_price as 'الأجمالي' from sales_body_table where fatora_id={invoice_number}"); ;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            my_grid_view_class.set_datasource(gridControl1, gridView1, table);
        }
    }
}
