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
|            |                   | <br />                                                                                           |


**HTTP Or Route Constraint Parametter   (list of constraints from)**

| **Constraint** | **Description**                                                              | **Example**              |
| -------------------- | ---------------------------------------------------------------------------------- | ------------------------------ |
| alpha                | Matches uppercase or lowercase Latin alphabet characters (a-z, A-Z)                | {x:alpha}                      |
| bool                 | Matches a Boolean value.                                                           | {x:bool}                       |
| datetime             | Matches a DateTime value.                                                          | {x:datetime}                   |
| decimal              | Matches a decimal value.                                                           | {x:decimal}                    |
| double               | Matches a 64-bit floating-point value.                                             | {x:double}                     |
| float                | Matches a 32-bit floating-point value.                                             | {x:float}                      |
| guid                 | Matches a GUID value.                                                              | {x:guid}                       |
| int                  | Matches a 32-bit integer value.                                                    | {x:int}                        |
| length               | Matches a string with the specified length or within a specified range of lengths. | {x:length(6)} {x:length(1,20)} |
| long                 | Matches a 64-bit integer value.                                                    | {x:long}                       |
| max                  | Matches an integer with a maximum value.                                           | {x:max(10)}                    |
| maxlength            | Matches a string with a maximum length.                                            | {x:maxlength(10)}              |
| min                  | Matches an integer with a minimum value.                                           | {x:min(10)}                    |
| minlength            | Matches a string with a minimum length.                                            | {x:minlength(10)}              |
| range                | Matches an integer within a range of values.                                       | {x:range(10,50)}               |
| regex                | Matches a regular expression.                                                      | {x:regex(^\d{3}-\d{3}-\d{4}$)} |

```csharp
[Route("api/books")]
[HttpPost]
public HttpResponseMessage CreateBook(Book book) { ... }

// WebDAV method
[Route("api/books")]
[AcceptVerbs("MKCOL")]
public void MakeCollection() { }


public class BooksController : ApiController
{
    [Route("api/books")]
    public IEnumerable<Book> GetBooks() { ... }

    [Route("api/books/{id:int}")]
    public Book GetBook(int id) { ... }

    [Route("api/books")]
    [HttpPost]
    public HttpResponseMessage CreateBook(Book book) { ... }
}



```

You can set a common prefix for an entire controller by using the **[RoutePrefix]** attribute:

```csharp
[RoutePrefix("api/books")]
public class BooksController : ApiController
{
    // GET api/books
    [Route("")]
    public IEnumerable<Book> Get() { ... }

    // GET api/books/5
    [Route("{id:int}")]
    public Book Get(int id) { ... }

    // POST api/books
    [Route("")]
    public HttpResponseMessage Post(Book book) { ... }
}
```
