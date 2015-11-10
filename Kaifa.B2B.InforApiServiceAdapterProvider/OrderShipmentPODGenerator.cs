using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Xml;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class OrderShipmentPODGenerator
    {
        private string[] _orderKeys;
        private string _fromRole;
        private string _toSTXRole;
        private string _toe2openRole;
        private string _warehous;
        private string _connectionstring;
        private string _tagnamespace;
        private string _configpath;
        public OrderShipmentPODGenerator(string[] orderkeys, string configpath, string fromRole, string tostxRole, string toe2openRole, string warehous, string connectionstring, string tagnamespace)
        {
            _orderKeys = orderkeys;
            _fromRole = fromRole;
            _toSTXRole = tostxRole;
            _toe2openRole = toe2openRole;
            _connectionstring = connectionstring;
            _warehous = warehous;
            _tagnamespace = tagnamespace;
            _configpath = configpath;
        }
        public XDocument Generator()
        {
            XDocument order = new XDocument(new XElement("OrderShipmentPOD"));

            IEnumerable<XElement> vendorreports = Group(OrderShipmentPOD().ToList());
            foreach (XElement report in vendorreports.ToList())
            {


                order.Root.Add(report);
            }

            IEnumerable<XElement> cmreports = GroupByCM(OrderShipmentPOD().ToList());
            foreach (XElement report in cmreports.ToList())
            {


                order.Root.Add(report);
            }


            if (!string.IsNullOrEmpty(_tagnamespace))
            {
                XNamespace nsSys = _tagnamespace;
                //asn.Root.Add(new XAttribute(XNamespace.Xmlns, nsSys));
                foreach (XElement el in order.Descendants())
                {
                    el.Name = nsSys + el.Name.LocalName;
                }
            }
            return order;
        }


        private IEnumerable<XElement> Group(IEnumerable<XElement> rows)
        {
            IEnumerable<string> storerkeys = rows.Select(x => x.Element("STORERKEY").Value).Distinct();
            foreach (string key in storerkeys)
            {

                string duns = getStorerDuns(key);
                XElement storerGroup = new XElement("VendorShipmentPODReport");
                storerGroup.Add(new XAttribute("VendorCode", key));
                storerGroup.Add(new XAttribute("VendorDuns", duns));
                //string cmcode = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("CONSIGNEEKEY").Value).First();
                //string cmduns = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("CMDUNS").Value).First();
                //storerGroup.Add(new XAttribute("CMCode", cmcode));
                //storerGroup.Add(new XAttribute("CMDuns", cmduns));


                XElement fromrole = ConfigHelper.GetRoleElement(_configpath, _fromRole, "fromRole");
                XElement tostxrole = ConfigHelper.GetRoleElement(_configpath, _toSTXRole, "toRole");
                XElement toe2openrole = ConfigHelper.GetRoleElement(_configpath, _toe2openRole, "toRole");
                //XElement hub = ConfigHelper.GetRoleElement(_warehous, "hub");
                XElement config = new XElement("config");
                config.Add(new XElement("fromRole", fromrole.Elements()));
                config.Add(new XElement("tostxRole", tostxrole.Elements()));
                config.Add(new XElement("toe2openRole", toe2openrole.Elements()));
                //config.Add(new XElement("hub", hub.Elements()));
                storerGroup.Add(config);
                //添加所有物流/分ASIC/NOASIC
                IEnumerable<XElement> vendorreport = rows.Where(x => x.Element("STORERKEY").Value == key).ToArray();
                XElement noasic = new XElement("NOASIC");
                IEnumerable<OrderHead> orderheads = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => new OrderHead(){ 
                                OrderKey =  x.Element("ORDERKEY").Value,
                                CMCode = x.Element("CONSIGNEEKEY").Value,
                                DeliveryOrder = x.Element("LOTTABLE02").Value,
                                ExternOrderKey = x.Element("EXTERNORDERKEY").Value
                }).Distinct();
                foreach (OrderHead orderhead in orderheads)
                {
                    //表头/表体分组
                    XElement orderel = new XElement("ORDER");
                    orderel.Add(new XElement("ORDERKEY", orderhead.OrderKey));
                    //string externorderkey = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("ORDERKEY").Value == orderkey).Select(x => x.Element("EXTERNORDERKEY").Value).First();
                    orderel.Add(new XElement("EXTERNORDERKEY", orderhead.ExternOrderKey));
                    orderel.Add(new XElement("DELIVERYORDER", orderhead.DeliveryOrder));
                    orderel.Add(new XElement("CMCODE", orderhead.CMCode));
                    //string comcode = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("ORDERKEY").Value == orderkey).Select(x => x.Element("COMCODE").Value).First();
                    //orderel.Add(new XElement("COMCODE", comcode));
                    //XElement orderdetail = new XElement("ORDERDETAIL");
                    IEnumerable<XElement> detail = rows.Where(x => x.Element("STORERKEY").Value == key && 
                                                                x.Element("ORDERKEY").Value == orderhead.OrderKey &&
                                                                x.Element("CONSIGNEEKEY").Value == orderhead.CMCode &&
                                                                x.Element("LOTTABLE02").Value == orderhead.DeliveryOrder).ToArray();
                    //orderdetail.Add(detail);
                    orderel.Add(detail);
                    noasic.Add(orderel);

                }



                storerGroup.Add(noasic);

                
     

                yield return storerGroup;

            }
        }


        private IEnumerable<XElement> GroupByCM(IEnumerable<XElement> rows) {
            IEnumerable<string> cmkeys = rows.Select(x => x.Element("CONSIGNEEKEY").Value).Distinct();
            foreach (string key in cmkeys)
            {

                string duns = getCMDuns(key);
                XElement cmGroup = new XElement("CMShipmentPODReport");
                cmGroup.Add(new XAttribute("CMCode", key));
                cmGroup.Add(new XAttribute("CMDuns", duns));
                //string cmcode = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("CONSIGNEEKEY").Value).First();
                //string cmduns = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("CMDUNS").Value).First();
                //storerGroup.Add(new XAttribute("CMCode", cmcode));
                //storerGroup.Add(new XAttribute("CMDuns", cmduns));


                XElement fromrole = ConfigHelper.GetRoleElement(_configpath, _fromRole, "fromRole");
                XElement tostxrole = ConfigHelper.GetRoleElement(_configpath, _toSTXRole, "toRole");
                XElement toe2openrole = ConfigHelper.GetRoleElement(_configpath, _toe2openRole, "toRole");
                //XElement hub = ConfigHelper.GetRoleElement(_warehous, "hub");
                XElement config = new XElement("config");
                config.Add(new XElement("fromRole", fromrole.Elements()));
                config.Add(new XElement("tostxRole", tostxrole.Elements()));
                config.Add(new XElement("toe2openRole", toe2openrole.Elements()));
                //config.Add(new XElement("hub", hub.Elements()));
                cmGroup.Add(config);
                //添加所有物流/分ASIC/NOASIC
                IEnumerable<XElement> vendorreport = rows.Where(x => x.Element("CONSIGNEEKEY").Value == key).ToArray();
                XElement noasic = new XElement("NOASIC");
                IEnumerable<OrderHead> orderheads = rows.Where(x => x.Element("CONSIGNEEKEY").Value == key).Select(x => new OrderHead()
                {
                    OrderKey = x.Element("ORDERKEY").Value,
                    CMCode = x.Element("CONSIGNEEKEY").Value,
                    DeliveryOrder = x.Element("LOTTABLE02").Value,
                    ExternOrderKey = x.Element("EXTERNORDERKEY").Value
                }).Distinct();
                foreach (OrderHead orderhead in orderheads)
                {
                    //表头/表体分组
                    XElement orderel = new XElement("ORDER");
                    orderel.Add(new XElement("ORDERKEY", orderhead.OrderKey));
                    //string externorderkey = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("ORDERKEY").Value == orderkey).Select(x => x.Element("EXTERNORDERKEY").Value).First();
                    orderel.Add(new XElement("EXTERNORDERKEY", orderhead.ExternOrderKey));
                    orderel.Add(new XElement("DELIVERYORDER", orderhead.DeliveryOrder));
                    orderel.Add(new XElement("CMCODE", orderhead.CMCode));
                    //string comcode = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("ORDERKEY").Value == orderkey).Select(x => x.Element("COMCODE").Value).First();
                    //orderel.Add(new XElement("COMCODE", comcode));
                    //XElement orderdetail = new XElement("ORDERDETAIL");
                    IEnumerable<XElement> detail = rows.Where(x => x.Element("CONSIGNEEKEY").Value == key &&
                                                                x.Element("ORDERKEY").Value == orderhead.OrderKey &&
                                                                x.Element("CONSIGNEEKEY").Value == orderhead.CMCode &&
                                                                x.Element("LOTTABLE02").Value == orderhead.DeliveryOrder).ToArray();
                    //orderdetail.Add(detail);
                    orderel.Add(detail);
                    noasic.Add(orderel);

                }



                cmGroup.Add(noasic);




                yield return cmGroup;

            }
        
        }

        private string getCMDuns(string key)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string sql = string.Format("select t3.DUNSID from [{1}].STORER t3 where t3.STORERKEY=N'{0}' and t3.[TYPE]=N'2' ", key,_warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                return cmd.ExecuteScalar().ToString();
            }
        }
        private string getStorerDuns(string storerkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string sql = string.Format("select t3.DUNSID from [{1}].STORER t3 where t3.STORERKEY=N'{0}' and t3.[TYPE]=N'1' ", storerkey, _warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                return cmd.ExecuteScalar().ToString();
            }

        }

        private IEnumerable<XElement> OrderShipmentPOD()
        {
            string sqlcommandtext = string.Format(@"SELECT  STORERKEY,
		ORDERKEY,
        TRANSACTIONDATE,
		EXTERNORDERKEY,
		COMCODE,
        CONSIGNEEKEY,
		CMDUNS,
		SKU,
		SKUGROUP,
		COMMODITYCLASS,
		LOTTABLE02,
		LOTTABLE03,
		LOTTABLE06,
		LOTTABLE07,
		LOTTABLE08,
        SPREMARK,
		CAST(SUM(QTY) as int) AS QTY
FROM [{0}].[ORDER_POD] as [ORDERDETAIL]  where ORDERKEY IN ({1})
GROUP BY 
		STORERKEY,ORDERKEY,TRANSACTIONDATE,EXTERNORDERKEY,COMCODE,
        CONSIGNEEKEY,CMDUNS,SKU,SKUGROUP,COMMODITYCLASS,
		LOTTABLE02,LOTTABLE03,LOTTABLE06,LOTTABLE07,LOTTABLE08,SPREMARK   FOR XML AUTO,ELEMENTS", this._warehous, string.Join(",", this._orderKeys.Select(t => "'" + t + "'").ToArray()));

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sqlcommandtext;
                XmlReader reader = command.ExecuteXmlReader();
                reader.Read();
                while (!reader.EOF)
                {
                    string row = reader.ReadOuterXml();
                    if (string.IsNullOrEmpty(row))
                        continue;
                    XElement el = XElement.Parse(row);
                    yield return el;
                }
                reader.Close();
                conn.Close();

            }


        }
    }

    public class OrderHead : IEquatable<OrderHead>
    {

        public string OrderKey { get; set; }
        public string ExternOrderKey { get; set; }
        public string CMCode { get; set; }
        public string DeliveryOrder { get; set; }

        #region IEquatable<OrderHead> Members

        public bool Equals(OrderHead other)
        {

            //Check whether the compared object is null.
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data.
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal.
            return OrderKey.Equals(other.OrderKey) && ExternOrderKey.Equals(other.ExternOrderKey) && CMCode.Equals(other.CMCode) && DeliveryOrder.Equals(other.DeliveryOrder);
        }
        public override int GetHashCode()
        {

            //Get hash code for the Name field if it is not null.
            int hashProductName = OrderKey == null ? 0 : OrderKey.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = DeliveryOrder.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }
        #endregion
    }


    

}
