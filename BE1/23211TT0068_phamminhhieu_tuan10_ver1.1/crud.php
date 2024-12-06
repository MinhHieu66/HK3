<?php
require_once "modal/Product_Database.php";
require_once "modal/Category_Database.php";
$product_Database = new Product_Database();
$category_Database = new Category_Database();
$categories = $category_Database->getAllCategories();
// $products = $product_Database->getAllProducts();
$total = $product_Database->product_total();
$page = $_GET["page"] ?? 1;
$perPage = 2;
$maxPage = ceil($total / $perPage);
$products = $product_Database->getAllProducts_pagination($page, $perPage);
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Shop Item - Start Bootstrap Template</title>
    <!-- Favicon-->
    <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
    <!-- Bootstrap icons-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href="css/styles.css" rel="stylesheet" />
</head>

<body>
    <!-- Navigation-->
    <?php require_once "navbar.php";?>
    <!-- Product section-->
    <section class="py-5">
        <div class="container px-4 px-lg-5 my-5">
            <div class="row gx-4 gx-lg-5 align-items-center">
                <div class="table-wrapper">
                    <div class="table-title">
                        <div class="row">
                            <div class="col-sm-6">
                                <h2>Manage <b>Products</b></h2>
                            </div>
                            <div class="col-sm-6">
                                <a class="btn btn-success" data-bs-toggle="modal" data-bs-target="#addEmployeeModal"><i
                                        class="bi bi-pencil"></i><span>Add New Product</span></a>

                            </div>
                        </div>
                    </div>
                    <table class="table table-striped table-hover">
                        <thead>
                            <tr>
                                <th>
                                    <span class="custom-checkbox">
                                        <input type="checkbox" id="selectAll">
                                        <label for="selectAll"></label>
                                    </span>
                                </th>
                                <th>Id</th>
                                <th>Name</th>
                                <th>Price</th>
                                <th>Desc</th>
                                <th>Image</th>
                                <th>Category_id</th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php foreach ($products as $product): ?>
                            <tr>
                                <td>
                                    <span class="custom-checkbox">
                                        <input type="checkbox" id="checkbox1" name="options[]" value="1">
                                        <label for="checkbox1"></label>
                                    </span>
                                </td>
                                <td><?=$product["id"]?></td>
                                <td><?=$product["name"]?></td>
                                <td><?=$product["price"]?></td>
                                <td><?=$product["desc"]?></td>
                                <td><?=$product["image"]?></td>
                                <td><?=$product["category_id"]?></td>
                                <td>
                                    <?php
$data = implode("#", $product);
$categories = $category_Database->getAllCategories();
$dataCategory = "";
foreach ($categories as $category) {
    $dataCategory .= ($category["name"] . "#");
}
?>
                                    <a data-bs-target="#editEmployeeModal" class="edit" data-bs-toggle="modal"
                                        data-category="<?=$dataCategory?>" data-id="<?=$data?>"><i
                                            class="bi bi-pencil"></i></a>
                                    <a data-bs-target="#deleteEmployeeModal" class="delete" data-bs-toggle="modal"
                                        data-id="<?=$data?>"><i class="bi bi-trash"></i></a>
                                </td>
                            </tr>
                            <?php endforeach?>
                        </tbody>
                    </table>
                    <div class="clearfix">
                        <div class="hint-text">Showing
                            <b><?=$perPage?></b> out of
                            <b><?=$total?></b> products
                        </div>
                        <ul class="pagination">
                            <?php
$pre = $page <= 1 ? 1 : $page - 1;
$next = $page >= $maxPage ? $maxPage : $page + 1;
$begin;
switch ($page) {
    case 1:
        $begin = 1;
        break;
    case $maxPage:
        $begin = $maxPage - 2 >= 1 ? $maxPage - 2 : 1;
        break;
    default:
        $begin = $page - 1;
}
$end = $begin + 2 > $maxPage ? $maxPage : $begin + 2;
// if ($page == 1) {
//     $begin = 1;
// } else if ($page == $maxPage) {
//     $begin = $maxPage - 2;
// } else {
//     $begin = $page - 1;
// }
?>
                            <!-- $i <= $maxPage && $i < $page + 3 -->
                            <!-- <li class="page-item active"><a href="#" class="page-link">3</a></li> -->
                            <li class="page-item"><a href="crud.php?page=<?=$pre?>" class="page-link">Previous</a></li>
                            <?php for ($i = $begin; $i <= $end; $i++): ?>
                            <li class="page-item <?=$page == $i ? "active" : ""?>"><a href="crud.php?page=<?=$i?>"
                                    class="page-link"><?=$i?></a></li>
                            <?php endfor?>
                            <li class="page-item"><a href="crud.php?page=<?=$next?>" class="page-link">Next</a></li>
                        </ul>
                    </div>
                </div>
            </div>

            <!-- Add Modal HTML -->
            <div id="addEmployeeModal" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <form action="processCRUD.php" method="POST">
                            <!-- <input type="hidden" name="action" value="add"> -->
                            <div class="modal-header">
                                <h4 class="modal-title">Add Employee</h4>
                                <button type="button" class="close" data-bs-dismiss="modal"
                                    aria-hidden="true">&times;</button>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label>Id</label>
                                    <input type="text" class="form-control" name="product_id" required>
                                </div>
                                <div class="form-group">
                                    <label>Name</label>
                                    <input type="text" class="form-control" name="name" required>
                                </div>
                                <div class="form-group">
                                    <label>Price</label>
                                    <input type="text" class="form-control" name="price" required>
                                </div>
                                <div class="form-group">
                                    <label>Desc</label>
                                    <textarea name="desc" class="form-control" required rows="5"></textarea>
                                </div>
                                <div class="form-group">
                                    <label>Image</label>
                                    <input type="text" class="form-control" name="image" required>
                                </div>
                                <div class="form-group">
                                    <label>Category_id</label>
                                    <select name="category_id" class="form-control">
                                        <?php foreach ($categories as $category): ?>
                                        <option value="<?=$category["id"]?>"><?=$category["name"]?></option>
                                        <?php endforeach?>
                                    </select>
                                    <!-- <input type="text" class="form-control" required> -->
                                </div>

                            </div>
                            <div class="modal-footer">
                                <input type="button" class="btn btn-default" data-bs-dismiss="modal" value="Cancel">
                                <input type="submit" class="btn btn-success" name="action" value="Add">
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <!-- Edit Modal HTML -->
            <div id="editEmployeeModal" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <form action="processCRUD.php" method="POST">
                            <div class="modal-header">
                                <h4 class="modal-title">Edit Employee</h4>
                                <button type="button" class="close" data-bs-dismiss="modal"
                                    aria-hidden="true">&times;</button>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label>Id</label>
                                    <input type="text" readonly class="form-control" id="product_id" name="product_id"
                                        value="" required>
                                </div>
                                <div class="form-group">
                                    <label>Name</label>
                                    <input type="text" class="form-control" value="" name="name" id="name" required>
                                </div>
                                <div class="form-group">
                                    <label>Price</label>
                                    <input type="text" class="form-control" value="" name="price" id="price" required>
                                </div>
                                <div class="form-group">
                                    <label>Desc</label>
                                    <textarea name="desc" id="desc" class="form-control" required rows="5"></textarea>
                                </div>
                                <div class="form-group">
                                    <label>Image</label>
                                    <input type="text" class="form-control" name="image" value="" id="image" required>
                                </div>
                                <div class="form-group">
                                    <label>Category_id</label>
                                    <select id="select" name="category_id" class="form-control">
                                        <option value=""></option>
                                        <option value=""></option>
                                        <option value=""></option>
                                        <option value=""></option>
                                    </select>
                                    <!-- <input type="text" class="form-control" required> -->
                                </div>

                            </div>
                            <div class="modal-footer">
                                <input type="button" class="btn btn-default" data-bs-dismiss="modal" value="Cancel">
                                <input type="submit" class="btn btn-info" name="action" value="Save">
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <!-- Delete Modal HTML -->
            <div id="deleteEmployeeModal" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <form action="processCRUD.php">
                            <input type="hidden" id="hiddenInput" name="product_id" value="">
                            <div class="modal-header">
                                <h4 class="modal-title">Delete Product</h4>
                                <button type="button" class="close" data-bs-dismiss="modal"
                                    aria-hidden="true">&times;</button>
                            </div>
                            <div class="modal-body">
                                <p>Bạn có chắc muốn xóa sản phẩm <span id="product-id"></span></p>
                            </div>
                            <div class="modal-footer">
                                <input type="button" class="btn btn-default" data-bs-dismiss="modal" value="Cancel">
                                <input type="submit" class="btn btn-danger" name="action" value="Delete">
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        </div>
    </section>

    <!-- Footer-->
    <footer class="py-5 bg-dark">
        <div class="container">
            <p class="m-0 text-center text-white">Copyright &copy; Your Website 2023</p>
        </div>
    </footer>
    <!-- Bootstrap core JS-->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <!-- Core theme JS-->
    <script src="js/scripts.js"></script>

</body>

</html>