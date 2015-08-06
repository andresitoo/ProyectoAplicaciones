using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modulo_Seguridad.ReglasNegocio;

namespace Modulo_Seguridad.Datos
{
    public class dt_Perfil
    {
        Coneccio cone = new Coneccio();

        public List<cls_Perfil> consulta()
        {
            List<cls_Perfil> lista = new List<cls_Perfil>();
            cls_Perfil clas = new cls_Perfil();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("consultaperfil", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                        var linea = new cls_Perfil();
                        linea.descripcion = Convert.ToString(rdr.GetValue(0));
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
        public int busc(string nom)
        {
            int x = 0;
            try
            {
                if (cone.Conectando())
                {
                    cone.cnn.Open();
                    SqlCommand coneccio = new SqlCommand("consultabusperfil", cone.cnn);
                    coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccio.Parameters.AddWithValue("@nom", nom);
                    coneccio.ExecuteNonQuery();
                    SqlDataReader rdr = coneccio.ExecuteReader();
                    rdr.Read();
                    x =Convert.ToInt32(rdr.GetValue(0));
                    return x;
                }
                else
                    return x;
            }
            catch
            {
                return x;
            }
        }
    }
}
