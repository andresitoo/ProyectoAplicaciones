using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Seguridad.Datos
{
    class dt_Rol
    {
        Coneccio cone = new Coneccio();
        public int ingresoRol(int id,string descripcion, DateTime fecha)
        {
            try
            {
                if (cone.Conectando())
                {
                    cone.cnn.Open();

                    SqlCommand coneccion = new SqlCommand("ingresorol", cone.cnn);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@cla", id);
                    coneccion.Parameters.AddWithValue("@des", descripcion);
                    coneccion.Parameters.AddWithValue("@fec", fecha);
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
    }
}
