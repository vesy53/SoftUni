<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if(isset($_GET['num'])){
    $num = intval($_GET['num']);

    $trib1 = 1;
    $trib2 = 1;
    $trib3 = 2;

    $nextTrib = 0;

    echo $trib1 . " " . $trib2 . " " . $trib3 . " ";

    for($i = 1; $i <= $num - 3; $i++) {
        $nextTrib = $trib1 + $trib2 + $trib3;
        $trib1 = $trib2;
        $trib2 = $trib3;
        $trib3 = $nextTrib;

        echo $nextTrib . " ";
    }
}
?>
</body>
</html>