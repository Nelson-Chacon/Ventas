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
            Login();//funcion con la cual el menu inicia
        }

        private void Login()
        {
            var formLogin = new Form1Login();// instanciamos la clase
            formLogin.ShowDialog();//mostramos un cuadro de dialogo con lo que contiene la clase login
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)// boton de login(inicio de sesion)
        {
            Login();//llamamos la funcion con la cual hemos realizado la operaciones de login
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)//boton de menu con la opcion producto
        {
            var formProducto = new FormProductos();//intanciamos la clase Productos
            formProducto.MdiParent = this;//intruccion que permine mostrar la ventana dentro del menu
            formProducto.Show();//mostramos la ventana con su contenido
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente();//intanciamos la clase Cliente
            formCliente.MdiParent = this;//intruccion que permine mostrar la ventana dentro del menu
            formCliente.Show();//mostramos la ventana con su contenido
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRentar = new FormRentas();//intanciamos la clase Rentas
            formRentar.MdiParent = this;//intruccion que permine mostrar la ventana dentro del menu
            formRentar.Show();//mostramos la ventana con su contenido
        }
    }
}
