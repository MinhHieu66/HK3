<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Bai 3</title>
   
</head>
<body>
    <?php
    // echo "Minh Hieu";
    if(isset($_POST['name']) && isset($_POST['email']) && isset($_POST['website'])){
        // echo "Minh Hieu";
        require_once "bai3.php"; ?>

<div class="row mt-3">
        <div class="col-md-6 m-auto text-center">
            <table class="table table-dark text-cent">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Website</th>
                        <th>Comment</th>
                        <th>Gender</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><?php echo $_POST["name"]?></td>
                        <td><?php echo $_POST["email"]?></td>
                        <td><?php echo $_POST["website"]?></td>
                        <td><?php echo $_POST["comment"]?></td>
                        <td><?php echo $_POST["gender"]?></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
   <?php } 
    ?>
</body>
</html>