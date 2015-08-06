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
    public partial class frmTipoProducto : Form
    {
        
        P_TipoProducto  oTipoProducto = new P_TipoProducto (); //Instancia de la Capa presentacion
        E_TipoProducto  oTipoProducto_ent = new E_TipoProducto(); //Instancia de Capa entidad

        public frmTipoProducto()
        {
            InitializeComponent();
        }

         private void IniDG()
        {
            try
            {
                dgvTipoProducto .DataSource = oTipoProducto.GetAll().Tables[0];
                dgvTipoProducto.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void frmTipoProducto_Load(object sender, EventArgs e)
        {
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
                
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTipoProducto.Clear();
            txtDescripcionTipoProducto.Clear();
        }
             

        private void frmTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CodID = Convert.ToInt32(txtTipoProducto.Text);
                try
                {
                    oTipoProducto_ent = oTipoProducto.GetOne(CodID);
                    txtDescripcionTipoProducto.Text = oTipoProducto_ent.Descripcion_TipoProducto;
                    cbxEstado.Text = Convert.ToString(oTipoProducto_ent.Estado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }


        }

        private void dgvTipoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTipoProducto.Text = Convert.ToString(dgvTipoProducto .Rows[e.RowIndex].Cells[0].Value);
                txtDescripcionTipoProducto.Text = Convert.ToString(dgvTipoProducto.Rows[e.RowIndex].Cells[1].Value);
                cbxEstado.Text = Convert.ToString(dgvTipoProducto.Rows[e.RowIndex].Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtTipoProducto.Clear();
            txtDescripcionTipoProducto.Clear();
        }

        private void actualizarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
            try
            {
                RN_TipoProducto con = new RN_TipoProducto();
                if (con.conectar())
                {
                    if (con.ModificarTipoProducto(Convert.ToInt32(txtTipoProducto.Text.ToString()),
                    txtDescripcionTipoProducto.Text.ToString(), valor))
                    {
                        MessageBox.Show("Producto Actualizado con Exito");
                    }
                    else
                    {

                        MessageBox.Show("Problema al Actualizar Producto");
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

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_TipoProducto con = new RN_TipoProducto();
                if (con.conectar())
                {
                    if (con.RegistraTipoProducto((txtDescripcionTipoProducto.Text.ToString()),valor))
                    {
                        MessageBox.Show("Registrado con Exito");
                    }
                    else
                    {
                        MessageBox.Show("Problema al ingresar Tipo Producto");
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

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                RN_TipoProducto con = new RN_TipoProducto();
                if (con.conectar())
                {
                    if (con.EliminarTipoProducto(Convert.ToInt32(txtTipoProducto.Text.ToString())))

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

        private void btnBusquedaPorCriterio_Click(object sender, EventArgs e)
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
                            String cons = "select * from IN_R_TIPO_PRODUCTO where Codigo_TipoProducto=" + txtTipoProducto.Text;
                            SqlCommand cmd = new SqlCommand(cons, cnn);
                            try
                            {
                                SqlDataReader r = cmd.ExecuteReader();
                                r.Read();
                                txtTipoProducto.Text = Convert.ToString(r.GetValue(0));
                                txtDescripcionTipoProducto.Text = Convert.ToString(r.GetValue(1));
                                cbxEstado.Text = Convert.ToString(r.GetValue(2));
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


        private void cbbCodigoTipoProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbCodigoTipoProducto.Checked)
                txtTipoProducto.Enabled = true;
            else
                txtTipoProducto.Enabled = false;
        }
        }
    }
