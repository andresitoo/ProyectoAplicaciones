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
    public partial class frmMantPercha : Form
    {
        public frmMantPercha()
        {
            InitializeComponent();
        }

        P_Percha oPercha = new P_Percha(); //Instancia de la Capa presentacion
        E_Percha oPercha_ent = new E_Percha(); //Instancia de Capa rntidad

        private void IniDG()
        {
            try
            {
                dgvPercha.DataSource = oPercha.GetAll().Tables[0];
                dgvPercha.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void frmMantPercha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CodID = Convert.ToInt32(txtCodPercha.Text);
                try
                {
                    oPercha_ent = oPercha.GetOne(CodID);
                    txtDescripcionPercha.Text = oPercha_ent.Descripcion_Percha;
                    txtUbicacionPercha.Text = oPercha_ent.Ubicacion_Percha;
                    txtCantidadNivelesPercha.Text = oPercha_ent.Cantidad_Niveles_Percha;
                    cbxEstado.Text = Convert.ToString(oPercha_ent.Estado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
          
        
        private void dgvPercha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        try
            {
                txtCodPercha.Text = Convert.ToString(dgvPercha.Rows[e.RowIndex].Cells[0].Value);
                txtDescripcionPercha.Text = Convert.ToString(dgvPercha.Rows[e.RowIndex].Cells[1].Value);
                txtUbicacionPercha.Text = Convert.ToString(dgvPercha.Rows[e.RowIndex].Cells[2].Value);
                txtCantidadNivelesPercha.Text = Convert.ToString(dgvPercha.Rows[e.RowIndex].Cells[3].Value);
                cbxEstado.Text = Convert.ToString(dgvPercha.Rows[e.RowIndex].Cells[4].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtCodPercha.Clear();
            txtDescripcionPercha.Clear();
            txtUbicacionPercha.Clear();
            txtCantidadNivelesPercha.Clear();
        }

    //---------------------------------------------ACTUALIZAR -------------------------------------
        private void actualizarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Percha con = new RN_Percha();
                if (con.conectar())
                {
                    if (con.ModificarPerchaNuevo (Convert.ToInt32(txtCodPercha.Text.ToString()),
                         (txtDescripcionPercha.Text.ToString()),
                         (txtUbicacionPercha.Text.ToString()),
                         (txtCantidadNivelesPercha.Text.ToString()),valor))
                    
                         
                        MessageBox.Show("Producto Actualizado con Exito");
                    else
                        MessageBox.Show("Problema al Actualizar Producto");
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

     //---------------------------------------------GRABAR --------------------------------------------
    
        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Percha con = new RN_Percha();
                if (con.conectar())
                {
                    if (con.RegistraPerchaNuevo 
                         ((txtDescripcionPercha.Text.ToString()),
                         (txtUbicacionPercha.Text.ToString()),
                         (txtCantidadNivelesPercha.Text.ToString()),valor))
                    {
                        MessageBox.Show("Percha Registrado con Exito.");
                    }
                    else
                    {
                        MessageBox.Show("Problema al ingresar Percha");
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

      

       //---------------------------------------------ELIMINAR ---------------------------------------
        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                RN_Percha con = new RN_Percha();
                if (con.conectar())
                {
                    if (con.EliminarPerchaNuevo(Convert.ToInt32(txtCodPercha.Text.ToString())))

                        MessageBox.Show("Cambio de Estado Producto con Exito");
                    else
                        MessageBox.Show("Problema al Eliminar Producto");
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

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantPercha_Load(object sender, EventArgs e)
        {
            IniDG();
            llenacomboboxEstado(); // llama al método llenacombobox
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

            private void txtCodigoProducto_Click(object sender, EventArgs e)
            {
                int selectedIndexg = cbxEstado.SelectedIndex;
                Object selectedItemg = cbxEstado.SelectedItem;

                try
                {
                    if (!string.IsNullOrEmpty(selectedItemg.ToString()))
                    {
                        RN_TipoProducto con = new RN_TipoProducto();
                        if (con.conectar())
                        {
                            String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                            SqlConnection cnn = new SqlConnection(coneccion);
                            cnn.Open();
                            String cons = "select * from IN_M_PERCHA where Codigo_Percha=" + txtCodPercha.Text;
                            SqlCommand cmd = new SqlCommand(cons, cnn);
                            try
                            {
                                SqlDataReader r = cmd.ExecuteReader();
                                r.Read();
                                txtCodPercha.Text = Convert.ToString(r.GetValue(0));
                                txtDescripcionPercha.Text = Convert.ToString(r.GetValue(1));
                                txtUbicacionPercha.Text = Convert.ToString(r.GetValue(2));
                                txtCantidadNivelesPercha.Text = Convert.ToString(r.GetValue(3));
                                cbxEstado.Text = Convert.ToString(r.GetValue(4));
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

            private void cbbCodigoPercha_CheckedChanged(object sender, EventArgs e)
            {
                if (cbbCodigoPercha.Checked)
                    txtCodPercha.Enabled = true;
                else
                    txtCodPercha.Enabled = false;
            }

            private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
            {
               cbxEstado.Items.Clear();
                IniDG();
            }

            private void groupBox3_Enter(object sender, EventArgs e)
            {

            }
    } 
}
