<?php
require_once "modal/Product_Database.php";
$product_Database = new Product_Database();
if (isset($_POST["action"])) {
    $action = $_POST["action"];
} else if (isset($_GET["action"])) {
    $action = $_GET["action"];
}
// echo "Minh Hieu";
// exit;
if ($action == "Add") {
    $product_id = $_POST["product_id"];
    $name = $_POST["name"];
    $price = $_POST["price"];
    $desc = $_POST["desc"];
    $image = $_POST["image"];
    $category_id = $_POST["category_id"];

    $product_Database->addProduct($product_id, $name, $price, $desc, $image, $category_id);
    header("location: crud.php");
} else if ($action == "Delete") {
    $product_id = $_GET["product_id"];
    $product_Database->deleteProduct($product_id);
    header("location: crud.php");
} else if ($action == "Save") {
    $product_id = $_POST["product_id"];
    $name = $_POST["name"];
    $price = $_POST["price"];
    $desc = $_POST["desc"];
    $image = $_POST["image"];
    $category_id = $_POST["category_id"];

    $product_Database->editProduct($product_id, $name, $price, $desc, $image, $category_id);
    header("location: crud.php");
}
