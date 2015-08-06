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
    public partial class ConsultaProducto : Form
    {
        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {

        }
        public int x = 0;
        private void GenerarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbtGeneral.Checked)
            {
               
                ReporteGeneralProducto f = new ReporteGeneralProducto();
                f.ShowDialog();
            }
            else
            {
                if (rbtCodigo.Checked)
                {
                 
                    ReporteEspecificoCodigoProducto f = new ReporteEspecificoCodigoProducto();
                    f.ShowDialog();

                }
                else
                {
                    ReporteEspecificoNombreProducto f = new ReporteEspecificoNombreProducto();
                    f.ShowDialog();
                    
                }
                    
            }
        }

        

       
    }
}
