<?php
// require "Shape.php";
// require "Movable.php";

class Rectangle extends Shape implements Movable
{
    private $width;
    private $height;

    function __construct($color, $x, $y, $width, $height)
    {
        parent::__construct($color, $x, $y);
        $this->width = $width;
        $this->height = $height;
    }

    public function calculateArea()
    {
        return $this->width * $this->height;
    }

    public function printInfo()
    {
        return "Rectangle($this->color, $this->x, $this->y, $this->width, $this->height)";
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
