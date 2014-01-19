<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderview.aspx.cs" Inherits="dx177.WebUI.admin.HotelMgnt.orderview" %>
<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register Src="../../usercontrols/UCSingleImgUpload.ascx" TagName="UCSingleImgUpload"
    TagPrefix="uc1" %>
<%@ Register Src="../../usercontrols/UCImgupload.ascx" TagName="UCImgupload" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NewNews</title>
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script>
        $(document).ready(function() {


    });
        
        
        //1提交，2草稿，0，不验证。
        function ValidationInput(flag) {
            if (flag == 1) {
                
            }
            else {
            }
        }
    </script>

</head>
<body >
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
                                            预定酒店信息</td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                           订单编号： 
                                        </td>                                        
                                        <td>
                                            <asp:Label ID="lblOrderno" runat="server" Text=""></asp:Label>
                                        </td>
                                        <td class="td_title" width="15%">
                                           预订时间： 
                                        </td>
                                        <td>
                                             <asp:Label ID="lblCreatedate" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td class="td_title" width="15%">
                                           预订酒店： 
                                        </td>
                                        <td colspan=3>                                        
                                         <asp:Label ID="lblHoteltiel" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                           房间名称： 
                                        </td>
                                        <td colspan=3>                                        
                                            <asp:Label ID="lblRoomtitle" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                           房间数： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblRoomCount" runat="server" Text=""></asp:Label>
                                        </td>
                                        <td class="td_title" width="15%">
                                           几晚： 
                                        </td>
                                        <td>                                        
                                            <asp:Label ID="lblNights" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td_title" width="15%">
                                           入住人姓名： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblPersonName" runat="server" Text=""></asp:Label>
                                        </td>
                                        <td class="td_title" width="15%">
                                           入住人手机： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblPersonPhone" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td class="td_title" width="15%">
                                           订单人姓名： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblOrderusername" runat="server" Text=""></asp:Label>
                                        </td>
                                        <td class="td_title" width="15%">
                                           订单人手机： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblOrderuserphone" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                        <tr>
                                        <td class="td_title" width="15%">
                                           入住时间： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblBegin" runat="server" Text=""></asp:Label>
                                        </td>
                                        <td class="td_title" width="15%">
                                           离开时间： 
                                        </td>
                                        <td>                                        
                                         <asp:Label ID="lblEnd" runat="server" Text=""></asp:Label>   
                                        </td>
                                        
                                    </tr>    
                                    <tr>
                                         <td class="td_title" width="15%">
                                           最晚到达时间： 
                                        </td>
                                         <td >
                                         <asp:Label ID="lblReachDate" runat="server" Text=""></asp:Label>
                                        </td>
                                        <td class="td_title" width="15%">
                                           总金额： 
                                        </td>
                                         <td >
                                         <asp:Label ID="lblTotalMoney" runat="server" Text=""></asp:Label>
                                        </td>                                        
                                    </tr>    
                                        
                                     <tr>
                                        <td class="td_title" width="15%">
                                           备注： 
                                        </td>
                                         <td colspan=3>                                        
                                            <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
                                        </td>                                       
                                    </tr>   
                                     <tr>
                                        <td class="td_title" width="15%">
                                          状态： 
                                        </td>
                                         <td colspan=3>                                        
                                             <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection=Horizontal>
                                             </asp:RadioButtonList>
                                        </td>                                       
                                    </tr>                               
                                </table>
                                <table width="100%">
                                    <tr>
                                        <td align="right" width="100%">
                                            <asp:Button ID="btnSave" runat="server" CssClass="button" Text="保存" OnClientClick="return ValidationInput(1)"
                                                OnClick="btnSave_Click"></asp:Button><asp:Button ID="btnReturn" OnClientClick="parent.tb_remove(); return false;"
                                                    runat="server" CssClass="button" Text="返回"  ></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
