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
    public class D_Producto : capaAccesoDatos
    {
        //RETORNA TODOS LOS DATOS
        public DataSet GetAll()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_PRODUCTO");
                Ds = GetDS(cmd, "IN_M_BUSQUEDA_GENERAL_PRODUCTO");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error Registros no obtenidos" + Ex.Message, Ex);
            }
            return Ds;

        }
        //RETORNA SOLO UN DATO
        public E_Producto GetOne(int CodigoProducto)
        {
            E_Producto vRes = new E_Producto();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = CrearComando("IN_M_BUSQUEDA_GENERAL_PRODUCTO");
                cmd.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.Codigo_Producto = (int)consulta["CodigoProducto"];
                        vRes.Descripcion_Producto = (string)consulta["DescripcionProducto"];
                        vRes.TipoProducto = (string)consulta["TipoProducto"];
                        vRes.Medida = (string)consulta["Medida"];
                        vRes.Bodega = (string)consulta["Bodega"];
                        vRes.Percha = (string)consulta["Percha"];
                        vRes.ExistenciaActual = (int)consulta["ExistenciaActual"];
                        vRes.Stock_Maximo = (int)consulta["StockMaximo"];
                        vRes.Stock_Minimo = (int)consulta["StockMinimo"];
                        vRes.Costo = (int)consulta["Costo"];
                        vRes.Precio = (int)consulta["Precio"];
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

        //----------------------------------INGRESAR PRODUCTO ------------------------------------------

        public Boolean IngresaProducto(string descripcionP, string tipoProducto, string medida,
            string bodega, string percha, int exisAc, int stockmi, int stockma, int costo, int precio, string estado)
        {
            {
                if (this.Conectando())
                {
                    try
                    {

                        SqlConnection conectado = new SqlConnection(this.cConex);
                        conectado.Open();
                        SqlCommand coneccion = new SqlCommand("SV_IN_INGRESAR_PRODUCTO", conectado);
                        coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                        coneccion.Parameters.AddWithValue("@descripcionProducto", descripcionP);
                        coneccion.Parameters.AddWithValue("@tipoProducto", tipoProducto);
                        coneccion.Parameters.AddWithValue("@medida", medida);
                        coneccion.Parameters.AddWithValue("@bodega", bodega);
                        coneccion.Parameters.AddWithValue("@percha", percha);
                        coneccion.Parameters.AddWithValue("@existenciaActual", exisAc);
                        coneccion.Parameters.AddWithValue("@stockMinimo", stockmi);
                        coneccion.Parameters.AddWithValue("@stockMaximo", stockma);
                        coneccion.Parameters.AddWithValue("@costo", costo);
                        coneccion.Parameters.AddWithValue("@precio", precio);
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

        public int GuardarImagen(E_Imagen oIma)
        {
            int resultado = 0;
            SqlConnection conn = new SqlConnection(this.cConex);
            //capaAccesoDatos conn = ConexionDAL.ObtenerConexion();
            conn.Open();
            SqlCommand coneccion = new SqlCommand("IN_M_INGRESO_IMAGEN", conn);
            coneccion.CommandType = System.Data.CommandType.StoredProcedure;
            
            coneccion.Parameters.AddWithValue("", oIma.ProductoId);
            coneccion.Parameters.AddWithValue("", oIma.Nombre);
            coneccion.Parameters.AddWithValue("", oIma.Imagen);
            resultado = coneccion.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        //----------------------------------MODIFICAR PRODUCTO -------------------------------------------

        public Boolean ModificaProducto(int codProducto, string descripcionP, string tipoProducto, string medida,
            string bodega, string percha, int exisAc, int stockmi, int stockma, int costo, int precio, string estado)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_EDITAR_PRODUCTO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@codigoProducto", codProducto);
                    coneccion.Parameters.AddWithValue("@descripcionProducto", descripcionP);
                    coneccion.Parameters.AddWithValue("@tipoProducto", tipoProducto);
                    coneccion.Parameters.AddWithValue("@medida", medida);
                    coneccion.Parameters.AddWithValue("@bodega", bodega);
                    coneccion.Parameters.AddWithValue("@percha", percha);
                    coneccion.Parameters.AddWithValue("@existenciaActual", exisAc);
                    coneccion.Parameters.AddWithValue("@stockMinimo", stockmi);
                    coneccion.Parameters.AddWithValue("@stockMaximo", stockma);
                    coneccion.Parameters.AddWithValue("@costo", costo);
                    coneccion.Parameters.AddWithValue("@precio", precio);
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

        //----------------------------------ELIMINAR PRODUCTO ------------------------------------------

        public Boolean EliminarProducto(int codProducto)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.cConex);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("IN_M_ELIMINAR_PRODUCTO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@cod", codProducto);
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
                    SqlCommand coneccion = new SqlCommand("SV_FC_CONSULTAR_PRODUCTO", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@CodigoProducto", cod);
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