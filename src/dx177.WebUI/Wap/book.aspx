<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="dx177.WebUI.Wap.book" %>

<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title> 丹霞山手机订房 - 游丹霞山</title>
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
        ul, h1, h2, h3, form
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
        .b_con
        {
            padding: 6px 8px;
            border-bottom: 1px dotted #ccc;
        }
        .b_con h3
        {
            font-size: 14px;
            color: #f70;
        }
        .f_f00
        {
            color: #f00;
        }
        .f_666
        {
            color: #666;
        }
        .f_f70
        {
            color: #f70;
        }
        .f_360
        {
            color: #360;
        }
        .f_12
        {
            font-size: 12px;
        }
        .r_info
        {
            color: #666;
            font-size: 12px;
            border-bottom: 1px dotted #ccc;
            border-top: 1px dotted #ccc;
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
                              <a href="index.aspx">首页</a> &nbsp;  <a href="default.aspx">酒店</a> &nbsp;  <a href="mplist.aspx"> 购物</a> &nbsp;<a href="hirecarlist.aspx"> 租车</a> &nbsp;<a href="Reslist.aspx"> 饭店</a>

                    </td>
                </tr>
            </table>
        </div>
        <div class="book">
            <h2>
                <%=HT.Name %></h2>
            <div class="b_con" style="border-bottom: none;">
                <h3>
                    <%=RM.Roomtitle %>
                </h3>
                <ul class="r_info">
                    <li>◇面积：<%=RM.Square %></li>
                    <li>◇早餐：<%=RM.Breakfast %></li>
                    <li>◇带宽：<%=RM.Broadband %></li>
                    <li>◇简述：<%=RM.Shortdescr %></li>
                </ul>
                <ul>
                    <li>总房费：<span class="f_f00"><%=RM.Price1 %></span>元 (<span class="f_666">前台支付费用)</span></li>
                </ul>
            </div>
        </div>
        <div class="book">
            <h2>
                填写订单信息</h2>
            <div class="b_con">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <form action="result.aspx?action=load" method="post">
                    <tr>
                        <td width="66" class="f_f00">
                            订房日期
                        </td>
                        <td>
                            <input name="dateTime" type="text" value="<%=TodayString %>" format="*N" class="input" />                       
                        </td>
                    </tr>
                    <tr>
                        <td width="66" class="f_f00">
                            房间数量
                        </td>
                        <td>
                            <input name="n" type="text" value="1" format="*N" class="input" />
                        </td>
                    </tr>
                    <tr>
                        <td class="f_f00">
                            入住人名
                        </td>
                        <td>
                            <input name="name" type="text" value="<%=UserName %>" class="input" />
                        </td>
                    </tr>
                    <tr>
                        <td class="f_f00">
                            手机号码
                        </td>
                        <td>
                            <input name="tel" type="text" value="<%=UserPhone %>" format="*N" class="input" />
                        </td>
                    </tr>
                    <tr>
                        <td class="f_f00">
                            最晚到店
                        </td>
                        <td>
                            <select name="arrive" id="arrive" class="select">
                                <option value="早上8:00之前">早上8:00之前</option>
                                <option value="10:00">10:00</option>
                                <option value="12:00">12:00</option>
                                <option value="14:00">14:00</option>
                                <option value="16:00">16:00</option>
                                <option value="18:00" selected="selected">18:00</option>
                                <option value="20:00">20:00</option>
                                <option value="22:00">22:00</option>
                                <option value="24:00">00:00</option>
                                <option value="晚上00:00之后(次日)">晚上00:00之后(次日)</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            备注说明
                        </td>
                        <td>
                            <input name="content" type="text" class="input" />
                            <input name="rid" value="<%=RoomID %>" type="hidden" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <input type="submit" name="button" id="button" value="提交订单" />
                        </td>
                    </tr>
                    </form>
                </table>
            </div>
        </div>
        <div id="footer">
            <a href="javascript:history.go(-1);">返回上页</a> · <a href="default.aspx">返回首页</a>
            · <a href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">苏ICP备10084268号&nbsp;<%=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></span>
        </div>
    </div>
</body>
</html>
