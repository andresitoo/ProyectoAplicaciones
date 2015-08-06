using ModuloFacturacion;
using ModuloFacturacion.Datos;
using Sistema_compras.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sistema_compras;
using ModuloFacturacion.Reglas_del_negocio;

namespace ModuloFacturacion
{
    public partial class frmMDI_Principal : Form
    {
     

        public frmMDI_Principal()
        {
            InitializeComponent();

            //CONEXION========================================================================
            
            



        }

        private void frmMDI_Principal_Load(object sender, EventArgs e)
        {

            tss_lbl_Fecha.Text = DateTime.Now.ToString();
            
        }

        private void opt_Salir_Click(object sender, EventArgs e)
        {

            DialogResult x = MessageBox.Show("¿Desea salir de la aplicacion?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (x == DialogResult.Yes) {
                Application.Exit();
            }
            
            
        }

        private void opt_Solicitud_Pedido_Click(object sender, EventArgs e)
        {
            frm_Solicitud_Pedido x1 = new frm_Solicitud_Pedido();
            x1.ShowDialog();
      
        }

        private void opt_orden_Compra_Click(object sender, EventArgs e)
        {
            
            frm_OrdenCompra x1 = new frm_OrdenCompra();
            x1.ShowDialog();
        }

        private void opt_Proveedor_Click(object sender, EventArgs e)
        {
            frm_Proveedor x1 = new frm_Proveedor();
            x1.ShowDialog();
        }

        private void consultasGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultarGenerales x1 = new frm_ConsultarGenerales();
            x1.ShowDialog();
        }

        private void opt_Cotizacion_Click(object sender, EventArgs e)
        {
            frm_Cotizacion x1 = new frm_Cotizacion();
            x1.ShowDialog();
        }

        private void opt_EntregaPedido_Click(object sender, EventArgs e)
        {
            frm_EntregaPedido x1 = new frm_EntregaPedido();
            x1.ShowDialog();
        }

        private void opt_Devolucion_Click(object sender, EventArgs e)
        {
            frm_Devoluciones x1 = new frm_Devoluciones();
            x1.ShowDialog();
        }

        private void opt_cambiar_User_Click(object sender, EventArgs e)
        {
            FrmLogin x = new FrmLogin();
            x.Show();
            
        }






    }
}
