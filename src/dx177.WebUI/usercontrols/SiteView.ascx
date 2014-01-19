<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteView.ascx.cs" Inherits="dx177.WebUI.usercontrols.SiteView" %>
   <div class="info_box">
        <h2>景点欣赏</h2>
        <div class="info_pic">
          <ul>
            
       
       
        <asp:Repeater ID="rpt" runat="server">
        <ItemTemplate>
        
         <li>
          <a href="<%# DataBinder.Eval(Container.DataItem, "JQCOD_PATH")%>sites_<%# DataBinder.Eval(Container.DataItem, "seqno")%>.html">
            <img border="0" src="<%# DataBinder.Eval(Container.DataItem, "logo")%>" alt="<%# DataBinder.Eval(Container.DataItem, "title")%>" width="160" height="120" /><%# DataBinder.Eval(Container.DataItem, "title")%>
          </a>
        </li>
        </ItemTemplate>
        </asp:Repeater>
          </ul>
        </div>
      </div>
        
