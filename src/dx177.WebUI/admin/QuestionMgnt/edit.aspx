<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" ValidateRequest="false" Inherits="dx177.WebUI.admin.QuestionMgnt.edit" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<%@ Import Namespace="dx177.Model" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="/js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="/js/qs_.js?guid=<%=System.Guid.NewGuid().ToString() %>" type="text/javascript"></script>
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>

    <link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />
    <script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script src="/Plugin/dingcai/dingcai.js" type="text/javascript"></script>

    <script>
        KindEditor.ready(function(K) {
            var editor1 = K.create('#fckContent', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                allowFileManager: true
            });
           
        });
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                if ($("#txtTitle").val() == '') {
                    alert("请输入标题!");
                    $("#txtTitle").focus();
                    return false;
                }
                if (document.getElementById ("txtClassLevel1").value == "") {
                    alert("请选择问题类型!");
                    
                    return false;
                } 
            }
            else {
            }
        }

        function EditReply(seqno) {
            var url = "reply.aspx?seqno=" + seqno + "&pguid=" + $('#txtGuid').val() + "TB_iframe=true&height=550&width=750&modal=true";
            ShowPopup(url);
            return false;            
        }
    </script>
    
     <script language="javascript">
         function FillClassLevel1(ClassLevel1) {
             for (i = 0; i < class_level_1.length; i++) {
                 ClassLevel1.options[i] = new Option(class_level_1[i][1], class_level_1[i][0]);
             }
             ClassLevel1.length = i;
         }

        function FillClassLevel2(ClassLevel2, class_level_1_id) {
            ClassLevel2.options[0] = new Option("不选择", class_level_1_id);
            count = 1;
            for (i = 0; i < class_level_2.length; i++) {
                if (class_level_2[i][0].toString() == class_level_1_id) {
                    ClassLevel2.options[count] = new Option(class_level_2[i][2], class_level_2[i][1]);
                    count = count + 1;
                }
            }
            ClassLevel2.options[0].selected = true;
            ClassLevel2.length = count;
        }

        function SetLevelValue(v) {
            var v1 = v;
            var ClassLevel1 = document.getElementById("ClassLevel1");
            for (i = 0; i < class_level_2.length; i++) {
                if (class_level_2[i][1].toString() == v) {
                    v1 = class_level_2[i][0];

                }
            }
            for (n = 0; n < ClassLevel1.length; n++) {
                if (ClassLevel1.options[n].value == v1) {
                    ClassLevel1.options[n].selected = true;

                }
            }
            ClassLevel1_onchange();
            var ClassLevel2 = document.getElementById("ClassLevel2");
            for (z = 0; z < ClassLevel2.length; z++) {
                if (ClassLevel2.options[z].value == v) {
                    ClassLevel2.options[z].selected = true;

                }
            }
            document.getElementById("txtClassLevel2").value = ClassLevel2.options[ClassLevel2.selectedIndex].value;
        }

        function ClassLevel1_onchange() {
            var obj = document.getElementById("ClassLevel1");
            if (obj.selectedIndex != -1) {
                var v = obj.options[obj.selectedIndex].value;
                FillClassLevel2(document.getElementById("ClassLevel2"), v);
                getValue();
            }
        }

        function getValue() {
            var obj = document.getElementById("ClassLevel1");
            document.getElementById("txtClassLevel1").value = obj.options[obj.selectedIndex].value;
            obj = document.getElementById("ClassLevel2");
            document.getElementById("txtClassLevel2").value = obj.options[obj.selectedIndex].value;

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
                                            问题信息<asp:HiddenField ID="txtGuid" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            标题*
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtTitle" runat="server" Width="420px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            类型</td>
                                        <td colspan="3">
                                             <select id="ClassLevel1" onchange="ClassLevel1_onchange();"  style="width: 180px" size="8" name="ClassLevel1"><option selected></option></select>
<input type="hidden" id="txtClassLevel1"  runat=server   />
&nbsp;&nbsp;
                                            <select id="ClassLevel2" style="width: 186px"  onchange="getValue();"  size="8" 
                                                 name="ClassLevel2"><option selected></option></select>
  <input type="hidden" id="txtClassLevel2"   runat=server  />
                                        </td>
                                    </tr>
                                    <tr>
                                    <td class="td_title" width="15%">
                                            问题状态
                                        </td>
                                        <td colspan="3">                                            
                                            <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection="Horizontal">
                                            </asp:RadioButtonList>
                                        </td>
                                       
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            问题描述
                                        </td>
                                        <td colspan="3">                                             
                                             <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                    height: 200px; visibility: hidden;"></textarea>
                                            </td>                                            
                                            
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            &nbsp;</td>
                                        <td colspan="3">
                                             &nbsp;</td>
                                            
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            创建人</td>
                                        <td colspan="3">
                                             <asp:TextBox ID="txtCreator" runat="server"></asp:TextBox>
                                        </td>
                                            
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            浏览次数</td>
                                        <td colspan="3">
                                             <asp:TextBox ID="txtViewtimes" runat="server"></asp:TextBox>
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
                    <table width="100%" class='tb_searchbar' id='tbMyReply'  runat=server>
                        <tr  >
                            <td class=td_head>
                                回复列表
                            </td>
                        </tr>
                        <tr>
                        <td>
                            <asp:Button ID="btnAddReply" runat="server"  CssClass='button4' OnClientClick='return EditReply(0);' Text="增加回复" /> 
                        </td></tr>
                        <tr>
                            <td>
                                <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 0px" CssClass="tb_datalist1"
                                    PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" IsAllowPaging="True"
                                    AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                                    BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" OnItemCommand="dgNews_ItemCommand">
                                    <ItemStyle CssClass="tr_datarow" />
                                    <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>                                         
                                        <asp:BoundColumn DataField="Content" HeaderText="内容"></asp:BoundColumn>
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="80px" />
                                            <HeaderTemplate>
                                                被顶
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                              <span support_get_guid='<%# DataBinder.Eval(Container.DataItem, "Guid") %>'></span>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="80px" />
                                            <HeaderTemplate>
                                                被贬
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                              <span oppose_get_guid='<%# DataBinder.Eval(Container.DataItem, "Guid") %>'></span>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>                                         
                                        <asp:BoundColumn DataField="Creator" HeaderText="创建人">
                                            <HeaderStyle Width="100px" />
                                        </asp:BoundColumn>
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="80px" />
                                            <HeaderTemplate>
                                                操作
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <a href='javascript:;' onclick="EditReply('<%# DataBinder.Eval(Container.DataItem, "Seqno") %>')" >修改</a>                                               
                                                
                                                <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return confirm('确认删除吗？')"
                                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <HeaderStyle CssClass="tr_title"></HeaderStyle>
                                    <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                                    <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                                </cc1:ZteGrid>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    
    
    
<script language="javascript"> 

FillClassLevel1( document.getElementById ("ClassLevel1")) ;
 SetLevelValue(document.getElementById ("txtClassLevel2").value) ;
//alert(document.getElementById ("txtClassLevel2").value);
//SetLevelValue(  document.getElementById ("txtClassLevel1").value ,document.getElementById ("ClassLevel2"),document.getElementById ("ClassLevel")) ;
</script>

    </form>
</body>
</html>
