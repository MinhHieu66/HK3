<?php
require_once "../model/Category_Database.php";
if (isset($_GET["category_id"])) {
    $category_id = $_GET["category_id"];
    $ctegory_Database = new Category_Database();
    $category = $ctegory_Database->getCategoryById($category_id);
    echo json_encode($category);
    // var_dump($category);
}
