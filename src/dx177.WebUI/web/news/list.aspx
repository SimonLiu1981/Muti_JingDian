<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.web.news.list"  %>
<%@ Register Src="../usercontrols/right_hireCar.ascx" TagName="right_hireCar" TagPrefix="uc5" %>
<%@ Register Src="../usercontrols/home_hotel_2.ascx" TagName="home_hotel_2" TagPrefix="uc2" %>
<%@ Register Src="../usercontrols/home_new.ascx" TagName="home_new" TagPrefix="uc4" %>
<%@ Register src="../usercontrols/right_restaurant1.ascx" tagname="right_restaurant1" tagprefix="uc1" %>
<%@ Register Src="../usercontrols/home_questions.ascx" TagName="home_questions" TagPrefix="uc3" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
    <script type="text/javascript">
        $(document).ready(function() {
            var code = "<%=Code.ToLower() %>";
            $('#Qtype' + code).addClass('here');
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <!--头部 结束-->
    <div class="main">
        <div class="navigation">
            <span>当前位置：</span><a title='177丹霞' href="/">177丹霞</a><span>»</span>新闻中心
        </div>
        <!--主体 开始-->
        <div class="blank05">
        </div>
        <div class="main_left">
            <ul class="css-tabs03">
                <li><a class="current">查询条件</a></li>
            </ul>
            <div class="css-panes03">
                <div class="out">
                    <div class="search_main">
                        <p>
                            <b>新闻类型：</b><a href="<%# GetUrlByCode("") %>" id="Qtype">全部</a>
                            <asp:Repeater ID="rpQtype" runat="server">
                                <ItemTemplate>
                                    <a href="<%# GetUrlByCode(DataBinder.Eval(Container.DataItem, "Code").ToString().ToLower()) %>"
                                        id='Qtype<%# DataBinder.Eval(Container.DataItem, "Code").ToString().ToLower() %>'>
                                        <%# DataBinder.Eval(Container.DataItem, "title")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
            <div style="" class="question">
                <h1>
                    <span class="fright02 link02"></span>
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
                                                <td height="0" width="16">
                                                </td>
                                                <td style="padding-left: 10px">
                                                    类型
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid; width: 410px; padding-left: 20px">
                                                    标题
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid; width: 40px; padding-left: 7px">
                                                    人气
                                                </td>
                                                <td style="border-left: #d7e2f8 1px solid; padding-left: 10px" width="120">
                                                    提问日期
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
                                    <table border="0" width="698" cellspacing="0" cellpadding="0">
                                        <tbody>
                                            <tr>
                                                <td style="width: 90px; padding-left: 20px;">
                                                </td>
                                                <td style="width: 440px">
                                                </td>
                                                <td width="50">
                                                </td>
                                                <td width="120">
                                                </td>
                                            </tr>
                                            <asp:ListView ID="LsQuestionList" runat="server" OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging"
                                                OnItemDataBound="LsQuestionList_ItemDataBound">
                                                <LayoutTemplate>
                                                    <div id="itemPlaceholder" runat="server">
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td style="width: 100px; padding-left: 20px;">
                                                            [<asp:Label ID="lblType" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Tguid")%>'></asp:Label>]
                                                        </td>
                                                        <td>
                                                            <a title="<%# DataBinder.Eval(Container.DataItem, "Title") %>" href="/news_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.html">
                                                                <%# DataBinder.Eval(Container.DataItem, "title")%></a>
                                                        </td>
                                                        <td>
                                                            <%# DataBinder.Eval(Container.DataItem, "viewtimes")%>
                                                        </td>
                                                        <td>
                                                            <%# DateTime.Parse(DataBinder.Eval(Container.DataItem, "CREATEDATE").ToString()).ToString("yyyy-MM-dd")%>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
                                    <div id="pagerwrapper">
                                        <div class="page_link_full">
                                            <asp:DataPager ID="DataPager1" PagedControlID="LsQuestionList" runat="server" PageSize="20"
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
                                </td>
                            </tr>
                        </tbody>
                    </table>
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
</asp:Content>
