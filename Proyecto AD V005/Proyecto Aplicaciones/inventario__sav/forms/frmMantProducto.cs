using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using Entity;
using ReglasNegocio;

namespace Forms
{
    public partial class frmMantProducto : Form
    {
        P_Producto oProducto = new P_Producto(); //Instancia de la Capa presentacion
        E_Producto oProducto_ent = new E_Producto(); //Instancia de Capa rntidad


        public frmMantProducto()
        {
            InitializeComponent();
        }

        private void IniDG()
        {
            try
            {
                dgbProducto.DataSource = oProducto.GetAll().Tables[0];
                dgbProducto.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
           
        private void frmMantProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int ProdID = Convert.ToInt32(textBox3.Text);
                try
                {
                    oProducto_ent = oProducto.GetOne(ProdID);
                    txtDescripcionProducto.Text = oProducto_ent.Descripcion_Producto;
                    cbxTipoProducto.Text = Convert.ToString(oProducto_ent.TipoProducto);
                    cbxMedida.Text = Convert.ToString(oProducto_ent.Medida);
                    cbxBodega.Text = Convert.ToString(oProducto_ent.Bodega);
                    cbxPercha.Text = Convert.ToString(oProducto_ent.Percha);
                    txtExistencia.Text = Convert.ToString(oProducto_ent.ExistenciaActual);
                    txtExisMinima.Text = Convert.ToString(oProducto_ent.Stock_Minimo);
                    txtExisMaxima.Text = Convert.ToString(oProducto_ent.Stock_Maximo);
                    txtCosto.Text = Convert.ToString(oProducto_ent.Costo);
                    txtPrecio.Text = Convert.ToString(oProducto_ent.Precio);
                    cbxEstado.Text = Convert.ToString(oProducto_ent.Estado);
                    
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

       

        private void dgbProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[0].Value);
                txtDescripcionProducto.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[1].Value);
                cbxTipoProducto.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[2].Value);
                cbxMedida.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[3].Value);
                cbxBodega.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[4].Value);
                txtExistencia.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[5].Value);
                txtExisMinima.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[6].Value);
                txtExisMaxima.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[7].Value);
                txtCosto.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[8].Value);
                txtPrecio.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[9].Value);
                cbxEstado.Text = Convert.ToString(dgbProducto.Rows[e.RowIndex].Cells[10].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
 //---------------------------------------------GRABAR ---------------------------------------------
        
        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Producto con = new RN_Producto();
                if (con.conectar())
                {
                    
                    if (con.RegistraProductoNuevo
                         ((txtDescripcionProducto.Text.ToString()),
                         (cbxTipoProducto.Text.ToString()),
                         (cbxMedida.Text.ToString()),
                         (cbxBodega.Text.ToString()),
                         (cbxPercha.Text.ToString()),
                         Convert.ToInt32(txtExistencia.Text),
                         Convert.ToInt32(txtExisMinima.Text),
                         Convert.ToInt32(txtExisMaxima.Text),
                         Convert.ToInt32(txtCosto.Text),
                         Convert.ToInt32(txtPrecio.Text),valor))
                                           
                    {
                        MessageBox.Show("Producto Registrado con Exito.");
                    }
                    else
                    {
                        MessageBox.Show("Problema al ingresar Producto");
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

           /**  _imagen = new E_Imagen()
            {
                //Nombre = txtNombreProducto.Text,
                //Precio = Convert.ToDecimal(txtPrecio.Text),
                ProductoId = textBox3.Text,
                Imagen = pbxProducto
            }
            _imagen.GuardarImagen(_imagen);
            MessageBox.Show("Registro Guardado");**/
        }
     //---------------------------------------------ELIMINAR ---------------------------------------
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                RN_Producto con = new RN_Producto();
                if (con.conectar())
                {
                    if (con.EliminarProductoNuevo(Convert.ToInt32(textBox3.Text.ToString())))

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
    //---------------------------------------------ACTUALIZAR --------------------------------------
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = ((System.Data.DataRowView)cbxEstado.SelectedItem).Row.ItemArray[0].ToString();
                RN_Producto con = new RN_Producto();
                if (con.conectar())
                {
                    if (con.ModificarProductoNuevo(Convert.ToInt32(textBox3.Text.ToString()),
                         (txtDescripcionProducto.Text.ToString()),
                         (cbxTipoProducto.Text.ToString()),
                         (cbxMedida.Text.ToString()),
                         (cbxBodega.Text.ToString()),
                         (cbxPercha.Text.ToString()),
                         Convert.ToInt32(txtExistencia.Text),
                         Convert.ToInt32(txtExisMinima.Text),
                         Convert.ToInt32(txtExisMaxima.Text),
                         Convert.ToInt32(txtCosto.Text),
                         Convert.ToInt32(txtPrecio.Text),valor))

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //++++++++++++++++++++++++++++ LLENAR COMBOBOX TIPO PRODUCTO +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void frmMantProducto_Load(object sender, EventArgs e)
        {
            llenacomboboxEstado(); // llama al método llenacombobox
            IniDG();
            llenaComboBoxTipoProducto();//llama al método llenacombobox
            llenacomboboxMedida();//llama al método llenacombobox
            llenacomboboxEstado();//llama al método llenacombobox
            llenacomboboxBodega();//llama al método llenacombobox
            llenacomboboxPercha();//llama al método llenacombobox
        }
        public void llenaComboBoxTipoProducto()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
             //se indica la cadena de conexion
            conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            //codigo para llenar el comboBox
             DataSet ds = new DataSet();
             //endicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT DescripcionTipoProducto FROM IN_R_TIPO_PRODUCTO ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "IN_R_TIPO_PRODUCTO");
            cbxTipoProducto.DataSource = ds.Tables[0].DefaultView;
             //se especifica el campo de la tabla
            cbxTipoProducto.ValueMember = "DescripcionTipoProducto";
        }
         //++++++++++++++++++++++++++++ LLENAR COMBOBOX MEDIDA +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void llenacomboboxMedida()
         {
             //se declara una variable de tipo SqlConnection
             SqlConnection conexion = new SqlConnection();
             //se indica la cadena de conexion
             conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
             //codigo para llenar el comboBox
             DataSet ds = new DataSet();
             //endicamos la consulta en SQL
             SqlDataAdapter da = new SqlDataAdapter("SELECT Descripcion_Medida FROM IN_R_TIPO_MEDIDA ", conexion);
             //se indica el nombre de la tabla
             da.Fill(ds, "IN_R_TIPO_MEDIDA");
             cbxMedida.DataSource = ds.Tables[0].DefaultView;
             //se especifica el campo de la tabla
             cbxMedida.ValueMember = "Descripcion_Medida";
         }

         //++++++++++++++++++++++++++++ LLENAR COMBOBOX ESTADO +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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

         //++++++++++++++++++++++++++++ LLENAR COMBOBOX BODEGA +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

         public void llenacomboboxBodega()
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
             cbxBodega.DataSource = ds.Tables[0].DefaultView;
             //se especifica el campo de la tabla
             cbxBodega.ValueMember = "Descripcion_Bodega";
         }

         //++++++++++++++++++++++++++++ LLENAR COMBOBOX PERCHA +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

         public void llenacomboboxPercha()
         {
             //se declara una variable de tipo SqlConnection
             SqlConnection conexion = new SqlConnection();
             //se indica la cadena de conexion
             conexion.ConnectionString = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
             //codigo para llenar el comboBox
             DataSet ds = new DataSet();
             //endicamos la consulta en SQL
             SqlDataAdapter da = new SqlDataAdapter("SELECT Descripcion_Percha FROM IN_M_PERCHA", conexion);
             //se indica el nombre de la tabla
             da.Fill(ds, "IN_M_PERCHA");
             cbxPercha.DataSource = ds.Tables[0].DefaultView;
             //se especifica el campo de la tabla
             cbxPercha.ValueMember = "Descripcion_Percha";
         }

         private void txtCodigoProducto_Click(object sender, EventArgs e)
         {
              OpenFileDialog BuscarImagen = new OpenFileDialog();
              BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
             //Aquí incluiremos los filtros que queramos.
              BuscarImagen.FileName = "";
              BuscarImagen.Title = "Titulo del Dialogo";
              BuscarImagen.InitialDirectory = "C:\\";
              BuscarImagen.FileName = this.txtBuscarImagen.Text;

            //++++++++++++++++++++++++++++ INSERTAR IMAGEN +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             if (BuscarImagen.ShowDialog() == DialogResult.OK)
            /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.txtBuscarImagen.Text = BuscarImagen.FileName;
                String Direccion = BuscarImagen.FileName;
                this.pbxProducto.ImageLocation = Direccion;

             //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
             //this.pictureBox1.ImageLocation = textBox1.Text;
         }

         private void btnTipoProducto_Click(object sender, EventArgs e)
         {
             frmTipoProducto frm = new frmTipoProducto();
             frm.ShowDialog();
         }

         private void button2_Click(object sender, EventArgs e)
         {
             frmMantMedida frm = new frmMantMedida();
             frm.ShowDialog();
         }

         private void button1_Click(object sender, EventArgs e)
         {
             frmMantBodega frm = new frmMantBodega();
             frm.ShowDialog();
         }

         private void button3_Click(object sender, EventArgs e)
         {
             frmMantPercha frm = new frmMantPercha();
             frm.ShowDialog();
         }

         private void cbbCodigoProducto_CheckedChanged(object sender, EventArgs e)
         {
             if (cbbCodigoProducto.Checked)
                 textBox3.Enabled = true;
             else
                 textBox3.Enabled = false;
         }

         private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
         {
             textBox3.Clear();
             txtDescripcionProducto.Clear();
             txtExistencia.Clear();
             txtExisMinima.Clear();
             txtExisMaxima.Clear();
             txtPrecio.Clear();
             txtCosto.Clear();

         }
     
         private void btnBusquedaPorCriterio_Click_1(object sender, EventArgs e)
         {
             int selectedIndextp = cbxTipoProducto.SelectedIndex;
             int selectedIndexm = cbxMedida.SelectedIndex;
             int selectedIndexb = cbxBodega.SelectedIndex;
             int selectedIndexp = cbxPercha.SelectedIndex;
             int selectedIndexe = cbxEstado.SelectedIndex;
             Object selectedItemtp = cbxTipoProducto.SelectedItem;
             Object selectedItemm = cbxMedida.SelectedItem;
             Object selectedItemb = cbxBodega.SelectedItem;
             Object selectedItemp = cbxPercha.SelectedItem;          
             Object selectedIteme = cbxEstado.SelectedItem;

             try
             {
                 if (!string.IsNullOrEmpty(selectedItemtp.ToString()) || !string.IsNullOrEmpty(selectedItemm.ToString()) 
                    || !string.IsNullOrEmpty(selectedItemb.ToString())
                     || !string.IsNullOrEmpty(selectedItemp.ToString()) 
                     || !string.IsNullOrEmpty(textBox3.Text))
                 {
                     RN_Producto con = new RN_Producto();
                     if (con.conectar())
                     {
                         String coneccion = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
                         SqlConnection cnn = new SqlConnection(coneccion);
                         cnn.Open();
                         String cons = "select * from IN_M_PRODUCTO where Codigo_Producto = " + textBox3.Text;
                         SqlCommand cmd = new SqlCommand(cons, cnn);               
                         
                         try
                         {
                             SqlDataReader r = cmd.ExecuteReader();
                             r.Read();
                             textBox3.Text = Convert.ToString(r.GetValue(0));
                             txtDescripcionProducto.Text = Convert.ToString(r.GetValue(1));
                             cbxTipoProducto.Text = Convert.ToString(r.GetValue(2));
                             cbxMedida.Text = Convert.ToString(r.GetValue(3));
                             cbxBodega.Text = Convert.ToString(r.GetValue(4));
                             cbxPercha.Text = Convert.ToString(r.GetValue(5));
                             txtExistencia.Text = Convert.ToString(r.GetValue(6));
                             txtExisMinima.Text = Convert.ToString(r.GetValue(7));
                             txtExisMaxima.Text = Convert.ToString(r.GetValue(8));
                             txtCosto.Text = Convert.ToString(r.GetValue(9));
                             txtPrecio.Text = Convert.ToString(r.GetValue(10));
                             cbxEstado.Text = Convert.ToString(r.GetValue(11));
                        }

                        catch
                        {
                            MessageBox.Show("No existe el producto");
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

         private void cbxTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
         {
             cbxTipoProducto.Items.Clear();
             llenaComboBoxTipoProducto();
         }

         private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
         {

         }

         private void dgbProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }
    }                    
}
