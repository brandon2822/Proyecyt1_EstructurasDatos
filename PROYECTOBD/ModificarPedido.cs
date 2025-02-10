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
    public partial class ModificarPedido : Form
    {

        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public ModificarPedido()
        {
            InitializeComponent();
            funQuery();
        }


        // Este boton modifica el pedido segun su ID
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            // esta validacion verifica que el ID a modificar no este vacio
            if (txtIDpedido.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un ID de pedido a modificar.");
                clear();
            }
            else
            {
                /// Las siguentes 3 validaciones verificar si hay alguno de lo campos queda vacio, en ese caso mantendra el valor anterior
                if (txtModFecha.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT fecha FROM Pedidos WHERE ID = {txtIDpedido.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModFecha.Text = resultado.ToString();

                }

                if (txtModCliente.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT cliente FROM Pedidos WHERE ID = {txtIDpedido.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModCliente.Text = resultado.ToString();

                }
                if (txtModIDProducto.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT ID_Producto FROM Pedidos WHERE ID = {txtIDpedido.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModIDProducto.Text = resultado.ToString();

                }

                /// Reliza la modificacion a la Base de Datos y muestra los cambios
                int flag = 0;
                connection.Open();
                string query = $"UPDATE Pedidos set fecha = '{txtModFecha.Text}', cliente = '{txtModCliente.Text}', ID_Producto = {txtModIDProducto.Text} " +
                    $" WHERE ID = '{txtIDpedido.Text}'";
                SqlCommand comand = new SqlCommand(query, connection);
                flag = comand.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show($"El pedido con el ID {txtIDpedido.Text} ha sido modificado.");
                    funQuery();
                    clear();
                }
                else
                {
                    MessageBox.Show("El Pedido no ha sido encontrado.");
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
            string query = "Select * from Pedidos";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    
        /// Limpia los textboxs
   
        public void clear()
        {
            txtIDpedido.Text = string.Empty;
            txtModCliente.Text = string.Empty;
            txtModIDProducto.Text = string.Empty;
            txtModFecha.Text = string.Empty;
        }


        // limpia los registros
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
