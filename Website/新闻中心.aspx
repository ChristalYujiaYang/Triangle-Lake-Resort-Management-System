<%@ Page Language="C#" AutoEventWireup="true" CodeFile="新闻中心.aspx.cs" Inherits="新闻中心" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>三角湖度假村</title>
    <style type="text/css">
        .paginator { font: 11px Arial, Helvetica, sans-serif;padding:10px 20px 10px 0; margin: 0px;}
        .paginator a {padding: 1px 6px; border: solid 1px #ddd; background: #fff; text-decoration: none;margin-right:2px}
        .paginator a:visited {padding: 1px 6px; border: solid 1px #ddd; background: #fff; text-decoration: none;}
        .paginator .cpb {padding: 1px 6px;font-weight: bold; font-size: 13px;border:none}
        .paginator a:hover {color: #fff; background: #ffa501;border-color:#ffa501;text-decoration: none;}
        
        .anpager { font: 11px Arial, Helvetica, sans-serif;margin:5px 4px 0 0;padding:4px 5px 0;}
        .anpager .cpb {background:#1F3A87;border:1px solid #CCCCCC;color:#FFFFFF;font-weight:bold;margin:0;padding:4px 5px 1px;}
        .anpager a {background:#FFFFFF;border:1px solid #CCCCCC;color:#1F3A87;margin: 0;padding:4px 5px 1px;text-decoration:none}
        .anpager a:hover{background:#1F3A87;border:1px solid #1F3A87;color:#FFFFFF;}
        
        .pages {  color: #999; }
        .pages a, .pages .cpb { text-decoration:none;float: left; padding: 0 5px; border: 1px solid #ddd;background: #ffff;margin:0 2px; font-size:11px; color:#000;}
        .pages a:hover { background-color: #E61636; color:#fff;border:1px solid #E61636; text-decoration:none;}
        .pages .cpb { font-weight: bold; color: #fff; background: #E61636; border:1px solid #E61636;}
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
<area shape="rect" coords="558,3,632,30" href="新闻中心.aspx" alt=""/><area shape="rect" coords="685,1,758,34" href="服务项目.aspx" alt=""/>
<area shape="rect" coords="815,3,900,32" href="联系我们.aspx" alt=""/><area shape="rect" coords="944,1,1026,31" href="查看个人信息.aspx"alt="" />
<area shape="rect" coords="1063,3,1131,32" href="订单查询.aspx" alt=""/></map>

    </td>
    </tr>
    <tr>
    <td>

        <asp:Image ID="Image2" runat="server" ImageUrl="~/图片/新闻中心.jpg" />

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="3" cellpadding="0" border="0" cellspacing="0">
    <tr>
    <td>
        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/新闻中心左.jpg" />
    </td>
    <td>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/图片/新闻中心右.jpg" Width="903px"/>
    </td>
    </tr>
    <tr>
    <td>
    <table id="5" border="0" cellpadding="0" cellspacing="0" width="380">
     <tr align="right">
    <td align="right">

        <table height="120" style="width: 122px">
	<tr>
		<td height="30">
		<li onmouseover="show('nav_1');" onmouseout="hide('nav_1')" ><a href="新闻中心.aspx">新闻中心</a>
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
        <asp:DataList ID="DataList1" runat="server" Width="846px">
<ItemTemplate>
<td>
                          <table>
                          <tr>
                          <td width="2000" align="left">
<a href="新闻.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id")%>"><%#DataBinder.Eval(Container.DataItem,"news")%></a>
    </td>
                          <td width="2000" align="right">
<asp:Label ID="lbTime" runat="server" Text='<%#Eval("date")%>'></asp:Label>
</td>
                          </tr>
                          </table> 
                        </td>
</ItemTemplate>
</asp:DataList>
    <br />
    <div id="PageInfo" runat="server" class="anpager"></div>
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