
// 引用jquery组件，前提条件
// 修改样式。setpagedingcaiui()
// comment_get_guid='' D:\Personal_files\Development\hotels-mutil-manager\Sources\dx177.WebUI\js\CommentNumberGet.js


$(document).ready(function() {

    $("[comment_get_guid]").each(function() {
        var guidItem = $(this).attr("comment_get_guid");
        var commentOjbect = $(this);
        $.post("/admin/ajaxHandler.aspx?MethodName=GetCommentCount&randID=" + escape(Math.round(new Date().getTime() / 1000)),
        $.parseJSON("{\"guid\":\"" + guidItem + "\"}"),
        function(json) {
            
            $(commentOjbect).html(json.Number);
        }, "json"
        );

    });

});
 