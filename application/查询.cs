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

    public partial class 查询 : Form
    {
        public static string idnumber;
        public 查询( )
        {
            InitializeComponent();
            

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text == "")
            {
                MessageBox.Show("请输入客户身份证号！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    idnumber = this.txtID.Text;
                    SqlConnection conn = DBHelper.Connection1;
                    using (SqlConnection conn1 = DBHelper.Connection1)
                    {
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = conn1;
                        conn1.Open();
                        cmd1.CommandText = "select * from orderdetail where idnumber='" + idnumber + "'";
                        SqlDataReader mysdr = cmd1.ExecuteReader();                                                             
                        if (mysdr.HasRows)
                        {
                            预订开单 Order1 = new 预订开单(idnumber);
                            Order1.Show();

                        }
                        else
                        {
                            MessageBox.Show("此客户没有预定项目！", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        }
                    }
                }
                catch (Exception ex)//抛出异常            
                {
                    MessageBox.Show(ex.Message);//弹出消息对话框            
                }
                this.Close();
            }
        }
    }
}