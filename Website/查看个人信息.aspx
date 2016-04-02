<%@ Page Language="C#" AutoEventWireup="true" CodeFile="查看个人信息.aspx.cs" Inherits="查看个人信息" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
    <script type="text/javascript">
        function show(id) {
            document.getElementById(id).style.display = 'block';
        }
        function hide(id) {
            document.getElementById(id).style.display = 'none';
        }
</script>
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
    <table id="5" border="0" cellpadding="0" cellspacing="0" width="370">
    <tr align="right">
    <td align="right">

        <table height="120" style="width: 122px">
            <tr>
                <td height="30">
                    <li onmouseout="hide('nav_1')" onmouseover="show('nav_1');"><a href="查看个人信息.aspx">查看个人信息</a>
                    </li>
                </td>
            </tr>
        </table>

    </td>
    </tr>
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
        查看个人信息
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
    &nbsp;</td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    姓名：
    </td>
    <td>
        
        <asp:TextBox ID="TextBox2" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
        
    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    &nbsp;</td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        身份证号：
    </td>
    <td>
        <asp:TextBox ID="TextBox3" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    &nbsp;</td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    联系方式：
    </td>
    <td>
        <asp:TextBox ID="TextBox4" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
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
    &nbsp;</td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
    &nbsp;&nbsp;
    用户名：
    </td>
    <td>
        <asp:TextBox ID="TextBox5" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
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
    &nbsp;</td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        性别：
    </td>
    <td>
        <asp:TextBox ID="TextBox6" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    &nbsp;</td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        VIP等级：
    </td>
    <td>
        <asp:TextBox ID="TextBox7" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td style="font-size: small; color: #FF0000" align="right">
    
    </td>
    <td align="right" style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold">
        折扣额： 
    </td>
    <td>
        <asp:TextBox ID="TextBox8" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td class="style2" align="center">

        <asp:Image ID="Image10" runat="server" ImageUrl="~/图片/确认.jpg" Width="473px" />

    </td>
    </tr>
    <tr>
    <td align="center">    
        <asp:Button ID="Button4" runat="server" Text="确认" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="修改" onclick="Button3_Click" />
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
