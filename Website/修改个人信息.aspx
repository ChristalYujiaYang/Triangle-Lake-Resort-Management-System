﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="修改个人信息.aspx.cs" Inherits="修改个人信息aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>三角湖度假村</title>
    <style type="text/css">
        .style1
        {
            width: 1129px;
        }
        .style2
        {
            width: 1129px;
            height: 90px;
        }
    </style>
</head>
<body>
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

        <asp:Image ID="Image2" runat="server" ImageUrl="~/图片/个人信息修改.jpg" />

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
        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/个人信息左.jpg" />
    </td>
    <td>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/图片/个人信息右.jpg" Width="951px" />
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
    <table id="6" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td align="center" class="style1" 
            style="font-size: x-large; font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bold; color: #000000">
        编辑个人信息
    </td>
    </tr>
    <tr>
    <td class="style1" align="center">
            <asp:Image ID="Image7" runat="server" ImageUrl="~/图片/个人信息.jpg" />
    </td>
    </tr>
    <tr>
    <td>
    <table id="7" align="center">
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    *
    </td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    姓名：
    </td>
    <td>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBox2" BackColor="Red" ErrorMessage="必须填写姓名" />

    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    *
    </td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    联系方式：
    </td>
    <td>

        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TextBox4"  BackColor="Red" ErrorMessage="必须填写联系方式" />

    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    
    </td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    所在地：
    </td>
    <td>

        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td class="style1" align="center">

        <asp:Image ID="Image8" runat="server" ImageUrl="~/图片/账户信息.jpg" />

    </td>
    </tr>
    <tr>
    <td>
    <table id="Table1" align="center">
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    *
    </td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    &nbsp;&nbsp;
    用户名：
    </td>
    <td>

        <asp:TextBox ID="TextBox6" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>

    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    *
    </td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    密码：
    </td>
    <td>

        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="TextBox7" BackColor="Red" ErrorMessage="必须填写密码" />

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td class="style1" align="center">

        <asp:Image ID="Image9" runat="server" ImageUrl="~/图片/其他信息.jpg" />

    </td>
    </tr>
    <tr>
    <td>
    <table id="Table2" align="center">
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    *
    </td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        性别：
    </td>
    <td>

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ControlToValidate="DropDownList1" BackColor="Red" ErrorMessage="必须填写性别" />

    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    &nbsp;</td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        教育程度：
    </td>
    <td>

        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>保密</asp:ListItem>
            <asp:ListItem>小学-初中</asp:ListItem>
            <asp:ListItem>高中</asp:ListItem>
            <asp:ListItem>大学</asp:ListItem>
            <asp:ListItem>硕士</asp:ListItem>
            <asp:ListItem>博士</asp:ListItem>
        </asp:DropDownList>

    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    
    </td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        公司： 
    </td>
    <td>

        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td class="style2" align="center">

        <asp:Image ID="Image10" runat="server" ImageUrl="~/图片/提交.jpg" Width="473px" />

    </td>
    </tr>
    <tr>
    <td align="center">

        <asp:Button ID="Button2" runat="server" Text="提交" onclick="Button2_Click" /> &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;      
        <asp:Button ID="Button3" runat="server" Text="取消" />

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
