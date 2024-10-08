<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Document</title>
</head>

<body>
    <?php
    require_once "User.php";
    if (isset($_POST["username"]) && $_POST["password"]) {
        $oke = User::login($_POST["username"], $_POST["password"]);

        if ($oke) {
            echo "<div class='bg-danger text-dark text-center'>Đăng nhập thành công!</div>";
        } else {
            echo "<div class='bg-warning text-dark text-center'>Đăng nhập không thành công!</div>";
        }
    } ?>
</body>

</html>