using System.ComponentModel.DataAnnotations;

namespace EFMVC_CRUD.Models
{
    public class Subject
    {
        [Key]
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public string subjectTerm { get; set; }
        public int subjectCredets { get; set; }
        public List<Student> SubjectStudents { get; set; } = new List<Student>();
    }
}
