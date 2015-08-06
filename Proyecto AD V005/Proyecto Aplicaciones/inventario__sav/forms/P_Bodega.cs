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
    public class P_Bodega
    {
        RN_Bodega RN_Bod = new RN_Bodega();
        
        public DataSet GetAll()
        {
            return RN_Bod.GetAll();
        }

        public E_Bodega GetOne(int CodBodega)
        {
            return RN_Bod.GetOne(CodBodega);
        }
    }
}
