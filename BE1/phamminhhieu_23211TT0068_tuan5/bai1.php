<?php
$txt = "Chào mừng các bạn đến với môn học Lập Trình Web Back-end 1";
$arrResult = explode(" ", $txt);

//1a
echo "<h2>Câu 1a: </h2>";
foreach ($arrResult as $item):
    echo $item . "<br>";
endforeach;

// 1b
echo "<h2>Câu 1b: </h2>";
$txtResult = implode("_", $arrResult);
echo $txtResult . "<br>";

//str_word_count(string)
$words = str_word_count($txtResult);
echo $words . "<br>";

//str_replace(find, replace, string)
$replace = str_replace(" ", "<br>", $txt);
echo $replace . "<br>";

//trim()
$fullName = "    Tran Thi Truc Giang    ";
$fullNameTrim = trim($fullName);
echo $fullNameTrim . "<br>";

//number_format(number)
$number1 = number_format(123456.789);
echo $number1 . "<br>";

$number2 = number_format(123456.789, 2);
echo $number2 . "<br>";
