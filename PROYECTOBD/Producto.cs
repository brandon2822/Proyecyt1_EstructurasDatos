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
    public partial class Producto : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public Producto()
        {
            InitializeComponent();
            funQuery();
        }


        /// <summary>
        /// Valida que todos los campos hayan sido llenados, despues añade los datos a la tabla
        /// </summary>
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((((((txtAgregarID.Text == "" || txtAgregarNombre.Text == "") || txtAgregarDescripcion.Text == "") || txtAgregarPrecio.Text == "") || txtAgregarCantidad.Text == "") || txtAgregarProveedor.Text == "") || txtAgregarID.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser rellenados.");
                clear();
            }
            else
            {
                connection.Open();
                
                string query = $"Insert Into Productos ([ID],[nombre], [descripcion],[cantidad]," +
                    $" [precio], [categoria],[ID_Proveedor]) " +
                    $"values ('{txtAgregarID.Text}','{txtAgregarNombre.Text}'," +
                    $"'{txtAgregarDescripcion.Text}','{txtAgregarCantidad.Text}','{txtAgregarPrecio.Text}'" +
                    $",'{txtAgregarCategoria.Text}','{txtAgregarProveedor.Text}')  ";
                SqlCommand comand = new SqlCommand(query, connection);
                comand.ExecuteNonQuery();
                MessageBox.Show($"El producto {txtAgregarNombre.Text} ha sido añadido.");
                funQuery();
                clear();
                connection.Close();
            }
        }

        /// <summary>
        /// Este metodo hace la consulta de la tabla y la actualiza 
        /// </summary>
        public void funQuery()
        {
            string query = "Select * from Productos";
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
            txtAgregarDescripcion.Text = string.Empty;
            txtAgregarCantidad.Text = string.Empty;
            txtAgregarPrecio.Text = string.Empty;
            txtAgregarProveedor.Text = string.Empty;
            txtAgregarCategoria.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
