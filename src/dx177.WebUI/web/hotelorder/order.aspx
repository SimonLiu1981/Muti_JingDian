<%@ Page Title="" Language="C#" MasterPageFile="~/web/defaultMaster.Master" AutoEventWireup="true"
    CodeBehind="order.aspx.cs" Inherits="dx177.WebUI.web.hotelorder.order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/web/css/order.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="/ajaxpro/prototype.ashx"></script>

    <script type="text/javascript" src="/ajaxpro/core.ashx"></script>

    <script type="text/javascript" src="/ajaxpro/converter.ashx"></script>

    <script type="text/javascript" src="/ajaxpro/dx177.WebUI.web.hotelorder.order,dx177.WebUI.ashx"></script>

    <script src="/js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    <script type="text/javascript">
        function ajaxFormSubmit() {
            var start_date = $('#start_date').val();
            var end_date = $('#end_date').val();
            var unitPrice = parseFloat('<%=RM.Price1 %>');
            var roomCount = parseInt($('#order_room_count').val());
            dx177.WebUI.web.hotelorder.order.GetCostList(start_date, end_date, roomCount, unitPrice, GetCostListCallBack);
        }

        function GetCostListCallBack(res) {
            $('#total_money2').html(res.value.TotalPrice);
            $('#total_days').html(res.value.Days);
            $('#total_money').html(res.value.TotalPrice);
            $('#total_rooms').html($('#order_room_count').val());

            var roompricehtml = '';
            for (var i = 0; i < res.value.RoomCostList.length; i++) {
                var tmp = res.value.RoomCostList[i];
                roompricehtml += '<ul><li class="li_th">' + tmp.DateString + '</li>' +
                                   '<li>' + tmp.MoneyString + '元</li>' +
                                '</ul>';
            }
            $('#roomprice').html(roompricehtml);

        }

        function changeRooms(va) {
            ajaxFormSubmit();
        }

        function submitHotelOrder() {
            if ($('#start_date').val() == '') {
                alert("请选择预定时间！");
                $('#start_date').focus();
                return false;
            }
            if ($('#end_date').val() == '') {
                alert("请选择预定时间！");
                $('#end_date').focus();
                return false;
            }
            if ($('#order_person_name').val() == '') {
                alert("请填写入住人姓名！");
                $('#order_person_name').focus();
                return false;
            }

            if ($('#order_person_phone').val() == '') {
                alert("请填写入住人手机！");
                $('#order_person_phone').focus();
                return false;
            }

             
            
            if ($('#order_username').val() == '') {
                alert("请填写订单联系人姓名！");
                $('#order_username').focus();
                return false;
            }

            if ($('#order_phone').val() == '') {
                alert("请填写订单联系人手机！");
                $('#order_phone').focus();
                return false;
            }

            if ($('#InTime').val() == '') {
                alert("请填写到店时间！");
                $('#InTime').focus();
                return false;
            }
            var param = {};
            param.RoomSeqno = <%=RM.Seqno %>;
            param.Roomtitle = '<%=RM.Roomtitle %>'
            param.HotelSeqno = <%=HT.Seqno %>;
            param.Hoteltitle = '<%=HT.Name %>';
            param.ReachDate = $('#InTime').val();
            param.end_date = $('#end_date').val();
            param.start_date = $('#start_date').val();
            param.order_person_name = $('#order_person_name').val();
            param.order_person_phone = $('#order_person_phone').val();
            param.order_username = $('#order_username').val();
            param.order_phone = $('#order_phone').val();
            param.unitPrice =parseFloat('<%=RM.Price1 %>');
            param.order_room_count = parseInt($('#order_room_count').val());
            param.totalPrice = parseFloat($('#total_money').html());
            param.Content = $('#order_others').val();
            $('#submit_button1').attr('disable','disable');
            dx177.WebUI.web.hotelorder.order.SubmitHotelOrder(param, SubmitHotelOrderCallBack);
        }
        function SubmitHotelOrderCallBack(res) {                       
            if (res.value.IsRegister)
            {
                alert("酒店预定成功。立即查看订单状态！稍后客服人员将会和你确认信息。");
                location.href = '/member-orders.aspx';
            }
            else
            {
                alert("酒店预定成功。稍后客服人员将会和你确认信息。");
                location.href = '/';
                
            }
            
        }
        
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="info_top" style="height: 100px; overflow: hidden;">
            <div style="float: left; width: 950px;">
                <div class="info_top_right">
                </div>
                <ul id="ul_top_mes" style="width: 420px; height: 115px; overflow: hidden;">
                    <li class="f7f7f7f">房款到店后支付，旺季或店家要求提前支付除外</li>
                    <li style="font-family: 黑体; color: #FF8000; font-size: 18px; margin-top: 30px;">&nbsp;</li>
                </ul>
            </div>
        </div>
        <div class="info">
            <div class="info_jd">
                <span class="step1_red">1. 填写订单信息</span><span class="red_gray"></span><span class="step2">2.
                    等待客服核实确认</span></div>
            <ul>
                <li><span class="info2_top_title">客房名称</span> <span class="info2_top_title3">选择入住日期</span>
                    <span class="info2_top_title2">首日单价(元)</span> <span class="info2_top_title2">间数</span><span
                        class="info2_top_title2">总计(元)</span> </li>
                <li class="room_info">
                    <div class="room_info_img">
                        <a href="#">
                            <img src="<%=RM.Logo %>" width="52" height="52" />
                        </a>
                    </div>
                    <div class="room_detail">
                        &nbsp;&nbsp;<a href="#" class="f3366cc"><%=RM.Roomtitle %></a><br />
                        &nbsp;&nbsp;<a href="/hotel_<%=HT.Seqno %>.html" target="_blank"><%=HT.Name %></a>
                    </div>
                    <span class="info_order_date" style="border-right: 0px;">&nbsp;入住时间：<input type="text"
                        class="text" name="start_date" id="start_date" value="" onchange="ajaxFormSubmit();"
                        onfocus="WdatePicker({onpicked:function(){end_date.focus();},doubleCalendar:false,minDate:'%y-%M-%d',maxDate:'%y-%M-{%d+30}'})"
                        readonly="readonly" size="10" /></span> <span class="info_order_date" style="border-left: 0px;">
                            &nbsp;离店时间：<input type="text" class="text" size="10" name="end_date" id="end_date"
                                readonly="readonly" value="" onchange="ajaxFormSubmit();" onfocus="WdatePicker({doubleCalendar:false,minDate:'#F{$dp.$D(\'start_date\',{d:1})}'})" /></span>
                    <span class="unit_price" id="unit_price">
                        <%=RM.Price1 %>
                    </span><span class="unit_total">
                        <select name="order_room_count" id="order_room_count" onchange="changeRooms(this.value)">
                            <option value="1" selected="selected">1</option>
                            <option value="2">2</option>
                            <option value="3">3</option>
                            <option value="4">4</option>
                            <option value="5">5</option>
                            <option value="6">6</option>
                            <option value="7">7</option>
                            <option value="8">8</option>
                            <option value="9">9</option>
                            <option value="10">10</option>
                            <option value="11">11</option>
                            <option value="12">12</option>
                        </select>
                    </span><span class="total_price fff5500" id="total_money2"></span></li>
                <li class="h20">&nbsp;</li>
            </ul>
            <div style="float: left; width: 910px; padding-bottom: 10px;">
                <div class="roomprice" id="roomprice">
                    <%--<ul>
                        <li class="li_th">03-29</li>
                        <li>320元</li>
                    </ul>
                    <ul>
                        <li class="li_th">03-29</li>
                        <li>320元</li>
                    </ul>
                    <ul>
                        <li class="li_th">03-29</li>
                        <li>320元</li>
                    </ul>--%>
                </div>
                <div class="clear">
                </div>
                <div class="alarm" id="alarm" style="display: ">
                    <b>节假日价格和平时价有不同，节假日价钱会更高一点，但网上预定，会更加优惠</b>
                </div>
                <div class="alarm" id="alarm3">
                    <b>请不要预订1个月以后的客房，如需预定请和我们的客户人员联系！</b></div>
            </div>
        </div>
        <div class="info2">
            <div class="info_form">
                <dl class="gtitle">
                    <dt class="dw100 info_top_title">入住人信息</dt><dt class="dw700" style="color: #A8A8A8">
                        入住人指实际到店入住者</dt></dl>
                <dl class="gtitle">
                    <dt class="dw100">入住人姓名：</dt><dt class="dw700"><span class="red">*</span><input type="text"
                        class="text" onblur="if($('#order_username').val()=='')$('#order_username').val($(this).val())"
                        value='<%=RU !=null ? RU.Name : ""%>' id="order_person_name" /></dt></dl>
                <dl class="gtitle">
                    <dt class="dw100">手机：</dt><dt class="dw700"><span class="red">*</span><input type="text"
                        class="text" onblur="if($('#order_phone').val()=='')$('#order_phone').val($(this).val())"
                        value='<%=RU !=null ? RU.Mobile : "" %>' id="order_person_phone" /><span class="f7f7f7f"></span></dt></dl>
                <dl class="gtitle">
                    <dt class="dw100 info_top_title">联系人信息</dt><dt class="dw700" style="color: #A8A8A8">
                        联系人指预订及确认订单者</dt></dl>
                <dl class="gtitle">
                    <dt class="dw100">联系人姓名：</dt><dt class="dw700"><span class="red">*</span><input type="text"
                        value='<%=RU !=null ? RU.Name : ""  %>' class="text" name="order_username" id="order_username" /></dt></dl>
                <dl class="gtitle">
                    <dt class="dw100">手机：</dt><dt class="dw700"><span class="red">*</span><input type="text"
                        value='<%=RU !=null ? RU.Mobile : ""  %>' class="text" name="order_phone" id="order_phone" /><span
                            class="f7f7f7f"></span></dt></dl>
                <dl class="gtitle">
                    <dt class="dw100 info_top_title">其他信息</dt><dt class="dw700" style="color: #A8A8A8">
                        最晚到店时间指您预计最晚到达酒店的时间</dt></dl>
                <dl class="gtitle">
                    <dt class="dw100">最晚到店时间：</dt><dt class="dw700"><span class="red">*</span><select
                        name="order_intime" id="InTime">
                        <option value=""></option>
                        <option value="1:00">1:00</option>
                        <option value="2:00">2:00</option>
                        <option value="3:00">3:00</option>
                        <option value="4:00">4:00</option>
                        <option value="5:00">5:00</option>
                        <option value="6:00">6:00</option>
                        <option value="7:00">7:00</option>
                        <option value="8:00">8:00</option>
                        <option value="9:00">9:00</option>
                        <option value="10:00">10:00</option>
                        <option value="11:00">11:00</option>
                        <option value="12:00">12:00</option>
                        <option value="13:00">13:00</option>
                        <option value="14:00">14:00</option>
                        <option value="15:00">15:00</option>
                        <option value="16:00">16:00</option>
                        <option value="17:00">17:00</option>
                        <option value="18:00">18:00</option>
                        <option value="19:00">19:00</option>
                        <option value="20:00">20:00</option>
                        <option value="21:00">21:00</option>
                        <option value="22:00">22:00</option>
                        <option value="23:00">23:00</option>
                        <option value="24:00">24:00</option>
                    </select>
                    </dt>
                </dl>
                <dl class="gtitle" style="height: 80px;">
                    <dt class="dw100">其他要求：</dt><dt class="dw700"><textarea name="order_others" cols="50"
                        rows="3" class="text"></textarea></dt></dl>
            </div>
        </div>
        <div class="info3">
            总房款：<span class="fff5500"><b id="total_money">0</b>元<span style="font-size: 12px;
                font-weight: normal;"> ［总天数：<b id="total_days">0</b>天，总间数：<b id="total_rooms">0</b>间］</span></span><span
                    class="f7f7f7f f12"> ( 房款到店后支付，旺季或店家要求提前支付除外 )</span>
        </div>
    </div>
    <div class="submit_div">
        <input type="button" name="submit_button"  id='submit_button1' value="" onclick="return submitHotelOrder();"
            class="submit_button" />
   <%--     <span style="float: left; width: 500px; height: 26px; line-height: 26px; margin-top: 26px;"
            class="f7f7f7f">查看<a href="http://www.becod.com/about/notes.html" target="_blank"
                style="color: #3366CC; text-decoration: underline;">预订帮助</a></span> --%> </div>
</asp:Content>
