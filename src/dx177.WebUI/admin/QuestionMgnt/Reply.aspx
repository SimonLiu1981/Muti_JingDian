<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reply.aspx.cs" Inherits="dx177.WebUI.admin.QuestionMgnt.Reply" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="/js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>

    <script src="/Plugin/dingcai/dingcai.js" type="text/javascript"></script>

    <script type="text/javascript" language="javascript">
        var  editor1;
         KindEditor.ready(function(K) {
            editor1 = K.create('#fckContent', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                allowFileManager: true,
                afterCreate: function() {
                    var self = this;
                    K.ctrl(document, 13, function() {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function() {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                }
            });
           
        });
        $(document).ready(function() {


        });
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                if ($("#fckContent").val() == '') {
                    alert("请输入回答内容!");
                    $("#fckContent").focus();
                    return false;
                }
                
               
                 
            }
            else {
            }
        }

        function UpdateReply() {                       
            var seqno = <%=Seqno %>;
            editor1.sync();       
            var content = $('#fckContent').val();
            
            var pguid ='<%=pguid%>';            
            var isRight = $('#chkIsRight').attr('checked');            
            
            $.ajax({
              url: "../ajaxSubmit.aspx?MethodName=ReplyQuestionSubmit",
              type: "POST",
              data:{ pguid : pguid, isRight:isRight,content:encodeURIComponent(content) ,seqno:seqno},
              dataType:"json",
              async: false,
              success: function(html){
               if (html)
               {
                    alert("保存成功！");
               }
               else
               {
                    alert("保存失败！");
               }
              }
            });           
            parent.location.href=parent.location.href;
            return false;
        }
        
        function ReturnB() {
            parent.location.href=parent.location.href;            
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
                                            回答问题<asp:HiddenField ID="txtGuid" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            问题标题
                                        </td>
                                        <td colspan="3">
                                            <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            问题内容
                                        </td>
                                        <td colspan="3">
                                            <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            回答
                                        </td>
                                        <td colspan="3">
                                            <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 500px;
                                                height: 200px; visibility: hidden;"></textarea>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            顶（good）
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtGood" runat="server" Width="50px">0</asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            坏（bad）
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtBad" runat="server" Width="50px">0</asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            标识为正解答复
                                        </td>
                                        <td colspan="3">
                                            <asp:CheckBox ID="chkIsRight" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                                <table width="100%">
                                    <tr>
                                        <td align="right" width="100%">
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="保存" OnClientClick="return UpdateReply()"
                                                OnClick="btnSave_Click"></asp:Button><asp:Button ID="btnReturn" OnClientClick="return ReturnB();"
                                                    runat="server" CssClass="button" Text="返回"></asp:Button>
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
