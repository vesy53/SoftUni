<?php
if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    echo $n * 2;
}
?>

<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
