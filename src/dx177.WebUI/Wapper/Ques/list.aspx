<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Home.Master"  CodeBehind="list.aspx.cs" Inherits="dx177.WebUI.Wapper.Ques.list"%>



 <%@ Register src="../../Control/TJHotel.ascx" tagname="TJHotel" tagprefix="uc1" %>
<%@ Register src="../../Control/lyCar.ascx" tagname="lyCar" tagprefix="uc2" %>

      


 
 
<%@ Register src="../../Control/QuesControl.ascx" tagname="QuesControl" tagprefix="uc4" %>
 
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

        
         <form id="form1" runat="server">
     <div id="nav_son">
            <span> <a href="/web/hotelorder/orderlist.aspx" class="cxdd">查询我的订单状态</a></span>当前位置：<a href="/index.html">首页</a>
            
            &gt;&nbsp;丹霞山酒店预订
     </div>
            
            
            
            
          <div id="mainContent">
    <div id="main">
     
          
     
      
     
   
         
     
     
   
        <uc4:QuesControl ID="QuesControl3" runat="server" />
   
        
     
   
         
     
     
   
      <div class="info_box">
        <h2>出行资讯</h2>
        <div class="zx_list">
         
            
 



 <asp:Repeater ID="RptData" runat="server">
 <HeaderTemplate>
  <ul>
 
 </HeaderTemplate>
 <ItemTemplate>
 <li><span><%# DataBinder.Eval(Container.DataItem, "create_date")%> </span>

<a href="list.aspx?JqCode=<%# DataBinder.Eval(Container.DataItem, "jingqucode")%>&qtype=<%# DataBinder.Eval(Container.DataItem, "qtype")%>">
     [<%# DataBinder.Eval(Container.DataItem, "SORTNAME")%> ]</a>&nbsp;<a href="/html/<%#DataBinder.Eval(Container.DataItem, "matchdomain")%>/question_<%#DataBinder.Eval(Container.DataItem, "seqno")%>.html"><%# DataBinder.Eval(Container.DataItem, "title")%> </a>

</li>
 
 </ItemTemplate>
 <FooterTemplate>
   </ul>
 </FooterTemplate>
        </asp:Repeater>

        

        </div>
          <div id="pages">
            <%=strpage%>
            </div>
      </div>
    </div>
    <div id="side">
       


    
      


        
        <uc1:TJHotel ID="TJHotel2" runat="server" />
        <uc2:lyCar ID="lyCar2" runat="server" />

    
      


    </div>
    <div class="clearfloat"></div>
  </div>
        

     </form>
        

</asp:Content>
