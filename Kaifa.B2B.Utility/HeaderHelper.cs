using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Solutions.BTARN.Shared;

namespace Kaifa.B2B.Utility
{
    public class HeaderHelper
    {
        static HeaderHelper()
        {
        }
        /// <summary>
        /// 生成WMS web service Request XML
        /// </summary>
        /// <param name="RequestType"></param>
        /// <param name="MessageType"></param>
        /// <param name="RequestMethod"></param>
        /// <param name="XmlString"></param>
        /// <returns></returns>

        static public XmlDocument GenerateInforRequest(string RequestType, string MessageType, string RequestMethod, string XmlString) {
            string content = string.Format("<ns0:callBackEnd xmlns:ns0=\"http://com.ssaglobal.com\"><ns0:in0>{0}</ns0:in0><ns0:in1>{1}</ns0:in1><ns0:in2>{2}</ns0:in2><ns0:in3>{3}</ns0:in3>  </ns0:callBackEnd>",
                RequestType, MessageType, RequestMethod, XmlString);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            return doc;
        }


        static public void AssignmentInforRequest(XmlDocument doc, string RequestType, string MessageType, string RequestMethod, string XmlString)
        {
            string content = string.Format("<callBackEnd xmlns=\"http://com.ssaglobal.com\"><in0>{0}</in0><in1>{1}</in1><in2>{2}</in2><in3></in3> </callBackEnd>",
                RequestType, MessageType, RequestMethod, XmlString);

            doc.LoadXml(content);

            XmlNode el = doc.DocumentElement.ChildNodes[3];
            el.InnerText = XmlString;

        }



        /// <summary>
        /// 将收到的标准RosettaNetXML数据转换为MS要求的XML数据
        /// </summary>
        /// <param name="strInput">RosettaNet数据</param>
        /// <param name="pipCode">要处理的PIP</param>
        /// <param name="vVersion">要处理的PIP的RosettaNetXML数据版本号</param>
        /// <returns>MS要求的XML数据对象XmlDocument</returns>
        static public XmlDocument ReturnXmlForStringInput(string strInput, string pipCode, string vVersion)
        {
            #region
            try
            {
                XmlDocument xDoc = new XmlDocument();
                string strPIP = pipCode + vVersion;
                strPIP = strPIP.Replace(".", "");

                #region Testing PIP
                if (strInput.Contains("Pip0C2AsynchronousTestRequest"))
                {
                    switch (strPIP.ToUpper().Trim())
                    {
                        case "0C2":
                            strInput = strInput.Replace("<!DOCTYPE Pip0C2AsynchronousTestRequest SYSTEM \"0C2_MS_R01_02_AsynchronousTestRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip0C2AsynchronousTestRequest>", "<Pip0C2AsynchronousTestRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/0C2_MS_R01_02_AsynchronousTestRequest.dtd\">");
                            break;
                    }
                }
                if (strInput.Contains("Pip0C2AsynchronousTestConfirmation"))
                {
                    switch (strPIP.ToUpper().Trim())
                    {
                        case "0C2":
                            strInput = strInput.Replace("<!DOCTYPE Pip0C2AsynchronousTestConfirmation SYSTEM \"0C2_MS_R01_02_AsynchronousTestConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip0C2AsynchronousTestConfirmation>", "<Pip0C2AsynchronousTestConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/0C2_MS_R01_02_AsynchronousTestConfirmation.dtd\">");
                            break;
                    }
                }

                #endregion

                #region PIP3A4
                if (strInput.Contains("Pip3A4PurchaseOrderConfirmation"))
                {
                    #region
                    switch (strPIP.ToUpper().Trim())
                    {
                        case "3A4V0200":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_00_PurchaseOrderConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderConfirmation>", "<Pip3A4PurchaseOrderConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_00_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0201":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_01_PurchaseOrderConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderConfirmation>", "<Pip3A4PurchaseOrderConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_01_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0202":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_02_PurchaseOrderConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderConfirmation>", "<Pip3A4PurchaseOrderConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0203":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_03_PurchaseOrderConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderConfirmation>", "<Pip3A4PurchaseOrderConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_03_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0204":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_04_PurchaseOrderConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderConfirmation>", "<Pip3A4PurchaseOrderConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_04_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0205":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_05_PurchaseOrderConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderConfirmation>", "<Pip3A4PurchaseOrderConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_05_PurchaseOrderConfirmation.dtd\">");
                            break;
                    }
                    #endregion
                }
                if (strInput.Contains("Pip3A4PurchaseOrderRequest"))
                {
                    #region
                    switch (strPIP.ToUpper().Trim())
                    {
                        case "3A4V0200":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_00_PurchaseOrderRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_00_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0201":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_01_PurchaseOrderRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_01_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0202":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_02_PurchaseOrderRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0203":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_03_PurchaseOrderRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_03_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0204":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_04_PurchaseOrderRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_04_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0205":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_05_PurchaseOrderRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A4PurchaseOrderRequest>", "<Pip3A4PurchaseOrderRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_05_PurchaseOrderRequest.dtd\">");
                            break;
                    }
                    #endregion
                }
                #endregion

                #region PIP3A7
                switch (strPIP.ToUpper().Trim())
                {
                    case "3A7V0200":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_00_PurchaseOrderUpdateNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A7PurchaseOrderUpdateNotification>", "<Pip3A7PurchaseOrderUpdateNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A7_MS_V02_00_PurchaseOrderUpdateNotification.dtd\">");
                        break;
                    case "3A7V0201":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_01_PurchaseOrderUpdateNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A7PurchaseOrderUpdateNotification>", "<Pip3A7PurchaseOrderUpdateNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A7_MS_V02_01_PurchaseOrderUpdateNotification.dtd\">");
                        break;
                    case "3A7V0202":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_02_PurchaseOrderUpdateNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A7PurchaseOrderUpdateNotification>", "<Pip3A7PurchaseOrderUpdateNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A7_MS_V02_02_PurchaseOrderUpdateNotification.dtd\">");
                        break;
                    case "3A7V0203":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_03_PurchaseOrderUpdateNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A7PurchaseOrderUpdateNotification>", "<Pip3A7PurchaseOrderUpdateNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A7_MS_V02_03_PurchaseOrderUpdateNotification.dtd\">");
                        break;
                    case "3A7V0204":
                        strInput = strInput.Replace("<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_04_PurchaseOrderUpdateNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3A7PurchaseOrderUpdateNotification>", "<Pip3A7PurchaseOrderUpdateNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A7_MS_V02_04_PurchaseOrderUpdateNotification.dtd\">");
                        break;
                }
                #endregion

                #region PIP3A8
                if (strInput.Contains("Pip3A8PurchaseOrderChangeRequest"))
                {
                    #region
                    switch (strPIP.ToUpper().Trim())
                    {
                        case "3A8V0100":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_00_PurchaseOrderChangeRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeRequest>", "<Pip3A8PurchaseOrderChangeRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_00_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0101":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_01_PurchaseOrderChangeRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeRequest>", "<Pip3A8PurchaseOrderChangeRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_01_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0102":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_02_PurchaseOrderChangeRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeRequest>", "<Pip3A8PurchaseOrderChangeRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_02_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0103":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_03_PurchaseOrderChangeRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeRequest>", "<Pip3A8PurchaseOrderChangeRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_03_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0104":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_04_PurchaseOrderChangeRequest.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeRequest>", "<Pip3A8PurchaseOrderChangeRequest xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_04_PurchaseOrderChangeRequest.dtd\">");
                            break;
                    }
                    #endregion
                }
                if (strInput.Contains("Pip3A8PurchaseOrderChangeConfirmation"))
                {
                    #region
                    switch (strPIP.ToUpper().Trim())
                    {
                        case "3A8V0100":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_00_PurchaseOrderChangeConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeConfirmation>", "<Pip3A8PurchaseOrderChangeConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_00_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0101":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_01_PurchaseOrderChangeConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeConfirmation>", "<Pip3A8PurchaseOrderChangeConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_01_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0102":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_02_PurchaseOrderChangeConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeConfirmation>", "<Pip3A8PurchaseOrderChangeConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_02_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0103":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_03_PurchaseOrderChangeConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeConfirmation>", "<Pip3A8PurchaseOrderChangeConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_03_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0104":
                            strInput = strInput.Replace("<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_04_PurchaseOrderChangeConfirmation.dtd\">", String.Empty);
                            strInput = strInput.Replace("<Pip3A8PurchaseOrderChangeConfirmation>", "<Pip3A8PurchaseOrderChangeConfirmation xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3A8_MS_V01_04_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                    }
                    #endregion
                }
                #endregion

                #region PIP3A9
                #endregion

                #region PIP3C3
                switch (strPIP.ToUpper().Trim())
                {
                    case "3C3V0100":
                        strInput = strInput.Replace("<!DOCTYPE Pip3C3InvoiceNotification SYSTEM \"3C3_MS_V01_00_InvoiceNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3C3InvoiceNotification>", "<Pip3C3InvoiceNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3C3_MS_V01_00_InvoiceNotification.dtd\">");
                        break;
                    case "3C3V0101":
                        strInput = strInput.Replace("<!DOCTYPE Pip3C3InvoiceNotification SYSTEM \"3C3_MS_V01_01_InvoiceNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3C3InvoiceNotification>", "<Pip3C3InvoiceNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3C3_MS_V01_01_InvoiceNotification.dtd\">");
                        break;
                    case "3C3V0102":
                        strInput = strInput.Replace("<!DOCTYPE Pip3C3InvoiceNotification SYSTEM \"3C3_MS_V01_02_InvoiceNotification.dtd\">", String.Empty);
                        strInput = strInput.Replace("<Pip3C3InvoiceNotification>", "<Pip3C3InvoiceNotification xmlns=\"http://schemas.microsoft.com/biztalk/btarn/2004/3C3_MS_V01_02_InvoiceNotification.dtd\">");
                        break;
                }
                #endregion

                #region PIP3B2
                #endregion

                #region PIP4C1
                #endregion

                #region 去掉namespace前缀
                strInput = strInput.Replace("xml:", String.Empty);
                strInput = strInput.Replace("b:", String.Empty);
                strInput = strInput.Replace("lang:", String.Empty);
                strInput = strInput.Replace("ns1:", String.Empty);
                #endregion

                xDoc.LoadXml(strInput);

                return xDoc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            #endregion
        }


        /// <summary>
        /// 将收到的MS XML数据转换成标准的RosettaNetXML数据
        /// </summary>
        /// <param name="xmlDoc">MS标准的XML数据对象XmlDocument（来源于Orchestration的）</param>
        /// <param name="pipCode">要处理的PIP，包含版本号</param>
        /// <returns></returns>
        static public string ReturnSCWithDocType(XmlDocument xmlDoc, string pipCode)
        {
            #region
            try
            {
                string sResponse = xmlDoc.InnerXml;
                sResponse = sResponse.Replace("ns0:", String.Empty);
                xmlDoc.LoadXml(sResponse);
                xmlDoc.DocumentElement.RemoveAllAttributes();
                sResponse = xmlDoc.InnerXml;

                //去掉<?xml version="1.0" encoding="UTF-8" ?>
                sResponse = RemoveXMLHeader(sResponse);

                #region Testing PIP
                if (sResponse.Contains("Pip0C2AsynchronousTestRequest"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip0C2AsynchronousTestRequest");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "0C2":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C2AsynchronousTestRequest SYSTEM \"0C2_MS_R01_02_AsynchronousTestRequest.dtd\">");
                            break;
                    }
                    #endregion
                }
                if (sResponse.Contains("Pip0C2AsynchronousTestConfirmation"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip0C2AsynchronousTestConfirmation");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "0C2":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip0C2AsynchronousTestConfirmation SYSTEM \"0C2_MS_R01_02_AsynchronousTestConfirmation.dtd\">");
                            break;
                    }
                    #endregion
                }
                #endregion

                #region PIP3A4
                if (sResponse.Contains("Pip3A4PurchaseOrderRequest"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip3A4PurchaseOrderRequest");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A4V0200":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_00_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0201":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_01_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0202":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_02_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0203":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_03_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0204":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_04_PurchaseOrderRequest.dtd\">");
                            break;
                        case "3A4V0205":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderRequest SYSTEM \"3A4_MS_V02_05_PurchaseOrderRequest.dtd\">");
                            break;
                    }
                    #endregion
                }
                if (sResponse.Contains("Pip3A4PurchaseOrderConfirmation"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip3A4PurchaseOrderConfirmation");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A4V0200":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_00_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0201":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_01_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0202":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_02_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0203":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_03_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0204":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_04_PurchaseOrderConfirmation.dtd\">");
                            break;
                        case "3A4V0205":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A4PurchaseOrderConfirmation SYSTEM \"3A4_MS_V02_05_PurchaseOrderConfirmation.dtd\">");
                            break;
                    }
                    #endregion
                }
                #endregion

                #region PIP3A7
                if (sResponse.Contains("Pip3A7PurchaseOrderUpdateNotification"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip3A7PurchaseOrderUpdateNotification");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A7V0200":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_00_PurchaseOrderUpdateNotification.dtd\">");
                            break;
                        case "3A7V0201":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_01_PurchaseOrderUpdateNotification.dtd\">");
                            break;
                        case "3A7V0202":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_02_PurchaseOrderUpdateNotification.dtd\">");
                            break;
                        case "3A7V0203":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_03_PurchaseOrderUpdateNotification.dtd\">");
                            break;
                        case "3A7V0204":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A7PurchaseOrderUpdateNotification SYSTEM \"3A7_MS_V02_04_PurchaseOrderUpdateNotification.dtd\">");
                            break;
                    }
                    #endregion
                }
                #endregion

                #region PIP3A8
                if (sResponse.Contains("Pip3A8PurchaseOrderChangeRequest"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip3A8PurchaseOrderChangeRequest");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A8V0100":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_00_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0101":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_01_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0102":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_02_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0103":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_03_PurchaseOrderChangeRequest.dtd\">");
                            break;
                        case "3A8V0104":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeRequest SYSTEM \"3A8_MS_V01_04_PurchaseOrderChangeRequest.dtd\">");
                            break;
                    }
                    #endregion
                }
                if (sResponse.Contains("Pip3A8PurchaseOrderChangeConfirmation"))
                {
                    #region
                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip3A8PurchaseOrderChangeConfirmation");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3A8V0100":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_00_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0101":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_01_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0102":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_02_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0103":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_03_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                        case "3A8V0104":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3A8PurchaseOrderChangeConfirmation SYSTEM \"3A8_MS_V01_04_PurchaseOrderChangeConfirmation.dtd\">");
                            break;
                    }
                    #endregion
                }
                #endregion

                #region PIP3A9
                #endregion

                #region PIP3C3
                #endregion

                #region PIP3B2
                if (sResponse.Contains("Pip3B2AdvanceShipmentNotification"))
                {
                    #region

                    sResponse = sResponse.Replace("ns1:lang=\"en-US\" xmlns:ns1=\"http://www.w3.org/XML/1998/namespace\"", string.Empty);

                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip3B2AdvanceShipmentNotification");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "3B2V0100":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3B2AdvanceShipmentNotification SYSTEM \"3B2_MS_V01_00_AdvanceShipmentNotification.dtd\">");
                            break;
                        case "3B2V0101":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3B2AdvanceShipmentNotification SYSTEM \"3B2_MS_V01_01_AdvanceShipmentNotification.dtd\">");
                            break;
                        case "3B2V0102":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3B2AdvanceShipmentNotification SYSTEM \"3B2_MS_V01_02_AdvanceShipmentNotification.dtd\">");
                            break;
                        case "3B2SG0100":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip3B2AdvanceShipmentNotification SYSTEM \"SG3B2_AdvanceShipmentNotification.dtd\">");
                            break;

                    }
                    #endregion
                }
                #endregion

                #region PIP4C1
                if (sResponse.Contains("Pip4C1InventoryReportNotification"))
                {
                    #region
                    sResponse = sResponse.Replace("ns1:lang=\"en-US\" xmlns:ns1=\"http://www.w3.org/XML/1998/namespace\"", string.Empty);

                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip4C1InventoryReportNotification");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "4C1V0200":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4C1InventoryReportNotification SYSTEM \"4C1_MS_V02_00_InventoryReportNotification.dtd\">");
                            break;
                        case "4C1V0201":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4C1InventoryReportNotification SYSTEM \"4C1_MS_V02_01_InventoryReportNotification.dtd\">");
                            break;
                        case "4C1V0202":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4C1InventoryReportNotification SYSTEM \"4C1_MS_V02_02_InventoryReportNotification.dtd\">");
                            break;
                        case "4C1V0203":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4C1InventoryReportNotification SYSTEM \"4C1_MS_V02_03_InventoryReportNotification.dtd\">");
                            break;
                        case "4C1V0206":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4C1InventoryReportNotification SYSTEM \"4C1_MS_V02_06_InventoryReportNotification.dtd\">");
                            break;
                        case "4C1R0200":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4C1InventoryReportNotification SYSTEM \"4C1_MS_R02_00_InventoryReportNotification.dtd\">");
                            break;

                    }
                    #endregion

                   

                }
                #endregion

                 #region PIP4B2
                if (sResponse.Contains("Pip4B2ShipmentReceiptNotification"))
                {
                    #region
                    sResponse = sResponse.Replace("ns1:lang=\"en-US\" xmlns:ns1=\"http://www.w3.org/XML/1998/namespace\"", string.Empty);

                    //更改MS的Root为RosettaNet要求的Root
                    sResponse = ReplaceMSPIPRootToRNPIPRoot(sResponse, "Pip4B2ShipmentReceiptNotification");

                    switch (pipCode.ToUpper().Trim())
                    {
                        case "4B2V0100":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4B2ShipmentReceiptNotification SYSTEM \"4B2_MS_V01_00_ShipmentReceiptNotification.dtd\">");
                            break;
                        case "4B2V0101":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4B2ShipmentReceiptNotification SYSTEM \"4B2_MS_V01_01_ShipmentReceiptNotification.dtd\">");
                            break;
                        case "4B2V0202":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4B2ShipmentReceiptNotification SYSTEM \"4B2_MS_V02_02_ShipmentReceiptNotification.dtd\">");
                            break;
                        case "4B2V0203":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4B2ShipmentReceiptNotification SYSTEM \"4B2_MS_V02_03_ShipmentReceiptNotification.dtd\">");
                            break;
                        case "4B2V0206":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4B2ShipmentReceiptNotification SYSTEM \"4B2_MS_V02_06_ShipmentReceiptNotification.dtd\">");
                            break;
                        case "4B2SG0100":
                            sResponse = sResponse.Insert(0, "<!DOCTYPE Pip4B2ShipmentReceiptNotification SYSTEM \"SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification.dtd\">");
                            break;

                    }
                    #endregion
                }
                 #endregion

                #region 去掉namespace前缀

                sResponse = sResponse.Replace("ns0:", String.Empty);
                sResponse = sResponse.Replace("b:", String.Empty);
                sResponse = sResponse.Replace("lang:", String.Empty);
                sResponse = sResponse.Replace("ns1:", String.Empty);
                sResponse = sResponse.Replace("ns2:", String.Empty);

                #endregion

                return sResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            #endregion
        }



        /// <summary>
        /// 去除xmlheader内容（如：<?xml version="1.0" encoding="UTF-8" ?>）
        /// 如果不符合要求则直接返回XML数据，不做任何处理
        /// </summary>
        /// <param name="vXMLContent">xml数据</param>
        /// <returns></returns>
        static public string RemoveXMLHeader(string vXMLContent)
        {
            #region
            int intHeaderEnd = 0;
            const string XMLHeaderStartWith = "<?xml";
            const string XMLHeaderEndWith = "?>";

            if (string.IsNullOrEmpty(vXMLContent))
            {
                return string.Empty;
            }
            else
            {
                //将xml字串的两端的空格去掉
                vXMLContent = vXMLContent.Trim();

                //以下的处理判断，如果不符合要求则直接返回XML数据，不做任何处理
                if (vXMLContent.StartsWith(XMLHeaderStartWith))
                {
                    //获取xml头的开始和结束位置
                    intHeaderEnd = vXMLContent.IndexOf(XMLHeaderEndWith, XMLHeaderStartWith.Length);

                    if (intHeaderEnd > XMLHeaderStartWith.Length)
                    {
                        vXMLContent = vXMLContent.Substring(intHeaderEnd + XMLHeaderEndWith.Length);
                    }
                }

                //返回xml数据
                return vXMLContent;
            }
            #endregion
        }

        /// <summary>
        /// 将PIP的Root改为RosettaNet要求的标签
        /// 如果不符合要求则直接返回XML数据，不做任何处理
        /// </summary>
        /// <param name="vXMLContent"></param>
        /// <param name="vPIPRoot"></param>
        /// <returns></returns>
        static public string ReplaceMSPIPRootToRNPIPRoot(string vXMLContent, string vPIPRoot)
        {
            #region
            int intRootEnd = 0;
            const string XMLRootStartWith = "<ns";
            const string XMLRootEndWith = ">";

            if (string.IsNullOrEmpty(vXMLContent))
            {
                return string.Empty;
            }
            else
            {
                //将xml字串的两端的空格去掉
                vXMLContent = vXMLContent.Trim();

                //以下的处理判断，如果不符合要求则直接返回XML数据，不做任何处理
                if (vXMLContent.StartsWith(XMLRootStartWith))
                {
                    //获取xml头的开始和结束位置
                    intRootEnd = vXMLContent.IndexOf(XMLRootEndWith, XMLRootStartWith.Length);

                    if (intRootEnd > XMLRootStartWith.Length)
                    {
                        vXMLContent = string.Format("<{0}>", vPIPRoot) + vXMLContent.Substring(intRootEnd + XMLRootEndWith.Length);
                    }
                }

                //返回xml数据
                return vXMLContent;
            }
            #endregion
        }



        static public XmlDocument RemoveNamespace(XmlDocument xmlDoc)
        {

            string sResponse = xmlDoc.InnerXml;
            sResponse = sResponse.Replace("ns0:", String.Empty);
            xmlDoc.LoadXml(sResponse);
            xmlDoc.DocumentElement.RemoveAllAttributes();
            return xmlDoc;
        }

        static public string ReturnStringRemoveNamespace(XmlDocument xmlDoc)
        {

            string sResponse = xmlDoc.InnerXml;
            sResponse = sResponse.Replace("ns0:", String.Empty);
            xmlDoc.LoadXml(sResponse);
            xmlDoc.DocumentElement.RemoveAllAttributes();
            return xmlDoc.InnerXml;
        }

        static public XmlDocument ReturnXmlDocumentFromString(string xmlcontent) {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlcontent);
            return doc;
        }

        static public string pipInstanceIdentifier(XmlDocument doc)
        {
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("ns0", doc.DocumentElement.NamespaceURI);
            XmlNode node = doc.DocumentElement.SelectSingleNode("descendant::ns0:thisDocumentIdentifier/ns0:ProprietaryDocumentIdentifier", ns);
            return node.InnerText;  
        }



        static public string InvokeWebService() {
            return "";
        }
    }
}