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
