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
    public class RN_Medida
    {
        D_Medida conec = new D_Medida();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraMedida(string descripcionM,string estado)
        {
            return this.conec.IngresaMedida(descripcionM, estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarMedida(int codigoMedida, string descripcionM,string estado)
        {
            return this.conec.ModificaMedida(codigoMedida, descripcionM, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarMedida(int codigoMedida)
        {
            return this.conec.EliminarMedida(codigoMedida);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
       D_Medida  d_med = new D_Medida();

        public DataSet GetAll()
        {
            return d_med.GetAll();
        }
       
        public E_Medida GetOne(int CodigoMedida)
        {
            return d_med.GetOne(CodigoMedida);
        }



    }
}
