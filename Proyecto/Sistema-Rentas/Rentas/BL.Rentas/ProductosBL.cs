using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProducto { get; set; }

        public ProductosBL()
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
        public BindingList<Producto> ObtenerProducto()
        {
            return ListaProducto;
        }
        public bool GuardarProducto(Producto producto)
        {
            if (producto.Id==0)
            {
                producto.Id = ListaProducto.Max(item => item.Id) + 1;
            }
            return true;
        }
        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProducto.Add(nuevoProducto);
        }

        }
    

public class Producto// clase creada para poder manipular base de dato
    {
        public int Id{ get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}
