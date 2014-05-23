(function() {
  var is_touch_device = 'ontouchstart' in document.documentElement;
  function ajaxIn(page) {
    $.ajax({
      url: "html/" + page,
      type: "GET",
      dataType: "html",
      cache: true
    })
    .fail(function() {
      alert("Sorry page couldn't load");
    })
    .done(function(html) {
      history.pushState(null, null, page);
      $container = $(".container");
      $container.html(html);
      $('html, body').animate({scrollTop: $container.offset().top}, 750);
      $container.fadeIn("slow");
      $("a[href='index.html']").on("click",function(event) {
        event.preventDefault();
        $('html, body').animate({scrollTop: 0}, 750);
        history.pushState(null, null, "index.html");
        $container.fadeOut("slow");
    });
      if (is_touch_device) {
        $(".secondNav li").on("click", function() {
          $("nav li ul").toggleClass("expose");
        });
      }
    });
  }
  $(document).ready(function() {
    var $navItems = $(".mainNav a");
    $navItems.on("click", function(event) {
      event.preventDefault();
      var requestPage = $(event.target).attr("href")
      console.log(requestPage);
      ajaxIn(requestPage);
    });
});
})(jQuery);