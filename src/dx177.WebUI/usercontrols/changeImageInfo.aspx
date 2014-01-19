<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changeImageInfo.aspx.cs"
    Inherits="dx177.WebUI.usercontrols.changeImageInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="/admin/css/cssCn.css" type="text/css" rel="stylesheet">

    <script type="text/javascript" src="/web/js/jquery-1.3.2.min.js"></script>

    <script language="javascript" type="text/javascript">
// <!CDATA[

        function btnSave_onclick() {

            var res = dx177.WebUI.usercontrols.changeImageInfo.AjaxUpdateByPicsId('<%=Request.QueryString["picSeqno"]%>', $('#txtTitle').val(), parseInt($('#txtShowidx').val()));
            parent.UCGetPicsList();
            parent.tb_remove();
        }

        function btnClose_onclick() {
            parent.tb_remove();
        }
        
// ]]>
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="tb_content" cellspacing="0" cellpadding="0" style="margin-top:5px">
            <tr>
                <td>
                    <table class="tb_input" id="queryPane" cellspacing="1" cellpadding="0" width="100%"
                        align="center" bgcolor="#ffffff" border="0">
                         <tr>
                            <td colspan="2" class="td_head">
                                图片信息 
                            </td>
                        </tr>
                        <tr>
                            <td class=td_title>
                                图片：
                            </td>
                            <td>
                                <asp:Image ID="Image1" runat="server" Width="110" />
                            </td>
                        </tr>
                        <tr>
                            <td class=td_title>
                                显示名：
                            </td>
                            <td>
                                <asp:TextBox ID="txtTitle" runat="server" MaxLength="15"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class=td_title>
                                显示顺序：
                            </td>
                            <td>
                                <asp:TextBox ID="txtShowidx" Width="80" runat="server"></asp:TextBox> (整数，值大排在前面)
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <input id="btnSave" type="button" value="保存" onclick="return btnSave_onclick()" />
                                <input id="btnClose" type="button" value="关闭" onclick="return btnClose_onclick()" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
