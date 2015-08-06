using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Modulo_Seguridad
{
    public partial class Frmempleado : Form
    {
        public String co = "";
        public String no = "";

        enum e_FILTER_OPTION { SIN_FILTRO, CADENA_QUE_COMIENCE_CON, CADENA_QUE_NO_COMIENCE_CON, CADENA_QUE_CONTENGA, CADENA_QUE_NO_CONTENGA, CADENA_IGUAL };
        enum e_FILTER_OPTION1 { SIN_FILTRO1, NUMERICO_MENOR, NUMERICO_MAYOR, NUMERICO_MENOR_IGUAL, NUMERICO_MAYOR_IGUAL, NUMERICO_IGUAL, NUMERICO_DISTINTO };
        public BindingSource BindingSource1 = new BindingSource();
        public Frmempleado()
        {
            InitializeComponent();
        }
        int Filtrar_DataGridView(String Columna, String texto, BindingSource BindingSource1, DataGridView DataGridView,
             e_FILTER_OPTION bus)
        {

            if (BindingSource1.DataSource == null)

                return 0;


            try
            {
                String filtro = null;
                switch (bus)
                {
                    case e_FILTER_OPTION.CADENA_QUE_COMIENCE_CON:
                        filtro = "like '" + texto + "%'";
                        break;
                    case e_FILTER_OPTION.CADENA_QUE_NO_COMIENCE_CON:
                        filtro = "Not like '" + texto + "%'";
                        break;
                    case e_FILTER_OPTION.CADENA_QUE_CONTENGA:
                        filtro = "Not like '%" + texto + "%'";
                        break;
                    case e_FILTER_OPTION.CADENA_QUE_NO_CONTENGA:
                        filtro = "like '%" + texto + "%'";
                        break;
                    case e_FILTER_OPTION.CADENA_IGUAL:
                        filtro = "='" + texto + "'";
                        break;
                    default:
                        MessageBox.Show("Nooooooooooo");
                        break;
                }
                if (bus == e_FILTER_OPTION.SIN_FILTRO)
                    filtro = "";


                if (filtro != null)
                    filtro = "[" + Columna + "]" + filtro;



                BindingSource1.Filter = filtro;
                DataGridView.DataSource = BindingSource1.DataSource;

                return (BindingSource1.Count);

            }
            catch
            {
                MessageBox.Show("error");
                return 0;
                //MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)  
            }
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        int Filtrar_DataGridView1(String Columna, String texto, BindingSource BindingSource1, DataGridView DataGridView,
             e_FILTER_OPTION1 bus)
        {

            if (BindingSource1.DataSource == null)

                return 0;


            try
            {
                String filtro = null;
                switch (bus)
                {
                    case e_FILTER_OPTION1.NUMERICO_MENOR:
                        filtro = "< " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_MAYOR:
                        filtro = "> " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_MENOR_IGUAL:
                        filtro = "<= " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_MAYOR_IGUAL:
                        filtro = ">= " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_IGUAL:
                        filtro = "= " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_DISTINTO:
                        filtro = "!= " + texto + "";
                        break;
                    default:
                        MessageBox.Show("Nooooooooooo");
                        break;
                }

                if (bus == e_FILTER_OPTION1.SIN_FILTRO1 | !IsNumeric(texto))
                    filtro = "";


                if (filtro != null)
                    filtro = "[" + Columna + "]" + filtro;



                BindingSource1.Filter = filtro;
                DataGridView.DataSource = BindingSource1.DataSource;

                return (BindingSource1.Count);

            }
            catch
            {
                MessageBox.Show("error");

                //MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)  
            }
            return 0;
        }
        public void filnum()
        {
            int ret = Filtrar_DataGridView("nombre", Convert.ToString(txtNombre.Text), BindingSource1, dataGridView1,
                                        (e_FILTER_OPTION)cmbFiltro.SelectedIndex);
            if (ret == 0)

                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = Color.White;
        }
        public void filnum1()
        {
            if (txtNombre.Text == "")
                txtNombre.Text = "0";
            int ret = Filtrar_DataGridView1("codigo", txtNombre.Text, BindingSource1, dataGridView1,
                                        (e_FILTER_OPTION1)cmbFiltro.SelectedIndex);
            if (ret == 0)

                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = Color.White;
        }
        private void Frmempleado_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            if (rdbNombre.Checked == (true))
                filnum();
            else
                filnum1();
        }
        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public void ini()
        {

            String a = "Data Source=FAMILIADLV-PC\\SQLEXPRESS;Initial Catalog=SAV;Integrated Security=True";
            String b = "FC_BUS_EMPLEADO";


            SqlDataAdapter da = new SqlDataAdapter(b, a);
            DataTable ta = new DataTable();
            da.Fill(ta);
            dataGridView1.DataSource = ta;
            BindingSource1.DataSource = ta;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow f = this.dataGridView1.CurrentRow;
            this.co = Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            this.no = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
            this.Close();
        }

        private void rdbCodigo_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("No filtrar");
            cmbFiltro.Items.Add("Que comience con");
            cmbFiltro.Items.Add("Que No comience con");
            cmbFiltro.Items.Add("Que contenga");
            cmbFiltro.Items.Add("Que No contenga");
            cmbFiltro.Items.Add("Que sea igual");
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.SelectedIndex = 1;
        }

        private void rdbNombre_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("No filtrar");
            cmbFiltro.Items.Add("Que comience con");
            cmbFiltro.Items.Add("Que No comience con");
            cmbFiltro.Items.Add("Que contenga");
            cmbFiltro.Items.Add("Que No contenga");
            cmbFiltro.Items.Add("Que sea igual");
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.SelectedIndex = 1;
        }

        private void Frmempleado_Load_1(object sender, EventArgs e)
        {
            Capa con = new Capa();
            try
            {
                if (con.conectar())
                {
                    ini();
                    cmbFiltro.Items.Add("No filtrar");
                    cmbFiltro.Items.Add("Que comience con");
                    cmbFiltro.Items.Add("Que No comience con");
                    cmbFiltro.Items.Add("Que contenga");
                    cmbFiltro.Items.Add("Que No contenga");
                    cmbFiltro.Items.Add("Que sea igual");
                    cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbFiltro.SelectedIndex = 1;
                }
            }
            catch
            {
                MessageBox.Show("Coneccion error", "Coneccion");
            }
        }
    }
}
