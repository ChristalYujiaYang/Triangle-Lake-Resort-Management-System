<%@ Page Language="C#" AutoEventWireup="true" CodeFile="预订.aspx.cs" Inherits="预订" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>三角湖度假村</title>
    <style type="text/css">
        .style1
        {
            width: 967px;
        }
        .style2
        {
            width: 1384px;
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
    <td class="style2">
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
    <td class="style2">
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

        <asp:Image ID="Image2" runat="server" ImageUrl="~/图片/预订.jpg" />

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td class="style2">
    <table id="3" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>

        <asp:Image ID="Image10" runat="server" ImageUrl="~/图片/预订-项目服务左.jpg" 
            Width="393px" />

    </td>
    <td class="style1">

        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/预订-项目服务右.jpg" 
            Width="956px" Height="65px" />

    </td>
    </tr>
    <tr>
    <td>
    <table id="5" border="0" cellpadding="0" cellspacing="0" width="340">
     <tr align="right">
    <td align="right">

        <table height="120" style="width: 147px">
	<tr>
		<td height="30">
		<li onmouseover="show('nav_1');" onmouseout="hide('nav_1')" ><a href="服务项目.aspx?id=room">三角湖度假村</a>
        <ul id="nav_1">
         <li><a href="服务项目.aspx?id=diningroom">餐厅</a></li>
            <li><a href="服务项目.aspx?id=room">客房</a></li>
            <li><a href="服务项目.aspx?id=meetingroom">会议中心</a></li>
            <li><a href="服务项目.aspx?id=tabletennis">兵乓球室</a></li>
            <li><a href="服务项目.aspx?id=villa">度假别墅</a></li>
            <li><a href="服务项目.aspx?id=chessroom">棋牌室</a></li>
            <li><a href="餐饮服务.aspx?id=ordermeal">餐饮</a></li>
            
        </ul>
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
    <td class="style1">
    <table id="6" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <table id="7" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td style="font-size: xx-large; font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bold; color: #008080">
        三角湖度假村预订
    </td>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #000000">
         &nbsp;&nbsp;&nbsp;&nbsp;
         填写订单
    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="8" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>
            <asp:Image ID="Image7" runat="server" ImageUrl="~/图片/项目信息.jpg" Width="947px" />
    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bold; color: #000000; font-size: small;">
    项目名称：
     
        <asp:TextBox ID="TextBox5" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    <td>

    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bold; color: #000000; font-size: small;">
    项目数量(天数)：

        <asp:DropDownList ID="DropDownList1" runat="server" 
            ontextchanged="DropDownList1_TextChanged" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>1/24</asp:ListItem>
            <asp:ListItem>2/24</asp:ListItem>
            <asp:ListItem>3/24</asp:ListItem>
            <asp:ListItem>4/24</asp:ListItem>
            <asp:ListItem>5/24</asp:ListItem>
            <asp:ListItem>6/24</asp:ListItem>
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bold; color: #000000; font-size: small;">
        项目单价：
        <asp:Label ID="price"  runat="server" BorderWidth="0px" ></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    <td>

    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bold; color: #000000; font-size: small;">
    <table><tr><td>入住日期：
        <asp:Calendar ID="Calendar1" runat="server" 
            onselectionchanged="Calendar1_SelectionChanged" Width="234px" SelectionMode="Day"></asp:Calendar>
            
    </td>
    <td width="40px"></td>
    <td>离开日期：
        <asp:Calendar ID="Calendar2" runat="server"  Width="255px" SelectionMode="Day" 
            onselectionchanged="Calendar2_SelectionChanged"></asp:Calendar>
    </td>
    <td>
    <asp:Label ID="Label1" runat="server" Text="时间超出可选范围" Visible="False" 
            ForeColor="Red"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="时间超出可选范围" Visible="False" 
            ForeColor="Red"></asp:Label>
    </td>
    </tr></table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="9" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>
        <asp:Image ID="Image9" runat="server" ImageUrl="~/图片/提示信息.jpg" Width="948px" />
    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: small; font-weight: bold; color: #000000">
    最晚使用时间：
     
        <asp:TextBox ID="TextBox7" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: small; font-weight: bold; color: #000000">
        入住人数：&nbsp;

     
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>单人</asp:ListItem>
            <asp:ListItem>多人</asp:ListItem>
        </asp:DropDownList>

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="10" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td>

        <asp:Image ID="Image8" runat="server" ImageUrl="~/图片/联系人信息.jpg" Width="949px" />

    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: small; font-weight: bold; color: #000000">
    联系人&nbsp; ：
     
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBox2"  BackColor="Red" ErrorMessage="必须填写联系人" />
    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: small; font-weight: bold; color: #000000">
    身份证号：
     
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="TextBox3" BackColor="Red" ErrorMessage="必须填写身份证号" />
    </td>
    </tr>
    <tr>
    <td style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: small; font-weight: bold; color: #000000">
    联系电话：
     
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ControlToValidate="TextBox4" BackColor="Red" ErrorMessage="必须填写联系方式" />
    </td>
    </tr>
    <tr>
    <td align="center">

        <asp:Button ID="Button2" runat="server" BackColor="#AACDC9" Text="提交" 
            Height="33px" Width="77px" onclick="Button2_Click" />

    </td>
    </tr>
    </table> 
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td class="style2">
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
