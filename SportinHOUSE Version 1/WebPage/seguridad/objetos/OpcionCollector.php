<?php

include_once("objOpcion.php");
include_once("Collector.php");

class OpcionCollector extends Collector{
  

 function createOpcion($descripcion) {    
    $insertrow = self::$db->insertRow("INSERT INTO sg_m_opcion (id_opcion, descripcion) VALUES (?, ?)", array(null, "{$descripcion}"));
  }  

   }
?>