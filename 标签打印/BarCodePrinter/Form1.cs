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
            generate3plImage();
        }

        private void txtdo_TextChanged(object sender, EventArgs e)
        {
            this.ldo.Text = this.txtdo.Text;
            generate3plImage();
        }

        private void txtpn_TextChanged(object sender, EventArgs e)
        {
            this.lpn.Text = this.txtpn.Text;
            generate3plImage();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            this.lqty.Text = this.txtqty.Text;
            generate3plImage();
        }

        private void txttrace_TextChanged(object sender, EventArgs e)
        {
            this.ltrace.Text = this.txttrace.Text;
            generate3plImage();
        }

        private void txtgts_TextChanged(object sender, EventArgs e)
        {
            this.lgts.Text = this.txtgts.Text;
            generate3plImage();
        }

        private void txtpart1_TextChanged(object sender, EventArgs e)
        {
            this.lpart1.Text = this.txtpart1.Text;
            generatestxImage();
        }

        private void txtqty1_TextChanged(object sender, EventArgs e)
        {
            this.lqty1.Text = this.txtqty1.Text;
            generatestxImage();
        }

        private void txtlot1_TextChanged(object sender, EventArgs e)
        {
            this.llot1.Text = this.txtlot1.Text;
            generatestxImage();
        }

        private void txtasl_TextChanged(object sender, EventArgs e)
        {
            this.lasl1.Text = this.txtasl.Text;
            generatestxImage();
        }

        private void txtven1_TextChanged(object sender, EventArgs e)
        {
            this.lven.Text = this.txtven1.Text;
            generatestxImage();
        }

        private void txttrace1_TextChanged(object sender, EventArgs e)
        {
            this.ltrace1.Text = this.txttrace1.Text;
            generatestxImage();
        }

        private void txtdcode_TextChanged(object sender, EventArgs e)
        {
            this.ldcode1.Text = this.txtdcode.Text;
            generatestxImage();
        }
        #endregion


        private void generate3plImage()
        {
            string strcontent = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n\r\n", this.txtpn.Text,
                this.txtdo.Text, this.txtpn.Text, this.txtqty.Text, this.txttrace.Text, this.txtgts.Text);
            this.pictureBox1.Image = BarCodeHelper.Generate(strcontent);
        }

        private void generatestxImage()
        {
            string strcontent = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n", this.txtpart1.Text,
               this.txtqty1.Text, this.txtlot1.Text, this.txtasl.Text, this.txtven1.Text, this.txttrace1.Text,this.txtdcode.Text);
            this.pictureBox3.Image = BarCodeHelper.Generate(strcontent);
        }

        private void generate3plTemplate()
        {
            string tempstring = PrintTemplate.Generate3PL(this.txtprint.Text, this.txtcop.Text, this.txtpo.Text, this.txtdo.Text, this.txtpn.Text, this.txtqty.Text,
                this.txttrace.Text, this.txtgts.Text, this.txtcoo.Text);
            Console.WriteLine(tempstring);
            uploadTemplateFile(tempstring);
        }

        private void uploadTemplateFile(string tempstring)
        {
            FtpWeb ftpclient = new FtpWeb(this.txtserver.Text, this.txtuser.Text, this.txtpasswd.Text, 21);
            if (ftpclient.Upload(tempstring, ""))
            {
                MessageBox.Show("上传打印服务器成功");
            }
            else
            {
                MessageBox.Show("上传失败");
            }
        }

        private void generatestxTemplate()
        {
            string tempstring = PrintTemplate.GenerateSTX(this.txtprint.Text, this.txtcop1.Text, this.txtpart1.Text, this.txtqty1.Text, this.txtlot1.Text, this.txtasl.Text,
                this.txtven1.Text, this.txttrace1.Text, this.txtdcode.Text);
            Console.WriteLine(tempstring);
            uploadTemplateFile(tempstring);
        }

        private void txtcoo_TextChanged(object sender, EventArgs e)
        {
            this.lcoo.Text = this.txtcoo.Text;
        }

        private void pirnt3pl_Click(object sender, EventArgs e)
        {
           generate3plTemplate();
        }

        private void btnprint1_Click(object sender, EventArgs e)
        {
            generatestxTemplate();
        }

        private void ftpvalidate_Click(object sender, EventArgs e)
        {
            FtpWeb ftpweb = new FtpWeb(this.txtserver.Text, this.txtuser.Text, this.txtpasswd.Text, 21);
            string[] paths= ftpweb.GetList();
            if (paths.Length > 0)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

    }
}
