using Microsoft.EntityFrameworkCore;
using RelationshipEntityFW.Data;
using RelationshipEntityFW.DTOs;
using RelationshipEntityFW.Models;

namespace RelationshipEntityFW.Repo
{
    public class Repository
    {
        private readonly AppDbContext _appDbContext;


        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task AddCarCompany(CarCompanyDTO carCompanyDTO)
        {

            var carcompany = new CarCompany();
            carcompany.Name = carCompanyDTO.Name;

            var carmodel = new CarModel();
            carmodel.Model = carCompanyDTO.ModelName;
            carmodel.CarCompanyId = carcompany.Id;
            carmodel.CarCompany = carcompany;
            _appDbContext.CarModels.Add(carmodel);

            _appDbContext.CarCompanies.Add(carcompany);
            await _appDbContext.SaveChangesAsync();
           
        }

        public async Task<List<CarCompany>> GetCarCompanies() => await _appDbContext.CarCompanies.ToListAsync();
        public async Task<List<CarModel>> GetCarModel() => await _appDbContext.CarModels.ToListAsync();

        public async Task AddCarModel(CarModel carModel)
        {
            _appDbContext.CarModels.Add(carModel);
            await _appDbContext.SaveChangesAsync();

        }


        public async Task AddDoctor(Doctor doctor)
        {
            _appDbContext.Doctors.Add(doctor);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Doctor>> GetDoctors() => await _appDbContext.Doctors.Include(q => q.Patients).ToListAsync();
        public async Task<List<Patient>> GetPatients() => await _appDbContext.Patients.Include(q => q.Doctor).ToListAsync();

        public async Task AddPatient(Patient patient)
        { 
            _appDbContext.Patients.Add(patient);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task AddStudent(Student student)
        {
            _appDbContext.Students.Add(student);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task AddSubject(Subject subject)
        {
            _appDbContext.Subjects.Add(subject);
            await _appDbContext.SaveChangesAsync();
        }


        public async Task<List<Student>> GetStudents() => await _appDbContext.Students.Include(q => q.Subjects).ToListAsync();
        public async Task<List<Subject>> GetSubjects() => await _appDbContext.Subjects.Include(q => q.Students).ToListAsync();




    }
}
