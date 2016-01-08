using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return template;
        
        }
    }
}
