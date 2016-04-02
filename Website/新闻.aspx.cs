using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 新闻 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
        string sql = "select news,text from news where id=" + Convert.ToInt64(Request["id"].ToString());//sql语句        
        SqlConnection con = new SqlConnection(connstr);        
        con.Open();//打开连接        
        SqlCommand cmd = new SqlCommand(sql, con);        
        SqlDataReader dr = cmd.ExecuteReader();        
        while (dr.Read()){            
            TextBox2.Text = dr["news"].ToString();
            TextBox3.Text = dr["text"].ToString();
        }        
            con.Close();//关闭连接    
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