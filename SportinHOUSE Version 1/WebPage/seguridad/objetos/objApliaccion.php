<?php
class objApliaccion
{
    private $Id_Apliaccion;
    private $Descripcion;
    
    function __construct($Id_Apliaccion,$Descripcion)
    {
        $this->Id=$Id_Apliaccion;
        $this->Usuario=$Usuario;
    }
    
    function setId($Id_Apliaccion)
    {
        $this->Id=$$Id_Apliaccion;        
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
