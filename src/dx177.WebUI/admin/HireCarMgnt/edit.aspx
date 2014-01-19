<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" ValidateRequest="false"
    Inherits="dx177.WebUI.admin.HireCarMgnt.eidt" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Src="../../usercontrols/UCModelType.ascx" TagName="UCModelType" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script type="text/javascript">

        var editor1 = null;
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
            prettyPrint();
        });
        $(document).ready(function() {

            var sortitem = new PictrueRequestSort("HireCar", $('#txtGuid').val(), "Ul1", "/img/upload/", "File1", "Div1");
            MultiPicUploadifyInit(sortitem);
        });

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
                editor1.sync();                
                if (KindEditor('#fckContent').val() == '') {
                    alert("请输入内容");
                    $('#fckContent').focus();
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
                                            租车信息<asp:HiddenField ID="txtGuid" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            租车标题*
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtTitle" runat="server" Width="420px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            相关图片
                                        </td>
                                        <td colspan="3">
                                            <div class="uploadpanal">
                                                <div style="float: ; width: 100; height: 30px">
                                                    <input id="File1" type="file" /></div>
                                                <div style="float: ; widows: 600px; height: 24px; padding: 7px 3px 0 0; vertical-align: middle;
                                                    color: #444444">
                                                    选择图片上传，一次可以多个图片，最大不能越过5M,拖动图片可以调整排序。</div>
                                            </div>
                                            <div>
                                                <ul id="Ul1" class='multuploadsortclass'>
                                                </ul>
                                            </div>
                                            <div id="Div1">
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            状态
                                        </td>
                                        <td colspan="1">
                                            <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection="Horizontal">
                                            </asp:RadioButtonList>
                                        </td>
                                        <td class="td_title" width="15%">
                                            模块
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCModelType ID="UCModelType1" runat="server" Type="HireCar" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            联系人
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtLinkman" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            联系电话
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtTelnumber" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            价格
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtPrice" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            范围
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtRange" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            人数
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtPersoncount" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            车型
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtCarType" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            阿里旺旺
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtAliww" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            QQ
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtQq" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            浏览次数
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtViewtimes" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            排序
                                        </td>
                                        <td colspan="1">
                                            <asp:TextBox ID="txtShowpr" runat="server" Width="250"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            简介
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtShortContent" runat="server" Width="80%" TextMode="MultiLine"
                                                Rows="3"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            详细描述
                                        </td>
                                        <td colspan="3">
                                            <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                height: 200px; visibility: hidden;"></textarea>
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
