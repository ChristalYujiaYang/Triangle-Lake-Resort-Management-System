namespace 三角湖度假村管理系统
{
    partial class 餐饮项目
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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("洋酒");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("红酒");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("啤酒");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("软饮");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("酒水", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("主食");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("甜点");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("主菜");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("食品", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("水果");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("菜品", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode21});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(餐饮项目));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvFood2 = new System.Windows.Forms.DataGridView();
            this.CboFood = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMprice = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.CboMtype = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmenu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDprice = new System.Windows.Forms.Label();
            this.labelDmenu = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnYu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTui = new System.Windows.Forms.Button();
            this.btnDian = new System.Windows.Forms.Button();
            this.txtIdnum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(185, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "菜品信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(14, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "价格";
            // 
            // dgvFood2
            // 
            this.dgvFood2.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvFood2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood2.Location = new System.Drawing.Point(188, 28);
            this.dgvFood2.Name = "dgvFood2";
            this.dgvFood2.RowTemplate.Height = 23;
            this.dgvFood2.Size = new System.Drawing.Size(383, 216);
            this.dgvFood2.TabIndex = 1;
            this.dgvFood2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood2_CellContentClick);
            // 
            // CboFood
            // 
            this.CboFood.FormattingEnabled = true;
            this.CboFood.Items.AddRange(new object[] {
            "洋酒",
            "红酒",
            "啤酒",
            "软饮",
            "主食",
            "主菜",
            "小吃",
            "甜点",
            "水果"});
            this.CboFood.Location = new System.Drawing.Point(309, 26);
            this.CboFood.Name = "CboFood";
            this.CboFood.Size = new System.Drawing.Size(163, 20);
            this.CboFood.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.PapayaWhip;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(6, 16);
            this.treeView1.Name = "treeView1";
            treeNode12.Name = "节点12";
            treeNode12.Text = "洋酒";
            treeNode13.Name = "节点13";
            treeNode13.Text = "红酒";
            treeNode14.Name = "节点14";
            treeNode14.Text = "啤酒";
            treeNode15.Name = "节点15";
            treeNode15.Text = "软饮";
            treeNode16.Name = "节点1";
            treeNode16.Text = "酒水";
            treeNode17.Name = "节点20";
            treeNode17.Text = "主食";
            treeNode18.Name = "节点22";
            treeNode18.Text = "甜点";
            treeNode19.Name = "节点23";
            treeNode19.Text = "主菜";
            treeNode20.Name = "节点19";
            treeNode20.Text = "食品";
            treeNode21.Name = "节点24";
            treeNode21.Text = "水果";
            treeNode22.Name = "节点0";
            treeNode22.Text = "菜品";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(156, 344);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(428, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 14);
            this.label10.TabIndex = 9;
            // 
            // txtMprice
            // 
            this.txtMprice.Location = new System.Drawing.Point(369, 303);
            this.txtMprice.Name = "txtMprice";
            this.txtMprice.Size = new System.Drawing.Size(100, 21);
            this.txtMprice.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.CboMtype);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.CboFood);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtMprice);
            this.tabPage1.Controls.Add(this.txtmenu);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvFood);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "餐饮基本信息";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(57, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 21);
            this.label12.TabIndex = 19;
            // 
            // CboMtype
            // 
            this.CboMtype.FormattingEnabled = true;
            this.CboMtype.Location = new System.Drawing.Point(550, 303);
            this.CboMtype.Name = "CboMtype";
            this.CboMtype.Size = new System.Drawing.Size(100, 20);
            this.CboMtype.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 1;
            this.button5.ImageList = this.imageList2;
            this.button5.Location = new System.Drawing.Point(587, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = " 刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "增加.png");
            this.imageList2.Images.SetKeyName(1, "刷新.png");
            this.imageList2.Images.SetKeyName(2, "修改.png");
            this.imageList2.Images.SetKeyName(3, "删除.png");
            this.imageList2.Images.SetKeyName(4, "chaxun.png");
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.imageList2;
            this.button4.Location = new System.Drawing.Point(512, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList2;
            this.button3.Location = new System.Drawing.Point(81, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(156, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(6, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = " 增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmenu
            // 
            this.txtmenu.Location = new System.Drawing.Point(194, 303);
            this.txtmenu.Name = "txtmenu";
            this.txtmenu.Size = new System.Drawing.Size(93, 21);
            this.txtmenu.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(509, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "类别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(324, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(153, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "序号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(258, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "菜品信息";
            // 
            // dgvFood
            // 
            this.dgvFood.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(6, 90);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowTemplate.Height = 23;
            this.dgvFood.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFood.Size = new System.Drawing.Size(696, 196);
            this.dgvFood.TabIndex = 3;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(257, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "食品";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDprice);
            this.groupBox1.Controls.Add(this.labelDmenu);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(188, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // labelDprice
            // 
            this.labelDprice.AutoSize = true;
            this.labelDprice.Location = new System.Drawing.Point(63, 71);
            this.labelDprice.Name = "labelDprice";
            this.labelDprice.Size = new System.Drawing.Size(47, 12);
            this.labelDprice.TabIndex = 2;
            this.labelDprice.Text = "label14";
            // 
            // labelDmenu
            // 
            this.labelDmenu.AutoSize = true;
            this.labelDmenu.Location = new System.Drawing.Point(63, 32);
            this.labelDmenu.Name = "labelDmenu";
            this.labelDmenu.Size = new System.Drawing.Size(47, 12);
            this.labelDmenu.TabIndex = 2;
            this.labelDmenu.Text = "label14";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuantity.Location = new System.Drawing.Point(240, 26);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(99, 23);
            this.txtQuantity.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(191, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "数量";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage2.Controls.Add(this.btnYu);
            this.tabPage2.Controls.Add(this.btnTui);
            this.tabPage2.Controls.Add(this.btnDian);
            this.tabPage2.Controls.Add(this.txtIdnum);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgvFood2);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "菜品一览表";
            // 
            // btnYu
            // 
            this.btnYu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYu.ImageIndex = 0;
            this.btnYu.ImageList = this.imageList1;
            this.btnYu.Location = new System.Drawing.Point(605, 92);
            this.btnYu.Name = "btnYu";
            this.btnYu.Size = new System.Drawing.Size(69, 34);
            this.btnYu.TabIndex = 20;
            this.btnYu.Text = " 预订";
            this.btnYu.UseVisualStyleBackColor = true;
            this.btnYu.Click += new System.EventHandler(this.btnYu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "客房状态视图-6.png");
            this.imageList1.Images.SetKeyName(1, "20090113083248284.jpg");
            this.imageList1.Images.SetKeyName(2, "quxiao.png");
            // 
            // btnTui
            // 
            this.btnTui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTui.ImageIndex = 2;
            this.btnTui.ImageList = this.imageList1;
            this.btnTui.Location = new System.Drawing.Point(605, 201);
            this.btnTui.Name = "btnTui";
            this.btnTui.Size = new System.Drawing.Size(69, 34);
            this.btnTui.TabIndex = 19;
            this.btnTui.Text = " 退点";
            this.btnTui.UseVisualStyleBackColor = true;
            this.btnTui.Click += new System.EventHandler(this.btnTui_Click);
            // 
            // btnDian
            // 
            this.btnDian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDian.ImageIndex = 1;
            this.btnDian.ImageList = this.imageList1;
            this.btnDian.Location = new System.Drawing.Point(605, 145);
            this.btnDian.Name = "btnDian";
            this.btnDian.Size = new System.Drawing.Size(69, 34);
            this.btnDian.TabIndex = 18;
            this.btnDian.Text = "点单";
            this.btnDian.UseVisualStyleBackColor = true;
            this.btnDian.Click += new System.EventHandler(this.btnDian_Click);
            // 
            // txtIdnum
            // 
            this.txtIdnum.Location = new System.Drawing.Point(592, 61);
            this.txtIdnum.Name = "txtIdnum";
            this.txtIdnum.Size = new System.Drawing.Size(132, 21);
            this.txtIdnum.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(589, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 14);
            this.label11.TabIndex = 4;
            this.label11.Text = "客户身份证号:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 401);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // 餐饮项目
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "餐饮项目";
            this.Text = "餐饮项目";
            this.Load += new System.EventHandler(this.餐饮项目_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvFood2;
        private System.Windows.Forms.ComboBox CboFood;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMprice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtmenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTui;
        private System.Windows.Forms.Button btnDian;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtIdnum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboMtype;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelDprice;
        private System.Windows.Forms.Label labelDmenu;
        private System.Windows.Forms.Button btnYu;

    }
}