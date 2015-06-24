<?php
session_start()
?>

<!DOCTYPE HTML>
<html>
<head>
<title>Sporting House</title>
<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
<link href="css/style.css" rel='stylesheet' type='text/css' />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Open+Sans+Condensed:300,700' rel='stylesheet' type='text/css'>
<link rel="shortcut icon" href="images/store.ico" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />-->
<script src="js/jquery.min.js"></script>
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
 <!-- start header_top -->
	<div class="header">
	   <div class="container">
		  <div class="header-text">
			<h4 class="title"><a href="indexprincipal.php"><img src="images/storelogin.png" alt=""/></a>Sporting House</h4>
            
            <form name="ingreso" action="php/validacionusuario.php" method="post">
           
						  <fieldset class="input">
						    <p id="login-form-username">
						      <label for="modlgn_username" class="user">User</label>

						      <input id="usuario" type="text" name="usuario" class="inputbox" size="18" autocomplete="off">
						    </p> 
                            <div class="remember">
							    <p id="login-form-remember">
							      <label for="modlgn_remember">Atención:</label>
 									<label for="modlgn_remember">En caso de que no tenga usuario, o su usuario se encuentre 		bloqueado acercarse al departamento de Seguridad. </label>
							   </p>
							    <input type="submit" name="Submit" class="button" value="Siguiente">
                               </div>
                            </fieldset>
						 </form>
			
			
		  </div>
		  <div class="header-arrow">

		  </div>
	    </div>
	  </div>
	<!-- end header_top -->
	<!-- start header_bottom -->
	
</body>
</html>