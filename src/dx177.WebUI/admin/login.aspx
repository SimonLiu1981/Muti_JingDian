<%@ Page Language="c#" CodeBehind="login.aspx.cs" AutoEventWireup="True" Inherits="dx177.WebUI.Admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>һ��ȥ��ϼ ��վ��̨����</title>
    <script src="/js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="/js/jquery.cookie.js" type="text/javascript"></script> 
    <link href="/admin/frame/img/login.css" rel="stylesheet" type="text/css" />
    
     <script type="text/javascript">

         function vaildation(flag) {
             if ($('#txtName').val() == '') {
                 $('#txtName').focus();
                 alert("�������û�����");
                 return false;
             }
             if ($('#txtPassWord').val() == '') {
                 //$('#txtpwd').focus();
                 //alert("���������룡");
                 //return false;
             }
             if ($('#txtcode').val() == '') {
                 $('#txtcode').focus();
                 //alert("��������֤�룡");
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
                        ��&nbsp; ��</div>
                    <div class="detail">
                        <asp:TextBox ID="txtName" runat="server" Width="80px"></asp:TextBox></div>
                </div>
                <div id="password">
                    <div class="title">
                        ��&nbsp; ��</div>
                    <div class="detail">
                        <asp:TextBox ID="txtPassWord" runat="server" CssClass="button1" TextMode="Password"
                            Width="80px"></asp:TextBox></div>
                </div>
                <div id="Valid">
                    <div class="title">
                        ��֤��</div>
                    <div class="detail">
                        <asp:TextBox ID="txtcode" runat="server" CssClass="button2" Width="80px"></asp:TextBox><asp:Image
                            ID="imgcode" runat="server" ImageUrl="CheckCode.aspx"></asp:Image>
                    </div>
                </div>
                <div id="btn">
                    <asp:Button ID="btnLogin" runat="server" Text="��¼" onclick="btnLogin_Click" OnClientClick="return vaildation(1);" /><asp:Button ID="btnClear" runat="server"
                        Text="���" />
                </div>
            </div>
            <div id="center_right">
            </div>
        </div>
        <div id="down">
            <div id="down_left">
                <div id="inf">
                    <span class="inf_text">�汾��Ϣ</span> <span class="copyright">��Ѷ���İ湺������ϵͳ V1.2</span>
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
