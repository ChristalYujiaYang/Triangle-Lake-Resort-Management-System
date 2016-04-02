<%@ Page Language="C#" AutoEventWireup="true" CodeFile="无空闲项目.aspx.cs" Inherits="无空闲项目" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<script type="text/javascript" >
    function change() {
        var img = document.getElementById("vcmg");
        img.src = img.src + '?';
    }
</script>
    <title>三角湖度假村</title>
    <style type="text/css">
        #Text1 {
            height: 19px;
            width: 147px;
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
<area shape="rect" coords="558,3,632,30" href="新闻中心.aspx" alt=""/><area shape="rect" coords="685,1,758,34" href="服务项目.aspx" alt=""/>
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
        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/服务项目左.jpg" />
    </td>
    <td>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/图片/服务项目右.jpg" Width="962px" />
    </td>
    </tr>
    <tr>
    <td>
    <table id="5" border="0" cellpadding="0" cellspacing="0" width="380">
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
    <td>
    <table id="6" border="0" cellpadding="0" cellspacing="0" align="center">
    <tr align="center">
    <td align="center" style="font-size: xx-large; font-weight: bold;">
        &nbsp;对不起，该项目已无空闲</td>
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
