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
    public class D_TipoProducto : capaAccesoDatos
    {
        //RETORNA TODOS LOS DATOS
        public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_TIPO_PRODUCTO");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_TIPO_PRODUCTO");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_TipoProducto GetOne(int Codigo_TipoProducto)
        {
            E_TipoProducto  vRes = new E_TipoProducto ();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_TIPO_PRODUCTO");
                cmd.Parameters.AddWithValue("@codigoTipoProducto", Codigo_TipoProducto);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.Codigo_TipoProducto = (int)consulta["CodigoTipoProducto"];
                        vRes.Descripcion_TipoProducto= (string)consulta["DescripcionTipoProducto"];
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

        //+++++++++++++++++++++++++++++++++++++++++ INGRESAR TIPO PRODUCTO ++++++++++++++++++++++++++++++++++++++++++++++++

        public Boolean IngresaTipoProducto(string descripcionTipoProducto, string estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_TIPO_PRODUCTO", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                        coneccion.Parameters.AddWithValue("@DescripcionTipoProducto", descripcionTipoProducto);
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
       
        //+++++++++++++++++++++++++++++++++++++++ MODIFICAR TIPO PRODUCTO +++++++++++++++++++++++++++++++++++++++++++++++

        public Boolean ModificaTipoProducto(int codTipoProducto,string descripcionTipoProducto, string estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_TIPO_PRODUCTO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@codigoTipoProducto", codTipoProducto);
                    coneccion.Parameters.AddWithValue("@DescripcionTipoProducto", descripcionTipoProducto);
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

        //++++++++++++++++++++++++++++++++++++++ ELIMINAR TIPO PRODUCTO ++++++++++++++++++++++++++++++++++++++++++++

        public Boolean EliminarTipoProducto(int codTipoProducto)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_TIPO_PRODUCTO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoTipoProducto", codTipoProducto);
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

         public Boolean ConsultarTipoProducto(int cod)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_CONSULTAR_TIPO_PRODUCTO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@CodigoTipoProducto", cod);
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
