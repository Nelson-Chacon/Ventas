using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL.Rentas
{
    public class ProductosBL//clase creada para poder realizar operaciones con los productos
    {
        public BindingList<Producto> ListaProducto { get; set; }//prpiedad creada para crear una lista de productos

        public ProductosBL()//lista de los productos ya regisrados
        {
            ListaProducto = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Iphone X";
            producto1.Precio = 25000;
            producto1.Existencia = 15;
            producto1.Activo = true;

            ListaProducto.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Samsung Galaxy S9";
            producto2.Precio = 20000;
            producto2.Existencia = 8;
            producto2.Activo = true;

            ListaProducto.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "LG J7";
            producto3.Precio = 12000;
            producto3.Existencia = 10;
            producto3.Activo = true;

            ListaProducto.Add(producto3);

        }

        public BindingList<Producto> ObtenerProducto()//Mostramos productos
        {
           return ListaProducto;
        }

        public Resultado GuardarProducto(Producto producto)//para guardar producto y validar con tipo Resultado que es la clase creada
        {
            var resultado = Validar(producto);//llamamos la funcion en la cual validamos el producto para poder agregar
            if (resultado.Exitoso==false)
            {
                return resultado;
            }



            if (producto.Id==0)
            {
                producto.Id = ListaProducto.Max(item => item.Id) + 1;//intruccion para asignar un codigo
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()//private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var nuevoProducto = new Producto();//variable vacia creada para agregar productos desde la ventana de windows
            ListaProducto.Add(nuevoProducto);// forma de como agregar los produtos
        }

        public bool EliminarProducto(int id)//funcion creada para eliminar productos
        {
            foreach (var producto in ListaProducto)//funcion para recorrer la lista de producto
            {
                if (producto.Id == id)
                {
                    ListaProducto.Remove(producto);//intruccion para remover el producto eliminado
                    return true;//en caso de que el producto se encuentre el producto eliminara desde el boton
                }
            }

            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion)== true)//validando que la descripcion no sea vacia 
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }
            if (producto.Existencia < 0)//validando que la existencia sea mayor que 0
            {
                resultado.Mensaje = "La Existencia debe de ser mayor de cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)//validando el precio
            {
                resultado.Mensaje = "El precio debe de ser mayor de cero";
                resultado.Exitoso = false;
            }

            return resultado;


        }




        }
    

public class Producto// clase creada para poder manipular base de dato contiene las propiedades del producto
    {
        public int Id{ get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

public class Resultado//clase creada para validaciones evitar el uso de datos erroneo como ser megativos
    {
        public bool Exitoso { get; set; }

        public string Mensaje { get; set; }
    }



}


