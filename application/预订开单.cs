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
    public partial class 预订开单 : Form
    {

        public static string idnumber; //客户身份证号码
        public static String item = "";
        public static String projectnumber1; //项目编号
        public static int level;  //会员等级
        public static string phonenumber; //会员联系电话
        public static string sex; //会员性别
        public static int days;     //天数
        //       public static int hours;
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
        // public static string[] project1;
        public static int num = 0;  //循环计数
        public static DateTime currenttime; //当前时间
        public static int Mark;
        public static DateTime paydate;
        public static DateTime leavedate;
        public static double totalprice_1;
        public static double totalprice_consume_1;
        public static double totalprice_deposit_1;

        SqlConnection conn = DBHelper.Connection1;
        public 预订开单(string id)
        {
            InitializeComponent();
            currenttime = 主界面.currenttime;
            idnumber = id;
            try
            {
                using (SqlConnection conn1 = DBHelper.Connection1)
                {
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn1;
                    conn1.Open();
                    cmd1.CommandText = "select * from orderdetail where idnumber=" + "'" + idnumber + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd1.CommandText, conn);
                    DataSet dataset = new DataSet();
                    adp.Fill(dataset);
                    this.dgvOrderdetail.DataSource = dataset.Tables[0];
                    SqlDataReader mysdr = cmd1.ExecuteReader();

                    if (mysdr.HasRows)
                    {
                        SqlDataAdapter adp1 = new SqlDataAdapter(cmd1.CommandText, conn);
                        DataSet ds = new DataSet();
                        adp1.Fill(ds);
                        foreach (DataRowView drv1 in ds.Tables[0].DefaultView)
                        {
                            price = Convert.ToDouble(drv1["price"]);
                            days = Convert.ToInt32(drv1["days"]);
                            discountprice = Convert.ToDouble(drv1["discountprice"]);
                            level = Convert.ToInt32(drv1["discount"]);
                            projectnumber1 = Convert.ToString(drv1["projectnumber"]);
                            project = projectnumber1.Substring(0, 2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("系统出错！", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    }
                    SqlConnection conn5 = DBHelper.Connection1;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn5;
                    conn5.Open();
                    cmd2.CommandText = "select * from [order] where idnumber=" + "'" + idnumber + "'";
                    SqlDataAdapter adp5 = new SqlDataAdapter(cmd2.CommandText, conn);
                    DataSet dataset2 = new DataSet();
                    adp.Fill(dataset2);
                    SqlDataReader mysdr2 = cmd2.ExecuteReader();
                    if (mysdr2.HasRows)
                    {
                        SqlDataAdapter adp1 = new SqlDataAdapter(cmd2.CommandText, conn);
                        DataSet ds = new DataSet();
                        adp1.Fill(ds);
                        foreach (DataRowView drv1 in ds.Tables[0].DefaultView)
                        {
                            totalprice_consume = Convert.ToDouble(drv1["totalprice"]);
                            paydate = Convert.ToDateTime(drv1["date"]);
                            customername = Convert.ToString(drv1["customername"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("系统出错！", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    }
                }
                this.lab_totalprice.Text = Convert.ToString(totalprice_consume);
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ActureTotalPrice = Convert.ToDouble(this.txtActureTotalPrice.Text);

            total_deposit = ActureTotalPrice - totalprice_consume;
            this.lab_posite.Text = Convert.ToString(total_deposit);
            deposit = total_deposit;

        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (this.txtActureTotalPrice.Text == "")
            {
                MessageBox.Show("请输入总收入金额！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("确认开单？", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        using (SqlConnection conn3 = DBHelper.Connection1)
                        {
                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.Connection = conn3;
                            conn3.Open();
                            cmd3.CommandText = "select * from bill where mark='0' and idnumber=" + "'" + idnumber + "'";

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

                                string sql4 = "update bill set totalprice='" + ActureTotalPrice1 + "',totalprice_consume='" + totalprice_consume1 + "',totalprice_deposit='" + total_deposit + "'";
                                SqlDataAdapter adp4 = new SqlDataAdapter(sql4, conn);
                                DataTable table4 = new DataTable();
                                adp4.Fill(table4);
                            }
                            else
                            {
                                string sql3 = "insert into bill(totalprice,totalprice_consume,totalprice_deposit,paydate,customername,idnumber,mark) values ( '" + ActureTotalPrice + "','" + totalprice_consume + "','" + total_deposit + "','" + currenttime + "','" + customername + "','" + idnumber + "','0')";
                                SqlDataAdapter adp3 = new SqlDataAdapter(sql3, conn);
                                DataTable table3 = new DataTable();
                                adp3.Fill(table3);
                            }

                            string sql2 = "insert into billdetail(idnumber,projectnumber,price,days,discount,discountprice,mark,deposit) values ('" + idnumber + "','" + projectnumber1 + "','" + price + "','" + days + "','" + level + "','" + discountprice + "','1','" + deposit + "')";
                            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, conn);
                            DataTable table2 = new DataTable();
                            adp2.Fill(table2);

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
                        }
                        string sql7 = "delete from [order] where idnumber=" + "'" + idnumber + "'";
                        string sql8 = "delete from orderdetail where idnumber=" + "'" + idnumber + "'";
                        SqlDataAdapter adp7 = new SqlDataAdapter(sql7, conn);
                        DataSet ds7 = new DataSet();
                        adp7.Fill(ds7);
                        SqlDataAdapter adp8 = new SqlDataAdapter(sql8, conn);
                        DataSet ds8 = new DataSet();
                        adp7.Fill(ds8);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
