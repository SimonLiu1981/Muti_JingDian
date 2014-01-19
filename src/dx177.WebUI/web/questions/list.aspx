<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.web.questions.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
    
    
        function SetStatus(sval) {
               // $("#txtsearchPrice").attr('value',sval) ;
               var Qtype='<%=this.Qtype%>' ;
               window.location.href = "/questions/default.aspx?qtype=" + Qtype + "&status=" + sval;
               
        }
    
        function SetQtype(sval) {
                    var Status='<%=this.Status%>' ; 
                    window.location.href="/questions/default.aspx?qtype="+sval +"&status="+Status;
        }
        
        function addclass()
        {
            var sQtype='<%=this.Qtype%>' ; 
            var sHsataus='<%=this.Status%>' ; 
            $("#Qtype").removeClass("here");
            $("#Qtype"+sQtype).addClass("here") ;
            $("#Hsataus").removeClass("here");
            $("#Hsataus"+sHsataus).addClass("here") ;
        }
    </script>


    <!--头部 结束-->
    <div class="main">

        <div class="navigation">
            <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span><a href="/questions/default.aspx" >疑问解答</a>
        </div>
        <div class="main_left">
            <ul class="css-tabs03">
                <li><a class="current">查询条件</a></li>
            </ul>
            <div class="css-panes03">
                <div class="out">
                    <div class="search_main">
                        <p>
                            <b>问题类型：</b><a class="here" href="#" id="Qtype" onclick="javascript:SetQtype('');">全部</a>
                            <asp:Repeater ID="rpQtype" runat="server">
                                <ItemTemplate>
                                    <a href="#" id='Qtype<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>' onclick="javascript:SetQtype('<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>');">
                                        <%# DataBinder.Eval(Container.DataItem, "tag_name")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                        <p class="heightlight">
                            <b>问题状态：</b><a class="here" onclick="javascript:SetStatus('');" id="Hsataus" href="#">全部</a>
                            <a href="#" onclick="javascript:SetStatus('0');" id="Hsataus0">待解决</a> <a href="#"
                                onclick="javascript:SetStatus('1');" id="Hsataus1">有回答</a> <a href="#" onclick="javascript:SetStatus('2');"
                                    id="Hsataus2">已解决</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
            <div style="margin-top: 10px" class="question">
                <h1>
                    <span class="fright02 link02"><a href="/member-editqueston.aspx">我要提问</a></span>
                </h1>
                <ul id="tablepage">
                    <table border="0" cellspacing="0" cellpadding="0" width="698">
                        <tbody>
                            <tr>
                                <td style="border-bottom: #ccc 1px solid; text-align: left; color: #9c9b9a" height="26"
                                    valign="bottom" background="/web/img/banner01.gif">
                                    <table border="0" cellspacing="0" cellpadding="0" width="698" height="26">
                                        <tbody>
                                            <tr>
                                                <td style="padding-left: 20px" width="94">
                                                    类型
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid; padding-left: 20px" width="252">
                                                    问题
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid; padding-left: 20px" width="65">
                                                    浏览次数
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid; padding-left: 10px" width="74">
                                                    提问日期
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid" width="40" align="middle">
                                                    回答数
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid" width="58" align="middle">
                                                    状态
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td bgcolor="#ffffff" height="4">
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: left; line-height: 28px" valign="top">
                                    <table border="0" cellspacing="0" cellpadding="0" id='questionlisttable'>
                                        <tbody>
                                            <tr style="height: 0">
                                                <td width="16">
                                                </td>
                                                <td width="110">
                                                </td>
                                                <td width="300">
                                                </td>
                                                <td width="90">
                                                </td>
                                                <td width="84">
                                                </td>
                                                <td width="40">
                                                </td>
                                                <td width="58">
                                                </td>
                                            </tr>
                                            <asp:ListView ID="LsQuestionList" runat="server" OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                                                <LayoutTemplate>
                                                    <div id="itemPlaceholder" runat="server">
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                        <td>
                                                            [<a title="<%# DataBinder.Eval(Container.DataItem, "qtypename") %>" href="/questions/?qtype=<%# DataBinder.Eval(Container.DataItem, "qtype")%>"><%# DataBinder.Eval(Container.DataItem, "qtypename")%></a>]
                                                        </td>
                                                        <td>
                                                            <a title="<%# DataBinder.Eval(Container.DataItem, "TITLE") %>" href="/question_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.html">
                                                                <%# dx177.FrameWork.StringUtil.CutString( DataBinder.Eval(Container.DataItem, "TITLE").ToString(), 44) %></a>
                                                        </td>
                                                        <td>
                                                            <a>
                                                                <%# DataBinder.Eval(Container.DataItem, "viewtimes")%>
                                                            </a>
                                                        </td>
                                                        <td>
                                                            <%# DateTime.Parse(DataBinder.Eval(Container.DataItem, "create_date").ToString()).ToString("yyyy-MM-dd") %>
                                                        </td>
                                                        <td>
                                                            <%# DataBinder.Eval(Container.DataItem, "tcount")%>
                                                        </td>
                                                        <td>
                                                            <img src="/web/img/<%# DataBinder.Eval(Container.DataItem, "status")%>_untie.gif">
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div id="pagerwrapper" style="margin-top: 5px">
                        <div class="page_link_full">
                            <asp:DataPager ID="DataPager1" PagedControlID="LsQuestionList" runat="server" PageSize="15"
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
                     <ucMy:right_restaurant1 ID="right_restaurant11" MaxCount=5  runat="server" />
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

    <script>
  addclass() ;
    </script>

</asp:Content>
