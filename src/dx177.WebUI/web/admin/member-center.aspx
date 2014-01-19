<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="member-center.aspx.cs" Inherits="dx177.WebUI.web.admin.member_center" %>
<%@ Register src="UCLeftMenu.ascx" tagname="UCLeftMenu" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
    <script type="text/javascript" src="/web/admin/js/head.js"></script>
    <script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
    <form id="form1" runat="server">

 
    <div id="MainWrap_Car" style="background: #fff;">
        <div class="MemberCenter">
            <div class="siteparttitle">
                <div class="title">
                </div>
                <div class="main">
                    <div class="content_c1">
                        <div class="user">
                            欢迎您：<br />
                            <strong><%=dx177.Model.AppContext.CurrentResuser.Username %></strong></div>
                        <div class="info">
                            您目前是<strong>[普通会员]，</strong>您的积分为:<strong class="point">0</strong></div>
                    </div>
                </div>
            </div>
            <div class="MemberSidebar">
                <div class="MemberMenu">
                    <div class="title">
                    </div>
                    <div class="body">                         
                         <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID = "menu_12" runat="server" />
                    </div>
                    <div class="foot"></div>
                </div>
            </div>
            <div class="MemberMain">
                <div >
                    <h2>
                        您好，刘建新先生，欢迎进入用户中心</h2>
                    <hr />
                    <div class="note clearfix" id="infotip">
                        <div class="span-1 pic">
                        </div>
                        <div class="span-10">
                            <h4>
                                温馨提示：</h4>
                            您有<strong class="fontcolorRed">1</strong>笔订单需要付款，现在去<a href="http://www.zhenfashion.com.cn/?member-orders.html">查阅</a></div>
                        <span class="option" id="closeinfotip" onclick="$('#infotip').hide();">[关闭提示]</span></div>
                    <div class="FormWrap">
                        <h3>
                            用户信息</h3>
                        <div class="division clearfix">
                            <ul class="list ">
                                <li>
                                    <div class="span-4">
                                        您的账户目前总积分：</div>
                                    <strong class="font16px fontcolorOrange">0</strong>分&nbsp;&nbsp;&nbsp;&nbsp;<a class="lnk"
                                        href="http://www.zhenfashion.com.cn/?member-pointHistory.html">查看积分历史</a></li><li>
                                            <div class="span-4">
                                                预存款余额：</div>
                                            <strong class="font16px fontcolorOrange">￥0.00</strong>元</li><li>
                                                <div class="span-4">
                                                    您的订单交易总数量：</div>
                                                <strong class="font16px fontcolorOrange">1</strong>个&nbsp;&nbsp;&nbsp;&nbsp;<a class="lnk"
                                                    href="http://www.zhenfashion.com.cn/?member-orders.html">进入订单列表</a></li></ul>
                        </div>
                        <h3>
                            促销活动</h3>
                        <div class="division">
                            <ul class="list">
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>

    </form>

</asp:Content>
