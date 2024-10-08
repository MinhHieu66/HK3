<?php
class Fruit
{
    private $name;
    private $color;

    function __construct($name, $color)
    {
        $this->name = $name;
        $this->color = $color;
    }

    public function getName()
    {
        return $this->name;
    }

    public function setName($name)
    {
        $this->name = $name;
    }


    public function getColor()
    {
        return $this->color;
    }

    public function setColor($color)
    {
        $this->color = $color;
    }

    function __destruct()
    {
        //echo "Destruct";
    }

    public function intro()
    {
        echo "This is fruit {$this->name} and color is {$this->color}";
    }
}
