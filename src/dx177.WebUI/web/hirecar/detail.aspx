<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="detail.aspx.cs" Inherits="dx177.WebUI.web.hirecar.detail" %>

<%@ Register Src="../usercontrols/home_new.ascx" TagName="home_new" TagPrefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="navigation">
            <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span> <a title='177丹霞'
                href="/hirecar/default.aspx">旅游租车</a><span>»</span><%=car.Title %>
        </div>
        <!--主体 开始-->
        <div class="main_left">
            <div class="blank05">
            </div>
            <div class="zuche_info link01">
                <!--图片-->
                <div id="divMap" class="show_pic">
                    <div class="top">
                        <img id="imgBig" src="<%=car.Logo %>" width="286" height="286"></div>
                </div>
                <h2 class="zuche_title">
                    <%=car.Title %>
                </h2>
                <div class='info'>
                    <dl>
                        <dt></dt>
                        <dd>
                            联系电话：<%=car.Telnumber %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            营运范围：
                            <%=car.Range %></dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            人气：<%=car.Viewtimes %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            车型：<%=car.Cartype %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            坐位数：<%=car.Personcount %>
                        </dd>
                    </dl>
                    <dl>
                        <dt></dt>
                        <dd>
                            价格：<%=car.Price %></dd>
                    </dl>
                </div>
                <!--酒店房型-->
            </div>
            <div class="hotel_info link01">
                <ul class="tit">
                    <li class="on">详细说明</li>
                </ul>
                <div class="zucheleft1_body">
                    <p>
                        <%=car.Content %></p>
                </div>
            </div>
        </div>
        <div class="main_right">
             
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
            <div class="table05">
                <div class="table05_title">
                    <p class='restaurant'>
                        饭店预订</p>
                </div>
                <div class="table05_body">
                    <ucMy:right_restaurant1 ID="right_restaurant11" MaxCount="3" runat="server" />
                    <div class="more">
                        <a href="/restaurant/default.aspx" target="_blank">更多</a></div>
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
        <div class="clear">
        </div>
        <!--主体 结束-->
    </div>
</asp:Content>
