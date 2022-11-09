using System.ComponentModel.DataAnnotations;
namespace TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models
{
    public class Employee
    {
        [Key]
        public string? EmployeeID  { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeAdd { get; set; }
    }
}