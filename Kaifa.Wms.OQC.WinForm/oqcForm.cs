using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaifa.Wms.OQC.WinForm
{
    public partial class oqcForm : Form
    {
        private string _connectionstring = "";

        private OQCChecker checker = null;
        public oqcForm()
        {
            InitializeComponent();
            _connectionstring = System.Configuration.ConfigurationSettings.AppSettings["connectionstring"];
            checker = new OQCChecker(_connectionstring);

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
            if (this.orderkeytxt.Text.Length != 10)
            {
                MessageBox.Show("输入的订单号有误！");
                clean();
            }
        }

        private void orderkeytxt_TextChanged(object sender, EventArgs e)
        {
            if (this.orderkeytxt.Text.Length == 10)
            {
                DataTable dt = checker.GetOrderQty(this.orderkeytxt.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("找不到订单记录！");
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
        }
        private void loadOQCResult(string orderkey, string dropid, bool onlydiff)
        {
            DataTable dt = checker.GetOQCResult(orderkey, dropid, onlydiff);
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
           
        }
        private void loadCheckLog(string orderkey, string dropid)
        {
            DataTable dt = checker.GetCheckLog(orderkey, dropid);
            this.checkrecordgrid.DataSource = dt;


            checkrecordgrid.Columns[0].HeaderText = "ID";
            checkrecordgrid.Columns[1].HeaderText = "货主";
            checkrecordgrid.Columns[2].HeaderText = "料号";
            checkrecordgrid.Columns[3].HeaderText = "复检数量";
            checkrecordgrid.Columns[4].HeaderText = "落放";
            checkrecordgrid.Columns[5].HeaderText = "订单号";
         
        }
        private void subpickedqtytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dropidtxt_Leave(object sender, EventArgs e)
        {
            if (checker.checkingDropId(this.orderkeytxt.Text, this.dropidtxt.Text))
            {

                loadOQCResult(this.orderkeytxt.Text, this.dropidtxt.Text, this.diffck.Checked);
                loadCheckLog(this.orderkeytxt.Text, this.dropidtxt.Text);
                int subtotalcheckqty = checker.GetSumCheckedQtyByDropId(this.orderkeytxt.Text, this.dropidtxt.Text);
                int subtotalpickqty = checker.GetSumPickedQtyByDropId(this.orderkeytxt.Text, this.dropidtxt.Text);
                this.subtotalcheckqtytxt.Text = subtotalcheckqty.ToString();
                this.subtotalpickedqtytxt.Text = subtotalpickqty.ToString();
                this.subtotaldiffqtytxt.Text = (subtotalpickqty - subtotalcheckqty).ToString();
            }
            else
            {
                MessageBox.Show("找到该落放ID，请重新输入");
            }

        }

        private void diffck_CheckedChanged(object sender, EventArgs e)
        {
            loadOQCResult(this.orderkeytxt.Text, this.dropidtxt.Text, this.diffck.Checked);
            loadCheckLog(this.orderkeytxt.Text, this.dropidtxt.Text);
        }

        private void stxqrcode_Leave(object sender, EventArgs e)
        {
            checker.PlayAlarm();
        }
    }
}
