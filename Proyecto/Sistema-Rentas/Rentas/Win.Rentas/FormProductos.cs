using BL.Rentas;
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
    public partial class FormProductos : Form
    {
        ProductosBL _productos;
        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();

            listaProductoBindingSource.DataSource =  _productos.ObtenerProducto();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void listaProductoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaProductoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductoBindingSource.EndEdit();

            var producto = (Producto)listaProductoBindingSource.Current;

            var resultado = _productos.GuardarProducto(producto);

            if (resultado == true)
            {
                listaProductoBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("!Ocurrio un error guardando el producto¡");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();

            listaProductoBindingSource.MoveLast();
        }
    }
}
