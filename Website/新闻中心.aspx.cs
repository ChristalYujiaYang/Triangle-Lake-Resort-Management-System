using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

public partial class 新闻中心 : System.Web.UI.Page
{
    protected SqlConnection conn; //添加数据库的操作对象
    protected SqlDataAdapter da;
    protected DataSet ds;
    protected SqlCommand comm;
    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new SqlConnection("server=(local);uid=sa;pwd=123456;database=三角湖度假村");//取连接字符串,建立连接
        da = new SqlDataAdapter();
        da.SelectCommand = new SqlCommand("select  * from news", conn);
        ds = new DataSet();
        try
        {
            conn.Open();
            da.Fill(ds, "abs");
            conn.Close();
        }
        catch (SqlException e1)
        {
            Response.Write(e1.ToString());
        }


        this.PageInfo.InnerHtml = PageNums.GetPageNum(ds, DataList1, 5); //传入DataSet,DataList名称和分页大小
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