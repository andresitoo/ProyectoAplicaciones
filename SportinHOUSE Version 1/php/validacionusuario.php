<?php
	$usuario= $_POST["usuario"];
    $valor1 = "amorales";
    $valor2 = "aede";
	

	if($usuario==$valor1 or $usuario==$valor2 ){
		echo "<meta http-equiv='Refresh' content='1;../loginpass.php'>";
}
