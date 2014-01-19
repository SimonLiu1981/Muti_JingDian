<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="detail.aspx.cs" Inherits="dx177.WebUI.web.Sites.detail" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="navigation">
            <span>当前位置：</span><a title='177丹霞' href="http://www.177dx.com/">177丹霞</a><span>»</span><a
                title='177丹霞' href="/Sites/default.aspx">丹霞风景</a><span>»</span>
            <%= n.Title %>
        </div>
        <div class="main_left">
            <!--主体 开始-->
            <div class="blank05">
            </div>
            <div class="news_content">
                <div class="art_title">
                    <ul>
                        <li>
                            <h1>
                                <%= n.Title %></h1>
                        </li>
                        <li><span class="rightmar5"></span><span class="rightmar5">浏览次数：
                            <%= n.Viewtimes%></span><span class="rightmar5">发表时间：<%=  n.CreateDate.ToString("yyyy-MM-dd") %></span>发布人：丹霞山旅游订房</li>
                    </ul>
                </div>
                <div id="posts_news_content" class="art_main">
                    <%=n.Content %>
                </div>
                <div style="margin-top: 10px" class="artbottom">
                    <div id="mark0" onmouseover="this.style.backgroundPosition='0 0'" onmouseout="this.style.backgroundPosition='-189px 0'"
                        onclick="return  AddDigg(true,<%=n.Seqno %>);">
                        <span id="barnum1"><span id="Comment_good_<%=n.Seqno %>">
                            <%=n.Good %></span></span></div>
                    <div id="mark1" onmouseover="this.style.backgroundPosition='-567px 0'" onmouseout="this.style.backgroundPosition='-378px 0'"
                        onclick="return AddDigg(false,<%=n.Seqno %>);">
                        <span id="barnum2"><span id="Comment_bad_<%=n.Seqno %>">
                            <%=n.Bad %></span></span></div>
                </div>
                <div class="clear">
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
            <div class="table03">
                <div class="table03_title">
                    <p>
                        旅游问答</p>
                    <div class="more">
                        <a href="/questions/default.aspx" >更多</a></div>
                </div>
                <div class="table03_body">
                    <ucMy:home_questions ID="home_questions1" runat="server" />
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
            <div class="table05">
                <div class="table05_title">
                    <p class='zuche'>
                        旅游租车</p>
                </div>
                <div class="table05_body">
                    <ucMy:right_hireCar ID="right_hireCar1" runat="server" MaxCount="4" />
                    <div class="more">
                        <a href="/hirecar/default.aspx">更多</a></div>
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
