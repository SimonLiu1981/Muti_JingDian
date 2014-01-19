<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.web.Sites.list" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <!--主体 开始-->
        
         <div class="navigation">
            <span>当前位置：</span><a title='177丹霞' href="http://www.177dx.com/">177丹霞</a><span>»</span><a
                title='177丹霞' href="/Sites/default.aspx">丹霞风景</a> 
        </div>
        
        <div class="main_left">
            <div class="site_list">
                <ul>
                    <asp:ListView ID="LsSiteList" runat="server" OnPagePropertiesChanging="LsRestaurantList_PagePropertiesChanging">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <dl class="siteitem_left1">
                                    <div style="text-align: center; line-height: 25px; width: 129px; float: left; color: #ff6100;
                                        font-weight: bold; margin-right: 5px; margin-top: 5px;">
                                        <a href="/Sites_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.html">
                                            <img src="<%# DataBinder.Eval(Container.DataItem, "Logo") %>" width="129" height="97"></a></div>
                                    <p>
                                        <a class="title" href="/Sites_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.html">
                                            <%# DataBinder.Eval(Container.DataItem, "Title")%></a></p>
                                    <p class="intro">
                                        <%# DataBinder.Eval(Container.DataItem, "shortContent")%>
                                    </p>
                                </dl>
                            </li>
                        </ItemTemplate>
                    </asp:ListView>
                </ul>
            </div>
           <div id="pagerwrapper">
                  <div class="page_link_full">
                    <asp:DataPager ID="DataPager1" PagedControlID="LsSiteList" runat="server" PageSize="8"
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
