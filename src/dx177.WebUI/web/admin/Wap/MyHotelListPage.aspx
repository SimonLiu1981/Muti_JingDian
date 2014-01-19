<%@ Page Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true" CodeBehind="MyHotelListPage.aspx.cs" Inherits="dx177.WebUI.web.admin.Wap.MyHotelListPage" Title="无标题页" %>
<%@ Register src="../UCLeftMenu.ascx" tagname="UCLeftMenu" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

 <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />
    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="/Plugin/fancybox/jquery.fancybox-1.3.4.pack.js"></script>

    <link rel="stylesheet" type="text/css" href="/Plugin/fancybox/jquery.fancybox-1.3.4.css"
        media="screen" />

    <script type="text/javascript">
        $(document).ready(function() {
            $("a.openorder").fancybox();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <form runat="server" id='form1'>
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
                     <uc1:UCLeftMenu ID="UCLeftMenu1"  CurrentMenuID="MyHoteList"   runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <div class="MemberMain">
                <div>  
                
                <div style="float: right; margin-top: 5px;" class="page_link_full">
                <table  style="height:120">
                <tr>
                <td>
                 <asp:Button ID="bntDelete" runat="server" Text="删除" onclick="bntDelete_Click" />
                     <br>
                </td>
                
                
                <td>
                 &nbsp;<asp:Button ID="bntSave" runat="server" Text="保存" 
                        onclick="bntSave_Click" />
                     
                </td>
                
                </tr>
                <tr>
                <td colspan=2>
                 &nbsp;
                </td>
                </tr>
                
                </table>
                 
                </div>   
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
                            <th>   <asp:CheckBox ID="chk" runat="server" AutoPostBack="True" 
                                    oncheckedchanged="chk_CheckedChanged" /></th>
                            <th>酒店名</th>
                                <th>我的酒店</th>
                                 
                                <th>最高价格</th>
                                <th>最低价格</th>
                                <th>顺序</th>                       
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvHotelList" runat="server" 
                                OnPagePropertiesChanging="lvHotelList_PagePropertiesChanging" >
                                <LayoutTemplate>
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                    <td>
                                        <asp:CheckBox ID="chk" runat="server" />
                                      </td>
                                        <td>
                                        <asp:Label ID="lbSeqno" runat="server" Visible=false  Text='<%#DataBinder.Eval(Container.DataItem, "seqno")%>'></asp:Label>
                                        <asp:Label ID="lbguid" runat="server" Visible=false  Text='<%#DataBinder.Eval(Container.DataItem, "guid")%>'></asp:Label>
                                          <%#DataBinder.Eval(Container.DataItem, "name")%>
                                        </td>
                                        <td >
                                         <%#DataBinder.Eval(Container.DataItem, "IsMyHotel")%>
                                        </td>
                                        
                                        <td>
                                           <%#DataBinder.Eval(Container.DataItem, "maxprice")%>
                                        </td>
                                        <td>
                                           <%#DataBinder.Eval(Container.DataItem, "minprice")%>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtShowIndex" Width=60 runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "showindex")%>'></asp:TextBox>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>                            
                        </tbody>
                    </table>
                    <div style="float: right; margin-top: 5px;" class="page_link_full">
                        <asp:DataPager ID="DataPager1" PagedControlID="lvHotelList" runat="server" 
                            PageSize="10"    OnPreRender="DataPager1_PreRender" 
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
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
    
                </form>
                
</asp:Content>
