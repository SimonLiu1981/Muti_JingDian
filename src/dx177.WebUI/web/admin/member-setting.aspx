<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-setting.aspx.cs" Inherits="dx177.WebUI.web.admin.member_setting" %>

<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
    
    <script type="text/javascript">
        function CheckUserInfo() {
            if ($('#<%=txtName.ClientID %>').val() == '') {
                alert("请输入姓名");
                $('#<%=txtName.ClientID %>').focus();
                return false;
            }
        }
        function CheckPwd() {
            if ($('#<%=txtOldPwd.ClientID %>').val() == '') {
                alert("请旧密码");
                $('#<%=txtOldPwd.ClientID %>').focus();
                return false;
            }
            if ($('#<%=txtNewPwd.ClientID %>').val() == '') {
                alert("请新密码");
                $('#<%=txtNewPwd.ClientID %>').focus();
                return false;
            }
            if ($('#<%=txtNewPwd.ClientID %>').val() != $('#<%=txtReNewPwd.ClientID %>').val()) {
                alert("确认密码与新密码不一致。");
                $('#<%=txtReNewPwd.ClientID %>').focus();
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
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_12" runat="server" />
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
                                   <em>*</em>姓名
                                </th>
                                <td>
                                    <asp:TextBox ID="txtName" CssClass="inputstyle _x_ipt _x_ipt" autocomplete="off"
                                        runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    性别
                                </th>
                                <td>
                                    <asp:RadioButtonList ID="rbtSex" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem Text="男" Value="男"></asp:ListItem>
                                        <asp:ListItem Text="女" Value="女"></asp:ListItem>
                                        <asp:ListItem Text="保密" Value="保密" Selected></asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    出生日期
                                </th>
                                <td>
                                    <cc2:DateTextBox ID="dateBrithday" runat="server"></cc2:DateTextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    移动电话
                                </th>
                                <td>
                                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    邮箱
                                </th>
                                <td>
                                    <asp:TextBox ID="txtEmail"  runat="server"></asp:TextBox>  
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    QQ
                                </th>
                                <td>
                                    <asp:TextBox ID="txtQq" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    MSN
                                </th>
                                <td>
                                    <asp:TextBox ID="txtMsn" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                </th>
                                <td>
                                    <asp:Button ID="btnSave" CssClass='sumitBlue1' runat="server" Text="修改资料"  OnClientClick="return CheckUserInfo();"
                                        onclick="btnSave_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="division">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0" class="forform">
                            <tr>
                                <th>
                                    <em>*</em>旧密码：
                                </th>
                                <td>
                                    <asp:TextBox ID="txtOldPwd" TextMode="Password" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    <em>*</em>新密码：
                                </th>
                                <td>
                                    <asp:TextBox ID="txtNewPwd" TextMode="Password" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    <em>*</em>确认密码：
                                </th>
                                <td>
                                    <asp:TextBox ID="txtReNewPwd" TextMode="Password" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                </th>
                                <td>
                                    <asp:Button ID="btnSave1" runat="server" CssClass='sumitBlue1' Text="修改密码"  OnClientClick="return CheckPwd();"
                                        onclick="btnSave1_Click" />
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
