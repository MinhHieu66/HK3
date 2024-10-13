<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Bai 3</title>

</head>

<body>
    <div class="row mt-3">
        <div class="col-md-6 m-auto bg-info rounded-3">
            <form action="bai3_res.php" method="POST">
                <div class="mb-3">
                    <label for="name" class="form-label">Name:</label>
                    <input type="text" class="form-control" name="name" id="name"
                        value="<?php echo isset($_POST['name']) ? $_POST['name'] : ""?>">
                </div>
                <div class="mb-3">
                    <label for="email" class="form-label">E-mail:</label>
                    <input type="email" class="form-control" id="email" name="email"
                        value="<?php echo isset($_POST['email']) ? $_POST['email'] : ""?>">
                </div>
                <div class="mb-3">
                    <label for="website" class="form-label">Website:</label>
                    <input type="text" class="form-control" name="website" id="website"
                        value="<?php echo isset($_POST['website']) ? $_POST['website'] : ""?>">
                </div>

                <div class="mb-3">
                    <label for="comment" class="form-label">Comment:</label>
                    <textarea name="comment" id="comment" rows="7"
                        class="form-control"><?php echo isset($_POST['comment']) ? $_POST['comment'] : ''?></textarea>
                </div>

                <div class="mb-3">
                    <label for="gender" class="form-label">Gender:</label>
                    <input type="radio" name="gender" checked value="Male"> Male
                    <input type="radio" name="gender" value="Female"
                        <?php echo (($_POST['gender'] ?? '') == 'Female') ? 'checked':''?>> Female
                </div>


                <div class="mb-3">
                    <button type="submit" class="btn btn-danger">Submit</button>
                </div>
            </form>
        </div>
    </div>
</body>

</html>