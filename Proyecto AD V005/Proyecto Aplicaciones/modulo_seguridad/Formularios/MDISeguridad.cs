using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Seguridad.Formularios;
using Modulo_Seguridad.ReglasNegocio;

namespace Modulo_Seguridad
{
    public partial class MDISeguridad : Form
    {
        public MDISeguridad()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario n = new frmUsuario();
            n.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfilUsuario p = new FrmPerfilUsuario();
            p.ShowDialog();
        }

        private void asignacionPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfilMenu n = new frmPerfilMenu();
            n.ShowDialog();
        }

        private void MDISeguridad_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfilUsuario p = new FrmPerfilUsuario();
            p.ShowDialog();
        }

        private void perfilMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfilMenu n = new frmPerfilMenu();
            n.ShowDialog();
        }

        public void desabilitar()
        {
            usuarioToolStripMenuItem.Visible = false;//Mantenimiento Usuario
            perfilUsuarioToolStripMenuItem.Visible = false;//Proceso Perfil por Usuario
            perfilMenuToolStripMenuItem.Visible = false;//Proceso Perfil por Menu
        }
        public void habilitar(int indice, String user)
        {
            desabilitar();
            List<cls_PerfilMenu> lista = new List<cls_PerfilMenu>();
            Modulo_Seguridad.Datos.dt_PerfilMenu usuarios = new Modulo_Seguridad.Datos.dt_PerfilMenu();
            lista = usuarios.PresentarPerfil(user);
            foreach (cls_PerfilMenu x in lista)
            {
                if (x.codop == 15)
                {
                    usuarioToolStripMenuItem.Visible = true;
                }
                if (x.codop == 16)
                {
                    perfilUsuarioToolStripMenuItem.Visible = true;
                }
                if (x.codop == 17)
                {
                    perfilMenuToolStripMenuItem.Visible = true;
                }
            }

        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRol n = new frmRol();
            n.ShowDialog();
        }
    }
}
