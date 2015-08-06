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
    public class RN_Bodega
    {

        D_Bodega  conec = new D_Bodega();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraBodegaNuevo(string descripcionB, string direccionB,
            string cantidadP, string responsableB, string estado)
        {
            return this.conec.IngresaBodega(descripcionB, direccionB, cantidadP, responsableB, estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarBodegaNuevo(int codBodega, string descripcionB, string direccionB,
            string cantidadP, string responsableB, string estado)
        {
            return this.conec.ModificaBodega(codBodega, descripcionB, direccionB, cantidadP, responsableB, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarBodegaNuevo(int codBodega)
        {
            return this.conec.EliminarBodega(codBodega);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
        D_Bodega d_bod = new D_Bodega();

        public DataSet GetAll()
        {
            return d_bod.GetAll();
        }
     
        public E_Bodega GetOne(int CodigoBodega)
        {
            return d_bod.GetOne(CodigoBodega);
        }

       

    }
}
