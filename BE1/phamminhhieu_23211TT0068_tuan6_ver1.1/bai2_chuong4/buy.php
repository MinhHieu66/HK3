<?php
session_start();
require_once "dataProducts.php";
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
        $_SESSION["cart"][$id]["quantity"]++;
    }
    // Neu ma khong ton tai thi them vao dong data moi
    else{
        // $_SESSION["cart"][$id] = $id;
        $_SESSION["cart"][$id] =[
            "quantity"=>1,
            "price"=>$item["price"],
            "name"=>$item["name"]
        ];
    }
    // var_dump($_SESSION); exit;
}
header("location: trang_chu.php");
?>