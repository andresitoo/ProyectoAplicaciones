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
    public class P_Medida
    {
        RN_Medida RN_med = new RN_Medida();

        public DataSet GetAll()
        {
            return RN_med.GetAll();
        }

        public E_Medida GetOne(int CodigoMedida)
        {
            return RN_med.GetOne(CodigoMedida);
        }
    }
}
