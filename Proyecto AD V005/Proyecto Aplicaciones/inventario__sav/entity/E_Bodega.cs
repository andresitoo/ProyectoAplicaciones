using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Bodega
    {

         #region Constructor
        public E_Bodega()
        {
            Codigo_Bodega = 0;
            Descripcion_Bodega = string.Empty; 
            DireccionBodega = string.Empty ;
            CantidadPercha = string.Empty;
            ResponsableBodega = string.Empty;
            Estado = 0;
        }
        #endregion

        #region Encapsulamiento

        public int Codigo_Bodega { get; set; }
        public string Descripcion_Bodega { get; set; }
        public string DireccionBodega { get; set; }
        public string CantidadPercha { get; set; }
        public string ResponsableBodega { get; set; }
        public int Estado { get; set; }

        #endregion
    }
}
