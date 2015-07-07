<?php

include_once("objTransaccion.php");
include_once("Collector.php");

class TransaccionCollector extends Collector{
  

 function createTransaccion($descripcion) {    
    $insertrow = self::$db->insertRow("INSERT INTO sg_m_transaccion (id_transaccion, descripcion) VALUES (?, ?)", array(null, "{$descripcion}"));
  }  

   }
?>