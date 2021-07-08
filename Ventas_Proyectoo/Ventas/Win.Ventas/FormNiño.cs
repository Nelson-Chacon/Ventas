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
    public partial class FormNiño : Form
    {

        NiñosBL _niños;
        public FormNiño()
        {
            
            InitializeComponent();

            _niños = new NiñosBL();

            niñoBindingSource.DataSource = _niños.Obtener_Producto();
        }

        private void FormNiño_Load(object sender, EventArgs e)
        {

        }

        private void niñoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            niñoBindingSource.EndEdit();

            var niños = (Niño)niñoBindingSource.Current;

            var resultado = _niños.GuardarProducto(niños);

            if (resultado.Exitoso == true)
            {
                niñoBindingSource.ResetBindings(false);
                DeshabilitarHabilitarbotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _niños.agregarproducto();
            niñoBindingSource.MoveLast();
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
            
            var resultado = _niños.EliminarProducto(codigo);

            if (resultado == true)
            {
                niñoBindingSource.ResetBindings(false);
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
