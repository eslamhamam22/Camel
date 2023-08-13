jQuery(function () {
    setInterval(function () {
        jQuery("#home .overlay-bg").fadeOut("fast", function () {
            jQuery(this).css("background-image", "url(../images/bg-8-1.jpg)");
            jQuery(this).delay(500).fadeIn("fast");
        });
    }, 1000);
    
    $(".before-after-car-container[data-orientation!='vertical']").twentytwenty({default_offset_pct: 0.7});

});
