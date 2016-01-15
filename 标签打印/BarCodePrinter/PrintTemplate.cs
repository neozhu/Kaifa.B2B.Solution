using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BarCodePrinter
{
    public class PrintTemplate
    {
        public static string Generate3PL(string printname,
            string cop,
            string po,
            string DO,
            string pn,
            string qty,
            string trace,
            string gts,
            string coo
        ) {
            string template = string.Format(Properties.Resources.kf3pl,
                printname, cop, po, DO, pn, qty, trace, gts,coo);


            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"Templates");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            
            path=Path.Combine(path,"_3pl_" + System.Guid.NewGuid().ToString() + ".xml");

            using (StreamWriter sw = new StreamWriter(path,false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(template);
                sw.Close();
            }
            return path;
        
        }



        public static string GenerateSTX(string printname,
            string cop,
            string part,
            string qty,
            string lot,
            string asl,
            string ven,
            string trace,
            string dcode
        )
        {
            string template = string.Format(Properties.Resources.stxpl,
                printname, cop, part, qty, lot, asl, ven, trace, dcode);

            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"Templates");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path=Path.Combine(path,"_STX_" + System.Guid.NewGuid().ToString() + ".xml");

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(template);
                sw.Close();
            }
            return path;
            //return template;

        }
    }
}
