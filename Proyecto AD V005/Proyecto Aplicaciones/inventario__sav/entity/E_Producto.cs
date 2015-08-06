using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Producto
    {     
    
        #region Constructor

        public E_Producto()
        {
            Codigo_Producto = 0;
            Descripcion_Producto =string.Empty ;
            TipoProducto = string.Empty;
            Medida = string.Empty; 
            Bodega = string.Empty;
            Percha = string.Empty;
            ExistenciaActual = 0;
            Stock_Minimo = 0;
            Stock_Maximo = 0;
            Costo = 0;
            Precio = 0;
            Estado=0;
        }
        #endregion

        #region Encapsulamiento

        public int Codigo_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public string TipoProducto { get; set; }
        public string Medida { get; set; }
        public string Bodega { get; set; }
        public string Percha { get; set; }
        public int ExistenciaActual { get; set; }
        public int Stock_Minimo { get; set; }
        public int Stock_Maximo { get; set; }
        public int Costo { get; set; }
        public int Precio { get; set; }
        public int Estado { get; set; }
       // public byte[] Imagen { get; set; }
        //public MemoryStream ayuda { get; set; }
        

        #endregion
    }
}