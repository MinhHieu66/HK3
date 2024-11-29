<?php
require_once 'Database.php';
class User_Database extends Database
{
    public function getUserByEmail($email)
    {
        $sql = self::$connection->prepare("SELECT * FROM user WHERE email = ?");
        $sql->bind_param("s", $email);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items[0] ?? null;
    }

    // public function getCategoryById($id){
    //     $sql = self::$connection->prepare("SELECT * FROM category WHERE id = ?");
    //     $sql->bind_param("i", $id);
    //     $sql->execute();
    //     $items = array();
    //     $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
    //     return $items[0];
    // }
}
