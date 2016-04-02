using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class 预订 : System.Web.UI.Page
{
    //string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
    //string connstr = "server=JOHN-PC;uid=sa;pwd=123456;database=三角湖度假村";
    String duct = null;
    DateTime start;
    DateTime leave;
    String tablename=null;
    String type=null;
    String project=null;
    static List<string> list = new List<string>();//声明静态数组
    protected void Page_Load(object sender, EventArgs e)
    {  
        //具体类型 
        duct = Request["duct"].ToString();
        TextBox5.Text = Request["duct"].ToString();
        //单价
        price.Text = Request["pre"].ToString();
        TextBox7.Text = "17:00";
        //room？chessroom？。。。
        type=Request["id"].ToString();
        int n=String.Compare(type,"villa");
        if(n==0)
            tablename="room";
        else
            tablename=type;
        if(String.Compare(tablename,"room")==0)
            project="room_num";
        if(String.Compare(tablename,"diningroom")==0)
            project="diningnumber";
        if(String.Compare(tablename,"chessroom")==0)
            project="chessnumber";
        if(String.Compare(tablename,"tabletennis")==0)
            project="tablenumber";
        if(String.Compare(tablename,"meetingroom")==0)
            project="meetingnumber";
        //TextBox6.Text = Request["pre"].ToString();
        //price.Text = (Convert.ToInt32(Request["pre"].ToString()) * Convert.ToInt32(DropDownList1.Text)).ToString();
        //Session["shuzu"] = list;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        //string statue1="空闲";
        //联系人
        Session["name"] = TextBox2.Text.Trim();
        //单价
        Session["price"] = TextBox6.Text.Trim();
        //根据日期查询可不可以预订；
        string connstr = "server=(local);uid=sa;pwd=123456;database=三角湖度假村";
        //string connstr = "server=JOHN-PC;uid=sa;pwd=123456;database=三角湖度假村";
        //创建数据库连接对象
        
        SqlConnection con = new SqlConnection(connstr);
        con.Open();//打开连接
        //int m=String.Compare(tablename,"
        //if(
        //'" + tablename + "'
        String sql = "SELECT * FROM " + tablename + " WHERE status ='空闲'AND type ='" + duct + "'";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataAdapter sdr = new SqlDataAdapter(cmd);
        DataTable dt= new DataTable();
        sdr.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            Response.Redirect("无空闲项目.aspx");
        }
        else
        {
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Session["projectid"] = dr[""+ project +""];
            }
            dr.Close();
            con.Close();
            //TextBox9.Text = statue1;
            //TextBox8.Text = Session["projectid"].ToString();
            String projectid1 = Session["projectid"].ToString();        
            //预订信息写入字符串（项目名，预订天数，单价，入住日期，最后使用时间，入住人数，联系人，身份证号，联系电话,类型
            String dingdaninfo = TextBox5.Text + "," + DropDownList1.SelectedValue + "," + Request["pre"].ToString() + "," + Calendar1.SelectedDate.ToString() + "," + TextBox7.Text + "," + DropDownList2.SelectedValue.ToString() + "," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text + "," + Request["id"].ToString() + "," + Calendar2.SelectedDate.ToString() + "," + Session["projectid"]+","+tablename+","+project;
            this.TextBox2.Text = "";//清空TextBox2数据
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";
            this.DropDownList1.SelectedValue = "1";
            Response.Redirect("订单确认.aspx?id=" + dingdaninfo);
        }
    }
    protected void DropDownList1_TextChanged(object sender, EventArgs e)
    {
       //TextBox5.Text = Request["id"].ToString();
       //TextBox6.Text =( Convert.ToInt32(Request["pre"].ToString())* Convert.ToInt32(DropDownList1.Text)).ToString();
       //price.Text = (Convert.ToInt32(Request["pre"].ToString()) * Convert.ToInt32(DropDownList1.Text)).ToString();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        string s = Calendar1.SelectedDate.ToString();
        String[] s1 = s.Split(' ');
        Session["startdate"] = s1[0];
        TextBox7.Text =Session["startdate"]+"17:00";
        start = Calendar1.SelectedDate;
        DateTime dt1=start;
        DateTime dt2=DateTime.Now;
        if (DateTime.Compare(dt1, dt2) < -1)
        {
            Label1.Visible = true;
        }
        else
            Label1.Visible = false;
        //DateTime longestdate = dt1 + 10;

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["selectdays"] = DropDownList1.SelectedValue;
        //int a = (Convert.ToInt32(Request["pre"].ToString()) * Convert.ToInt32(DropDownList1.SelectedValue));
        //DropDownList1.SelectedValue
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        leave = Calendar2.SelectedDate;
        DateTime dt1 = start;
        DateTime dt2 = DateTime.Now;
        DateTime dt3 = leave;
        if (DateTime.Compare(dt3, dt2) < 0)
        {
            Label2.Visible = true;
        }
        else
            Label2.Visible = false;

        if (DateTime.Compare(dt3,dt1) < 0)
        {
            Label2.Visible = true;
        }
        else
            Label2.Visible = false;
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