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
    public partial class frmMantBodega : Form
    {
        P_Bodega oBodega = new P_Bodega(); //Instancia de la Capa presentacion
        E_Bodega oBodega_ent = new E_Bodega(); //Instancia de Capa rntidad

        public frmMantBodega()
        {
            InitializeComponent();
        }



        private void IniDG()
        {
            try
            {
                dgvBodega.DataSource = oBodega.GetAll().Tables[0];
                dgvBodega.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void frmMantBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CodID = Convert.ToInt32(txtCodBodega.Text);
                try
                {
                    oBodega_ent = oBodega.GetOne(CodID);
                    txtDescripcionBodega.Text = oBodega_ent.Descripcion_Bodega;
                    txtDireccionBodega.Text = Convert.ToString(oBodega_ent.DireccionBodega);
                    txtCantPerchas.Text = Convert.ToString(oBodega_ent.CantidadPercha);
                    cbxResponsable.Text = Convert.ToString(oBodega_ent.ResponsableBodega);
                    cbxEstado.Text = Convert.ToString(oBodega_ent.Estado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void dgvBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodBodega.Text = Convert.ToString(dgvBodega.Rows[e.RowIndex].Cells[0].Value);
                txtDescripcionBodega.Text = Convert.ToString(dgvBodega.Rows[e.RowIndex].Cells[1].Value);
                txtDireccionBodega.Text = Convert.ToString(dgvBodega.Rows[e.RowIndex].Cells[2].Value);
                txtCantPerchas.Text = Convert.ToString(dgvBodega.Rows[e.RowIndex].Cells[3].Value);
                cbxResponsable.Text = Convert.ToString(dgvBodega.Rows[e.RowIndex].Cells[4].Value);
                cbxEstado.Text = Convert.ToString(dgvBodega.Rows[e.RowIndex].Cells[5].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodBodega.Clear();
            txtDescripcionBodega.Clear();
            txtDireccionBodega.Clear();
            txtCantPerchas.Clear();


        }
        //---------------------------------------------ACTUALIZAR -------------------------------------
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Bodega con = new RN_Bodega();
                if (con.conectar())
                {
                    if (con.ModificarBodegaNuevo
                        (Convert.ToInt32(txtCodBodega.Text.ToString()),
                         (txtDescripcionBodega.Text.ToString()),
                         (txtDireccionBodega.Text.ToString()),
                         (txtCantPerchas.Text.ToString()),
                         (cbxResponsable.Text.ToString()), valor))


                        MessageBox.Show("Bodega Actualizado con Exito");
                    else
                        MessageBox.Show("Problema al Actualizar Bodega");
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


        //---------------------------------------------ELIMINAR ---------------------------------------
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RN_Bodega con = new RN_Bodega();
                if (con.conectar())
                {
                    if (con.EliminarBodegaNuevo(Convert.ToInt32(txtCodBodega.Text.ToString())))

                        MessageBox.Show("Cambio de Estado Bodega con Exito");
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
        //---------------------------------------------GRABAR --------------------------------------------
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Bodega con = new RN_Bodega();
                if (con.conectar())
                {
                    if (con.RegistraBodegaNuevo
                         ((txtDescripcionBodega.Text.ToString()),
                         (txtDireccionBodega.Text.ToString()),
                         (txtCantPerchas.Text.ToString()),
                         (cbxResponsable.Text.ToString()), valor))
                    {
                        MessageBox.Show("Registrado con Exito");
                    }
                    else
                    {
                        MessageBox.Show("Problema al ingresar Bodega");
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



        private void frmMantBodega_Load(object sender, EventArgs e)
        {
            llenacomboboxResponsable();//llama al método llenacombobox
            llenacomboboxEstado(); // llama al método llenacombobox
            IniDG();
        }
        public void llenacomboboxEstado()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            //codigo para llenar el comboBox
            DataSet ds = new DataSet();
            //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT descripcion FROM ESTADO ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "ESTADO");
            cbxEstado.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cbxEstado.ValueMember = "descripcion";
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

        private void cbbCodigoBodega_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbCodigoBodega.Checked)
                txtCodBodega.Enabled = true;
            else
                txtCodBodega.Enabled = false;
        }

        private void btnBusquedaCriterio_Click(object sender, EventArgs e)
        {
            int selectedIndexr = cbxResponsable.SelectedIndex;
            Object selectedItemr = cbxResponsable.SelectedItem;
            int selectedIndexg = cbxEstado.SelectedIndex;
            Object selectedItemg = cbxEstado.SelectedItem;

            try
            {
                if (!string.IsNullOrEmpty(selectedItemg.ToString()) || !string.IsNullOrEmpty(selectedItemr.ToString()))
                {
                    RN_Bodega con = new RN_Bodega();
                    if (con.conectar())
                    {
                        String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                        SqlConnection cnn = new SqlConnection(coneccion);
                        cnn.Open();
                        String cons = "select * from IN_M_BODEGA where Codigo_Bodega = " + txtCodBodega.Text;
                        SqlCommand cmd = new SqlCommand(cons, cnn);
                        try
                        {
                            SqlDataReader r = cmd.ExecuteReader();
                            r.Read();
                            txtCodBodega.Text = Convert.ToString(r.GetValue(0));
                            txtDescripcionBodega.Text = Convert.ToString(r.GetValue(1));
                            txtDireccionBodega.Text = Convert.ToString(r.GetValue(2));
                            cbxResponsable.Text = Convert.ToString(r.GetValue(3));
                            txtCantPerchas.Text = Convert.ToString(r.GetValue(4));
                            cbxEstado.Text = Convert.ToString(r.GetValue(5));
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

    }
}
