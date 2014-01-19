<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsSort.ascx.cs" Inherits="dx177.WebUI.Control.NewsSort" %>
 
<div class="list_top">
    <h2>
        <strong>资讯分类</strong>
    </h2>
    <div class="zx_city_list">
        <ul>
            
            <asp:Repeater ID="rpt" runat="server">
                <ItemTemplate>                    
                    <li><a href="<%# dx177.FrameWork.UrlUtility.GenerateURL(this.Page, new string[]{ "typeCode=" + DataBinder.Eval(Container.DataItem, "Code").ToString() }) %>"
                        title="<%# DataBinder.Eval(Container.DataItem, "title")%>">[<%# DataBinder.Eval(Container.DataItem, "title")%>]</a>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>
