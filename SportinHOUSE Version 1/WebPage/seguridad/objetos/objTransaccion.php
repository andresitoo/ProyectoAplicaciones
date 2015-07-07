<?php
class objTransaccion
{
    private $Id_Transaccion;
    private $Descripcion;
    
    function __construct($Id_Transaccion,$Descripcion)
    {
        $this->Id=$Id_Transaccion;
        $this->Usuario=$Usuario;
    }
    
    function setId($Id_Transaccion)
    {
        $this->Id=$$Id_Transaccion;        
    }
    function getId()
    {
        return $this->Id;
    }
    
    function setDescripcion($Descripcion)
    {
        $this->Descripcion=$Descripcion;
    }
    function getDescripcion()
    {
        return $this->Descripcion;
    }
}
?>
