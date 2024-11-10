<?php
require_once '../../Database.php';
class Category_Database extends Database
{
    public function getAllCategories()
    {
        $sql = self::$connection->prepare("SELECT * FROM category");
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

    public function getCategoryById($id)
    {
        $sql = self::$connection->prepare("SELECT * FROM category WHERE id = ?");
        $sql->bind_param("i", $id);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items[0];
    }

    public function deleteCategory($id)
    {
        $sql = self::$connection->prepare("DELETE FROM category WHERE id = ?");
        $sql->bind_param("i", $id);
        return $sql->execute();
    }

    public function addCategory($id, $name)
    {
        $sql = self::$connection->prepare("INSERT INTO category VALUES(?, ?)");
        $sql->bind_param("is", $id, $name);
        return $sql->execute();
    }

    public function updateCategory($id, $name)
    {
        $sql = self::$connection->prepare("UPDATE category SET name = ? WHERE id = ?");
        $sql->bind_param("si", $name, $id);
        return $sql->execute();
    }
}