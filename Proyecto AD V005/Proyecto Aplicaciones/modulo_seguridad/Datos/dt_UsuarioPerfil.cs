using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modulo_Seguridad.ReglasNegocio;

namespace Modulo_Seguridad.Datos
{
    public class dt_UsuarioPerfil
    {
        Coneccio cone = new Coneccio();

        public Boolean ingreso(int codP,int codm)
        {
            try
            {
                if (cone.Conectando())
                {
                    cone.cnn.Open();
                    SqlCommand coneccio = new SqlCommand("ingresoperfilusuario", cone.cnn);
                    coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccio.Parameters.AddWithValue("@codper", codP);
                    coneccio.Parameters.AddWithValue("@codusu", codm);
                    coneccio.ExecuteNonQuery();
                    cone.cnn.Close();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public Boolean actualizar(int codP, int codm)
        {
            try
            {
                if (cone.Conectando())
                {
                    cone.cnn.Open();
                    SqlCommand coneccio = new SqlCommand("actualizaperfilusuario", cone.cnn);
                    coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccio.Parameters.AddWithValue("@codper", codP);
                    coneccio.Parameters.AddWithValue("@codusu", codm);
                    coneccio.ExecuteNonQuery();
                    cone.cnn.Close();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public List<cls_UsuarioPerfil> consulta(int cod)
        {
            List<cls_UsuarioPerfil> lista = new List<cls_UsuarioPerfil>();
            cls_UsuarioPerfil clas = new cls_UsuarioPerfil();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("consultausuarioperfil", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                coneccio.Parameters.AddWithValue("@cod", cod);
                coneccio.ExecuteNonQuery();
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                        var linea = new cls_UsuarioPerfil();
                        linea.nom = Convert.ToString(rdr.GetValue(0));
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
    }
}
