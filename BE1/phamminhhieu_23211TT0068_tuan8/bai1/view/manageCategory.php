<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Quản lý danh mục sản phẩm</title>
    <link rel="stylesheet" href="../../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css" />
</head>

<body>
    <?php
require_once "../model/Category_Database.php";
$category_Database = new Category_Database();
$categories = $category_Database->getAllCategories();
?>
    <h2>Quản lý danh mục sản phẩm</h2>
    <div class="row">
        <div class="col-md-6 m-auto">
            <h3>Danh sách các danh mục</h3>
            <table class="table table-bordered text-center">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <?php foreach ($categories as $category): ?>
                    <tr>
                        <td><?=$category["id"]?></td>
                        <td><?=$category["name"]?></td>
                        <td>
                            <a data-id="<?=$category["id"]?>" id="edit"
                                href="manageCategory.php?category_id=<?=$category["id"]?>">Edit</a>
                            <a href="../controller/processCategory.php?action=delete&category_id=<?=$category["id"]?>"
                                onclick="return confirm('Bạn có chắc xóa loai <?=$category['name']?> không?')">Delete</a>
                        </td>
                    </tr>
                    <?php endforeach?>
                </tbody>
            </table>
        </div>
    </div>
    <div class="row" id="add">
        <div class="col-md-4 m-auto border-1">
            <form action="../controller/processCategory.php" method="POST" class="">
                <h4>Add Category</h4>
                <input type="hidden" name="action" value="add">
                <div class="row mb-3">
                    <label for="category_id">Id</label>
                    <input type="text" name="category_id" id="category_id" class="form-control mt-2">
                </div>
                <div class="row mb-3">
                    <label for="category_name">Name</label>
                    <input type="text" name="category_name" id="category_name" class="form-control mt-2">
                </div>
                <button type="submit" class="btn btn-danger">Add</button>
            </form>
        </div>
    </div>
    <div class="row" id="update">
        <div class="col-md-4 m-auto border-1">
            <form action="../controller/processCategory.php" method="POST" class="d-none">
                <h4>Update Category</h4>
                <input type="hidden" name="action" value="update">
                <div class="row mb-3">
                    <label for="category_id">Id</label>
                    <input type="text" name="category_id" value="" id="category_id" class="form-control mt-2" readonly>
                </div>
                <div class="row mb-3">
                    <label for="category_name">Name</label>
                    <input type="text" name="category_name" value="" id="category_name" class="form-control mt-2">
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