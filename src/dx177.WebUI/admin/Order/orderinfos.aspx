<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderinfos.aspx.cs" Inherits="dx177.WebUI.admin.Order.orderinfos" %>
 <%@ Register assembly="COM.ZTE.TPG.App.UI.WebForm" namespace="COM.ZTE.TPG.App.UI.WebForm" tagprefix="cc1" %>
 <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>酒店列表</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../css/cssCn1.css" type="text/css" rel="stylesheet">
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script type="text/javascript">

        function ValidationInput() {
            if ($("#txtName").val() == '') {
                alert("请输入酒店名!");
                $("#txtName").focus();
                return false;
            }
            if ($("#drpHoteltype").val() == '') {
                alert("请选择酒店类型!");
                $("#drpHoteltype").focus();
                return false;
            }
            
        }
    
    </script>

    <style type="text/css">
        .style1
        {
            height: 27px;
        }
    </style>

</head>
<body ms_positioning="GridLayout" id="thebody">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：订单管理<span class="arrow_subtitle">&gt;</span>详细订单</div>
            </td>
        </tr>
    </table>
    <table id="tb_content" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td>
                    <table id="tb_content" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <table class="tb_input" id="queryPane" cellspacing="1" cellpadding="0" width="100%"
                                    align="center" bgcolor="#ffffff" border="0">
                                    <tbody>
                                        <tr>
                                            <td colspan="4">
                                                <img src="../Img/showtoc.gif">
                                                详细订单</td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                标题
                                            </td>
                                            <td colspan="3">
                                                <asp:Label ID="lbOrderTitle" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                手机                                             </td>
                                            <td>
                                                <asp:Label ID="lbReceivePhone" runat="server"></asp:Label>
                                            </td>
                                            <td class="td_title" width="15%">
                                                电话
                                            </td>
                                            <td>
                                                <asp:Label ID="lbReceiveTel" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                邮件方式</td>
                                            <td>
                                                <asp:Label ID="lbShipment" runat="server"></asp:Label>
                                            </td>
                                            <td class="td_title" width="15%">
                                                付款方式</td>
                                            <td>
                                                <asp:Label ID="lbMypayment" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                产产品金额</td>
                                            <td>
                                                <asp:Label ID="lbProductTMoney" runat="server"></asp:Label>
                                            </td>
                                            <td class="td_title" width="15%">
                                                快递金额</td>
                                            <td>
                                                <asp:Label ID="lbMailMoney" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%" style="height: 27px">
                                                总金额</td>
                                            <td colspan="3" class="style1">
                                                <asp:Label ID="lbTotalMoney" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%" style="height: 27px">
                                                收货地址</td>
                                            <td colspan="3" class="style1">
                                                <asp:Label ID="lbReceiveAddress" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%" style="height: 27px">
                                                备注</td>
                                            <td colspan="3" class="style1">
                                                <asp:Label ID="lbRemark" runat="server"></asp:Label>
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
                    
                    
                    <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" 
                        PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Order_Apply_Item_ID" HeaderText="Order_Apply_Item_ID"></asp:BoundColumn>                            
                          
                            <asp:BoundColumn DataField="Product_Name" HeaderText="标题"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Unit_Price" HeaderText="单价"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Count" HeaderText="数量"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Tatol" HeaderText="金额"></asp:BoundColumn>
                        
                        </Columns>
                        <HeaderStyle CssClass="tr_title"></HeaderStyle>
                        <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                        <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                    </cc1:ZteGrid>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" width="100%">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
