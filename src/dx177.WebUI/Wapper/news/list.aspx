<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" MasterPageFile="~/Home.Master"
    Inherits="dx177.WebUI.Wapper.news.list" %>

<%@ Register Src="~/Control/TJHotel.ascx" TagName="TJHotel" TagPrefix="uc1" %>
<%@ Register Src="~/Control/lyCar.ascx" TagName="lyCar" TagPrefix="uc2" %>
<%@ Register Src="../../Control/NewsSort.ascx" TagName="NewsSort" TagPrefix="uc5" %>
<%@ Register Src="../../Control/SiteView.ascx" TagName="SiteView" TagPrefix="uc6" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <form id="form1" runat="server">
    <div id="nav_son">
        <span><a href="/web/hotelorder/orderlist.aspx" class="cxdd">查询我的订单状态</a></span>当前位置：<a
            href="/">首页</a> &gt;&nbsp;<%=strjqname + strTpename%>
    </div>
    <div id="mainContent">
        <div id="main">
            
            <uc5:NewsSort ID="NewsSort2" runat="server" />
            <div class="info_box">
                <h2><%=strTpename%></h2>
                <div class="zx_list">
                    <asp:Repeater ID="RptData" runat="server">
                        <HeaderTemplate>
                            <ul>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li><span>
                                <%# DataBinder.Eval(Container.DataItem, "create_date")%>
                            </span><a href="/JQ_<%# DataBinder.Eval(Container.DataItem, "jingqucode")%>/news?typeCode=<%# DataBinder.Eval(Container.DataItem, "typeCode")%>">
                                [<%# DataBinder.Eval(Container.DataItem, "typename")%>
                                ]</a>&nbsp;<a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/news/<%#DataBinder.Eval(Container.DataItem, "seqno")%>"><%# DataBinder.Eval(Container.DataItem, "title")%>
                                </a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
                <div id="pages">
                    <%=strpage%>
                </div>
            </div>
        </div>
        <div id="side">
            <uc1:TJHotel ID="TJHotel1" runat="server" />
            <uc2:lyCar ID="lyCar1" runat="server" />
        </div>
        <div class="clearfloat">
        </div>
    </div>
    </form>
</asp:Content>
