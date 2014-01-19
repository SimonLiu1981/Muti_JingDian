<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderlist.aspx.cs" Inherits="dx177.WebUI.web.hotelorder.orderlist" %>
 <%=top %>
    <form id="form1" runat="server">
    <div id="nav_son"><span><a href="/order.asp" class="cxdd">查询我的订单状态</a></span>免费预订，酒店前台付款，保证价格比酒店前台价格低，预订成功即给您保留房间！</div>
      
  <div id="mainContent">
   <div class="big_box">
                <h1>
                    查询我的订单状态</h1>
                
                <table width="100%" border="0" cellspacing="1" cellpadding="4" bgcolor="#CCCCCC">
          <tr>
            <th style="width:80px;" bgcolor="#FFFFFF">姓名</th>
            <td bgcolor="#FFFFFF" >  
                            &nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </td>
            <th style="width:80px;" bgcolor="#FFFFFF"> 手机号</th>
            <td bgcolor="#FFFFFF" >  
                  &nbsp;<asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                        </td>
             
          </tr>
     <tr>
        
            <td bgcolor="#FFFFFF"  colspan=4 >  
                        <asp:Button ID="bntsearch" runat="server" Text="查 询" 
                            onclick="bntsearch_Click" />
            </td>
             
          </tr>
    
           
        </table>
             
                 
            </div>
            <div class="clearfloat">
            </div>
            
            
            
  	<div class="big_box">
  	  <h1>查询我的订单  </h1>
      <div id="search_order" style="padding:30px 60px 50px 60px;">
     <table width="100%" border="0" cellspacing="1" cellpadding="4" bgcolor="#CCCCCC">
          <tr>
            <th bgcolor="#FFFFFF">酒店名称</th>
            <th width="80" bgcolor="#FFFFFF">房型</th>
            <th width="80" bgcolor="#FFFFFF">入住人</th>
            <th width="220" align="center" bgcolor="#FFFFFF">入住时间</th>
            <th width="50" align="center" bgcolor="#FFFFFF">价格</th>
            <th width="80" align="center" bgcolor="#FFFFFF">备注</th>
          </tr>
          
                <asp:Repeater ID="Repeater1" runat="server">
     
    <ItemTemplate>
    
             <tr>
            <td height="34"  align="center" bgcolor="#FFFFFF"> <%#DataBinder.Eval(Container.DataItem, "HotelName") %></td>
            <td height="34"  align="center" bgcolor="#FFFFFF"> <%#DataBinder.Eval(Container.DataItem, "RoomTitle") %></td>
            <td height="34"  align="center" bgcolor="#FFFFFF"><%#DataBinder.Eval(Container.DataItem, "PCount") %></td>
            <td height="34"  align="center" bgcolor="#FFFFFF"> <%#DataBinder.Eval(Container.DataItem, "ReachDate") %></td>
            <td height="34"  align="center" bgcolor="#FFFFFF"><%#DataBinder.Eval(Container.DataItem, "Price") %> </td>
            <td height="34"  align="center" bgcolor="#FFFFFF"> <%#DataBinder.Eval(Container.DataItem, "Content") %> </td>
          </tr>
        
    </ItemTemplate>
 </asp:Repeater> 


    
          <tr>
            <td height="34" colspan="6" align="center" bgcolor="#FFFFFF">您提供的信息不正确，无法查询.</td>
          </tr>
        </table>
        
        
         
          
      
      </div>
  	</div>
  	<div class="clearfloat"></div>
  </div>

    </form>
 <%=footer %>