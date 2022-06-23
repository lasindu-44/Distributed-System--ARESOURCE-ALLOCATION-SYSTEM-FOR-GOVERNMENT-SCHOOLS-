<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staff.aspx.cs" Inherits="ip_web.staff" %>

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

        <style>
#GridView3 {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#GridView3 td, #customers th {
  border: 1px solid #ddd;
  padding: 8px;
}

#GridView3 tr:nth-child(even){background-color: #f2f2f2;}

#GridView3 tr:hover {background-color: #ddd;}

#GridView3 th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
}
</style>

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
						<li ><a href="index.html"><span>Home <span class="border"></span></span></a></li>
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
        <br /><br />
	<div id="fh5co-main">
		<!-- Features -->
        <div> <form id="form1" runat="server">
        <div padding-left="100px" align="center">
            
			<!--
			<asp:GridView ID="GridView2" runat="server" Height="10px" Width="1505px" style="margin-left: 0px; margin-right: 0px;" AutoGenerateColumns="false" BackColor="white" BorderColor="Blue" BorderStyle="Solid" HorizontalAlign="Center" Font-Bold="True" Font-Size="X-Large" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" ForeColor="#25D366" >
            </asp:GridView>
			-->
            <p><asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Grade 6-9 Time Table View" /></p>
            <p><asp:Button ID="Button3" runat="server" OnClick="Button2_Click1" Text="Grade 10-11 O/L Time Table View" /></p>
            <p><asp:Button ID="Button7" runat="server" OnClick="Button3_Click" Text="Grade 12-13 A/L Time Table View" /></p>
			<asp:Label ID="LabelName" runat="server" Text="" Font-Bold="True" Font-Size="XX-Large" ForeColor="#25D366"></asp:Label>
			<br />
			<!--
           <asp:GridView ID="GridView5" runat="server"  Height="150px" Width="1516px" style="margin-left: 0px; padding-top: 12px;  padding-bottom: 12px;  text-align: left;  background-color: #443f3b;  color: white;" AutoGenerateColumns="false" BackColor="#99CCFF" BorderColor="Blue" BorderStyle="Solid"  Font-Bold="True" Font-Size="X-Large" ForeColor="#25D366">
                 <RowStyle BackColor="#16125e" BorderColor="Fuchsia" />
                 <Columns>
					<asp:BoundField DataField="no" HeaderText="Nox" ItemStyle-Width="30" >
						<ItemStyle Width="30px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="date" HeaderText="Date" ItemStyle-Width="100" >
						<ItemStyle Width="100px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="grade" HeaderText="Grade" ItemStyle-Width="50" >
						<ItemStyle Width="50px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="class" HeaderText="Class" ItemStyle-Width="150" >
						<ItemStyle Width="150px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="subject" HeaderText="Subject" ItemStyle-Width="80" >
						<ItemStyle Width="80px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="Class_Room_Lab" HeaderText="Class_Room_Lab" ItemStyle-Width="150" >
						<ItemStyle Width="150px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="Class_Room_Lab_ID" HeaderText="Class_Room_Lab_ID" ItemStyle-Width="150" >
						<ItemStyle Width="150px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="teacher" HeaderText="Teacher" ItemStyle-Width="150" >
						<ItemStyle Width="150px" Height="15px"></ItemStyle>
					</asp:BoundField>
					<asp:BoundField DataField="time" HeaderText="Time" ItemStyle-Width="150" >
						<ItemStyle Width="150px" Height="15px"></ItemStyle>
					</asp:BoundField>
				</Columns>
            </asp:GridView>
            <asp:GridView ID="GridView3" runat="server" Height="150px" Width="1516px" style="margin-left: 0px; padding-top: 12px;  padding-bottom: 12px;  text-align: left;  background-color: #443f3b;  color: white;" AutoGenerateColumns="false" BackColor="#99CCFF" BorderColor="Blue" BorderStyle="Solid"  Font-Bold="True" Font-Size="X-Large" ForeColor="#25D366">
                <RowStyle BackColor="#16125e" BorderColor="Fuchsia" />
                 <Columns>
					<asp:BoundField DataField="no" HeaderText="Noy" ItemStyle-Width="30" >
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
				-->
            </div>
            </div>
      <div style="text-align: center">  
			<asp:GridView ID="GridView1" runat="server" style="margin-left: 0px; padding-top: 12px;  padding-bottom: 12px;  text-align: left;  background-color: #443f3b;  color: white;" AutoGenerateColumns="false" BackColor="#99CCFF" BorderColor="Blue" BorderStyle="Solid" BorderWidth="2px" Width="1378px"  HorizontalAlign="Center" ForeColor="#25D366">
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
            <RowStyle BackColor="#16125e" BorderColor="Fuchsia" />
        </asp:GridView>
          </div>
        <br /><br />
        <br />
    <div>
    </div>
        <div>
        <p align="center"></p>
		</div>
        <br /><br />
		<br /><br />
         <div style="text-align: center">
             <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click1" />
         </div>
    </form></div>
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
							<li><a href="#"><i class="icon-facebook"></i></a></li>
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

