using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo_Seguridad.ReglasNegocio;
using System.Data.SqlClient;

namespace Modulo_Seguridad.Datos
{
    public class dt_Modulo
    {
        Coneccio cone = new Coneccio();

        public List<cls_Modulo> consulta()
        {
            List<cls_Modulo> lista = new List<cls_Modulo>();
            cls_Modulo clas = new cls_Modulo();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("consultamodulo", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                        var linea = new cls_Modulo();
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
    }
}
