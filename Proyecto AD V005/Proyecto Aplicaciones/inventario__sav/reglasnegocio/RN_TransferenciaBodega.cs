using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


using Entity;
using Datos;

namespace ReglasNegocio
{
   public class RN_TransferenciaBodega
    {
        D_TransferenciaBodega conec = new D_TransferenciaBodega();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraTransferencia(string bodegaSaliente, string bodegaEntrante, string responsable, string motivo, string estado)
        {
            return this.conec.IngresaTransferencia(bodegaSaliente, bodegaEntrante,responsable,motivo, estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarTransaccion(int CodTransferenciaBodega, string bodegaSaliente, string bodegaEntrante, string responsable, string motivo, string estado)
        {
            return this.conec.ModificaTransferencia(CodTransferenciaBodega,bodegaSaliente, bodegaEntrante, responsable, motivo, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarTransaccion(int CodTransferenciaBodega)
        {
            return this.conec.EliminarTransferencia(CodTransferenciaBodega);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
        D_TransferenciaBodega d_trb = new D_TransferenciaBodega();

        public DataSet GetAll()
        {
            return d_trb.GetAll();
        }

        public E_Transferencia GetOne(int CodTransferenciaBodega)
        {
            return d_trb.GetOne(CodTransferenciaBodega);
        }
    }
}
