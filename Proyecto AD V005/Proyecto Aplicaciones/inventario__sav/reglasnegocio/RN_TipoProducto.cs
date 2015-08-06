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
    public class RN_TipoProducto
    {
        D_TipoProducto conec = new D_TipoProducto();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraTipoProducto(string descripcionTipoProducto, string estado)
        {
            return this.conec.IngresaTipoProducto(descripcionTipoProducto, estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarTipoProducto(int codTipoProducto, string descripcionTipoProducto, string estado)
        {
            return this.conec.ModificaTipoProducto(codTipoProducto,descripcionTipoProducto, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarTipoProducto(int codigoTipoProducto)
        {
            return this.conec.EliminarTipoProducto(codigoTipoProducto);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
        D_TipoProducto d_per = new D_TipoProducto();

        public DataSet GetAll()
        {
            return d_per.GetAll();
        }

        public E_TipoProducto GetOne(int CodTipoProducto)
        {
            return d_per.GetOne(CodTipoProducto);
        }
    }
}