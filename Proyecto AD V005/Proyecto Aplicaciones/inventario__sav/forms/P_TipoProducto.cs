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
    public class P_TipoProducto
    {
        RN_TipoProducto RN_tip = new RN_TipoProducto();

        public DataSet GetAll()
        {
            return RN_tip.GetAll();
        }

        public E_TipoProducto GetOne(int CodTipoProducto)
        {
            return RN_tip.GetOne(CodTipoProducto);
        }

    }
}
