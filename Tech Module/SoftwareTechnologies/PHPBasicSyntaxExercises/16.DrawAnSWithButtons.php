<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
$rowSize = 9;
$colSize = 5;

for($row = 0; $row < $rowSize; $row++) {
    for($col = 0; $col < $colSize; $col++) {
        if($row == 0 || $row == ($rowSize - 1) / 2 || $row == $rowSize - 1) {
            echo "<button style='background-color:blue'>1</button>";
        } else if(($row < 4 && $col == 0) ||
            ($row > 4 && $col == $colSize - 1)) {
            echo "<button style='background-color:blue'>1</button>";
        }
        else {
            echo "<button>0</button>";
        }
    }

    echo "</br>";
}
?>
</body>
</html>