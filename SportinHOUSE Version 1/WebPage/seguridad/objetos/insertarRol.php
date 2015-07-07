<?php

include_once("RolCollector.php");

$valor1=$_POST["descripcion"];

$RolCollectorAux = new RolCollector();
$RolCollectorAux->createRol($valor1);

echo "funciono";

?>