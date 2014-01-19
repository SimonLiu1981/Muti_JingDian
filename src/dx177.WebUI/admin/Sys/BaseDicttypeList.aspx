<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaseDicttypeList.aspx.cs" Inherits="dx177.WebUI.admin.Sys.BaseDicttypeList" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
 <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>系统类型</title>
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
                    当前位置：系统类型<span class="arrow_subtitle">&gt;</span>系统类型列表</div>
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
                                    请录入数据点击新增</td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap width="9%">
                                    标题</td>
                                <td class="detail" width="24%">
                                    <asp:TextBox ID="txtTitle" runat="server" Width="267px"></asp:TextBox>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    代号</td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtcode" runat="server" Width="267px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                
                                <td class="td_detail" colspan=4  >
                                    <asp:Button ID="btnAdd" runat="server" Text="新增" CssClass="Button" OnClick="btnAdd_Click">
                                    </asp:Button>
                                </td>
                            </tr>
                            <tr>
                                
                                <td class="td_detail" colspan=4  >
                                    <asp:Button ID="bntAllSave" runat="server" Text="批量保存" CssClass="Button" 
                                        OnClick="bntAllSave_Click">
                                    </asp:Button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    
                    
                    <cc1:ZteGrid ID="dgData" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" 
                        PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgData_ItemDataBound" 
                        OnItemCommand="dgData_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>                            
                          
                                <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    标题
                                </HeaderTemplate>
                                <ItemTemplate>    
                                    <asp:TextBox ID="txtTitle"  Text='<%# DataBinder.Eval(Container.DataItem, "Title") %>'  runat="server"></asp:TextBox>                                                    
                                </ItemTemplate>
                            </asp:TemplateColumn>
                              <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    代号
                                </HeaderTemplate>
                                <ItemTemplate>    
                                    <asp:TextBox ID="txtCode" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Code") %>'></asp:TextBox>                                                    
                                </ItemTemplate>
                            </asp:TemplateColumn>
                             
                             
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>    
                                                                                                
                                                                                      
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('是否删除该记录！')"  CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
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
