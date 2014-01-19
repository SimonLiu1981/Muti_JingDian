<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewOrder.aspx.cs" Inherits="dx177.WebUI.web.hotelorder.NewOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>丹霞旅游订房_丹霞住宿_丹霞自助游_丹霞山自由行_丹霞特产---游丹霞山</title>
        <link href="/css/layout.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript" src="/js/jquery.min.js"></script>
    <style>
        body
        {
            margin: 0 auto;
            font-size: 12px;
            font-family: Verdana;
            line-height: 1.5;
        }
        ul, dl, dd, h1, h2, h3, h4, h5, h6, form, p
        {
            padding: 0;
            margin: 0;
        }
        h4
        {
            font-size: 12px;
        }
        ul
        {
            list-style: none;
        }
        img
        {
            border: 0px;
        }
        a
        {
            color: #195cb5;
            text-decoration: none;
        }
        a:hover
        {
            color: #f00;
        }
        select
        {
            height: 21px;
        }
        #layout
        {
            width: 950px;
            margin: 0 auto;
        }
        .ebook
        {
            border: 1px solid #ccc;
            margin-bottom: 8px;
        }
        .ebook h2
        {
            height: 24px;
            padding: 4px 12px 0 12px;
            background: #eee;
            border-top: 1px solid #fff;
            border-left: 1px solid #fff;
            border-bottom: 1px solid #ccc;
            font-size: 14px;
            color: #333;
        }
        #layout
        {
            width: 950px;
        }
        .ebook
        {
            border: 1px solid #aacbee;
        }
        .ebook h2
        {
            background: #e0f5fc;
            border-bottom: 1px solid #aacbee;
            color: #295574;
        }
        .ebook h2 span
        {
            float: right;
            font-weight: normal;
            font-size: 12px;
        }
        .yuding
        {
            padding: 10px 40px 10px 20px;
            color: #222;
        }
        .yuding dl
        {
            padding: 4px 0px;
            overflow: auto;
            zoom: 1;
        }
        .yuding dl dt
        {
            float: left;
            width: 110px;
            padding-top: 3px;
            font-weight: bold;
            text-align: right;
            line-height: 1.3;
        }
        .yuding dl dd
        {
            margin-left: 115px;
            color: #666;
        }
        #yuding_tianshu
        {
            padding: 6px 0px 6px 115px;
        }
        #yuding_tianshu table
        {
            margin-bottom: 6px;
        }
        .yuding_ts
        {
            border-collapse: collapse;
        }
        .yuding_ts td
        {
            border: 1px solid #fc6;
            text-align: center;
            width: 100px;
            line-height: 200%;
        }
        .yuding_ts td h4
        {
            background: #fff3c3;
            border-bottom: 1px solid #fc6;
            padding: 0;
            margin: 0;
        }
        .yd_info
        {
            padding: 8px 0;
        }
        .yuding_next
        {
            padding: 0 0px 15px 136px;
        }
        .btn
        {
            width: 107px;
            height: 28px;
            border: none;
            background: url(/img/btn_bg.gif) 0 0 no-repeat;
            color: #fff;
            font-size: 16px;
            font-weight: bold;
            cursor: pointer;
        }
        .ordersave
        {
            list-style: disc inside;
            padding: 10px 30px 10px 70px;
            color: #333;
        }
        .ordersave li
        {
            padding: 2px 0px;
            clear: both;
        }
        .ordersave1
        {
            margin: 0px 70px 15px 70px;
            border: 1px solid #fc6;
            padding: 5px 10px;
            background: #ffffe8;
        }
        .ordersave1 ul
        {
            line-height: 200%;
        }
        .f_12_f00
        {
            color: #f00;
        }
        .f_14b_f60
        {
            color: #f60;
            font-size: 14px;
            font-weight: bold;
        }
        .f_f00
        {
            color: #933;
        }
        .danbao
        {
            border-top: 1px solid #d0dae4;
        }
        .guangao
        {
            height: 48px;
            padding-top: 10px;
            border: 1px #CCCCCC solid;
        }
        .guangao
        {
            border: 1px solid #aacbee;
        }
        .guangao ul li
        {
            float: left;
            width: 25%;
            text-align: center;
        }
        #footer
        {
            background: url(/img/footer_bg.gif) 0 0 repeat-x;
            padding: 12px 0;
            text-align: center;
            margin-top: 2px;
            color: #666;
        }
        .errMsg
        {
            background-color: #FF9;
            border: 1px solid #F30;
            width: 600px;
            height: 30px;
            line-height: 30px;
            text-align: center;
            margin-bottom: 10px;
        }
        .blink
        {
            background-color: #ff0;
        }
        .tel
        {
            font-family: Georgia, "Times New Roman" , Times, serif;
            font-weight: bold;
            color: #F30;
        }
    </style>

    <script type="text/javascript" src="/ajaxpro/prototype.ashx"></script>

    <script type="text/javascript" src="/ajaxpro/core.ashx"></script>

    <script type="text/javascript" src="/ajaxpro/converter.ashx"></script>

    <script type="text/javascript" src="/ajaxpro/dx177.WebUI.web.hotelorder.NewOrder,dx177.WebUI.ashx"></script>

    <script src="/Plugin/Jquery.tools/jquery.tools.min.js" type="text/javascript"></script>

    <script src="/js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    <script type="text/javascript">
        function ajaxFormSubmit() {
            var start_date = $('#start_date').val();
            var end_date = $('#end_date').val();
            var unitPrice = parseFloat('<%=RM.Price1 %>');
            var unitPrice1 = parseFloat('<%= RM.Price2 %>');
            var roomCount = parseInt($('#order_room_count').val());
            var Guid='<%=RM.Guid %>';
            dx177.WebUI.web.hotelorder.NewOrder.GetCostList(start_date, end_date, roomCount, unitPrice,unitPrice1,Guid , GetCostListCallBack);
        }

        function GetCostListCallBack(res) {
            $('#total_money2').html(res.value.TotalPrice);
            $('#total_days').html(res.value.Days);
            $('#total_money').html(res.value.TotalPrice);
            $('#total_rooms').html($('#order_room_count').val());

            var roompricehtml = '';
            for (var i = 0; i < res.value.RoomCostList.length; i++) {
                var tmp = res.value.RoomCostList[i];
                roompricehtml += '<td><h4>' + tmp.DateString + '</h4>' +
                                   '' + tmp.MoneyString + '元</td>'   ;
        
            }
            
            roompricehtml="<table class='yuding_ts' cellspacing='0' cellpadding='0' border='0'><tr>"+roompricehtml+"</tr>" ;
             
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
            param.Roomtitle = '<%=RM.Roomtitle %>';
            param.HotelSeqno = <%=HT.Seqno %>;
            param.Issendorderemail= <%=HT.Issendorderemail %>;
            param.Email = '<%=HT.Email %>';
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
            param.totalPrice = parseFloat($('#total_money2').html());
            param.Content = $('#order_others').val();
            $('#submit_button1').attr('disable','disable');
            dx177.WebUI.web.hotelorder.NewOrder.SubmitHotelOrder(param, SubmitHotelOrderCallBack);
        }
        function SubmitHotelOrderCallBack(res) {                       
            if (res.value.IsRegister)
            {
                alert('<%=OrderAlertDescr%>');
                location.href = '/member-orders.aspx';
            }
            else
            {
                alert('<%=OrderAlertDescr%>' );
                location.href = '/index.html';
                
            }
            
        }
        
    </script>

</head>
<body>
    <div id="top">
        <div id="top_con">
            <span> </span> 
            <em> 
            </em>
        </div>
    </div>
    <div id="container">
        <div id="header">
            <div id="logo">
                <a href="/">
                    <img alt="游丹霞山" src="/img/logo.gif" /></a></div>
            <div id="header_ad">
                <div class="">
                    <a href="#" target="_blank" title="酒店广告">
                        <img width="658" height="60" src="/img/top_ad.gif" border="0" alt="酒店广告" /></a></div>
            </div>
        </div>
        <div class="clearfloat">
        </div>
        <div id="nav">
            <ul>
                   <li><a href="/index.html">首 页</a></li>
                <li><a href="/hotel_list_all_1.html">酒店预订</a></li>
                 <li><a href="/product_listall_1.html">丹霞特产</a></li>
                <li><a href="/hotel_ask_1.html">酒店问答</a></li>
                <li><a href="/questionlistAll_1.html">问题解答</a></li>
                <li><a href="/NewsTypeLYGL_1.html">丹霞攻略</a></li>
                <li><a href="/NewsTypeJQDT_1.html">景区动态</a></li>
               
                <li><a href="/sites_listall_1.html">丹霞风景</a></li>
                <li><a href="/iss_contact.html">联系我们</a></li>
                <li><a href="/iss_need.html">订房须知</a></li>
                <li><a href="#">帮助中心</a></li>
            </ul>
        </div>
     
    <form id="form1" runat="server">
    <div id="layout">
        <div class="ebook" id="eb1">
            <h2>
                确认客房信息</h2>
            <div class="yuding">
                <dl>
                    <dt>
                        <label>
                            预订酒店：</label>
                    </dt>
                    <dd>
                        <span style='line-height: 170%;' class='f_14b_f60' id='_hotelname'><a href="/hotel_<%=HT.Seqno %>.html"
                            target="_blank">
                            <%=HT.Name %></a> </span>
                    </dd>
                </dl>
                <dl>
                    <dt>
                        <label>
                            房间类型：</label>
                    </dt>
                    <dd>
                        <%=RM.Roomtitle %>
                    </dd>
                </dl>
                <dl>
                    <dt>
                        <label>
                            入住日期：</label>
                    </dt>
                    <dd style="color: #333;">
                        <input type="text" class="text" name="start_date" id="start_date" value="" onchange="ajaxFormSubmit();"
                            onfocus="WdatePicker({onpicked:function(){end_date.focus();},doubleCalendar:false,minDate:'%y-%M-%d',maxDate:'%y-%M-{%d+30}'})"
                            readonly="readonly" size="10" />
                        <strong>离店日期： </strong>
                        <input type="text" class="text" size="10" name="end_date" id="end_date" readonly="readonly"
                            value="" onchange="ajaxFormSubmit();" onfocus="WdatePicker({doubleCalendar:false,minDate:'#F{$dp.$D(\'start_date\',{d:1})}'})" />
                        <strong>预订间数： </strong>
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
                    </dd>
                </dl>
                <dl>
                    <div id="yuding_tianshu">
                        <table cellspacing="0" cellpadding="0" border="0" class="yuding_ts">
                            <tbody id="_rate">
                            </tbody>
                        </table>
                        <div class="roomprice" id="roomprice">
                        </div>
                    </div>
                    <dt>
                        <label>
                            酒店提示：</label>
                    </dt>
                    <dd>
                        房费包含酒店服务费，不包含酒店其他费用、税收及客人额外要求费用。
                        <p style="padding-right: 0px; padding-left: 0px; font-weight: bold; font-size: 14px;
                            padding-bottom: 10px; padding-top: 10px">
                            总天数：<span class="f_14b_f60"><font color="#ff6600"> <b id="total_days">0</b>天</font></span>
                            房间数：<span class="f_14b_f60"><font color="#ff6600"> <b id="total_rooms">0</b> 间</font></span>
                            房价合计：<span class="f_14b_f60"><font color="#ff6600">RMB<span class="total_price fff5500"
                                id="total_money2"></span></font></span>（前台现付）</p>
                    </dd>
                </dl>
            </div>
        </div>
        <div class="ebook">
            <h2>
                填写住店信息</h2>
            <div class="yuding">
                <dl>
                    <dt>
                        <label>
                            <span class="f_12_f00">*</span>入住人姓名：</label>
                    </dt>
                    <dd id="guesters">
                        <input type="text"
                        value='<%=RU !=null ? RU.Name : ""  %>' class="text" name="order_username" id="order_username" />
                    </dd>
                </dl>
                <dl>
                    <dd>
                        请分别填写房间入住人姓名，如果多人入住同一客房，请用‘/’隔开，如 ‘张三/李四’；</dd>
                    <dd>
                        为避免耽误您的行程，请务必保证所提供的入住人姓名与入住时所持证件上的姓名一致。</dd></dl>
                <dl>
                    <dt>
                        <label>
                            <span class="f_12_f00">*</span>联系人：</label>
                    </dt>
                    <dd>
                        <input type="text" style="width: 120px;" name="c_name" />
                        <span style="color: #333;"><span class="f_12_f00">*</span><strong>手机号：</strong></span>
                        <input type="text"
                        class="text" onblur="if($('#order_phone').val()=='')$('#order_phone').val($(this).val())"
                        value='<%=RU !=null ? RU.Mobile : "" %>' id="order_person_phone" />
                        <span style="color: #333;"><strong>电子邮件：</strong></span>
                        <input style="width: 150px;" id="c_email" name="c_email" />
                    </dd>
                </dl>
                 
                <dl>
                    <dt>
                        <label>
                            <span class="f_12_f00">*</span>最晚到店时间：</label>
                    </dt>
                    <dd>
                        <select
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
                        
                    </dd>
                </dl>
                <dl>
                    <dt>
                        <label>
                            特殊要求：</label>
                    </dt>
                    <dd>
                        (如有特殊要求请输入，我们会与酒店确认，但因酒店原因不能保证实现，或酒店可能额外收费)</dd>
                </dl>
                <dl>
                    <dt>
                        <label>
                        </label>
                    </dt>
                    <dd>
                        <textarea name="order_others" cols="50"
                        rows="3" class="text"></textarea>
                    </dd>
                </dl>
                          <dl>
                    <dt>
                        <label>
                        </label>
                    </dt>
                    <dd>
                    <div style='display:<%=ButtonStyle%>' >
             
                        <input   name="submit_button"  id='submit_button1'  onclick="return submitHotelOrder();" type="button" value="提 交" />
                        </div>
                          <br ><%=OrderButtonDescr%>
                        </dd>
              
                      
                </dl>
                
                 
            </div>
          
       
    </form>
   
        <div id="footer">
            
            <p>
               版权：游丹霞山 Copyright 2009-2010 Corporation, All Rights Reserved
                <br>
                  本网站与和丹霞山当地上百家酒店、宾馆、旅店、餐厅及相关的旅游服务单位合作.
                  <br>
                  欢迎旅游团队与本网站合作！
            </p>
               <script language="javascript" type="text/javascript" src="http://js.users.51.la/4764325.js"></script>

        </div>
 
    </div>
</body>
</html>

 
