<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="home_hotel_1.ascx.cs"
    EnableViewState="false" Inherits="dx177.WebUI.web.usercontrols.home_hotel_1" %> 
 
<asp:Repeater ID="Repeater1" runat="server">      
    <HeaderTemplate>
        <ul class="index_jd">
    </HeaderTemplate>  
    <ItemTemplate>
        <li class="pichotel" title='<%#DataBinder.Eval(Container.DataItem, "name") %>'><a href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html">
            <img align="left" src="<%# DataBinder.Eval(Container.DataItem, "logo") %>"
                width="100" height="75">
        </a><a class="gray_blod" href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html"><%#dx177.FrameWork.StringUtil.CutString(DataBinder.Eval(Container.DataItem, "name").ToString(),14) %></a>
            <br>
            <span>人气：<b><%# DataBinder.Eval(Container.DataItem, "viewtimes") %></b><br>
                最低<b><%# DataBinder.Eval(Container.DataItem, "minprice")%></b>元起<br>
                <a class="hotel_search" href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html">查看详情</a></span></li>
    </ItemTemplate>
    <FooterTemplate>
         </ul>
    </FooterTemplate>
</asp:Repeater> 
<asp:Repeater ID="Repeater2" runat="server">      
    <HeaderTemplate>
  <ul class="index_jdwzlist">
    </HeaderTemplate>  
    <ItemTemplate>
            <li><p><b><%# DataBinder.Eval(Container.DataItem, "minprice")%></b></b>元起</p>
            <a href="/hotel_<%# DataBinder.Eval(Container.DataItem, "seqno") %>.html"><%#DataBinder.Eval(Container.DataItem, "name") %></a></li>
    </ItemTemplate>
    <FooterTemplate>
         </ul>
    </FooterTemplate>
</asp:Repeater> 


   