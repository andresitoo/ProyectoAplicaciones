using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using Entity;
using ReglasNegocio;

namespace Forms
{
    public partial class frmConceptoMovimientoInventario : Form
    {
        public frmConceptoMovimientoInventario()
        {
            InitializeComponent();
        }

        P_MovimientoInventario oMovInv = new P_MovimientoInventario(); //Instancia de la Capa presentacion
        E_MovimientoInventario oMovInv_ent = new E_MovimientoInventario(); //Instancia de Capa rntidad

        private void IniDG()
        {
            try
            {
                dgvMovInventario.DataSource = oMovInv.GetAll().Tables[0];
                dgvMovInventario.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void frmConceptoMovimientoInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CodID = Convert.ToInt32(txtCodMovimientoInventario.Text);
                try
                {
                    oMovInv_ent = oMovInv.GetOne (CodID);
                    txtDescripcion.Text = oMovInv_ent.DescripcionMovimientoInventario;
                    cbxTipoDocumento.Text = Convert.ToString(oMovInv_ent.TipoDocumento);
                    cbxAsociado.Text = Convert.ToString(oMovInv_ent.AsociadoA);
                    cbxEstado.Text = Convert.ToString(oMovInv_ent.Estado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }


        private void dgvMovInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodMovimientoInventario.Text = Convert.ToString(dgvMovInventario.Rows[e.RowIndex].Cells[0].Value);
                cbxTipoDocumento.Text = Convert.ToString(dgvMovInventario.Rows[e.RowIndex].Cells[1].Value);
                txtDescripcion.Text = Convert.ToString(dgvMovInventario.Rows[e.RowIndex].Cells[2].Value);
                cbxAsociado.Text = Convert.ToString(dgvMovInventario.Rows[e.RowIndex].Cells[3].Value);
                cbxEstado.Text = Convert.ToString(dgvMovInventario.Rows[e.RowIndex].Cells[4].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodMovimientoInventario.Clear();
            txtDescripcion.Clear();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RN_MovimientoInventario con = new RN_MovimientoInventario();
                if (con.conectar())
                {
                    if (con.RegistraMovimientoInventarioNuevo 
                        (Convert.ToInt32(txtCodMovimientoInventario.Text.ToString()),
                         (cbxTipoDocumento.Text.ToString()),
                         (txtDescripcion.Text.ToString()), (cbxAsociado .Text.ToString()), 1))
                    {
                        MessageBox.Show("Movimiento Inventario Registrado con Exito.");
                    }
                    else
                    {
                        MessageBox.Show("Problema al ingresar Movimiento Inventario");
                    }
                }
                else
                {
                    MessageBox.Show("Conexion rechazada");
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Conexion");
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RN_MovimientoInventario con = new RN_MovimientoInventario();
                if (con.conectar())
                {
                    if (con.ModificarMovimientoInventarioNuevo
                        (Convert.ToInt32(txtCodMovimientoInventario.Text.ToString()),
                         (cbxTipoDocumento.Text.ToString()),
                         (txtDescripcion.Text.ToString()), 
                         (cbxAsociado.Text.ToString()), 1))


                        MessageBox.Show("Movimiento Inventario Actualizado con Exito");
                    else
                        MessageBox.Show("Problema al Actualizar Movimiento Inventario");
                }
                else
                {
                    MessageBox.Show("Conexion rechazada");
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Conexion");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RN_MovimientoInventario  con = new RN_MovimientoInventario();
                if (con.conectar())
                {
                    if (con.EliminarMovimientoInventarioNuevo
                        (Convert.ToInt32(txtCodMovimientoInventario.Text.ToString())))

                        MessageBox.Show("Cambio de Estado MovimientoInventario con Exito");
                    else
                        MessageBox.Show("Problema al Eliminar MovimientoInventario");
                }
                else
                {
                    MessageBox.Show("Conexion rechazada");
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Conexion");
            }
        }

        private void consultaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniDG();
        }

        private void frmConceptoMovimientoInventario_Load(object sender, EventArgs e)
        {

        }

    }
}
