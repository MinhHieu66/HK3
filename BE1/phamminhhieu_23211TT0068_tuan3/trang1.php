<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    require_once "Shape.php";
    require_once "Movable.php";
    require_once "Circle.php";
    require_once "Rectangle.php";

    $circle1 = new Circle("Red", 2, 4, 5);
    $circle2 = new Circle("Green", 5, 4, 5);
    echo $circle1->printInfo();
    echo "<br>";
    echo $circle1->calculateArea();

    $circle1->move(30, 40);
    echo "<br><br>";
    echo $circle1->printInfo();
    echo "<br>";
    echo $circle1->calculateArea();

    echo $circle2->printInfo();
    echo "<br>";
    echo $circle2->calculateArea();

    $circle2->move(30, 40);
    echo "<br><br>";
    echo $circle2->printInfo();
    echo "<br>";
    echo $circle2->calculateArea();

    $rectangle1 = new Rectangle("Red", 2, 4, 5, 10);
    $rectangle2 = new Rectangle("Green", 5, 4, 5, 15);

    echo $rectangle1->printInfo();
    echo "<br>";
    echo $rectangle1->calculateArea();

    $rectangle1->move(30, 40);
    echo "<br><br>";
    echo $rectangle1->printInfo();
    echo "<br>";
    echo $rectangle1->calculateArea();

    echo $rectangle2->printInfo();
    echo "<br>";
    echo $rectangle2->calculateArea();

    $rectangle2->moveTo(30, 40);
    echo "<br><br>";
    echo $rectangle2->printInfo();
    echo "<br>";
    echo $rectangle2->calculateArea();





    ?>
</body>

</html>