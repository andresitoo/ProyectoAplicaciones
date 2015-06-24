<!--A Design by W3layouts
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE HTML>
<html>
<head>
<title>Sporting House</title>
<link href="../../css/bootstrap.css" rel='stylesheet' type='text/css' />
<link href="../../css/style.css" rel='stylesheet' type='text/css' />
<link rel="shortcut icon" href="../../images/store.ico" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="imagetoolbar" content="no" />
	<meta name="keywords" content="slideman, sliderman.js, javascript slider, jquery, slideshow, effects" />
	<meta name="description" content="Sliderman.js - will do all the sliding for you :)" />

<script type="text/javascript" src="../../js/sliderman.1.3.8.js"></script>
	<link rel="stylesheet" type="text/css" href="../../css/sliderman.css" />
<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Open+Sans+Condensed:300,700' rel='stylesheet' type='text/css'>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />-->
<script src="../../js/jquery.min.js"></script>

<script type="text/javascript">
		jQuery(document).ready(function($) {
			$(".scroll").click(function(event){		
				event.preventDefault();
				$('html,body').animate({scrollTop:$(this.hash).offset().top},1200);
			});
		});
	</script>
<!-- grid-slider -->
<script type="text/javascript" src="../../js/jquery.mousewheel.js"></script>
<script type="text/javascript" src="../../js/jquery.contentcarousel.js"></script>
<script type="text/javascript" src="../../js/jquery.easing.1.3.js"></script>
<!-- //grid-slider -->

</head>
<body>

	<!-- start menu -->
    <div class="menu" id="menu">
	  <div class="container">
		 <div class="logo">
			<a href="../seguridad/index.php"><img src="../../images/store.png" alt=""/></a>
		 </div>
		 <div class="h_menu4"><!-- start h_menu4 -->
		   <a class="toggleMenu" href="#">Menu</a>
			 <ul class="nav">
			   <li class="active"><a href="#"> Inicio</a>
               		<ul>
                        <li class="active"><a href="2"><img src="../../images/ayuda.png" alt=""/>Ayuda</a></li>
                        <li class="active"><a href="../../login.php"><img src="../../images/salir.png" alt=""/>Salir</a></li>
                    </ul>
               </li>
                 <li class="active"><a href="#">Seguridad</a>
               		<ul>
                    	<li class="active"><a href="1"><img src="../../images/usuario.png" alt=""/>Usuario</a></li>					
                        <li class="active"><a href="3"><img src="../../images/rol.png" alt=""/>Rol</a></li>
                       
                        <li class="active"><a href="2"><img src="../../images/aplicacion.png" alt=""/>Aplicación</a></li>
                        <li class="active"><a href="3"><img src="../../images/transaccion.png" alt=""/>Transacción</a></li>
                          <li class="active"><a href="3"><img src="../../images/opcion.png" alt=""/>Opción</a></li>
                          <li class="active"><a href="3"><img src="../../images/asignacion.png" alt=""/>Asignación de Permisos</a></li>
                    </ul>
               </li>
                
                 <li class="active"><a href="#">Procesos</a>
               		<ul>
                    	<li class="active"><a href="1">Asignación de Roles</a></li>
                        <li class="active"><a href="2">Asignación de Aplicaciones</a></li>
                        <li class="active"><a href="2">Asignación de Transaccioness</a></li>
                        <li class="active"><a href="2">Asignación de Opciones</a></li>
                        <li class="active"><a href="3">Cambio de Contraseña</a></li>
                    </ul>
               </li>
			    <li class="active"><a href="#">Reportes</a>
               		<ul>
                    	<li class="active"><a href="1">opcion1</a></li>
                        <li class="active"><a href="2">opcion2</a></li>
                        <li class="active"><a href="3">opcion3</a></li>
                    </ul>
               </li>
			 </ul>
			  <script type="text/javascript" src="../../js/nav.js"></script>
		  </div><!-- end h_menu4 -->
          
          
		 <div class="clear"></div>
	  </div>
	</div>
	<!-- end menu -->

				   <h3 class="bienvenido">Bienvenido !</h3>
				   <h3 class="parrafo">Sporting House brinda los mejores productos a todo su publico on line. </h3>
      
     <p>&nbsp;</p>
     <p>&nbsp;</p>

     <div id="slider_container_2">

				<div id="SliderName_2" class="SliderName_2">
					<img src="../../images/home_01.jpg" height="1400"  width="500" usemap="#img1map" title="Demo2 first" />
				
					
					<img src="../../images/home_02.jpg" width="1400" height="500" alt="Demo2 second" title="Demo2 second" />
					
					<img src="../../images/home_03.jpg" width="1400" height="500" alt="Demo2 third" title="Demo2 third" />
					
					<img src="../../images/home_04.jpg" width="1400" height="500" alt="Demo2 fourth" title="Demo2 fourth" />
					
	   </div>
                
				<div class="c"></div>
				<div id="SliderNameNavigation_2"></div>
				<div class="c"></div>

	   <script type="text/javascript">
					effectsDemo2 = 'rain,stairs,fade';
					var demoSlider_2 = Sliderman.slider({container: 'SliderName_2', width: 1100, height: 500, effects: effectsDemo2,
						display: {
							autoplay: 3000,
							loading: {background: '#000000', opacity: 0.5, image: 'img/loading.gif'},
							buttons: {hide: true, opacity: 1, prev: {className: 'SliderNamePrev_2', label: ''}, next: {className: 'SliderNameNext_2', label: ''}},
							description: {hide: true, background: '#000000', opacity: 0.4, height: 50, position: 'bottom'},
							navigation: {container: 'SliderNameNavigation_2', label: '<img src="img/clear.gif" />'}
						}
					});
				</script>
	   

	   <!-- end content-top -->
      <div class="row about">
		 <div class="col-md-8">
		     	 <h3 class="m_2">Gallery</h3>
		     	 <div id="ca-container" class="ca-container">
				    <div class="ca-wrapper">
				         <div class="ca-item ca-item-1">
						   <div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon1"> </div>
							</div>
						  </div>
						<div class="ca-item ca-item-2">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon2"> </div>
							</div>
						</div>
						<div class="ca-item ca-item-3">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon3"> </div>
							</div>
						</div>
						<div class="ca-item ca-item-4">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon4"> </div>
						     </div>
						</div>
						<div class="ca-item ca-item-5">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon5"> </div>
							</div>
						</div>
						<div class="ca-item ca-item-6">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon6"> </div>
							</div>
						</div>
						<div class="ca-item ca-item-7">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon7"> </div>
							</div>
						</div>
						<div class="ca-item ca-item-8">
							<div class="ca-item-main">
								<div class="ca-icon"> </div>
								<div class="ca-icon"> </div>
							</div>
						</div>
			    </div>
			 </div>
				    <script type="text/javascript">
						$('#ca-container').contentcarousel();
					</script>
		   </div>
		   <div class="col-md-4">
		   	 <h3 class="m_2">Partner</h3>
			  <ul class="partner">
			  	<li><img src="../../images/p6.png" alt=""/></li>
			  	<li><img src="../../images/p5.png" alt=""/></li>
			  	<li><img src="../../images/p4.png" alt=""/></li>
			  	<li><img src="../../images/p3.png" alt=""/></li>
			  	
			  	 <div class="clear"></div>
			  </ul>
		   </div>
	       <div class="clear"></div>
	      </div>
	     </div>
	    <!--<div class="map">
			<iframe width="100%" height="450" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=United+Kingdom&amp;aq=0&amp;oq=un&amp;sll=37.0625,-95.677068&amp;sspn=48.956293,107.138672&amp;ie=UTF8&amp;hq=&amp;hnear=United+Kingdom&amp;ll=55.378051,-3.435973&amp;spn=135.795411,68.554687&amp;t=m&amp;z=2&amp;output=embed"> </iframe><br /><small><a href="http://maps.google.com/maps?f=q&amp;source=embed&amp;hl=en&amp;geocode=&amp;q=United+Kingdom&amp;aq=0&amp;oq=un&amp;sll=37.0625,-95.677068&amp;sspn=48.956293,107.138672&amp;ie=UTF8&amp;hq=&amp;hnear=United+Kingdom&amp;ll=55.378051,-3.435973&amp;spn=135.795411,68.554687&amp;t=m&amp;z=2" style="color:#666;font-size:12px;text-align:left"> </a></small>
			<div class="opening_hours">
			 <ul class="times">
			 	<h3>Opening <span class="opening">Hours</span></h3>
			 	<li><i class="calender"> </i><span class="week">Monday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			 	<li><i class="calender"> </i><span class="week">Tuesday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			 	<li><i class="calender"> </i><span class="week">Wednesday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			 	<li><i class="calender"> </i><span class="week">Thrusday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			 	<li><i class="calender"> </i><span class="week">Friday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			 	<li><i class="calender"> </i><span class="week">Saturday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			 	<li><i class="calender"> </i><span class="week">Sunday</span><div class="hours">h.6:00-h.24:00</div>  <div class="clear"></div></li>
			    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet</p>
			 	<h4>Enjoy it!</h4>
			 </ul>
		    </div>
		 </div>
		 <div class="footer-top">
		 	<ul class="twitter_footer">
		 	 <li>
		 	   <i class="twt_icon"> </i><p>aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel  <span class="m_6">2 days ago</span></p>
		 	   <div class="clear"></div>
		 	 </li>
		 	</ul>
		 </div>
		 <div class="footer-bottom">
		   <div class="container">
		 	 <div class="row section group">
				<div class="col-md-4">
				   <h4 class="m_7">Newsletter Signup</h4>
				   <p class="m_8">Lorem ipsum dolor sit amet, consectetuer adipiscing elit sed diam nonummy.</p>
				      <form class="subscribe">
			             <input type="text" value="Insert Email" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Insert Email';}">
					  </form>
			          <div class="subscribe1">
			            <a href="#">Submit Email<i class="but_arrow"> </i></a>
			          </div>
				</div>
				<div class="col-md-4">
					<div class="f-logo">
						<img src="images/logo.png" alt=""/>
					</div>
					<p class="m_9">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis</p>
					<p class="address">Phone : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="m_10">(00) 222 666 444</span></p>
					<p class="address">Email : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="m_10">info[at]mycompany.com</span></p>
				</div>
				<div class="col-md-4">
					<ul class="list">
						<h4 class="m_7">Menu</h4>
						<li><a href="#">About</a></li>
						<li><a href="#">Trainers</a></li>
						<li><a href="#">Classes</a></li>
						<li><a href="#">Pricing</a></li>
						<li><a href="#">Privacy</a></li>
						<li><a href="#">Contact</a></li>
					</ul>
					<ul class="list1">
						<h4 class="m_7">Community</h4>
						<li><a href="#">Blog</a></li>
						<li><a href="#">Forum</a></li>
						<li><a href="#">Support</a></li>
						<li><a href="#">Newsletter</a></li>
					</ul>
				</div>
				<div class="clear"></div>
	  		  </div>
		 	</div>
		 </div>-->
		 <div class="copyright">
		  <div class="container">
		    <div class="copy">
		        <p>© 2014 Template by <a href="http://w3layouts.com" target="_blank"> w3layouts</a></p>
		    </div>
		    <div class="social">	
			   <ul>	
				  <li class="facebook"><a href="#"><span> </span></a></li>
				  <li class="twitter"><a href="#"><span> </span></a></li>
				  <li class="pinterest"><a href="#"><span> </span></a></li>	
				  <li class="google"><a href="#"><span> </span></a></li>
				  <li class="tumblr"><a href="#"><span> </span></a></li>
				  <li class="instagram"><a href="#"><span> </span></a></li>	
				  <li class="rss"><a href="#"><span> </span></a></li>							
			   </ul>
		    </div>
		   <div class="clear"></div>
		  </div>
	     </div>
</body>
</html>