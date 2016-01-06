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
    public class HBDec
    {

        public static void Read(XmlDocument xml)
        {
            List<DecModel> list = new List<DecModel>();
            XNamespace ns = "HTTP://CLIS.HB_DEC";

            using (var nodeReader = new XmlNodeReader(xml))
            {
                nodeReader.MoveToContent();
                XDocument xdoc= XDocument.Load(nodeReader);

                var seqNo = xdoc.Descendants(ns + "SEQ_NO").First().Value;
                var entryId = xdoc.Descendants(ns + "ENTRY_ID").First().Value;
                var ieFlag = xdoc.Descendants(ns + "I_E_FLAG").First().Value;

                foreach (var element in xdoc.Descendants(ns + "HB_DEC_LIST"))
                {
                    Console.WriteLine(element.Element(ns + "COP_G_NO").Value, element.Element(ns + "QTY").Value);
                    DecModel item = new DecModel();
                    item.EntryId = entryId;
                    item.SeqNo = seqNo;
                    item.IEFlag = ieFlag;
                    item.GNo = element.Element(ns + "COP_G_NO").Value;
                    item.Qty = Convert.ToDecimal(element.Element(ns + "QTY").Value);
                    list.Add(item);
                }

                if (list.Count > 0)
                {
                    SqlHelper.Insert(list);
                }
               

            }
        }
    }
}
