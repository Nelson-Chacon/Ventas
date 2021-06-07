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
        ProductosBL _productos;//creamos una variable global



        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();//instaciamos la otra solucion

            listaProductoBindingSource.DataSource = _productos.ObtenerProducto();//LLamamos la funcion para mostrar los productos
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void listaProductoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaProductoBindingNavigatorSaveItem_Click(object sender, EventArgs e)//boton para guardar el producto
        {
            listaProductoBindingSource.EndEdit();//instruccion para que el usuario pueda seguir editando la creacion del nuevo producto

            var producto = (Producto)listaProductoBindingSource.Current;// creacion de la variable"producto" para poder guardar el producto actual (el nuevo producto)

            var resultado = _productos.GuardarProducto(producto); // Instruccion con el producto ya agregado

            if (resultado.Exitoso== true)
            {
                listaProductoBindingSource.ResetBindings(false);//intruccion que nos permite poder cambiar los valores de las propiedades pero no asignar mas propiedades solo si esta: (True)
                DeshabilitarHabiliarBotones(true);
                MessageBox.Show("El producto a sido guardado exitosamente");//mensaje de confirmacion que el producto se guardo
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);//mensaje de error en caso de que ocurra
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)//boton de adicionar producto
        {
            _productos.AgregarProducto(); //llamamos la funcion 

            listaProductoBindingSource.MoveLast();//mueve el producto nuevo a la ultima posicion

            DeshabilitarHabiliarBotones(false);//llama la funcion con el valor de falso
        }

        private void DeshabilitarHabiliarBotones(bool valor) //funcion para inicializar el estado de los botones de la barra de navegacion
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)//boton de eliminar
        {
            var resultado = MessageBox.Show("Decea eliminar este registro","Eliminar", MessageBoxButtons.YesNo);//creacion de variable y asignacion de una ventana para verificar la eliminacion y de la misma manera asignacion de titulo y habilitacion de botones Si o NO
            if (resultado==DialogResult.OK)//Opcion para validar si el usuario ingreso si o no de la ventana anterior
            {

            }

            if (idTextBox.Text != "")
            {
                if (resultado == DialogResult.Yes)//Opcion para validar si el usuario ingreso si o no de la ventana anterior
                {
                    var id = Convert.ToInt32(idTextBox.Text);// convertir 
                    Eliminar(id);//llama a ala funcion eliminar
                }

            }
        }

        private void Eliminar(int id)//opcion para eliminar un producto (funvion)
        { 
           
            var resultado = _productos.EliminarProducto(id);//llama la funcion de la libreria productosbl

            if (resultado == true)
            {
                listaProductoBindingSource.ResetBindings(false);///opcion para reiniciar la lita de los productos una vez eliminados
            }
            else
            {
                MessageBox.Show("Ocurrio un error en eliminacion del producto");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)//boton de cancelar
        {
            DeshabilitarHabiliarBotones(true);//llama la funcion para habilitar botones
            Eliminar(0);
        }

        
    }
}
