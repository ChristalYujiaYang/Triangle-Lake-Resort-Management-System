using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 修改个人信息aspx : System.Web.UI.Page
{
    string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) //没有这个东西，下面的修改无法正常运行。
        {
            TextBox6.Text = Session["UserName"].ToString();
            string sql = "select name,address,password,idnumber,phonenumber,sex,level from vip where idnumber='" + Convert.ToString(TextBox6.Text) + "'";//sql语句        
            SqlConnection con = new SqlConnection(connstr);
            con.Open();//打开连接  
            //SqlDataReader reader = SQLHelp.ExecuteReader(sql);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox2.Text = dr["name"].ToString();
                TextBox4.Text = dr["phonenumber"].ToString();
                TextBox5.Text = dr["address"].ToString();
                TextBox7.Text = dr["password"].ToString();
                DropDownList1.Text = Session["sex"].ToString();
            }
            con.Close();//关闭连接   
            /*TextBox2.Text = Session["name"].ToString();
            TextBox4.Text = Session["phonenumber"].ToString();
            TextBox5.Text = Session["address"].ToString();
            TextBox7.Text = Session["Password"].ToString();
            DropDownList1.Text = Session["sex"].ToString();*/
        }
    }

        protected void  Button2_Click(object sender, EventArgs e)
        {
            //TextBox15.Text = TextBox4.Text;
            if (TextBox2.Text == null || TextBox4.Text == null || TextBox5.Text == null || TextBox7.Text == null) {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Startup", "alert('星号处为必填项！');", true);
            }
            else
            {
                string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
                SqlConnection con = new SqlConnection(connstr);
                string SqlUpdate = "UPDATE vip SET name='" + Convert.ToString(TextBox2.Text).Trim() + "',sex='" + Convert.ToString(DropDownList1.Text) + "',password='" + Convert.ToString(TextBox7.Text).Trim() + "',phonenumber='" + Convert.ToString(TextBox4.Text).Trim() + "',address='" + Convert.ToString(TextBox5.Text).Trim() + "'where idnumber='" + TextBox6.Text.Trim() + "'";
                con.Open();
                SqlCommand sqlcom = new SqlCommand(SqlUpdate, con);
                sqlcom.ExecuteNonQuery();
                con.Close();
                //Session["dizhi"] = TextBox5.Text.Trim();
                Response.Redirect("查看个人信息.aspx");

            }

            /* 
             *  if (!Page.IsPostBack) //没有这个东西，下面的修改无法正常运行。

         {

 int Id = Convert.ToInt32(Request.QueryString["Id"]);//获取ID

             string StrSql = "SELECT * FROM [guanlibanfa] WHERE Id=" + Id.ToString();

             SqlDataReader reader = SQLHelp.ExecuteReader(StrSql);

             if (reader.Read())

             {

                 biaoti.Text = Convert.ToString(reader["biaoti"]);

                 neirong.Text = Convert.ToString(reader["neirong"]);

             }

  reader.Close();//关闭读取，必须要有这个语句。

         }
             * string sqlcon = "Data Source=(local);Initial Catalog=客户关系管理;Integrated Security=True";
             SqlConnection myConnection = new SqlConnection(sqlcon);
             myConnection.Open();
             SqlCommand com = new SqlCommand("update 管理员信息 set 密码 = '" + TextBox3.Text + "' where 员工编号= '" + TextBox1.Text + "'");
             com.Connection = myConnection;
             com.ExecuteNonQuery();
              * SqlConnection myCon = new SqlConnection(connstr);
             string cmd = "insert into vip(name,phonenumber,idnumber) values('" + Convert.ToString(TextBox2.Text) + "','" + Convert.ToString(TextBox4.Text) + "','" + Convert.ToString(TextBox6.Text) + "')"; 
             SqlCommand mySql = new SqlCommand(cmd, myCon); 
             SqlDataAdapter sda = new SqlDataAdapter(); 
             myCon.Open(); 
             mySql .ExecuteNonQuery(); 
             myCon.Close(); 增加一条记录*/
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