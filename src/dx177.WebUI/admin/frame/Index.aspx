<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="dx177.WebUI.Admin.Frame.Index" %>

<html >
<head>
  <title>һ��ȥ��ϼ ��վ��̨����</title>
    <meta name="keywords" content="�����ó��վ,��ѹ�����վ,��ѿ�����,�������,����̳�,�����ó�̳�,����������,��ó������,��˾��վ����,��˾������վ����,������,�������,��ѿ�����,����ʵ����,��ο�����,����������,����ϵͳ,��վ����" />
    <meta name="description" content="�����ó��վ,��ѹ�����վ,��ѿ�����,�������,����̳�,�����ó�̳�,����������,��ó������,��˾��վ����,��˾������վ����,������,�������,��ѿ�����,����ʵ����,��ο�����,����������,����ϵͳ,��վ����" />
    <script type="text/javascript" language="JavaScript">
<!--
        function switchSysBar() {
            var src = document.getElementById("myarrow").src;
            if (src.indexOf("arrow_l.gif") != -1) {
                document.getElementById("myarrow").src = document.getElementById("myarrow").src.replace("arrow_l.gif", "arrow_r.gif");
                document.getElementById("myarrow").title = "չ��";
                document.all("frmTitle").style.display = "none"
            } else {
                document.getElementById("myarrow").src = document.getElementById("myarrow").src.replace("arrow_r.gif", "arrow_l.gif");
                document.getElementById("myarrow").title = "�۵�";
                document.all("frmTitle").style.display = "";
            }
        }

 
        

//-->
    </script>
</head>
<body style="margin: 0px"   >
    <table height="100%" id="tbS" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tbody>
            <tr  >
                <td colspan="3">
                    <iframe style="z-index: 1; visibility: inherit; width: 100%; height: 79px" name="Explorer_Tool"
                        marginwidth="0" marginheight="0" src="FrameTop.aspx" frameborder="0" noresize
                        scrolling="no" bordercolor="threedface"></iframe>
                </td>
            </tr>
            <tr >
                <td id="frmTitle" align="middle" width="135" height="100%">
                    <iframe style="z-index: 2; visibility: inherit; width: 150px; height: 100%" id="left"
                        name="left" marginwidth="0" framespacing="2" marginheight="0" scrolling="no"
                        src="leftmenu.aspx?topId=1" frameborder="0" noresize></iframe>
                </td>
                <td width="4px" bgcolor="#DCF4BF" style="height: 100%" onclick="switchSysBar()">
                    <a href="#">
                        <img id="myarrow" title="�۵�" src="img/arrow_l.gif" border="0"></a>
                </td>
                <td height="100%">
                    <iframe style="z-index: 3; visibility: inherit; width: 100%; height: 100%" id="right"
                        name="BoardRight" framespacing="0" src="main.aspx" frameborder="0"></iframe>
                </td>
            </tr>
        </tbody>
    </table>
</body>
</html>
