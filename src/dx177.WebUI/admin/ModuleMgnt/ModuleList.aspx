<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuleList.aspx.cs" Inherits="dx177.WebUI.admin.ModuleMgnt.ModuleList" %>
 
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
    
     
    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>
<link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />
<script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

    <script>
        $(document).ready(function() {


        });
       

        function EditReply(seqno) {
            var url = "ModuleEdit.aspx?seqno=" + seqno + "TB_iframe=true&height=500&width=600&modal=true";
            ShowPopup(url);
            return false;
            
        }
    
    </script>
    
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：模块管理<span class="arrow_subtitle">&gt;</span>模块列表</div>
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
                                                                        类型</td>
                                <td class="detail" width="24%">
                                    <span class="td_detail">
                                        <asp:DropDownList ID="drpType" runat="server" Width="142px">
                                            <asp:ListItem Value="" >请选择</asp:ListItem>
                                            <asp:ListItem Value="news">新闻</asp:ListItem>
                                            <asp:ListItem Value="products">产品</asp:ListItem>
                                            <asp:ListItem Value="questions">问题</asp:ListItem>
                                            <asp:ListItem Value="Hotel">酒店</asp:ListItem>
                                            <asp:ListItem Value="room">房间</asp:ListItem>
                                            <asp:ListItem Value="Restaurant">饭店</asp:ListItem>
                                            <asp:ListItem Value="HireCar">租车</asp:ListItem>
                                            <asp:ListItem Value="Shop">店铺</asp:ListItem>
                                        </asp:DropDownList>
                                    </span>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    标题</td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtTitle" runat="server" Width="267px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap width="9%">
                                                                        模块</td>
                                <td class="detail" width="24%">
                                    <asp:DropDownList ID="drpModule" runat="server" Height="23px" Width="142px">
                                    </asp:DropDownList>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    &nbsp;</td>
                                <td class="td_detail" width="23%">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="Button" OnClick="btnSearch_Click">
                                    </asp:Button></td>
                            </tr>
                            <tr>
                                <td align="right" colspan="4">
                                    <asp:Button ID="btnSave0" runat="server" Text="新 增" CssClass="Button" 
                                        OnClientClick='return EditReply(0);' >
                                    </asp:Button>
                                    <br />
                                    <br />
                                    <asp:Button ID="btnSave" runat="server" Text="批量保存" CssClass="Button" 
                                        OnClick="btnSave_Click">
                                    </asp:Button></td>
                            </tr>
                        </tbody>
                    </table>
                    
                    
                    <cc1:ZteGrid ID="dgModule" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" 
                        PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgHotel_ItemDataBound" 
                        OnItemCommand="dgHotel_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>                            
                           
                            <asp:BoundColumn DataField="Title" HeaderText="名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="modulename" HeaderText="类型">
                            <ItemStyle Width=150 />
                            </asp:BoundColumn>
                            
                                <asp:TemplateColumn>
                                <HeaderStyle Width="60px" />
                                <HeaderTemplate>
                                    序列
                                </HeaderTemplate>
                                <ItemStyle Width="60px" />
                                <ItemTemplate>    
                                                                                                  
                                    <asp:TextBox ID="txtShowidx"  Width=60 runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Showidx") %>' ></asp:TextBox>    
                                </ItemTemplate>
                            </asp:TemplateColumn>
                           
                            <asp:TemplateColumn>
                                <HeaderStyle Width="60px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemStyle Width="60px" />
                                <ItemTemplate>  <a href='javascript:;' onclick="EditReply('<%# DataBinder.Eval(Container.DataItem, "Seqno") %>')" >修改</a>                                               
                                              
                                                                                                  
                                          <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
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