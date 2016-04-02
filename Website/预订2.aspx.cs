using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 预订2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox5.Text = Request["duct"].ToString();
        price.Text = Request["pre"].ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String orderinfo = null;
        //菜品名称0，单价1，分数2，用餐日期3，用餐时间4，用餐地点5，联系人6，身份证7，联系方式8
        orderinfo = Request["duct"].ToString() + "," + Request["pre"].ToString() + "," + DropDownList4.SelectedValue + "," + Calendar1.SelectedDate + "," + DropDownList3.SelectedValue + "," + DropDownList2.SelectedValue+ "," +TextBox2.Text+","+TextBox3.Text+","+TextBox4.Text;
        Session["orderinfo"] = orderinfo;
        Response.Redirect("订单确认2.aspx?id=" + orderinfo);

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTime dt1 = Calendar1.SelectedDate;
        DateTime dt2 = DateTime.Now;
        if (DateTime.Compare(dt1, dt2) < 0)
        {
            Label1.Visible = true;
        }
        else
            Label1.Visible = false;

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