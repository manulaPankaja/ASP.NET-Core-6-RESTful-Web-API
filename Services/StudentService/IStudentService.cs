using StudentApplication.DTOs.Requests;
using StudentApplication.DTOs.Responces;

namespace StudentApplication.Services.StudentService
{
    public interface IStudentService
    {
        BaseResponse CreateStudent(CreateStudentRequest request);
        BaseResponse StudentList();

        BaseResponse GetStudentById(long id);

        BaseResponse UpdateStudentById(long id, UpdateStudentRequset request);

        BaseResponse DeleteStudentById(long id);
    }
}
