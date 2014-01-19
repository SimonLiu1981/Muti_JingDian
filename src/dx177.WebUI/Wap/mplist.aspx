<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mplist.aspx.cs" Inherits="dx177.WebUI.Wap.mplist" %>
<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>丹霞山手机订房 - 一起去丹霞</title>
    <meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
    <meta http-equiv="Cache-Control" content="no-cache" />
    <style type="text/css">
        body
        {
            margin: 0;
            padding: 0;
            font-size: 14px;
            color: #333;
            background: url(img/bg.gif) 0 0 repeat-x;
            line-height: 1.5;
        }
        ul, h1, h2, form
        {
            padding: 0;
            margin: 0;
        }
        ul
        {
            list-style: none;
        }
        h2
        {
            font-size: 14px;
        }
        a
        {
            color: #05a;
            text-decoration: none;
        }
        a:hover
        {
            color: #f60;
        }
        #header
        {
            border-bottom: 1px solid #e4f1fb;
        }
        #header table tr td
        {
            padding: 5px 5px 0 5px;
            border-bottom: 1px solid #b8d2e5;
        }
        #header span
        {
            font-size: 22px;
            font-weight: bold;
        }
        .list
        {
            padding: 0 6px 0px 6px;
        }
        .list h2
        {
            padding-top: 8px;
            font-size: 14px;
        }
        .list_t
        {
            background: url(img/arrow.gif) right 10px no-repeat;
        }
        .list_t tr td
        {
            border-bottom: 1px dotted #ccc;
        }
        .l_top
        {
            border-bottom: 1px solid #ccc;
        }
        .l_top h2
        {
            background: #c3dae9;
            border-bottom: 1px solid #b0cadb;
            padding: 2px 0 0 6px;
        }
        .l_top ul
        {
            padding: 4px 6px;
            font-size: 12px;
        }
        #page
        {
            padding: 4px 6px;
            border-bottom: 1px solid #ccc;
        }
        .f_f00
        {
            color: #f00;
        }
        .f_666
        {
            color: #666;
        }
        .f_360
        {
            color: #360;
        }
        .f_12
        {
            font-size: 12px;
        }
        .input
        {
            width: 120px;
            border: 1px solid #999;
        }
        .select
        {
            width: 124px;
        }
        .shuoming
        {
            font-size: 12px;
            color: #666;
        }
        #footer
        {
            padding: 4px 6px;
            line-height: 1.2;
        }
        .jianjie
        {
            border-bottom: 1px dotted #ccc;
            padding: 6px 0 2px 0;
        }
        .jiage
        {
            font-size: 20px;
            color: #f00;
        }
        .syq
        {
            font-size: 12px;
            color: #999;
        }
        
        .w-bg2
        {
            background-color: #FFE4D7;
        }
        .w-sec
        {
            margin-top: 3px;
        }
        .w-mod
        {
            padding: 0 3px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div id="header">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                          <a href="index.aspx">首页</a> &nbsp;  <a href="default.aspx">酒店</a> &nbsp;  <a href="mplist.aspx"> 购物</a> &nbsp;<a href="hirecarlist.aspx"> 租车</a> &nbsp;<a href="Reslist.aspx"> 饭店</a>

                    </td>
                </tr>
            </table>
        </div>
        <div class="l_top">
            <h2>
                丹霞山旅游购物 </h2>
            <ul>
                <li>
                    <b>类型：</b>
                    <a  href="mplist.aspx?pid=" target="_self">全部</a> &nbsp;
                    <asp:Repeater ID="tyrpt" runat="server">
                    <ItemTemplate><a  href="mplist.aspx?pguid=<%# DataBinder.Eval(Container.DataItem, "guid") %>" target="_self"><%# DataBinder.Eval(Container.DataItem, "title") %></a> &nbsp;
                    </ItemTemplate>
                    </asp:Repeater>
                   
                    
                    
                </li>
            </ul>
        </div>
        <div class="list">
            <asp:ListView ID="LsHotelList" runat="server" OnItemDataBound="LsHotelList_ItemDataBound"
                OnPagePropertiesChanging="LsHotelList_PagePropertiesChanging">
                <LayoutTemplate>
                    <div id="itemPlaceholder" runat="server">
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <h2>
                        <a href="P.aspx?seqno=<%# DataBinder.Eval(Container.DataItem, "seqno") %>"><%# DataBinder.Eval(Container.DataItem, "TITLE") %></a></h2>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="list_t">
                        <tr>
                            <td width="86" valign="top">
                                <a href="P.aspx?seqno=<%# DataBinder.Eval(Container.DataItem, "seqno") %>">
                                    <img style="margin-top: 4px;" src="<%# DataBinder.Eval(Container.DataItem, "logo") %>"
                                        border="0" alt="<%# DataBinder.Eval(Container.DataItem, "TITLE") %>" width="60" height="50" /></a>
                            </td>
                            <td valign="top">
                                <span class="syq"> <%# DataBinder.Eval(Container.DataItem, "TYPENAME") %><br />
                                    
                                </span><span class="jiage"><%# DataBinder.Eval(Container.DataItem, "NOWPRICE")%></span>元 
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:ListView>            
        <div id="page">
            
            <asp:DataPager ID="DataPager1" PagedControlID="LsHotelList" runat="server" PageSize="4"
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
        <div id="footer">
            <a href="javascript:history.go(-1);">返回上页</a> · <a href="index.aspx">返回首页</a>
            · <a href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">版权：游丹霞山&nbsp;<%=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></span>
        </div>
    </div>
</body>
</html>
