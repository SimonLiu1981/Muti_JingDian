$(document).ready(function() {
    //设置加减的样式
    $('#cartItems .numadjust').hover(function() { jQuery(this).addClass('active') }, function() { jQuery(this).removeClass('active') });
    $('#cart-index .cart-product-img').each(function(i) {
        var isrc = $(this).attr('isrc');
        $(this).children('img').attr("src", isrc);
        //                    $(this).children('img').hover(function() {
        //                        this.style.width = "150px";
        //                        this.style.height = "150px";
        //                    },
        //                                function() {
        //                                    this.style.width = "50px";
        //                                    this.style.height = "50px";
        //                                });
    });
    //增加事件
    $('#cartItems .Numinput .increase').bind('click', function() {
        var i = parseInt($(this).parent('.Numinput').children('._x_ipt').val());
        $(this).parent('.Numinput').children('._x_ipt').val(i + 1);
        $(this).parent('div').parent('td').parent('tr').attr('number', i + 1);
        var productId = $(this).parent('div').parent('td').parent('tr').attr('productId');
        var productNumber = $(this).parent('div').parent('td').parent('tr').attr('number');
        UpdateProductNumber(productId, productNumber);

    });
    //减少事件
    $('#cartItems .Numinput .decrease').bind('click', function() {
        var i = parseInt($(this).parent('.Numinput').children('._x_ipt').val());
        if (i - 1 > 0) {
            $(this).parent('.Numinput').children('._x_ipt').val(i - 1);
            $(this).parent('div').parent('td').parent('tr').attr('number', i - 1);
            var productId = $(this).parent('div').parent('td').parent('tr').attr('productId');
            var productNumber = $(this).parent('div').parent('td').parent('tr').attr('number');
            UpdateProductNumber(productId, productNumber);
        }
    });
    
    ReShowCartItem(); 
});
function checkInputNum(intput1) {
    if (/[^\d]/.test($(intput1).val()) || parseInt($(intput1).val()) <= 0) {
        alert("请录入大于0的整数");
        $(intput1).val($(intput1).parent('div').parent('td').parent('tr').attr('number'));
        $(intput1).focus();
        return false;
    }
    $(intput1).parent('div').parent('td').parent('tr').attr('number', intput1.value);
    var productId = $(intput1).parent('div').parent('td').parent('tr').attr('productId');
    var productNumber = $(intput1).parent('div').parent('td').parent('tr').attr('number');
    UpdateProductNumber(productId, productNumber);
}

function UpdateProductNumber(prodectId, productNumber) {
    $.getJSON("/User/AjaxHandler.aspx?MethodName=UpdateProductNum&jsoncallback=?",
			        { 'productId': prodectId, 'num': productNumber },
                    function(json) {
                        try {
                            $("#itemTotal_" + prodectId).html(json.Total.toFixed(2) + '');
                            $('#my_shop_price_All').html(json.TotalAmount.toFixed(2) + '');
                        }
                        catch (ex) {
                            window.location = window.location;
                        }
                    });
                }

function ClearCart() {
    if (confirm('你确定要清除购物车里的产品吗？')) {
        $.getJSON("/User/AjaxHandler.aspx?MethodName=ClearCart&jsoncallback=?",
					function(json) {
					    try {
					        $('#cartItems table tr').each(function() {
					            if (this.id.indexOf('my_car_ul_') != -1) {
					                $(this).remove();
					            }
					        });
					        $('#my_shop_price_All').html(json.TotalAmount.toFixed(2) + '');
					        ReShowCartItem();
					    }
					    catch (ex) {
					        window.location = window.location;
					    }
					});
    }
}

function ReShowCartItem() {
     
    if ($('#tr_clear_cart_info').parent('tbody').children('tr').length > 1) {
        $('#tr_clear_cart_info').hide();
    }
    else {
        $('#tr_clear_cart_info').show();
    }
}

function checkCarCount() {
    if (parseFloat($('#my_shop_price_All').html()) == 0) {
        alert("购物车的产品不能为空！");
        return false;
    }
    window.location = 'CarCheck.aspx?r=~/ShoppingCar/MyShopCarList.aspx'
}
function DeleProduct(productId) {
    if (confirm('你确定要将所选产品从购物车里删除吗？')) {
        $.getJSON("/User/AjaxHandler.aspx?MethodName=DelProduct&jsoncallback=?",
					{ 'productId': productId },
					function(json) {
					    try {
					        $('#my_car_ul_' + productId).remove();
					        $('#my_shop_price_All').html(json.TotalAmount.toFixed(2));
					        if (json.TotalAmount == 0) {
					            $('#tr_clear_cart_info').show();
					        }
					        else {
					            $('#tr_clear_cart_info').hide();
					        }
					    }
					    catch (ex) {
					        window.location = window.location;
					    }
					});
    }
}

this.imagePreview1 = function() {
    /* CONFIG */

    xOffset = 10;
    yOffset = 30;

    // these 2 variable determine popup's distance from the cursor
    // you might want to adjust to get the right result

    /* END CONFIG */
    $("img.preview_img").hover(function(e) {
       
        this.t = this.title;
        this.title = "";
        var c = (this.t != "") ? "<br/>" + this.t : "";
        $("body").append("<p id='preview_img'><img src='" + this.toop_img + "' alt='Image preview' />" + c + "</p>");
        $("#preview_img")
			.css("top", (e.pageY - xOffset) + "px")
			.css("left", (e.pageX + yOffset) + "px")
			.fadeIn(400);
    },
	function() {
	    this.title = this.t;
	    $("#preview_img").remove();
	});
    $("img.preview_img").mousemove(function(e) {
        $("#preview_img")
			.css("top", (e.pageY - xOffset) + "px")
			.css("left", (e.pageX + yOffset) + "px");
    });
};
// starting the script on page load
$(document).ready(function() {
    imagePreview1();
});