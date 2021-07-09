using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class MujerBL
    {

        public BindingList<Mujer> ListaproMujer { get; set; }
        public MujerBL()
        {
            ListaproMujer = new BindingList<Mujer>();

            var a = new Mujer();
            a.Codigo = 1;
            a.Descripcion = "camisa";
            a.Precio = 15.50;
            a.Categoria = "Ropa";
            a.Existencia = 124;
            a.Activo = true;
            ListaproMujer.Add(a);

            var b = new Mujer();
            b.Codigo = 2;
            b.Descripcion = "camisa";
            b.Precio = 15.50;
            b.Categoria = "Ropa";
            b.Existencia = 124;
            b.Activo = true;
            ListaproMujer.Add(b);
        }

        public BindingList<Mujer> Obtener_Producto()
        {
            return ListaproMujer;
        }
        public Resultado GuardarProducto(Mujer mujer)
        {
            var resultado = validar(mujer);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (mujer.Codigo == 0)
            {
                mujer.Codigo = ListaproMujer.Max(item => item.Codigo) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void agregarproducto()
        {
            var nuevoProducto = new Mujer();
            ListaproMujer.Add(nuevoProducto);
        }

        public bool EliminarProducto(int codigo)
        {
            foreach (var producto in ListaproMujer)
            {
                if (producto.Codigo == codigo)
                {
                    ListaproMujer.Remove(producto);

                    return true;
                }
            }
            return false;
        }

        private Resultado validar(Mujer mujer)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(mujer.Descripcion) == true)

            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (mujer.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe de ser mayor a cero";
                resultado.Exitoso = false;
            }

            if (mujer.Precio < 0)
            {
                resultado.Mensaje = "El precio debe de ser mayor a cero";
                resultado.Exitoso = false;
            }


            return resultado;
        }
    }

    public class Mujer:Niño
    {
        public int Codigo { get; set; }

    }
    public class ResultadoM:Resultado
    {
        
    }

}

