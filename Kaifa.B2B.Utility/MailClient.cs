﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

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
                error = GetMsg(GetResponseDocument(doc));
                orderno = GetOrderNo(GetResponseDocument(doc));
            }
            string content = ConstructContent(pulllistNo, siteCode, RequestDate, Type, orderno, error);
            content = TemplateHTML().Replace("#Email Content#", content);

            SendSMTPMail("B2B HUB System Manager", "B2Badmin@kaifa.cn", new string[] { "KFSU-WSC-B2B@kaifa.cn", "huzhu@ataway.cn", "XiaoQinWang@kaifa.cn",  "HaiYangLi@kaifa.cn", "JessieZeng@kaifa.cn", "JieLingYe@kaifa.cn", "HuiYang@kaifa.cn", "YanPan@kaifa.cn", "LongWang@kaifa.cn", "KangZuWang@kaifa.cn", "QiangKong@kaifa.cn" }, siteCode + "-940-" + pulllistNo, content, null, true, "", "", "10.2.232.75");
            
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

        private static string GetMsg(XmlDocument doc)
        {

            XmlNode node = doc.DocumentElement.SelectSingleNode("/Message/Body/Result/ShipmentOrder/ShipmentOrderHeader/Msg");
            if (node != null)
            {
                return Regex.Replace(node.InnerText, @"\r\n?|\n", "<br />");  //node.InnerText.Replace("\r\n", "</br>");
            }
            else
            {
                return string.Empty;
            }
        }
        private static string TemplateHTML() {

            string templatestring = @"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Strict//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd'>
    <html xmlns='http://www.w3.org/1999/xhtml'>
        <head>
            <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
            <meta name='viewport' content='width=device-width'/>

            <!-- Framework: ink.css -->
            <style type='text/css'>
                #outlook a{padding:0}body{width:100%!important;min-width:100%;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%}.ExternalClass{width:100%}.ExternalClass,.ExternalClass div,.ExternalClass font,.ExternalClass p,.ExternalClass span,.ExternalClass td{line-height:100%}#backgroundTable{margin:0;padding:0;width:100%!important;line-height:100%!important}img{outline:0;text-decoration:none;-ms-interpolation-mode:bicubic;width:auto;max-width:100%;float:left;clear:both;display:block}center{width:100%;min-width:580px}a img{border:none}table{border-spacing:0;border-collapse:collapse}td{word-break:break-word;-webkit-hyphens:none;-moz-hyphens:none;hyphens:none;border-collapse:collapse!important}table,td,tr{padding:0;vertical-align:top;text-align:left}hr{color:#d9d9d9;background-color:#d9d9d9;height:1px;border:none}table.body{height:100%;width:100%}table.container{width:580px;margin:0 auto;text-align:inherit}table.row{padding:0;width:100%;position:relative}table.container table.row{display:block}td.wrapper{padding:10px 20px 0 0;position:relative}table.column,table.columns{margin:0 auto}table.column td,table.columns td{padding:0 0 10px}table.column td.sub-column,table.column td.sub-columns,table.columns td.sub-column,table.columns td.sub-columns{padding-right:10px}td.sub-column,td.sub-columns{min-width:0}table.container td.last,table.row td.last{padding-right:0}table.one{width:30px}table.two{width:80px}table.three{width:130px}table.four{width:180px}table.five{width:230px}table.six{width:280px}table.seven{width:330px}table.eight{width:380px}table.nine{width:430px}table.ten{width:480px}table.eleven{width:530px}table.twelve{width:580px}table.one center{min-width:30px}table.two center{min-width:80px}table.three center{min-width:130px}table.four center{min-width:180px}table.five center{min-width:230px}table.six center{min-width:280px}table.seven center{min-width:330px}table.eight center{min-width:380px}table.nine center{min-width:430px}table.ten center{min-width:480px}table.eleven center{min-width:530px}table.twelve center{min-width:580px}table.one .panel center{min-width:10px}table.two .panel center{min-width:60px}table.three .panel center{min-width:110px}table.four .panel center{min-width:160px}table.five .panel center{min-width:210px}table.six .panel center{min-width:260px}table.seven .panel center{min-width:310px}table.eight .panel center{min-width:360px}table.nine .panel center{min-width:410px}table.ten .panel center{min-width:460px}table.eleven .panel center{min-width:510px}table.twelve .panel center{min-width:560px}.body .column td.one,.body .columns td.one{width:8.333333%}.body .column td.two,.body .columns td.two{width:16.666666%}.body .column td.three,.body .columns td.three{width:25%}.body .column td.four,.body .columns td.four{width:33.333333%}.body .column td.five,.body .columns td.five{width:41.666666%}.body .column td.six,.body .columns td.six{width:50%}.body .column td.seven,.body .columns td.seven{width:58.333333%}.body .column td.eight,.body .columns td.eight{width:66.666666%}.body .column td.nine,.body .columns td.nine{width:75%}.body .column td.ten,.body .columns td.ten{width:83.333333%}.body .column td.eleven,.body .columns td.eleven{width:91.666666%}.body .column td.twelve,.body .columns td.twelve{width:100%}td.offset-by-one{padding-left:50px}td.offset-by-two{padding-left:100px}td.offset-by-three{padding-left:150px}td.offset-by-four{padding-left:200px}td.offset-by-five{padding-left:250px}td.offset-by-six{padding-left:300px}td.offset-by-seven{padding-left:350px}td.offset-by-eight{padding-left:400px}td.offset-by-nine{padding-left:450px}td.offset-by-ten{padding-left:500px}td.offset-by-eleven{padding-left:550px}td.expander{visibility:hidden;width:0;padding:0!important}table.column .text-pad,table.columns .text-pad{padding-left:10px;padding-right:10px}table.column .left-text-pad,table.column .text-pad-left,table.columns .left-text-pad,table.columns .text-pad-left{padding-left:10px}table.column .right-text-pad,table.column .text-pad-right,table.columns .right-text-pad,table.columns .text-pad-right{padding-right:10px}.block-grid{width:100%;max-width:580px}.block-grid td{display:inline-block;padding:10px}.two-up td{width:270px}.three-up td{width:173px}.four-up td{width:125px}.five-up td{width:96px}.six-up td{width:76px}.seven-up td{width:62px}.eight-up td{width:52px}h1.center,h2.center,h3.center,h4.center,h5.center,h6.center,p.center,table.center,td.center{text-align:center}span.center{display:block;width:100%;text-align:center}img.center{margin:0 auto;float:none}.hide-for-desktop,.show-for-small{display:none;width:0;mso-hide:all;overflow:hidden}.hide-for-desktop *,.show-for-small *{mso-hide:all}body,h1,h2,h3,h4,h5,h6,p,table.body,td{color:#222;font-family:Helvetica,Arial,sans-serif;font-weight:400;padding:0;margin:0;text-align:left;line-height:1.3}h1,h2,h3,h4,h5,h6{word-break:normal}h1{font-size:40px}h2{font-size:36px}h3{font-size:32px}h4{font-size:28px}h5{font-size:24px}h6{font-size:20px}body,p,table.body,td{font-size:14px;line-height:19px}p.lead,p.lede,p.leed{font-size:18px;line-height:21px}p{margin-bottom:10px}small{font-size:10px}a{color:#2ba6cb;text-decoration:none}a:active,a:hover{color:#2795b6!important}a:visited{color:#2ba6cb!important}h1 a,h2 a,h3 a,h4 a,h5 a,h6 a{color:#2ba6cb}h1 a:active,h1 a:visited,h2 a:active,h2 a:visited,h3 a:active,h3 a:visited,h4 a:active,h4 a:visited,h5 a:active,h5 a:visited,h6 a:active,h6 a:visited{color:#2ba6cb!important}.panel{background:#f2f2f2;border:1px solid #d9d9d9;padding:10px!important}.sub-grid table{width:100%}.sub-grid td.sub-columns{padding-bottom:0}table.button,table.large-button,table.medium-button,table.small-button,table.tiny-button{width:100%;overflow:hidden}table.button td,table.large-button td,table.medium-button td,table.small-button td,table.tiny-button td{display:block;width:auto!important;text-align:center;background:#2ba6cb;border:1px solid #2284a1;color:#fff;padding:8px 0;line-height:initial!important}table.tiny-button td{padding:5px 0}table.small-button td{padding:8px 0}table.medium-button td{padding:12px 0}table.large-button td{padding:21px 0}table.button td a,table.large-button td a,table.medium-button td a,table.small-button td a,table.tiny-button td a{font-weight:700;text-decoration:none;font-family:Helvetica,Arial,sans-serif;color:#fff;font-size:16px;display:block;height:100%;width:100%}table.tiny-button td a{font-size:12px;font-weight:400}table.small-button td a{font-size:16px}table.medium-button td a{font-size:20px}table.large-button td a{font-size:24px}table.button:active td,table.button:hover td,table.button:visited td{background:#2795b6!important}table.button:active td a,table.button:hover td a,table.button:visited td a{color:#fff!important}table.button:hover td,table.large-button:hover td,table.medium-button:hover td,table.small-button:hover td,table.tiny-button:hover td{background:#2795b6!important}table.button td a:visited,table.button:active td a,table.button:hover td a,table.large-button td a:visited,table.large-button:active td a,table.large-button:hover td a,table.medium-button td a:visited,table.medium-button:active td a,table.medium-button:hover td a,table.small-button td a:visited,table.small-button:active td a,table.small-button:hover td a,table.tiny-button td a:visited,table.tiny-button:active td a,table.tiny-button:hover td a{color:#fff!important}table.secondary td{background:#e9e9e9;border-color:#d0d0d0;color:#555}table.secondary td a{color:#555}table.secondary:hover td{background:#d0d0d0!important;color:#555}table.secondary td a:visited,table.secondary:active td a,table.secondary:hover td a{color:#555!important}table.success td{background:#5da423;border-color:#457a1a}table.success:hover td{background:#457a1a!important}table.alert td{background:#c60f13;border-color:#970b0e}table.alert:hover td{background:#970b0e!important}table.radius td{-webkit-border-radius:3px;-moz-border-radius:3px;border-radius:3px}table.round td{-webkit-border-radius:500px;-moz-border-radius:500px;border-radius:500px}body.outlook p{display:inline!important}@media only screen and (max-width:600px){table[class=body] img{max-width:auto!important;max-height:auto!important}table[class=body] center{min-width:0!important}table[class=body] .container{width:95%!important}table[class=body] .row{width:100%!important;display:block!important}table[class=body] .wrapper{display:block!important;padding-right:0!important}table[class=body] .column,table[class=body] .columns{table-layout:fixed!important;float:none!important;width:100%!important;padding-right:0!important;padding-left:0!important;display:block!important}table[class=body] .wrapper.first .column,table[class=body] .wrapper.first .columns{display:table!important}table[class=body] table.column td,table[class=body] table.columns td{width:100%!important}table[class=body] .column td.one,table[class=body] .columns td.one{width:8.333333%!important}table[class=body] .column td.two,table[class=body] .columns td.two{width:16.666666%!important}table[class=body] .column td.three,table[class=body] .columns td.three{width:25%!important}table[class=body] .column td.four,table[class=body] .columns td.four{width:33.333333%!important}table[class=body] .column td.five,table[class=body] .columns td.five{width:41.666666%!important}table[class=body] .column td.six,table[class=body] .columns td.six{width:50%!important}table[class=body] .column td.seven,table[class=body] .columns td.seven{width:58.333333%!important}table[class=body] .column td.eight,table[class=body] .columns td.eight{width:66.666666%!important}table[class=body] .column td.nine,table[class=body] .columns td.nine{width:75%!important}table[class=body] .column td.ten,table[class=body] .columns td.ten{width:83.333333%!important}table[class=body] .column td.eleven,table[class=body] .columns td.eleven{width:91.666666%!important}table[class=body] .column td.twelve,table[class=body] .columns td.twelve{width:100%!important}table[class=body] td.offset-by-eight,table[class=body] td.offset-by-eleven,table[class=body] td.offset-by-five,table[class=body] td.offset-by-four,table[class=body] td.offset-by-nine,table[class=body] td.offset-by-one,table[class=body] td.offset-by-seven,table[class=body] td.offset-by-six,table[class=body] td.offset-by-ten,table[class=body] td.offset-by-three,table[class=body] td.offset-by-two{padding-left:0!important}table[class=body] table.columns td.expander{width:1px!important}table[class=body] .right-text-pad,table[class=body] .text-pad-right{padding-left:10px!important}table[class=body] .left-text-pad,table[class=body] .text-pad-left{padding-right:10px!important}table[class=body] .hide-for-small,table[class=body] .show-for-desktop{display:none!important}table[class=body] .hide-for-desktop,table[class=body] .show-for-small{display:block!important;width:auto!important;overflow:visible!important}}
            </style>

            <!-- Your Custom CSS here -->
            <style type='text/css'>

            </style>

            <!-- Your mobile CSS here -->
            <style type='text/css'>
                @media only screen and (max-width: 600px) {

                }
            </style>
        </head>
        <body>
            <table class='body'>
                <tr>
                    <td class='center' align='center' valign='top'>
                        <center>
                            <br/>
                            <br/>
                            <!-- Email Content -->
                            #Email Content#
                        </center>
                    </td>
                </tr>
            </table>
        </body>
    </html>";


            return templatestring;
        }
        private static string ConstructContent(string pulllistNo, string siteCode, string RequestDate, string Type,string orderno,string error)
        { 
            string conntent=string.Format(@"<table border=1>
    <thead>
	<tr>
		<th>Date Time</th>
		<th>PullListNo#</th>
		<th>CM SITE</th>
		<th>Request DateTime</th>
		<th>TYPE</th>
		<th>HUB ORDER NO</th>
		<th>Error Message</th>
	</tr>
    </thead>
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
