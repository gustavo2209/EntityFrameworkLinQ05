using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkLinQ05
{
    public partial class ModelCV : DbContext
    {
        public ModelCV()
            : base("name=ModelCV")
        {
        }

        public virtual DbSet<movimientos> movimientos { get; set; }
        public virtual DbSet<productos> productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<productos>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<productos>()
                .Property(e => e.precioCompra)
                .HasPrecision(12, 2);

            modelBuilder.Entity<productos>()
                .Property(e => e.precioVenta)
                .HasPrecision(12, 2);
        }
    }
}
