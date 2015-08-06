using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Seguridad.Datos;
using Modulo_Seguridad.ReglasNegocio;

namespace Modulo_Seguridad.Formularios
{
    public partial class frmPerfilMenu : Form
    {
        public frmPerfilMenu()
        {
            InitializeComponent();
        }

        List<cls_Perfil> clsper = new List<cls_Perfil>();
        dt_Perfil dtper = new dt_Perfil();
        List<cls_Modulo> clsmo = new List<cls_Modulo>();
        dt_Modulo dtmo = new dt_Modulo();
        private void frmPerfilMenu_Load(object sender, EventArgs e)
        {
            clsper = dtper.consulta();
            if (clsper == null)
            {
                MessageBox.Show("No hay datos a presentar en el perfil", "error");
            }
            else
            {
                foreach (var item in clsper)
                {
                    cmbPerfil.Items.Add(Convert.ToString(item.descripcion));
                }
            }
            clsmo = dtmo.consulta();
            if (clsmo == null)
            {
                MessageBox.Show("No hay datos a presentar en el perfil", "error");
            }
            else
            {
                foreach (var item in clsmo)
                {
                    CmbModulo.Items.Add(Convert.ToString(item.descripcion));
                }
            }
        }
        List<cls_OpcionMenu> clsusup = new List<cls_OpcionMenu>();
        dt_OpcionMenu dtsup = new dt_OpcionMenu();
        private void CmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMenu.Items.Clear();
            clsusup = dtsup.consulta(CmbModulo.SelectedIndex + 1);
            if (clsusup == null)
            {
                MessageBox.Show("No hay datos a presentar en el Usuario", "error");
            }
            else
            {
                foreach (var item in clsusup)
                {
                    lstMenu.Items.Add(Convert.ToString(item.nomb));
                }
            }
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            if (!lstPerfilMenu.Items.Contains(Convert.ToString(lstMenu.SelectedItem)))
                lstPerfilMenu.Items.Add(lstMenu.SelectedItem);
            else
                MessageBox.Show("elemento ya existente");
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            lstPerfilMenu.Items.Remove(lstPerfilMenu.SelectedItem);
        }
        List<cls_PerfilMenu> clsper1 = new List<cls_PerfilMenu>();
        dt_PerfilMenu dtper1 = new dt_PerfilMenu();
        dt_OpcionMenu asd = new dt_OpcionMenu();
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int x = 0;
            foreach (string f in lstPerfilMenu.Items)
            {
                n = asd.busop(f);
                if (dtper1.ingreso(cmbPerfil.SelectedIndex + 1, n))
                    x++;
            }
            if (lstPerfilMenu.Items.Count == x)
                MessageBox.Show("Perfil asignado correctamente");
            else
                MessageBox.Show("Perfil no asignado correctamente");
        }

        /*
        
        
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            int n;
            x = 0;
            foreach (string f in lstPerfilMenu.Items)
            {
                n = dtsup.busop(f);
                if (dtper1.ingreso(cmbPerfil.SelectedIndex + 1,n))
                    x++;
            }
            if (lstPerfilMenu.Items.Count == x)
                MessageBox.Show("Perfil asignado correctamente");
            else
                MessageBox.Show("Perfil no asignado correctamente");
        }*/
    }
}
