<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="detail.aspx.cs" Inherits="dx177.WebUI.web.questions.Qdetail" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
<script type="text/javascript" src="../../Plugin/dingcai/dingcai.js"></script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <form id="form1" runat="server">
    <!--头部 结束-->
    <div class="main">
        <!--主体 开始-->
        <div class="main_left">
            <div class="navigation">
                <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span></span><a href="/questions/default.aspx" >疑问解答</a>  <span>»</span>    <%=q.Title  %>
            </div>
            <div class="question_detail">
                <h3>
                    <span class="question_title">
                        <%=q.Title  %>
                    </span><span class="question_time">2011-2-5 2:41:34</span>
                </h3>
                <ul>
                    <li class="bring">所属类型：<a href="/questions/?Qtype=<%=q.Qtype%>"><%=strQuestion%></a>
                        | 浏览次数：
                         <span viewtimes_add_guid='<%=q.Guid %>'>loading</span>
                        | 日期:
                        <%=q.CreateDate.ToString("yyyy-MM-dd")   %>
                    </li>
                    <li class="zctw">
                        <%=q.Content   %>
                    </li>
                </ul>
                <div class="blank05">
                </div>
                <!--采纳意见-->
                <%=strGoodQuetion %>
                <!--采纳意见-->
                <div class="blank05">
                </div>
                <h3>
                    <span class="question_allreply">[所有回答]</span>
                </h3>
                <ul>
                    <asp:Repeater ID="rpList" runat="server">
                        <ItemTemplate>
                            <li class="bring"><span style="color: #000">回答者：<%# DataBinder.Eval(Container.DataItem, "CREATOR")%>
                            </span><span style="padding: 0 5px; color: #000"></span><span style="padding: 0 5px;
                                color: #000">时间：<%# DataBinder.Eval(Container.DataItem, "CREATEDATE")%>
                            </span>
                                <div style="float: right;">
                                    这条点评对你： <a style="cursor: pointer" title="点击评定"
                                        href="javascript:;" id='asupport_<%# DataBinder.Eval(Container.DataItem, "seqno")%>'>
                                        <img border="0" src="/web/img/v3_up.gif" width="15" height="16">
                                        有用(<span support_add_guid='<%#DataBinder.Eval(Container.DataItem, "guid") %>'tagID='asupport_<%# DataBinder.Eval(Container.DataItem, "seqno")%>'>0</span>)</a>
                                    <a style="cursor: pointer" title="点击评定"  id='aoppose_<%# DataBinder.Eval(Container.DataItem, "seqno")%>'
                                        href="javascript:;">
                                        <img border="0" src="/web/img/v3_down.gif" width="15" height="16">
                                        无用(<span tagID='aoppose_<%# DataBinder.Eval(Container.DataItem, "seqno")%>' oppose_add_guid='<%#DataBinder.Eval(Container.DataItem, "guid") %>'>0</span>)</a>
                                </div>
                            </li>
                            <li class="zctw">
                                <%# DataBinder.Eval(Container.DataItem, "Content")%>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <div class="blank05">
                </div>
                <h3>
                    <span class="question_allreply">我来回答</span>
                </h3>
                <ul>
                    <li class='wyhd1'>
                        <textarea id="txtMyAnswer" class='content' runat="server" name="txtMyAnswer"></textarea>
                        <asp:Button ID="btnAnswer" runat="server" class="anniu" Text="我来回答" OnClick="btnAnswer_Click" />
                    </li>
                </ul>
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
                        <ucMy:home_hotel_2 ID="home_hotel_21" ModuleCode='recommend'  runat="server" />
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
                     <ucMy:right_restaurant1 ID="right_restaurant11" MaxCount=4  runat="server" />
                    <div class="more">
                        <a href="/restaurant/" target="_blank">更多</a></div>
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
                    <ucMy:right_hireCar ID="right_hireCar1" runat="server"  MaxCount="4"/>
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
