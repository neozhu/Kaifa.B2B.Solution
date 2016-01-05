namespace Kaifa.Wms.OQC.WinForm
{
    partial class oqcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oqcForm));
            this.label1 = new System.Windows.Forms.Label();
            this.orderkeytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropidtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.subtotalpickedqtytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotalcheckqtytxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotaldiffqtytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stxqrcode = new System.Windows.Forms.TextBox();
            this.openqtytxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pickedqty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedqtytxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pickdetailgrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.checkrecordgrid = new System.Windows.Forms.DataGridView();
            this.diffqtytxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.diffck = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pickdetailgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkrecordgrid)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "出货单号";
            // 
            // orderkeytxt
            // 
            this.orderkeytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderkeytxt.Location = new System.Drawing.Point(92, 10);
            this.orderkeytxt.MaxLength = 10;
            this.orderkeytxt.Name = "orderkeytxt";
            this.orderkeytxt.Size = new System.Drawing.Size(248, 26);
            this.orderkeytxt.TabIndex = 1;
            this.orderkeytxt.TextChanged += new System.EventHandler(this.orderkeytxt_TextChanged);
            this.orderkeytxt.Leave += new System.EventHandler(this.orderkeytxt_Leave);
            this.orderkeytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderkeytxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "落放ID";
            // 
            // dropidtxt
            // 
            this.dropidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropidtxt.Location = new System.Drawing.Point(407, 10);
            this.dropidtxt.MaxLength = 14;
            this.dropidtxt.Name = "dropidtxt";
            this.dropidtxt.Size = new System.Drawing.Size(248, 26);
            this.dropidtxt.TabIndex = 2;
            this.dropidtxt.Leave += new System.EventHandler(this.dropidtxt_Leave);
            this.dropidtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderkeytxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "订单状态";
            // 
            // statustxt
            // 
            this.statustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustxt.Location = new System.Drawing.Point(740, 13);
            this.statustxt.Name = "statustxt";
            this.statustxt.ReadOnly = true;
            this.statustxt.Size = new System.Drawing.Size(92, 26);
            this.statustxt.TabIndex = 50;
            // 
            // subtotalpickedqtytxt
            // 
            this.subtotalpickedqtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotalpickedqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalpickedqtytxt.Location = new System.Drawing.Point(450, 399);
            this.subtotalpickedqtytxt.Name = "subtotalpickedqtytxt";
            this.subtotalpickedqtytxt.Size = new System.Drawing.Size(190, 38);
            this.subtotalpickedqtytxt.TabIndex = 90;
            this.subtotalpickedqtytxt.Text = "0";
            this.subtotalpickedqtytxt.TextChanged += new System.EventHandler(this.subpickedqtytxt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "捡货数量";
            // 
            // subtotalcheckqtytxt
            // 
            this.subtotalcheckqtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotalcheckqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalcheckqtytxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subtotalcheckqtytxt.Location = new System.Drawing.Point(17, 399);
            this.subtotalcheckqtytxt.Name = "subtotalcheckqtytxt";
            this.subtotalcheckqtytxt.Size = new System.Drawing.Size(190, 38);
            this.subtotalcheckqtytxt.TabIndex = 110;
            this.subtotalcheckqtytxt.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "已检查数量";
            // 
            // subtotaldiffqtytxt
            // 
            this.subtotaldiffqtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotaldiffqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaldiffqtytxt.ForeColor = System.Drawing.Color.Red;
            this.subtotaldiffqtytxt.Location = new System.Drawing.Point(685, 399);
            this.subtotaldiffqtytxt.Name = "subtotaldiffqtytxt";
            this.subtotaldiffqtytxt.Size = new System.Drawing.Size(190, 38);
            this.subtotaldiffqtytxt.TabIndex = 130;
            this.subtotaldiffqtytxt.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "差异数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "希捷标签";
            // 
            // stxqrcode
            // 
            this.stxqrcode.BackColor = System.Drawing.Color.White;
            this.stxqrcode.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxqrcode.Location = new System.Drawing.Point(92, 106);
            this.stxqrcode.Multiline = true;
            this.stxqrcode.Name = "stxqrcode";
            this.stxqrcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stxqrcode.Size = new System.Drawing.Size(740, 31);
            this.stxqrcode.TabIndex = 3;
            this.stxqrcode.TextChanged += new System.EventHandler(this.stxqrcode_TextChanged);
            this.stxqrcode.Leave += new System.EventHandler(this.stxqrcode_Leave);
            this.stxqrcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stxqrcode_KeyPress);
            // 
            // openqtytxt
            // 
            this.openqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openqtytxt.Location = new System.Drawing.Point(15, 59);
            this.openqtytxt.Name = "openqtytxt";
            this.openqtytxt.Size = new System.Drawing.Size(190, 38);
            this.openqtytxt.TabIndex = 170;
            this.openqtytxt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "分配数量";
            // 
            // pickedqty
            // 
            this.pickedqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickedqty.Location = new System.Drawing.Point(231, 59);
            this.pickedqty.Name = "pickedqty";
            this.pickedqty.Size = new System.Drawing.Size(190, 38);
            this.pickedqty.TabIndex = 190;
            this.pickedqty.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "捡货数量";
            // 
            // checkedqtytxt
            // 
            this.checkedqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedqtytxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkedqtytxt.Location = new System.Drawing.Point(442, 59);
            this.checkedqtytxt.Name = "checkedqtytxt";
            this.checkedqtytxt.Size = new System.Drawing.Size(190, 38);
            this.checkedqtytxt.TabIndex = 210;
            this.checkedqtytxt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "复捡数量";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "复检结果";
            // 
            // pickdetailgrid
            // 
            this.pickdetailgrid.AllowUserToAddRows = false;
            this.pickdetailgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pickdetailgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pickdetailgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pickdetailgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.pickdetailgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickdetailgrid.Location = new System.Drawing.Point(0, 0);
            this.pickdetailgrid.Name = "pickdetailgrid";
            this.pickdetailgrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pickdetailgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pickdetailgrid.Size = new System.Drawing.Size(540, 225);
            this.pickdetailgrid.TabIndex = 230;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "复检记录";
            // 
            // checkrecordgrid
            // 
            this.checkrecordgrid.AllowUserToAddRows = false;
            this.checkrecordgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkrecordgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.checkrecordgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkrecordgrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.checkrecordgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkrecordgrid.Location = new System.Drawing.Point(0, 0);
            this.checkrecordgrid.Name = "checkrecordgrid";
            this.checkrecordgrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkrecordgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.checkrecordgrid.Size = new System.Drawing.Size(490, 225);
            this.checkrecordgrid.TabIndex = 250;
            // 
            // diffqtytxt
            // 
            this.diffqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffqtytxt.ForeColor = System.Drawing.Color.Red;
            this.diffqtytxt.Location = new System.Drawing.Point(642, 59);
            this.diffqtytxt.Name = "diffqtytxt";
            this.diffqtytxt.Size = new System.Drawing.Size(190, 38);
            this.diffqtytxt.TabIndex = 270;
            this.diffqtytxt.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(643, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "差异数量";
            // 
            // diffck
            // 
            this.diffck.AutoSize = true;
            this.diffck.Checked = true;
            this.diffck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.diffck.Location = new System.Drawing.Point(659, 138);
            this.diffck.Name = "diffck";
            this.diffck.Size = new System.Drawing.Size(134, 17);
            this.diffck.TabIndex = 280;
            this.diffck.Text = "只显示有差异的记录";
            this.diffck.UseVisualStyleBackColor = true;
            this.diffck.CheckedChanged += new System.EventHandler(this.diffck_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 155);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkrecordgrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pickdetailgrid);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 225);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 281;
            // 
            // oqcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.stxqrcode);
            this.Controls.Add(this.diffqtytxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkedqtytxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pickedqty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.openqtytxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subtotaldiffqtytxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subtotalcheckqtytxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotalpickedqtytxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderkeytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diffck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "oqcForm";
            this.Text = "出货复检程序";
            ((System.ComponentModel.ISupportInitialize)(this.pickdetailgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkrecordgrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderkeytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dropidtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.TextBox subtotalpickedqtytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subtotalcheckqtytxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotaldiffqtytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stxqrcode;
        private System.Windows.Forms.TextBox openqtytxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pickedqty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox checkedqtytxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView checkrecordgrid;
        private System.Windows.Forms.TextBox diffqtytxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox diffck;
        private System.Windows.Forms.DataGridView pickdetailgrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

