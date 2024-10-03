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
    


        // CONFIG RELATIONSHIP WITH FLUENT API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ONE TO ONE
            modelBuilder.Entity<CarCompany>()
                .HasOne(a => a.CarModel)
                .WithOne(c => c.CarCompany)
                .HasForeignKey<CarModel>(k => k.CarCompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Doctor>()
                .HasMany(d => d.Patients)
                .WithOne(p => p.Doctor)
                .HasForeignKey(k => k.DoctorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<StudentSubject>(entity =>
            {


                entity.HasKey(ss => new { ss.StudentId, ss.SubjectId });
                entity.HasOne(s => s.Student)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.StudentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(s => s.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.SubjectId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            }
            );
                


        }


    }
}
