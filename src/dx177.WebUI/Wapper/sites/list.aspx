<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.Wapper.sites.list"
    MasterPageFile="~/Home.Master" %>

<%@ Register src="../../Control/TJHotel.ascx" tagname="TJHotel" tagprefix="uc1" %>
<%@ Register src="../../Control/lyCar.ascx" tagname="lyCar" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div id="nav_son">
        当前位置：<a href="index.html">首页</a> &gt;&nbsp;<a href="#">风景列表</a></div>
    <div id="mainContent">
        <div id="main">
            <div class="info_box">
                <h2>
                    风景</h2>
                <div class="info_pic">
                    <ul>
                        <asp:ListView ID="lsQuestion" runat="server" OnItemDataBound="LsHotelList_ItemDataBound"
                            OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                            <LayoutTemplate>
                                <div id="itemPlaceholder" runat="server">
                                </div>
                            </LayoutTemplate>
                            <EmptyDataTemplate>
                                <div class="list_box div0">
                                    没有查到相关数据
                                </div>
                            </EmptyDataTemplate>
                            <ItemTemplate>                                
                                    <li><a href="/JQ_<%# DataBinder.Eval(Container.DataItem, "matchdomain")%>/sites/<%# DataBinder.Eval(Container.DataItem, "seqno")%>" target="_blank" title="<%# DataBinder.Eval(Container.DataItem, "title")%>">
                                        <img border="0" src="<%# DataBinder.Eval(Container.DataItem, "logo")%>" alt="<%# DataBinder.Eval(Container.DataItem, "title")%>"
                                            width="160" height="120" /><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                
                            </ItemTemplate>
                        </asp:ListView>
                    </ul>
                </div>
                <div id="pages">
                    <asp:DataPager ID="DataPager1" PagedControlID="lsQuestion" runat="server" PageSize="20"
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
