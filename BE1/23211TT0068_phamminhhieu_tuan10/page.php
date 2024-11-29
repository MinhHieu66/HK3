<?php
require_once "modal/Category_Database.php";
require_once "modal/Product_Database.php";
$category_Database = new Category_Database();
$categories = $category_Database->getAllCategories();
$product_Database = new Product_Database();
$perPage = 1;
$page = $_GET["page"] ?? 1;
if (isset($_GET["category_id"])) {
    $category_id = $_GET["category_id"];
    $products = $product_Database->sreach_categoroy_pagination($category_id, $page, $perPage);
} else if (isset($_GET["keyword"])) {
    $keyword = $_GET["keyword"];
    $products = $product_Database->sreach_pagination($keyword, $page, $perPage);
} else {
    $products = $product_Database->getAllProducts_pagination($page, $perPage);
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Shop Homepage - Start Bootstrap Template</title>
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
    <!-- Header-->
    <header class="bg-dark py-5">
        <div class="container px-4 px-lg-5 my-5">
            <div class="text-center text-white">
                <h1 class="display-4 fw-bolder">Shop in style</h1>
                <p class="lead fw-normal text-white-50 mb-0">With this shop hompeage template</p>
            </div>
        </div>
    </header>
    <!-- Section-->
    <section class="py-5">
        <div class="container px-4 px-lg-5 mt-5">
            <div class="row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center">
                <?php foreach ($products as $product): ?>
                <div class="col mb-5">
                    <div class="card h-100">
                        <!-- Product image-->
                        <img class="card-img-top" src="images/<?=$product["image"]?>" alt="..." />
                        <!-- Product details-->
                        <div class="card-body p-4">
                            <div class="text-center">
                                <!-- Product name-->
                                <h5 class="fw-bolder"><?=$product["name"]?></h5>
                                <!-- Product price-->
                                <?=$product["price"]?>
                            </div>
                        </div>
                        <!-- Product actions-->
                        <div class="card-footer p-4 pt-0 border-top-0 bg-transparent">
                            <div class="text-center"><a class="btn btn-outline-dark mt-auto"
                                    href="item.php?product_id=<?=$product["id"]?>">View options</a>
                            </div>
                        </div>
                    </div>
                </div>
                <?php endforeach?>
            </div>

        </div>
    </section>

    <?php
if (isset($_GET["category_id"])) {
    $url = $_SERVER["PHP_SELF"] . "?category_id=" . $category_id;
    $total = $product_Database->productByCategoryId_total($category_id);
} else if (isset($_GET["keyword"])) {
    $url = $_SERVER["PHP_SELF"] . "?keyword=" . $keyword;
    $total = $product_Database->sreach_total($keyword);
} else {
    $url = $_SERVER["PHP_SELF"] . "?product_id=all";
    $total = $product_Database->product_total();
}

echo $product_Database->nagivationBar($url, $page, $perPage, $total)?>
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