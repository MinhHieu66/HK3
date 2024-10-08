<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Bai 5</title>
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
    <style>
    body {
        position: relative;
    }

    .position {
        position: absolute;
        left: 85px;
    }
    </style>
</head>

<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false"
                aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link" aria-current="page" href="#">Trang chủ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active" href="?/sp=sanpham&id=sp">Sản phẩm</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Giới thiệu</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Dịch vụ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Liên hệ</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="position">
        <?php 
      if(isset($_GET["id"]) && !isset($_GET["ma"])){
        for($i = 1; $i <= 5; $i++){
          echo "<a class='nav-link' href='?/sp=sanpham&id=sp&ma=$i'>Sản phẩm $i</a>";
        }
      }
    ?>

        <?php 
    if(isset($_GET["ma"])){
        $id = $_GET["ma"];
        echo "<h2>Đây là sản phẩm $id</h2>";
    }
    ?>
    </div>
</body>

</html>