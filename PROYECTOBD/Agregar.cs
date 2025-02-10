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
    public partial class Agregar : Form
    {

        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto AgregarP = new Producto();
            AgregarP.Show();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedido AgregarPed = new Pedido();
            AgregarPed.Show();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor AgregarProv = new Proveedor();
            AgregarProv.Show();
        }
    }
}
