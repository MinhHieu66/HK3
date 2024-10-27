<?php session_start();?>
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
    <title>cart</title>
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="public/css/style.css" />
</head>

<body>
    <h1>Your cart</h1>
    <a href="trang_chu.php">Trang chu</a>
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
        require_once "Product.php";
    $total = 0;
	if(isset($_SESSION["cart"])){
        // var_dump($_SESSION); exit;
		foreach($_SESSION["cart"] as $key=>$value){ 
        $temp = unserialize($value);
        $amount = $temp->quantity * $temp->price;
        $total += $amount;?>
        <tr>
            <td><?= $key?></td>
            <td><?= $temp->name?></td>
            <td><?= $temp->quantity?></td>
            <td><?= $temp->price?></td>
            <td><?= $amount?></td>
            <td><a id="delete" href="deleteProduct.php?id=<?= $key?>">Delete</a></td>
            <td><button class="btn btn-danger"><a href="processQuantity.php?id=<?= $key?>&name=increase"
                        style="text-decoration: none; color: aliceblue;">+</a></button></td>
            <td><button class="btn btn-info"><a href="processQuantity.php?id=<?= $key?>&name=reduce"
                        style="text-decoration: none; color: aliceblue;">-</a></button>
            </td>
        </tr>
        <?php }
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