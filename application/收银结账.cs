using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 三角湖度假村管理系统
{
    public partial class 收银结账 : Form
    {
        public static String item1 = "";
        public static String idnumber = "";  //客户身份证号
        public static String projectnumber; //项目编号
        public static int discount = 1;  //会员等级
        public static int days = 1;     //天数
        public static double totalprice;  //已收总额
        public static double totalprice_consume;//消费总额
        public static double discountprice; //客户每个消费项目的折后金额
        public static double youhuiprice; //优惠金额
        public static double deposit;    //押金
        public static String customername;  //客户姓名
        public static double price;    //客户每个项目消费金额
        public static double zhaoling;  //找零
        public static double totalprice_deposit; //客户总的押金
        public static double totalprice_discount; //客户总折后金额
        public static int billMark;  //账单标记
        public static int billdetailMark;  //账单明细标记
        public static string project;  //项目标记
        public static string project2;
        public static string[] project1;
        public static int num = 0;  //循环计数
        public static DateTime currenttime; //当前时间
        DataTable gettable;
        //得到预定房间的信息
        private void GetTable(string _project)
        {
            if (_project.Substring(0, 2) == "RM")
            {
                gettable = RoomManager.GetRoomTableByRoom_num(_project);
                // this.txtday.Text = "1";
            }
            else if (_project.Substring(0, 2) == "MT")
            {
                gettable = PlaceManager.GetMeetingroomByMeeting_num(_project);


            }
            else if (_project.Substring(0, 2) == "TB")
            {
                gettable = PlaceManager.GetTabletennisByTable_num(_project);

            }
            else if (_project.Substring(0, 2) == "CR")
            {
                gettable = PlaceManager.GetChessroomByChess_num(_project);


            }

        }
        public 收银结账(string number)
        {
            project2 = number;
            GetTable(project2);
            foreach (DataRow row in gettable.Rows)
            {
                if (Convert.ToString(row["status"]) != "使用")
                {
                    MessageBox.Show("房间不可结账，请按取消关闭窗口！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                }
            }

            this.lab_billnumber.Text = "";
            this.lab_item.Text = "";
            this.lab_moneyConsume.Text = "";
            this.moneyYingshou.Text = "";
            this.moneyDeposit.Text = "";
            this.moneyDiscount.Text = "";
            this.moneyShiShou.Text = "";
            this.moneyZhaoling.Text = "";
            projectnumber = number;

            project = number.Substring(0, 2);

            item1 = number;
            try
            {

                //this.lab_billnumber.Text = number;
                using (SqlConnection conn = DBHelper.Connection1)
                {

                    SqlCommand cmd = new SqlCommand();//实体化SqlCommand
                    cmd.Connection = conn;//为cmd的Connetion属性赋值
                    cmd.CommandText = "select billnumber  from billdetail where projectnumber='" + @projectnumber + "'";

                    // 对账单明细表进行操作
                    string sql1 = "select deposit,idnumber,discount,days from billdetail where projectnumber='" + projectnumber + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    foreach (DataRowView drv in ds.Tables[0].DefaultView)
                    {
                        deposit = Convert.ToInt32(drv["deposit"]);
                        this.moneyDeposit.Text = Convert.ToString(deposit);

                        idnumber = drv["idnumber"].ToString();
                        discount = Convert.ToInt32(drv["discount"]);
                        days = Convert.ToInt32(drv["days"]);
                    }

                    //对账单表进行操作
                    string sql2 = "select customername,totalprice,totalprice_consume,totalprice_deposit from bill where idnumber='" + idnumber + "'and mark=0";
                    SqlDataAdapter adp2 = new SqlDataAdapter(sql2, conn);
                    DataSet ds2 = new DataSet();
                    adp2.Fill(ds2);
                    foreach (DataRowView drv1 in ds2.Tables[0].DefaultView)
                    {
                        customername = drv1["customername"].ToString();
                        this.lab_name.Text = customername;

                        totalprice = Convert.ToInt32(drv1["totalprice"]);
                        totalprice_consume = Convert.ToInt32(drv1["totalprice_consume"]);
                        //totalprice_discount = Convert.ToInt32(drv1["totalprice_discount"]);
                        totalprice_deposit = Convert.ToInt32(drv1["totalprice_deposit"]);

                        // this.lab_money1.Text = Convert.ToString(totalprice);
                    }
                    //计算折后价格
                    if (discount == 1)
                    {
                        totalprice_discount = totalprice_consume * 1;

                    }
                    else if (discount == 2)
                    {
                        totalprice_discount = totalprice_consume * 0.95;
                    }
                    else if (discount == 3)
                    {
                        totalprice_discount = totalprice_consume * 0.9;
                    }
                    else if (discount == 4)
                    {
                        totalprice_discount = totalprice_consume * 0.85;
                    }
                    else
                    {
                        totalprice_discount = totalprice_consume * 0.8;
                    }
                    youhuiprice = totalprice_consume - totalprice_discount;
                    zhaoling = totalprice - totalprice_discount;

                    this.lab_moneyConsume.Text = Convert.ToString(totalprice_consume);

                    this.moneyYingshou.Text = Convert.ToString(totalprice_discount);
                    this.moneyDeposit.Text = Convert.ToString(totalprice_deposit);
                    this.moneyDiscount.Text = Convert.ToString(youhuiprice);
                    this.moneyShiShou.Text = Convert.ToString(totalprice);
                    this.moneyZhaoling.Text = Convert.ToString(zhaoling);

                    cmd.Parameters.AddWithValue("@projectnumber", "projectnumber");//传参
                    conn.Open();

                    string cmdtext = Convert.ToString(cmd.ExecuteScalar());//获取你需要的结果
                    this.lab_billnumber.Text = cmdtext;

                    //SqlCommand cmd1 = new SqlCommand();
                    //conn.Close();
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }

        }
        public 收银结账(string number, string item)
        {

            InitializeComponent();
            project2 = number;
            GetTable(project2);
            foreach (DataRow row in gettable.Rows)
            {
                if (Convert.ToString(row["status"]) != "使用")
                {
                    MessageBox.Show("房间不可结账，请按取消关闭窗口！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                }
            }

            this.lab_billnumber.Text = "";
            this.lab_item.Text = "";
            this.lab_moneyConsume.Text = "";
            this.moneyYingshou.Text = "";
            this.moneyDeposit.Text = "";
            this.moneyDiscount.Text = "";
            this.moneyShiShou.Text = "";
            this.moneyZhaoling.Text = "";

            this.lab_item.Text = item;
            projectnumber = number;

            project = number.Substring(0, 2);

            item1 = number;
            try
            {

                //this.lab_billnumber.Text = number;
                using (SqlConnection conn = DBHelper.Connection1)
                {

                    SqlCommand cmd = new SqlCommand();//实体化SqlCommand
                    cmd.Connection = conn;//为cmd的Connetion属性赋值
                    cmd.CommandText = "select billnumber  from billdetail where projectnumber='" + @projectnumber + "'";

                    // 对账单明细表进行操作
                    string sql1 = "select deposit,idnumber,discount,days from billdetail where projectnumber='" + projectnumber + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    foreach (DataRowView drv in ds.Tables[0].DefaultView)
                    {
                        deposit = Convert.ToInt32(drv["deposit"]);
                        this.moneyDeposit.Text = Convert.ToString(deposit);

                        idnumber = drv["idnumber"].ToString();
                        discount = Convert.ToInt32(drv["discount"]);
                        days = Convert.ToInt32(drv["days"]);
                    }

                    //对账单表进行操作
                    string sql2 = "select customername,totalprice,totalprice_consume,totalprice_deposit from bill where idnumber='" + idnumber + "'and mark=0";
                    SqlDataAdapter adp2 = new SqlDataAdapter(sql2, conn);
                    DataSet ds2 = new DataSet();
                    adp2.Fill(ds2);
                    foreach (DataRowView drv1 in ds2.Tables[0].DefaultView)
                    {
                        customername = drv1["customername"].ToString();
                        this.lab_name.Text = customername;

                        totalprice = Convert.ToInt32(drv1["totalprice"]);
                        totalprice_consume = Convert.ToInt32(drv1["totalprice_consume"]);
                        //totalprice_discount = Convert.ToInt32(drv1["totalprice_discount"]);
                        totalprice_deposit = Convert.ToInt32(drv1["totalprice_deposit"]);

                        // this.lab_money1.Text = Convert.ToString(totalprice);
                    }
                    //计算折后价格
                    if (discount == 1)
                    {
                        totalprice_discount = totalprice_consume * 1;

                    }
                    else if (discount == 2)
                    {
                        totalprice_discount = totalprice_consume * 0.95;
                    }
                    else if (discount == 3)
                    {
                        totalprice_discount = totalprice_consume * 0.9;
                    }
                    else if (discount == 4)
                    {
                        totalprice_discount = totalprice_consume * 0.85;
                    }
                    else
                    {
                        totalprice_discount = totalprice_consume * 0.8;
                    }
                    youhuiprice = totalprice_consume - totalprice_discount;
                    zhaoling = totalprice - totalprice_discount;

                    this.lab_moneyConsume.Text = Convert.ToString(totalprice_consume);

                    this.moneyYingshou.Text = Convert.ToString(totalprice_discount);
                    this.moneyDeposit.Text = Convert.ToString(totalprice_deposit);
                    this.moneyDiscount.Text = Convert.ToString(youhuiprice);
                    this.moneyShiShou.Text = Convert.ToString(totalprice);
                    this.moneyZhaoling.Text = Convert.ToString(zhaoling);

                    cmd.Parameters.AddWithValue("@projectnumber", "projectnumber");//传参
                    conn.Open();

                    string cmdtext = Convert.ToString(cmd.ExecuteScalar());//获取你需要的结果
                    this.lab_billnumber.Text = cmdtext;

                    //SqlCommand cmd1 = new SqlCommand();
                    //conn.Close();
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }

        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DBHelper.Connection1;
                string sql1 = "select * from billdetail where idnumber='" + idnumber + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                this.dgvBills.DataSource = ds.Tables[0];
                if (MessageBox.Show("确认结账？", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //修改客户账单标记
                    currenttime = 主界面.currenttime;

                    string sql2 = "update bill set mark=1,leavedate='" + currenttime + "' where idnumber='" + idnumber + "' and mark=0";
                    adp = new SqlDataAdapter(sql2, conn);
                    adp.Fill(ds);
                    this.dgvBills.DataSource = ds.Tables[0];

                    conn.Close();
                    //修改客户账单明细表的标记
                    string sql5 = "update billdetail set mark=1 where idnumber='" + idnumber + "' and mark=0";
                    adp = new SqlDataAdapter(sql5, conn);
                    adp.Fill(ds);
                    conn.Close();
                    //修改使用项目的状态

                    string sql3;
                    string sql4 = "select projectnumber from billdetail where idnumber='" + idnumber + "'";

                    project1 = new string[10];

                    using (SqlConnection conn1 = DBHelper.Connection1)
                    {

                        SqlCommand cmd1 = new SqlCommand();//实体化SqlCommand
                        cmd1.Connection = conn1;//为cmd的Connetion属性赋值
                        conn1.Open();
                        cmd1.CommandText = "select projectnumber from billdetail where idnumber='" + idnumber + "'";
                        SqlDataReader rd = cmd1.ExecuteReader(CommandBehavior.CloseConnection); //创建DataReader对象 

                        //num = (int)cmd1.ExecuteScalar();

                        num = 0;
                        while (rd.Read()) //遍历DataReader对象 
                        {
                            project1[num] = rd["projectnumber"].ToString();
                            num = num + 1;
                        }
                        num--;
                        rd.Close();
                    }


                    for (int i = num; i >= 0; i--)
                    {
                        conn.Open();
                        if (project1[i].Substring(0, 2) == "RM")
                        {
                            sql3 = "update room set status='空闲' where room_num='" + project1[i] + "'";
                        }
                        else if (project1[i].Substring(0, 2).Substring(0, 2) == "CR")
                        {
                            sql3 = "update chessroom set status='空闲' where chessnumber='" + project1[i] + "'";
                        }
                        else if (project1[i].Substring(0, 2).Substring(0, 2) == "MT")
                        {
                            sql3 = "update meetingroom set status='空闲' where meetingnumber='" + project1[i] + "'";
                        }
                        else
                        {
                            sql3 = "update tabletennis set status='空闲' where tablenumber='" + project1[i] + "'";
                        }
                        //this.label3.Text = project1[i].Substring(0, 2);
                        adp = new SqlDataAdapter(sql3, conn);
                        adp.Fill(ds);
                        conn.Close();
                    }

                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void butTakeoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // conn.Close();
    }


}
