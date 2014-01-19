<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.admin.ImgMgnt.list" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>图片列表</title>    

<script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>
<script type="text/javascript" src="/plugin/jquery.tools/jquery.tools.min.js"></script>
<link rel="stylesheet" type="text/css" href="/plugin/fancybox/jquery.fancybox-1.3.4.css" media="screen" />
<script type="text/javascript" src="/plugin/fancybox/jquery.fancybox-1.3.4.pack.js"></script> 
<link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />
<script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

    
    
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">
    <script type="text/javascript">
        $(document).ready(function() {
            $("a[rel=showGrop]").fancybox({
                'transitionIn': 'none',
                'transitionOut': 'none',
                'titlePosition': 'over',
                'titleFormat': function(title, currentArray, currentIndex, currentOpts) {
                    return '<span id="fancybox-title-over">图像： ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';
                }
            });
        });
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
        function ModifyImage(picSeqno) {
            var url = "/usercontrols/changeImageInfo.aspx?picSeqno=" + picSeqno + "&TB_iframe=true&height=300&width=420&modal=true";
            ShowPopup(url);
        }

        function UCGetPicsList() {
            $('#btnSearch').click();
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
                                    是否被用
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:RadioButtonList ID="rbtList1" runat="server"  RepeatDirection=Horizontal>
                                        <asp:ListItem Text = "全部" Value = "" Selected></asp:ListItem>
                                        <asp:ListItem Text = "被用" Value = "1"></asp:ListItem>
                                        <asp:ListItem Text = "未用" Value = "0"></asp:ListItem>
                                        
                                    </asp:RadioButtonList>
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
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>
                            
                             <asp:TemplateColumn>
                                <HeaderStyle Width="30px" />
                                <HeaderTemplate>
                                    <asp:CheckBox ID="cbxAll" runat="server" ToolTip="全选/全否选" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="cbItem" runat="server" /><asp:HiddenField ID="txtSeqno" Value='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'
                                        runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>                            
                            <asp:TemplateColumn>
                                <HeaderStyle Width="200px" />
                                <HeaderTemplate>
                                    产品外观
                                </HeaderTemplate>
                                <ItemTemplate>                                                                        
                                     <asp:HyperLink id='HyperLink1' class='preview_img' runat="server"></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Title" HeaderText="标题"></asp:BoundColumn>
                             <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    是否被用
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" id='lblUsed' Text=""></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Creator"   HeaderText="创建人">
                            <HeaderStyle Width="100px" />
                            </asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>    
                                    <a href="javascript:;"  onclick='ModifyImage("<%# DataBinder.Eval(Container.DataItem, "Seqno") %>")' >修改</a>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick='return confirm("是否删除图片？")' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
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
     <table width="100%" style="margin-top: 5px">
        <tr>
            <td>
                 
                <asp:Button ID="btnDel" runat="server" CssClass="button3" Text="删除选中"  OnClientClick='return CheckSelected("dgNews",1)'
                    onclick="btnDel_Click" />
            </td>
        </tr>
    </table>
    
    </form>
</body>
</html>
