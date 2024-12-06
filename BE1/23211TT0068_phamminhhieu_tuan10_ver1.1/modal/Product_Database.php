<?php
require_once "Database.php";
class Product_Database extends Database
{

    public function editProduct($id, $name, $price, $desc, $image, $category_id)
    {
        $sql = self::$connection->prepare("UPDATE product SET name = ?, price = ?, `desc` = ?, image = ?, category_id = ? WHERE id = ?");
        $sql->bind_param("sdssii", $name, $price, $desc, $image, $category_id, $id);
        return $sql->execute();
    }

    public function deleteProduct($id)
    {
        $sql = self::$connection->prepare("DELETE FROM product WHERE id = ?");
        $sql->bind_param("i", $id);
        return $sql->execute();
    }

    public function addProduct($id, $name, $price, $desc, $image, $category_id)
    {
        $sql = self::$connection->prepare("INSERT INTO product VALUES(?, ?, ?, ?, ?, ?)");
        $sql->bind_param("isdssi", $id, $name, $price, $desc, $image, $category_id);
        return $sql->execute();
    }

    public function getAllProducts_pagination($page, $perPage)
    {
        $startRecord = ($page - 1) * $perPage;
        $sql = self::$connection->prepare("SELECT * FROM product LIMIT ?, ?");
        $sql->bind_param("ii", $startRecord, $perPage);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

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
        $keyword2 = "%$keyword%";
        $sql = self::$connection->prepare("SELECT count(*) as total FROM product WHERE name LIKE ? or `desc` LIKE ?");
        $sql->bind_param("ss", $keyword2, $keyword2);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_assoc();
        return $items["total"];
    }

    public function sreach_pagination($keyword, $page, $perPage)
    {
        $keyword2 = "%$keyword%";
        $startRecord = ($page - 1) * $perPage;
        $sql = self::$connection->prepare("SELECT * FROM product WHERE name LIKE ? or `desc` LIKE ? LIMIT ?, ?");
        $sql->bind_param("ssii", $keyword2, $keyword2, $startRecord, $perPage);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;
    }

    public function nagivationBar($url, $page, $perPage, $total)
    {
        // if ($url[-1] == "?") {

        // }
        $links = "";
        $maxPage = ceil($total / $perPage);
        $pre = $page > 1 ? $page - 1 : $page;
        $next = $page < $maxPage ? $page + 1 : $maxPage;
        $links .= "<li class='page-item'><a href='$url&page=$pre' class='page-link'>Previous</a></li>";
        for ($i = 1; $i <= $maxPage; $i++) {
            if ($i == $page) {
                $links .= "<li class='page-item'><a href='$url&page=$i' class='page-link active'>$i</a></li>";
            } else {
                $links .= "<li class='page-item'><a href='$url&page=$i' class='page-link'>$i</a></li>";
            }
        }
        $links .= "<li class='page-item'><a href='$url&page=$next' class='page-link'>Next</a></li>";
        return $links;
    }

    public function sreach_categoroy_pagination($category_id, $page, $perPage)
    {$startRecord = ($page - 1) * $perPage;
        $sql = self::$connection->prepare("SELECT * FROM product WHERE category_id = ? LIMIT ?, ?");
        $sql->bind_param("iii", $category_id, $startRecord, $perPage);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items;}

// public function getAllProducts_pagination($page, $perPage)
// {
// $startRecord = ($page - 1) * $perPage;
// $sql = self::$connection->prepare("SELECT * FROM product LIMIT ?, ?");
// $sql->bind_param("ii", $startRecord, $perPage);
// $sql->execute();
// $items = array();
// $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
// return $items;
// }

    public function product_total()
    {
        $sql = self::$connection->prepare("SELECT count(*) as total FROM product");
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_assoc();
        return $items["total"];
    }

    public function productByCategoryId_total($category_id)
    {
        $sql = self::$connection->prepare("SELECT count(*) as total FROM product WHERE category_id = ?");
        $sql->bind_param("i", $category_id);
        $sql->execute();
        $items = array();
        $items = $sql->get_result()->fetch_assoc();
        return $items["total"];
    }
}
