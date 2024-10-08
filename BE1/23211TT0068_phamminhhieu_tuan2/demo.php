<?php

require_once 'Fruit.php';
require_once 'Strawberry.php';

$apple = new Fruit("Apple", "Green");
$banana = new Fruit("Banana", "Yellow");

// $apple->setName("Apple");
// $apple->setColor("Green");

// $banana->setName("Banana");
// $banana->setColor("Yellow");


echo $apple->getName() . " - " . $apple->getColor();
echo "<br>";
echo $banana->getName() . " - " . $banana->getColor();
echo "<br>";


$strawberry = new Strawberry("Strawberry", "red");
$strawberry->message();
$strawberry->intro();
