using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entity;

namespace Datos
{
    public class D_MovimientoInventario : capaAccesoDatos
    {
        //RETORNA TODOS LOS DATOS
        public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_MOVIMIENTO_INVENTARIO");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_MOVIMIENTO_INVENTARIO");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_MovimientoInventario  GetOne(int CodigoMov_Inventario)
        {
            E_MovimientoInventario  vRes = new E_MovimientoInventario ();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_MOVIMIENTO_INVENTARIO");
                cmd.Parameters.AddWithValue("@codigoMovimientoInventario", CodigoMov_Inventario);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.CodigoMovimientoInventario = (int)consulta["codigoMovimientoInventario"];
                        vRes.TipoDocumento = (string)consulta["TipoDocumento"];
                        vRes.DescripcionMovimientoInventario = (string)consulta["DescripcionMovimientoInventario"];
                        vRes.AsociadoA = (string)consulta["AsociadoA"];
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

        //----------------------------------INSERTAR MOVIMIENTO INVENTARIO ------------------------------------------
        public Boolean IngresaMovimientoInventario(int codMovInv, string TipoDocumento, string DescripcionMovimientoInventario,
        string AsociadoA, int estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {
                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_MOVIMIENTO_INVENTARIO", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                        coneccion.Parameters.AddWithValue("@codigoMov_Inventario", codMovInv);
                        coneccion.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                        coneccion.Parameters.AddWithValue("@descripcionMovimientoInventario", DescripcionMovimientoInventario);
                        coneccion.Parameters.AddWithValue("@asociadoA", AsociadoA);
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
        //----------------------------------ACTUALIZAR MOVIMIENTO INVENTARIO ------------------------------------------
        public Boolean ModificaMovimientoInventario(int codMovInv, string TipoDocumento, string DescripcionMovimientoInventario,
         string AsociadoA, int estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_MOVIMIENTO_INVENTARIO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@codigoMov_Inventario", codMovInv);
                    coneccion.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                    coneccion.Parameters.AddWithValue("@descripcionMovimientoInventario", DescripcionMovimientoInventario);
                    coneccion.Parameters.AddWithValue("@asociadoA", AsociadoA);
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

        //----------------------------------ELIMINAR MOVIMIENTO INVENTARIO ------------------------------------------
        public Boolean EliminarMovimientoInventario(int codMovInv)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_MOVIMIENTO_INVENTARIO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoMov_Inventario", codMovInv);
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
