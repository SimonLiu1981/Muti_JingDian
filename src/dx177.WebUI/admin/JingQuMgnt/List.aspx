<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="dx177.WebUI.admin.JingQuMgnt.List" ValidateRequest="false" %>

<%@ Register TagPrefix="cc1" Namespace="COM.ZTE.TPG.App.UI.WebForm" Assembly="COM.ZTE.TPG.App.UI.WebForm" %>
<%@ Register Assembly="My97" Namespace="My97" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>景区设置</title>

    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/themes/default/default.css" />
    <link rel="stylesheet" href="/Plugin/kindeditor-4.1.1/plugins/code/prettify.css" />
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/kindeditor.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/lang/zh_CN.js"></script>
    <script charset="utf-8" src="/Plugin/kindeditor-4.1.1/plugins/code/prettify.js"></script>
    
    <script type="text/javascript" src="/js/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" src="/plugin/jquery.tools/jquery.tools.min.js"></script>

    <link rel="stylesheet" type="text/css" href="/plugin/fancybox/jquery.fancybox-1.3.4.css"
        media="screen" />

    <script type="text/javascript" src="/plugin/fancybox/jquery.fancybox-1.3.4.pack.js"></script>

    <link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />

    <script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

    <link href="../css/cssCn.css" type="text/css" rel="stylesheet">

    <script type="text/javascript">
        $(document).ready(function() {
            $("a[rel=showGrop]").fancybox({
                'transitionIn': 'none',
                'transitionOut': 'none',
                'titlePosition': 'over',
                'titleFormat': function(title, currentArray, currentIndex, currentOpts) {
                    return '<span id="fancybox-title-over">图像： ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';
                }
            });
        });
        function SelectAll(strGridId) {
            var objCK = document.getElementsByTagName("input");
            var loop;
            var index = 0;
            var objArray = new Array();

            for (loop = 1; loop < objCK.length; loop++) {
                if (objCK[loop].type == "checkbox") {
                    if (objCK[loop].id.indexOf(strGridId) != -1) {
                        objArray[index] = objCK[loop];
                        index++;
                    }
                }
            }
            for (loop = 1; loop < objArray.length; loop++) {
                if (!objArray[loop].disabled) {
                    objArray[loop].click();
                    objArray[loop].checked = objArray[0].checked;
                }
            }
        }
        function CheckSelected(strGridId, isdel) {
            var taskIds;
            var check = false;
            var objCK = document.getElementsByTagName("input");
            var loop;
            var index = 0;
            var objArray = new Array();
            for (loop = 1; loop < objCK.length; loop++) {
                if (objCK[loop].type == "checkbox") {
                    if (objCK[loop].id.indexOf(strGridId) != -1) {
                        objArray[index] = objCK[loop];
                        index++;
                    }
                }
            }

            for (loop = 1; loop < objArray.length; loop++) {
                if (objArray[loop].checked) {

                    check = true;
                }
            }
            if (!check) {
                alert('请至少选择一个数据进行操作！');
                return false;
            }
            if (isdel == 1) {
                return confirm("确认要删除你所选择项吗？");
            }
        }
        function ModifyImage(picSeqno) {
            var url = "/usercontrols/changeImageInfo.aspx?picSeqno=" + picSeqno + "&TB_iframe=true&height=300&width=420&modal=true";
            ShowPopup(url);
        }

        function UCGetPicsList() {
            $('#btnSearch').click();
        }

        function ValidationInput() {
            if ($('#txtJingQuCode').val() == '') {
                alert("请输入编码");
                $('#txtJingQuCode').focus();
                return false;
            }

            if ($('#txtJingQuName').val() == '') {
                alert("请输入景区名称");
                $('#txtJingQuName').focus();
                return false;
            }
            if ($('#txtMatchDomain').val() == '') {
                alert("请输入二级域名");
                $('#txtMatchDomain').focus();
                return false;
            }
        }

        var editor1 = null;
        KindEditor.ready(function(K) {
            editor1 = K.create('#fckContent', {
                cssPath: '/plugin/kindeditor-4.1.1/plugins/code/prettify.css',
                uploadJson: '/plugin/kindeditor-4.1.1/asp.net/upload_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                fileManagerJson: '/plugin/kindeditor-4.1.1/asp.net/file_manager_json.ashx?jingqucode=<%=dx177.Model.AppContext.CurrentMgtJingQuCode %>',
                allowFileManager: true,
                afterCreate: function() {
                    var self = this;
                    K.ctrl(document, 13, function() {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function() {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });


        $(document).ready(function() {
            var sortitem = new PictrueRequestSort("JingQu", $('#txt1Guid').val(), "Ul1", "/img/upload/", "File1", "Div1");
              
            MultiPicUploadifyInit(sortitem);
        });
    </script>

    <script src="/Plugin/MultiPicUploadify/multipicuploadfy.js" type="text/javascript"></script>

    <link href="/Plugin/MultiPicUploadify/multipicuploadfy.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .preview_img  img
        {
            border-bottom: #cccccc 2px solid;
            border-left: #cccccc 2px solid;
            width: 168px;
            height: 68px;
            border-top: #cccccc 2px solid;
            border-right: #cccccc 2px solid;
        }
      
    </style>
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
    <table id="tb_content" cellspacing="0" cellpadding="0" align="center">
        <tbody>
            <tr>
                <td>
                    <cc1:ZteGrid ID="dgNews" runat="server" Style="margin-top: 5px" CssClass="tb_datalist1"
                        PageChange="TextBox" Width="100%" AllowPaging="True" PageLanguage="Chinese" IsAllowPaging="True"
                        AutoGenerateColumns="False" CacheData="ServerCach" SortMode="Total" PageCSS="scrollButton"
                        BorderStyle="Solid" OnItemDataBound="dgNews_ItemDataBound" OnItemCommand="dgNews_ItemCommand">
                        <ItemStyle CssClass="tr_datarow" />
                        <AlternatingItemStyle CssClass="tr_alertrow"></AlternatingItemStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="JingQuID" HeaderText="JingQuID"></asp:BoundColumn>
                             <asp:TemplateColumn HeaderStyle-Width="130px">                                
                                <HeaderTemplate>
                                    景区图标
                                </HeaderTemplate>
                                <ItemTemplate>
                                   <a class="preview_img" href=#><asp:Image ID="imgLogo"   ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Logo") %>'
                                        Width="120px" runat="server" /></a> 
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="JingQuName" HeaderText="景区名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="JingQuCode" HeaderText="景区编码"></asp:BoundColumn>
                            <asp:BoundColumn DataField="MatchDomain" HeaderText="比配二级域名"></asp:BoundColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="80px" />
                                <HeaderTemplate>
                                    操作
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnModify" runat="server" CommandName="Modify" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JingQuID") %>'>修改</asp:LinkButton>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick='return confirm("是否删除景区？")'
                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JingQuID") %>'>删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <HeaderStyle CssClass="tr_title"></HeaderStyle>
                        <SelectedItemStyle CssClass="tr_selected"></SelectedItemStyle>
                        <PagerStyle CssClass="tr_pagenumber"></PagerStyle>
                    </cc1:ZteGrid>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="新增景区" CssClass="button" OnClick="btnAdd_Click"
                        Width="200px" />
                </td>
            </tr>
            <tr>
                <td runat="server" id='tdEdit' style="display:none">
                    <table cellspacing="0" width="100%" cellpadding="0">
                        <tr>
                            <td>
                                <table class="tb_input" id="queryPane" cellspacing="1" cellpadding="0" width="100%"
                                    align="center" bgcolor="#ffffff" border="0">
                                    <tbody>
                                        <tr>
                                            <td colspan="2">
                                                <img src="../Img/showtoc.gif">
                                                景区信息<asp:HiddenField ID="txtJingQuID" runat="server" />
                                            </td>
                                             <asp:HiddenField ID="txt1Guid" runat="server" />
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                景区编码
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtJingQuCode" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                景区名称
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtJingQuName" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                门票信息
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtPriceinfo" TextMode=MultiLine Rows=2 runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                          <tr>
                                            <td class="td_title" width="15%">
                                                天气情况
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtWeatherInfo" TextMode=MultiLine Rows=2 runat="server" Width="200px"></asp:TextBox>
                                                <a href ='http://service.weather.com.cn/plugin/forcast.shtml?id=pn12' target=_blank>获得代码</a>
                                            </td>
                                        </tr>
                                        
                                        <tr>
                                            <td class="td_title" width="15%">
                                                比配二级域名
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtMatchDomain" runat="server" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td_title" width="15%">
                                                省市
                                            </td>
                                            <td>
                                                <div>
                                                    省：
                                                    <select id="ddlProvince">
                                                    </select>
                                                    市：
                                                    <select id="ddlCity">
                                                    </select>
                                                    <asp:HiddenField ID="txtCommonAreaID" runat="server" />
                                                </div>

                                                <script type="text/javascript">

                                                    function InitProvince(selectId) {
                                                        $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                                                           { Pid: 0 },
                                                          function(json) {

                                                              if ($('#txtCommonAreaID').val() != '0') {
                                                                  $.post("/admin/ajaxHandler.aspx?MethodName=GetByAreadID&randID=" + escape(new Date()),
                                                                    { Areaid: $('#txtCommonAreaID').val() },
                                                                    function(json1) {
                                                                        if (json1.Depth == 1) {
                                                                            callbackSubmitComment($('#ddlProvince'), json, json1.Areaid);
                                                                            InitCity(json1.Areaid, "0");
                                                                        }
                                                                        if (json1.Depth == 2) {
                                                                            callbackSubmitComment($('#ddlProvince'), json, json1.Pareaid);
                                                                            InitCity(json1.Pareaid, json1.Areaid);
                                                                        }

                                                                    });
                                                              }
                                                              else {
                                                                  callbackSubmitComment($('#ddlProvince'), json, "0");
                                                              }


                                                          });
                                                    }
                                                    
                                                    function InitCity(Pid, selectId) 
                                                    {
                                                        $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                                                           { Pid: Pid },
                                                           function(json) {
                                                            callbackSubmitComment( $("#ddlCity"), json, selectId);
                                                          });
                                                    }
                                                    
                                                    $(document).ready(function() {
                                                        InitProvince(0);
                                                        $("#ddlProvince").change(
                                                            function() {
                                                                var s = $("#ddlProvince").val();
                                                                $("#ddlCity").get(0).selectedIndex = 0;
                                                                $("#ddlCity").empty();
                                                                if (s != 0) {
                                                                    $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                                                                       { Pid: s },
                                                                      function(json) {
                                                                          callbackSubmitComment($('#ddlCity'), json, "0");
                                                                      });
                                                                }
                                                            }
                                                        );
                                                        $("#ddlCity").change(
                                                            function() {
                                                                $('#txtCommonAreaID').val($(this).val());

                                                            });
                                                        $("#ddlProvince").change(
                                                        function() {
                                                            $('#txtCommonAreaID').val($(this).val());

                                                        });
                                                        $("#ddlCity").empty();
                                                        $("#ddlCity").append("<option value=''>请选择</option>");

                                                        

                                                    });

                                                    function callbackSubmitComment(dll, json, selectId) {
                                                        $(dll).empty();
                                                        $(dll).append("<option value=''>请选择</option>");
                                                        for (var i = 0; i < json.length; i++) {
                                                            $(dll).append("<option value='" + json[i].Areaid + "'>" + json[i].Areaname + "</option>");
                                                        }
                                                        $(dll).val(selectId);
                                                    }
                                                </script>
                                            </td>
                                        </tr>
                                        
                                        <tr>
                                            <td class="td_title" width="15%">
                                                相关图片
                                            </td>
                                            <td>
                                                 <div class="uploadpanal">
                                                    <div style="width: 100; height: 30px">
                                                        <input id="File1" type="file" /></div>
                                                    <div style="float: ; widows: 600px; height: 24px; padding: 7px 3px 0 0; vertical-align: middle;
                                                        color: #444444">
                                                        选择图片上传，一次可以多个图片，最大不能越过5M,拖动图片可以调整排序。</div>
                                                </div>
                                                <div>
                                                    <ul id="Ul1" class='multuploadsortclass'>
                                                    </ul>
                                                </div>
                                                <div id="Div1">
                                                </div>
                                            </td>
                                        </tr>
                                       <tr>
                                            <td class="td_title" width="15%">
                                                子景点</td>
                                            <td>
                                                 
                                                <asp:CheckBoxList ID="chkChildJingQu" runat="server" 
                                                    RepeatDirection="Horizontal">
                                                </asp:CheckBoxList>
                                                
                                                
                                                </td>
                                        </tr>
                                        
                                         
                                        
                                       <tr>
                                            <td class="td_title" width="15%">
                                                导航
                                            </td>
                                            <td>
                                                 
                                                <textarea id="txtNavigation" runat="server" cols="100" rows="8" style="width: 700px;
                                                height: 200px;"></textarea>
                                            </td>
                                        </tr>
                                        
                                         
                                        
                                        <tr>
                                            <td class="td_title" width="15%">
                                                启用自定义导航
                                            </td>
                                            <td>
                                                <asp:CheckBox ID="chbNavigationSwitch" runat="server" />                                                
                                            </td>
                                        </tr>
                                        
                                        <tr>
                                            <td class="td_title" width="15%">
                                                描述
                                            </td>
                                            <td>                                                
                                                <textarea id="fckContent" runat="server" cols="100" rows="8" style="width: 700px;
                                                height: 200px; visibility: hidden;"></textarea>
                                                
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="td_title" width="15%">
                                                优先顺序
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtShowIdx" runat="server" Width="50px" Text=0></asp:TextBox>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table width="100%">
                        <tr>
                            <td align="right" width="100%">
                                <asp:Button ID="btnSave" OnClientClick="return ValidationInput();" runat="server"
                                    CssClass="button" Text="保存" OnClick="btnSave_Click"></asp:Button>
                                <asp:Button ID="btnReturn" runat="server" CssClass="button" Text="返回" OnClick="btnReturn_Click">
                                </asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
