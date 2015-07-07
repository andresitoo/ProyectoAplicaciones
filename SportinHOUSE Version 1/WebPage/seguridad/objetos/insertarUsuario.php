<?php

include_once("UsuarioCollector.php");

$valor1=$_POST["usuario"];
$valor2=$_POST["contraseña"];

$UsuarioCollectorAux = new UsuarioCollector();
$UsuarioCollectorAux->createUsuario($valor1,$valor2);

echo "funciono";

?>