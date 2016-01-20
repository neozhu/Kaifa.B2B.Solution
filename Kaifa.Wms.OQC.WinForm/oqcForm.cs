using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.IO;

namespace Kaifa.Wms.OQC.WinForm
{

    public partial class oqcForm : Form
    {
        public delegate DataTable QueryQCDelegate(string orderkey, string dropid, bool onlydiff);
        public delegate DataTable QueryLogDelegate(string orderkey, string dropid);
        public delegate void QueryCompleted(DataTable dt);
        private string _connectionstring = "";

        private OQCChecker checker = null;
        public oqcForm()
        {
            InitializeComponent();
            //_connectionstring = System.Configuration.ConfigurationSettings.AppSettings["connectionstring"];
            checker = new OQCChecker(_connectionstring);
            //this.stxqrcode.Enabled = false;
        }

        private void clean()
        {
            this.orderkeytxt.Text = "";
            this.dropidtxt.Text = "";
            this.statustxt.Text = "";
            this.openqtytxt.Text = "";
            this.pickedqty.Text = "";
            this.checkedqtytxt.Text = "";
            this.diffqtytxt.Text = "";
            this.checkrecordgrid.DataSource = null;
            this.pickdetailgrid.DataSource = null;
            this.subtotalcheckqtytxt.Text = "";
            this.subtotaldiffqtytxt.Text = "";
            this.subtotalpickedqtytxt.Text = "";
        }

        private void orderkeytxt_Leave(object sender, EventArgs e)
        {
            if (this.orderkeytxt.Text.Length != 10 && this.orderkeytxt.Text.Length >0)
            {
                checker.PlayAlarm();
                clean();
            }
            else if (this.orderkeytxt.Text.Length == 10 && !checker.checkingOrderKey(this.orderkeytxt.Text))
            {
                checker.PlayAlarm();
                clean();
            }
        }
       

        private void orderkeytxt_TextChanged(object sender, EventArgs e)
        {
            if (this.orderkeytxt.Text.Length == 10)
            {
                GetOrderQtyInfo();
            }
        }

        private void GetOrderQtyInfo()
        {
            DataTable dt = checker.GetOrderQty(this.orderkeytxt.Text);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("找不到订单记录！");
                checker.PlayAlarm();
                clean();
            }
            else
            {
                this.statustxt.Text = dt.Rows[0]["STATUS"].ToString();
                this.openqtytxt.Text = Convert.ToInt32(dt.Rows[0]["OPENQTY"]).ToString();
                this.pickedqty.Text = Convert.ToInt32(dt.Rows[0]["QTYPICKED"]).ToString();

                int checkedqty = checker.GetSumCheckedQty(this.orderkeytxt.Text);

                this.checkedqtytxt.Text = checkedqty.ToString();
                this.diffqtytxt.Text = (Convert.ToInt32(dt.Rows[0]["QTYPICKED"]) - checkedqty).ToString();



                loadOQCResult(this.orderkeytxt.Text, this.dropidtxt.Text, this.diffck.Checked);
                loadCheckLog(this.orderkeytxt.Text, this.dropidtxt.Text);
            }
        }
        private void loadOQCResult(string orderkey, string dropid, bool onlydiff)
        {
            //DataTable dt = checker.GetOQCResult(orderkey, dropid, onlydiff);

            QueryQCDelegate querydelegate = new QueryQCDelegate(checker.GetOQCResult);

            querydelegate.BeginInvoke(orderkey, dropid, onlydiff, new AsyncCallback(res => {

                QueryQCDelegate query = (QueryQCDelegate)res.AsyncState;
                DataTable dt = query.EndInvoke(res);

                this.Invoke((QueryCompleted)delegate
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;




                    this.pickdetailgrid.DataSource = bindingSource;

                    //pickdetailgrid.Columns[0].Name = "ORDERKEY";
                    //pickdetailgrid.Columns[0].DataPropertyName = "ORDERKEY";
                    pickdetailgrid.Columns[0].HeaderText = "订单号";
                    //pickdetailgrid.Columns[1].Name = "DROPID";
                    //pickdetailgrid.Columns[1].DataPropertyName = "DROPID";
                    pickdetailgrid.Columns[1].HeaderText = "货主";
                    pickdetailgrid.Columns[2].HeaderText = "料号";
                    pickdetailgrid.Columns[3].HeaderText = "捡货数量";
                    pickdetailgrid.Columns[4].HeaderText = "复检数量";
                    pickdetailgrid.Columns[5].HeaderText = "差异数量";
                    pickdetailgrid.Columns[6].HeaderText = "落放ID";
                }, dt
                );

                

            
            }), querydelegate);

            
           
        }
        private void loadCheckLog(string orderkey, string dropid)
        {
            //DataTable dt = checker.GetCheckLog(orderkey, dropid);
              QueryLogDelegate querydelegate = new QueryLogDelegate(checker.GetCheckLog);

            querydelegate.BeginInvoke(orderkey, dropid, new AsyncCallback(res => {

                 QueryLogDelegate query = (QueryLogDelegate)res.AsyncState;
                DataTable dt = query.EndInvoke(res);

                this.Invoke((QueryCompleted)delegate
                {

                    this.countlb.Text = string.Format("({0}) 盘", dt.Rows.Count);
                    this.checkrecordgrid.DataSource = dt;


                    checkrecordgrid.Columns[0].HeaderText = "ID";
                    checkrecordgrid.Columns[0].Width = 40;
                    checkrecordgrid.Columns[1].HeaderText = "货主";
                    checkrecordgrid.Columns[2].HeaderText = "料号";
                    checkrecordgrid.Columns[3].HeaderText = "复检数量";
                    checkrecordgrid.Columns[4].HeaderText = "落放";
                    checkrecordgrid.Columns[6].HeaderText = "订单号";
                    checkrecordgrid.Columns[5].HeaderText = "条码信息";
                }, dt);

                }),querydelegate);
            
         
        }
        private void subpickedqtytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dropidtxt_Leave(object sender, EventArgs e)
        {
            if ((this.dropidtxt.Text.Length>1) && checker.checkingDropId(this.orderkeytxt.Text, this.dropidtxt.Text))
            {
                ReloadCheckResult();
                checker.loadcacheTable(this.orderkeytxt.Text, this.dropidtxt.Text);
            }
            else if(this.dropidtxt.Text.Length>1)
            {
                MessageBox.Show("找到该落放ID，请重新输入");
                //this.stxqrcode.Enabled = false;

                int subtotalcheckqty = 0;
                int subtotalpickqty = 0;
                this.subtotalcheckqtytxt.Text = subtotalcheckqty.ToString();
                this.subtotalpickedqtytxt.Text = subtotalpickqty.ToString();
                this.subtotaldiffqtytxt.Text = (subtotalcheckqty - subtotalpickqty).ToString();
                checker.PlayAlarm();
            }

        }

        private void ReloadCheckResult()
        {
            loadOQCResult(this.orderkeytxt.Text, this.dropidtxt.Text, this.diffck.Checked);
            loadCheckLog(this.orderkeytxt.Text, this.dropidtxt.Text);
            int subtotalcheckqty = checker.GetSumCheckedQtyByDropId(this.orderkeytxt.Text, this.dropidtxt.Text);
            int subtotalpickqty = checker.GetSumPickedQtyByDropId(this.orderkeytxt.Text, this.dropidtxt.Text);
            this.subtotalcheckqtytxt.Text = subtotalcheckqty.ToString();
            this.subtotalpickedqtytxt.Text = subtotalpickqty.ToString();
            this.subtotaldiffqtytxt.Text = (subtotalcheckqty - subtotalpickqty  ).ToString();
        }

        private void diffck_CheckedChanged(object sender, EventArgs e)
        {
            loadOQCResult(this.orderkeytxt.Text, this.dropidtxt.Text, this.diffck.Checked);
            loadCheckLog(this.orderkeytxt.Text, this.dropidtxt.Text);
        }

        private void stxqrcode_Leave(object sender, EventArgs e)
        {
            //checker.PlayAlarm();
            //Console.WriteLine(this.stxqrcode.Text);
            string[] spilt = stxqrcode.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            Console.WriteLine(spilt);
        }

        private void stxqrcode_TextChanged(object sender, EventArgs e)
        {
            //if (!checker.checkingDropId(this.orderkeytxt.Text, this.dropidtxt.Text))
            //{
            //    MessageBox.Show("输入的出货单号和落放ID不存在，请重新输入！");
            //    this.orderkeytxt.Focus();

            //    //checker.PlayAlarm();

             
            //}
            //else
            //{
            //    if(stxqrcode.Text.IndexOf("\r\n\r\n")>0){
            //        string[] barcodespilt = stxqrcode.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //        string orderkey = this.orderkeytxt.Text;
            //        string dropid = this.dropidtxt.Text;
            //        string sku = barcodespilt[0];
            //        string qty = barcodespilt[1];
            //        string ven = barcodespilt[3];

            //        Console.WriteLine(sku + qty + ven);
            //        //MessageBox.Show(stxqrcode.Text);
            //        //this.stxqrcode.Text = string.Empty;
            //    }
            //    //2703-002775\r\n\r\n15000\r\n\r\n150917NWL\r\nSG\r\n60542\r\n\r\n150917WL\r\n20150917\r\n
            //    //string[] barcodespilt = stxqrcode.Text.Split(new string[]{"\r\n"}, StringSplitOptions.None);
            //    //if (barcodespilt.Length == 8)
            //    //{
            //    //    MessageBox.Show(barcodespilt[0] + "\\"+ barcodespilt[1]);
            //    //    this.stxqrcode.Text = string.Empty;
            //    //    string orderkey = this.orderkeytxt.Text;
            //    //    string dropid = this.dropidtxt.Text;
            //    //    string sku = barcodespilt[0];
            //    //    string qty = barcodespilt[1];
            //    //    string lot=barcodespilt[2];
            //    //    string asl = barcodespilt[3];
            //    //    string ven = barcodespilt[4];
            //    //    string trace = barcodespilt[5];
            //    //    string dcode = barcodespilt[6];


            //    //}
            //    //else if (barcodespilt.Length>8)
            //    //{
            //    //    checker.PlayAlarm();
            //    //    this.stxqrcode.Text = string.Empty;
            //    //    this.stxqrcode.Focus();
            //    //}
            //}

            
        }

        private void orderkeytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = false;
            }
        }

        private void stxqrcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                string[] barcodes =  this.stxqrcode.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (barcodes.Length >= 7)
                {
                    string orderkey = this.orderkeytxt.Text;
                    string dropid = this.dropidtxt.Text;
                    string sku = barcodes[0];
                    string qty = barcodes[1];
                    int intqty=0;
                    if (!int.TryParse(qty, out intqty))
                    {
                        checker.PlayAlarm();
                        this.stxqrcode.Text = string.Empty;
                        CleanTextBox();
                        //string[] spqty = qty.Split(new string[]{"K"}, StringSplitOptions.RemoveEmptyEntries);
                        //if (spqty.Length > 0)
                        //{
                        //    string kqty = spqty[0];

                        //    if()
                        //}

                    }
                    string ven = barcodes[4];
                    bool isok = checker.checkingSku(orderkey, dropid, ven.Replace("\n", ""), sku.Replace("\n", ""));
                    
                    if (isok)
                    {
                        checker.insertLog(this.orderkeytxt.Text, this.dropidtxt.Text, ven.Replace("\n", ""), sku.Replace("\n", ""), Convert.ToInt32(qty.Replace("\n", "")), this.stxqrcode.Text);
                        checker.PlayOK();
                        
                        CleanTextBox();
                        this.stxqrcode.BackColor = Color.Green;
                        this.stxqrcode.Text = string.Empty;
                    }
                    else
                    {
                        checker.PlayAlarm();
                        
                        CleanTextBox();
                        this.stxqrcode.BackColor = Color.Red;
                        this.stxqrcode.Text = string.Empty;
                    }
                    this.GetOrderQtyInfo();
                    this.ReloadCheckResult();
                    //MessageBox.Show(sku + "\\" + qty + "\\" + ven);
                    
                    //this.stxqrcode.Text = string.Empty;
                }
                
            }
        }

        private void CleanTextBox()
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(doCleanEmpty));
            thread.Start();
        }
        private void doCleanEmpty(object obj)
        {
            System.Threading.Thread.Sleep(500);
            this.Invoke((MethodInvoker)delegate
            {
                this.stxqrcode.Text = string.Empty; // runs on UI thread
                this.stxqrcode.SelectAll();
                this.stxqrcode.Focus();
            });
        }

        private void delmenu_Click(object sender, EventArgs e)
        {
            if (this.checkrecordgrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选中要删除的记录！");
            }
            else
            {
                object id = this.checkrecordgrid.SelectedRows[0].Cells[0].Value;
                checker.DelCheckLog(Convert.ToInt32(id));

                this.GetOrderQtyInfo();
                this.ReloadCheckResult();
            };
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            if (this.orderkeytxt.Text.Length > 0)
            {
                MemoryStream filestrem = checker.ExportExcel(this.orderkeytxt.Text);
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Excel文件|*.xls";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = this.orderkeytxt.Text + "复检结果.xls";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        // Code to write the stream goes here.
                        myStream.Write(filestrem.GetBuffer(), 0, filestrem.GetBuffer().Length);
                        myStream.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("请输入订单号！");
                this.orderkeytxt.Focus();
            }
        }

        
    
    }

    
}
