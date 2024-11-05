<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Detail</title>
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="public/css/style.css">
    <link rel="stylesheet" href="../vendor/fontawesome-free-6.6.0-web/css/all.min.css">
</head>

<body>
    <?php
    require_once "../modal/Category_Database.php";
    require_once "../modal/Product_Database.php";
    $category_Database = new Category_Database();
    $categories = $category_Database->getAllCategories(); 
    $product_Database = new Product_Database();
    require_once "hearder.php";
    ?>
    <br>
    <?php
	$product_id = $_GET["id"] ?? "";
    $product_Database = new Product_Database();
    $product = $product_Database->getProductById($product_id);
    $category_Database = new Category_Database();
    $category = $category_Database->getCategoryById($product["category_id"])?>

    <div class='sanpham'>
        <img src='public/images/<?= $product["image"]?>'>
        <h1><?= $product["name"]?></h1>
        <p><a href="trang_chu.php?category_id=<?= $category["id"]?>"><?= $category["name"]?></a></p>
        <b>Giá: </b> <span class='gia'><?= $product["price"]?></span><br>
        <p><?= $product["desc"]?></p>
        <a class="addcart" data-id="<?= $product["id"]?>" href="buy.php?id=<?= $product["id"]?>">Add To Cart</a>
    </div>

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