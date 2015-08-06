using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;
using Modulo_Seguridad.ReglasNegocio;
using Modulo_Seguridad.Datos;
using Modulo_Seguridad.Formularios;
using Modulo_Seguridad;



namespace ModuloFacturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cmbModulo.Text) & !string.IsNullOrEmpty(txtUser.Text) & !string.IsNullOrEmpty(txtPasword.Text))
            {
                dt_Usuario user = new dt_Usuario();
                if (user.consultaUser(txtUser.Text,txtPasword.Text) == 1)
                {
                    switch (cmbModulo.SelectedIndex)
                    {
                        case 0://modulo de inventario
                            {
                                frmInv_MenuPrincipal frm = new frmInv_MenuPrincipal();
                                frm.habilitar(cmbModulo.SelectedIndex, txtUser.Text);
                                frm.ShowDialog();
                            } break;
                        case 1://modulo de seguridad
                            {
                                MDISeguridad d = new MDISeguridad();
                                d.habilitar(cmbModulo.SelectedIndex, txtUser.Text);
                                d.ShowDialog();
                            } break;
                    }
                }
                else if (user.consultaUser(txtUser.Text, txtPasword.Text) == 0)
                {
                    MessageBox.Show("Clave o usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user.consultaUser(txtUser.Text, txtPasword.Text) == 2)
                {
                    MessageBox.Show("Error Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("No dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        List<cls_Modulo> clsmo = new List<cls_Modulo>();
        dt_Modulo dtmo = new dt_Modulo();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPasword.Text = "";
            clsmo = dtmo.consulta();
            if (clsmo == null)
            {
                MessageBox.Show("No hay datos a presentar en el perfil", "error");
            }
            else
            {
                foreach (var item in clsmo)
                {
                    cmbModulo.Items.Add(Convert.ToString(item.descripcion));
                }
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
