using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRANHOANGCHUNGBTH2.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TRANHOANGCHUNGBTH2.Models.Student> Student { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGBTH2.Models.Employee> Employee { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGBTH2.Models.Person> Person { get; set; } = default!;

        public DbSet<TRANHOANGCHUNGBTH2.Models.Customer> Customer { get; set; } = default!;
    }