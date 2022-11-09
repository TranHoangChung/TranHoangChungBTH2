using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models.Student> Student { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models.Employee> Employee { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models.Person> Person { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGTRANHOANGCHUNGBTH2.Models.Customer> Customer { get; set; } = default!;
    }