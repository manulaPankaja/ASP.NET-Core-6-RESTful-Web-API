using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using StudentApplication.DTOs.Requests;
using StudentApplication.DTOs.Responces;
using StudentApplication.Services.StudentService;

namespace StudentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        //constructor
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        //endpoints
        [HttpPost("save")]
        public BaseResponse CreateStudent(CreateStudentRequest request)
        {
            return studentService.CreateStudent(request);
        }

        [HttpGet("list")]
        public BaseResponse StudentList()
        {
            return studentService.StudentList();
        }

        [HttpGet("{id}")]
        public BaseResponse GetStudentById(long id)
        {
            return studentService.GetStudentById(id);
        }

        [HttpPut("{id}")]
        public BaseResponse UpdateStudentById(long id, UpdateStudentRequset requset)
        {
            return studentService.UpdateStudentById(id, requset);
        }

        [HttpDelete("{id}")]
        public BaseResponse DeleteStudentById(long id)
        {
            return studentService.DeleteStudentById(id);
        }
    }
}
