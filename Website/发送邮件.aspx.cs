using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class 发送邮件 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public static string SendMail(string StrTo, string StrBody, string strSubjec)
    {
        MailMessage onemail = new MailMessage();
        string myEmail = "yangyujiacrystal@gmail.com"; //发送邮件的邮箱地址
        string myPwd = "ANGEL16yjroy"; //发送邮件的邮箱密码
        onemail.BodyEncoding = System.Text.Encoding.UTF8;
        onemail.IsBodyHtml = true;
        onemail.From = new MailAddress(myEmail);
        onemail.To.Add(new MailAddress(StrTo));
        onemail.Subject = strSubjec;
        onemail.Body = StrBody;
        SmtpClient clint = new SmtpClient("smtp.gmail.com", 587);//发送邮件的服务器
        clint.Credentials = new System.Net.NetworkCredential(myEmail, myPwd);
        clint.EnableSsl = true;
        clint.Timeout = 15000;
        try { clint.Send(onemail); }
        catch (Exception ex) { return ex.Message; }
        return "";
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        SendMail("593201827@qq.com",zhengwen.Text.Trim(),zhuti.Text.Trim());
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "Startup", "alert('发送成功!');", true);
        zhuti.Text = "";
        zhengwen.Text = "";
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
    