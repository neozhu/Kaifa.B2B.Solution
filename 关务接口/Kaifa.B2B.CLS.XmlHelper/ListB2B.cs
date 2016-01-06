using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Configuration;
namespace Kaifa.B2B.CLS.XmlHelper
{
    public class ListB2B
    {

        public static void Read(XmlDocument xml)
        {
            List<DecModel> list = new List<DecModel>();
            //XNamespace ns = "HTTP://CLIS.HB_DEC";

            using (var nodeReader = new XmlNodeReader(xml))
            {
                nodeReader.MoveToContent();
                XDocument xdoc= XDocument.Load(nodeReader);

                var orderno = xdoc.Descendants("ERP_OBJECT_ID").First().Value;
                var preno = xdoc.Descendants("PRE_GATEPASS_NO").First().Value;
                var gatepassno = xdoc.Descendants("GATEPASS_NO").First().Value;

                if (orderno.Length > 0 && gatepassno.Length > 0)
                {
                    SqlHelper.UpdateCLSStatus(orderno, gatepassno
                        );
                }

                
               

            }
        }
    }
}
