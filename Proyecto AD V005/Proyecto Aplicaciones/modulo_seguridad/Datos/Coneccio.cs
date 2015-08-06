using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modulo_Seguridad
{
    public class Coneccio
    {
        public String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
        public SqlConnection cnn;
        public Boolean Conectando()
        {
            try
            {
                cnn = new SqlConnection(this.coneccion);
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
