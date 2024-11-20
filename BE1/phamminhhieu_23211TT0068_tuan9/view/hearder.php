<div class="hearder">
    <div class="hearder-top">
        <nav class="navbar navbar-expand-lg bg-body-tertiary bg-warning fixed-top">
            <div class="container-fluid">
                <a class="navbar-brand" href="#"><img src="public/images/logo.png" alt="logo" width="50px"></a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                    data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false"
                    aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNavDropdown">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="trang_chu.php">Home</a>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown"
                                aria-expanded="false">
                                Tất cả sản phẩm
                            </a>
                            <ul class="dropdown-menu">
                                <?php foreach ($categories as $category): ?>
                                <li><a class="dropdown-item"
                                        href="trang_chu.php?category_id=<?=$category["id"]?>"><?=$category["name"]?></a>
                                </li>
                                <?php endforeach?>
                            </ul>
                        </li>
                    </ul>
                    <form class="d-flex ms-4" role="search" action="trang_chu.php">
                        <input class="form-control me-2" type="search" placeholder="" aria-label="Search" name="keyword"
                            value="<?=isset($_GET["keyword"]) ? $_GET["keyword"] : ""?>">
                        <button type="submit" class="btn btn-danger">Tìm kiếm</button>
                    </form>
                </div>
                <div class="profile">
                    <a href="#">
                        <i class="fa-regular fa-user"></i>
                        Đăng nhập
                    </a>
                </div>

                <div class="cart">
                    <a href="viewcart.php">
                        <i class="fa-solid fa-cart-shopping"></i>
                        Giỏ hàng
                    </a>
                </div>
            </div>

        </nav>
    </div>
    <div class="hearder-bottom bg-warning">
        <div class="container-fluid">
            <ul class="">
                <div class="row">
                    <div class="col-1">
                        <li>
                            <i class="fa-solid fa-mobile"></i>
                            <span>Điện thoại</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-solid fa-laptop"></i>
                            <span>Laptop</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-solid fa-bug"></i>
                            <span>Phụ kiện</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-solid fa-mobile"></i>
                            <span>Smartwatch</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-regular fa-clock"></i>
                            <span>Đồng hồ</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-regular fa-tablet"></i>
                            <span>Tablet</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-brands fa-apple"></i>
                            <span>Máy cũ</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-brands fa-snapchat"></i>
                            <span>PC</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-brands fa-github"></i>
                            <span>Thẻ cào</span>
                        </li>
                    </div>
                    <div class="col-1">
                        <li>
                            <i class="fa-brands fa-linkedin"></i>
                            <span>Khác</span>
                        </li>
                    </div>
                </div>
            </ul>
        </div>
    </div>
</div>