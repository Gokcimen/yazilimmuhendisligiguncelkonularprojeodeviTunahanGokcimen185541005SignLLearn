<?php
$servername = "localhost";
$username = "root";
$paswword = "";
$dbname = "signllearndatabase";


$loginUser =$_POST["loginUser"];
$loginPass =$_POST["loginPass"];

$conn new mysqli($servername,$username,$paswword,$dbname);

if ($conn->connect_error){
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT  paswword FROM user where username= '" . $loginUser . "'";

$result = $conn->query($sql);

if ($result->num_rows > 0) {

    while($row =$result->fetch_assoc()){
      
        echo "User Name already taken."

    }
} else{
    echo "Creating user..."
    $sql2 = "INSERT INTO user (username, paswword,alive) VALUES ('". $loginUser . "', '" . $loginPass . "',1)";
    if ($conn->query($sql2) === TRUE) {
        echo "New record created successfully";
      } else {
        echo "Error: " . $sql2 . "<br>" . $conn->error;
      }
}



$conn->close();
?>