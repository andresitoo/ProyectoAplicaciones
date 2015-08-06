using Modulo_Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Seguridad.Formularios
{
    public partial class frmRol : Form
    {
        public frmRol()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Lim()
        {
            txtDescripcion.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Lim();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            Coneccio con = new Coneccio();
            if (con.Conectando())
            {
                String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(coneccion);
                cnn.Open();
                String cons = "select count(*) from SG_M_PERFIL";
                
                SqlCommand cmd = new SqlCommand(cons, cnn);
                try
                {
                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();
                    Console.WriteLine("Hola"+r.GetValue(0));
                    lblId.Text = Convert.ToString(Convert.ToInt64(r.GetValue(0))+1);
                }

                catch
                {
                    MessageBox.Show("Conexion Erronea");
                }

            }
            else
            {
                MessageBox.Show("Coneccion rechazada");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dt_Rol v = new dt_Rol();
            if (v.ingresoRol(Convert.ToInt32(lblId.Text), Convert.ToString(txtDescripcion.Text),
                Convert.ToDateTime(dtmFecha.Text)) == 1)
                 MessageBox.Show("Rol registrado correctamente");
            else
                 MessageBox.Show("Rol no registrado correctamente");
            
        }
    }
}
