<?php
session_start();

if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true) {
  header("location.welcome.php");
  exit;
}

require_once('connect.php');

$username = $password = "";
$username_err = $password_err = "";

if($_SERVER["REQUEST_METHOD"] == "POST") {
  if(empty(trim($_POST["username"]))) {
    $username_err = "Please enter your username";
  } else {
    $username = trim($_POST["username"]);
  }
  
  if(empty(trim($_POST["password"]))) {
    $password_err = "Please enter your password";
  } else {
    $password = trim($_POST["password"]);
  }
  
  if(empty($username_err) && empty($password_err)) {
    $sql = "SELECT id, username, password FROM users WHERE username = ?";
  
    if($stmt = mysqli_prepare($connect, $sql)) {
      mysqli_stmt_bind_param($stmt, "s", $param_username);
      $param_username = $username;
  
      if(mysqli_stmt_execute($stmt)) {
        mysqli_stmt_store_result($stmt);
  
        if(mysqli_stmt_num_rows($stmt) == 1) {
          mysqli_stmt_bind_result($stmt, $id, $username, $hashed_password);
  
          if(mysqli_stmt_fetch($stmt)) {

            if(password_verify($password, $hashed_password)) {
              session_start();
  
              $_SESSION["loggedin"] = true;
              $_SESSION["id"] = $id;
              $_SESSION["username"] = $username;
  
              header("location: welcome.php");
            } else {
              $password_err = "The password you entered is not valid";
            }
          }
        } else {
          $username_err = "No account found with that username";
        }
      } else {
        echo "Something went wrong. Please try again later";
      }
      mysqli_stmt_close($stmt);
    }
  }
  mysqli_close($connect);
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    <link rel="stylesheet" href="../CSS/style.css"></link>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>

    <title>VGR: Video Game Reviews</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
      
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav mr-auto">
            <li class="nav-item">
              <a class="nav-link" href="index.php"></a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="aboutus.php"></a>
            </li>
          </ul>
          <img src="../CSS/logo2.png" id="logopic">
          <a href="register.php"><button class="btn btn-outline-primary my-0 my-sm-0" type="submit">Register</button></a>
        </div>
      </nav>
      <div id="page-container">
        <div id="content-wrap">
          <div class="blockdiv">
            <h1>Sign In</h1>
            <div class="label">
            <label>Please login with your account</label>
          </div>
          <form id="siteform" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
          <div class="form-group <? echo (!empty($username_err)) ? 'has-error' : '';?>">
            <label>Username</label></br>
            <input type="text" name="username" placeholder="Username" class="login" id="username" value="<?php echo $username ?>"></br>
            <span class="help-block"><?php echo $username_err; ?></span></br>
          </div>
          <div class="form-group" <?php echo (!empty($password_err)) ? 'has-error' : ''; ?>>
          <label>Password</label></br>
            <input type="password" name="password" placeholder="Password" class="login" id="password"><br>
            <span class="help-block"><?php echo $password_err; ?></span></br>
          </div>
            <div class="loginbutton form-group">
            <input type="submit" name="submit" value="Login" class="btn btn-outline-success my-2 my-sm-0 login"></br>
          </div>
            <div class="labelbottom">
            <label>You don't have an account?</label></br>
            <label>Register <a href="register.php">here</a> or Download our application <a href="#">here</a></label>
          </div>
          </form>
        </div>
        </div>
        <footer id="footer" class="bg-dark align-items-center  my-auto">
          <div class="footerlink"><span class="text">Quick Links</span><br>
          <a href="#">Home</a>
          <a href="#">About us</a>
          <a href="#">See Reviews</a>
          <a href="#">Write a Review</a>
          <a href="#">Got an issue?</a>
          <span id="footerlogo">VGR</span>
          <span id="vgr2020">2021 VGR: Video Game Reviews</span>
        </div>
        </footer>
      </div>    
</body>
</html>