using System.ComponentModel.DataAnnotations;
namespace TRANHOANGCHUNGBTH2.Models
{
    public class Person
    {
        [Key]
        public string? PersonName  { get; set; }
        public string? PersonID  { get; set; }

        public string? PersonAge  { get; set; }
        public string? PersonAdd  { get; set; }
    }
}