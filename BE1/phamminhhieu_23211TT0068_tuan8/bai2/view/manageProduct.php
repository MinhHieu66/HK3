<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Quản lý sản phẩm</title>
    <link rel="stylesheet" href="../../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
    <style>
    #add {
        text-decoration: none;
        color: black;
        height: 15px;
        background-color: red;
        padding: 5px;
        border-radius: 10px;
        margin-bottom: 10px;
        font-weight: 400;
    }
    </style>
</head>

<body>
    <?php
require_once "../model/Product_Database.php";
$product_Database = new Product_Database();
$products = $product_Database->getAllProducts();
?>
    <h2>Quản lý sản phẩm</h2>
    <a href="addProduct.php" id="add">Thêm sản phẩm mới</a>
    <table class="table table-bordered mt-3">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Price</th>
                <th>Desc</th>
                <th>Image</th>
                <th>Category_id</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <?php foreach ($products as $product): ?>
            <tr>
                <td><?=$product["id"]?></td>
                <td><?=$product["name"]?></td>
                <td><?=$product["price"]?></td>
                <td><?=$product["desc"]?></td>
                <td><?=$product["image"]?></td>
                <td><?=$product["category_id"]?></td>
                <td>
                    <a href="editProduct.php?product_id=<?=$product["id"]?>">Edit</a>
                    <a href="processProduct.php?action=delete&product_id=<?=$product["id"]?>"
                        onclick="return confirm('Bạn chắc muốn xóa sản phẩm <?=$product['name']?> không?')">Delete</a>
                </td>
            </tr>
            <?php endforeach?>
        </tbody>
    </table>
    <script src="../../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../../vendor/jquery-3.7.1.js"></script>
    <script src="public/js/script.js"></script>
</body>

</html>