<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-login.aspx.cs" Inherits="dx177.WebUI.web.admin.member_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />

    <script type="text/javascript">


        function Login1() {
            if ($('#username1').val() == '' || $('#password1').val() == '') {
                $('.error12').html('用户或者密码不能为空');
                $('.error12').show();
                if ($('#username1').val() == '') {
                    $('#username1').focus();
                }
                else {
                    $('#password1').focus();
                }
                return false;
            }
            $.getJSON("/web/Admin/AjaxHandler.aspx?MethodName=Login&jsoncallback=?",
		        {
		            username: encodeURIComponent($('#username1').val()),
		            password: encodeURIComponent($('#password1').val())
		        },
		        function(json) {
		            if (json.Result.Result == 1) {
		                if ($('#hidGobackTo').val() != '') {
		                    location.href = $('#hidGobackTo').val();
		                }
		                else {
		                    if (json.Result.NavigationUrl) {
		                        location.href = json.Result.NavigationUrl;
		                    }		                 
		                }
		                
		            }
		            if (json.Result.Result == 2) {
		                $('.error12').html('密码有误，请重新输入');
		                $('.error12').show();
		                $('#username1').focus();
		            }
		            if (json.Result.Result == 0) {
		                $('.error12').html('用户名不存在，请重新输入');
		                $('.error12').show();
		                $('#password1').focus();
		            }
		        });
		    }

		    $(document).ready(function() {

		        if ($('#hidGobackTo').val() != '') {
		            //用户注册
		            $('#register1').attr('href', "/register/1/default.aspx?r=" + encodeURIComponent($('#hidGobackTo').val()));
		        }

		    });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="MainWrap_Car" style="background: #fff;">
        <div class="PassportWrap">
            <div class="RegisterWrap">
                <h4>
                    已注册用户，请登录</h4>
                <div class="intro">
                    如果您已经是本站会员，请登录</div>
                <div class="error12" style="display: none">
                </div>
                <div class="form">
                    <input name="forward" type="hidden" value="" /><table width="100%" border="0" cellspacing="0"
                        cellpadding="0">
                        <tr>
                            <th>
                                <i>*</i>用户名：
                            </th>
                            <td>
                                <input autocomplete="off" class="inputstyle _x_ipt" id="username1" tabindex="1" value=""
                                    style="width: 100px;" /><a style="margin-left: 6px;" id='register1' href="/register/default.aspx">立即注册</a>
                            </td>
                        </tr>
                        <tr>
                            <th>
                                <i>*</i>密码：
                            </th>
                            <td>
                                <input autocomplete="off" class="inputstyle _x_ipt" type="password" tabindex="2"
                                    required="true" id="password1" style="width: 100px;" vtype="password" />
                                <%--<a style="margin-left: 6px;" href="#">忘记密码？</a>--%>
                            </td>
                        </tr>
                        <%--<tr>
                            <th>
                                <i>*</i>验证码：
                            </th>
                            <td id='verifyCodebox'>
                                <input autocomplete="off" size="8" class="inputstyle _x_ipt" type="digits" required="true"
                                    name="loginverifycode" id="iptlogin" tabindex="3" vtype="digits" /><span class='verifyCode'
                                        style='display: none;'><img src="img/" border="1" id="LoginimgVerifyCode" /><a href="javascript:changeimg()">&nbsp;看不清楚?换个图片</a></span>
                            </td>
                        </tr>--%>
                        <tr>
                            <th>
                            </th>
                            <td>
                                <input class="actbtn btn-login" type="submit" value="登录" tabindex="3" onclick="return Login1();" />     
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
