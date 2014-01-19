<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ser.aspx.cs" Inherits="dx177.WebUI.ser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td> <asp:TextBox ID="txtcontent" runat="server" Height="221px" TextMode="MultiLine" 
            Width="633px"></asp:TextBox>   </td>
    
    
    </tr>
    
    <tr>
    <td>  &nbsp;  
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Value="H">酒店问题</asp:ListItem>
            <asp:ListItem Value="A">问题</asp:ListItem>
            <asp:ListItem Value="R">回复</asp:ListItem>
        </asp:RadioButtonList>
                    </td>
    
    
    </tr>
    
    </table>
       
        <br />
        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="执 行" 
            Width="93px" />
       <br />
      问题： 标题$$内容$$创建人$$类型|| 标题$$内容$$创建人$$类型 <br />
      回复： 内容$$创建人$$ID$$最佳(0/1)|| 内容$$创建人$$ID$$最佳(0/1)  <br />
      酒店问题： 内容$$酒店ID$$酒店回复 || 内容$$酒店ID$$酒店回复 <br />
    </div>
    </form>
</body>
</html>
