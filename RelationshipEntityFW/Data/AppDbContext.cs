using Microsoft.EntityFrameworkCore;
using RelationshipEntityFW.Models;

namespace RelationshipEntityFW.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        // one to one
        public DbSet<CarCompany> CarCompanies { get; set; }
        public DbSet<CarModel> CarModels { get; set; }



        // one to many
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
    
    

        // many to many
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    
    }
}
