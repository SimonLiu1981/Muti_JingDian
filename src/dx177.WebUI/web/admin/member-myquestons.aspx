<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="member-myquestons.aspx.cs" Inherits="dx177.WebUI.web.admin.member_myquestons" %>
<%@ Register Src="UCLeftMenu.ascx" TagName="UCLeftMenu" TagPrefix="uc1" %>
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
    <div id="MainWrap_Car" style="background: #fff;">
        <div class="MemberCenter">
            <div class="siteparttitle">
                <div class="title">
                </div>
                <div class="main">
                    <div class="content_c1">
                        <div class="user">
                            欢迎您：<br />
                           <strong><%=dx177.Model.AppContext.CurrentResuser.Username %></strong></div>
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
                        <uc1:UCLeftMenu ID="UCLeftMenu1" CurrentMenuID="menu_13" runat="server" />
                    </div>
                    <div class="foot">
                    </div>
                </div>
            </div>
            <form id='form1' runat=server >
            <div class="MemberMain">
                <div> 
                    <div style=" margin-bottom:2px;" >
                          <asp:Button ID="btnSave" CssClass='sumitBlue1' runat="server" Text="新建问题" 
                              onclick="btnSave_Click"  />                           
                    </div>
                    <table width="100%" cellpadding="3" cellspacing="0" class="liststyle">
                        <colgroup>
                            <col class="span-auto" />
                            <col class="span-3 ColColorGray" />
                            <col class="span-3" />                            
                            <col class="span-3 ColColorOrange" />
                            <col class="span-3" />
                        </colgroup>
                        <thead>
                            <tr>
                                <th>
                                    标题
                                </th>
                                <th>
                                    类型
                                </th>
                                <th>
                                    状态
                                </th>
                                <th>
                                    创建日期
                                </th>
                                <th>
                                    操作
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                             <asp:ListView ID="lvQestions" runat="server" OnPagePropertiesChanging="lvQestions_PagePropertiesChanging">
                                <LayoutTemplate>
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td class="textleft">
                                            <%#DataBinder.Eval(Container.DataItem,"Title")%>
                                        </td>
                                        <td>
                                            <%# dx177.Business.DictBus.Dict.Tag["QuestionType", DataBinder.Eval(Container.DataItem, "Qtype").ToString(), 2052]%>
                                        </td>
                                        <td>
                                            
                                            <%# dx177.Business.DictBus.Dict.Tag["QuestionStatus", DataBinder.Eval(Container.DataItem, "Status").ToString(), 2052]%>
                                            
                                        </td>
                                        <td class="textright">
                                            <%#DateTime.Parse(DataBinder.Eval(Container.DataItem,"Createdate").ToString()).ToString("yyyy-MM-dd") %>
                                        </td>
                                        <td>
                                            <a href="/member-editqueston.aspx?seqno=<%#DataBinder.Eval(Container.DataItem,"Seqno")%>">查看问题</a>                                            
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                    </table>
                    
                    <div style="float: right; margin-top:5px;" class="page_link_full">
                        <asp:DataPager ID="DataPager1" PagedControlID="lvQestions" runat="server" PageSize="10"
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
            </div>
            
            </form>
            <div class="clear">
            </div>
        </div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
