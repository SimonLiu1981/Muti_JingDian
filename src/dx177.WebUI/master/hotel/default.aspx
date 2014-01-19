<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="dx177.WebUI.master.hotel._default"  MasterPageFile="~/master/Site.Master"  %>
 
<%@ Register src="../../Control/lyCar.ascx" tagname="lyCar" tagprefix="uc1" %>
<%@ Register src="../../Control/SiteLeft.ascx" tagname="SiteLeft" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/room.gbk.css" rel="stylesheet" type="text/css" />
    <link href="/js/My97DatePicker/skin/WdatePicker.css" rel="stylesheet" type="text/css">
    <script src="/js/jquery.cookie.js" type="text/javascript"></script> 
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script src="/js/room.gbk.js" type="text/javascript"></script>
    <script type="text/javascript" src="/js/My97DatePicker/WdatePicker.js"></script>    
    
    <script type="text/javascript">
        
        $(document).ready(function() {
            InitSection();
            SearchPriceZhuna();
        });
        function SearchPriceZhuna() {
            _hid = '';
            _tm1 = '<%=tm1 %>';
            _tm2 = '<%=tm2 %>';            
            $(".room_con[refHotelId]").each(function() {                
                if ($(this).attr("refType") == '1') {
                    if (_hid != '') {
                        _hid += ',';
                    }
                    _hid += $(this).attr("refHotelId");
                }
            });
            loadPrice();
        }      
    
        function InitSection() {
            //class="sx_curr"
             
            cur = '<%=this.HotelType %>';
            if ($('A[HotelType=' + cur + ']').length > 0) {
                $($('A[HotelType=' + cur + ']')[0]).addClass("sx_curr");
            }
            else {
                $($('A[HotelType=\'\']')[0]).addClass("sx_curr");
            }

            cur = '<%=this.Area %>';
            if ($('A[area=' + cur + ']').length > 0) {
                $($('A[area=' + cur + ']')[0]).addClass("sx_curr");
            }
            else {
                $($('A[area=\'\']')[0]).addClass("sx_curr");
            }

        }

        function changeTheOtherDate() {
            var url = '<%=GetUrlWithOutTm1Tm2() %>';
            if (url.indexOf('?') != -1) {
                url += '&';
            }
            else {
                url += '?';
            }
            $.cookie('tm1', $('#tm1').val());
            $.cookie('tm2', $('#tm2').val());
            url += 'tm1=' + $('#tm1').val();
            url += '&tm2=' + $('#tm2').val();
            window.location = url;      
        }
        
        
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div id="nav_son">
        <span><a href="/web/hotelorder/orderlist.aspx" class="cxdd">查询我的订单状态</a></span>当前位置：<a
            href="/">首页</a> &gt;&nbsp;酒店预订</div>
    <div id="mainContent">
        <div id="side">
            <uc2:SiteLeft ID="SiteLeft1" runat="server" />
            <uc1:lyCar ID="lyCar1" runat="server" />
        </div>
        <div id="main">
            <div class="list_top">
                <h2>
                </h2>
                <div id="list_filter">
                    <dl style="display:none">
                        <dt>价格范围</dt>
                        <dd>
                            <a href="<%=GetNewUrl("price", "0") %>" price='0' class='<% if (this.price == "0") this.Response.Write("sx_curr"); %>'>全部</a> 
                            <a href="<%=GetNewUrl("price","100") %>" price='100' class='<% if (this.price == "100") this.Response.Write("sx_curr"); %>'>100元以下</a>
                            <a href="<%=GetNewUrl("price","200") %>" price='200' class='<% if (this.price == "200") this.Response.Write("sx_curr"); %>'>100元-200元</a>
                            <a href="<%=GetNewUrl("price","300") %>" price='300' class='<% if (this.price == "300") this.Response.Write("sx_curr"); %>'>200元- 300元</a>
                            <a href="<%=GetNewUrl("price","400") %>" price='400' class='<% if (this.price == "400") this.Response.Write("sx_curr"); %>'>300元- 400元</a>
                            <a href="<%=GetNewUrl("price","401") %>" price='401' class='<% if (this.price == "401") this.Response.Write("sx_curr"); %>'>400元以上</a>
                        </dd>
                    </dl>
                    <dl>
                        <dt>酒店类型</dt>
                        <dd>
                            <a href="<%=GetNewUrl("HotelType","") %>" hoteltype=''>全部</a>
                            <asp:Repeater ID="rpHotelType" runat="server">
                                <ItemTemplate>
                                    <a href="<%#GetNewUrl("HotelType", DataBinder.Eval(Container.DataItem, "Enum_value").ToString()) %>"
                                        hoteltype='<%# DataBinder.Eval(Container.DataItem, "Enum_value") %>'>
                                        <%# DataBinder.Eval(Container.DataItem, "tag_name")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </dd>
                    </dl>
                    <dl id="dlArea" runat=server>
                        <dt>酒店地区</dt>
                        <dd>
                            <a href="<%=GetNewUrl("area","") %>" area=''>全部</a>
                            <asp:Repeater ID="rpAddress" runat="server">
                                <ItemTemplate>
                                    <a href="<%#GetNewUrl("area",DataBinder.Eval(Container.DataItem, "jingquareaid").ToString()) %>"
                                        area='<%# DataBinder.Eval(Container.DataItem, "jingquareaid") %>'>
                                        <%# DataBinder.Eval(Container.DataItem, "areaname")%></a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </dd>
                    </dl>
                </div>
            </div> 
            <div class="list_tab">
                <span style="float:left">入住日期：</span>                 
                <input onFocus="var tm2=$dp.$('tm2');WdatePicker({minDate:'<%=DateTime.Now.ToString("yyyy-MM-dd") %>',onpicked:function(){tm2.focus();}})" name="tm1" type="text" id="tm1" style="height:12px;  line-height:12px; margin-top:5px; width:80px;float:left " value='<%=tm1 %>' />
                <span style="float:left; margin-left:5px; margin-right:3px">至</span>
                <input onFocus="WdatePicker({minDate:'#F{$dp.$D(\'tm1\')}',onpicked:changeTheOtherDate})" name="tm2" type="text" id="tm2" style="height:12px;  line-height:12px; margin-top:5px; width:80px;float:left " value='<%=tm2 %>' />
                
            </div>
            <div class="list_con">
                <asp:ListView ID="LsHotelList" runat="server" OnItemDataBound="LsHotelList_ItemDataBound"
                    OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                    <LayoutTemplate>
                        <div id="itemPlaceholder" runat="server">
                        </div>
                    </LayoutTemplate>
                    <EmptyDataTemplate>
                        <div class="list_box div0">
                            没有查到相关酒店数据</div>
                    </EmptyDataTemplate>
                    <ItemTemplate>
                        <div class="list_box div0">
                            <div class="lb_pic">
                                <dl>
                                    <dt>
                                        <input id="txtGuid" runat="server" type="hidden" value='<%# DataBinder.Eval(Container.DataItem, "GUID")%>' />
                                        <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/hotel/<%# DataBinder.Eval(Container.DataItem, "seqno") %>">
                                            <img src="<%# DataBinder.Eval(Container.DataItem, "Logo")%>" width="100" height="80" /></a>
                                        <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/hotel/<%# DataBinder.Eval(Container.DataItem, "seqno") %>?#pic">更多图片</a></dt>
                                    <dd>
                                        <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/hotel?HotelType=<%#DataBinder.Eval(Container.DataItem, "HotelType")%>">
                                            <%# DataBinder.Eval(Container.DataItem, "hoteltypename")%></a><br />
                                        点评：<span><%# DataBinder.Eval(Container.DataItem, "scount")%>条</span><br />
                                        <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/hotel/<%# DataBinder.Eval(Container.DataItem, "seqno") %>?#comment" target="_blank">
                                            <img src="/img/but_03.gif" width="74" height="19" /></a>
                                    </dd>
                                </dl>
                            </div>
                            <div class="lb_con">
                                <h2>
                                    <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/hotel/<%# DataBinder.Eval(Container.DataItem, "seqno") %>">
                                        <%# DataBinder.Eval(Container.DataItem, "Name")%></a></h2>
                                <dl>
                                    <dt>地址：</dt>
                                    <dd style="height: 20px; overflow: hidden;">
                                        <%# DataBinder.Eval(Container.DataItem, "Address")%>
                                    </dd>
                                </dl>
                                <dl>
                                    <dt>简介：</dt>
                                    <dd>
                                        <%# DataBinder.Eval(Container.DataItem, "BIZ")%></dd>
                                </dl>
                                <dl>
                                    <dt>位于：</dt>
                                    <dd>
                                        <a href="#">
                                            <%# dx177.Business.DictBus.Dict.Tag["Area", DataBinder.Eval(Container.DataItem, "Area").ToString(), 2052]%></a>
                                        价格范围： <font style='color: #f60;'>
                                            <%# DataBinder.Eval(Container.DataItem, "minprice")%>元-<%# DataBinder.Eval(Container.DataItem, "maxprice")%>元</font>
                                    </dd>
                                </dl>
                                <div class="list_room">
                                    <div class="room_tit">
                                        <strong>房型与价格</strong>
                                    </div>
                                    <div class="room_con" id="h<%# DataBinder.Eval(Container.DataItem, "refHotelId")%>" refHotelId="<%# DataBinder.Eval(Container.DataItem, "refHotelId")%>"  jq='<%# DataBinder.Eval(Container.DataItem, "jingqucode")%>' seqno='<%# DataBinder.Eval(Container.DataItem, "seqno")%>' refType='<%# DataBinder.Eval(Container.DataItem, "refType")%>' >
                                        
                                        
                                    </div>
                                </div>
                            </div>
                            <div class="clearfloat">
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div id="pages">
                <asp:DataPager ID="DataPager1" PagedControlID="LsHotelList" runat="server" PageSize="8"
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
</asp:Content>
