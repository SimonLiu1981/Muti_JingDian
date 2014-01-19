<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCSingleImgUpload.ascx.cs" Inherits="dx177.WebUI.usercontrols.UCSingleImgUpload" %>
<link href="/Plugin/JqueryUploadify/uploadify.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/Plugin/JqueryUploadify/swfobject.js"></script>
<script type="text/javascript" src="/Plugin/JqueryUploadify/jquery.uploadify.v2.1.0.min.js"></script>

<style type="text/css">
    
    #Singeimg-list-ul<%=this.ClientID%>
    {
        padding: 0;
        list-style: none;
        height:114px;        
        
    }
    #Singeimg-list-ul<%=this.ClientID%> li
    { 
        height:114px;
        float: left;
    }
    #Singeimg-list-ul<%=this.ClientID%> li .ImgShow
    {       
        
        float: left;
        position: relative;       
    }
    #Singeimg-list-ul<%=this.ClientID%> li .ImgShow .Show
    {        
        border: 1px #ccc solid;
        padding: 2px;
        width:110px;
      
        vertical-align: middle;
        float: left;
        text-align: center;
    }
    #Singeimg-list-ul<%=this.ClientID%> li .ImgShow .Delete
    {
        float:left;       
       
        cursor: pointer;
      
        height: 16px;
        width: 16px;
         
    }
    #Singeimg-list-ul<%=this.ClientID%> li .ImgShow .Modify
    {
        position: absolute;
        bottom: 2px;
        cursor: pointer;
        left: 10px;
        display: none;
    }
    #Singeimg-list-ul<%=this.ClientID%> li .ImgShow .ShowIdx
    {
        top: 30px;
        left: 30px;
        color: red;
        background-color: #FFF;
        height: 19px;
        font-size: 18px;
        position: absolute;
    }
     
   
</style>

<script type="text/javascript">

    $(document).ready(function() {

        StartUploadifySingle<%=this.ClientID%>();
        var ShowImgPath = '<%=ShowImgPath %>';
        var ImgPath = '<%=ImgPath %>';
        UCSetPic<%=this.ClientID%>(ImgPath, ShowImgPath);
        

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
    function StartUploadifySingle<%=this.ClientID%>() {
        $("#<%=this.FileUpload1.ClientID %>").uploadify({
            'uploader': '/Plugin/JqueryUploadify/uploadify2.swf',
            'cancelImg': '/Plugin/JqueryUploadify/images/cancel.png',
            'buttonText': 'Select Files',
            'buttonImg': '/Plugin/JqueryUploadify/images/SelectUp.png',
            'width': 87,
            'height': 30,
            'script': '/RemoteHandlers/JqueryUploadify/SingleImgUpload.ashx',
            'scriptData': { 'oldPicturePath': '<%=OldPicturePath %>', 'pguid': '<%=PGuid %>','seqno': '<%=Seqno%>' }, 
            'folder': 'uploads',
            'fileDesc': 'Files',
            'fileExt': '*.jpg;*.jpeg;*.gif;*.png;',
            'sizeLimit': iMaxUpdateFileSize,
            'simUploadLimit': 1,
            'multi': false,
            'auto': true,
            'onSelect': function(a, b, c) { /*选择文件上传时可以禁用某些按钮*/ },
            'onComplete': function(a, b, c, d, e) { SetLi_UpdateFiles<%=this.ClientID%>(c, d); },
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

    function UCSetPic<%=this.ClientID%>(imgPath,showImgPath) {    
         
        var html = "<li  filepath='" + imgPath + "'>" +
                    "<div class='ImgShow'> " +
                    "    <img class='Show' src='" + showImgPath + "'" +
                    "        alt='' />" +
                    "    <div class='Delete'>" +
                    "        <img src='/Plugin/JqueryUploadify/images/cancel.png' onclick=\"return DeleteLiImage<%=this.ClientID%>(this,'" + imgPath + "');\"" +
                    "            title='删除' /></div>" +
                    "</div>" +
                  "</li> ";
        $('#Singeimg-list-ul<%=this.ClientID%>').html(html); 
    }
    
    function SetLi_UpdateFiles<%=this.ClientID%>(objFile, response) {    
        var obj = strToJson(response);           
        $('#<%=this.txtImgPath.ClientID %>').val(obj.ImgPath);
        $('#<%=this.txtOldPath.ClientID %>').val(obj.ImgPath);
        $("#<%=this.FileUpload1.ClientID %>").uploadifySettings( 'scriptData',{ 'oldPicturePath': obj.ImgPath});
        UCSetPic<%=this.ClientID%>(obj.ImgPath,obj.ShowImgPath);
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

    function DeleteLiImage<%=this.ClientID%>(limidel, imgPath) {
        if (imgPath == '') {
            alert("目前还没有上传图片");
            return;
        }
        
        if (confirm("确定删除该文件？")) {
            var picSeqno = $(limidel).parent().parent().parent().attr('id');
            picSeqno = picSeqno.replace('li_', '');
            var filepath = $(limidel).parent().parent().parent().attr('filepath');            
            var res = dx177.WebUI.usercontrols.UCSingleImgUpload.AjaxDeleteFile(filepath);
            $('#<%=this.txtImgPath.ClientID %>').val("");
            var obj = strToJson(res.value);
            UCSetPic<%=this.ClientID%>(obj.ImgPath,obj.ShowImgPath);
            
        }
    }

    
</script>    
    <div style="margin-top:3px;">
        <div style=" float:left;" >
        <asp:HiddenField ID="txtImgPath" runat="server" /><asp:HiddenField ID="txtOldPath" runat="server" />
            <input id="FileUpload1" type="file" runat="server" style=" float:left; " />
             
        </div>
        <div style=" float:left; margin-left:10px; ">
            <ul id="Singeimg-list-ul<%=this.ClientID%>">
               <%-- <li filepath='<%=FilePath %>'>
                    <div class="ImgShow">                        
                        <img class="Show" src="<%=FilePath %>"
                            alt="" />
                        <div class="Delete">
                            <img src="/Plugin/JqueryUploadify/images/cancel.png" onclick='return DeleteLiImage<%=this.ClientID%>(thid,"<%=ImgPath %>");'
                                title='删除' /></div>
                    </div>
                </li>         --%>   
            </ul>
             <div style="clear:both"></div>
        </div>
       
    </div>
 
