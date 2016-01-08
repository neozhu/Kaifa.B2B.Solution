/// Parser built by Dipesh Avlani (http://integrationexperts.wordpress.com). Free to use in your projects.

using System;
using System.IO;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Linq;

using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace IntegrationExperts.Samples.PipelineComponents.Parsers
{
    public class Excel2007Parser
    {
        private string _targetNS;
        private string _rootNodeName;
        private bool _isFirstRowHeader;
        private string _nsPrefix;
        private string _tempFolder;

        #region ctor
        /// <summary> 
        /// </summary>
        /// <param name="namespacePrefix">The namespace prefix of the xml document.</param>
        /// <param name="targetNamespace">The base namespace of the xml document.</param>
        /// <param name="isFirstRowHeader">Treats the first row as the header if set to true.</param>
        /// <param name="rootNodeName">Name of the root node.</param>
        public Excel2007Parser(string namespacePrefix, string baseNamespace, string rootNodeName,  bool isFirstRowHeader)
        {
            _targetNS = baseNamespace;
            _rootNodeName = rootNodeName;
            _nsPrefix = namespacePrefix;
            _isFirstRowHeader = isFirstRowHeader;       
        }

        #endregion
                

        #region members
        public ArrayList ReadStringTable(Stream input)
        {
            ArrayList stringTable = new ArrayList();

            using (XmlTextReader reader = new XmlTextReader(input))
            {
                for (reader.MoveToContent(); reader.Read(); )
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "t")
                        stringTable.Add(reader.ReadElementString());
            }

            return stringTable;
        }

        /// <summary>
        ///Reads the worksheet from the stream. Also handles blanks cells ignored by excel.When an xlsx file is converted to xml, blanks cells are left out from the sharedStrings file. To handle this case, the worksheet file is parsed to check for any missing columns. If columns are missing, blanks are inserted for the columns missing.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="stringTable"></param>
        /// <param name="data"></param>
        public void ReadWorksheet(Stream input, ArrayList stringTable, DataTable data)
        {
            int maxCols = 0;
            using (XmlTextReader reader = new XmlTextReader(input))
            {
                DataRow dr = null;
                int colIndex = 0;
                string type;
                string val;
                int lastAscii = 0;
                int index;
                int ascii = 0; ;
                for (reader.MoveToContent(); reader.Read(); )
                    if (reader.NodeType == XmlNodeType.Element)
                        switch (reader.Name)
                        {
                            case "row":
                                dr = data.NewRow();
                                data.Rows.Add(dr);

                                if (colIndex > maxCols)
                                    maxCols = colIndex;

                                colIndex = 0;
                                lastAscii = 0;
                                break;

                            case "c":
                                type = reader.GetAttribute("t");
                                string colName = reader.GetAttribute("r");
                                string alpha = Regex.Match(colName, "[A-Z]*[a-z]*").Value;
                                int numeric = int.Parse(Regex.Match(colName, "[0-9]").Value);

                                Byte[] asciiCodes = Encoding.ASCII.GetBytes(alpha);
                                ascii = int.Parse(asciiCodes[asciiCodes.Length - 1].ToString());
                                var diff = ascii - lastAscii;
                                if (lastAscii != 0 && diff > 1 && diff < 25)
                                {
                                    while (diff > 1)
                                    {
                                        dr[colIndex] = string.Empty;
                                        colIndex++;
                                        diff = diff - 1;
                                    }
                                }
                                val = string.Empty;
                                reader.Read();
                                while (!reader.Name.Equals("v"))//look for value elements.
                                    reader.Read();

                                reader.Read();
                                val = reader.Value.Trim();


                                if (type == "s" && int.TryParse(val, out index))
                                    dr[colIndex] = stringTable[index].ToString().Trim();
                                else
                                    dr[colIndex] = val;

                                colIndex++;

                                lastAscii = ascii;
                                break;
                        }

            }

            //remove extra columns
            int tableColCnt = data.Columns.Count;
            for (int col = tableColCnt - 1; col >= maxCols; col--)
            {
                data.Columns.RemoveAt(col);
            }

            if (_isFirstRowHeader)
            {
                //assign column names as per the input document
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    data.Columns[i].ColumnName = data.Rows[0][i].ToString();
                }
                int pos = data.Columns.Count - 1;

                while (pos >= 0)
                {
                    stringTable.RemoveAt(pos);
                    pos--;
                }

                data.Rows[0].Delete();
            }

            data.AcceptChanges();

        }
 
        public MemoryStream WriteWorksheetToStream(DataTable data)
        {
            var ds = new DataSet("Root");
            var stream = new MemoryStream();
            data.TableName = _rootNodeName;
            ds.Namespace = _targetNS;
            ds.Prefix = _nsPrefix;
            data.Namespace = _targetNS;            
            data.Prefix = _nsPrefix;    
            ds.Tables.Add(data);
            data.DataSet.WriteXml(stream);
            return stream;
        }

        #endregion
    }
}
