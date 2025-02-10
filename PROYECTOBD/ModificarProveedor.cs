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
    public partial class ModificarProveedor : Form
    {
       


        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public ModificarProveedor()
        {
            InitializeComponent();
            funQuery();
        }

        /// <summary>
        /// Este metodo hace la consulta de la tabla y la actualiza 
        /// </summary>
        public void funQuery()
        {
            string query = "Select * from Proveedores";
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
            txtModDireccion.Text = string.Empty;
            txtModTelefono.Text = string.Empty;
           
        }

        //Limpia pantalla
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }


        //Modifica el registro
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // esta validacion verifica que el ID a modificar no este vacio
            if (txtIDproveedor.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un ID de proveedor a modificar.");
                clear();
            }
            else
            {
                /// Las siguentes 3 validaciones verificar si hay alguno de lo campos queda vacio, en ese caso mantendra el valor anterior
                if (txtModNombre.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT nombre FROM Proveedores WHERE ID = {txtIDproveedor.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModNombre.Text = resultado.ToString();

                }

                if (txtModDireccion.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT direccion FROM Proveedores WHERE ID = {txtIDproveedor.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModDireccion.Text = resultado.ToString();

                }
                if (txtModTelefono.Text == "")
                {
                    connection.Open();
                    string queryFecha = $"SELECT telefono FROM Proveedores WHERE ID = {txtIDproveedor.Text}";
                    SqlCommand command = new SqlCommand(queryFecha, connection);
                    var resultado = command.ExecuteScalar();
                    connection.Close();
                    txtModTelefono.Text = resultado.ToString();

                }

                /// Reliza la modificacion a la Base de Datos y muestra los cambios
                int flag = 0;
                connection.Open();
                string query = $"UPDATE Proveedores set nombre = '{txtModNombre.Text}', direccion = '{txtModDireccion.Text}', telefono = {txtModTelefono.Text} " +
                    $" WHERE ID = '{txtIDproveedor.Text}'";
                SqlCommand comand = new SqlCommand(query, connection);
                flag = comand.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show($"El proveedor con el ID {txtIDproveedor.Text} ha sido modificado.");
                    funQuery();
                    clear();
                }
                else
                {
                    MessageBox.Show("El Proveedor no ha sido encontrado.");
                    clear();

                }
                connection.Close();
               
            }
        }
    }
}
