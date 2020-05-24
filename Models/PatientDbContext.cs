using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cwieczenie11.Models
{
    public class PatientDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public PatientDbContext() 
        { }

        public PatientDbContext(DbContextOptions<PatientDbContext> options) 
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

/*            modelBuilder.Entity<Patient>((builder) =>
            {
        // /*
                builder.HasKey(e => e.IdPatient);
                builder.Property(e => e.FirstName)
                        .HasMaxLength(100);
                builder.Property(e => e.LastName)
                        .HasMaxLength(100);
    
    
                builder.HasMany(a => a.Prescriptions)
                        .WithOne(a => a.Patient)
                        .HasForeignKey(a => a.IdPatient)
                        .IsRequired();
    
            });
  */          
        }
    }
}
