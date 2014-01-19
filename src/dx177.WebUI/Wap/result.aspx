<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="dx177.WebUI.Wap.result" %>

<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>预订结果-丹霞山手机订房 - 一起去丹霞</title>
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
        .book
        {
        }
        .book h2
        {
            background: #c3dae9;
            border-bottom: 1px solid #b0cadb;
            padding: 2px 0 0 6px;
        }
        .book ul
        {
            padding: 6px 8px;
            border-bottom: 1px dotted #ccc;
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
                   
                </tr>
            </table>
        </div>
        <asp:Panel ID="Panel1" CssClass='book' runat="server">
            <h2>
                订单正在提交中</h2>
            <ul>
                <li class="f_f00">订单正在自动提交中...禁止任何操作</li><li>如长时间无反应请返回<a href="javascript:history.go(-1);">“重新提交”</a></li></ul>
        </asp:Panel>
        
         <asp:Panel ID="Panel2" Visible=false CssClass='book' runat="server">
             <h2>
                订单已提交</h2>
            <ul>
                <li>订单号：<span class="f_f00"> <%=OrderNO %> </span></li>
                <li>订单已提交，客服正在为您处理...</li>
                <li>我们将在30分钟内通过短信通知您是否预订成功。如未收到短信，您可以在线<a href="Order_info.aspx?id=<%=OrderSeqno %>">查看订单状态</a>，或通过电话与我们联系：</li>
                <li>请等待处理结果，不要重复下单</li>
            </ul>
        </asp:Panel>
        <div id="footer">
              <a href="javascript:history.go(-1);">返回上页</a> · <a href="index.aspx">返回首页</a>
            · <a href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">版权：游丹霞山&nbsp;<%=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></span>
        </div>
    </div>
</body>
</html>
