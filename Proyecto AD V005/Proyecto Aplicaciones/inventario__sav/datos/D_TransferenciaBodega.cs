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
    public class D_TransferenciaBodega :capaAccesoDatos
    {
         public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_TRANSFERENCIA");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_TRANSFERENCIA");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_Transferencia GetOne(int CodigoTransferencia)
        {
            E_Transferencia vRes = new E_Transferencia();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_TRANSFERENCIA");
                cmd.Parameters.AddWithValue("@CodigoTransferencia", CodigoTransferencia);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.Codigo_Transferencia = (int)consulta["CodigoTransferencia"];
                        vRes.Bodega_Saliente = (string)consulta["BodegaSalienteTransferencia"];
                        vRes.Bodega_Entrante = (string)consulta["BodegaEntranteTransferencia"];
                        vRes.Responsable = (string)consulta["ResponsableTransferencia"];
                        vRes.Motivo = (string)consulta["MotivoTransferencia"];
                        vRes.Estado = (int)consulta["EstadoTransferencia"];
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

        public Boolean IngresaTransferencia(string bodegaSaliente, string bodegaEntrante,
         string responsable, string motivo, string estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_TRANSFERENCIA", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                        coneccion.Parameters.AddWithValue("@bodegaSaliente", bodegaSaliente);
                         coneccion.Parameters.AddWithValue("@bodegaEntrante", bodegaEntrante);
                         coneccion.Parameters.AddWithValue("@responsable", responsable);
                        coneccion.Parameters.AddWithValue("@motivo", motivo);
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

        public Boolean ModificaTransferencia(int codTransaccion, string bodegaSaliente, string bodegaEntrante,
         string responsable, string motivo, string estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_TRANSFERENCIA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@codigoTransaccion", codTransaccion);
                    coneccion.Parameters.AddWithValue("@bodegaSaliente", bodegaSaliente);
                    coneccion.Parameters.AddWithValue("@bodegaEntrante", bodegaEntrante);
                    coneccion.Parameters.AddWithValue("@responsable", responsable);
                    coneccion.Parameters.AddWithValue("@motivo", motivo);
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

        public Boolean EliminarTransferencia(int codTransferencia)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_TRANSFERENCIA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoTransferencia", codTransferencia);
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
        public Boolean ConsultarTransferencia(int Codigo_Transferencia)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_CONSULTAR_TRANSFERENCIA", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@CodigoTransferencia", Codigo_Transferencia);
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
 
