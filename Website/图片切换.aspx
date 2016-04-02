<%@ Page Language="C#" AutoEventWireup="true" CodeFile="图片切换.aspx.cs" Inherits="图片切换" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>带左右箭头切换</title>
<style type="text/css">
*{margin:0px; padding:0px;}
img{border:0;}
a{text-decoration:none;}
a:hover{text-decoration:underline;}
li{list-style:none; list-style-image:none; list-style-type:none;}
.rollBox{width:938px;overflow:hidden;padding:0;margin:0 auto; background-color:#006666;
        height: 59px;
    }
.rollBox .LeftBotton{height:59px;width:19px;background:url(http://www.huizhou.cn/webfile/2012/8/21/images/left.jpg) no-repeat;overflow:hidden;float:left;display:inline;margin:15px 0 0 0;cursor:pointer;}
.rollBox .RightBotton{height:59px;width:19px;background:url(http://www.huizhou.cn/webfile/2012/8/21/images/right.jpg) no-repeat right 0;overflow:hidden;float:left;display:inline;margin:15px 0 0 0;cursor:pointer;}
.rollBox .Cont{width:900px;overflow:hidden;float:left;}
.rollBox .ScrCont{width:1274px;
        height: 70px;
    }
.rollBox .Cont .pic{width:172px;float:left;text-align:center; margin-right:10px;}
.rollBox .Cont .pic img{display:block; margin-bottom:7px;
        height: 51px;
        width: 182px;
    }
.rollBox .Cont .pic p,.rollBox .Cont .pic p a{font:normal 12px/20px "宋体";color:#777;}
.rollBox #List1,.rollBox #List2{float:left;}
.rollBox .Cont .pic p span,.rollBox .Cont .pic p span a{color:#E30074;}
</style>
</head>

<body>

<script language="javascript" type="text/javascript">

<!--    //--><![CDATA[//><!--

    //图片滚动列表 5icool.org

    var Speed = 0; //速度(毫秒)

    var Space = 5; //每次移动(px)

    var PageWidth = 182; //翻页宽度

    var fill = 0; //整体移位

    var MoveLock = false;

    var MoveTimeObj;

    var Comp = 0;

    var AutoPlayObj = null;

    GetObj("List2").innerHTML = GetObj("List1").innerHTML;

    GetObj('ISL_Cont').scrollLeft = fill;

    GetObj("ISL_Cont").onmouseover = function () { clearInterval(AutoPlayObj); }

    GetObj("ISL_Cont").onmouseout = function () { AutoPlay(); }

    AutoPlay();

    function GetObj(objName) { if (document.getElementById) { return eval('document.getElementById("' + objName + '")') } else { return eval('document.all.' + objName) } }

    function AutoPlay() { //自动滚动

        clearInterval(AutoPlayObj);

        AutoPlayObj = setInterval('ISL_GoDown();ISL_StopDown();', 10000000000); //间隔时间

    }

    function ISL_GoUp() { //上翻开始

        if (MoveLock) return;

        clearInterval(AutoPlayObj);

        MoveLock = true;

        MoveTimeObj = setInterval('ISL_ScrUp();', Speed);

    }

    function ISL_StopUp() { //上翻停止

        clearInterval(MoveTimeObj);

        if (GetObj('ISL_Cont').scrollLeft % PageWidth - fill != 0) {

            Comp = fill - (GetObj('ISL_Cont').scrollLeft % PageWidth);

            CompScr();

        } else {

            MoveLock = false;

        }

        AutoPlay();

    }

    function ISL_ScrUp() { //上翻动作

        if (GetObj('ISL_Cont').scrollLeft <= 0) { GetObj('ISL_Cont').scrollLeft = GetObj('ISL_Cont').scrollLeft + GetObj('List1').offsetWidth }

        GetObj('ISL_Cont').scrollLeft -= Space;

    }

    function ISL_GoDown() { //下翻

        clearInterval(MoveTimeObj);

        if (MoveLock) return;

        clearInterval(AutoPlayObj);

        MoveLock = true;

        ISL_ScrDown();

        MoveTimeObj = setInterval('ISL_ScrDown()', Speed);

    }

    function ISL_StopDown() { //下翻停止

        clearInterval(MoveTimeObj);

        if (GetObj('ISL_Cont').scrollLeft % PageWidth - fill != 0) {

            Comp = PageWidth - GetObj('ISL_Cont').scrollLeft % PageWidth + fill;

            CompScr();

        } else {

            MoveLock = false;

        }

        AutoPlay();

    }

    function ISL_ScrDown() { //下翻动作

        if (GetObj('ISL_Cont').scrollLeft >= GetObj('List1').scrollWidth) { GetObj('ISL_Cont').scrollLeft = GetObj('ISL_Cont').scrollLeft - GetObj('List1').scrollWidth; }

        GetObj('ISL_Cont').scrollLeft += Space;

    }

    function CompScr() {

        var num;

        if (Comp == 0) { MoveLock = false; return; }

        if (Comp < 0) { //上翻

            if (Comp < -Space) {

                Comp += Space;

                num = Space;

            } else {

                num = -Comp;

                Comp = 0;

            }

            GetObj('ISL_Cont').scrollLeft -= num;

            setTimeout('CompScr()', Speed);

        } else { //下翻

            if (Comp > Space) {

                Comp -= Space;

                num = Space;

            } else {

                num = Comp;

                Comp = 0;

            }

            GetObj('ISL_Cont').scrollLeft += num;

            setTimeout('CompScr()', Speed);

        }

    }

    //--><!]]>

</script>

<div class="rollBox">

     <div class="LeftBotton" onmousedown="ISL_GoUp()" onmouseup="ISL_StopUp()" onmouseout="ISL_StopUp()"></div>

     <div class="Cont" id="ISL_Cont">

      <div class="ScrCont">

       <div id="List1">

        <!-- 图片列表 begin -->
                 
        <div class="pic">
		    <a href="服务项目.aspx?id=villa" target="_blank">
            <img src="图片/度假别墅.jpg"width="182"/></a>
		</div> 
		   
        <div class="pic">
		    <a href="服务项目.aspx?id=room" target="_blank">
            <img src="图片/客房.jpg"width="182"/></a>
		</div> 
		   
        <div class="pic">
		    <a href="服务项目.aspx?id=meetingroom" target="_blank">
            <img src="图片/商务中心.jpg" width="182"/></a>
		</div> 
		   
        <div class="pic">
		    <a href="服务项目.aspx?id=room" target="_blank">
            <img src="图片/娱乐休闲.jpg"width="182"/></a>
		</div> 
		   
        <div class="pic">
		    <a href="服务项目.aspx?id=meetingroom" target="_blank">
            <img src="图片/会议中心.jpg"width="182"/></a>
		</div> 
		   
        <div class="pic">
		    <a href="关于我们.aspx" target="_blank">
            <img src="图片/实景漫游.jpg"width="182"/></a>
		</div> 
		   
        <div class="pic">
		    <a href="服务项目.aspx?id=diningroom" target="_blank">
            <img src="图片/餐厅.jpg" width="182"/></a>
		</div> 
		   		   
      
        <!-- 图片列表 end -->

       </div>

       <div id="List2"></div>

      </div>

     </div>

     <div class="RightBotton" onmousedown="ISL_GoDown()" onmouseup="ISL_StopDown()" onmouseout="ISL_StopDown()"></div>

    </div>

   </body>

</html>