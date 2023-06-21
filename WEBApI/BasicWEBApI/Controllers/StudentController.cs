using BasicWEBApI.Model;
using BasicWEBApI.Repository.Students;
using Microsoft.AspNetCore.Mvc;

namespace BasicWEBApI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        public string GetStudent()
        {
            return "hellow my First  Api start";
        }

        [HttpGet("/api/GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {

            return StudentRepository.Students;
        }

        [HttpGet("{id:int}")]
        public Student GetStudentById(int id)
        {
            return StudentRepository.Students.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
