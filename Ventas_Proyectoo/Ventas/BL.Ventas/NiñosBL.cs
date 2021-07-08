using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class NiñosBL
    {
        Contexto _contexto;
        public BindingList<Niño> ListaproNinos { get; set; }
        public NiñosBL()
        {
            _contexto = new Contexto();
            ListaproNinos = new BindingList<Niño>();
        }

        public BindingList<Niño> Obtener_Producto ()
        {
            _contexto.Niños.Load();

            ListaproNinos = _contexto.Niños.Local.ToBindingList();
            return ListaproNinos;
        }
        public Resultado GuardarProducto(Niño niño)
        {
            var resultado = validar(niño);
            if (resultado.Exitoso==false)
            {
                return resultado;
            }
            if (niño.Codigo == 0)
            {
                niño.Codigo = ListaproNinos.Max(item => item.Codigo) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void agregarproducto()
        {
            var nuevoProducto = new Niño();
            ListaproNinos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int codigo)
        {
            foreach (var producto in ListaproNinos)
            {
                if (producto.Codigo == codigo)
                {
                    ListaproNinos.Remove(producto);

                    return true;
                }
            }
            return false;
        }

        private Resultado validar(Niño niño)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(niño.Descripcion)==true)

            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (niño.Existencia<0)
            {
                resultado.Mensaje = "La existencia debe de ser mayor a cero";
                resultado.Exitoso = false;
            }

            if (niño.Precio < 0)
            {
                resultado.Mensaje = "El precio debe de ser mayor a cero";
                resultado.Exitoso = false;
            }


            return resultado;
        }
    }

    public class Niño
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
