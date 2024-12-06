<?php
session_start();
if (isset($_GET["product_id"]) && isset($_GET["quantity"])) {
    $product_id = $_GET["product_id"];
    $quantity = (int) $_GET["quantity"];
    $cart = $_SESSION["cart"] ?? [];
    if (isset($cart["$product_id"])) {
        $cart["$product_id"] += $quantity;
    } else {
        $cart["$product_id"] = $quantity;
    }

    $_SESSION["cart"] = $cart;
    header("location: cart.php");
}
