<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="detail.aspx.cs" Inherits="dx177.WebUI.web.restaurant.detail" %>

<%@ Register Src="../usercontrols/right_hireCar.ascx" TagName="right_hireCar" TagPrefix="uc5" %>
<%@ Register Src="../usercontrols/home_hotel_2.ascx" TagName="home_hotel_2" TagPrefix="uc2" %>
<%@ Register Src="../../usercontrols/UCJqueryRaty.ascx" TagName="UCJqueryRaty" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="main">
             <div class="navigation">
                <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span></span><a href="/restaurant/default.aspx">饭店预订</a>
                <span>»</span>
                <%=Rest.Title%>
            </div>
        <!--主体 开始-->
        <div class="main_left">       
            <div class="cate_info link01">
                <!--图片-->
                <div id="divMap" class="show_pic">
                    <div class="top">
                        <img id="imgBig" src="<%=Rest.Logo %>" width="266" height="192">
                    </div>
                    <div class="bottom">
                        <a class="prev" title="向左"></a>
                        <div class="scrollable" id='abcd'>
                            <div class="items">
                                <%=Pics %>
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
                                var wrap = $(".top").fadeTo("medium", 0.5);

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
                <h1 class="cate_title">
                    <%=Rest.Title %>
                </h1>
                <div class='info'>
                    <dl>
                        <dt></dt>
                        <dd>
                            地址：<%=Rest.Address %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            简述：
                            <%=Rest.Shortcontent %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            电话：<%=Rest.Telnumber %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            <div class="pingf1_title">
                                饭店综合评分：</div>
                            <ul id="ulPingji" class="pingf1">
                                <li><span>口味：</span><span class="c-value-no c-value-<%=myScore.CssScore1 %>" title="<%=myScore.ScoreTitle1 %>"></span><%=myScore.ScoreTitle1 %></li>
                                <li><span>环境：</span><span class="c-value-no c-value-<%=myScore.CssScore2 %>" title="<%=myScore.ScoreTitle2 %>"></span><%=myScore.ScoreTitle2 %></li>
                                <li><span>服务：</span><span class="c-value-no c-value-<%=myScore.CssScore3 %>" title="<%=myScore.ScoreTitle3 %>"></span><%=myScore.ScoreTitle3 %></li>
                                <li><span>卫生：</span><span class="c-value-no c-value-<%=myScore.CssScore4 %>" title="<%=myScore.ScoreTitle4 %>"></span><%=myScore.ScoreTitle4 %></li></ul>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            人均消费:<span class="rjxf">￥<%=Rest.Cost %></span>元</dd>
                    </dl>
                </div>
                <!--酒店房型-->
            </div>
            <div class="hotel_info link01">
                <ul class="tit">
                    <li class="on"><a href="/restaurant_<%=seqno %>.aspx">特色菜普</a></li>
                    <li><a href="/restaurantcomments_<%=seqno %>.aspx">用户点评</a></li>
                </ul>
                <div style="height: 0px; clear: both; overflow: hidden">
                </div>
                <div class="zyleft1_body">
                    <asp:Repeater ID="rptTsjd" runat="server">
                        <HeaderTemplate>
                            <ul class="imgul">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li><a title="<%#DataBinder.Eval(Container.DataItem,"Name")%>" href="<%#DataBinder.Eval(Container.DataItem,"Logo")%>"
                                rel="lightbox_group">
                                <img src="<%#DataBinder.Eval(Container.DataItem,"Logo")%>">
                            </a><a title="<%#DataBinder.Eval(Container.DataItem,"Name")%>" href="<%#DataBinder.Eval(Container.DataItem,"Logo")%>">
                                <%#DataBinder.Eval(Container.DataItem,"Name")%>
                            </a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                    </li> </ul>
                </div>
            </div>
        </div>
        <div class="main_right">
            <div class="blank05">
            </div>
            <div class="table04">
                <div class="table04_title">
                    <p>
                        推荐宾馆
                    </p>
                </div>
                <div class="table04_body">
                    <div id='scrollDiv' style='float: left; width: 240px; height: 173px; overflow: hidden;'>
                        <uc2:home_hotel_2 ID="home_hotel_21" ModuleCode='recommend' runat="server" />

                        <script src="/js/jQuery.Times.js" type="text/javascript"></script>

                        <script type="text/javascript">
                            function AutoScroll(obj) {
                                $(obj).find("ul:first").animate({
                                    marginTop: "-52px"
                                }, 1000, function() {
                                    $(this).css({ marginTop: "5px" }).find("li:first").appendTo(this);
                                });
                            }
                            function StartTimer() {
                                $('#scrollDiv').everyTime(2800, 'mytimer', function() {
                                    AutoScroll("#scrollDiv");
                                });
                            }
                            $(document).ready(function() {
                                if ($('#scrollDiv ul li').length > 3) {
                                    StartTimer();
                                    $('#scrollDiv').bind('mouseover', function() {
                                        $('#scrollDiv').stopTime('mytimer');
                                    });
                                    $('#scrollDiv').bind('mouseout', function() {
                                        StartTimer();
                                    });
                                }
                            });
                        </script>

                    </div>
                    <div class="clear">
                    </div>
                    <div class="more">
                        <a href="/hotel/default.aspx">更多</a></div>
                    <div class="clear">
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
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
        </div>
        <div class="clear">
        </div>
        <!--主体 结束-->
    </div>
    </form>
</asp:Content>
