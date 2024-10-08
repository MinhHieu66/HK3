<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng ký</title>
    <link rel="stylesheet" href="../vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">

    <!-- <style>
        table,
        th,
        td {
            border: 1px solid black;
            border-collapse: collapse;
        }

        table {
            width: 100%;
        }

        .top {
            margin-top: 50px;
        }
    </style> -->
</head>

<body>
    <div class="row">
        <div class="col-md-6 m-auto">
            <div class="container mt-5 bg-primary py-3 rounded-5">
                <h2>Đăng ký</h2>
                <form action="register-result.php" method="POST">
                    <div class="mb-3">
                        <label for="username" class="form-label">Username</label>
                        <input type="text" name="username" id="username" class="form-control" required>
                    </div>

                    <div class="mb-3">
                        <label for="password" class="form-label">Password</label>
                        <input type="password" name="password" id="password" class="form-control" required>
                    </div>

                    <div class="mb-3">
                        <label for="firstname" class="form-label">Tên</label>
                        <input type="text" name="firstname" id="firstname" class="form-control" required>
                    </div>

                    <div class="mb-3">
                        <label for="lastname" class="form-label">Họ</label>
                        <input type="text" name="lastname" id="lastname" class="form-control" required>
                    </div>

                    <button type="submit" class="btn btn-warning">Đăng ký</button>

                </form>
            </div>
        </div>
    </div>

</body>

</html>