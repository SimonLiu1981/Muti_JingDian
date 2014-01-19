<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="member-vieworder.aspx.cs"
    Inherits="dx177.WebUI.web.admin.member_vieworder" %>

<table width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td width="77" height="26" align="right">
            订&nbsp; 单&nbsp; 号：
        </td>
        <td width="177">
           <%=HOrder.Orderno %>
        </td>
        <td width="76" align="right">
            预订时间：
        </td>
        <td>
            <%=HOrder.CreateDate.ToString("yyyy-MM-dd") %>
        </td>
    </tr>
    <tr>
        <td height="26" align="right">
            预订酒店：
        </td>
        <td colspan="3">
           <%=HOrder.Hotelname %>             
        </td>
    </tr>
    <tr>
        <td height="26" align="right">
            预订客房：
        </td>
        <td colspan="3">
           <%=HOrder.Roomtitle %>
        </td>
    </tr>
    <tr>
        <td height="26" align="right">
            房&nbsp; 间&nbsp; 数：
        </td>
        <td width="177">
           <%=HOrder.Roomcount %>
        </td>
        <td width="76" align="right">
            
        </td>
        <td colspan="2">
           <%= (HOrder.Enddate-HOrder.Begindate ).Days %> 晚
        </td>
    </tr>
    <tr>
        <td height="26" align="right">
            入住人：
        </td>
        <td width="177">
           <%=HOrder.Personname %>
        </td>
        <td align="right">
             入住人手机：
        </td>
        <td colspan="2">
           <%=HOrder.Personphone %> 
        </td>
    </tr>
    <tr>
        <td height="26" align="right">
            入住时间：
        </td>
        <td>
            <%=HOrder.Begindate.ToString("yyyy-MM-dd") %>
        </td>
        <td align="right">
            离开时间：
        </td>
        <td>
            <%=HOrder.Enddate.ToString("yyyy-MM-dd") %>  
        </td>
    </tr>
    <tr>
        <td height="30" class="button_bg">
            &nbsp;
        </td>
        <td colspan="3" class="button_bg">
            <input type="submit" name="button" id="button" value="确定" class="sumit_viewOrder" onclick="$.fancybox.close()">
        </td>
    </tr>
</table>
