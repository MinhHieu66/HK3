<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Document</title>
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
</head>

<body>
    <a href="?/a=add">Add</a>

    <?php 
    if(isset($_GET["a"])){
      echo "Hieu";
    }else{
      echo "Thao";
    }
    ?>
</body>

</html>