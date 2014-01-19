<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true" CodeBehind="MyOrderList.aspx.cs" Inherits="dx177.WebUI.web.admin.Wap.MyOrderList" Title="无标题页" %>
 

<%@ Register src="../UCLeftMenu.ascx" tagname="UCLeftMenu" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
<link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/Plugin/fancybox/jquery.fancybox-1.3.4.pack.js"></script>
<link rel="stylesheet" type="text/css" href="/Plugin/fancybox/jquery.fancybox-1.3.4.css" media="screen" />
    <script type="text/javascript">
        $(document).ready(function() {
            $("a.openorder").fancybox();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
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
                            <strong>
                                <%=dx177.Model.AppContext.CurrentResuser.Username %></strong></div>
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
                        <uc2:UCLeftMenu ID="UCLeftMenu1"   runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <div class="MemberMain">
                <div>
                    <div class="order_title_div">
                        <table border='0' cellspacing="0" cellpadding="0" width="250">
                            <tbody>
                                <tr id='ordre_head_tr'>
                                    <td id='ptd_0'>
                                        <a href="/MyOrderList_9_<%=Historystatus%>.aspx">全部订单</a>
                                    </td>
                                    <td id='ptd_1'>
                                        <a href="/MyOrderList_1_<%=Historystatus%>.aspx">已经取消</a>
                                    </td>
                                    <td id='ptd_2'>
                                        <a href="/MyOrderList_2_<%=Historystatus%>.aspx">等待确认</a>
                                    </td>
                                    <td id='ptd_3'>
                                        <a href="/MyOrderList_3_<%=Historystatus%>.aspx">已经确认</a>
                                    </td>
                                    <td id='ptd_4'>
                                        <a href="/MyOrderList_4_<%=Historystatus%>.aspx">已经入住</a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>

                        <script type="text/javascript">
                            $(document).ready(function() {
                                $('#ordre_head_tr td').each(function() {
                                    $(this).removeClass('current');
                                });
                                var statusType = '<%=StatusType %>';
                                if (statusType == '') {

                                    $('#ptd_0').addClass('current');
                                }
                                else {
                                    $('#ptd_' + statusType).addClass('current');
                                }
                            });
                        </script>

                    </div>
                    <table width="100%" cellpadding="3" cellspacing="0" class="liststyle">
                        <colgroup>
                            <col class="span-3 ColColorGray" />
                            <col class="span-3" />
                            <col class="span-auto" />
                            <col class="span-2 ColColorOrange" />
                            <col class="span-3" />
                            <col class="span-3" />
                            <col class="span-2" />
                        </colgroup>
                        <thead>
                            <tr>
                                <th>
                                    订单编号
                                </th>
                                <th>
                                    预订日期
                                </th>
                                <th>
                                    店家名称
                                </th>
                                <th>
                                    订单总额
                                </th>
                                <th>
                                    入住日期
                                </th>
                                <th>
                                    离店日期
                                </th>
                                <th>
                                    订单状态
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvOrder" runat="server" OnPagePropertiesChanging="lvOrder_PagePropertiesChanging">
                                <LayoutTemplate>
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <a href="/web/admin/member-vieworder.aspx?seqno=<%#DataBinder.Eval(Container.DataItem,"Seqno")%>"
                                                class='openorder'>
                                                <%#DataBinder.Eval(Container.DataItem,"orderno")%></a>
                                        </td>
                                        <td>
                                            <%#DateTime.Parse(DataBinder.Eval(Container.DataItem,"CREATEDATE").ToString()).ToString("yyyy-MM-dd") %>
                                        </td>
                                        <td>
                                            <%#DataBinder.Eval(Container.DataItem,"Hotelname")%>
                                        </td>
                                        <td class="textright">
                                            ￥<%#Double.Parse(DataBinder.Eval(Container.DataItem,"Totalmoney").ToString()).ToString("0.00")%>
                                        </td>
                                        <td>
                                            <%#DateTime.Parse(DataBinder.Eval(Container.DataItem,"Begindate").ToString()).ToString("yyyy-MM-dd") %>
                                        </td>
                                        <td>
                                            <%#DateTime.Parse(DataBinder.Eval(Container.DataItem,"Enddate").ToString()).ToString("yyyy-MM-dd") %>
                                        </td>
                                        <td>
                                            <%# dx177.Business.DictBus.Dict.Tag[(dx177.FrameWork.HotelOrderStatus)int.Parse(DataBinder.Eval(Container.DataItem,"status").ToString())] %>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                    </table>
                    <div style="float: right; margin-top: 5px;" class="page_link_full">
                        <asp:DataPager ID="DataPager1" PagedControlID="lvOrder" runat="server" PageSize="10"
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
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    </form>
</asp:Content>

