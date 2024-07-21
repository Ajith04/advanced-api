using Sample.Database;

namespace Sample.Services
{
    public interface IStudentServices
    {
        public Task<Student> addStudent(Student student);
    }
}
