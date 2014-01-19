<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopPage.aspx.cs" ValidateRequest="false" Inherits="dx177.WebUI.admin.ShopMgnt.ShopPage" %>

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
        
        
    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    <script src="/Plugin/ViewTimes_0_1/ViewTimes_0_1.js" type="text/javascript"></script>
  <script type="text/javascript">


        KindEditor.ready(function(K) {
            var editor1 = K.create('#fckContent', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                allowFileManager: true,
                afterCreate: function() {
                    var self = this;
                    K.ctrl(document, 13, function() {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function() {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });
        $(document).ready(function() {

        var sortitem = new PictrueRequestSort("Restaurant", $('#txt1Guid').val(), "Ul1", "/img/upload/", "File1", "Div1");
        MultiPicUploadifyInit(sortitem);
        });
</script>
	    </HEAD>
	<body MS_POSITIONING="GridLayout" id="thebody">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td>
						<div class="div_subtitle">当前位置：商铺管理<span class="arrow_subtitle">&gt;</span>商铺发布</div>
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
													<td colSpan="4"><IMG src="../Img/showtoc.gif"> 商铺信息 
													</td>
												</tr>
												<TR>
													<TD class="td_title" width="15%">商铺名称</TD>
													<TD colSpan="3">
													
													 
													    <asp:TextBox ID="txtTitle" runat="server" Width="363px"></asp:TextBox>
													
													 
													    <asp:HiddenField ID="txt1Guid" runat="server" />
													
													 
													</TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">类型</TD>
													<TD >
                                                        <asp:DropDownList ID="drpBiztype" runat="server" 
                                                            Width="200px">
                                                        </asp:DropDownList>
                                                    </TD>
													<TD class="td_title" width="15%">所属景区地段</TD>
													<TD>
                                                        <asp:DropDownList ID="drpArea" runat="server" Width="200px">
                                                        </asp:DropDownList>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">旺旺</TD>
													<TD >
                                                        <asp:textbox id="txtAliww" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
													<TD class="td_title" width="15%">QQ</TD>
													<TD>
                                                        <asp:textbox id="txtQq" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">联系电话</TD>
													<TD >
                                                        <asp:textbox id="txtPhone" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
													<TD class="td_title" width="15%">手机</TD>
													<TD>
                                                        <asp:textbox id="txtMobile" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">开业时间</TD>
													<TD >
                                    <cc2:DateTextBox ID="dateRundate" runat="server" Width="199px"></cc2:DateTextBox>
                                                    </TD>
													<TD class="td_title" width="15%">人均消费</TD>
													<TD>
                                                        <asp:textbox id="txtCost" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">可容纳人数</TD>
													<TD >
                                                        <asp:textbox id="txtCapcount" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
													<TD class="td_title" width="15%">停车数</TD>
													<TD>
                                                        <asp:textbox id="txtParkcount" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">状态</TD>
													<TD >
													
													 <asp:RadioButtonList ID="rbtStatus" runat="server" RepeatDirection=Horizontal>
                                            
                                            </asp:RadioButtonList>
                                                    </TD>
													<TD class="td_title" width="15%">模块</TD>
													<TD>
                                                        <uc3:UCModelType ID="UCModelType1" runat="server" Type="Shop" />
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">浏览次数</TD>
													<TD >
													
                                            <asp:TextBox ID="txtViewtimes" runat="server" Width=201px  ></asp:TextBox>
                                                    </TD>
													<TD class="td_title" width="15%">排序</TD>
													<TD>
                                            <asp:TextBox ID="txtShowpr" runat="server" Width=201px  ></asp:TextBox>
                                                    </TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">地址</TD>
													<TD colSpan="3">
													
													 
														<asp:TextBox ID="txtAddress" runat="server" Rows="3" TextMode="MultiLine" 
                                                            Width="654px" Height="29px"></asp:TextBox>
													
													 
													</TD>
												</TR>
												<TR>
													<TD class="td_title" width="15%">经营特色</TD>
													<TD colSpan="3">
													
													 
														<asp:TextBox ID="txtBizcharacter" runat="server" Rows="3" TextMode="MultiLine" 
                                                            Width="654px" Height="47px"></asp:TextBox>
													
													 
													</TD>
												</TR>
												 
												<TR >
													<TD class="td_title" width="15%">展示图片</TD>
													<TD  colspan="3">
														 <div class="uploadpanal">
                                                            <div style="float: ; width: 100; height: 30px">
                                                                <input id="File1" type="file" /></div>
                                                            <div style="float: ; widows: 600px; height: 24px; padding: 7px 3px 0 0; vertical-align: middle;
                                                                color: #444444">
                                                                选择图片上传，一次可以多个图片，最大不能越过5M,拖动图片可以调整排序。</div>
                                                        </div>
                                                        <div>
                                                            <ul id="Ul1" class='multuploadsortclass'>
                                                            </ul>
                                                        </div>
                                                        <div id="Div1">
                                                        </div>
                                                    </TD>
												</TR>
												<TR  >
													<TD class="td_title" width="15%">描述</TD>
													<TD  colspan="3">
														   <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                    height: 200px; visibility: hidden;"></textarea>
                                                        </TD>
												</TR>
												<TR >
													<TD class="td_title" width="15%">标签</TD>
													<TD  colspan="3">
                                                        <asp:textbox id="txtTag" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                        &nbsp;</TD>
												</TR>
												<TR  >
													<TD class="td_title" width="15%">创建人：</TD>
													<TD  colspan="3">
                                                        <asp:textbox id="txtCreator" runat="server" 
                                                            Width="200px"></asp:textbox>
                                                        
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
