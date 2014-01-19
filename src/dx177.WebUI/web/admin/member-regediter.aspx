<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-regediter.aspx.cs" Inherits="dx177.WebUI.web.admin.member_regediter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
<script src="/js/my_Common.js" type="text/javascript"></script>
     
    <script type="text/javascript">
        $(document).ready(function() {
            $('#subCreate').click(SubmitRegedit);
            $("#reg_user").blur(function() {
                return ChueckInputUserEmail();
            });
            $("#reg_passwd").blur(function() { return CheckInputPwd(); });
            $("#reg_passwd_r").blur(function() { return CheckInputPwd(); });
        });

        function SubmitRegedit() {
            ChueckInputUserEmail();
            CheckInputPwd();            
            if ($('#txtEmail_Val').is(":visible")) {
                $('#reg_user').focus();
                return false;
            }
            if ($('#txtPassword_Val').is(":visible")) {
                $('#reg_password').focus();
                return false;
            }
            if ($('#txtPasswordConfirm_Val').is(":visible")) {
                $('#reg_password').focus();
                return false;
            }

            $.getJSON("/web/admin/AjaxHandler.aspx?MethodName=RegeditUser&jsoncallback=?",
			{
			    email: encodeURIComponent($('#reg_user').val()),
			    pwd: encodeURIComponent($('#reg_password').val()),
			    jingquCode: encodeURIComponent($('#ddlJingQu').val()),
			    userType: '<%=Request.QueryString["type"] %>'
			},
			function(json) {
			    if ($('#hidGobackTo').val() != '') {
			        location.href = $('#hidGobackTo').val();
			    }
			    else {
			        if (json.Result.NavigationUrl) {
			            location.href = json.Result.NavigationUrl;
			        }
			    }
			});
        }

        function ChueckInputUserEmail() {
            if ($('#reg_user').val() == '' || !isEmail($('#reg_user').val(), '')) {
                $('#txtEmail_Val').show();
            }
            if ($('#reg_user').val() != '' && isEmail($('#reg_user').val(), '')) {
                $.getJSON("/web/admin/AjaxHandler.aspx?MethodName=RegeditUser_DualisticJudge&jsoncallback=?",
				{ email: encodeURIComponent($('#reg_user').val()) },
				function(json) {				    
				    if (json.Result.Exists) {
				        $('#txtEmail_Val').html($('#reg_user').val() + ' 已经被人注册，请重新输入。');
				        $('#txtEmail_Val').show();
				    }
				    else {
				        $('#txtEmail_Val').hide();
				    }
				});
            }
            else {
                $('#txtEmail_Val').show();
            }

        }

        function CheckInputPwd() {
            if ($('#reg_password').val() == '') {
                $('#txtPassword_Val').show();
            } else if ($('#txtPassword').val() != '') {
                $('#txtPassword_Val').hide();
            }
            if ($('#reg_password_r').val() == '' || $('#reg_password_r').val() != $('#reg_password').val()) {
                $('#txtPasswordConfirm_Val').show();
            } else {

                $('#txtPasswordConfirm_Val').hide();
            }
            return true;
        }
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="MainWrap_Car" style="background: #fff;">
        ﻿<div class="PassportWrap">
            <div class="RegisterWrap">
                <h4>
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label></h4>
                <div class="intro">
                    
                        <asp:Label ID="lblDesc" runat="server" Text="Label">
                        </asp:Label>                           
                        <br />欢迎来到我们网站，如果您是新用户，请填写下面的表单进行注册
                    </div>
                <div class="error12" style="display: none">                
                </div>
                <div class="form">
                    <input name="forward" type="hidden" value=""><table width="100%" border="0" cellspacing="0"
                        cellpadding="0">
                        
                        
                        <tr>
                            <th>
                                <i>*</i>用户名：
                            </th>
                            <td>                                 
                                <input autocomplete="off" class="inputstyle _x_ipt"  required="true"  id="reg_user" 
                                    style="width: 120px;"maxlength="25" />
                                    <font id='txtEmail_Val' style="display:none" color=red>必须为邮箱格式。</font>邮箱格式，注册成功用户名不能修改。
                                   
                                   
                            </td>
                        </tr>
                        <tr>
                            <th>
                                <i>*</i>密码：
                            </th>
                            <td>
                                <input autocomplete="off" class="inputstyle _x_ipt"  type="password"  id="reg_password"
                                    style="width: 120px;" required="true" vtype="password" maxlength="25" />
                                    <font id='txtPassword_Val' style="display:none" color=red>请输入密码。 </font>密码可由6-16个字符组成，请注意：密码区分大小写。
                            </td>
                        </tr>
                        <tr>
                            <th>
                                <i>*</i>确认密码：
                            </th>
                            <td>
                                <input autocomplete="off" class="inputstyle _x_ipt" name="reg_password_r" type="password"
                                    style="width: 120px;" required="true" id="reg_password_r" vtype="password" maxlength="25" /><font id='txtPasswordConfirm_Val' style="display:none" color=red>重输一次密码。</font>
                            </td>
                        </tr>
                        <tr>
                            <th>
                                <i>*</i>景区：
                            </th>
                            <td>                                
                                <select id="ddlJingQu">
                                    <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <option value='<%# DataBinder.Eval(Container.DataItem, "Jingqucode") %>'><%# DataBinder.Eval(Container.DataItem, "Jingquname") %></option>
                                    </ItemTemplate>
                                    </asp:Repeater>
                                    
                                </select>
                            </td>
                        </tr>
                        
                        
                        <tr>
                            <th>
                            </th>
                            <td>
                                <input class="actbtn btn-register" type="submit" value="注册新用户" id='subCreate' /> 
                                 <input id="hidGobackTo" type="hidden" value="<%=Request .QueryString["r"] %>" />               
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
