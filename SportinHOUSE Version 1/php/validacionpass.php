<?php
	$usuario= $_POST["contraseña"];
    $valor1 = "amorales";
    $valor2 = "aede";
	

	if($usuario==$valor1  ){
		echo "<meta http-equiv='Refresh' content='0;../webpage/seguridad/index.php'>";
}else{
	if( $usuario==$valor2 ){
		echo "<meta http-equiv='Refresh' content='0;../webpage/inventario/index.php'>";
}
	}
