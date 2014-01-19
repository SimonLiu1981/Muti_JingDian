function MulFileUploadifyInit(sortitem, queueSizeLimit) {
    $("#" + sortitem.UploadFileControlId).uploadify({
        'uploader': '/Plugins/MultiFilesUpload/uploadify2.swf',
        'cancelImg': '/Plugins/MultiFilesUpload/images/cancel.png',
        'buttonText': 'Select Files',
        'buttonImg': '/Plugins/MultiFilesUpload/images/SelectUp.png',
        'width': 89,
        'height': 30,
        'script': '/Plugins/MultiFilesUpload/MultiFileUploadHandler.aspx',
        'scriptData': { 'SaveFolder': sortitem.UpdateLoadFloader, 'Moudle': sortitem.ModuleName, 'TableIdentityId': sortitem.TableIdentityId },
        'folder': 'uploads',
        'fileDesc': 'Files',
        'queueID': sortitem.UploadFileQuensId,
        'fileExt': '*.doc;*.rar;*.zip;*.txt',
        'sizeLimit': 1024 * 1024 * 5, //5M        
        'multi': true,
        'auto': true,
        'onQueueFull': function(event, queueSizeLimit) {
        },
        'onSelect': function(a, b, c) {
        },
        'onComplete': function(a, b, c, d, e) {
            var obj = (new Function("return " + d))();
            AppendToMultiFileConste(sortitem, obj);
        },
        'onAllComplete': function(a, b) {


        },
        'onCancel': function(a, b, c, d, e) { },
        'onError': function(a, b, c, d, e) {
            alert("error");
        }
    });



    $.getJSON("/Plugins/MultiFilesUpload/MultiupFilesAjaxHandler.aspx?MethodName=GetFileList&Random=" + Math.random() + "&jsoncallback=?",
            {
                ModuleName: encodeURIComponent(sortitem.ModuleName),
                TableIdentityId: sortitem.TableIdentityId
            },
            function(json) {
                if (json.length > 0) {
                    $(json).each(function() {
                        AppendToMultiFileConste(sortitem, this);
                    });
                }
            });
}

function AppendToMultiFileConste(sortitem, fileObj) {

    if ($("#" + sortitem.UploadFileQuensId + " > ul.multifilelist").length == 0) {
        $("#" + sortitem.UploadFileQuensId).append("<ul class=\"multifilelist\"></ul>");
    }
    $("#" + sortitem.UploadFileQuensId + " > ul.multifilelist").first().append("<li> <a href='" + fileObj.ShowPath + "'>" + fileObj.FileName + "</a><span> 文件大小：" + fileObj.FileSize + "</span> <a href='javascript:;' onclick='multifiledelete(this," + fileObj.FileId + ")'><img src=\"Plugins/MultiFilesUpload/images/cancel.png\"  alt='删除'/></a></li>");
}

function multifiledelete(deleObj, fileId) {
    if (confirm("你是否要删除该文件？")) {
        $.getJSON("/Plugins/MultiFilesUpload/MultiupFilesAjaxHandler.aspx?MethodName=DelteFile&jsoncallback=?",
                {
                    fileid: fileId
                },
                function(json) {
                    $(deleObj).parent().remove();
                });
    }
}