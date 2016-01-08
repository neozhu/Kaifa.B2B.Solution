using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using Kaifa.B2B.VendorAlloc;

namespace Kaifa.B2B.SZDImportService
{
    public partial class Kaifa_B2B_SZDImportService : ServiceBase
    {
        private CalendarTask calTask = null;
        private AllocTask allTask = null;
        public Kaifa_B2B_SZDImportService()
        {
            InitializeComponent();
            string connectionstring = System.Configuration.ConfigurationManager.AppSettings["connectionstring"];
            string alldir = System.Configuration.ConfigurationManager.AppSettings["allocDir"];
            string allbakdir = System.Configuration.ConfigurationManager.AppSettings["allocBakDir"];
            string warehouse = System.Configuration.ConfigurationManager.AppSettings["warehouse"];

            allTask = new AllocTask(alldir, allbakdir, connectionstring,warehouse);
            string caldir = System.Configuration.ConfigurationManager.AppSettings["calDir"];
            string calbakdir = System.Configuration.ConfigurationManager.AppSettings["calBakDir"];

            calTask = new CalendarTask(caldir, calbakdir, connectionstring, warehouse);
        }

        protected override void OnStart(string[] args)
        {

            allTask.Start();
            calTask.Start();
        }

        protected override void OnStop()
        {
            allTask.Stop();
            calTask.Stop();
        }
    }
}
