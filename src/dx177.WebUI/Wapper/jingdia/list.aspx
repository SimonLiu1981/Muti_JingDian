<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.Wapper.jingdia.list"
    MasterPageFile="~/master/site.Master" %>

<%@ Register Src="../../Control/lyCar.ascx" TagName="lyCar" TagPrefix="uc1" %>
<%@ Register Src="../../Control/SiteLeft.ascx" TagName="SiteLeft" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/room.gbk.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script type="text/javascript" src="/js/jquery.tipsy.js"></script>
    <link href="/css/tipsy.css" rel="stylesheet" type="text/css" />
 <script type='text/javascript'>
    $(function() {
        $('img[tooltip]').tipsy({ title: 'tooltip', fade: true, html: true, opacity: 0.7 });
    });
</script>	 

    <style type="text/css">
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="nav_son">
        <span><a href="#" class="cxdd">查询我的订单状态</a></span>当前位置：<a
            href="/index.html">首页</a> &gt;&nbsp;
    </div>
    <div id="mainContent">
        <div id="side">
            <uc2:SiteLeft ID="SiteLeft1" runat="server" />
            <uc1:lyCar ID="lyCar1" runat="server" />
        </div>
        <div id="main">
            <div class="list_top">
                <h2>
                    <strong>景点查询</strong></h2>
                <div class="zx_city_list">
                    <ul>
                        <asp:Repeater ID="rpProvince" runat="server">
                            <ItemTemplate>
                                <li><a href="?k0=<%#DataBinder.Eval(Container.DataItem, "areaid")%>">
                                    <%#DataBinder.Eval(Container.DataItem, "areaname")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="zx_city_list_srh">
                    <form action="/Wapper/jingdia/list.aspx" method="get" name="school">
                    <select id="ddlProvince">
                        <option value="">请选择省</option>
                    </select>
                    <select id="ddlCity">
                        <option value="">请选择市</option>
                    </select>
                    <input id="txtCommonAreaID" name="k0" value="0" type="hidden" />
                    <input name="k1" type="text" id="k1" value="" title="酒店位置 例如：长安街" />
                    <input type="submit" value="搜景点" class="btn04" />
                    </form>
                </div>
            </div>
            <div class="list_tab">
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
                            没有查到相关经典数据</div>
                    </EmptyDataTemplate>
                    <ItemTemplate>
                        <div class="list_box div0">
                            <div class="lb_pic">
                                <dl>
                                    <dt style="border-bottom-width:0px">
                                        <input id="txtAreaId" runat="server" type="hidden" value='<%# DataBinder.Eval(Container.DataItem, "Areaid")%>' />
                                        <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "MatchDomain")%>">
                                            <img src="<%#DataBinder.Eval(Container.DataItem, "logo")%>" width="100" height="80"  tooltip='<%#DataBinder.Eval(Container.DataItem, "priceinfo1")%>'  /></a>
                                        <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "MatchDomain")%>">
                                            <%#DataBinder.Eval(Container.DataItem, "JingQuName")%></a></dt>
                                </dl>
                            </div>
                            <div class="lb_con">
                                <h2>
                                    <a href="/JQ_<%#DataBinder.Eval(Container.DataItem, "MatchDomain")%>">
                                        <%#DataBinder.Eval(Container.DataItem, "JingQuName")%></a></h2>
                                <dl>
                                    <dt>地址：</dt>
                                    <dd style="height: 20px; overflow: hidden;">
                                       <asp:Literal ID="lblAddress" runat="server"></asp:Literal>
                                         
                                    </dd>
                                </dl>
                                <dl>
                                    <dt>简介：</dt>
                                    <dd>
                                        <%#DataBinder.Eval(Container.DataItem, "Sumary")%></dd>
                                </dl>
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

    <script type="text/javascript">
                        if ('<%=Request["k0"] %>' != '')
                        {
                            $('#txtCommonAreaID').val(<%=Request["k0"] %>);
                        }  
                        if ('<%=Request["k1"] %>' != '')
                        {
                            $('#k1').val('<%=Request["k1"] %>');
                        }  
                                              
                        function InitProvince(selectId) {
                            $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                                                           { Pid: 0 },
                                                          function(json) {

                                                              if ($('#txtCommonAreaID').val() != '0') {
                                                                  $.post("/admin/ajaxHandler.aspx?MethodName=GetByAreadID&randID=" + escape(new Date()),
                                                                    { Areaid: $('#txtCommonAreaID').val() },
                                                                    function(json1) {
                                                                        if (json1.Depth == 1) {
                                                                            callbackSubmitComment($('#ddlProvince'), json, json1.Areaid);
                                                                            InitCity(json1.Areaid, "0");
                                                                        }
                                                                        if (json1.Depth == 2) {
                                                                            callbackSubmitComment($('#ddlProvince'), json, json1.Pareaid);
                                                                            InitCity(json1.Pareaid, json1.Areaid);
                                                                        }

                                                                    });
                                                              }
                                                              else {
                                                                  callbackSubmitComment($('#ddlProvince'), json, "0");
                                                              }


                                                          });
                        }

                        function InitCity(Pid, selectId) {
                            $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                                                           { Pid: Pid },
                                                           function(json) {
                                                               callbackSubmitComment($("#ddlCity"), json, selectId);
                                                           });
                        }

                        $(document).ready(function() {
                            InitProvince(0);
                            $("#ddlProvince").change(
                                                            function() {
                                                                var s = $("#ddlProvince").val();
                                                                $("#ddlCity").get(0).selectedIndex = 0;
                                                                $("#ddlCity").empty();
                                                                if (s != 0) {
                                                                    $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                                                                       { Pid: s },
                                                                      function(json) {
                                                                          callbackSubmitComment($('#ddlCity'), json, "0");
                                                                      });
                                                                }
                                                            }
                                                        );
                            $("#ddlCity").change(
                                                            function() {
                                                                $('#txtCommonAreaID').val($(this).val());

                                                            });
                            $("#ddlProvince").change(
                                                        function() {
                                                            $('#txtCommonAreaID').val($(this).val());

                                                        });
                            $("#ddlCity").empty();
                            $("#ddlCity").append("<option value=''>请选择</option>");



                        });

                        function callbackSubmitComment(dll, json, selectId) {
                            $(dll).empty();
                            $(dll).append("<option value=''>请选择</option>");
                            for (var i = 0; i < json.length; i++) {
                                $(dll).append("<option value='" + json[i].Areaid + "'>" + json[i].Areaname + "</option>");
                            }
                            $(dll).val(selectId);
                        }
    </script>

</asp:Content>
