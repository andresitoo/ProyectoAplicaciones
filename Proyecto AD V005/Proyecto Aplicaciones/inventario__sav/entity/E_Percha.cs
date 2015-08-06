using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Percha
    {
        #region Constructor
        public E_Percha()
        {
            Codigo_Percha = 0;
            Descripcion_Percha = string.Empty; 
            Ubicacion_Percha = string.Empty ;
            Cantidad_Niveles_Percha = string.Empty;
            Estado = 0;
        }
       #endregion

       #region Encapsulamiento
        public int Codigo_Percha { get; set; }
        public string Descripcion_Percha { get; set; }
        public string Ubicacion_Percha { get; set; }
        public string Cantidad_Niveles_Percha { get; set; }
        public int Estado { get; set; }
       #endregion
    }
}
