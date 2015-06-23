function validacions() {
    
    if (document.getElementById('modlgn_username').value =='') 
    { 
        alert('El nombre esta vacío'); 
        return false; 
    }
    else{
        if (document.getElementById('modlgn_username').value =='aede'){ 
        <!-- document.location('WebPage/Inventario/IndexInventario.html','','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, width=1024, height=480, left=0, target="_blank", top=0');->
        
        }
        else{
            if (document.getElementById('modlgn_username').value =='amorales'){ 
       document.location.
	   <!-- document.location('WebPage/Seguridad/index.html','','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, width=1024, height=640, left=0, target="_blank", top=0');->
        }
            
        }
    return true; 
    }
}