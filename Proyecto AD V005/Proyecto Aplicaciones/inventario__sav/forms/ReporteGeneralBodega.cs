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
    public partial class ReporteGeneralBodega : Form
    {
        public ReporteGeneralBodega()
        {
            InitializeComponent();
        }

        private void ReporteGeneralBodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SAVDataSetInventario.IN_M_BODEGA' Puede moverla o quitarla según sea necesario.
            this.IN_M_BODEGATableAdapter.Fill(this.SAVDataSetInventario.IN_M_BODEGA);

            this.reportViewer1.RefreshReport();
        }
    }
}
