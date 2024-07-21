using Sample.Database;
using Sample.Repositories;

namespace Sample.Services
{
    public class StudentService : IStudentServices
    {
        private IStudentRepos _studentrepos;

        public StudentService(IStudentRepos studentrepos)
        {
            _studentrepos = studentrepos;
        }

        public async Task<Student> addStudent(Student student)
        {
            if (student.age > 0)
            {
                var data = await _studentrepos.addStudent(student);
                return data;
            }
            else
            {
                throw new Exception("Age should not be a negative number");
            }

        }
    }
}
