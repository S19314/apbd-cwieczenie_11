using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cwieczenie11.Models
{
    public class MedicamentsDbContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }
        public MedicamentsDbContext()
        {}
        public MedicamentsDbContext(DbContextOptions<MedicamentsDbContext> options) 
        : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Medicament>((builder) =>
            {
                builder.HasKey(e => e.IdMedicament);
                builder.Property(e => e.Name).HasMaxLength(100);
                builder.Property(e => e.Description).HasMaxLength(100);
                builder.Property(e => e.Type).HasMaxLength(100);
                /*
                builder.HasMany(a => a.Prescription_Medicaments)
                        .WithOne(a => a.Medicament)
                        .HasForeignKey(a => a.IdMedicament)
                        .IsRequired();
                */
            }
            );
        
        
        
        }

    }
}
