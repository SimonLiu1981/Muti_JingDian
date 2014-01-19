//  viewtimes_get_guid = '124' 只读，不增加数据
//  viewtimes_add_guid = '123' 增1， 并读数据
//  viewtimes_set_guid = '123' 增1， 并读数据

$(document).ready(function() {       
    ViewTimes_0_1();
});

var url_ViewTimes_0_1 = '/plugin/ViewTimes_0_1/';

function TimeStampGet() {
    return Math.round(new Date().getTime() / 1000);
}


function ViewTimes_0_1() {
    var guids = GetReadViewTimesRequestData();
    if (guids != '') {
        $.post(url_ViewTimes_0_1 + "ajaxHandler.aspx?MethodName=Get&randID=" + escape(TimeStampGet()),
        $.parseJSON("{\"GUIDs\":\"" + guids + "\"}"),
        function(json) {
            BindAllViewsTimsTags(json);
        });
    }

    guids = GetAddViewTimesRequestData();
    if (guids != '') {

        $.post(url_ViewTimes_0_1 + "ajaxHandler.aspx?MethodName=Add&randID=" + escape(TimeStampGet()),
        $.parseJSON("{\"GUIDs\":\"" + guids + "\"}"),
        function(json) {                       
            BindAllViewsTimsTags(json);
        });

    }
    guids = GetSetViewTimesRequestData();
    if (guids != '') {
        $.post(url_ViewTimes_0_1 + "ajaxHandler.aspx?MethodName=Set&randID=" + escape(TimeStampGet()),
        $.parseJSON("{\"GUIDs\":\"" + guids + "\"}"),
        function(json) {
            BindAllViewsTimsTags(json);
        });
    }


    $("[viewtimes_set_guid]").bind('blur',
	function() {

    $.post(url_ViewTimes_0_1 + "ajaxHandler.aspx?MethodName=Set&randID=" + escape(TimeStampGet()),
        $.parseJSON("{\"GUIDs\":\"'" + $(this).attr("viewtimes_set_guid") + "'\",\"NUMBER\":\"" + $(this).val() + "\"}"),
        function(json) {	       
            BindAllViewsTimsTags(json);
        });
	});
    
}

function BindAllViewsTimsTags(json) {
    $("[viewtimes_get_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("viewtimes_get_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].TotalCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].TotalCount);
                }
                catch (ex) {
                }
            }
        }
    });

    $("[viewtimes_set_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("viewtimes_set_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].TotalCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].TotalCount);
                }
                catch (ex) {
                }
            }
        }
    });

    $("[viewtimes_add_guid]").each(function() {
        for (var i = 0; i < json.length; i++) {
            if ($(this).attr("viewtimes_add_guid") == json[i].UnqiueCode) {
                try {
                    $(this).val(json[i].TotalCount);
                }
                catch (ex) {
                }
                try {
                    $(this).html(json[i].TotalCount);
                }
                catch (ex) {
                }
            }
        }
    });
     
}

function GetReadViewTimesRequestData() {
    var first = true;
    var res = "";
    $("[viewtimes_get_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("viewtimes_get_guid");
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


function GetAddViewTimesRequestData() {
    var first = true;
    var res = "";
    $("[viewtimes_add_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("viewtimes_add_guid");
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


function GetSetViewTimesRequestData() {
    var first = true;
    var res = "";
    $("[viewtimes_set_guid]").each(function() {
        var fAppend = false;
        if ($(this).attr("load") == null) {
            $(this).attr("load", 0);
            fAppend = true
        }
        if (!fAppend) {

        }
        else {
            var guidItem = $(this).attr("viewtimes_set_guid");
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