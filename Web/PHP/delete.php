<?php
require_once('connect.php');

if($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['id']))
{
    $row = $connect -> real_escape_string($_POST['id']);
    $sql = "DELETE FROM reviews WHERE id = ?";

    if($stmt = $connect -> prepare($sql))
    {
        $stmt -> bind_param("i", $row);
        if(!$stmt -> execute())
        {
            echo ('SQL error - could not delete row');
        }
        $stmt -> close();
    }
    else
    {
        echo ('SQL error');
    }
}
$connect -> close();