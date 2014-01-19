<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="member-roomlist.aspx.cs" Inherits="dx177.WebUI.web.admin.member_roomlist" Title="无标题页" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />

    <script type="text/javascript">
        function AddNewRoom() {
            document.location.href = '/member-room.aspx?hotelGuid=<%=Request.QueryString["hotelGuid"] %>';
            return false;
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <div id="MainWrap_Car" style="background: #fff;">
        <div class="MemberCenter">
            <div class="siteparttitle">
                <div class="title">
                </div>
                <div class="main">
                    <div class="content_c1">
                        <div class="user">
                            欢迎您：<br />
                            <strong>
                                <%=dx177.Model.AppContext.CurrentResuser.Username %></strong></div>
                        <div class="info">
                            您目前是<strong>[普通会员]，</strong>您的积分为:<strong class="point">0</strong></div>
                    </div>
                </div>
            </div>
            <div class="MemberSidebar">
                <div class="MemberMenu">
                    <div class="title">
                    </div>
                    <div class="body">
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_hotel" runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <div class="MemberMain">
                <form runat="server" id='form1'>
                <div>     
                    <asp:Button ID="btnAddRoom" runat="server" OnClientClick="return AddNewRoom()" Text="加入新房间" />
                    <table width="100%" cellpadding="3" cellspacing="0" class="liststyle">
                        <colgroup>
                            <col class="span-2" />
                            <col class="span-auto" />                            
                            <col class="span-3 ColColorOrange" />                            
                            <col class="span-2" />
                            <col class="span-4" />
                        </colgroup>
                        <thead>
                            <tr>
                                <th>Logo</th>
                                <th>房型</th> 
                                <th>平时价</th>
                                <th>节假日价格</th>
                                <th>操作</th>                       
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvRoomList" runat="server"  
                                OnPagePropertiesChanging="lvRoomList_PagePropertiesChanging" 
                                onitemcommand="lvRoomList_ItemCommand" >
                                <LayoutTemplate>
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                         <img src ='<%#DataBinder.Eval(Container.DataItem,"logo")%>' width="80" height=80 alt="" />
                                        </td>
                                        <td>
                                            <%#DataBinder.Eval(Container.DataItem, "RoomTitle")%>
                                        </td>
                                        <td>
                                           <%#DataBinder.Eval(Container.DataItem, "Price1")%>
                                        </td>
                                        <td>
                                           <%#DataBinder.Eval(Container.DataItem, "Price2")%>
                                        </td>
                                        <td>
                                            <a href="member-room.aspx?hotelGuid=<%#Request.QueryString["hotelGuid"] %>&seqno=<%#DataBinder.Eval(Container.DataItem,"seqno")%>">修改</a>
                                            <asp:LinkButton ID="btnDelete" runat="server" OnClientClick="return confirm('你确认要删除该房间吗？');" CommandName="Remove" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Seqno") %>'>删除</asp:LinkButton>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>                            
                        </tbody>
                    </table>
                    <div style="float: right; margin-top: 5px;" class="page_link_full">
                        <asp:DataPager ID="DataPager1" PagedControlID="lvRoomList" runat="server" PageSize="10"    OnPreRender="DataPager1_PreRender" 
                             QueryStringField="p">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" FirstPageText="第一页" LastPageText="尾页"
                                    NextPageText="下一页" PreviousPageText="上一页" ShowFirstPageButton="True" ShowNextPageButton="False"
                                    ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                <asp:NumericPagerField NextPageText="..." PreviousPageText="..." ButtonCount="5"
                                    CurrentPageLabelCssClass='this-page'></asp:NumericPagerField>
                                <asp:NextPreviousPagerField ButtonType="Button" FirstPageText="第一页" LastPageText="尾页"
                                    NextPageText="下一页" PreviousPageText="上一页" ShowLastPageButton="True" ShowNextPageButton="False"
                                    ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>
                    </div>                    
                </div>
                </form>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
</asp:Content>

