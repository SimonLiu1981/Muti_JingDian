﻿function getallpictureids(obj) {
    var ids = "";
    var first = true;
    $(obj).children("li").each(function() {
        if (!first) {
            ids += ",";
        }
        first = false;
        ids += $(this).attr("PictureId");
    });
    return ids;
}
function bindPicListTextEvent() {
    var temp;
    $("input[ptitle], textarea[pdesc]").bind({
        focusin: function() {
            temp = $(this).val();
        },
        focusout: function() {
            var lastValue = $(this).val();
            if (temp != lastValue && null != lastValue && "" != lastValue) {

                var pid = 0
                if ($(this).attr("ptitle") != null) {
                    pid = $(this).attr("ptitle");
                }
                else {
                    pid = $(this).attr("pdesc");
                }
               
                $.getJSON("/Plugin/MultiPicUploadify/MultiPictureAjaxHandler.aspx?MethodName=UpdateEntity&jsoncallback=?",
                        {
                            picid: pid,
                            Title: encodeURIComponent($("input[ptitle='" + pid + "']").val()),
                            desc: encodeURIComponent($("textarea[pdesc='" + pid + "']").val())
                        },
                        function(json) {
                            if (json.Success) {
                                $("div[pdiv='" + pid + "']").fadeIn(500, function() {
                                    $(this).fadeOut(1000);
                                });
                            }
                        });
            }
        }
    });


    
    $('input[ptitle]').inputlimitor({
        limit: 50,
        remText: '你还有%n个字可以输入，',
        limitText: '你最多可以输入%n个字。'
    });
    $('textarea[pdesc]').inputlimitor({
        limit: 300,
        remText: '你还有%n个字可以输入，',
        limitText: '你最多可以输入%n个字。'
    });
    
    
    $("a.preview").preview();	 
}
function saveOrder() {
    var ulobj = $(this).parent();
    var ids = getallpictureids(ulobj);
    // reset
    if ($(this).parent().attr("PictureIds") != ids) {
        $.getJSON("/Plugin/MultiPicUploadify/MultiPictureAjaxHandler.aspx?MethodName=SortList&jsoncallback=?",
                {
                    picids: ids
                },
                function(json) {
                    ulobj.attr("PictureIds", getallpictureids(ulobj));
                });
    }
    $(this).parent().attr("PictureIds", ids);
};

function deleteImg(img) {
    if (!confirm("你确认要删除该图片吗？")) {
        return false;
    }
    var itemli = $(img).parent().parent();
    var ulobj = itemli.parent();

    var PictureId = itemli.attr("PictureId");
    // ajax delete picture
    $.getJSON("/Plugin/MultiPicUploadify/MultiPictureAjaxHandler.aspx?MethodName=DeltePic&jsoncallback=?",
                {
                    picid: PictureId
                },
                function(json) {
                    itemli.remove();
                    ulobj.attr("PictureIds", getallpictureids(ulobj));
                });
}

function AppendToPicList(picul, obj) {
    var htmlString = "";
    htmlString += (" <li title='拖动块进行排序' PictureId='" + obj.PictureId + "'>");
    htmlString += ("            <div class=\"wapper\">");
    htmlString += ("                <div class=\'img\'>");
    htmlString += ("                    <a class=\"preview\" target=_blank bigimg=\"" + obj.ShowBigPath + "\" >");
    htmlString += ("                        <img alt=\"" + obj.Title + "\" title=\"" + obj.Title + "\" src=\"" + obj.ShowSmaillPath + "\" />");
    htmlString += ("                    </a>");
    htmlString += ("                </div>");
    htmlString += ("                <div class=\"deletesortitem\" title='点击删除此图片' onclick=\"return deleteImg(this)\">");
    htmlString += ("                </div>");
    htmlString += ("                <div class=\"content\">");
    htmlString += ("                    <div class=\"title\">");
    htmlString += ("                        <span class=\"caption\">标题：</span>");
    htmlString += ("                            <input title='图片标题' ptitle='" + obj.PictureId + "' type=\"text\" value='" + obj.Title + "' /><div pdiv='" + obj.PictureId + "' class='success'>保存成功</div>");
    htmlString += ("                    </div>");
    htmlString += ("                    <div class=\"descption\">");
    htmlString += ("                        <span class=\"caption\">描述：</span>");
    htmlString += ("                        <textarea title='图片描述' pdesc='" + obj.PictureId + "'>" + obj.Description + "</textarea>");
    htmlString += ("                    </div>");
    htmlString += ("                </div>");
    htmlString += ("            </div>");
    htmlString += ("        </li>");
    $(picul).append(htmlString);    
}

function PictrueRequestSort(mModuleName, mTableIdentityId, mULID, mUpdateLoadFloader, mUploadFileControlId, mUploadFileQuensId) {
    this.ModuleName = mModuleName;
    this.TableIdentityId = mTableIdentityId;
    this.ULID = mULID;
    this.UpdateLoadFloader = mUpdateLoadFloader;
    this.UploadFileControlId = mUploadFileControlId;
    this.UploadFileQuensId = mUploadFileQuensId;
    this.onClick;
}

function MultiPicUploadifyInit(sortitem) {
  
    $("#" + sortitem.ULID).dragsort({ dragSelector: "div", dragBetween: true, dragEnd: saveOrder, placeHolderTemplate: "<li class='placeHolder'><div></div></li>" });
    $.getJSON("/Plugin/MultiPicUploadify/MultiPictureAjaxHandler.aspx?MethodName=GetPicList&jsoncallback=?",
                {
                    ModuleName: encodeURIComponent(sortitem.ModuleName),
                    TableIdentityId: sortitem.TableIdentityId
                },
                function(json) {
                    if (json.length > 0) {
                        $(json).each(function() {
                            AppendToPicList($("#" + sortitem.ULID), this);
                        });
                        var ids = getallpictureids($("#" + sortitem.ULID));
                        $("#" + sortitem.ULID).attr("PictureIds", ids);
                        bindPicListTextEvent();
                    }
                });

    $("#" + sortitem.UploadFileControlId).uploadify({
        'uploader': '/Plugin/MultiPicUploadify/uploadify2.swf',
        'cancelImg': '/Plugin/MultiPicUploadify/images/cancel.png',
        'buttonText': 'Select Files',
        'buttonImg': '/Plugin/MultiPicUploadify/images/SelectUp.png',
        'width': 89,
        'height': 30,
        'script': '/Plugin/MultiPicUploadify/MultiPictureUploadHandler.aspx',
        'scriptData': { 'SaveFolder': sortitem.UpdateLoadFloader, 'Moudle': sortitem.ModuleName, 'TableIdentityId': sortitem.TableIdentityId },
        'folder': 'uploads',
        'fileDesc': 'Files',
        'queueID': sortitem.UploadFileQuensId,
        'fileExt': '*.jpg;*.jpeg;*.gif;*.png;',
        'sizeLimit': 1024 * 1024 * 5, //5M            
        'multi': true,
        'auto': true,
        'onSelect': function(a, b, c) {

        },
        'onComplete': function(a, b, c, d, e) {
            var obj = (new Function("return " + d))();
            AppendToPicList($("#" + sortitem.ULID), obj);
            $("html,body").animate({ scrollTop: $("#" + sortitem.ULID).children('li').last().offset().top - 15 }, 1000);
        },
        'onAllComplete': function(a, b) {
            var ids = getallpictureids($("#" + sortitem.ULID));
            $("#" + sortitem.ULID).attr("PictureIds", ids);            
            bindPicListTextEvent();

        },
        'onCancel': function(a, b, c, d, e) { },
        'onError': function(a, b, c, d, e) {
            alert("error");
        }
    });

}

(function($) {
    $.fn.preview = function() {
        var xOffset = 10;
        var yOffset = 20;
        var w = $(window).width();
        $(this).each(function() {
            $(this).hover(function(e) {
            if (/.png$|.gif$|.jpg$|.bmp$/.test($(this).attr('bigimg').toLowerCase())) {
                 $("body").append("<div id='preview'><div><img src='" + $(this).attr('bigimg') + "' /><p>" + $(this).attr('title') + "</p></div></div>");
                } else {
                    $("body").append("<div id='preview'><div><p>" + $(this).attr('title') + "</p></div></div>");
                }
                $("#preview").css({
                    position: "absolute",
                    padding: "4px",
                    border: "1px solid #f3f3f3",
                    backgroundColor: "#eeeeee",
                    top: (e.pageY - yOffset) + "px",
                    zIndex: 1000
                });
                $("#preview > div").css({
                    padding: "5px",
                    backgroundColor: "white",
                    border: "1px solid #cccccc"
                });
                $("#preview > div > p").css({
                    textAlign: "center",
                    fontSize: "12px",
                    padding: "8px 0 3px",
                    margin: "0"
                });
                if (e.pageX < w / 2) {
                    $("#preview").css({
                        left: e.pageX + xOffset + "px",
                        right: "auto"
                    }).fadeIn("fast");
                } else {
                    $("#preview").css("right", (w - e.pageX + yOffset) + "px").css("left", "auto").fadeIn("fast");
                }
            }, function() {
                $("#preview").remove();
            }).mousemove(function(e) {
                $("#preview").css("top", (e.pageY - xOffset) + "px")
                if (e.pageX < w / 2) {
                    $("#preview").css("left", (e.pageX + yOffset) + "px").css("right", "auto");
                } else {
                    $("#preview").css("right", (w - e.pageX + yOffset) + "px").css("left", "auto");
                }
            });
        });
    };
})(jQuery);

if (jQuery) { (function(a) { a.extend(a.fn, { uploadify: function(b) { a(this).each(function() { var f = a.extend({ id: a(this).attr("id"), uploader: "uploadify.swf", script: "uploadify.php", expressInstall: null, folder: "", height: 30, width: 120, cancelImg: "cancel.png", wmode: "opaque", scriptAccess: "sameDomain", fileDataName: "Filedata", method: "POST", queueSizeLimit: 999, simUploadLimit: 1, queueID: false, displayData: "percentage", removeCompleted: true, onInit: function() { }, onSelect: function() { }, onSelectOnce: function() { }, onQueueFull: function() { }, onCheck: function() { }, onCancel: function() { }, onClearQueue: function() { }, onError: function() { }, onProgress: function() { }, onComplete: function() { }, onAllComplete: function() { } }, b); a(this).data("settings", f); var e = location.pathname; e = e.split("/"); e.pop(); e = e.join("/") + "/"; var g = {}; g.uploadifyID = f.id; g.pagepath = e; if (f.buttonImg) { g.buttonImg = escape(f.buttonImg) } if (f.buttonText) { g.buttonText = escape(f.buttonText) } if (f.rollover) { g.rollover = true } g.script = f.script; g.folder = escape(f.folder); if (f.scriptData) { var h = ""; for (var d in f.scriptData) { h += "&" + d + "=" + f.scriptData[d] } g.scriptData = escape(h.substr(1)) } g.width = f.width; g.height = f.height; g.wmode = f.wmode; g.method = f.method; g.queueSizeLimit = f.queueSizeLimit; g.simUploadLimit = f.simUploadLimit; if (f.hideButton) { g.hideButton = true } if (f.fileDesc) { g.fileDesc = f.fileDesc } if (f.fileExt) { g.fileExt = f.fileExt } if (f.multi) { g.multi = true } if (f.auto) { g.auto = true } if (f.sizeLimit) { g.sizeLimit = f.sizeLimit } if (f.checkScript) { g.checkScript = f.checkScript } if (f.fileDataName) { g.fileDataName = f.fileDataName } if (f.queueID) { g.queueID = f.queueID } if (f.onInit() !== false) { a(this).css("display", "none"); a(this).after('<div id="' + a(this).attr("id") + 'Uploader"></div>'); swfobject.embedSWF(f.uploader, f.id + "Uploader", f.width, f.height, "9.0.24", f.expressInstall, g, { quality: "high", wmode: f.wmode, allowScriptAccess: f.scriptAccess }, {}, function(i) { if (typeof (f.onSWFReady) == "function" && i.success) { f.onSWFReady() } }); if (f.queueID == false) { a("#" + a(this).attr("id") + "Uploader").after('<div id="' + a(this).attr("id") + 'Queue" class="uploadifyQueue"></div>') } else { a("#" + f.queueID).addClass("uploadifyQueue") } } if (typeof (f.onOpen) == "function") { a(this).bind("uploadifyOpen", f.onOpen) } a(this).bind("uploadifySelect", { action: f.onSelect, queueID: f.queueID }, function(k, i, j) { if (k.data.action(k, i, j) !== false) { var l = Math.round(j.size / 1024 * 100) * 0.01; var m = "KB"; if (l > 1000) { l = Math.round(l * 0.001 * 100) * 0.01; m = "MB" } var n = l.toString().split("."); if (n.length > 1) { l = n[0] + "." + n[1].substr(0, 2) } else { l = n[0] } if (j.name.length > 20) { fileName = j.name.substr(0, 20) + "..." } else { fileName = j.name } queue = "#" + a(this).attr("id") + "Queue"; if (k.data.queueID) { queue = "#" + k.data.queueID } a(queue).append('<div id="' + a(this).attr("id") + i + '" class="uploadifyQueueItem"><div class="cancel"><a href="javascript:jQuery(\'#' + a(this).attr("id") + "').uploadifyCancel('" + i + '\')"><img src="' + f.cancelImg + '" border="0" /></a></div><span class="fileName">' + fileName + " (" + l + m + ')</span><span class="percentage"></span><div class="uploadifyProgress"><div id="' + a(this).attr("id") + i + 'ProgressBar" class="uploadifyProgressBar"><!--Progress Bar--></div></div></div>') } }); a(this).bind("uploadifySelectOnce", { action: f.onSelectOnce }, function(i, j) { i.data.action(i, j); if (f.auto) { if (f.checkScript) { a(this).uploadifyUpload(null, false) } else { a(this).uploadifyUpload(null, true) } } }); a(this).bind("uploadifyQueueFull", { action: f.onQueueFull }, function(i, j) { if (i.data.action(i, j) !== false) { alert("The queue is full.  The max size is " + j + ".") } }); a(this).bind("uploadifyCheckExist", { action: f.onCheck }, function(n, m, l, k, p) { var j = new Object(); j = l; j.folder = (k.substr(0, 1) == "/") ? k : e + k; if (p) { for (var i in l) { var o = i } } a.post(m, j, function(s) { for (var q in s) { if (n.data.action(n, s, q) !== false) { var r = confirm("Do you want to replace the file " + s[q] + "?"); if (!r) { document.getElementById(a(n.target).attr("id") + "Uploader").cancelFileUpload(q, true, true) } } } if (p) { document.getElementById(a(n.target).attr("id") + "Uploader").startFileUpload(o, true) } else { document.getElementById(a(n.target).attr("id") + "Uploader").startFileUpload(null, true) } }, "json") }); a(this).bind("uploadifyCancel", { action: f.onCancel }, function(n, j, m, o, i, l) { if (n.data.action(n, j, m, o, l) !== false) { if (i) { var k = (l == true) ? 0 : 250; a("#" + a(this).attr("id") + j).fadeOut(k, function() { a(this).remove() }) } } }); a(this).bind("uploadifyClearQueue", { action: f.onClearQueue }, function(k, j) { var i = (f.queueID) ? f.queueID : a(this).attr("id") + "Queue"; if (j) { a("#" + i).find(".uploadifyQueueItem").remove() } if (k.data.action(k, j) !== false) { a("#" + i).find(".uploadifyQueueItem").each(function() { var l = a(".uploadifyQueueItem").index(this); a(this).delay(l * 100).fadeOut(250, function() { a(this).remove() }) }) } }); var c = []; a(this).bind("uploadifyError", { action: f.onError }, function(m, i, l, k) { if (m.data.action(m, i, l, k) !== false) { var j = new Array(i, l, k); c.push(j); a("#" + a(this).attr("id") + i).find(".percentage").text(" - " + k.type + " Error"); a("#" + a(this).attr("id") + i).find(".uploadifyProgress").hide(); a("#" + a(this).attr("id") + i).addClass("uploadifyError") } }); if (typeof (f.onUpload) == "function") { a(this).bind("uploadifyUpload", f.onUpload) } a(this).bind("uploadifyProgress", { action: f.onProgress, toDisplay: f.displayData }, function(k, i, j, l) { if (k.data.action(k, i, j, l) !== false) { a("#" + a(this).attr("id") + i + "ProgressBar").animate({ width: l.percentage + "%" }, 250, function() { if (l.percentage == 100) { a(this).closest(".uploadifyProgress").fadeOut(250, function() { a(this).remove() }) } }); if (k.data.toDisplay == "percentage") { displayData = " - " + l.percentage + "%" } if (k.data.toDisplay == "speed") { displayData = " - " + l.speed + "KB/s" } if (k.data.toDisplay == null) { displayData = " " } a("#" + a(this).attr("id") + i).find(".percentage").text(displayData) } }); a(this).bind("uploadifyComplete", { action: f.onComplete }, function(l, i, k, j, m) { if (l.data.action(l, i, k, unescape(j), m) !== false) { a("#" + a(this).attr("id") + i).find(".percentage").text(" - Completed"); if (f.removeCompleted) { a("#" + a(l.target).attr("id") + i).fadeOut(250, function() { a(this).remove() }) } a("#" + a(l.target).attr("id") + i).addClass("completed") } }); if (typeof (f.onAllComplete) == "function") { a(this).bind("uploadifyAllComplete", { action: f.onAllComplete }, function(i, j) { if (i.data.action(i, j) !== false) { c = [] } }) } }) }, uploadifySettings: function(f, j, c) { var g = false; a(this).each(function() { if (f == "scriptData" && j != null) { if (c) { var i = j } else { var i = a.extend(a(this).data("settings").scriptData, j) } var l = ""; for (var k in i) { l += "&" + k + "=" + i[k] } j = escape(l.substr(1)) } g = document.getElementById(a(this).attr("id") + "Uploader").updateSettings(f, j) }); if (j == null) { if (f == "scriptData") { var b = unescape(g).split("&"); var e = new Object(); for (var d = 0; d < b.length; d++) { var h = b[d].split("="); e[h[0]] = h[1] } g = e } } return g }, uploadifyUpload: function(b, c) { a(this).each(function() { if (!c) { c = false } document.getElementById(a(this).attr("id") + "Uploader").startFileUpload(b, c) }) }, uploadifyCancel: function(b) { a(this).each(function() { document.getElementById(a(this).attr("id") + "Uploader").cancelFileUpload(b, true, true, false) }) }, uploadifyClearQueue: function() { a(this).each(function() { document.getElementById(a(this).attr("id") + "Uploader").clearFileUploadQueue(false) }) } }) })(jQuery) };

(function(a) { a.fn.dragsort = function(c) { var d = a.extend({}, a.fn.dragsort.defaults, c); var b = new Array(); var f = null, e = null; if (this.selector) { a("head").append("<style type='text/css'>" + (this.selector.split(",").join(" " + d.dragSelector + ",") + " " + d.dragSelector) + " { cursor: pointer; }</style>") } this.each(function(h, g) { if (a(g).is("table") && a(g).children().size() == 1 && a(g).children().is("tbody")) { g = a(g).children().get(0) } var j = { draggedItem: null, placeHolderItem: null, pos: null, offset: null, offsetLimit: null, container: g, init: function() { a(this.container).attr("listIdx", h).mousedown(this.grabItem).find(d.dragSelector).css("cursor", "pointer") }, grabItem: function(l) { if (l.button == 2 || a(l.target).is(d.dragSelectorExclude)) { return } var n = l.target; while (!a(n).is("[listIdx=" + a(this).attr("listIdx") + "] " + d.dragSelector)) { if (n == this) { return } n = n.parentNode } if (f != null && f.draggedItem != null) { f.dropItem() } a(l.target).css("cursor", "move"); f = b[a(this).attr("listIdx")]; f.draggedItem = a(n).closest(d.itemSelector); var i = parseInt(f.draggedItem.css("marginTop")); var m = parseInt(f.draggedItem.css("marginLeft")); f.offset = f.draggedItem.offset(); f.offset.top = l.pageY - f.offset.top + (isNaN(i) ? 0 : i) - 1; f.offset.left = l.pageX - f.offset.left + (isNaN(m) ? 0 : m) - 1; if (!d.dragBetween) { var k = a(f.container).outerHeight() == 0 ? Math.max(1, Math.round(0.5 + a(f.container).children(d.itemSelector).size() * f.draggedItem.outerWidth() / a(f.container).outerWidth())) * f.draggedItem.outerHeight() : a(f.container).outerHeight(); f.offsetLimit = a(f.container).offset(); f.offsetLimit.right = f.offsetLimit.left + a(f.container).outerWidth() - f.draggedItem.outerWidth(); f.offsetLimit.bottom = f.offsetLimit.top + k - f.draggedItem.outerHeight() } f.draggedItem.css({ position: "absolute", opacity: 0.8, "z-index": 999 }).after(d.placeHolderTemplate); f.placeHolderItem = f.draggedItem.next().css("height", f.draggedItem.height()).attr("placeHolder", true); a(b).each(function(p, o) { o.ensureNotEmpty(); o.buildPositionTable() }); f.setPos(l.pageX, l.pageY); a(document).bind("selectstart", f.stopBubble); a(document).bind("mousemove", f.swapItems); a(document).bind("mouseup", f.dropItem); return false }, setPos: function(i, m) { var l = m - this.offset.top; var k = i - this.offset.left; if (!d.dragBetween) { l = Math.min(this.offsetLimit.bottom, Math.max(l, this.offsetLimit.top)); k = Math.min(this.offsetLimit.right, Math.max(k, this.offsetLimit.left)) } this.draggedItem.parents().each(function() { if (a(this).css("position") != "static" && (!a.browser.mozilla || a(this).css("display") != "table")) { var n = a(this).offset(); l -= n.top; k -= n.left; return false } }); this.draggedItem.css({ top: l, left: k }) }, buildPositionTable: function() { var i = this.draggedItem == null ? null : this.draggedItem.get(0); var k = new Array(); a(this.container).children(d.itemSelector).each(function(l, n) { if (n != i) { var m = a(n).offset(); m.right = m.left + a(n).width(); m.bottom = m.top + a(n).height(); m.elm = n; k.push(m) } }); this.pos = k }, dropItem: function() { if (f.draggedItem == null) { return } a(f.container).find(d.dragSelector).css("cursor", "pointer"); f.placeHolderItem.before(f.draggedItem); f.draggedItem.css({ position: "", top: "", left: "", opacity: "", "z-index": "" }); f.placeHolderItem.remove(); a("*[emptyPlaceHolder]").remove(); d.dragEnd.apply(f.draggedItem); f.draggedItem = null; a(document).unbind("selectstart", f.stopBubble); a(document).unbind("mousemove", f.swapItems); a(document).unbind("mouseup", f.dropItem); return false }, stopBubble: function() { return false }, swapItems: function(n) { if (f.draggedItem == null) { return false } f.setPos(n.pageX, n.pageY); var m = f.findPos(n.pageX, n.pageY); var l = f; for (var k = 0; m == -1 && d.dragBetween && k < b.length; k++) { m = b[k].findPos(n.pageX, n.pageY); l = b[k] } if (m == -1 || a(l.pos[m].elm).attr("placeHolder")) { return false } if (e == null || e.top > f.draggedItem.offset().top || e.left > f.draggedItem.offset().left) { a(l.pos[m].elm).before(f.placeHolderItem) } else { a(l.pos[m].elm).after(f.placeHolderItem) } a(b).each(function(p, o) { o.ensureNotEmpty(); o.buildPositionTable() }); e = f.draggedItem.offset(); return false }, findPos: function(k, m) { for (var l = 0; l < this.pos.length; l++) { if (this.pos[l].left < k && this.pos[l].right > k && this.pos[l].top < m && this.pos[l].bottom > m) { return l } } return -1 }, ensureNotEmpty: function() { if (!d.dragBetween) { return } var i = this.draggedItem == null ? null : this.draggedItem.get(0); var l = null, k = true; a(this.container).children(d.itemSelector).each(function(m, n) { if (a(n).attr("emptyPlaceHolder")) { l = n } else { if (n != i) { k = false } } }); if (k && l == null) { a(this.container).append(d.placeHolderTemplate).children(":last").attr("emptyPlaceHolder", true) } else { if (!k && l != null) { a(l).remove() } } } }; j.init(); b.push(j) }); return this }; a.fn.dragsort.defaults = { itemSelector: "li", dragSelector: "li", dragSelectorExclude: "input, a[href], textarea, div.deletesortitem, div.img img", dragEnd: function() { }, dragBetween: false, placeHolderTemplate: "<li>&nbsp;</li>"} })(jQuery);

var swfobject = function() { var D = "undefined", r = "object", S = "Shockwave Flash", W = "ShockwaveFlash.ShockwaveFlash", q = "application/x-shockwave-flash", R = "SWFObjectExprInst", x = "onreadystatechange", O = window, j = document, t = navigator, T = false, U = [h], o = [], N = [], I = [], l, Q, E, B, J = false, a = false, n, G, m = true, M = function() { var aa = typeof j.getElementById != D && typeof j.getElementsByTagName != D && typeof j.createElement != D, ah = t.userAgent.toLowerCase(), Y = t.platform.toLowerCase(), ae = Y ? /win/.test(Y) : /win/.test(ah), ac = Y ? /mac/.test(Y) : /mac/.test(ah), af = /webkit/.test(ah) ? parseFloat(ah.replace(/^.*webkit\/(\d+(\.\d+)?).*$/, "$1")) : false, X = ! +"\v1", ag = [0, 0, 0], ab = null; if (typeof t.plugins != D && typeof t.plugins[S] == r) { ab = t.plugins[S].description; if (ab && !(typeof t.mimeTypes != D && t.mimeTypes[q] && !t.mimeTypes[q].enabledPlugin)) { T = true; X = false; ab = ab.replace(/^.*\s+(\S+\s+\S+$)/, "$1"); ag[0] = parseInt(ab.replace(/^(.*)\..*$/, "$1"), 10); ag[1] = parseInt(ab.replace(/^.*\.(.*)\s.*$/, "$1"), 10); ag[2] = /[a-zA-Z]/.test(ab) ? parseInt(ab.replace(/^.*[a-zA-Z]+(.*)$/, "$1"), 10) : 0 } } else { if (typeof O.ActiveXObject != D) { try { var ad = new ActiveXObject(W); if (ad) { ab = ad.GetVariable("$version"); if (ab) { X = true; ab = ab.split(" ")[1].split(","); ag = [parseInt(ab[0], 10), parseInt(ab[1], 10), parseInt(ab[2], 10)] } } } catch (Z) { } } } return { w3: aa, pv: ag, wk: af, ie: X, win: ae, mac: ac} } (), k = function() { if (!M.w3) { return } if ((typeof j.readyState != D && j.readyState == "complete") || (typeof j.readyState == D && (j.getElementsByTagName("body")[0] || j.body))) { f() } if (!J) { if (typeof j.addEventListener != D) { j.addEventListener("DOMContentLoaded", f, false) } if (M.ie && M.win) { j.attachEvent(x, function() { if (j.readyState == "complete") { j.detachEvent(x, arguments.callee); f() } }); if (O == top) { (function() { if (J) { return } try { j.documentElement.doScroll("left") } catch (X) { setTimeout(arguments.callee, 0); return } f() })() } } if (M.wk) { (function() { if (J) { return } if (!/loaded|complete/.test(j.readyState)) { setTimeout(arguments.callee, 0); return } f() })() } s(f) } } (); function f() { if (J) { return } try { var Z = j.getElementsByTagName("body")[0].appendChild(C("span")); Z.parentNode.removeChild(Z) } catch (aa) { return } J = true; var X = U.length; for (var Y = 0; Y < X; Y++) { U[Y]() } } function K(X) { if (J) { X() } else { U[U.length] = X } } function s(Y) { if (typeof O.addEventListener != D) { O.addEventListener("load", Y, false) } else { if (typeof j.addEventListener != D) { j.addEventListener("load", Y, false) } else { if (typeof O.attachEvent != D) { i(O, "onload", Y) } else { if (typeof O.onload == "function") { var X = O.onload; O.onload = function() { X(); Y() } } else { O.onload = Y } } } } } function h() { if (T) { V() } else { H() } } function V() { var X = j.getElementsByTagName("body")[0]; var aa = C(r); aa.setAttribute("type", q); var Z = X.appendChild(aa); if (Z) { var Y = 0; (function() { if (typeof Z.GetVariable != D) { var ab = Z.GetVariable("$version"); if (ab) { ab = ab.split(" ")[1].split(","); M.pv = [parseInt(ab[0], 10), parseInt(ab[1], 10), parseInt(ab[2], 10)] } } else { if (Y < 10) { Y++; setTimeout(arguments.callee, 10); return } } X.removeChild(aa); Z = null; H() })() } else { H() } } function H() { var ag = o.length; if (ag > 0) { for (var af = 0; af < ag; af++) { var Y = o[af].id; var ab = o[af].callbackFn; var aa = { success: false, id: Y }; if (M.pv[0] > 0) { var ae = c(Y); if (ae) { if (F(o[af].swfVersion) && !(M.wk && M.wk < 312)) { w(Y, true); if (ab) { aa.success = true; aa.ref = z(Y); ab(aa) } } else { if (o[af].expressInstall && A()) { var ai = {}; ai.data = o[af].expressInstall; ai.width = ae.getAttribute("width") || "0"; ai.height = ae.getAttribute("height") || "0"; if (ae.getAttribute("class")) { ai.styleclass = ae.getAttribute("class") } if (ae.getAttribute("align")) { ai.align = ae.getAttribute("align") } var ah = {}; var X = ae.getElementsByTagName("param"); var ac = X.length; for (var ad = 0; ad < ac; ad++) { if (X[ad].getAttribute("name").toLowerCase() != "movie") { ah[X[ad].getAttribute("name")] = X[ad].getAttribute("value") } } P(ai, ah, Y, ab) } else { p(ae); if (ab) { ab(aa) } } } } } else { w(Y, true); if (ab) { var Z = z(Y); if (Z && typeof Z.SetVariable != D) { aa.success = true; aa.ref = Z } ab(aa) } } } } } function z(aa) { var X = null; var Y = c(aa); if (Y && Y.nodeName == "OBJECT") { if (typeof Y.SetVariable != D) { X = Y } else { var Z = Y.getElementsByTagName(r)[0]; if (Z) { X = Z } } } return X } function A() { return !a && F("6.0.65") && (M.win || M.mac) && !(M.wk && M.wk < 312) } function P(aa, ab, X, Z) { a = true; E = Z || null; B = { success: false, id: X }; var ae = c(X); if (ae) { if (ae.nodeName == "OBJECT") { l = g(ae); Q = null } else { l = ae; Q = X } aa.id = R; if (typeof aa.width == D || (!/%$/.test(aa.width) && parseInt(aa.width, 10) < 310)) { aa.width = "310" } if (typeof aa.height == D || (!/%$/.test(aa.height) && parseInt(aa.height, 10) < 137)) { aa.height = "137" } j.title = j.title.slice(0, 47) + " - Flash Player Installation"; var ad = M.ie && M.win ? "ActiveX" : "PlugIn", ac = "MMredirectURL=" + O.location.toString().replace(/&/g, "%26") + "&MMplayerType=" + ad + "&MMdoctitle=" + j.title; if (typeof ab.flashvars != D) { ab.flashvars += "&" + ac } else { ab.flashvars = ac } if (M.ie && M.win && ae.readyState != 4) { var Y = C("div"); X += "SWFObjectNew"; Y.setAttribute("id", X); ae.parentNode.insertBefore(Y, ae); ae.style.display = "none"; (function() { if (ae.readyState == 4) { ae.parentNode.removeChild(ae) } else { setTimeout(arguments.callee, 10) } })() } u(aa, ab, X) } } function p(Y) { if (M.ie && M.win && Y.readyState != 4) { var X = C("div"); Y.parentNode.insertBefore(X, Y); X.parentNode.replaceChild(g(Y), X); Y.style.display = "none"; (function() { if (Y.readyState == 4) { Y.parentNode.removeChild(Y) } else { setTimeout(arguments.callee, 10) } })() } else { Y.parentNode.replaceChild(g(Y), Y) } } function g(ab) { var aa = C("div"); if (M.win && M.ie) { aa.innerHTML = ab.innerHTML } else { var Y = ab.getElementsByTagName(r)[0]; if (Y) { var ad = Y.childNodes; if (ad) { var X = ad.length; for (var Z = 0; Z < X; Z++) { if (!(ad[Z].nodeType == 1 && ad[Z].nodeName == "PARAM") && !(ad[Z].nodeType == 8)) { aa.appendChild(ad[Z].cloneNode(true)) } } } } } return aa } function u(ai, ag, Y) { var X, aa = c(Y); if (M.wk && M.wk < 312) { return X } if (aa) { if (typeof ai.id == D) { ai.id = Y } if (M.ie && M.win) { var ah = ""; for (var ae in ai) { if (ai[ae] != Object.prototype[ae]) { if (ae.toLowerCase() == "data") { ag.movie = ai[ae] } else { if (ae.toLowerCase() == "styleclass") { ah += ' class="' + ai[ae] + '"' } else { if (ae.toLowerCase() != "classid") { ah += " " + ae + '="' + ai[ae] + '"' } } } } } var af = ""; for (var ad in ag) { if (ag[ad] != Object.prototype[ad]) { af += '<param name="' + ad + '" value="' + ag[ad] + '" />' } } aa.outerHTML = '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"' + ah + ">" + af + "</object>"; N[N.length] = ai.id; X = c(ai.id) } else { var Z = C(r); Z.setAttribute("type", q); for (var ac in ai) { if (ai[ac] != Object.prototype[ac]) { if (ac.toLowerCase() == "styleclass") { Z.setAttribute("class", ai[ac]) } else { if (ac.toLowerCase() != "classid") { Z.setAttribute(ac, ai[ac]) } } } } for (var ab in ag) { if (ag[ab] != Object.prototype[ab] && ab.toLowerCase() != "movie") { e(Z, ab, ag[ab]) } } aa.parentNode.replaceChild(Z, aa); X = Z } } return X } function e(Z, X, Y) { var aa = C("param"); aa.setAttribute("name", X); aa.setAttribute("value", Y); Z.appendChild(aa) } function y(Y) { var X = c(Y); if (X && X.nodeName == "OBJECT") { if (M.ie && M.win) { X.style.display = "none"; (function() { if (X.readyState == 4) { b(Y) } else { setTimeout(arguments.callee, 10) } })() } else { X.parentNode.removeChild(X) } } } function b(Z) { var Y = c(Z); if (Y) { for (var X in Y) { if (typeof Y[X] == "function") { Y[X] = null } } Y.parentNode.removeChild(Y) } } function c(Z) { var X = null; try { X = j.getElementById(Z) } catch (Y) { } return X } function C(X) { return j.createElement(X) } function i(Z, X, Y) { Z.attachEvent(X, Y); I[I.length] = [Z, X, Y] } function F(Z) { var Y = M.pv, X = Z.split("."); X[0] = parseInt(X[0], 10); X[1] = parseInt(X[1], 10) || 0; X[2] = parseInt(X[2], 10) || 0; return (Y[0] > X[0] || (Y[0] == X[0] && Y[1] > X[1]) || (Y[0] == X[0] && Y[1] == X[1] && Y[2] >= X[2])) ? true : false } function v(ac, Y, ad, ab) { if (M.ie && M.mac) { return } var aa = j.getElementsByTagName("head")[0]; if (!aa) { return } var X = (ad && typeof ad == "string") ? ad : "screen"; if (ab) { n = null; G = null } if (!n || G != X) { var Z = C("style"); Z.setAttribute("type", "text/css"); Z.setAttribute("media", X); n = aa.appendChild(Z); if (M.ie && M.win && typeof j.styleSheets != D && j.styleSheets.length > 0) { n = j.styleSheets[j.styleSheets.length - 1] } G = X } if (M.ie && M.win) { if (n && typeof n.addRule == r) { n.addRule(ac, Y) } } else { if (n && typeof j.createTextNode != D) { n.appendChild(j.createTextNode(ac + " {" + Y + "}")) } } } function w(Z, X) { if (!m) { return } var Y = X ? "visible" : "hidden"; if (J && c(Z)) { c(Z).style.visibility = Y } else { v("#" + Z, "visibility:" + Y) } } function L(Y) { var Z = /[\\\"<>\.;]/; var X = Z.exec(Y) != null; return X && typeof encodeURIComponent != D ? encodeURIComponent(Y) : Y } var d = function() { if (M.ie && M.win) { window.attachEvent("onunload", function() { var ac = I.length; for (var ab = 0; ab < ac; ab++) { I[ab][0].detachEvent(I[ab][1], I[ab][2]) } var Z = N.length; for (var aa = 0; aa < Z; aa++) { y(N[aa]) } for (var Y in M) { M[Y] = null } M = null; for (var X in swfobject) { swfobject[X] = null } swfobject = null }) } } (); return { registerObject: function(ab, X, aa, Z) { if (M.w3 && ab && X) { var Y = {}; Y.id = ab; Y.swfVersion = X; Y.expressInstall = aa; Y.callbackFn = Z; o[o.length] = Y; w(ab, false) } else { if (Z) { Z({ success: false, id: ab }) } } }, getObjectById: function(X) { if (M.w3) { return z(X) } }, embedSWF: function(ab, ah, ae, ag, Y, aa, Z, ad, af, ac) { var X = { success: false, id: ah }; if (M.w3 && !(M.wk && M.wk < 312) && ab && ah && ae && ag && Y) { w(ah, false); K(function() { ae += ""; ag += ""; var aj = {}; if (af && typeof af === r) { for (var al in af) { aj[al] = af[al] } } aj.data = ab; aj.width = ae; aj.height = ag; var am = {}; if (ad && typeof ad === r) { for (var ak in ad) { am[ak] = ad[ak] } } if (Z && typeof Z === r) { for (var ai in Z) { if (typeof am.flashvars != D) { am.flashvars += "&" + ai + "=" + Z[ai] } else { am.flashvars = ai + "=" + Z[ai] } } } if (F(Y)) { var an = u(aj, am, ah); if (aj.id == ah) { w(ah, true) } X.success = true; X.ref = an } else { if (aa && A()) { aj.data = aa; P(aj, am, ah, ac); return } else { w(ah, true) } } if (ac) { ac(X) } }) } else { if (ac) { ac(X) } } }, switchOffAutoHideShow: function() { m = false }, ua: M, getFlashPlayerVersion: function() { return { major: M.pv[0], minor: M.pv[1], release: M.pv[2]} }, hasFlashPlayerVersion: F, createSWF: function(Z, Y, X) { if (M.w3) { return u(Z, Y, X) } else { return undefined } }, showExpressInstall: function(Z, aa, X, Y) { if (M.w3 && A()) { P(Z, aa, X, Y) } }, removeSWF: function(X) { if (M.w3) { y(X) } }, createCSS: function(aa, Z, Y, X) { if (M.w3) { v(aa, Z, Y, X) } }, addDomLoadEvent: K, addLoadEvent: s, getQueryParamValue: function(aa) { var Z = j.location.search || j.location.hash; if (Z) { if (/\?/.test(Z)) { Z = Z.split("?")[1] } if (aa == null) { return L(Z) } var Y = Z.split("&"); for (var X = 0; X < Y.length; X++) { if (Y[X].substring(0, Y[X].indexOf("=")) == aa) { return L(Y[X].substring((Y[X].indexOf("=") + 1))) } } } return "" }, expressInstallCallback: function() { if (a) { var X = c(R); if (X && l) { X.parentNode.replaceChild(l, X); if (Q) { w(Q, true); if (M.ie && M.win) { l.style.display = "block" } } if (E) { E(B) } } a = false } } } } ();


(function($) {
    $.fn.inputlimitor = function(options) {
        var opts = $.extend({}, $.fn.inputlimitor.defaults, options); if (opts.boxAttach && !$('#' + opts.boxId).length) {
            $('<div/>').appendTo("body").attr({ id: opts.boxId, 'class': opts.boxClass }).css({ 'position': 'absolute' }).hide(); if ($.fn.bgiframe)
                $('#' + opts.boxId).bgiframe();
        }
        $(this).each(function(i) {
            $(this).keyup(function(e) {
                if ($(this).val().length > opts.limit)
                    $(this).val($(this).val().substring(0, opts.limit)); if (opts.boxAttach)
                { $('#' + opts.boxId).css({ 'width': $(this).outerWidth() - ($('#' + opts.boxId).outerWidth() - $('#' + opts.boxId).width()) + 'px', 'left': $(this).offset().left + 'px', 'top': ($(this).offset().top + $(this).outerHeight()) - 1 + 'px' }); }
                var remText = opts.remText; remText = remText.replace(/\%n/g, opts.limit - $(this).val().length); remText = remText.replace(/\%s/g, (opts.limit - $(this).val().length == 1 ? '' : 's')); var limitText = opts.limitText; limitText = limitText.replace(/\%n/g, opts.limit); limitText = limitText.replace(/\%s/g, (opts.limit == 1 ? '' : 's')); if (opts.limitTextShow) {
                    $('#' + opts.boxId).html(remText + ' ' + limitText); var textWidth = $("<span/>").appendTo("body").attr({ id: '19cc9195583bfae1fad88e19d443be7a', 'class': opts.boxClass }).html(remText + ' ' + limitText).innerWidth(); $("#19cc9195583bfae1fad88e19d443be7a").remove(); if (textWidth > $('#' + opts.boxId).innerWidth()) { $('#' + opts.boxId).html(remText + '<br />' + limitText); }
                    $('#' + opts.boxId).show();
                }
                else
                    $('#' + opts.boxId).html(remText).show();
            }); $(this).keypress(function(e) {
                if ((!e.keyCode || (e.keyCode > 46 && e.keyCode < 90)) && $(this).val().length >= opts.limit)
                    return false;
            }); $(this).blur(function() {
                if (opts.boxAttach)
                { $('#' + opts.boxId).fadeOut('fast'); }
                else if (opts.remTextHideOnBlur)
                { var limitText = opts.limitText; limitText = limitText.replace(/\%n/g, opts.limit); limitText = limitText.replace(/\%s/g, (opts.limit == 1 ? '' : 's')); $('#' + opts.boxId).html(limitText); } 
            });
        });
    }; $.fn.inputlimitor.defaults = { limit: 255, boxAttach: true, boxId: 'limitorBox', boxClass: 'limitorBox', remText: '%n character%s remaining.', remTextHideOnBlur: true, limitTextShow: true, limitText: 'Field limited to %n character%s.' };
})(jQuery);