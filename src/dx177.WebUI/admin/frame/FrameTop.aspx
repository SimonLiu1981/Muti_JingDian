<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrameTop.aspx.cs" Inherits="dx177.WebUI.Admin.Frame.FrameTop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>帕讯中文版购物网店系统-后台管理</title>  
    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link rel="stylesheet" rev="stylesheet" href="img/home.css" type="text/css" />
    <script type="text/javascript">
        var switchTag1 = function(tag, url) {
            var numericId = tag.id.replace(/[^0-9]/g, '');
            var tds = document.getElementsByTagName('a');
            for (i = 0; i < tds.length; i++) {
                if (tds[i].id.indexOf('tdT') != -1) {
                    if (tds[i].id == "tdT" + numericId) {

                        tds[i].className = "actived";
                    } else {
                        tds[i].className = "";
                    }
                }
            }
            if (url != null) {

                var rtnValues = new Array();
                var datenow = new Date();
                var sdate = new String();
                var sminute = new String();
                var sMillisecond = new String();
                sminute = datenow.getMinutes();
                sMillisecond = sdate + datenow.getMilliseconds();
                sdate = sminute + sMillisecond;
                window.top.document.getElementById("left").src = url + "&rnd=" + sdate;
                
            }
            return false;
        }
        function setValues(iHeight, iWidth, resizable) {
            var features = "dialogHeight: " + iHeight + "px;";
            features += "dialogWidth: " + iWidth + "px;";
            features += "help: no; status: no; scroll: yes;";
            features += "resizable: " + resizable;

            return features;
        } 
    
    </script>

    <style type="text/css">
        body
        {
            margin: 0px;
            padding: 0px;
            color: #192E32;
            font: 12px "sans-serif" , "Arial" , "Verdana";
        }
        #submenu-div
        {
            height: 50px;
            
        }
        #submenu-div ul
        {
            margin: 0;
            padding: 0;
            list-style-type: none;
        }
        #submenu-div li
        {
            float: right;
            padding: 0 10px;
            margin: 3px 0;             
               display:block;
             width:80px;
             height:31px;
            border-left: 1px solid #FFF;
        }
        #submenu-div a:visited, #submenu-div a:link ,#tabs_r a:visited, #tabs_r-div a:link 
        {             
            text-decoration: none;
        }
        
        #submenu-div a
        {
            padding: 3px;
            background-color:#ef5603;
            color: #ffffff;
            cursor:hand;
        }
        #submenu-div a:hover
        {
            color: #ffffff;
            text-decoration:underline;
            background-color:#ef5603;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server">
    <div id="header">
        <div class="banner">
            <div class="tabbar">
                <div id="submenu-div" style=" margin: 5px;">
                
                     <div style="margin:5px; float: left">
                        当前位置：<%=currentLocation %> 
                    </div>
                    
                    
                    <div style="float: left">
                    <a style="color:Black; font-size:2em;" href="javascript:top.location.href='../JingquManagementNavigation.aspx';"> 选择其它景区 </a>
                    </div>
                   
                </div>
                <div class="tabs">
                    <!--<div class="float_icon">新</div>-->
                    <asp:Repeater ID="NavMenu_List" runat="server">
                        <ItemTemplate>
                            <a href="#" title="<%# ((System.Data.DataRowView)Container.DataItem)["Text"]%>" id="tdT<%# ((System.Data.DataRowView)Container.DataItem)["ID"]%>"
                                class="" style='display:<%#IsDisplayed(((System.Data.DataRowView)Container.DataItem)["Show"]) %>' onclick="return switchTag1(this,'<%# ((System.Data.DataRowView)Container.DataItem)["NavigateUrl"]%>');">
                                <%# ((System.Data.DataRowView)Container.DataItem)["Text"]%>
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="tabs_r">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Small" OnClick="btnLogout_Click">注销系统</asp:LinkButton>
                </div>
                <div class="bg">
                    <asp:Repeater ID="rpBack" runat="server">
                        <ItemTemplate>
                            <div class="<%# ((System.Data.DataRowView)Container.DataItem)["BackGroupClass"]%>" style='display:<%#IsDisplayed(((System.Data.DataRowView)Container.DataItem)["Show"]) %>'>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div class="bar">
        </div>
    </div>

    <script type="text/javascript">

        var initURL = function() {

            var redirectURL = "<%=sCurrentMenuID %>";
            try {

                if (redirectURL != '') {
                    document.getElementById("tdT" + redirectURL).click();
                }
            } catch (e) {
                //alert(e);
            }

        }
        $(document).ready(function() {
            initURL();
        });
    
    </script>

    </form>
</body>
</html>
