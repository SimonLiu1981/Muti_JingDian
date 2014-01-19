<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JingquManagementNavigation.aspx.cs"
    Inherits="dx177.WebUI.admin.JingquManagementNavigation" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>景区管理</title>
    <link href="css/cssCn.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
    <table id="tb_content" width="50%" cellspacing="0" cellpadding="0" align="center">
        <tbody>
            <tr>
                <td>
                    <asp:HyperLink ID="linkToManagement" NavigateUrl="frame/Index.aspx" runat="server">系统管理</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" PageSize="50" OnItemCommand="dgNews_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="JingQu_ID" HeaderText="JingQuID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="JingQuName" HeaderText="景区名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="JingQuCode" HeaderText="景区编码"></asp:BoundColumn>
                            <asp:BoundColumn DataField="MatchDomain" HeaderText="比配二级域名"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Manage" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JingQuCode") %>'>管理景区</asp:LinkButton>
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
</html>
