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
    public class RN_MovimientoInventario
    {
        D_MovimientoInventario  conec = new D_MovimientoInventario();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraMovimientoInventarioNuevo(int codMovInv, string tipoDocumento, string descripcionMovimiento,string asociadoA, int estado)
        {
            return this.conec.IngresaMovimientoInventario(codMovInv, tipoDocumento, descripcionMovimiento, asociadoA, estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarMovimientoInventarioNuevo(int codMovInv, string tipoDocumento, string descripcionMovimiento, string asociadoA, int estado)
        {
            return this.conec.ModificaMovimientoInventario(codMovInv, tipoDocumento, descripcionMovimiento, asociadoA, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarMovimientoInventarioNuevo(int codMovInv)
        {
            return this.conec.EliminarMovimientoInventario (codMovInv);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
        D_MovimientoInventario d_movInv = new D_MovimientoInventario();

        public DataSet GetAll()
        {
            return d_movInv.GetAll();
        }

        public E_MovimientoInventario GetOne(int codMovInv)
        {
            return d_movInv.GetOne(codMovInv);
        }

    }
}
