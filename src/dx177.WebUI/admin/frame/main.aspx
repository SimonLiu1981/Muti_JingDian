<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="dx177.WebUI.Admin.Frame.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>一起去丹霞 网站后台管理</title>
    <meta name="keywords" content="免费外贸网站,免费购物网站,免费开网店,免费试用,免费商城,免费外贸商城,购物网建设,外贸网建设,公司网站建设,公司内容网站建设,开网店,免费网店,免费开网店,网店实名制,如何开网店,怎样开网店,网店系统,网站建设" />
    <meta name="description" content="免费外贸网站,免费购物网站,免费开网店,免费试用,免费商城,免费外贸商城,购物网建设,外贸网建设,公司网站建设,公司内容网站建设,开网店,免费网店,免费开网店,网店实名制,如何开网店,怎样开网店,网店系统,网站建设" />
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="C#">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">
</head>
<body ms_positioning="GridLayout">
    <form name="Form1" method="post" action="PassWordManager.aspx" id="Form1">
    <input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwUJNzYxNDcyMTc0ZGStHYFC88jEZnMivKUiwpGa6Utj5g==" />
    <input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="/wEWBQKX0KPhAQK3o/22DgL/8OWiAwLF28GfBAKct7iSDD9i2dtQfueooEZhlLHb9MqjzPqU" />
    <table align="center" cellpadding="0" cellspacing="0" id="tb_content">
        <tbody>
            <tr>
                <td>
                    <table class="tb_input" id="queryPane" cellspacing="1" cellpadding="0" width="100%"
                        align="center" bgcolor="#ffffff" border="0">
                        <tbody>
                            <tr>
                                <td colspan="4" nowrap class="td_head">
                                    订单统计信息
                                </td>
                            </tr>
                            <tr>
                                <td nowrap class="td_title" width="18%">
                                    未付款订单
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkWaitePlay" runat="server">0</asp:HyperLink>
                                </td>
                                <td nowrap class="td_title" width="18%">
                                    已付款订单
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkPlayedList" runat="server">0</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td nowrap class="td_title" width="18%">
                                    已发货订单
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkSendList" runat="server">0</asp:HyperLink>
                                </td>
                                <td nowrap class="td_title" width="18%">
                                    已收货订单
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkReceived" runat="server">0</asp:HyperLink>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table class="tb_input" id="Table1" cellspacing="1" cellpadding="0" width="100%"
                        align="center" bgcolor="#ffffff" border="0">
                        <tbody>
                            <tr>
                                <td colspan="4" nowrap class="td_head">
                                    产品信息
                                </td>
                            </tr>
                            <tr>
                                <td nowrap class="td_title" width="18%">
                                    产品总数
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkProductsCount" runat="server">0</asp:HyperLink>
                                </td>
                                <td nowrap class="td_title" width="18%">
                                    新增产品数
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkNewCount" runat="server">0</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td nowrap class="td_title" width="18%">
                                    上架产品数
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkUpCount" runat="server">0</asp:HyperLink>
                                </td>
                                <td nowrap class="td_title" width="18%">
                                    下架产品数
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkDownCount" runat="server">0</asp:HyperLink>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    
                    <table class="tb_input" id="Table2" cellspacing="1" cellpadding="0" width="100%"
                        align="center" bgcolor="#ffffff" border="0">
                        <tbody>
                            <tr>
                                <td colspan="4" nowrap class="td_head">
                                    消息统计
                                </td>
                            </tr>
                            <tr>
                                <td nowrap class="td_title" width="18%">
                                    &nbsp;待回复</td>
                                <td>
                                      <asp:HyperLink ID="lnkNewMsg" runat="server">0</asp:HyperLink>
                                </td>
                                <td nowrap class="td_title" width="18%">
                                    订单消息
                                </td>
                                <td>
                                    <asp:HyperLink ID="lnkOrder" runat="server">0</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td nowrap class="td_title" width="18%">
                                    产品消息
                                </td>
                                <td>
                                      <asp:HyperLink ID="lnkProduct" runat="server">0</asp:HyperLink>
                                </td>
                                <td nowrap class="td_title" width="18%">
                                    网站消息
                                </td>
                                <td>
                                     <asp:HyperLink ID="lnkSystem" runat="server">0</asp:HyperLink>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div align="center">
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
