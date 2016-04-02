using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class 服务项目 : System.Web.UI.Page
{
    protected static PagedDataSource pds = new PagedDataSource();//创建一个分页数据源的对象且一定要声明为静态
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            //调用自定义方法绑定数据到控件（为以后做MVC打下基础）
            BindDataList(0);
       // } 
    }
    private void BindDataList(int currentpage)
    {
        string type=null;
        if (Request.QueryString["id"] == null)
            type = "room";
        else
            type = Request.QueryString["id"].ToString();
        
        string connstr = "server=XP;uid=sa;pwd=123456;database=三角湖度假村"; 
        //string connstr = "server=JOHN-PC;uid=sa;pwd=123456;database=三角湖度假村";
        //创建数据库连接对象
        SqlConnection con = new SqlConnection(connstr);
        //定义查询语句,这里最好将SQL语句在SQL中写好并验证正确确在复制粘贴过来（在对数据查询时最好只查所需的一些不需要的数据就不要取出，这样可以提高运行的效率）
        string strSql1 = "SELECT * FROM service WHERE type='" +type+ "'";//定义一条SQL语句
        con.Open();//打开数据库连接 (当然此句可以不写的)
        //SqlCommand cmd = new SqlCommand(strSql1, con);
        //SqlDataReader dr = cmd.ExecuteReader();
        //Session["perprice"] = dr["price"].ToString();
        SqlDataAdapter adapter1 = new SqlDataAdapter(strSql1, con);
        DataSet ds = new DataSet();
        adapter1.Fill(ds);//把执行得到的数据放在数据集中
        pds.DataSource = ds.Tables[0].DefaultView;//把数据集中的数据放入分页数据源中
        DataList1.DataSource = pds;//绑定Datalist
        DataList1.DataBind();
        con.Close();
        this.PageInfo.InnerHtml = PageNums.GetPageNum(ds, DataList1, 3); //传入DataSet,DataList名称和分页大小
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Session["perprice"] = perprice.Text.Trim();
        Response.Redirect("预订.aspx");
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