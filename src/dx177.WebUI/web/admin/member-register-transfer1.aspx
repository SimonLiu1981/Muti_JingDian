<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-register-transfer1.aspx.cs" Inherits="dx177.WebUI.web.admin.member_register_transfer1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .choseClass1
        {
            font-size:18px;
            color:#999999;
                
        }
        #choseClass ul
        {
            background:#f0f5fe;
            margin:10px;                
        }
         #choseClass ul li
        {
            padding-left:25px;
            padding-bottom:25px;
            width:269px;       
            float:left;     
        }
        
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="blank05">
    </div>
    <div class="blank05">
    </div>      
    <div id="MainWrap_Car" style="background: #fff;">
        <h1 class="choseClass1">请选择注册用户类型</h1>
        <div id='choseClass'  style=" border:#abd2e8 1px solid;">
            <ul>                
                <li><a title="酒店" href="/register/4/default.aspx">
                    <img border="0" src="/web/admin/img/zc_9.jpg"></a></li>
                
                
                <li><a title="租车企业" href="/register/2/default.aspx">
                    <img border="0" src="/web/admin/img/zc_17.jpg"></a></li>
                 
                <li><a title="餐饮企业" href="/register/3/default.aspx">
                    <img border="0" src="/web/admin/img/zc_25.jpg"></a></li></ul>
                    <div class="clear"></div>
        </div>        
    </div>
</asp:Content>
