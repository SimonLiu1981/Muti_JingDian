<%@ Page Language="c#" CodeBehind="login.aspx.cs" AutoEventWireup="True" Inherits="dx177.WebUI.Admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>一起去丹霞 网站后台管理</title>
    <script src="/js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="/js/jquery.cookie.js" type="text/javascript"></script> 
    <link href="/admin/frame/img/login.css" rel="stylesheet" type="text/css" />
    
     <script type="text/javascript">

         function vaildation(flag) {
             if ($('#txtName').val() == '') {
                 $('#txtName').focus();
                 alert("请输入用户名！");
                 return false;
             }
             if ($('#txtPassWord').val() == '') {
                 //$('#txtpwd').focus();
                 //alert("请输入密码！");
                 //return false;
             }
             if ($('#txtcode').val() == '') {
                 $('#txtcode').focus();
                 //alert("请输入验证码！");
                 //return false;
             }
             $.cookie('txtName', $('#txtName').val());
             return true;
         }

         $(document).ready(function() {
             if ($('#txtuserid').val() == '') {
                 $('#txtuserid').focus();
             }

             if ($.cookie('txtName') != null) {
                 $('#txtName').val($.cookie('txtName'));
             }
         });
    
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="login">
        <div id="top">
            <div id="top_left">
                <img src="frame/img/login_03.gif" /></div>
            <div id="top_center">
            </div>
        </div>
        <div id="center">
            <div id="center_left">
            </div>
            <div id="center_middle">
                <div id="user">
                    <div class="title">
                        用&nbsp; 户</div>
                    <div class="detail">
                        <asp:TextBox ID="txtName" runat="server" Width="80px"></asp:TextBox></div>
                </div>
                <div id="password">
                    <div class="title">
                        密&nbsp; 码</div>
                    <div class="detail">
                        <asp:TextBox ID="txtPassWord" runat="server" CssClass="button1" TextMode="Password"
                            Width="80px"></asp:TextBox></div>
                </div>
                <div id="Valid">
                    <div class="title">
                        验证码</div>
                    <div class="detail">
                        <asp:TextBox ID="txtcode" runat="server" CssClass="button2" Width="80px"></asp:TextBox><asp:Image
                            ID="imgcode" runat="server" ImageUrl="CheckCode.aspx"></asp:Image>
                    </div>
                </div>
                <div id="btn">
                    <asp:Button ID="btnLogin" runat="server" Text="登录" onclick="btnLogin_Click" OnClientClick="return vaildation(1);" /><asp:Button ID="btnClear" runat="server"
                        Text="清空" />
                </div>
            </div>
            <div id="center_right">
            </div>
        </div>
        <div id="down">
            <div id="down_left">
                <div id="inf">
                    <span class="inf_text">版本信息</span> <span class="copyright">帕讯中文版购物网店系统 V1.2</span>
                </div>
                  
            </div>
            <div id="down_center">
                 <asp:Label ID="lblMsg" CssClass=inf_error runat="server" Text=""></asp:Label>
            </div>
        </div>
        
    </div>
    </form>
</body>
</html>
