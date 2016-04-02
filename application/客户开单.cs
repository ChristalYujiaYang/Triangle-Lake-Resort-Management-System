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
    public partial class 客户开单 : Form
    {
        public static String item1 = "";
        public static String idnumber = "";  //客户身份证号
        public static String projectnumber1; //项目编号
        public static int level;  //会员等级
        public static string phonenumber; //会员联系电话
        public static string sex; //会员性别
        public static int days;     //天数
        //public static int hours;
        public static double totalprice_consume;//消费总额
        public static double totalprice_consume1;
        public static double discountprice; //客户每个消费项目的折后金额
        public static double deposit;    //实收押金
        public static double total_deposit;  //实收客户总押金
        public static String customername;  //客户姓名
        public static double price;    //客户每个项目消费金额
        public static double ActurePrice;  //消费项目实际单价
        public static double ActureTotalPrice;  //客户总收金额
        public static double ActureTotalPrice1; //订单表客户总收金额
        public static int billMark;  //账单标记
        public static int billdetailMark;  //账单明细标记
        public static string project;  //项目标记
        public static string[] project1;
        public static int num = 0;  //循环计数
        public static DateTime currenttime; //当前时间
        public static string project2;
        public static int Mark;
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
        public 客户开单(string projectnumber, string item)
        {
            InitializeComponent();

            project2 = projectnumber;
            GetTable(project2);
            foreach (DataRow row in gettable.Rows)
            {
                if (Convert.ToString(row["status"]) != "空闲" && Convert.ToString(row["status"]) != "预订")
                {
                    MessageBox.Show("房间不可开单，请按取消关闭窗口！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                }
            }


            this.lab_ProjectNumber.Text = projectnumber;
            this.lab_ProjectType.Text = item;
            this.txtDays.Text = " 1 ";
            projectnumber1 = projectnumber;
            currenttime = 主界面.currenttime;

            try
            {
                using (SqlConnection conn = DBHelper.Connection1)
                {
                    SqlCommand cmd = new SqlCommand();//实体化SqlCommand
                    cmd.Connection = conn;
                    conn.Open();
                    // 查询项目表得出对应单价
                    if (projectnumber1.Substring(0, 2) == "RM")
                    {
                        cmd.CommandText = "select price from room where room_num='" + projectnumber1 + "'";
                        project = "RM";
                    }
                    else if (projectnumber1.Substring(0, 2).Substring(0, 2) == "CR")
                    {
                        cmd.CommandText = "select price from chessroom where chessnumber='" + projectnumber1 + "'";
                        project = "CR";
                    }
                    else if (projectnumber1.Substring(0, 2).Substring(0, 2) == "MT")
                    {
                        cmd.CommandText = "select price from meetingroom where meetingnumber='" + projectnumber1 + "'";
                        project = "MT";
                    }
                    else
                    {
                        cmd.CommandText = "select price from tabletennis where tablenumber='" + projectnumber1 + "'";
                        project = "TB";
                    }
                    SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    foreach (DataRowView drv1 in ds.Tables[0].DefaultView)
                    {
                        price = Convert.ToInt32(drv1["price"]);
                    }
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
            this.lab_price.Text = Convert.ToString(price);
            this.txtActualPrice.Text = Convert.ToString(price);
            this.txtDays.Text = "1";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtCustomerName.Text == "" || this.txtIDNumber.Text == "")
            {
                MessageBox.Show("请填写完整！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    customername = this.txtCustomerName.Text;
                    idnumber = this.txtIDNumber.Text;
                    days = Convert.ToInt32(this.txtDays.Text);
                    ActurePrice = Convert.ToDouble(this.txtActualPrice.Text);
                    //ActureTotalPrice = Convert .ToDouble (this.txtActureTotalPrice.Text);
                    SqlConnection conn = DBHelper.Connection1;

                    using (SqlConnection conn1 = DBHelper.Connection1)
                    {
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = conn1;
                        conn1.Open();
                        cmd1.CommandText = "select level,phonenumber,sex from vip where idnumber='" + idnumber + "'";

                        SqlDataReader mysdr = cmd1.ExecuteReader();

                        if (mysdr.HasRows)
                        {
                            SqlDataAdapter adp = new SqlDataAdapter(cmd1.CommandText, conn);
                            DataSet ds = new DataSet();
                            adp.Fill(ds);
                            foreach (DataRowView drv1 in ds.Tables[0].DefaultView)
                            {
                                level = Convert.ToInt32(drv1["level"]);
                                phonenumber = Convert.ToString(drv1["phonenumber"]);
                                sex = Convert.ToString(drv1["sex"]);
                            }
                            this.txtPhoneNumber.Text = phonenumber.ToString();
                            this.cboSex.Text = sex.ToString();
                            if (level == 1)
                            {
                                this.lab_discount.Text = "100%";
                                discountprice = ActurePrice * 1;
                                this.lab_DiscountPrice.Text = Convert.ToString(discountprice);
                            }
                            else if (level == 2)
                            {
                                this.lab_discount.Text = "0.95";
                                discountprice = ActurePrice * 0.95;
                                this.lab_DiscountPrice.Text = Convert.ToString(discountprice);
                                this.txtActualPrice.Text = Convert.ToString(price);
                            }
                            else if (level == 3)
                            {
                                this.lab_discount.Text = "0.90";
                                discountprice = ActurePrice * 0.9;
                                this.lab_DiscountPrice.Text = Convert.ToString(discountprice);
                            }
                            else if (level == 4)
                            {
                                this.lab_discount.Text = "0.85";
                                discountprice = ActurePrice * 0.85;
                                this.lab_DiscountPrice.Text = Convert.ToString(discountprice);
                            }
                            else
                            {
                                this.lab_discount.Text = "0.80";
                                discountprice = ActurePrice * 0.8;
                                this.lab_DiscountPrice.Text = Convert.ToString(discountprice);
                            }

                        }

                        else
                        {
                            this.lab_discount.Text = "100%";
                            this.lab_DiscountPrice.Text = this.txtActualPrice.Text;
                            discountprice = ActurePrice;
                            // this.lab_totalprice.Text = Convert.ToString(ActurePrice * hours + ActurePrice * days);
                            using (SqlConnection conn2 = DBHelper.Connection1)
                            {
                                SqlCommand cmd2 = new SqlCommand();
                                cmd2.Connection = conn2;
                                conn2.Open();
                                cmd2.CommandText = "select phonenumber,sex from customer where idnumber='" + idnumber + "'";
                                SqlDataReader mysdr2 = cmd2.ExecuteReader();
                                if (mysdr2.HasRows)
                                {
                                    SqlDataAdapter adp2 = new SqlDataAdapter(cmd2.CommandText, conn);
                                    DataSet ds2 = new DataSet();
                                    adp2.Fill(ds2);
                                    foreach (DataRowView drv2 in ds2.Tables[0].DefaultView)
                                    {
                                        phonenumber = Convert.ToString(drv2["phonenumber"]);
                                        sex = Convert.ToString(drv2["sex"]);
                                        this.txtPhoneNumber.Text = phonenumber.ToString();
                                        this.cboSex.Text = sex.ToString();
                                    }
                                }
                                else
                                {
                                    Mark = 1;
                                }
                            }
                        }
                        mysdr.Close();
                    }

                    totalprice_consume = discountprice * days;
                    this.lab_totalprice.Text = Convert.ToString(totalprice_consume);
                }
                catch (Exception ex)//抛出异常            
                {
                    MessageBox.Show(ex.Message);//弹出消息对话框            
                }
            }
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (this.txtPhoneNumber.Text == "" || this.cboSex.Text == "")
            {
                MessageBox.Show("请填写完整顾客信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.txtActureTotalPrice.Text == "")
            {
                MessageBox.Show("请输入总收金额！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ActureTotalPrice = Convert.ToDouble(this.txtActureTotalPrice.Text);
                deposit = ActureTotalPrice - totalprice_consume;
                this.lab_posite.Text = Convert.ToString(deposit);
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确认开单？", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    double totalprice_1;    //已收客户总金额
                    double totalprice_consume_1;   //客户已消费金额
                    double totalprice_deposit_1;   //客户已收押金
                    SqlConnection conn = DBHelper.Connection1;
                    using (SqlConnection conn3 = DBHelper.Connection1)
                    {
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.Connection = conn3;
                        conn3.Open();
                        cmd3.CommandText = "select totalprice,totalprice_consume,totalprice_deposit,paydate,customername,idnumber from bill where mark='0' and idnumber=" + "'" + idnumber + "'";

                        SqlDataReader mysdr = cmd3.ExecuteReader();

                        if (mysdr.HasRows)
                        {

                            SqlDataAdapter adp = new SqlDataAdapter(cmd3.CommandText, conn);
                            DataSet ds = new DataSet();
                            adp.Fill(ds);
                            foreach (DataRowView drv3 in ds.Tables[0].DefaultView)
                            {
                                totalprice_1 = Convert.ToDouble(drv3["totalprice"]);
                                ActureTotalPrice1 = totalprice_1 + ActureTotalPrice;    //重新计算总收客户金额
                                totalprice_consume_1 = Convert.ToDouble(drv3["totalprice_consume"]);
                                totalprice_consume1 = totalprice_consume_1 + totalprice_consume;  //重新计算客户总消费金额
                                totalprice_deposit_1 = Convert.ToDouble(drv3["totalprice_deposit"]);
                                total_deposit = totalprice_deposit_1 + deposit;

                            }

                            string sql2 = "update bill set totalprice='" + ActureTotalPrice1 + "',totalprice_consume='" + totalprice_consume1 + "',totalprice_deposit='" + total_deposit + "'";
                            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, conn);
                            //SqlCommandBuilder builder = new SqlCommandBuilder(adp2);
                            // adp2.UpdateCommand = builder.GetUpdateCommand();
                            DataTable table2 = new DataTable();
                            adp2.Fill(table2);
                        }
                        else
                        {
                            string sql3 = "insert into bill(totalprice,totalprice_consume,totalprice_deposit,paydate,customername,idnumber,mark) values ( '" + ActureTotalPrice + "','" + totalprice_consume + "','" + deposit + "','" + currenttime + "','" + customername + "','" + idnumber + "','0')";
                            SqlDataAdapter adp3 = new SqlDataAdapter(sql3, conn);
                            //SqlCommandBuilder builder3 = new SqlCommandBuilder(adp3);
                            // adp3.InsertCommand = builder3.GetInsertCommand();
                            DataTable table3 = new DataTable();
                            adp3.Fill(table3);
                        }
                        string sql2_2 = "insert into billdetail(idnumber,projectnumber,price,days,discount,discountprice,deposit,mark) values ('" + idnumber + "','" + projectnumber1 + "','" + ActurePrice + "','" + days + "','" + level + "','" + discountprice + "','" + deposit + "','1')";
                        SqlDataAdapter adp2_2 = new SqlDataAdapter(sql2_2, conn);
                        DataTable table2_2 = new DataTable();
                        adp2_2.Fill(table2_2);
                    }
                    if (Mark == 1)
                    {
                        sex = Convert.ToString(this.cboSex.Text);
                        phonenumber = Convert.ToString(this.txtPhoneNumber.Text);
                        string sql5 = "insert into customer(name,sex,idnumber,phonenumber) values('" + customername + "','" + sex + "','" + idnumber + "','" + phonenumber + "')";
                        SqlDataAdapter adp3 = new SqlDataAdapter(sql5, conn);
                        DataSet ds3 = new DataSet();
                        adp3.Fill(ds3);
                    }
                    string sql6;
                    if (project == "RM")
                    {
                        sql6 = "update room set status='使用' where room_num='" + projectnumber1 + "'";
                    }
                    else if (project == "MT")
                    {
                        sql6 = "update meetingroom set status='使用' where meetingnumber='" + projectnumber1 + "'";
                    }
                    else if (project == "CR")
                    {
                        sql6 = "update chessroom set status='使用' where chessnumber='" + projectnumber1 + "'";
                    }
                    else
                    {
                        sql6 = "update tabletennis set status='使用' where tablenumber='" + projectnumber1 + "'";
                    }
                    SqlDataAdapter adp6 = new SqlDataAdapter(sql6, conn);
                    DataSet ds6 = new DataSet();
                    adp6.Fill(ds6);

                    string sql7 = "delete from [order] where idnumber=" + "'" + idnumber + "'";
                    string sql8 = "delete from orderdetail where idnumber=" + "'" + idnumber + "'";
                    SqlDataAdapter adp7 = new SqlDataAdapter(sql7, conn);
                    DataSet ds7 = new DataSet();
                    adp7.Fill(ds7);
                    SqlDataAdapter adp8 = new SqlDataAdapter(sql7, conn);
                    DataSet ds8 = new DataSet();
                    adp7.Fill(ds8);

                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void 客户开单_Load(object sender, EventArgs e)
        {

        }

        private void 客户开单_Load_1(object sender, EventArgs e)
        {

        }

    }
}
