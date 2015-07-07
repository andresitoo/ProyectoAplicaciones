<?php
class objUsuario
{
    private $Id_Usuario;
    private $Usuario;
    private $Contraseña;
    
    
    function __construct($Id_Usuario,$Usuario,$Contraseña)
    {
        $this->Id=$Id_Usuario;
        $this->Usuario=$Usuario;
        $this->Contra=$Contraseña;
    }
    
    function setId($Id_Usuario)
    {
        $this->Id=$Id_Usuario;        
    }
    function getId()
    {
        return $this->Id;
    }
    
    function setUsuario($Usuario)
    {
        $this->Usuario=$Usuario;
    }
    function getUsuario()
    {
        return $this->Usuario;
    }
      
    function setContra($Contraseña)
    {
        $this->Contraseña=$Contraseña;
    }
    function getContra()
    {
        return $this->Contraseña;
    }

}
?>
