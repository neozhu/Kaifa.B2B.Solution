using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kaifa.B2B.VendorAlloc;

namespace Kaifa.B2B.Import.Console
{
    class Program

    {
     

        static void Main(string[] args)
        {
            string connectionstring = System.Configuration.ConfigurationManager.AppSettings["connectionstring"];
            string alldir = System.Configuration.ConfigurationManager.AppSettings["allocDir"];
            string allbakdir = System.Configuration.ConfigurationManager.AppSettings["allocBakDir"];
            string warehouse = System.Configuration.ConfigurationManager.AppSettings["warehouse"];

             AllocTask allTask = new AllocTask(alldir, allbakdir, connectionstring, warehouse);
            string caldir = System.Configuration.ConfigurationManager.AppSettings["calDir"];
            string calbakdir = System.Configuration.ConfigurationManager.AppSettings["calBakDir"];

            CalendarTask calTask = new CalendarTask(caldir, calbakdir, connectionstring, warehouse);
            allTask.Start();
            calTask.Start();
            System.Console.ReadLine();

        }
    }
}
