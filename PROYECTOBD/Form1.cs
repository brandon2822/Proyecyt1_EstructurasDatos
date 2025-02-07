using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTOBD
{
    public partial class Form1 : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        Mostrar ventanaMostrar = new Mostrar();
        Agregar ventanaAgregar = new Agregar();

        public Form1()
        {
            InitializeComponent();
        }


        // Boton de Mostrar que abre la ventana para de Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ventanaMostrar.Show();
        }


        // Boton de agregar que abre la ventana de agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventanaAgregar.Show();

        }
    }
}
