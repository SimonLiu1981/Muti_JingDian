<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="NewsTypeTree.aspx.cs" Inherits="dx177.WebUI.admin.NewsMgnt.NewsTypeTree" %>

 <%@ Register TagPrefix="radT" Namespace="Telerik.WebControls" Assembly="RadTreeView.Net2" %>
<%@ Register TagPrefix="radm" Namespace="Telerik.WebControls" Assembly="RadMenu.NET2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
  	<LINK href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="/js/jquery-1.3.2.min.js" type="text/javascript"></script>

    

    <script type="text/javascript">
         
        function validation(flag) {

            if ($('#txtTitle').val() == '') {
                $('#txtTitle').focus();
                alert("请输入类型名！");
                return false;
            }
             

        }
    </script>

    <script type="text/javascript">
        //<!--
        function ShowRadMenu(node, e) {
            var menu = null;

            if (node.Category == "Folder") {

                menu = window["<%= RadMenu2.ClientID %>"];
            }
            else {

                menu = window["<%= RadMenu1.ClientID %>"];
            }
            if (menu) {
                menu.Show(e);
                e.cancelBubble = true;
                if (e.stopPropagation) {
                    e.stopPropagation();
                }
                e.returnValue = false;
                if (e.preventDefault) {
                    e.preventDefault();
                }
            }
        }
        function OnClick(sender, eventArgs) {
            var treeView = window["<%=RadTree1.ClientID%>"];
            if (eventArgs.Item.Value == "Rename") {
                treeView.SelectedNode.StartEdit();
                eventArgs.Item.Menu.Hide();
                return false;
            }
            if (eventArgs.Item.Value == "Disable") {
                treeView.SelectedNode.Disable();
                eventArgs.Item.Menu.Hide();
                return false;
            }
            if (eventArgs.Item.Value == "Enable All") {
                for (var i = 0; i < treeView.AllNodes.length; i++) {
                    treeView.AllNodes[i].Enable();
                }
                eventArgs.Item.Menu.Hide();
                return false;
            }
            if (eventArgs.Item.Value == "Expand") {
                treeView.SelectedNode.Expand();
                eventArgs.Item.Menu.Hide();
                return false;
            }
            if (eventArgs.Item.Value == "Collapse") {
                treeView.SelectedNode.Collapse();
                eventArgs.Item.Menu.Hide();
                return false;
            }
        }
        //-->
    </script>

    <style type="text/css">
        .module
        {
            border-right: 1px solid #B4C9F1;
            background: #EAF0FB;
            border-left: 1px solid #B4C9F1;
            border-bottom: 1px solid #B4C9F1;
            border-top: 1px solid #B4C9F1;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="98%" border="0" cellpadding="0" cellspacing="0" style="margin: 0px 5px">
            <tr>
                <td colspan="3" style="border-left: 1px solid #d4d4d4; border-right: 1px solid #d4d4d4;
                    border-bottom: 1px solid #d4d4d4;">
                    <table id="Table1" width="100%" cellspacing="0" cellpadding="0">
                        <tr>
                            <td align="left" colspan="2" style="padding: 5px 2px;">
                                <input type="hidden" id="SerId" runat="server" />
                                <font color="red"><strong>选择选中产品类型，鼠标右键进行编辑！</strong> </font>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" style="padding: 0 0px 0 1px; width: 25%">
                                <div class="module" style="width: 100%;">
                                    <radT:RadTreeView ID="RadTree1" runat="server" Skin="Telerik" BeforeClientContextMenu="ShowRadMenu"
                                        OnNodeEdit="RadTree1_NodeEdit1" OnNodeClick="RadTree1_NodeClick" AutoPostBack="True">
                                    </radT:RadTreeView>
                                </div>
                                <radm:RadMenu ID="RadMenu1" runat="server" IsContext="True" Skin="Office2007" OnClientItemClicking="OnClick"
                                    ContextMenuElementID="none" OnItemClick="RadMenu1_ItemClick1">
                                    <Items>
                                        <radm:RadMenuItem Text="删除" Value="Delete" />
                                        <radm:RadMenuItem Text="重名" Value="Rename" />
                                        <radm:RadMenuItem Text="增加子级" Value="AddSubLevel" />
                                        <radm:RadMenuItem Text="增加同级" Value="AddSameLevel" />
                                    </Items>
                                </radm:RadMenu>
                                <radm:RadMenu ID="RadMenu2" runat="server" IsContext="True" Skin="Office2007" OnClientItemClicking="OnClick"
                                    ContextMenuElementID="none" OnItemClick="RadMenu1_ItemClick1">
                                    <Items>
                                        <radm:RadMenuItem Text="删 除" Value="Delete" />
                                        <radm:RadMenuItem Text="重 名" Value="Rename" />
                                        <radm:RadMenuItem Text="增加子级" Value="AddSubLevel" />
                                        <radm:RadMenuItem Text="增加同级" Value="AddSameLevel" />
                                    </Items>
                                </radm:RadMenu>
                            </td>
                            <td valign="top" valign="top" style="padding: 0 0 0 5px; width: 75%">
                                <table id="Table2" class="tb_input" width="100%" cellspacing="1">
                                    <tr>
                                        <td colspan="2" class="td_head">
                                            内容信息
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            名称                                         </td>
                                        <td class="td_detail">
                                            <asp:TextBox ID="txtTitle" runat="server" Width="424px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            简介</td>
                                        <td class="td_detail">
                                            <asp:TextBox ID="txtShortcontent" runat="server" Width="424px" Height="48px" 
                                                TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            内容</td>
                                        <td class="td_detail">
                                            <asp:TextBox ID="txtContent" runat="server" Width="563px" Height="145px" 
                                                TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td class="td_title" width="15%">
                                            代码</td>
                                        <td class="td_detail">
                                            <asp:TextBox ID="txtCode" runat="server" Width="70px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="center">
                                            <asp:Button ID="btnSave" CssClass="btn02" runat="server" Enabled="false" onmouseover="this.className='btn04'"
                                                onmouseout="this.className='btn02'" Text="保存" OnClientClick="return validation(1);"
                                                OnClick="btnSave_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>