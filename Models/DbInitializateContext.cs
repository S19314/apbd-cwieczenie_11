using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cwieczenie11.Models
{
    public class DbInitializateContext : DbContext
    {
        public DbInitializateContext() 
        { }

        public DbInitializateContext(DbContextOptions<DbInitializateContext> options) 
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            ICollection<Doctor> doctors = new List<Doctor>();
            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Vladimir",
                LastName = "Vladimir",
                Email = "gjfgre@po@ua"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Vladimir_22",
                LastName = "Kola",
                Email = "gjfg22e@po@ua"
            });
            doctors.Add(new Doctor
            {
                IdDoctor = 3,
                FirstName = "Pola",
                LastName = "Iowumir",
                Email = "gjfgre@po@ua"
            });

            
            modelBuilder.Entity<Doctor>()   
                        .HasData(doctors);

            ICollection<Patient> patients = new List<Patient>();
            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Oini",
                LastName = "Sise",
                BirthDate = new DateTime(2020, 02, 23)
            });

            patients.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Oioweni",
                LastName = "Siswqee",
                BirthDate = new DateTime(1999, 02, 10)
            });
            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Oini",
                LastName = "Sise",
                BirthDate = new DateTime(1850, 10, 13)
            });

            modelBuilder.Entity<Patient>()
                        .HasData(patients);

            ICollection<Prescription> prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription
            {
                IdPrescription =  1, 
                IdDoctor = 1,
                Date = new DateTime(2000, 02, 02),
                DueDate = new DateTime(2033, 02, 02),
                IdPatient = 1
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 2,
                IdDoctor = 2,
                Date = new DateTime(2010, 02, 02),
                DueDate = new DateTime(2003, 02, 02),
                IdPatient = 2
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 3,
                IdDoctor = 3,
                Date = new DateTime(2011, 02, 05),
                DueDate = new DateTime(2033, 02, 05),
                IdPatient = 3
            });

            modelBuilder.Entity<Prescription>()
                        .HasData(prescriptions);

            ICollection<Medicament> medicaments = new List<Medicament>();
            medicaments.Add(new Medicament
            {
                IdMedicament = 1,
                Name = "Ibuprofen",
                Description = "Nie prinimat",
                Type = "LOX"                
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "Nurofen",
                Description = "prinimat",
                Type = "XYZ"
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 3,
                Name = "Poujn",
                Description = "Pit",
                Type = "Kut"
            });
            modelBuilder.Entity<Medicament>()
                        .HasData(medicaments);

            ICollection<Prescription_Medicament> prescription_Medicaments = new List<Prescription_Medicament>();
            prescription_Medicaments.Add(new Prescription_Medicament
            {
                IdMedicament = 1,
                IdPrescription = 1,
                Dose = 10,
                Details = "Ujnhjhj"
            });

            prescription_Medicaments.Add(new Prescription_Medicament
            {
                IdMedicament = 2,
                IdPrescription = 2,
                Dose = 40,
                Details = "opl"
            });

            prescription_Medicaments.Add(new Prescription_Medicament
            {
                IdMedicament = 3,
                IdPrescription = 3,
                Dose = 110,
                Details = "Tewrw"
            });
            modelBuilder.Entity<Medicament>()
                        .HasData(prescription_Medicaments);



        }
    }
}
