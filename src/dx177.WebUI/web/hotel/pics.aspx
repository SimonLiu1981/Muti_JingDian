<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/web/defaultMaster.Master"
    CodeBehind="pics.aspx.cs" Inherits="dx177.WebUI.web.hotel.pics" %>
<%@ Register Src="/web/usercontrols/home_hotel_2.ascx" TagName="home_hotel_2" TagPrefix="uc2" %>
<%@ Register Src="/web/usercontrols/home_questions.ascx" TagName="home_questions" TagPrefix="uc3" %>
<%@ Register Src="/web/usercontrols/home_new.ascx" TagName="home_new" TagPrefix="uc4" %>
<%@ Register Src="/web/usercontrols/right_hireCar.ascx" TagName="right_hireCar" TagPrefix="uc5" %>
<%@ Register src="../usercontrols/right_restaurant1.ascx" tagname="right_restaurant1" tagprefix="uc1" %>
<asp:Content ContentPlaceHolderID="head" ID="Content2" runat="server">

    <script src="/Plugin/Jquery.tools/jquery.tools.min.js" type="text/javascript"></script>

    <link rel="stylesheet" type="text/css" href="/plugin/fancybox/jquery.fancybox-1.3.4.css"
        media="screen" />

    <script type="text/javascript" src="/plugin/fancybox/jquery.fancybox-1.3.4.pack.js"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $("a[rel=lightbox_group]").fancybox({
                'transitionIn': 'none',
                'transitionOut': 'none',
                'titlePosition': 'over',
                'titleFormat': function(title, currentArray, currentIndex, currentOpts) {
                    return '<span id="fancybox-title-over">图像： ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';
                }
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="navigation">
        <span>当前位置：</span><a title='177丹霞' href="/">177丹霞</a><span>»</span><a title='酒店预定' href="/hotel/default.aspx">酒店预定</a><span>»</span>  <%=h.Name%> 图片欣赏
    </div>
    <!--头部 结束-->
    <div class="main">
        
        <!--主体 开始-->
        <div class="main_left">
            <div class="blank05">
            </div>
            <div class="hotel_tit">
                <span class="zuo"></span>
                <div class="info">
                    <div class="biaoti link01">
                        <h2><%=h.Name%></h2>
                        <ul>
                            <li><a href="http://wpa.qq.com/msgrd?V=1&amp;Uin=57718504&amp;Site=QQ咨询&amp;Menu=yes"
                                target="_blank">
                                <img style="vertical-align: middle" border="0" alt="QQ" src=" http://wpa.qq.com/pa?p=1:57718504:4">在线客户</a></li>
                            <li><a href="http://wpa.qq.com/msgrd?V=1&amp;Uin=57718504&amp;Site=QQ咨询&amp;Menu=yes"
                                target="_blank">
                                <img style="vertical-align: middle" border="0" alt="QQ" src=" http://wpa.qq.com/pa?p=1:57718504:4">在线客户</a></li>
                        </ul>
                    </div>
                    <p>
                        <%=h.Biz%>
                    </p>
                </div>
                <span class="you"></span>
            </div>
            <div class="hotel_info link01">
                <ul class="tit">
                    <li><a title="点击查看酒店图片" href="/hotel_<%=this.Seqno %>.html">概括及房价</a> </li>
                    <li class="on"><a class="on" href="/hotelpics_<%=this.Seqno %>.html">酒店图片</a></li>
                    <li><a title="点击查看客人点评" href="/hotelcomments_<%=this.Seqno %>.html">客人点评</a> </li>
                </ul>
                <div style="height: 0px; clear: both; overflow: hidden">
                </div>
                <div class="zyleft1_body">
                    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
                    <ul class="imgul">
                        <asp:ListView ID="lsPicList" runat="server" OnPagePropertiesChanging="lsPicList_PagePropertiesChanging">
                            <LayoutTemplate>
                                <div id="itemPlaceholder" runat="server">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <li><a title="<%=h.Name%>外观" href="<%# DataBinder.Eval(Container.DataItem, "bigimgfile")%>"
                                    rel="lightbox_group">
                                    <img src='<%# DataBinder.Eval(Container.DataItem, "smallimgfile")%> ' /></a><a title="外观"
                                        href="<%# DataBinder.Eval(Container.DataItem, "bigimgfile")%>">外观 </a></li>
                            </ItemTemplate>
                        </asp:ListView>
                    </ul>
                    <div id="pagerwrapper" style="margin-top: 5px">
                        <div class="page_link_full">
                            <asp:DataPager ID="DataPager1" PagedControlID="lsPicList" runat="server" PageSize="9"
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
                <!--酒店房型-->
                <div class="zyleft2 mtop">
                    <div class="blank05">
                    </div>
                    <div class="zyleft2_head">
                        <h3>
                            <%=h.Name%>
                        </h3>
                    </div>
                    <div id="showprice7887" class="fang_lis zyleft2_body" style="width: 698px">
                        <div style="z-index: 1000; position: relative; float: left">
                            <table style="float: left; width: 698px" class="tabH01">
                                <tbody>
                                    <tr>
                                        <th class="fx">
                                            房型<span style="font-size: 12px; font-weight: normal">（点击房型查看详情）</span>
                                        </th>
                                        <th class="wid_th1">
                                            门市价
                                        </th>
                                        <th class="wid_th1">
                                            现价
                                        </th>
                                        <th class="wid_th1">
                                            周末价
                                        </th>
                                        
                                        <th class="wid_th1">
                                            节假日
                                        </th>
                                        <th class="wid_th1">
                                            操作
                                        </th>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div id="showall_7887_0">
                            <asp:Repeater ID="rpRoom" runat="server">
                                <ItemTemplate>
                                    <div class="rel_cs">
                                        <table style="float: left; width: 698px" class="tabH01">
                                            <tbody>
                                                <tr>
                                                    <td class="fx02">
                                                        <img src="http://img.17u.cn/hotel/images/www_17u_cn/SearchListNew/List/icon08.gif"><a
                                                            class="fang" title="标准房" onclick="onPopup2('fx_7887_39157')" href="javascript:void(0);"><%# DataBinder.Eval(Container.DataItem, "RoomTitle")%>
                                                        </a>
                                                    </td>
                                                    <td class="msj">
                                                        ￥<%# DataBinder.Eval(Container.DataItem, "MarketPrice")%>
                                                    </td>
                                                    <td class="tcj">
                                                        <a href="javascript:void(0);">￥<%# DataBinder.Eval(Container.DataItem, "Price1")%>
                                                        </a>
                                                    </td>
                                                    <td class="tcj">
                                                        <a href="javascript:void(0);">￥<%# DataBinder.Eval(Container.DataItem, "Price2")%>
                                                        </a>
                                                    </td>
                                                    <td class="tcj">
                                                        <a href="javascript:void(0);">待定
                                                        </a>
                                                    </td>
                                                    
                                                    <td class="wid_th1">
                                                        <a class="yd" href="/roomorder_<%# DataBinder.Eval(Container.DataItem, "Seqno")%>.aspx"
                                                            target="_blank">预订</a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <div style="height: 0px; clear: both; overflow: hidden">
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="main_right">
             
            <div class="table05">
                <div class="table05_title">
                    <p class='zuche'>
                        旅游租车</p>
                </div>
                <div class="table05_body">
                    <uc5:right_hireCar ID="right_hireCar1" runat="server" MaxCount="4" />
                    <div class="more">
                        <a href="/hirecar/default.aspx" target="_blank">更多</a></div>
                    <div class="clear">
                    </div>
                </div>
            </div>
            
            <div class="blank05">
            </div>
            <div class="table05">
                <div class="table05_title">
                    <p class='restaurant'>
                        饭店预订</p>
                </div>
                <div class="table05_body">
                     <uc1:right_restaurant1 ID="right_restaurant11" MaxCount=5  runat="server" />
                    <div class="more">
                        <a href="/restaurant/default.aspx" target="_blank">更多</a></div>
                    <div class="clear">
                        
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
            <div class="table03">
                <div class="table03_title">
                    <p>
                        旅游问答</p>
                    <div class="more">
                        <a href="/questions/default.aspx" target="_blank">更多</a></div>
                </div>
                <div class="table03_body">
                    <uc3:home_questions ID="home_questions1" runat="server" />
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
        <div class="clear">
        </div>
        <!--主体 结束-->
    </div>
</asp:Content>
