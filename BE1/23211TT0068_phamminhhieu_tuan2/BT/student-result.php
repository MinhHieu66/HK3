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
    require_once "Student.php";

    $username = isset($_POST['username']) ? $_POST['username'] : "";
    $password = isset($_POST['password']) ? $_POST['password'] : "";
    $firstname = isset($_POST['firstname']) ? $_POST['firstname'] : "";
    $lastname = isset($_POST['lastname']) ? $_POST['lastname'] : "";
    $gpa = isset($_POST['gpa']) ? $_POST['gpa'] : "";

    $student = new Student($_POST["username"], $_POST["password"], $_POST["firstname"], $_POST["lastname"], $_POST["gpa"]);
    //echo $student->getFullname();
    ?>
    <div class="row">
        <div class="col-lg-6 m-auto">
            <table class="table table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Fullname</th>
                        <th>GPA</th>
                        <th>Classity</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><?php echo $student->getUsername() ?></td>
                        <td><?php echo $student->getFullname() ?></td>
                        <td><?php echo $student->getGpa() ?></td>
                        <td><?php echo $student->classify() ?></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</body>

</html>