<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Quản lý sản phẩm</title>
    <link rel="stylesheet" href="../../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
</head>

<body>
    <?php
require_once "../model/Product_Database.php";
require_once "../../bai1/model/Category_Database.php";
if (isset($_GET["product_id"])) {
    $product_id = $_GET["product_id"];
    $product_Database = new Product_Database();
    $product = $product_Database->getProductById($product_id);
    $category_Database = new Category_Database();
    $categories = $category_Database->getAllCategories();
}
?>
    <div class="row">
        <div class="col-md-5 m-auto">
            <form action="processProduct.php" method="POST">
                <input type="hidden" name="action" value="edit">
                <h2>Edit Product</h2>
                <div class="form-group mb-3">
                    <label for="product_id">Id</label>
                    <input type="text" name="product_id" value="<?=isset($product) ? $product["id"] : ""?>"
                        id="product_id" class="form-control mt-2" readonly>
                </div>
                <div class="form-group mb-3">
                    <label for="product_name">Name</label>
                    <input type="text" name="product_name" value="<?=isset($product) ? $product["name"] : ""?>"
                        id="product_name" class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <label for="price">Price</label>
                    <input type="text" name="price" value="<?=isset($product) ? $product["price"] : ""?>" id="price"
                        class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <label for="desc">Desc</label>
                    <textarea name="desc" id="desc" rows="6"
                        class="form-control"><?=isset($product) ? $product["desc"] : ""?></textarea>
                </div>
                <div class="form-group mb-3">
                    <label for="image">Image</label>
                    <input type="text" name="image" value="<?=isset($product) ? $product["image"] : ""?>" id="image"
                        class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <label for="category_id">Category_id</label>
                    <select name="category_id" id="category_id" class="form-control mt-2">
                        <?php foreach ($categories as $category): ?>
                        <option <?=$category["id"] == $product["category_id"] ? "selected" : ""?>
                            value="<?=$category["id"]?>"><?=$category["name"]?></option>
                        <?php endforeach?>
                    </select>
                </div>
                <button type="submit" class="btn btn-danger">Update</button>
            </form>
        </div>
    </div>

    <script src="../../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../../vendor/jquery-3.7.1.js"></script>
    <script src="public/js/script.js"></script>
</body>

</html>