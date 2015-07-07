<?php

include_once("AplicacionCollector.php");

$valor1=$_POST["descripcion"];

$AplicacionCollectorAux = new AplicacionCollector();
$AplicacionCollectorAux->createAplicacion($valor1);

echo "funciono";

?>