<?php
session_start();
require_once('connect.php');
$html="";
$gid = $_SESSION['gid'];
$sql = "SELECT * FROM reviews  WHERE GameID = $gid";
$result = $connect -> query($sql);
if(!$result)
{
    $html = 'SQL error';
}
else
{  
    $html = '<table class="table-bordered"></tr><th>Username</th><th>Review</th><th>Action</th></tr>';
    while($row = $result -> fetch_array())
    {
        $html .= '<tr>';
        $html .= '<td>'.$row[3].'</td>';
        $html .= '<td>'.$row[4].'</td>';
        $html .= '<td><span data-id="'.$row[0].'" class="btn del"> &#10060; </span></td>';
        $html .= '</tr>';
    }
    $html .= '</table>';
}
echo $html;
$connect -> close();