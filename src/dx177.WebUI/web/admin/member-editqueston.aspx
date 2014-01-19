<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="member-editqueston.aspx.cs" Inherits="dx177.WebUI.web.admin.member_editqueston" %>

<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
    
    <script type="text/javascript">
        function CheckQInfo() {
            if ($('#<%=txtTitle.ClientID %>').val() == '') {
                alert("请输入标题");
                $('#<%=txtTitle.ClientID %>').focus();
                return false;
            }

            if ($('input[name=<%=rbtQuestionType.ClientID.Replace("_","$") %>]:checked').length == 0) {
                alert("请选择问题类型!");

                return false;
            }
                
            if ($('#<%=txtContent.ClientID %>').val() == '') {
                alert("请输入问题描述");
                $('#<%=txtContent.ClientID %>').focus();
                return false;
            }
            
        }
         
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
                           <strong><%=dx177.Model.AppContext.CurrentResuser.Username %></strong></div>
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
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_13" runat="server" />
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
                                   <em>*</em>标题<asp:HiddenField ID="txtGuid" runat="server" />
                                </th>
                                <td>
                                    <asp:TextBox ID="txtTitle" CssClass="inputstyle _x_ipt _x_ipt" Width="200px" autocomplete="off"
                                        runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    问题类型
                                </th>
                                <td>
                                    <asp:RadioButtonList ID="rbtQuestionType" runat="server" RepeatDirection="Horizontal">                                        
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    问题状态
                                </th>
                                <td>
                                     <asp:RadioButtonList ID="rbtQuestionStatus" runat="server" RepeatDirection="Horizontal">                                        
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                   <em>*</em>问题描述
                                </th>
                                <td>
                                    <asp:TextBox ID="txtContent" runat="server" TextMode=MultiLine Rows=5 Columns=60></asp:TextBox>
                                </td>
                            </tr>                          
                            <tr>
                                <th>
                                </th>
                                <td style=" padding-top:5px">
                                    <asp:Button ID="btnSave" CssClass='sumitBlue1' runat="server" Text="保存问题"  OnClientClick="return CheckQInfo();"
                                        onclick="btnSave_Click" />
                                <asp:Button ID="btnBlack" CssClass='sumitBlue1' runat="server" Text="返回" 
                                        onclick="btnBlack_Click"    />
                                </td>
                            </tr>
                        </table>
                    </div>
                    
                    <h3>答复列表</h3>
                    <table width="100%" cellpadding="3" cellspacing="0" class="liststyle">
                        <colgroup>
                            <col class="span-auto ColColorWhite" />                             
                            <col class="span-4 ColColorWhite" />                            
                            <col class="span-3 ColColorOrange" />                             
                        </colgroup>
                        <thead>
                            <tr>
                                <th>
                                    内容
                                </th>
                                <th>
                                    创建日期
                                </th>
                                <th>
                                    是否最佳答复
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                             <asp:ListView ID="lvRQestions" runat="server" 
                                 onitemcommand="lvRQestions_ItemCommand" 
                                 onitemdatabound="lvRQestions_ItemDataBound"  >
                                <LayoutTemplate>
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td title='<%#DataBinder.Eval(Container.DataItem,"content")  %>'>
                                           <%# dx177.FrameWork.StringUtil.CutString(DataBinder.Eval(Container.DataItem,"content").ToString(),60)  %>
                                        </td>
                                        <td>
                                           <%#DataBinder.Eval(Container.DataItem,"createdate")  %> 
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbtnSetRight"  CommandName="SetRight" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"seqno")  %>'>正解</asp:LinkButton>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                    </table>
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
