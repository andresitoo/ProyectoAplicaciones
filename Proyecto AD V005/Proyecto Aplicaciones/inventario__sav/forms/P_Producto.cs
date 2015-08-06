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
    public class P_Producto
    {
        RN_Producto RN_Prod = new RN_Producto();
        
        public DataSet GetAll()
        {
            return RN_Prod.GetAll();
        }

        public E_Producto GetOne(int CodigoProducto)
        {
            return RN_Prod.GetOne(CodigoProducto);
        }



      

    }
}
