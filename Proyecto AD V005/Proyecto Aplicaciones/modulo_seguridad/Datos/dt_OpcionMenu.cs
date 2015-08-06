using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo_Seguridad.ReglasNegocio;
using Modulo_Seguridad.Datos;
using System.Data.SqlClient;

namespace Modulo_Seguridad.Datos
{
    public class dt_OpcionMenu
    {
        Coneccio cone = new Coneccio();

        public int busop(string nom)
        {
            int x=0;
            if (cone.Conectando())
            {
                cone.cnn.Open();
                
                SqlCommand coneccio = new SqlCommand("busop", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                coneccio.Parameters.AddWithValue("@nom", nom);
                coneccio.ExecuteNonQuery();
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                       
                        x = Convert.ToInt32(rdr.GetValue(0));
                    }
                    cone.cnn.Close();
                    return x;
                }
            }
            else
            {
                return x;
            }
        }

        public List<cls_OpcionMenu> consulta(int cod)
        {
            List<cls_OpcionMenu> lista = new List<cls_OpcionMenu>();
            cls_OpcionMenu clas = new cls_OpcionMenu();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("consulta_modulo", cone.cnn);
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
                        var linea = new cls_OpcionMenu();
                        linea.nomb = Convert.ToString(rdr.GetValue(0));
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
