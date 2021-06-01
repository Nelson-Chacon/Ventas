﻿using BL.Rentas;
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

            listaProductoBindingSource.DataSource =  _productos.ObtenerProducto();//LLamamos la funcion para mostrar los productos
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

            if (resultado == true)
            {
                listaProductoBindingSource.ResetBindings(false);//intruccion que nos permite poder cambiar los valores de las propiedades pero no asignar mas propiedades solo si esta: (True)

            }
            else
            {
                MessageBox.Show("!Ocurrio un error guardando el producto¡");//mensaje de error en caso de que ocurra
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)//boton de adicionar producto
        {
            _productos.AgregarProducto(); //llamamos la funcion 

            listaProductoBindingSource.MoveLast();//mueve el producto nuevo a la ultima posicion
        }
    }
}
