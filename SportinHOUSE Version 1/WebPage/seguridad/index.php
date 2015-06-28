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
                        <li class="active"><a href="../../indexprincipal.php"><img src="../../images/salir.png" alt=""/>Salir</a></li>
                    </ul>
               </li>
                 <li class="active"><a href="#">Mantenimiento</a>
               		<ul>
                    	<li class="active"><a href="mantenimiento/usuario.php"><img src="../../images/usuario.png" alt=""/>Usuario</a></li>					
                        <li class="active"><a href="mantenimiento/rol.php"><img src="../../images/rol.png" alt=""/>Rol</a></li>
                       
                        <li class="active"><a href="mantenimiento/aplicacion.php"><img src="../../images/aplicacion.png" alt=""/>Aplicación</a></li>
                        <li class="active"><a href="mantenimiento/transaccion.php"><img src="../../images/transaccion.png" alt=""/>Transacción</a></li>
                          <li class="active"><a href="mantenimiento/opcion.php"><img src="../../images/opcion.png" alt=""/>Opción</a></li>
                          
                    </ul>
               </li>
                
                 <li class="active"><a href="#">Procesos</a>
               		<ul>
                    	<li class="active"><a href="1"><img src="../../images/rol.png" alt=""/>Asignación de Roles</a></li>
                        <li class="active"><a href="2"><img src="../../images/aplicacion.png" alt=""/>Asignación de Aplicaciones</a></li>
                        <li class="active"><a href="2"><img src="../../images/transaccion.png" alt=""/>Asignación de Transaccioness</a></li>
                        <li class="active"><a href="2"><img src="../../images/opcion.png" alt=""/>Asignación de Opciones</a></li>
                        <li class="active"><a href="3"><img src="../../images/cambiocontraseña.png" alt=""/>Cambio de Contraseña</a></li>
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
     
		   
           
	       <div class="clear"></div>
     </div>
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