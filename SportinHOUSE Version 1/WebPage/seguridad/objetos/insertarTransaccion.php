<?php

include_once("TransaccionCollector.php");

$valor1=$_POST["descripcion"];

$TransaccionCollectorAux = new TransaccionCollector();
$TransaccionCollectorAux->createTransaccion($valor1);

echo "funciono";

?>