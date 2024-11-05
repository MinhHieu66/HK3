<?php
session_start();
if(isset($_GET["id"])){
    $id = $_GET["id"];

    //Neu ma ton tai thi tang so luong
    if(isset($_SESSION["cart"][$id])){
        $_SESSION["cart"][$id]++;
    }
    // Neu ma khong ton tai thi them vao dong data moi
    else{
        $_SESSION["cart"][$id] = 1;
    }
}
header("location: trang_chu.php");
?>