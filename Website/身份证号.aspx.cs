using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 身份证号 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
    SqlConnection sconn = new SqlConnection();
    SqlCommand scmd = new SqlCommand();
    DataSet ds = new DataSet();
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string UserName = user_TextBox.Text.Trim();
        scmd.CommandText = "select * from customer where idnumber='" + UserName + "'";
        sconn.ConnectionString = connstr;
        scmd.Connection = sconn;
        sconn.Open();
        SqlDataReader dr = scmd.ExecuteReader();
        if (dr.Read())
        {
            Session["UserName"] = dr["idnumber"].ToString().Trim();
            if (Request.QueryString["ReturnUrl"] != null)
            {
                Response.Redirect(Request.QueryString["returnUrl"]);
            }
            else
            {
                Response.Redirect("关于我们.aspx");//登陆成功跳转页面
            }
        }
        else
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Startup", "alert('您还未进行预订!');", true);
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