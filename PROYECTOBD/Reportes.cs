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
    public partial class Reportes : Form
    {
        // Crear conexion a la base de datos SQL
        static string stringConnection = "server= DESKTOP-JNRPR72\\SQLEXPRESS ; database= Inventario ; integrated security= true";
        SqlConnection connection = new SqlConnection(stringConnection);

        public Reportes()
        {
            InitializeComponent();
        }

        // Reporte 1
        private void btn1_Click(object sender, EventArgs e)
        {
            string query = "Select TOP 5 ID_Producto,COUNT(*) AS venta from Pedidos GROUP BY ID_Producto ORDER BY venta DESC";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        //Reporte 2
        private void btn2_Click(object sender, EventArgs e)
        {
            string query = "Select TOP 1 Proveedores.nombre AS Proveedor, SUM(Productos.cantidad) AS TotalInventario from Productos INNER JOIN Proveedores ON Productos.ID_Proveedor = Proveedores.ID GROUP BY Proveedores.nombre ORDER BY TotalInventario DESC";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Reporte 3
        private void btn3_Click(object sender, EventArgs e)
        {
            string query = "Select SUM(precio * cantidad) AS Total_Inventario FROM Productos";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Reporte 4
        private void btn4_Click(object sender, EventArgs e)
        {
            string query = "Select COUNT(*) AS Pedidos_ultimo_mes FROM Pedidos WHERE fecha between '2025-02-01' AND '2025-02-28'";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Reporte 5
        private void btn5_Click(object sender, EventArgs e)
        {
            string query = "Select cliente, COUNT(*) AS Pedidos_hechos FROM Pedidos GROUP BY cliente ORDER BY Pedidos_hechos DESC";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Reporte 6
        private void btn6_Click(object sender, EventArgs e)
        {
            string query = "Select P1.categoria, P1.nombre AS ProductoVendido, P1.Total_venta FROM (SELECT categoria, nombre,COUNT(*) AS Total_venta FROM Productos INNER JOIN Pedidos ON Productos.ID = Pedidos.ID_Producto GROUP BY categoria, nombre) AS P1 INNER JOIN (SELECT categoria, MAX(Total_venta) AS MaxVentas FROM (SELECT categoria,nombre,COUNT(*) AS Total_venta FROM Productos INNER JOIN Pedidos ON Productos.ID = Pedidos.ID_Producto GROUP BY categoria, nombre) AS P2 GROUP BY categoria) AS P3 ON P1.categoria = P3.categoria AND P1.Total_venta = P3.MaxVentas ";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // Reporte 7
        private void btn7_Click(object sender, EventArgs e)
        {
            string query = "SELECT Proveedores.nombre AS Proveedor, AVG(Productos.precio) AS Precio_Promedio FROM Productos INNER JOIN Proveedores ON Productos.ID_Proveedor = Proveedores.ID GROUP BY Proveedores.nombre ORDER BY Precio_Promedio ASC  ";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        // Reporte 8
        private void btn8_Click(object sender, EventArgs e)
        {
            string query = "SELECT Productos.nombre, Pedidos.fecha FROM Productos INNER JOIN Pedidos ON Productos.ID = Pedidos.ID_Producto WHERE Productos.cantidad = 0 AND Pedidos.fecha BETWEEN '2024-12-1' AND '2025-03-01' ORDER BY Pedidos.fecha DESC  ";
            SqlCommand comand = new SqlCommand(query, connection);
            SqlDataAdapter data = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
