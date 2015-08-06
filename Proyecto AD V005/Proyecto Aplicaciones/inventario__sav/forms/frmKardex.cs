using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmKardex : Form
    {
        public frmKardex()
        {
            InitializeComponent();
        }

        private void btnBusquedaCriterio_Click(object sender, EventArgs e)
        {
            ConsultaKardexProducto f = new ConsultaKardexProducto();
            f.ShowDialog();
        }

        private void frmKardex_Load(object sender, EventArgs e)
        {

        }
    }
}
