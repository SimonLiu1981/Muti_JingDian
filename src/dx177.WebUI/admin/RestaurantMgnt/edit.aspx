<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" ValidateRequest="false"
    Inherits="dx177.WebUI.admin.RestaurantMgnt.edit" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Import Namespace="dx177.Model" %>
<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<%@ Register src="../../usercontrols/UCModelType.ascx" tagname="UCModelType" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script type="text/javascript">


        KindEditor.ready(function(K) {
            var editor1 = K.create('#fckContent', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?JingQuCode=<%=AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?JingQuCode=<%=AppContext.CurrentMgtJingQuCode %>',
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

        var sortitem = new PictrueRequestSort("Restaurant", $('#txtGuid').val(), "Ul1", "/img/upload/", "File1", "Div1");
        MultiPicUploadifyInit(sortitem);
        });
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                if ($("#txtTitle").val() == '') {
                    alert("请输入标题!");
                    $("#txtTitle").focus();
                    return false;
                }

                if ($("#drpRestaurantType").val() == '') {
                    alert("请饭店类型!");
                    $("#drpRestaurantType").focus();
                    return false;
                }

                if ($("#drpArea").val() == '') {
                    alert("请选择地段!");
                    $("#drpArea").focus();
                    return false;
                }
 
            }
            else {
            }
        }

        function EditBook(bookSeqno) {
            var url = "/admin/RestaurantMgnt/editCookBook.aspx?pguid=" + $('#txtGuid').val() + "&Seqno=" + bookSeqno + "TB_iframe=true&height=500&width=800&modal=true";
            ShowPopup(url);
            return false;
        }

        function RefeshBook() {
            $('#btnRefeshBook').click();
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
                                            饭店信息<asp:HiddenField ID="txtGuid" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            饭店标题*
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
                                            浏览次数</td>
                                        <td>
                                            <asp:TextBox ID="txtViewtimes" runat="server" Width=201  ></asp:TextBox>
                                        </td>
                                        <td class="td_title" width="15%">
                                            排序</td>
                                        <td>
                                            <asp:TextBox ID="txtShowpr" runat="server" Width=201  ></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            饭店类型
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="drpRestaurantType" runat="server" Width="200px">
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
                                        <td class="td_title" nowrap width="15%">
                                            状态
                                        </td>
                                        <td class="detail">
                                            <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection="Horizontal">
                                            </asp:RadioButtonList>
                                        </td>
                                        <td class="td_title" nowrap width="15%">
                                            模块</td>
                                        <td class="detail">
                                            <uc3:UCModelType ID="UCModelType1" runat="server" Type="Restaurant" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" nowrap width="15%">
                                            联系人
                                        </td>
                                        <td class="detail">
                                            <asp:TextBox ID="txtLinkMan" runat="server" Width="250px"></asp:TextBox>
                                        </td>
                                        <td class="td_title" nowrap width="15%">
                                            联系电话
                                        </td>
                                        <td class="detail">
                                            <asp:TextBox ID="txtTelNumber" runat="server" Width="250px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" nowrap width="15%">
                                            人均花费
                                        </td>
                                        <td class="detail">
                                            <asp:TextBox ID="txtCost" runat="server" Width="250px" Text="0"></asp:TextBox>（数字型）
                                        </td>
                                        <td class="td_title" nowrap width="15%">
                                            优惠
                                        </td>
                                        <td class="detail">
                                            <asp:TextBox ID="txtFavorable" runat="server" Width="250px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" nowrap width="15%">
                                            在线旺旺
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtAliww" runat="server" Rows="4" Columns="29" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                        <td class="td_title" nowrap width="15%">
                                            在线QQ
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtQQ" runat="server" Rows="4" Columns="29" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            地址</td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtAddress" runat="server" Width="729px" Height="37px" 
                                                TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            地图
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtMap" runat="server" Width="80%" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            菜谱
                                        </td>
                                        <td colspan="3">
                                            <asp:Button ID="btnAddCookBook" runat="server" CssClass="button4" Text="新增菜谱" OnClientClick="return EditBook('0');" />
                                            <asp:Button ID="btnRefeshBook" runat="server" OnClick="btnRefeshBook_Click" Style="display: none"
                                                Text="Button" />
                                            <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                                                PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" isallowpaging="True"
                                                AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" pagecss="scrollButton"
                                                BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" OnItemCommand="dgNews_ItemCommand">
                                                <ItemStyle CssClass="tr_datarow" />
                                                <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                                                <Columns>
                                                    <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>
                                                    <asp:TemplateColumn>
                                                        <HeaderStyle Width="150px" />
                                                        <HeaderTemplate>
                                                            菜LOGO
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <asp:Image ID="imgLogo" Width="120" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Logo") %>'
                                                                runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="Name" HeaderText="菜名"></asp:BoundColumn>
                                                    <asp:BoundColumn DataField="Price" HeaderText="价格"></asp:BoundColumn>
                                                    <asp:BoundColumn DataField="ShortContent" HeaderText="简介"></asp:BoundColumn>
                                                    <asp:TemplateColumn>
                                                        <HeaderStyle Width="80px" />
                                                        <HeaderTemplate>
                                                            操作
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <a href="javascript:;" onclick='return EditBook("<%#DataBinder.Eval(Container.DataItem, "Seqno") %>");'>
                                                                修改</a>
                                                            <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                </Columns>
                                                <HeaderStyle CssClass="tr_title"></HeaderStyle>
                                                <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                                                <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                                            </cc1:ZteGrid>
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
