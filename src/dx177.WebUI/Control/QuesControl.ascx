<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuesControl.ascx.cs" Inherits="dx177.WebUI.Control.QuesControl" %>
<div class="list_top">
        <h2>
          <span>免费预订 酒店前台付款</span>
          <strong>问答类型</strong>
        </h2>
        <div class="zx_city_list">
          <ul>
           <asp:Repeater ID="rpt" runat="server">
             <ItemTemplate>
             <li>
                <a href="/Wapper/Ques/list.aspx?JqCode=<%=this.jingqucode %>&qtype=<%# DataBinder.Eval(Container.DataItem, "guid")%>" title="<%# DataBinder.Eval(Container.DataItem, "title")%>">[<%# DataBinder.Eval(Container.DataItem, "title")%>]</a>
             </li>
             </ItemTemplate>
            </asp:Repeater>
          </ul>
            
        </div>
      </div>