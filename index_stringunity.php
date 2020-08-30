<?php

// include("function/functions.php");
// $pdo = connectDB();

// $stmt = $pdo->prepare("SELECT COUNT(*) FROM user_table");
// $status = $stmt->execute();
// $count = $stmt->fetchColumn(); 

//     $view .=$count;

// $id = $_GET["id"];
$id = 8;

// require "../Datatest 08292159/function/functions.php";
require "../function/functions.php";
$pdo = connectDB();

// $stmt = $pdo->prepare("SELECT * FROM message_table WHERE id=:id");
$stmt = $pdo->prepare("SELECT * FROM message_table WHERE id=:id");
$stmt ->bindvalue(":id",$id,PDO::PARAM_INT);
$status = $stmt->execute();

if ($status == false) { 
  sql_error($stmt);
}else{
  $row = $stmt->fetch();
  // $view .= '"'.$row['ad2'].'"'; 
  $view .= strval($row['ad2']); 

  // $json = json_encode( $view ) ;//
}

?>

<!DOCTYPE html>
<html lang="en-us">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>Unity WebGL Player | PHP test_2</title>
    <link rel="shortcut icon" href="TemplateData/favicon.ico">
    <link rel="stylesheet" href="TemplateData/style.css">
    <script src="TemplateData/UnityProgress.js"></script>
    <script src="Build/UnityLoader.js"></script>
    <script>
      var unityInstance = UnityLoader.instantiate("unityContainer", "Build/Datatest String08302013.json", {onProgress: UnityProgress});

      // var  js_test =JSON.parse('<?php echo $json; ?>');
      // var js = "<?php echo $view; ?>";
      // var testObject = {name:"John" , age: 34};
      // var testObject = {name:"<?php echo $view; ?>"};
      // var jsonString = JSON.stringify(testObject);

      // document.open();
      // document.write(jsonString);
      // document.close();
      
    </script>

</head>
<body>
  <div class="webgl-content">
    <div id="unityContainer" style="width: 960px; height: 600px"></div>
    <div class="footer">
      <div class="webgl-logo"></div>
      <div class="fullscreen" onclick="unityInstance.SetFullscreen(1)"></div>
      <div class="title">Data test_2</div>

  <!-- <div style="border:solid 1px black; width:200px; height:30px; margin:auto; text-align:center" onclick="unityInstance.SendMessage('GameResultPlay_2','SetString','Hello')">STRING</div> -->

  <div style="border:solid 1px bGY90lack; width:200px; height:30px; margin:auto; text-align:center" onclick="unityInstance.SendMessage('GameResultPlay_2','SetString','<?=$view?>')">STRING</div>

 <!-- <div style="border:solid 1px black; width:200px; height:30px; margin:auto; text-align:center" onclick="unityInstance.SendMessage('GameResultPlay_2','SetString',<?=$json?>)">STRING</div>  -->

 <!-- <div style="border:solid 1px bGY90lack; width:200px; height:30px; margin:auto; text-align:center" onclick="unityInstance.SendMessage('GameResultPlay_2','SetString',js)">STRING</div> -->

  <!-- <p><?=$row['ad2']?></p> -->
  <p><?=$view?></p>
  <!-- <p><?=$json?></p> -->

  <!-- json -->
  <!-- <div style="border:solid 1px black; width:200px; height:30px; margin:auto; text-align:center" onclick="unityInstance.SendMessage('JavascriptHook','Testjson',jsonString)">JSON OBJECT</div> -->
<!-- 
  <div style="border:solid 1px black; width:200px; height:30px; margin:auto; text-align:center" onclick="unityInstance.SendMessage('GameResultPlay_3','Testjson',<?=$json?>)">JSON OBJECT</div>  -->


</div>
</div>
</body>
</html>
