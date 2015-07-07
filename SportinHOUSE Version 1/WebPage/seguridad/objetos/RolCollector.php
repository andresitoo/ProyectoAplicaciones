<?php

include_once("objRol.php");
include_once("Collector.php");

class RolCollector extends Collector{
  

 function createRol($descripcion) {    
    $insertrow = self::$db->insertRow("INSERT INTO sg_m_rol (id_rol, descripcion) VALUES (?, ?)", array(null, "{$descripcion}"));
  }  

   }
?>