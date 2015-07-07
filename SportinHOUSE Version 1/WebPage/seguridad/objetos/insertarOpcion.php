<?php

include_once("OpcionCollector.php");

$valor1=$_POST["descripcion"];

$OpcionCollectorAux = new OpcionCollector();
$OpcionCollectorAux->createOpcion($valor1);

echo "funciono";

?>