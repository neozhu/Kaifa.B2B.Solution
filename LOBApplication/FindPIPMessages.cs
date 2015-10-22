using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace LOBApplication
{
    public partial class FindPIPMessages : Form
    {
        public PipMessage _pipmessage;
        public FindPIPMessages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pipcode = this.pipcodetxt.Text;
            string pipid = this.pipidtxt.Text;

            string sql = string.Format("SELECT     * FROM         MessagesToLOB where PIPInstanceID like '%{0}%' and PIPCode ='{1}' and MessageCategory ='{2}' ORDER BY TIMECREATED DESC ", pipid,
                pipcode, this.categorytxt.Text);
            using (SqlConnection db = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Db"])) {
                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter adpater = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpater.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
             
                
            
            
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx= e.RowIndex;
            if (idx > -1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[idx];
                _pipmessage =   getMessage(row.Cells[1].Value.ToString());
            }
        }




        private PipMessage getMessage(string pipid) {
            string sql = string.Format("SELECT     * FROM         MessagesFromLOB where PIPInstanceID='{0}' ", pipid);
            PipMessage msg = new PipMessage();
            using (SqlConnection db = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Db"]))
            {
                db.Open();
                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    msg.PipCode = reader.GetString(8);
                    msg.PipVer = reader.GetString(9);
                    msg.Source = reader.GetString(7);
                    msg.Destination = reader.GetString(6);
                    msg.PipId = reader.GetString(1);
                    string doccontent = reader.GetString(3);
                    int i = doccontent.LastIndexOf("[<");
                    int l = doccontent.LastIndexOf("]]");
                    //XDocument doc = new XDocument(doccontent.Substring(i,l);
                   
                    MessageBox.Show(doccontent.Substring(i+1,(l-i)-1));
                    msg.XmlContent = doccontent.Substring(i + 1, (l - i) - 1);

                    this.DialogResult = DialogResult.OK;

                }




            }
            return msg;
        
        }
    }
}
