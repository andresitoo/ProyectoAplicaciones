<?php
include_once("UsuarioCollector.php");

$contrasena=$_POST["pass"];
session_start();

$usuario= $_SESSION['usuario'];

$UsuarioCollectorAux = new UsuarioCollector();
$UsuarioCollectorAux->readPass($usuario,$contrasena);

?>