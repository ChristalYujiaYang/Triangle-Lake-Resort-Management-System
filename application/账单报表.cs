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
    public partial class 账单报表 : Form
    {
        public static DateTime dt1;
        public static DateTime dt2;
        public static string idnumber;
        public static string roomnumber;
        public static string[] project1;
        public 账单报表()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMark.Text == "")
                {
                    SqlConnection conn = DBHelper.Connection1;

                    conn.Open();

                    //SqlCommand cmd = new SqlCommand("select * from bill", sqlcon);

                    dt1 = Convert.ToDateTime(this.dateTimePicker1.Text);
                    dt2 = Convert.ToDateTime(this.dateTimePicker2.Text);
                    idnumber = this.txtMark.Text;
                    String sql1 = "select * from bill where paydate between" + "'" + dt1 + "'" + " and " + "'" + dt2 + "' ";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();

                    adp.Fill(ds);
                    this.dgvBillStatus.DataSource = ds.Tables[0];

                    conn.Close();
                }
                else
                {
                    SqlConnection conn = DBHelper.Connection1;
                    conn.Open();
                    //SqlCommand cmd = new SqlCommand("select * from bill", sqlcon);

                    dt1 = Convert.ToDateTime(this.dateTimePicker1.Text);
                    dt2 = Convert.ToDateTime(this.dateTimePicker2.Text);
                    idnumber = this.txtMark.Text;
                    String sql1 = "select * from bill where paydate between" + "'" + dt1 + "'" + " and " + "'" + dt2 + "' and idnumber=" + "'" + idnumber + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();

                    adp.Fill(ds);
                    this.dgvBillStatus.DataSource = ds.Tables[0];

                    conn.Close();
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                roomnumber = this.txtRoomNumber.Text.ToString();
                dt2 = DateTime.Now.AddDays(30);
                dt1 = DateTime.Now;
                SqlConnection conn = DBHelper.Connection1;
                SqlCommand cmd = new SqlCommand();//实体化SqlCommand
                cmd.Connection = conn;//为cmd的Connetion属性赋值
                conn.Open();

                //String sql1 = "select orderdetail.ordernumber,projectnumber,days,orderdetail.idnumber,customername,hours,discountprice from orderdetail,[order] where [order].date between" + "'" + dt1 + "'" + " and " + "'" + dt2 + "' and orderdetail.projectnumber=" + "'" + roomnumber + "'";
                string sql1 = "select * from orderdetail where idnumber in (select idnumber from [order] where [date] between " + "'" + dt1 + "'" + " and " + "'" + dt2 + "') and projectnumber=" + "'" + roomnumber + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                DataSet ds = new DataSet();

                adp.Fill(ds);
                this.dgvRoom.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void Bind()
        {
            this.dataGridView1.DataSource = detailtable;
        }
        //状态修改
        private void modefiy(string _project)
        {
            string xx = "";
            if (_project.Substring(0, 2) == "RM")
            {
                xx = "update room set status='空闲' where room_num='" + _project + "'";
            }
            else if (_project.Substring(0, 2) == "MT")
            {
                xx = "update meetingroom set status='空闲' where meetingnumber='" + _project + "'";
            }
            else if (_project.Substring(0, 2) == "TB")
            {
                xx = "update tabletennis set status='空闲' where tablenumber='" + _project + "'";
            }
            else if (_project.Substring(0, 2) == "CR")
            {
                xx = "update chessroom set status='空闲' where chessnumber='" + _project + "'";
            }
            DBHelper.ExecuteCommand(xx);

        }
        //查询order
        DataTable ordertable;
        DataTable detailtable;
        public string _idnumber = System.String.Empty;
        private void check_order(string _idnumber)
        {
            string cko = "select * from [order] where idnumber='" + _idnumber + "'";


            ordertable = DBHelper.GetDataSet(cko);

        }
        //查询orderdetail
        private void check_detail(string _idnumber)
        {
            string cko;
            if (_idnumber == System.String.Empty)
            {
                cko = "select ordernumber,projectnumber,price,days,discount,discountprice from orderdetail";
            }
            else
            {
                cko = "select ordernumber,projectnumber,price,days,discount,discountprice from orderdetail where idnumber=" + "'" + _idnumber + "'";
            }
            detailtable = DBHelper.GetDataSet(cko);
        }



        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == System.String.Empty)
            {
                MessageBox.Show("请输入身份证号", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _idnumber = this.textBox1.Text.Trim();
                check_order(_idnumber);
                check_detail(_idnumber);
                if (ordertable.Rows.Count > 0)
                {
                    this.label11.Text = ordertable.Rows[0]["customername"].ToString();
                    this.label9.Text = ordertable.Rows[0]["phonenumber"].ToString();
                    Bind();
                }
                else
                {
                    MessageBox.Show("抱歉，您没有预定项目！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _idnumber = this.textBox1.Text.Trim();
            check_detail(_idnumber);
            Bind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _idnumber = this.textBox1.Text.Trim();
            if (this.dataGridView1.SelectedRows.Count == 0 || _idnumber == System.String.Empty)
            {
                MessageBox.Show("请先先查询并单击每行最左边选择要删除的行！");
            }
            else
            {
                if (MessageBox.Show("确定删除此信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sc0 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string sc1 = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    if (this.dataGridView1.Rows.Count == 1)//就预定了一个项目
                    {
                        string sql = "delete from orderdetail where ordernumber =" + "'" + sc0 + "'";
                        int result = DBHelper.ExecuteCommand(sql);
                        modefiy(sc1);
                        string sql1 = "delete from [order] where idnumber=" + "'" + _idnumber + "'";
                        int result1 = DBHelper.ExecuteCommand(sql1);
                        check_detail(_idnumber);
                        Bind();
                    }
                    else//预定了多个项目
                    {
                        double totalprice_consume;
                        int _days = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        int _hours = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[6].Value.ToString());
                        double _price = Convert.ToDouble(this.dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        if (_days == 0)
                        {
                            totalprice_consume = _price * _hours;
                        }
                        else
                        {
                            totalprice_consume = _price * _days;
                        }
                        totalprice_consume = Convert.ToDouble(ordertable.Rows[0]["totalprice_consume"].ToString()) - totalprice_consume;
                        string sqlbm = "update [order] set totalprice_consume='" + totalprice_consume + "'  where idnumber='" + _idnumber + "'";
                        int gx = DBHelper.ExecuteCommand(sqlbm);
                        string sql = "delete from orderdetail where ordernumber =" + "'" + sc0 + "'";
                        int result = DBHelper.ExecuteCommand(sql);
                        modefiy(sc1);
                        check_detail(_idnumber);
                        Bind();

                    }
                }
            }
        }

        private void 账单报表_Load(object sender, EventArgs e)
        {

        }
    }
}
