<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JingQuManager.aspx.cs" Inherits="dx177.WebUI.admin.UserMgnt.JingQuManager" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="../../js/jQuery.Inputlimitor.js" type="text/javascript"></script>
    <script>
        $(document).ready(function() {


        });
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                if ($("#txtTitle").val() == '') {
                    alert("请输入标题!");
                    $("#txtTitle").focus();
                    return false;
                }                
                
                var oEditor = FCKeditorAPI.GetInstance('fckContent');
                var editorValue = oEditor.GetHTML();
                if (editorValue == '') {
                    alert("请输入内容!");
                    oEditor.Focus();
                    return false;
                }
            }
            else {
            }
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
                                            域名绑定<asp:HiddenField ID="txtGuid" runat="server" />
                                        </td>
                                    </tr>
                                    
                                     <tr>                                        
                                        <td class="td_title" width="15%">
                                           管辖景区：                                         </td>
                                        <td colspan="1">
                                            <asp:DropDownList ID="ddlJingQus" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="td_title" width="15%">
                                            密码：</td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtPassword" limitorlength=10 runat="server" Width=133px  ></asp:TextBox>
                                        </td>
                                    </tr>
                                    
                                     <tr>
                                        <td class="td_title" width="15%">
                                            姓名：</td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtName" runat="server" Width=133px  ></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            邮箱：</td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtMailBox" runat="server" Width=133px  ></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            手机：</td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtMobile" runat="server" Width=133px  ></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            电话：                                         </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtPhone" runat="server" Width=128px  ></asp:TextBox>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td class="td_title" width="15%">
                                            简述：
                                        </td>
                                        <td colspan="3">
                                             <asp:TextBox ID="txtShortcontent" runat="server" Height="45px" Rows="4" 
                                                 TextMode="MultiLine" Width="384px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                                  <table width="100%">
                                    <tr>
                                        <td align="right" width="100%">
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="保存" OnClientClick="return ValidationInput(1)"
                                                OnClick="btnSave_Click"></asp:Button><asp:Button ID="btnReturn" OnClientClick="return ValidationInput(0)"
                                                    runat="server" CssClass="button" Text="返回" OnClick="btnReturn_Click"></asp:Button>
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
