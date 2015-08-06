using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ReglasNegocio;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Seguridad.ReglasNegocio;
using Modulo_Seguridad.Datos;

namespace Modulo_Seguridad.Formularios
{
    public partial class FrmPerfilUsuario : Form
    {
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }
        List<cls_Usuario> clscar = new List<cls_Usuario>();
        dt_Usuario dtcar = new dt_Usuario();
        List<cls_Perfil> clsper = new List<cls_Perfil>();
        dt_Perfil dtper = new dt_Perfil();
        List<cls_UsuarioPerfil> clsusup = new List<cls_UsuarioPerfil>();
        dt_UsuarioPerfil dtsup = new dt_UsuarioPerfil();
        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            cmbPerfil.Visible = false;
            clscar = dtcar.consulta();
            if (clscar == null)
            {
                MessageBox.Show("No hay datos a presentar en el Usuario", "error");
            }
            else
            {
                foreach (var item in clscar)
                {
                    cmbUser.Items.Add(Convert.ToString(item.log));
                }
            }
            clsper = dtper.consulta();
            if (clsper == null)
            {
                MessageBox.Show("No hay datos a presentar en el perfil", "error");
            }
            else
            {
                foreach (var item in clsper)
                {
                    lstPerfil.Items.Add(Convert.ToString(item.descripcion));
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
                if (!lstPerfilUsuario.Items.Contains(Convert.ToString(lstPerfil.SelectedItem)))
                    lstPerfilUsuario.Items.Add(lstPerfil.SelectedItem);
                else
                    MessageBox.Show("elemento ya existente");

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            lstPerfilUsuario.Items.Remove(lstPerfilUsuario.SelectedItem);
        }
        ListBox lis = new ListBox();
        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPerfilUsuario.Items.Clear();
            clsusup = dtsup.consulta(cmbUser.SelectedIndex + 1);
            if (clsusup == null)
            {
                MessageBox.Show("No hay datos a presentar en el Usuario", "error");
            }
            else
            {
                foreach (var item in clsusup)
                {
                    lstPerfilUsuario.Items.Add(Convert.ToString(item.nom));
                    lis.Items.Add(Convert.ToString(item.nom));
                }
            }
        }
        int x = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //cmbUser.SelectedIndex + 1
            int s;
            x = 0;
            foreach (string f in lstPerfilUsuario.Items)
            {
                s = dtper.busc(f);
                if (dtsup.ingreso(s,cmbUser.SelectedIndex + 1))
                        x++;
            }
            if (lstPerfilUsuario.Items.Count==x)
                MessageBox.Show("Perfil asignado correctamente");
           else
                MessageBox.Show("Perfil no asignado correctamente");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int s;
            x = 0;
            foreach (string f in lis.Items)
            {
                if (!lstPerfilUsuario.Items.Contains(Convert.ToString(f)))
                {
                    s = dtper.busc(f);
                    if (dtsup.actualizar(s, cmbUser.SelectedIndex + 1))
                        x++;
                }
                
            }
            if (lstPerfilUsuario.Items.Count == x)
                MessageBox.Show("Perfil actualizado correctamente");
            else
                MessageBox.Show("Perfil no actualizado correctamente");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
