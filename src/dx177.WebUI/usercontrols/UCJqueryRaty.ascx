<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCJqueryRaty.ascx.cs" Inherits="dx177.WebUI.usercontrols.UCJqueryRaty" %>
<script>$(function() {$('#<%=Sc.ClientID %>').raty({readOnly:  <%=ReadOnly.ToString().ToLower() %>,hintList:     ['差', '一般', '好', '很好', '非常好'],noRatedMsg:   '暂无评论！',half: true,path: '/Plugin/jquery.raty-1.3.2/img/',start: <%=Score %>,click: function(score) {$('#<%=Scv.ClientID %>').val(score);}});});   
function GetRatyValue(controlID){return $('#'+ controlID + "_Scv" ).val();} </script>
<div id="Sc" runat=server><asp:HiddenField ID="Scv" runat="server" /></div>


