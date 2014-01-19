<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="comments.aspx.cs" Inherits="dx177.WebUI.web.restaurant.comments" %>

<%@ Register Src="../usercontrols/home_hotel_2.ascx" TagName="home_hotel_2" TagPrefix="uc2" %>
<%@ Register Src="../usercontrols/right_hireCar.ascx" TagName="right_hireCar" TagPrefix="uc5" %>
<%@ Register Src="../../usercontrols/UCJqueryRaty.ascx" TagName="UCJqueryRaty" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="/Plugin/Jquery.tools/jquery.tools.min.js" type="text/javascript"></script>
    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
    
<script type="text/javascript" src="/ajaxpro/prototype.ashx"></script>
<script type="text/javascript" src="/ajaxpro/core.ashx"></script>
<script type="text/javascript" src="/ajaxpro/converter.ashx"></script>
<script type="text/javascript" src="/ajaxpro/dx177.WebUI.web.restaurant.comments,dx177.WebUI.ashx?id=1"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="main">
        <div class="navigation">
            <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span><a href="/restaurant/default.aspx" >饭店预订</a>  <span>»</span>    <%=Rest.Title%>
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

                       

                        function SumitComment() {
                            //imgtijiaonow
                            var score1 = parseFloat(GetRatyValue('<%=UCJqueryRaty1.ClientID %>'));
                            var score2 =parseFloat(GetRatyValue('<%=UCJqueryRaty2.ClientID %>'));
                            var score3 = parseFloat(GetRatyValue('<%=UCJqueryRaty3.ClientID %>'));
                            var score4 = parseFloat(GetRatyValue('<%=UCJqueryRaty4.ClientID %>'));
                            var content = $('#txtComments').val();
                             
                            var pguid = '<%=Rest.Guid %>';
                            if ($('#txtComments').val() == '') {
                                alert("请填写评论内容！");
                                return false;
                            }
                            
                            //dx177.WebUI.web.restaurant.comments.SubmitComment(score1, score2, score3, score4, content, pguid, $('#<%=txtUserName.ClientID %>').val(), callbackSubmitComment);
                            $('#imgtijiao').hide();
                            $('#imgtijiaonow').show();
                            
                        }
                        function callbackSubmitComment(res) {
                            
                            $('#imgtijiao').show();
                            $('#imgtijiaonow').hide();
                            alert("已经提交，待管理员审核后，生效！");
                            location.href = location.href;
                        }
                                            
                    </script>

                </div>
                <h2 class="cate_title">
                    <%=Rest.Title %>
                </h2>
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
            <div class="cate_info link01">
                <ul class="tit">
                    <li><a href="/restaurant_<%=seqno %>.aspx">特色菜普</a></li>
                    <li class="on"><a href="/restaurantcomments_<%=seqno %>.aspx">用户点评</a></li>
                </ul>
                <div style="width: 698px" class="zyleft_main">
                    <div class="zyleft_head">
                        <span>共有<%=CommentCount %>条点评</span>
                        <div class='fright' style=' margin-right:5px;'> <a href="#txtComments">我要评论</a> </div>
                    </div>
                    <asp:ListView ID="lvComment" runat="server" OnPagePropertiesChanging="lvComment_PagePropertiesChanging">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <!--点评详细内容开始-->
                            <div class="zyleft_tr2">
                                <div class="trsp2">
                                    <ul>
                                        <li class="li01">
                                            <%#DataBinder.Eval(Container.DataItem,"CREATOR")%>
                                            于
                                            <%#DataBinder.Eval(Container.DataItem, "CREATEDATE")%>
                                            发表 </li>
                                        <li>
                                            <!--酒店评分开始 -->
                                            <ul class="pingf_itemli">
                                                <li><span>口味：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%></li>
                                                <li><span>环境：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%></li>
                                                <li><span>服务：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%></li>
                                                <li><span>卫生：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score4").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score4").ToString()%></li></ul>
                                            <!--酒店评分结束-->
                                        </li>
                                        <li>评论：<%#DataBinder.Eval(Container.DataItem, "Content")%>
                                        </li>
                                        <li class="li04"><span class="shang"></span><span class="zhong">
                                            <div class="text04">
                                                回复：<%#DataBinder.Eval(Container.DataItem, "ReplyContent")%>
                                            </div>
                                        </span><span class="xia"></span></li>
                                        <li class="li04">
                                            <div class="row_updown">
                                                这条点评对你： <a style="cursor: pointer" title="点击评定" onclick="javascript:AddDigg(<%#DataBinder.Eval(Container.DataItem, "seqno")%>, true);">
                                                    <img border="0" src="/web/img/v3_up.gif" width="15" height="16">
                                                    有用(<span id="Comment_good_<%#DataBinder.Eval(Container.DataItem, "seqno")%>"><%#DataBinder.Eval(Container.DataItem, "Good")%></span>)</a>
                                                <a style="cursor: pointer" title="点击评定" onclick="javascript:AddDigg(<%#DataBinder.Eval(Container.DataItem, "seqno")%>, false);">
                                                    <img border="0" src="/web/img/v3_down.gif" width="15" height="16">
                                                    无用(<span id="Comment_bad_<%#DataBinder.Eval(Container.DataItem, "seqno")%>"><%#DataBinder.Eval(Container.DataItem, "Bad")%></span>)</a>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <div class="zyleft_tr3">
                                <div class="trsp2">
                                    <ul>
                                        <li class="li01">
                                            <%#DataBinder.Eval(Container.DataItem,"CREATOR")%>
                                            于
                                            <%#DataBinder.Eval(Container.DataItem, "CREATEDATE")%>
                                            发表 </li>
                                        <li>
                                            <!--酒店评分开始 -->
                                            <ul class="pingf_itemli">
                                                <li><span>口味：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%></li>
                                                <li><span>环境：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%></li>
                                                <li><span>服务：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%></li>
                                                <li><span>卫生：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score4").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score4").ToString()%></li></ul>
                                            <!--酒店评分结束-->
                                        </li>
                                        <li>评论：<%#DataBinder.Eval(Container.DataItem, "Content")%>
                                        </li>
                                        <li class="li04"><span class="shang"></span><span class="zhong">
                                            <div class="text04">
                                                回复：<%#DataBinder.Eval(Container.DataItem, "ReplyContent")%>
                                            </div>
                                        </span><span class="xia"></span></li>
                                        <li class="li04">
                                            <div class="row_updown">
                                                这条点评对你： <a style="cursor: pointer" title="点击评定" href="javascript:;" onclick="javascript:AddDigg(<%#DataBinder.Eval(Container.DataItem, "seqno")%>, true);">
                                                    <img border="0" src="/web/img/v3_up.gif" width="15" height="16">
                                                    有用(<span id="Comment_good_<%#DataBinder.Eval(Container.DataItem, "seqno")%>"><%#DataBinder.Eval(Container.DataItem, "Good")%></span>)</a>
                                                <a href="javascript:;"  style="cursor: pointer" title="点击评定" onclick="javascript:AddDigg(<%#DataBinder.Eval(Container.DataItem, "seqno")%>, false);">
                                                    <img border="0" src="/web/img/v3_down.gif" width="15" height="16">
                                                    无用(<span id="Comment_bad_<%#DataBinder.Eval(Container.DataItem, "seqno")%>"><%#DataBinder.Eval(Container.DataItem, "Bad")%></span>)</a>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </AlternatingItemTemplate>
                    </asp:ListView>
                    <!--点评详细内容结束-->
                    <!--分页开始-->
                    <div style="float: right" class="page_link_full">
                        <asp:DataPager ID="DataPager1" PagedControlID="lvComment" runat="server" PageSize="3"
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
                    <!--分页结束-->
                    <div style="height: 0px; clear: both; overflow: hidden">
                    </div>
                    <div style="height: 0px; clear: both; overflow: hidden">
                    </div>
                    <!--验证开始 -->
                    <!-- 验客结束 -->
                    <div style="height: 0px; clear: both; overflow: hidden">
                    </div>
                </div>
            </div>
            <div class="fbdp" >
                <div class="fbdp_top">
                    对 <span class="ti"> <%=Rest.Title %> </span>发表点评<span class="bi"> (<span class="xing">*</span>为必填项)</span>
                </div>
                <div class="fbdp_cen">
                    <input id="txtCityId" value="321" type="hidden" name="txtCityId">
                    <div class="hh">
                        <dl>
                            口味
                            <div id="divkouwei">                                  
                                 <uc1:UCJqueryRaty ID="UCJqueryRaty1" runat="server" />
                            </div>
                            
                        </dl>
                        <dl>
                            环境
                            <div id="divhuanjing">
                                 <uc1:UCJqueryRaty ID="UCJqueryRaty2" runat="server" />
                            </div>
                        </dl>
                        <dl>
                            服务
                            <div id="divfuwu">
                                <uc1:UCJqueryRaty ID="UCJqueryRaty3" runat="server" />
                            </div>
                             
                        </dl>
                        <dl>
                            卫生
                            <div id="divWeiSheng">
                                <uc1:UCJqueryRaty ID="UCJqueryRaty4" runat="server" />
                            </div>                            
                        </dl>
                    </div>
                    
                    <div class="pj" style='display:none'>
                        <span class="xing">*</span> 你的评价： <span id="rblGrade">
                            <input id="rblGrade_0" value="3" checked type="radio" name="rblGrade"><label for="rblGrade_0">好评</label><input
                                id="rblGrade_1" value="2" type="radio" name="rblGrade"><label for="rblGrade_1">中评</label><input
                                    id="rblGrade_2" value="1" type="radio" name="rblGrade"><label for="rblGrade_2">差评</label></span>
                    </div>
                    <div class="yh">                        
                        <textarea id="txtComments" name="txtComments" ></textarea>
                    </div>
                    <div class="rj" style="margin-top:5px">
                         <span class="yu">用户名：</span> 
                        <asp:TextBox ID="txtUserName" Width="120px" runat="server"></asp:TextBox>
                    </div>
                    <div class="tj">
                        
                    </div>
                    <img style="cursor: pointer" id="imgtijiao" class="pl" title="提交点评" onclick="return SumitComment()"
                        alt="提交点评" src="/web/img/bu_01.gif"/>
                    <img style="display: none" id="imgtijiaonow" class="pl" title="提交点评中，请稍候..." alt="提交点评中，请稍候..."
                        src="/web/img/tijiaonow.gif"/>
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
                    <uc5:right_hireCar ID="right_hireCar1" runat="server"  MaxCount="4"/>
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
