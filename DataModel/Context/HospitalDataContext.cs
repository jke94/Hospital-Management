using DataModel.Models;
using DataModel.DataSeeding;
using Microsoft.EntityFrameworkCore;
namespace DataModel.Context
{
    public class HospitalDataContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        
        public DbSet<Patient> Patients { get; set; }

        public DbSet<MedicalTreatment> MedicalTreatments { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hospital");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(DoctorDataSeeded.GenerateRandomDoctors());

            modelBuilder.Entity<Patient>().HasData(PatientDataSeeded.GenerateRandomPatients());

            modelBuilder.Entity<MedicalTreatment>().HasData(MedicalTreatmentDataSeeded.GenerateMedicalTreatment());
        }
    }
}