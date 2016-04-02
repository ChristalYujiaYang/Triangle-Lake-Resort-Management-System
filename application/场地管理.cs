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
    public partial class 场地管理 : Form
    {
        private string lookmode = "全部";//保存查看内容。可供、清理---
       // private string ShowMode = "棋牌室";
        //清空编辑
        public void ClearEditSection()
        {
            this.CboType1.Items.Clear();
            this.CboType1.Text = "";
            //this.CboType1.DropDownStyle = ComboBoxStyle.DropDown;修改cbotype1的显示方式
            //this.CboType1.Text = "";
            this.Cboplace.SelectedIndex = -1;
            this.txtNum.Text = "";
            this.txtPrice1.Text = "";
            this.CboStatus1.SelectedIndex = -1;

        }
        //绑定客房信息
        public void BindPlaces(string sql)
        {
            this.dgvPlaces.DataSource = PlaceManager.GetPlaces(sql);
            
        }
        public 场地管理()
        {
            InitializeComponent();
        }
        //查询
        private void button4_Click(object sender, EventArgs e)
        {
            string sql = this.CboPlaces.Text.Trim();
            if (sql == System.String.Empty)
            {
                MessageBox.Show("请输入场地名称！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (sql == "棋牌室")
            {
                sql = "chessroom";
            }
            else if (sql == "会议室")
            {
                sql = "meetingroom";
            }
            else if (sql == "乒乓球室")
            {
                sql = "tabletennis";
            }
            BindPlaces(sql);
                
        }
        //新增
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string sql=System.String.Empty;
            int message;
           if (Cboplace.Text == string.Empty || this.txtNum.Text == string.Empty || this.txtPrice1.Text == string.Empty || CboType1.Text == string.Empty || this.CboStatus1.Text == string.Empty)
            {
                MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Cboplace.Text=="棋牌室")
            {
             chessroom _chessroom = new chessroom();
            _chessroom.Chessnumber= this.txtNum.Text.Trim();
            _chessroom.Price = Convert.ToDecimal(this.txtPrice1.Text.Trim());
            _chessroom.Type = this.CboType1.Text.Trim();
            _chessroom.Status = this.CboStatus1.Text.Trim();
               message = PlaceManager.AddChessRoom(_chessroom);
            if (message == 0)
            {
                MessageBox.Show("该棋牌室已存在！");
            }
            else
            {
                sql = "chessroom";
                BindPlaces(sql);
                MessageBox.Show("添加成功！");
            }

            }
            else if (Cboplace.Text == "会议室")
            {
                meetingroom _meetingroom = new meetingroom();
                _meetingroom.Meetingnumber = this.txtNum.Text.Trim();
                _meetingroom.Price = Convert.ToDecimal(this.txtPrice1.Text.Trim());
                _meetingroom.Type = this.CboType1.Text.Trim();
                _meetingroom.Status = this.CboStatus1.Text.Trim();
                message = PlaceManager.AddMeetingRoom(_meetingroom);
                if (message == 0)
                {
                    MessageBox.Show("该会议室已存在！");
                }
                else
                {
                    sql = "meetingroom";
                    BindPlaces(sql);
                    MessageBox.Show("添加成功！");
                }

            }
            else if (Cboplace.Text == "乒乓球室")
            {
                tabletennis _tabletennis = new tabletennis();
                _tabletennis.Tablenumber= this.txtNum.Text.Trim();
                _tabletennis.Price = Convert.ToDecimal(this.txtPrice1.Text.Trim());
                _tabletennis.Type = this.CboType1.Text.Trim();
                _tabletennis.Status = this.CboStatus1.Text.Trim();
                message = PlaceManager.AddTabletennis(_tabletennis);
                if (message == 0)
                {
                    MessageBox.Show("该乒乓球台已存在！");
                }
                else
                {
                    sql = "tabletennis";
                    BindPlaces(sql);
                    MessageBox.Show("添加成功！");
                }

            }
        }
        //修改
        private void btnModify1_Click(object sender, EventArgs e)
        {
            if(this.txtNum.Text == string.Empty || this.txtPrice1.Text == string.Empty || CboType1.Text == string.Empty || this.CboStatus1.Text == string.Empty)
            {
                MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           // this.Cboplace.Enabled = false;
            string sql = this.CboPlaces.Text;
            bool result=false;
            if (sql=="棋牌室")
            {
                sql = "chessroom";
                string chess_id = this.dgvPlaces.CurrentRow.Cells["chess_id"].Value.ToString();
                string chessnumber0 = this.dgvPlaces.CurrentRow.Cells["cheesnumber"].Value.ToString();
                 chessroom _chessroom = PlaceManager.GetChessroomByChess_id(Convert.ToInt32(chess_id));
                 _chessroom.Chessnumber = this.txtNum.Text.Trim();
                 _chessroom.Price = Convert.ToDecimal(this.txtPrice1.Text.Trim());
                 _chessroom.Type = this.CboType1.Text.Trim();
                 _chessroom.Status = this.CboStatus1.Text.Trim();
                 result = PlaceManager.ModifyChessroom(_chessroom, chessnumber0);
            }
            else if(sql=="会议室")
            {
                sql = "meetingroom";
                string meeting_id = this.dgvPlaces.CurrentRow.Cells["meeting_id"].Value.ToString();
                string meetingnumber0 = this.dgvPlaces.CurrentRow.Cells["meetingnumber"].Value.ToString();
                meetingroom _meetingroom = PlaceManager.GetMeetingroomByMeeting_id(Convert.ToInt32(meeting_id));
                _meetingroom.Meetingnumber = this.txtNum.Text.Trim();
                _meetingroom.Price = Convert.ToDecimal(this.txtPrice1.Text.Trim());
                _meetingroom.Type = this.CboType1.Text.Trim();
                _meetingroom.Status = this.CboStatus1.Text.Trim();
                result = PlaceManager.ModifyMeetingroom(_meetingroom, meetingnumber0);
            }
            else if (sql == "乒乓球室")
            {
                sql = "tabletennis";
                string table_id = this.dgvPlaces.CurrentRow.Cells["table_id"].Value.ToString();
                string tablenumber0 = this.dgvPlaces.CurrentRow.Cells["tablenumber"].Value.ToString();
                tabletennis _tabletennis= PlaceManager.GetTabletennisByTable_id(Convert.ToInt32(table_id));
                _tabletennis.Tablenumber= this.txtNum.Text.Trim();
                _tabletennis.Price = Convert.ToDecimal(this.txtPrice1.Text.Trim());
                _tabletennis.Type = this.CboType1.Text.Trim();
                _tabletennis.Status = this.CboStatus1.Text.Trim();
                result = PlaceManager.ModifyTabletennis(_tabletennis, tablenumber0);
            }
            if (result)
            {
                BindPlaces(sql);
                MessageBox.Show("修改成功", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败请重新修改！");
            }
        
        }
        //删除
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (this.dgvPlaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先单击每行最左边选择要删除的行");
            }
            else 
            {   string sql=this.CboPlaces.Text;
                string sql1 = System.String.Empty;
                string a = this.dgvPlaces.CurrentRow.Cells[1].Value.ToString();
                if (sql == "棋牌室")
                {
                    sql = "chessroom";
                    sql1 ="chessnumber";
                }
                else if (sql == "会议室")
                {
                    sql = "meetingroom";
                    sql1 = "meetingnumber";
                }
                else if (sql == "乒乓球室")
                {
                    sql = "tabletennis";
                    sql1 = "tablenumber";
                }
                if (MessageBox.Show("确定删除此信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = PlaceManager.DeleteBycNumber(a, sql,sql1);
                    if (result == 1)
                    {
                        MessageBox.Show(string.Format("已删除{0}的信息！", a));
                        BindPlaces(sql);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }

            }

        }
        //刷新
        private void btnrefresh1_Click(object sender, EventArgs e)
        {
            ClearEditSection();
            string sql = this.CboPlaces.Text.Trim();
            if (sql == System.String.Empty)
            { return; }
            else if (sql == "棋牌室")
            {
                sql = "chessroom";
            }
            else if (sql == "会议室")
            {
                sql = "meetingroom";
            }
            else if (sql == "乒乓球室")
            {
                sql = "tabletennis";
            }
            BindPlaces(sql);
        }
        private void dgvPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
// 加载窗体时
        private void 场地管理_Load(object sender, EventArgs e)
        {

        }
        //点击dgv事件
        private void dgvPlaces_Click(object sender, EventArgs e)
        {
            if (this.dgvPlaces.SelectedRows.Count >0)
            {
                //int i = this.dgvPlaces.CurrentCell.RowIndex;
                this.Cboplace.DropDownStyle = ComboBoxStyle.DropDown;
                this.Cboplace.Text = this.CboPlaces.Text;
                this.txtNum.Text = this.dgvPlaces.CurrentRow.Cells[1].Value.ToString();//
                this.txtPrice1.Text = this.dgvPlaces.CurrentRow.Cells[2].Value.ToString();
                this.CboType1.DropDownStyle = ComboBoxStyle.DropDown;
                CboType1.Text = this.dgvPlaces.CurrentRow.Cells[4].Value.ToString();
               // this.CboType1.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CboStatus1.DropDownStyle = ComboBoxStyle.DropDown;
                this.CboStatus1.Text = this.dgvPlaces.CurrentRow.Cells[3].Value.ToString();
               // this.CboStatus1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else { return; }

        }

        private void CboType1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Cboplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Cboplace.SelectedIndex == -1)
            { return; }
            if (this.Cboplace.SelectedItem.ToString() == "棋牌室")
            {
                this.CboType1.Items.Clear();
                this.CboType1.Items.Add("棋牌室");
               
            }
            else if (this.Cboplace.SelectedItem.ToString() == "会议室")
            {
                this.CboType1.Items.Clear();
                this.CboType1.Items.Add("大会议室（多功能厅）");
                this.CboType1.Items.Add("中会议室");
                this.CboType1.Items.Add("小会议室");
            }
            else if (this.Cboplace.SelectedItem.ToString() == "乒乓球室")
            {
                this.CboType1.Items.Clear();
                this.CboType1.Items.Add("乒乓球室");
            }
            else { return; }
        }
        //视图按page显示内容
        private void showPage(string PlaceType)
        {
            if (PlaceType == System.String.Empty || PlaceType == "棋牌室")
            {
                PlaceType = "chessroom";
            }
            else if (PlaceType == "乒乓球室")
            {
                PlaceType = "tabletennis";
            }
            else if (PlaceType == "会议室")
            {
                PlaceType = "meetingroom";
            }
            DataTable PageTable = PlaceManager.GetPlaces(PlaceType);
            this.listView2.Items.Clear();
            int count = 0;
            foreach (DataRow row in PageTable.Rows)
            {
                int img = 0;
                string state = row["status"].ToString();
                if (this.lookmode != "全部")//是否显示全部
                {
                    if (state != this.lookmode)//只显示可供/清理/停用-----
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
                ListViewItem item = new ListViewItem(row[1].ToString(), img);
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

                this.listView2.Items.Add(item);
            }
        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String PlaceType = this.tabControl4.SelectedTab.Text;
            this.showPage(PlaceType); // 显示该类别的所有房间
        }
//刷新2
        private void btnref_Click(object sender, EventArgs e)
        {
            String PlaceType = this.tabControl4.SelectedTab.Text;
            this.showPage(PlaceType); // 显示该类别的所有房间
        }
//查看方式
        private void btnlookmode_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip4.Show(this.btnlookmode, new Point(0, this.btnlookmode.Height));
        }

        private void btnstatus_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip3.Show(this.btnstatus, new Point(0, this.btnstatus.Height)); 
        }

        private void 使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*this.lookmode = "使用";
            String PlayType = this.tabControl4.SelectedTab.Text;
            this.showPage(PlayType);*/
        }

        private void 空闲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* this.lookmode = "空闲";
            String PlayType = this.tabControl4.SelectedTab.Text;
            this.showPage(PlayType);*/
        }

        private void contextMenuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.lookmode = e.ClickedItem.Text;
            String PlaceType = this.tabControl4.SelectedTab.Text;
            this.showPage(PlaceType);
        }

        private void contextMenuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string showmode= e.ClickedItem.Text;
            if (showmode == "大图")
            {
                this.listView2.View = View.LargeIcon;
            }
            else if (showmode == "小图")
            {
                this.listView2.View = View.SmallIcon;
            }
            else if (showmode == "详细")
            {
                this.listView2.View = View.Details;
            }
            else if (showmode == "列表")
            {
                this.listView2.View = View.List;
            }
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (this.tabControl1.SelectedTab.Text == "场地状态")
            {
                String PlaceType = "棋牌室";
                this.showPage(PlaceType);
            }
        }
     

    }
}
