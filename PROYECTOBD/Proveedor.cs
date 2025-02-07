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

namespace PROYECTOBD
{
    public partial class Proveedor : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public Proveedor()
        {
            InitializeComponent();
            funQuery();
        }
    /// <summary>
    /// Boton pora agregar un proveedor a la base de datos
    /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((((txtAgregarID.Text == "" || txtAgregarNombre.Text == "")
                || txtAgregarDireccion.Text == "") || txtAgregarTelefono.Text == "") || txtAgregarID.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser rellenados.");
                clear();
            }
            else
            {
                connection.Open();

                string query = $"Insert Into Proveedores ([ID],[nombre], [direccion],[telefono])" +
                    $"values ('{txtAgregarID.Text}','{txtAgregarNombre.Text}'," +
                    $"'{txtAgregarDireccion.Text}','{txtAgregarTelefono.Text}')";
                SqlCommand comand = new SqlCommand(query, connection);
                comand.ExecuteNonQuery();
                MessageBox.Show($"El proveedor: {txtAgregarNombre.Text} ha sido añadido.");
                funQuery();
                clear();
                connection.Close();
            }
        }

        public void funQuery()
        {
            string query = "Select * from Proveedores";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        ///  Metodo que limpia los txt
        /// </summary>
        public void clear()
        {
            txtAgregarNombre.Text = string.Empty;
            txtAgregarID.Text = string.Empty;
            txtAgregarDireccion.Text = string.Empty;
            txtAgregarTelefono.Text = string.Empty;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }


    }
}
