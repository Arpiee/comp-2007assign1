namespace Assignment_1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<chopper> choppers { get; set; }
        public virtual DbSet<plane> planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chopper>()
                .Property(e => e.Helicopters)
                .IsUnicode(false);

            modelBuilder.Entity<chopper>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<plane>()
                .Property(e => e.Fighter_Planes)
                .IsUnicode(false);

            modelBuilder.Entity<plane>()
                .Property(e => e.Company)
                .IsUnicode(false);
        }
    }
}
