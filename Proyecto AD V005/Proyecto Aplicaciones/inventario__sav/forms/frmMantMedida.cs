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
    public partial class frmMantMedida : Form
    {
        P_Medida oMedida = new P_Medida(); //Instancia de la Capa presentacion
        E_Medida oMedida_ent = new E_Medida(); //Instancia de Capa entidad

        public frmMantMedida()
        {
            InitializeComponent();
        }

        private void IniDG()
        {
            try
            {
                dgvMedida.DataSource = oMedida.GetAll().Tables[0];
                dgvMedida.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void frmMantMedida_Load(object sender, EventArgs e)
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

        private void frmMantMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CodID = Convert.ToInt32(txtTMedida.Text);
                try
                {
                    oMedida_ent = oMedida.GetOne(CodID);
                    txtDescripcionMedida.Text = oMedida_ent.Descripcion_Medida;
                    cbxEstado.Text = Convert.ToString(oMedida_ent.Estado);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTMedida.Clear();
            txtDescripcionMedida.Clear();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
            try
            {
                RN_Medida con = new RN_Medida();
                if (con.conectar())
                {
                    if (con.ModificarMedida(Convert.ToInt32(txtTMedida.Text.ToString()),
                    txtDescripcionMedida.Text.ToString(), valor))
                    {
                        MessageBox.Show("Actualizado con Exito");
                    }
                    else
                    {

                        MessageBox.Show("Problema al Actualizar");
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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Medida con = new RN_Medida();
                if (con.conectar())
                {
                    if (con.RegistraMedida((txtDescripcionMedida.Text.ToString()), valor))
                    {
                        MessageBox.Show("Registrado con Exito");
                    }
                    else
                    {
                        MessageBox.Show("Problema al Ingresar Medida");
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RN_Medida con = new RN_Medida();
                if (con.conectar())
                {
                    if (con.EliminarMedida(Convert.ToInt32(txtTMedida.Text.ToString())))

                        MessageBox.Show("Cambio de Estado Medida realizada con Exito");
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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
                    RN_Medida con = new RN_Medida();
                    if (con.conectar())
                    {
                        String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                        SqlConnection cnn = new SqlConnection(coneccion);
                        cnn.Open();
                        String cons = "select * from IN_R_TIPO_MEDIDA where Codigo_Medida=" + txtTMedida.Text;
                        SqlCommand cmd = new SqlCommand(cons, cnn);
                        try
                        {
                            SqlDataReader r = cmd.ExecuteReader();
                            r.Read();
                            txtTMedida.Text = Convert.ToString(r.GetValue(0));
                            txtDescripcionMedida.Text = Convert.ToString(r.GetValue(1));
                            cbxEstado.Text = Convert.ToString(r.GetValue(2));
                        }

                        catch
                        {
                            MessageBox.Show("Coneccion Erronea");
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

        private void dgvMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTMedida.Text = Convert.ToString(dgvMedida.Rows[e.RowIndex].Cells[0].Value);
                txtDescripcionMedida.Text = Convert.ToString(dgvMedida.Rows[e.RowIndex].Cells[1].Value);
                cbxEstado.Text = Convert.ToString(dgvMedida.Rows[e.RowIndex].Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void cbbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbCodigo.Checked)
                txtTMedida.Enabled = true;
            else
                txtTMedida.Enabled = false;
        }

        private void btnBusquedaCriterio_Click(object sender, EventArgs e)
        {
              int selectedIndexg = cbxEstado.SelectedIndex;
                Object selectedItemg = cbxEstado.SelectedItem;

                try
                {
                    if (!string.IsNullOrEmpty(selectedItemg.ToString()))
                    {
                        RN_Medida con = new RN_Medida();
                        if (con.conectar())
                        {
                            String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                            SqlConnection cnn = new SqlConnection(coneccion);
                            cnn.Open();
                            String cons = "select * from IN_R_MEDIDA where Codigo_Medida=" + txtTMedida.Text;
                            SqlCommand cmd = new SqlCommand(cons, cnn);
                            try
                            {
                                SqlDataReader r = cmd.ExecuteReader();
                                r.Read();
                                txtTMedida.Text = Convert.ToString(r.GetValue(0));
                                txtDescripcionMedida.Text = Convert.ToString(r.GetValue(1));
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
        }
    }

