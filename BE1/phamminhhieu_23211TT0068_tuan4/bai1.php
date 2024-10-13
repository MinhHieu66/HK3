<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="vendor/bootstrap-5.0.2-dist/css/bootstrap.min.css">
    <title>Bai 1</title>
</head>
<body>
    <?php
    $students = array(
        'sv1'=>array('Tinhoc'=>10, 'KTLT'=>8, 'MMT'=>10),
        'sv2'=>array('Tinhoc'=>8, 'KTLT'=>8, 'MMT'=>9),
        'sv3'=>array('Tinhoc'=>9, 'KTLT'=>7, 'MMT'=>8),
    ); 

    // Them sinh vien sv5, sv7
    $sv5 = array('Tinhoc'=>10, 'KTLT'=>9, 'MMT'=>8);
    $sv7 = array('Tinhoc'=>8, 'KTLT'=>9, 'MMT'=>10);
    $students += ['sv5'=>$sv5, 'sv7'=>$sv7];

    // Sua diem KTLT sv3
    $students['sv3']['KTLT'] = 9;

    //Xoa sinh vien cuoi cung
    array_pop($students);

    //Xoa sinh vien 2
    array_splice($students, 1, 1);
    
    // foreach($students as $key=>$value){
    //     echo $key . " (Tin học: " . $value['Tinhoc'] . ' - Kỹ thuật lập trình: ' . $value['KTLT'] . " - Mạng máy tính: " . $value['MMT'] . ')';
    //     echo "<br>";
    // }
    ?>

    <div class="row">
        <div class="col-lg-6 m-auto">
        <table class="table table-dark text-center">
        <thead>
            <tr>
                <th>Họ tên</th>
                <th>Tin học</th>
                <th>KTLT</th>
                <th>MMT</th>
            </tr>
        </thead>
        <tbody>
            <?php foreach($students as $key=>$value):?>
            <tr>
                <td><?php echo $key?></td>
                <td><?php echo $value['Tinhoc']?></td>
                <td><?php echo $value['KTLT']?></td>
                <td><?php echo $value['MMT']?></td>
            </tr>
            <?php endforeach?>
        </tbody>
    </table>
        </div>
    </div>

    
   
</body>
</html>