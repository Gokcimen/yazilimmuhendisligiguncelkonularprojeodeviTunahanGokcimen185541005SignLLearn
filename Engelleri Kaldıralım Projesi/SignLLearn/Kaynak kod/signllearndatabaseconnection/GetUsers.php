<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "signllearndatabase";
// Create connection
$conn = new mysqli($servername, $username, $password,$dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully.<br><br>";


$sql = "SELECT username, password FROM user";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo "username: " . $row["username"]. " - password: " . $row["password"]. "<br>";
  }
} else {
  echo "0 results";
}
$conn->close();
?>