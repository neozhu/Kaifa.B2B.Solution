using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarCodePrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region ###
        private void txtpo_TextChanged(object sender, EventArgs e)
        {
            this.lpo.Text = this.txtpo.Text;
            generate3pl();
        }

        private void txtdo_TextChanged(object sender, EventArgs e)
        {
            this.ldo.Text = this.txtdo.Text;
            generate3pl();
        }

        private void txtpn_TextChanged(object sender, EventArgs e)
        {
            this.lpn.Text = this.txtpn.Text;
            generate3pl();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            this.lqty.Text = this.txtqty.Text;
            generate3pl();
        }

        private void txttrace_TextChanged(object sender, EventArgs e)
        {
            this.ltrace.Text = this.txttrace.Text;
            generate3pl();
        }

        private void txtgts_TextChanged(object sender, EventArgs e)
        {
            this.lgts.Text = this.txtgts.Text;
            generate3pl();
        }

        private void txtpart1_TextChanged(object sender, EventArgs e)
        {
            this.lpart1.Text = this.txtpart1.Text;
        }

        private void txtqty1_TextChanged(object sender, EventArgs e)
        {
            this.lqty1.Text = this.txtqty1.Text;
        }

        private void txtlot1_TextChanged(object sender, EventArgs e)
        {
            this.llot1.Text = this.txtlot1.Text;
        }

        private void txtasl_TextChanged(object sender, EventArgs e)
        {
            this.lasl1.Text = this.txtasl.Text;
        }

        private void txtven1_TextChanged(object sender, EventArgs e)
        {
            this.lven.Text = this.txtven1.Text;
        }

        private void txttrace1_TextChanged(object sender, EventArgs e)
        {
            this.ltrace1.Text = this.txttrace1.Text;
        }

        private void txtdcode_TextChanged(object sender, EventArgs e)
        {
            this.ldcode1.Text = this.txtdcode.Text;
        }
        #endregion


        private void generate3pl()
        {
            string strcontent = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n\r\n", this.txtpn.Text,
                this.txtdo.Text, this.txtpn.Text, this.txtqty.Text, this.txttrace.Text, this.txtgts.Text);
            this.pictureBox1.Image = BarCodeHelper.Generate(strcontent);
        }

        private void txtcoo_TextChanged(object sender, EventArgs e)
        {
            this.lcoo.Text = this.txtcoo.Text;
        }

    }
}
