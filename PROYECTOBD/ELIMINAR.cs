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
    
    public partial class ELIMINAR : Form
    {
   
        public ELIMINAR()
        {
            InitializeComponent();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)

        {
            EliminarProducto EliminarProd = new EliminarProducto();
            EliminarProd.ShowDialog();
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            EliminarPedido EliminarPedido = new EliminarPedido();
            EliminarPedido.ShowDialog();

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            EliminarProveedor EliminarProv = new EliminarProveedor();
            EliminarProv.ShowDialog();
        }
    }
}
