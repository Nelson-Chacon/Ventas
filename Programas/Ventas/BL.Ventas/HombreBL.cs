using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class HombreBL
    {
        public BindingList<Hombre> ListaproHombre { get; set; }
        public HombreBL()
        {
            ListaproHombre = new BindingList<Hombre>();

            var a = new Hombre();
            a.Codigo = 1;
            a.Descripcion = "camisa";
            a.Precio = 15.50;
            a.Categoria = "Ropa";
            a.Existencia = 124;
            a.Activo = true;
            ListaproHombre.Add(a);

            var b = new Hombre();
            b.Codigo = 2;
            b.Descripcion = "camisa";
            b.Precio = 15.50;
            b.Categoria = "Ropa";
            b.Existencia = 124;
            b.Activo = true;
            ListaproHombre.Add(b);
        }

        public BindingList<Hombre> Obtener_Producto()
        {
            return ListaproHombre;
        }
        public Resultado GuardarProducto(Hombre hombre)
        {
            var resultado = validar(hombre);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (hombre.Codigo == 0)
            {
                hombre.Codigo = ListaproHombre.Max(item => item.Codigo) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void agregarproducto()
        {
            var nuevoProducto = new Hombre();
            ListaproHombre.Add(nuevoProducto);
        }

        public bool EliminarProducto(int codigo)
        {
            foreach (var producto in ListaproHombre)
            {
                if (producto.Codigo == codigo)
                {
                    ListaproHombre.Remove(producto);

                    return true;
                }
            }
            return false;
        }

        private Resultado validar(Hombre hombre)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(hombre.Descripcion) == true)

            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (hombre.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe de ser mayor a cero";
                resultado.Exitoso = false;
            }

            if (hombre.Precio < 0)
            {
                resultado.Mensaje = "El precio debe de ser mayor a cero";
                resultado.Exitoso = false;
            }


            return resultado;
        }
    }

    public class Hombre : Niño
    {
        public int Codigo { get; set; }
    }
    public class ResultadoH : Resultado
    {

    }


}
