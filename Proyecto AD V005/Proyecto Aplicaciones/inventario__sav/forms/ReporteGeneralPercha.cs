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
    public partial class ReporteGeneralPercha : Form
    {
        public ReporteGeneralPercha()
        {
            InitializeComponent();
        }

        private void ReporteGeneralPercha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SAVDataSetInventario.IN_M_PERCHA' Puede moverla o quitarla según sea necesario.
            this.IN_M_PERCHATableAdapter.Fill(this.SAVDataSetInventario.IN_M_PERCHA);

            this.reportViewer1.RefreshReport();
        }
    }
}
