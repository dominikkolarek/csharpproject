using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ZooApp
{
    public partial class ZooDB : DbContext
    {
        public ZooDB()
            : base("name=ZooDB")
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Zoo> Zoos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(e => e.Species)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Zoo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Zoo>()
                .Property(e => e.Location)
                .IsUnicode(false);
        }
    }
}
