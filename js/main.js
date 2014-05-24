"use strict";
(function () {
    var is_touch_device = document.documentElement.hasOwnProperty('ontouchstart');
    function ajaxIn(page) {
        $.ajax({
            url: "html/" + page,
            type: "GET",
            dataType: "html",
            cache: true
        })
            .fail(function () {
                alert("Sorry page couldn't load");
            })
            .done(function (html) {
                history.pushState(null, null, page);
                var $container = $(".container");
                $container.html(html);
                $('html, body').animate({scrollTop: $container.offset().top}, 750);
                $container.fadeIn("slow");
                $("a[href='index.html']").on("click", function (event) {
                    event.preventDefault();
                    $('html, body').animate({scrollTop: 0}, 750);
                    history.pushState(null, null, "index.html");
                });
                if (is_touch_device) {
                    $(".secondNav li").on("touchstart", function (event) {
                        event.stropPropagation();
                        event.preventDefault();
                        $("nav li ul").toggleClass("expose");
                    });
                }
            });
        $(document).ready(function () {
            var $navItems = $(".mainNav a");
            $navItems.on("click", function (event) {
                event.preventDefault();
                var requestPage = $(event.target).attr("href");
                console.log(requestPage);
                ajaxIn(requestPage);
            });
        });
    }(jQuery));