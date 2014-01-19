<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusIssueTypeList.aspx.cs" Inherits="dx177.WebUI.admin.NewsMgnt.BusIssueTypeList" %>


<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>图片列表</title>

    <script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" src="/plugin/jquery.tools/jquery.tools.min.js"></script>

    <link rel="stylesheet" type="text/css" href="/plugin/fancybox/jquery.fancybox-1.3.4.css"
        media="screen" />

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
        function ValidationInput() {
            if ($('#txtTypeName').val() == '') {
                alert("请输入类型。");
                return false;
            }
            return true;
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
                    <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" OnItemCommand="dgNews_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Bus_Issue_Type_Id" HeaderText="Bus_Issue_Type_Id"></asp:BoundColumn>                             
                            <asp:BoundColumn DataField="Bus_Issue_Type_Name" HeaderText="文章类型"></asp:BoundColumn>
                             
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Modify" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Bus_Issue_Type_Id") %>'>修改</asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick='return confirm("是否删除文章类型？")'
                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Bus_Issue_Type_Id") %>'>删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <HeaderStyle CssClass="tr_title"></HeaderStyle>
                        <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                        <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                    </cc1:ZteGrid>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="新增景区" CssClass="button" 
                        onclick="btnAdd_Click" Width="200px" />
                </td>
            </tr>
            <tr>
                <td runat="server" id='tdEdit' visible="false">
                    <table cellspacing="0" width="100%" cellpadding="0">
                        <tr>
                            <td>
                                <table class="tb_input" id="queryPane" cellspacing="1" cellpadding="0" width="100%"
                                    align="center" bgcolor="#ffffff" border="0">
                                    <tbody>
                                        <tr>
                                            <td colspan="4">
                                                <img src="../Img/showtoc.gif">
                                                文章类型信息
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                &nbsp;景区名<asp:HiddenField ID="txtIssueTypeID" runat="server" />
                                            </td>
                                            <td>
                                                <asp:Label ID="lblJingQuName" runat="server" Text="Label"></asp:Label> 
                                            </td>
                                            <td class="td_title" width="15%">
                                                文章类型
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtTypeName" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table width="100%">
                        <tr>
                            <td align="right" width="100%">
                                <asp:Button ID="btnSave" OnClientClick="return ValidationInput();" runat="server"
                                    CssClass="button" Text="保存" OnClick="btnSave_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
