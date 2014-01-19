<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="right_hireCar.ascx.cs" Inherits="dx177.WebUI.web.usercontrols.right_hireCar" %>
<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
      <ul class='new_list250_02'>
    </HeaderTemplate>
    <ItemTemplate>
            <li title='<%#DataBinder.Eval(Container.DataItem, "title") %>'>
                <div class="pic">
                    <a href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html">
                        <img src="<%# DataBinder.Eval(Container.DataItem, "logo") %>" width="70" height="40" />
                    </a>
                </div>
                <div class="desc">
                    <h1>
                        <a href="/hirecar_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html">
                            <%#DataBinder.Eval(Container.DataItem, "title")%></h1>
                    </a> <span>电话：<%#DataBinder.Eval(Container.DataItem, "TelNumber")%>
                    </span>
                </div>
            </li>
    </ItemTemplate>
    <FooterTemplate>
      </ul>
    </FooterTemplate>
</asp:Repeater>


