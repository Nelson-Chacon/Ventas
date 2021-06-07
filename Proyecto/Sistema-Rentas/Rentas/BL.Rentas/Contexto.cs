using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    class Contexto: DbContext//clase creada para poder usar con la base de dato y hereda la bibilioteca "Entity", da acceso a la base de dato
    {

        public Contexto():base("VideoJuegos")//instancia del entity y asignamos nombre dentro del parentesis
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)//intruccion para que no se pluralice las palabras
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Producto> Productos{ get; set; }//propiedad para crear una tabla con los productos en una base de datos

    }
}
