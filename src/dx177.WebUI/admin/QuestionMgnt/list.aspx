<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.admin.QuestionMgnt.list" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>问题列表</title>

    <script type="text/javascript" src="/web/js/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" src="/web/js/jquery.tools.min.js"></script>

    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script type="text/javascript">

        function SelectAll(strGridId) {
            var objCK = document.getElementsByTagName("input");
            var loop;
            var index = 0;
            var objArray = new Array();

            for (loop = 1; loop < objCK.length; loop++) {
                if (objCK[loop].type == "checkbox") {
                    if (objCK[loop].id.indexOf(strGridId) != -1) {
                        objArray[index] = objCK[loop];
                        index++;
                    }
                }
            }
            for (loop = 1; loop < objArray.length; loop++) {
                if (!objArray[loop].disabled) {
                    objArray[loop].click();
                    objArray[loop].checked = objArray[0].checked;
                }
            }
        }
        function CheckSelected(strGridId, isdel) {
            var taskIds;
            var check = false;
            var objCK = document.getElementsByTagName("input");
            var loop;
            var index = 0;
            var objArray = new Array();
            for (loop = 1; loop < objCK.length; loop++) {
                if (objCK[loop].type == "checkbox") {
                    if (objCK[loop].id.indexOf(strGridId) != -1) {
                        objArray[index] = objCK[loop];
                        index++;
                    }
                }
            }

            for (loop = 1; loop < objArray.length; loop++) {
                if (objArray[loop].checked) {

                    check = true;
                }
            }
            if (!check) {
                alert('请至少选择一个数据进行操作！');
                return false;
            }
            if (isdel == 1) {
                return confirm("确认要删除你所选择项吗？");
            }
        }
        
    
    </script>

    <style type="text/css">
        .preview_img img
        {
            border-bottom: #cccccc 2px solid;
            border-left: #cccccc 2px solid;
            width: 168px;
            height: 68px;
            border-top: #cccccc 2px solid;
            border-right: #cccccc 2px solid;
        }
    </style>
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置： 问题列表</div>
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
                                    请填写查询条件
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap style="width: 4%">
                                    标题
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtName" runat="server" Width="233px"></asp:TextBox>
                                </td>
                                <td class="td_title" nowrap style="width: 4%">
                                    状态
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:DropDownList ID="ddlStatus" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <asp:Button ID="bntCreatePage" runat="server" Text="生成页面" CssClass="button" OnClick="bntCreatePage_Click">
                                    </asp:Button>
                                </td>
                                <td align="right" colspan="3">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="button" OnClick="btnSearch_Click">
                                    </asp:Button>
                                    <asp:Button runat="server" ID="btnAdd" Text="增加" CssClass="button" OnClick="btnAdd_Click" />
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
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="50px" />
                                <HeaderTemplate>
                                    <asp:CheckBox ID="chkAll" runat="server" Text="全选" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkGrid" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Title" HeaderText="标题"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="150px" />
                                <HeaderTemplate>
                                    类型
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblQtype" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Qtype") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Content" Visible="false" HeaderText="内容"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="150px" />
                                <HeaderTemplate>
                                    状态
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Status") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Creator" HeaderText="创建人">
                                <HeaderStyle Width="100px" />
                            </asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnRelate" runat="server" CommandName="Relate" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>联关问题管理</asp:LinkButton>
                                    
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Modify" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>修改</asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('确认删除该饭店吗？')"
                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                        
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
