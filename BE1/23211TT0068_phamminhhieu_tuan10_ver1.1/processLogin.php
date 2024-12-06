<?php
session_start();
require_once "modal/User_Database.php";
$user_Database = new User_Database();
if (isset($_POST["email"]) && (isset($_POST["password"]))) {
    $email = $_POST["email"];
    $password = $_POST["password"];
    $user = $user_Database->getUserByEmail($email);

    if (!$user || $user["password"] != $password) {
        header("location: login.html");
        return;
    }

    $_SESSION["fullname"] = $user["fullname"];
    if ($user["authorization"] == 1) {
        header("location: crud.php");
        return;
    }

    header("location: page.php");
}
