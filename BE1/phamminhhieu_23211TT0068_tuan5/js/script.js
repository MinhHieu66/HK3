$(".navbar ul li").click(function (e) {
  $("li.active").removeClass("active");
  $(this).addClass("active");
  e.preventDefault();
});

// Modal
$(document).ready(function () {
  $("#exampleModal").modal("show");
});

$(".hide").click(function (e) {
  $("#exampleModal").modal("hide");
  e.preventDefault();
});
