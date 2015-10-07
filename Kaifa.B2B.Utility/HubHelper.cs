using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Solutions.BTARN.Shared;
using System.Xml;

namespace Kaifa.B2B.Utility
{
    public class HubHelper
    {
        static HubHelper()
        {
        }

        static public XmlDocument ReturnXmlForStringInput(string strInput, string pipCode)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                //				strInput = strInput.Replace("<![CDATA[",String.Empty);
                //				strInput = strInput.Replace("]]>",String.Empty);

                switch (pipCode.ToUpper().Trim())
                {
                    case "3A4":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_02_PurchaseOrderRequest.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd\">");
                        break;

                    case "3A2":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A2PriceAndAvailabilityQuery SYSTEM \"3A2PriceAndAvailabilityQueryMessageGuideline_v1_3.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A2PriceAndAvailabilityQuery>", "<Pip3A2PriceAndAvailabilityQuery xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityQueryMessageGuideline_v1_3.dtd\">");
                        break;

                    case "0C2":
                        strInput = strInput.Replace("<!DOCTYPE Pip0C2AsynchronousTestRequest SYSTEM \"0C2_MS_R01_02_AsynchronousTestRequest.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip0C2AsynchronousTestRequest>", "<Pip0C2AsynchronousTestRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/0C2_MS_R01_02_AsynchronousTestRequest.dtd\">");
                        break;

                    case "0C4":
                        strInput = strInput.Replace("<!DOCTYPE Pip0C4SynchronousTestQuery SYSTEM \"0C4_MS_R01_02_SynchronousTestQuery.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip0C4SynchronousTestQuery>", "<Pip0C4SynchronousTestQuery xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/0C4_MS_R01_02_SynchronousTestQuery.dtd\">");
                        break;

                    case "0C1":
                        strInput = strInput.Replace("<!DOCTYPE Pip0C1AsynchronousTestNotification SYSTEM \"0C1_MS_R01_02_AsynchronousTestNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip0C1AsynchronousTestNotification>", "<Pip0C1AsynchronousTestNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd\">");
                        break;
                }
                strInput = strInput.Replace("xml:", String.Empty);
                strInput = strInput.Replace("b:", String.Empty);
                strInput = strInput.Replace("lang:", String.Empty);
                strInput = strInput.Replace("ns1:", String.Empty);

                xDoc.LoadXml(strInput);
                //				xDoc.DocumentElement.RemoveAllAttributes();

                return xDoc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public string ReturnSCWithDocType(XmlDocument xmlDoc, int category, string pipCode)
        {
            try
            {
                string sResponse = xmlDoc.InnerXml;
                sResponse = sResponse.Replace("ns0:", String.Empty);
                xmlDoc.LoadXml(sResponse);
                xmlDoc.DocumentElement.RemoveAllAttributes();
                sResponse = xmlDoc.InnerXml;

                if (category == MessageCategory.AsyncAction)
                {
                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A4":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_02_PurchaseOrderRequest.dtd\">");
                            break;

                        case "3A2":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A2PriceAndAvailabilityQuery SYSTEM \"3A2PriceAndAvailabilityQueryMessageGuideline_v1_3.dtd\">");
                            break;

                        case "0C2":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C2AsynchronousTestRequest SYSTEM \"0C2_MS_R01_02_AsynchronousTestRequest.dtd\">");
                            break;

                        case "0C1":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C1AsynchronousTestNotification SYSTEM \"0C1_MS_R01_02_AsynchronousTestNotification.dtd\">");
                            break;

                        case "0C4":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C4SynchronousTestQuery SYSTEM \"0C4_MS_R01_02_SynchronousTestQuery.dtd\">");
                            break;
                        
                    }
                }
                else
                {
                    //Response
                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A4":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_02_PurchaseOrderConfirmation.dtd\">");
                            break;

                        case "3A2":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A2PriceAndAvailabilityResponse SYSTEM \"3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd\">");
                            break;

                        case "0C2":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C2AsynchronousTestConfirmation SYSTEM \"0C2_MS_R01_02_AsynchronousTestConfirmation.dtd\">");
                            break;

                        case "0C4":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C4SynchronousTestResponse SYSTEM \"0C4_MS_R01_02_SynchronousTestResponse.dtd\">");
                            break;
                    }
                }

                sResponse = sResponse.Replace("ns0:", String.Empty);
                sResponse = sResponse.Replace("b:", String.Empty);
                sResponse = sResponse.Replace("lang:", String.Empty);
                sResponse = sResponse.Replace("ns1:", String.Empty);

                return sResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        static public XmlDocument RemoveNamespace(XmlDocument xmlDoc)
        {

            string sResponse = xmlDoc.InnerXml;
            sResponse = sResponse.Replace("ns0:", String.Empty);
            xmlDoc.LoadXml(sResponse);
            xmlDoc.DocumentElement.RemoveAllAttributes();
            return xmlDoc;
        }

        public static string GetNameFromDuns(string duns)
        {
            PartyLookup p = new PartyLookup(duns, PartyLookupField.DUNS);
            return p.Name;
        }
    }
}
