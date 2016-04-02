<%@ Page Language="C#" AutoEventWireup="true" CodeFile="首页.aspx.cs" Inherits="首页" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>三角湖度假村首页</title>
    <style type="text/css">
        html,body,form
        {
            width:100%;
            margin:0px;
            padding:0px;
        }
        .style3
        {
            width: 1336px;
            height: 183px;
        }
        .style4
        {
            width: 1336px;
        }
        .style5
        {
            width: 1340px;
            height: 210px;
            background-image: url('http://localhost:54874/三角湖/图片/渐变背景.jpg');
        }
        .style6
        {
            width: 143px;
        }
        .style7
        {
            width: 1340px;
        }
        
        
        ul
        {
            margin: 0;
            padding: 0;
        }
        li
        {
            list-style-position: outside;
            list-style: none;
        }
        a
        {
            text-decoration: none;
            color: #666;
        }
        
        ul#dropmenu, ul#dropmenu ul
        {
            margin: 0 auto;
            text-align: left;
            padding: 0;
            list-style: none;
            z-index: 99;
        }
        ul#dropmenu
        {
            width: 770px;
            display: block;
            height: 24px;
            clear: both;
            border: 0;
            text-align: center;
            background: #5EA294;
        }
        ul#dropmenu li
        {
            position: relative;
            z-index: 999;
            float: left;
            top: 0px;
            left: 0px;
            width: 110px;
        }
        ul#dropmenu ul
        {
            /*width: 122px;
w\idth: 120px;*/
            height: 28px;
            width: 500px;
            position: relative;
            text-align: left;
            left: 0px;
            display: none;
            border: 0;
        }
        ul#dropmenu ul li
        {
            display: block;
            float: left;
            position: fixed;
            height: 24px;
            width: 20%;
        }
        /*当鼠标在子菜单和父菜单上时，父菜单的样式*/
        ul#dropmenu li.over a, ul#dropmenu li:hover a
        {
            border-color: #ccc;
            background: #3CC457;
            color: #fff;
        }
        /*将子菜单的样式清除*/
        ul#dropmenu li.over ul a, ul#dropmenu li:hover ul a
        {
            font-weight: normal;
            color: #666;
            background: #3CC457;
        }
        /*子菜单的hover样式*/
        ul#dropmenu li.over ul a:hover, ul#dropmenu li:hover ul a:hover
        {
            font-weight: normal;
            color: #cc0000;
            font-weight: bold;
            background: #3CC457;
        }
        /* Styles for Menu Items */
        ul#dropmenu a
        {
            display: block;
            padding: 0 0 0 10px;
            width: 110px;
            width: 96px;
            color: #666;
            line-height: 24px;
        }
        ul#dropmenu ul li
        {
            border: 0;
            float: left;
            position: relative;
            height: 24px;
            width: 20%;
        }
        /* End */
        ul#dropmenu ul a
        {
            filter: progid:DXImageTransform.Microsoft.Alpha(opacity=70); /* 透明 */
            padding: 2px 0px 2px 10px;
            border: 0;
            width: 110px; /* Sub Menu Styles */
        }
        ul#dropmenu li:hover ul, ul#dropmenu li.over ul
        {
            display: block; /* The magic */
        }
        .style8
        {
            width: 1336px;
            height: 60px;
        }
    </style>
    <script type="text/javascript">
        /**
        *菜单的构造,需要绑定到onload
        */
        startList = function () {
            if (document.all && document.getElementById) {
                dropmenuRoot = document.getElementById("dropmenu");
                for (i = 0; i < dropmenuRoot.childNodes.length; i++) {
                    node = dropmenuRoot.childNodes[i];
                    if (node.nodeName == "LI") {
                        node.onmouseover = function () {
                            this.className += " over";
                            //开始灌水
                            for (j = 0; j < this.childNodes.length; j++) {
                                if (this.childNodes[j].nodeName == "UL") {
                                    if (this.childNodes[j].childNodes[0].nodeName == "LI") {
                                        if (this.offsetLeft + this.childNodes[j].childNodes.length * this.childNodes[j].childNodes[0].offsetWidth - dropmenuRoot.offsetLeft > dropmenuRoot.offsetWidth) {
                                            var len = this.childNodes[j].childNodes.length * this.childNodes[j].childNodes[0].offsetWidth; //菜单的长度
                                            (len > dropmenuRoot.offsetWidth) ? this.childNodes[j].style.width = 776 + "px" : this.childNodes[j].style.width = len + "px"; //给ul设置宽度 如果子菜单比较多，大于容器的宽度，那么ul的宽度就是容器的宽度
                                            len = this.offsetLeft + len - dropmenuRoot.offsetLeft - dropmenuRoot.offsetWidth;
                                            (len > this.offsetLeft - dropmenuRoot.offsetLeft) ? this.childNodes[j].style.marginLeft = -(this.offsetLeft - dropmenuRoot.offsetLeft) : this.childNodes[j].style.marginLeft = -len + "px";
                                        }
                                    }
                                }
                            }
                        }
                        //灌水完毕
                        node.onmouseout = function () {
                            this.className = this.className.replace(" over", "");
                        }
                    }
                }
            }
        }
        window.onload = startList;
    </script>
</head>
<body style="width:100%;margin:0px;padding:0px">
    <form id="form1" runat="server">
    <div style="width:100%">
        <table border="0" cellpadding="0" cellspacing="0" style="margin:0px auto">
            <tr>
                <td class="style7">
                    <table id="1" style="margin-right: 0px; background-image: url('图片/2.jpg');">
                        <tr>
                            <td class="style4">
                                <table id="2">
                                    <tr>
                                        <td>
                                            <asp:Image ID="Image3" runat="server" ImageUrl="~/图片/三角湖度假村logo.gif" />
                                        </td>
                                        <td width="600px">
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="#DDECEF"
                                                BorderWidth="2px" Height="21px"></asp:TextBox>
                                            <asp:Button ID="Button1" runat="server" Text="搜索" BackColor="#AACDC9" ForeColor="Black"
                                                OnClick="Button1_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="style8">
                                <div id="nav">
                                    <ul id="dropmenu">
                                        <li><a href="关于我们.aspx" target="_blank">关于我们</a>
                                            <ul>
                                                <li><a href="关于我们.aspx" target="_blank">三角湖度假村</a></li>
                                                <li><a href="关于我们.aspx" target="_blank">荣誉资质</a></li>
                                                <li><a href="关于我们.aspx" target="_blank">发展历程</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="新闻中心.aspx" target="_blank">新闻中心</a>
                                            <ul>
                                                <li><a href="新闻中心.aspx" target="_blank">公司新闻</a></li>
                                                <li><a href="新闻中心.aspx" target="_blank">行业动态</a></li>
                                                <li><a href="新闻中心.aspx" target="_blank">营销活动</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="企业文化.aspx" target="_blank">企业文化</a>
                                            <ul>
                                                <li><a href="企业文化.aspx" target="_blank">企业文化</a></li>
                                                <li><a href="企业文化.aspx" target="_blank">管理理念</a></li>
                                                <li><a href="企业文化.aspx" target="_blank">员工活动</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="服务项目.aspx?id=room" target="_blank">服务项目</a>
                                            <ul>
                                                <li><a href="服务项目.aspx?id=room" target="_blank">三角湖度假村</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="查看个人信息.aspx" target="_blank">个人信息</a>
                                            <ul>
                                                <li><a href="查看个人信息.aspx" target="_blank">个人信息查询</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="联系我们.aspx" target="_blank">联系我们</a>
                                            <ul>
                                                <li><a href="联系我们.aspx" target="_blank">联系我们</a></li>
                                                <li><a href="联系我们.aspx" target="_blank">地理位置</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="订单查询.aspx" target="_blank">订单</a>
                                            <ul>
                                                <li><a href="订单查询.aspx" target="_blank">订单查询</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <iframe frameborder="0" src="图片切换.aspx" style="height: 60px; width: 71%; margin-left: 306px;">
                                </iframe>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <table style="background-image: url('图片/渐变背景.jpg');">
                        <tr>
                            <td width="120px">
                            </td>
                            <td width="360px">
                                <iframe frameborder="0" src="zuodaohang.aspx" style="width: 340px; height: 173px">
                                </iframe>
                            </td>
                            <td width="360px">
                                <iframe frameborder="0" src="tupiangundong.aspx" style="width: 340px; height: 175px">
                                </iframe>
                            </td>
                            <td align="center" width="360px">
                                <iframe frameborder="0" src="youdaohang.aspx" style="width: 334px; height: 190px">
                                </iframe>
                            </td>
                            <td class="style6">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <table>
                        <tr>
                            <td>
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/图片/底部.jpg" Width="1347px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
