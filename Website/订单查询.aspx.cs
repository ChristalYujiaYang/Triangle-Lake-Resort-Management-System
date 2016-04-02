using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class 订单查询 : System.Web.UI.Page
{
    string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
    protected static PagedDataSource pds = new PagedDataSource();//创建一个分页数据源的对象且一定要声明为静态
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {//判断是否为初次执行
            if (Object.Equals(Session["UserName"], null))
            {//判断在Session["UserName"]是否存在值
                Response.Redirect("身份证号.aspx?returnUrl=订单查询.aspx");
            }
            //调用自定义方法绑定数据到控件（为以后做MVC打下基础）
            BindDataList(0);
        }
        string sql = "select customername,totalprice from [order] where idnumber='" + Session["UserName"] + "'";//sql语句        
        SqlConnection con = new SqlConnection(connstr);
        con.Open();//打开连接        
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            TextBox2.Text = dr["customername"].ToString();
            TextBox3.Text = dr["totalprice"].ToString();
        }
        con.Close();//关闭连接 
    }
    private void BindDataList(int currentpage)
    {
        string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
        //创建数据库连接对象
        SqlConnection con = new SqlConnection(connstr);
        //定义查询语句,这里最好将SQL语句在SQL中写好并验证正确确在复制粘贴过来（在对数据查询时最好只查所需的一些不需要的数据就不要取出，这样可以提高运行的效率）
        string strSql1 = "SELECT projectnumber,days,price FROM orderdetail where idnumber='" + Session["UserName"] + "'";//定义一条SQL语句
        con.Open();//打开数据库连接 (当然此句可以不写的)
        SqlDataAdapter adapter1 = new SqlDataAdapter(strSql1, con);
        DataSet ds = new DataSet();
        adapter1.Fill(ds);//把执行得到的数据放在数据集中
        pds.DataSource = ds.Tables[0].DefaultView;//把数据集中的数据放入分页数据源中
        DataList1.DataSource = pds;//绑定Datalist
        DataList1.DataBind();
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
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