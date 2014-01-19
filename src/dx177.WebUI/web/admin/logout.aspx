<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="dx177.WebUI.web.admin.logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="/js/jQuery.Times.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            $('#login_info').oneTime(1000, 'mytimer', function() {
                location.href = '/default.aspx';
            });
        });    
    </script>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    你已经成功退出！    
</asp:Content>
