<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cstudents.aspx.cs" Inherits="ip_web.Cstudents" %>

<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->
	<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title>School Resource Allocation System</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="Free HTML5 Template by FREEHTML5.CO" />
	<meta name="keywords" content="free html5, free template, free bootstrap, html5, css3, mobile first, responsive" />
	<meta name="author" content="FREEHTML5.CO" />
         <link rel="title icon" href="images/title.png" />
  <!-- 
	//////////////////////////////////////////////////////

	FREE HTML5 TEMPLATE 
	DESIGNED & DEVELOPED by FREEHTML5.CO
		
	Website: 		http://freehtml5.co/
	Email: 			info@freehtml5.co
	Twitter: 		http://twitter.com/fh5co
	Facebook: 		https://www.facebook.com/fh5co

	//////////////////////////////////////////////////////
	 -->

  <!-- Facebook and Twitter integration -->
	<meta property="og:title" content=""/>
	<meta property="og:image" content=""/>
	<meta property="og:url" content=""/>
	<meta property="og:site_name" content=""/>
	<meta property="og:description" content=""/>
	<meta name="twitter:title" content="" />
	<meta name="twitter:image" content="" />
	<meta name="twitter:url" content="" />
	<meta name="twitter:card" content="" />

	<!-- Place favicon.ico and apple-touch-icon.png in the root directory -->
	<link rel="shortcut icon" href="favicon.ico">

	<!-- Google Webfonts -->
	<link href='http://fonts.googleapis.com/css?family=Roboto:400,300,100,500' rel='stylesheet' type='text/css'>
	<link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
	
	<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">
	<!-- Icomoon Icon Fonts-->
	<link rel="stylesheet" href="css/icomoon.css">
	<!-- Owl Carousel -->
	<link rel="stylesheet" href="css/owl.carousel.min.css">
	<link rel="stylesheet" href="css/owl.theme.default.min.css">
	<!-- Magnific Popup -->
	<link rel="stylesheet" href="css/magnific-popup.css">
	<!-- Theme Style -->
	<link rel="stylesheet" href="css/style.css">
	<!-- Modernizr JS -->
	<script src="js/modernizr-2.6.2.min.js"></script>
	<!-- FOR IE9 below -->
	<!--[if lt IE 9]>
	<script src="js/respond.min.js"></script>
	<![endif]-->

	</head>
	<body >
		
	<header id="fh5co-header" role="banner">
		<nav class="navbar navbar-default" role="navigation">
			<div class="container-fluid">
				<div class="navbar-header"> 
				<!-- Mobile Toggle Menu Button -->
				<a href="#" class="js-fh5co-nav-toggle fh5co-nav-toggle" data-toggle="collapse" data-target="#fh5co-navbar" aria-expanded="false" aria-controls="navbar"><i></i></a>
				<a class="navbar-brand" href="index.html">Resource Allocation System</a>
				</div>
				<div id="fh5co-navbar" class="navbar-collapse collapse">
					<ul class="nav navbar-nav navbar-right">
						<li class="active"><a href="index.html"><span>Home <span class="border"></span></span></a></li>
						<li><a href="login.aspx"><span>Login <span class="border"></span></span></a></li>
					</ul>
				</div>
			</div>
		</nav>
	</header>
	<!-- END .header -->
	
	<div class="fh5co-slider">
		<div class="owl-carousel owl-carousel-fullwidth">
		    <div class="item" style="background-image:url(images/slide_5.jpg)">
		    	<div class="fh5co-overlay"></div>
		    	<div class="container">
		    		<div class="row">
		    			<div class="col-md-8 col-md-offset-2">
			    			<div class="fh5co-owl-text-wrap">
						    	<div class="fh5co-owl-text text-center to-animate">
									<h1 class="fh5co-lead">School Resources</h1>
									<h2 class="fh5co-sub-lead">School Academy is a community of learners including students, parents and staff who are dedicated to creating an academically rigorous, culturally caring and inclusive learning environment. We are Reaching Excellence in Academics and Changing History! Together, we are champions of knowledge, our communities, the environment and of our futures.</h2>
						    	</div>
						    </div>
					    </div>
		    		</div>
		    	</div>
		    </div>
		    
		    <div class="item" style="background-image:url(images/slide_6.jpg)">
		    	<div class="fh5co-overlay"></div>
		    	<div class="container">
		    		<div class="row">
		    			<div class="col-md-8 col-md-offset-2">
			    			<div class="fh5co-owl-text-wrap">
								<div class="fh5co-owl-text text-center to-animate">
									<h1 class="fh5co-lead">School Achievers</h1>
									<h2 class="fh5co-sub-lead"> School Achievers are goal-oriented, critical thinkers and community leaders who are dedicated to achieving the highest level of integrity and academic success.</h2> 
								</div>
						    </div>
					    </div>
		    		</div>
		    	</div>
		    </div>
		</div>
	</div>	
	<div id="fh5co-main">
		<!-- Features -->
        <div><form id="form1" runat="server" style="text-align: center">
    
<div style="text-align: center">
    <asp:Label ID="Label1" runat="server" Text="Label"  Visible="False"></asp:Label> <br><br />
    <asp:Label ID="Label2" runat="server" Text="Student" Font-Bold="True" Font-Size="XX-Large" ForeColor="#25D366"></asp:Label>
    
          <asp:GridView ID="GridView2" runat="server" Height="150px" Width="100%" style="margin-left: 0px" AutoGenerateColumns="true" BackColor="#66CCFF" BorderColor="Green" BorderStyle="Solid" HorizontalAlign="Center" Font-Bold="True" Font-Size="X-Large" ForeColor="Black">
                <HeaderStyle BorderColor="#FF3300" />
                <RowStyle BackColor="#B7DBFF" BorderColor="Fuchsia" />
                 <Columns>
					<asp:BoundField DataField="no" HeaderText="No" ItemStyle-Width="30" >
						<ItemStyle Width="30px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="date" HeaderText="Date" ItemStyle-Width="100" >
						<ItemStyle Width="100px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="grade" HeaderText="Grade" ItemStyle-Width="50" >
						<ItemStyle Width="50px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="class" HeaderText="Class" ItemStyle-Width="150" >
						<ItemStyle Width="150px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="subject" HeaderText="Subject" ItemStyle-Width="80" >
						<ItemStyle Width="80px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="Class_Room_Lab" HeaderText="Class_Room_Lab" ItemStyle-Width="150" >
						<ItemStyle Width="150px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="Class_Room_Lab_ID" HeaderText="Class_Room_Lab_ID" ItemStyle-Width="150" >
						<ItemStyle Width="150px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="Teacher" HeaderText="Teacher" ItemStyle-Width="150" >
						<ItemStyle Width="150px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="time" HeaderText="Time" ItemStyle-Width="150" >
						<ItemStyle Width="150px"></ItemStyle>
					</asp:BoundField>
				</Columns>
            </asp:GridView>
        </div>
        <br />
			
		   <div style="text-align: center">
			  <asp:Button ID="Button1" runat="server" Text="Full Time Table" OnClick="Button1_Click" /></div>
				<br />
			<div>
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" BackColor="LightYellow" BorderColor="Green" BorderStyle="Solid" BorderWidth="2px" Width="1378px"  HorizontalAlign="Center" ForeColor="Black">
           <RowStyle BackColor="LightGreen" BorderColor="Green" />
           <Columns>
			<asp:BoundField DataField="no" HeaderText="No" ItemStyle-Width="30" >
				<ItemStyle Width="30px"></ItemStyle>
			</asp:BoundField>
			<asp:BoundField DataField="date" HeaderText="Date" ItemStyle-Width="100" >
				<ItemStyle Width="100px"></ItemStyle>
			</asp:BoundField>
			<asp:BoundField DataField="grade" HeaderText="Grade" ItemStyle-Width="50" >
				<ItemStyle Width="50px"></ItemStyle>
			 </asp:BoundField>
			<asp:BoundField DataField="class" HeaderText="Class" ItemStyle-Width="150" >
				<ItemStyle Width="150px"></ItemStyle>
			</asp:BoundField>
			<asp:BoundField DataField="subject" HeaderText="Subject" ItemStyle-Width="80" >
				<ItemStyle Width="80px"></ItemStyle>
			</asp:BoundField>
			<asp:BoundField DataField="Class_Room_Lab" HeaderText="Class_Room_Lab" ItemStyle-Width="150" >
				<ItemStyle Width="150px"></ItemStyle>
			</asp:BoundField>
			<asp:BoundField DataField="Class_Room_Lab_ID" HeaderText="Class_Room_Lab_ID" ItemStyle-Width="150" >
				<ItemStyle Width="150px"></ItemStyle>
			 </asp:BoundField>
			 <asp:BoundField DataField="Teacher" HeaderText="Teacher" ItemStyle-Width="150" >
				<ItemStyle Width="150px"></ItemStyle>
			 </asp:BoundField>
			 <asp:BoundField DataField="time" HeaderText="Time" ItemStyle-Width="150" >
				<ItemStyle Width="150px"></ItemStyle>
			 </asp:BoundField>
			</Columns>
       </asp:GridView>
        </div>
        <br /><br />
        <div style="text-align: center">
            <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" /></div>
    </form></div>
		
	</div>

	<footer id="fh5co-footer">
		
		<div class="container">
			<div class="row">
				<div class="col-md-6 col-sm-6">
					<div class="fh5co-footer-widget">
						<h2 class="fh5co-footer-logo">School Resource Allocation System</h2>
						<p></p>
					</div>
					<div class="fh5co-footer-widget">
						<ul class="fh5co-social">
							<li><a href="https://www.facebook.com/100066490605132/posts/105051185054568/?d=n"><i class="icon-facebook"></i></a></li>
							<li><a href="#"><i class="icon-twitter"></i></a></li>
							<li><a href="#"><i class="icon-instagram"></i></a></li>
							<li><a href="#"><i class="icon-linkedin"></i></a></li>
							<li><a href="#"><i class="icon-youtube"></i></a></li>
						</ul>
					</div>
				</div>
		<div class="visible-sm-block clearfix"></div>
			</div>
			<div class="row fh5co-row-padded fh5co-copyright">
				<div class="col-md-5"><p><small>&copy; All Rights Reserved.</small></p>
				</div>
			</div>
		</div>
	</footer>


	<!-- jQuery -->
	<script src="js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Owl carousel -->
	<script src="js/owl.carousel.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Magnific Popup -->
	<script src="js/jquery.magnific-popup.min.js"></script>
	<!-- Main JS -->
	<script src="js/main.js"></script>

	
	</body>
</html>
