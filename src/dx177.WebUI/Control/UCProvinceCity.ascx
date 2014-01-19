<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCProvinceCity.ascx.cs"
    Inherits="dx177.WebUI.Control.UCProvinceCity" %>
<div>
    省：
    <select id="ddlProvince">
    </select>
    市：
    <select id="ddlCity">
    </select>
</div>

<script type="text/javascript">

    $(document).ready(function() {
        $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
           { Pid: 0 },
          function(json) {
              callbackSubmitComment($('#ddlProvince'), json);
          });

        $("#ddlProvince").change(
            function() {
                var s = $("#ddlProvince").val();
                $("#ddlCity").get(0).selectedIndex = 0;
                $("#ddlCity").empty();
                if (s != 0) {
                    $.post("/admin/ajaxHandler.aspx?MethodName=ProvinceCity&randID=" + escape(new Date()),
                       { Pid: s },
                      function(json) {
                          callbackSubmitComment($('#ddlCity'), json);
                      });
                }
            }
        );
            $("#ddlCity").empty();
            $("#ddlCity").append("<option value=''>请选择</option>");
    });

    function callbackSubmitComment(dll, json) {
        $(dll).empty();
        $(dll).append("<option value=''>请选择</option>");
        for (var i = 0; i < json.length; i++) {
            $(dll).append("<option value='" + json[i].Areaid + "'>" + json[i].Areaname + "</option>");
        }
    }
</script>

