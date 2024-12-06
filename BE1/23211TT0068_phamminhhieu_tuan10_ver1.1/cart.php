<?php
session_start();
require_once "modal/Product_Database.php";
require_once "modal/Category_Database.php";
$product_Database = new Product_Database();
$category_Database = new Category_Database();
$categories = $category_Database->getAllCategories();
$products = $product_Database->getAllProducts();
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
                <div id="shopping-cart">
                    <h2>Shopping Cart</h2>
                    <div class="float-end">
                        <a class="btn btn-outline-dark mt-auto" href="clearCart.php"
                            onclick="return confirm('Bạn có chắc xóa hết sản phẩm trong giỏ hàng không?')">Empty
                            Cart</a>
                    </div>
                    <table class="table" cellpadding="10" cellspacing="1">
                        <tbody>
                            <tr>
                                <th style="text-align:left;">Name</th>
                                <th style="text-align:left;">Code</th>
                                <th style="text-align:right;" width="5%">Quantity</th>
                                <th style="text-align:center;" width="10%">Add</th>
                                <th style="text-align:center;" width="10%">Reduce<br></th>
                                <th style="text-align:right;" width="10%">Price<br>( in $)</th>
                                <th style="text-align:right;" width="10%">Total<br>( in $)</th>
                                <th style="text-align:center;" width="5%">Remove</th>
                            </tr>
                            <?php
$totalQuantity = 0;
$total = 0;
if (isset($_SESSION["cart"])):
    foreach ($_SESSION["cart"] as $product_id => $quantity):
        foreach ($products as $product):
            if ($product["id"] == $product_id):
                $money = $quantity * $product["price"];
                $totalQuantity += $quantity;
                $total += $money;
                ?>
				                            <tr>
				                                <td><?=$product["name"]?></td>
				                                <td><?=$product["id"]?></td>
				                                <td style="text-align:right;"><?=$quantity?></td>
				                                <td style="text-align:center;"><a
				                                        href="processQuantity.php?product_id=<?=$product["id"]?>&action=add"
				                                        class="btn btn-danger">+</a></td>
				                                <td style="text-align:center;"><a
				                                        href="processQuantity.php?product_id=<?=$product["id"]?>&action=reduce"
				                                        class="btn btn-info">-</a></td>

				                                <td style="text-align:right;"><?=$product["price"]?></td>
				                                <td style="text-align:right;"><?=$money?></td>
				                                <td style="text-align:center;"><a href="deleteItem.php?product_id=<?=$product["id"]?>"
				                                        class=""
				                                        onclick="return confirm('Bạn có chắc xóa <?=$product['name']?> không?')"><i
				                                            class="bi bi-trash"></i></a></td>
				                            </tr>

				                            <?php endif;
        endforeach;
    endforeach;
endif?>

                            <tr>
                                <td colspan="2" align="right">Total:</td>
                                <td align="right"><?=$totalQuantity?></td>
                                <td align="right" colspan="2"><strong><?=$total?></strong></td>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
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