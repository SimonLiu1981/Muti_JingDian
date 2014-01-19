<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteLeft.ascx.cs" Inherits="dx177.WebUI.Control.SiteLeft" %>
<div class="sidebox">
    <h4>
        景点欣赏</h4>
    <div class="sbox_con">
        <ul>
            <asp:Repeater ID="rpt" runat="server">
                <ItemTemplate>
                    <li><a href="/JQ_<%# DataBinder.Eval(Container.DataItem, "JQCOD_PATH").ToString().Trim('/')%>/sites/<%# DataBinder.Eval(Container.DataItem, "seqno")%>">
                        <%# DataBinder.Eval(Container.DataItem, "title")%>
                    </a></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>
