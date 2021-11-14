using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }


        

        public DbSet<DemoMVC.Models.Student> Student { get; set; }

        public DbSet<DemoMVC.Models.Employee> Employee { get; set; }

        public DbSet<DemoMVC.Models.Person> Person { get; set; }

      

       
    }
