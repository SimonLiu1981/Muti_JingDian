<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UndefinedJingQu.aspx.cs"
    Inherits="dx177.WebUI.UndefinedJingQu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="js/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="Plugin/dingcai/dingcai.js" type="text/javascript"></script>


    <script language="javascript" type="text/javascript">
// <!CDATA[
        function Button1_onclick() {
            UpdateSupportOppose();
        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        不是有效的景区！
        <ul>
            <li>踩<span oppose_guid='123'>0</span> </li>
            <li>踩<span oppose_guid='aaaaaaa'>0</span> </li>
            <li>顶<a href='javascript:;' support_guid='123'>0</a> </li>
        </ul>
        <input id="txtGood" type="text" support_guid="278ffba7-b47d-48b3-b9bd-d151c58a6453" >
        <input id="Text1" type="text"   oppose_guid="278ffba7-b47d-48b3-b9bd-d151c58a6453" >
        <input id="Button1" type="button" value="button" onclick="return Button1_onclick()" />
    </div>
    </form>
</body>
</html>
