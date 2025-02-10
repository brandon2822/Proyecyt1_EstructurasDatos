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
    public partial class Mostrar : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public Mostrar()
        {
            InitializeComponent();
        }


        // Funcion que muestra la tabla elegida en el textbox
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtTabla.Text == "")
            {
                MessageBox.Show("Por favor ingrese un nombre de tabla.");
             
            } else if (txtTabla.Text.ToLower() == "pedidos")
            {
                string query = "Select * from Pedidos";
                SqlCommand comand = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (txtTabla.Text.ToLower() == "productos")
            {
                string query = "Select * from Productos";
                SqlCommand comand = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (txtTabla.Text.ToLower() == "proveedores")
            {
                string query = "Select * from Proveedores";
                SqlCommand comand = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Profavor ingrese un nombre de tabla correcto.");
            }

            txtTabla.Text = string.Empty;

        }
    }
}
