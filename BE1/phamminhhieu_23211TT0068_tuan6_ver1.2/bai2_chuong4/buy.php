<?php
session_start();
require_once "dataProducts.php";
require_once "Product.php";
if(isset($_GET["id"])){
    $id = $_GET["id"];
    $item;
    foreach($products as $product){
        if($product["id"] == $id){
            $item = $product;
            break;
        }
    }

    if(!isset($_SESSION["cart"])) $_SESSION["cart"] = [];
    
    //Neu ma ton tai thi tang so luong
    if(isset($_SESSION["cart"][$id])){
        $product = unserialize($_SESSION["cart"][$id]);
        $product->quantity++;
    }
    // Neu ma khong ton tai thi them vao dong data moi
    else{
        $product = new Product($item["name"], $item["price"], 1);
    }
    $_SESSION["cart"][$id] = serialize($product);
}
header("location: trang_chu.php");
?>