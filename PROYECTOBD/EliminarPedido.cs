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
    public partial class EliminarPedido : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public EliminarPedido()
        {
            InitializeComponent();
            funQuery();
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
        /// Limpia los textboxs
        /// </summary>
        public void clear()
        {
            txtIDPedido.Text = string.Empty;
            txtIDProducto.Text = string.Empty;
        }

        
        



        /// <summary>
        /// Boton para eliminar un registro de pedido
        /// </summary>

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int flag = 0;

            connection.Open();
            string query = $"DELETE FROM Pedidos WHERE ID = '{txtIDPedido.Text}' AND ID_Producto = '{txtIDProducto.Text}'";
            SqlCommand comand = new SqlCommand(query, connection);
            flag = comand.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show($"El pedido con el ID {txtIDPedido.Text} ha sido eliminado.");
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
        /// <summary>
        /// Boton cancalera
        /// </summary>
        
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            clear();
            MessageBox.Show("Operacion cancelada");
        }
    }
}
