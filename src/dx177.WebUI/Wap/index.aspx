<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="dx177.WebUI.Wap.index" %>
  

<?xml version="1.0" encoding="utf-8" ?>
<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN" "http://www.wapforum.org/DTD/xhtml-mobile10.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>
        丹霞山手机网_酒店预订_丹霞山手机订房 - 游丹霞山</title>
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
            酒店推荐</h2>
        <div class="info">
           <table width="100%" border="0" cellspacing="0" cellpadding="0">
               <asp:Repeater ID="rphotel" runat="server">
               <ItemTemplate>
                <tr>
                            <td>
                              <a href="hotel.aspx?seqno=<%# DataBinder.Eval(Container.DataItem, "seqno") %>"><%# DataBinder.Eval(Container.DataItem, "Name") %></a>   [<%#dx177.Business.DictBus.Dict.Tag["Area", DataBinder.Eval(Container.DataItem, "area").ToString(), 2052]%>]
                            </td>
                            <td align="left">
                                <span class="f_f00">
                                    <%# DataBinder.Eval(Container.DataItem, "minprice") %></span>元起  
                            </td>
                        </tr>
               </ItemTemplate>
               </asp:Repeater>
              
            </table>
        </div>
        
         <h2 class="info_t">
            经济型宾馆</h2>
        <div class="info">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
               <asp:Repeater ID="rpcphotel" runat="server">
               <ItemTemplate>
                <tr>
                            <td>
                              <a href="hotel.aspx?seqno=<%# DataBinder.Eval(Container.DataItem, "seqno") %>"><%# DataBinder.Eval(Container.DataItem, "Name") %></a>   [<%#dx177.Business.DictBus.Dict.Tag["Area", DataBinder.Eval(Container.DataItem, "area").ToString(), 2052]%>]
                            </td>
                            <td align="left">
                                <span class="f_f00">
                                    <%# DataBinder.Eval(Container.DataItem, "minprice") %></span>元起  
                            </td>
                        </tr>
               </ItemTemplate>
               </asp:Repeater>
              
            </table>
        </div>
        
        
        <h2 class="info_t">
            旅游租车</h2>
        <div class="room">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
               <asp:Repeater ID="rphire" runat="server">
               <ItemTemplate>
                <tr>
                            <td>
                              <a href="hircar.aspx?seqno=<%# DataBinder.Eval(Container.DataItem, "seqno") %>"><%# DataBinder.Eval(Container.DataItem, "Title")%></a> 
                            </td>
                            <td align="left">
                                <span class="f_f00">
                                  电话  <%# DataBinder.Eval(Container.DataItem, "telnumber")%></span>   
                            </td>
                        </tr>
               </ItemTemplate>
               </asp:Repeater>
              
            </table>
        </div>
        
        
              <h2 class="info_t">
            旅游购物</h2>
        <div class="room">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
               <asp:Repeater ID="rplist" runat="server">
               <ItemTemplate>
                <tr>
                            <td>
                                <a href="P.aspx?seqno=<%# DataBinder.Eval(Container.DataItem, "seqno") %>"><%# DataBinder.Eval(Container.DataItem, "TITLE") %></a>
                            </td>
                            <td align="left">
                                <span class="f_f00">
                                   <%# DataBinder.Eval(Container.DataItem, "NOWPRICE")%></span>元   </span>   
                            </td>
                        </tr>
               </ItemTemplate>
               </asp:Repeater>
              
            </table>
        </div>
        
        
        
              <div id="page">
            
              
        </div>
        <div id="footer">
             <a href="javascript:history.go(-1);">返回上页</a> · <a href="index.aspx">返回首页</a>
            · <a href="srh_order.aspx">查询订单</a><br />
            <span class="f_12">版权：游丹霞山&nbsp;<%=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></span>
        </div>
    </div>
</body>
</html>
