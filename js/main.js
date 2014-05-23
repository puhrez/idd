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
      $(".container").html(html);
      $(".mainNav").addClass("moveUp");
      $(".container").fadeIn("slow");
      $("a[href='index.html']").on("click",function(event) {
        event.preventDefault();
        $(".mainNav").removeClass("moveUp");
        history.pushState(null, null, "index.html");
        $(".container").fadeOut("slow");
    });
      if (is_touch_device) {
        $(".secondNav li").on("click", function() {
          $("nav li ul").toggleClass("expose");
        });
      }
    });
  }
  $(document).ready(function() {
    var $navItems = $(".mainNav");
    $navItems.on("click", function(event) {
      event.preventDefault();
      var requestPage = $(event.target).attr("href")
      console.log(requestPage);
      ajaxIn(requestPage);
    });
});
})(jQuery);