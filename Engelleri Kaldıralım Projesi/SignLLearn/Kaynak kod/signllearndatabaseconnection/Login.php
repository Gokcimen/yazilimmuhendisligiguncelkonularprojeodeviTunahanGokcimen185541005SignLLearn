<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "signllearndatabase";

$loginUser =  isset($_POST['loginUser']);
$loginPass = isset($_POST['loginPass']);


// Create connection
$conn = new mysqli($servername, $username, $password,$dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully.<br><br>";




$sql = "SELECT  password,username FROM user where username =  '" .$loginUser . "'";

$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    if($row["password"] == $loginPass){
        echo "Login Succes."     
    }
    else{
        echo "Wrong Credentials."
    }

  }
} else {
    echo "User Name not exist."
}
$conn->close();
?>