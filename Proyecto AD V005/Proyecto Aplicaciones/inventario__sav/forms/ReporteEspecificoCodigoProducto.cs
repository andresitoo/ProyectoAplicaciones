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
    public partial class ReporteEspecificoCodigoProducto : Form
    {
        public ReporteEspecificoCodigoProducto()
        {
            InitializeComponent();
        }

        private void Pueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SAVDataSetInventario.IN_M_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.IN_M_PRODUCTOTableAdapter.Fill(this.SAVDataSetInventario.IN_M_PRODUCTO);

          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void fillByProductToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.IN_M_PRODUCTOTableAdapter.FillByProduct(this.SAVDataSetInventario.IN_M_PRODUCTO, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(codigoProductoToolStripTextBox.Text, typeof(decimal))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByProductToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
