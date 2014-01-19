// JavaScript Document
var _v1=null,dn=0,tb1='',wks='',d,hotels=null,n1=0,agent_id=0,_hid='',_tm1='',_tm2='',_fid=0,_timer1=null,reNum=0, _islistpage=0, _hasdata=false;
if(window.location.hostname=='hotel.nanjings.com'){window.location='http://www.zhuna.cn';}
function loadPrice(islistpage, hid,tm1,tm2,fid){
    if (typeof (hid) != 'undefined') { _hid = hid; } if (typeof (tm1) != 'undefined') { _tm1 = tm1; } if (typeof (tm2) != 'undefined') { _tm2 = tm2; } if (typeof (fid) != 'undefined') { _fid = fid; }
    if (typeof (islistpage) != 'undefined') { _islistpage = islistpage; }
    var ids = _hid.split(',');
    for (var i = 0; i < ids.length; i++) {
        if (_g('h' + ids[i])) _g('h' + ids[i]).innerHTML = '<img src="http://www.api.zhuna.cn/price/default/loading.gif" alt="加载中"  style="padding:15px;" />';
    }
    $.ajax({
        type: "GET",
        url: "/js/ZhunaAPI/hotelprice.aspx?hid=" + _hid + "&tm1=" + _tm1 + "&tm2=" + _tm2 + "&orderfrom=" + _fid + "&callback=?",

        dataType: "json",
        timeout: 5000,
        error: function(XMLHttpRequest, textStatus, errorThrown) {
            _jsout();
        },
        success: function(msg) {
            if (msg.error) {                
                _jsout();
                return;
            }             
            callback(msg);
        }
    });
}

function _jsout() {
    if (!_hasdata) {
        if (reNum < 5) { reNum++; loadPrice(); return; }
        var ids = _hid.split(','), isv = false;
        for (var i = 0; i < ids.length; i++) {
            isv = true;
            if (_g('h' + ids[i])) _g('h' + ids[i]).innerHTML = '<div style="background-color:#FF9; border:1px solid #F30; width:500px; height:30px; line-height:30px; text-align:center; margin-bottom:10px ;height:40px; line-height:40px; color:#f30" > 在查询实时房态信息过程中出现异常!请<a href="javascript:loadPrice()">重试</a></div>';
        }
    }    
	reNum=0;
}

function dobook(jqcode, hid, rid, pid) {
    var url = '/JQ_'+ jqcode +'/hotelorder?';
    url += 'hid=' + hid;
    url += '&rid=' + rid;
    url += '&pid=' + pid;
    url += '&tm1=' + $('#tm1').val();
    url += '&tm2=' + $('#tm2').val();
    window.location = url;
}

function callback(jsData) {
    _hasdata = true;
    var _Hide = true; hotels = jsData; if (hotels.length == 1) { _Hide = false }; for (k in hotels) { vhotel(hotels[k], _Hide); }
}
function RefreshHotel(hid,Hide){var k;for(k in hotels){if(hotels[k].zid==hid){vhotel(hotels[k],Hide);return;}}}
//get plans 
function gPlan(a,b,c){
	for(var k=0;k<hotels.length;k++){
		if(hotels[k].zid==a){
			for(var m=0;m<hotels[k].rooms.length;m++){
				if(hotels[k].rooms[m].rid==b){
					for(var n=0;n<hotels[k].rooms[m].plans.length;n++){
						if(hotels[k].rooms[m].plans[n].planid==c){
							return hotels[k].rooms[m].plans[n];
						}
					}
					return null;
				}
			}
			return null;
		}
	}
	return null;
}
//hotel room
function vhotel(hotel, Hide) {
   
	var ar_tm1=hotel.tm1.split('-');
	if(dn==0){
		//table
		dn=DateDiff('d',sToDate(hotel.tm1),sToDate(hotel.tm2));
		var stm1=sToDate(hotel.tm1).format('MM\u6708dd\u65E5');
		var stm2=DateAdd('d',1,sToDate(hotel.tm1)).format('MM\u65E5dd\u65E5');
		if(dn<2){
			tb1='<div class="zn_row2">'+stm1+'</div>';
		}else if(dn==2){
			tb1='<div class="zn_row2">'+stm1+'</div><div class="zn_row3">'+stm2+'</div>';
		}else{
			tb1='<div class="zn_row2">'+stm1+'</div><div class="zn_row3">\u65E5\u5747\u4EF7</div>';
		}
		if(dn>2){
			for(var i=0;i<dn;i++){				
				 wks+='        <dt>'+DateAdd('d',i,sToDate(hotel.tm1)).format('EE')+'</dt>';
				 if(i>5)i=99999;
			}			
		}
	}	
	var	html='  <div class="zn_room">';
		html+='    <div class="zn_room_title">';		
		html+='      <div class="zn_row"><div class="zn_row8">\u8BF4\u660E</div><div class="zn_row1">\u95E8\u5E02\u4EF7</div>'+tb1+'<div class="zn_row6">\u5BBD\u5E26</div><div class="zn_row7">\u9884\u8BA2</div></div>';
		html+='      \u623F\u578B\u540D\u79F0';
		html+='    </div>';	
	var rNum=0;
	if(hotel.rooms){
		rNum=hotel.rooms.length;
	}else{
		html+='    <dl>\u6682\u65E0\u53EF\u9884\u8BA2\u623F\u578B</dl>';
	}
	for(var a=0;a<rNum;a++){
		var room=hotel.rooms[a],ico_cx='class="zn_ico_cx"';
		var _idv1='ri_'+room.rid;
		for(var b=0;b<room.plans.length;b++){
			var plan=room.plans[b];
			if(plan.description.Promotion){ico_cx='class="zn_ico_cx"';}else{ico_cx='zn_ico_cx1';}
			html+='<div class="zn_room_row">';			
			//均价
			var strPrice=''
			var sri=(plan.date[0])?plan.date[0].price:0;			
			if(dn<2){
				strPrice='';
			}else if(dn==2){
				var strPrice='<div class="zn_row3">'+plan.date[1].price+'\u5143</div>';
			}else if(plan.status!='0'){
				strPrice='<div class="zn_row3" onMouseOver="tips(this,\'v3\',\''+hotel.zid+'\',\''+room.rid+'\',\''+plan.planid+'\')"><a href="javascript:void(0)" >\u6709\u6EE1\u623F</a></div>';
			}else{
				var junjia=parseInt(plan.totalprice/plan.date.length);
				strPrice='<div class="zn_row3" onMouseOver="tips(this,\'v3\',\''+hotel.zid+'\',\''+room.rid+'\',\''+plan.planid+'\')"><a href="javascript:void(0)" >'+junjia+'\u5143</a></div>';
			}			
			html+='      <div class="zn_row"><div class="zn_row8" onMouseOver="tips(this,\'v1\',\''+hotel.zid+'\',\''+room.rid+'\',\''+plan.planid+'\')"><a href="javascript:void(0)" onclick="_display(\''+_idv1+'\');" '+ico_cx+'>'+plan.planname+'</a></div><div class="zn_row1"><del>'+plan.menshi+'</del>\u5143</div><div class="zn_row2">'+sri+'\u5143</div>'+strPrice+'<div class="zn_row6">'+room.adsl+'</div><div class="zn_row7">';
			if (plan.status == '0') {
			    html += '        <input type="button"value="\u9884\u8BA2" onclick="dobook(\'' + $('#h' + hotel.zid).attr('jq') + '\',\'' + hotel.zid + '\',\'' + room.rid + '\',\'' + plan.planid + '\')" class="zn_btn_yd"></div></div>';			
			     
			}else{
				html+='        <input type="button"value="\u6EE1\u623F" class="zn_btn_mf"></div></div>';
			}	
			if(b==0){				
				html+='      <a href="javascript:void(\''+_idv1+'\');" onclick="_display(\''+_idv1+'\');" class="zn_room_name">'+room.title+'</a>';
			}
			html+='    </div>';	
			if(Hide){b=9999;}
		}//for(b in room.plans)
		html+='    <div class="zn_room_info" id="'+_idv1+'">';
		html+='      <ul>';
		html+='        <li>\u623F\u578B：'+room.bed+'</li>';
		html+='        <li>\u697C\u5C42：'+room.floor+'</li>';
		html+='        <li>\u9762\u79EF：'+room.area+'</li>';
		if(room.notes)html+='<li style="width:99%;">\u8BF4\u660E\uFF1A'+room.notes+'</li>';
		html+='      </ul>';
		html+='    </div>';
		if(Hide&&a>1&&a<(hotel.rooms.length-1)){
			a=9999;
			html+='    <div class="zn_room_more">';
			html+='      <a class="zn_r_more" href="javascript:RefreshHotel('+hotel.zid+',false)">\u6240\u6709\u623F\u578B('+hotel.rooms.length+')</a>';
			html+='    </div>';
		}
	
	}//end for(a in hotel.rooms)
 	if(!Hide&&a>3&&a!=9999){
			html+='    <div class="zn_room_more">';
			html+='      <a class="zn_r_more1" href="javascript:RefreshHotel('+hotel.zid+',true)">\u6240\u6709\u623F\u578B('+hotel.rooms.length+')</a>';
			html+='    </div>';
	}
	html+='  </div>';
	if(_g('h'+hotel.zid))_g('h'+hotel.zid).innerHTML=html;
}
var mdiv=document.createElement("div"),timeOut=null;
function rmtips(){
	try {
		if(timeOut){window.clearTimeout(timeOut);timeOut=null}
		if(mdiv){document.body.removeChild(mdiv);}
	}catch(e){
		//alert(e);
	}
		
}
function ycrmtips(){
	window.clearTimeout(timeOut);
	timeOut=window.setTimeout('rmtips()',100);
}
//动态生成提示框
function tips(a,b,c,d,e){
	var html='',_plan=gPlan(c,d,e);;
	if(b=='v1'){
		mdiv.className='zn_room_tips';
		mdiv.style.width='400px';
		mdiv.style.left=(gL(a)-parseInt(mdiv.style.width)/2+15)+'px';		
			html+='<div class="zn_rt_con">';
		if(_plan.description.Promotion)
			html+='<p class="zn_rt_con_cx">'+_plan.description.Promotion+'</p>';
		if(_plan.description.GaranteeRule)
			html+='<p class="zn_rt_con_db">'+_plan.description.GaranteeRule+'</p>';
			html+='<p class="zn_rt_con_fj">\u652F\u4ED8\u65B9\u5F0F\uFF1A\u5230\u5E97\u4ED8\u6B3E';
		if(_plan.description.AddValues)
			html+='<br/>'+_plan.description.AddValues;
			html+='</p>';		
			html+='</div>';
	}else{		
		mdiv.className='zn_room_price';
		var width=(dn>7)?354:(dn*50+4);
		mdiv.style.width=width+'px';
		mdiv.style.left=(gL(a)-parseInt(mdiv.style.width)/2+30)+'px';
			html+='<dl>';
			html+=wks;
			for(c in _plan.date){
				var dt=_plan.date[c];
				html+='<dd>'+sToDate(dt.day).format('dd')+'\u65E5<em>'+dt.price+'\u5143</em></dd>';
			}	
			html+='</dl>';
	}
	mdiv.innerHTML=html;
	rmtips();		
	a.onmouseout=ycrmtips;
	document.body.appendChild(mdiv);	
	mdiv.style.top=(gT(a)+20)+'px';
}
function dps_Over(obj){
		obj.style.position='relative';
	var pts=obj.getElementsByTagName('div');
		pts[0].style.display='block';
}
function dps_Out(obj){
		obj.style.position='static';
	var pts=obj.getElementsByTagName('div');
		pts[0].style.display='none';
}

function _display(id){
	if(_g(id).style.display!='block'){_g(id).style.display='block'}else{_g(id).style.display='none'}
}
function _g(id){return document.getElementById(id)};
function gL(x){var l=0;while(x){l+=x.offsetLeft;x=x.offsetParent;}return l};
function gT(x){var t=0;while(x){t+=x.offsetTop;x=x.offsetParent;}return t};
function sToDate(d){var ds = d.toString().split("-");return (new Date(parseFloat(ds[0]),parseFloat(ds[1])-1,parseFloat(ds[2])))}
function DateAdd(interval,number,date){
    switch(interval.toLowerCase()){
        case "y": return new Date(date.setFullYear(date.getFullYear()+number));
        case "m": return new Date(date.setMonth(date.getMonth()+number));
        case "d": return new Date(date.setDate(date.getDate()+number));
        case "w": return new Date(date.setDate(date.getDate()+7*number));
        case "h": return new Date(date.setHours(date.getHours()+number));
        case "n": return new Date(date.setMinutes(date.getMinutes()+number));
        case "s": return new Date(date.setSeconds(date.getSeconds()+number));
        case "l": return new Date(date.setMilliseconds(date.getMilliseconds()+number));
    } 
}
function DateDiff(interval,date1,date2){
    var long = date2.getTime() - date1.getTime();
    switch(interval.toLowerCase()){
        case "y": return parseInt(date2.getFullYear() - date1.getFullYear());
        case "m": return parseInt((date2.getFullYear() - date1.getFullYear())*12 + (date2.getMonth()-date1.getMonth()));
        case "d": return parseInt(long/1000/60/60/24);
        case "w": return parseInt(long/1000/60/60/24/7);
        case "h": return parseInt(long/1000/60/60);
        case "n": return parseInt(long/1000/60);
        case "s": return parseInt(long/1000);
        case "l": return parseInt(long);
    }
}
Date.prototype.format=function(fmt) {         
    var o = {         
    "M+" : this.getMonth()+1,        
    "d+" : this.getDate(),        
    "h+" : this.getHours()%12 == 0 ? 12 : this.getHours()%12,      
    "H+" : this.getHours(),         
    "m+" : this.getMinutes(),        
    "s+" : this.getSeconds(),          
    "q+" : Math.floor((this.getMonth()+3)/3),       
    "S" : this.getMilliseconds()       
    };         
    var week = {         
    "0" : "\u65e5",         
    "1" : "\u4e00",         
    "2" : "\u4e8c",         
    "3" : "\u4e09",         
    "4" : "\u56db",         
    "5" : "\u4e94",         
    "6" : "\u516d"        
    };         
    if(/(y+)/.test(fmt)){         
        fmt=fmt.replace(RegExp.$1, (this.getFullYear()+"").substr(4 - RegExp.$1.length));         
    }         
    if(/(E+)/.test(fmt)){         
        fmt=fmt.replace(RegExp.$1, ((RegExp.$1.length>1) ? (RegExp.$1.length>2 ? "\u661f\u671f" : "\u5468") : "")+week[this.getDay()+""]);         
    }         
    for(var k in o){         
        if(new RegExp("("+ k +")").test(fmt)){         
            fmt = fmt.replace(RegExp.$1, (RegExp.$1.length==1) ? (o[k]) : (("00"+ o[k]).substr((""+ o[k]).length)));         
        }         
    }         
    return fmt;         
} 