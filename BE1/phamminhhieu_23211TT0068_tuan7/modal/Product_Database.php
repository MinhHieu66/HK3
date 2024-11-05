<?php
require_once "Database.php";
class Product_Database extends Database{
    public function getAllProducts(){
        $sql = self::$connection->prepare("SELECT * FROM product");
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }
    
	public function getProductById($id){
        $sql = self::$connection->prepare('SELECT * FROM product WHERE id = ?');
        $sql->bind_param("i", $id);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items[0];
    }

    public function getProductsByCategoryId($category_id){
        $sql = self::$connection->prepare('SELECT * FROM product WHERE category_id = ?');
        $sql->bind_param("i", $category_id);
        $sql->execute();
        $items =array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

}