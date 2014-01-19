<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuletypeEdit.aspx.cs" Inherits="dx177.WebUI.admin.ModuleMgnt.ModuletypeEdit" %>


<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script>
        $(document).ready(function() {


        });
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                if ( $("#dropType").val()  == '') {
                    alert("请选择类型!");
                    return false;
                }


                 
            }
            else {
            }
        }

        function Update() {
           if ( $("#dropType").val()  == '') {
                    alert("请选择类型!");
                    return false;
                }
                
            var seqno = <%=Seqno %>;
            var Title = $('#txtTitle').val() ;
            var Code = $('#txtCode').val() ;
            var Type = $("#dropType").val();           
            var ss = dx177.WebUI.admin.ModuleMgnt.ModuletypeEdit.Update(seqno,Title ,Code ,Type);
            parent.location.href=parent.location.href;
            return false;
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
                                        <td colspan="2" class="td_head">
                                            类型<asp:HiddenField ID="txtGuid" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            标题
                                                                          </td>
                                        <td>
                                            <asp:TextBox ID="txtTitle" runat="server" Width="325px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            编码
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtCode" runat="server" Width="325px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            类型</td>
                                        <td>
                                            <asp:DropDownList  ID="dropType" runat="server" Width="128px">
                                            </asp:DropDownList>
                                            
                                            <asp:HiddenField ID="txtModuleType" runat="server"  Value="ModuleType"/>
                                        </td>
                                    </tr>
                                    </table>
                                <table width="100%">
                                    <tr>
                                        <td align="right" width="100%">
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="保存" OnClientClick="return Update()"
                                               ></asp:Button><asp:Button ID="btnReturn" OnClientClick="return ReturnB();"
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
