<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bai 2</title>
</head>

<body>

    <?php 
    for($i = 1; $i <= 30; $i++){ ?>
    <span style="color: <?= $i % 2 == 0 ? "red" : ""?>; font-weight: 700;"><?= $i . " "?></span>
    <?php }?>
</body>

</html>