using Modulo_Seguridad.ReglasNegocio;
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
    public partial class frmInv_MenuPrincipal : Form
    {
        public frmInv_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantProducto frm = new frmMantProducto();
            frm.ShowDialog();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantBodega frm = new frmMantBodega();
            frm.ShowDialog();
        }

        private void perchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantPercha frm = new frmMantPercha();
            frm.ShowDialog();
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKardex frm = new frmKardex();
            frm.ShowDialog();
        }

        private void movimientosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientoInventario frm = new frmMovimientoInventario();
            frm.ShowDialog();
        }

        private void conceptosDeMovimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMovimientoInventario frm = new ConsultaMovimientoInventario();
            frm.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           ConsultaProducto rep = new ConsultaProducto();
            rep.ShowDialog();
        }
        private void tipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTipoProducto rep = new ConsultaTipoProducto();
            rep.ShowDialog();
        }

        private void perchaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPercha rep = new ConsultaPercha();
            rep.ShowDialog();
        }

        private void movimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteMovimientoInventario rep = new ReporteMovimientoInventario();
            rep.ShowDialog();
        }

        private void bodegaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaBodega rep = new ConsultaBodega();
            rep.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProducto frm = new frmTipoProducto();
            frm.ShowDialog();
        }

        private void medidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantMedida frm = new frmMantMedida();
            frm.ShowDialog();
        }

        private void movimientoDeBodegaABodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferenciaBodega frm = new frmTransferenciaBodega();
            frm.ShowDialog();
        }

        private void consultaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProducto frm = new ConsultaProducto();
            frm.ShowDialog();
        }
        public void desabilitar()
        {
            productoToolStripMenuItem.Visible = false;//Mantenimiento Producto
            bodegaToolStripMenuItem.Visible = false;//Mantenimiento Bodega
            perchaToolStripMenuItem.Visible = false;//Mantenimiento Percha
            conceptosDeMovimientoDeInventarioToolStripMenuItem.Visible = false;//Mantenimiento de conceptos de movimientos de inventario
            tipoProductoToolStripMenuItem.Visible = false;//Mantenimiento de Tipo de Producto
            medidaToolStripMenuItem.Visible = false;//Mantenimiento de Medida
            movimientosDeInventarioToolStripMenuItem.Visible = false;//Proceso de movimiento de inventario
            kardexToolStripMenuItem.Visible = false;//Proceso de Kardex
            movimientoDeBodegaABodegaToolStripMenuItem.Visible = false;//Proceso movimiento de Bodega
            productoToolStripMenuItem1.Visible = false;//Reporte Producto
            bodegaToolStripMenuItem1.Visible = false;//Reporte Bodega
            perchaToolStripMenuItem1.Visible = false;//Reporte Percha
            tipoDeProductoToolStripMenuItem.Visible = false;//Reporte tipo de Producto
            movimientoDeInventarioToolStripMenuItem.Visible = false;//Reporte de movimiento de Inventario
        }
        public void habilitar(int indice, String user)
        {
            desabilitar();
            List<cls_PerfilMenu> lista = new List<cls_PerfilMenu>();
            Modulo_Seguridad.Datos.dt_PerfilMenu usuarios = new Modulo_Seguridad.Datos.dt_PerfilMenu();
            lista = usuarios.PresentarPerfil(user);
            foreach (cls_PerfilMenu x in lista)
            {
                if (x.codop == 1)
                {
                    productoToolStripMenuItem.Visible = true;
                }
                if (x.codop == 2)
                {
                    bodegaToolStripMenuItem.Visible = true;
                }
                if (x.codop == 3)
                {
                    perchaToolStripMenuItem.Visible = true;
                }
                if (x.codop == 4)
                {
                    conceptosDeMovimientoDeInventarioToolStripMenuItem.Visible = true;
                }
                if (x.codop == 5)
                {
                    tipoProductoToolStripMenuItem.Visible = true;
                }
                if (x.codop == 6)
                {
                    medidaToolStripMenuItem.Visible = true;
                }
            }

        }
        private void frmInv_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
