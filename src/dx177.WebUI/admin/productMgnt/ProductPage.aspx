<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" ValidateRequest=false Inherits="dx177.WebUI.admin.productMgnt.ProductPage" %>

<%@ Import Namespace="System.ComponentModel" %>
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
    <script type="text/javascript">
        KindEditor.ready(function(K) {
            var editor1 = K.create('#fckContent', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                allowFileManager: true
                }
            });
            var editor2 = K.create('#txtOther', {
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
    
    </script>

</head>
<body ms_positioning="GridLayout" id="thebody">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：产品管理<span class="arrow_subtitle">&gt;</span>产品发布</div>
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
                                               产品信息
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                <font face="宋体">产品名</font>
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtTitle" runat="server" Width="324px"></asp:TextBox>
                                                <asp:HiddenField ID="txt1Guid" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                产品类型
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="drpPtype" runat="server" Width="200px">
                                                </asp:DropDownList>
                                            </td>
                                            <td class="td_title" width="15%">
                                                浏览次数
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtViewtimes" runat="server" Width="201px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                市场价
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtMarketprice" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                现价
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNowprice" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                单位</td>
                                            <td>
                                                <asp:TextBox ID="txtdanwei" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                库存
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtStock" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                重量
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtWeigth" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                权重
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtShowpr" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                            <td class="td_title" width="15%">
                                                模块
                                            </td>
                                            <td>
                                                <uc3:UCModelType ID="UCModelType1" runat="server" Type="Products" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                简述
                                            </td>
                                            <td colspan="3">
                                                <asp:TextBox ID="txtShortcontent" runat="server" Rows="3" TextMode="MultiLine" Width="654px"
                                                    Height="47px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                logo
                                            </td>
                                            <td colspan="3">
                                                <uc2:UCSingleImgUpload ID="UCSingleImgUpload1" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                展示图片
                                            </td>
                                            <td colspan="3">
                                                <uc1:UCImgupload ID="UCImgupload1" runat="server" />
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
                                        <tr>
                                            <td class="td_title" width="15%">
                                                其他</td>
                                            <td colspan="3">
                                                <textarea id="txtOther" runat="server" cols="100" rows="8" style="width: 700px;
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
