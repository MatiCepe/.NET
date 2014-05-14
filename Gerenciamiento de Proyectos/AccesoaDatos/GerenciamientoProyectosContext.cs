using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AccesoaDatos
{
    public class GerencimientoProyectosContext : DbContext
    {
        public GerencimientoProyectosContext()
            : base("GerenciamientoProyectosDB")
        {           
        }

        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Valor> Valor { get; set; }
        public DbSet<Gerente> Gerente { get; set; }
        public DbSet<Factor> Factor { get; set; }
        public DbSet<ProyectoFactor> ProyectoFactor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            try
            {
                // Remocion de la pluralidad de las tablas
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                base.OnModelCreating(modelBuilder);

                //// Mapeo de Proyecto
                //  modelBuilder.Entity<Proyecto>().
                //  HasMany(c => c.Factores).
                //  WithMany().
                //  Map(mc =>
                //  {
                //      mc.MapLeftKey("ProyectoId");
                //      mc.MapRightKey("FactorId");
                //      mc.ToTable("ProyectoFactor");
                //  });

                //  modelBuilder.Entity<Proyecto>().
                //  HasMany(c => c.ValoresSeleccionados).
                //  WithMany().
                //  Map(mc =>
                //  {
                //      mc.MapLeftKey("ProyectoId");
                //      mc.MapRightKey("ValorId");
                //      mc.ToTable("ProyectoValor");
                //  });

                // Nuevo Mapeo de Proyecto
                /* modelBuilder.Entity<Proyecto>().
                     HasMany(c => c.ProyectoFactor);*/



                // Mapeo de Factor
                modelBuilder.Entity<Factor>().
                HasMany(c => c.ValoresSeleccionados).
                WithMany().
                Map(mc =>
                {
                    mc.MapLeftKey("FactorId");
                    mc.MapRightKey("ValorId");
                    mc.ToTable("FactorValor");
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error con el siguiente mensaje: " + e.Message);
            }
            

              
        }
    }
}
