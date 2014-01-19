<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomPircePage.aspx.cs" Inherits="dx177.WebUI.admin.HotelMgnt.RoomPircePage" %>

 
 <%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>

<%@ Register src="../../usercontrols/UCImgupload.ascx" tagname="UCImgupload" tagprefix="uc1" %>
<%@ Register src="../../usercontrols/UCSingleImgUpload.ascx" tagname="UCSingleImgUpload" tagprefix="uc2" %>
<%@ Register src="../../usercontrols/UCModelType.ascx" tagname="UCModelType" tagprefix="uc3" %>
<%@ Register assembly="My97" namespace="My97" tagprefix="cc2" %>
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
	     
	    <script type="text/javascript" src="/web/js/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="/web/js/jquery.tools.min.js"></script>
    
    
     <script type="text/javascript">

        function ValidationInput() {
            if ($("#txtPrice").val() == '') {
                alert("请输入价格!");
                $("#txtPrice").focus();
                return false;
            }
            
             if ($("#dateStar").val() == '') {
                alert("请录入起始日期!");
                $("#dateStar").focus();
                return false;
            }
            
            
            
             if ($("#dateEnd").val() == '') {
                alert("请录入结束日期!");
                $("#dateEnd").focus();
                return false;
            }
            return true ;
        }
    
    </script>



	    </HEAD>
	<body MS_POSITIONING="GridLayout" id="thebody">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td>
						<div class="div_subtitle">当前位置：酒店管理<span class="arrow_subtitle">&gt;</span>房间价格</div>
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
													<td colSpan="2"><IMG src="../Img/showtoc.gif"> 房间价格</td>
												</tr>
												<TR>
													<TD class="td_title" width="15%"><FONT face="宋体">房型</FONT></TD>
													<TD>
													<asp:label  runat="server"  id="lbRoomTitle" ></asp:label>
													 
													    &nbsp;</TD>
												</TR>
											 
												<TR  >
													<TD class="td_title" width="15%">起始时间：</TD>
													<TD>
														<cc2:DateTextBox ID="dateStar" runat="server"></cc2:DateTextBox>
                                                    </TD>
												</TR>
											 
												<TR  >
													<TD class="td_title" width="15%">结束时间：</TD>
													<TD>
														<cc2:DateTextBox ID="dateEnd" runat="server"></cc2:DateTextBox>
                                                    </TD>
												</TR>
											 
												<TR  >
													<TD class="td_title" width="15%">价格：</TD>
													<TD>
                                    <asp:TextBox ID="txtPrice" runat="server" Width="128px"></asp:TextBox>
                                                    </TD>
												</TR>
											 
												<TR  >
													<TD class="td_title" width="15%">&nbsp;</TD>
													<TD>
														<asp:button id="btnSave"   OnClientClick="return ValidationInput();"  runat="server" 
                                            CssClass="Button" Text="保存" onclick="btnSave_Click"></asp:button>
                                                    &nbsp;
                                        <asp:button id="btnReturn" runat="server" CssClass="Button" Text="返回" onclick="btnReturn_Click"></asp:button>
                                                    </TD>
												</TR>
											</TBODY>
										</TABLE>
									</td>
								</tr>
							</TABLE>
							<table width="100%">
								<tr>
									<td align="right" width="100%">
                    
                    
                    <cc1:ZteGrid ID="dgRoomPrice" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" 
                        PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgRoomPrice_ItemDataBound" 
                        OnItemCommand="dgRoomPrice_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>                            
                           
                            <asp:BoundColumn DataField="HotelName" HeaderText="酒店"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RoomTitle" HeaderText="房型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Price" HeaderText="价格"></asp:BoundColumn>
                              <asp:BoundColumn DataField="SDate" HeaderText="起始日期"></asp:BoundColumn> 
                              <asp:BoundColumn DataField="EDate" HeaderText="结束日期"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="40px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>    
                                                                                                
                                          <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <HeaderStyle CssClass="tr_title"></HeaderStyle>
                        <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                        <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                    </cc1:ZteGrid>
                                    </td>
								</tr>
							</table>
						</td>
					</tr>
				</TBODY>
			</TABLE>
		</form>
		 
	</body>
</HTML>
