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
    public partial class Pedido : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public Pedido()
        {
            InitializeComponent();
            funQuery();
        }

        /// <summary>
        /// Valida que todos los campos hayan sido llenados, despues añade los datos a la tabla
        /// </summary>

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((((txtAgregarID.Text == "" || txtAgregarFecha.Text == "")
                || txtAgregarCliente.Text == "") || txtAgregarIDProducto.Text == "") || txtAgregarID.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser rellenados.");
                clear();
            } 
            else
            {
                connection.Open();

                string query = $"Insert Into Pedidos ([ID],[fecha], [cliente],[ID_Producto])" +
                    $"values ('{txtAgregarID.Text}','{txtAgregarFecha.Text}'," +
                    $"'{txtAgregarCliente.Text}','{txtAgregarIDProducto.Text}')";
                SqlCommand comand = new SqlCommand(query, connection);
                comand.ExecuteNonQuery();
                MessageBox.Show($"El pedido hecho el: {txtAgregarFecha.Text} ha sido añadido.");
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
            string query = "Select * from Pedidos";
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
            txtAgregarFecha.Text = string.Empty;
            txtAgregarID.Text = string.Empty;
            txtAgregarCliente.Text = string.Empty;
            txtAgregarIDProducto.Text = string.Empty;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        
    }
}
