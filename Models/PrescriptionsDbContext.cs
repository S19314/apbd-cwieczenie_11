using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
namespace Cwieczenie11.Models
{
    public class PrescriptionsDbContext : DbContext
    {
        public DbSet<Prescription> Prescriptions { get; set; }
        public PrescriptionsDbContext()
        { }

        public PrescriptionsDbContext(DbContextOptions<PrescriptionsDbContext> options)
        : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
        /*
            modelBuilder.Entity<Prescription>((builder) =>
            {
                builder.HasKey(e => e.IdPrescription);
                // builder.Property(e => e.IdDoctor);

                builder.HasMany(a => a.Prescription_Medicaments)
                       .WithOne(a => a.Prescription)
                       .HasForeignKey(a => a.IdPrescription)
                       .IsRequired();   
     
    }
            );
            */        
        }

    }
}
