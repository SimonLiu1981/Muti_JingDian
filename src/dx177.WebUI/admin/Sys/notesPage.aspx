<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notesPage.aspx.cs"   ValidateRequest="false"  Inherits="dx177.WebUI.admin.Sys.notesPage" %>
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
    
    <script type ="text/javascript">

        function checkInput() {

        }
    
    </script>

</head>
<body ms_positioning="GridLayout" id="thebody">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：公告<span class="arrow_subtitle">&gt;公告设置</span></div>
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
                                            <td colspan="2">
                                                <img src="../Img/showtoc.gif">信息
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                &nbsp;订单页面成功提示：</td>
                                            <td>
                                                <asp:TextBox ID="txtOrderAlertDescr" runat="server" Width="525px" Height="154px" 
                                                    TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                订单页的提交按钮提示</td>
                                            <td>
                                                <asp:TextBox ID="txtOrderButtonDescr" runat="server" Width="525px" Height="154px" 
                                                    TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                公告&nbsp;
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNoteDescr" runat="server" Width="525px" Height="154px" 
                                                    TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                订单按钮是否显示</td>
                                            <td>
                                                <asp:CheckBox ID="chkIsshow" runat="server" />
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
                                <asp:Button ID="btnSave" OnClientClick="return checkInput();" runat="server" CssClass="Button"
                                    Text="保存" OnClick="btnSave_Click"></asp:Button>
                                <asp:Button ID="btnReturn" runat="server" CssClass="Button" Text="返回"></asp:Button>
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
