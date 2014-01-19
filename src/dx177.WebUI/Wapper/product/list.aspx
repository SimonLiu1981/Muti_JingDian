<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs"
    Inherits="dx177.WebUI.Wapper.product.list" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="nav_son">
        <span><a href="/web/hotelorder/orderlist.aspx" class="cxdd">查询我的订单状态</a></span>当前位置：<a
            href="index.html">首页</a> &gt;&nbsp;<a href="product_listall_1.html">产品列表</a>
    </div>
    <div id="main">
        <div class="info_box">
            <h2>
                产品列表</h2>
            <div class="info_pic">
                <ul>
                    <li><a href="product_1.html" target="_blank" title="丹霞山农家土鸡/乡下家鸡">
                        <img border="0" src="/uploadfile/img/single/20110723/033337826.jpg" alt="丹霞山农家土鸡/乡下家鸡"
                            width="160" height="120" />丹霞山农家土鸡/乡下家鸡</a></li>
                    <li><a href="product_3.html" target="_blank" title="山坑鱼干">
                        <img border="0" src="/uploadfile/img/single/20110723/043338514.jpg" alt="山坑鱼干" width="160"
                            height="120" />山坑鱼干</a></li>
                    <li><a href="product_5.html" target="_blank" title="笋干">
                        <img border="0" src="/uploadfile/img/single/20110723/041320154.jpg" alt="笋干" width="160"
                            height="120" />笋干</a></li>
                </ul>
            </div>
            <div id="pages">
                <a href="product_list3_1.html" title="第一页"><<</a> <strong>1</strong> <a href="product_list3_1.html"
                    title="尾页">>></a></div>
        </div>
    </div>
    <div id="side">
        <div class="sidebox">
            <h4>
                旅游特产</h4>
            <div class="sbox_con">
                <ul>
                    <li><a href='product_list3_1.html' title='农家特产'>农家特产</a></li>
                    <li><a href='product_list4_1.html' title='山珍'>山珍</a></li>
                    <li><a href='product_list5_1.html' title='农家果'>农家果</a></li>
                </ul>
            </div>
        </div>
        <div class="sidebox">
            <h4>
                推荐酒店</h4>
            <div class="sbox_con">
                <ul>
                    <li title='丹霞山温泉假日酒店'><span>158元</span> <a href='hotel_11.html'>丹霞山温泉假日酒店</a> </li>
                    <li title='丹霞山庄'><span>188元</span> <a href='hotel_4.html'>丹霞山庄</a> </li>
                    <li title='红豆兰庭'><span>100元</span> <a href='hotel_28.html'>红豆兰庭</a> </li>
                    <li title='丹霞印象客栈'><span>108元</span> <a href='hotel_2.html'>丹霞印象客栈</a> </li>
                    <li title='回驿客栈'><span>98元</span> <a href='hotel_29.html'>回驿客栈</a> </li>
                </ul>
            </div>
        </div>
    </div>
    <div class="clearfloat">
    </div>
</asp:Content>
