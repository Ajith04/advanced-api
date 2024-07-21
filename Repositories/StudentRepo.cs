using Sample.Database;

namespace Sample.Repositories
{
    public class StudentRepo : IStudentRepos
    {
        private SchoolDbContext _schooldbcontext;

        public StudentRepo(SchoolDbContext schooldbcontext)
        {
            _schooldbcontext = schooldbcontext;
        }

        public async Task<Student> addStudent(Student student)
        {
            await _schooldbcontext.Students.AddAsync(student);
            await _schooldbcontext.SaveChangesAsync();
            return student;
        }
    }
}
