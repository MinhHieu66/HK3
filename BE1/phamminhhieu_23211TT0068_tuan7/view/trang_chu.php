<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Trang chu</title>
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

    <?php
    if(!isset($_GET["category_id"])){
        $products = $product_Database->getAllProducts();
        echo '<h2>Tất cả các sản phẩm</h2>';
    }else{
        $category_id = $_GET["category_id"];
        $category = $category_Database->getCategoryById($category_id);
        echo '<h2>Sản phẩm của ' . $category["name"] .'</h2>';
        $products = $product_Database->getProductsByCategoryId($category_id);
    }
    ?>
    <br>
    <?php foreach($products as $product):
		$desc = substr($product["desc"], 0, 80); ?>

    <div class='sanpham'>
        <img src='public/images/<?= $product["image"]?>'>
        <h1><a href='detail.php?id=<?= $product["id"]?>'><?= $product["name"]?></a></h1>
        <b>Giá: </b> <span class='gia'><?= $product["price"]?></span><br>
        <p><?= substr($desc, 0, strrpos($desc, " "));?><a href='detail.php?id=<?= $product["id"]?>'>[...]</a></p>
        <a class="addcart" data-id="<?= $product["id"]?>" href="buy.php?id=<?= $product["id"]?>">Add To Cart</a>
    </div>
    <?php endforeach?>
    <!-- Modal -->
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