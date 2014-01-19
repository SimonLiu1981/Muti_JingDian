<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true" CodeBehind="Issue.aspx.cs" Inherits="dx177.WebUI.web.Issue" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script type="text/javascript" src="/ajaxpro/prototype.ashx"></script>
    <script type="text/javascript" src="/ajaxpro/core.ashx"></script>
    <script type="text/javascript" src="/ajaxpro/converter.ashx"></script>
    <script type="text/javascript" src="/ajaxpro/dx177.WebUI.web.questions.Qdetail,dx177.WebUI.ashx"></script>

    <script type="text/javascript">

        function AddDigg(seqno,flag) {

            var res = dx177.WebUI.web.questions.Qdetail.AddDigg(flag, seqno);
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
    </script>
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<form id="form1" runat="server">
    <!--头部 结束-->
    <div class="main">
        <!--主体 开始-->
        <div class="main_left">
            <div class="navigation">
                <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span></span>    <%=IssueInfo.Title%>
            </div>
            <div class="question_detail">
                <h3>
                    <span class="question_allreply">
                        <%=IssueInfo.Title  %>
                    </span><span class="question_time"> </span>
                </h3>
                
               
                
                <ul>
                    <li class="bring"> </li>
                    <li class="zctw">
                        <%=IssueInfo.Content%>
                    </li>
                </ul>
                <div class="blank05">
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
