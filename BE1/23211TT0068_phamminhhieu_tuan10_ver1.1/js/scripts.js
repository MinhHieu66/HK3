/*!
 * Start Bootstrap - Shop Homepage v5.0.6 (https://startbootstrap.com/template/shop-homepage)
 * Copyright 2013-2023 Start Bootstrap
 * Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-shop-homepage/blob/master/LICENSE)
 */
// This file is intentionally blank
// Use this file to add JavaScript to your project
// alert("1");
document.querySelectorAll(".delete").forEach(function (element) {
  element.addEventListener("click", function () {
    var dataProduct = this.getAttribute("data-id");
    var result = dataProduct.split("#");
    document.getElementById("product-id").textContent = result[1];
    document.getElementById("hiddenInput").value = result[0];
  });
});

document.querySelectorAll(".edit").forEach(function (element) {
  element.addEventListener("click", function () {
    var dataProduct = this.getAttribute("data-id");
    var dataCategory = this.getAttribute("data-category");
    // alert(dataCategory);
    var result = dataProduct.split("#");
    // document.getElementById("product-id").textContent = result[1];
    document.getElementById("product_id").value = result[0];
    document.getElementById("name").value = result[1];
    document.getElementById("price").value = result[2];
    document.getElementById("desc").value = result[3];
    document.getElementById("image").value = result[4];
    //Lay tat ca option
    var categoryNames = dataCategory.split("#");
    let options = document.querySelectorAll("#select option");
    let i = 0;
    options.forEach(function (element) {
      if (i + 1 == result[5]) {
        element.setAttribute("selected", "selected");
      }
      element.textContent = categoryNames[i];
      //   element.textContent = "123";
      element.value = ++i;
    });
  });
});
