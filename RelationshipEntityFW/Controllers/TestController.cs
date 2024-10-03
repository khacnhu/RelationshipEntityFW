using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelationshipEntityFW.DTOs;
using RelationshipEntityFW.Models;
using RelationshipEntityFW.Repo;

namespace RelationshipEntityFW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly Repository repository;

        public TestController(Repository repository) 
        {
            this.repository = repository;
        }

        //MANY TO MANY


        //[HttpPost("student")]
        //public async Task<IActionResult> AddStudent(Student student)
        //{
        //    await repository.AddStudent(student);
        //    return Ok("Student ADD SUCCESSFULLY");
        //}

        //[HttpPost("subject")]
        //public async Task<IActionResult> AddSubject(Subject subject)
        //{
        //    await repository.AddSubject(subject);
        //    return Ok("Subject ADD SUCCESSFULLY");
        //}

        //[HttpGet("students")]
        //public async Task<IActionResult> GetStudents()
        //{
        //    return Ok(await repository.GetStudents());
        //}

        //[HttpGet("subjects")]
        //public async Task<IActionResult> GetSubjects()
        //{
        //    return Ok(await repository.GetSubjects());
        //}






        //// ONE TO MANY
        //[HttpPost("doctor")]
        //public async Task<IActionResult> AddCarCompany(Doctor doctor)
        //{
        //    await repository.AddDoctor(doctor);
        //    return Ok("Doctor Add Successfully Saved");
        //}

        //[HttpPost("patient")]
        //public async Task<IActionResult> AddPatient(Patient patient)
        //{
        //    await repository.AddPatient(patient);
        //    return Ok("Doctor Add Successfully Saved");
        //}

        //[HttpGet("doctors")]
        //public async Task<IActionResult> GetDoctors()
        //{
        //    return Ok(await repository.GetDoctors());
        //}

        //[HttpGet("patients")]
        //public async Task<IActionResult> GetPatients()
        //{
        //    return Ok(await repository.GetPatients());
        //}






        //// ONE TO ONE
        //[HttpPost("company")]
        //public async Task<IActionResult> AddCarCompany([FromBody]CarCompanyDTO carCompanyDTO)
        //{
        //    await repository.AddCarCompany(carCompanyDTO);
        //    return Ok("Company Saved");
        //}

        //[HttpPost("model")]
        //public async Task<IActionResult> AddCarModel(CarModel carModel)
        //{
        //    await repository.AddCarModel(carModel);
        //    return Ok("Car Model Save");
        //}

        //[HttpGet("company")]
        //public async Task<IActionResult> GetCarCompanies()
        //{
        //    return Ok(await repository.GetCarCompanies());
        //}

        //[HttpGet("car")]
        //public async Task<IActionResult> GetCarModel()
        //{
        //    return Ok(await repository.GetCarModel());
        //}



    }
}
