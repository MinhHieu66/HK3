<?php
session_start();
if(isset($_GET['id']) && isset($_GET['name'])){
    $id = $_GET['id'];
    $check = $_GET["name"];
        if($check == "increase"){
            $_SESSION["cart"][$id]["quantity"]++;
        }
        else{
            if($_SESSION["cart"][$id]["quantity"] > 1){
                $_SESSION["cart"][$id]["quantity"]--;
            }else if($_SESSION["cart"][$id]["quantity"] == 1){
                unset($_SESSION["cart"][$id]);
            }
        }
}
header("location: viewcart.php");
?>