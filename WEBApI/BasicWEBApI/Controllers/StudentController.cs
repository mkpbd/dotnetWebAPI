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

        //[HttpGet("/api/GetAllStudents")]

       
        [HttpGet("GetAllStudents")]
       // [Route("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {

            return StudentRepository.Students;
        }

        [HttpGet("{id:int}", Name ="GetStudentById")]
      //  [HttpGet]
      //  [Route("{id:int}",Name ="GetStudentById")]
        public Student GetStudentById(int id)
        {
            return StudentRepository.Students.Where(x => x.Id == id).FirstOrDefault();
        }

      //  [HttpDelete]
        [HttpDelete("{id:int}", Name = "DeleteStudentById")]
       // [Route("{id:int}", Name = "DeleteStudentById")]
        public bool DeleteStudentById(int id)
        {
            return StudentRepository.Students.Where(x=> x.Id == id).FirstOrDefault() != null;
        }
    }
}
