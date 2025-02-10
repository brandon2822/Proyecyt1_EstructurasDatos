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
    public partial class EliminarProducto : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public EliminarProducto()
        {
            InitializeComponent();
            funQuery();
        }

        /// <summary>
        /// Boton para eliminar un registro de producto
        /// </summary>
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int flag = 0;

            connection.Open();
            string query = $"DELETE FROM Productos WHERE nombre = '{txtNombre.Text}' AND ID = '{txtID.Text}'";
            SqlCommand comand = new SqlCommand(query, connection);
            flag = comand.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show($"El producto {txtNombre.Text} ha sido eliminado.");
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
        /// Limpia los textboxs
        /// </summary>
        public void clear()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        /// <summary>
        /// Boton de cancelar
        /// </summary>
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            MessageBox.Show("Operacion cancelada");
        }
    }
}
