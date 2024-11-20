<?php
require_once "Database.php";
class Product_Database extends Database
{
    public function getAllProducts()
    {
        $sql = self::$connection->prepare("SELECT * FROM product");
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

    public function getProductById($id)
    {
        $sql = self::$connection->prepare('SELECT * FROM product WHERE id = ?');
        $sql->bind_param("i", $id);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items[0];
    }

    public function getProductsByCategoryId($category_id)
    {
        $sql = self::$connection->prepare('SELECT * FROM product WHERE category_id = ?');
        $sql->bind_param("i", $category_id);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

    public function sreach($keyword)
    {
        $sql = self::$connection->prepare("SELECT * FROM product WHERE name LIKE '%$keyword%'");
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

    public function sreach_total($keyword)
    {
        $sql = self::$connection->prepare("SELECT count(*) as total FROM product WHERE name LIKE '%$keyword%'");
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_assoc();
        return $items["total"];
    }

    public function sreach_pagination($keyword, $page, $perPage)
    {
        $keyword2 = "%$keyword%";
        $startRecord = ($page - 1) * $perPage;
        $sql = self::$connection->prepare("SELECT * FROM product WHERE name LIKE ? LIMIT ?, ?");
        $sql->bind_param("sii", $keyword2, $startRecord, $perPage);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

    public function nagivationBar($url, $page, $perPage, $total)
    {
        $links = "";
        $maxPage = ceil($total / $perPage);
        $pre = $page > 1 ? $page - 1 : $page;
        $next = $page < $maxPage ? $page + 1 : $maxPage;
        $links .= "<a href='$url&page=1' class='m-2'><<</a>";
        $links .= "<a href='$url&page=$pre' class='m-2'><</a>";
        for ($i = 1; $i <= $maxPage; $i++) {
            if ($i == $page) {
                $links .= "<a href='$url&page=$i' class='m-2 border border-danger'>$i</a>";
            } else {
                $links .= "<a href='$url&page=$i' class='m-2'>$i</a>";
            }

        }

        $links .= "<a href='$url&page=$next' class='m-2'>></a>";
        $links .= "<a href='$url&page=$maxPage' class='m-2'>>></a>";
        return $links;
    }
}