using Sample.Database;

namespace Sample.Repositories
{
    public interface IStudentRepos
    {
        public Task<Student> addStudent(Student student);
    }
}
