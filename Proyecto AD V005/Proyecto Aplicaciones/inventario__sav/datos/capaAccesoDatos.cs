using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DEBSAccesoSQL;
namespace Datos
{
    public class capaAccesoDatos : DEBSAccesoDatos
    {
        public capaAccesoDatos()
        {
            cConex = " Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            conexion = new SqlConnection(cConex);
        }

        public Boolean Conectando()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(this.cConex);
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
