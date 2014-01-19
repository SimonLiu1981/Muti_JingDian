<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="home_questions.ascx.cs" Inherits="dx177.WebUI.web.usercontrols.home_questions" %>
<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
       <ul class='new_list250_03'>
    </HeaderTemplate>
    <ItemTemplate>
         <li title='<%#DataBinder.Eval(Container.DataItem, "title") %>'>
            <a href="/question_<%#DataBinder.Eval(Container.DataItem, "seqno") %>.html"><%#DataBinder.Eval(Container.DataItem, "title") %></a><div class="s<%#DataBinder.Eval(Container.DataItem, "status") %>"></div>
        </li>            
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>


