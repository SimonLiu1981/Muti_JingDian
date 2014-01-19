<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderlist.aspx.cs" Inherits="dx177.WebUI.admin.Order.orderlist" %>
<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
 <%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
 <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>酒店管理</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../css/cssCn1.css" type="text/css" rel="stylesheet">
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：订单管理<span class="arrow_subtitle">&gt;</span>我的订单</div>
            </td>
        </tr>
    </table>
    <table id="tb_content" cellspacing="0" cellpadding="0" align="center">
        <tbody>
            <tr>
                <td>
                    <table class="tb_searchbar" cellspacing="1" width="100%">
                        <tbody>
                            <tr>
                                <td class="td_head" colspan="4">
                                    &nbsp;请填写查询条件
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap width="9%">
                                    类型
                                </td>
                                <td class="detail" width="24%">
                                    &nbsp;</td>
                                <td class="td_title" nowrap width="12%">
                                    标题                                 </td>
                                <td class="td_detail" width="23%">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right" colspan="4">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="Button" OnClick="btnSearch_Click">
                                    </asp:Button><font face="宋体">&nbsp;</font> <font face="宋体">&nbsp;</font>
                              
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    
                    
                    <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" 
                        PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" 
                        OnItemCommand="dgNews_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Order_Apply_ID" HeaderText="Seqno"></asp:BoundColumn>                            
                          
                            <asp:BoundColumn DataField="Order_Title" HeaderText="标题"></asp:BoundColumn>
                            <asp:BoundColumn DataField="receive_Phone" HeaderText="电话"></asp:BoundColumn>
                            <asp:BoundColumn DataField="receive_Tel" HeaderText="手机"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Total_money" HeaderText="金额"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ShipMent" HeaderText="邮件方式"></asp:BoundColumn>
                            
                              <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    浏览
                                </HeaderTemplate>
                                <ItemTemplate>    
                                <a href="orderinfos.aspx?Order_Apply_ID=<%# DataBinder.Eval(Container.DataItem, "Order_Apply_ID") %>">点击 </a>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                             
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>    
                                                                                                
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Modify" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Order_Apply_ID") %>'>修改</asp:LinkButton>                                                    
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('是否删除该记录！')"  CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Order_Apply_ID") %>'>删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <HeaderStyle CssClass="tr_title"></HeaderStyle>
                        <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                        <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                    </cc1:ZteGrid>
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>