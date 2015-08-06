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
    public class P_Percha
    {
        RN_Percha RN_per = new RN_Percha();

        public DataSet GetAll()
        {
            return RN_per.GetAll();
        }

        public E_Percha GetOne(int CodigoPercha)
        {
            return RN_per.GetOne(CodigoPercha);
        }
    }
}
