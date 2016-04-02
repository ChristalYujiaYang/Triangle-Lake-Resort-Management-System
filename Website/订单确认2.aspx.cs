using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 订单确认2 : System.Web.UI.Page
{
    string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
    //string connstr = "server=JOHN-PC;uid=sa;pwd=123456;database=三角湖度假村";
    //菜品名称0，单价1，分数2，用餐日期3，用餐时间4，用餐地点5，联系人6，身份证7，联系方式8
    String dingdaninfo = null;
    String[] dingdan = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        dingdaninfo = Request.QueryString["id"].ToString();
        dingdan = dingdaninfo.Split(',');
        //将入住离开日期分别取出前面的日期
        String[] riqi = dingdan[3].Split(' ');
        //联系人
        TextBox2.Text = dingdan[6];
        //TextBox3.Text = (Convert.ToInt32(dingdan[2]) * Convert.ToInt32(dingdan[1])).ToString();
        TextBox3.Text = (Convert.ToDecimal(dingdan[1]) * Convert.ToInt32(dingdan[2])).ToString() + "元";
        //名称
        TextBox4.Text = dingdan[0];
        //使用日期
        TextBox5.Text = riqi[0] + " " + dingdan[4]+" "+dingdan[5];
        //单价
        TextBox6.Text = dingdan[1];
        //联系方式
        TextBox7.Text = dingdan[8];

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //用来记录打折后的价格
        decimal discountprice1 = 0;
        //用来记录会员的打折额度，不是会员的默认为1
        decimal discount1 = 1;
        //原价
        decimal price1 = Convert.ToDecimal(dingdan[1]) * Convert.ToInt32(dingdan[2]);
        int days1 = Convert.ToInt16(dingdan[2]);
        //创建数据库连接对象
        SqlConnection con = new SqlConnection(connstr);
        //用于判断Customer中有没有记录
        String sql1 = "SELECT * FROM customer WHERE idnumber='" + dingdan[7] + "'";
        //用于判断Order中有没有记录
        String sql2 = "SELECT * FROM [order] WHERE idnumber='" + dingdan[7] + "'";
        //用于判断Bill中有没有记录
        String sql3 = "SELECT * FROM bill WHERE idnumber='" + dingdan[7] + "'";
        //String sql10 = "UPDATE " + dingdan[12] + " SET status='预订' WHERE " + dingdan[13] + "='" + dingdan[11] + "'";
        //打开数据库
        con.Open();
        //SqlCommand cmd10 = new SqlCommand(sql10, con);
        //cmd10.ExecuteNonQuery();
        //查询Customer表中是否有记录
        SqlCommand cmd1 = new SqlCommand(sql1, con);
        //在顾客表中没有记录，即不存在订单
        SqlDataAdapter sdr1 = new SqlDataAdapter(cmd1);
        DataTable dt1 = new DataTable();
        sdr1.Fill(dt1);
        if (dt1.Rows.Count == 0)
        {
            //查询该顾客是否是会员，输出打折后价格discountprice
            discount1 = IsVip(con);
            discountprice1 = GetDiscountPrice(con);
            //sql = "insert into table (字段1，字段2) values ('xx','aa')";//增
            //向顾客表中插入信息
            String sql4 = "INSERT INTO customer (name,idnumber,phonenumber) values ('" + dingdan[6] + "','" + dingdan[7] + "','" + dingdan[8] + "')";
            SqlCommand cmd2 = new SqlCommand(sql4, con);
            cmd2.ExecuteNonQuery();
            //向Order和OrderDetail中插入数据
            InsertOrder(con, discountprice1, discount1,days1, price1);
            con.Close();
            Response.Redirect("预订成功.aspx");
        }
        //客户表中已经有该客户的信息
        else
        {
            discount1 = IsVip(con);
            discountprice1 = GetDiscountPrice(con);
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlDataAdapter sdr2 = new SqlDataAdapter(cmd3);
            DataTable dt2 = new DataTable();
            sdr2.Fill(dt2);
            //TextBox8.Text = dt2.Rows.Count.ToString();
            if (dt2.Rows.Count > 0)
            {
                //菜品名称0，单价1，分数2，用餐日期3，用餐时间4，用餐地点5，联系人6，身份证7，联系方式8
                string sql4 = "SELECT * FROM bill WHERE idnumber='" + dingdan[7] + "'AND mark=0";
                SqlCommand cmd4 = new SqlCommand(sql4, con);
                SqlDataAdapter sdr3 = new SqlDataAdapter(cmd4);
                DataTable dt3 = new DataTable();
                sdr3.Fill(dt3);
                //TextBox9.Text = dt2.Rows.Count.ToString();
                if (dt3.Rows.Count > 0)
                {
                    noInsertBill(con, discountprice1, discount1, days1, price1);
                    con.Close();
                    Response.Redirect("预订成功.aspx");
                }
                else
                {
                    SqlCommand cmd5 = new SqlCommand(sql2, con);
                    SqlDataAdapter sdr4 = new SqlDataAdapter(cmd5);
                    DataTable dt4 = new DataTable();
                    sdr4.Fill(dt4);
                    //TextBox10.Text = dt2.Rows.Count.ToString();
                    if (dt4.Rows.Count > 0)
                    {
                        noInsertOrder(con, discountprice1, discount1, days1, price1);
                        con.Close();
                        Response.Redirect("预订成功.aspx");
                    }
                    else
                    {
                        InsertOrder(con, discountprice1, discount1, days1, price1);
                        con.Close();
                        Response.Redirect("预订成功.aspx");
                    }
                }

            }
            else
            {
                discount1 = IsVip(con);
                discountprice1 = GetDiscountPrice(con);
                SqlCommand cmd5 = new SqlCommand(sql2, con);
                SqlDataAdapter sdr4 = new SqlDataAdapter(cmd5);
                DataTable dt4 = new DataTable();
                sdr4.Fill(dt4);
                //TextBox10.Text = dt2.Rows.Count.ToString();
                if (dt4.Rows.Count > 0)
                {
                    noInsertOrder(con, discountprice1, discount1, days1, price1);
                    con.Close();
                    Response.Redirect("预订成功.aspx");
                }
                else
                {
                    InsertOrder(con, discountprice1, discount1, days1, price1);
                    con.Close();
                    Response.Redirect("预订成功.aspx");
                }
            }
        }
    }

    //查看是否是VIP，计算打折后的价格
    protected decimal IsVip(SqlConnection con)
    {
        int level = 0;
        decimal discount1;
        String sql7 = "SELECT * FROM vip WHERE idnumber='" + dingdan[7] + "'";
        SqlCommand cmd5 = new SqlCommand(sql7, con);
        SqlDataAdapter sdr = new SqlDataAdapter(cmd5);
        DataTable dt = new DataTable();
        sdr.Fill(dt);
        //该顾客是会员
        if (dt.Rows.Count > 0)
        {
            String sql8 = "Select level From vip WHERE idnumber='" + dingdan[7] + "'";
            SqlCommand cmd6 = new SqlCommand(sql8, con);
            SqlDataReader dr1 = cmd6.ExecuteReader();
            while (dr1.Read())
            {
                level = Convert.ToInt16(dr1["level"]);
            }
            dr1.Close();
            discount1 = Convert.ToDecimal(1 - 0.05 * (level - 1));
            return discount1;
        }
        else
        {
            return 1;
        }
    }
    //计算会员的折扣后的价格
    protected decimal GetDiscountPrice(SqlConnection con)
    {
        decimal discount1 = IsVip(con);
        decimal discountprice1 = discount1 * Convert.ToDecimal(dingdan[1]) * Convert.ToInt32(dingdan[2]);
        return discountprice1;
    }


    //直接插入数据
    protected void InsertOrder(SqlConnection con, decimal discountprice1, decimal discount1, int days1, decimal price1)
    {
        //decimal price1 = Convert.ToDecimal(dingdan[2]);
        //向order中插入信息
        //菜品名称0，单价1，分数2，用餐日期3，用餐时间4，用餐地点5，联系人6，身份证7，联系方式8
        String sql5 = "INSERT INTO [order] (customername,idnumber,totalprice,date,phonenumber) values ('" + dingdan[6] + "','" + dingdan[7] + "'," + discountprice1 + ",'" + dingdan[3] + "','"+ dingdan[8] +"')";
        SqlCommand cmd3 = new SqlCommand(sql5, con);
        cmd3.ExecuteNonQuery();
        //向OrderDetail中插入信息
        String sql6 = "INSERT INTO orderdetail (price,days,discount,discountprice,idnumber,projectnumber,startdate) values (" + price1 + "," + days1 + "," + discount1 + "," + discountprice1 + ",'" + dingdan[7] + "','" + dingdan[0] + "','" + dingdan[3] + "')";
        SqlCommand cmd4 = new SqlCommand(sql6, con);
        cmd4.ExecuteNonQuery();
    }

    //向OrderDetail中插入数据，修改Order中的总价
    protected void noInsertOrder(SqlConnection con, decimal discountprice1, decimal discount1, int days1, decimal price1)
    {
        decimal jine = 0;

        //decimal price1 = Convert.ToDecimal(dingdan[2]);
        //向OrderDetail中插入信息
        String sql6 = "INSERT INTO orderdetail (price,days,discount,discountprice,idnumber,projectnumber,startdate) values (" + price1 + "," + days1 + "," + discount1 + "," + discountprice1 + ",'" + dingdan[7] + "','" + dingdan[0] + "','" + dingdan[3] + "')";
        SqlCommand cmd4 = new SqlCommand(sql6, con);
        cmd4.ExecuteNonQuery();
        //从order表中查询到该顾客已消费的金额
        String sql5 = "Select * FROM [order] WHERE idnumber ='" + dingdan[7] + "'";
        SqlCommand cmd3 = new SqlCommand(sql5, con);
        SqlDataReader dr1 = cmd3.ExecuteReader();
        while (dr1.Read())
        {
            jine = Convert.ToDecimal(dr1["totalprice"]);
        }
        dr1.Close();
        //计算现在新的总价
        jine = jine + discountprice1;
        String sql7 = "UPDATE [order] SET totalprice='" + jine + "' WHERE idnumber='" + dingdan[7] + "'";
        SqlCommand cmd5 = new SqlCommand(sql7, con);
        cmd5.ExecuteNonQuery();
    }
    //向BillDetail中插入数据，修改bill中的总价
    protected void noInsertBill(SqlConnection con, decimal discountprice1, decimal discount1, int days1, decimal price1)
    {
        decimal jine = 0;
        //decimal price1 = Convert.ToDecimal(dingdan[2]);
        //向OrderDetail中插入信息
        String sql6 = "INSERT INTO billdetail (price,days,discount,discountprice,idnumber,projectnumber) values (" + price1 + "," + days1 + "," + discount1 + "," + discountprice1 + ",'" + dingdan[7] + "','" + dingdan[0] + "')";
        SqlCommand cmd4 = new SqlCommand(sql6, con);
        cmd4.ExecuteNonQuery();
        //从order表中查询到该顾客已消费的金额
        String sql5 = "Select * FROM bill WHERE idnumber ='" + dingdan[7] + "'";
        SqlCommand cmd3 = new SqlCommand(sql5, con);
        SqlDataReader dr1 = cmd3.ExecuteReader();

        //计算现在新的总价
        while (dr1.Read())
        {
            jine = Convert.ToDecimal(dr1["totalprice_consume"]);
        }
        dr1.Close();
        jine = jine + discountprice1;
        String sql7 = "UPDATE bill SET totalprice_consume='" + jine + "' WHERE idnumber='" + dingdan[7] + "'";
        SqlCommand cmd5 = new SqlCommand(sql7, con);
        cmd5.ExecuteNonQuery();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        dingdaninfo = null;

        Response.Redirect("服务项目.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String neirong = TextBox1.Text.ToString();
        if (neirong == "客房" || neirong == "标准间" || neirong == "别墅" || neirong == "豪华包间")
            Response.Redirect("服务项目.aspx?id=room");
        if (neirong == "会议室")
            Response.Redirect("服务项目.aspx?id=meetingroom");
        if (neirong == "棋牌室" || neirong == "娱乐项目")
            Response.Redirect("服务项目.aspx?id=chessroom");
        if (neirong == "乒乓球室" || neirong == "乒乓球")
            Response.Redirect("服务项目.aspx?id=meetingroom");
        if (neirong == "餐厅" || neirong == "订餐位置")
            Response.Redirect("服务项目.aspx?id=diningroom");
        if (neirong == "餐饮" || neirong == "订餐")
            Response.Redirect("餐饮项目.aspx?id=ordermeal");
        else
            Response.Redirect("无此项目.aspx");
    }
}