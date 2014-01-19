<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="home_hotel_2.ascx.cs"
    Inherits="dx177.WebUI.web.usercontrols.home_hotel_2" %>
<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
        <ul   class='new_list250_02'>
    </HeaderTemplate>
    <ItemTemplate>
        <li title='<%#DataBinder.Eval(Container.DataItem, "name") %>'>
            <div class="pic">
                <a href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html">
                    <img src="<%# DataBinder.Eval(Container.DataItem, "logo") %>" width="70" height="40" />
                </a>
            </div>
            <div class="desc">
                <h1>
                    <a href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html">
                        <%#DataBinder.Eval(Container.DataItem, "name") %></h1>
                </a> <span>价格：<%#DataBinder.Eval(Container.DataItem, "minprice") %> — <%#DataBinder.Eval(Container.DataItem, "maxprice") %>
                </span>
            </div>
        </li>
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>


