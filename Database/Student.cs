using System.ComponentModel.DataAnnotations;

namespace Sample.Database
{
    public class Student
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
    }
}
