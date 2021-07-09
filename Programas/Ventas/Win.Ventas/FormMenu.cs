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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void departamentoDeNiñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formnino = new FormNiño();
            formnino.MdiParent = this;
            formnino.Show();
        }

        private void departamentoDeMujerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMujer = new FormMujer();
            formMujer.MdiParent = this;
            formMujer.Show();
        }

        private void departamentoDeHombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHombre = new FormHombre();
            formHombre.MdiParent = this;
            formHombre.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }
    }
}
