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
    class P_Transferencia
    {
        RN_TransferenciaBodega RN_trs = new RN_TransferenciaBodega();

        public DataSet GetAll()
        {
            return RN_trs.GetAll();
        }

        public E_Transferencia GetOne(int CodTransferencia)
        {
            return RN_trs.GetOne(CodTransferencia);
        }

    }
}
