$("table a#edit").click(function (e) {
  e.preventDefault();
  $("div#add form").addClass("d-none");
  $("div#update form").removeClass("d-none");

  const productId = $(this).data("id");
  $.ajax({
    url: "processAjax.php",
    type: "GET",
    data: { category_id: productId },
    success: function (response) {
      response = JSON.parse(response);
      // alert(response.id);
      $("div#update form input#category_id").val(response.id);
      $("div#update form input#category_name").val(response.name);
    },
  });
});

$("div#update form #btn-add").click(function (e) {
  e.preventDefault();
  $("div#add form").removeClass("d-none");
  $("div#update form").addClass("d-none");
});
