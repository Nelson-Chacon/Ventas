using BL.Ventas;
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
    public partial class FormHombre : Form
    {
        HombreBL _hombre;
        public FormHombre()
        {
            InitializeComponent();
            _hombre= new HombreBL();
            hombreBindingSource.DataSource = _hombre.Obtener_Producto();
        }

        private void FormHombre_Load(object sender, EventArgs e)
        {

        }

        private void hombreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            hombreBindingSource.EndEdit();

            var niños = (Hombre)hombreBindingSource.Current;

            var resultado = _hombre.GuardarProducto(niños);

            if (resultado.Exitoso == true)
            {
                hombreBindingSource.ResetBindings(false);
                DeshabilitarHabilitarbotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _hombre.agregarproducto();
            hombreBindingSource.MoveLast();
            DeshabilitarHabilitarbotones(false);
        }

        private void DeshabilitarHabilitarbotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text != "")
            {

                var resultado = MessageBox.Show("Decea eliminar este registo?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var codigo = Convert.ToInt32(codigoTextBox.Text);

                    Eliminar(codigo);
                }
            }
        }

        private void Eliminar(int codigo)
        {

            var resultado = _hombre.EliminarProducto(codigo);

            if (resultado == true)
            {
                hombreBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarbotones(true);

            Eliminar(0);
        }
    }
}
