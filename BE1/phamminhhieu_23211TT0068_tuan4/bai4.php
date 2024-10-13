<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
    <title>Bai 4</title>
</head>

<body>
    <?php require_once "bai4_data.php";?>
    <div class="row">
        <div class="col-md-6 m-auto">
            <form action="bai4_result.php" method="POST">
                <h2 class="text-center">Thực đơn</h2>
                <div class="row">
                    <div class="col-4">
                        <h4>Món khai vị</h4>
                        <select name="khai_vi[]" id="khai-vi" multiple>
                            <?php for($i = 0; $i <= count($khaiVi) - 1; $i++): ?>
                            <option value="<?= $i?>"><?= $khaiVi[$i]?></option>
                            <?php endfor ?>
                        </select>
                    </div>
                    <div class="col-4">
                        <h4>Món chính</h4>
                        <select name="chinh[]" id="chinh" multiple>
                            <?php for($i = 0; $i <= count($chinh) - 1; $i++): ?>
                            <option value="<?= $i?>"><?= $chinh[$i]?></option>
                            <?php endfor ?>
                        </select>
                    </div>
                    <div class="col-4">
                        <h4>Món tráng miệng</h4>
                        <select name="trang_mieng[]" id="trang_mieng" multiple>
                            <?php for($i = 0; $i <= count($trangMieng) - 1; $i++): ?>
                            <option value="<?= $i?>"><?= $trangMieng[$i]?></option>
                            <?php endfor ?>
                        </select>
                    </div>
                </div>
                <div class="text-center">
                    <button class="btn btn-danger mt-3" type="submit">Submit</button>
                </div>
            </form>
        </div>
    </div>
</body>

</html>