using System.ComponentModel.DataAnnotations;
namespace TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models
{
    public class Customer
    {
        [Key]
        public string? CustomerID { get; set; }
        public string? CustomerName  { get; set; }
        public string? CustomerAdd  { get; set; }
    }
}