using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Configuration;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public static class ConfigHelper
    {
        public static XElement GetRoleElement(string configpath,string parten,string roleType)
        {
            //string configpath = System.Configuration.ConfigurationManager.AppSettings["config"];
            XDocument config = XDocument.Load(configpath);
            string xpath = string.Format("/Config/role[Partner='{0}'][roleType='{1}']", parten, roleType);
            XElement role = config.XPathSelectElement(xpath);
            return role;
        }
    }
}
