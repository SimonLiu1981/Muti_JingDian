<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sumarylist.aspx.cs" Inherits="dx177.WebUI.admin.CommentMgnt.sumarylist" %>


<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>图片列表</title>    

<script type="text/javascript" src="/web/js/jquery-1.3.2.min.js"></script>
   
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">
    <script type="text/javascript">
        
    </script>
 
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table id="tb_content" cellspacing="0" cellpadding="0" align="center">
        <tbody>
            <tr>
                <td>
                    
                    <table class="tb_searchbar" cellspacing="1" width="100%">
                        <tbody>
                            <tr>
                                <td class="td_head" colspan="4">
                                    请填写查询条件
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap style="width: 4%">
                                    点评对象
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtTitle" runat="server" Width="233px"></asp:TextBox>
                                </td>
                                 <td class="td_title" nowrap style="width: 4%">
                                    过滤条件
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:CheckBox ID="cbxIsnew" Checked=true runat="server"  Text='新评论'/>
                                    <asp:CheckBox ID="cbxIsnoreply" runat="server" Text='未答复' />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="4">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="button" OnClick="btnSearch_Click">
                                    </asp:Button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" OnItemCommand="dgNews_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="guid" HeaderText="guid"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="objtype" HeaderText="objtype"></asp:BoundColumn>
                                                        
                            <asp:TemplateColumn>
                                <HeaderStyle />
                                <HeaderTemplate>
                                    点评对象
                                </HeaderTemplate>
                                <ItemTemplate>                                                                        
                                    <asp:HyperLink ID="lnkTitle" CssClass=normal runat="server"><%# DataBinder.Eval(Container.DataItem, "ObjTitle") %></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                             <asp:TemplateColumn>
                                <HeaderStyle />
                                <HeaderTemplate>
                                    总点评数
                                </HeaderTemplate>
                                <ItemTemplate>                                                                        
                                    <asp:HyperLink ID="lnkAllCount" CssClass=normal runat="server"><%# DataBinder.Eval(Container.DataItem, "总点评数") %></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle />
                                <HeaderTemplate>
                                    新点评数
                                </HeaderTemplate>
                                <ItemTemplate>                                                                        
                                    <asp:HyperLink ID="lnkNewCount" CssClass=normal runat="server"><%# DataBinder.Eval(Container.DataItem, "新点评")%></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle />
                                <HeaderTemplate>
                                    未答复点评数
                                </HeaderTemplate>
                                <ItemTemplate>                                                                        
                                    <asp:HyperLink ID="lnkNoReplyCount" CssClass=normal runat="server"><%# DataBinder.Eval(Container.DataItem, "未答复点评")%></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>    
                                    <asp:HyperLink ID="lnkAllCount1" runat="server">查看</asp:HyperLink>
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
