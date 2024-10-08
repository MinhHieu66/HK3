<?php

class Strawberry extends Fruit
{
    public function message()
    {
        echo "Am I a fruit or a berry? <br>";
    }

    public function intro()
    {
        parent::intro();
        echo "<br>Am I a fruit or a berry? ";
    }
}
