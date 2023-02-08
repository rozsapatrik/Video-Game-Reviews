<?php

session_start();

if(!isset($_SESSION["loggedin"]) || $_SESSION["loggedin"] !== true) {
  header("location: login.php");
  exit;
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
              <a class="nav-link" href="index.php">Home</a>
            </li>
            <li class="nav-item active">
              <a class="nav-link" href="aboutus.php">About Us <span class="sr-only">(current)</span></a>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Game Reviews
              </a>
              <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                <a class="dropdown-item" href="seereviews.php">See Reviews</a>
                <a class="dropdown-item" href="towriteareview.php">Write A Review</a>
                <a class="dropdown-item" href="todeleteareview.php">Delete A Review</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="gotanissue.php">Got an issue?</a>
              </div>
            </li>
          </ul>
          <img src="../CSS/logo2.png" id="logopic">
          <a href="logout.php"><button class="btn btn-outline-primary my-0 my-sm-0" type="submit">Sign Out</button></a>
        </div>
      </nav>
      <div id="page-container">
        <div id="content-wrap">
          <div class="blockdiv">
            <h1>About Us</h1>
            <div class="label aboutus">
              <p>Everyone who is interested in video games just the slightest bit probably once in their life wanted to search for reviews on their game of choice because they
                weren't sure if that game was for them, now you no longer need to search on different forums, because we brought you VGR: Video Game Reviews</p>
                <p>VGR: Video Game Reviews is a completely free-to-use website/application so all you need to do in order to acces our data is to register (Top left corner).</p>
              <p>VGR: Video Game Reviews lets you share your opinion on all kinds of video games and it gives you the opportunity to read other's reviews as well rate them.</p>
              <p>VGR: Video Game Reviews is an ambitious project developed by one person so any kind of support is appreciated.</p>
            </div>
          </div>
        </div>
        <footer id="footer" class="bg-dark align-items-center  my-auto">
          <div class="footerlink"><span class="text">Quick Links</span><br>
          <a href="index.php">Home</a>
          <a href="aboutus.php">About us</a>
          <a href="seereviews.php">See Reviews</a>
          <a href="towriteareview.php">Write a Review</a>
          <a href="gotanissue.php">Got an issue?</a>
          <span id="footerlogo">VGR</span>
          <span id="vgr2020">2021 VGR: Video Game Reviews</span>
        </div>
        </footer>
      </div>
      
</body>
</html>