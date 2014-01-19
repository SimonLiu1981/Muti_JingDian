<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLeftMenu.ascx.cs"
    Inherits="dx177.WebUI.web.admin.UCLeftMenu" %>
<ul style="min-height: 300px">
    <asp:Repeater ID="NavMenu_List" runat="server" OnItemDataBound="NavMenu_List_ItemDataBound">
        <ItemTemplate>
            <li><span style="font-size: 14px;">
                <%# ((System.Data.DataRowView)Container.DataItem)["Text"]%></span>
                <ul>
                    <asp:Repeater ID="MenuItem_List" runat="server">
                        <ItemTemplate>
                            <li id='<%# ((System.Data.DataRowView)Container.DataItem)["ID"]%>'><a href="<%# ((System.Data.DataRowView)Container.DataItem)["NavigateUrl"]%>">
                                <%# ((System.Data.DataRowView)Container.DataItem)["Text"]%></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>

<script type="text/javascript">
    $(document).ready(function() {
        if ('<%=this.CurrentMenuID %>' != '') {
            $('#user_nav_menu li').each(function() {
                $(this).removeClass('current');
            });
            $('#<%=this.CurrentMenuID %>').addClass('current');
        }
    });
</script>

