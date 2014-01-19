<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.web.hirecar.list" %>
<%@ Register Src="../usercontrols/home_new.ascx" TagName="home_new" TagPrefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--头部 结束-->
  
    <div class="main">
          <div class="navigation">
            <span>当前位置：</span> <a title='177丹霞' href="/">177丹霞</a> <span>»</span>旅游租车
        </div>
        <!--主体 开始-->        
        <div class="main_left">            
            <div class="zuche_list">
                <ul>
                    <asp:ListView ID="LsHireCarList" runat="server" OnPagePropertiesChanging="LsHireCarList_PagePropertiesChanging">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <AlternatingItemTemplate>                           
                            <li  class="bg_color_1">
                                <div class="zucheitem_left1">
                                    <div style="text-align: center; line-height: 25px; width: 129px; float: left; color: #ff6100;
                                        font-weight: bold; margin-right: 5px; margin-top: 5px;">
                                        <a href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            <img src="<%# DataBinder.Eval(Container.DataItem, "logo")%>" width="129" height="97"></a></div>
                                    <p>
                                        <a class="title" href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            <%# DataBinder.Eval(Container.DataItem, "title")%></a></p>
                                    <dl>
                                        <dt></dt>
                                        <dd>
                                            联系电话：<%# DataBinder.Eval(Container.DataItem, "telnumber")%></dd>
                                    </dl>
                                    <dl>
                                        <dt></dt>
                                        <dd>
                                            营运范围：<%# DataBinder.Eval(Container.DataItem, "range")%></dd>
                                    </dl>
                                    <dl>
                                        <dt></dt>
                                        <dd>
                                            价格：<%# DataBinder.Eval(Container.DataItem, "price")%></dd>
                                    </dl>
                                    <p class="intro">
                                        <a style="color: #00519c; text-decoration: none" href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            [查看租车]</a>
                                    </p>
                                </div>
                            </li>
                        </AlternatingItemTemplate>
                        <ItemTemplate>
                            <li>
                                <div class="zucheitem_left1">
                                    <div style="text-align: center; line-height: 25px; width: 129px; float: left; color: #ff6100;
                                        font-weight: bold; margin-right: 5px; margin-top: 5px;">
                                        <a href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            <img src="<%# DataBinder.Eval(Container.DataItem, "logo")%>" width="129" height="97"></a></div>
                                    <p>
                                        <a class="title" href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            <%# DataBinder.Eval(Container.DataItem, "title")%></a></p>
                                    <dl>
                                        <dt></dt>
                                        <dd>
                                            联系电话：<%# DataBinder.Eval(Container.DataItem, "telnumber")%></dd>
                                    </dl>
                                    <dl>
                                        <dt></dt>
                                        <dd>
                                            营运范围：<%# DataBinder.Eval(Container.DataItem, "range")%></dd>
                                    </dl>
                                    <dl>
                                        <dt></dt>
                                        <dd>
                                            价格：<%# DataBinder.Eval(Container.DataItem, "price")%></dd>
                                    </dl>
                                    <p class="intro">
                                        <a style="color: #00519c; text-decoration: none" href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.aspx">
                                            [查看租车]</a>
                                    </p>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:ListView>
                </ul>
            </div>
            <div id="pagerwrapper" style="margin-top: 5px">
                <div class="page_link_full">
                    <asp:DataPager ID="DataPager1" PagedControlID="LsHireCarList" runat="server" PageSize="5"
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
    <!--尾开始-->
</asp:Content>
