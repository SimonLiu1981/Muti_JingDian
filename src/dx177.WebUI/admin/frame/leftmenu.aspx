<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leftmenu.aspx.cs" Inherits="dx177.WebUI.Admin.Frame.leftmenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1">
    <title>一起去丹霞 网站后台管理</title>
    <meta name="keywords" content="免费外贸网站,免费购物网站,免费开网店,免费试用,免费商城,免费外贸商城,购物网建设,外贸网建设,公司网站建设,公司内容网站建设,开网店,免费网店,免费开网店,网店实名制,如何开网店,怎样开网店,网店系统,网站建设" />
    <meta name="description" content="免费外贸网站,免费购物网站,免费开网店,免费试用,免费商城,免费外贸商城,购物网建设,外贸网建设,公司网站建设,公司内容网站建设,开网店,免费网店,免费开网店,网店实名制,如何开网店,怎样开网店,网店系统,网站建设" />

    <script type="text/javascript" language="JavaScript"> 
<!--
        var noHelp = "<p align='center' style='color: #666'>暂时还没有该部分内容</p>";
        var helpLang = "en_us";
//-->
</script>

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <style type="text/css">
        /*
$Id: general.css 6098 2009-09-09 06:52:23Z xiaoxinxin $
*/
        body
        {
            margin: 0px;
            padding: 0px;
            color: #192E32;
            font: 12px "sans-serif" , "Arial" , "Verdana";
        }
        p, td, div
        {
            font: 12px "sans-serif" , "Arial" , "Verdana";
        }
        body
        {
             
        }
        
         
        
        #main-div
        {
            border: 0px solid #345C65;
            padding: 5px;
            margin: 2px;
            background: #FFF;
            height:100%;
        }
        #menu-list
        {
            padding: 0;
            margin: 0;
        }
        #menu-list ul
        {
            padding: 0;
            margin: 0;
            list-style-type: none;
            color: #335B64;
        }
        #menu-list li
        {
            padding-left: 16px;
            line-height: 16px;
            cursor: hand;
            cursor: pointer;
        }
        #main-div a:visited, #menu-list a:link, #menu-list a:hover
        {
            color: #335B64 text-decoration: none;
        }
        #menu-list a:active
        {
            color: #EB8A3D;
        }
        .explode
        {
            background: url(img/menu_minus.gif) no-repeat 0px 3px;
            font-weight: bold;
        }
        .collapse
        {
            background: url(img/menu_plus.gif) no-repeat 0px 3px;             
            font-weight: bold;
        }
        
        
        .menu-item
        {
            background: url(img/menu_arrow.gif) no-repeat 0px 3px;
            font-weight: normal;
        }
        .menu-item a.cur
        {
            color:#f90;    
            font-weight:bold;
            text-decoration:none;
        }
        #help-title
        {
            font-size: 14px;
            color: #000080;
            margin: 5px 0;
            padding: 0px;
        }
        #help-content
        {
            margin: 0;
            padding: 0;
        }
        .tips
        {
            color: #CC0000;
        }
        .link
        {
            color: #000099;
        }
        a:visited
        {
            color: #335B64;
            text-decoration: none;
        }
        a:link
        {
            color: #335B64;
            text-decoration: none;
        }
        a:hover
        {
            color: #EB8A3D;
            text-decoration: underline;
        }
        a:active
        {
            color: #EB8A3D;
            text-decoration: underline;
        }
    </style>
</head>
<body >
    <div id="main-div">
        <%-- <img src="img/left-top.gif" alt="" /><a href="../PopNewOrderSms.aspx" target="right"><img
            src="img/desk.gif" border="0" alt="" />桌面</a>--%>
        <div id="menu-list">
            <ul  >
                <asp:Repeater ID="NavMenu_List" runat="server" OnItemDataBound="NavMenu_List_ItemDataBound">
                    <ItemTemplate>
                        <li class='collapse' onclick="toggleCollapseExpand(this)" id="zt_<%# ((System.Data.DataRowView)Container.DataItem)["ID"]%>" style='display:<%#IsDisplayed(((System.Data.DataRowView)Container.DataItem)["Show"]) %>'
                            name='menu'>
                            <%# ((System.Data.DataRowView)Container.DataItem)["Text"]%>
                           
                                <ul  id='zd_<%# ((System.Data.DataRowView)Container.DataItem)["ID"]%>' style='display: none;'>
                                    <asp:Repeater ID="MenuItem_List" runat="server">
                                        <ItemTemplate>
                                            <li class='menu-item' style='display:<%#IsDisplayed(((System.Data.DataRowView)Container.DataItem)["Show"]) %>' ><a href='<%# ((System.Data.DataRowView)Container.DataItem)["NavigateUrl"]%>' target='BoardRight' onclick='setCur(this)'>
                                                <%# ((System.Data.DataRowView)Container.DataItem)["Text"]%></a></li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
       <%-- <img src="img/lastnodeline.gif" alt="" /><a href="../default.aspx" target="_top"><img
            src="img/service.gif" border="0" alt="" />退出系统</a>--%>
    </div>


    <script language="JavaScript" type="text/javascript">
        function setCur(li) {
            $('li.menu-item a').removeClass('cur');
            $(li).addClass('cur');
        }
        function toggleCollapseExpand(obj) {            
            if (obj.id.indexOf("zt_") != -1) {
                var idx = obj.id.replace('zt_', '');
                var subUL = document.getElementById('zd_' + idx);
                if (obj.className == 'collapse') {
                    obj.className = 'explode';
                    subUL.style.display = 'inline';
                }
                else {
                    obj.className = 'collapse';
                    subUL.style.display = 'none';
                }
            }
        }
        function clearLinkEvent() {//为第二组li元素绑定onclick事件 
            var li = document.getElementsByTagName("li");
            for (var i = 0; i < li.length; i++) {
                if (li[i].className == 'menu-item') {
                    li[i].onclick = function(e) {                        
                        stopBubble(e); //运行阻止冒泡的函数
                    }
                }                
            }
        }
        //该函数的功能用来阻止事件冒泡．并兼容多浏览器
        function stopBubble(e) {
            //如果传入了事件对象.那么就是非IE浏览器
            if (e) {
                //因此它支持W3C的stopPropation()方法
                e.stopPropagation();
            }
            else {
                //否则,我们得使用IE的方式来取消事件冒泡
                window.event.cancelBubble = true;
            }
        }

        $(document).ready(function() {
            clearLinkEvent();
            var fistId = -100;
            $("ul").each(function(i) {
                if (this.id.indexOf('zd_') != -100) {
                    if (this.style.display == 'none' && fistId == -100) {
                        fistId = this.id.replace('zd_', '');
                    }
                }
            });
            if (fistId != -1) {
                document.getElementById('zt_' + fistId).click();
                $(parent.document.getElementsByName("BoardRight")).attr('src', $('#zt_' + fistId + ' li a').filter(":first").attr('href'));
                $('li.menu-item a').removeClass('cur');
                $('#zt_' + fistId + ' li a').filter(":first").addClass('cur');
 

            }
        });
        
</script>

</body>
</html>
