<?php
include_once("UsuarioCollector.php");

$usuario=$_POST["usuario"];

session_start();

$UsuarioCollectorAux = new UsuarioCollector();
$UsuarioCollectorAux->readUsuarios($usuario);

?>