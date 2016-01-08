using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using System.Data;
using System.Linq;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Component;
using Microsoft.BizTalk.Messaging;
//using Microsoft.BizTalk.Component.Utilities;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Kaifa.B2B.PipelineComponents.ExcelReader
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [System.Runtime.InteropServices.Guid("0022db2c-1599-4008-9312-ec3f9b66c356")]
    [ComponentCategory(CategoryTypes.CATID_Decoder)]
    public class Excel2007XmlExtractor: Microsoft.BizTalk.Component.Interop.IComponent, IBaseComponent, IPersistPropertyBag, IComponentUI
    {
        #region private variables
       private System.Resources.ResourceManager resourceManager = new System.Resources.ResourceManager("Resources", Assembly.GetExecutingAssembly());

        // Propertie declarations.
        private bool _UseColumnNamesFromFirstRow;
        public bool UseColumnNamesFromFirstRow
        {
            get { return _UseColumnNamesFromFirstRow; }
            set { _UseColumnNamesFromFirstRow = value; }
        }
        private string _RootElementName;
        public string RootElementName
        {
            get { return string.IsNullOrEmpty(_RootElementName)?"root":_RootElementName; }
            set { _RootElementName = value; }
        }
        private string _RowElementName;
        public string RowElementName
        {
            get { return string.IsNullOrEmpty(_RowElementName)?"row":_RowElementName; }
            set { _RowElementName = value; }
        }
        private string _NamespaceName;
        public string NamespaceName
        {
            get { return string.IsNullOrEmpty(_NamespaceName)?"nonamespace":_NamespaceName; }
            set { _NamespaceName = value; }
        }

        #endregion
 
        #region IBaseComponent members
        /// <summary>
        /// Name of the component
        /// </summary>
        [Browsable(false)]
        public string Name
        {
            get
            {
                return resourceManager.GetString("COMPONENTNAME", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        /// <summary>
        /// Version of the component
        /// </summary>
        [Browsable(false)]
        public string Version
        {
            get
            {
                return resourceManager.GetString("COMPONENTVERSION", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        /// <summary>
        /// Description of the component
        /// </summary>
        [Browsable(false)]
        public string Description
        {
            get
            {
                return resourceManager.GetString("COMPONENTDESCRIPTION", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        #endregion
 
        #region IPersistPropertyBag members
        /// <summary>
        /// Gets class ID of component for usage from unmanaged code.
        /// </summary>
        /// <param name="classid">
        /// Class ID of the component
        /// </param>
        public void GetClassID(out System.Guid classid)
        {
            classid = new System.Guid("0022db2c-1599-4008-9312-ec3f9b66c356");
        }
        /// <summary>
        /// not implemented
        /// </summary>
        public void InitNew()
        {
        }
        /// <summary>
        /// Loads configuration properties for the component
        /// </summary>
        /// <param name="pb">Configuration property bag</param>
        /// <param name="errlog">Error status</param>
        public virtual void Load(Microsoft.BizTalk.Component.Interop.IPropertyBag pb,int errlog)
        {
            object val;
            val = this.ReadPropertyBag(pb, "UseColumnNamesFromFirstRow");
            if (val != null)
            {
                this.UseColumnNamesFromFirstRow = ((bool)(val));
            }
            val = this.ReadPropertyBag(pb, "RootElementName");
            if (val != null)
            {
                this.RootElementName = ((string)(val));
            }
            val = this.ReadPropertyBag(pb, "RowElementName");
            if (val != null)
            {
                this.RowElementName = ((string)(val));
            }
            val = this.ReadPropertyBag(pb, "NamespaceName");
            if (val != null)
            {
                this.NamespaceName = ((string)(val));
            }
        }
        /// <summary>
        /// Saves the current component configuration into the property bag
        /// </summary>
        /// <param name="pb">Configuration property bag</param>
        /// <param name="fClearDirty">not used</param>
        /// <param name="fSaveAllProperties">not used</param>
        public virtual void Save(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, bool fClearDirty, bool fSaveAllProperties)
        {
            this.WritePropertyBag(pb, "UseColumnNamesFromFirstRow", this.UseColumnNamesFromFirstRow);
            this.WritePropertyBag(pb, "RootElementName", this.RootElementName);
            this.WritePropertyBag(pb, "RowElementName", this.RowElementName);
            this.WritePropertyBag(pb, "NamespaceName", this.NamespaceName);
        }
        #region utility functionality
        /// <summary>
        /// Reads property value from property bag
        /// </summary>
        /// <param name="pb">Property bag</param>
        /// <param name="propName">Name of property</param>
        /// <returns>Value of the property</returns>
        private object ReadPropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName)
        {
            object val = null;
            try
            {
                pb.Read(propName, out val,0);
            }
            catch (System.ArgumentException)
            {
                return val;
            }
            catch (System.Exception e)
            {
                throw new System.ApplicationException(e.Message);
            }
            return val;
        }
        /// <summary>
        /// Writes property values into a property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <param name="val">Value of property.</param>
        private void WritePropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName, object val)
        {
            try
            {
                pb.Write(propName, ref val);
            }
            catch (System.Exception e)
            {
                throw new System.ApplicationException(e.Message);
            }
        }
        #endregion
        #endregion
 
        #region IComponentUI members
        /// <summary>
        /// Component icon to use in BizTalk Editor
        /// </summary>
        [Browsable(false)]
        public IntPtr Icon
        {
            get
            {
                return((System.Drawing.Bitmap)(this.resourceManager.GetObject("icon", System.Globalization.CultureInfo.InvariantCulture))).GetHicon();
            }
        }
        /// <summary>
        /// The Validate method is called by the BizTalk Editor during the build 
        /// of a BizTalk project.
        /// </summary>
        /// <param name="obj">An Object containing the configuration properties.</param>
        /// <returns>The IEnumerator enables the caller to enumerate through a collection of strings containing error messages. These error messages appear as compiler error messages. To report successful property validation, the method should return an empty enumerator.</returns>
        public System.Collections.IEnumerator Validate(object obj)
        {
            // example implementation:
            // ArrayList errorList = new ArrayList();
            // errorList.Add("This is a compiler error");
            // return errorList.GetEnumerator();
            return null;
        }
        #endregion
 
        #region IComponent members
        /// <summary>
        /// Implements IComponent.Execute method.
        /// </summary>
        /// <param name="pc">Pipeline context</param>
        /// <param name="inmsg">Input message</param>
        /// <returns>Original input message</returns>
        /// <remarks>
        /// IComponent.Execute method is used to initiate
        /// the processing of the message in this pipeline component.
        /// </remarks>

         // Here we go... this is where the real work is done!
        public Microsoft.BizTalk.Message.Interop.IBaseMessage Execute(Microsoft.BizTalk.Component.Interop.IPipelineContext pc, Microsoft.BizTalk.Message.Interop.IBaseMessage inmsg)
        {

            // The 'SpreadsheetDocument.Open' method throws a System.IndexOutOfRange exception when you use the stream from inmsg directly. This is because this is a Microsoft.BizTalk.Message.Interop.StreamViewOfIStream occurence. So first I copy it to a regular MemoryStream.

            Stream instream = CopyStream(inmsg.BodyPart.GetOriginalDataStream());

            //try
            //{
                string xml = string.Empty;
                XmlDocument xmldoc = new XmlDocument();
                XmlElement root = xmldoc.CreateElement(RootElementName, NamespaceName);
                xmldoc.AppendChild(root);
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(instream, false))
                {

                    // I'm not going into all the details of the OpenXml format. You can find it all in the SDK.

                    WorkbookPart wbp = doc.WorkbookPart;
                    SharedStringTablePart shareStringPart = doc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First();
                    SharedStringItem[] items = shareStringPart.SharedStringTable.Elements<SharedStringItem>().ToArray();

                    Sheet sheet = wbp.Workbook.Descendants<Sheet>().First();
                    Worksheet worksheet = ((WorksheetPart)doc.WorkbookPart.GetPartById(sheet.Id)).Worksheet;
                    Hashtable columnHeaders = new Hashtable();
                    if(_UseColumnNamesFromFirstRow)
                    {

                        // Here is the part where I look for the column headers. I loop through the rows of the sheet to find the top row (RowIndex.Value == 1) and then put all cell values into a Hashtable. (There's probably an easier way to get the first row, but I couldn't figure it out, and this works too ;-)

                        foreach(Row row in worksheet.Descendants<Row>())
                        {
                            if(row.RowIndex.Value == 1)
                            {
                                foreach(Cell cell in row)
                                {
                                    string columnheader = GetCellValue(cell, items).Replace(' ', '_');
                                    if(!string.IsNullOrEmpty(columnheader))
                                    {
                                        string col = GetCellColumn(cell);

                                        // As explained above, I'm adding the column as a prefix.

                                        columnHeaders.Add(col, col + "_" + columnheader);
                                    }
                                }
                                break;
                            }
                        }
                    }
                    foreach (Row row in worksheet.Descendants<Row>())
                    {
                        if(!(_UseColumnNamesFromFirstRow && row.RowIndex.Value == 1))
                        {

                            // And here the XmlDocument is being build. 

                            XmlElement rownode = xmldoc.CreateElement(RowElementName, NamespaceName);
                            root.AppendChild(rownode);
                            foreach(Cell cell in row)
                            {
                                string col = GetCellColumn(cell);
                                string nodename;
                                if(columnHeaders.ContainsKey(col))
                                    nodename = (string)columnHeaders[col];
                                else
                                    nodename = "Col" + col;
                                string cellvalue = GetCellValue(cell, items).Trim();
                                if(!string.IsNullOrEmpty(cellvalue))
                                {
                                    XmlElement node = xmldoc.CreateElement(nodename, NamespaceName);
                                    node.InnerText = cellvalue;
                                    rownode.AppendChild(node);
                                }
                            }
                        }
                    }
                }

                // Finally write the XmlDocument contents to a stream and replace the pipeline stream with this new stream.

                MemoryStream memStr = new MemoryStream();
                StreamWriter strOut = new StreamWriter(memStr);
                strOut.Write(xmldoc.OuterXml);
          
 
                strOut.Flush();
                memStr.Position = 0;
                pc.ResourceTracker.AddResource(memStr);
                inmsg.BodyPart.Data = memStr;
            //}
            //catch (Exception exc)
            //{
            // You can do your own error handling here...
            //}

            return inmsg;
        }
        private Stream CopyStream(Stream input)
        {
            Stream output = new MemoryStream();
            byte[] buffer = new byte[32768];
            int read = 1;
            while (read > 0) {
                read = input.Read(buffer, 0, buffer.Length);
                if (read > 0)           
                    output.Write(buffer, 0, read);
            }
            return output;
        }
        private string GetCellColumn(Cell cell)
        {
            string cellref = cell.CellReference.Value;
            int pos = 0;
            int column;
            while (!int.TryParse(cellref.Substring(pos), out column))
                pos++;
            return cellref.Substring(0, pos);
        }
        private string GetCellValue(Cell cell, SharedStringItem[] items)
        {
            string txt = string.Empty;
            if (cell.CellValue != null)
                txt = cell.CellValue.Text;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                txt = items[int.Parse(txt)].InnerText;
            return txt;
       }

        #endregion
    }
}
