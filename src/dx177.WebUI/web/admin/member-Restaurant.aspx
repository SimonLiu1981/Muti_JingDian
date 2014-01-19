<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" ValidateRequest="false"
    CodeBehind="member-Restaurant.aspx.cs" Inherits="dx177.WebUI.web.admin.member_publish_Restaurant" %>


<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc2" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc3" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
    <link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    
        function RefeshBook() {
            $('#<%=btnSearchCookBook.ClientID %>').click();
        }

        function EditBook(bookSeqno) {
            var url = "/member-editCookBook.aspx?pguid=" + $('#<%=txtGuid.ClientID %>').val() + "&Seqno=" + bookSeqno + "TB_iframe=true&height=640&width=800&modal=true";
            ShowPopup(url);
            return false;
        }
        $(document).ready(function() {
        var sortitem = new PictrueRequestSort("Restaurant", $('#<%=txtGuid.ClientID %>').val(), "Ul1", "/img/upload/", "File1", "Div1");
            MultiPicUploadifyInit(sortitem);
        });

        KindEditor.ready(function(K) {
        var editor1 = K.create('#<%=fckContent.ClientID %>', {
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
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_Restaurant" runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <div class="MemberMain">
                <form runat="server" id='form1'>
                <div class="FormWrap">
                    <div class="division">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0" class="forform">
                            <tr>
                                <th>
                                    <em>*</em>饭店标题<asp:HiddenField ID="txtGuid" runat="server" />
                                </th>
                                <td colspan='3'>
                                    <asp:TextBox ID="txtTitle" runat="server" CssClass="inputstyle _x_ipt _x_ipt" autocomplete="off"
                                        Width="420px"></asp:TextBox>
                                </td>
                            </tr>                            
                            <tr>
                                <th>
                                    相关图片
                                </th>
                                <td colspan='3'>
                                    <div class="uploadpanal">
                                        <div style="float: left;">
                                            <input id="File1" type="file" /></div>
                                        <div style="float: ; widows: 600px; height: 24px; padding: 7px 3px 0 0; vertical-align: middle;
                                            color: #444444">
                                            选择图片上传，可以多个图片，每个图片不越过5M,拖动图片可以调整排序,第一张图片默认为LOGO</div>
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
                                    饭店类型
                                </th>
                                <td>
                                    <asp:DropDownList ID="drpRestaurantType" runat="server" Width="150px">
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
                                    联系人
                                </th>
                                <td>
                                    <asp:TextBox ID="txtLinkMan" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="250"></asp:TextBox>
                                </td>
                            
                                <th>
                                    联系电话
                                </th>
                                <td>
                                    <asp:TextBox ID="txtTelNumber" CssClass="inputstyle _x_ipt _x_ipt" runat="server"
                                        Width="250"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    地址
                                </th>
                               <td colspan='3'>
                                    <asp:TextBox ID="txtAddress" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="250"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    人均花费
                                </th>
                                 <td colspan='3'>
                                    <asp:TextBox ID="txtCost" CssClass="inputstyle _x_ipt _x_ipt" runat="server" Width="250"></asp:TextBox>（单位元，数字型如:30）
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    优惠信息
                                </th>
                                 <td colspan='3'>
                                    <asp:TextBox ID="txtFavorable" CssClass="inputstyle _x_ipt _x_ipt" runat="server"
                                        Width="250"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    饭店菜谱
                                </th>
                                <td colspan='3'>
                                    <asp:Button ID="btnAddCookBook" CssClass='sumitBlue1' runat="server" Text="新增菜谱"
                                        OnClientClick="return EditBook('0');" /><asp:Button ID="btnSearchCookBook" OnClick='btnSearchCookBook_Click'
                                            runat="server" Style="display: none" Text="Button" />
                                    <table width="100%" cellpadding="3" cellspacing="0" class="liststyle">
                                        <colgroup>
                                            <col class="span-3 ColColorWhite" />
                                            <col class="span-auto ColColorWhite" />
                                            <col class="span-4 ColColorWhite" />
                                        </colgroup>
                                        <thead>
                                            <tr>
                                                <th style="text-align: center; width: auto">
                                                    菜谱LOGO
                                                </th>
                                                <th style="text-align: center; width: auto">
                                                    菜名
                                                </th>
                                                <th style="text-align: center; width: auto">
                                                    操作
                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:ListView ID="lvCookBookList" runat="server" OnItemCommand="lvCookBookList_ItemCommand">
                                                <LayoutTemplate>
                                                    <div id="itemPlaceholder" runat="server">
                                                    </div>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                            <img src='<%#DataBinder.Eval(Container.DataItem,"logo")%>' width="80" height=80 alt="" />
                                                        </td>
                                                        <td>
                                                            <%#DataBinder.Eval(Container.DataItem,"Name")%>
                                                        </td>
                                                        <td>
                                                            <a href="javascript:;" onclick='return EditBook("<%#DataBinder.Eval(Container.DataItem, "Seqno") %>");'>
                                                                修改</a>
                                                            <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete1" OnClientClick="return confirm('确认删除该菜谱吗？')"
                                                                CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    饭店简介
                                </th>
                                 <td colspan='3'>
                                    <asp:TextBox ID="txtShortContent" CssClass="inputstyle _x_ipt _x_ipt" runat="server"
                                        Width="80%" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    详细描述
                                </th>
                                 <td colspan='3'>
                                      
                                                        <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                    height: 200px; visibility: hidden;"></textarea>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                </th>
                                <td colspan='3'>
                                    <asp:Button ID="btnSave" CssClass='sumitBlue1' runat="server" Text="保存资料" OnClientClick="return CheckHireCarInfo();"
                                        OnClick="btnSave_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                </form>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
