<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
    <title>Trang chu</title>
    <link rel="shortcut icon" href="../images/icon.ico" type="image/x-icon" />
    <link rel="stylesheet" href="../vendor/fontawesome-free-6.6.0-web/css/all.min.css" />
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../css/style.css" />
    <link rel="stylesheet" type="text/css" href="public/css/style.css" />
</head>

<body>
    <!-- Button trigger modal -->
    <!-- <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
        Launch demo modal
    </button> -->

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel"
        aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                    <button type="button" class="close hide" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">Đừng có copy đem đi nộp (Tham khảo thôi)</div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary hide" data-dismiss="modal">
                        Close
                    </button>
                </div>
            </div>
        </div>
    </div>

    <!-- Header -->
    <?php require_once "header.php";?>
    <?php require_once "data_products.php";
    foreach($products as $product):
        $desc = $product["desc"];
        $len = 80;
        do{
            if($desc[$len] != " ") $len++;   
            else break;
        }while(1);
        // echo $len;
        // exit;
        $descResult = substr($desc, 0, $len);
    ?>
    <div class="sanpham">
        <img src="public/images/<?= $product["image"]?>" />
        <h1><a href="detail.php?id=<?= $product["id"]?>"><?= $product["name"]?></a></h1>
        <b>Giá: </b> <span class="gia"><?= $product["price"]?></span><br />
        <p>
            <?= $descResult?> <a href="detail.php?id=<?= $product["id"]?>">[...]</a>
        </p>
    </div>
    <?php endforeach?>
    <?php require_once "footer.php";?>
    <script src="../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../vendor/jquery-3.7.1.js"></script>
    <script src="../js/script.js"></script>
</body>

</html>