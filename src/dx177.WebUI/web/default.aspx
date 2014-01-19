<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="default.aspx.cs" Inherits="dx177.WebUI.web._default" %>

<%@ Register Src="/web/usercontrols/home_hotel_1.ascx" TagName="home_hotel_1" TagPrefix="uc1" %>
<%@ Register Src="/usercontrols/UCJqueryRaty.ascx" TagName="UCJqueryRaty" TagPrefix="uc6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="main">
        <!--主体 开始-->
        <div class="main_left">
            <div class="blank05">
            </div>
            <div class="banner01">

                <script type="text/javascript" src="/Plugin/jquery.smallslider/jquery-1.3.2.min.js"></script>

                <script type="text/javascript" src="/Plugin/jquery.smallslider/jquery.smallslider.js"></script>

                <link type="text/css" href="/Plugin/jquery.smallslider/smallslider_2.css" rel="stylesheet">

                <script type="text/javascript">
                    $(document).ready(function() {
                        $('#flashbox').smallslider({ showButtons: true, showText: true, time: '5000',
                            switchEffect: 'ease', switchEase: 'easeOutCirc', switchPath: 'up', textSwitch: 1, textAlign: 'left'
                        });
                    });
                </script>

                <div id="flashbox" class="smallslider">
                    <ul class="slider slider2" id="idSlider2">
                        <li><a href="#" title="阳元山">
                            <img src="/web/img/ad1.jpg" border="0" /></a></li>
                        <li><a href="#">
                            <img src="/web/img/ad2.jpg" border="0" /></a></li>
                        <li><a href="#">
                            <img src="/web/img/ad3.jpg" border="0" /></a></li>
                        <li><a href="#">
                            <img src="/web/img/ad4.jpg" border="0" /></a></li>
                    </ul>
                </div>
            </div>
            <div class="blank05">
            </div>
            <div style="width: 700px">
                <ul class="css-tabs04" style="position: relative">
                    <li><a href="#">特色宾馆</a></li>
                    <li><a id='A1' href="#">推荐宾馆</a></li>
                    <li id='Li1' style='float: right; background: none; border: 0px; position: relative;
                        text-align: right; padding-right: 3px; color: #ff7e00; cursor: pointer;' onclick="location.href='/hotel/default.aspx'">
                        更多 </li>
                </ul>
                <div class="css-panes04">
                    <div class="out">
                        <uc1:home_hotel_1 ID="home_hotel_11" ModuleCode="special" runat="server" />
                        <div class="clear">
                        </div>
                    </div>
                    <div class="out">
                        <uc1:home_hotel_1 ID="home_hotel_12" ModuleCode="recommend" runat="server" />
                        <div class="clear">
                        </div>
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>

            <script type="text/javascript">
                $(document).ready(function() {
                    $("ul.css-tabs02").tabs("div.css-panes02 > div", { "event": "mouseover", initialIndex: 0, onBeforeClick: function() {
                        if ($(this).attr('id') == 'formoreli' || $(this).attr('id') == 'formorelia') {
                            return false;

                        }
                    }
                    });

                    $("ul.css-tabs04").tabs("div.css-panes04 > div", { "event": "mouseover", initialIndex: 0, onBeforeClick: function() {
                        if ($(this).attr('id') == 'formoreli' || $(this).attr('id') == 'formorelia') {
                            return false;

                        }
                    }
                    });
                });
    
            </script>

            <div class="blank05">
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
                        <ucMy:home_hotel_2 ID="home_hotel_21" ModuleCode='recommend' runat="server" />

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
        <div class="blank05 fleft" style="width: 960px">
        </div>
        <div class='ad960'>
            <a href="#">
                <img src='/web/img/ad960.jpg' /></a>
        </div>
        <div class="main_left">
            <div class="blank05">
            </div>
            <div style="width: 700px; margin: 2px auto;">
                <h1 class="table01_title">
                    <p>
                        推荐饭店</p>
                </h1>
                <div class="table01_body">
                    <asp:Repeater ID="rptHoteltj" runat="server">
                        <HeaderTemplate>
                            <ul class="index_jd">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="pichotel"><a href="/Restaurant_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.aspx">
                                <img align="left" alt='<%#DataBinder.Eval(Container.DataItem, "title") %>' title='<%#DataBinder.Eval(Container.DataItem, "title") %>'
                                    src="<%# DataBinder.Eval(Container.DataItem, "logo") %>" width="100" height="75">
                            </a><a class="gray_blod" href="/Restaurant_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.aspx"
                                title='<%#DataBinder.Eval(Container.DataItem, "title") %>'>
                                <%#dx177.FrameWork.StringUtil.CutString(DataBinder.Eval(Container.DataItem, "title").ToString(), 14)%></a>
                                <br>
                                <span>人气：<b><%# DataBinder.Eval(Container.DataItem, "viewtimes") %></b><br>
                                    综合评分： <span class="c-value-no c-value-<%# SocreToCssStr(DataBinder.Eval(Container.DataItem, "avgscore")) %>"
                                        title="<%# DataBinder.Eval(Container.DataItem, "avgscore") %>/5.0"></span>
                                    <%# DataBinder.Eval(Container.DataItem, "avgscore") %></span></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                    <asp:Repeater ID="rptAll" runat="server">
                        <HeaderTemplate>
                            <ul class="index_jdwzlist">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li>
                                <p>
                                    <font color="black">评论：</font><b><%# DataBinder.Eval(Container.DataItem, "scount1")%></b>
                                </p>
                                <a href="/Restaurant_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.aspx">
                                    <%#DataBinder.Eval(Container.DataItem, "title") %></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                    <div class="clear">
                    </div>
                </div>
                <div class="table01_footer">
                </div>
            </div>
            <div class="blank05">
            </div>
            <div style="width: 700px;">
                <div class="ol_bd">
                    <div class="title">
                        <h2>
                            丹霞山景区欣赏</h2>
                        <span><a class="more" href="/Sites/default.aspx">更多</a></span></div>
                    <div id="ydzxsj" class="content">
                        <asp:Repeater ID="rptFJ" runat="server">
                            <HeaderTemplate>
                                <ul class="ol_clist">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <li><a href="/Sites_<%#DataBinder.Eval(Container.DataItem, "seqno") %>.html" target="_blank">
                                    <img class="pic" src="<%#DataBinder.Eval(Container.DataItem, "logo") %>" width="120"
                                        height="90"></a><br>
                                    <div class="c_name">
                                        <a href="/Sites_<%#DataBinder.Eval(Container.DataItem, "seqno") %>.html" target="_blank"
                                            title='<%#DataBinder.Eval(Container.DataItem, "title") %>'>
                                            <%#dx177.FrameWork.StringUtil.CutString(DataBinder.Eval(Container.DataItem, "title").ToString(),17) %></a></div>
                                    <div class="xiaofei">
                                        人气：<%#DataBinder.Eval(Container.DataItem, "viewtimes") %></div>
                                </li>
                            </ItemTemplate>
                            <FooterTemplate>
                                </ul>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
        <div class="main_right">
            <div class="blank05">
            </div>
            <div class="table05">
                <div class="table05_title">
                    <p class='news'>
                        旅游攻略</p>
                </div>
                <div class="table05_body">
                    <ucMy:home_new ID="home_new1" NewsTypeCode="LYGL"  OrderBy="ViewTimes" MaxCount="8" runat="server" />
                    <div class="more">
                        <a href="/news/list_lygl.aspx">更多</a></div>
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
                    <ucMy:right_hireCar ID="right_hireCar1" runat="server" MaxCount="4" />
                    <div class="more">
                        <a href="/hirecar/default.aspx" target="_blank">更多</a></div>
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
    </div>
   
</asp:Content>
