<?php

include_once("objAplicacion.php");
include_once("Collector.php");

class AplicacionCollector extends Collector{
  

 function createAplicacion($descripcion) {    
    $insertrow = self::$db->insertRow("INSERT INTO sg_m_aplicacion (id_transaccion, descripcion) VALUES (?, ?)", array(null, "{$descripcion}"));
  }  

   }
?>