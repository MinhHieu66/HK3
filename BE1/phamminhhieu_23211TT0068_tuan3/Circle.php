<?php
// require "Shape.php";
// require "Movable.php";

class Circle extends Shape implements Movable
{
    private $radius;

    function __construct($color, $x, $y, $radius)
    {
        parent::__construct($color, $x, $y);
        $this->radius = $radius;
    }

    public function calculateArea()
    {
        return 3.14 * $this->radius ** 2;
    }

    public function printInfo()
    {
        return "Circle($this->color, $this->x, $this->y, $this->radius)";
    }

    public function move($dx, $dy)
    {
        $this->x += $dx;
        $this->y += $dy;
    }

    public function moveTo($x, $y)
    {
        $this->x = $x;
        $this->y = $y;
    }
}
