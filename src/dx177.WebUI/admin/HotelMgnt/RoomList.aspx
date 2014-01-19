<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomList.aspx.cs" Inherits="dx177.WebUI.admin.HotelMgnt.RoomList" %>
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
                    当前位置：酒店管理<span class="arrow_subtitle">&gt;</span>酒店列表</div>
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
                                    酒店类型
                                </td>
                                <td class="detail" width="24%">
                                    <span class="td_detail">
                                        <asp:DropDownList ID="drHotelType" runat="server" Width="142px">
                                        </asp:DropDownList>
                                    </span>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    酒店名                                 </td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtName" runat="server" Width="267px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap width="9%">
                                    价格区间</td>
                                <td class="detail" width="24%">
                                    <asp:TextBox ID="txtMinPrice" runat="server" Width="67px"></asp:TextBox>
                                    &nbsp;到<asp:TextBox ID="txtMaxPrice" runat="server" Width="69px"></asp:TextBox>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    发布时间   <td class="td_detail" width="23%">
                                    <cc2:DateTextBox ID="dateBegin" runat="server"></cc2:DateTextBox>
                                    到<cc2:DateTextBox ID="dateEnd" runat="server"></cc2:DateTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="4">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="Button" OnClick="btnSearch_Click">
                                    </asp:Button><font face="宋体">&nbsp;</font>
                                    <asp:Button ID="btnAdd" runat="server" Text="新增" CssClass="Button" OnClick="btnAdd_Click">
                                    </asp:Button><font face="宋体">&nbsp;</font>
                              
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    
                    
                    <cc1:ZteGrid ID="dgHotel" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" 
                        PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgRoom_ItemDataBound" 
                        OnItemCommand="dgRoom_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>                            
                            <asp:TemplateColumn>
                                <HeaderStyle Width="150px" />
                                <HeaderTemplate>
                                    图标
                                </HeaderTemplate>
                                <ItemTemplate>        <asp:Image ID="imgLogo" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Logo") %>'
                                        Width="120px" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Name" HeaderText="酒店名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RoomTitle" HeaderText="房型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Price1" HeaderText="平时价"></asp:BoundColumn>
                               <asp:BoundColumn DataField="Price2" HeaderText="节假日价格"></asp:BoundColumn>
                                
                             
                             
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>    
                                                                                                
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Modify" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>修改</asp:LinkButton>                                                    
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                    &nbsp;
                                    <a href ="RoomPircePage.aspx?RGuid=<%# DataBinder.Eval(Container.DataItem, "guid") %>&HGuid=<%=this.PGUID %>"> 价格设置</a>
                                
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
