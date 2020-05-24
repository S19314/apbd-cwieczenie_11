using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cwieczenie11.Models
{
    public class Prescription_MedicamentsDbContext : DbContext
    {
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }

        public Prescription_MedicamentsDbContext()
        { }

        public Prescription_MedicamentsDbContext(DbContextOptions<Prescription_MedicamentsDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<Prescription_Medicament>((builder) =>
            {
                builder.HasKey(e => e.IdMedicament);
                builder.HasKey(e => e.IdPrescription);
                builder.Property(e => e.Dose)
                       .IsRequired();
                builder.Property(e => e.Details)
                       .HasMaxLength(100);
            }
            );
        */
        }




    }
}
