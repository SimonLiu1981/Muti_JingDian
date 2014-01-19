<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="BuildPage.aspx.cs" Inherits=" dx177.WebUI.admin.BuildMgnt.BuildPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <table style=" width:80%; ">
        <tr>
            <td class="le" style=" width:150px">
                <asp:CheckBox ID="cbAll" runat="server"  AutoPostBack="true" OnCheckedChanged="cbAll_CheckedChanged"  Text="全选/全非选" />
            </td>
            <td class="le">
                <asp:CheckBoxList ID="chkList" runat="server">
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="le"    colspan=2>
                <asp:Button ID="bntCreate" runat="server" Text="生成" OnClick="bntCreate_Click" Width="70px" />
                &nbsp;
                </td>
        </tr>
        <tr>
            <td class="le">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="le">
              <a href='<%=Defaulthomepage %>'  target=_blank > 查看首页</a>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
