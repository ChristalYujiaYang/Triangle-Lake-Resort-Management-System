using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 三角湖度假村管理系统
{
    public partial class 客房管理 : Form
    {
        private string LookMode = "全部";//保存查看内容。可供、清理---
        private string ShowMode = "分页显示";//保存单页还是分页显示
        public 客房管理()
        {
            InitializeComponent();
        }


        //隐藏编辑区
        public void HideEditSection()
        {
            this.Height = 417;
            //将编辑区设为不可操作的状态
            this.txtRoom_num.Enabled = false;
            this.txtPrice.Enabled = false;
            this.CboType.Enabled = false;
            this.CboStatus.Enabled = false;

        }
        //显示编辑区
        public void VisibleEditSection()
        {
            this.Height = 417;
            this.txtRoom_num.Enabled = true;
            this.txtPrice.Enabled = true;
            this.CboType.Enabled = true;
            this.CboStatus.Enabled = true;
        }
        //清空编辑区
        public void ClearEditSection()
        {
            this.txtRoom_num.Text = "";
            this.txtPrice.Text = "";
            this.CboType.Text = "单间";
            this.CboStatus.Text = "空闲";

        }
        //绑定客房信息
        public void BindRoomList()
        {
            //this.dgvRoom.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(this.txtRoom.Text.Trim()))
            {
                this.dgvRoom.DataSource = RoomManager.GetAllRooms();
            }
            else
                this.dgvRoom.DataSource = RoomManager.GetRoomListByRoom_num(this.txtRoom.Text.Trim());
        }
//按类型显示房间
        private void showRoomBytype(string roomtype)
        {
            DataTable RoomTable;
            if (this.ShowMode == "单页显示")
            {
                //roomtype = "单页显示";
                RoomTable = RoomManager.GetRoomTable();
            }
            else
            {
                RoomTable = RoomManager.GetRoomTableByRoom_Type(roomtype);
            }
            //this.showRoomBytype(RoomTable);

            this.listView1.Items.Clear();
            int count = 0;
            foreach (DataRow row in RoomTable.Rows)
            {
                int img = 0;
                string state = row["status"].ToString();
                if (this.LookMode != "全部")//是否显示全部
                {
                    if (state != this.LookMode)//只显示可供/清理/停用-----
                    {
                        continue;
                    }
                }
                if (state == "使用")
                {
                    img = 0;
                }
                else if (state == "空闲")
                {
                    img = 1;
                }
                else if (state == "维修")
                {
                    img = 2;
                }
                else if (state == "预订")
                {
                    img = 3;
                }
                ListViewItem item = new ListViewItem(row["room_num"].ToString(), img);
                //item.SubItems.Add(row["room_num"].ToString());
                item.SubItems.Add(row["price"].ToString());
                item.SubItems.Add(row["status"].ToString());

                item.SubItems.Add(row["type"].ToString());
                count++;
                if (count % 2 == 0)
                {
                    item.BackColor = System.Drawing.Color.AliceBlue;
                }
                else 
                {
                    item.BackColor = System.Drawing.Color.White;
                }
                
                this.listView1.Items.Add(item);
            }

        }

        //窗体加载时执行

        private void 客房管理_Load(object sender, EventArgs e)
        {
            BindRoomList();
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string room_num = dgvRoom.Rows[e.RowIndex].Cells["room_num"].Value.ToString();
            room _room = RoomManager.GetRoomByRoom_num(room_num);
            this.txtRoom_num.Text = _room.Room_num.Trim();
            this.txtPrice.Text = Convert.ToString(_room.Price);
            this.CboType.Text = _room.Type.Trim();
            this.CboStatus.Text = _room.Status.Trim();

        }
//查询
        private void btnSerch_Click(object sender, EventArgs e)
        {
            //通过客房名称得到客房列表
            BindRoomList();

            //string room_num = this.dgvRoom.Rows[0].Cells["room_num"].Value.ToString();
            if (this.dgvRoom.DataSource == null)
            {
                MessageBox.Show("抱歉，没有此房间！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string room_num = this.dgvRoom.Rows[0].Cells["room_num"].Value.ToString();
                room _room = RoomManager.GetRoomByRoom_num(room_num);
                this.txtRoom_num.Text = _room.Room_num.Trim();
                this.txtPrice.Text = Convert.ToString(_room.Price);
                this.CboType.Text = _room.Type.Trim();
                this.CboStatus.Text = _room.Status.Trim();
            }
        }
//增加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ClearEditSection();
            //VisibleEditSection();
            if (txtRoom_num.Text == string.Empty || this.txtPrice.Text == string.Empty || CboType.Text == string.Empty || this.CboStatus.Text == string.Empty)
            {
                MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            room _room = new room();
            _room.Room_num = this.txtRoom_num.Text.Trim();
            _room.Price = Convert.ToDecimal(this.txtPrice.Text.Trim());
            _room.Type = this.CboType.Text.Trim();
            _room.Status = this.CboStatus.Text.Trim();
            int message = RoomManager.AddRoom(_room);
            if (message == 0)
            {
                MessageBox.Show("房间已存在！");
            }
            else
            {
                BindRoomList();
                MessageBox.Show("添加成功！");
            }
        }
//修改
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtRoom_num.Text == string.Empty || this.txtPrice.Text == string.Empty || CboType.Text == string.Empty || this.CboStatus.Text == string.Empty)
            {
                MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string room_id = this.dgvRoom.CurrentRow.Cells["room_id"].Value.ToString();
            string Room_Num0 = this.dgvRoom.CurrentRow.Cells["room_num"].Value.ToString();
            room _room = RoomManager.GetRoomByRoom_id(Convert.ToInt32(room_id));
            // room _room = new room();
            _room.Room_num = this.txtRoom_num.Text.Trim();
            _room.Price = Convert.ToDecimal(this.txtPrice.Text.Trim());
            _room.Type = this.CboType.Text.Trim();
            _room.Status = this.CboStatus.Text.Trim();
            bool result = RoomManager.ModifyRoom(_room,Room_Num0);
            if (result)
            {
                BindRoomList();
                MessageBox.Show("修改成功", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("该房间号已使用！");
            }

        }
//删除房间信息
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先单击每行最左边选择要删除的行");
            }
            else
            {
                string a = this.dgvRoom.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("确定删除此房间信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = RoomManager.DeleteRoomByRoom_num(a);
                    if (result == 1)
                    {
                        MessageBox.Show(string.Format("已删除{0}房间信息！", a));
                        BindRoomList();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ClearEditSection();
            this.txtRoom.Text = "";
            BindRoomList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
          
        }

        
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

            String roomtype = this.tabControl2.SelectedTab.Text;

            this.showRoomBytype(roomtype); // 显示该类别的所有房间
        }


        private void 使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LookMode = "使用";
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Show(this.button1, new Point(0, this.button1.Height));
        }

        private void 空闲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LookMode = "空闲";
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void 维修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LookMode = "维修";
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void 预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LookMode = "预订";
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void 全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LookMode = "全部";
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void 大图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void 小图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void 详细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip2.Show(this.button2, new Point(0, this.button2.Height));
        }

        private void 分页显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMode = "分页显示";
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void 单页显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMode = "单页显示";
            String roomtype = "单页显示";
            this.showRoomBytype(roomtype);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String roomtype = this.tabControl2.SelectedTab.Text;
            this.showRoomBytype(roomtype);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (this.tabControl1.SelectedTab.Text == "客房状态一览表")
            {
                String roomtype = "标准间";
                DataTable roomtable;
                this.showRoomBytype(roomtype);
               roomtable = RoomManager.GetRoomTable();
                int zs=roomtable.Rows.Count;
                int sy=0;
                int kx=0;
                int wx=0;
                int yd=0;
                for(int i=0;i<zs;i++)
                {
                    DataRow row=roomtable.Rows[i];
                    string status1=row["status"].ToString();
                    if (status1 == "使用")
                    {
                        sy++;
                    }
                    else if (status1 == "空闲")
                    {
                        kx++;
                    }
                    else if (status1 == "维修")
                    {
                        wx++;
                    }
                    else if(status1=="预订")
                    {
                        yd++;
                    }
                }
                this.label13.Text = Convert.ToString(zs);
                this.label14.Text = Convert.ToString(sy);
                this.label15.Text = Convert.ToString(kx);
                this.label16.Text = Convert.ToString(wx);
                this.label17.Text = Convert.ToString(yd);

            }
        }
    }
}