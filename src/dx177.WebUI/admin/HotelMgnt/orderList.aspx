<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderList.aspx.cs" Inherits="dx177.WebUI.admin.HotelMgnt.orderList" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>租车列表</title>

    <script type="text/javascript" src="/web/js/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" src="/web/js/jquery.tools.min.js"></script>

    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">
    <link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

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

        function RefashData() {
            $('#btnSearch').click();
        }

        function ModifyHotelOrder(seqno) {
            var url = "/admin/hotelmgnt/orderview.aspx?seqno=" + seqno + "&TB_iframe=true&height=600&width=820&modal=true";
            ShowPopup(url);
        }


        function Button1_onclick() {
            $('#txtOrderNO').val('');
            $('#dateBegin').val('');
            $('#dateEnd').val('');
            $('#txtHoteltitle').val('');
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
                    当前位置：租车管理<span class="arrow_subtitle">&gt;</span>租车列表</div>
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
                                    订单编号
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtOrderNO" runat="server" Width="120px"></asp:TextBox>
                                </td>
                                <td class="td_title" nowrap style="width: 4%">
                                    订单状态
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection="Horizontal">
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap style="width: 4%">
                                    入住日期
                                </td>
                                <td class="td_detail" width="23%">
                                    <cc2:DateTextBox ID="dateBegin" runat="server"></cc2:DateTextBox>
                                    到<cc2:DateTextBox ID="dateEnd" runat="server"></cc2:DateTextBox>
                                </td>
                                <td class="td_title" nowrap style="width: 4%">
                                    酒店名
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtHoteltitle" runat="server" Width="180px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="4">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="button" OnClick="btnSearch_Click">
                                    </asp:Button>
                                    <input id="Button1" type="button" class="button" value="清除" onclick="return Button1_onclick()" />
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
                            <asp:BoundColumn DataField="OrderNo" HeaderText="订单编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="OrderUserName" HeaderText="预订姓名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="personphone" HeaderText="预订电话"></asp:BoundColumn>
                            <asp:BoundColumn DataField="HotelName" HeaderText="酒店名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RoomTitle" HeaderText="房间名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="BeginDate" HeaderText="入住日期"></asp:BoundColumn>
                            <asp:BoundColumn DataField="EndDate" HeaderText="离开日期"></asp:BoundColumn>
                            <asp:BoundColumn DataField="CREATEDATE" HeaderText="创建时间"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    状态
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Status") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <a href="javascript:;" onclick='ModifyHotelOrder("<%# DataBinder.Eval(Container.DataItem, "Seqno") %>")'>
                                        修改</a>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('确认删除该订单吗？')"
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
