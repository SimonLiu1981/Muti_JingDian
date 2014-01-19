<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="msg.aspx.cs" Inherits="dx177.WebUI.Wap.msg" %>

<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>对不起，出错了!-丹霞山手机订房 - 一起去丹霞</title>
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
        <div class="book">
            <h2>
                错误提示</h2>
            <ul>
                <li class="f_f00"><%=Request.QueryString["msg"] %></li>
                <li><a href="<%=BackUrl %>">返回重填</a></li>
            </ul>
        </div>
        <div id="footer">
            <a href="javascript:history.go(-1);">返回上页</a> · <a href="default.aspx">返回首页</a> · <a
                href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">苏ICP备10084268号&nbsp;2011-4-11 10:44:29</span>
        </div>
    </div>
</body>
</html>
