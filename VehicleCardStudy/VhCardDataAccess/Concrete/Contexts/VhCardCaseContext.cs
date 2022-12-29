using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VhCardEntity.Concrete
{
    public partial class VhCardCaseContext : DbContext
    {
        public VhCardCaseContext()
        {
        }

        public VhCardCaseContext(DbContextOptions<VhCardCaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<VehiclesType> VehiclesTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=VhCardCase;User ID=sa;Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.Plate).HasMaxLength(20);
            });

            modelBuilder.Entity<VehiclesType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK_Types");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CapacityKg).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapacityM3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
