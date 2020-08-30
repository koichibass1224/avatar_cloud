<?php

//PDO MySQL接続
function connectDB(){

//ユーザ名やDBアドレスの定義
    // $dsn = 'mysql:dbname=unity;host=localhost;charset=utf8';
    $dsn = 'mysql:dbname=end2_db;host=localhost;charset=utf8';
    $username = 'root';
    $password = 'root';

    try {
        $pdo = new PDO($dsn, $username, $password);
    } catch (PDOException $e) {
        exit('' . $e->getMessage());
    }

    return $pdo;
}