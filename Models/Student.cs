using System.ComponentModel.DataAnnotations;

namespace EFMVC_CRUD.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string studentAddress { get; set; }
        public int studentAge { get; set; }

        public Subject Subject { get; set; } 
    }
}
