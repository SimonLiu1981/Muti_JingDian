<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="lyCar.ascx.cs" Inherits="dx177.WebUI.Control.lyCar" %>
<div class="sidebox">
    <h4>
        <span><a href="#">更多</a> </span>旅游租车
    </h4>
    <div class="sbox_con">
    <ul>
        <asp:Repeater ID="rpt" runat="server">
            <ItemTemplate>
                <li><a href='/html/<%# DataBinder.Eval(Container.DataItem, "JQCOD_PATH")%>HireCar_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.html'>
                    <%# DataBinder.Eval(Container.DataItem, "title")%>
                </a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    </div>
</div>
