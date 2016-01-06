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
    public class DisB2B
    {

        public static void Read(XmlDocument xml)
        {
            List<DecModel> list = new List<DecModel>();
            //XNamespace ns = "HTTP://CLIS.HB_DEC";

            using (var nodeReader = new XmlNodeReader(xml))
            {
                nodeReader.MoveToContent();
                XDocument xdoc= XDocument.Load(nodeReader);

                var seqNo = xdoc.Descendants("PRE_GATEPASS_NO").First().Value;
                var entryId = xdoc.Descendants("PASS_NO").First().Value;
                var ieFlag = xdoc.Descendants("IE_MARK").First().Value;

                foreach (var element in xdoc.Descendants("DIS_B2B_BODY_ORG"))
                {
                    Console.WriteLine(element.Element("PART_NO").Value, element.Element("COMMON_NUM").Value);
                    DecModel item = new DecModel();
                    item.EntryId = entryId;
                    item.SeqNo = seqNo;
                    item.IEFlag = ieFlag;
                    item.GNo = element.Element("PART_NO").Value;
                    item.Qty = Convert.ToDecimal(element.Element("COMMON_NUM").Value);
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
