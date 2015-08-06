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
    public class D_Medida : capaAccesoDatos
    {
        //RETORNA TODOS LOS DATOS
        public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_MEDIDA");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_MEDIDA");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_Medida GetOne(int Codigo_Medida)
        {
            E_Medida vRes = new E_Medida();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_MEDIDA");
                cmd.Parameters.AddWithValue("@codigoMedida", Codigo_Medida);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.Codigo_Medida = (int)consulta["CodigoMedida"];
                        vRes.Descripcion_Medida = (string)consulta["DescripcionMedida"];
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

        public Boolean IngresaMedida(string descripcionMedida, string estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_MEDIDA", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                        coneccion.Parameters.AddWithValue("@descripcionMedida", descripcionMedida);
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

        public Boolean ModificaMedida(int codigoMedida,string descripcionMedida, string estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_MEDIDA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@codigoMedida", codigoMedida);
                    coneccion.Parameters.AddWithValue("@descripcionMedida", descripcionMedida);
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

        public Boolean EliminarMedida(int codigoMedida)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_MEDIDA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoMedida", codigoMedida);
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

         public Boolean ConsultarMedida(int codigoMedida)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_CONSULTAR_MEDIDA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@CodigoMedida", codigoMedida);
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
