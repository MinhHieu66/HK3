<?php
class MyClass
{
    public static $count = 1;
    public static function plusOne()
    {
        return self::$count++;
    }
}

echo MyClass::plusOne() . "<br>";
echo MyClass::plusOne() . "<br>";
echo MyClass::plusOne() . "<br>";
