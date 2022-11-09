using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRANHOANGCHUNGBTH2.Models;

namespace TRANHOANGCHUNGBTH2.Data
{
    public class TRANHOANGCHUNGBTH2Context : DbContext
    {
        public TRANHOANGCHUNGBTH2Context (DbContextOptions<TRANHOANGCHUNGBTH2Context> options)
            : base(options)
        {
        }

        public DbSet<TRANHOANGCHUNGBTH2.Models.Student> Student { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGBTH2.Models.Employee> Employee { get; set; }

        public DbSet<TRANHOANGCHUNGBTH2.Models.Person> Person { get; set; }

        public DbSet<TRANHOANGCHUNGBTH2.Models.Customer> Customer { get; set; }
    }
}
