<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Document</title>
    <style>
    img {
        width: 200px !important;
    }
    </style>
</head>

<body>
    <?php 
    if(isset($_GET['search'])){
        require_once 'bai2.html';

        echo "Kết quả tìm kiếm với từ khóa: " . $_GET['search'];
        if($_GET['search'] == 'Dong ho'){
            for($i = 0; $i <= 1; $i++){?>
    <div class="row">
        <div class="col-2">
            <img src="images/pic1.jpg" alt="">
        </div>
        <div class="col-2">
            <img src="images/pic2.jpg" alt="">
        </div>
        <div class="col-2">
            <img src="images/pic1.jpg" alt="">
        </div>
        <div class="col-2">
            <img src="images/pic2.jpg" alt="">
        </div>
        <div class="col-2">
            <img src="images/pic1.jpg" alt="">
        </div>
        <div class="col-2">
            <img src="images/pic2.jpg" alt="">
        </div>
    </div>
    <?php } 
        } 
    }?>
</body>

</html>