using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReglasNegocio;
using Datos;
using Modulo_Seguridad.Datos;


namespace Modulo_Seguridad
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Lim()
        {
            txtContra.Text = "";
            txtIdempleado.Text = "";
            txtLogin.Text = "";
            txtNContra.Text = "";
            txtNombre.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Lim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frmempleado n = new Frmempleado();
            n.ShowDialog();
            txtIdempleado.Text = n.co;
            txtNombre.Text = n.no;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dt_Usuario x = new dt_Usuario();
            try
            {
                if (x.BuscarLogin(txtLogin.Text) == 0)
                    MessageBox.Show("Login libre");
                else
                {
                    MessageBox.Show("Login ocupado");
                    txtLogin.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Login libre");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dt_Usuario v = new dt_Usuario();
            if (txtNContra.Text == txtContra.Text)
            {
                if (v.ingresouser(Convert.ToInt32(txtIdempleado.Text), Convert.ToString(txtLogin.Text),
                    Convert.ToString(txtContra.Text), Convert.ToDateTime(dtmFecha.Text)) == 1)
                    MessageBox.Show("Usuario registrado correctamente");
                else
                    MessageBox.Show("Usuario no registrado correctamente");
            }
            else
            {
                MessageBox.Show("Contaseñas diferentes");
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
