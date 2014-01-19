<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imHotel.aspx.cs" Inherits="dx177.WebUI.ImportTool.imHotel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>导入酒店 Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        HotelID:
        <asp:TextBox ID="txtHotelId" runat="server"></asp:TextBox>
        <br />
        JingQuCode:<asp:TextBox ID="txtJingQuCode" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="导入酒店" /> 
    
    </div>
    </form>
</body>
</html>
