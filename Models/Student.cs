using System.ComponentModel.DataAnnotations;
namespace TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models
{
    public class Student
    {
        [Key]
        public string? StudentID  { get; set; }
        public string? StudentName  { get; set; }
        public string? Address { get; set; }
    }
}