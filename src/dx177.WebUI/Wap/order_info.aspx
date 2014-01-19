<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order_info.aspx.cs" Inherits="dx177.WebUI.Wap.order_info" %>

<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>订单详情-丹霞山手机订房 - 一起去丹霞</title>
    <meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
    <meta http-equiv="Cache-Control" content="no-cache" />
    <style type="text/css">
        body
        {
            margin: 0;
            padding: 0px;
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
        .fankui
        {
        }
        .fankui h2
        {
            background: #c3dae9;
            border-bottom: 1px solid #b0cadb;
            padding: 2px 0 0 6px;
        }
        .fankui ul
        {
            padding: 6px 8px;
            border-bottom: 1px dotted #ccc;
        }
        .fankui ul li
        {
            padding: 3px 0;
        }
        .f_f00
        {
            color: #f00;
        }
        .f_f60
        {
            color: #f60;
        }
        .f_666
        {
            color: #666;
        }
        .f_888
        {
            color: #888;
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
            width: 110px;
            border: 1px solid #999;
        }
        .select
        {
            width: 114px;
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
        .zt
        {
            font-size: 15px;
            color: #f00;
        }
    </style>
</head>
<body>
    <div class="container">
        <div id="header">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                         <span>丹霞山手机订房 - 一起去丹霞</span>
                    </td>
                    <td align="right">
                        订单详情
                    </td>
                </tr>
            </table>
        </div>
        <div class="fankui">
            <h2>
                订单详细信息</h2>
            <ul>
                <table width="100%" border="0" cellspacing="0" cellpadding="0" class="t_login">
                    <tr>
                        <td width="60" valign="top" class="f_888">
                            预订单号
                        </td>
                        <td valign="top">
                            <strong><%=HO.Orderno %></strong>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" class="f_888">
                            订单状态
                        </td>
                        <td valign="top">
                            <span class="zt">
                            <%= dx177.Business.DictBus.Dict.Tag[((dx177.FrameWork.HotelOrderStatus)HO.Status)] %>
                            </span>(<a href="order_info.aspx?id=<%=HO.Seqno %>">刷新订单状态</a>)
                        </td>
                    </tr>
                    
                    <tr>
                        <td valign="top" class="f_888">
                            酒店名称
                        </td>
                        <td valign="top">
                            <a href="hotel.aspx?seqno=<%=HT.Seqno %>"><%=HT.Name %></a>
                        </td>
                    </tr>                     
                    <tr>
                        <td valign="top" class="f_888">
                            酒店地址
                        </td>
                        <td valign="top">
                            <%=HT.Address %>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" class="f_888">
                            订单明细
                        </td>
                        <td valign="top">
                            房型：<%=RM.Roomtitle %><br />
                            入住：<%=HO.Begindate.ToString("yyyy年MM月dd日") %>
                            <br />
                            离店：<%=HO.Enddate.ToString("yyyy年MM月dd日") %>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" class="f_888">
                            房费金额
                        </td>
                        <td valign="top">
                            <strong class="f_f00"><%=HO.Totalmoney %> 元</strong>(前台支付)
                        </td>
                    </tr>
                     
                    <tr>
                        <td valign="top" class="f_888">
                            入住人
                        </td>
                        <td valign="top">
                            姓名：<%=HO.Personname %><br />
                            手机：<%=HO.Personphone %>
                        </td>
                    </tr>
                </table>
                </li>
            </ul>
        </div>
        <div id="footer">
            <a href="javascript:history.go(-1);">返回上页</a> · <a href="index.aspx">返回首页</a>
            · <a href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">版权：游丹霞山&nbsp;<%=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></span>
        </div>
    </div>
</body>
</html>
