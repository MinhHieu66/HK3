<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Dang ky</title>
    <link rel="stylesheet" href="./vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />

    <style>
    select {
        width: 205px !important;
    }
    </style>
</head>

<body>
    <form action="bai4.php" method="POST">
        <label>
            Tên: <input type="text" name="name" id="name" class="form-control" />
        </label>
        <br />
        <br />
        Năm sinh:
        <select name="year" id="year" class="form-control">
            <?php for($i = 1990; $i <= 2030; $i++){?>
            <option value="<?= $i?>"><?= $i?></option>
            <?php }?>
        </select>
        <br /><br />
        <button type="submit" class="btn btn-danger">Submit</button>
    </form>
</body>

</html>