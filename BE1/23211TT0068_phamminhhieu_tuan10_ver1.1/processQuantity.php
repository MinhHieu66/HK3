<?php
session_start();
if (isset($_GET["product_id"]) && isset($_GET["action"])) {
    $product_id = $_GET["product_id"];
    $action = $_GET["action"];
    if ($action == "add") {
        $_SESSION["cart"][$product_id]++;
        header("location: cart.php");
        return;
    }

    if ($_SESSION["cart"][$product_id] == 1) {
        unset($_SESSION["cart"][$product_id]);
        header("location: cart.php");
        return;
    }

    $_SESSION["cart"][$product_id]--;
    header("location: cart.php");
}
