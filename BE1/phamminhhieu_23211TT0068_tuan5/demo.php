<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Demo</title>
</head>

<body>
    <?php
    echo "He said \"welcome to FIT-TDC\"";
    echo "<br>";
    echo addslashes("He said: 'Welcome to FIT-TDC'");
    echo "<br>";
    echo stripslashes("He said \"welcome to FIT-TDC\"");
    echo "<br>";
    echo strlen("Hello world!");
    echo "<br>";
    echo substr("Hello word!", 0, 5);
    echo "<br>";
    echo substr("Hello word!", 0);
    echo "<br>";
    echo substr("Hello wordl!", -8, 2); //[ )
    echo "<br>";

    $fullName = "Tran-Thi-Truc-Giang";
    $arrResult = explode("-", $fullName);
    var_dump($arrResult);
    echo "<br>";

    $arr = array("Tran", "Thi", "Truc", "Giang");
    $result = implode(" ", $arr);
    echo $result . "<br>";
    ?>
</body>

</html>