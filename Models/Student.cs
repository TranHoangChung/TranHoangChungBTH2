using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TranHoangChungBTH2.Models
{
    public class Student
    {
        public string? StudentID { get; set; } = default!;
        public string? StudentName { get; set; } = default!;
        public string? FacultyID {get; set;}
        [ForeignKey("FacultyID")]
        public Faculty Faculty {get; set;} = default!;

    }
}