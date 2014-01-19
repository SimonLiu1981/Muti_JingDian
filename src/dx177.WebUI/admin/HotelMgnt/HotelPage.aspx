<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelPage.aspx.cs" ValidateRequest="false"
    Inherits="dx177.WebUI.admin.HotelMgnt.HotelPage" %>

<%@ Import Namespace="System.ComponentModel" %>
<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc2" %>
<%@ Register Src="../../usercontrols/UCModelType.ascx" TagName="UCModelType" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<html>
<head>
    <title>酒店列表</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../css/cssCn1.css" type="text/css" rel="stylesheet">
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="/js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>

    

    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>

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

        $(document).ready(function() {           
            var sortitem = new PictrueRequestSort("Hotel", $('#txt1Guid').val(), "Ul1", "/img/upload/", "File1", "Div1");
            MultiPicUploadifyInit(sortitem);
        });
        


        KindEditor.ready(function(K) {
            var editor1 = K.create('#FckeDescr', {
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
    </script>

</head>
<body ms_positioning="GridLayout" id="thebody">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：酒店管理<span class="arrow_subtitle">&gt;</span>酒店发布</div>
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
                                                酒店信息
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                <font face="宋体">酒店名</font>
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtName" runat="server" Width="324px"></asp:TextBox>
                                                <asp:HiddenField ID="txt1Guid" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                酒店类型
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="drpHoteltype" runat="server" Width="200px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="td_title" width="15%">
                                                所属景区地段
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="drpArea" runat="server" Width="200px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                旺旺
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtAliww" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                QQ
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtQq" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                联系电话
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                手机
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtMobile" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                浏览次数
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtViewtimes" runat="server" Width="201px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                排序
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtShowpr" runat="server" Width="201px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                EMAIL：
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtemail" runat="server" Width="201px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                订房后是否发邮件
                                            </td>
                                            <td>
                                                <asp:CheckBox ID="chkIssendorderemail" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                状态
                                            </td>
                                            <td>
                                                <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection="Horizontal">
                                                </asp:RadioButtonList>
                                            </td>
                                            <td class="td_title" width="15%">
                                                模块
                                            </td>
                                            <td>
                                                <uc3:UCModelType ID="UCModelType1" runat="server" Type="Hotel" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                酒店地址
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtAddress" runat="server" Width="654px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                经营特色
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtBiz" runat="server" Rows="3" TextMode="MultiLine" Width="654px"
                                                    Height="47px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                服务设施
                                            </td>
                                            <td colspan="3">
                                                <asp:CheckBoxList ID="chklistInstallationsstr" runat="server" RepeatDirection="Horizontal">
                                                </asp:CheckBoxList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                展示图片
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
                                                描述
                                            </td>
                                            <td colspan="3">
                                                <textarea id="FckeDescr" runat="server" cols="100" rows="8" style="width: 700px;
                                                    height: 200px; visibility: hidden;"></textarea>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                标签
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtTag" runat="server" Width="200px"></asp:TextBox>
                                                &nbsp;比如 农家乐、最好的宾馆
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
                                <asp:Button ID="btnSave" OnClientClick="return ValidationInput();" runat="server"
                                    CssClass="Button" Text="保存" OnClick="btnSave_Click"></asp:Button>
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
