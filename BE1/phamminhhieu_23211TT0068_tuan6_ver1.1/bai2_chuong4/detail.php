<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Detail</title>
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="public/css/style.css" />
</head>

<body>
    <a href="viewcart.php">Giỏ hàng</a>
    <br>
    <?php
	require_once "dataProducts.php";
	$id = $_GET["id"] ?? "";
	foreach ($products as $value) 
	{
		if($value["id"] == $id){
			$product = $value?>
    <div class='sanpham'>
        <img src='public/images/<?= $product["image"]?>'>
        <h1><?= $product["name"]?></h1>
        <b>Giá: </b> <span class='gia'><?= $product["price"]?></span><br>
        <p><?= $product["desc"]?></p>
        <a class="addcart" data-id="<?= $product["id"]?>" href="buy.php?id=<?= $product["id"]?>">Add To Cart</a>
    </div>
    <?php }
	}
	 ?>
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    Thêm sản phẩm vào giỏ hành thành công
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <script src="../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../vendor/jquery-3.7.1.js"></script>
    <script src="public/js/script.js"></script>
</body>

</html>