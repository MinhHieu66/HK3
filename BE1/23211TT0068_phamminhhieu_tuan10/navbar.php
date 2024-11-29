<?php session_id() || session_start()?>
<nav class="navbar navbar-expand-lg navbar-light bg-light">
    <div class="container px-4 px-lg-5">
        <a class="navbar-brand" href="#!">Start Bootstrap</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span
                class="navbar-toggler-icon"></span></button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0 ms-lg-4">
                <li class="nav-item"><a class="nav-link active" aria-current="page" href="page.php">Home</a></li>
                <li class="nav-item"><a class="nav-link" href="#!">About</a></li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button"
                        data-bs-toggle="dropdown" aria-expanded="false">Danh mục sản phẩm</a>
                    <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                        <?php foreach ($categories as $category): ?>
                        <li><a class="dropdown-item"
                                href="page.php?category_id=<?=$category["id"]?>&page=1"><?=$category["name"]?></a>
                        </li>
                        <?php endforeach?>

                    </ul>
                </li>
            </ul>

            <form class="d-flex" action="page.php">
                <input type="hidden" name="page" value="1">
                <input type="text" name="keyword" class="form-control me-3" placeholder="Từ khóa..."
                    value="<?=isset($_GET["keyword"]) ? $_GET["keyword"] : ""?>" required>
                <button type="submit" class="btn btn btn-outline-dark me-3">Tìm</button>
            </form>


            <form action="login.html" method="POST">
                <button type="submit" class="btn btn btn-dark me-3">Đăng nhập</button>
            </form>

            <form action="login.html" method="POST">
                <button type="submit" class="btn btn btn-dark me-3">Đăng xuất</button>
            </form>



            <form class="d-flex" action="cart.php">
                <button class="btn btn-outline-dark" type="submit">
                    <i class="bi-cart-fill me-1"></i>
                    Cart
                    <span class="badge bg-dark text-white ms-1 rounded-pill">
                        <?=isset($_SESSION["cart"]) ? count($_SESSION["cart"]) : "0"?>
                    </span>
                </button>
            </form>
        </div>
    </div>
</nav>