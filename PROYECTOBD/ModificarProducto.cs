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
    public partial class ModificarProducto : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public ModificarProducto()
        {
            InitializeComponent();
            funQuery();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // esta validacion verifica que el ID a modificar no este vacio
            if (txtIDproducto.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un ID de Producto a modificar.");
                clear();
            }
            else
            {
                /// Las siguentes 3 validaciones verificar si hay alguno de lo campos queda vacio, en ese caso mantendra el valor anterior
                if (txtModNombre.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT nombre FROM Productos WHERE ID = {txtIDproducto.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModNombre.Text = resultado.ToString();

                }

                if (txtModDescripcion.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT descripcion FROM Productos WHERE ID = {txtIDproducto.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModDescripcion.Text = resultado.ToString();

                }
                if (txtModPrecio.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT precio FROM Productos WHERE ID = {txtIDproducto.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModPrecio.Text = resultado.ToString();

                }

                if (txtModCantidad.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT cantidad FROM Productos WHERE ID = {txtIDproducto.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModCantidad.Text = resultado.ToString();

                }

                if (txtModProveedor.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT ID_Proveedor FROM Productos WHERE ID = {txtIDproducto.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModProveedor.Text = resultado.ToString();

                }

                if (txtModCategoria.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT categoria FROM Productos WHERE ID = {txtIDproducto.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModCategoria.Text = resultado.ToString();

                }

                /// Reliza la modificacion a la Base de Datos y muestra los cambios
                int flag = 0;
                connection.Open();
                string query = $"UPDATE Productos set nombre = '{txtModNombre.Text}', descripcion = '{txtModDescripcion.Text}', precio = {txtModPrecio.Text}, cantidad = '{txtModCantidad.Text}'," +
                    $"categoria ='{txtModCategoria.Text}', ID_Proveedor = '{txtModProveedor.Text}' WHERE ID = '{txtIDproducto.Text}'";
                SqlCommand comand = new SqlCommand(query, connection);
                flag = comand.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show($"El producto con el ID {txtIDproducto.Text} ha sido modificado.");
                    funQuery();
                    clear();
                }
                else
                {
                    MessageBox.Show("El producto no ha sido encontrado.");
                    clear();

                }
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

        /// Limpia los textboxs

        public void clear()
        {
            txtModNombre.Text = string.Empty;
            txtModDescripcion.Text = string.Empty;
            txtModCantidad.Text = string.Empty;
            txtModPrecio.Text = string.Empty;
            txtModCategoria.Text = string.Empty;
            txtModProveedor.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }
    }

}
