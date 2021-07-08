using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class Contexto: DbContext
    {

        public Contexto():base()
        {

        }
        public DbSet<Niño> Niños { get; set; }
    }
}
