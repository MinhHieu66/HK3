<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bai 4</title>
</head>

<body>
    <?php 
    if(isset($_POST["name"]) && isset($_POST["year"])){
        $name = $_POST["name"];
        $year = $_POST["year"];
        $age = 2024 - $year;
        echo "Ten: $name <br>Tuoi: $age";
    }
    ?>
</body>

</html>