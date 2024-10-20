<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Detail</title>
    <link rel="shortcut icon" href="../images/icon.ico" type="image/x-icon" />
    <link rel="stylesheet" href="../vendor/fontawesome-free-6.6.0-web/css/all.min.css" />
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../css/style.css" />
    <link rel="stylesheet" type="text/css" href="public/css/style.css">
</head>

<body>
    <?php require_once "header.php";?>
    <?php
	require_once "data_products.php";
	$id = $_GET["id"]; 
	$product;
	foreach($products as $item){
		if($item["id"] == $id){
			$product = $item;
			break;
		}
	}
	?>
    <div class='sanpham mb-5'>
        <img src='public/images/<?= $product["image"]?>'>
        <h1><?= $product["name"]?></h1>
        <b>Giá: </b> <span class='gia'><?= $product["price"]?></span><br>
        <p><?= $product["desc"]?></p>
        <a class="addcart" href="#">Add To Cart</a>
    </div>
    <?php require_once "footer.php";?>
    <script src="../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../vendor/jquery-3.7.1.js"></script>
    <script src="../js/script.js"></script>
</body>

</html>