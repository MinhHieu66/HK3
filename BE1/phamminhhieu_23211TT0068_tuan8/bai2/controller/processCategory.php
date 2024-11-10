<?php
require_once "../model/Category_Database.php";
if (isset($_GET["action"])) {
    $action = $_GET["action"];
} else if (isset($_POST["action"])) {
    $action = $_POST["action"];
}

if ($action == "delete") {
    $category_id = $_GET["category_id"];
    $category_Database = new Category_Database();
    $category = $category_Database->deleteCategory($category_id);
    header("location: ../view/manageCategory.php");
} else if ($action == "add") {
    $category_id = $_POST["category_id"];
    $category_name = $_POST["category_name"];
    $category_Database = new Category_Database();
    $category = $category_Database->addCategory($category_id, $category_name);
    header("location: ../view/manageCategory.php");
} else if ($action == "update") {
    $category_id = $_POST["category_id"];
    $category_name = $_POST["category_name"];
    $category_Database = new Category_Database();
    $category = $category_Database->updateCategory($category_id, $category_name);
    header("location: ../view/manageCategory.php");
}