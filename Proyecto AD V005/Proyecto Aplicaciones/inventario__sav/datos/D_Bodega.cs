using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEBSAccesoSQL;

using Entity;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class D_Bodega : capaAccesoDatos
    {
        //RETORNA TODOS LOS DATOS
        public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_BODEGA");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_BODEGA");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_Bodega GetOne(int CodigoBodega)
        {
            E_Bodega vRes = new E_Bodega();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_BODEGA");
                cmd.Parameters.AddWithValue("@CodigoBodega", CodigoBodega);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.Codigo_Bodega = (int)consulta["CodigoProducto"];
                        vRes.Descripcion_Bodega = (string)consulta["DescripcionProducto"];
                        vRes.DireccionBodega = (string)consulta["CodigoTipoProducto"];
                        vRes.CantidadPercha = (string)consulta["CodigoSeccion"];
                        vRes.ResponsableBodega = (string)consulta["CodigoTipoUnidad"];
                        vRes.Estado = (int)consulta["Estado"];
                    }
                }
                consulta.Close();
                consulta.Dispose();
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message, Ex);
            }
            finally
            {
                cmd.Dispose();
                CerrarConexion();
            }
            return vRes;
        }

        //----------------------------------INGRESAR BODEGA ------------------------------------------

        public Boolean IngresaBodega(string descripcionB, string direccionB,
            string cantidadP, string responsableB, string estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_BODEGA", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                        coneccion.Parameters.AddWithValue("@DescripcionBodega", descripcionB);
                        coneccion.Parameters.AddWithValue("@DireccionBodega", direccionB);
                        coneccion.Parameters.AddWithValue("@CantidadPercha", cantidadP);
                        coneccion.Parameters.AddWithValue("@ResponsableBodega", responsableB);
                        coneccion.Parameters.AddWithValue("@estado", estado);

                        coneccion.ExecuteNonQuery();
                        conectado.Close();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        //----------------------------------MODIFICAR BODEGA -------------------------------------------

        public Boolean ModificaBodega(int codBodega, string descripcionB, string direccionB,
            string cantidadP, string responsableB, string estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_BODEGA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoBodega", codBodega);
                    coneccion.Parameters.AddWithValue("@DescripcionBodega", descripcionB);
                    coneccion.Parameters.AddWithValue("@DireccionBodega", direccionB);
                    coneccion.Parameters.AddWithValue("@CantidadPercha", cantidadP);
                    coneccion.Parameters.AddWithValue("@ResponsableBodega", responsableB);
                    coneccion.Parameters.AddWithValue("@estado", estado);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //----------------------------------ELIMINAR BODEGA ------------------------------------------

        public Boolean EliminarBodega(int codBodega)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_BODEGA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoBodega", codBodega);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
