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
    public partial class ConsultaBodega : Form
    {
        public ConsultaBodega()
        {
            InitializeComponent();
        }

        private void GenerarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteGeneralBodega f = new ReporteGeneralBodega();
            f.ShowDialog();
        }
    }
}
