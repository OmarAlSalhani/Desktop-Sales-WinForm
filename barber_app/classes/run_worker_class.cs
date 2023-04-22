using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace ClientApp.classes
{
    class run_worker_class
    {
        public static void run(BackgroundWorker backgroundWorker)
        {
            if(backgroundWorker.IsBusy==false)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }
    }
}
