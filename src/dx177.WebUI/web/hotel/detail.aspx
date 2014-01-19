<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="detail.aspx.cs" Inherits="dx177.WebUI.web.hotel.detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--主体 开始-->
    <div class="navigation">
            <span>当前位置：</span><a title='177丹霞' href="/">177丹霞</a><span>»</span><a title='酒店预定' href="/hotel/default.aspx">酒店预定</a><span>»</span>  <%=h.Name%> 
        </div>
    <div class="main_left">
              
        <div class="hotel_tit">
            <span class="zuo"></span>
            <div class="info">
                <div class="biaoti link01">
                    <h2>
                        <a>
                            <%=h.Name%></a></h2>
                    <ul>
                        <li><a href="http://wpa.qq.com/msgrd?V=1&amp;Uin=57718504&amp;Site=QQ咨询&amp;Menu=yes"
                            target="_blank">
                            <img style="vertical-align: middle" border="0" alt="QQ" src=" http://wpa.qq.com/pa?p=1:57718504:4">在线客户</a>
                        </li>
                        <li><a href="http://wpa.qq.com/msgrd?V=1&amp;Uin=57718504&amp;Site=QQ咨询&amp;Menu=yes"
                            target="_blank">
                            <img style="vertical-align: middle" border="0" alt="QQ" src=" http://wpa.qq.com/pa?p=1:57718504:4">在线客户</a>
                        </li>
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
                <li class="on"><a title="点击查看酒店图片" href="/hotel_<%=this.Seqno %>.html">概括及房价</a>   
                </li>
                <li><a class="on" href="/hotelpics_<%=this.Seqno %>.html">酒店图片</a></li>
                <li><a title="点击查看客人点评" href="/hotelcomments_<%=this.Seqno %>.html">客人点评</a> </li>
            </ul>
            <div style="height: 0px; clear: both; overflow: hidden">
            </div>
            <div class="infos">
                <!--图片-->
                <div id="divMap" class="show_pic">
                    <div class="top">
                        <img id="imgBig" src="<%=h.Logo %>" width="266" height="192">
                    </div>
                    <div class="bottom">
                        <a class="prev" title="向左"></a>
                        <div class="scrollable" id='abcd'>
                            <div class="items">
                                <%=PicArr2 %>
                            </div>
                        </div>
                        <a class="next" title="向右"></a>
                    </div>

                    <script type="text/javascript" language="javascript">
                        $(function() {

                            $(".scrollable").scrollable({ "steps": 4 });

                            $(".items img").click(function() {

                                // see if same thumb is being clicked
                                if ($(this).hasClass("active")) { return; }

                                // calclulate large image's URL based on the thumbnail URL (flickr specific)
                                var url = $(this).attr("bigImg");

                                // get handle to element that wraps the image and make it semi-transparent
                                var wrap = $(".top").fadeTo("medium", 0.9);

                                // the large image from www.flickr.com
                                var img = new Image();


                                // call this function after it's loaded
                                img.onload = function() {

                                    // make wrapper fully visible
                                    wrap.fadeTo("fast", 1);

                                    // change the image
                                    wrap.find("img").attr("src", url);

                                };

                                // begin loading the image from www.flickr.com
                                img.src = url;

                                // activate item
                                $(".items img").removeClass("active");
                                $(this).addClass("active");

                                // when page loads simulate a "click" on the first image
                            }).filter(":first").click();
                        });
                    </script>

                </div>
                <ul id="ulInfo" class="info">
                    <li>酒店等级：<a href="<%=HotelTypeNameLink %>" title="<%=HotelTypeName %>"><%=HotelTypeName %></a>
                    </li>
                    <li>酒店设施：
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"w")%>.gif' alt="网络" title="网络" />
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"k")%>.gif' alt="KTV" title="KTV" />
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"s")%>.gif' alt="桑拿" title="桑拿" />
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"c")%>.gif' alt="餐厅" title="餐厅" />
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"y")%>.gif' alt="游泳池" title="游泳池" />
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"t")%>.gif' alt="停车场" title="停车场" />
                        <img src='/web/img/<%= GetIInst(h.Installationsstr,"j")%>.gif' alt="健身房" title="健身房" />
                    </li>
                    <li>房价范围：<%=h.Minprice%>
                        -<%=h.Maxprice%>
                    </li>
                    <li>酒店地址：<a>
                        <%=h.Address%>
                    </a></li>
                    <li>商业区域： <a href="<%=AreaTypeLink %>">
                        <%=AreaType%>
                    </a></li>
                     <li>浏览次数： 
                        <span viewtimes_add_guid="<%=h.Guid %>">0</span>
                     </li>
                    <li class="pj"><span class='title'>综合评价：</span>
                        <!--酒店评分开始 -->
                        <ul>
                            <li><span>设施：</span><span class="c-value-no c-value-<%=myScore.CssScore1 %>" title="<%=myScore.ScoreTitle1 %>"></span></li>
                            <li><span>交通：</span><span class="c-value-no c-value-<%=myScore.CssScore2 %>" title="<%=myScore.ScoreTitle2 %>"></span></li>
                            <li><span>卫生：</span><span class="c-value-no c-value-<%=myScore.CssScore3 %>" title="<%=myScore.ScoreTitle3 %>"></span>
                            </li>
                            <li><span>性价比：</span><span class="c-value-no c-value-<%=myScore.CssScore4 %>" title="<%=myScore.ScoreTitle4 %>"></span>
                        </ul>
                        <!--酒店评分结束-->
                    </li>
                </ul>
            </div>
        
            <!--酒店房型-->
            <div class="zyleft2 mtop">
                <div class="blank05">
                </div>
                <div class="zyleft2_head">
                    <h3>
                        <%=h.Name%>
                        所有房型
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
                                        平时
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
                                                    <img src="/web/img/icon08.gif"><a class="fang" title="标准房" onclick="onPopup2('fx_7887_39157')"
                                                        href="javascript:void(0);"><%# DataBinder.Eval(Container.DataItem, "RoomTitle")%>
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
            
                <div class="hotel_info_about">
                <h3>
                    <%=h.Name%>
                    简介</h3>
                <p>
                    <%=h.Descr  %>
                </p>
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
    <div class="clear">
    </div>
</asp:Content>
