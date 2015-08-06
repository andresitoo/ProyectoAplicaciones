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
    public class RN_Percha
    {

        //capaAccesoDatos conec = new capaAccesoDatos();
        D_Percha conec = new D_Percha();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraPerchaNuevo(string descripcionP, string ubicacionP,
            string cantidadNivelesP, string estado)
        {
            return this.conec.IngresaPercha(descripcionP, ubicacionP, cantidadNivelesP, estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarPerchaNuevo(int codigoPercha, string descripcionP, string ubicacionP,
            string cantidadNivelesP, string estado)
        {
            return this.conec.ModificaPercha(codigoPercha, descripcionP, ubicacionP, cantidadNivelesP, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarPerchaNuevo(int codigoPercha)
        {
            return this.conec.EliminarPercha(codigoPercha);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
       D_Percha  d_per = new D_Percha();

        public DataSet GetAll()
        {
            return d_per.GetAll();
        }
       
        public E_Percha GetOne(int CodigoPercha)
        {
            return d_per.GetOne(CodigoPercha);
        }



    }
}
