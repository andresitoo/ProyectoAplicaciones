using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_TipoProducto
    {
        #region Constructor
        public E_TipoProducto()
        {
            Codigo_TipoProducto = 0;
            Descripcion_TipoProducto = string.Empty; 
            Estado = 0;
        }
       #endregion

       #region Encapsulamiento
        public int Codigo_TipoProducto { get; set; }
        public string Descripcion_TipoProducto { get; set; }
        public int Estado { get; set; }
       #endregion
    }
}
