<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="True" CodeBehind="RoomPage.aspx.cs"
    Inherits="dx177.WebUI.admin.HotelMgnt.RoomPage" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc2" %>
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

    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>

    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>

    <script type="text/javascript" language="javascript">


        $(document).ready(function() {
            var sortitem = new PictrueRequestSort("Room", $('#txt1Guid').val(), "Ul1", "/img/upload/", "File1", "Div1");
            MultiPicUploadifyInit(sortitem);
        });
        KindEditor.ready(function(K) {
            var editor1 = K.create('#fckContent', {
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
                    当前位置：酒店管理<span class="arrow_subtitle">&gt;</span>房间发布</div>
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
                                                房间信息
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                <font face="宋体">房型</font>
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtRoomtitle" runat="server" Width="294px"></asp:TextBox>
                                                <asp:HiddenField ID="txt1Guid" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                门市价
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtMarketprice" runat="server" Width="82px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                网上价
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtPrice1" runat="server" Width="82px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                节假日价
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtPrice2" runat="server" Width="82px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                面积
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtSquare" runat="server" Width="82px"></asp:TextBox>
                                                平方米
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                早餐
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtBreakfast" runat="server" Width="82px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                宽带
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtBroadband" runat="server" Width="82px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                模块
                                            </td>
                                            <td>
                                                <uc3:UCModelType ID="UCModelType1" runat="server" />
                                            </td>
                                            <td class="td_title" width="15%">
                                                排序
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtShowpr" runat="server" Width="83px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                简述
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtShortdescr" runat="server" Rows="7" TextMode="MultiLine" Width="654px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                服务设施
                                            </td>
                                            <td colspan="3">
                                                <asp:CheckBoxList ID="chklistInstallations" runat="server" RepeatDirection="Horizontal">
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
                                                浏览次数
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtViewtimes" runat="server" Width="201px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                描述
                                            </td>
                                            <td colspan="3">
                                                <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                    height: 200px; visibility: hidden;"></textarea>
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
                                <asp:Button ID="btnSave" runat="server" CssClass="Button"
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
