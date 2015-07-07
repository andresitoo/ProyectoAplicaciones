<?php
class objRol
{
    private $Id_Rol;
    private $Descripcion;
    
    function __construct($Id_Rol,$Descripcion)
    {
        $this->Id=$Id_Rol;
        $this->Usuario=$Usuario;
    }
    
    function setId($Id_Rol)
    {
        $this->Id=$$Id_Rol;        
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
