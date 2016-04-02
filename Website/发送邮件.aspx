<%@ Page Language="C#" AutoEventWireup="true" CodeFile="发送邮件.aspx.cs" Inherits="发送邮件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>三角湖度假村</title>
    <style type="text/css">
        #Text1 {
            height: 19px;
            width: 147px;
        }
    </style>
</head>
<body>
    <div id='loaddiv' runat="server" style="display:none;position:absolute;width:300px;height:200px;z-index:100">
        用户名或密码错误，请重新输入！
    </div>
    <form id="form1" runat="server">
    <table>
    <tr>
    <td>
    <table id="1" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>
    
        <asp:Image ID="Image3" runat="server" ImageUrl="~/图片/三角湖度假村logo.jpg" />
    
    </td>
    <td width="400">

    </td>
    <td>

        <asp:TextBox ID="TextBox1" runat="server" BackColor="White" 
            BorderColor="#DDECEF" BorderWidth="2px" Height="21px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="搜索" BackColor="#AACDC9" 
            ForeColor="Black" onclick="Button1_Click" />
    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="2" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>

        <img src="图片/导航条.jpg" width="1349" height="33" border="0" usemap="#Map" alt=""/>
<map name="Map" id="Map"><area shape="rect" coords="207,1,287,32" href="首页.aspx" alt="" />
<area shape="rect" coords="326,2,413,39" href="关于我们.aspx" alt="" /><area shape="rect" coords="437,0,525,38" href="企业文化.aspx"alt="" />
<area shape="rect" coords="558,3,632,30" href="新闻中心.aspx" alt=""/><area shape="rect" coords="685,1,758,34" href="服务项目.aspx?id=room" alt=""/>
<area shape="rect" coords="815,3,900,32" href="联系我们.aspx" alt=""/><area shape="rect" coords="944,1,1026,31" href="查看个人信息.aspx"alt="" />
<area shape="rect" coords="1063,3,1131,32" href="订单查询.aspx" alt=""/></map>

    </td>
    </tr>
    <tr>
    <td>

        <asp:Image ID="Image2" runat="server" ImageUrl="~/图片/会员登录.jpg" />

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="3" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>
        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/联系我们左.jpg" />
    </td>
    <td>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/图片/联系我们右.jpg" Width="962px" />
    </td>
    </tr>
    <tr>
    <td>
    <table id="5" border="0" cellpadding="0" cellspacing="0" width="380">
    <tr align="right">
    <td align="right">

        <asp:Image ID="Image4" runat="server" ImageUrl="~/图片/花图片.jpg" Height="182px" 
            Width="200px" />

    </td>
    </tr>
    </table>
    </td>
    <td>
    <table id="6" border="0" cellpadding="0" cellspacing="0" align="center">
    <tr align="center">
    <td align="left" style="font-size: small">
        主题&nbsp;&nbsp;&nbsp; ：
        <asp:TextBox ID="zhuti" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="zhuti"  BackColor="Red" ErrorMessage="必须填写主题" />
        <br />
        正文：<br />
         <asp:TextBox ID="zhengwen" runat="server" TextMode="MultiLine" 
            Height="171px" Width="321px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="zhengwen"  BackColor="Red" ErrorMessage="必须填写正文内容" />
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="发送邮件" onclick="btnLogin_Click" />
        </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="4" border="0" cellpadding="0" cellspacing="0">

        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/图片/底部.jpg" />
            </td>
        </tr>

    </table>
    </td>
    </tr>
    </table>
    </form>
</body>
</html>