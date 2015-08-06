
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Transferencia
    {
         #region Constructor
        public E_Transferencia()
        {
            Codigo_Transferencia = 0;
            Bodega_Saliente = string.Empty;
            Bodega_Entrante = string.Empty;
            Responsable = string.Empty; 
            Motivo = string.Empty ;
            Estado = 0;
        }
       #endregion

       #region Encapsulamiento

        public int Codigo_Transferencia { get; set; }
        public string Bodega_Saliente { get; set; }
        public string Bodega_Entrante { get; set; }
        public string Responsable { get; set; }
        public string Motivo { get; set; }
        public int Estado { get; set; }
       #endregion

    }
    }
