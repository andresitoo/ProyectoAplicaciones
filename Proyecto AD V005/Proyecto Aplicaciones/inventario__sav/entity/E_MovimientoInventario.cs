using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_MovimientoInventario
    {
      
            #region Constructor
            public E_MovimientoInventario()
            {
                CodigoMovimientoInventario = 0;
                TipoDocumento = string.Empty;
                DescripcionMovimientoInventario = string.Empty;
                AsociadoA = string.Empty;
                Estado = 0;
            }
            #endregion

            #region Encapsulamiento
            public int CodigoMovimientoInventario { get; set; }
            public string TipoDocumento { get; set; }
            public string DescripcionMovimientoInventario { get; set; }
            public string AsociadoA { get; set; }
            public int Estado { get; set; }
            #endregion
    }
}
