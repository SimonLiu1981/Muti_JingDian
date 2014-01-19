<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="dx177.WebUI.master.news._default" MasterPageFile="~/master/Site.Master" %>

<%@ Register Src="~/Control/TJHotel.ascx" TagName="TJHotel" TagPrefix="uc1" %>
<%@ Register Src="~/Control/lyCar.ascx" TagName="lyCar" TagPrefix="uc2" %>
<%@ Register Src="../../Control/NewsSort.ascx" TagName="NewsSort" TagPrefix="uc5" %>
<%@ Register Src="../../Control/SiteView.ascx" TagName="SiteView" TagPrefix="uc6" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <form id="form1" runat="server">
    <div id="nav_son">
        <span><a href="/web/hotelorder/orderlist.aspx" class="cxdd">查询我的订单状态</a></span>当前位置：<a
            href="/index.html">首页</a> &gt;&nbsp;<%=strTpename == string.Empty ? "新闻资讯" : strTpename%>
    </div>
    <div id="mainContent">
        <div id="main">            
            <uc5:NewsSort ID="NewsSort2" runat="server" />
            
            <div class="info_box">
                <h2><%=strTpename%></h2>
                <div class="zx_list">
                    <ul>
                     <asp:ListView ID="LsHotelList" runat="server"  
                            OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                            <LayoutTemplate>
                                <div id="itemPlaceholder" runat="server">
                                </div>
                            </LayoutTemplate>
                            <EmptyDataTemplate>
                                <li>
                                    没有查到相关数据</li>
                            </EmptyDataTemplate>                    
                            <ItemTemplate>
                                    <li><span>
                                        <%# DataBinder.Eval(Container.DataItem, "create_date")%>
                                    </span><a href="/JQ_<%# DataBinder.Eval(Container.DataItem, "jingqucode")%>/news?typeCode=<%# DataBinder.Eval(Container.DataItem, "typeCode")%>">
                                        [<%# DataBinder.Eval(Container.DataItem, "typename")%>
                                        ]</a>&nbsp;<a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/news/<%#DataBinder.Eval(Container.DataItem, "seqno")%>"><%# DataBinder.Eval(Container.DataItem, "title")%>
                                        </a></li>                        
                            </ItemTemplate>
                        </asp:ListView>
                </ul>
                </div>
                <div id="pages">
                <asp:DataPager ID="DataPager1" PagedControlID="LsHotelList" runat="server" PageSize="15"
                    OnPreRender="DataPager1_PreRender" QueryStringField="p">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" FirstPageText="第一页" LastPageText="尾页"
                            NextPageText="下一页" PreviousPageText="上一页" ShowFirstPageButton="True" ShowNextPageButton="False"
                            ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                        <asp:NumericPagerField NextPageText="..." PreviousPageText="..." ButtonCount="5"
                            CurrentPageLabelCssClass='this-page'></asp:NumericPagerField>
                        <asp:NextPreviousPagerField ButtonType="Button" FirstPageText="第一页" LastPageText="尾页"
                            NextPageText="下一页" PreviousPageText="上一页" ShowLastPageButton="True" ShowNextPageButton="False"
                            ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                    </Fields>
                </asp:DataPager>
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
