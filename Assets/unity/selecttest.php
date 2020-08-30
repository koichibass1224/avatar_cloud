<?php

require_once('mysql_connect.php');
$pdo = connectDB();

//POSTうけとり
// $id = $_POST["id"]; //要求されてくるid
$contributor = $_POST["contributor"]; //要求されてくるid

try {
    //今回ここではSELECT文を送信している。UPDATE、DELETEなどは、また少し記法が異なる。
    // $stmt = $pdo->query("SELECT * FROM `test` WHERE `id` = '". $id. "'");
    $stmt = $pdo->query("SELECT * FROM message_table WHERE contributor =  '". $contributor. "'");
    foreach ($stmt as $row) {
      //今回はただカラムを指定し、出力された文字列を結合して出力
        // $res = $row['id'];
        $res1 = $row['ad1'];
        $res2 = $row['ad2'];
        //$res. $rowは全文を繰り返してくれる。
        // $res = $res. $row['ad3'];
        $res = $res. $row['contiributor'];
        // $res = $res. $row['indate'];
    }

} catch (PDOException $e) {
    var_dump($e->getMessage());
}
$pdo = null;    //DB切断

echo "$res1\n";  //unity に結果を返す
echo $res2;  //unity に結果を返す