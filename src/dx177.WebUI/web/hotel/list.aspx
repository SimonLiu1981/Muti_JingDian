<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" MasterPageFile="~/web/defaultMaster.Master"
    Inherits="dx177.WebUI.web.hotel.list" %>

<asp:Content ContentPlaceHolderID="head" ID="cotent2" runat="server">
    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
 

    <script type="text/javascript">
        function SetConditionclass() {
            var p = '<%=this.price.ToLower()%>';
            var h = '<%=this.HotelType.ToLower()%>';
            var a = "<%=Area.ToLower() %>";
            $("#Hhotel" + h).addClass("here");
            $("#Hprice" + p).addClass("here");
            $('#Hotel_address_' + a).addClass('here');

        }
        $(document).ready(function() {

            SetConditionclass();
            $(".fang_lis").each(function() {
                var roomcount = $(this).children('.rel_cs').length;
                if (roomcount > 2) {
                    $(this).children('.down2').show();
                    $(this).children('.down2').children('a').children('.roomcount1').html(roomcount);
                    for (var i1 = 2; i1 < roomcount; i1++) {
                        $(this).children('.rel_cs').eq(i1).hide();
                    }
                }
                else {
                    $(this).children('.down2').hide();
                }
            });
        });
        function showAllRooms(lnk) {
            if ($(lnk).hasClass('fright2')) {
                $(lnk).removeClass('fright2').addClass('fright3');
                var roomcount = $(lnk).parent('.down2').parent('.fang_lis').children('.rel_cs').length;

                for (var i1 = 2; i1 < roomcount; i1++) {
                    $(lnk).parent('.down2').parent('.fang_lis').children('.rel_cs').eq(i1).show();
                }
            }
            else {
                $(lnk).removeClass('fright3').addClass('fright2');
                var roomcount = $(lnk).parent('.down2').parent('.fang_lis').children('.rel_cs').length;
                for (var i1 = 2; i1 < roomcount; i1++) {
                    $(lnk).parent('.down2').parent('.fang_lis').children('.rel_cs').eq(i1).hide();
                }
            }
        }
        
    </script>

    <div class="navigation">
        <span>当前位置：</span><a title='一起去丹霞' href="/">一起去丹霞</a><span>»</span><a title='酒店预定'
            href="/hotel/default.aspx">酒店预定</a>
    </div>
    <!--头部 结束-->
    <div class="main">
        <div class="main_left">
            <ul class="css-tabs03">
                <li><a class="current" href="#">查询条件</a></li>
            </ul>
            <div class="css-panes03">
                <div class="out">
                    <div class="search_main">
                        <p>
                            <b>价格范围：</b><a id="Hprice0" href="<%=GetPriceUrl("0") %>" target="_self">全部</a>
                            <a id="Hprice100" href="<%=GetPriceUrl("100") %>" target="_self">100元以下</a><a href="<%=GetPriceUrl("200") %>"
                                id="Hprice200" target="_self">100-200元</a><a href="<%=GetPriceUrl("300") %>" id="Hprice300"
                                    target="_self">200-300元</a><a href="<%=GetPriceUrl("301") %>" id="Hprice301" target="_self">300元以上</a>
                        </p>
                        <p class="heightlight">
                            <b>酒店类型：</b> <a href="<%=GetHotelTypeUrl("") %>" id="Hhotel" target="_self">全部</a>
                            <asp:Repeater ID="rpHotelType" runat="server">
                                <ItemTemplate>
                                    <a href="<%#GetHotelTypeUrl(DataBinder.Eval(Container.DataItem, "Enum_value").ToString()) %>"
                                        id='Hhotel<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>' target="_self">
                                        <%# DataBinder.Eval(Container.DataItem, "tag_name")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                        <p>
                            <b>酒店地区：</b> <a href="<%=GetAddressUrl("") %>" id="Hotel_address_" target="_self">全部</a>
                            <asp:Repeater ID="rpAddress" runat="server">
                                <ItemTemplate>
                                    <a href="<%#GetAddressUrl(DataBinder.Eval(Container.DataItem, "Enum_value").ToString()) %>"
                                        id='Hotel_address_<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>' target="_self">
                                        <%# DataBinder.Eval(Container.DataItem, "tag_name")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
            <asp:ListView ID="LsHotelList" runat="server" OnItemDataBound="LsHotelList_ItemDataBound"
                OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                <LayoutTemplate>
                    <div id="itemPlaceholder" runat="server">
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="hotel_list">
                        <div class="hotel_list_item">
                            <div class="hotel_list_item_content link01">
                                <div class="blue_left">
                                    <a class="picture1" href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html"
                                        target="_blank">
                                        <img src='<%# DataBinder.Eval(Container.DataItem, "Logo")%>' width="95" height="95"></a>
                                    <a class="picture2" href="/hotelpics_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.aspx"
                                        target="_blank">
                                        <img src="/web/img/11252-com_75.gif"></a><span class="picture3"><a>
                                            <%# DataBinder.Eval(Container.DataItem, "hoteltypename")%></span></A><a class="picture6"
                                                href="/hotelcomments_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.aspx"
                                                target="_blank">
                                                <%# DataBinder.Eval(Container.DataItem, "scount")%>
                                                条酒店点评</a>
                                    <div class="picture6">
                                        <span class='c-value-no c-value-<%# SocreToCssStr(DataBinder.Eval(Container.DataItem, "AvgScore")) %>'
                                            title="<%# DataBinder.Eval(Container.DataItem, "AvgScore") %>/5.0"></span>
                                        <%# DataBinder.Eval(Container.DataItem, "AvgScore")%></div>
                                </div>
                                <h2>
                                    <a href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html" target="_blank">
                                        <%# DataBinder.Eval(Container.DataItem, "Name")%>
                                    </a>
                                </h2>
                                <dl class="low_est">
                                    <dt>最低房价：</dt>
                                    <dd>
                                        ￥
                                        <%# DataBinder.Eval(Container.DataItem, "MinPrice")%>
                                    </dd>
                                </dl>
                                <dl class="jieshao">
                                    <dt>介绍：</dt>
                                    <dd>
                                        <%# DataBinder.Eval(Container.DataItem, "biz")%>
                                    </dd>
                                </dl>
                                <dl class="dizhi">
                                    <dt>地址：</dt>
                                    <dd>
                                        <%# DataBinder.Eval(Container.DataItem, "Address")%>
                                        <input id="txtGuid" runat="server" type="hidden" value='<%# DataBinder.Eval(Container.DataItem, "GUID")%>' />
                                    </dd>
                                </dl>
                                <dl class="dizhi">
                                    <dt>人气：</dt>
                                    <dd>
                                         <span viewtimes_get_guid='<%# DataBinder.Eval(Container.DataItem, "GUID")%>'>0</span>                                        
                                    </dd>
                                </dl>
                                <dl class="fuwu">
                                    <dt>酒店服务：</dt>
                                    <dd>
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"w")%>.gif'
                                            alt="网络" title="网络" />
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"k")%>.gif'
                                            alt="KTV" title="KTV" />
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"s")%>.gif'
                                            alt="桑拿" title="桑拿" />
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"c")%>.gif'
                                            alt="餐厅" title="餐厅" />
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"y")%>.gif'
                                            alt="游泳池" title="游泳池" />
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"t")%>.gif'
                                            alt="停车场" title="停车场" />
                                        <img src='/web/img/<%# GetIInst(DataBinder.Eval(Container.DataItem, "installationsStr"),"j")%>.gif'
                                            alt="健身房" title="健身房" />
                                    </dd>
                                </dl>
                                <div class="fang_lis">
                                    <table style="float: left" class="tabH01">
                                        <tbody>
                                            <tr>
                                                <th class="fx">
                                                    房型<span style="font-size: 12px; font-weight: normal">（点击房型查看详情）</span>
                                                </th>
                                                <th class="wid_th1">
                                                    门市价
                                                </th>
                                                <th class="wid_th1">
                                                    平时价
                                                </th>
                                                <th class="wid_th1">
                                                    周末价
                                                </th>
                                                  <th class="wid_th1">
                                                    节假日价
                                                </th>
                                                <th class="wid_th1">
                                                    操作
                                                </th>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <asp:Repeater ID="RpRoom" runat="server">
                                        <ItemTemplate>
                                            <div class="rel_cs">
                                                <table class="tabH01">
                                                    <tbody>
                                                        <tr>
                                                            <td class="fx02">
                                                                <a class="fang" title='<%# DataBinder.Eval(Container.DataItem, "RoomTitle")%>' onclick="onPopup2('fx_15284_77191')"
                                                                    href="javascript:void(0);">
                                                                    <%# DataBinder.Eval(Container.DataItem, "RoomTitle")%>
                                                                </a>
                                                            </td>
                                                            <td class="msj">
                                                                ￥<%# DataBinder.Eval(Container.DataItem, "MarketPrice")%>
                                                            </td>
                                                            <td class="tcj">
                                                                <a href="javascript:void(0);">
                                                                    <%# DataBinder.Eval(Container.DataItem, "Price1")%></a>
                                                            </td>
                                                            <td class="tcj">
                                                                <a href="javascript:void(0);">
                                                                    <%# DataBinder.Eval(Container.DataItem, "Price2")%></a>
                                                            </td>
                                                             <td class="tcj">
                                                                <a href="javascript:void(0);">
                                                                     待定</a>
                                                            </td>
                                                            <td class="wid_th1">
                                                                <a class="yd" href="/web/hotelorder/NewOrder.aspx?roomid=<%# DataBinder.Eval(Container.DataItem, "Seqno")%>"
                                                                    target="_blank">预订</a>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                    <div class="down2">
                                        <a onclick="showAllRooms(this)" class="fright2" href="javascript:void(0);">所有房型[<span
                                            class='roomcount1'></span>]</a></div>
                                    <div class="blank05">
                                    </div>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <input id="txtGuid" runat="server" type="hidden" />
            <div id="pagerwrapper" style="margin-top: 5px">
                <div class="page_link_full">
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
        </div>
        <div class="main_right">
            <div class="table05">
                <div class="table05_title">
                    <p class='zuche'>
                        旅游租车</p>
                </div>
                <div class="table05_body">
                    <ucMy:right_hireCar ID="right_hireCar1" runat="server" MaxCount="4" />
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
                    <ucMy:right_restaurant1 ID="right_restaurant11" MaxCount="5" runat="server" />
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
                    <ucMy:home_questions ID="home_questions1" runat="server" />
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    <!--主体 结束-->
  
</asp:Content>
