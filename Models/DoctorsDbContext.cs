using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwieczenie11.Models
{
    public class DoctorsDbContext : DbContext 
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DoctorsDbContext() 
        { }

        public DoctorsDbContext(DbContextOptions options)
        : base (options)
        {
        
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>((builder) =>
            {
                builder.HasKey(e => e.IdDoctor); // Определяет это поле как уникальное
                builder.Property(e => e.IdDoctor).ValueGeneratedOnAdd(); // Автоматическое генерация нового уникального значения в поле IdDoctor при вставлении нового элемента


            }
            );
            
        }


    }
}
