# open visual studio and select  web API  with controller

### create a project   my project BasiceWebAPI

### Create a controller   with  api

    1. Setup routes    [Route("api/[Controller]") ]
    2. setup Controller [ApiController]

Create Student Controller
Http Get method Calls

```Csharp
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
    }
}

```

**HTTP Method Get, Post, put, delete, patch**

```csharp
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
```

We can use [Route()]  Attribute

```csharp
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

        //[Route("All")]
        [HttpGet]
        [Route("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {

            return StudentRepository.Students;
        }

        //[HttpGet("{id:int}", Name ="GetStudentById")]
        [HttpGet]
        [Route("{id:int}",Name ="GetStudentById")]
        public Student GetStudentById(int id)
        {
            return StudentRepository.Students.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpDelete]
        //[HttpDelete("{id:int}", Name = "DeleteStudentById")]
        [Route("{id:int}", Name = "DeleteStudentById")]
        public bool DeleteStudentById(int id)
        {
            return StudentRepository.Students.Where(x=> x.Id == id).FirstOrDefault() != null;
        }
    }
}

```

Or We can also use [Http()] for routing or

```csharp
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
        //[Route("{id:int}",Name ="GetStudentById")]
        public Student GetStudentById(int id)
        {
            return StudentRepository.Students.Where(x => x.Id == id).FirstOrDefault();
        }

   
        [HttpDelete("{id:int}", Name = "DeleteStudentById")]
       // [Route("{id:int}", Name = "DeleteStudentById")]
        public bool DeleteStudentById(int id)
        {
            return StudentRepository.Students.Where(x=> x.Id == id).FirstOrDefault() != null;
        }
    }
}

```

| HTTP Verbs | Actions (Methods) | URL                                                                                              |
| ---------- | ----------------- | ------------------------------------------------------------------------------------------------ |
| HttpGet    | Student           | [https://localhost:7126/api/Student](https://localhost:7126/api/Student)                            |
| HttpGet    | StudentById       | [https://localhost:7126/api/StudentById/1](https://localhost:7126/api/StudentById/1)                |
| HttpDelete | StudentDeleteById | [https://localhost:7126/api/StudentDeleteById/](https://localhost:7126/api/StudentDeleteById/2){id} |
|            |                   |                                                                                                  |
