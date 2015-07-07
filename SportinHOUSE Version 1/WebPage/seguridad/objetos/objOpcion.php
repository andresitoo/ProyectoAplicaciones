<?php
class objOpcion
{
    private $Id_Opcion;
    private $Descripcion;
    
    function __construct($Id_Opcion,$Descripcion)
    {
        $this->Id=$Id_Opcion;
        $this->Usuario=$Usuario;
    }
    
    function setId($Id_Opcion)
    {
        $this->Id=$$Id_Opcion;        
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
