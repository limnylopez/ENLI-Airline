using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Practicas
{
    class Contexto: DbContext
    {
        public Contexto(): base("VideoJuegos") //en base, lo que esta en parentesis nombramos nuestra base de datos
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //eliminanos la pluralizacion en las tablas de la base de datos
        }

        public DbSet<Producto> Productos { get; set; } // DbSet, crea listas para bases de datos. Creamos tabla de llamada producto
    }
}
