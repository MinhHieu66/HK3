$(".addcart").click(function (e) {
  e.preventDefault();
  const productId = $(this).data("id");

  $.ajax({
    url: "buy.php", // Đường dẫn tới file PHP để thêm vào giỏ hàng
    type: "GET",
    data: { id: productId },
    success: function (response) {
      $("#exampleModal").modal("show");
      // Có thể cập nhật thông tin giỏ hàng nếu cần
    },
  });
  // alert("Them sp thanh cong");
});
