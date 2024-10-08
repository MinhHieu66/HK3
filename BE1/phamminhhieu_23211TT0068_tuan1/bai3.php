<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bai 3</title>
    <style>
    table,
    th,
    td {
        border: 1px solid black;
        border-collapse: collapse;
    }

    table {
        width: 100%;
    }

    tr th {
        background-color: yellow;
        color: red;
    }
    </style>
</head>

<body>
    <?php
    $rows = 100;
    $col = 3;
    
    ?>
    <table>
        <thead>
            <tr>
                <?php for($k = 1; $k <= $col; $k++){?>
                <th>Tiêu đề <?= $k?></th>
                <?php }?>
            </tr>
        </thead>
        <tbody>
            <?php 
            
            for($j = 1; $j <= $rows; $j++){?>
            <tr>
                <?php for($i = 1; $i <= $col; $i++){ ?>
                <td><?= "Cot " . $i . ", Hang" . $j ?></td>

                <?php }
                }?>
            </tr>
        </tbody>
    </table>
</body>

</html>