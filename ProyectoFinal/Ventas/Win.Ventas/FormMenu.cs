using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Ventas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new FormLogin();
            
            formLogin.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
                formProducto.MdiParent = this;
                formProducto.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCliente = new FormClientes();
                formCliente.MdiParent = this;
                formCliente.Show();
        }

        private void retarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.Show();
        }
    }
}
