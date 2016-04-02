using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace 三角湖度假村管理系统
{
    public partial class 主界面 : Form
    {
        private string LookMode = "全部";//保存查看内容。可供、清理---
        private string ShowMode = "分页显示";//保存单页还是分页显示
        private string placetype = "普通标间";
        public static DateTime currenttime;   //当前时间
        public static ArrayList arrlist2 = new ArrayList();
        public static ArrayList arrlist = new ArrayList();
        public static double []vipConsume1;
        public static double vipTotalConsume1;
        public static int num;
        public static int num1;
        public static string[] idnumber;
        public static string[] idnumber1;
        public static string AdType;

 /*       private void VIP()
        {
            SqlConnection conn = new SqlConnection("server=(local);database=三角湖度假村;uid=sa;pwd=123456");
            SqlConnection conn2 = new SqlConnection("server=(local);database=三角湖度假村;uid=sa;pwd=123456");
            using (SqlConnection conn1 = new SqlConnection("server=(local);database=三角湖度假村;uid=sa;pwd=123456"))
            {
                SqlCommand cmd1 = new SqlCommand();//实体化SqlCommand
                cmd1.Connection = conn1;//为cmd的Connetion属性赋值
                conn1.Open();
                cmd1.CommandText = "select * from bill order by idnumber";
                SqlDataReader rd = cmd1.ExecuteReader(CommandBehavior.CloseConnection); //创建DataReader对象 
                //num = (int)cmd1.ExecuteScalar();

                num = 0;
                num1 = 0;
                vipConsume1 = new double[100];
                vipTotalConsume1 = 0;
                while (rd.Read()) //遍历DataReader对象 
                {
                    idnumber[num] = Convert.ToString(rd["idnumber"]);
                    idnumber1[num] = idnumber[num];

                    SqlCommand cmd2 = new SqlCommand();//实体化SqlCommand
                    cmd2.Connection = conn2;//为cmd的Connetion属性赋值
                    conn2.Open();
                    cmd2.CommandText = "select totalprice_consume from bill where idnumber='" + idnumber1[num] + "'";
                    SqlDataReader rd2 = cmd2.ExecuteReader(CommandBehavior.CloseConnection); //创建DataReader对象 
                    while (rd2.Read())
                    {
                        vipConsume1[num1] = Convert.ToDouble(rd["totalprice_consume"]);
                        num1 = num1 + 1;
                    }
                    num1--;
                    vipTotalConsume1 = Convert.ToDouble(vipConsume1[num1]);

                    for (int i = num1 - 1; i >= 0; i--)
                    {
                        vipTotalConsume1 = Convert.ToDouble(vipConsume1[num1] + vipConsume1[num1 + 1]);
                    }

                    if (vipTotalConsume1 >= 10000 && vipTotalConsume1 < 20000)
                    {
                        string sql1 = "update vip set level='2' where idnumber[i]='" + idnumber + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                    }
                    else if (vipTotalConsume1 >= 20000 && vipTotalConsume1 < 50000)
                    {
                        string sql1 = "update vip set level='3' where idnumber[i]='" + idnumber + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                    }
                    else if (vipTotalConsume1 >= 50000 && vipTotalConsume1 < 80000)
                    {
                        string sql1 = "update vip set level='4' where idnumber[i]='" + idnumber + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                    }
                    else if (vipTotalConsume1 >= 80000 && vipTotalConsume1 < 100000)
                    {
                        string sql1 = "update vip set level='5' where idnumber[i]='" + idnumber + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                    }
                    else if (vipTotalConsume1 >= 100000)
                    {
                        string sql1 = "update vip set level='5' where idnumber[i]='" + idnumber + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                    }
                    //rd.Close();
                }
            }           
        }
        */




        private void butTakeoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowST(string PlaceType)
        {    
            DataTable Table;
            if (this.tabControlA.SelectedTab.Text == "客房状态视图" || PlaceType == "标准间")
            {
                if (ShowMode == "单页显示")
                {
                    Table = RoomManager.GetRoomTable();
                }
                else
                {
                    Table = RoomManager.GetRoomTableByRoom_Type(PlaceType);
                }

            }
            else
            {
                Table = PlaceManager.GetPlaces(PlaceType);
            }
            this.listViewZJM.Items.Clear();
            int count = 0;
            foreach (DataRow row in Table.Rows)
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

                this.listViewZJM.Items.Add(item);
            }
            
        }

        //客户结账
        private void ShowSTS(string PlaceType)
        {
            DataTable Table;
            if (this.tabControlA.SelectedTab.Text == "客房状态视图")
            {
                if (ShowMode == "单页显示")
                {
                    Table = RoomManager.GetRoomTable();
                }
                else
                {
                    Table = RoomManager.GetRoomTableByRoom_Type(PlaceType);
                }

            }
            else
            {
                Table = PlaceManager.GetPlaces(PlaceType);
            }
            this.listViewZJM.Items.Clear();
            int count = 0;
            foreach (DataRow row in Table.Rows)
            {
                int img = 0;
                string state = row["status"].ToString();
                if (this.LookMode != "全部")//是否显示全部
                {
                    if (state != "使用")//只显示可供/清理/停用-----
                    {
                        continue;
                    }
                }
                if (state == "使用")
                {
                    img = 0;
                }
                else { continue; }
               
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

                this.listViewZJM.Items.Add(item);
            }

        }

        //客户预订
        private void ShowSTY(string PlaceType)
        {
            DataTable Table;
            if (this.tabControlA.SelectedTab.Text == "客房状态视图" )
            {
                if (ShowMode == "单页显示")
                {
                    Table = RoomManager.GetRoomTable();
                }
                else
                {
                    Table = RoomManager.GetRoomTableByRoom_Type(PlaceType);
                }

            }
            else
            {
                Table = PlaceManager.GetPlaces(PlaceType);
            }
            this.listViewZJM.Items.Clear();
            int count = 0;
            foreach (DataRow row in Table.Rows)
            {
                int img = 0;
                string state = row["status"].ToString();
                if (this.LookMode != "全部")//是否显示全部
                {
                    if (state != "预定")//只显示可供/清理/停用-----
                    {
                        continue;
                    }
                }
                if (state == "预订")
                {
                    img = 3;
                }
                else { continue; }

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

                this.listViewZJM.Items.Add(item);
            }

        }




        public 主界面(string _AdType)
        {
            InitializeComponent();
            AdType = _AdType;
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myconn = DBHelper.Connection1;
                myconn.Open();
                string strsql = "Select date From [order]";
                //string strsql2 = "Select ordernumber From [order]";
                SqlDataAdapter da = new SqlDataAdapter(strsql, myconn);
                //SqlDataAdapter da2 = new SqlDataAdapter(strsql2, myconn);
                DataSet ds = new DataSet();
                da.Fill(ds, "order");
                //da2.Fill(ds, "order");
                DataTable dt = ds.Tables["order"];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arrlist.Add(dt.Rows[i]["date"]);
                    //arrlist2.Add(dt.Rows[i]["ordernumber"]);

                }
                ShowST(placetype); 
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
            try
            {
                SqlConnection myconn = DBHelper.Connection1;
                myconn.Open();
                //string strsql = "Select date From [order]";
                string strsql2 = "Select ordernumber From [order]";
                //SqlDataAdapter da = new SqlDataAdapter(strsql, myconn);
                SqlDataAdapter da2 = new SqlDataAdapter(strsql2, myconn);
                DataSet ds = new DataSet();
                //da.Fill(ds, "order");
                da2.Fill(ds, "order");
                DataTable dt = ds.Tables["order"];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //arrlist.Add(dt.Rows[i]["date"]);
                    arrlist2.Add(dt.Rows[i]["ordernumber"]);

                }
                ShowST(placetype);
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
            
        }

        private void tabControlA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a=this.tabControlA.SelectedTab.Text;
            if (a == "客房状态视图")
            {
                placetype = "标准间";
            }
            else if (a == "会议室状态视图")
            {
                placetype = "meetingroom";
            }
            else if (a == "棋牌室状态视图")
            {
                placetype = "chessroom";
            }
            else if (a == "乒乓球室状态视图")
            {
                placetype = "tabletennis";
            }
            ShowST(placetype);

        }

        private void contextMenuStripST_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.LookMode = e.ClickedItem.Text;
            ShowST(placetype);
            
        }

        private void contextMenuStripLK_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string LVV = e.ClickedItem.Text;
            if (LVV == "大图")
            {
                this.listViewZJM.View = View.LargeIcon;
            }
            else if (LVV == "小图")
            {
                this.listViewZJM.View = View.SmallIcon;
            }
            else if (LVV == "详细")
            {
                this.listViewZJM.View = View.Details;
            }
            else if (LVV == "列表")
            {
                this.listViewZJM.View = View.List;
            }

        }

        private void 单页显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMode = "单页显示";
            ShowST(placetype);

        }

        private void 分页显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMode = "分页显示";
            ShowST(placetype);
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            this.contextMenuStripST.Show(this.btnST, new Point(0, this.btnST.Height)); 
        }

        private void btnLK_Click(object sender, EventArgs e)
        {
            this.contextMenuStripLK.Show(this.btnLK, new Point(0, this.btnLK.Height)); 
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            ShowST(placetype);
        }

        private void tabControlB_Selected(object sender, TabControlEventArgs e)
        {
            placetype = this.tabControlB.SelectedTab.Text;
            ShowST(placetype);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            餐饮项目 Food = new 餐饮项目();
            Food.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string a = this.tabControlA.SelectedTab.Text;
            if (a == "客房状态视图")
            {
                string b = this.tabControlB.SelectedTab.Text;
                if (b == System.String.Empty)
                {
                    placetype = "标准间";
                }
                placetype =b;
            }
            else if (a == "会议室状态视图")
            {
                placetype = "meetingroom";
            }
            else if (a == "棋牌室状态视图")
            {
                placetype = "chessroom";
            }
            else if (a == "乒乓球室状态视图")
            {
                placetype = "tabletennis";
            }
            ShowSTS(placetype);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            账单报表 Bill = new 账单报表();
            Bill.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            客户管理 Customer = new 客户管理();
            Customer.Show();

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (AdType == "超级管理员")
            {
                客房管理 Room = new 客房管理();
                Room.Show();
            }
            else
            {
                MessageBox.Show("抱歉，您没有权限查看此项！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (AdType == "超级管理员")
            {
                场地管理 Place = new 场地管理();
                Place.Show();
            }
            else
            {
                MessageBox.Show("抱歉，您没有权限查看此项！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

        }

        private void CheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            收银结账 Checkout = new 收银结账(this.listViewZJM.SelectedItems[0].SubItems[0].Text, this.listViewZJM.SelectedItems[0].SubItems[3].Text);
            Checkout.Show();
        }

        private void BillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客户开单 Billing = new 客户开单(this.listViewZJM.SelectedItems[0].SubItems[0].Text, this.listViewZJM.SelectedItems[0].SubItems[3].Text);
            Billing.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //textBox1.Text = Convert.ToString(arrlist2[0]);
                this.lab_CurrentTime.Text = DateTime.Now.ToString();
                currenttime = Convert.ToDateTime(this.lab_CurrentTime.Text);
                int i = 0;
                foreach (DateTime j in arrlist)
                {
                    i += 1;
                    if (j == currenttime)
                    {
                        DialogResult dr = MessageBox.Show(arrlist2[i-1] + "号订单预定项目已到最晚使用时间！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        break;
                    }
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnKaidan_Click(object sender, EventArgs e)
        {
            查询 Search = new 查询();
            Search.Show();
        }

        private void bbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            预订项目 bb = new 预订项目(this.listViewZJM.SelectedItems[0].SubItems[0].Text, this.listViewZJM.SelectedItems[0].SubItems[3].Text);
            bb.Show();

        }

        private void 预订ToolStripMenuSItem_Click(object sender, EventArgs e)
        {

        }

        private void listViewZJM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = this.tabControlA.SelectedTab.Text;
            if (a == "客房状态视图")
            {
                string b = this.tabControlB.SelectedTab.Text;
                if (b == System.String.Empty)
                {
                    placetype = "标准间";
                }
                placetype = b;
            }
            else if (a == "会议室状态视图")
            {
                placetype = "meetingroom";
            }
            else if (a == "棋牌室状态视图")
            {
                placetype = "chessroom";
            }
            else if (a == "乒乓球室状态视图")
            {
                placetype = "tabletennis";
            }
            ShowSTY(placetype);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
   
    }
}
