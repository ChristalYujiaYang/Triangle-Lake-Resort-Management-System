<%@ Page Language="C#" AutoEventWireup="true" CodeFile="订单查询.aspx.cs" Inherits="订单查询" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>三角湖度假村</title>
    <style type="text/css">
        .style4
        {
            width: 315px;
        }
        .style7
        {
            width: 240px;
        }
        .style8
        {
            width: 306px;
        }
        .style9
        {
            width: 255px;
        }
        .style10
        {
            width: 89px;
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

        <asp:Image ID="Image2" runat="server" ImageUrl="~/图片/服务项目.jpg" />

    </td>
    </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table id="3" border="0" cellpadding="0" cellspacing="0">
    <tr>
    <td class="style7">
        <asp:Image ID="Image5" runat="server" ImageUrl="~/图片/服务项目左.jpg" />
    </td>
    <td>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/图片/服务项目右.jpg"/>
    </td>
    </tr>
    <tr>
    <td class="style7">
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
    <td>
    <table id="7" style="width: 729px">
    <tr>
    <td>
    <table id="8" border="0" cellpadding="0" cellspacing="0" 
            style="margin: 0px; padding: 0px; width: 715px;">
    <tr>
    <td align="center" class="style8" 
            
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #FFFFFF; background-color: #008080">
        项目名称
    </td>
    <td align="center" class="style9" 
            
            
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; color: #FFFFFF; font-weight: bold; background-color: #008080;">
        时间</td>
    <td align="center" class="style4" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; color: #FFFFFF; background-color: #008080;">
    价格
    </td>
    </tr>
    </table>   
    </td>
    </tr>
    <tr>
    <td>
    <table id="9" border="0" cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px">
    <tr>
    <td class="style14">
        <asp:DataList ID="DataList1" runat="server" GridLines="Horizontal" 
            HorizontalAlign="Center" Width="710px">
            <ItemTemplate>
                         <td>
                          <table>
                          <tr>
                          <td width="2000" align="center">
                          <%# DataBinder.Eval(Container.DataItem, "projectnumber")%>
                          </td>
                          <td width="2000" align="center">
                           <%# DataBinder.Eval(Container.DataItem, "days")%>
                          </td>
                          <td width="2000" align="center">
                          <%# DataBinder.Eval(Container.DataItem, "price")%>
                          </td>
                          </tr>
                          </table> 
                        </td>    
              </ItemTemplate>
        </asp:DataList>
        </td>
        </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td>
    <table style="width: 709px">
    <tr>
    <td class="style10"></td>
    <td></td>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; font-weight: bold; color: #000000" 
            class="style4">
    总价：
    </td>
    <td>
    &nbsp;<asp:TextBox ID="TextBox3" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td align="right" 
            style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: medium; color: #000000; font-weight: bold" 
            class="style10">
    联系人：
    </td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server" BorderWidth="0px" ReadOnly="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td class="style10"></td>
    <td></td>
    <td align="right" class="style4">

        &nbsp;</td>
    <td align="right">

        <asp:Button ID="Button2" runat="server" BackColor="Teal" ForeColor="White" 
            Text="继续预订" onclick="Button2_Click" />

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
