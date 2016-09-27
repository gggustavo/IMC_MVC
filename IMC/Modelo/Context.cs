using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Modelo
{
    public class Context : DbContext
    {
        public Context() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Persona>().HasKey(_ => _.Dni);

            modelBuilder.Entity<Atencion>().HasKey(_ => _.IdAtencion);
        }

        public DbSet<Persona> Personas { get; set; }
        //public DbSet<Hombre> Hombres { get; set; }
        //public DbSet<Mujer> Mujeres { get; set; }
        //public DbSet<Medico> Medicos { get; set; }
        public DbSet<Atencion> Atenciones { get; set; }
    }

}
