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
    public class RN_Producto
    {

       D_Producto conec = new D_Producto ();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        //------------------------------NUEVO ----------------------------------------------------
        public Boolean RegistraProductoNuevo(string descripcionP, string tipoProducto, string medida, string bodega,
            string percha, int existenciaActual, int stockmi, int stockma, int costo, int precio, string estado)
        {
            return this.conec.IngresaProducto(descripcionP, tipoProducto, medida, bodega, percha,existenciaActual, stockmi, stockma,costo, precio,estado);
        }
        //------------------------------MODIFICAR ----------------------------------------------------
        public Boolean ModificarProductoNuevo(int codProducto, string descripcionP, string tipoProducto, string medida, string bodega,
            string percha, int existenciaActual, int stockmi, int stockma, int costo, int precio, string estado)
        {
            return this.conec.ModificaProducto(codProducto, descripcionP, tipoProducto, medida, bodega, percha, existenciaActual, stockmi, stockma, costo, precio, estado);
        }
        //------------------------------ELIMINAR ----------------------------------------------------
        public Boolean EliminarProductoNuevo(int codProducto)
        {
            return this.conec.EliminarProducto(codProducto);
        }

        //------------------------------CONSULTA GENERAL ----------------------------------------------------
        D_Producto d_proc = new D_Producto();
       
        public DataSet GetAll()
        {
            return d_proc.GetAll();
        }
        //------------------------------NUEVO ----------------------------------------------------
        public E_Producto GetOne(int CodigoProducto)
        {
            return d_proc.GetOne(CodigoProducto);
        }


        
       
    }
}
