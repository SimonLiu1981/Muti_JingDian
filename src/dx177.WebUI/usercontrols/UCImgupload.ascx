<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCImgupload.ascx.cs"
    Inherits="dx177.WebUI.usercontrols.UCImgupload" %>
<link rel="stylesheet" type="text/css" href="/web/js/fancybox/jquery.fancybox-1.3.4.css" media="screen" />
<script src="/Plugin/fancybox/jquery.fancybox-1.3.4.pack.js" type="text/javascript"></script>
<link href="/Plugin/JqueryUploadify/uploadify.css" rel="stylesheet" type="text/css" />
<link href="/Plugin/thickbox/thickbox.css" rel="stylesheet" type="text/css" />
<script src="/Plugin/thickbox/thickbox.js" type="text/javascript"></script>

<style type="text/css">
     
    #uploadimg-list-ul
    {
        padding: 0;
         
        float:left;
        list-style: none;
        margin: 10px auto;
    }
    #uploadimg-list-ul li
    {
        width: 118px;
        height: 150px;
        padding-left: 10px;
        float:left;        
    }
    #uploadimg-list-ul li .ImgShow
    {
        width: 106px;
        height: 106px;
        float: left;
        position: relative;
        margin: 10px auto;
    }
    #uploadimg-list-ul li .ImgShow .Show
    {
        width: 100px;
        height: 100px;
        border: 1px #ccc solid;
        padding: 2px;
        vertical-align: middle;        
        text-align: center;
    }
    #uploadimg-list-ul li .ImgShow .Delete
    {
        position: absolute;
        top: -10px;
        cursor: pointer;
        right: -10px;
        height: 16px;
        width: 16px;
        display: none;
    }
    #uploadimg-list-ul li .ImgShow .Modify
    {
        position: absolute;
        bottom: 2px;
        cursor: pointer;
        left: 10px;
        display: none;
    }
    #uploadimg-list-ul li .ImgShow .ShowIdx
    {
        top: 30px;
        left: 30px;
        color: red;
        background-color: #FFF;
        height: 19px;
        font-size: 18px;
        position: absolute;
    }
    #uploadimg-list-ul li .TitleShow
    {
        width: 106px;
        text-align: center;
        color: #333;
        font-size:12px;
        float: left;
        margin: 0px auto;
        overflow: hidden;
        text-overflow: ellipsis;
        white-space: nowrap;
    }
 
</style>

<script type="text/javascript">

    $(document).ready(function() {

        StartUploadify();
        UCGetPicsList();
    });
    function OverDiv(dv) {
        $(dv).children('.ImgShow').children('.Delete').show();
        $(dv).children('.ImgShow').children('.Modify').show();

    }

    function OutDiv(dv) {
        $(dv).children('.ImgShow').children('.Delete').hide();
        $(dv).children('.ImgShow').children('.Modify').hide();
    }


    var iMaxUpdateFileSize = 1024 * 1024; //1M
    function StartUploadify() {
        $("#<%=this.FileUpload1.ClientID %>").uploadify({
            'uploader': '/Plugin/JqueryUploadify/uploadify2.swf',
            'cancelImg': '/Plugin/JqueryUploadify/images/cancel.png',
            'buttonText': 'Select Files',
            'buttonImg': '/Plugin/JqueryUploadify/images/SelectUp.png',
            'width': 87,
            'height': 30,
            'script': '/RemoteHandlers/JqueryUploadify/Uploadimg.ashx',
            'scriptData': { 'pguid': '<%=PGuid %>', 'seqno': '<%=Seqno%>' }, 
            'folder': 'uploads',
            'fileDesc': 'Files',
            'fileExt': '*.jpg;*.jpeg;*.gif;*.png;',
            'sizeLimit': iMaxUpdateFileSize,
            'simUploadLimit': 5,
            'multi': true,
            'auto': true,
            'onSelect': function(a, b, c) { /*选择文件上传时可以禁用某些按钮*/ },
            'onComplete': function(a, b, c, d, e) { SetLi_UpdateFiles(c, d); },
            'onAllComplete': function(a, b) {
                UCGetPicsList();
            },
            'onCancel': function(a, b, c, d, e) { },
            'onError': function(a, b, c, d, e) {
                if (c.size > iMaxUpdateFileSize) {
                    setTimeout("$('#<%=this.FileUpload1.ClientID %>').uploadifyCancel('" + b + "')", 2000);
                }
            }
        });
    }

    function strToJson(str) {
        return (new Function("return " + str))();
    }

    function UCGetPicsList() {
        dx177.WebUI.usercontrols.UCImgupload.AjaxGetPicsByGuid('<%=PGuid %>', UCGetPicsList_CallBack);
    }

    function UCGetPicsList_CallBack(res) {
        UCInitPics(strToJson(res.value));
    }

    function UCInitPics(lists) {
        var repalceHtml = '';
        for (var ii = 0; ii < lists.length; ii++) {
            var itemHtml = "<li onmouseover='OverDiv(this)' id='li_" + lists[ii].Seqno + "' onmouseout='OutDiv(this)'>" +
                    "<div class='ImgShow'>" +
                        "<a href='" + lists[ii].Bigimgfile + "' title='" + lists[ii].Title + "' rel='showGroupUc'><img class=\"Show\" src=\"" + lists[ii].Smallimgfile + "\"" +
                            " alt=\"" + lists[ii].Title + "\" /> </a>" +
                        "<div class=\"ShowIdx\" title='显示顺序'>" + lists[ii].Showidx + "</div>" +
                        "<div class=\"Delete\">" +
                            "<img src='/Plugin/JqueryUploadify/images/cancel.png' onclick='return DeleteLiImage(this);'" +
                                "title='删除' /></div>" +
                        "<div class=\"Modify\">" +
                            "<img src='/Plugin/JqueryUploadify/images/Document 2 Edit.png' onclick='return ModifyLiImage(this);' title='编辑' /></div>" +
                        "</div>" +
                    "<div class=\"TitleShow\">" +
                        "" + lists[ii].Title + "</div>" +
                "</li> ";
            repalceHtml += itemHtml;
        }
        $('#uploadimg-list-ul').html(repalceHtml);
        //提示
        $("a[rel=showGroupUc]").fancybox({
            'transitionIn': 'none',
            'transitionOut': 'none',
            'titlePosition': 'over',
            'titleFormat': function(title, currentArray, currentIndex, currentOpts) {
                return '<span id="fancybox-title-over">图像： ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';
            }
        });
    }

    function SetLi_UpdateFiles(objFile, response) {
    }

    function GetFileSize(iBytes) {
        var iFileKB = iBytes / 1024;
        iFileKB = SizeFormat(iFileKB.toString());
        return iFileKB + " KB";
    }

    function SizeFormat(s) {
        s = s.replace(/^(\d*)$/, "$1.");
        s = (s + "00").replace(/(\d*\.\d\d)\d*/, "$1");
        s = s.replace(".", ",");
        var re = /(\d)(\d{3},)/;
        while (re.test(s))
            s = s.replace(re, "$1,$2");
        s = s.replace(/,(\d\d)$/, ".$1");
        return s.replace(/^\./, "0.")
    }

    function DeleteLiImage(limidel) {
        if (confirm("确定删除该文件？")) {
            var picSeqno = $(limidel).parent().parent().parent().attr('id');
            picSeqno = picSeqno.replace('li_', '');
            var res = dx177.WebUI.usercontrols.UCImgupload.AjaxDeleteByPicsId(picSeqno);
            $(limidel).parent().parent().parent().remove();
        }
    }

    function ModifyLiImage(limidfy) {
        var picSeqno = $(limidfy).parent().parent().parent().attr('id');
        picSeqno = picSeqno.replace('li_', '');

        var url = "/usercontrols/changeImageInfo.aspx?picSeqno=" + picSeqno + "&TB_iframe=true&height=250&width=420&modal=true";
        ShowPopup(url);
    }

    function ModifyLiImageReturn(limidfy) {
        alert(limidfy);
    }
        
</script>

 
    <div style="margin-top:3px;">
        <input id="FileUpload1" type="file" runat="server" />
        <div>
            <ul id="uploadimg-list-ul">
                <%--<li onmouseover="OverDiv(this)" id='li_124' onmouseout="OutDiv(this)">
                    <div class="ImgShow">
                        <img class="Show" src="http://upload.17u.com/uploadfile/2008/08/20/3/2008082009364013390_s90.jpg"
                            alt="" />
                        <div class="ShowIdx">
                            1</div>
                        <div class="Delete">
                            <img src="/Plugin/JqueryUploadify/images/cancel.png" onclick='return DeleteLiImage(this);'
                                title='删除' /></div>
                        <div class="Modify">
                            <img src="/web/img/modify1.png" onclick='return ModifyLiImage(this);' title='编辑' /></div>
                    </div>
                    <div class="TitleShow">
                        显示民
                    </div>
                </li>
                <li onmouseover="OverDiv(this)" id='li_125' onmouseout="OutDiv(this)">
                    <div class="ImgShow">
                        <img class="Show" src="http://upload.17u.com/uploadfile/2008/08/20/3/2008082009364013390_s90.jpg"
                            alt="" />
                        <div class="Delete">
                            <img src="/Plugin/JqueryUploadify/images/cancel.png" onclick='return DeleteLiImage(this);'
                                title='删除' /></div>
                        <div class="Modify">
                            <img src="/web/img/modify1.png" onclick='return ModifyLiImage(this);' title='编辑' /></div>
                    </div>
                    <div class="TitleShow" title="我是中人在我是中人在我是中人在">
                        我是中人在我是中人在我是中人在
                    </div>
                </li>
                <li onmouseover="OverDiv(this)" id='li_126' onmouseout="OutDiv(this)">
                    <div class="ImgShow">
                        <img class="Show" src="http://upload.17u.com/uploadfile/2008/08/20/3/2008082009364013390_s90.jpg"
                            alt="" />
                        <div class="Delete">
                            <img src="/Plugin/JqueryUploadify/images/cancel.png" onclick='return DeleteLiImage(this);'
                                title='删除' /></div>
                        <div class="Modify">
                            <img src="/web/img/modify1.png" onclick='return ModifyLiImage(this);' title='编辑' /></div>
                    </div>
                    <div class="TitleShow">
                        显示民
                    </div>
                </li>
                <li onmouseover="OverDiv(this)" id='li_127' onmouseout="OutDiv(this)">
                    <div class="ImgShow">
                        <img class="Show" src="http://upload.17u.com/uploadfile/2008/08/20/3/2008082009364013390_s90.jpg"
                            alt="" />
                        <div class="Delete">
                            <img src="/Plugin/JqueryUploadify/images/cancel.png" onclick='return DeleteLiImage(this);'
                                title='删除' /></div>
                        <div class="Modify">
                            <img src="/web/img/modify1.png" onclick='return ModifyLiImage(this);' title='编辑' /></div>
                    </div>
                    <div class="TitleShow">
                        显示民
                    </div>
                </li>--%>
            </ul>
        </div>
    </div> 