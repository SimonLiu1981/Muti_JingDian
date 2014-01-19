<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TJHotel.ascx.cs" Inherits="dx177.WebUI.Control.TJHotel" %>
<div class="sidebox">
    <h4>
        推荐酒店</h4>
    <div class="sbox_con">
        <ul>
            <asp:Repeater ID="rpt" runat="server">
                <ItemTemplate>
                    <li title='<%# DataBinder.Eval(Container.DataItem, "Name")%>'><span>
                        <%# DataBinder.Eval(Container.DataItem, "minprice")%>元</span> <a href='/JQ_<%# DataBinder.Eval(Container.DataItem, "JQCOD_PATH").ToString().Trim('/')%>/hotel/<%# DataBinder.Eval(Container.DataItem, "seqno")%>'>
                            <%# DataBinder.Eval(Container.DataItem, "Name")%></a> </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>
