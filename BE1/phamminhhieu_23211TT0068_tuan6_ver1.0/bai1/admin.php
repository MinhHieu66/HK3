<?php session_start();?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin</title>
</head>
<body>
    <?php
    if(isset($_SESSION["username"]))
        echo "Xin chao " . $_SESSION["username"];
    else{
        header("location: login.html");
    }
    ?>
    <a href="logout.php">Logout</a>
</body>
</html>