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
    public partial class FormMujer : Form
    {
        MujerBL _mujer;
        public FormMujer()
        {
            InitializeComponent();
            _mujer = new MujerBL();
            mujerBindingSource.DataSource = _mujer.Obtener_Producto();
        }

        private void mujerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            mujerBindingSource.EndEdit();

            var niños = (Mujer)mujerBindingSource.Current;

            var resultado = _mujer.GuardarProducto(niños);

            if (resultado.Exitoso == true)
            {
                mujerBindingSource.ResetBindings(false);
                DeshabilitarHabilitarbotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _mujer.agregarproducto();
            mujerBindingSource.MoveLast();
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
            toolStripButton1.Visible = !valor;
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

            var resultado = _mujer.EliminarProducto(codigo);

            if (resultado == true)
            {
                mujerBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarbotones(true);

            Eliminar(0);
        }
    }
  }

