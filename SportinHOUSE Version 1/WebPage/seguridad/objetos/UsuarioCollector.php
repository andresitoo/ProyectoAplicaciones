<?php

include_once("objUsuario.php");
include_once("Collector.php");

class UsuarioCollector extends Collector{
  

 function createUsuario($usuario,$contrasena) {    
    $insertrow = self::$db->insertRow("INSERT INTO usuario (idusuario,usuario,contrasena) VALUES (?, ?, ?)", array(null, "{$usuario}", "{$contrasena}"));
  }  

  function readUsuarios($usuario) {
   
    $rows = self::$db->getRows("SELECT * FROM usuario WHERE usuario = '".$usuario."' ");        
           
   if (!$rows)   {
    	echo "<meta http-equiv='Refresh' content='0;../../../sesiones/loginusuario.php'>";
    } else{

        $_SESSION['usuario']= $usuario;
          echo "<meta http-equiv='Refresh' content='0;../../../sesiones/loginpass.php'>";
    
    }
	}

function readPass($usuario,$contrasena) {
   
    $rows = self::$db->getRows("SELECT * FROM usuario WHERE usuario = '$usuario' AND contrasena = '$contrasena' ");        
           
   if (!$rows)   {
      echo "<meta http-equiv='Refresh' content='0;../../../sesiones/loginpass.php'>";
    } else{
        echo "<meta http-equiv='Refresh' content='0;../../../sesiones/indexprincipal.php'>";

    }
  }

 }
?>