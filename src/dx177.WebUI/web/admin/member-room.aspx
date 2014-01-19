<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-room.aspx.cs" ValidateRequest="false" Inherits="dx177.WebUI.web.admin.member_room"
    Title="无标题页" %>


<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc2" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />

    <script type="text/javascript" src="/js/my_Common.js">
        
    </script>

    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    
    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript">
        $(document).ready(function() {
            var sortitem = new PictrueRequestSort("Room", $('#<%=txt1Guid.ClientID %>').val(), "Ul1", "/img/upload/", "File1", "Div1");
            MultiPicUploadifyInit(sortitem);
        });

        KindEditor.ready(function(K) {
        var editor1 = K.create('#<%=fckDesc.ClientID %>', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                allowFileManager: true          
            });
            prettyPrint();
        });
        function CheckNumeric(obj )
        {
            var v=obj.value ;
            if (!isNumeric(v,"请录入数字"))
            {
                obj.value="0";
            }
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
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
                                    <em>*</em>房型<asp:HiddenField ID="txt1Guid" runat="server" />
                                </th>
                                <td colspan="3">
                                    <asp:TextBox ID="txtRoomtitle" CssClass="inputstyle _x_ipt _x_ipt" runat="server"
                                        Width="300px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    平时价
                                </th>
                                <td>
                                    <asp:TextBox ID="txtMarketprice" onblur="CheckNumeric(this) ;" on CssClass="inputstyle _x_ipt _x_ipt"
                                        runat="server" Width="100px"  Text='0'></asp:TextBox>
                                </td>
                                <th>
                                    网上价
                                </th>
                                <td>
                                    <asp:TextBox ID="txtPrice1" onblur="CheckNumeric(this) ;" CssClass="inputstyle _x_ipt _x_ipt"
                                        runat="server" Width="100px"  Text='0'></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    节假日价
                                </th>
                                <td>
                                    <asp:TextBox ID="txtPrice2" onblur="CheckNumeric(this) ;" CssClass="inputstyle _x_ipt _x_ipt"
                                        runat="server" Width="100px"  Text='0'></asp:TextBox>
                                </td>
                                <th>
                                    面积
                                </th>
                                <td>
                                    <asp:TextBox ID="txtSquare" onblur="CheckNumeric(this) ;" CssClass="inputstyle _x_ipt _x_ipt"
                                        runat="server" Width="100px" Text='0'></asp:TextBox>
                                    平方米(数字)
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    早餐
                                </th>
                                <td>
                                    <asp:RadioButtonList ID="rbtBreakfast" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem>无</asp:ListItem>
                                        <asp:ListItem>有</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <th>
                                    宽带
                                </th>
                                <td>
                                    <asp:RadioButtonList ID="rbtBroadband" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem>无</asp:ListItem>
                                        <asp:ListItem>有</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    简述
                                </th>
                                <td colspan="3">
                                    <asp:TextBox ID="txtShortdescr" CssClass="inputstyle _x_ipt _x_ipt" runat="server"
                                        Width="80%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    服务设施
                                </th>
                                <td colspan="3">
                                    <asp:CheckBoxList ID="chklistInstallations" runat="server" RepeatDirection="Horizontal"
                                        Height="16px">
                                    </asp:CheckBoxList>
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
                                            选择图片上传，可以多个图片，每个图片不越过5M,拖动图片可以调整排序,第一张图片默认为房间的LOGO</div>
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
                                      
                                        <textarea id="fckDesc" runat="server" cols="100" rows="8" style="width: 700px;
                                                    height: 200px; visibility: hidden;"></textarea>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                </th>
                                <td colspan="3">
                                    <asp:Button ID="btnSave" CssClass='sumitBlue1' runat="server" Text="保存资料" OnClick="btnSave_Click" />
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
