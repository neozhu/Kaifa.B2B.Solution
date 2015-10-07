using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kaifa.B2B.Utility
{
    public  class MailClient
    {
        static MailClient()
        {
        }

        #region 使用MS发送SMTP邮件

        static public bool SendSMTPMail(string vFromName, string vFrom, string[] vTo, string vSubject, string vBodyText, string[] vAttachment, bool vHTML, string vEmailLoginUser, string vEmailLoginPwd, string vEmailHost)
        {
            #region
            bool blnReturn = false;
            try
            {
                // create  message
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

                // set sender
                if (vFrom == "" || vFrom == null) { return blnReturn; }
                message.From = new System.Net.Mail.MailAddress(vFrom, vFromName);

                // add a recipient
                foreach (string strTo in vTo) { message.To.Add(strTo); }

                // set the subject & body
                message.Subject = vSubject;
                message.IsBodyHtml = vHTML;
                message.Body = vBodyText;

                //add an attachment
                if (null != vAttachment)
                {
                    foreach (string strAttachment in vAttachment)
                    {
                        if (null != strAttachment && "" != strAttachment.Trim())
                        {
                            message.Attachments.Add(new System.Net.Mail.Attachment(strAttachment));
                        }
                    }
                }
                message.BodyEncoding = System.Text.Encoding.GetEncoding("gb2312");

                // send the message
                System.Net.Mail.SmtpClient client;
                if (string.IsNullOrEmpty(vEmailLoginUser))
                {
                    client = new System.Net.Mail.SmtpClient(vEmailHost);
                    client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                    client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    client.Timeout = 500;
                    client.EnableSsl = false;
                    client.Send(message);
                }
                else
                {

                    client = new System.Net.Mail.SmtpClient(vEmailHost);
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(vEmailLoginUser, vEmailLoginPwd);
                    client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    //client.UseDefaultCredentials = true;
                    client.EnableSsl = true;

                    //client.Timeout = 5000;
                    client.Send(message);

                }

                blnReturn = true;
            }
            catch (Exception ex)
            {
                //WriteLogInfo(string.Format("邮件发送出现异常，异常信息为：{0}", ex.Message), "SendSMTPMail");
            }
            return blnReturn;
            #endregion
        }

        #endregion







        static public void Send940NotificationMail(XmlDocument doc, string pulllistNo, string siteCode, string RequestDate, string Type)
        {
            string orderno = "";
            string error = GetError(GetResponseDocument(doc));
            if (string.IsNullOrEmpty(error))
            {
                orderno = GetOrderNo(GetResponseDocument(doc));
            }
            string content = ConstructContent(pulllistNo, siteCode, RequestDate, Type, orderno, error);
            SendSMTPMail("B2B HUB System Manager", "B2Badmin@kaifa.cn", new string[] { "huzhu@ataway.cn" }, siteCode + "-940-" + pulllistNo, content, null, true, "", "", "10.2.232.75");
            
        }

        private static XmlDocument GetResponseDocument(XmlDocument doc)
        {
        
            string responsexml = doc.DocumentElement.ChildNodes[0].InnerText;
            XmlDocument resDoc = new XmlDocument();
            resDoc.LoadXml(responsexml);
            return resDoc;
        }

        private static string GetError(XmlDocument doc)
        {
            XmlNode node = doc.DocumentElement.SelectSingleNode("/Message/Body/Error");
            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                return string.Empty;
            }
        }

        private static string GetOrderNo(XmlDocument doc) {

            XmlNode node = doc.DocumentElement.SelectSingleNode("/Message/Body/Result/ShipmentOrder/ShipmentOrderHeader/OrderKey");
            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                return string.Empty;
            }
        }

        private static string ConstructContent(string pulllistNo, string siteCode, string RequestDate, string Type,string orderno,string error)
        { 
            string conntent=string.Format(@"<table border=1>
	<tr>
		<td><b>Date Time</b></td>
		<td><b>PullListNo#</b></td>
		<td><b>CM SITE</b></td>
		<td><b>Request DateTime</b></td>
		<td><b>TYPE</b></td>
		<td><b>HUB ORDER NO</b></td>
		<td><b>Error Message</b></td>
	</tr>
	<tr>
		<td>{0}</td>
		<td>{1}</td>
		<td>{2}</td>
		<td>{3}</td>
		<td>{4}</td>
		<td>{5}</td>
		<td>{6}</td>
	</tr>
</table>", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
            pulllistNo,
            siteCode,
            RequestDate,
            Type,
            orderno,
            error

            );
            return conntent;
        }




    }
}
