<%@ Page Language="C#" AutoEventWireup="true" CodeFile="服务项目.aspx.cs" Inherits="服务项目" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>三角湖度假村</title>
    <style type="text/css">
        .style3
        {
            width: 282px;
        }
        .style4
        {
            width: 316px;
        }
        .style7
        {
            width: 306px;
        }
        .style8
        {
            width: 289px;
        }
        .style14
        {
            width: 169px;
        }
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
    <table id="1" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">
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
    <table id="2" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">
    <tr>
    <td>

        <img src="图片/导航条.jpg" width="1349" height="33" border="0" usemap="#Map" alt=""/>
<map name="Map" id="Map1"><area shape="rect" coords="207,1,287,32" href="首页.aspx" alt="" />
<area shape="rect" coords="326,2,413,39" href="关于我们.aspx" alt="" /><area shape="rect" coords="437,0,525,38" href="企业文化.aspx"alt="" />
<area shape="rect" coords="558,3,632,30" href="新闻中心.aspx" alt=""/><area shape="rect" coords="685,1,758,34" href="服务项目.aspx?id=room" alt=""/>
<area shape="rect" coords="815,3,900,32" href="联系我们.aspx" alt=""/><area shape="rect" coords="944,1,1026,31" href="查看个人信息.aspx"alt="" />
<area shape="rect" coords="1063,3,1131,32" href="订单查询.aspx" alt=""/></map>

    </td>
    </tr>
    <tr>
    <td>

        <asp:Image ID="Image2" runat="server" ImageUrl="~/图片/服务项目.jpg" align="absmiddle" />

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="3" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">
    <tr>
    <td>
        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/服务项目左.jpg"  align="absmiddle"/>
    </td>
    <td>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/图片/服务项目右.jpg" Width="898px" align="absmiddle" />
    </td>
    </tr>
    <tr>
    <td>
    <table id="5" border="0" cellpadding="0" cellspacing="0" width="380" style="margin: 0px; padding: 0px">
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
    <table id="6" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">
    <tr>
    <td>
    <table id="7" border="0" cellpadding="0" cellspacing="0" 
            style="margin: 0px; padding: 0px; width: 715px;">
    <tr>
    <td align="center" class="style8" 
            
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #FFFFFF; background-color: #008080">
    图片
    </td>
    <td align="center" class="style7" 
            
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; color: #FFFFFF; font-weight: bold; background-color: #008080;">
    说明
    </td>
    <td align="center" class="style4" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #FFFFFF; background-color: #008080;">
    价格
    </td>
    <td align="center" class="style3" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-weight: bolder; font-size: large; color: #FFFFFF; background-color: #008080;">
    预订
    </td>
    </tr>
    </table>   
    </td>
    </tr>
    <tr>
    <td>
    <table id="Table8" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">
    <tr>
    <td class="style14">
        <asp:DataList ID="DataList1" runat="server" GridLines="Horizontal" 
            HorizontalAlign="Center" Width="715px">
            <ItemTemplate>
                         <td>
                          <table>
                          <tr>
                          <td width="2000" align="left">
                          <img src="<%# DataBinder.Eval(Container.DataItem, "photo")%>"  height="100px" width="150px"/>
                          </td>
                          <td width="2000" align="center">
                           <%# DataBinder.Eval(Container.DataItem, "introduction")%>
                          </td>
                          <td width="2000" align="center">
                          <%# DataBinder.Eval(Container.DataItem, "price")%>
                          </td>
                          <td width="2000" align="center">
                          <a href="预订.aspx?id=<%# DataBinder.Eval(Container.DataItem, "type")%>&pre=<%# DataBinder.Eval(Container.DataItem, "price")%>&duct=<%# DataBinder.Eval(Container.DataItem, "introduction")%>">预订</a>
                           
                          </td>
                          </tr>
                          </table> 
                        </td>    
              </ItemTemplate>
        </asp:DataList>
        <div id="PageInfo" runat="server" class="anpager"></div>
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
    <td>
    <table id="4" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">

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
