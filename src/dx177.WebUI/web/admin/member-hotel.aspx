<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    ValidateRequest="false" CodeBehind="member-hotel.aspx.cs" Inherits="dx177.WebUI.web.admin.member_publish_hotel" %>

<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc2" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    
    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .abcd
        {
            border: 1px red solid;    
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function() {
        var sortitem = new PictrueRequestSort("Hotel", $('#<%=txt1Guid.ClientID %>').val(), "Ul1", "/img/upload/", "File1", "Div1");
            MultiPicUploadifyInit(sortitem);
        });

        KindEditor.ready(function(K) {
            var editor1 = K.create('#<%=fckDesc.ClientID %>', {
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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id='form1'>
    <div id="MainWrap_Car" style="background: #fff;">
        <div class="MemberCenter">
            <div class="siteparttitle">
                <div class="title">
                </div>
                <div class="main">
                    <div class="content_c1">
                        <div class="user">
                            欢迎您：<br />
                            <strong>
                                <%=dx177.Model.AppContext.CurrentResuser.Username %></strong></div>
                        <div class="info">
                            您目前是<strong>[普通会员]，</strong>您的积分为:<strong class="point">0</strong></div>
                    </div>
                </div>
            </div>
            <div class="MemberSidebar">
                <div class="MemberMenu">
                    <div class="title">
                    </div>
                    <div class="body">
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_hotel" runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <div class="MemberMain">
                <div class="FormWrap">
                    <div class="division">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0" class="forform">
                            <tr>
                                <th>
                                    <em>*</em>酒店名<asp:HiddenField ID="txt1Guid" runat="server" />
                                </th>
                                <td colspan="3">
                                    <asp:TextBox ID="txtName" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="300px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    酒店状态
                                </th>
                                <td colspan="3">
                                    <asp:Label ID="lbstatus" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    酒店类型
                                </th>
                                <td>
                                    <asp:DropDownList ID="drpHoteltype" runat="server" Width="150px">
                                    </asp:DropDownList>
                                </td>
                                <th>
                                    所属景区地段
                                </th>
                                <td>
                                    <asp:DropDownList ID="drpArea" runat="server" Width="150px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    QQ
                                </th>
                                <td>
                                    <asp:TextBox ID="txtAliww" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="150px"></asp:TextBox>
                                </td>
                                <th>
                                    旺旺
                                </th>
                                <td>
                                    <asp:TextBox ID="txtQq" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    联系电话
                                </th>
                                <td>
                                    <asp:TextBox ID="txtPhone" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="150px"></asp:TextBox>
                                </td>
                                <th>
                                    手机
                                </th>
                                <td>
                                    <asp:TextBox ID="txtMobile" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    地址
                                </th>
                                <td colspan="3">
                                    <asp:TextBox ID="txtAddress" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="300px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    服务设施
                                </th>
                                <td colspan="3">
                                    <asp:CheckBoxList ID="chklistInstallationsstr" runat="server" RepeatDirection="Horizontal"
                                        Height="16px">
                                    </asp:CheckBoxList>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    &nbsp;经营特色
                                </th>
                                <td colspan="3">
                                    <asp:TextBox ID="txtBiz" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="80%"
                                        TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </td>
                            </tr>
                             
                            <tr>
                                <th>
                                    相关图片
                                </th>
                                <td colspan="3">
                                    <div class="uploadpanal">
                                        <div style="float: left;">
                                            <input id="File1" type="file" /></div>
                                        <div style="float: ; widows: 600px; height: 24px; padding: 7px 3px 0 0; vertical-align: middle;
                                            color: #444444">
                                            选择图片上传，可以多个图片，每个图片不越过5M,拖动图片可以调整排序,第一张图片默认为酒店的LOGO</div>
                                    </div>
                                    <div style="float: left;">
                                        <ul id="Ul1" class='multuploadsortclass'>
                                        </ul>
                                    </div>
                                    <div id="Div1" style="float: left;">
                                    </div>
                                    <div class="clear">
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    详细描述
                                </th>
                                <td colspan="3">
                                    <textarea id="fckDesc" runat="server"   rows="8" style="width:600px; height: 200px;visibility: hidden;"></textarea>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                </th>
                                <td colspan="3">
                                    <asp:Button ID="btnSave" CssClass='sumitBlue1' runat="server" Text="保存资料" OnClientClick="return CheckHireCarInfo();"
                                        OnClick="btnSave_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    </form>
</asp:Content>
