<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Bai_so_1.form.home" %>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title>Home: Hồ Chí Minh</title>
	<link rel="stylesheet" href="../css/all.min.css">
	<link rel="stylesheet" href="../css/bootstrap.min.css">
	<link rel="stylesheet" href="../css/style_home.css">
</head>
<body>
	<header id="header" class="">
		<nav class="navbar navbar-light bg-faded">
			<div class="container">
				<center style="width: 100%;">
					<img src="../image/banner.jpg" alt="">	
				</center>
			</div>
		</nav>
	</header><!-- /header -->
	<div id="content">
		<div class="container">
			<div class="row">
				<div class="col-xl-4">
					<div class="item_image">
						<div class="../image"><img src="../image/nk1.jpg" alt=""></div>
						<div class="link">
							<a href="Trang1_nhatkytrongtu.aspx" class="btn btn-block text-xl-center">Học đánh cờ</a>
						</div>
					</div>
				</div>

				<div class="col-xl-4">
					<div class="item_image">
						<div class="image"><img src="../image/chuctet.jpg" alt=""></div>
						<div class="link">
							<a href="Trang2_chuctet.aspx" class="btn btn-block text-xl-center">Học đánh cờ</a>
						</div>
					</div>
				</div>

				<div class="col-xl-4">
					<div class="item_image">
						<div class="image"><img src="../image/muaxuanhcm.jpg" alt=""></div>
						<div class="link">
							<a href="Trang3_Nuocvietnam.aspx" class="btn btn-block text-xl-center">Học đánh cờ</a>
						</div>
					</div>
				</div>


			</div>
		</div>
	</div>	

	<script src="../js/jquery-3.3.1.min.js"></script>
	<script src="../js/bootstrap.min.js"></script>
	<script src="../js/popper.min.js"></script>
</body>
</html>
