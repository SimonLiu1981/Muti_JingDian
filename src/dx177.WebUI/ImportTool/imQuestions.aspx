<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imQuestions.aspx.cs" ValidateRequest="false" Inherits="dx177.WebUI.ImportTool.imQuestions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>导入问题数据</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
           
        <asp:TextBox ID="TextBox1"  TextMode=MultiLine MaxLength=50 Rows=35 Columns=100 
            runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" 
            style="height: 26px; width: 40px;" />        <br />
        <a href=ImprotQuestions.xml>模板</a>
    </div>
    </form>
</body>
</html>
