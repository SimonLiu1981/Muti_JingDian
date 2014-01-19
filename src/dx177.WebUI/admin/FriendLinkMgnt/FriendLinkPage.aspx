<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FriendLinkPage.aspx.cs"
    Inherits="dx177.WebUI.admin.FriendLinkMgnt.FriendLinkPage" %>

<%@ Import Namespace="System.ComponentModel" %>
<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc2" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="../../usercontrols/UCModelType.ascx" TagName="UCModelType" TagPrefix="uc3" %>
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
                    当前位置：友情管理<span class="arrow_subtitle">&gt;</span>友情发布</div>
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
                                                <font face="宋体">标题</font>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtTitle" runat="server" Width="358px"></asp:TextBox>
                                                <asp:HiddenField ID="txt1Guid" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                类型</td>
                                            <td>
                                                <asp:DropDownList ID="dropType" runat="server" Width="149px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                链接地址
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtLink" runat="server" Width="358px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                logo
                                            </td>
                                            <td>
                                                <uc2:UCSingleImgUpload ID="UCSingleImgUpload1" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                简介
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtShowcontent" runat="server" Rows="3" TextMode="MultiLine" Width="674px"
                                                    Height="87px"></asp:TextBox>
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
