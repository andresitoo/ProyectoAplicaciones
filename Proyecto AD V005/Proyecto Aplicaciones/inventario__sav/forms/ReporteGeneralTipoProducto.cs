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
    public partial class ReporteGeneralTipoProducto : Form
    {
        public ReporteGeneralTipoProducto()
        {
            InitializeComponent();
        }

        private void ReporteGeneralTipoProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SAVDataSetInventario.IN_R_TIPO_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.IN_R_TIPO_PRODUCTOTableAdapter.Fill(this.SAVDataSetInventario.IN_R_TIPO_PRODUCTO);

            this.reportViewer1.RefreshReport();
        }
    }
}
