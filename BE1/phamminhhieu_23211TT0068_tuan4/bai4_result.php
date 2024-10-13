<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Bai 4 - Result</title>
</head>

<body>
    <?php
    require_once "bai4_data.php";
    $khaiViResult = $_POST['khai_vi'] ?? [];
    $chinhResult = $_POST['chinh'] ?? [];
    $trangMiengResult = $_POST['trang_mieng'] ?? [];
    ?>
    <h2 class="text-center mb-3">Thực đơn đã chọn</h2>
    <div class="row">
        <div class="col-md-6 m-auto">
            <div class="row">
                <div class="col-4 border">
                    <h6>Món khai vị:</h6>
                    <ol>
                        <?php foreach($khaiViResult as $mon): ?>
                        <li><?php echo $khaiVi[$mon]?></li>
                        <?php endforeach ?>
                    </ol>
                </div>
                <div class="col-4 border">
                    <h6>Món chính:</h6>
                    <ol>
                        <?php foreach($chinhResult as $mon): ?>
                        <li><?php echo $chinh[$mon]?></li>
                        <?php endforeach ?>
                    </ol>
                </div>
                <div class="col-4 border">
                    <h6>Món tráng miệng:</h6>
                    <ol>
                        <?php foreach($trangMiengResult as $mon): ?>
                        <li><?php echo $trangMieng[$mon]?></li>
                        <?php endforeach ?>
                    </ol>
                </div>
            </div>
        </div>
    </div>
</body>

</html>