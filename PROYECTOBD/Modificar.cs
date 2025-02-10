using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBD
{
    public partial class Modificar : Form
    {

        public Modificar()
        {
            InitializeComponent();
        }

        private void btnModProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto producto = new ModificarProducto();
            producto.Show();
        }

        private void btnModPedido_Click(object sender, EventArgs e)
        {
            ModificarPedido pedido = new ModificarPedido();
            pedido.Show();
        }

        private void btnModProveedor_Click(object sender, EventArgs e)
        {
            ModificarProveedor proveedor = new ModificarProveedor();
            proveedor.Show();
        }
    }
}
