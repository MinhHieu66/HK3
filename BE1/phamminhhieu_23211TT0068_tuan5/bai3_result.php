<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
    <title>Bai 3</title>
</head>

<body>
    <?php
    if(isset($_GET["number1"]) && isset($_GET["number2"])){
        $number1 = $_GET["number1"];
        $number2 = $_GET["number2"];
        $calculation = $_GET["calculations"];
        $result = "";
        switch($calculation){
            case "+":{
                $result = "Tổng 2 số $number1 và $number2 là: " . ($number1 + $number2);
                break;
            }
            case "-":{
                $result = "Hiệu 2 số $number1 và $number2 là: " . ($number1 - $number2);
                break;
            }
            case "*":{
                $result = "Tích 2 số $number1 và $number2 là: " . ($number1 * $number2);
                break;
            }
            case "/":{
                $result = "Thương 2 số $number1 và $number2 là: " . ($number1 / $number2);
                break;
            }
        }
    }
    ?>
    <div class="row mt-3">
        <div class="col-md-6 m-auto border">
            <h2 class="text-center mb-4">KẾT QUẢ</h2>
            <p><?= $result?></p>
        </div>
    </div>
    <script src="vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
</body>

</html>