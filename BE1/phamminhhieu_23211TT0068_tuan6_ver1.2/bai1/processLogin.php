<?php
session_start();

$username = $_POST["username"] ?? "";// ?
$password = $_POST["password"] ?? "";

function checkPassword($username, $password){
//username: Admin, pass: 123456
$hash = password_hash(123456, PASSWORD_BCRYPT);
$decode = password_verify($password, $hash);
if($username == "Admin" && $decode) return true;
return false;
}

if(checkPassword($username, $password))
{
    $_SESSION["username"] = $username;
    // $_SESSION["password"] = $password;
    header("location: admin.php");
}else{
    header("location: login.html");
}
?>