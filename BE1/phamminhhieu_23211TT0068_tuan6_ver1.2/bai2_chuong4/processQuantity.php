<?php
session_start();
require_once "Product.php";
if(isset($_GET['id']) && isset($_GET['name'])){
    $id = $_GET['id'];
    $check = $_GET["name"];
    $product = unserialize($_SESSION["cart"][$id]);
        if($check == "increase"){
            $product->quantity++;
            $_SESSION["cart"][$id] = serialize($product);
        }
        else{
            if($product->quantity > 1){
                $product->quantity--;
                $_SESSION["cart"][$id] = serialize($product);
            }else if($product->quantity == 1){
                unset($_SESSION["cart"][$id]);
            }
        }
}
header("location: viewcart.php");
?>