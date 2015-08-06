using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Entity;

namespace Forms
{
    public partial class FrmConsultaGeneral_Producto : Form
    {
        P_Producto oProducto = new P_Producto();
        public FrmConsultaGeneral_Producto()
        {
            InitializeComponent();
        }

        private void IniDG()
        {
            try
            {
                dgbProducto.DataSource = oProducto.GetAll().Tables[0];
                dgbProducto.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void FrmConsultaGeneral_Producto_Load(object sender, EventArgs e)
        {
            IniDG();

        }

        private void dgbProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
