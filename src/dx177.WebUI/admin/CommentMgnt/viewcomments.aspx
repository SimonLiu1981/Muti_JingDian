<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewcomments.aspx.cs" Inherits="dx177.WebUI.admin.CommentMgnt.viewcomments" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<%@ Register Src="../../usercontrols/UCJqueryRaty.ascx" TagName="UCJqueryRaty" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>
    
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
    <script src="/Plugin/dingcai/dingcai.js" type="text/javascript"></script>

    <script type="text/javascript" language=javascript>        
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                if ( $("#txtSummaryContent").val().length > 255){                
                    alert("综合点评不能超过255字!");
                    $("#txtSummaryContent").focus();
                    return false;
                }
                  

            }
            else {
            }
        }

        function EditComment(seqno) {
            var url = "/admin/CommentMgnt/editComment.aspx?seqno=" + seqno + "&pguid=" + $('#txtPGuid').val() + "&type=<%=Request.QueryString["type"] %>TB_iframe=true&height=550&width=750&modal=true";
            ShowPopup(url);
            return false;

        }
        
        function RefeshInfo() {
            $('#btnRefeshData').click();   
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
                                            评论统计信息<asp:HiddenField ID="txtPGuid" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            评论统计对象：
                                        </td>
                                        <td colspan="3">
                                          <b style="font-size:20px  "> <asp:Label ID="lblObjTile" runat="server" Text="Label"></asp:Label></b>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            评分1：（<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>）
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty1" ReadOnly="true" runat="server" />
                                        </td>
                                        <td class="td_title" width="15%">
                                            评分2：（<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>）
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty2" ReadOnly="true" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                            评分3：（<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>）
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty3" ReadOnly="true" runat="server" />
                                        </td>
                                        <td class="td_title" width="15%">
                                            评分4：（<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>）
                                        </td>
                                        <td colspan="1">
                                            <uc3:UCJqueryRaty ID="UCJqueryRaty4" ReadOnly="true" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        
                                        <td class="td_title" width="15%">
                                           <b>综合评分：</b>
                                        </td>
                                        <td colspan="3">
                                            <uc3:UCJqueryRaty ID="ratySummary" ReadOnly="true" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        
                                        <td class="td_title" width="15%">
                                           <b>综合点评：</b>
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtSummaryContent" runat="server" Rows=6 Columns=60 TextMode=MultiLine></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                                <table width="100%">
                                    <tr>
                                        <td align="right" width="100%">
                                            <asp:Button ID="btnRefeshData" runat="server" style='display:none' onclick="Button1_Click" Text="Button" />
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="保存" OnClientClick="return ValidationInput(1)"
                                                OnClick="btnSave_Click"></asp:Button><asp:Button ID="btnReturn" OnClientClick="return ValidationInput(0)"
                                                    runat="server" CssClass="button" Text="返回" OnClick="btnReturn_Click"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table width="100%" class='tb_searchbar' id='tbMyReply' runat="server">
                        <tr>
                            <td class="td_head"  colspan=4>
                                回复列表
                            </td>
                        </tr>
                         <tr>                                        
                            <td class="td_title" width="15%">
                                评论内容：
                            </td>
                            <td colspan="1">
                                <asp:TextBox ID="txtQueryContent" runat="server"></asp:TextBox>
                            </td>
                                                       
                            <td class="td_title" width="15%">
                                过滤条件： 
                            </td>
                            <td colspan="1">
                                  <asp:CheckBox ID="cbxIsnew" runat="server"  Text='新评论'/>
                                  <asp:CheckBox ID="cbxIsnoreply" runat="server" Text='未答复' />
                                  <asp:CheckBox ID="cbxIsShow" runat="server" Text='显示到前台' />
                                   
                            </td>
                        </tr>
                         
                        <tr>
                         <td colspan=1 align=left>
                                <asp:Button ID="bntUpdate" runat="server" CssClass='button' Text="更新" onclick="bntUpdate_Click" 
                                   />
                         </td>
                            <td colspan=3 align=right>
                                <asp:Button ID="btnQuery" runat="server" CssClass='button' Text="查询" onclick="btnQuery_Click" 
                                   />
                                 <asp:Button ID="btnAddCommnet" runat="server" CssClass='button4' Text="增加评论"  OnClientClick='return EditComment(0);'
                                      />
                            </td>
                        </tr>
                        <tr>
                            <td colspan=4>
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
                                            <HeaderStyle Width="50px" />
                                            <HeaderTemplate>
                                                状态
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblStatus" runat="server"  ></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>            
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="50px" />
                                            <HeaderTemplate>
                                                <asp:Label ID="lblAvgScore" runat="server" Text="平均分"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblAvgScore" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AvgScore") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>            
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="50px" />
                                            <HeaderTemplate>
                                                <asp:Label ID="lbl1" runat="server" Text="评分1"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblScore1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Score1") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                      
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="50px" />
                                            <HeaderTemplate>
                                                <asp:Label ID="lbl3" runat="server" Text="回复"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtReplycontent" runat="server"></asp:TextBox> 
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                         <asp:TemplateColumn>
                                            <HeaderStyle Width="80px" />
                                            <HeaderTemplate>
                                                前台显示
                                            </HeaderTemplate>
                                            <ItemTemplate>                                            
                                                <asp:LinkButton ID="btnIsShow" runat="server" CommandName="IsShow" 
                                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>显示</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                      
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="80px" />
                                            <HeaderTemplate>
                                                操作
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                            
                                                <a href='javascript:;' onclick="EditComment('<%# DataBinder.Eval(Container.DataItem, "Seqno") %>')">
                                                    变更</a>
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
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
