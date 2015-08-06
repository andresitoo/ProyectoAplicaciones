using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Medida
    {
        #region Constructor
        public E_Medida()
        {
            Codigo_Medida = 0;
            Descripcion_Medida = string.Empty; 
            Estado = 0;
        }
       #endregion

       #region Encapsulamiento
        public int Codigo_Medida { get; set; }
        public string Descripcion_Medida { get; set; }
        public int Estado { get; set; }
       #endregion
    }
}
