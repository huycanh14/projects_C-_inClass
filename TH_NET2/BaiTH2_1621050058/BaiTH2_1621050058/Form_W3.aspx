<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_W3.aspx.cs" Inherits="BaiTH2_1621050058.Form_W3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title>Thực hành W3.CSS</title>
	<link rel="stylesheet" href="css/all.min.css">
	<link rel="stylesheet" href="css/bootstrap.min.css">
	<link rel="stylesheet" href="css/animate.css">
	<link rel="stylesheet" href="css/form_w3.css">
</head>
<body>
    <form id="form1" runat="server">
       <header id="header" class="">
		    <div class="container-fluid">
			    <h3>Album - Tin học mỏ K56 - HUMG</h3>
		    </div>
	    </header><!-- /header -->
	<div id="content">
		<div class="container-fluid clearfix">
			<div class="dong1">
				<div class="row">
					<div class="col-xl-4"><img src="image/b1_1.jpg" alt="" class="animated bounceInDown"></div>
					<div class="col-xl-4"><img src="image/b1_2.jpg" alt="" class="animated zoomInRight delay-1s"></div>
					<div class="col-xl-4"><img src="image/b1_3.jpg" alt="" class="animated bounceInDown delay-2s"></div>
				</div>
			</div>

			<div class="row">
				<div class="col-xl-4"><img src="image/b1_4.jpg" alt="" class="animated fadeInLeft delay-1.5s"></div>
				<div class="col-xl-4"><img src="image/b1_5.jpg" alt="" class="animated zoomInRight delay-2.5s"></div>
				<div class="col-xl-4"><img src="image/b1_6.jpg" alt="" class="animated jackInTheBox delay-3s"></div>
			</div>
		</div>
	</div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script src="js/popper.min.js"></script>
</body>
</html>
