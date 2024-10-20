<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Bai2</title>
</head>

<body>
    <?php
    if (isset($_GET["date"])) {
        $date = $_GET["date"];
        $arrTime = explode("/", $date);
        list($day, $month, $year) = $arrTime;
        $dateCreate = date_create("$year-$month-$day");
        // var_dump($dateCreate);
        // exit;

        // 2c
        $age = date("Y") - $year;
        $birthday = date_create(date('Y') . "-$month-$day");
        
        // 2d
        $arrWeek = ["Sunday"=>"Chủ nhật", "Monday"=> "Thứ 2", "Tuesday"=>"Thứ Ba", "Wednesday"=>"Thứ Tư", "Thursday"=>"Thứ Năm", "Friday"=>"Thứ Sáu", "Saturday"=>"Thứ Bảy"];
       
        // 2e
        $arrCan = ["Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ"];
        $arrChi = ["Thân", "Dậu", "Tuất", "Heo", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi"];
        $can = $arrCan[$year%10];
        $chi = $arrChi[$year%12];
        $result = $can . " " . $chi;
    ?>
    <div class="row mt-4 mx-2">
        <div class="col-md-6 border bg-warning rounded-3">
            <h2 class="text-center mt-2">Kết quả</h2>
            <!-- 2a -->
            <p>Ngày đã nhập: <?php echo $date ?></p>
            <div class="m-5">
                <p>Ngày <?= $day ?>, tháng <?= $month ?> năm <?= $year ?></p>
                <!-- 2b -->
                <p><?php echo date_format($dateCreate, "l, F, jS, Y"); ?></p>
                <p>Năm nay bạn <?= $age ?> tuổi</p>
                <p>Sinh nhật của bạn vào ngày <?= $arrWeek[date_format($birthday, "l")]?>
                    (<?= date_format($birthday, "d-m-Y")?>)</p>
                <p>Bạn tuổi <?= $result?></p>
            </div>
        </div>
    </div>
    <?php }
    ?>
    <script src="vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
</body>

</html>