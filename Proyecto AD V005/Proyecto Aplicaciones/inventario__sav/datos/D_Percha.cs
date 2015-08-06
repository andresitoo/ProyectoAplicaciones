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
    public class D_Percha : capaAccesoDatos
    {

        //RETORNA TODOS LOS DATOS
        public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_PERCHA");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_PERCHA");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_Percha GetOne(int CodigoPercha)
        {
            E_Percha vRes = new E_Percha();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_PERCHA");
                cmd.Parameters.AddWithValue("@CodigoPercha", CodigoPercha);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.Codigo_Percha = (int)consulta["CodigoPercha"];
                        vRes.Descripcion_Percha = (string)consulta["DescripcionPercha"];
                        vRes.Ubicacion_Percha = (string)consulta["UbicacionPercha"];
                        vRes.Cantidad_Niveles_Percha = (string)consulta["CantidadNivelesPercha"];
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


        //+++++++++++++++++++++++++++++++++++++++++ INGRESAR PERCHA ++++++++++++++++++++++++++++++++++++++++++++++++

        public Boolean IngresaPercha(string descripcionP, string ubicacionPercha,
         string cantidadNivelesP, string estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_PERCHA", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                        coneccion.Parameters.AddWithValue("@DescripcionPercha", descripcionP);
                        coneccion.Parameters.AddWithValue("@UbicacionPercha", ubicacionPercha);
                        coneccion.Parameters.AddWithValue("@CantidadNivelesPercha", cantidadNivelesP);
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




        //+++++++++++++++++++++++++++++++++++++++ MODIFICAR PERCHA +++++++++++++++++++++++++++++++++++++++++++++++

        public Boolean ModificaPercha(int codPercha, string descripcionP, string ubicacionPercha,
           string cantidadNivelesP, string estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_PERCHA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@codigoPercha", codPercha);
                    coneccion.Parameters.AddWithValue("@DescripcionPercha", descripcionP);
                    coneccion.Parameters.AddWithValue("@UbicacionPercha", ubicacionPercha);
                    coneccion.Parameters.AddWithValue("@CantidadNivelesPercha", cantidadNivelesP);
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

        //++++++++++++++++++++++++++++++++++++++ ELIMINAR PERCHA ++++++++++++++++++++++++++++++++++++++++++++

        public Boolean EliminarPercha(int codPercha)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_PERCHA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoPercha", codPercha);
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
        public Boolean ConsultarPercha(int cod)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_CONSULTAR_PERCHA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@CodigoPercha", cod);
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
