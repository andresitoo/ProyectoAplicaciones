<!DOCTYPE HTML>
<html>
<head>
<title>Mantenimiento de Aplicación</title>
<link href="../../../css/bootstrap.css" rel='stylesheet' type='text/css' />
<link href="../../../css/style.css" rel='stylesheet' type='text/css' />
<link rel="shortcut icon" href="../../../images/store.ico" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="imagetoolbar" content="no" />
	<meta name="keywords" content="slideman, sliderman.js, javascript slider, jquery, slideshow, effects" />
	<meta name="description" content="Sliderman.js - will do all the sliding for you :)" />

<script type="text/javascript" src="../../../js/sliderman.1.3.8.js"></script>
	<link rel="stylesheet" type="text/css" href="../../../css/sliderman.css" />
<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Open+Sans+Condensed:300,700' rel='stylesheet' type='text/css'>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />-->
<script src="../../../js/jquery.min.js"></script>

<script type="text/javascript">
		jQuery(document).ready(function($) {
			$(".scroll").click(function(event){		
				event.preventDefault();
				$('html,body').animate({scrollTop:$(this.hash).offset().top},1200);
			});
		});
	</script>
<!-- grid-slider -->
<script type="text/javascript" src="js/jquery.mousewheel.js"></script>
<script type="text/javascript" src="js/jquery.contentcarousel.js"></script>
<script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
<!-- //grid-slider -->

</head>
<body>

	<!-- start menu -->
    <div class="menu" id="menu">
	  <div class="container">
		 <div class="logo"><a href="../index.php">
			<img src="../../../images/store.png" alt=""/></a>
		 </div>
		 <div class="h_menu4"><!-- start h_menu4 -->
		   <a class="toggleMenu" href="#">Menu</a>
			 <ul class="nav">
             
             <li class="opcionespantalla"><a href="loginusuario.php"><img src="../../../images/crear.png" alt=""/> Crear</a></li>
                <li class="opcionespantalla"><a href="loginusuario.php"><img src="../../../images/consultar.png" alt=""/> Consultar</a></li>
                <li class="opcionespantalla"><a href="loginusuario.php"><img src="../../../images/modificar.png" alt=""/> Editar</a></li>
                <li class="opcionespantalla"><a href="loginusuario.php"><img src="../../../images/eliminar.png" alt=""/> Eliminar</a></li>
    
		   </ul>
			  <script type="text/javascript" src="../../../js/nav.js"></script>
		  </div><!-- end h_menu4 -->
 <div class="clear"></div>
	  </div>
	</div>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
    <form class="formulariomantenimiento" name="ingreso" action="../objetos/insertarAplicacion.php" method="post">
           
  <fieldset class="input">
						    <p id="login-form-username">
                            <label for="modlgn_username" class="labelmantenimiento">Código:</label>
                            <input id="codigo" type="text" name="codigo" class="boxmantenimiento" size="18" autocomplete="off">
                            <button class="estilobutton2">
                             <img title="cdlibre.org" src="../../../images/busqueda.png" width="20" height="20" />
                            </button> 
                            <br><br>							    
                            <label for="modlgn_username" class="labelmantenimiento">Descripción:</label>
						    <input id="descripcion" type="text" name="descripcion" class="boxmantenimiento" size="18" autocomplete="off">
                            <br><br>							    
                            <button class="estilobutton">
                              <img title="cdlibre.org" src="../../../images/guardar.png" width="45" height="45" />
                              Guardar
                            </button>                             
                            </fieldset>
						 </form>
</div>
</body>
</html>
