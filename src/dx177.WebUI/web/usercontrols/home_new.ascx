<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="home_new.ascx.cs" Inherits="dx177.WebUI.web.usercontrols.home_new" %>

<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
       <ul class='new_list250_01'>
    </HeaderTemplate>
    <ItemTemplate>         
         <li title='<%#DataBinder.Eval(Container.DataItem, "title") %>'><a href="/news_<%#DataBinder.Eval(Container.DataItem, "seqno") %>.html"><%#DataBinder.Eval(Container.DataItem, "title") %></a></li>        
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater> 