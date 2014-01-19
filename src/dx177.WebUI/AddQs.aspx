<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddQs.aspx.cs" Inherits="dx177.WebUI.AddQs" %>

<%@ Register src="Control/UCProvinceCity.ascx" tagname="UCProvinceCity" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="http://price.un.zhuna.cn/room.gbk.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://price.un.zhuna.cn/room.utf8.js"></script>

    <script src="js/jquery-1.4.3.min.js" type="text/javascript"></script>



</head>
<body>
    <form id="form1" runat="server">
    <uc1:UCProvinceCity ID="UCProvinceCity1" 
                runat="server" />
    <div>
        <div id='h10605' >...正在加载房间信息，请稍候(10605)...
        </div>
        <div id='h10606' >...正在加载房间信息，请稍候(10606)...</div>
    
        <input id="File1" type="file" runat=server  />&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" />
    
    </div>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
    </form>
    

    <script type="text/javascript" src="http://price.un.zhuna.cn/json.php?hid=10605,10606&tm1=2011-09-02&tm2=2011-09-03&call=callback"></script>
    
    <script type="text/javascript">

        function dobook(hid, rid, pid) {

            var url = '/htmlhotel_17.html?' + "hid=" + hid + "rid=" + rid + "pid=" + pid;
            window.open(url);
            
        }
        
    
    </script>
</body>
</html>
