$(document).ready(function () {

	var h1=["натуральнІ маски <br>для обличчя","Длинный заголовок <br> два","просто заголовок", "Длинный заголовок <br> три" ]
	var h1count=0;
	var p1=["Якщо ви збираєтесь використовувати Lorem Ipsum, ви <br> маєте упевнитись в тому, що всередині тексту не <br> приховано нічого, могло б викликати у читача конфуз. <br> Більшість відомих генераторів.", "Якщо ви збираєтесь використовувати Lorem Ipsum, ви <br> маєте упевнитись в тому, що всередині тексту не <br>приховано нічого, могло б викликати ","Якщо ви збираєтесь використовувати Lorem Ipsum, ви <br> маєте упевнитись в тому, що всередині тексту не <br> приховано нічого, могло б викликати у читача конфуз. <br> Більшість відомих генераторів.","Якщо ви збираєтесь використовувати Lorem Ipsum, ви <br> маєте упевнитись в тому, що всередині тексту не <br>приховано нічого, могло б викликати "]
    
    $(".slider_button_right").click(function () { 
    	$(".slider-content-h1").fadeOut(300);
    	$(".slider-content-p").fadeOut(300);
    	h1count++
    	if(h1count==4)
    		h1count=0;
    	$(".slider-content-h1").html(h1[h1count]);
    	$(".slider-content-p").html(p1[h1count]);

    	$(".slider-content-h1").fadeIn(100);	
    	$(".slider-content-p").fadeIn(100);	
    	 });
    $(".slider_button_left").click(function () { 

    	$(".slider-content-h1").fadeOut();
    	$(".slider-content-p").fadeOut();
    	h1count--
    	if(h1count==-1)
    		h1count=3;
    	$(".slider-content-h1").html(h1[h1count]);
    	$(".slider-content-p").html(p1[h1count]);

    	$(".slider-content-h1").fadeIn();	
    	$(".slider-content-p").fadeIn();	
    	 });
});