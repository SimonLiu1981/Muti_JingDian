<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comments.aspx.cs" Inherits="dx177.WebUI.Wapper.comm.comments"
    MasterPageFile="~/Home.Master" %>

<%@ Register Src="../../Control/lyCar.ascx" TagName="lyCar" TagPrefix="uc1" %>
<%@ Register Src="../../Control/SiteLeft.ascx" TagName="SiteLeft" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/room.gbk.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>

    <script type="text/javascript">
     
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="nav_son">
        <span><a href="/web/hotelorder/orderlist.aspx" class="cxdd">查询我的订单状态</a></span>当前位置：<a
            href="/index.html">首页</a> &gt;&nbsp;<%=CommentTitle%>点评</div>
    <div id="mainContent">
        <div id="side">
            <uc2:SiteLeft ID="SiteLeft1" runat="server" />
            <uc1:lyCar ID="lyCar1" runat="server" />
        </div>
        <div id="main">
            <div class='info_box'>
                <h2>
                    <%=CommentTitle%>点评</h2>
                <div class="ib_con">                
                    <asp:ListView ID="LsHotelList" runat="server" OnItemDataBound="LsHotelList_ItemDataBound"
                        OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <EmptyDataTemplate>
                            <div class="list_box div0">
                                没有查到相关评论</div>
                        </EmptyDataTemplate>
                        <ItemTemplate>
                             <dl>
                                <dt><%# DataBinder.Eval(Container.DataItem, "CREATOR")%> 于 <%# DataBinder.Eval(Container.DataItem, "CREATEDATE")%> 评价说：</dt>
                                <dd class="info_ask_row">
                                    <%# DataBinder.Eval(Container.DataItem, "Content")%>
                                </dd>
                                <dd>
                                    <%# DataBinder.Eval(Container.DataItem, "ReplyContent")%>
                                </dd>
                             </dl>
                        </ItemTemplate>
                    </asp:ListView>
                    <div id="pages">
                        <asp:DataPager ID="DataPager1" PagedControlID="LsHotelList" runat="server" PageSize="8"
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
                
                <div class="info_box" style="margin-top:5px;">
                    <h2>
                       <%=CommentTitle%>客人点评</h2>
                    <div class="ib_con">                        
                        <table border="0" cellspacing="0" cellpadding="4" width="100%">
                            <form id="form1" method="post" name="form1"  
                            target="_top">
                            <tbody>
                                <tr>
                                    <td style="color:#666;">
                                      我要向<%=CommentTitle%>点评:
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        邮箱：<input name="email" type="text" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        手机：<input name="phone" type="text" />
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" width="464">
                                        <textarea style="width: 98%; height: 120px" id="Content" name="Content"></textarea>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="color: #666">
                                        正常工作日9:00－18:00，您的提问会得到及时回答；其它时段可能需等待较长时间
                                    </td>
                                </tr>
                                <tr>
                                     
                                    <input value="<%=Pguid %>" type="hidden" name="pguid">
                                    <td>
                                        <input id="button" class="btn05" value="提交问题" type="submit" name="button">
                                    </td>
                                </tr>
                            </form>
                            </TBODY></table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
