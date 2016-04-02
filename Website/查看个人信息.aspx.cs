using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 查看个人信息 : System.Web.UI.Page
{  
    string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {//判断是否为初次执行
            if (Object.Equals(Session["UserName"], null))
            {//判断在Session["UserName"]是否存在值
                Response.Redirect("登录.aspx");
            }
            else
            {//要是存在则记录下这个人的用户名
                TextBox5.Text = Session["UserName"].ToString();
            }
        }
        string sql = "select name,address,idnumber,phonenumber,sex,level from vip where idnumber='"+Convert.ToString(TextBox5.Text)+"'";//sql语句        
        SqlConnection con = new SqlConnection(connstr);        
        con.Open();//打开连接        
        SqlCommand cmd = new SqlCommand(sql, con);        
        SqlDataReader dr = cmd.ExecuteReader();        
        while (dr.Read()){            
            TextBox2.Text = dr["name"].ToString();
            TextBox3.Text = dr["idnumber"].ToString();
            TextBox4.Text = dr["phonenumber"].ToString();
            TextBox5.Text = dr["idnumber"].ToString();
            TextBox6.Text = dr["sex"].ToString();
            TextBox7.Text = dr["level"].ToString();
            string y = dr["level"].ToString();
            int x = Convert.ToInt32(y);
            TextBox8.Text = (10-x).ToString();
            Session["address"] = dr["address"].ToString();
        }        
            con.Close();//关闭连接    
            Session["name"] = TextBox2.Text.Trim();
            Session["phonenumber"] = TextBox4.Text.Trim();
            Session["sex"] = TextBox6.Text.Trim();
            //TextBox15.Text = Session["dizhi"].ToString();
        }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("修改个人信息.aspx");
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