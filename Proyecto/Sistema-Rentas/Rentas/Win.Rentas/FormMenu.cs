using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new Form1Login();
            formLogin.ShowDialog();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProductos();
            formProducto.MdiParent = this;
            formProducto.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRentar = new FormRentas();
            formRentar.MdiParent = this;
            formRentar.Show();
        }
    }
}
