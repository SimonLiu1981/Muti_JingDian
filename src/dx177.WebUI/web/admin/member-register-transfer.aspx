<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-register-transfer.aspx.cs" Inherits="dx177.WebUI.web.admin.member_regiditer_transfer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/web/admin/css/registerall.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="blank05">
    </div>
    <div id="MainWrap_Car" style="background: #fff;">
        <div style="width: 620px; margin: 0 auto;">
            <div class="zhuceright bgmgryh">
                <span>预定酒店用户在此注册</span>
                <ul class="zhuce_ul1">
                    <li>轻松进行酒店预定。</li>
                    <li>查到酒店预定状态</li>
                    <li>&nbsp;</li>
                    <li>&nbsp;</li>
                    <li><a href="/register/1/default.aspx">
                        <img src="/web/admin/img/zhuce4.gif" /></a> </li>
                </ul>
            </div>
            <div class="zhuceright bgmqyyh">
                <span>酒店企业、餐饮企业、租车信息发布请在此注册</span>
                <ul class="zhuce_ul1">
                    <li>发布酒店信息、查看预定状态</li>
                    <li>发布餐饮企业信息、</li>
                    <li>发布租车信息，游客在网上获取联系方式</li>                     
                    <li><a href="/register/qy/default.aspx">
                    <img src="/web/admin/img/zhuce4.gif" /></a> </li>
                </ul>
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>
