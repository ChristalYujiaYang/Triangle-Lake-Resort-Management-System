namespace 三角湖度假村管理系统
{
    partial class 客房管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(客房管理));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnSerch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.CboType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoom_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.大图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分页显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单页显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空闲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListRoomLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListRoomSmall = new System.Windows.Forms.ImageList(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 401);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage1.Controls.Add(this.btnrefresh);
            this.tabPage1.Controls.Add(this.btnSerch);
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.CboStatus);
            this.tabPage1.Controls.Add(this.CboType);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtRoom_num);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvRoom);
            this.tabPage1.Controls.Add(this.txtRoom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客房基本信息";
            // 
            // btnrefresh
            // 
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.ImageIndex = 1;
            this.btnrefresh.ImageList = this.imageList2;
            this.btnrefresh.Location = new System.Drawing.Point(488, 21);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(69, 34);
            this.btnrefresh.TabIndex = 14;
            this.btnrefresh.Text = " 刷新";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
            // btnSerch
            // 
            this.btnSerch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerch.ImageIndex = 4;
            this.btnSerch.ImageList = this.imageList2;
            this.btnSerch.Location = new System.Drawing.Point(413, 21);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(69, 34);
            this.btnSerch.TabIndex = 13;
            this.btnSerch.Text = "查询";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // btnModify
            // 
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.ImageIndex = 2;
            this.btnModify.ImageList = this.imageList2;
            this.btnModify.Location = new System.Drawing.Point(94, 17);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(69, 34);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.imageList2;
            this.btnDelete.Location = new System.Drawing.Point(169, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imageList2;
            this.btnAdd.Location = new System.Drawing.Point(19, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = " 增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CboStatus
            // 
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "空闲",
            "使用",
            "维修",
            "预订"});
            this.CboStatus.Location = new System.Drawing.Point(548, 321);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(109, 20);
            this.CboStatus.TabIndex = 9;
            // 
            // CboType
            // 
            this.CboType.FormattingEnabled = true;
            this.CboType.Items.AddRange(new object[] {
            "标准间  ",
            "豪华单间",
            "豪华标准间",
            "法式别墅(新)",
            "法式别墅"});
            this.CboType.Location = new System.Drawing.Point(373, 321);
            this.CboType.Name = "CboType";
            this.CboType.Size = new System.Drawing.Size(109, 20);
            this.CboType.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(215, 322);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(93, 21);
            this.txtPrice.TabIndex = 7;
            // 
            // txtRoom_num
            // 
            this.txtRoom_num.Location = new System.Drawing.Point(54, 321);
            this.txtRoom_num.Name = "txtRoom_num";
            this.txtRoom_num.Size = new System.Drawing.Size(100, 21);
            this.txtRoom_num.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(507, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(332, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(174, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "房号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(258, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "房间信息";
            // 
            // dgvRoom
            // 
            this.dgvRoom.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(6, 90);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowTemplate.Height = 23;
            this.dgvRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRoom.Size = new System.Drawing.Size(634, 196);
            this.dgvRoom.TabIndex = 3;
            this.dgvRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellContentClick);
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoom.Location = new System.Drawing.Point(306, 25);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(80, 26);
            this.txtRoom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "房间号";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "客房状态一览表";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(556, 323);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 16);
            this.label17.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(432, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(316, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(194, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(65, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 28);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(195, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.ContextMenuStrip = this.contextMenuStrip2;
            this.button2.Location = new System.Drawing.Point(99, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "查看方式";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图ToolStripMenuItem,
            this.小图ToolStripMenuItem,
            this.详细ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.分页显示ToolStripMenuItem,
            this.单页显示ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 136);
            // 
            // 大图ToolStripMenuItem
            // 
            this.大图ToolStripMenuItem.Name = "大图ToolStripMenuItem";
            this.大图ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.大图ToolStripMenuItem.Text = "大图";
            this.大图ToolStripMenuItem.Click += new System.EventHandler(this.大图ToolStripMenuItem_Click);
            // 
            // 小图ToolStripMenuItem
            // 
            this.小图ToolStripMenuItem.Name = "小图ToolStripMenuItem";
            this.小图ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.小图ToolStripMenuItem.Text = "小图";
            this.小图ToolStripMenuItem.Click += new System.EventHandler(this.小图ToolStripMenuItem_Click);
            // 
            // 详细ToolStripMenuItem
            // 
            this.详细ToolStripMenuItem.Name = "详细ToolStripMenuItem";
            this.详细ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.详细ToolStripMenuItem.Text = "详细";
            this.详细ToolStripMenuItem.Click += new System.EventHandler(this.详细ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // 分页显示ToolStripMenuItem
            // 
            this.分页显示ToolStripMenuItem.Name = "分页显示ToolStripMenuItem";
            this.分页显示ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.分页显示ToolStripMenuItem.Text = "分页显示";
            this.分页显示ToolStripMenuItem.Click += new System.EventHandler(this.分页显示ToolStripMenuItem_Click);
            // 
            // 单页显示ToolStripMenuItem
            // 
            this.单页显示ToolStripMenuItem.Name = "单页显示ToolStripMenuItem";
            this.单页显示ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.单页显示ToolStripMenuItem.Text = "单页显示";
            this.单页显示ToolStripMenuItem.Click += new System.EventHandler(this.单页显示ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "分状态查看";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用ToolStripMenuItem,
            this.空闲ToolStripMenuItem,
            this.维修ToolStripMenuItem,
            this.预订ToolStripMenuItem,
            this.全部ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 114);
            // 
            // 使用ToolStripMenuItem
            // 
            this.使用ToolStripMenuItem.Name = "使用ToolStripMenuItem";
            this.使用ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.使用ToolStripMenuItem.Text = "使用";
            this.使用ToolStripMenuItem.Click += new System.EventHandler(this.使用ToolStripMenuItem_Click);
            // 
            // 空闲ToolStripMenuItem
            // 
            this.空闲ToolStripMenuItem.Name = "空闲ToolStripMenuItem";
            this.空闲ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.空闲ToolStripMenuItem.Text = "空闲";
            this.空闲ToolStripMenuItem.Click += new System.EventHandler(this.空闲ToolStripMenuItem_Click);
            // 
            // 维修ToolStripMenuItem
            // 
            this.维修ToolStripMenuItem.Name = "维修ToolStripMenuItem";
            this.维修ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.维修ToolStripMenuItem.Text = "维修";
            this.维修ToolStripMenuItem.Click += new System.EventHandler(this.维修ToolStripMenuItem_Click);
            // 
            // 预订ToolStripMenuItem
            // 
            this.预订ToolStripMenuItem.Name = "预订ToolStripMenuItem";
            this.预订ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.预订ToolStripMenuItem.Text = "预订";
            this.预订ToolStripMenuItem.Click += new System.EventHandler(this.预定ToolStripMenuItem_Click);
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.全部ToolStripMenuItem.Text = "全部";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "维修";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "预订";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "可用";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "使用量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "房间总量";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.LargeImageList = this.imageListRoomLarge;
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(672, 238);
            this.listView1.SmallImageList = this.imageListRoomSmall;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "房间号";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "价格";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "状态";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "类型";
            // 
            // imageListRoomLarge
            // 
            this.imageListRoomLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRoomLarge.ImageStream")));
            this.imageListRoomLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRoomLarge.Images.SetKeyName(0, "shiyong.bmp");
            this.imageListRoomLarge.Images.SetKeyName(1, "keyong.bmp");
            this.imageListRoomLarge.Images.SetKeyName(2, "weixiu.bmp");
            this.imageListRoomLarge.Images.SetKeyName(3, "yuding.bmp");
            // 
            // imageListRoomSmall
            // 
            this.imageListRoomSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRoomSmall.ImageStream")));
            this.imageListRoomSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRoomSmall.Images.SetKeyName(0, "shiyong.bmp");
            this.imageListRoomSmall.Images.SetKeyName(1, "keyong.bmp");
            this.imageListRoomSmall.Images.SetKeyName(2, "weixiu.bmp");
            this.imageListRoomSmall.Images.SetKeyName(3, "yuding.bmp");
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(3, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(672, 24);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(664, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "标准间";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(664, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "豪华单间";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(664, 0);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "豪华标准间";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(664, 0);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "法式别墅(新)";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(664, 0);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "法式别墅";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // 客房管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "客房管理";
            this.Load += new System.EventHandler(this.客房管理_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.ComboBox CboType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoom_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ImageList imageListRoomLarge;
        private System.Windows.Forms.ImageList imageListRoomSmall;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空闲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预订ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 大图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分页显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单页显示ToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList imageList2;
    }
}