function validacions(f) {
    
    if (document.ingreso.usuario.length ==0) 
    { 
        alert('El nombre esta vacío'); 
        document.ingreso.usuario.focus()
        return false; 
    }
    else{
        window.open('http://127.0.0.1:51457/WebPage/Inventario/IndexInventario.html','','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, width=420, height=480, left=0, top=0');
    return true; 
    }
}