<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusIssueInfoPage.aspx.cs" ValidateRequest="false" Inherits="dx177.WebUI.admin.NewsMgnt.BusIssueInfoPage" %>

 <%@ Import namespace="System.ComponentModel"%>
 
<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register src="../../usercontrols/UCImgupload.ascx" tagname="UCImgupload" tagprefix="uc1" %>
<%@ Register src="../../usercontrols/UCSingleImgUpload.ascx" tagname="UCSingleImgUpload" tagprefix="uc2" %>
<%@ Register assembly="My97" namespace="My97" tagprefix="cc2" %>
<%@ Register src="../../usercontrols/UCModelType.ascx" tagname="UCModelType" tagprefix="uc3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>酒店列表</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	     <link href="../css/cssCn1.css" type="text/css" rel="stylesheet">
         <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

        <script src="../../js/jquery-1.3.2.min.js" type="text/javascript"></script>
        <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>

    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>         
    <script src="/Plugin/dingcai/dingcai.js" type="text/javascript"></script>

     <script type ="text/javascript">

         KindEditor.ready(function(K) {
             var editor1 = K.create('#fckContent', {
                 cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                 uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                 fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                 allowFileManager: true
             });
             prettyPrint();
         });
          </script>
	    </HEAD>
	<body MS_POSITIONING="GridLayout" id="thebody">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td>
						<div class="div_subtitle">当前位置：内容管理<span class="arrow_subtitle">&gt;</span>内容发布</div>
					</td>
				</tr>
			</table>
			<TABLE id="tb_content" cellSpacing="0" cellPadding="0">
				<TBODY>
					<tr>
						<td>
							<TABLE id="tb_content" cellSpacing="0" cellPadding="0">
								<tr>
									<td>
										<TABLE class="tb_input" id="queryPane" cellSpacing="1" cellPadding="0" width="100%" align="center"
											bgColor="#ffffff" border="0">
											<TBODY>
												<tr>
													<td colSpan="4"><IMG src="../Img/showtoc.gif"> 内容信息 
													</td>
												</tr>
												<TR>
													<TD class="td_title" width="15%"><FONT face="宋体">标题</FONT></TD>
													<TD colSpan="3">
													
													 
													    <asp:TextBox ID="txtTitle" runat="server" Width="358px"></asp:TextBox>
													
													 
													    <asp:HiddenField ID="txt1Guid" runat="server" />
													
													 
													</TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">类型</TD>
													<TD >
                                                        <asp:DropDownList ID="drpInfotype" runat="server" 
                                                            Width="140px">
                                                        </asp:DropDownList>
                                                    </TD>
													<TD class="td_title" width="15%">代码</TD>
													<TD>
                                                        <asp:textbox id="txtCode" runat="server" 
                                                            Width="140px"></asp:textbox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">顶</TD>
													<TD >
                                                        <asp:textbox id="txtGood" runat="server" 
                                                            Width="140px"></asp:textbox>
                                                    </TD>
													<TD class="td_title" width="15%">踩</TD>
													<TD>
                                                        <asp:textbox id="txtBad" runat="server" 
                                                            Width="140px"></asp:textbox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">浏览次数</TD>
													<TD >
                                                        <asp:textbox id="txtViewtimes" runat="server" 
                                                            Width="140px"></asp:textbox>
                                                    </TD>
													<TD class="td_title" width="15%">发布时间</TD>
													<TD>
                                    <cc2:DateTextBox ID="dateCreateDate" runat="server" Width="140px"></cc2:DateTextBox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">模块</TD>
													<TD >
                                                        <uc3:UCModelType ID="UCModelType1" runat="server" />
                                                    </TD>
													<TD class="td_title" width="15%">最后更新时间</TD>
													<TD>
                                    <cc2:DateTextBox ID="dateLasteUpdateDate" runat="server" Width="140px"></cc2:DateTextBox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">简介</TD>
													<TD colSpan="3">
													
													 
														<asp:TextBox ID="txtShortcontent" runat="server" Rows="3" TextMode="MultiLine" 
                                                            Width="674px" Height="87px"></asp:TextBox>
													
													 
													</TD>
												</TR>
												<TR >
													<TD class="td_title" width="15%">logo</TD>
													<TD  colspan="3">
														<uc2:UCSingleImgUpload ID="UCSingleImgUpload1" runat="server" />
                                                    </TD>
												</TR>
												<TR  >
													<TD class="td_title" width="15%">描述</TD>
													<TD  colspan="3">
														   <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                height: 200px; visibility: hidden;"></textarea>
                                                        </TD>
												</TR>
											</TBODY>
										</TABLE>
									</td>
								</tr>
							</TABLE>
							<table width="100%">
								<tr>
									<td align="right" width="100%"><asp:button id="btnSave"  OnClientClick="return checkImg();" runat="server" 
                                            CssClass="Button" Text="保存" onclick="btnSave_Click"></asp:button>
                                        <asp:button id="btnReturn" runat="server" CssClass="Button" Text="返回"></asp:button></td>
								</tr>
							</table>
						</td>
					</tr>
				</TBODY>
			</TABLE>
		</form>
		</TD></TR></TBODY></TABLE>
	</body>
</HTML>
