namespace 三角湖度假村管理系统
{
    partial class 收银结账
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(收银结账));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.moneyShiShou = new System.Windows.Forms.Label();
            this.butTakeoff = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.moneyDiscount = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.moneyZhaoling = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.moneyDeposit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.moneyYingshou = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_moneyConsume = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_item = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_billnumber = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "quxiao.png");
            this.imageList1.Images.SetKeyName(1, "结账.png");
            // 
            // moneyShiShou
            // 
            this.moneyShiShou.AutoSize = true;
            this.moneyShiShou.ForeColor = System.Drawing.Color.Red;
            this.moneyShiShou.Location = new System.Drawing.Point(284, 13);
            this.moneyShiShou.Name = "moneyShiShou";
            this.moneyShiShou.Size = new System.Drawing.Size(71, 21);
            this.moneyShiShou.TabIndex = 18;
            this.moneyShiShou.Text = "money5";
            // 
            // butTakeoff
            // 
            this.butTakeoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTakeoff.ImageIndex = 0;
            this.butTakeoff.ImageList = this.imageList1;
            this.butTakeoff.Location = new System.Drawing.Point(353, 106);
            this.butTakeoff.Name = "butTakeoff";
            this.butTakeoff.Size = new System.Drawing.Size(76, 31);
            this.butTakeoff.TabIndex = 17;
            this.butTakeoff.Text = "取消";
            this.butTakeoff.UseVisualStyleBackColor = true;
            this.butTakeoff.Click += new System.EventHandler(this.butTakeoff_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.ImageIndex = 1;
            this.btnCheckout.ImageList = this.imageList1;
            this.btnCheckout.Location = new System.Drawing.Point(257, 106);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(76, 31);
            this.btnCheckout.TabIndex = 16;
            this.btnCheckout.Text = "结账";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.moneyShiShou);
            this.panel2.Controls.Add(this.butTakeoff);
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Controls.Add(this.moneyDiscount);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.moneyZhaoling);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.moneyDeposit);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.moneyYingshou);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lab_moneyConsume);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(12, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 142);
            this.panel2.TabIndex = 5;
            // 
            // moneyDiscount
            // 
            this.moneyDiscount.AutoSize = true;
            this.moneyDiscount.ForeColor = System.Drawing.Color.Red;
            this.moneyDiscount.Location = new System.Drawing.Point(588, 13);
            this.moneyDiscount.Name = "moneyDiscount";
            this.moneyDiscount.Size = new System.Drawing.Size(71, 21);
            this.moneyDiscount.TabIndex = 13;
            this.moneyDiscount.Text = "money4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(501, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 12;
            this.label18.Text = "优惠金额：";
            // 
            // moneyZhaoling
            // 
            this.moneyZhaoling.AutoSize = true;
            this.moneyZhaoling.ForeColor = System.Drawing.Color.Red;
            this.moneyZhaoling.Location = new System.Drawing.Point(483, 52);
            this.moneyZhaoling.Name = "moneyZhaoling";
            this.moneyZhaoling.Size = new System.Drawing.Size(71, 21);
            this.moneyZhaoling.TabIndex = 11;
            this.moneyZhaoling.Text = "money6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(396, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 21);
            this.label16.TabIndex = 10;
            this.label16.Text = "找    零：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(199, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "实收金额：";
            // 
            // moneyDeposit
            // 
            this.moneyDeposit.AutoSize = true;
            this.moneyDeposit.ForeColor = System.Drawing.Color.Red;
            this.moneyDeposit.Location = new System.Drawing.Point(436, 13);
            this.moneyDeposit.Name = "moneyDeposit";
            this.moneyDeposit.Size = new System.Drawing.Size(71, 21);
            this.moneyDeposit.TabIndex = 5;
            this.moneyDeposit.Text = "money3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(349, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "已收押金：";
            // 
            // moneyYingshou
            // 
            this.moneyYingshou.AutoSize = true;
            this.moneyYingshou.ForeColor = System.Drawing.Color.Red;
            this.moneyYingshou.Location = new System.Drawing.Point(199, 52);
            this.moneyYingshou.Name = "moneyYingshou";
            this.moneyYingshou.Size = new System.Drawing.Size(71, 21);
            this.moneyYingshou.TabIndex = 3;
            this.moneyYingshou.Text = "money2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(112, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "应收金额：";
            // 
            // lab_moneyConsume
            // 
            this.lab_moneyConsume.AutoSize = true;
            this.lab_moneyConsume.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab_moneyConsume.Location = new System.Drawing.Point(108, 13);
            this.lab_moneyConsume.Name = "lab_moneyConsume";
            this.lab_moneyConsume.Size = new System.Drawing.Size(71, 21);
            this.lab_moneyConsume.TabIndex = 1;
            this.lab_moneyConsume.Text = "money1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(21, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "消费金额：";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(12, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 33);
            this.panel3.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(284, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "结账消费清单";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "结账单号：";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab_name.Location = new System.Drawing.Point(527, 13);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(83, 21);
            this.lab_name.TabIndex = 5;
            this.lab_name.Text = "lab_name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lab_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lab_item);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lab_billnumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 44);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(440, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "宾客姓名：";
            // 
            // lab_item
            // 
            this.lab_item.AutoSize = true;
            this.lab_item.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab_item.Location = new System.Drawing.Point(321, 13);
            this.lab_item.Name = "lab_item";
            this.lab_item.Size = new System.Drawing.Size(74, 21);
            this.lab_item.TabIndex = 3;
            this.lab_item.Text = "lab_item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(234, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "结账项目：";
            // 
            // lab_billnumber
            // 
            this.lab_billnumber.AutoSize = true;
            this.lab_billnumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab_billnumber.Location = new System.Drawing.Point(108, 13);
            this.lab_billnumber.Name = "lab_billnumber";
            this.lab_billnumber.Size = new System.Drawing.Size(92, 21);
            this.lab_billnumber.TabIndex = 1;
            this.lab_billnumber.Text = "billnumber";
            // 
            // dgvBills
            // 
            this.dgvBills.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(12, 230);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowTemplate.Height = 23;
            this.dgvBills.Size = new System.Drawing.Size(710, 239);
            this.dgvBills.TabIndex = 7;
            // 
            // 收银结账
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(734, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBills);
            this.Name = "收银结账";
            this.Text = "收银结账";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label moneyShiShou;
        private System.Windows.Forms.Button butTakeoff;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label moneyDiscount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label moneyZhaoling;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label moneyDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label moneyYingshou;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_moneyConsume;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_billnumber;
        private System.Windows.Forms.DataGridView dgvBills;

    }
}