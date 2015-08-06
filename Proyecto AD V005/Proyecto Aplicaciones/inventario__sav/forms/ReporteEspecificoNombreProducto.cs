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
    public partial class ReporteEspecificoNombreProducto : Form
    {
        public ReporteEspecificoNombreProducto()
        {
            InitializeComponent();
        }

        private void ReporteEspecificoNombreProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAVDataSetInventario.IN_M_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.iN_M_PRODUCTOTableAdapter.Fill(this.sAVDataSetInventario.IN_M_PRODUCTO);

        }

        private void fillByNomProductoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.iN_M_PRODUCTOTableAdapter.FillByNomProducto(this.sAVDataSetInventario.IN_M_PRODUCTO, descripcionToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNomProductoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.iN_M_PRODUCTOTableAdapter.FillByNomProducto(this.savDataSetInventario1.IN_M_PRODUCTO, descripcionToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNomProductoToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
