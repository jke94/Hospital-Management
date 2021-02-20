using DataModel.Models;
using Microsoft.EntityFrameworkCore;
namespace DataModel.Context
{
    public class HospitalDataContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hospital");
        }
    }
}
