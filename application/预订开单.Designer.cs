namespace 三角湖度假村管理系统
{
    partial class 预订开单
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(预订开单));
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_posite = new System.Windows.Forms.Label();
            this.txtActureTotalPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBilling = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtActualPrice = new System.Windows.Forms.TextBox();
            this.lab_totalprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvOrderdetail = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(97, 236);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 21);
            this.txtDays.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(19, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 82;
            this.label10.Text = "共收金额：";
            // 
            // lab_posite
            // 
            this.lab_posite.AutoSize = true;
            this.lab_posite.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_posite.ForeColor = System.Drawing.Color.Red;
            this.lab_posite.Location = new System.Drawing.Point(314, 309);
            this.lab_posite.Name = "lab_posite";
            this.lab_posite.Size = new System.Drawing.Size(91, 14);
            this.lab_posite.TabIndex = 83;
            this.lab_posite.Text = "actureposite";
            // 
            // txtActureTotalPrice
            // 
            this.txtActureTotalPrice.Location = new System.Drawing.Point(97, 307);
            this.txtActureTotalPrice.Name = "txtActureTotalPrice";
            this.txtActureTotalPrice.Size = new System.Drawing.Size(100, 21);
            this.txtActureTotalPrice.TabIndex = 81;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(266, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "开单信息";
            // 
            // btnBilling
            // 
            this.btnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilling.ImageIndex = 5;
            this.btnBilling.ImageList = this.imageList1;
            this.btnBilling.Location = new System.Drawing.Point(371, 359);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 23);
            this.btnBilling.TabIndex = 80;
            this.btnBilling.Text = "开单";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "修改.png");
            this.imageList1.Images.SetKeyName(1, "增加.png");
            this.imageList1.Images.SetKeyName(2, "删除.png");
            this.imageList1.Images.SetKeyName(3, "chaxun.png");
            this.imageList1.Images.SetKeyName(4, "刷新.png");
            this.imageList1.Images.SetKeyName(5, "quxiao.png");
            this.imageList1.Images.SetKeyName(6, "13266.png");
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.ImageIndex = 6;
            this.btnOK.ImageList = this.imageList1;
            this.btnOK.Location = new System.Drawing.Point(166, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(-5, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 25);
            this.panel3.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(452, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 41;
            this.label13.Text = "实际单价：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(18, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 14);
            this.label14.TabIndex = 42;
            this.label14.Text = "预定天数：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(231, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 14);
            this.label15.TabIndex = 73;
            this.label15.Text = "实收押金：";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(317, 239);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 21);
            this.txtHours.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(231, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 53;
            this.label11.Text = "预定小时：";
            // 
            // txtActualPrice
            // 
            this.txtActualPrice.Location = new System.Drawing.Point(531, 242);
            this.txtActualPrice.Name = "txtActualPrice";
            this.txtActualPrice.Size = new System.Drawing.Size(100, 21);
            this.txtActualPrice.TabIndex = 61;
            // 
            // lab_totalprice
            // 
            this.lab_totalprice.AutoSize = true;
            this.lab_totalprice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_totalprice.ForeColor = System.Drawing.Color.Red;
            this.lab_totalprice.Location = new System.Drawing.Point(528, 309);
            this.lab_totalprice.Name = "lab_totalprice";
            this.lab_totalprice.Size = new System.Drawing.Size(77, 14);
            this.lab_totalprice.TabIndex = 63;
            this.lab_totalprice.Text = "totalprice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(452, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 62;
            this.label1.Text = "总   价：";
            // 
            // dgvOrderdetail
            // 
            this.dgvOrderdetail.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvOrderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderdetail.Location = new System.Drawing.Point(-1, 41);
            this.dgvOrderdetail.Name = "dgvOrderdetail";
            this.dgvOrderdetail.RowTemplate.Height = 23;
            this.dgvOrderdetail.Size = new System.Drawing.Size(639, 243);
            this.dgvOrderdetail.TabIndex = 85;
            // 
            // 预订开单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 408);
            this.Controls.Add(this.dgvOrderdetail);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtActualPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lab_posite);
            this.Controls.Add(this.lab_totalprice);
            this.Controls.Add(this.txtActureTotalPrice);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label15);
            this.Name = "预订开单";
            this.Text = "预订开单";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_posite;
        private System.Windows.Forms.TextBox txtActureTotalPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtActualPrice;
        private System.Windows.Forms.Label lab_totalprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvOrderdetail;
    }
}