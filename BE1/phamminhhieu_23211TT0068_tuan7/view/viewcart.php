<?php session_start();?>
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
    <title>cart</title>
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
    <h1>Your cart</h1>
    <table class="table" cellspacing="0" cellpadding="5">
        <tr>
            <th>#id</th>
            <th>Name</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Amount</th>
            <th>Action</th>
            <th></th>
            <th></th>
        </tr>
        <?php
    $product_Database = new Product_Database();
    $products = $product_Database->getAllProducts();
    $total = 0;
	if(isset($_SESSION["cart"])){
		foreach($_SESSION["cart"] as $key=>$value){ 
      foreach($products as $product){
      if($product["id"] == $key){
        $amount = $product["price"] * $value;
        $total += $amount;?>
        <tr>
            <td><?= $product["id"]?></td>
            <td><?= $product["name"]?></td>
            <td><?= $value?></td>
            <td><?= $product["price"]?></td>
            <td><?= $amount?></td>
            <td><a id="delete" href="deleteProduct.php?id=<?= $product["id"]?>">Delete</a></td>
            <td><button class="btn btn-danger"><a href="processQuantity.php?id=<?= $product["id"]?>&name=increase"
                        style="text-decoration: none; color: aliceblue;">+</a></button></td>
            <td><button class="btn btn-info"><a href="processQuantity.php?id=<?= $product["id"]?>&name=reduce"
                        style="text-decoration: none; color: aliceblue;">-</a></button>
            </td>
        </tr>
        <?php }
			}
		}
	}
	?>
        <tr>
            <td>Total</td>
            <td colspan="7"><?= $total?></td>
        </tr>
    </table>
    <div class="clear">
        <button class="btn btn-warning"><a href="clearProduct.php">Clear</a></button>
    </div>
    <script src="../vendor/bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../vendor/jquery-3.7.1.js"></script>
    <script src="public/js/script.js"></script>
</body>

</html>