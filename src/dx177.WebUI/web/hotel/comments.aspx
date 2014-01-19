<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="True"
    CodeBehind="comments.aspx.cs" Inherits="dx177.WebUI.web.hotel.comments" Title="无标题页" %>

<%@ Register Src="/web/usercontrols/home_hotel_2.ascx" TagName="home_hotel_2" TagPrefix="uc2" %>
<%@ Register Src="/web/usercontrols/home_questions.ascx" TagName="home_questions"
    TagPrefix="uc3" %>
<%@ Register Src="/web/usercontrols/home_new.ascx" TagName="home_new" TagPrefix="uc4" %>
<%@ Register Src="/web/usercontrols/right_hireCar.ascx" TagName="right_hireCar" TagPrefix="uc5" %>
<%@ Register Src="../usercontrols/right_restaurant1.ascx" TagName="right_restaurant1"
    TagPrefix="uc1" %>
<%@ Register Src="/usercontrols/UCJqueryRaty.ascx" TagName="UCJqueryRaty" TagPrefix="uc1" %>
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

    <script type="text/javascript" language="javascript">
        function AddDigg(seqno, flag) {
            var res = dx177.WebUI.web.restaurant.comments.AddDigg(flag, seqno);
            var resObj = (new Function("return " + res.value))();
            var vv = 0;
            if (resObj.Result == 1) {
                if (flag) {
                    vv = parseInt($('#Comment_good_' + seqno).html());
                    vv++;
                    $('#Comment_good_' + seqno).html(vv);

                }
                else {
                    vv = parseInt($('#Comment_bad_' + seqno).html());
                    vv++;
                    $('#Comment_bad_' + seqno).html(vv);
                }
            }
            else {
                alert(resObj.Message);
            }
        }

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
            
            dx177.WebUI.web.restaurant.comments.SubmitComment(score1, score2, score3, score4, content, pguid, $('#<%=txtUserName.ClientID %>').val(), callbackSubmitComment);
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
   
   
          <div class="navigation">
                <span>当前位置：</span><a title='177丹霞' href="/">177丹霞</a><span>»</span><a title='酒店预定' href="/hotel/default.aspx">酒店预定</a><span>»</span>  <%=Rest.Name%>评论
        </div>   
        <!--主体 开始-->
        <div class="main_left">
             
            <div class="hotel_tit">
                <span class="zuo"></span>
                <div class="info">
                    <div class="biaoti link01">
                        <h2>
                            <%=Rest.Name%>
                        </h2>
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
                        <%=Rest.Biz%>
                    </p>
                </div>
                <span class="you"></span>
            </div>
            <div class="hotel_info link01">
                <ul class="tit">
                    <li><a title="点击查看酒店图片" href="/hotel_<%=this.Seqno %>.html">概括及房价</a> </li>
                    <li><a href="/hotelpics_<%=this.Seqno %>.html">酒店图片</a></li>
                    <li class="on"><a title="点击查看客人点评" href="/hotelcomments_<%=this.Seqno %>.html">客人点评</a>
                    </li>
                </ul>
                <div style="height: 0px; clear: both; overflow: hidden">
                </div>
                <div style="width: 698" class="zyleft_main">
                    <div class="zyleft_head">
                        <span>此酒店共有<%=CommentCount%>条点评</span>
                        <!--<dl>
                                <dt>查看点评：</dt>
                                <dt>
                                    <select id="ddlDianPing" onchange="jsSort(this.value);" name="ddlDianPing">
                                        <option selected value="1">最新点评</option>
                                        <option value="2">图片点评</option>
                                        <option value="3">好评</option>
                                        <option value="4">中评</option>
                                        <option value="5">差评</option>
                                    </select>
                                </dt>
                            </dl>-->
                    </div>
                    <div class="zyleft_tr1">
                        <div class="pingf">
                            <span class="title">酒店综合评分：</span>
                            <!--酒店评分开始 -->
                            <ul id="ulPingji" class="pingf_ul">
                                <li><span>设施：</span><span class="c-value-no c-value-<%=myScore.CssScore1 %>" title="<%=myScore.ScoreTitle1 %>"></span><%=myScore.ScoreTitle1 %></li>
                                <li><span>交通：</span><span class="c-value-no c-value-<%=myScore.CssScore2 %>" title="<%=myScore.ScoreTitle2 %>"></span><%=myScore.ScoreTitle2 %></li>
                                <li><span>卫生：</span><span class="c-value-no c-value-<%=myScore.CssScore3 %>" title="<%=myScore.ScoreTitle3 %>"></span><%=myScore.ScoreTitle3 %></li>
                                <li><span>性价比：</span><span class="c-value-no c-value-<%=myScore.CssScore4 %>" title="<%=myScore.ScoreTitle4 %>"></span><%=myScore.ScoreTitle4 %></li></ul>
                            </ul>
                            <!--酒店评分结束-->
                        </div>
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
                                                <li><span>设施：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%></li>
                                                <li><span>交通：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%></li>
                                                <li><span>卫生：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%></li>
                                                <li><span>性价比：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
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
                                                <li><span>设施：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score1").ToString()%></li>
                                                <li><span>交通：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score2").ToString()%></li>
                                                <li><span>卫生：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
                                                    title="<%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%>"></span><%#DataBinder.Eval(Container.DataItem,"Score3").ToString()%></li>
                                                <li><span>性价比：</span><span class="c-value-no c-value-<%#DataBinder.Eval(Container.DataItem,"Score1").ToString().Replace(".", "d")%>"
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
                                                <a href="javascript:;" style="cursor: pointer" title="点击评定" onclick="javascript:AddDigg(<%#DataBinder.Eval(Container.DataItem, "seqno")%>, false);">
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
            <div class="fbdp">
                <div class="fbdp_top">
                    对 <span class="ti">
                        <%=Rest.Name%>
                    </span>发表点评<span class="bi"> (<span class="xing">*</span>为必填项)</span>
                </div>
                <div class="fbdp_cen">
                    <input id="txtCityId" value="321" type="hidden" name="txtCityId">
                    <div class="hh">
                        <dl>
                            设施
                            <div id="divkouwei">
                                <uc1:UCJqueryRaty ID="UCJqueryRaty1" runat="server" />
                            </div>
                        </dl>
                        <dl>
                            交通
                            <div id="divhuanjing">
                                <uc1:UCJqueryRaty ID="UCJqueryRaty2" runat="server" />
                            </div>
                        </dl>
                        <dl>
                            卫生
                            <div id="divfuwu">
                                <uc1:UCJqueryRaty ID="UCJqueryRaty3" runat="server" />
                            </div>
                        </dl>
                        <dl>
                            性价比
                            <div id="divWeiSheng">
                                <uc1:UCJqueryRaty ID="UCJqueryRaty4" runat="server" />
                            </div>
                        </dl>
                    </div>
                    <div class="pj" style='display: none'>
                        <span class="xing">*</span> 你的评价： <span id="rblGrade">
                            <input id="rblGrade_0" value="3" checked type="radio" name="rblGrade"><label for="rblGrade_0">好评</label><input
                                id="rblGrade_1" value="2" type="radio" name="rblGrade"><label for="rblGrade_1">中评</label><input
                                    id="rblGrade_2" value="1" type="radio" name="rblGrade"><label for="rblGrade_2">差评</label></span>
                    </div>
                    <div class="yh">
                        <textarea id="txtComments" name="txtComments"></textarea>
                    </div>
                    <div class="rj" style="margin-top: 5px">
                        <span class="yu">用户名：</span>
                        <asp:TextBox ID="txtUserName" Width="80px" runat="server"></asp:TextBox>
                    </div>
                    <div class="tj">
                    </div>
                    <img style="cursor: pointer" id="imgtijiao" class="pl" title="提交点评" onclick="return SumitComment()"
                        alt="提交点评" src="/web/img/bu_01.gif" />
                    <img style="display: none" id="imgtijiaonow" class="pl" title="提交点评中，请稍候..." alt="提交点评中，请稍候..."
                        src="/web/img/tijiaonow.gif" />
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
                    <uc1:right_restaurant1 ID="right_restaurant11" MaxCount="5" runat="server" />
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
   
    </form>
</asp:Content>
