
function isIp(ip) {

    var re = /^(\d+)\.(\d+)\.(\d+)\.(\d+)$/g;

    if (re.test(ip)) {
        if (RegExp.$1 < 256 && RegExp.$2 < 256 && RegExp.$3 < 256 && RegExp.$4 < 256) {
            return true;
        }
    }
    alert(ip + "不是一个有效的IP地址");
    return false;

}
function isEmail(strEmail,msg) {     
    var myReg = /^[-_A-Za-z0-9]+@([_A-Za-z0-9]+\.)+[A-Za-z0-9]{2,3}$/;    
    if (myReg.test(strEmail)) {        
        return true;
    }
   
    if (msg != null ) {
        if (msg != '') alert(msg);
    }
    else {
        alert(strEmail + "不是邮件地址！");
    }
    
    return false;
}

function isPhone(num) {
    if (/^(\d{7,13}|\d{7,13}-\d{3,4})$/.test(num) == false) {
        alert(num + "不是合法的电话号码");
        return false;
    }
    return true;
}


function isMobile(num) {
    if (/^[1][2345678][0-9]{9}$/.test(num) == false) {
        alert(num + "不是合法的手机号码");
        return false;
    }
    return true;
}

function isWww(ptah) {
    var correcUrl = /^[A-Za-z0-9]+\.[A-Za-z0-9]+[\/=\?%\-&_~`@[\]\':+!]*([^<>\"\"])*$/;
    if (!correcUrl.exec(ptah)) {
        alert(ptah + "不是合法的网址");
        return false;
    }
    return true;
}

function isNumeric(strValue, msg) {
    var objExp = /(^-?\d\d*\.\d*$)|(^-?\d\d*$)|(^-?\.\d\d*$)/;
    if (!objExp.exec(strValue)) {
        
        if (msg != null) {
            if (msg != '') {
                alert(msg);
            }
        }
        else {
            alert(strValue + "不是数字！");
        }    
        return false;
    }
    return true;
} 


function isInteger(num,msg) {
    var correcUrl = /^\d+$/;
    if (!correcUrl.exec(num)) {

        if (msg != null && msg != '') {
            alert(msg);
        }
        else {
            alert(strValue + "不是整数！");
        }
         
        return false;
    }
    return true;
}

function isMoney(num,msg) {
    var correcUrl = /^(([1-9]\d*)|0)(\.\d{1,2})?$/;
    if (!correcUrl.exec(num)) {
        if (msg != null) {
            alert(msg);
        }
        else {
            alert(strValue + "不是金额格式！");
        }       
        return false;
    }
    return true;
}

function timeRunner() {
    return Math.round(new Date().getTime() / 1000);
}