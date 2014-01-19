<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelList.aspx.cs" Inherits="dx177.WebUI.admin.HotelMgnt.HotelList" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>酒店管理</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="../css/cssCn1.css" type="text/css" rel="stylesheet">
    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">
    <script language=javascript>
        function SelectAll(strGridId) {
            var objCK = document.getElementsByTagName("input");
            var loop;
            var index = 0;
            var objArray = new Array();

            for (loop = 1; loop < objCK.length; loop++) {
                if (objCK[loop].type == "checkbox") {
                    if (objCK[loop].id.indexOf(strGridId) != -1) {
                        objArray[index] = objCK[loop];
                        index++;
                    }
                }
            }
            for (loop = 1; loop < objArray.length; loop++) {
                if (!objArray[loop].disabled) {
                    objArray[loop].click();
                    objArray[loop].checked = objArray[0].checked;
                }
            }
        }
        function CheckSelected(strGridId, isdel) {
            var taskIds;
            var check = false;
            var objCK = document.getElementsByTagName("input");
            var loop;
            var index = 0;
            var objArray = new Array();
            for (loop = 1; loop < objCK.length; loop++) {
                if (objCK[loop].type == "checkbox") {
                    if (objCK[loop].id.indexOf(strGridId) != -1) {
                        objArray[index] = objCK[loop];
                        index++;
                    }
                }
            }

            for (loop = 1; loop < objArray.length; loop++) {
                if (objArray[loop].checked) {

                    check = true;
                }
            }
            if (!check) {
                alert('请至少选择一个数据进行操作！');
                return false;
            }
            if (isdel == 1) {
                return confirm("确认要删除你所选择项吗？");
            }
        }
    
    </script>
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <div class="div_subtitle">
                    当前位置：酒店管理<span class="arrow_subtitle">&gt;</span>酒店列表</div>
            </td>
        </tr>
    </table>
    <table id="tb_content" cellspacing="0" cellpadding="0" align="center">
        <tbody>
            <tr>
                <td>
                    <table class="tb_searchbar" cellspacing="1" width="100%">
                        <tbody>
                            <tr>
                                <td class="td_head" colspan="4">
                                    &nbsp;请填写查询条件
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap width="9%">
                                    酒店类型
                                </td>
                                <td class="detail" width="24%">
                                    <span class="td_detail">
                                        <asp:DropDownList ID="drpHoteltype" runat="server" Width="142px">
                                        </asp:DropDownList>
                                    </span>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    酒店名
                                </td>
                                <td class="td_detail" width="23%">
                                    <asp:TextBox ID="txtName" runat="server" Width="267px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="td_title" nowrap width="9%">
                                    价格区间
                                </td>
                                <td class="detail" width="24%">
                                    <asp:TextBox ID="txtMinPrice" runat="server" Width="67px"></asp:TextBox>
                                    &nbsp;到<asp:TextBox ID="txtMaxPrice" runat="server" Width="69px"></asp:TextBox>
                                </td>
                                <td class="td_title" nowrap width="12%">
                                    发布时间
                                    <td class="td_detail" width="23%">
                                        <cc2:DateTextBox ID="dateBegin" runat="server"></cc2:DateTextBox>
                                        到<cc2:DateTextBox ID="dateEnd" runat="server"></cc2:DateTextBox>
                                    </td>
                            </tr>
                            <tr>
                            <td align="left" >
                            
                                    <asp:Button ID="bntCreatePage" runat="server" Text="生成页面" CssClass="button" 
                                    OnClick="bntCreatePage_Click">
                                    </asp:Button>
                            
                            </td>
                                <td align="right" colspan="3">
                                    <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="Button" OnClick="btnSearch_Click">
                                    </asp:Button><font face="宋体">&nbsp;</font>
                                    <asp:Button ID="btnAdd" runat="server" Text="新增" CssClass="Button" OnClick="btnAdd_Click">
                                    </asp:Button><font face="宋体">&nbsp;</font>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <cc1:ZteGrid ID="dgHotel" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgHotel_ItemDataBound" OnItemCommand="dgHotel_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="Seqno" HeaderText="Seqno"></asp:BoundColumn>
                              <asp:TemplateColumn>
                                <HeaderStyle Width="50px" />
                                <HeaderTemplate>
                                      <asp:CheckBox ID="cbxAll"   runat="server"  Text="全选"/>  
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkGrid" runat="server" />  
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            
                            <asp:TemplateColumn>
                                <HeaderStyle Width="150px" />
                                <HeaderTemplate>
                                    图标
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Image ID="imgLogo" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Logo") %>'
                                        Width="120px" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Name" HeaderText="酒店名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="HotelType" HeaderText="酒店类型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Area" HeaderText="所属区域"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="150px" />
                                <HeaderTemplate>
                                    价格区间
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%# DataBinder.Eval(Container.DataItem, "MinPrice")%>
                                    --<%# DataBinder.Eval(Container.DataItem, "MaxPrice")%>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Creator" HeaderText="创建人">
                                <HeaderStyle Width="100px" />
                            </asp:BoundColumn>
                            
                             <asp:TemplateColumn>
                                <HeaderStyle Width="150px" />
                                <HeaderTemplate>
                                     状态
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Status") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>       
                            
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <a href='RoomList.aspx?PGUID=<%# DataBinder.Eval(Container.DataItem, "GUID") %>'>房间管理
                                    </a>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="ViewComment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "GUID") %>'>查看评论</asp:LinkButton>
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Modify" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>修改</asp:LinkButton>
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
        </tbody>
    </table>
    </form>
</body>
</html>
