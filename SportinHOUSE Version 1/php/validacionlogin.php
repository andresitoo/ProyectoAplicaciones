<!DOCTYPE HTML>
<html>

<?php
	$usuario=$_POST["usuario"];
    $contrasena=$_POST["pass"];
    $valor1 = "amorales";
    $valor2 = "aede";

	if($valor1==$usuario){
		
		echo "<meta http-equiv='Refresh' content='0;../webpage/seguridad/index.php'>";
		
		}else{
			if($valor2==$usuario){
			 
			 echo "<meta http-equiv='Refresh' content='0;../webpage/inventario/index.php'>";
			}

			}
?>


</html>