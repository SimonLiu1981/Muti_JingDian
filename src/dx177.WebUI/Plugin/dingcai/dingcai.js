// 引用jquery组件，前提条件
// 修改样式。setpagedingcaiui()
// support_get_guid=''
// support_set_guid=''
// support_add_guid='' tagID=''  -- 说明点击对象才会触发

// oppose_get_guid=''
// oppose_set_guid=''
// oppose_add_guid='' tagID='' -- 说明点击对象才会触发

var uriofsupportoppose = '/plugin/dingcai/';

$(document).ready(function() {
    var guids = GetReadDingCaiRequestData(); //support_get_guid + oppose_get_guid
    if (guids != '') {       
        $.post(uriofsupportoppose + "dingcaiget.aspx?MethodName=Load&randID=" + escape(new Date()),
        $.parseJSON("{\"GUIDs\":\"" + guids + "\"}"),
        function(json) {            
            BindAllDingCaiTags(json);
        }, "json"
        );
    }
    guids = GetSetDingCaiRequestData();  //support_set_guid + oppose_set_guid
    if (guids != '') {
        $.post(uriofsupportoppose + "dingcaiget.aspx?MethodName=Load&randID=" + escape(new Date()),
        $.parseJSON("{\"GUIDs\":\"" + guids + "\"}"),
        function(json) {
            BindAllDingCaiTags(json);
        }, "json");
    }
    guids = GetAddDingCaiRequestData();   //support_add_guid + oppose_add_guid
    if (guids != '') {
        $.post(uriofsupportoppose + "dingcaiget.aspx?MethodName=Load&randID=" + escape(new Date()),
        $.parseJSON("{\"GUIDs\":\"" + guids + "\"}"),
        function(json) {
            BindAllDingCaiTags(json);
        }, "json");
    }

    $("[oppose_set_guid]").bind('blur',
	function() {
	    $.post(uriofsupportoppose + "dingcaiget.aspx?MethodName=Update&randID=" + escape(new Date()),
	    { "GUIDs": "'" + $(this).attr("oppose_set_guid") + "'", "NUMBER": $(this).val(), FLAG: false },
        function(json) {
            BindAllDingCaiTags(json);
        }, "json");
	});

    $("[support_set_guid]").bind('blur',
	function() {
	    $.post(uriofsupportoppose + "dingcaiget.aspx?MethodName=Update&randID=" + escape(new Date()),
        { "GUIDs": "'" + $(this).attr("support_set_guid") + "'", "NUMBER": $(this).val(), FLAG: true },
        function(json) {
            BindAllDingCaiTags(json);
        }, "json");
	});

    // 转移banding to tagID
    $("[support_add_guid]").each(function() {
        if ($(this).attr("tagID") != null) {
            $("#" + $(this).attr("tagID")).attr("guid", $(this).attr("support_add_guid"));
            $("#" + $(this).attr("tagID")).attr("submit", $(this).attr("submit"));
            $("#" + $(this).attr("tagID")).bind('click', function() {
                if ($(this).attr("submit") == "1") {
                    return;
                }
                IncreaseSupportOppose($(this).attr("guid"), true);
            });
        }
        else {
            $(this).bind('click',
            function() {
                if ($(this).attr("submit") == "1") {
                    return;
                }
                IncreaseSupportOppose($(this).attr("support_add_guid"), true);
            });
        }
    });

    // 转移banding to tagID
    $("[oppose_add_guid]").each(function() {
        if ($(this).attr("tagID") != null) {
            $("#" + $(this).attr("tagID")).attr("guid", $(this).attr("oppose_add_guid"));
            $("#" + $(this).attr("tagID")).attr("submit", $(this).attr("submit"));
            $("#" + $(this).attr("tagID")).bind('click', function() {
                if ($(this).attr("submit") == "1") {
                    return;
                }
                IncreaseSupportOppose($(this).attr("guid"), false);
            });
        }
        else {
            $(this).bind('click',
            function() {
                if ($(this).attr("submit") == "1") {
                    return;
                }
                IncreaseSupportOppose($(this).attr("support_add_guid"), false);
            });
        }
    });
});

function IncreaseSupportOppose(guid, flag) {
    $.post(uriofsupportoppose + "dingcaiget.aspx?MethodName=Submit&randID=" + escape(new Date()),
        { "GUIDs": "'" + guid + "'", FLAG: flag },
        function(json) {
            BindAllDingCaiTags(json);
        }, "json");
}

function BindAllDingCaiTags(json) {
    $("[support_get_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("support_get_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].SupportCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].SupportCount);
                }
                catch (ex) {
                }
            }
        }
    });

    $("[oppose_get_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("oppose_get_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].OpposeCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].OpposeCount);
                }
                catch (ex) {
                }
            }
        }
    });

    $("[support_set_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("support_set_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].SupportCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].SupportCount);
                }
                catch (ex) {
                }
            }
        }
    });

    $("[oppose_set_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("oppose_set_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].OpposeCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].OpposeCount);
                }
                catch (ex) {
                }
            }
        }
    });


    $("[support_add_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("support_add_guid") == json[i].UnqiueCode) {
                if (json[i].Submited) {
                    $(this).attr('submit', '1');
                }
                else {
                    $(this).attr('submit', '0');
                }
                if ($(this).attr("tagID") != null) {
                    $("#" + $(this).attr("tagID")).attr("submit", $(this).attr("submit"));
                }
                try {
                    $(this).val(json[i].SupportCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].SupportCount);
                }
                catch (ex) {
                }
            }
        }
    });
    $("[oppose_add_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("oppose_add_guid") == json[i].UnqiueCode) {
                if (json[i].Submited) {
                    $(this).attr('submit', '1');
                }
                else {
                    $(this).attr('submit', '0');
                }
                if ($(this).attr("tagID") != null) {
                    $("#" + $(this).attr("tagID")).attr("submit", $(this).attr("submit"));
                }
                try {
                    $(this).val(json[i].OpposeCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].OpposeCount);
                }
                catch (ex) {
                }
            }
        }
    });

}



function GetReadDingCaiRequestData() {
    var first = true;
    var res = "";
    $("[support_get_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("support_get_guid");
            if (res.indexOf("'" + guidItem + "'") == -1) {
                if (!first) {
                    res += ',';
                }
                first = false;
                res += "'" + guidItem + "'";
            }
        }
    });
    $("[oppose_get_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("oppose_get_guid");
            if (res.indexOf("'" + guidItem + "'") == -1) {
                if (!first) {
                    res += ',';
                }
                first = false;
                res += "'" + guidItem + "'";
            }
        }
    });
    return res;
}


function GetAddDingCaiRequestData() {
    var first = true;
    var res = "";
    $("[support_add_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("support_add_guid");
            if (res.indexOf("'" + guidItem + "'") == -1) {
                if (!first) {
                    res += ',';
                }
                first = false;
                res += "'" + guidItem + "'";
            }
        }
    });
    $("[oppose_add_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("oppose_add_guid");
            if (res.indexOf("'" + guidItem + "'") == -1) {
                if (!first) {
                    res += ',';
                }
                first = false;
                res += "'" + guidItem + "'";
            }
        }
    });
    return res;
}


function GetSetDingCaiRequestData() {
    var first = true;
    var res = "";
    $("[support_set_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("support_set_guid");
            if (res.indexOf("'" + guidItem + "'") == -1) {
                if (!first) {
                    res += ',';
                }
                first = false;
                res += "'" + guidItem + "'";
            }
        }
    });
    $("[oppose_set_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("oppose_add_guid");
            if (res.indexOf("'" + guidItem + "'") == -1) {
                if (!first) {
                    res += ',';
                }
                first = false;
                res += "'" + guidItem + "'";
            }
        }
    });
    return res;
}