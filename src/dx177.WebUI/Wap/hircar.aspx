<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hircar.aspx.cs" Inherits="dx177.WebUI.Wap.hircar" %>

<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>
         <%=hr.Title%>_旅游购物_丹霞山手机订房 - 一起去丹霞</title>
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
        ul, h1, h2, form, p
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
        .info_t
        {
            background: #c3dae9;
            border-bottom: 1px solid #b0cadb;
            padding: 2px 0 0 6px;
        }
        .info
        {
            padding: 0 6px;
        }
        .info h2
        {
            padding-top: 8px;
            font-size: 16px;
            color: #f00;
        }
        .info ul
        {
            padding: 0px 0px 4px 0px;
            border-bottom: 1px dotted #ccc;
        }
        .info ul li
        {
            color: #666;
        }
        .room
        {
            padding: 3px 6px;
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
        .jianjie
        {
            border-bottom: 1px dotted #ccc;
            padding: 6px 6px 2px 6px;
        }
        .container p
        {
            padding: 8px 0 0 0;
            text-align: center;
        }
        #footer
        {
            padding: 4px 6px;
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
        <h2 class="info_t">
            <%=hr.Title%></h2>
        <div class="info">
            <ul>
                <li>电&nbsp;&nbsp;话：<%=hr.Telnumber%></li>
                <li>车&nbsp;&nbsp;型： <%=hr.Cartype%></li>
                <li>坐位数：<%=hr.Personcount%>   
                </li>
                 <li>联系人：<%=hr.Linkman%>   
                </li>
                <li>价&nbsp;&nbsp;格：<%=hr.Price%>   
                </li>
                
                <br />
              
            </ul>
        </div>
        
        <h2 class="info_t">
            图片</h2>
        <p>
        <img src="<%=hr.Logo%>" width="120"
                        alt="" />
                        <br />
            <asp:Repeater ID="dlPics" runat="server">
                <ItemTemplate>
                    <img src="<%# DataBinder.Eval(Container.DataItem, "smallimgfile")%>" width="120"
                        alt="" /><br />
                </ItemTemplate>
            </asp:Repeater>
        </p>
        <h2 class="info_t">
            介绍</h2>
        <div class="jianjie">
            <%=hr.Content%>
        </div>
        <div id="footer">
            <a href="javascript:history.go(-1);">返回上页</a> · <a href="index.aspx">返回首页</a>
            · <a href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">版权：游丹霞山&nbsp;<%=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></span>
        </div>
    </div>
</body>
</html>