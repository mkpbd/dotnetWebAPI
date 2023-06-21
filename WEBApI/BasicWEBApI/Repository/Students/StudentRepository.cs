using BasicWEBApI.Model;

namespace BasicWEBApI.Repository.Students
{
    public class StudentRepository
    {
        public static List<Student> Students { get;set; } = new List<Student>()
            {
                new Student() {
                    Id = 1,
                    Name = "mostofa ",
                     Address = "gazipur"
                },
                new Student { Id = 2,
                    Name ="jamal",
                    Address ="abc"
                }
            };
    }
}
