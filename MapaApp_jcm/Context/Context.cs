using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MapaApp_jcm.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<locales> locales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<locales>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<locales>()
                .Property(e => e.departamento)
                .IsUnicode(false);

            modelBuilder.Entity<locales>()
                .Property(e => e.latitud)
                .IsUnicode(false);

            modelBuilder.Entity<locales>()
                .Property(e => e.longitud)
                .IsUnicode(false);
        }
    }
}
