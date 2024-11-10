<?php
require_once "../model/Product_Database.php";
if (isset($_GET["action"])) {
    $action = $_GET["action"];
} else if (isset($_POST["action"])) {
    $action = $_POST["action"];
}

if ($action == "delete") {
    $product_id = $_GET["product_id"];
    $product_Database = new Product_Database();
    $product_Database->deleteProduct($product_id);
    header("location: manageProduct.php");
} else if ($action == "add") {
    $product_id = $_POST["product_id"];
    $product_name = $_POST["product_name"];
    $price = $_POST["price"];
    $desc = $_POST["desc"];
    $image = $_POST["image"];
    $category_id = $_POST["category_id"];

    $product_Database = new Product_Database();
    $product_Database->addProduct($product_id, $product_name, $price, $desc, $image, $category_id);
    header("location: manageProduct.php");
} else if ($action == "edit") {
    $product_id = $_POST["product_id"];
    $product_name = $_POST["product_name"];
    $price = $_POST["price"];
    $desc = $_POST["desc"];
    $image = $_POST["image"];
    $category_id = $_POST["category_id"];

    $product_Database = new Product_Database();
    $product_Database->editProduct($product_id, $product_name, $price, $desc, $image, $category_id);
    header("location: manageProduct.php");
}
