using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }


        

        public DbSet<DemoMVC.Models.Student> Student { get; set; }

        public DbSet<DemoMVC.Models.Employee> Employee { get; set; }

        public DbSet<DemoMVC.Models.Car> Car { get; set; }
        public DbSet<DemoMVC.Models.Car> SuperCar { get; set; }

        public DbSet<DemoMVC.Models.Khoa> Khoa { get; set; }
        public DbSet<DemoMVC.Models.ChuyenNganh> ChuyenNganh { get; set; }
        public DbSet<DemoMVC.Models.Movie> Movie { get; set; }


     
      
    

      


      

       
    }
}
