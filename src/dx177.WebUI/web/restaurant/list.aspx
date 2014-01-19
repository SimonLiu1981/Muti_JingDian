<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.web.restaurant.list" %>
<%@ Register Src="../usercontrols/right_hireCar.ascx" TagName="right_hireCar" TagPrefix="uc5" %>
<%@ Register Src="../usercontrols/home_hotel_2.ascx" TagName="home_hotel_2" TagPrefix="uc2" %>
<%@ Register Src="../usercontrols/home_new.ascx" TagName="home_new" TagPrefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    function SetArea(sval) {
        var Rtype = '<%=this.Rtype%>';
        window.location.href = "/restaurant/default.aspx?Rtype=" + Rtype + "&Area=" + sval;
    }
    function SetRtype(sval) {
        var Area = '<%=this.Area%>';
        window.location.href = "/restaurant/default.aspx?Rtype=" + sval + "&Area=" + Area;
    }
    
    function addclass() {
        var Area = '<%=this.Area%>';
        var Rtype = '<%=this.Rtype%>';
        $("#Rtype").removeClass("here");
        $("#Rtype" + Rtype).addClass("here");
        $("#Area").removeClass("here");
        $("#Area" + Area).addClass("here");
    }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">

             <div class="navigation">
                <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span></span> 饭店预订 
               
            </div>

       
        <div class="main_left">
            <ul class="css-tabs03">
                <li><a class="current" href="#">查询条件</a></li>
            </ul>
            <div class="css-panes03">
                <div class="out">
                    <div class="search_main">
                        <p>
                            <b>地段：</b> <a id='Area' class="here" href="#" onclick="javascript:SetArea('');" target="_self">
                                全部</a>
                            <asp:Repeater ID="rpArea" runat="server">
                                <ItemTemplate>
                                    <a href="#" id='Area<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>' onclick="javascript:SetArea('<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>');">
                                        <%# DataBinder.Eval(Container.DataItem, "tag_name")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                        <p class="heightlight">
                            <b>类型：</b> <a id='Rtype' class="here" href="#" onclick="javascript:SetRtype('');"
                                target="_self">全部</a>
                            <asp:Repeater ID="rpRtype" runat="server">
                                <ItemTemplate>
                                    <a href="#" id='Rtype<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>' onclick="javascript:SetRtype('<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>');">
                                        <%# DataBinder.Eval(Container.DataItem, "tag_name")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
            <div class="cate_list">
                <ul>
                    <asp:ListView ID="LsRestaurantList" runat="server" OnPagePropertiesChanging="LsRestaurantList_PagePropertiesChanging">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <dl class="cateitem_left1">
                                    <div style="text-align: center; line-height: 25px; width: 129px; float: left; color: #ff6100;
                                        font-weight: bold; margin-right: 5px; margin-top: 5px;">
                                        <a href="/restaurant_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            <img src="<%# DataBinder.Eval(Container.DataItem, "Logo") %>" width="129" height="97"></a></div>
                                    <p>
                                        <a class="title" href="/restaurant_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            <%# DataBinder.Eval(Container.DataItem, "Title")%></a></p>
                                    <p class="intro">
                                        <%# DataBinder.Eval(Container.DataItem, "shortContent")%>
                                        </p>
                                </dl>
                                <dl class="cateitem_right1">
                                    <a href="/restaurantcomments_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                        我要点评</a>
                                    <div class="pjCount">
                                        评价(<span class="orange">
                                            <%# DataBinder.Eval(Container.DataItem, "Comment") %>
                                        </span>)
                                    </div>
                                </dl>
                            </li>
                        </ItemTemplate>
                    </asp:ListView>
                </ul>
            </div>
            <div id="pagerwrapper">
                 <div class="page_link_full">
                    <asp:DataPager ID="DataPager1" PagedControlID="LsRestaurantList" runat="server" PageSize="8"
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
                        <a href="#">更多</a></div>
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
                        <a href="/hirecar/" target="_blank">更多</a></div>
                    <div class="clear">
                    </div>
                </div>
            </div>
            <div class="blank05">
            </div>
            <div class="table05">
                <div class="table05_title">
                    <p class='news'>
                        最新新闻</p>
                </div>
                <div class="table05_body">
                    <uc4:home_new ID="home_new1" NewsTypeCode="" MaxCount="8" runat="server" />
                    <div class="more">
                        <a href="/news/list_lygl.aspx">更多</a></div>
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
