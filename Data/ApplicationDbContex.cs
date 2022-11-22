using TranHoangChungBTH2.Models;
using Microsoft.EntityFrameworkCore;

namespace TranHoangChungBTH2.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex (DbContextOptions<ApplicationDbContex>options) : base(options)

        {

        }
        public DbSet<Student>Student {get; set;} = default!;
        public DbSet<Employee>Employee {get; set;} = default!;
        public DbSet<Faculty>Faculty {get; set;} = default!;
    }
}