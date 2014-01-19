<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true"
    CodeBehind="member-hirecarlist.aspx.cs" Inherits="dx177.WebUI.web.admin.member_publish_hirecarlist" %>

<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/web/admin/css/style1.css" type="text/css" />

    <script type="text/javascript">
        
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_hirecarlist" runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <div class="MemberMain">
                <form runat="server" id='form1'>
                <div>     
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
                                <th>
                                    Logo
                                </th>
                                <th>
                                    标题
                                </th> 
                                <th>
                                    审核状态
                                </th>
                                <th>
                                    联系电话
                                </th>
                                <th>
                                    操作
                                </th>                       
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvHireCarList" runat="server" OnPagePropertiesChanging="lvHireCarList_PagePropertiesChanging">
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
                                            <%#DataBinder.Eval(Container.DataItem,"Title")%>
                                        </td>
                                        <td>
                                           <%#GetStatusString(DataBinder.Eval(Container.DataItem,"status").ToString())%>
                                        </td>
                                        <td>
                                           <%#DataBinder.Eval(Container.DataItem,"telnumber")%>
                                        </td>
                                        <td>
                                            <a href="member-hirecar.aspx?seqno=<%#DataBinder.Eval(Container.DataItem,"seqno")%>">修改</a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>                            
                        </tbody>
                    </table>
                    <link href="/web/css/pager.css" rel="stylesheet" type="text/css" />
                    <div style="float: right; margin-top: 5px;" class="page_link_full">
                        <asp:DataPager ID="DataPager1" PagedControlID="lvHireCarList" runat="server" PageSize="4"
                            OnPreRender="DataPager1_PreRender" QueryStringField="p">
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
