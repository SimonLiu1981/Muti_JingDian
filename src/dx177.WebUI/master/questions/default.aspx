<%@ Page Language="C#" MasterPageFile="~/master/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="dx177.WebUI.master.questions._default" Title="Untitled Page" %>
<%@ Register src="../../Control/lyCar.ascx" tagname="lyCar" tagprefix="uc1" %>
<%@ Register src="../../Control/TJHotel.ascx" tagname="TJHotel" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="nav_son">      
        当前位置：<a href="/index.html">首页</a> &gt;&nbsp; <a href="<%= GetQuestionURL("")%>">问题解答</a>
    </div>
    <div id="main">
        <div class="list_top">
            <h2>
                <span><a href=#> 我要提问 </a></span>
                <strong>问题类型</strong>                
            </h2>
            
            <div class="zx_question_list">
                <ul>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                             <li><a href="<%# GetQuestionURL(DataBinder.Eval(Container.DataItem, "code").ToString())%>" title="<%# DataBinder.Eval(Container.DataItem, "title")%>">[<%# DataBinder.Eval(Container.DataItem, "title")%>]</a> </li>
                        </ItemTemplate>
                    </asp:Repeater>                    
                </ul>
            </div>
        </div>
        <div class="info_box">
            <h2>
                问题解答</h2>
            <div class="zx_list">
                <ul>
                 <asp:ListView ID="lsQuestion" runat="server" OnItemDataBound="LsHotelList_ItemDataBound"
                    OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                    <LayoutTemplate>
                        <div id="itemPlaceholder" runat="server">
                        </div>
                    </LayoutTemplate>
                    <EmptyDataTemplate>
                     <div class="list_box div0">
                            没有查到相关问题数据 </div>
                    </EmptyDataTemplate>
                    <ItemTemplate>
                    <li>
                        <span><%#DateTime.Parse(DataBinder.Eval(Container.DataItem, "create_date").ToString()).ToString("yyyy-MM-dd HH:mm") %></span> 
 
                          <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "JingQuCode") %>/questions?type=<%#DataBinder.Eval(Container.DataItem, "typecode") %>">[<%# DataBinder.Eval(Container.DataItem, "qtypename")%>]</a>&nbsp;<a href="/JQ_<%# DataBinder.Eval(Container.DataItem, "matchdomain")%>/questions/<%# DataBinder.Eval(Container.DataItem, "seqno")%>"><%# DataBinder.Eval(Container.DataItem, "title")%></a> 
 
                    </li>
                    </ItemTemplate>
                    </asp:ListView>                    
                   
                </ul>
            </div>
            <div id="pages">
                <asp:DataPager ID="DataPager1" PagedControlID="lsQuestion" runat="server" PageSize="16"
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
        
        <uc1:lyCar ID="lyCar1" runat="server" />
        <uc2:TJHotel ID="TJHotel" runat="server" />
        
    </div>
    <div class="clearfloat">
    </div>
</asp:Content>
