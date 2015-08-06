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
    public partial class frmTransferenciaBodega : Form
    {
        P_Transferencia oTransferenciaBodega = new P_Transferencia(); //Instancia de la Capa presentacion
        E_Transferencia oTransferenciaBodega_ent = new E_Transferencia(); //Instancia de Capa rntidad


        public frmTransferenciaBodega()
        {
            InitializeComponent();
        }

        private void IniDG()
        {
            try
            {
                dgvMovimientoInventario.DataSource = oTransferenciaBodega.GetAll().Tables[0];
                dgvMovimientoInventario.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void frmTransferenciaBodega_Load(object sender, EventArgs e)
        {
           
            llenacomboboxResponsable();//llama al método llenacombobox
            llenacomboboxBodegaOrigen();//llama al método llenacombobox
            llenacomboboxBodegaDestino();//llama al método llenacombobox
            llenacomboboxEstadoProducto();//llama al método llenacombobox
        }

        public void llenacomboboxResponsable()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre_Empleado FROM IN_M_EMPLEADO ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "IN_M_EMPLEADO");
            cbxResponsable.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cbxResponsable.ValueMember = "Nombre_Empleado";
        }

        public void llenacomboboxBodegaOrigen()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Descripcion_Bodega FROM IN_M_BODEGA ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "IN_M_BODEGA");
            cbxBodegaOrigen.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cbxBodegaOrigen.ValueMember = "Descripcion_Bodega";
        }

        public void llenacomboboxBodegaDestino()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Descripcion_Bodega FROM IN_M_BODEGA ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "IN_M_BODEGA");
            cbxBodegaDestino.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cbxBodegaDestino.ValueMember = "Descripcion_Bodega";
        }

        public void llenacomboboxEstadoProducto()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Descripcion_EstadoProducto FROM IN_ESTADO_PRODUCTO ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "ESTADO_PRODUCTO");
            cbxEstadoProducto.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cbxEstadoProducto.ValueMember = "Descripcion_EstadoProducto";
        }

        private void frmTransferenciaBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CodID = Convert.ToInt32(txtCodigoMovimientoInventario.Text);
                try
                {
                    oTransferenciaBodega_ent = oTransferenciaBodega.GetOne(CodID);
                    cbxBodegaOrigen.Text = Convert.ToString(oTransferenciaBodega_ent.Bodega_Entrante);
                    cbxBodegaDestino.Text = Convert.ToString(oTransferenciaBodega_ent.Bodega_Saliente);
                    cbxResponsable.Text = Convert.ToString(oTransferenciaBodega_ent.Responsable);
                    txtMotivo.Text = oTransferenciaBodega_ent.Motivo;
                    cbxEstadoProducto.Text = Convert.ToString(oTransferenciaBodega_ent.Estado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void dgvMovimientoInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigoMovimientoInventario.Text = Convert.ToString(dgvMovimientoInventario.Rows[e.RowIndex].Cells[0].Value);
                cbxBodegaOrigen.Text = Convert.ToString(dgvMovimientoInventario.Rows[e.RowIndex].Cells[1].Value);
                cbxBodegaDestino.Text = Convert.ToString(dgvMovimientoInventario.Rows[e.RowIndex].Cells[2].Value);

                cbxResponsable.Text = Convert.ToString(dgvMovimientoInventario.Rows[e.RowIndex].Cells[3].Value);
                txtMotivo.Text = Convert.ToString(dgvMovimientoInventario.Rows[e.RowIndex].Cells[4].Value);
                cbxEstadoProducto.Text = Convert.ToString(dgvMovimientoInventario.Rows[e.RowIndex].Cells[5].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstadoProducto.SelectedItem).Row.ItemArray[0].ToString();
                RN_Bodega con = new RN_Bodega();
                if (con.conectar())
                {
                    if (con.ModificarBodegaNuevo
                        (Convert.ToInt32(txtCodigoMovimientoInventario.Text.ToString()),
                         (cbxBodegaOrigen.Text.ToString()), (cbxBodegaDestino.Text.ToString()),
                        (cbxResponsable.Text.ToString()), (txtMotivo.Text.ToString()), valor))


                        MessageBox.Show("Transferencia Actualizada con Exito");
                    else
                        MessageBox.Show("Problema al Actualizar Transferencia");
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
            IniDG();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RN_Bodega con = new RN_Bodega();
                if (con.conectar())
                {
                    if (con.EliminarBodegaNuevo(Convert.ToInt32(txtCodigoMovimientoInventario.Text.ToString())))

                        MessageBox.Show("Cambio de Estado de Transferencia realizada con Exito");
                    else
                        MessageBox.Show("Problema al Eliminar Bodega");
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
            IniDG();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ccbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbCodigo.Checked)
                txtCodigoMovimientoInventario.Enabled = true;
            else
                txtCodigoMovimientoInventario.Enabled = false;
        }

        private void btnConsultaPorCriterio_Click(object sender, EventArgs e)
        {

            int selectedIndexbs = cbxResponsable.SelectedIndex;
            int selectedIndexbe = cbxResponsable.SelectedIndex;
            int selectedIndexr = cbxResponsable.SelectedIndex;
            int selectedIndexe = cbxEstadoProducto.SelectedIndex;
            Object selectedItembs = cbxResponsable.SelectedItem;
            Object selectedItembe = cbxResponsable.SelectedItem;
            Object selectedItemr = cbxResponsable.SelectedItem;
            Object selectedIteme = cbxEstadoProducto.SelectedItem;

            try
            {
                if (!string.IsNullOrEmpty(selectedItembs.ToString()) || !string.IsNullOrEmpty(selectedItembe.ToString())
                    || !string.IsNullOrEmpty(selectedItemr.ToString()) || !string.IsNullOrEmpty(selectedIteme.ToString()))
                {
                    RN_TransferenciaBodega con = new RN_TransferenciaBodega();
                    if (con.conectar())
                    {
                        String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                        SqlConnection cnn = new SqlConnection(coneccion);
                        cnn.Open();
                        String cons = "select * from IN_R_TRANSFERENCIA_INVENTARIO_BODEGA where CodigoTransferenciaInventario = " + txtCodigoMovimientoInventario.Text;
                        SqlCommand cmd = new SqlCommand(cons, cnn);
                        try
                        {
                            SqlDataReader r = cmd.ExecuteReader();
                            r.Read();
                            txtCodigoMovimientoInventario.Text = Convert.ToString(r.GetValue(0));
                            cbxBodegaOrigen.Text = Convert.ToString(r.GetValue(1));
                            cbxBodegaDestino.Text = Convert.ToString(r.GetValue(2));
                            cbxResponsable.Text = Convert.ToString(r.GetValue(3));
                            txtMotivo.Text = Convert.ToString(r.GetValue(4));
                            cbxEstadoProducto.Text = Convert.ToString(r.GetValue(5));
                        }

                        catch
                        {
                            MessageBox.Show("Conexion Erronea");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Coneccion rechazada");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Coneccion");
            }
        }

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstadoProducto.SelectedItem).Row.ItemArray[0].ToString();
                RN_TransferenciaBodega con = new RN_TransferenciaBodega();
                if (con.conectar())
                {
                    if (con.RegistraTransferencia
                         ((cbxBodegaOrigen.Text.ToString()), (cbxBodegaDestino.Text.ToString()),
                        (cbxResponsable.Text.ToString()), (txtMotivo.Text.ToString()), valor))
                    {
                        MessageBox.Show("Transferencia realizada con Exito");
                    }
                    else
                    {
                        MessageBox.Show("Problema al Registrar Transferencia");
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
            IniDG();
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtCodigoMovimientoInventario.Clear();
            txtMotivo.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}