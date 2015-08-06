using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Entity;
using ReglasNegocio;

namespace Forms
{
    public class P_MovimientoInventario
    {
         RN_MovimientoInventario  RN_movInv = new RN_MovimientoInventario();
        
        public DataSet GetAll()
        {
            return RN_movInv.GetAll();
        }

        public E_MovimientoInventario GetOne(int CodMovInv)
        {
            return RN_movInv.GetOne(CodMovInv);
        }
    }
}
