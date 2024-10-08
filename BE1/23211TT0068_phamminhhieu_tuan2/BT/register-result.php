<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng ký</title>
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
</head>

<body>
    <?php
    require_once "User.php";
    if (isset($_POST["username"]) && isset($_POST["password"]) && isset($_POST["firstname"]) && isset($_POST["lastname"])) {
        $username = $_POST["username"];
        $password = $_POST["password"];
        $firstname = $_POST["firstname"];
        $lastname = $_POST["lastname"];
        $user = new User($username, $password, $firstname, $lastname) ?>
        <div class="container top">
            <table class="table table-bordered table-dark text-center mt-5">
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Fullname</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><?= $username ?></td>
                        <td><?= $user->getFullname() ?></td>
                    </tr>
                </tbody>
            </table>
        </div>
    <?php }
    ?>
</body>

</html>