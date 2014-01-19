<%@ Page language="c#" Codebehind="PassWordManager.aspx.cs" AutoEventWireup="True" Inherits="dx177.WebUI.admin.UserMgnt.PassWordManager" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>PassWordManager</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cssCn.css" type="text/css" rel="stylesheet">
		    <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../js/jQuery.Inputlimitor.js" type="text/javascript"></script>
  </HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td>
						<div class="div_subtitle">当前位置：系统管理<span class="arrow_subtitle">&gt;</span>修改密码</div>
					</td>
				</tr>
			</table>
			<table align="center" cellPadding="0" cellSpacing="0" id="tb_content">
				<TBODY>
					<tr>
						<td>
							<TABLE class="tb_searchbar" cellSpacing="1" width="100%">
								<TBODY>
									<TR>
										<TD colspan="4" noWrap class="tb_input">   <img src="../Img/showtoc.gif">密码修改</TD>
									</TR>
									<TR>
										<TD noWrap class="td_title" width="18%">旧密码:</TD>
										<TD colspan="3" width="82%">
											<asp:TextBox id="txtOldPassWord" limitorlength=10 runat="server" TextMode="Password"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD class="td_title" noWrap width="18%">新密码:</TD>
										<TD width="82%" colSpan="3">
												<asp:TextBox id="txtNewPassWord" runat="server" TextMode="Password" limitorlength=10></asp:TextBox></TD>
									</TR>
									<TR>
										<TD class="td_title" noWrap width="18%"><FONT face="宋体">重新输入新密码:</FONT></TD>
										<TD width="82%" colSpan="3"><FONT face="宋体">
												<asp:TextBox id="txtRepitPassWord" runat="server" TextMode="Password"></asp:TextBox></FONT></TD>
									</TR>
								</TBODY>
							</TABLE>
							<TABLE cellSpacing="0" cellpadding="0" width="100%">
								<tr>
									<td height="5"></td>
								</tr>
							</TABLE>
							<div align="right">
								
								<asp:Button id="btnSave" runat="server" Text="保存" CssClass="button" onclick="btnSave_Click"></asp:Button>&nbsp;
							</div>
							<div align=center>
								<asp:Label id="lblMsg" runat="server" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
							</div>
						</td>
					</tr>
				</TBODY>
			</table>
		</form>
	</body>
</HTML>
