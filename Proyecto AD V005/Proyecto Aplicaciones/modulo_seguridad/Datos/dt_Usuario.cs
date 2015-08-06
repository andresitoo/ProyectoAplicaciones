using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReglasNegocio;
using System.Data.SqlClient;
using Modulo_Seguridad.ReglasNegocio;

namespace Modulo_Seguridad.Datos
{
    public class dt_Usuario
    {
        Coneccio cone = new Coneccio();

        public List<cls_Usuario> consulta()
        {
            List<cls_Usuario> lista = new List<cls_Usuario>();
            cls_Usuario clas = new cls_Usuario();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("consultarlogin", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                        var linea = new cls_Usuario();
                        linea.log = Convert.ToString(rdr.GetValue(0));
                        lista.Add(linea);
                    }
                    cone.cnn.Close();
                }
                if (lista.Count == 0)
                {
                    lista = null;
                    return lista;
                }
                else
                {
                    return lista;
                }
            }
            else
            {
                return null;
            }
        }

        public int consultaUser(String us, String pas)
        {
            List<cls_Usuario> lista = new List<cls_Usuario>();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("IngresoSistema", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                coneccio.Parameters.AddWithValue("@usu", us);
                coneccio.Parameters.AddWithValue("@pas", pas);
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                        var linea = new cls_Usuario();
                        linea.log = Convert.ToString(rdr.GetValue(0));
                        lista.Add(linea);
                    }
                    cone.cnn.Close();
                }
                if (lista.Count == 0)
                {
                    lista = null;
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
        
    //ingrso Usuario
        public int ingresouser(int cod, String us, String pas, DateTime fe)
        {
            try
            {
                if (cone.Conectando())
                {
                    cone.cnn.Open();
                   
                    SqlCommand coneccion = new SqlCommand("ingresousuario", cone.cnn);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@code", cod);
                    coneccion.Parameters.AddWithValue("@user", us);
                    coneccion.Parameters.AddWithValue("@pas", pas);
                    coneccion.Parameters.AddWithValue("@fec", fe);
                    coneccion.ExecuteNonQuery();
                    return 1;
                }
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }



        public int BuscarLogin(String login)
        {
            cls_Usuario clas = new cls_Usuario();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccion = new SqlCommand("buscarlogin", cone.cnn);
                coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.Parameters.AddWithValue("@login", login);
                coneccion.ExecuteNonQuery();
                SqlDataReader r = coneccion.ExecuteReader();

                r.Read();
                if (r == null)
                {
                    return 0;
                }
                else
                {
                    clas.co = Convert.ToString(r.GetValue(0));
                    cone.cnn.Close();
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

    }
}
