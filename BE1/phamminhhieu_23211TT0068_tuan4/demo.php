<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Demo</title>
    <style>
        table, th, td{
            border: 1px black solid;
        }
        table{
            border-collapse: collapse ;
        }
    </style>
</head>
<body>
    <?php
    // $cars = array("Volvo", "BMW", "Toyota");
    // foreach($cars as $key=>$car){
    //     $count = ++$key;
    //     echo "<p style='color: green'> $count - $car</p>";
    //     // echo $key+1 . "-" . $car;
    //     // echo "<br>";
    // }

    $cars = array(
        array("Volvo", 22, 18),
        array("BMW", 15, 13),
        array("Saab", 5, 2),
        array("Land Rover", 17, 15),
    );
    
    // foreach($cars as $value){
    //     echo $value[0] . ": In stock: " . $value[1] . ", sold: " .$value[2];
    //     echo "<br>";
    // }

     ?>
     <table>
        <thead>
            <tr>
                <th>Brand</th>
                <th>InStock</th>
                <th>Sold</th>
            </tr>
        </thead>
        <tbody>
            <?php foreach($cars as $car): ?>
            <tr>
                <td><?php echo $car[0]?></td>
                <td><?php echo $car[1]?></td>
                <td><?php echo $car[2]?></td>
            </tr>
            <?php endforeach?>
        </tbody>
     </table>
     
</body>
</html>
