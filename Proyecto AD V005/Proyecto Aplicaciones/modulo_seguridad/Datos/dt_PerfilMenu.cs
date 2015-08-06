using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modulo_Seguridad.ReglasNegocio;

namespace Modulo_Seguridad.Datos
{
    public class dt_PerfilMenu
    {
        Coneccio cone = new Coneccio();

        public List<cls_PerfilMenu> PresentarPerfil(String codper)
        {
            List<cls_PerfilMenu> lista = new List<cls_PerfilMenu>();
            cls_PerfilMenu clas = new cls_PerfilMenu();
            if (cone.Conectando())
            {
                cone.cnn.Open();
                SqlCommand coneccio = new SqlCommand("habilitarperfil", cone.cnn);
                coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                coneccio.Parameters.AddWithValue("@user", codper);
                using (SqlDataReader rdr = coneccio.ExecuteReader())
                {
                    if (rdr == null)
                    {
                        throw new NullReferenceException("No People Available.");
                    }
                    while (rdr.Read())
                    {
                        var linea = new cls_PerfilMenu();
                        linea.codop = Convert.ToInt16(rdr.GetValue(0));
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
        
        public Boolean ingreso(int codP, int codm)
        {
            try
            {
                if (cone.Conectando())
                {
                    cone.cnn.Open();
                    SqlCommand coneccio = new SqlCommand("ingresoperfilmenu", cone.cnn);
                    coneccio.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccio.Parameters.AddWithValue("@codper", codP);
                    coneccio.Parameters.AddWithValue("@codop", codm);
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
        
    }
}
