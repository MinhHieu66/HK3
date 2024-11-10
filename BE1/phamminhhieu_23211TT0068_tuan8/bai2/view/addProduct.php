<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Quản lý sản phẩm</title>
    <link rel="stylesheet" href="../../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
</head>

<body>
    <div class="row">
        <div class="col-md-5 m-auto">
            <form action="processProduct.php" method="POST">
                <input type="hidden" name="action" value="add">
                <h2>Add Product</h2>
                <div class="form-group mb-3">
                    <label for="product_id">Id</label>
                    <input type="text" name="product_id" id="product_id" class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <label for="product_name">Name</label>
                    <input type="text" name="product_name" id="product_name" class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <label for="price">Price</label>
                    <input type="text" name="price" id="price" class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <label for="desc">Desc</label>
                    <textarea name="desc" id="desc" rows="6" class="form-control"></textarea>
                </div>
                <div class="form-group mb-3">
                    <label for="image">Image</label>
                    <input type="text" name="image" id="image" class="form-control mt-2">
                </div>
                <div class="form-group mb-3">
                    <?php
require_once "../../bai1/model/Category_Database.php";
$category_Database = new Category_Database();
$categories = $category_Database->getAllCategories();
?>
                    <label for="category_id">Category_id</label>
                    <select name="category_id" id="category_id" class="form-control mt-2">
                        <?php foreach ($categories as $category): ?>
                        <option value="<?=$category["id"]?>"><?=$category["name"]?></option>
                        <?php endforeach?>
                    </select>
                </div>
                <button type="submit" class="btn btn-danger">Add</button>
            </form>
        </div>
    </div>

    <script src="../../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../../vendor/jquery-3.7.1.js"></script>
    <script src="public/js/script.js"></script>
</body>

</html>