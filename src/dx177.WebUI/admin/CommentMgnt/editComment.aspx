<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editComment.aspx.cs" Inherits="dx177.WebUI.admin.CommentMgnt.editComment" %>
<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Src="../../usercontrols/UCJqueryRaty.ascx" TagName="UCJqueryRaty" TagPrefix="uc3" %>

<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script src="/Plugin/dingcai/dingcai.js" type="text/javascript"></script>

    <script> 
        function ValidationInput() {
            if ($("#txtContent").val() == '') {
                alert("请输入回答内容!");
                $("#txtContent").focus();
                return false;
            }
         
        }
        
        function ReturnB() {
            parent.tb_remove();
            return false;
            
        }
        
    </script>
 
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table id="tb_content" cellspacing="0" cellpadding="0" align="center">
        <tbody>
            <tr>
                <td>
                    <table id="tb_content" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <table class="tb_input" id="queryPane" cellspacing="1" cellpadding="0" width="100%"
                                    align="center" bgcolor="#ffffff" border="0">
                                    <tr>
                                        <td colspan="4" class="td_head">
                                            编辑评论<asp:HiddenField ID="txtGuid" runat="server" /><font color=red>(注意：设置是否前台显示)</font>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty1" runat="server" />
                                        </td>
                                        <td class="td_title" width="15%">
                                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty2" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                             <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label> 
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty3" runat="server" />
                                        </td>
                                        <td class="td_title" width="15%">
                                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty4" runat="server" />
                                        </td>
                                    </tr>
                                     
                                    
                                    <tr>
                                        <td class="td_title" width="15%">
                                            点评内容：
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtContent" runat="server" Rows=4 Columns=60 TextMode=MultiLine></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            点评答复：
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtReplyContent" runat="server" Rows=4 Columns=60 TextMode=MultiLine></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            顶（good）
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtGood" runat="server"  Width="50px"
                                                >0</asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            坏（bad）
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtBad" runat="server"  Width="50px"
                                                >0</asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                             是否显示到前台：
                                        </td>
                                        <td colspan="1">
                                            <asp:CheckBox ID="chkIsShow" runat="server" />
                                        </td>
                                         <td class="td_title" width="15%">
                                             创建人：
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtCreator" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                                <table width="100%">
                                    <tr>
                                        <td align="right" width="100%">
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="保存" OnClientClick='return ValidationInput();'  
                                                OnClick="btnSave_Click"></asp:Button><asp:Button ID="btnReturn" OnClientClick="return ReturnB();"
                                                    runat="server" CssClass="button" Text="返回" ></asp:Button>
                                        </td>
                                    </tr>
                                </table>
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
