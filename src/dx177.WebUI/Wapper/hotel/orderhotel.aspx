<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderhotel.aspx.cs" Inherits="dx177.WebUI.Wapper.hotel.orderhotel" MasterPageFile="~/Home.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">

        function resetsize(obj) {
            var mainheight = $(obj).contents().find("body").height() + 30;           
            $(this).height(mainheight);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <iframe width='950px' height='900px' frameborder=0 src="http://www.api.zhuna.cn/e/b.php?agent_id=<%=agent_id %>&agent_md=<%=agent_md %>&hid=<%=hid %>&rid=<%=rid %>&pid=<%=pid %>&tm1=<%=tm1 %>&tm2=<%=tm2 %>" id='orderiframe' onload="resetsize(this)">
     
     </iframe>
 </asp:Content>