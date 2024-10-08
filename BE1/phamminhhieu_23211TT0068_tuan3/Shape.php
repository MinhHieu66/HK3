<?php
abstract class Shape
{
    protected $color;
    protected $x;
    protected $y;

    function __construct($color, $x, $y)
    {
        $this->color = $color;
        $this->x = $x;
        $this->y = $y;
    }

    abstract protected function calculateArea();

    public function printInfo()
    {
        return "Shape($this->color, $this->x, $this->y)";
    }
}
